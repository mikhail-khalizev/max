using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_0e00-9c631a9d")]
        public void Method_100e_0e00()
        {
            ii(0x100e_0e00, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100e_0e05, 5); calld(Definitions.sys_check_available_stack_size, 0x8_4f48); /* call 0x10165d52 */
            ii(0x100e_0e0a, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_0e0b, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_0e0c, 1); pushd(edx);                             /* push edx */
            ii(0x100e_0e0d, 1); pushd(esi);                             /* push esi */
            ii(0x100e_0e0e, 1); pushd(edi);                             /* push edi */
            ii(0x100e_0e0f, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_0e10, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_0e12, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100e_0e18, 3); mov(memb_a32[ss, ebp - 0x4], al);       /* mov [ebp-0x4], al */
            ii(0x100e_0e1b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_0e1d, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_0e1e, 1); popd(edi);                              /* pop edi */
            ii(0x100e_0e1f, 1); popd(esi);                              /* pop esi */
            ii(0x100e_0e20, 1); popd(edx);                              /* pop edx */
            ii(0x100e_0e21, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_0e22, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_0e23, 1); retd();                                 /* ret */
        }
    }
}
