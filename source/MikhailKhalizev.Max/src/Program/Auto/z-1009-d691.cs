using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_d691-21d7f418")]
        public void Method_1009_d691()
        {
            ii(0x1009_d691, 5); push(0x94);                             /* push 0x94 */
            ii(0x1009_d696, 5); call(Definitions.sys_check_available_stack_size, 0xc_86b7); /* call 0x10165d52 */
            ii(0x1009_d69b, 1); push(ebx);                              /* push ebx */
            ii(0x1009_d69c, 1); push(ecx);                              /* push ecx */
            ii(0x1009_d69d, 1); push(edx);                              /* push edx */
            ii(0x1009_d69e, 1); push(esi);                              /* push esi */
            ii(0x1009_d69f, 1); push(edi);                              /* push edi */
            ii(0x1009_d6a0, 1); push(ebp);                              /* push ebp */
            ii(0x1009_d6a1, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_d6a3, 6); sub(esp, 0x74);                         /* sub esp, 0x74 */
            ii(0x1009_d6a9, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1009_d6ac, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1009_d6af, 5); call(Definitions.my_ctor_0x101b_4184, -0x2_6bc4); /* call 0x10076af0 */
            ii(0x1009_d6b4, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1009_d6b7, 5); call(Definitions.my_ctor_0x101b_4184, -0x2_6bcc); /* call 0x10076af0 */
            ii(0x1009_d6bc, 5); mov(eax, memd[ds, 0x101c_8172]);        /* mov eax, [0x101c8172] */
            ii(0x1009_d6c1, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_d6c4, 1); push(eax);                              /* push eax */
            ii(0x1009_d6c5, 6); mov(ecx, memd[ds, 0x101c_8170]);        /* mov ecx, [0x101c8170] */
            ii(0x1009_d6cb, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x1009_d6ce, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1009_d6d0, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_d6d2, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x1009_d6d5, 5); call(0x1008_b148, -0x1_2592);           /* call 0x1008b148 */
            ii(0x1009_d6da, 7); mov(memd[ss, ebp - 0x10], 0);           /* mov dword [ebp-0x10], 0x0 */
            ii(0x1009_d6e1, 7); mov(memd[ss, ebp - 0x14], 0xffff_ffff); /* mov dword [ebp-0x14], 0xffffffff */
            ii(0x1009_d6e8, 7); mov(memd[ss, ebp - 0x20], 0);           /* mov dword [ebp-0x20], 0x0 */
            ii(0x1009_d6ef, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_d6f2, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1009_d6f5, 5); call(0x1007_6574, -0x2_7186);           /* call 0x10076574 */
            ii(0x1009_d6fa, 3); mov(eax, memd[ds, eax + 0x6]);          /* mov eax, [eax+0x6] */
            ii(0x1009_d6fd, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_d700, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x1009_d703, 7); test(memb[ds, eax + 0x101c_81d4], 0x2); /* test byte [eax+0x101c81d4], 0x2 */
            ii(0x1009_d70a, 2); if(jz(0x1009_d715, 0x9)) goto l_0x1009_d715; /* jz 0x1009d715 */
            ii(0x1009_d70c, 7); mov(memd[ss, ebp - 0x14], 0xffff_ffff); /* mov dword [ebp-0x14], 0xffffffff */
            ii(0x1009_d713, 2); jmp(0x1009_d71c, 0x7); goto l_0x1009_d71c; /* jmp 0x1009d71c */
        l_0x1009_d715:
            ii(0x1009_d715, 7); mov(memd[ss, ebp - 0x14], 0x4e);        /* mov dword [ebp-0x14], 0x4e */
        l_0x1009_d71c:
            ii(0x1009_d71c, 4); or(memb[ss, ebp - 0xc], 0x1);           /* or byte [ebp-0xc], 0x1 */
            ii(0x1009_d720, 4); movsx(eax, memw[ss, ebp - 0x14]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1009_d724, 3); mov(memd[ss, ebp - 0x3c], eax);         /* mov [ebp-0x3c], eax */
            ii(0x1009_d727, 3); push(memd[ss, ebp - 0x3c]);             /* push dword [ebp-0x3c] */
            ii(0x1009_d72a, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_d72d, 4); cmp(memb[ds, eax + 0x3e], 0);           /* cmp byte [eax+0x3e], 0x0 */
            ii(0x1009_d731, 2); if(jz(0x1009_d739, 0x6)) goto l_0x1009_d739; /* jz 0x1009d739 */
            ii(0x1009_d733, 4); mov(memb[ss, ebp - 0x40], 0);           /* mov byte [ebp-0x40], 0x0 */
            ii(0x1009_d737, 2); jmp(0x1009_d73d, 0x4); goto l_0x1009_d73d; /* jmp 0x1009d73d */
        l_0x1009_d739:
            ii(0x1009_d739, 4); mov(memb[ss, ebp - 0x40], 0x3);         /* mov byte [ebp-0x40], 0x3 */
        l_0x1009_d73d:
            ii(0x1009_d73d, 3); mov(ecx, memd[ss, ebp - 0x43]);         /* mov ecx, [ebp-0x43] */
            ii(0x1009_d740, 3); sar(ecx, 0x18);                         /* sar ecx, 0x18 */
            ii(0x1009_d743, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1009_d748, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_d74b, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1009_d74e, 5); call(0x1007_65d0, -0x2_7183);           /* call 0x100765d0 */
            ii(0x1009_d753, 3); lea(esi, ebp - 0x50);                   /* lea esi, [ebp-0x50] */
            ii(0x1009_d756, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_d758, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1009_d75a, 5); call(0x1011_fec1, 0x8_2762);            /* call 0x1011fec1 */
            ii(0x1009_d75f, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1009_d762, 4); and(memb[ss, ebp - 0xc], -0x2 /* 0xfe */); /* and byte [ebp-0xc], 0xfe */
            ii(0x1009_d766, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_d769, 4); cmp(memb[ds, eax + 0x3e], 0);           /* cmp byte [eax+0x3e], 0x0 */
            ii(0x1009_d76d, 2); if(jnz(0x1009_d7a4, 0x35)) goto l_0x1009_d7a4; /* jnz 0x1009d7a4 */
            ii(0x1009_d76f, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x1009_d774, 5); mov(ebx, 0x3);                          /* mov ebx, 0x3 */
            ii(0x1009_d779, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_d77c, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1009_d77f, 5); call(0x1007_65d0, -0x2_71b4);           /* call 0x100765d0 */
            ii(0x1009_d784, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_d786, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_d789, 3); mov(eax, memd[ds, eax + 0x7]);          /* mov eax, [eax+0x7] */
            ii(0x1009_d78c, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_d78f, 6); imul(esi, eax, 0xc5);                   /* imul esi, eax, 0xc5 */
            ii(0x1009_d795, 5); mov(eax, 0x101c_31c4);                  /* mov eax, 0x101c31c4 */
            ii(0x1009_d79a, 2); add(eax, esi);                          /* add eax, esi */
            ii(0x1009_d79c, 5); call(0x100c_1fd4, 0x2_4833);            /* call 0x100c1fd4 */
            ii(0x1009_d7a1, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
        l_0x1009_d7a4:
            ii(0x1009_d7a4, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_d7a7, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1009_d7aa, 5); call(0x1007_6574, -0x2_723b);           /* call 0x10076574 */
            ii(0x1009_d7af, 4); mov(ax, memw[ds, eax + 0x1a]);          /* mov ax, [eax+0x1a] */
            ii(0x1009_d7b3, 4); mov(memw[ss, ebp - 0x28], ax);          /* mov [ebp-0x28], ax */
            ii(0x1009_d7b7, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_d7ba, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1009_d7bd, 5); call(0x1007_6574, -0x2_724e);           /* call 0x10076574 */
            ii(0x1009_d7c2, 4); mov(ax, memw[ds, eax + 0x1c]);          /* mov ax, [eax+0x1c] */
            ii(0x1009_d7c6, 4); mov(memw[ss, ebp - 0x26], ax);          /* mov [ebp-0x26], ax */
        l_0x1009_d7ca:
            ii(0x1009_d7ca, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1009_d7cf, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1009_d7d2, 4); sub(ax, memw[ds, edx + 0x21]);          /* sub ax, [edx+0x21] */
            ii(0x1009_d7d6, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1009_d7d9, 4); mov(memw[ds, edx + 0x21], ax);          /* mov [edx+0x21], ax */
            ii(0x1009_d7dd, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_d7e0, 4); neg(memw[ds, eax + 0x3b]);              /* neg word [eax+0x3b] */
            ii(0x1009_d7e4, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_d7e7, 3); mov(eax, memd[ds, eax + 0x1f]);         /* mov eax, [eax+0x1f] */
            ii(0x1009_d7ea, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_d7ed, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1009_d7ef, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1009_d7f2, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1009_d7f4, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_d7f7, 4); mov(ax, memw[ds, eax + 0x3b]);          /* mov ax, [eax+0x3b] */
            ii(0x1009_d7fb, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1009_d7fd, 4); mov(dx, memw[ds, edx + 0x2b]);          /* mov dx, [edx+0x2b] */
            ii(0x1009_d801, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1009_d803, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1009_d805, 5); and(eax, 0x7);                          /* and eax, 0x7 */
            ii(0x1009_d80a, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_d80c, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_d80f, 3); mov(eax, memd[ds, eax + 0x1f]);         /* mov eax, [eax+0x1f] */
            ii(0x1009_d812, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_d815, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1009_d817, 3); add(eax, memd[ss, ebp - 0x4]);          /* add eax, [ebp-0x4] */
            ii(0x1009_d81a, 4); mov(memw[ds, eax + 0x2b], dx);          /* mov [eax+0x2b], dx */
            ii(0x1009_d81e, 7); mov(memd[ss, ebp - 0x18], 0);           /* mov dword [ebp-0x18], 0x0 */
        l_0x1009_d825:
            ii(0x1009_d825, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_d828, 3); mov(eax, memd[ds, eax + 0x1f]);         /* mov eax, [eax+0x1f] */
            ii(0x1009_d82b, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_d82e, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1009_d830, 3); add(eax, memd[ss, ebp - 0x4]);          /* add eax, [ebp-0x4] */
            ii(0x1009_d833, 4); mov(ax, memw[ds, eax + 0x2b]);          /* mov ax, [eax+0x2b] */
            ii(0x1009_d837, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1009_d83a, 4); add(ax, memw[ds, edx + 0x3b]);          /* add ax, [edx+0x3b] */
            ii(0x1009_d83e, 5); and(eax, 0x7);                          /* and eax, 0x7 */
            ii(0x1009_d843, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_d845, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_d848, 3); mov(eax, memd[ds, eax + 0x1f]);         /* mov eax, [eax+0x1f] */
            ii(0x1009_d84b, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_d84e, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1009_d850, 3); add(eax, memd[ss, ebp - 0x4]);          /* add eax, [ebp-0x4] */
            ii(0x1009_d853, 4); mov(memw[ds, eax + 0x2b], dx);          /* mov [eax+0x2b], dx */
            ii(0x1009_d857, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_d85a, 3); mov(eax, memd[ds, eax + 0x1f]);         /* mov eax, [eax+0x1f] */
            ii(0x1009_d85d, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_d860, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1009_d863, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1009_d866, 3); add(edx, 0x23);                         /* add edx, 0x23 */
            ii(0x1009_d869, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1009_d86b, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1009_d86e, 5); call(0x1008_8b44, -0x1_4d2f);           /* call 0x10088b44 */
            ii(0x1009_d873, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_d876, 3); mov(eax, memd[ds, eax + 0x1f]);         /* mov eax, [eax+0x1f] */
            ii(0x1009_d879, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_d87c, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1009_d87e, 3); add(eax, memd[ss, ebp - 0x4]);          /* add eax, [ebp-0x4] */
            ii(0x1009_d881, 3); mov(eax, memd[ds, eax + 0x29]);         /* mov eax, [eax+0x29] */
            ii(0x1009_d884, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_d887, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1009_d88a, 5); mov(edx, 0x101c_5348);                  /* mov edx, 0x101c5348 */
            ii(0x1009_d88f, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1009_d891, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1009_d894, 5); call(0x1008_b1a4, -0x1_26f5);           /* call 0x1008b1a4 */
            ii(0x1009_d899, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1009_d89c, 3); inc(memd[ss, ebp - 0x18]);              /* inc dword [ebp-0x18] */
            ii(0x1009_d89f, 1); cwde();                                 /* cwde */
            ii(0x1009_d8a0, 3); cmp(eax, 0x8);                          /* cmp eax, 0x8 */
            ii(0x1009_d8a3, 2); if(jl(0x1009_d8b8, 0x13)) goto l_0x1009_d8b8; /* jl 0x1009d8b8 */
            ii(0x1009_d8a5, 4); mov(memb[ss, ebp - 0x8], 0);            /* mov byte [ebp-0x8], 0x0 */
            ii(0x1009_d8a9, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_d8ab, 3); lea(eax, ebp - 0x50);                   /* lea eax, [ebp-0x50] */
            ii(0x1009_d8ae, 5); call(Definitions.my_dtor_d1, -0x1_4bb7); /* call 0x10088cfc */
            ii(0x1009_d8b3, 5); jmp(0x1009_db15, 0x25d); goto l_0x1009_db15; /* jmp 0x1009db15 */
        l_0x1009_d8b8:
            ii(0x1009_d8b8, 3); lea(edx, ebp - 0x28);                   /* lea edx, [ebp-0x28] */
            ii(0x1009_d8bb, 3); lea(eax, ebp - 0x54);                   /* lea eax, [ebp-0x54] */
            ii(0x1009_d8be, 5); call(0x1007_5e64, -0x2_7a5f);           /* call 0x10075e64 */
            ii(0x1009_d8c3, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1009_d8c5, 3); lea(edx, ebp - 0x24);                   /* lea edx, [ebp-0x24] */
            ii(0x1009_d8c8, 3); lea(eax, ebp - 0x58);                   /* lea eax, [ebp-0x58] */
            ii(0x1009_d8cb, 5); call(0x1007_5e64, -0x2_7a6c);           /* call 0x10075e64 */
            ii(0x1009_d8d0, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x1009_d8d2, 5); call(0x100a_5fca, 0x86f3);              /* call 0x100a5fca */
            ii(0x1009_d8d7, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1009_d8da, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1009_d8dc, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1009_d8df, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1009_d8e1, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x1009_d8e3, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1009_d8e6, 3); mov(edx, memd[ds, edx + 0x35]);         /* mov edx, [edx+0x35] */
            ii(0x1009_d8e9, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1009_d8ec, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x1009_d8ee, 6); if(jnz(0x1009_d825, -0xcf)) goto l_0x1009_d825; /* jnz 0x1009d825 */
            ii(0x1009_d8f4, 3); lea(edx, ebp - 0x24);                   /* lea edx, [ebp-0x24] */
            ii(0x1009_d8f7, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_d8fa, 3); mov(eax, memd[ds, eax + 0x1f]);         /* mov eax, [eax+0x1f] */
            ii(0x1009_d8fd, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_d900, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1009_d903, 3); mov(ebx, memd[ss, ebp - 0x4]);          /* mov ebx, [ebp-0x4] */
            ii(0x1009_d906, 3); add(ebx, 0x23);                         /* add ebx, 0x23 */
            ii(0x1009_d909, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1009_d90b, 5); call(0x1008_8b44, -0x1_4dcc);           /* call 0x10088b44 */
            ii(0x1009_d910, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1009_d913, 3); inc(memd[ss, ebp - 0x10]);              /* inc dword [ebp-0x10] */
            ii(0x1009_d916, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_d919, 3); mov(eax, memd[ds, eax + 0x1f]);         /* mov eax, [eax+0x1f] */
            ii(0x1009_d91c, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_d91f, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1009_d922, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1009_d925, 3); add(edx, 0x23);                         /* add edx, 0x23 */
            ii(0x1009_d928, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1009_d92a, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x1009_d92d, 5); call(0x1010_82ce, 0x6_a99c);            /* call 0x101082ce */
            ii(0x1009_d932, 2); test(al, al);                           /* test al, al */
            ii(0x1009_d934, 6); if(jz(0x1009_da0b, 0xd1)) goto l_0x1009_da0b; /* jz 0x1009da0b */
            ii(0x1009_d93a, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_d93d, 4); mov(memb[ds, eax + 0x3d], 0x1);         /* mov byte [eax+0x3d], 0x1 */
            ii(0x1009_d941, 4); cmp(memd[ss, ebp - 0x20], 0);           /* cmp dword [ebp-0x20], 0x0 */
            ii(0x1009_d945, 2); if(jz(0x1009_d98b, 0x44)) goto l_0x1009_d98b; /* jz 0x1009d98b */
            ii(0x1009_d947, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_d94a, 3); mov(eax, memd[ds, eax + 0x1f]);         /* mov eax, [eax+0x1f] */
            ii(0x1009_d94d, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_d950, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1009_d953, 3); add(eax, memd[ss, ebp - 0x4]);          /* add eax, [ebp-0x4] */
            ii(0x1009_d956, 3); mov(eax, memd[ds, eax + 0x21]);         /* mov eax, [eax+0x21] */
            ii(0x1009_d959, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_d95c, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1009_d95f, 3); mov(edx, memd[ss, ebp - 0x20]);         /* mov edx, [ebp-0x20] */
            ii(0x1009_d962, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1009_d964, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_d967, 3); mov(eax, memd[ds, eax + 0x1f]);         /* mov eax, [eax+0x1f] */
            ii(0x1009_d96a, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_d96d, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1009_d970, 3); add(eax, memd[ss, ebp - 0x4]);          /* add eax, [ebp-0x4] */
            ii(0x1009_d973, 3); mov(eax, memd[ds, eax + 0x23]);         /* mov eax, [eax+0x23] */
            ii(0x1009_d976, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_d979, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1009_d97b, 2); mov(edx, memd[ds, edx]);                /* mov edx, [edx] */
            ii(0x1009_d97d, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1009_d97f, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x1009_d982, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1009_d985, 6); if(jge(0x1009_da0b, 0x80)) goto l_0x1009_da0b; /* jge 0x1009da0b */
        l_0x1009_d98b:
            ii(0x1009_d98b, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_d98e, 3); mov(eax, memd[ds, eax + 0x1f]);         /* mov eax, [eax+0x1f] */
            ii(0x1009_d991, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_d994, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1009_d997, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1009_d99a, 3); add(edx, 0x23);                         /* add edx, 0x23 */
            ii(0x1009_d99d, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1009_d99f, 3); lea(eax, ebp - 0x5c);                   /* lea eax, [ebp-0x5c] */
            ii(0x1009_d9a2, 5); call(0x1007_5e64, -0x2_7b43);           /* call 0x10075e64 */
            ii(0x1009_d9a7, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1009_d9a9, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_d9ac, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1009_d9af, 5); call(0x1007_65d0, -0x2_73e4);           /* call 0x100765d0 */
            ii(0x1009_d9b4, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_d9b6, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_d9b9, 5); call(0x1009_dfcf, 0x611);               /* call 0x1009dfcf */
            ii(0x1009_d9be, 2); test(al, al);                           /* test al, al */
            ii(0x1009_d9c0, 2); if(jz(0x1009_d9ee, 0x2c)) goto l_0x1009_d9ee; /* jz 0x1009d9ee */
            ii(0x1009_d9c2, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_d9c5, 3); mov(edx, memd[ds, eax + 0x1f]);         /* mov edx, [eax+0x1f] */
            ii(0x1009_d9c8, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1009_d9cb, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x1009_d9ce, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_d9d1, 3); add(eax, 0x23);                         /* add eax, 0x23 */
            ii(0x1009_d9d4, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1009_d9d6, 3); lea(eax, ebp - 0x60);                   /* lea eax, [ebp-0x60] */
            ii(0x1009_d9d9, 5); call(0x1007_5e64, -0x2_7b7a);           /* call 0x10075e64 */
            ii(0x1009_d9de, 3); lea(ebx, ebp - 0x50);                   /* lea ebx, [ebp-0x50] */
            ii(0x1009_d9e1, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_d9e3, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1009_d9e5, 5); call(0x1011_ff4c, 0x8_2562);            /* call 0x1011ff4c */
            ii(0x1009_d9ea, 2); test(al, al);                           /* test al, al */
            ii(0x1009_d9ec, 2); if(jnz(0x1009_d9f0, 0x2)) goto l_0x1009_d9f0; /* jnz 0x1009d9f0 */
        l_0x1009_d9ee:
            ii(0x1009_d9ee, 2); jmp(0x1009_da0b, 0x1b); goto l_0x1009_da0b; /* jmp 0x1009da0b */
        l_0x1009_d9f0:
            ii(0x1009_d9f0, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_d9f3, 5); call(0x1009_db21, 0x129);               /* call 0x1009db21 */
            ii(0x1009_d9f8, 4); mov(memb[ss, ebp - 0x8], 0x1);          /* mov byte [ebp-0x8], 0x1 */
            ii(0x1009_d9fc, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_d9fe, 3); lea(eax, ebp - 0x50);                   /* lea eax, [ebp-0x50] */
            ii(0x1009_da01, 5); call(Definitions.my_dtor_d1, -0x1_4d0a); /* call 0x10088cfc */
            ii(0x1009_da06, 5); jmp(0x1009_db15, 0x10a); goto l_0x1009_db15; /* jmp 0x1009db15 */
        l_0x1009_da0b:
            ii(0x1009_da0b, 5); call(0x1014_82f4, 0xa_a8e4);            /* call 0x101482f4 */
            ii(0x1009_da10, 6); sub(eax, memd[ds, 0x101c_3974]);        /* sub eax, [0x101c3974] */
            ii(0x1009_da16, 6); cmp(eax, memd[ds, 0x101b_dd84]);        /* cmp eax, [0x101bdd84] */
            ii(0x1009_da1c, 2); if(jb(0x1009_da27, 0x9)) goto l_0x1009_da27; /* jb 0x1009da27 */
            ii(0x1009_da1e, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1009_da22, 3); cmp(eax, 0x14);                         /* cmp eax, 0x14 */
            ii(0x1009_da25, 2); if(jg(0x1009_da29, 0x2)) goto l_0x1009_da29; /* jg 0x1009da29 */
        l_0x1009_da27:
            ii(0x1009_da27, 2); jmp(0x1009_da9a, 0x71); goto l_0x1009_da9a; /* jmp 0x1009da9a */
        l_0x1009_da29:
            ii(0x1009_da29, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_da2c, 5); call(0x1008_ad28, -0x1_2d09);           /* call 0x1008ad28 */
            ii(0x1009_da31, 2); test(al, al);                           /* test al, al */
            ii(0x1009_da33, 2); if(jnz(0x1009_da87, 0x52)) goto l_0x1009_da87; /* jnz 0x1009da87 */
            ii(0x1009_da35, 5); call(0x1008_a7bc, -0x1_327e);           /* call 0x1008a7bc */
            ii(0x1009_da3a, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1009_da3f, 3); mov(memd[ss, ebp - 0x64], eax);         /* mov [ebp-0x64], eax */
            ii(0x1009_da42, 5); mov(eax, 0xa);                          /* mov eax, 0xa */
            ii(0x1009_da47, 5); call(Definitions.sys_new, 0xc_83b4);    /* call 0x10165e00 */
            ii(0x1009_da4c, 3); mov(memd[ss, ebp - 0x68], eax);         /* mov [ebp-0x68], eax */
            ii(0x1009_da4f, 3); mov(eax, memd[ss, ebp - 0x68]);         /* mov eax, [ebp-0x68] */
            ii(0x1009_da52, 3); mov(memd[ss, ebp - 0x6c], eax);         /* mov [ebp-0x6c], eax */
            ii(0x1009_da55, 4); cmp(memd[ss, ebp - 0x6c], 0);           /* cmp dword [ebp-0x6c], 0x0 */
            ii(0x1009_da59, 2); if(jz(0x1009_da71, 0x16)) goto l_0x1009_da71; /* jz 0x1009da71 */
            ii(0x1009_da5b, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1009_da5e, 3); mov(eax, memd[ss, ebp - 0x68]);         /* mov eax, [ebp-0x68] */
            ii(0x1009_da61, 5); call(Definitions.my_ctor_c11, 0x5e63);  /* call 0x100a38c9 */
            ii(0x1009_da66, 3); mov(memd[ss, ebp - 0x70], eax);         /* mov [ebp-0x70], eax */
            ii(0x1009_da69, 3); mov(eax, memd[ss, ebp - 0x70]);         /* mov eax, [ebp-0x70] */
            ii(0x1009_da6c, 3); mov(memd[ss, ebp - 0x74], eax);         /* mov [ebp-0x74], eax */
            ii(0x1009_da6f, 2); jmp(0x1009_da77, 0x6); goto l_0x1009_da77; /* jmp 0x1009da77 */
        l_0x1009_da71:
            ii(0x1009_da71, 3); mov(eax, memd[ss, ebp - 0x6c]);         /* mov eax, [ebp-0x6c] */
            ii(0x1009_da74, 3); mov(memd[ss, ebp - 0x74], eax);         /* mov [ebp-0x74], eax */
        l_0x1009_da77:
            ii(0x1009_da77, 3); mov(edx, memd[ss, ebp - 0x74]);         /* mov edx, [ebp-0x74] */
            ii(0x1009_da7a, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1009_da7f, 3); mov(ebx, memd[ss, ebp - 0x64]);         /* mov ebx, [ebp-0x64] */
            ii(0x1009_da82, 5); call(0x100a_4db6, 0x732f);              /* call 0x100a4db6 */
        l_0x1009_da87:
            ii(0x1009_da87, 4); mov(memb[ss, ebp - 0x8], 0x1);          /* mov byte [ebp-0x8], 0x1 */
            ii(0x1009_da8b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_da8d, 3); lea(eax, ebp - 0x50);                   /* lea eax, [ebp-0x50] */
            ii(0x1009_da90, 5); call(Definitions.my_dtor_d1, -0x1_4d99); /* call 0x10088cfc */
            ii(0x1009_da95, 5); jmp(0x1009_db15, 0x7b); goto l_0x1009_db15; /* jmp 0x1009db15 */
        l_0x1009_da9a:
            ii(0x1009_da9a, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_da9d, 3); mov(eax, memd[ds, eax + 0x1f]);         /* mov eax, [eax+0x1f] */
            ii(0x1009_daa0, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_daa3, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1009_daa6, 3); add(eax, memd[ss, ebp - 0x4]);          /* add eax, [ebp-0x4] */
            ii(0x1009_daa9, 4); mov(dx, memw[ds, eax + 0x23]);          /* mov dx, [eax+0x23] */
            ii(0x1009_daad, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_dab0, 4); cmp(dx, memw[ds, eax + 0x2f]);          /* cmp dx, [eax+0x2f] */
            ii(0x1009_dab4, 2); if(jnz(0x1009_dad2, 0x1c)) goto l_0x1009_dad2; /* jnz 0x1009dad2 */
            ii(0x1009_dab6, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_dab9, 3); mov(eax, memd[ds, eax + 0x1f]);         /* mov eax, [eax+0x1f] */
            ii(0x1009_dabc, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_dabf, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1009_dac2, 3); add(eax, memd[ss, ebp - 0x4]);          /* add eax, [ebp-0x4] */
            ii(0x1009_dac5, 4); mov(dx, memw[ds, eax + 0x25]);          /* mov dx, [eax+0x25] */
            ii(0x1009_dac9, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_dacc, 4); cmp(dx, memw[ds, eax + 0x31]);          /* cmp dx, [eax+0x31] */
            ii(0x1009_dad0, 2); if(jz(0x1009_daf4, 0x22)) goto l_0x1009_daf4; /* jz 0x1009daf4 */
        l_0x1009_dad2:
            ii(0x1009_dad2, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_dad5, 4); mov(dx, memw[ds, eax + 0x23]);          /* mov dx, [eax+0x23] */
            ii(0x1009_dad9, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_dadc, 4); cmp(dx, memw[ds, eax + 0x27]);          /* cmp dx, [eax+0x27] */
            ii(0x1009_dae0, 2); if(jnz(0x1009_daf2, 0x10)) goto l_0x1009_daf2; /* jnz 0x1009daf2 */
            ii(0x1009_dae2, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_dae5, 4); mov(dx, memw[ds, eax + 0x25]);          /* mov dx, [eax+0x25] */
            ii(0x1009_dae9, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_daec, 4); cmp(dx, memw[ds, eax + 0x29]);          /* cmp dx, [eax+0x29] */
            ii(0x1009_daf0, 2); if(jz(0x1009_daf4, 0x2)) goto l_0x1009_daf4; /* jz 0x1009daf4 */
        l_0x1009_daf2:
            ii(0x1009_daf2, 2); jmp(0x1009_daf6, 0x2); goto l_0x1009_daf6; /* jmp 0x1009daf6 */
        l_0x1009_daf4:
            ii(0x1009_daf4, 2); jmp(0x1009_dafb, 0x5); goto l_0x1009_dafb; /* jmp 0x1009dafb */
        l_0x1009_daf6:
            ii(0x1009_daf6, 5); jmp(0x1009_d7ca, -0x331); goto l_0x1009_d7ca; /* jmp 0x1009d7ca */
        l_0x1009_dafb:
            ii(0x1009_dafb, 4); mov(memb[ss, ebp - 0x8], 0);            /* mov byte [ebp-0x8], 0x0 */
            ii(0x1009_daff, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_db01, 3); lea(eax, ebp - 0x50);                   /* lea eax, [ebp-0x50] */
            ii(0x1009_db04, 5); call(Definitions.my_dtor_d1, -0x1_4e0d); /* call 0x10088cfc */
            ii(0x1009_db09, 2); jmp(0x1009_db15, 0xa); goto l_0x1009_db15; /* jmp 0x1009db15 */
        //  ii(0x1009_db0b, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x1009_db0d, 3); lea(eax, ebp - 0x50);                   /* lea eax, [ebp-0x50] */
        //  ii(0x1009_db10, 5); call(Definitions.my_dtor_d1, -0x1_4e19); /* call 0x10088cfc */
        l_0x1009_db15:
            ii(0x1009_db15, 3); mov(al, memb[ss, ebp - 0x8]);           /* mov al, [ebp-0x8] */
            ii(0x1009_db18, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_db1a, 1); pop(ebp);                               /* pop ebp */
            ii(0x1009_db1b, 1); pop(edi);                               /* pop edi */
            ii(0x1009_db1c, 1); pop(esi);                               /* pop esi */
            ii(0x1009_db1d, 1); pop(edx);                               /* pop edx */
            ii(0x1009_db1e, 1); pop(ecx);                               /* pop ecx */
            ii(0x1009_db1f, 1); pop(ebx);                               /* pop ebx */
            ii(0x1009_db20, 1); ret();                                  /* ret */
        }
    }
}
