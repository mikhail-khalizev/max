using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c09aa8f8-2c5e-462a-9547-b3355e28dd57")]
        public void Method_100d_4fbc()
        {
            ii(0x100d_4fbc, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100d_4fc1, 5); calld(Definitions.sys_check_available_stack_size, 0x9_0d8c); /* call 0x10165d52 */
            ii(0x100d_4fc6, 1); pushd(ebx);                             /* push ebx */
            ii(0x100d_4fc7, 1); pushd(ecx);                             /* push ecx */
            ii(0x100d_4fc8, 1); pushd(edx);                             /* push edx */
            ii(0x100d_4fc9, 1); pushd(esi);                             /* push esi */
            ii(0x100d_4fca, 1); pushd(edi);                             /* push edi */
            ii(0x100d_4fcb, 1); pushd(ebp);                             /* push ebp */
            ii(0x100d_4fcc, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_4fce, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100d_4fd4, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100d_4fd7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_4fda, 3); mov(eax, memd_a32[ds, eax + 0x4]);      /* mov eax, [eax+0x4] */
            ii(0x100d_4fdd, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100d_4fe0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_4fe3, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_4fe5, 1); popd(ebp);                              /* pop ebp */
            ii(0x100d_4fe6, 1); popd(edi);                              /* pop edi */
            ii(0x100d_4fe7, 1); popd(esi);                              /* pop esi */
            ii(0x100d_4fe8, 1); popd(edx);                              /* pop edx */
            ii(0x100d_4fe9, 1); popd(ecx);                              /* pop ecx */
            ii(0x100d_4fea, 1); popd(ebx);                              /* pop ebx */
            ii(0x100d_4feb, 1); retd(); return;                         /* ret */
        }
    }
}
