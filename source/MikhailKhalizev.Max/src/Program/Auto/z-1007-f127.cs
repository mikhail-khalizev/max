using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("1dca419b-a242-4448-933b-ea28dd8291c1")]
        public void Method_1007_f127()
        {
            ii(0x1007_f127, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1007_f12c, 5); calld(Definitions.sys_check_available_stack_size, 0xe_6c21); /* call 0x10165d52 */
            ii(0x1007_f131, 1); pushd(ebx);                             /* push ebx */
            ii(0x1007_f132, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_f133, 1); pushd(edx);                             /* push edx */
            ii(0x1007_f134, 1); pushd(esi);                             /* push esi */
            ii(0x1007_f135, 1); pushd(edi);                             /* push edi */
            ii(0x1007_f136, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_f137, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_f139, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1007_f13f, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1007_f142, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_f145, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1007_f148, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_f14b, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x1007_f14e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_f151, 3); calld_abs(memd_a32[ds, edx + 0x4c]);    /* call dword [edx+0x4c] */
            ii(0x1007_f154, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_f156, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_f157, 1); popd(edi);                              /* pop edi */
            ii(0x1007_f158, 1); popd(esi);                              /* pop esi */
            ii(0x1007_f159, 1); popd(edx);                              /* pop edx */
            ii(0x1007_f15a, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_f15b, 1); popd(ebx);                              /* pop ebx */
            ii(0x1007_f15c, 1); retd(); return;                         /* ret */
        }
    }
}
