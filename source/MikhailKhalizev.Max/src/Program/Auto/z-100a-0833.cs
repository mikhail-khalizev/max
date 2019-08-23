using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_0833-ce8e1eda")]
        public void Method_100a_0833()
        {
            ii(0x100a_0833, 5); push(0x20);                             /* push 0x20 */
            ii(0x100a_0838, 5); call(Definitions.sys_check_available_stack_size, 0xc_5515); /* call 0x10165d52 */
            ii(0x100a_083d, 1); push(ebx);                              /* push ebx */
            ii(0x100a_083e, 1); push(ecx);                              /* push ecx */
            ii(0x100a_083f, 1); push(esi);                              /* push esi */
            ii(0x100a_0840, 1); push(edi);                              /* push edi */
            ii(0x100a_0841, 1); push(ebp);                              /* push ebp */
            ii(0x100a_0842, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_0844, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100a_084a, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100a_084d, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100a_0850, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_0853, 5); call(0x1007_6204, -0x2_a654);           /* call 0x10076204 */
            ii(0x100a_0858, 3); mov(ebx, memd[ss, ebp - 0x8]);          /* mov ebx, [ebp-0x8] */
            ii(0x100a_085b, 3); add(ebx, 0x2);                          /* add ebx, 0x2 */
            ii(0x100a_085e, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_0860, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100a_0862, 5); call(0x1007_6e00, -0x2_9a67);           /* call 0x10076e00 */
            ii(0x100a_0867, 2); test(al, al);                           /* test al, al */
            ii(0x100a_0869, 2); if(jz(0x100a_087e, 0x13)) goto l_0x100a_087e; /* jz 0x100a087e */
            ii(0x100a_086b, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_086e, 3); mov(eax, memd[ds, eax + 0x6]);          /* mov eax, [eax+0x6] */
            ii(0x100a_0871, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_0874, 5); call(0x1007_1f2e, -0x2_e94b);           /* call 0x10071f2e */
            ii(0x100a_0879, 1); cwde();                                 /* cwde */
            ii(0x100a_087a, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_087c, 2); if(jl(0x100a_0880, 0x2)) goto l_0x100a_0880; /* jl 0x100a0880 */
        l_0x100a_087e:
            ii(0x100a_087e, 2); jmp(0x100a_08c6, 0x46); goto l_0x100a_08c6; /* jmp 0x100a08c6 */
        l_0x100a_0880:
            ii(0x100a_0880, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_0883, 5); cmp(memw[ds, eax + 0x8], 0x2);          /* cmp word [eax+0x8], 0x2 */
            ii(0x100a_0888, 2); if(jnz(0x100a_08a9, 0x1f)) goto l_0x100a_08a9; /* jnz 0x100a08a9 */
            ii(0x100a_088a, 3); mov(ecx, memd[ss, ebp - 0x8]);          /* mov ecx, [ebp-0x8] */
            ii(0x100a_088d, 6); add(ecx, 0x373);                        /* add ecx, 0x373 */
            ii(0x100a_0893, 3); mov(ebx, memd[ss, ebp - 0x8]);          /* mov ebx, [ebp-0x8] */
            ii(0x100a_0896, 6); add(ebx, 0x36f);                        /* add ebx, 0x36f */
            ii(0x100a_089c, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x100a_089f, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_08a2, 5); call(0x100a_0774, -0x133);              /* call 0x100a0774 */
            ii(0x100a_08a7, 2); jmp(0x100a_08c6, 0x1d); goto l_0x100a_08c6; /* jmp 0x100a08c6 */
        l_0x100a_08a9:
            ii(0x100a_08a9, 3); mov(ecx, memd[ss, ebp - 0x8]);          /* mov ecx, [ebp-0x8] */
            ii(0x100a_08ac, 6); add(ecx, 0x371);                        /* add ecx, 0x371 */
            ii(0x100a_08b2, 3); mov(ebx, memd[ss, ebp - 0x8]);          /* mov ebx, [ebp-0x8] */
            ii(0x100a_08b5, 6); add(ebx, 0x36d);                        /* add ebx, 0x36d */
            ii(0x100a_08bb, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x100a_08be, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_08c1, 5); call(0x100a_0774, -0x152);              /* call 0x100a0774 */
        l_0x100a_08c6:
            ii(0x100a_08c6, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_08c8, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_08c9, 1); pop(edi);                               /* pop edi */
            ii(0x100a_08ca, 1); pop(esi);                               /* pop esi */
            ii(0x100a_08cb, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_08cc, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_08cd, 1); ret();                                  /* ret */
        }
    }
}
