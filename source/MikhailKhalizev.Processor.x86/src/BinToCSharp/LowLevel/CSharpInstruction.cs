using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MikhailKhalizev.Processor.x86.CSharpExecutor.Abstractions.Memory;
using MikhailKhalizev.Processor.x86.Decoder;
using MikhailKhalizev.Processor.x86.Utils;
using SharpDisasm;
using SharpDisasm.Udis86;

namespace MikhailKhalizev.Processor.x86.BinToCSharp.LowLevel
{
    public class CSharpInstruction
    {
        public DefinitionCollection DefinitionCollection { get; }
        public Address Begin { get; set; }
        public Address End { get; set; }

        /// <summary>
        /// Закомментировать всю напечатанную строку.
        /// </summary>
        public bool CommentThis { get; set; }

        /// <summary>
        /// Комментарии к инструкции.
        /// </summary>
        public List<string> Comments { get; set; }

        public int Mode { get; set; }
        public int AddrMode { get; set; }
        public int OprMode { get; set; }

        public ud_mnemonic_code Mnemonic { get; set; }
        public List<ud_operand> Operands { get; set; }

        public ud_type PfxSeg { get; set; }
        public bool PfxAddress { get; set; }
        public bool PfxOpr { get; set; }

        public bool HaveAnyRep => PfxRep || PfxRepe || PfxRepne;
        public bool PfxRep { get; set; }
        public bool PfxRepe { get; set; }
        public bool PfxRepne { get; set; }

        public bool BrFar { get; set; }

        public bool IsCall { get; set; }
        public bool IsCallUp { get; set; }
        public bool IsLoopOrLoopcc { get; set; }
        public bool IsRet { get; set; }
        public bool IsJmp { get; set; }
        public bool IsJmpOrRet => IsJmp || IsRet;
        public bool IsJmpOrJcc { get; set; }
        public bool IsLocalBranch { get; set; }

        public delegate string WriteCmdDelegate(Engine engine, DetectedMethod dm, int cmdIndex, List<string> commentsInCurrentFunc);

        public WriteCmdDelegate WriteCmd { get; set; }

        public CSharpInstruction(Address address)
        {
            Begin = address;
            End = address;
        }

        public CSharpInstruction(Address begin, Address end, string comment = null)
        {
            Begin = begin;
            End = end;
            CommentThis = true;
            if (comment != null)
                Comments = new List<string> { comment };
        }

        public CSharpInstruction(DefinitionCollection definitionCollection, ud ud)
        {
            if (ud == null)
                throw new ArgumentNullException(nameof(ud));
            DefinitionCollection = definitionCollection;

            WriteCmd = (e, dm, index, func) =>
            {
                var isLast = dm.Instructions.Count <= index + 1;
                return ToCodeString(onlyRawCmd: isLast);
            };

            Comments = new List<string>();

            Begin = ud.insn_offset;
            End = ud.pc;

            Mnemonic = ud.mnemonic;

            BrFar = ud.br_far != 0;
            PfxSeg = (ud_type)ud.pfx_seg;
            PfxRep = ud.pfx_rep != 0;
            PfxRepe = ud.pfx_repe != 0;
            PfxRepne = ud.pfx_repne != 0;
            PfxAddress = ud.pfx_adr != 0;
            PfxOpr = ud.pfx_opr != 0;

            IsJmp = ud.mnemonic == ud_mnemonic_code.UD_Ijmp;
            IsCall = ud.mnemonic == ud_mnemonic_code.UD_Icall;
            IsJmpOrJcc = udis86.ud_lookup_mnemonic(Mnemonic).StartsWith("j");
            IsLoopOrLoopcc = udis86.ud_lookup_mnemonic(Mnemonic).StartsWith("loop");
            IsRet = 0 <= ud.mnemonic.ToString().IndexOf("ret", StringComparison.OrdinalIgnoreCase);

            if (ud.pfx_rex != 0) // unknown ud_obj.pfx_insn ?
                throw new NotImplementedException();

            Operands = ud.operand
                .TakeWhile(x => x.type != ud_type.UD_NONE)
                .ToList();

            if ((IsJmpOrJcc || IsLoopOrLoopcc || IsCall) && Operands[0].type == ud_type.UD_OP_PTR)
                BrFar = true; /* Почему-то cам ud_obj не устанавливает его в 1, хотя это far jump. */

            Mode = ud.dis_mode;
            AddrMode = ud.adr_mode;
            OprMode = ud.opr_mode;

            try
            {
                var str = new string(ud.asm_buf, 0, ud.asm_buf_fill);
                Comments.Add(str);
            }
            catch { }
        }

