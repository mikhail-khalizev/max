using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_5946-c5cb09b7")]
        public void Method_1014_5946()
        {
            ii(0x1014_5946, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1014_594b, 5); calld(Definitions.sys_check_available_stack_size, 0x2_0402); /* call 0x10165d52 */
            ii(0x1014_5950, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_5951, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_5952, 1); pushd(esi);                             /* push esi */
            ii(0x1014_5953, 1); pushd(edi);                             /* push edi */
            ii(0x1014_5954, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_5955, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_5957, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1014_595d, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_5960, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1014_5963, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1014_5966, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_5969, 5); calld(0x1014_5725, -0x249);             /* call 0x10145725 */
            ii(0x1014_596e, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1014_5971, 4); cmp(memd_a32[ss, ebp - 0x10], 0);       /* cmp dword [ebp-0x10], 0x0 */
            ii(0x1014_5975, 2); if(jnzd(0x1014_5980, 0x9)) goto l_0x1014_5980; /* jnz 0x10145980 */
            ii(0x1014_5977, 7); mov(memd_a32[ss, ebp - 0xc], 0);        /* mov dword [ebp-0xc], 0x0 */
            ii(0x1014_597e, 2); jmpd(0x1014_598b, 0xb); goto l_0x1014_598b; /* jmp 0x1014598b */
        l_0x1014_5980:
            ii(0x1014_5980, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_5983, 5); calld(0x1014_7c10, 0x2288);             /* call 0x10147c10 */
            ii(0x1014_5988, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
        l_0x1014_598b:
            ii(0x1014_598b, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_598e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_5990, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_5991, 1); popd(edi);                              /* pop edi */
            ii(0x1014_5992, 1); popd(esi);                              /* pop esi */
            ii(0x1014_5993, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_5994, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_5995, 1); retd();                                 /* ret */
        }
    }
}
