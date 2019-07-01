using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MikhailKhalizev.Processor.x86.Abstractions;
using MikhailKhalizev.Processor.x86.Abstractions.Memory;
using MikhailKhalizev.Processor.x86.Utils;
using MikhailKhalizev.Utils;
using SharpDisasm;
using SharpDisasm.Udis86;

namespace MikhailKhalizev.Processor.x86.BinToCSharp
{
    public class Instruction
    {
        public Address Begin { get; }
        public Address End { get; }
        private List<string> _comments = new List<string>();
        //private bool _commentThis; // Закомментировать всю напечатанную строку.

        private int _addrMode;
        private int _oprMode;

        private ud_mnemonic_code _mnemonic;
        private List<ud_operand> _operands;

        private ud_type _pfx_seg;
        private bool _br_far;
        private bool _pfx_rep;
        private bool _pfx_repe;
        private bool _pfx_repne;

        private bool _is_call;
        private bool _is_any_loop;
        private bool _is_any_jump;
        private bool _is_any_ret;
        private bool _is_jmp_or_ret;


        public Instruction(ArchitectureMode mode, Address address, byte[] raw)
            : this(new Disassembler(raw, mode, address, true, Vendor.Intel).NextInstruction())
        { }

        public Instruction(ArchitectureMode mode, Address address, IMemorySpaceReadAccess memory)
            : this(CreateDisassembler(mode, address, memory).NextInstruction())
        { }

        public static Disassembler CreateDisassembler(ArchitectureMode mode, Address address, IMemorySpaceReadAccess memory)
        {
            var disassembler = new Disassembler(new byte[0], mode, 0, true, Vendor.Intel);
            var ud = disassembler._u;

            var pcInInputHook = disassembler.Address;
            ud.inp_hook = delegate
            {
                try
                {
                    var ret = memory.GetFixSize(pcInInputHook, 1);
                    pcInInputHook++;
                    return ret[0];
                }
                catch
                {
                    return -1;
                }
            };

            return disassembler;
        }

        public Instruction(SharpDisasm.Instruction instr)
        {
            if (instr == null)
                throw new ArgumentNullException(nameof(instr));

            Begin = (Address)instr.Offset;
            End = (Address)instr.PC;

            _mnemonic = instr.Mnemonic;

            _br_far = instr.br_far != 0;
            _pfx_seg = (ud_type)instr.pfx_seg;
            _pfx_rep = instr.pfx_rep != 0;
            _pfx_repe = instr.pfx_repe != 0;
            _pfx_repne = instr.pfx_repne != 0;

            _is_call = instr.Mnemonic == ud_mnemonic_code.UD_Icall;
            _is_any_loop = udis86.ud_lookup_mnemonic(_mnemonic).StartsWith("loop");
            _is_any_jump = udis86.ud_lookup_mnemonic(_mnemonic).StartsWith("j");
            _is_any_ret = 0 <= instr.Mnemonic.ToString().IndexOf("ret", StringComparison.OrdinalIgnoreCase);
            _is_jmp_or_ret = instr.Mnemonic == ud_mnemonic_code.UD_Ijmp || _is_any_ret;

            if (instr.pfx_rex != 0) // unknown ud_obj.pfx_insn ?
                throw new NotImplementedException();

            _operands = instr.Operands
                .Select(x => x.UdOperand)
                .ToList();

            if ((_is_any_jump || _is_any_loop || _is_call) && _operands[0].type == ud_type.UD_OP_PTR)
                _br_far = true; /* Почему-то cам ud_obj не устанавливает его в 1, хотя это far jump. */

            _addrMode = instr.adr_mode;
            _oprMode = instr.opr_mode;

            try
            {
                var str = instr.ToString();
                _comments.Add(str);
            }
            catch { }
        }
        
        private ud_type GetEffectiveSegmentOfOperand(ud_operand op)
        {
            if (_pfx_seg != ud_type.UD_NONE)
                return _pfx_seg;
            if (new[] { ud_type.UD_R_BP, ud_type.UD_R_SP, ud_type.UD_R_EBP, ud_type.UD_R_ESP }.Contains(op.@base))
                return ud_type.UD_R_SS;
            return ud_type.UD_R_DS;
        }

