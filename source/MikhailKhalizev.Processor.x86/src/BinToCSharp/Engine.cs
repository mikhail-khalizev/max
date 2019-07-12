using System;
using System.Collections.Generic;
using System.Linq;
using MikhailKhalizev.Max;
using MikhailKhalizev.Processor.x86.Abstractions;
using MikhailKhalizev.Processor.x86.Abstractions.Memory;
using MikhailKhalizev.Processor.x86.BinToCSharp.Plugin;
using SharpDisasm;

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
        public IMemoryReadAccess Memory { get; }

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
        public HashSet<Address> ForceEndFuncs { get; } = new HashSet<Address>();
        public MultiValueDictionary<Address, FunctionModel> AlreadyDecodedFuncs { get; } = new MultiValueDictionary<Address, FunctionModel>();

        // [begin, end)
        public List<(Address, Address)> SuppressDecode { get; } = new List<(Address, Address)>();

        //private HashSet<Instruction> AllDecodedInstruction
        private HashSet<DetectedMethod> NewDetectedMethods = new HashSet<DetectedMethod>(DetectedMethod.BeginEqualityComparer);
        private HashSet<Address> AddressesToDecode = new HashSet<Address>();
        private Dictionary<Address, ArchitectureMode> Aligment = new Dictionary<Address, ArchitectureMode>(); // <addr of start, aligment>

        // std::map<addr_type, jtka> jmp_to_known_addr; /* <cmd_addr_start, ... */
        // decoded_code code;        
        // addr_type pc_used_in_input_hook;

        private const int LineCmdOffset = 22;
        private const int LineCommentOffset = 60;

        // TODO plugin::jmp_call_loop_simple plugin_jmp_call_loop_simple; - addr_to_decode from any jmp.
        // TODO plugin::switch_ plugin_switch; - decode switch.
        private readonly AddCStringToCommentPlugin _addCStringToCommentPlugin;
        // TODO plugin::comment_idle plugin_comment_idle; - comment dummy instruction


        public Engine(ArchitectureMode mode, Address csBase, Address dsBase, IMemoryReadAccess memory)
        {
            Mode = mode;
            CsBase = csBase;
            DsBase = dsBase;
            Memory = memory;

            if (csBase != 0)
                SuppressDecode.Add((0, csBase));

            _addCStringToCommentPlugin = new AddCStringToCommentPlugin(this);
        }

        public void Decode(Address address)
        {
            AddressesToDecode.Add(address);
            Process();
        }

        public void DecodeMethod(Address address)
        {
            if (NewDetectedMethods.Add(new DetectedMethod(address)))
                Decode(address);
        }

        private void Process()
        {
            while (AddressesToDecode.Count != 0)
            {
                var addr = AddressesToDecode.First();
                AddressesToDecode.Remove(addr);
                Process(addr);
            }
        }

        private void Process(Address address)
        {
            //if (code.contains(address))
            //    return; // Код включающий этот адрес уже декодирован.

            if (address < CsBase)
                return;

            var nearestSuppressDecode = SuppressDecode
                .Where(x => address < x.Item2 || x.Item2 == 0)
                .Select(x => x.Item1)
                .DefaultIfEmpty(Address.MaxValue)
                .Min();

            if (nearestSuppressDecode <= address)
                return;

            Memory.GetFixSize(address, 1); // Попробуем прочитать хоть один байт - вдруг чтение недоступно.

            var disassembler = Instruction.CreateDisassembler(Mode, address, Memory);
            var nearestForceEnd = ForceEndFuncs.OrderBy(x => x).FirstOrDefault(x => address < x); // Специально '<', чтобы функция, начинающаяся с точного совпадения с ForceEndFuncs смогла начать декодироваться.

            for (;;)
            {
                if (nearestForceEnd <= disassembler.Address ||
                        nearestSuppressDecode <= disassembler.Address ||
                        AlreadyDecodedFuncs.ContainsKey(disassembler.Address))
                    break;

                var rawInstr = disassembler.NextInstruction();
                if (rawInstr == null)
                    throw new InvalidOperationException("Преждевременное завершение функции из-за нехватки кода.");
                var instr = new Instruction(rawInstr);


            }
        }

        public void set_string_data_area(Address begin, Address end)
        {
            _addCStringToCommentPlugin.StringDataAreaBegin = begin;
            _addCStringToCommentPlugin.StringDataAreaEnd = end;
        }
    }
}