using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MikhailKhalizev.Processor.x86.Core.Abstractions.Memory;
using MikhailKhalizev.Processor.x86.Decoder;
using MikhailKhalizev.Processor.x86.Utils;
using SharpDisasm.Udis86;

namespace MikhailKhalizev.Processor.x86.BinToCSharp.Plugin
{
    public class SwitchPlugin : PluginBase
    {
        private int _state;
        private RegisterInfo _reg;
        private ud_operand _op;
        private Address _addrAreaBegin;
        private int _sizeOfAddrArea;

        /// <inheritdoc />
        public SwitchPlugin(Engine engine)
            : base(engine)
        {
            Engine.InstructionDecoded += EngineOnInstructionDecoded;
        }

        private void EngineOnInstructionDecoded(object sender, CSharpInstruction cmd)
        {
#if false
    /* Pattern for: */

    II(0x10122c34, 0x4)   cmp(memb_a32(ss, ebp - 0x3c), 0x4);   /* cmp byte [ebp-0x3c], 0x4 */
2   II(0x10122c38, 0x2)   jad(0x10122c14, -0x26);               /* ja 0x10122c14 */
    II(0x10122c3a, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x10122c3c, 0x3)   mov(al, memb_a32(ss, ebp - 0x3c));    /* mov al, [ebp-0x3c] */
    II(0x10122c3f, 0x3)   shl(eax, 0x2);                        /* shl eax, 0x2 */
6   II(0x10122c42, 0x7)   jmpd_abs(memd_a32(cs, eax + 0x10122c18)); /* jmp dword near [cs:eax+0x10122c18] */

    II(0x10070886, 0x5)   cmp(memw_a32(ss, ebp - 0x2c), 0x3);   /* cmp word [ebp-0x2c], 0x3 */
2   II(0x1007088b, 0x2)   jad_func(0x1007086c, -0x21);          /* ja 0x1007086c */
    II(0x1007088d, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x1007088f, 0x4)   mov(ax, memw_a32(ss, ebp - 0x2c));    /* mov ax, [ebp-0x2c] */
    II(0x10070893, 0x3)   shl(eax, 0x2);                        /* shl eax, 0x2 */
6   II(0x10070896, 0x7)   jmpd_abs(memd_a32(cs, eax + 0x10070870)); /* jmp dword near [cs:eax+0x10070870] */

    II(0x1010fc44, 0x4)   cmp(memd_a32(ss, ebp - 0xc), 0x6);    /* cmp dword [ebp-0xc], 0x6 */
2   II(0x1010fc48, 0x2)   jad(0x1010fc24, -0x26);               /* ja 0x1010fc24 */
    II(0x1010fc4a, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x1010fc4d, 0x3)   shl(eax, 0x2);                        /* shl eax, 0x2 */
6   II(0x1010fc50, 0x7)   jmpd_abs(memd_a32(cs, eax + 0x1010fc28)); /* jmp dword near [cs:eax+0x1010fc28] */


    II(0x10172cc4, 0x3)   cmp(eax, 0x4);                        /* cmp eax, 0x4 */
7   II(0x10172cc7, 0x2)   jad(0x10172d26, 0x5d);                /* ja 0x10172d26 */
8   II(0x10172cc9, 0x8)   jmpd_abs(memd_a32(cs, eax * 0x4 + 0x10172ca4)); /* jmp dword near [cs:eax*4+0x10172ca4] */

    II(0x10196425, 0x2)   cmp(al, 0x3);                         /* cmp al, 0x3 */
7   II(0x10196427, 0x6)   jad(0x101964bc, 0x8f);                /* ja dword 0x101964bc */
8   II(0x1019642d, 0x3)   movzx(eax, al);                       /* movzx eax, al */
    II(0x10196430, 0x8)   jmpd_abs(memd_a32(cs, eax * 0x4 + 0x10196408)); /* jmp dword near [cs:eax*4+0x10196408] */

    II(0x10196098, 0x3)   cmp(cl, 0x8);                         /* cmp cl, 0x8 */
7   II(0x1019609b, 0x2)   jad_func(0x10196078, -0x25);          /* ja 0x10196078 */
8   II(0x1019609d, 0x3)   movzx(ecx, cl);                       /* movzx ecx, cl */
    II(0x101960a0, 0x3)   shl(ecx, 0x2);                        /* shl ecx, 0x2 */
6   II(0x101960a3, 0x7)   jmpd_abs(memd_a32(cs, ecx + 0x10195f48)); /* jmp dword near [cs:ecx+0x10195f48] */


    II(0x1017bab3, 0x3)   mov(ah, memb_a32(ss, ebp - 0xe));     /* mov ah, [ebp-0xe] */
    II(0x1017bab6, 0x3)   mov(memd_a32(ss, ebp - 0xc), esi);    /* mov [ebp-0xc], esi */
    II(0x1017bab9, 0x3)   cmp(ah, 0x11);                        /* cmp ah, 0x11 */
7   II(0x1017babc, 0x2)   jad(0x1017ba97, -0x27);               /* ja 0x1017ba97 */
8   II(0x1017babe, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x1017bac0, 0x3)   mov(al, memb_a32(ss, ebp - 0xe));     /* mov al, [ebp-0xe] */
    II(0x1017bac3, 0x8)   jmpd_abs(memd_a32(cs, eax * 0x4 + 0x1017b9e8)); /* jmp dword near [cs:eax*4+0x1017b9e8] */

16-bit

    II(0x0015bae0, 0x3)   cmp(ax, 0x8);                         /* cmp ax, 0x8 */
7   II(0x0015bae3, 0x2)   jaw_func(0x0015bad9, -0xc);           /* ja 0x15bad9 */
8   II(0x0015bae5, 0x2)   shl(ax, 0x1);                         /* shl ax, 1 */
11  II(0x0015bae7, 0x1)   xchg(bx, ax);                         /* xchg bx, ax */
6   II(0x0015bae8, 0x5)   jmpw_abs(memw_a16(cs, bx + 0x66cd));  /* jmp word near [cs:bx+0x66cd] */

    II(0x001577d5, 0x3)   cmp(ax, 0x18);                        /* cmp ax, 0x18 */
7   II(0x001577d8, 0x2)   jbew(0x001577dd, 0x3);                /* jbe 0x1577dd */
12  II(0x001577da, 0x3)   jmpw_func(0x00157817, 0x3a);          /* jmp 0x157817 */
  l_0x001577dd:
8   II(0x001577dd, 0x2)   shl(ax, 0x1);                         /* shl ax, 1 */
    II(0x001577df, 0x1)   xchg(bx, ax);                         /* xchg bx, ax */
    II(0x001577e0, 0x5)   jmpw_abs(memw_a16(cs, bx + 0x23c5));  /* jmp word near [cs:bx+0x23c5] */
#endif

            switch (_state)
            {
                case 2:
                    if (cmd.Mnemonic == ud_mnemonic_code.UD_Ija)
                        _state++;
                    else
                        _state = 0;
                    break;

                case 3:
                    if (cmd.Mnemonic == ud_mnemonic_code.UD_Ixor
                        && cmd.Operands[0].type == ud_type.UD_OP_REG
                        && cmd.Operands[1].type == ud_type.UD_OP_REG
                        && cmd.Operands[0].@base == cmd.Operands[1].@base)
                    {
                        _reg = RegisterInfo.GetRegister(cmd.Operands[1].@base);
                        if (_reg.IsGeneralPurpose)
                            _state++;
                    }
                    else if (cmd.Mnemonic == ud_mnemonic_code.UD_Imov
                        && cmd.Operands[0].type == ud_type.UD_OP_REG)
                    {
                        _reg = RegisterInfo.GetRegister(cmd.Operands[0].@base);
                        if (_reg.IsGeneralPurpose && _reg.Size == 32 && Equals(cmd.Operands[1], _op))
                            _state = 5;
                    }

                    if (_state == 3)
                        _state = 0;

                    break;

                case 4:
                    if (cmd.Mnemonic == ud_mnemonic_code.UD_Imov
                        && cmd.Operands[0].type == ud_type.UD_OP_REG
                        && RegisterInfo.Intersects(cmd.Operands[0].@base, _reg.UdType)
                        && Equals(cmd.Operands[1], _op))
                        _state++;
                    else
                        _state = 0;
                    break;

                case 5:
                    if (cmd.Mnemonic == ud_mnemonic_code.UD_Ishl
                        && cmd.Operands[0].type == ud_type.UD_OP_REG
                        && RegisterInfo.GetRegister(cmd.Operands[0].@base) == _reg
                        && (cmd.Operands[1].type == ud_type.UD_OP_IMM)
                        && cmd.Operands[1].lval.uqword == (uint)Engine.Mode / 16)
                        _state++;
                    else
                        _state = 0;
                    break;

                case 6:
                    if (cmd.Mnemonic == ud_mnemonic_code.UD_Ijmp
                        && cmd.Operands[0].type == ud_type.UD_OP_MEM
                        && RegisterInfo.GetRegister(cmd.Operands[0].@base) == _reg)
                        add_switch_at(cmd);

                    _state = 0;
                    break;


                case 7:
                    if (cmd.Mnemonic == ud_mnemonic_code.UD_Ija)
                        _state++;
                    else if (cmd.Mnemonic == ud_mnemonic_code.UD_Ijbe)
                        _state = 12;
                    else
                        _state = 0;
                    break;

                case 8:
                    if (cmd.Mnemonic == ud_mnemonic_code.UD_Ijmp
                        && cmd.Operands[0].type == ud_type.UD_OP_MEM
                        //                && RegisterInfo.GetRegister(cmd.Operands[0].index) == reg
                        && cmd.Operands[0].scale == 4)
                    {
                        add_switch_at(cmd);
                        _state = 0;
                    }
                    else if (cmd.Mnemonic == ud_mnemonic_code.UD_Imovzx
                        && cmd.Operands[0].type == ud_type.UD_OP_REG
                        && cmd.Operands[1].type == ud_type.UD_OP_REG
                    //                && RegisterInfo.GetRegister(cmd.Operands[0].@base) == reg
                    //                && RegisterInfo.GetRegister(cmd.Operands[1].@base) == reg
                    )
                    {
                        _state++;
                    }
                    else if (cmd.Mnemonic == ud_mnemonic_code.UD_Ixor
                        && cmd.Operands[0].type == ud_type.UD_OP_REG
                        && cmd.Operands[1].type == ud_type.UD_OP_REG
                        && cmd.Operands[0].@base == cmd.Operands[1].@base
                    //                && RegisterInfo.GetRegister(cmd.Operands[0].@base) == reg
                    )
                    {
                        _state = 10;
                    }
                    else if (cmd.Mnemonic == ud_mnemonic_code.UD_Ishl
                        && cmd.Operands[0].type == ud_type.UD_OP_REG
                        && RegisterInfo.GetRegister(cmd.Operands[0].@base) == _reg
                        && (cmd.Operands[1].type == ud_type.UD_OP_CONST)
                        && cmd.Operands[1].lval.uqword == (uint)Engine.Mode / 16)
                    {
                        _state = 11;
                    }
                    else
                        _state = 0;

                    break;

                case 9:
                    if (cmd.Mnemonic == ud_mnemonic_code.UD_Ijmp
                        && cmd.Operands[0].type == ud_type.UD_OP_MEM
                        //                && RegisterInfo.GetRegister(cmd.Operands[0].index) == reg
                        && cmd.Operands[0].scale == 4)
                    {
                        add_switch_at(cmd);
                        _state = 0;
                    }
                    else if (cmd.Mnemonic == ud_mnemonic_code.UD_Ishl
                        && cmd.Operands[0].type == ud_type.UD_OP_REG
                        //                && RegisterInfo.GetRegister(cmd.Operands[0].@base) == reg
                        && (cmd.Operands[1].type == ud_type.UD_OP_IMM)
                        && cmd.Operands[1].lval.uqword == (uint)Engine.Mode / 16)
                        _state = 6;
                    else
                        _state = 0;

                    break;

                case 10:
                    if (cmd.Mnemonic == ud_mnemonic_code.UD_Imov
                        && cmd.Operands[0].type == ud_type.UD_OP_REG
                    //                && RegisterInfo.GetRegister(cmd.Operands[0].@base) == reg
                    )
                        _state = 9;
                    else
                        _state = 0;
                    break;

                case 11:
                    if (cmd.Mnemonic == ud_mnemonic_code.UD_Ixchg
                        && RegisterInfo.GetRegister(cmd.Operands[1].@base) == _reg)
                    {
                        _reg = RegisterInfo.GetRegister(cmd.Operands[0].@base);
                        _state = 6;
                    }
                    else
                        _state = 0;

                    break;

                case 12:
                    if (cmd.Mnemonic == ud_mnemonic_code.UD_Ijmp)
                        _state = 8;
                    else
                        _state = 0;
                    break;

                default:
                    _state = 0;
                    break;
            }


            if (_state == 0
                && cmd.Mnemonic == ud_mnemonic_code.UD_Icmp
                && cmd.Operands[1].type == ud_type.UD_OP_IMM
                && cmd.Operands[1].size <= 16)
            {
                _sizeOfAddrArea = (cmd.Operands[1].lval.uword + 1) * ((int)Engine.Mode / 8);

                if (cmd.Operands[0].type == ud_type.UD_OP_MEM)
                {
                    _op = cmd.Operands[0]; // memb_a32(ss, ebp - 0x3c)
                    _state = 2;
                }
                else if (cmd.Operands[0].type == ud_type.UD_OP_REG)
                {
                    _reg = RegisterInfo.GetRegister(cmd.Operands[0].@base);
                    _state = 7;
                }
            }
        }

