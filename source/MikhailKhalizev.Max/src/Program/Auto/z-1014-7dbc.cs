using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("413983ae-c4d0-4873-ade6-c2bb79b08629")]
        public void Method_1014_7dbc()
        {
            ii(0x1014_7dbc, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1014_7dc1, 5); calld(Definitions.sys_check_available_stack_size, 0x1df8c); /* call 0x10165d52 */
            ii(0x1014_7dc6, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_7dc7, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_7dc8, 1); pushd(esi);                             /* push esi */
            ii(0x1014_7dc9, 1); pushd(edi);                             /* push edi */
            ii(0x1014_7dca, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_7dcb, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_7dcd, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1014_7dd3, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_7dd6, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1014_7dd9, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1014_7ddc, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_7ddf, 5); calld(0x1007_6d14, -0xd10d0);           /* call 0x10076d14 */
            ii(0x1014_7de4, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_7de7, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1014_7dea, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1014_7ded, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_7df0, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1014_7df3, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_7df6, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_7df8, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_7df9, 1); popd(edi);                              /* pop edi */
            ii(0x1014_7dfa, 1); popd(esi);                              /* pop esi */
            ii(0x1014_7dfb, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_7dfc, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_7dfd, 1); retd(); return;                         /* ret */
        }
    }
}