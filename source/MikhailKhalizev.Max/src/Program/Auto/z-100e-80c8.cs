using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a5ac2d7a-9e64-4a9d-a9dc-fb94a82d57ba")]
        public void Method_100e_80c8()
        {
            ii(0x100e_80c8, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100e_80cd, 5); calld(Definitions.sys_check_available_stack_size, 0x7_dc80); /* call 0x10165d52 */
            ii(0x100e_80d2, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_80d3, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_80d4, 1); pushd(edx);                             /* push edx */
            ii(0x100e_80d5, 1); pushd(esi);                             /* push esi */
            ii(0x100e_80d6, 1); pushd(edi);                             /* push edi */
            ii(0x100e_80d7, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_80d8, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_80da, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100e_80e0, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100e_80e3, 5); calld(0x100e_85b8, 0x4d0);              /* call 0x100e85b8 */
            ii(0x100e_80e8, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100e_80eb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_80ee, 5); calld(0x100e_8564, 0x471);              /* call 0x100e8564 */
            ii(0x100e_80f3, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_80f6, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_80f9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_80fb, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_80fc, 1); popd(edi);                              /* pop edi */
            ii(0x100e_80fd, 1); popd(esi);                              /* pop esi */
            ii(0x100e_80fe, 1); popd(edx);                              /* pop edx */
            ii(0x100e_80ff, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_8100, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_8101, 1); retd(); return;                         /* ret */
        }
    }
}