        public ud_type GetEffectiveSegmentOfOperand(ud_operand op)
        {
            if (PfxSeg != ud_type.UD_NONE)
                return PfxSeg;
            if (new[] { ud_type.UD_R_BP, ud_type.UD_R_SP, ud_type.UD_R_EBP, ud_type.UD_R_ESP }.Contains(op.@base))
                return ud_type.UD_R_SS;
            return ud_type.UD_R_DS;
        }

        /// <inheritdoc />
        public override string ToString()
        {
            return ToCodeString();
        }

        public string ToCodeString(
            string cmdSuffix = "",
            string funcAddArg = "",
            bool onlyRawCmd = false)
        {
            if (IsCallUp)
                cmdSuffix += "_up";

            var addIf = !onlyRawCmd && (IsCallUp || IsJmpOrJcc || IsLoopOrLoopcc) && (Mnemonic != ud_mnemonic_code.UD_Ijmp || !IsLocalBranch);
            var addGotoLabel = !onlyRawCmd && IsLocalBranch && (IsJmpOrJcc || IsLoopOrLoopcc) && Operands[0].type == ud_type.UD_OP_JIMM;
            var addReturn = !onlyRawCmd && !IsLocalBranch && (
                addIf ||
                new[]
                {
                    ud_mnemonic_code.UD_Ijmp,
                    ud_mnemonic_code.UD_Iret,
                    ud_mnemonic_code.UD_Iretf,
                    ud_mnemonic_code.UD_Iiretw,
                    ud_mnemonic_code.UD_Iiretd,
                    ud_mnemonic_code.UD_Iiretq
                }.Contains(Mnemonic)
            );


            var sb = new StringBuilder();

            if (!_knownInstr.TryGetValue(Mnemonic, out var flags))
                flags = InstrFlags.None;

            var effOprSize = OprMode;
            if (Mnemonic == ud_mnemonic_code.UD_Iout)
                if (ud_type.UD_R_AL <= Operands[1].@base && Operands[1].@base <= ud_type.UD_R_BH)
                    effOprSize = 8;

            if (Mnemonic == ud_mnemonic_code.UD_Iin
                || Mnemonic == ud_mnemonic_code.UD_Iimul
                || Mnemonic == ud_mnemonic_code.UD_Imul)
                if (ud_type.UD_R_AL <= Operands[0].@base && Operands[0].@base <= ud_type.UD_R_BH)
                    effOprSize = 8;
            
            var method = udis86.ud_lookup_mnemonic(Mnemonic);


            bool addSizeSuffix;

            if (Mnemonic == ud_mnemonic_code.UD_Ipush || Mnemonic == ud_mnemonic_code.UD_Ipop)
            {
                var op = Operands[0];
                if (Operands[0].type == ud_type.UD_OP_REG)
                    addSizeSuffix = effOprSize != RegisterInfo.GetRegister(op.@base).Size;
                else if (Operands[0].type == ud_type.UD_OP_MEM)
                    addSizeSuffix = effOprSize != (op.size == 0 ? effOprSize : op.size);
                else
                    addSizeSuffix = effOprSize != Mode;
            }
            else if (Mnemonic == ud_mnemonic_code.UD_Iin || Mnemonic == ud_mnemonic_code.UD_Iout)
            {
                addSizeSuffix = true;
            }
            else
            {
                addSizeSuffix = flags.HasFlag(InstrFlags.UseOprSizeInside) && effOprSize != Mode;
            }

            
            var addAdrSuffix = flags.HasFlag(InstrFlags.UseAdrSizeInside) && AddrMode != Mode;
            var adrModeStr = AddrMode != Mode ? $"_a{AddrMode}" : "";


            if (addSizeSuffix)
                method += GetSizeSuffixByBits(effOprSize);
            if (addAdrSuffix)
                method += adrModeStr;
            if (BrFar)
                method += "_far";

            var needWriteNamespace = IsCall;
            if (IsJmpOrJcc || IsLoopOrLoopcc || IsCall)
            {
                if (Operands[0].type == ud_type.UD_OP_PTR)
                {
                    method += "_abs";
                    needWriteNamespace = true;
                }
                else if (Operands[0].type == ud_type.UD_OP_MEM || Operands[0].type == ud_type.UD_OP_REG)
                {
                    method += BrFar ? "_ind" : "_abs";
                    needWriteNamespace = true;
                }
            }
            else
                needWriteNamespace = true;

            var options = new DefinitionCollection.Options { WithNamespace = needWriteNamespace };

            method += cmdSuffix;

            if (new[] { "int", "in", "out" }.Contains(method))
                method = "@" + method;

            
            if (PfxRepne)
                sb.Append($"repne{adrModeStr}(() => ");
            else if (PfxRepe)
                sb.Append($"repe{adrModeStr}(() => ");
            else if (PfxRep)
                sb.Append($"rep{adrModeStr}(() => ");

            if (addIf)
                sb.Append("if(");

            sb.Append(method);
            sb.Append("(");


            var nonFirstArg = false;
            var usePfxSeg = false; // Используется ли где-то в операндах сегмент?

            foreach (var op in Operands)
            {
                if (nonFirstArg)
                    sb.Append(", ");
                nonFirstArg = true;

                var oprSize = op.size == 0 ? effOprSize : op.size;

                int val;
                switch (op.type)
                {
                    case ud_type.UD_NONE:
                        break;

                    case ud_type.UD_OP_REG:
                        if (ud_type.UD_R_ST0 <= op.@base && op.@base <= ud_type.UD_R_ST7)
                            sb.Append($"ST({op.@base - ud_type.UD_R_ST0})");
                        else
                            sb.Append(RegisterInfo.GetRegister(op.@base));
                        break;

                    case ud_type.UD_OP_MEM:
                        {
                            sb.Append("mem");
                            sb.Append(GetSizeSuffixByBits(oprSize));
                            sb.Append(adrModeStr);
                            sb.Append($"[{RegisterInfo.GetRegister(GetEffectiveSegmentOfOperand(op))}, ");

                            if (PfxSeg != ud_type.UD_NONE)
                                usePfxSeg = true;

                            var isNextOperation = false; // Cтоит ли писать '+' (т.е. 'не первое слагаемое').
                            if (op.@base != ud_type.UD_NONE)
                            {
                                sb.Append(syn.ud_reg_tab[op.@base - ud_type.UD_R_AL]);
                                isNextOperation = true;
                            }

                            if (op.index != ud_type.UD_NONE)
                            {
                                if (isNextOperation)
                                    sb.Append(" + ");
                                isNextOperation = true;

                                sb.Append(syn.ud_reg_tab[op.index - ud_type.UD_R_AL]);
                            }

                            if (1 < op.scale)
                            {
                                if (op.index == ud_type.UD_NONE)
                                    throw new NotImplementedException();

                                sb.Append($" * {op.scale}");
                            }

                            if (op.offset != 0)
                            {
                                switch (op.offset)
                                {
                                    case 8:
                                        val = op.lval.@sbyte;
                                        break;
                                    case 16:
                                        val = op.lval.sword;
                                        break;
                                    case 32:
                                        val = op.lval.sdword;
                                        break;
                                    default:
                                        throw new NotImplementedException($"op.offset: {op.offset}");
                                }

                                if (val < 0)
                                {
                                    sb.Append(isNextOperation ? " - " : "-");
                                    sb.Append(HexHelper.ToShortGrouped4Hex(-val));
                                }
                                else
                                {
                                    sb.Append(isNextOperation ? " + " : "");
                                    sb.Append(DefinitionCollection.GetAddressFullName(val, options));
                                }

                                isNextOperation = true;
                            }

                            sb.Append(']');
                            break;
                        }

                    case ud_type.UD_OP_IMM:
                        switch (oprSize)
                        {
                            case 8:
                                {
                                    var needSignExtend = new[]
                                    {
                                        ud_mnemonic_code.UD_Iimul,
                                        ud_mnemonic_code.UD_Ipush,
                                        ud_mnemonic_code.UD_Iadc,
                                        ud_mnemonic_code.UD_Iadd,
                                        ud_mnemonic_code.UD_Isbb,
                                        ud_mnemonic_code.UD_Isub,
                                        ud_mnemonic_code.UD_Icmp
                                    }.Contains(Mnemonic);

                                    // Работа не с 8-байтой инструкцией.
                                    if (!(ud_type.UD_R_AL <= Operands[0].@base && Operands[0].@base <= ud_type.UD_R_BH))
                                        needSignExtend = needSignExtend ||
                                            Mnemonic == ud_mnemonic_code.UD_Iand ||
                                            Mnemonic == ud_mnemonic_code.UD_Ior ||
                                            Mnemonic == ud_mnemonic_code.UD_Ixor;

                                    val = op.lval.@sbyte;

                                    if (val < 0 && needSignExtend)
                                    {
                                        sb.Append($"-{HexHelper.ToShortGrouped4Hex(-val)} /* {HexHelper.ToShortGrouped4Hex(op.lval.ubyte)} */");
                                    }
                                    else
                                    {
                                        sb.Append(HexHelper.ToShortGrouped4Hex(op.lval.ubyte));
                                    }

                                    break;
                                }

                            case 16:
                                sb.Append(DefinitionCollection.GetAddressFullName(op.lval.uword, options));
                                break;
                            case 32:
                                sb.Append(DefinitionCollection.GetAddressFullName(op.lval.udword, options));
                                break;
                            default:
                                throw new NotImplementedException($"oprSize: {oprSize}");
                        }
                        break;

                    case ud_type.UD_OP_JIMM:
                        switch (oprSize)
                        {
                            case 8:
                                val = op.lval.@sbyte;
                                break;
                            case 16:
                                val = op.lval.sword;
                                break;
                            case 32:
                                val = op.lval.sdword;
                                break;
                            default: throw new NotImplementedException($"oprSize: {oprSize}");
                        }

                        sb.Append(DefinitionCollection.GetAddressFullName(End + val, options));
                        sb.Append(", ");

                        sb.Append(
                            val < 0
                                ? $"-{HexHelper.ToShortGrouped4Hex(-val)}"
                                : HexHelper.ToShortGrouped4Hex(val));
                        break;

                    case ud_type.UD_OP_CONST:
                        sb.Append(DefinitionCollection.GetAddressFullName(op.lval.udword, options));
                        break;

                    case ud_type.UD_OP_PTR:
                        sb.Append($"{HexHelper.ToShortGrouped4Hex(op.lval.ptr_seg)}, {HexHelper.ToShortGrouped4Hex(op.lval.ptr_off)}");
                        break;

                    default:
                        throw new NotImplementedException($"op.type: {op.type}");
                }
            }

            if (usePfxSeg == false && PfxSeg != ud_type.UD_NONE
                && Mnemonic != ud_mnemonic_code.UD_Imov
                && Mnemonic != ud_mnemonic_code.UD_Ilea)
            {
                // к примеру movsb_a16(es)

                if (nonFirstArg)
                    sb.Append(", ");
                nonFirstArg = true;

                sb.Append(syn.ud_reg_tab[PfxSeg - ud_type.UD_R_AL]);
            }

            if (funcAddArg.Length != 0)
            {
                if (nonFirstArg)
                    sb.Append(", ");
                nonFirstArg = true;

                sb.Append(funcAddArg);
            }

            if (HaveAnyRep)
                sb.Append(")");
            sb.Append(")");
            sb.Append(addIf ? ")" : ";");

            if (addGotoLabel)
            {
                Address val;
                var op = Operands[0];
                var oprSize = (int)op.size;
                if (oprSize == 0)
                    oprSize = effOprSize;

                switch (oprSize)
                {
                    case 8:
                        val = op.lval.@sbyte;
                        break;
                    case 16:
                        val = op.lval.sword;
                        break;
                    case 32:
                        val = op.lval.sdword;
                        break;
                    default: throw new NotImplementedException($"oprSize: {oprSize}");
                }

                sb.Append($" goto l_{(Address)(End + val)};");
            }
            else if (addReturn)
                sb.Append($" return;");

            return sb.ToString();
        }

