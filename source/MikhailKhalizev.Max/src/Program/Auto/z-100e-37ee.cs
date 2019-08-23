using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_37ee-8a1d3214")]
        public void Method_100e_37ee()
        {
            ii(0x100e_37ee, 5); push(0x2c);                             /* push 0x2c */
            ii(0x100e_37f3, 5); call(Definitions.sys_check_available_stack_size, 0x8_255a); /* call 0x10165d52 */
            ii(0x100e_37f8, 1); push(ebx);                              /* push ebx */
            ii(0x100e_37f9, 1); push(ecx);                              /* push ecx */
            ii(0x100e_37fa, 1); push(esi);                              /* push esi */
            ii(0x100e_37fb, 1); push(edi);                              /* push edi */
            ii(0x100e_37fc, 1); push(ebp);                              /* push ebp */
            ii(0x100e_37fd, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_37ff, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x100e_3805, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100e_3808, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100e_380b, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_380e, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x100e_3811, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100e_3814, 3); add(eax, 0x1c);                         /* add eax, 0x1c */
            ii(0x100e_3817, 5); call(0x1007_6338, -0x6_d4e4);           /* call 0x10076338 */
            ii(0x100e_381c, 3); lea(ebx, ebp - 0x10);                   /* lea ebx, [ebp-0x10] */
            ii(0x100e_381f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_3821, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100e_3823, 5); call(0x1007_64b8, -0x6_d370);           /* call 0x100764b8 */
            ii(0x100e_3828, 4); mov(memb[ss, ebp - 0xc], 0);            /* mov byte [ebp-0xc], 0x0 */
            ii(0x100e_382c, 2); jmp(0x100e_3836, 0x8); goto l_0x100e_3836; /* jmp 0x100e3836 */
        l_0x100e_382e:
            ii(0x100e_382e, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100e_3831, 5); call(0x1007_6bf8, -0x6_cc3e);           /* call 0x10076bf8 */
        l_0x100e_3836:
            ii(0x100e_3836, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_3838, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100e_383b, 5); call(0x1013_ad71, 0x5_7531);            /* call 0x1013ad71 */
            ii(0x100e_3840, 2); test(al, al);                           /* test al, al */
            ii(0x100e_3842, 2); if(jz(0x100e_3872, 0x2e)) goto l_0x100e_3872; /* jz 0x100e3872 */
            ii(0x100e_3844, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100e_3847, 5); call(0x1007_63d4, -0x6_d478);           /* call 0x100763d4 */
            ii(0x100e_384c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_384e, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100e_3851, 5); call(0x100e_2f92, -0x8c4);              /* call 0x100e2f92 */
            ii(0x100e_3856, 2); test(al, al);                           /* test al, al */
            ii(0x100e_3858, 2); if(jz(0x100e_3870, 0x16)) goto l_0x100e_3870; /* jz 0x100e3870 */
            ii(0x100e_385a, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100e_385d, 5); call(0x1007_63d4, -0x6_d48e);           /* call 0x100763d4 */
            ii(0x100e_3862, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_3864, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100e_3867, 5); call(0x100e_3347, -0x525);              /* call 0x100e3347 */
            ii(0x100e_386c, 4); mov(memb[ss, ebp - 0xc], 0x1);          /* mov byte [ebp-0xc], 0x1 */
        l_0x100e_3870:
            ii(0x100e_3870, 2); jmp(0x100e_382e, -0x44); goto l_0x100e_382e; /* jmp 0x100e382e */
        l_0x100e_3872:
            ii(0x100e_3872, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100e_3877, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100e_387a, 5); call(0x100e_41e7, 0x968);               /* call 0x100e41e7 */
            ii(0x100e_387f, 4); cmp(memb[ss, ebp - 0xc], 0);            /* cmp byte [ebp-0xc], 0x0 */
            ii(0x100e_3883, 2); if(jz(0x100e_38a1, 0x1c)) goto l_0x100e_38a1; /* jz 0x100e38a1 */
            ii(0x100e_3885, 5); call(0x100d_5470, -0xe41a);             /* call 0x100d5470 */
            ii(0x100e_388a, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100e_388d, 5); mov(ebx, 0x3ef);                        /* mov ebx, 0x3ef */
            ii(0x100e_3892, 5); mov(edx, 0x3ee);                        /* mov edx, 0x3ee */
            ii(0x100e_3897, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x100e_389c, 5); call(0x1013_daea, 0x5_a249);            /* call 0x1013daea */
        l_0x100e_38a1:
            ii(0x100e_38a1, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_38a3, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100e_38a6, 5); call(0x1007_5f6c, -0x6_d93f);           /* call 0x10075f6c */
            ii(0x100e_38ab, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_38ad, 1); pop(ebp);                               /* pop ebp */
            ii(0x100e_38ae, 1); pop(edi);                               /* pop edi */
            ii(0x100e_38af, 1); pop(esi);                               /* pop esi */
            ii(0x100e_38b0, 1); pop(ecx);                               /* pop ecx */
            ii(0x100e_38b1, 1); pop(ebx);                               /* pop ebx */
            ii(0x100e_38b2, 1); ret();                                  /* ret */
        }
    }
}
