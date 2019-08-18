using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("d69e1395-3dfc-401b-875e-efd48f5eb5a4")]
        public void Method_100d_4ef0()
        {
            ii(0x100d_4ef0, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100d_4ef5, 5); calld(Definitions.sys_check_available_stack_size, 0x9_0e58); /* call 0x10165d52 */
            ii(0x100d_4efa, 1); pushd(ebx);                             /* push ebx */
            ii(0x100d_4efb, 1); pushd(ecx);                             /* push ecx */
            ii(0x100d_4efc, 1); pushd(edx);                             /* push edx */
            ii(0x100d_4efd, 1); pushd(esi);                             /* push esi */
            ii(0x100d_4efe, 1); pushd(edi);                             /* push edi */
            ii(0x100d_4eff, 1); pushd(ebp);                             /* push ebp */
            ii(0x100d_4f00, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_4f02, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100d_4f08, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100d_4f0b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_4f0e, 4); mov(ax, memw_a32[ds, eax + 0x4]);       /* mov ax, [eax+0x4] */
            ii(0x100d_4f12, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100d_4f15, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_4f18, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_4f1a, 1); popd(ebp);                              /* pop ebp */
            ii(0x100d_4f1b, 1); popd(edi);                              /* pop edi */
            ii(0x100d_4f1c, 1); popd(esi);                              /* pop esi */
            ii(0x100d_4f1d, 1); popd(edx);                              /* pop edx */
            ii(0x100d_4f1e, 1); popd(ecx);                              /* pop ecx */
            ii(0x100d_4f1f, 1); popd(ebx);                              /* pop ebx */
            ii(0x100d_4f20, 1); retd(); return;                         /* ret */
        }
    }
}
