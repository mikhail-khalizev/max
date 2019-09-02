using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_a86a-64c24012")]
        public void Method_1014_a86a()
        {
            ii(0x1014_a86a, 5); push(0x28);                             /* push 0x28 */
            ii(0x1014_a86f, 5); call(Definitions.sys_check_available_stack_size, 0x1_b4de); /* call 0x10165d52 */
            ii(0x1014_a874, 1); push(ebx);                              /* push ebx */
            ii(0x1014_a875, 1); push(ecx);                              /* push ecx */
            ii(0x1014_a876, 1); push(edx);                              /* push edx */
            ii(0x1014_a877, 1); push(esi);                              /* push esi */
            ii(0x1014_a878, 1); push(edi);                              /* push edi */
            ii(0x1014_a879, 1); push(ebp);                              /* push ebp */
            ii(0x1014_a87a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_a87c, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1014_a882, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1014_a885, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_a888, 5); add(eax, 0x94);                         /* add eax, 0x94 */
            ii(0x1014_a88d, 5); call(0x1008_aef4, -0xb_f99e);           /* call 0x1008aef4 */
            ii(0x1014_a892, 3); lea(ebx, memd[ss, ebp - 8]);            /* lea ebx, [ebp-0x8] */
            ii(0x1014_a895, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_a897, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1014_a899, 5); call(0x1008_ae70, -0xb_fa2e);           /* call 0x1008ae70 */
            ii(0x1014_a89e, 2); jmp(0x1014_a8a8, 8); goto l_0x1014_a8a8; /* jmp 0x1014a8a8 */
        l_0x1014_a8a0:
            ii(0x1014_a8a0, 3); lea(eax, memd[ss, ebp - 8]);            /* lea eax, [ebp-0x8] */
            ii(0x1014_a8a3, 5); call(0x1007_6bf8, -0xd_3cb0);           /* call 0x10076bf8 */
        l_0x1014_a8a8:
            ii(0x1014_a8a8, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_a8aa, 3); lea(eax, memd[ss, ebp - 8]);            /* lea eax, [ebp-0x8] */
            ii(0x1014_a8ad, 5); call(0x1013_ad71, -0xfb41);             /* call 0x1013ad71 */
            ii(0x1014_a8b2, 2); test(al, al);                           /* test al, al */
            ii(0x1014_a8b4, 2); if(jz(0x1014_a8d2, 0x1c)) goto l_0x1014_a8d2; /* jz 0x1014a8d2 */
            ii(0x1014_a8b6, 3); lea(eax, memd[ss, ebp - 8]);            /* lea eax, [ebp-0x8] */
            ii(0x1014_a8b9, 5); call(0x1008_adc4, -0xb_fafa);           /* call 0x1008adc4 */
            ii(0x1014_a8be, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1014_a8c1, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1014_a8c4, 3); mov(ebx, memd[ds, eax + 2]);            /* mov ebx, [eax+0x2] */
            ii(0x1014_a8c7, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1014_a8ca, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1014_a8cd, 3); call_abs(memd[ds, ebx + 84]);           /* call dword [ebx+0x54] */
            ii(0x1014_a8d0, 2); jmp(0x1014_a8a0, -0x32); goto l_0x1014_a8a0; /* jmp 0x1014a8a0 */
        l_0x1014_a8d2:
            ii(0x1014_a8d2, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_a8d5, 5); add(eax, 0x94);                         /* add eax, 0x94 */
            ii(0x1014_a8da, 5); call(0x1013_a6f4, -0x1_01eb);           /* call 0x1013a6f4 */
            ii(0x1014_a8df, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_a8e1, 3); lea(eax, memd[ss, ebp - 8]);            /* lea eax, [ebp-0x8] */
            ii(0x1014_a8e4, 5); call(0x1008_8bbc, -0xc_1d2d);           /* call 0x10088bbc */
            ii(0x1014_a8e9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_a8eb, 1); pop(ebp);                               /* pop ebp */
            ii(0x1014_a8ec, 1); pop(edi);                               /* pop edi */
            ii(0x1014_a8ed, 1); pop(esi);                               /* pop esi */
            ii(0x1014_a8ee, 1); pop(edx);                               /* pop edx */
            ii(0x1014_a8ef, 1); pop(ecx);                               /* pop ecx */
            ii(0x1014_a8f0, 1); pop(ebx);                               /* pop ebx */
            ii(0x1014_a8f1, 1); ret();                                  /* ret */
        }
    }
}
