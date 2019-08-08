using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("da21f9a0-0e83-4ea2-a3d0-d867aa5812df")]
        public void my_ctor_0x101b6edc()
        {
            ii(0x1007_6e44, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1007_6e49, 5); calld(Definitions.sys_check_available_stack_size, 0xe_ef04); /* call 0x10165d52 */
            ii(0x1007_6e4e, 1); pushd(ebx);                             /* push ebx */
            ii(0x1007_6e4f, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_6e50, 1); pushd(edx);                             /* push edx */
            ii(0x1007_6e51, 1); pushd(esi);                             /* push esi */
            ii(0x1007_6e52, 1); pushd(edi);                             /* push edi */
            ii(0x1007_6e53, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_6e54, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_6e56, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1007_6e5c, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1007_6e5f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_6e62, 6); mov(memd_a32[ds, eax], 0);              /* mov dword [eax], 0x0 */
            ii(0x1007_6e68, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_6e6b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1007_6e6e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_6e71, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_6e73, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_6e74, 1); popd(edi);                              /* pop edi */
            ii(0x1007_6e75, 1); popd(esi);                              /* pop esi */
            ii(0x1007_6e76, 1); popd(edx);                              /* pop edx */
            ii(0x1007_6e77, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_6e78, 1); popd(ebx);                              /* pop ebx */
            ii(0x1007_6e79, 1); retd(); return;                         /* ret */
        }
    }
}
