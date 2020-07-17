using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using MikhailKhalizev.Processor.x86.CSharpExecutor.Abstractions.Memory;
using MikhailKhalizev.Processor.x86.Decoder;
using MikhailKhalizev.Processor.x86.Utils;
using SharpDisasm;
using SharpDisasm.Udis86;

namespace MikhailKhalizev.Processor.x86.BinToCSharp.LowLevel
{
    public interface ICSharpInstruction
    {
        public static IEqualityComparer<ICSharpInstruction> BeginEqualityComparer =>
            new CustomEqualityComparer<ICSharpInstruction>(
                (x, y) => x.Begin == y.Begin,
                x => x.Begin.GetHashCode());

        public static IComparer<ICSharpInstruction> BeginComparer =>
            new CustomComparer<ICSharpInstruction>(
                (x, y) => x.Begin.CompareTo(y.Begin));
        

        Address Begin { get; set; }
        Address End { get; set; }

        bool HasLabel { get; set; }
        bool IsJmpOrJcc { get; }
        bool IsLoopOrLoopcc { get; }
        bool IsRet { get; }
        bool IsJmp { get; }
        bool IsJmpOrRet => IsJmp || IsRet;
        bool IsLocalBranch { get; set; }


        IEnumerable<string> GetCode(bool isLastInstructionInMethod);

    }

    public static class CSharpInstructionExtensions
    {
        public static string GetInstructionInfoStringStatic(bool withRightPadding, Address begin, Address end)
        {
            var str = $"ii({begin}, {end - begin});";

            if (withRightPadding)
                str += "  ";

            return str;
        }

        public static string GetInstructionInfoString(this ICSharpInstruction cmd, bool withRightPadding)
        {
            return GetInstructionInfoStringStatic(withRightPadding, cmd.Begin, cmd.End);
        }
    }

    
    public class ProxyCSharpInstruction : ICSharpInstruction
    {
        public ICSharpInstruction IcSharpInstructionImplementation { get; }

        public ProxyCSharpInstruction(ICSharpInstruction icSharpInstructionImplementation)
        {
            IcSharpInstructionImplementation = icSharpInstructionImplementation;
        }

        /// <inheritdoc />
        public virtual Address End
        {
            get => IcSharpInstructionImplementation.End;
            set => IcSharpInstructionImplementation.End = value;
        }

        /// <inheritdoc />
        public virtual bool HasLabel
        {
            get => IcSharpInstructionImplementation.HasLabel;
            set => IcSharpInstructionImplementation.HasLabel = value;
        }

        /// <inheritdoc />
        public virtual bool IsJmpOrJcc => IcSharpInstructionImplementation.IsJmpOrJcc;

        /// <inheritdoc />
        public virtual bool IsLoopOrLoopcc => IcSharpInstructionImplementation.IsLoopOrLoopcc;

        /// <inheritdoc />
        public virtual bool IsRet => IcSharpInstructionImplementation.IsRet;

        /// <inheritdoc />
        public virtual bool IsJmp => IcSharpInstructionImplementation.IsJmp;

        /// <inheritdoc />
        public virtual bool IsLocalBranch
        {
            get => IcSharpInstructionImplementation.IsLocalBranch;
            set => IcSharpInstructionImplementation.IsLocalBranch = value;
        }

        /// <inheritdoc />
        public virtual IEnumerable<string> GetCode(bool isLastInstructionInMethod)
        {
            return IcSharpInstructionImplementation.GetCode(isLastInstructionInMethod);
        }

        /// <inheritdoc />
        public virtual Address Begin
        {
            get => IcSharpInstructionImplementation.Begin;
            set => IcSharpInstructionImplementation.Begin = value;
        }
    }

    public class CSharpInstructionAddressSearch : ICSharpInstruction
    {
        /// <inheritdoc />
        public Address Begin { get; set; }

        /// <inheritdoc />
        public Address End { get; set; }

        /// <inheritdoc />
        public bool HasLabel { get; set; }

        /// <inheritdoc />
        public bool IsJmpOrJcc { get; }

        /// <inheritdoc />
        public bool IsLoopOrLoopcc { get; }

        /// <inheritdoc />
        public bool IsRet { get; }

        /// <inheritdoc />
        public bool IsJmp { get; }

        public CSharpInstructionAddressSearch(Address address)
        {
            Begin = address;
            End = address;
        }