        #region Known Instructions

        [Flags]
        private enum InstrFlags
        {
            None = 0,
            UseOprSizeInside = 1,
            UseAdrSizeInside = 2
        }

        private static readonly Dictionary<ud_mnemonic_code, InstrFlags> _knownInstr = new Dictionary<ud_mnemonic_code, InstrFlags>
            {
                {ud_mnemonic_code.UD_Istosb, InstrFlags.UseAdrSizeInside},
                {ud_mnemonic_code.UD_Istosw, InstrFlags.UseAdrSizeInside},
                {ud_mnemonic_code.UD_Istosd, InstrFlags.UseAdrSizeInside},
                {ud_mnemonic_code.UD_Iscasb, InstrFlags.UseAdrSizeInside},
                {ud_mnemonic_code.UD_Iscasw, InstrFlags.UseAdrSizeInside},
                {ud_mnemonic_code.UD_Iscasd, InstrFlags.UseAdrSizeInside},
                {ud_mnemonic_code.UD_Ilodsb, InstrFlags.UseAdrSizeInside},
                {ud_mnemonic_code.UD_Ilodsw, InstrFlags.UseAdrSizeInside},
                {ud_mnemonic_code.UD_Ilodsd, InstrFlags.UseAdrSizeInside},
                {ud_mnemonic_code.UD_Imovsb, InstrFlags.UseAdrSizeInside},
                {ud_mnemonic_code.UD_Imovsw, InstrFlags.UseAdrSizeInside},
                {ud_mnemonic_code.UD_Imovsd, InstrFlags.UseAdrSizeInside},
                {ud_mnemonic_code.UD_Icmpsb, InstrFlags.UseAdrSizeInside},
                {ud_mnemonic_code.UD_Icmpsw, InstrFlags.UseAdrSizeInside},
                {ud_mnemonic_code.UD_Icmpsd, InstrFlags.UseAdrSizeInside},

                {ud_mnemonic_code.UD_Ifnsave, InstrFlags.UseOprSizeInside | InstrFlags.UseAdrSizeInside},
                {ud_mnemonic_code.UD_Ifrstor, InstrFlags.UseOprSizeInside | InstrFlags.UseAdrSizeInside},
                
                {ud_mnemonic_code.UD_Ifbstp, InstrFlags.UseAdrSizeInside},

                {ud_mnemonic_code.UD_Ijmp, InstrFlags.UseOprSizeInside},
                {ud_mnemonic_code.UD_Ijb, InstrFlags.UseOprSizeInside},
                {ud_mnemonic_code.UD_Ijz, InstrFlags.UseOprSizeInside},
                {ud_mnemonic_code.UD_Ijnz, InstrFlags.UseOprSizeInside},
                {ud_mnemonic_code.UD_Ijns, InstrFlags.UseOprSizeInside},
                {ud_mnemonic_code.UD_Ijae, InstrFlags.UseOprSizeInside},
                {ud_mnemonic_code.UD_Ijg, InstrFlags.UseOprSizeInside},
                {ud_mnemonic_code.UD_Ijs, InstrFlags.UseOprSizeInside},
                {ud_mnemonic_code.UD_Ijge, InstrFlags.UseOprSizeInside},
                {ud_mnemonic_code.UD_Ijl, InstrFlags.UseOprSizeInside},
                {ud_mnemonic_code.UD_Ija, InstrFlags.UseOprSizeInside},
                {ud_mnemonic_code.UD_Ijbe, InstrFlags.UseOprSizeInside},
                {ud_mnemonic_code.UD_Ijle, InstrFlags.UseOprSizeInside},
                {ud_mnemonic_code.UD_Ijno, InstrFlags.UseOprSizeInside},
                {ud_mnemonic_code.UD_Ijnp, InstrFlags.UseOprSizeInside},
                {ud_mnemonic_code.UD_Ijcxz, InstrFlags.UseOprSizeInside},
                {ud_mnemonic_code.UD_Ijecxz, InstrFlags.UseOprSizeInside},
                {ud_mnemonic_code.UD_Ijo, InstrFlags.UseOprSizeInside},
                {ud_mnemonic_code.UD_Ijp, InstrFlags.UseOprSizeInside},

                {ud_mnemonic_code.UD_Iloop, InstrFlags.UseOprSizeInside | InstrFlags.UseAdrSizeInside},
                {ud_mnemonic_code.UD_Iloope, InstrFlags.UseOprSizeInside | InstrFlags.UseAdrSizeInside},
                {ud_mnemonic_code.UD_Iloopne, InstrFlags.UseOprSizeInside | InstrFlags.UseAdrSizeInside},
                
                {ud_mnemonic_code.UD_Icall, InstrFlags.UseOprSizeInside},
                {ud_mnemonic_code.UD_Iret, InstrFlags.UseOprSizeInside},
                {ud_mnemonic_code.UD_Iretf, InstrFlags.UseOprSizeInside},
                {ud_mnemonic_code.UD_Ienter, InstrFlags.UseOprSizeInside},
                {ud_mnemonic_code.UD_Ileave, InstrFlags.UseOprSizeInside},
                
                {ud_mnemonic_code.UD_Ilgdt, InstrFlags.UseOprSizeInside | InstrFlags.UseAdrSizeInside},
                {ud_mnemonic_code.UD_Ilidt, InstrFlags.UseOprSizeInside | InstrFlags.UseAdrSizeInside},
                {ud_mnemonic_code.UD_Isidt, InstrFlags.UseOprSizeInside | InstrFlags.UseAdrSizeInside},
                {ud_mnemonic_code.UD_Ixlatb, InstrFlags.UseAdrSizeInside},

                {ud_mnemonic_code.UD_Iinsb, InstrFlags.UseAdrSizeInside},
                {ud_mnemonic_code.UD_Iinsw, InstrFlags.UseAdrSizeInside},
                {ud_mnemonic_code.UD_Iinsd, InstrFlags.UseAdrSizeInside},
                {ud_mnemonic_code.UD_Ioutsb, InstrFlags.UseAdrSizeInside},
                {ud_mnemonic_code.UD_Ioutsw, InstrFlags.UseAdrSizeInside},
                {ud_mnemonic_code.UD_Ioutsd, InstrFlags.UseAdrSizeInside},
            };

