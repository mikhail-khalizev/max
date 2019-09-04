using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_f679-f628f4af")]
        public void Method_1011_f679()
        {
            ii(0x1011_f679, 5); push(0xd4);                             /* push 0xd4 */
            ii(0x1011_f67e, 5); call(Definitions.sys_check_available_stack_size, 0x4_66cf); /* call 0x10165d52 */
            ii(0x1011_f683, 1); push(ebx);                              /* push ebx */
            ii(0x1011_f684, 1); push(ecx);                              /* push ecx */
            ii(0x1011_f685, 1); push(edx);                              /* push edx */
            ii(0x1011_f686, 1); push(esi);                              /* push esi */
            ii(0x1011_f687, 1); push(edi);                              /* push edi */
            ii(0x1011_f688, 1); push(ebp);                              /* push ebp */
            ii(0x1011_f689, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_f68b, 6); sub(esp, 0xb4);                         /* sub esp, 0xb4 */
            ii(0x1011_f691, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1011_f694, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_f697, 3); add(eax, 4);                            /* add eax, 0x4 */
            ii(0x1011_f69a, 5); call(0x1007_6b90, -0xa_8b0f);           /* call 0x10076b90 */
            ii(0x1011_f69f, 1); cwde();                                 /* cwde */
            ii(0x1011_f6a0, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_f6a2, 6); if(jz(0x1011_fb94, 0x4ec)) goto l_0x1011_fb94; /* jz 0x1011fb94 */
            ii(0x1011_f6a8, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_f6ab, 3); add(eax, 4);                            /* add eax, 0x4 */
            ii(0x1011_f6ae, 5); call(0x1012_0894, 0x11e1);              /* call 0x10120894 */
            ii(0x1011_f6b3, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1011_f6b5, 3); lea(eax, memd[ss, ebp - 88]);           /* lea eax, [ebp-0x58] */
            ii(0x1011_f6b8, 5); call(0x1012_0748, 0x108b);              /* call 0x10120748 */
            ii(0x1011_f6bd, 3); lea(eax, memd[ss, ebp - 88]);           /* lea eax, [ebp-0x58] */
            ii(0x1011_f6c0, 5); call(0x1012_06a0, 0xfdb);               /* call 0x101206a0 */
            ii(0x1011_f6c5, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1011_f6c7, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_f6ca, 5); call(0x100b_7fa4, -0x6_772b);           /* call 0x100b7fa4 */
            ii(0x1011_f6cf, 3); lea(eax, memd[ss, ebp - 88]);           /* lea eax, [ebp-0x58] */
            ii(0x1011_f6d2, 5); call(0x1012_06d4, 0xffd);               /* call 0x101206d4 */
            ii(0x1011_f6d7, 3); mov(ebx, memd[ss, ebp - 4]);            /* mov ebx, [ebp-0x4] */
            ii(0x1011_f6da, 3); add(ebx, 4);                            /* add ebx, 0x4 */
            ii(0x1011_f6dd, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1011_f6df, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1011_f6e1, 5); call(0x1012_0804, 0x111e);              /* call 0x10120804 */
            ii(0x1011_f6e6, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_f6e9, 5); call(0x100b_7f18, -0x6_77d6);           /* call 0x100b7f18 */
            ii(0x1011_f6ee, 5); call(Definitions.my__get_unit, -0x6_76d7); /* call 0x100b801c */
            ii(0x1011_f6f3, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1011_f6f5, 3); lea(eax, memd[ss, ebp - 84]);           /* lea eax, [ebp-0x54] */
            ii(0x1011_f6f8, 5); call(0x1007_66ac, -0xa_9051);           /* call 0x100766ac */
            ii(0x1011_f6fd, 3); lea(edx, memd[ss, ebp - 80]);           /* lea edx, [ebp-0x50] */
            ii(0x1011_f700, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_f703, 5); call(0x100b_7f18, -0x6_77f0);           /* call 0x100b7f18 */
            ii(0x1011_f708, 5); call(0x100b_808c, -0x6_7681);           /* call 0x100b808c */
            ii(0x1011_f70d, 3); lea(eax, memd[ss, ebp - 84]);           /* lea eax, [ebp-0x54] */
            ii(0x1011_f710, 5); call(0x1007_6574, -0xa_91a1);           /* call 0x10076574 */
            ii(0x1011_f715, 3); mov(ebx, memd[ds, eax + 26]);           /* mov ebx, [eax+0x1a] */
            ii(0x1011_f718, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1011_f71b, 3); lea(eax, memd[ss, ebp - 84]);           /* lea eax, [ebp-0x54] */
            ii(0x1011_f71e, 5); call(0x1007_6574, -0xa_91af);           /* call 0x10076574 */
            ii(0x1011_f723, 3); mov(edx, memd[ds, eax + 24]);           /* mov edx, [eax+0x18] */
            ii(0x1011_f726, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1011_f729, 3); lea(eax, memd[ss, ebp - 76]);           /* lea eax, [ebp-0x4c] */
            ii(0x1011_f72c, 5); call(0x1007_6aac, -0xa_8c85);           /* call 0x10076aac */
            ii(0x1011_f731, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_f734, 5); call(0x100b_7f18, -0x6_7821);           /* call 0x100b7f18 */
            ii(0x1011_f739, 3); mov(memd[ss, ebp - 72], eax);           /* mov [ebp-0x48], eax */
            ii(0x1011_f73c, 3); mov(edx, memd[ss, ebp - 72]);           /* mov edx, [ebp-0x48] */
            ii(0x1011_f73f, 3); mov(edx, memd[ds, edx + 2]);            /* mov edx, [edx+0x2] */
            ii(0x1011_f742, 3); mov(eax, memd[ss, ebp - 72]);           /* mov eax, [ebp-0x48] */
            ii(0x1011_f745, 3); call_abs(memd[ds, edx + 4]);            /* call dword [edx+0x4] */
            ii(0x1011_f748, 2); test(al, al);                           /* test al, al */
            ii(0x1011_f74a, 2); if(jz(0x1011_f76f, 0x23)) goto l_0x1011_f76f; /* jz 0x1011f76f */
            ii(0x1011_f74c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_f74e, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_f751, 5); call(0x100b_7fa4, -0x6_77b2);           /* call 0x100b7fa4 */
            ii(0x1011_f756, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_f758, 3); lea(eax, memd[ss, ebp - 84]);           /* lea eax, [ebp-0x54] */
            ii(0x1011_f75b, 5); call(0x1007_5f2c, -0xa_9834);           /* call 0x10075f2c */
            ii(0x1011_f760, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_f762, 3); lea(eax, memd[ss, ebp - 88]);           /* lea eax, [ebp-0x58] */
            ii(0x1011_f765, 5); call(0x1012_0464, 0xcfa);               /* call 0x10120464 */
            ii(0x1011_f76a, 5); jmp(0x1011_fb94, 0x425); goto l_0x1011_fb94; /* jmp 0x1011fb94 */
        l_0x1011_f76f:
            ii(0x1011_f76f, 5); call(0x1014_82f4, 0x2_8b80);            /* call 0x101482f4 */
            ii(0x1011_f774, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1011_f776, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_f779, 3); mov(memd[ds, eax + 14], edx);           /* mov [eax+0xe], edx */
            ii(0x1011_f77c, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_f77f, 3); mov(edx, memd[ds, eax + 14]);           /* mov edx, [eax+0xe] */
            ii(0x1011_f782, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_f785, 3); mov(memd[ds, eax + 18], edx);           /* mov [eax+0x12], edx */
            ii(0x1011_f788, 10); mov(memd[ds, 0x101c_52e8], 0);         /* mov dword [0x101c52e8], 0x0 */
            ii(0x1011_f792, 10); mov(memd[ds, 0x101c_52ec], 0);         /* mov dword [0x101c52ec], 0x0 */
            ii(0x1011_f79c, 10); mov(memd[ds, 0x101c_52f0], 0);         /* mov dword [0x101c52f0], 0x0 */
            ii(0x1011_f7a6, 10); mov(memd[ds, 0x101c_52f8], 0);         /* mov dword [0x101c52f8], 0x0 */
            ii(0x1011_f7b0, 10); mov(memd[ds, 0x101c_52f4], 0);         /* mov dword [0x101c52f4], 0x0 */
            ii(0x1011_f7ba, 9); mov(memw[ds, 0x101c_52fc], 0);          /* mov word [0x101c52fc], 0x0 */
            ii(0x1011_f7c3, 3); mov(eax, memd[ss, ebp - 76]);           /* mov eax, [ebp-0x4c] */
            ii(0x1011_f7c6, 4); cmp(ax, memw[ss, ebp - 80]);            /* cmp ax, [ebp-0x50] */
            ii(0x1011_f7ca, 2); if(jnz(0x1011_f7d5, 9)) goto l_0x1011_f7d5; /* jnz 0x1011f7d5 */
            ii(0x1011_f7cc, 3); mov(eax, memd[ss, ebp - 74]);           /* mov eax, [ebp-0x4a] */
            ii(0x1011_f7cf, 4); cmp(ax, memw[ss, ebp - 78]);            /* cmp ax, [ebp-0x4e] */
            ii(0x1011_f7d3, 2); if(jz(0x1011_f7d7, 2)) goto l_0x1011_f7d7; /* jz 0x1011f7d7 */
        l_0x1011_f7d5:
            ii(0x1011_f7d5, 2); jmp(0x1011_f7fa, 0x23); goto l_0x1011_f7fa; /* jmp 0x1011f7fa */
        l_0x1011_f7d7:
            ii(0x1011_f7d7, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_f7d9, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_f7dc, 5); call(0x1011_e342, -0x149f);             /* call 0x1011e342 */
            ii(0x1011_f7e1, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_f7e3, 3); lea(eax, memd[ss, ebp - 84]);           /* lea eax, [ebp-0x54] */
            ii(0x1011_f7e6, 5); call(0x1007_5f2c, -0xa_98bf);           /* call 0x10075f2c */
            ii(0x1011_f7eb, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_f7ed, 3); lea(eax, memd[ss, ebp - 88]);           /* lea eax, [ebp-0x58] */
            ii(0x1011_f7f0, 5); call(0x1012_0464, 0xc6f);               /* call 0x10120464 */
            ii(0x1011_f7f5, 5); jmp(0x1011_fb94, 0x39a); goto l_0x1011_fb94; /* jmp 0x1011fb94 */
        l_0x1011_f7fa:
            ii(0x1011_f7fa, 3); lea(edx, memd[ss, ebp - 80]);           /* lea edx, [ebp-0x50] */
            ii(0x1011_f7fd, 3); lea(eax, memd[ss, ebp - 64]);           /* lea eax, [ebp-0x40] */
            ii(0x1011_f800, 5); call(0x1007_5e64, -0xa_99a1);           /* call 0x10075e64 */
            ii(0x1011_f805, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1011_f807, 3); lea(edx, memd[ss, ebp - 76]);           /* lea edx, [ebp-0x4c] */
            ii(0x1011_f80a, 3); lea(eax, memd[ss, ebp - 68]);           /* lea eax, [ebp-0x44] */
            ii(0x1011_f80d, 5); call(0x1007_5e64, -0xa_99ae);           /* call 0x10075e64 */
            ii(0x1011_f812, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x1011_f814, 5); call(0x1007_0c51, -0xa_ebc8);           /* call 0x10070c51 */
            ii(0x1011_f819, 1); cwde();                                 /* cwde */
            ii(0x1011_f81a, 3); cmp(eax, 2);                            /* cmp eax, 0x2 */
            ii(0x1011_f81d, 6); if(jg(0x1011_f986, 0x163)) goto l_0x1011_f986; /* jg 0x1011f986 */
            ii(0x1011_f823, 4); mov(memb[ss, ebp - 92], 0);             /* mov byte [ebp-0x5c], 0x0 */
            ii(0x1011_f827, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_f82a, 5); call(0x100b_7f18, -0x6_7917);           /* call 0x100b7f18 */
            ii(0x1011_f82f, 5); call(0x1012_09fc, 0x11c8);              /* call 0x101209fc */
            ii(0x1011_f834, 2); test(al, al);                           /* test al, al */
            ii(0x1011_f836, 2); if(jz(0x1011_f851, 0x19)) goto l_0x1011_f851; /* jz 0x1011f851 */
            ii(0x1011_f838, 4); movsx(ebx, memw[ss, ebp - 78]);         /* movsx ebx, word [ebp-0x4e] */
            ii(0x1011_f83c, 4); movsx(edx, memw[ss, ebp - 80]);         /* movsx edx, word [ebp-0x50] */
            ii(0x1011_f840, 3); lea(eax, memd[ss, ebp - 84]);           /* lea eax, [ebp-0x54] */
            ii(0x1011_f843, 5); call(0x1007_65d0, -0xa_9278);           /* call 0x100765d0 */
            ii(0x1011_f848, 5); call(0x1007_510b, -0xa_a742);           /* call 0x1007510b */
            ii(0x1011_f84d, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_f84f, 2); if(jnz(0x1011_f853, 2)) goto l_0x1011_f853; /* jnz 0x1011f853 */
        l_0x1011_f851:
            ii(0x1011_f851, 2); jmp(0x1011_f85c, 9); goto l_0x1011_f85c; /* jmp 0x1011f85c */
        l_0x1011_f853:
            ii(0x1011_f853, 4); mov(memb[ss, ebp - 92], 1);             /* mov byte [ebp-0x5c], 0x1 */
            ii(0x1011_f857, 5); jmp(0x1011_f8d6, 0x7a); goto l_0x1011_f8d6; /* jmp 0x1011f8d6 */
        l_0x1011_f85c:
            ii(0x1011_f85c, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_f85f, 5); call(0x100b_7f18, -0x6_794c);           /* call 0x100b7f18 */
            ii(0x1011_f864, 5); call(0x1012_0a2c, 0x11c3);              /* call 0x10120a2c */
            ii(0x1011_f869, 3); movsx(eax, al);                         /* movsx eax, al */
            ii(0x1011_f86c, 1); push(eax);                              /* push eax */
            ii(0x1011_f86d, 4); movsx(ecx, memw[ss, ebp - 78]);         /* movsx ecx, word [ebp-0x4e] */
            ii(0x1011_f871, 4); movsx(ebx, memw[ss, ebp - 80]);         /* movsx ebx, word [ebp-0x50] */
            ii(0x1011_f875, 3); lea(eax, memd[ss, ebp - 84]);           /* lea eax, [ebp-0x54] */
            ii(0x1011_f878, 5); call(0x1007_6574, -0xa_9309);           /* call 0x10076574 */
            ii(0x1011_f87d, 3); mov(al, memb[ds, eax + 38]);            /* mov al, [eax+0x26] */
            ii(0x1011_f880, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1011_f882, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1011_f885, 3); lea(eax, memd[ss, ebp - 84]);           /* lea eax, [ebp-0x54] */
            ii(0x1011_f888, 5); call(0x1007_6574, -0xa_9319);           /* call 0x10076574 */
            ii(0x1011_f88d, 3); mov(eax, memd[ds, eax + 6]);            /* mov eax, [eax+0x6] */
            ii(0x1011_f890, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_f893, 5); call(0x1007_02b9, -0xa_f5df);           /* call 0x100702b9 */
            ii(0x1011_f898, 3); test(ax, ax);                           /* test ax, ax */
            ii(0x1011_f89b, 2); if(jz(0x1011_f8d0, 0x33)) goto l_0x1011_f8d0; /* jz 0x1011f8d0 */
            ii(0x1011_f89d, 5); mov(ecx, 1);                            /* mov ecx, 0x1 */
            ii(0x1011_f8a2, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_f8a5, 5); call(0x100b_7f18, -0x6_7992);           /* call 0x100b7f18 */
            ii(0x1011_f8aa, 5); call(0x100b_80c4, -0x6_77eb);           /* call 0x100b80c4 */
            ii(0x1011_f8af, 3); movsx(ebx, al);                         /* movsx ebx, al */
            ii(0x1011_f8b2, 3); lea(edx, memd[ss, ebp - 80]);           /* lea edx, [ebp-0x50] */
            ii(0x1011_f8b5, 3); lea(eax, memd[ss, ebp - 96]);           /* lea eax, [ebp-0x60] */
            ii(0x1011_f8b8, 5); call(0x1007_5e64, -0xa_9a59);           /* call 0x10075e64 */
            ii(0x1011_f8bd, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1011_f8bf, 3); lea(eax, memd[ss, ebp - 84]);           /* lea eax, [ebp-0x54] */
            ii(0x1011_f8c2, 5); call(0x1008_abbc, -0x9_4d0b);           /* call 0x1008abbc */
            ii(0x1011_f8c7, 5); call(0x100a_90f9, -0x7_67d3);           /* call 0x100a90f9 */
            ii(0x1011_f8cc, 2); test(al, al);                           /* test al, al */
            ii(0x1011_f8ce, 2); if(jz(0x1011_f8d2, 2)) goto l_0x1011_f8d2; /* jz 0x1011f8d2 */
        l_0x1011_f8d0:
            ii(0x1011_f8d0, 2); jmp(0x1011_f8d6, 4); goto l_0x1011_f8d6; /* jmp 0x1011f8d6 */
        l_0x1011_f8d2:
            ii(0x1011_f8d2, 4); mov(memb[ss, ebp - 92], 1);             /* mov byte [ebp-0x5c], 0x1 */
        l_0x1011_f8d6:
            ii(0x1011_f8d6, 4); cmp(memb[ss, ebp - 92], 0);             /* cmp byte [ebp-0x5c], 0x0 */
            ii(0x1011_f8da, 2); if(jnz(0x1011_f8eb, 0xf)) goto l_0x1011_f8eb; /* jnz 0x1011f8eb */
            ii(0x1011_f8dc, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_f8de, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_f8e1, 5); call(0x1011_e342, -0x15a4);             /* call 0x1011e342 */
            ii(0x1011_f8e6, 5); jmp(0x1011_f96d, 0x82); goto l_0x1011_f96d; /* jmp 0x1011f96d */
        l_0x1011_f8eb:
            ii(0x1011_f8eb, 5); mov(eax, 0x1c);                         /* mov eax, 0x1c */
            ii(0x1011_f8f0, 5); call(Definitions.sys_new, 0x4_650b);    /* call 0x10165e00 */
            ii(0x1011_f8f5, 3); mov(memd[ss, ebp - 100], eax);          /* mov [ebp-0x64], eax */
            ii(0x1011_f8f8, 3); mov(eax, memd[ss, ebp - 100]);          /* mov eax, [ebp-0x64] */
            ii(0x1011_f8fb, 3); mov(memd[ss, ebp - 104], eax);          /* mov [ebp-0x68], eax */
            ii(0x1011_f8fe, 4); cmp(memd[ss, ebp - 104], 0);            /* cmp dword [ebp-0x68], 0x0 */
            ii(0x1011_f902, 2); if(jz(0x1011_f91f, 0x1b)) goto l_0x1011_f91f; /* jz 0x1011f91f */
            ii(0x1011_f904, 4); movsx(ebx, memw[ss, ebp - 78]);         /* movsx ebx, word [ebp-0x4e] */
            ii(0x1011_f908, 4); movsx(edx, memw[ss, ebp - 80]);         /* movsx edx, word [ebp-0x50] */
            ii(0x1011_f90c, 3); mov(eax, memd[ss, ebp - 100]);          /* mov eax, [ebp-0x64] */
            ii(0x1011_f90f, 5); call(Definitions.my_ctor_c20, -0x59be); /* call 0x10119f56 */
            ii(0x1011_f914, 3); mov(memd[ss, ebp - 108], eax);          /* mov [ebp-0x6c], eax */
            ii(0x1011_f917, 3); mov(eax, memd[ss, ebp - 108]);          /* mov eax, [ebp-0x6c] */
            ii(0x1011_f91a, 3); mov(memd[ss, ebp - 112], eax);          /* mov [ebp-0x70], eax */
            ii(0x1011_f91d, 2); jmp(0x1011_f925, 6); goto l_0x1011_f925; /* jmp 0x1011f925 */
        l_0x1011_f91f:
            ii(0x1011_f91f, 3); mov(eax, memd[ss, ebp - 104]);          /* mov eax, [ebp-0x68] */
            ii(0x1011_f922, 3); mov(memd[ss, ebp - 112], eax);          /* mov [ebp-0x70], eax */
        l_0x1011_f925:
            ii(0x1011_f925, 3); mov(edx, memd[ss, ebp - 112]);          /* mov edx, [ebp-0x70] */
            ii(0x1011_f928, 3); lea(eax, memd[ss, ebp - 116]);          /* lea eax, [ebp-0x74] */
            ii(0x1011_f92b, 5); call(0x100a_b3b0, -0x7_4580);           /* call 0x100ab3b0 */
            ii(0x1011_f930, 3); mov(eax, memd[ss, ebp - 78]);           /* mov eax, [ebp-0x4e] */
            ii(0x1011_f933, 3); sub(eax, memd[ss, ebp - 74]);           /* sub eax, [ebp-0x4a] */
            ii(0x1011_f936, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1011_f939, 3); mov(eax, memd[ss, ebp - 80]);           /* mov eax, [ebp-0x50] */
            ii(0x1011_f93c, 3); sub(eax, memd[ss, ebp - 76]);           /* sub eax, [ebp-0x4c] */
            ii(0x1011_f93f, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1011_f942, 3); lea(eax, memd[ss, ebp - 116]);          /* lea eax, [ebp-0x74] */
            ii(0x1011_f945, 5); call(0x100a_b2e0, -0x7_466a);           /* call 0x100ab2e0 */
            ii(0x1011_f94a, 5); call(0x1011_aca3, -0x4cac);             /* call 0x1011aca3 */
            ii(0x1011_f94f, 3); lea(eax, memd[ss, ebp - 116]);          /* lea eax, [ebp-0x74] */
            ii(0x1011_f952, 5); call(0x100a_b33c, -0x7_461b);           /* call 0x100ab33c */
            ii(0x1011_f957, 3); mov(ebx, memd[ss, ebp - 4]);            /* mov ebx, [ebp-0x4] */
            ii(0x1011_f95a, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1011_f95c, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1011_f95e, 5); call(0x1011_e342, -0x1621);             /* call 0x1011e342 */
            ii(0x1011_f963, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_f965, 3); lea(eax, memd[ss, ebp - 116]);          /* lea eax, [ebp-0x74] */
            ii(0x1011_f968, 5); call(0x100a_9f38, -0x7_5a35);           /* call 0x100a9f38 */
        l_0x1011_f96d:
            ii(0x1011_f96d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_f96f, 3); lea(eax, memd[ss, ebp - 84]);           /* lea eax, [ebp-0x54] */
            ii(0x1011_f972, 5); call(0x1007_5f2c, -0xa_9a4b);           /* call 0x10075f2c */
            ii(0x1011_f977, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_f979, 3); lea(eax, memd[ss, ebp - 88]);           /* lea eax, [ebp-0x58] */
            ii(0x1011_f97c, 5); call(0x1012_0464, 0xae3);               /* call 0x10120464 */
            ii(0x1011_f981, 5); jmp(0x1011_fb94, 0x20e); goto l_0x1011_fb94; /* jmp 0x1011fb94 */
        l_0x1011_f986:
            ii(0x1011_f986, 3); lea(eax, memd[ss, ebp - 84]);           /* lea eax, [ebp-0x54] */
            ii(0x1011_f989, 5); call(0x1007_65d0, -0xa_93be);           /* call 0x100765d0 */
            ii(0x1011_f98e, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1011_f990, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_f993, 5); call(0x1011_f150, -0x848);              /* call 0x1011f150 */
            ii(0x1011_f998, 2); test(al, al);                           /* test al, al */
            ii(0x1011_f99a, 2); if(jnz(0x1011_f9bf, 0x23)) goto l_0x1011_f9bf; /* jnz 0x1011f9bf */
            ii(0x1011_f99c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_f99e, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_f9a1, 5); call(0x1011_e342, -0x1664);             /* call 0x1011e342 */
            ii(0x1011_f9a6, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_f9a8, 3); lea(eax, memd[ss, ebp - 84]);           /* lea eax, [ebp-0x54] */
            ii(0x1011_f9ab, 5); call(0x1007_5f2c, -0xa_9a84);           /* call 0x10075f2c */
            ii(0x1011_f9b0, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_f9b2, 3); lea(eax, memd[ss, ebp - 88]);           /* lea eax, [ebp-0x58] */
            ii(0x1011_f9b5, 5); call(0x1012_0464, 0xaaa);               /* call 0x10120464 */
            ii(0x1011_f9ba, 5); jmp(0x1011_fb94, 0x1d5); goto l_0x1011_fb94; /* jmp 0x1011fb94 */
        l_0x1011_f9bf:
            ii(0x1011_f9bf, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_f9c2, 5); call(0x100b_7f18, -0x6_7aaf);           /* call 0x100b7f18 */
            ii(0x1011_f9c7, 5); call(0x100b_8054, -0x6_7978);           /* call 0x100b8054 */
            ii(0x1011_f9cc, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_f9ce, 2); if(jz(0x1011_f9e4, 0x14)) goto l_0x1011_f9e4; /* jz 0x1011f9e4 */
            ii(0x1011_f9d0, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_f9d3, 5); call(0x100b_7f18, -0x6_7ac0);           /* call 0x100b7f18 */
            ii(0x1011_f9d8, 5); call(0x100b_8054, -0x6_7989);           /* call 0x100b8054 */
            ii(0x1011_f9dd, 5); cmp(memw[ds, eax + 8], 0x4e);           /* cmp word [eax+0x8], 0x4e */
            ii(0x1011_f9e2, 2); if(jz(0x1011_f9e6, 2)) goto l_0x1011_f9e6; /* jz 0x1011f9e6 */
        l_0x1011_f9e4:
            ii(0x1011_f9e4, 2); jmp(0x1011_f9ec, 6); goto l_0x1011_f9ec; /* jmp 0x1011f9ec */
        l_0x1011_f9e6:
            ii(0x1011_f9e6, 4); mov(memb[ss, ebp - 120], 1);            /* mov byte [ebp-0x78], 0x1 */
            ii(0x1011_f9ea, 2); jmp(0x1011_f9f0, 4); goto l_0x1011_f9f0; /* jmp 0x1011f9f0 */
        l_0x1011_f9ec:
            ii(0x1011_f9ec, 4); mov(memb[ss, ebp - 120], 0);            /* mov byte [ebp-0x78], 0x0 */
        l_0x1011_f9f0:
            ii(0x1011_f9f0, 3); mov(al, memb[ss, ebp - 120]);           /* mov al, [ebp-0x78] */
            ii(0x1011_f9f3, 3); mov(memb[ss, ebp - 8], al);             /* mov [ebp-0x8], al */
            ii(0x1011_f9f6, 4); mov(memb[ss, ebp - 12], 0);             /* mov byte [ebp-0xc], 0x0 */
            ii(0x1011_f9fa, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1011_f9fd, 3); lea(eax, memd[ss, ebp - 124]);          /* lea eax, [ebp-0x7c] */
            ii(0x1011_fa00, 5); call(0x1012_0940, 0xf3b);               /* call 0x10120940 */
            ii(0x1011_fa05, 6); mov(edx, memd[ds, 0x101c_5368]);        /* mov edx, [0x101c5368] */
            ii(0x1011_fa0b, 6); lea(eax, memd[ss, ebp - 168]);          /* lea eax, [ebp-0xa8] */
            ii(0x1011_fa11, 5); call(0x1011_d987, -0x208f);             /* call 0x1011d987 */
            ii(0x1011_fa16, 3); lea(edx, memd[ss, ebp - 76]);           /* lea edx, [ebp-0x4c] */
            ii(0x1011_fa19, 6); lea(eax, memd[ss, ebp - 172]);          /* lea eax, [ebp-0xac] */
            ii(0x1011_fa1f, 5); call(0x1007_5e64, -0xa_9bc0);           /* call 0x10075e64 */
            ii(0x1011_fa24, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1011_fa26, 6); lea(eax, memd[ss, ebp - 168]);          /* lea eax, [ebp-0xa8] */
            ii(0x1011_fa2c, 5); call(0x1009_034f, -0x8_f6e2);           /* call 0x1009034f */
            ii(0x1011_fa31, 4); movsx(eax, memw[ss, ebp - 80]);         /* movsx eax, word [ebp-0x50] */
            ii(0x1011_fa35, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1011_fa38, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1011_fa3a, 5); mov(eax, memd[ds, 0x101c_5368]);        /* mov eax, [0x101c5368] */
            ii(0x1011_fa3f, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1011_fa41, 4); movsx(edx, memw[ss, ebp - 78]);         /* movsx edx, word [ebp-0x4e] */
            ii(0x1011_fa45, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1011_fa47, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1011_fa49, 2); mov(al, memb[ds, eax]);                 /* mov al, [eax] */
            ii(0x1011_fa4b, 2); and(al, 0x20);                          /* and al, 0x20 */
            ii(0x1011_fa4d, 3); mov(memb[ss, ebp - 12], al);            /* mov [ebp-0xc], al */
            ii(0x1011_fa50, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_fa52, 3); lea(eax, memd[ss, ebp - 124]);          /* lea eax, [ebp-0x7c] */
            ii(0x1011_fa55, 5); call(0x100b_7368, -0x6_86f2);           /* call 0x100b7368 */
            ii(0x1011_fa5a, 4); cmp(memb[ss, ebp - 12], 0);             /* cmp byte [ebp-0xc], 0x0 */
            ii(0x1011_fa5e, 2); if(jnz(0x1011_fa83, 0x23)) goto l_0x1011_fa83; /* jnz 0x1011fa83 */
            ii(0x1011_fa60, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_fa62, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_fa65, 5); call(0x1011_e342, -0x1728);             /* call 0x1011e342 */
            ii(0x1011_fa6a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_fa6c, 3); lea(eax, memd[ss, ebp - 84]);           /* lea eax, [ebp-0x54] */
            ii(0x1011_fa6f, 5); call(0x1007_5f2c, -0xa_9b48);           /* call 0x10075f2c */
            ii(0x1011_fa74, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_fa76, 3); lea(eax, memd[ss, ebp - 88]);           /* lea eax, [ebp-0x58] */
            ii(0x1011_fa79, 5); call(0x1012_0464, 0x9e6);               /* call 0x10120464 */
            ii(0x1011_fa7e, 5); jmp(0x1011_fb94, 0x111); goto l_0x1011_fb94; /* jmp 0x1011fb94 */
        l_0x1011_fa83:
            ii(0x1011_fa83, 5); mov(eax, 0x23);                         /* mov eax, 0x23 */
            ii(0x1011_fa88, 5); call(Definitions.sys_new, 0x4_6373);    /* call 0x10165e00 */
            ii(0x1011_fa8d, 3); mov(memd[ss, ebp - 40], eax);           /* mov [ebp-0x28], eax */
            ii(0x1011_fa90, 3); mov(eax, memd[ss, ebp - 40]);           /* mov eax, [ebp-0x28] */
            ii(0x1011_fa93, 3); mov(memd[ss, ebp - 44], eax);           /* mov [ebp-0x2c], eax */
            ii(0x1011_fa96, 4); cmp(memd[ss, ebp - 44], 0);             /* cmp dword [ebp-0x2c], 0x0 */
            ii(0x1011_fa9a, 2); if(jz(0x1011_fad1, 0x35)) goto l_0x1011_fad1; /* jz 0x1011fad1 */
            ii(0x1011_fa9c, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1011_fa9e, 3); mov(cl, memb[ss, ebp - 8]);             /* mov cl, [ebp-0x8] */
            ii(0x1011_faa1, 3); lea(edx, memd[ss, ebp - 80]);           /* lea edx, [ebp-0x50] */
            ii(0x1011_faa4, 3); lea(eax, memd[ss, ebp - 52]);           /* lea eax, [ebp-0x34] */
            ii(0x1011_faa7, 5); call(0x1007_5e64, -0xa_9c48);           /* call 0x10075e64 */
            ii(0x1011_faac, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1011_faae, 3); lea(edx, memd[ss, ebp - 76]);           /* lea edx, [ebp-0x4c] */
            ii(0x1011_fab1, 3); lea(eax, memd[ss, ebp - 56]);           /* lea eax, [ebp-0x38] */
            ii(0x1011_fab4, 5); call(0x1007_5e64, -0xa_9c55);           /* call 0x10075e64 */
            ii(0x1011_fab9, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1011_fabb, 3); mov(eax, memd[ss, ebp - 40]);           /* mov eax, [ebp-0x28] */
            ii(0x1011_fabe, 5); call(0x1011_bfbf, -0x3b04);             /* call 0x1011bfbf */
            ii(0x1011_fac3, 3); mov(memd[ss, ebp - 48], eax);           /* mov [ebp-0x30], eax */
            ii(0x1011_fac6, 3); mov(eax, memd[ss, ebp - 48]);           /* mov eax, [ebp-0x30] */
            ii(0x1011_fac9, 6); mov(memd[ss, ebp - 176], eax);          /* mov [ebp-0xb0], eax */
            ii(0x1011_facf, 2); jmp(0x1011_fada, 9); goto l_0x1011_fada; /* jmp 0x1011fada */
        l_0x1011_fad1:
            ii(0x1011_fad1, 3); mov(eax, memd[ss, ebp - 44]);           /* mov eax, [ebp-0x2c] */
            ii(0x1011_fad4, 6); mov(memd[ss, ebp - 176], eax);          /* mov [ebp-0xb0], eax */
        l_0x1011_fada:
            ii(0x1011_fada, 6); mov(eax, memd[ss, ebp - 176]);          /* mov eax, [ebp-0xb0] */
            ii(0x1011_fae0, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1011_fae3, 3); mov(memd[ds, edx + 22], eax);           /* mov [edx+0x16], eax */
            ii(0x1011_fae6, 5); mov(eax, 0x23);                         /* mov eax, 0x23 */
            ii(0x1011_faeb, 5); call(Definitions.sys_new, 0x4_6310);    /* call 0x10165e00 */
            ii(0x1011_faf0, 3); mov(memd[ss, ebp - 20], eax);           /* mov [ebp-0x14], eax */
            ii(0x1011_faf3, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x1011_faf6, 3); mov(memd[ss, ebp - 24], eax);           /* mov [ebp-0x18], eax */
            ii(0x1011_faf9, 4); cmp(memd[ss, ebp - 24], 0);             /* cmp dword [ebp-0x18], 0x0 */
            ii(0x1011_fafd, 2); if(jz(0x1011_fb34, 0x35)) goto l_0x1011_fb34; /* jz 0x1011fb34 */
            ii(0x1011_faff, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1011_fb01, 3); mov(cl, memb[ss, ebp - 8]);             /* mov cl, [ebp-0x8] */
            ii(0x1011_fb04, 3); lea(edx, memd[ss, ebp - 76]);           /* lea edx, [ebp-0x4c] */
            ii(0x1011_fb07, 3); lea(eax, memd[ss, ebp - 32]);           /* lea eax, [ebp-0x20] */
            ii(0x1011_fb0a, 5); call(0x1007_5e64, -0xa_9cab);           /* call 0x10075e64 */
            ii(0x1011_fb0f, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1011_fb11, 3); lea(edx, memd[ss, ebp - 80]);           /* lea edx, [ebp-0x50] */
            ii(0x1011_fb14, 3); lea(eax, memd[ss, ebp - 36]);           /* lea eax, [ebp-0x24] */
            ii(0x1011_fb17, 5); call(0x1007_5e64, -0xa_9cb8);           /* call 0x10075e64 */
            ii(0x1011_fb1c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1011_fb1e, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x1011_fb21, 5); call(0x1011_bfbf, -0x3b67);             /* call 0x1011bfbf */
            ii(0x1011_fb26, 3); mov(memd[ss, ebp - 28], eax);           /* mov [ebp-0x1c], eax */
            ii(0x1011_fb29, 3); mov(eax, memd[ss, ebp - 28]);           /* mov eax, [ebp-0x1c] */
            ii(0x1011_fb2c, 6); mov(memd[ss, ebp - 180], eax);          /* mov [ebp-0xb4], eax */
            ii(0x1011_fb32, 2); jmp(0x1011_fb3d, 9); goto l_0x1011_fb3d; /* jmp 0x1011fb3d */
        l_0x1011_fb34:
            ii(0x1011_fb34, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x1011_fb37, 6); mov(memd[ss, ebp - 180], eax);          /* mov [ebp-0xb4], eax */
        l_0x1011_fb3d:
            ii(0x1011_fb3d, 6); mov(eax, memd[ss, ebp - 180]);          /* mov eax, [ebp-0xb4] */
            ii(0x1011_fb43, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1011_fb46, 3); mov(memd[ds, edx + 26], eax);           /* mov [edx+0x1a], eax */
            ii(0x1011_fb49, 5); mov(ebx, 1);                            /* mov ebx, 0x1 */
            ii(0x1011_fb4e, 3); lea(edx, memd[ss, ebp - 76]);           /* lea edx, [ebp-0x4c] */
            ii(0x1011_fb51, 3); lea(eax, memd[ss, ebp - 16]);           /* lea eax, [ebp-0x10] */
            ii(0x1011_fb54, 5); call(0x1007_5e64, -0xa_9cf5);           /* call 0x10075e64 */
            ii(0x1011_fb59, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1011_fb5b, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_fb5e, 3); mov(eax, memd[ds, eax + 22]);           /* mov eax, [eax+0x16] */
            ii(0x1011_fb61, 5); call(0x1011_c644, -0x3522);             /* call 0x1011c644 */
            ii(0x1011_fb66, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1011_fb68, 3); lea(edx, memd[ss, ebp - 80]);           /* lea edx, [ebp-0x50] */
            ii(0x1011_fb6b, 3); lea(eax, memd[ss, ebp - 60]);           /* lea eax, [ebp-0x3c] */
            ii(0x1011_fb6e, 5); call(0x1007_5e64, -0xa_9d0f);           /* call 0x10075e64 */
            ii(0x1011_fb73, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1011_fb75, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_fb78, 3); mov(eax, memd[ds, eax + 26]);           /* mov eax, [eax+0x1a] */
            ii(0x1011_fb7b, 5); call(0x1011_c644, -0x353c);             /* call 0x1011c644 */
            ii(0x1011_fb80, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_fb82, 3); lea(eax, memd[ss, ebp - 84]);           /* lea eax, [ebp-0x54] */
            ii(0x1011_fb85, 5); call(0x1007_5f2c, -0xa_9c5e);           /* call 0x10075f2c */
            ii(0x1011_fb8a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_fb8c, 3); lea(eax, memd[ss, ebp - 88]);           /* lea eax, [ebp-0x58] */
            ii(0x1011_fb8f, 5); call(0x1012_0464, 0x8d0);               /* call 0x10120464 */
        l_0x1011_fb94:
            ii(0x1011_fb94, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_fb96, 1); pop(ebp);                               /* pop ebp */
            ii(0x1011_fb97, 1); pop(edi);                               /* pop edi */
            ii(0x1011_fb98, 1); pop(esi);                               /* pop esi */
            ii(0x1011_fb99, 1); pop(edx);                               /* pop edx */
            ii(0x1011_fb9a, 1); pop(ecx);                               /* pop ecx */
            ii(0x1011_fb9b, 1); pop(ebx);                               /* pop ebx */
            ii(0x1011_fb9c, 1); ret();                                  /* ret */
        }
    }
}