        private void add_switch_at(CSharpInstruction cmd)
        {
            if (cmd.BrFar)
                return;

            Address addrOfAddrs = Engine.CsBase + cmd.Operands[0].lval.udword;
            _addrAreaBegin = addrOfAddrs;

            var os = new StringBuilder();
            os.Append("Служебная область с абсолютными адресами переходов. (");

            Engine.BrunchesInfo.TryGetValue(new BrunchInfo(cmd.Begin), out var jtka);
            if (jtka == null)
            {
                jtka = new BrunchInfo(cmd.Begin);
                jtka.To = new SortedSet<Address>();
                Engine.BrunchesInfo.Add(jtka);
            }

            var notFirst = false;
            for (Address i = 0; i < _sizeOfAddrArea; i += (uint)Engine.Mode / 8)
            {
                Address to;
                switch ((int)Engine.Mode)
                {
                    case 16:
                        to = Engine.Memory.GetFixSize(addrOfAddrs + i, 2).GetUInt16();
                        break;
                    case 32:
                        to = Engine.Memory.GetFixSize(addrOfAddrs + i, 4).GetUInt32();
                        break;
                    default:
                        throw new NotImplementedException($"Engine.Mode: {(int)Engine.Mode}.");
                }

                to += Engine.CsBase;

                if (notFirst)
                    os.Append(", ");
                notFirst = true;
                os.Append(to.ToString());

                jtka.To.Add(to);
                Engine.AddToDecode(to);
            }

            os.Append(").");

            Engine.DecodedCode.Insert(new CSharpInstruction(addrOfAddrs, addrOfAddrs + _sizeOfAddrArea, os.ToString()));

            var copyAddrAreaBegin = _addrAreaBegin;
            var copySizeOfAddrArea = _sizeOfAddrArea;
            cmd.WriteCmd = (engine, dm, index, func, offset) => WriteCmd(copyAddrAreaBegin, copySizeOfAddrArea, engine, dm, index, func, offset);
        }

