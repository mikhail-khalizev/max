using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("bb99688f-193e-4801-a495-71d1fe94ddcd")]
        public void Method_1012_0c30()
        {
            ii(0x1012_0c30, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1012_0c35, 5); calld(Definitions.sys_check_available_stack_size, 0x4_5118); /* call 0x10165d52 */
            ii(0x1012_0c3a, 1); pushd(ebx);                             /* push ebx */
            ii(0x1012_0c3b, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_0c3c, 1); pushd(edx);                             /* push edx */
            ii(0x1012_0c3d, 1); pushd(esi);                             /* push esi */
            ii(0x1012_0c3e, 1); pushd(edi);                             /* push edi */
            ii(0x1012_0c3f, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_0c40, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_0c42, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1012_0c48, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1012_0c4b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_0c4e, 4); mov(ax, memw_a32[ds, eax + 0x8]);       /* mov ax, [eax+0x8] */
            ii(0x1012_0c52, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1012_0c55, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_0c58, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_0c5a, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_0c5b, 1); popd(edi);                              /* pop edi */
            ii(0x1012_0c5c, 1); popd(esi);                              /* pop esi */
            ii(0x1012_0c5d, 1); popd(edx);                              /* pop edx */
            ii(0x1012_0c5e, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_0c5f, 1); popd(ebx);                              /* pop ebx */
            ii(0x1012_0c60, 1); retd(); return;                         /* ret */
        }
    }
}
