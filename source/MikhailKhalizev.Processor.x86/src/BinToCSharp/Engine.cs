using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using MikhailKhalizev.Max;
using MikhailKhalizev.Processor.x86.Abstractions;
using MikhailKhalizev.Processor.x86.Abstractions.Memory;
using MikhailKhalizev.Processor.x86.BinToCSharp.Plugin;
using MikhailKhalizev.Processor.x86.Utils;
using SharpDisasm;
using SharpDisasm.Udis86;

namespace MikhailKhalizev.Processor.x86.BinToCSharp
{
    /// <summary>
    /// Алгоритм декодирует код по частям. Каждую часть декодируется последовательно
    /// до тех пор пока не встретится потенциальный конец функции (ret или jmp). После
    /// чего декодирование части заканчивается и начинается декодирование других частей,
    /// выявленных по операциям ветвления (jcc, jmp, loop, call).
    /// 
    /// Алгоритм устроен так, что без необходимости, ничего лишнего он не декодирует.
    ///
    /// (Возможно описание устарело) 
    /// </summary>
    public class Engine
    {
        public ArchitectureMode Mode { get; }
        public Address CsBase { get; }
        public Address DsBase { get; }
        public IMemory Memory { get; }

        public event EventHandler<Instruction> InstructionDecoded;

        /// <summary>
        /// Список адресов на которых происходит принудительное завершение декодирования.
        /// Это требуется при декодировании 'странного' кода. Например когда в функции,
        /// вызванной call происходит возврат не на один уровень вверх, а на два. В результате
        /// требуется принудительно остановить декодирование после данного call.
        /// </summary>
        /// <remarks>
        /// Если <see cref="ForceEndFuncs"/> делит инструкцию пополам,
        /// то эта инструкция относится к методу, расположенному с меньшим адресом.
        /// </remarks>
        private SortedSet<Address> force_end_funcs_ { get; } = new SortedSet<Address>();

        public void AddForceEndFuncs(Address address)
        {
            force_end_funcs_.Add(address);
        }


        private MultiValueDictionary<Address, FunctionModel> already_decoded_funcs_ { get; } = new MultiValueDictionary<Address, FunctionModel>();

        public void AddAlreadyDecodedFunc(FunctionModel model)
        {
            foreach (var address in model.Addresses)
                already_decoded_funcs_.Add(address, model);
        }

        public void RemoveAlreadyDecodedFunc(Address address)
        {
            already_decoded_funcs_.Remove(address);
        }

        public bool already_decoded_funcs_check(Address address)
        {
            if (!already_decoded_funcs_.TryGetValue(address, out var models))
                return false;

            foreach (var model in models)
            {
                if (Memory.mem_pg_equals(address, model.GetRawBytes()))
                    return true;
            }

            return false;
        }


        public UsedSpace<Address> SuppressDecode { get; } = new UsedSpace<Address>();

        //private HashSet<Instruction> AllDecodedInstruction

        /// <summary>
        /// Содержит информацию об определённых методах.
        /// </summary>
        private HashSet<DetectedMethod> NewDetectedMethods = new HashSet<DetectedMethod>(DetectedMethod.BeginEqualityComparer);
        
        /// <summary>
        /// Набор адресов начиная с которых необходимо произвести декодирование.
        /// </summary>
        private HashSet<Address> AddressesToDecode = new HashSet<Address>();

        private Dictionary<Address, ArchitectureMode> Aligment = new Dictionary<Address, ArchitectureMode>(); // <addr of start, aligment>

        // std::map<addr_type, jtka> jmp_to_known_addr; /* <cmd_addr_start, ... */
        private DecodedCode code = new DecodedCode();
        // addr_type pc_used_in_input_hook;

        private const int LineCmdOffset = 22;
        private const int LineCommentOffset = 60;

        // TODO plugin::jmp_call_loop_simple plugin_jmp_call_loop_simple; - addr_to_decode from any jmp.
        // TODO plugin::switch_ plugin_switch; - decode switch.
        private readonly AddCStringToCommentPlugin _addCStringToCommentPlugin;
        // TODO plugin::comment_idle plugin_comment_idle; - comment dummy instruction


