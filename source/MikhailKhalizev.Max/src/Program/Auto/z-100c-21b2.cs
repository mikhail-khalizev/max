using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_21b2-157b4152")]
        public void Method_100c_21b2()
        {
            ii(0x100c_21b2, 5); push(0x40);                             /* push 0x40 */
            ii(0x100c_21b7, 5); call(Definitions.sys_check_available_stack_size, 0xa_3b96); /* call 0x10165d52 */
            ii(0x100c_21bc, 1); push(ebx);                              /* push ebx */
            ii(0x100c_21bd, 1); push(ecx);                              /* push ecx */
            ii(0x100c_21be, 1); push(esi);                              /* push esi */
            ii(0x100c_21bf, 1); push(edi);                              /* push edi */
            ii(0x100c_21c0, 1); push(ebp);                              /* push ebp */
            ii(0x100c_21c1, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_21c3, 6); sub(esp, 0x28);                         /* sub esp, 0x28 */
            ii(0x100c_21c9, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100c_21cc, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100c_21cf, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100c_21d2, 3); add(eax, 0x16);                         /* add eax, 0x16 */
            ii(0x100c_21d5, 5); call(0x1007_6574, -0x4_bc66);           /* call 0x10076574 */
            ii(0x100c_21da, 4); test(memb[ds, eax + 18], 0x40);         /* test byte [eax+0x12], 0x40 */
            ii(0x100c_21de, 6); if(jz(0x100c_226f, 0x8b)) goto l_0x100c_226f; /* jz 0x100c226f */
            ii(0x100c_21e4, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_21e6, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_21e9, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x100c_21ec, 5); call(0x1013_ad11, 0x7_8b20);            /* call 0x1013ad11 */
            ii(0x100c_21f1, 2); test(al, al);                           /* test al, al */
            ii(0x100c_21f3, 2); if(jz(0x100c_2257, 0x62)) goto l_0x100c_2257; /* jz 0x100c2257 */
            ii(0x100c_21f5, 5); mov(eax, 0x56);                         /* mov eax, 0x56 */
            ii(0x100c_21fa, 5); call(Definitions.sys_new, 0xa_3c01);    /* call 0x10165e00 */
            ii(0x100c_21ff, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x100c_2202, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100c_2205, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x100c_2208, 4); cmp(memd[ss, ebp - 16], 0);             /* cmp dword [ebp-0x10], 0x0 */
            ii(0x100c_220c, 2); if(jz(0x100c_222c, 0x1e)) goto l_0x100c_222c; /* jz 0x100c222c */
            ii(0x100c_220e, 5); mov(ebx, 0x40);                         /* mov ebx, 0x40 */
            ii(0x100c_2213, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_2216, 3); movsx(edx, memw[ds, eax]);              /* movsx edx, word [eax] */
            ii(0x100c_2219, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100c_221c, 5); call(Definitions.my_ctor_c13, -0x1_abd2); /* call 0x100a764f */
            ii(0x100c_2221, 3); mov(memd[ss, ebp - 20], eax);           /* mov [ebp-0x14], eax */
            ii(0x100c_2224, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x100c_2227, 3); mov(memd[ss, ebp - 24], eax);           /* mov [ebp-0x18], eax */
            ii(0x100c_222a, 2); jmp(0x100c_2232, 6); goto l_0x100c_2232; /* jmp 0x100c2232 */
        l_0x100c_222c:
            ii(0x100c_222c, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100c_222f, 3); mov(memd[ss, ebp - 24], eax);           /* mov [ebp-0x18], eax */
        l_0x100c_2232:
            ii(0x100c_2232, 3); mov(edx, memd[ss, ebp - 24]);           /* mov edx, [ebp-0x18] */
            ii(0x100c_2235, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_2238, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x100c_223b, 5); call(0x100c_b550, 0x9310);              /* call 0x100cb550 */
            ii(0x100c_2240, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_2243, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x100c_2246, 5); call(0x100c_b520, 0x92d5);              /* call 0x100cb520 */
            ii(0x100c_224b, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_224d, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100c_2252, 5); call(0x100a_4d50, -0x1_d507);           /* call 0x100a4d50 */
        l_0x100c_2257:
            ii(0x100c_2257, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100c_225a, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_225d, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x100c_2260, 5); call(0x100c_b4c4, 0x925f);              /* call 0x100cb4c4 */
            ii(0x100c_2265, 5); call(0x100a_796c, -0x1_a8fe);           /* call 0x100a796c */
            ii(0x100c_226a, 5); jmp(0x100c_22f5, 0x86); goto l_0x100c_22f5; /* jmp 0x100c22f5 */
        l_0x100c_226f:
            ii(0x100c_226f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_2271, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_2274, 3); add(eax, 0x11);                         /* add eax, 0x11 */
            ii(0x100c_2277, 5); call(0x1013_ad11, 0x7_8a95);            /* call 0x1013ad11 */
            ii(0x100c_227c, 2); test(al, al);                           /* test al, al */
            ii(0x100c_227e, 2); if(jz(0x100c_22e2, 0x62)) goto l_0x100c_22e2; /* jz 0x100c22e2 */
            ii(0x100c_2280, 5); mov(eax, 0x56);                         /* mov eax, 0x56 */
            ii(0x100c_2285, 5); call(Definitions.sys_new, 0xa_3b76);    /* call 0x10165e00 */
            ii(0x100c_228a, 3); mov(memd[ss, ebp - 28], eax);           /* mov [ebp-0x1c], eax */
            ii(0x100c_228d, 3); mov(eax, memd[ss, ebp - 28]);           /* mov eax, [ebp-0x1c] */
            ii(0x100c_2290, 3); mov(memd[ss, ebp - 32], eax);           /* mov [ebp-0x20], eax */
            ii(0x100c_2293, 4); cmp(memd[ss, ebp - 32], 0);             /* cmp dword [ebp-0x20], 0x0 */
            ii(0x100c_2297, 2); if(jz(0x100c_22b7, 0x1e)) goto l_0x100c_22b7; /* jz 0x100c22b7 */
            ii(0x100c_2299, 5); mov(ebx, 0x180);                        /* mov ebx, 0x180 */
            ii(0x100c_229e, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_22a1, 3); movsx(edx, memw[ds, eax]);              /* movsx edx, word [eax] */
            ii(0x100c_22a4, 3); mov(eax, memd[ss, ebp - 28]);           /* mov eax, [ebp-0x1c] */
            ii(0x100c_22a7, 5); call(Definitions.my_ctor_c13, -0x1_ac5d); /* call 0x100a764f */
            ii(0x100c_22ac, 3); mov(memd[ss, ebp - 36], eax);           /* mov [ebp-0x24], eax */
            ii(0x100c_22af, 3); mov(eax, memd[ss, ebp - 36]);           /* mov eax, [ebp-0x24] */
            ii(0x100c_22b2, 3); mov(memd[ss, ebp - 40], eax);           /* mov [ebp-0x28], eax */
            ii(0x100c_22b5, 2); jmp(0x100c_22bd, 6); goto l_0x100c_22bd; /* jmp 0x100c22bd */
        l_0x100c_22b7:
            ii(0x100c_22b7, 3); mov(eax, memd[ss, ebp - 32]);           /* mov eax, [ebp-0x20] */
            ii(0x100c_22ba, 3); mov(memd[ss, ebp - 40], eax);           /* mov [ebp-0x28], eax */
        l_0x100c_22bd:
            ii(0x100c_22bd, 3); mov(edx, memd[ss, ebp - 40]);           /* mov edx, [ebp-0x28] */
            ii(0x100c_22c0, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_22c3, 3); add(eax, 0x11);                         /* add eax, 0x11 */
            ii(0x100c_22c6, 5); call(0x100c_b550, 0x9285);              /* call 0x100cb550 */
            ii(0x100c_22cb, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_22ce, 3); add(eax, 0x11);                         /* add eax, 0x11 */
            ii(0x100c_22d1, 5); call(0x100c_b520, 0x924a);              /* call 0x100cb520 */
            ii(0x100c_22d6, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_22d8, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100c_22dd, 5); call(0x100a_4d50, -0x1_d592);           /* call 0x100a4d50 */
        l_0x100c_22e2:
            ii(0x100c_22e2, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100c_22e5, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_22e8, 3); add(eax, 0x11);                         /* add eax, 0x11 */
            ii(0x100c_22eb, 5); call(0x100c_b4c4, 0x91d4);              /* call 0x100cb4c4 */
            ii(0x100c_22f0, 5); call(0x100a_796c, -0x1_a989);           /* call 0x100a796c */
        l_0x100c_22f5:
            ii(0x100c_22f5, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_22f7, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_22f8, 1); pop(edi);                               /* pop edi */
            ii(0x100c_22f9, 1); pop(esi);                               /* pop esi */
            ii(0x100c_22fa, 1); pop(ecx);                               /* pop ecx */
            ii(0x100c_22fb, 1); pop(ebx);                               /* pop ebx */
            ii(0x100c_22fc, 1); ret();                                  /* ret */
        }
    }
}
