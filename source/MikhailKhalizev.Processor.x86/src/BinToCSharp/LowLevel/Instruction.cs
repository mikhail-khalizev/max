﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MikhailKhalizev.Processor.x86.Core.Abstractions;
using MikhailKhalizev.Processor.x86.Utils;
using SharpDisasm;
using SharpDisasm.Udis86;

namespace MikhailKhalizev.Processor.x86.BinToCSharp
{
    public class Instruction
    {
        public DefinitionCollection DefinitionCollection { get; } // TODO Remove?
        public Address Begin { get; set; }
        public Address End { get; set; }

        /// <summary>
        /// Закомментировать всю напечатанную строку.
        /// </summary>
        public bool CommentThis { get; set; }

        /// <summary>
        /// Комментарии к иструкции.
        /// </summary>
        public List<string> Comments { get; set; }

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
        public bool IsAnyLoop { get; set; }
        public bool IsAnyJump { get; set; }
        public bool IsAnyRet { get; set; }
        public bool IsJmpOrRet { get; set; }

        public delegate string WriteCmdDelegate(Engine engine, DetectedMethod dm, int cmdIndex, List<string> commentsInCurrentFunc, int offset);

        public WriteCmdDelegate WriteCmd { get; set; }

        public Instruction(Address address)
        {
            Begin = address;
            End = address;
        }

        public Instruction(Address begin, Address end, string comment = null)
        {
            Begin = begin;
            End = end;
            CommentThis = true;
            if (comment != null)
                Comments = new List<string> { comment };
        }

