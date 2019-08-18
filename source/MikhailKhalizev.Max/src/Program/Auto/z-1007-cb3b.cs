using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_cb3b-58e00e0a")]
        public void Method_1007_cb3b()
        {
            ii(0x1007_cb3b, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1007_cb40, 5); calld(Definitions.sys_check_available_stack_size, 0xe_920d); /* call 0x10165d52 */
            ii(0x1007_cb45, 1); pushd(ebx);                             /* push ebx */
            ii(0x1007_cb46, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_cb47, 1); pushd(edx);                             /* push edx */
            ii(0x1007_cb48, 1); pushd(esi);                             /* push esi */
            ii(0x1007_cb49, 1); pushd(edi);                             /* push edi */
            ii(0x1007_cb4a, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_cb4b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_cb4d, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1007_cb53, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1007_cb56, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_cb59, 5); calld(0x1007_cbd0, 0x72);               /* call 0x1007cbd0 */
            ii(0x1007_cb5e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_cb60, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_cb61, 1); popd(edi);                              /* pop edi */
            ii(0x1007_cb62, 1); popd(esi);                              /* pop esi */
            ii(0x1007_cb63, 1); popd(edx);                              /* pop edx */
            ii(0x1007_cb64, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_cb65, 1); popd(ebx);                              /* pop ebx */
            ii(0x1007_cb66, 1); retd(); return;                         /* ret */
        }
    }
}