        /// <inheritdoc />
        public bool IsLocalBranch { get; set; }

        /// <inheritdoc />
        public IEnumerable<string> GetCode(bool isLastInstructionInMethod)
        {
            throw new NotImplementedException();
        }
    }


    public class CSharpInstruction : ICSharpInstruction
    {
        public Address Begin { get; set; }
        public Address End { get; set; }

        public int Mode { get; set; }
        public int AddrMode { get; set; }
        public int OprMode { get; set; }
        public int EffOprMode { get; set; }

        public ud_mnemonic_code Mnemonic { get; set; } = ud_mnemonic_code.UD_Inone;
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

        
        public DefinitionCollection DefinitionCollection { get; }

        /// <summary>
        /// Закомментировать всю напечатанную строку.
        /// </summary>
        public bool CommentThis { get; set; }

        /// <summary>
        /// Комментарии к инструкции.
        /// </summary>
        public List<string> Comments { get; set; }
        public List<string> CommandSuffix { get; set; }

        public bool HasLabel { get; set; }
        public List<IInstructionFeature> Features { get; } = new List<IInstructionFeature>();

        private int DecimalLimit => 0xfff;

        
        public CSharpInstruction(Address begin, Address end, string comment = null)
        {
            Begin = begin;
            End = end;
            CommentThis = true;

            Comments = new List<string>();
            if (comment != null)
                Comments.Add(comment);

            CommandSuffix = new List<string>();
        }

        public CSharpInstruction(DefinitionCollection definitionCollection, ud ud)
        {
            if (ud == null)
                throw new ArgumentNullException(nameof(ud));
            DefinitionCollection = definitionCollection;

            Comments = new List<string>();
            CommandSuffix = new List<string>();

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


            // Fix instruction.

            EffOprMode = OprMode;
            if (Mnemonic == ud_mnemonic_code.UD_Iout)
                if (ud_type.UD_R_AL <= Operands[1].@base && Operands[1].@base <= ud_type.UD_R_BH)
                    EffOprMode = 8;

            if (Mnemonic == ud_mnemonic_code.UD_Iin
                || Mnemonic == ud_mnemonic_code.UD_Iimul
                || Mnemonic == ud_mnemonic_code.UD_Imul)
                if (ud_type.UD_R_AL <= Operands[0].@base && Operands[0].@base <= ud_type.UD_R_BH)
                    EffOprMode = 8;
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
            var str = GetCommandString();
            if (string.IsNullOrEmpty(str))
                str = string.Join(" ", Comments);
            return str;
        }

        public IEnumerable<string> GetCode(bool isLastInstructionInMethod)
        {
            var lines = Enumerable.Empty<string>();

            var ii = this.GetInstructionInfoString(true);
            var comments = string.Join(" ", Comments.Select(x => $"/* {x} */"));

            
            var cmd = GetCommandString(isLastInstructionInMethod && !IsLocalBranch);
            var line = ii + cmd;

            if (!string.IsNullOrEmpty(cmd) && !string.IsNullOrEmpty(comments))
            {
                line = line.PadRight(59);
                line += comments;
            }

            lines = lines.Append(line);


            lines =
                CommentThis
                    ? lines.Select(x => "//  " + x)
                    : lines.Select(x => "    " + x);

            if (HasLabel)
                lines = Enumerable.Empty<string>().Append($"l_{Begin}:").Concat(lines);

            return lines;
        }


