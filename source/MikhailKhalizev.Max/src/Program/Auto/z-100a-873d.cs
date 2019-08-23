using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_873d-64d40fc8")]
        public void Method_100a_873d()
        {
            ii(0x100a_873d, 5); push(0x4c);                             /* push 0x4c */
            ii(0x100a_8742, 5); call(Definitions.sys_check_available_stack_size, 0xb_d60b); /* call 0x10165d52 */
            ii(0x100a_8747, 1); push(ebx);                              /* push ebx */
            ii(0x100a_8748, 1); push(ecx);                              /* push ecx */
            ii(0x100a_8749, 1); push(edx);                              /* push edx */
            ii(0x100a_874a, 1); push(esi);                              /* push esi */
            ii(0x100a_874b, 1); push(edi);                              /* push edi */
            ii(0x100a_874c, 1); push(ebp);                              /* push ebp */
            ii(0x100a_874d, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_874f, 6); sub(esp, 0x2c);                         /* sub esp, 0x2c */
            ii(0x100a_8755, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100a_8758, 5); mov(eax, memd[ds, 0x101c_8172]);        /* mov eax, [0x101c8172] */
            ii(0x100a_875d, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_8760, 1); push(eax);                              /* push eax */
            ii(0x100a_8761, 6); mov(ecx, memd[ds, 0x101c_8170]);        /* mov ecx, [0x101c8170] */
            ii(0x100a_8767, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100a_876a, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100a_876c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_876e, 3); lea(eax, memd[ss, ebp - 0x1c]);         /* lea eax, [ebp-0x1c] */
            ii(0x100a_8771, 5); call(0x1008_b148, -0x1_d62e);           /* call 0x1008b148 */
            ii(0x100a_8776, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x100a_8779, 5); call(Definitions.my_ctor_0x101b_4184, -0x3_1c8e); /* call 0x10076af0 */
            ii(0x100a_877e, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_8781, 4); mov(memb[ds, eax + 0x13], 0x2);         /* mov byte [eax+0x13], 0x2 */
        l_0x100a_8785:
            ii(0x100a_8785, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_8788, 3); add(eax, 0x1e);                         /* add eax, 0x1e */
            ii(0x100a_878b, 5); call(Definitions.my_3_get_count, -0x1_d310); /* call 0x1008b480 */
            ii(0x100a_8790, 1); cwde();                                 /* cwde */
            ii(0x100a_8791, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_8793, 2); if(jle(0x100a_879e, 0x9)) goto l_0x100a_879e; /* jle 0x100a879e */
            ii(0x100a_8795, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_8798, 4); cmp(memb[ds, eax + 0x13], 0x2);         /* cmp byte [eax+0x13], 0x2 */
            ii(0x100a_879c, 2); if(jz(0x100a_87a0, 0x2)) goto l_0x100a_87a0; /* jz 0x100a87a0 */
        l_0x100a_879e:
            ii(0x100a_879e, 2); jmp(0x100a_87b3, 0x13); goto l_0x100a_87b3; /* jmp 0x100a87b3 */
        l_0x100a_87a0:
            ii(0x100a_87a0, 5); call(0x1014_82f4, 0x9_fb4f);            /* call 0x101482f4 */
            ii(0x100a_87a5, 6); sub(eax, memd[ds, 0x101c_3974]);        /* sub eax, [0x101c3974] */
            ii(0x100a_87ab, 6); cmp(eax, memd[ds, 0x101b_dd84]);        /* cmp eax, [0x101bdd84] */
            ii(0x100a_87b1, 2); if(jb(0x100a_87b8, 0x5)) goto l_0x100a_87b8; /* jb 0x100a87b8 */
        l_0x100a_87b3:
            ii(0x100a_87b3, 5); jmp(0x100a_887e, 0xc6); goto l_0x100a_887e; /* jmp 0x100a887e */
        l_0x100a_87b8:
            ii(0x100a_87b8, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_87ba, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_87bd, 3); add(eax, 0x1e);                         /* add eax, 0x1e */
            ii(0x100a_87c0, 5); call(0x100a_a700, 0x1f3b);              /* call 0x100aa700 */
            ii(0x100a_87c5, 3); lea(ebx, memd[ss, ebp - 0x24]);         /* lea ebx, [ebp-0x24] */
            ii(0x100a_87c8, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_87ca, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100a_87cc, 5); call(0x100a_a514, 0x1d43);              /* call 0x100aa514 */
            ii(0x100a_87d1, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_87d3, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_87d6, 3); add(eax, 0x1e);                         /* add eax, 0x1e */
            ii(0x100a_87d9, 5); call(0x100c_db14, 0x2_5336);            /* call 0x100cdb14 */
            ii(0x100a_87de, 3); lea(edx, memd[ss, ebp - 0x24]);         /* lea edx, [ebp-0x24] */
            ii(0x100a_87e1, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_87e4, 3); add(eax, 0x3e);                         /* add eax, 0x3e */
            ii(0x100a_87e7, 5); call(0x100a_aa64, 0x2278);              /* call 0x100aaa64 */
            ii(0x100a_87ec, 7); mov(memd[ss, ebp - 0x8], 0);            /* mov dword [ebp-0x8], 0x0 */
            ii(0x100a_87f3, 2); jmp(0x100a_87fb, 0x6); goto l_0x100a_87fb; /* jmp 0x100a87fb */
        l_0x100a_87f5:
            ii(0x100a_87f5, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_87f8, 3); inc(memd[ss, ebp - 0x8]);               /* inc dword [ebp-0x8] */
        l_0x100a_87fb:
            ii(0x100a_87fb, 4); movsx(eax, memw[ss, ebp - 0x8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x100a_87ff, 3); cmp(eax, 0x8);                          /* cmp eax, 0x8 */
            ii(0x100a_8802, 2); if(jge(0x100a_880d, 0x9)) goto l_0x100a_880d; /* jge 0x100a880d */
            ii(0x100a_8804, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_8807, 4); cmp(memb[ds, eax + 0x13], 0x2);         /* cmp byte [eax+0x13], 0x2 */
            ii(0x100a_880b, 2); if(jz(0x100a_880f, 0x2)) goto l_0x100a_880f; /* jz 0x100a880f */
        l_0x100a_880d:
            ii(0x100a_880d, 2); jmp(0x100a_8879, 0x6a); goto l_0x100a_8879; /* jmp 0x100a8879 */
        l_0x100a_880f:
            ii(0x100a_880f, 3); lea(edx, memd[ss, ebp - 0x24]);         /* lea edx, [ebp-0x24] */
            ii(0x100a_8812, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x100a_8815, 5); call(0x1008_8b44, -0x1_fcd6);           /* call 0x10088b44 */
            ii(0x100a_881a, 4); movsx(eax, memw[ss, ebp - 0x8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x100a_881e, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100a_8821, 5); mov(edx, 0x101c_5348);                  /* mov edx, 0x101c5348 */
            ii(0x100a_8826, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100a_8828, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x100a_882b, 5); call(0x1008_b1a4, -0x1_d68c);           /* call 0x1008b1a4 */
            ii(0x100a_8830, 3); lea(edx, memd[ss, ebp - 0xc]);          /* lea edx, [ebp-0xc] */
            ii(0x100a_8833, 3); lea(eax, memd[ss, ebp - 0x1c]);         /* lea eax, [ebp-0x1c] */
            ii(0x100a_8836, 5); call(0x1010_82ce, 0x5_fa93);            /* call 0x101082ce */
            ii(0x100a_883b, 2); test(al, al);                           /* test al, al */
            ii(0x100a_883d, 2); if(jz(0x100a_885a, 0x1b)) goto l_0x100a_885a; /* jz 0x100a885a */
            ii(0x100a_883f, 3); lea(edx, memd[ss, ebp - 0xc]);          /* lea edx, [ebp-0xc] */
            ii(0x100a_8842, 3); lea(eax, memd[ss, ebp - 0x28]);         /* lea eax, [ebp-0x28] */
            ii(0x100a_8845, 5); call(0x1007_5e64, -0x3_29e6);           /* call 0x10075e64 */
            ii(0x100a_884a, 3); mov(ebx, memd[ss, ebp - 0x4]);          /* mov ebx, [ebp-0x4] */
            ii(0x100a_884d, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_884f, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100a_8851, 5); call(0x100a_7e7a, -0x9dc);              /* call 0x100a7e7a */
            ii(0x100a_8856, 2); test(al, al);                           /* test al, al */
            ii(0x100a_8858, 2); if(jnz(0x100a_885c, 0x2)) goto l_0x100a_885c; /* jnz 0x100a885c */
        l_0x100a_885a:
            ii(0x100a_885a, 2); jmp(0x100a_8874, 0x18); goto l_0x100a_8874; /* jmp 0x100a8874 */
        l_0x100a_885c:
            ii(0x100a_885c, 3); lea(edx, memd[ss, ebp - 0xc]);          /* lea edx, [ebp-0xc] */
            ii(0x100a_885f, 3); lea(eax, memd[ss, ebp - 0x2c]);         /* lea eax, [ebp-0x2c] */
            ii(0x100a_8862, 5); call(0x1007_5e64, -0x3_2a03);           /* call 0x10075e64 */
            ii(0x100a_8867, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100a_8869, 3); lea(edx, memd[ss, ebp - 0x24]);         /* lea edx, [ebp-0x24] */
            ii(0x100a_886c, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_886f, 5); call(0x100a_7f34, -0x940);              /* call 0x100a7f34 */
        l_0x100a_8874:
            ii(0x100a_8874, 5); jmp(0x100a_87f5, -0x84); goto l_0x100a_87f5; /* jmp 0x100a87f5 */
        l_0x100a_8879:
            ii(0x100a_8879, 5); jmp(0x100a_8785, -0xf9); goto l_0x100a_8785; /* jmp 0x100a8785 */
        l_0x100a_887e:
            ii(0x100a_887e, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_8881, 3); add(eax, 0x1e);                         /* add eax, 0x1e */
            ii(0x100a_8884, 5); call(Definitions.my_3_get_count, -0x1_d409); /* call 0x1008b480 */
            ii(0x100a_8889, 1); cwde();                                 /* cwde */
            ii(0x100a_888a, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_888c, 2); if(jnz(0x100a_88a9, 0x1b)) goto l_0x100a_88a9; /* jnz 0x100a88a9 */
            ii(0x100a_888e, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_8891, 3); add(eax, 0x3e);                         /* add eax, 0x3e */
            ii(0x100a_8894, 5); call(0x1009_cb94, -0xbd05);             /* call 0x1009cb94 */
            ii(0x100a_8899, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_889c, 4); cmp(memb[ds, eax + 0x13], 0x2);         /* cmp byte [eax+0x13], 0x2 */
            ii(0x100a_88a0, 2); if(jnz(0x100a_88a9, 0x7)) goto l_0x100a_88a9; /* jnz 0x100a88a9 */
            ii(0x100a_88a2, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_88a5, 4); mov(memb[ds, eax + 0x13], 0);           /* mov byte [eax+0x13], 0x0 */
        l_0x100a_88a9:
            ii(0x100a_88a9, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_88ac, 4); cmp(memb[ds, eax + 0x13], 0x2);         /* cmp byte [eax+0x13], 0x2 */
            ii(0x100a_88b0, 2); if(jnz(0x100a_88c3, 0x11)) goto l_0x100a_88c3; /* jnz 0x100a88c3 */
            ii(0x100a_88b2, 5); call(0x100a_b288, 0x29d1);              /* call 0x100ab288 */
            ii(0x100a_88b7, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_88b9, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x100a_88bb, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_88be, 5); call(0x100a_28ff, -0x5fc4);             /* call 0x100a28ff */
        l_0x100a_88c3:
            ii(0x100a_88c3, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_88c5, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_88c6, 1); pop(edi);                               /* pop edi */
            ii(0x100a_88c7, 1); pop(esi);                               /* pop esi */
            ii(0x100a_88c8, 1); pop(edx);                               /* pop edx */
            ii(0x100a_88c9, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_88ca, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_88cb, 1); ret();                                  /* ret */
        }
    }
}
