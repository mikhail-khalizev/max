using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_0a5c-958ff7a9")]
        public void Method_1012_0a5c()
        {
            ii(0x1012_0a5c, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1012_0a61, 5); calld(Definitions.sys_check_available_stack_size, 0x4_52ec); /* call 0x10165d52 */
            ii(0x1012_0a66, 1); pushd(ebx);                             /* push ebx */
            ii(0x1012_0a67, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_0a68, 1); pushd(edx);                             /* push edx */
            ii(0x1012_0a69, 1); pushd(esi);                             /* push esi */
            ii(0x1012_0a6a, 1); pushd(edi);                             /* push edi */
            ii(0x1012_0a6b, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_0a6c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_0a6e, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1012_0a74, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1012_0a77, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_0a7a, 7); mov(ax, memw_a32[ds, eax + 0xd5]);      /* mov ax, [eax+0xd5] */
            ii(0x1012_0a81, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1012_0a84, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_0a87, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_0a89, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_0a8a, 1); popd(edi);                              /* pop edi */
            ii(0x1012_0a8b, 1); popd(esi);                              /* pop esi */
            ii(0x1012_0a8c, 1); popd(edx);                              /* pop edx */
            ii(0x1012_0a8d, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_0a8e, 1); popd(ebx);                              /* pop ebx */
            ii(0x1012_0a8f, 1); retd(); return;                         /* ret */
        }
    }
}