        public string MyToString()
        {
            var os = new StringBuilder();

            var flags = KnownInstr[_mnemonic];
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

            var adr_mode_str = $"_a{_addrMode}";

            var eff_opr_size = _oprMode;
            if (_mnemonic == ud_mnemonic_code.UD_Iout)
                if (ud_type.UD_R_AL <= _operands[1].@base && _operands[1].@base <= ud_type.UD_R_BH)
                    eff_opr_size = 8;

            if (_mnemonic == ud_mnemonic_code.UD_Iin
                || _mnemonic == ud_mnemonic_code.UD_Iimul
                || _mnemonic == ud_mnemonic_code.UD_Imul)
                if (ud_type.UD_R_AL <= _operands[0].@base && _operands[0].@base <= ud_type.UD_R_BH)
                    eff_opr_size = 8;

            if (_pfx_repne)
                os.Append($"repne{adr_mode_str} ");
            else if (_pfx_repe)
                os.Append($"repe{adr_mode_str} ");
            if (_pfx_rep)
                os.Append($"rep{adr_mode_str} ");

            os.Append(udis86.ud_lookup_mnemonic(_mnemonic));
            if (new[] {
                    ud_mnemonic_code.UD_Iint,
                    ud_mnemonic_code.UD_Iand,
                    ud_mnemonic_code.UD_Ior,
                    ud_mnemonic_code.UD_Ixor,
                    ud_mnemonic_code.UD_Istd,
                    ud_mnemonic_code.UD_Inot}.Contains(_mnemonic))
                os.Append('_'); // Чтоб не конфликтовать с различными ключевыми словами C++ и студии разработки.

            if (flags.HasFlag(InstrFlags.UseOprSizeInside))
            {
                if (eff_opr_size == 8)
                    os.Append('b');
                else if (eff_opr_size == 16)
                    os.Append('w');
                else if (eff_opr_size == 32)
                    os.Append('d');
                else if (eff_opr_size != 0)
                    throw new InvalidOperationException();
            }

            if (flags.HasFlag(InstrFlags.UseAdrSizeInside) ||
                    new[] { ud_mnemonic_code.UD_Icall, ud_mnemonic_code.UD_Ijmp }.Contains(_mnemonic) &&
                    _br_far &&
                    _operands[0].type == ud_type.UD_OP_MEM)
                os.Append(adr_mode_str);

            if (_br_far)
                os.Append("_far");

            var need_write_namespace = _is_call;
            if (_is_any_jump || _is_any_loop || _is_call)
            {
                if (_operands[0].type == ud_type.UD_OP_PTR)
                {
                    os.Append("_abs");
                    need_write_namespace = true;
                }
                else if (_operands[0].type == ud_type.UD_OP_MEM || _operands[0].type == ud_type.UD_OP_REG)
                {
                    os.Append(_br_far ? "_ind" : "_abs");
                    need_write_namespace = true;
                }
            }
            else
                need_write_namespace = true;


            // os << cmd_suffix;
            os.Append("(");


            var non_first_arg = false;
            var use_pfx_seg = false; // Используется ли где-то в операндах сегмент?

            foreach (var op in _operands)
            {
                if (non_first_arg)
                    os.Append(", ");
                non_first_arg = true;

                var opr_size = (int)op.size;
                if (opr_size == 0)
                    opr_size = eff_opr_size;

                int val;
                switch (op.type)
                {
                    case ud_type.UD_NONE:
                        break;

                    case ud_type.UD_OP_REG:
                        if (ud_type.UD_R_ST0 <= op.@base && op.@base <= ud_type.UD_R_ST7)
                            os.Append($"{HexHelper.ToString(op.@base - ud_type.UD_R_ST0, o => o.SetTrimZero())} /* {syn.ud_reg_tab[op.@base - ud_type.UD_R_AL]} */");
                        else
                            os.Append(syn.ud_reg_tab[op.@base - ud_type.UD_R_AL]);
                        break;

                    case ud_type.UD_OP_MEM:
                        {
                            var mem_inside = /* Обращение к памяти происходит внутри инструкции. */
                                new[] {
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
                                ud_mnemonic_code.UD_Ibound}.Contains(_mnemonic) ||
                                new[] {
                                    ud_mnemonic_code.UD_Icall,
                                    ud_mnemonic_code.UD_Ijmp}.Contains(_mnemonic) && _br_far;

                            if (mem_inside == false)
                            {
                                if (opr_size == 8)
                                    os.Append("memb");
                                else if (opr_size == 16)
                                    os.Append("memw");
                                else if (opr_size == 32)
                                    os.Append("memd");
                                else if (opr_size == 64)
                                    os.Append("memq");
                                else if (opr_size == 80)
                                    os.Append("memt");
                                else
                                    throw new NotImplementedException();
                                os.Append($"{adr_mode_str}[");
                            }

                            if (_mnemonic != ud_mnemonic_code.UD_Ilea /* Эта инструкция не использует сегмент. */)
                            {
                                os.Append($"{syn.ud_reg_tab[GetEffectiveSegmentOfOperand(op) - ud_type.UD_R_AL]}, ");

                                if (_pfx_seg != ud_type.UD_NONE)
                                    use_pfx_seg = true;
                            }

                            var op_f = false; // Cтоит ли писать '+' (т.е. 'не первое слагаемое').
                            if (op.@base != ud_type.UD_NONE)
                            {
                                os.Append(syn.ud_reg_tab[op.@base - ud_type.UD_R_AL]);
                                op_f = true;
                            }

                            if (op.index != ud_type.UD_NONE)
                            {
                                if (op_f)
                                    os.Append(" + ");
                                op_f = true;

                                os.Append(syn.ud_reg_tab[op.index - ud_type.UD_R_AL]);
                            }

                            if (1 < op.scale)
                            {
                                if (op.index == ud_type.UD_NONE)
                                    throw new NotImplementedException();

                                os.Append($" * {HexHelper.ToString(op.scale, o => o.SetTrimZero())}");
                            }

                            if (op.offset != 0)
                            {
                                switch (op.offset)
                                {
                                    case 8: val = op.lval.@sbyte; break;
                                    case 16: val = op.lval.sword; break;
                                    case 32: val = op.lval.sdword; break;
                                    default: throw new NotImplementedException();
                                }

                                if (val < 0)
                                {
                                    os.Append(op_f ? " - " : "-");
                                    os.Append($"0x{-val:x}");
                                }
                                else
                                {
                                    os.Append(op_f ? " + " : "");
                                    os.Append(AddressNameConverter.GetResultName((Address)val, false, need_write_namespace));
                                }
                                op_f = true;
                            }

                            if (mem_inside == false)
                                os.Append(']');
                            break;
                        }

                    case ud_type.UD_OP_IMM:
                        switch (opr_size)
                        {
                            case 8:
                            {
                                var need_sign_extend = new[]
                                {
                                    ud_mnemonic_code.UD_Iimul,
                                    ud_mnemonic_code.UD_Ipush,
                                    ud_mnemonic_code.UD_Iadc,
                                    ud_mnemonic_code.UD_Iadd,
                                    ud_mnemonic_code.UD_Isbb,
                                    ud_mnemonic_code.UD_Isub,
                                    ud_mnemonic_code.UD_Icmp
                                }.Contains(_mnemonic);

                                // Работа не с 8-байтой инструкцией.
                                if (!(ud_type.UD_R_AL <= _operands[0].@base && _operands[0].@base <= ud_type.UD_R_BH))
                                    need_sign_extend = need_sign_extend ||
                                                       _mnemonic == ud_mnemonic_code.UD_Iand ||
                                                       _mnemonic == ud_mnemonic_code.UD_Ior ||
                                                       _mnemonic == ud_mnemonic_code.UD_Ixor;

                                val = op.lval.@sbyte;

                                if (val < 0 && need_sign_extend)
                                    os.Append($"-{HexHelper.ToString(-val, o => o.SetTrimZero())} /* {HexHelper.ToString(op.lval.ubyte, o => o.SetTrimZero())} */");
                                else
                                    os.Append(HexHelper.ToString(op.lval.ubyte, o => o.SetTrimZero()));
                                break;
                            }
                            case 16:
                                os.Append(AddressNameConverter.GetResultName(op.lval.uword, false, need_write_namespace));
                                break;
                            case 32:
                                os.Append(AddressNameConverter.GetResultName(op.lval.udword, false, need_write_namespace));
                                break;
                            default:
                                throw new NotImplementedException();
                        }
                        break;

                    case ud_type.UD_OP_JIMM:
                        switch (opr_size)
                        {
                            case 8: val = op.lval.@sbyte; break;
                            case 16: val = op.lval.sword; break;
                            case 32: val = op.lval.sdword; break;
                            default: throw new NotImplementedException();
                        }

                        os.Append(AddressNameConverter.GetResultName(End.AddBytes(val), true, need_write_namespace));
                        os.Append(", ");

                        os.Append(val < 0 ? $"-{HexHelper.ToString(-val, o => o.SetTrimZero())}" : HexHelper.ToString(val, o => o.SetTrimZero()));
                        break;

                    case ud_type.UD_OP_CONST:
                        os.Append(AddressNameConverter.GetResultName(op.lval.udword, false, need_write_namespace));
                        break;

                    case ud_type.UD_OP_PTR:
                        os.Append($"{HexHelper.ToString(op.lval.ptr_seg, o => o.SetTrimZero())}, {HexHelper.ToString(op.lval.ptr_off, o => o.SetTrimZero())}");
                        break;

                    default:
                        throw new NotImplementedException();
                }
            }

            if (use_pfx_seg == false && _pfx_seg != ud_type.UD_NONE
                && _mnemonic != ud_mnemonic_code.UD_Imov
                && _mnemonic != ud_mnemonic_code.UD_Ilea)
            {
                // к примеру movsb(es)

                if (non_first_arg)
                    os.Append(", ");
                non_first_arg = true;

                os.Append(syn.ud_reg_tab[_pfx_seg - ud_type.UD_R_AL]);
            }

            //if (func_add_arg.size() != 0)
            //{
            //    if (non_first_arg)
            //        os << ", ";
            //    non_first_arg = true;

            //    os << func_add_arg;
            //}

            os.Append(");");
            return os.ToString();
        }
        
        #region KnownInstr

        [Flags]
        private enum InstrFlags
        {
            None = 0,
            UseOprSizeInside = 1,
            UseAdrSizeInside = 2
        }

        private static Dictionary<ud_mnemonic_code, InstrFlags> KnownInstr = new Dictionary<ud_mnemonic_code, InstrFlags>
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
    }
}