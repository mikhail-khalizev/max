using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("b27f7ae5-51fd-43f8-8f7e-aa6d9cb956ce")]
        public void Method_1014_a86a()
        {
            ii(0x1014_a86a, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1014_a86f, 5); calld(Definitions.sys_check_available_stack_size, 0x1b4de); /* call 0x10165d52 */
            ii(0x1014_a874, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_a875, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_a876, 1); pushd(edx);                             /* push edx */
            ii(0x1014_a877, 1); pushd(esi);                             /* push esi */
            ii(0x1014_a878, 1); pushd(edi);                             /* push edi */
            ii(0x1014_a879, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_a87a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_a87c, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1014_a882, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1014_a885, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_a888, 5); add(eax, 0x94);                         /* add eax, 0x94 */
            ii(0x1014_a88d, 5); calld(0x1008_aef4, -0xbf99e);           /* call 0x1008aef4 */
            ii(0x1014_a892, 3); lea(ebx, ebp - 0x8);                    /* lea ebx, [ebp-0x8] */
            ii(0x1014_a895, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_a897, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1014_a899, 5); calld(0x1008_ae70, -0xbfa2e);           /* call 0x1008ae70 */
            ii(0x1014_a89e, 2); jmpd(0x1014_a8a8, 0x8); goto l_0x1014_a8a8; /* jmp 0x1014a8a8 */
        l_0x1014_a8a0:
            ii(0x1014_a8a0, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1014_a8a3, 5); calld(0x1007_6bf8, -0xd3cb0);           /* call 0x10076bf8 */
        l_0x1014_a8a8:
            ii(0x1014_a8a8, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_a8aa, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1014_a8ad, 5); calld(0x1013_ad71, -0xfb41);            /* call 0x1013ad71 */
            ii(0x1014_a8b2, 2); test(al, al);                           /* test al, al */
            ii(0x1014_a8b4, 2); if(jzd(0x1014_a8d2, 0x1c)) goto l_0x1014_a8d2; /* jz 0x1014a8d2 */
            ii(0x1014_a8b6, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1014_a8b9, 5); calld(0x1008_adc4, -0xbfafa);           /* call 0x1008adc4 */
            ii(0x1014_a8be, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1014_a8c1, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_a8c4, 3); mov(ebx, memd_a32[ds, eax + 0x2]);      /* mov ebx, [eax+0x2] */
            ii(0x1014_a8c7, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1014_a8ca, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_a8cd, 3); calld_abs(memd_a32[ds, ebx + 0x54]);    /* call dword [ebx+0x54] */
            ii(0x1014_a8d0, 2); jmpd(0x1014_a8a0, -0x32); goto l_0x1014_a8a0; /* jmp 0x1014a8a0 */
        l_0x1014_a8d2:
            ii(0x1014_a8d2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_a8d5, 5); add(eax, 0x94);                         /* add eax, 0x94 */
            ii(0x1014_a8da, 5); calld(0x1013_a6f4, -0x101eb);           /* call 0x1013a6f4 */
            ii(0x1014_a8df, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_a8e1, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1014_a8e4, 5); calld(0x1008_8bbc, -0xc1d2d);           /* call 0x10088bbc */
            ii(0x1014_a8e9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_a8eb, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_a8ec, 1); popd(edi);                              /* pop edi */
            ii(0x1014_a8ed, 1); popd(esi);                              /* pop esi */
            ii(0x1014_a8ee, 1); popd(edx);                              /* pop edx */
            ii(0x1014_a8ef, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_a8f0, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_a8f1, 1); retd(); return;                         /* ret */
        }
    }
}