        private static string WriteCmd(
            Address addrAreaBegin, int sizeOfAddrArea,
            Engine engine, DetectedMethod dm, int cmdIndex, List<string> commentsInCurrentFunc, int offset)
        {
            var raw = engine.Memory.ReadAll(addrAreaBegin, sizeOfAddrArea);
            engine.MethodInfoCollection.AddExtraRaw(dm.MethodInfo, addrAreaBegin, raw);

            engine.BrunchesInfo.TryGetValue(new BrunchInfo(dm.Instructions[cmdIndex].Begin), out var curJmp);
            if (curJmp == null)
                throw new NotImplementedException("curJmp == null");

            var funcAddArg = new StringBuilder();

            foreach (var to in curJmp.To)
            {
                if (!dm.Labels.Contains(to))
                {
                    NonBlockingConsole.WriteLine(
                        "Не все метки switch находятся внутри одного метода " +
                        "(видимо не удалось разбить код на методы так, чтобы switch целиком находился внутри метода). " +
                        $"Method.Id = {dm.MethodInfo.Id}.");
                    return dm.Instructions[cmdIndex].ToCodeString();
                }
                funcAddArg.Append($"({to})");
            }

            if (curJmp.To.Count == 0)
                throw new NotImplementedException("curJmp.To.Count == 0");
            var funcSuffix = "_switch";

            if (!dm.Instructions[cmdIndex].IsLocalBranch)
                throw new InvalidOperationException($"Должно быть уже заполнено в {nameof(Engine)}.{nameof(Engine.DetectMethods)}.");

            var str = dm.Instructions[cmdIndex].ToCodeString(funcSuffix, "", offset: offset);

            var lines = new[]
                {
                    $"            switch ({str.TrimEnd(';')})",
                    "            {"
                }
                .Concat(curJmp.To.SelectMany(
                    to =>
                    {
                        if (!dm.Labels.Contains(to))
                            throw new NotImplementedException("!dm.Labels.Contains(to) 2");

                        return
                            new[]
                            {
                                $"                case {to}:",
                                $"                    goto l_{to};"
                            };
                    }))
                .Concat(
                    new[]
                    {
                        "                default:",
                        "                    throw new NotImplementedException();",
                        "            }"
                    });

            return Environment.NewLine + string.Join(Environment.NewLine, lines);
        }
    }
}