        public Engine(ArchitectureMode mode, Address csBase, Address dsBase, IMemory memory)
        {
            Mode = mode;
            CsBase = csBase;
            DsBase = dsBase;
            Memory = memory;

            if (csBase != 0)
                SuppressDecode.Add(0, csBase);

            _addCStringToCommentPlugin = new AddCStringToCommentPlugin(this);
        }

        public void DecodeMethod(Address address)
        {
            if (NewDetectedMethods.Add(new DetectedMethod(address)))
                Decode(address);
        }

        private void Decode(Address address)
        {
            AddressesToDecode.Add(address);
            Process();
        }

        private void Process()
        {
            while (AddressesToDecode.Count != 0)
            {
                var address = AddressesToDecode.First();
                AddressesToDecode.Remove(address);
                Process(address);
            }
        }


        private class AssemblyCode : IAssemblyCode
        {
            public Engine Engine { get; }
            public Disassembler Disassembler { get; set; }

            public AssemblyCode(Engine engine)
            {
                Engine = engine;
            }

            /// <inheritdoc />
            public byte this[int index]
            {
                get
                {
                    // @todo Проверять suppress_decode.
                    try
                    {
                        if (index < Engine.CsBase)
                            throw new InvalidOperationException();

                        if (Engine.Mode == ArchitectureMode.x86_16 && 0xffff < index - Engine.CsBase)
                            throw new NotImplementedException();

                        return Engine.Memory.GetMinSize(index, 1)[0];
                    }
                    catch (Exception)
                    {
                        Disassembler._u.inp_end = 1;
                        Disassembler._u.error = 1;
                        Disassembler._u.errorMessage = "byte expected, eoi received";
                        return 0;
                    }
                }
            }

            /// <inheritdoc />
            public int Length => int.MaxValue;
        }

        private void Process(Address address)
        {
            if (code.Contains(address))
                return; // Код включающий этот адрес уже декодирован.

            if (address < CsBase)
                return;

            var lowerBound = SuppressDecode.LowerBound(address, false);
            var nearestSuppressDecode = lowerBound.IsEmpty ? Address.MaxValue : lowerBound.Begin;
            
            if (nearestSuppressDecode <= address)
                return;


            // Decode.

            Memory.GetMinSize(address, 1); // Попробуем прочитать хоть один байт - вдруг чтение недоступно.

            var ac = new AssemblyCode(this);
            var dis = new Disassembler(ac, Mode, address, true, Vendor.Intel);
            ac.Disassembler = dis;
            dis._u.inp_buf_index = address;


            
            // Функция, начинающаяся с точного совпадения force_end_funcs_ может начать декодироваться.
            var nearestForceEnd = force_end_funcs_.GetViewBetween(address, Address.MaxValue)
                .Where(x => x != address)
                .DefaultIfEmpty(Address.MaxValue)
                .First();


            while (true)
            {
                var eip = dis._u.pc;
                if (nearestForceEnd <= eip || nearestSuppressDecode <= eip)
                    break;

                if (already_decoded_funcs_check(eip))
                    break; // Нашли среди декодированных.


                var rawInstruction = dis.NextInstruction();
                if (rawInstruction == null)
                    throw new InvalidOperationException("Преждевременное завершение функции из-за нехватки кода.");

                var cmd = new Instruction(rawInstruction);

                // Бывают случаи, когда ud_obj незнаком с инструкцией, хотя в документации x86 она есть.
                //        if (cmd.mnemonic == UD_Iinvalid)
                //            throw exo::exception::not_implemented();

                code.Insert(cmd);
                InstructionDecoded?.Invoke(this, cmd);

                if (cmd._is_jmp_or_ret)
                    break; // Потенциальный конец функции.
                
                if (code.Contains(cmd.End))
                    break; // Следующая часть кода уже декодирована.
            }
        }

        public void SetCStringDataArea(Address begin, Address end)
        {
            _addCStringToCommentPlugin.StringDataAreaBegin = begin;
            _addCStringToCommentPlugin.StringDataAreaEnd = end;
        }
    }
}