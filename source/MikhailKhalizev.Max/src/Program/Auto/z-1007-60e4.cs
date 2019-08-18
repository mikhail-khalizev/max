using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0ffcf056-60a7-493d-a4d2-8e7e3829cffd")]
        public void Method_1007_60e4()
        {
            ii(0x1007_60e4, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1007_60e9, 5); calld(Definitions.sys_check_available_stack_size, 0xe_fc64); /* call 0x10165d52 */
            ii(0x1007_60ee, 1); pushd(ebx);                             /* push ebx */
            ii(0x1007_60ef, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_60f0, 1); pushd(edx);                             /* push edx */
            ii(0x1007_60f1, 1); pushd(esi);                             /* push esi */
            ii(0x1007_60f2, 1); pushd(edi);                             /* push edi */
            ii(0x1007_60f3, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_60f4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_60f6, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1007_60fc, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1007_60ff, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_6102, 5); add(eax, 0x86);                         /* add eax, 0x86 */
            ii(0x1007_6107, 5); calld(0x1007_6600, 0x4f4);              /* call 0x10076600 */
            ii(0x1007_610c, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1007_610f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_6112, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_6114, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_6115, 1); popd(edi);                              /* pop edi */
            ii(0x1007_6116, 1); popd(esi);                              /* pop esi */
            ii(0x1007_6117, 1); popd(edx);                              /* pop edx */
            ii(0x1007_6118, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_6119, 1); popd(ebx);                              /* pop ebx */
            ii(0x1007_611a, 1); retd(); return;                         /* ret */
        }
    }
}