        #endregion

        public static IEqualityComparer<CSharpInstruction> BeginEqualityComparer =>
            new CustomEqualityComparer<CSharpInstruction>(
                (x, y) => x.Begin == y.Begin,
                x => x.Begin.GetHashCode());

        public static IComparer<CSharpInstruction> BeginComparer =>
            new CustomComparer<CSharpInstruction>(
                (x, y) => x.Begin.CompareTo(y.Begin));


        public static IEnumerable<CSharpInstruction> DecodeCode(
            IMemory memory,
            Address address,
            ArchitectureMode mode,
            DefinitionCollection definitionCollection)
        {
            var u = new ud();
            var ac = new AssemblyCode(memory, u);
            udis86.ud_init(ref u);
            udis86.ud_set_pc(ref u, address);
            udis86.ud_set_mode(ref u, (byte)mode);
            udis86.ud_set_vendor(ref u, (int)Vendor.Any);
            udis86.ud_set_syntax(ref u, new syn_intel().ud_translate_intel);
            udis86.ud_set_input_buffer(ref u, ac);

            u.inp_buf_index = (int)address;

            while (true)
            {
                var length = udis86.ud_disassemble(ref u);
                if (length <= 0 || u.error != 0 || u.mnemonic == ud_mnemonic_code.UD_Iinvalid)
                    break; // throw new InvalidOperationException("Преждевременное завершение функции.");

                var cmd = new CSharpInstruction(definitionCollection, u);
                yield return cmd;
            }
        }


