using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_d644-7501bfa5")]
        public void Method_1010_d644()
        {
            ii(0x1010_d644, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1010_d649, 5); calld(Definitions.sys_check_available_stack_size, 0x5_8704); /* call 0x10165d52 */
            ii(0x1010_d64e, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_d64f, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_d650, 1); pushd(edx);                             /* push edx */
            ii(0x1010_d651, 1); pushd(esi);                             /* push esi */
            ii(0x1010_d652, 1); pushd(edi);                             /* push edi */
            ii(0x1010_d653, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_d654, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_d656, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1010_d65c, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1010_d65f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_d662, 7); mov(memd_a32[ds, eax + 0x4], 0x1);      /* mov dword [eax+0x4], 0x1 */
            ii(0x1010_d669, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_d66b, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_d66c, 1); popd(edi);                              /* pop edi */
            ii(0x1010_d66d, 1); popd(esi);                              /* pop esi */
            ii(0x1010_d66e, 1); popd(edx);                              /* pop edx */
            ii(0x1010_d66f, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_d670, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_d671, 1); retd();                                 /* ret */
        }
    }
}