        public string GetCommandString(bool onlyRawCmd = false)
        {
            var cmdSuffix = "";

            if (Mnemonic == ud_mnemonic_code.UD_Inone)
                return "";

            if ((IsLoopOrLoopcc || IsJmpOrJcc) && !IsLocalBranch && Operands[0].type == ud_type.UD_OP_JIMM)
                cmdSuffix += "_func";

            if (IsCallUp)
                cmdSuffix += "_up";

            foreach (var suffix in CommandSuffix)
                cmdSuffix += suffix;
            
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

            if (!InstructionsFlag.TryGetValue(Mnemonic, out var flags))
                flags = InstrFlags.Unknown;

            var method = udis86.ud_lookup_mnemonic(Mnemonic);


            bool addSizeSuffix;

            if (Mnemonic == ud_mnemonic_code.UD_Ipush || Mnemonic == ud_mnemonic_code.UD_Ipop)
            {
                var op = Operands[0];
                if (Operands[0].type == ud_type.UD_OP_REG)
                    addSizeSuffix = EffOprMode != RegisterInfo.GetRegister(op.@base).Bits;
                else if (Operands[0].type == ud_type.UD_OP_MEM)
                    addSizeSuffix = EffOprMode != (op.size == 0 ? EffOprMode : op.size);
                else
                    addSizeSuffix = EffOprMode != Mode;
            }
            else if (Mnemonic == ud_mnemonic_code.UD_Iin || Mnemonic == ud_mnemonic_code.UD_Iout)
            {
                addSizeSuffix = true;
            }
            else
            {
                if (PfxOpr &&
                    !flags.HasFlag(InstrFlags.UseOprSizeInside) &&
                    !flags.HasFlag(InstrFlags.NotUseOprSizeInside) &&
                    !Operands.Any(x => x.type == ud_type.UD_OP_REG || x.type == ud_type.UD_OP_MEM))
                    throw new NotImplementedException(
                        "Вероятно, не используем переопределение размера операнда инструкции. " +
                        $"Mnemonic = {Mnemonic}; Mode = {Mode}; EffOprMode = {EffOprMode}; AddrMode = {AddrMode};  " +
                        $"PfxOpr = {PfxOpr}; PfxAddress = {PfxAddress}; " +
                        $"Comments = {string.Join(",", Comments)}.");

                addSizeSuffix = flags.HasFlag(InstrFlags.UseOprSizeInside) && !flags.HasFlag(InstrFlags.NotUseOprSizeInside) && EffOprMode != Mode;
            }


            if (PfxAddress &&
                !flags.HasFlag(InstrFlags.UseAdrSizeInside) &&
                !flags.HasFlag(InstrFlags.NotUseAdrSizeInside) &&
                Operands.All(x => x.type != ud_type.UD_OP_MEM))
                throw new NotImplementedException(
                    "Вероятно, не используем переопределение размера адреса инструкции. " +
                    $"Mnemonic = {Mnemonic}; Mode = {Mode}; EffOprMode = {EffOprMode}; AddrMode = {AddrMode}; " +
                    $"PfxOpr = {PfxOpr}; PfxAddress = {PfxAddress}; " +
                    $"Comments = {string.Join(",", Comments)}.");

            var addAdrSuffix = flags.HasFlag(InstrFlags.UseAdrSizeInside) && !flags.HasFlag(InstrFlags.NotUseAdrSizeInside) && AddrMode != Mode;
            var adrModeStr = AddrMode != Mode ? $"_a{AddrMode}" : "";


            if (addSizeSuffix)
                method += GetSizeSuffixByBits(EffOprMode);
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

                AppendOperand(op, sb, adrModeStr, ref usePfxSeg, options);
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
                    oprSize = EffOprMode;

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
                sb.Append(" return;");

            return sb.ToString();
        }

        private void AppendOperand(ud_operand op, StringBuilder sb, string adrModeStr, ref bool usePfxSeg, DefinitionCollection.Options options)
        {
            var oprSize = op.size == 0 ? EffOprMode : op.size;

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

                            AppendAddress(sb, (uint) -val, options.WithWriteAddressAsDecimal(isNextOperation && -DecimalLimit < val));
                        }
                        else if (0 < val || !isNextOperation)
                        {
                            if (isNextOperation)
                                sb.Append(" + ");

                            AppendAddress(sb, (uint) val, options.WithWriteAddressAsDecimal(isNextOperation && val < DecimalLimit));
                        }

                        isNextOperation = true;
                    }

