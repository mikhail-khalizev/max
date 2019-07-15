using System;
using System.Collections.Generic;
using System.Text;
using MikhailKhalizev.Processor.x86.Abstractions;
using MikhailKhalizev.Processor.x86.Abstractions.Memory;
using MikhailKhalizev.Processor.x86.InstructionDecode;
using SharpDisasm.Udis86;

namespace MikhailKhalizev.Processor.x86.BinToCSharp.Plugin
{
    public class Switch : PluginBase
    {
        private int state;
        private Register reg;
        private ud_operand op;
        private int size_of_addr_area;

        /// <inheritdoc />
        public Switch(Engine engine)
            : base(engine)
        {
            Engine.InstructionDecoded += EngineOnInstructionDecoded;
        }

        private void EngineOnInstructionDecoded(object sender, Instruction cmd)
        {
#if false
    /* Pattern for: */

    II(0x10122c34, 0x4)   cmp(memb_a32(ss, ebp - 0x3c), 0x4);   /* cmp byte [ebp-0x3c], 0x4 */
2    II(0x10122c38, 0x2)   jad(0x10122c14, -0x26);               /* ja 0x10122c14 */
    II(0x10122c3a, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x10122c3c, 0x3)   mov(al, memb_a32(ss, ebp - 0x3c));    /* mov al, [ebp-0x3c] */
    II(0x10122c3f, 0x3)   shl(eax, 0x2);                        /* shl eax, 0x2 */
6    II(0x10122c42, 0x7)   jmpd_abs(memd_a32(cs, eax + 0x10122c18)); /* jmp dword near [cs:eax+0x10122c18] */

    II(0x10070886, 0x5)   cmp(memw_a32(ss, ebp - 0x2c), 0x3);   /* cmp word [ebp-0x2c], 0x3 */
2    II(0x1007088b, 0x2)   jad_func(0x1007086c, -0x21);          /* ja 0x1007086c */
    II(0x1007088d, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x1007088f, 0x4)   mov(ax, memw_a32(ss, ebp - 0x2c));    /* mov ax, [ebp-0x2c] */
    II(0x10070893, 0x3)   shl(eax, 0x2);                        /* shl eax, 0x2 */
6    II(0x10070896, 0x7)   jmpd_abs(memd_a32(cs, eax + 0x10070870)); /* jmp dword near [cs:eax+0x10070870] */

    II(0x1010fc44, 0x4)   cmp(memd_a32(ss, ebp - 0xc), 0x6);    /* cmp dword [ebp-0xc], 0x6 */
2    II(0x1010fc48, 0x2)   jad(0x1010fc24, -0x26);               /* ja 0x1010fc24 */
    II(0x1010fc4a, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x1010fc4d, 0x3)   shl(eax, 0x2);                        /* shl eax, 0x2 */
6    II(0x1010fc50, 0x7)   jmpd_abs(memd_a32(cs, eax + 0x1010fc28)); /* jmp dword near [cs:eax+0x1010fc28] */


    II(0x10172cc4, 0x3)   cmp(eax, 0x4);                        /* cmp eax, 0x4 */
7    II(0x10172cc7, 0x2)   jad(0x10172d26, 0x5d);                /* ja 0x10172d26 */
8    II(0x10172cc9, 0x8)   jmpd_abs(memd_a32(cs, eax * 0x4 + 0x10172ca4)); /* jmp dword near [cs:eax*4+0x10172ca4] */

    II(0x10196425, 0x2)   cmp(al, 0x3);                         /* cmp al, 0x3 */
7    II(0x10196427, 0x6)   jad(0x101964bc, 0x8f);                /* ja dword 0x101964bc */
8    II(0x1019642d, 0x3)   movzx(eax, al);                       /* movzx eax, al */
    II(0x10196430, 0x8)   jmpd_abs(memd_a32(cs, eax * 0x4 + 0x10196408)); /* jmp dword near [cs:eax*4+0x10196408] */

    II(0x10196098, 0x3)   cmp(cl, 0x8);                         /* cmp cl, 0x8 */
7    II(0x1019609b, 0x2)   jad_func(0x10196078, -0x25);          /* ja 0x10196078 */
8    II(0x1019609d, 0x3)   movzx(ecx, cl);                       /* movzx ecx, cl */
    II(0x101960a0, 0x3)   shl(ecx, 0x2);                        /* shl ecx, 0x2 */
6    II(0x101960a3, 0x7)   jmpd_abs(memd_a32(cs, ecx + 0x10195f48)); /* jmp dword near [cs:ecx+0x10195f48] */


      II(0x1017bab3, 0x3)   mov(ah, memb_a32(ss, ebp - 0xe));     /* mov ah, [ebp-0xe] */
      II(0x1017bab6, 0x3)   mov(memd_a32(ss, ebp - 0xc), esi);    /* mov [ebp-0xc], esi */
    II(0x1017bab9, 0x3)   cmp(ah, 0x11);                        /* cmp ah, 0x11 */
7    II(0x1017babc, 0x2)   jad(0x1017ba97, -0x27);               /* ja 0x1017ba97 */
8    II(0x1017babe, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x1017bac0, 0x3)   mov(al, memb_a32(ss, ebp - 0xe));     /* mov al, [ebp-0xe] */
    II(0x1017bac3, 0x8)   jmpd_abs(memd_a32(cs, eax * 0x4 + 0x1017b9e8)); /* jmp dword near [cs:eax*4+0x1017b9e8] */


    II(0x0015bae0, 0x3)   cmp(ax, 0x8);                         /* cmp ax, 0x8 */
7    II(0x0015bae3, 0x2)   jaw_func(0x0015bad9, -0xc);           /* ja 0x15bad9 */
8    II(0x0015bae5, 0x2)   shl(ax, 0x1);                         /* shl ax, 1 */
11    II(0x0015bae7, 0x1)   xchg(bx, ax);                         /* xchg bx, ax */
6    II(0x0015bae8, 0x5)   jmpw_abs(memw_a16(cs, bx + 0x66cd));  /* jmp word near [cs:bx+0x66cd] */

    II(0x001577d5, 0x3)   cmp(ax, 0x18);                        /* cmp ax, 0x18 */
7    II(0x001577d8, 0x2)   jbew(0x001577dd, 0x3);                /* jbe 0x1577dd */
12    II(0x001577da, 0x3)   jmpw_func(0x00157817, 0x3a);          /* jmp 0x157817 */
l_0x001577dd:
8    II(0x001577dd, 0x2)   shl(ax, 0x1);                         /* shl ax, 1 */
    II(0x001577df, 0x1)   xchg(bx, ax);                         /* xchg bx, ax */
    II(0x001577e0, 0x5)   jmpw_abs(memw_a16(cs, bx + 0x23c5));  /* jmp word near [cs:bx+0x23c5] */
#endif


            switch (state)
            {
                case 2:
                    if (cmd.Mnemonic == ud_mnemonic_code.UD_Ija)
                        state++;
                    else
                        state = 0;
                    break;

                case 3:
                    if (cmd.Mnemonic == ud_mnemonic_code.UD_Ixor
                        && cmd.Operands[0].type == ud_type.UD_OP_REG
                        && cmd.Operands[1].type == ud_type.UD_OP_REG
                        && cmd.Operands[0].@base == cmd.Operands[1].@base)
                    {
                        reg = Register.GetRegister(cmd.Operands[1].@base);
                        if (reg.IsGeneralPurpose)
                            state++;
                    }
                    else if (cmd.Mnemonic == ud_mnemonic_code.UD_Imov
                        && cmd.Operands[0].type == ud_type.UD_OP_REG)
                    {
                        reg = Register.GetRegister(cmd.Operands[0].@base);
                        if (reg.IsGeneralPurpose && reg.Size == 32 && Equals(cmd.Operands[1], op))
                            state = 5;
                    }

                    if (state == 3)
                        state = 0;

                    break;

                case 4:
                    if (cmd.Mnemonic == ud_mnemonic_code.UD_Imov
                        && cmd.Operands[0].type == ud_type.UD_OP_REG
                        && Register.GetRegister(cmd.Operands[0].@base) == reg
                        && Equals(cmd.Operands[1], op))
                        state++;
                    else
                        state = 0;
                    break;

                case 5:
                    if (cmd.Mnemonic == ud_mnemonic_code.UD_Ishl
                        && cmd.Operands[0].type == ud_type.UD_OP_REG
                        && Register.GetRegister(cmd.Operands[0].@base) == reg
                        && (cmd.Operands[1].type == ud_type.UD_OP_IMM)
                        && cmd.Operands[1].lval.uqword == (uint)Engine.Mode / 16)
                        state++;
                    else
                        state = 0;
                    break;

                case 6:
                    if (cmd.Mnemonic == ud_mnemonic_code.UD_Ijmp
                        && cmd.Operands[0].type == ud_type.UD_OP_MEM
                        && Register.GetRegister(cmd.Operands[0].@base) == reg)
                        add_switch_at(cmd);

                    state = 0;
                    break;


                case 7:
                    if (cmd.Mnemonic == ud_mnemonic_code.UD_Ija)
                        state++;
                    else if (cmd.Mnemonic == ud_mnemonic_code.UD_Ijbe)
                        state = 12;
                    else
                        state = 0;
                    break;

                case 8:
                    if (cmd.Mnemonic == ud_mnemonic_code.UD_Ijmp
                        && cmd.Operands[0].type == ud_type.UD_OP_MEM
                        //                && Register.GetRegister(cmd.Operands[0].index) == reg
                        && cmd.Operands[0].scale == 4)
                    {
                        add_switch_at(cmd);
                        state = 0;
                    }
                    else if (cmd.Mnemonic == ud_mnemonic_code.UD_Imovzx
                        && cmd.Operands[0].type == ud_type.UD_OP_REG
                        && cmd.Operands[1].type == ud_type.UD_OP_REG
                    //                && Register.GetRegister(cmd.Operands[0].@base) == reg
                    //                && Register.GetRegister(cmd.Operands[1].@base) == reg
                    )
                    {
                        state++;
                    }
                    else if (cmd.Mnemonic == ud_mnemonic_code.UD_Ixor
                        && cmd.Operands[0].type == ud_type.UD_OP_REG
                        && cmd.Operands[1].type == ud_type.UD_OP_REG
                        && cmd.Operands[0].@base == cmd.Operands[1].@base
                    //                && Register.GetRegister(cmd.Operands[0].@base) == reg
                    )
                    {
                        state = 10;
                    }
                    else if (cmd.Mnemonic == ud_mnemonic_code.UD_Ishl
                        && cmd.Operands[0].type == ud_type.UD_OP_REG
                        && Register.GetRegister(cmd.Operands[0].@base) == reg
                        && (cmd.Operands[1].type == ud_type.UD_OP_CONST)
                        && cmd.Operands[1].lval.uqword == (uint)Engine.Mode / 16)
                    {
                        state = 11;
                    }
                    else
                        state = 0;

                    break;

                case 9:
                    if (cmd.Mnemonic == ud_mnemonic_code.UD_Ijmp
                        && cmd.Operands[0].type == ud_type.UD_OP_MEM
                        //                && Register.GetRegister(cmd.Operands[0].index) == reg
                        && cmd.Operands[0].scale == 4)
                    {
                        add_switch_at(cmd);
                        state = 0;
                    }
                    else if (cmd.Mnemonic == ud_mnemonic_code.UD_Ishl
                        && cmd.Operands[0].type == ud_type.UD_OP_REG
                        //                && Register.GetRegister(cmd.Operands[0].@base) == reg
                        && (cmd.Operands[1].type == ud_type.UD_OP_IMM)
                        && cmd.Operands[1].lval.uqword == (uint)Engine.Mode / 16)
                        state = 6;
                    else
                        state = 0;

                    break;

                case 10:
                    if (cmd.Mnemonic == ud_mnemonic_code.UD_Imov
                        && cmd.Operands[0].type == ud_type.UD_OP_REG
                    //                && Register.GetRegister(cmd.Operands[0].@base) == reg
                    )
                        state = 9;
                    else
                        state = 0;
                    break;

                case 11:
                    if (cmd.Mnemonic == ud_mnemonic_code.UD_Ixchg
                        && Register.GetRegister(cmd.Operands[1].@base) == reg)
                    {
                        reg = Register.GetRegister(cmd.Operands[0].@base);
                        state = 6;
                    }
                    else
                        state = 0;

                    break;

                case 12:
                    if (cmd.Mnemonic == ud_mnemonic_code.UD_Ijmp)
                        state = 8;
                    else
                        state = 0;
                    break;

                default:
                    state = 0;
                    break;
            }


            if (state == 0
                && cmd.Mnemonic == ud_mnemonic_code.UD_Icmp
                && cmd.Operands[1].type == ud_type.UD_OP_IMM
                && cmd.Operands[1].size <= 16)
            {
                size_of_addr_area = (cmd.Operands[1].lval.uword + 1) * ((int)Engine.Mode / 8);

                if (cmd.Operands[0].type == ud_type.UD_OP_MEM)
                {
                    op = cmd.Operands[0]; // memb_a32(ss, ebp - 0x3c)
                    state = 2;
                }
                else if (cmd.Operands[0].type == ud_type.UD_OP_REG)
                {
                    reg = Register.GetRegister(cmd.Operands[0].@base);
                    state = 7;
                }
            }
        }

