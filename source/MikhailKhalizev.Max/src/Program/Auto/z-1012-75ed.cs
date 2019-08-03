using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("76328ec1-548d-48c8-a4a8-74c2eccedce0")]
        public void Method_1012_75ed()
        {
            ii(0x1012_75ed, 5); pushd(0xd4);                            /* push 0xd4 */
            ii(0x1012_75f2, 5); calld(Definitions.sys_check_available_stack_size, 0x3e75b); /* call 0x10165d52 */
            ii(0x1012_75f7, 1); pushd(ebx);                             /* push ebx */
            ii(0x1012_75f8, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_75f9, 1); pushd(edx);                             /* push edx */
            ii(0x1012_75fa, 1); pushd(esi);                             /* push esi */
            ii(0x1012_75fb, 1); pushd(edi);                             /* push edi */
            ii(0x1012_75fc, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_75fd, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_75ff, 6); sub(esp, 0xac);                         /* sub esp, 0xac */
            ii(0x1012_7605, 7); mov(memd_a32[ss, ebp - 0x4], 0x101c_59f5); /* mov dword [ebp-0x4], 0x101c59f5 */
        }
    }
}