                    sb.Append(']');
                    break;
                }

                case ud_type.UD_OP_IMM:
                {
                    var hexValue = true;
                    //new[]
                    //{
                    //    ud_mnemonic_code.UD_Iand,
                    //    ud_mnemonic_code.UD_Ior,
                    //    ud_mnemonic_code.UD_Itest,
                    //    ud_mnemonic_code.UD_Irol,
                    //    ud_mnemonic_code.UD_Iror,
                    //    ud_mnemonic_code.UD_Ishl,
                    //    ud_mnemonic_code.UD_Ishr,
                    //    ud_mnemonic_code.UD_Iint,
                    //}.Contains(Mnemonic);

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

                            // Работа не с 8-битной инструкцией.
                            if (!(ud_type.UD_R_AL <= Operands[0].@base && Operands[0].@base <= ud_type.UD_R_BH))
                                needSignExtend = needSignExtend ||
                                    Mnemonic == ud_mnemonic_code.UD_Iand ||
                                    Mnemonic == ud_mnemonic_code.UD_Ior ||
                                    Mnemonic == ud_mnemonic_code.UD_Ixor;

                            val = op.lval.@sbyte;

                            if (val < 0 && needSignExtend)
                            {
                                sb.Append("-");
                                AppendAddress(sb, (byte) -val, options.WithWriteAddressAsDecimal(-val < DecimalLimit && !hexValue));
                                sb.Append(" /* ");

                                AppendAddress(sb, (byte) val, options.WithWriteAddressAsDecimal((byte) val < DecimalLimit && !hexValue));
                                sb.Append(" */");
                            }
                            else
                            {
                                AppendAddress(sb, (byte) val, options.WithWriteAddressAsDecimal(val < DecimalLimit && !hexValue));
                            }

                            break;
                        }

                        case 16:
                            AppendAddress(sb, op.lval.uword, options.WithWriteAddressAsDecimal(op.lval.uword < DecimalLimit && !hexValue));
                            break;
                        case 32:
                            AppendAddress(sb, op.lval.udword, options.WithWriteAddressAsDecimal(op.lval.udword < DecimalLimit && !hexValue));
                            break;
                        default:
                            throw new NotImplementedException($"oprSize: {oprSize}");
                    }
                    break;
                }

                case ud_type.UD_OP_JIMM:
                {
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

                    if (val < 0)
                        sb.Append("-");
                    AppendNumeric(sb, val < 0 ? (uint) -val : (uint) val);
                    break;
                }

                case ud_type.UD_OP_CONST:
                    AppendAddress(sb, op.lval.udword, options);
                    break;

                case ud_type.UD_OP_PTR:
                    sb.Append($"{HexHelper.ToShortGrouped4Hex(op.lval.ptr_seg)}, {HexHelper.ToShortGrouped4Hex(op.lval.ptr_off)}");
                    break;

                default:
                    throw new NotImplementedException($"op.type: {op.type}");
            }
        }

        private static void AppendNumeric(StringBuilder sb, uint val)
        {
            if (val <= 9)
                sb.Append(val);
            else
                sb.Append(HexHelper.ToShortGrouped4Hex(val));
        }

        private void AppendAddress(StringBuilder sb, uint val, DefinitionCollection.Options options)
        {
            if (val <= 9)
                sb.Append(val);
            else
                sb.Append(DefinitionCollection.GetAddressFullName(val, options));
        }

        #region Known Instructions

        [Flags]
        private enum InstrFlags
        {
            Unknown = 0,

            UseOprSizeInside = 1,
            NotUseOprSizeInside = 2,

            UseAdrSizeInside = 4,
            NotUseAdrSizeInside = 8
        }

        private static readonly Dictionary<ud_mnemonic_code, InstrFlags> InstructionsFlag = new Dictionary<ud_mnemonic_code, InstrFlags>
            {
                {ud_mnemonic_code.UD_Ipusha, InstrFlags.NotUseOprSizeInside},  // Always 16-bit size.
                {ud_mnemonic_code.UD_Ipushad, InstrFlags.NotUseOprSizeInside}, // Always 32-bit size.

                {ud_mnemonic_code.UD_Ipopa, InstrFlags.NotUseOprSizeInside},  // Always 16-bit size.
                {ud_mnemonic_code.UD_Ipopad, InstrFlags.NotUseOprSizeInside}, // Always 32-bit size.

                {ud_mnemonic_code.UD_Ipushfw, InstrFlags.NotUseOprSizeInside}, // Always 16-bit size.
                {ud_mnemonic_code.UD_Ipushfd, InstrFlags.NotUseOprSizeInside}, // Always 32-bit size.
                {ud_mnemonic_code.UD_Ipushfq, InstrFlags.NotUseOprSizeInside}, // Always 64-bit size.

                {ud_mnemonic_code.UD_Ipopfw, InstrFlags.NotUseOprSizeInside}, // Always 16-bit size.
                {ud_mnemonic_code.UD_Ipopfd, InstrFlags.NotUseOprSizeInside}, // Always 32-bit size.
                {ud_mnemonic_code.UD_Ipopfq, InstrFlags.NotUseOprSizeInside}, // Always 64-bit size.

                {ud_mnemonic_code.UD_Imovsb, InstrFlags.NotUseOprSizeInside | InstrFlags.UseAdrSizeInside}, // Always 8-bit size, PfxOpr ignored.
                {ud_mnemonic_code.UD_Imovsw, InstrFlags.NotUseOprSizeInside | InstrFlags.UseAdrSizeInside}, // Always 16-bit size.
                {ud_mnemonic_code.UD_Imovsd, InstrFlags.NotUseOprSizeInside | InstrFlags.UseAdrSizeInside}, // Always 32-bit size.
                {ud_mnemonic_code.UD_Imovsq, InstrFlags.NotUseOprSizeInside | InstrFlags.UseAdrSizeInside}, // Always 64-bit size.

                {ud_mnemonic_code.UD_Istosb, InstrFlags.NotUseOprSizeInside | InstrFlags.UseAdrSizeInside}, // Always 8-bit size, PfxOpr ignored.
                {ud_mnemonic_code.UD_Istosw, InstrFlags.NotUseOprSizeInside | InstrFlags.UseAdrSizeInside}, // Always 16-bit size.
                {ud_mnemonic_code.UD_Istosd, InstrFlags.NotUseOprSizeInside | InstrFlags.UseAdrSizeInside}, // Always 32-bit size.
                {ud_mnemonic_code.UD_Istosq, InstrFlags.NotUseOprSizeInside | InstrFlags.UseAdrSizeInside}, // Always 64-bit size.

                {ud_mnemonic_code.UD_Iscasb, InstrFlags.NotUseOprSizeInside | InstrFlags.UseAdrSizeInside}, // Always 8-bit size, PfxOpr ignored.
                {ud_mnemonic_code.UD_Iscasw, InstrFlags.NotUseOprSizeInside | InstrFlags.UseAdrSizeInside}, // Always 16-bit size.
                {ud_mnemonic_code.UD_Iscasd, InstrFlags.NotUseOprSizeInside | InstrFlags.UseAdrSizeInside}, // Always 32-bit size.
                {ud_mnemonic_code.UD_Iscasq, InstrFlags.NotUseOprSizeInside | InstrFlags.UseAdrSizeInside}, // Always 64-bit size.

                {ud_mnemonic_code.UD_Ilodsb, InstrFlags.NotUseOprSizeInside | InstrFlags.UseAdrSizeInside}, // Always 8-bit size, PfxOpr ignored.
                {ud_mnemonic_code.UD_Ilodsw, InstrFlags.NotUseOprSizeInside | InstrFlags.UseAdrSizeInside}, // Always 16-bit size.
                {ud_mnemonic_code.UD_Ilodsd, InstrFlags.NotUseOprSizeInside | InstrFlags.UseAdrSizeInside}, // Always 32-bit size.
                {ud_mnemonic_code.UD_Ilodsq, InstrFlags.NotUseOprSizeInside | InstrFlags.UseAdrSizeInside}, // Always 64-bit size.

                {ud_mnemonic_code.UD_Icmpsb, InstrFlags.NotUseOprSizeInside | InstrFlags.UseAdrSizeInside}, // Always 8-bit size, PfxOpr ignored.
                {ud_mnemonic_code.UD_Icmpsw, InstrFlags.NotUseOprSizeInside | InstrFlags.UseAdrSizeInside}, // Always 16-bit size.
                {ud_mnemonic_code.UD_Icmpsd, InstrFlags.NotUseOprSizeInside | InstrFlags.UseAdrSizeInside}, // Always 32-bit size.
                {ud_mnemonic_code.UD_Icmpsq, InstrFlags.NotUseOprSizeInside | InstrFlags.UseAdrSizeInside}, // Always 64-bit size.

                {ud_mnemonic_code.UD_Icbw, InstrFlags.NotUseOprSizeInside},  // Always 16-bit size.
                {ud_mnemonic_code.UD_Icwde, InstrFlags.NotUseOprSizeInside}, // Always 32-bit size.
                {ud_mnemonic_code.UD_Icdqe, InstrFlags.NotUseOprSizeInside}, // Always 64-bit size.

                {ud_mnemonic_code.UD_Icwd, InstrFlags.NotUseOprSizeInside}, // Always 16-bit size.
                {ud_mnemonic_code.UD_Icdq, InstrFlags.NotUseOprSizeInside}, // Always 32-bit size.
                {ud_mnemonic_code.UD_Icqo, InstrFlags.NotUseOprSizeInside}, // Always 64-bit size.

                {ud_mnemonic_code.UD_Iiretw, InstrFlags.NotUseOprSizeInside}, // Always 16-bit size.
                {ud_mnemonic_code.UD_Iiretd, InstrFlags.NotUseOprSizeInside}, // Always 32-bit size.
                {ud_mnemonic_code.UD_Iiretq, InstrFlags.NotUseOprSizeInside}, // Always 64-bit size.

                {ud_mnemonic_code.UD_Ijcxz, InstrFlags.NotUseAdrSizeInside},  // Always 16-bit cx.
                {ud_mnemonic_code.UD_Ijecxz, InstrFlags.NotUseAdrSizeInside}, // Always 32-bit ecx.
                {ud_mnemonic_code.UD_Ijrcxz, InstrFlags.NotUseAdrSizeInside}, // Always 64-bit rcx.

                {ud_mnemonic_code.UD_Ixchg, InstrFlags.NotUseAdrSizeInside}, // Not used memory inside, PfxAddress ignored for method name.
                {ud_mnemonic_code.UD_Iadd, InstrFlags.NotUseAdrSizeInside}, // Not used memory inside, PfxAddress ignored for method name.
                {ud_mnemonic_code.UD_Iinc, InstrFlags.NotUseAdrSizeInside}, // Not used memory inside, PfxAddress ignored for method name.

                {ud_mnemonic_code.UD_Inop, InstrFlags.NotUseOprSizeInside | InstrFlags.NotUseAdrSizeInside}, // Ignore PfxOpr & PfxAddress.
                {ud_mnemonic_code.UD_Isti, InstrFlags.NotUseOprSizeInside | InstrFlags.NotUseAdrSizeInside}, // Ignore PfxOpr & PfxAddress.

                {ud_mnemonic_code.UD_Ifnsave, InstrFlags.UseAdrSizeInside},
                {ud_mnemonic_code.UD_Ifrstor, InstrFlags.UseAdrSizeInside},

                {ud_mnemonic_code.UD_Iinsb, InstrFlags.UseAdrSizeInside},
                {ud_mnemonic_code.UD_Iinsw, InstrFlags.UseAdrSizeInside},
                {ud_mnemonic_code.UD_Iinsd, InstrFlags.UseAdrSizeInside},

                {ud_mnemonic_code.UD_Ioutsb, InstrFlags.UseAdrSizeInside},
                {ud_mnemonic_code.UD_Ioutsw, InstrFlags.UseAdrSizeInside},
                {ud_mnemonic_code.UD_Ioutsd, InstrFlags.UseAdrSizeInside},

                {ud_mnemonic_code.UD_Iloop, InstrFlags.UseAdrSizeInside},
                {ud_mnemonic_code.UD_Iloope, InstrFlags.UseAdrSizeInside},
                {ud_mnemonic_code.UD_Iloopne, InstrFlags.UseAdrSizeInside},

                {ud_mnemonic_code.UD_Ijmp, InstrFlags.UseOprSizeInside},
                {ud_mnemonic_code.UD_Icall, InstrFlags.UseOprSizeInside},

                {ud_mnemonic_code.UD_Iret, InstrFlags.UseOprSizeInside},
                {ud_mnemonic_code.UD_Iretf, InstrFlags.UseOprSizeInside}
            };

        #endregion




        public static IEnumerable<CSharpInstruction> DecodeCode(
            IRandomAccess memory,
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


        public static string GetSizeSuffixByBits(int bits)
        {
            switch (bits)
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
                    throw new ArgumentException($"Unknown size {bits}.");
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
            private readonly IRandomAccess _memory;
            private readonly ud _ud;

            public AssemblyCode(IRandomAccess memory, ud ud)
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


        public T GetFeature<T>()
        {
            return Features.OfType<T>().First();
        }

        public bool TryGetFeature<T>(out T feature)
        {
            feature = Features.OfType<T>().FirstOrDefault();
            return feature != null;
        }
    }
}