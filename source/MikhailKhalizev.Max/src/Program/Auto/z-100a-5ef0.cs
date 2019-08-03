using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("1aa28e40-dfeb-40bd-9b97-287401d1bfc0")]
        public void Method_100a_5ef0()
        {
            ii(0x100a_5ef0, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x100a_5ef5, 5); calld(Definitions.sys_check_available_stack_size, 0xbfe58); /* call 0x10165d52 */
            ii(0x100a_5efa, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_5efb, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_5efc, 1); pushd(esi);                             /* push esi */
            ii(0x100a_5efd, 1); pushd(edi);                             /* push edi */
            ii(0x100a_5efe, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_5eff, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_5f01, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100a_5f07, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_5f0a, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100a_5f0d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_5f10, 5); calld(0x1008_aef4, -0x1b021);           /* call 0x1008aef4 */
            ii(0x100a_5f15, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_5f17, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100a_5f1a, 5); calld(0x1008_ae70, -0x1b0af);           /* call 0x1008ae70 */
            ii(0x100a_5f1f, 2); jmpd(0x100a_5f29, 0x8); goto l_0x100a_5f29; /* jmp 0x100a5f29 */
        l_0x100a_5f21:
            ii(0x100a_5f21, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100a_5f24, 5); calld(0x1007_6bf8, -0x2f331);           /* call 0x10076bf8 */
        l_0x100a_5f29:
            ii(0x100a_5f29, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_5f2b, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100a_5f2e, 5); calld(0x1013_ad71, 0x94e3e);            /* call 0x1013ad71 */
            ii(0x100a_5f33, 2); test(al, al);                           /* test al, al */
            ii(0x100a_5f35, 2); if(jzd(0x100a_5f53, 0x1c)) goto l_0x100a_5f53; /* jz 0x100a5f53 */
            ii(0x100a_5f37, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100a_5f3a, 5); calld(0x1008_adc4, -0x1b17b);           /* call 0x1008adc4 */
            ii(0x100a_5f3f, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100a_5f42, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100a_5f45, 3); mov(ebx, memd_a32[ds, eax + 0x2]);      /* mov ebx, [eax+0x2] */
            ii(0x100a_5f48, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100a_5f4b, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100a_5f4e, 3); calld_abs(memd_a32[ds, ebx + 0x64]);    /* call dword [ebx+0x64] */
            ii(0x100a_5f51, 2); jmpd(0x100a_5f21, -0x32); goto l_0x100a_5f21; /* jmp 0x100a5f21 */
        l_0x100a_5f53:
            ii(0x100a_5f53, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_5f55, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100a_5f58, 5); calld(0x1008_8bbc, -0x1d3a1);           /* call 0x10088bbc */
            ii(0x100a_5f5d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_5f5f, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_5f60, 1); popd(edi);                              /* pop edi */
            ii(0x100a_5f61, 1); popd(esi);                              /* pop esi */
            ii(0x100a_5f62, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_5f63, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_5f64, 1); retd(); return;                         /* ret */
        }
    }
}