        public static string GetSizeSuffixByBits(int size)
        {
            switch (size)
            {
                case 8:
                    return "b";
                case 16:
                    return "w";
                case 32:
                    return "d";
                case 64:
                    return "q";
                case 80:
                    return "t";
                case 128:
                    return "o";
                case 256:
                    return "y";
                case 512:
                    return "z";
                default:
                    throw new ArgumentException($"Unknown size {size}.");
            }
        }

        public static string GetCSharpCast(bool signed, int bits)
        {
            switch (bits)
            {
                case 8:
                    return signed ? "(sbyte)" : "(byte)";
                case 16:
                    return signed ? "(short)" : "(ushort)";
                case 32:
                    return signed ? "(int)" : "(uint)";
                case 64:
                    return signed ? "(long)" : "(ulong)";
                default:
                    throw new ArgumentException($"signed: {signed}, bits: {bits}.");
            }
        }

        private class AssemblyCode : IAssemblyCode
        {
            private readonly IMemory _memory;
            private readonly ud _ud;

            public AssemblyCode(IMemory memory, ud ud)
            {
                _memory = memory;
                _ud = ud;
            }

            /// <inheritdoc />
            public byte this[int index]
            {
                get
                {
                    try
                    {
                        return _memory.GetMinSize(index, 1)[0];
                    }
                    catch (Exception)
                    {
                        _ud.inp_end = 1;
                        _ud.error = 1;
                        _ud.errorMessage = "byte expected, eoi received";
                        return 0;
                    }
                }
            }

            /// <inheritdoc />
            public int Length => int.MaxValue;
        }
    }
}