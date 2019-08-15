using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("53f752cc-a032-4a9b-acc5-cd6879aeb7b7")]
        public void Method_100e_38b3()
        {
            ii(0x100e_38b3, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x100e_38b8, 5); calld(Definitions.sys_check_available_stack_size, 0x8_2495); /* call 0x10165d52 */
            ii(0x100e_38bd, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_38be, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_38bf, 1); pushd(esi);                             /* push esi */
            ii(0x100e_38c0, 1); pushd(edi);                             /* push edi */
            ii(0x100e_38c1, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_38c2, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_38c4, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100e_38ca, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_38cd, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100e_38d0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_38d3, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100e_38d6, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_38d9, 3); add(eax, 0x1c);                         /* add eax, 0x1c */
            ii(0x100e_38dc, 5); calld(0x1007_6338, -0x6_d5a9);          /* call 0x10076338 */
            ii(0x100e_38e1, 3); lea(ebx, ebp - 0xc);                    /* lea ebx, [ebp-0xc] */
            ii(0x100e_38e4, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_38e6, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100e_38e8, 5); calld(0x1007_64b8, -0x6_d435);          /* call 0x100764b8 */
            ii(0x100e_38ed, 2); jmpd(0x100e_38f7, 0x8); goto l_0x100e_38f7; /* jmp 0x100e38f7 */
        l_0x100e_38ef:
            ii(0x100e_38ef, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100e_38f2, 5); calld(0x1007_6bf8, -0x6_ccff);          /* call 0x10076bf8 */
        l_0x100e_38f7:
            ii(0x100e_38f7, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_38f9, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100e_38fc, 5); calld(0x1013_ad71, 0x5_7470);           /* call 0x1013ad71 */
            ii(0x100e_3901, 2); test(al, al);                           /* test al, al */
            ii(0x100e_3903, 2); if(jzd(0x100e_3919, 0x14)) goto l_0x100e_3919; /* jz 0x100e3919 */
            ii(0x100e_3905, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100e_3908, 5); calld(0x1007_63d4, -0x6_d539);          /* call 0x100763d4 */
            ii(0x100e_390d, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_390f, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_3912, 5); calld(0x100e_33cc, -0x54b);             /* call 0x100e33cc */
            ii(0x100e_3917, 2); jmpd(0x100e_38ef, -0x2a); goto l_0x100e_38ef; /* jmp 0x100e38ef */
        l_0x100e_3919:
            ii(0x100e_3919, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100e_391e, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_3921, 5); calld(0x100e_41e7, 0x8c1);              /* call 0x100e41e7 */
            ii(0x100e_3926, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_3928, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100e_392b, 5); calld(0x1007_5f6c, -0x6_d9c4);          /* call 0x10075f6c */
            ii(0x100e_3930, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_3932, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_3933, 1); popd(edi);                              /* pop edi */
            ii(0x100e_3934, 1); popd(esi);                              /* pop esi */
            ii(0x100e_3935, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_3936, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_3937, 1); retd(); return;                         /* ret */
        }
    }
}