        public Instruction(DefinitionCollection definitionCollection, ud ud)
        {
            if (ud == null)
                throw new ArgumentNullException(nameof(ud));
            DefinitionCollection = definitionCollection;

            WriteCmd = (e, dm, index, func, offset) => ToCodeString(offset: offset);

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

            IsCall = ud.mnemonic == ud_mnemonic_code.UD_Icall;
            IsAnyLoop = udis86.ud_lookup_mnemonic(Mnemonic).StartsWith("loop");
            IsAnyJump = udis86.ud_lookup_mnemonic(Mnemonic).StartsWith("j");
            IsAnyRet = 0 <= ud.mnemonic.ToString().IndexOf("ret", StringComparison.OrdinalIgnoreCase);
            IsJmpOrRet = ud.mnemonic == ud_mnemonic_code.UD_Ijmp || IsAnyRet;

            if (ud.pfx_rex != 0) // unknown ud_obj.pfx_insn ?
                throw new NotImplementedException();

            Operands = ud.operand
                .TakeWhile(x => x.type != ud_type.UD_NONE)
                .ToList();

            if ((IsAnyJump || IsAnyLoop || IsCall) && Operands[0].type == ud_type.UD_OP_PTR)
                BrFar = true; /* Почему-то cам ud_obj не устанавливает его в 1, хотя это far jump. */

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

        public string ToCodeString(string cmdSuffix = "", string funcAddArg = "", bool isJmpOutside = true, int offset = 0)
        {
            var gotoLabelConditional = 
                (IsAnyJump || IsAnyLoop) && Operands[0].type == ud_type.UD_OP_JIMM && !isJmpOutside && Mnemonic != ud_mnemonic_code.UD_Ijmp;
            var gotoLabel = 
                IsAnyJump && Operands[0].type == ud_type.UD_OP_JIMM && !isJmpOutside && Mnemonic == ud_mnemonic_code.UD_Ijmp;

            var addIf = gotoLabelConditional;
            var addGotoLabel = gotoLabelConditional || gotoLabel;
            var addReturn = isJmpOutside && new[]
            {
                ud_mnemonic_code.UD_Ijmp,
                ud_mnemonic_code.UD_Iret,
                ud_mnemonic_code.UD_Iretf,
                ud_mnemonic_code.UD_Iiretw,
                ud_mnemonic_code.UD_Iiretd,
                ud_mnemonic_code.UD_Iiretq
            }.Contains(Mnemonic);


            var sb = new StringBuilder();

            var flags = _knownInstr[Mnemonic];
            //auto meta = get_meta(mnemonic);
            //if (meta.first == false)
            //{
            //    std::ostringstream err;
            //    err << std::hex << std::showbase << "Unknown instruction at ";
            //    write_addr(err, begin);
            //    err << ':';
            //    for (auto s : comments)
            //        err << " '" << s << '\'';
            //    err << '.';
            //    throw std::logic_error(err.str());
            //}

            var adrModeStr = $"_a{AddrMode}";

            var effOprSize = OprMode;
            if (Mnemonic == ud_mnemonic_code.UD_Iout)
                if (ud_type.UD_R_AL <= Operands[1].@base && Operands[1].@base <= ud_type.UD_R_BH)
                    effOprSize = 8;

            if (Mnemonic == ud_mnemonic_code.UD_Iin
                || Mnemonic == ud_mnemonic_code.UD_Iimul
                || Mnemonic == ud_mnemonic_code.UD_Imul)
                if (ud_type.UD_R_AL <= Operands[0].@base && Operands[0].@base <= ud_type.UD_R_BH)
                    effOprSize = 8;

            if (PfxRepne)
                sb.Append($"repne{adrModeStr}(() => ");
            else if (PfxRepe)
                sb.Append($"repe{adrModeStr}(() => ");
            if (PfxRep)
                sb.Append($"rep{adrModeStr}(() => ");

            if (addIf)
                sb.Append("if(");

            if (Mnemonic == ud_mnemonic_code.UD_Iint)
                sb.Append("@");
            sb.Append(udis86.ud_lookup_mnemonic(Mnemonic));

            if (flags.HasFlag(InstrFlags.UseOprSizeInside))
            {
                if (effOprSize == 8)
                    sb.Append('b');
                else if (effOprSize == 16)
                    sb.Append('w');
                else if (effOprSize == 32)
                    sb.Append('d');
                else if (effOprSize != 0)
                    throw new InvalidOperationException();
            }

            if (flags.HasFlag(InstrFlags.UseAdrSizeInside) ||
                new[] { ud_mnemonic_code.UD_Icall, ud_mnemonic_code.UD_Ijmp }.Contains(Mnemonic) &&
                BrFar &&
                Operands[0].type == ud_type.UD_OP_MEM)
                sb.Append(adrModeStr);

            if (BrFar)
                sb.Append("_far");

            var needWriteNamespace = IsCall;
            if (IsAnyJump || IsAnyLoop || IsCall)
            {
                if (Operands[0].type == ud_type.UD_OP_PTR)
                {
                    sb.Append("_abs");
                    needWriteNamespace = true;
                }
                else if (Operands[0].type == ud_type.UD_OP_MEM || Operands[0].type == ud_type.UD_OP_REG)
                {
                    sb.Append(BrFar ? "_ind" : "_abs");
                    needWriteNamespace = true;
                }
            }
            else
                needWriteNamespace = true;
            
            var options = new DefinitionCollection.Options { WithNamespace = needWriteNamespace };


            sb.Append(cmdSuffix);
            sb.Append("(");


            var nonFirstArg = false;
            var usePfxSeg = false; // Используется ли где-то в операндах сегмент?

            foreach (var op in Operands)
            {
                if (nonFirstArg)
                    sb.Append(", ");
                nonFirstArg = true;

                var oprSize = (int) op.size;
                if (oprSize == 0)
                    oprSize = effOprSize;

                int val;
                switch (op.type)
                {
                    case ud_type.UD_NONE:
                        break;

                    case ud_type.UD_OP_REG:
                        if (ud_type.UD_R_ST0 <= op.@base && op.@base <= ud_type.UD_R_ST7)
                            sb.Append($"ST({op.@base - ud_type.UD_R_ST0})");
                        else
                            sb.Append(syn.ud_reg_tab[op.@base - ud_type.UD_R_AL]);
                        break;

                    case ud_type.UD_OP_MEM:
                    {
                        // TODO Remove?
                        var memInside = // Обращение к памяти происходит внутри инструкции.
                            new[]
                            {
                                ud_mnemonic_code.UD_Ilds,
                                ud_mnemonic_code.UD_Iles,
                                ud_mnemonic_code.UD_Ilss,
                                ud_mnemonic_code.UD_Ilgs,
                                ud_mnemonic_code.UD_Ilfs,
                                ud_mnemonic_code.UD_Ilea,
                                ud_mnemonic_code.UD_Ilgdt,
                                ud_mnemonic_code.UD_Ilidt,
                                ud_mnemonic_code.UD_Isidt,
                                ud_mnemonic_code.UD_Ifnsave,
                                ud_mnemonic_code.UD_Ifrstor,
                                ud_mnemonic_code.UD_Ifbstp,
                                ud_mnemonic_code.UD_Ibound
                            }.Contains(Mnemonic) ||
                            new[]
                            {
                                ud_mnemonic_code.UD_Icall,
                                ud_mnemonic_code.UD_Ijmp
                            }.Contains(Mnemonic) && BrFar;

                        if (memInside == false)
                        {
                            if (oprSize == 8)
                                sb.Append("memb");
                            else if (oprSize == 16)
                                sb.Append("memw");
                            else if (oprSize == 32)
                                sb.Append("memd");
                            else if (oprSize == 64)
                                sb.Append("memq");
                            else if (oprSize == 80)
                                sb.Append("memt");
                            else
                                throw new NotImplementedException();
                            sb.Append($"{adrModeStr}[");
                        }

                        if (Mnemonic != ud_mnemonic_code.UD_Ilea /* Эта инструкция не использует сегмент. */)
                        {
                            sb.Append($"{syn.ud_reg_tab[GetEffectiveSegmentOfOperand(op) - ud_type.UD_R_AL]}, ");

                            if (PfxSeg != ud_type.UD_NONE)
                                usePfxSeg = true;
                        }

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
                                default: throw new NotImplementedException();
                            }

                            if (val < 0)
                            {
                                sb.Append(isNextOperation ? " - " : "-");
                                sb.Append($"0x{-val:x}");
                            }
                            else
                            {
                                sb.Append(isNextOperation ? " + " : "");
                                sb.Append(DefinitionCollection.GetAddressFullName(val, options));
                            }

                            isNextOperation = true;
                        }

                        if (memInside == false)
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
                                    sb.Append(
                                        $"-{HexHelper.ToString(-val, o => o.SetTrimZero())} /* {HexHelper.ToString(op.lval.ubyte, o => o.SetTrimZero())} */");
                                else
                                    sb.Append(HexHelper.ToString(op.lval.ubyte, o => o.SetTrimZero()));
                                break;
                            }

                            case 16:
                                sb.Append(DefinitionCollection.GetAddressFullName(op.lval.uword, options));
                                break;
                            case 32:
                                sb.Append(DefinitionCollection.GetAddressFullName(op.lval.udword, options));
                                break;
                            default:
                                throw new NotImplementedException();
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
                            default: throw new NotImplementedException();
                        }

                        sb.Append(DefinitionCollection.GetAddressFullName(End + val + offset, options));
                        sb.Append(", ");

                        sb.Append(
                            val < 0
                                ? $"-{HexHelper.ToString(-val, o => o.SetTrimZero())}"
                                : HexHelper.ToString(val, o => o.SetTrimZero()));
                        break;

                    case ud_type.UD_OP_CONST:
                        sb.Append(DefinitionCollection.GetAddressFullName(op.lval.udword, options));
                        break;

                    case ud_type.UD_OP_PTR:
                        sb.Append(
                            $"{HexHelper.ToString(op.lval.ptr_seg, o => o.SetTrimZero())}, {HexHelper.ToString(op.lval.ptr_off, o => o.SetTrimZero())}");
                        break;

                    default:
                        throw new NotImplementedException();
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

            if (addIf)
                sb.Append($")");
            else
                sb.Append(";");

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
                    default: throw new NotImplementedException();
                }

