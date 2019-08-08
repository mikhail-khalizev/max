using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("90147aea-ab09-45b7-9364-409d3af898cd")]
        public void Method_1007_6b90()
        {
            ii(0x1007_6b90, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1007_6b95, 5); calld(Definitions.sys_check_available_stack_size, 0xe_f1b8); /* call 0x10165d52 */
            ii(0x1007_6b9a, 1); pushd(ebx);                             /* push ebx */
            ii(0x1007_6b9b, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_6b9c, 1); pushd(edx);                             /* push edx */
            ii(0x1007_6b9d, 1); pushd(esi);                             /* push esi */
            ii(0x1007_6b9e, 1); pushd(edi);                             /* push edi */
            ii(0x1007_6b9f, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_6ba0, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_6ba2, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1007_6ba8, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1007_6bab, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_6bae, 3); mov(ax, memw_a32[ds, eax]);             /* mov ax, [eax] */
            ii(0x1007_6bb1, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1007_6bb4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_6bb7, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_6bb9, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_6bba, 1); popd(edi);                              /* pop edi */
            ii(0x1007_6bbb, 1); popd(esi);                              /* pop esi */
            ii(0x1007_6bbc, 1); popd(edx);                              /* pop edx */
            ii(0x1007_6bbd, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_6bbe, 1); popd(ebx);                              /* pop ebx */
            ii(0x1007_6bbf, 1); retd(); return;                         /* ret */
        }
    }
}
