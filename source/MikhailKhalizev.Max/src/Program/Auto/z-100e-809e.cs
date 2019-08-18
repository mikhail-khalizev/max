using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_809e-69f47c9f")]
        public void Method_100e_809e()
        {
            ii(0x100e_809e, 5); pushd(0x1c);                            /* push 0x1c */
            ii(0x100e_80a3, 5); calld(Definitions.sys_check_available_stack_size, 0x7_dcaa); /* call 0x10165d52 */
            ii(0x100e_80a8, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_80a9, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_80aa, 1); pushd(edx);                             /* push edx */
            ii(0x100e_80ab, 1); pushd(esi);                             /* push esi */
            ii(0x100e_80ac, 1); pushd(edi);                             /* push edi */
            ii(0x100e_80ad, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_80ae, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_80b0, 6); sub(esp, 0);                            /* sub esp, 0x0 */
            ii(0x100e_80b6, 5); mov(eax, 0x101c_3620);                  /* mov eax, 0x101c3620 */
            ii(0x100e_80bb, 5); calld(0x1009_cb94, -0x4_b52c);          /* call 0x1009cb94 */
            ii(0x100e_80c0, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_80c1, 1); popd(edi);                              /* pop edi */
            ii(0x100e_80c2, 1); popd(esi);                              /* pop esi */
            ii(0x100e_80c3, 1); popd(edx);                              /* pop edx */
            ii(0x100e_80c4, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_80c5, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_80c6, 1); retd(); return;                         /* ret */
        }
    }
}