                sb.Append($" goto l_{(Address)(End + val + offset)};");
            }
            else if (addReturn)
                sb.Append($" return;");

            return sb.ToString();
        }
        
        #region KnownInstr

        [Flags]
        private enum InstrFlags
        {
            None = 0,
            UseOprSizeInside = 1,
            UseAdrSizeInside = 2
        }

        private static Dictionary<ud_mnemonic_code, InstrFlags> _knownInstr = new Dictionary<ud_mnemonic_code, InstrFlags>
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

                {ud_mnemonic_code.UD_Ifninit, InstrFlags.None},
                {ud_mnemonic_code.UD_Ifnsetpm, InstrFlags.None},
                {ud_mnemonic_code.UD_Ifnstsw, InstrFlags.None},
                {ud_mnemonic_code.UD_Ifnstcw, InstrFlags.None},
                {ud_mnemonic_code.UD_Ifnsave, InstrFlags.UseOprSizeInside | InstrFlags.UseAdrSizeInside},
                {ud_mnemonic_code.UD_Ifrstor, InstrFlags.UseOprSizeInside | InstrFlags.UseAdrSizeInside},
                {ud_mnemonic_code.UD_Iwait, InstrFlags.None},
                {ud_mnemonic_code.UD_Ifldcw, InstrFlags.None},
                {ud_mnemonic_code.UD_Ifld, InstrFlags.None},
                {ud_mnemonic_code.UD_Ifldz, InstrFlags.None},
                {ud_mnemonic_code.UD_Ifld1, InstrFlags.None},
                {ud_mnemonic_code.UD_Ifldlg2, InstrFlags.None},
                {ud_mnemonic_code.UD_Ifdivp, InstrFlags.None},
                {ud_mnemonic_code.UD_Ifdiv, InstrFlags.None},
                {ud_mnemonic_code.UD_Ifidivr, InstrFlags.None},
                {ud_mnemonic_code.UD_Ifmulp, InstrFlags.None},
                {ud_mnemonic_code.UD_Ifmul, InstrFlags.None},
                {ud_mnemonic_code.UD_Ifimul, InstrFlags.None},
                {ud_mnemonic_code.UD_Ifchs, InstrFlags.None},
                {ud_mnemonic_code.UD_Ifcom, InstrFlags.None},
                {ud_mnemonic_code.UD_Ifcom2, InstrFlags.None},
                {ud_mnemonic_code.UD_Ifcomp, InstrFlags.None},
                {ud_mnemonic_code.UD_Ifcompp, InstrFlags.None},
                {ud_mnemonic_code.UD_Ifxch, InstrFlags.None},
                {ud_mnemonic_code.UD_Ifsubp, InstrFlags.None},
                {ud_mnemonic_code.UD_Ifsub, InstrFlags.None},
                {ud_mnemonic_code.UD_Ifsubr, InstrFlags.None},
                {ud_mnemonic_code.UD_Ifild, InstrFlags.None},
                {ud_mnemonic_code.UD_Ifst, InstrFlags.None},
                {ud_mnemonic_code.UD_Ifstp, InstrFlags.None},
                {ud_mnemonic_code.UD_Ifist, InstrFlags.None},
                {ud_mnemonic_code.UD_Ifistp, InstrFlags.None},
                {ud_mnemonic_code.UD_Ifisttp, InstrFlags.None},
                {ud_mnemonic_code.UD_Iftst, InstrFlags.None},
                {ud_mnemonic_code.UD_Ifrndint, InstrFlags.None},
                {ud_mnemonic_code.UD_Ifprem, InstrFlags.None},
                {ud_mnemonic_code.UD_Ifdivr, InstrFlags.None},
                {ud_mnemonic_code.UD_Ifdivrp, InstrFlags.None},
                {ud_mnemonic_code.UD_Ifldln2, InstrFlags.None},
                {ud_mnemonic_code.UD_Ifyl2x, InstrFlags.None},
                {ud_mnemonic_code.UD_Ifldl2e, InstrFlags.None},
                {ud_mnemonic_code.UD_Ifadd, InstrFlags.None},
                {ud_mnemonic_code.UD_Ifaddp, InstrFlags.None},
                {ud_mnemonic_code.UD_Ifsqrt, InstrFlags.None},
                {ud_mnemonic_code.UD_Ifscale, InstrFlags.None},
                {ud_mnemonic_code.UD_Ifbstp, InstrFlags.UseAdrSizeInside},
                {ud_mnemonic_code.UD_Ifisubr, InstrFlags.None},
                {ud_mnemonic_code.UD_Ifabs, InstrFlags.None},
                {ud_mnemonic_code.UD_If2xm1, InstrFlags.None},

                {ud_mnemonic_code.UD_Ipushfw, InstrFlags.None},
                {ud_mnemonic_code.UD_Ipushfd, InstrFlags.None},
                {ud_mnemonic_code.UD_Ipopfw, InstrFlags.None},
                {ud_mnemonic_code.UD_Ipopfd, InstrFlags.None},
                {ud_mnemonic_code.UD_Ipush, InstrFlags.UseOprSizeInside},
                {ud_mnemonic_code.UD_Ipop, InstrFlags.UseOprSizeInside},
                {ud_mnemonic_code.UD_Ipusha, InstrFlags.None},
                {ud_mnemonic_code.UD_Ipopa, InstrFlags.None},
                {ud_mnemonic_code.UD_Ipushad, InstrFlags.None},
                {ud_mnemonic_code.UD_Ipopad, InstrFlags.None},

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

                {ud_mnemonic_code.UD_Iles, InstrFlags.None},
                {ud_mnemonic_code.UD_Ilds, InstrFlags.None},
                {ud_mnemonic_code.UD_Ilss, InstrFlags.None},
                {ud_mnemonic_code.UD_Ilgs, InstrFlags.None},
                {ud_mnemonic_code.UD_Ilfs, InstrFlags.None},

                {ud_mnemonic_code.UD_Imov, InstrFlags.None},
                {ud_mnemonic_code.UD_Iadd, InstrFlags.None},
                {ud_mnemonic_code.UD_Iadc, InstrFlags.None},
                {ud_mnemonic_code.UD_Icmp, InstrFlags.None},
                {ud_mnemonic_code.UD_Isub, InstrFlags.None},
                {ud_mnemonic_code.UD_Isbb, InstrFlags.None},
                {ud_mnemonic_code.UD_Isar, InstrFlags.None},
                {ud_mnemonic_code.UD_Ishl, InstrFlags.None},
                {ud_mnemonic_code.UD_Ishr, InstrFlags.None},
                {ud_mnemonic_code.UD_Ishrd, InstrFlags.None},
                {ud_mnemonic_code.UD_Ishld, InstrFlags.None},
                {ud_mnemonic_code.UD_Ircl, InstrFlags.None},
                {ud_mnemonic_code.UD_Ircr, InstrFlags.None},
                {ud_mnemonic_code.UD_Iror, InstrFlags.None},
                {ud_mnemonic_code.UD_Irol, InstrFlags.None},
                {ud_mnemonic_code.UD_Iinc, InstrFlags.None},
                {ud_mnemonic_code.UD_Idec, InstrFlags.None},
                {ud_mnemonic_code.UD_Ineg, InstrFlags.None},
                {ud_mnemonic_code.UD_Inot, InstrFlags.None},
                {ud_mnemonic_code.UD_Iint, InstrFlags.None},
                {ud_mnemonic_code.UD_Iinto, InstrFlags.None},
                {ud_mnemonic_code.UD_Iint1, InstrFlags.None},
                {ud_mnemonic_code.UD_Iint3, InstrFlags.None},
                {ud_mnemonic_code.UD_Icld, InstrFlags.None},
                {ud_mnemonic_code.UD_Iand, InstrFlags.None},
                {ud_mnemonic_code.UD_Ior, InstrFlags.None},
                {ud_mnemonic_code.UD_Ixor, InstrFlags.None},
                {ud_mnemonic_code.UD_Itest, InstrFlags.None},
                {ud_mnemonic_code.UD_Icall, InstrFlags.UseOprSizeInside},
                {ud_mnemonic_code.UD_Iret, InstrFlags.UseOprSizeInside},
                {ud_mnemonic_code.UD_Iretf, InstrFlags.UseOprSizeInside},
                {ud_mnemonic_code.UD_Iiretw, InstrFlags.None},
                {ud_mnemonic_code.UD_Iiretd, InstrFlags.None},
                {ud_mnemonic_code.UD_Iiretq, InstrFlags.None},
                {ud_mnemonic_code.UD_Icwd, InstrFlags.None},
                {ud_mnemonic_code.UD_Icbw, InstrFlags.None},
                {ud_mnemonic_code.UD_Istd, InstrFlags.None},
                {ud_mnemonic_code.UD_Ixchg, InstrFlags.None},
                {ud_mnemonic_code.UD_Ilea, InstrFlags.None},
                {ud_mnemonic_code.UD_Iinvalid, InstrFlags.None},
                {ud_mnemonic_code.UD_Ismsw, InstrFlags.None},
                {ud_mnemonic_code.UD_Ilmsw, InstrFlags.None},
                {ud_mnemonic_code.UD_Ienter, InstrFlags.UseOprSizeInside},
                {ud_mnemonic_code.UD_Ileave, InstrFlags.UseOprSizeInside},
                {ud_mnemonic_code.UD_Ibt, InstrFlags.None},
                {ud_mnemonic_code.UD_Ibtc, InstrFlags.None},
                {ud_mnemonic_code.UD_Icpuid, InstrFlags.None},

                {ud_mnemonic_code.UD_Iseta, InstrFlags.None},
                {ud_mnemonic_code.UD_Isetg, InstrFlags.None},
                {ud_mnemonic_code.UD_Isetae, InstrFlags.None},
                {ud_mnemonic_code.UD_Isetz, InstrFlags.None},
                {ud_mnemonic_code.UD_Isetnz, InstrFlags.None},
                {ud_mnemonic_code.UD_Isetbe, InstrFlags.None},
                {ud_mnemonic_code.UD_Isetge, InstrFlags.None},
                {ud_mnemonic_code.UD_Isetl, InstrFlags.None},
                {ud_mnemonic_code.UD_Isetle, InstrFlags.None},

                {ud_mnemonic_code.UD_Imul, InstrFlags.None},
                {ud_mnemonic_code.UD_Iimul, InstrFlags.None},
                {ud_mnemonic_code.UD_Idiv, InstrFlags.None},
                {ud_mnemonic_code.UD_Iidiv, InstrFlags.None},
                {ud_mnemonic_code.UD_Icli, InstrFlags.None},
                {ud_mnemonic_code.UD_Isti, InstrFlags.None},
                {ud_mnemonic_code.UD_Icmc, InstrFlags.None},
                {ud_mnemonic_code.UD_Imovzx, InstrFlags.None},
                {ud_mnemonic_code.UD_Iclts, InstrFlags.None},
                {ud_mnemonic_code.UD_Illdt, InstrFlags.None},
                {ud_mnemonic_code.UD_Isldt, InstrFlags.None},
                {ud_mnemonic_code.UD_Ilgdt, InstrFlags.UseOprSizeInside | InstrFlags.UseAdrSizeInside},
                {ud_mnemonic_code.UD_Ilidt, InstrFlags.UseOprSizeInside | InstrFlags.UseAdrSizeInside},
                {ud_mnemonic_code.UD_Isidt, InstrFlags.UseOprSizeInside | InstrFlags.UseAdrSizeInside},
                {ud_mnemonic_code.UD_Iltr, InstrFlags.None},
                {ud_mnemonic_code.UD_Ilar, InstrFlags.None},
                {ud_mnemonic_code.UD_Iclc, InstrFlags.None},
                {ud_mnemonic_code.UD_Istc, InstrFlags.None},
                {ud_mnemonic_code.UD_Ibtr, InstrFlags.None},
                {ud_mnemonic_code.UD_Istr, InstrFlags.None},
                {ud_mnemonic_code.UD_Ilsl, InstrFlags.None},
                {ud_mnemonic_code.UD_Ixlatb, InstrFlags.UseAdrSizeInside},

                {ud_mnemonic_code.UD_Iin, InstrFlags.UseOprSizeInside},
                {ud_mnemonic_code.UD_Iout, InstrFlags.UseOprSizeInside},
                {ud_mnemonic_code.UD_Iinsb, InstrFlags.UseAdrSizeInside},
                {ud_mnemonic_code.UD_Iinsw, InstrFlags.UseAdrSizeInside},
                {ud_mnemonic_code.UD_Iinsd, InstrFlags.UseAdrSizeInside},
                {ud_mnemonic_code.UD_Ioutsb, InstrFlags.UseAdrSizeInside},
                {ud_mnemonic_code.UD_Ioutsw, InstrFlags.UseAdrSizeInside},
                {ud_mnemonic_code.UD_Ioutsd, InstrFlags.UseAdrSizeInside},

                {ud_mnemonic_code.UD_Isahf, InstrFlags.None},
                {ud_mnemonic_code.UD_Imovsx, InstrFlags.None},
                {ud_mnemonic_code.UD_Icwde, InstrFlags.None},
                {ud_mnemonic_code.UD_Icdq, InstrFlags.None},
                {ud_mnemonic_code.UD_Inop, InstrFlags.None},

                {ud_mnemonic_code.UD_Iaaa, InstrFlags.None},
                {ud_mnemonic_code.UD_Iaad, InstrFlags.None},
                {ud_mnemonic_code.UD_Iaam, InstrFlags.None},
                {ud_mnemonic_code.UD_Iaas, InstrFlags.None},
                {ud_mnemonic_code.UD_Idaa, InstrFlags.None},
                {ud_mnemonic_code.UD_Idas, InstrFlags.None},
                {ud_mnemonic_code.UD_Iarpl, InstrFlags.None},
                {ud_mnemonic_code.UD_Ibound, InstrFlags.UseAdrSizeInside},
                {ud_mnemonic_code.UD_Ihlt, InstrFlags.None},
                {ud_mnemonic_code.UD_Ibsr, InstrFlags.None},
                {ud_mnemonic_code.UD_Iverr, InstrFlags.None},
                {ud_mnemonic_code.UD_Ilahf, InstrFlags.None},
                {ud_mnemonic_code.UD_Isalc, InstrFlags.None},

                //        {ud_mnemonic_code.UD_Isysenter, InstrFlags.None},
                //        {ud_mnemonic_code.UD_Imovups, InstrFlags.None},
            };

        #endregion

        public static IEqualityComparer<Instruction> BeginEqualityComparer =>
            new CustomEqualityComparer<Instruction>(
                (x, y) => x.Begin == y.Begin,
                x => x.Begin.GetHashCode());

        public static IComparer<Instruction> BeginComparer =>
            new CustomComparer<Instruction>(
                (x, y) => x.Begin.CompareTo(y.Begin));
    }
}