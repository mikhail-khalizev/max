using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_3729-c284ffec")]
        public void Method_100e_3729()
        {
            ii(0x100e_3729, 5); push(0x2c);                             /* push 0x2c */
            ii(0x100e_372e, 5); call(Definitions.sys_check_available_stack_size, 0x8_261f); /* call 0x10165d52 */
            ii(0x100e_3733, 1); push(ebx);                              /* push ebx */
            ii(0x100e_3734, 1); push(ecx);                              /* push ecx */
            ii(0x100e_3735, 1); push(esi);                              /* push esi */
            ii(0x100e_3736, 1); push(edi);                              /* push edi */
            ii(0x100e_3737, 1); push(ebp);                              /* push ebp */
            ii(0x100e_3738, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_373a, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x100e_3740, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100e_3743, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100e_3746, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_3749, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x100e_374c, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100e_374f, 3); add(eax, 0x1c);                         /* add eax, 0x1c */
            ii(0x100e_3752, 5); call(0x1007_6338, -0x6_d41f);           /* call 0x10076338 */
            ii(0x100e_3757, 3); lea(ebx, memd[ss, ebp - 0x10]);         /* lea ebx, [ebp-0x10] */
            ii(0x100e_375a, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_375c, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100e_375e, 5); call(0x1007_64b8, -0x6_d2ab);           /* call 0x100764b8 */
            ii(0x100e_3763, 4); mov(memb[ss, ebp - 0xc], 0);            /* mov byte [ebp-0xc], 0x0 */
            ii(0x100e_3767, 2); jmp(0x100e_3771, 0x8); goto l_0x100e_3771; /* jmp 0x100e3771 */
        l_0x100e_3769:
            ii(0x100e_3769, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x100e_376c, 5); call(0x1007_6bf8, -0x6_cb79);           /* call 0x10076bf8 */
        l_0x100e_3771:
            ii(0x100e_3771, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_3773, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x100e_3776, 5); call(0x1013_ad71, 0x5_75f6);            /* call 0x1013ad71 */
            ii(0x100e_377b, 2); test(al, al);                           /* test al, al */
            ii(0x100e_377d, 2); if(jz(0x100e_37ad, 0x2e)) goto l_0x100e_37ad; /* jz 0x100e37ad */
            ii(0x100e_377f, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x100e_3782, 5); call(0x1007_63d4, -0x6_d3b3);           /* call 0x100763d4 */
            ii(0x100e_3787, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_3789, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100e_378c, 5); call(0x100e_2f04, -0x88d);              /* call 0x100e2f04 */
            ii(0x100e_3791, 2); test(al, al);                           /* test al, al */
            ii(0x100e_3793, 2); if(jz(0x100e_37ab, 0x16)) goto l_0x100e_37ab; /* jz 0x100e37ab */
            ii(0x100e_3795, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x100e_3798, 5); call(0x1007_63d4, -0x6_d3c9);           /* call 0x100763d4 */
            ii(0x100e_379d, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_379f, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100e_37a2, 5); call(0x100e_32c2, -0x4e5);              /* call 0x100e32c2 */
            ii(0x100e_37a7, 4); mov(memb[ss, ebp - 0xc], 0x1);          /* mov byte [ebp-0xc], 0x1 */
        l_0x100e_37ab:
            ii(0x100e_37ab, 2); jmp(0x100e_3769, -0x44); goto l_0x100e_3769; /* jmp 0x100e3769 */
        l_0x100e_37ad:
            ii(0x100e_37ad, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100e_37b2, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100e_37b5, 5); call(0x100e_41e7, 0xa2d);               /* call 0x100e41e7 */
            ii(0x100e_37ba, 4); cmp(memb[ss, ebp - 0xc], 0);            /* cmp byte [ebp-0xc], 0x0 */
            ii(0x100e_37be, 2); if(jz(0x100e_37dc, 0x1c)) goto l_0x100e_37dc; /* jz 0x100e37dc */
            ii(0x100e_37c0, 5); call(0x100d_5470, -0xe355);             /* call 0x100d5470 */
            ii(0x100e_37c5, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100e_37c8, 5); mov(ebx, 0x3e5);                        /* mov ebx, 0x3e5 */
            ii(0x100e_37cd, 5); mov(edx, 0x3e4);                        /* mov edx, 0x3e4 */
            ii(0x100e_37d2, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x100e_37d7, 5); call(0x1013_daea, 0x5_a30e);            /* call 0x1013daea */
        l_0x100e_37dc:
            ii(0x100e_37dc, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_37de, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x100e_37e1, 5); call(0x1007_5f6c, -0x6_d87a);           /* call 0x10075f6c */
            ii(0x100e_37e6, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_37e8, 1); pop(ebp);                               /* pop ebp */
            ii(0x100e_37e9, 1); pop(edi);                               /* pop edi */
            ii(0x100e_37ea, 1); pop(esi);                               /* pop esi */
            ii(0x100e_37eb, 1); pop(ecx);                               /* pop ecx */
            ii(0x100e_37ec, 1); pop(ebx);                               /* pop ebx */
            ii(0x100e_37ed, 1); ret();                                  /* ret */
        }
    }
}