        private void add_switch_at(Instruction cmd)
        {
            if (cmd.BrFar)
                return;

            Address addrOfAddrs = Engine.CsBase + cmd.Operands[0].lval.udword;

            if ((addrOfAddrs & ((int)Engine.Mode / 8 - 1)) == 0)
                Engine.Aligment[addrOfAddrs] = (int)Engine.Mode / 8;

            var os = new StringBuilder();
            os.Append("Служебная область с абсолютными адресами переходов. {");

            var jtka = new JumpsToKnownAddresses(cmd.Begin);
            Engine.jmp_to_known_addr.Add(jtka);
            Engine.jmp_to_known_addr.TryGetValue(jtka, out jtka);

            var notFirst = false;
            for (Address i = 0; i < size_of_addr_area; i += (uint)Engine.Mode / 8)
            {
                Address to;
                switch ((int)Engine.Mode)
                {
                    case 16:
                        to = Engine.Memory.GetStruct<ushort>(addrOfAddrs + i);
                        break;
                    case 32:
                        to = Engine.Memory.GetStruct<uint>(addrOfAddrs + i);
                        break;
                    default:
                        throw new NotImplementedException();
                }

                to += Engine.CsBase;

                if (notFirst)
                    os.Append(", ");
                notFirst = true;
                os.Append(to);

                jtka.To.Add(to);
                Engine.AddressesToDecode.Add(to);
            }

            os.Append("}.");

            Engine.code.Insert(new Instruction(addrOfAddrs, addrOfAddrs + size_of_addr_area, os.ToString()));

            cmd.write_cmd = WriteCmd;
        }

        private string WriteCmd(Engine engine, DetectedMethod dm, int cmd_index, List<string> comments_in_current_func)
        {
            Engine.jmp_to_known_addr.TryGetValue(new JumpsToKnownAddresses(dm.Instructions[cmd_index].Begin), out var curJmp);
            if (curJmp == null)
                throw new NotImplementedException();

            var funcAddArg = new StringBuilder();

            foreach (var to in curJmp.To)
                if (dm.Labels.Contains(to))
                    funcAddArg.Append($"({to})");

            var funcSuffix = "";
            if (funcAddArg.Length != 0)
                funcSuffix = "_switch";

            return dm.Instructions[cmd_index].ToCodeString(funcSuffix, funcAddArg.ToString());
        }
    }
}