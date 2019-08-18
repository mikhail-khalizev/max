using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("9c71cfa7-f67d-4e97-88fb-c3fe4d030473")]
        public void Method_100d_4f58()
        {
            ii(0x100d_4f58, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100d_4f5d, 5); calld(Definitions.sys_check_available_stack_size, 0x9_0df0); /* call 0x10165d52 */
            ii(0x100d_4f62, 1); pushd(ebx);                             /* push ebx */
            ii(0x100d_4f63, 1); pushd(ecx);                             /* push ecx */
            ii(0x100d_4f64, 1); pushd(edx);                             /* push edx */
            ii(0x100d_4f65, 1); pushd(esi);                             /* push esi */
            ii(0x100d_4f66, 1); pushd(edi);                             /* push edi */
            ii(0x100d_4f67, 1); pushd(ebp);                             /* push ebp */
            ii(0x100d_4f68, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_4f6a, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100d_4f70, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100d_4f73, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_4f76, 4); mov(ax, memw_a32[ds, eax + 0x8]);       /* mov ax, [eax+0x8] */
            ii(0x100d_4f7a, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100d_4f7d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_4f80, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_4f82, 1); popd(ebp);                              /* pop ebp */
            ii(0x100d_4f83, 1); popd(edi);                              /* pop edi */
            ii(0x100d_4f84, 1); popd(esi);                              /* pop esi */
            ii(0x100d_4f85, 1); popd(edx);                              /* pop edx */
            ii(0x100d_4f86, 1); popd(ecx);                              /* pop ecx */
            ii(0x100d_4f87, 1); popd(ebx);                              /* pop ebx */
            ii(0x100d_4f88, 1); retd(); return;                         /* ret */
        }
    }
}
