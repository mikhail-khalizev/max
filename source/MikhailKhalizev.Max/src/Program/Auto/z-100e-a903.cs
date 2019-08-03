using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("62bb0762-58e5-40a5-8c62-3ada2ebdfedf")]
        public void Method_100e_a903()
        {
            ii(0x100e_a903, 5); pushd(0x1c);                            /* push 0x1c */
            ii(0x100e_a908, 5); calld(Definitions.sys_check_available_stack_size, 0x7b445); /* call 0x10165d52 */
            ii(0x100e_a90d, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_a90e, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_a90f, 1); pushd(edx);                             /* push edx */
            ii(0x100e_a910, 1); pushd(esi);                             /* push esi */
            ii(0x100e_a911, 1); pushd(edi);                             /* push edi */
            ii(0x100e_a912, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_a913, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_a915, 6); sub(esp, 0);                            /* sub esp, 0x0 */
            ii(0x100e_a91b, 5); mov(eax, 0x101c_3664);                  /* mov eax, 0x101c3664 */
            ii(0x100e_a920, 5); calld(0x1009_cb94, -0x4dd91);           /* call 0x1009cb94 */
            ii(0x100e_a925, 7); mov(memb_a32[ds, 0x101c_3674], 0);      /* mov byte [0x101c3674], 0x0 */
            ii(0x100e_a92c, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_a92d, 1); popd(edi);                              /* pop edi */
            ii(0x100e_a92e, 1); popd(esi);                              /* pop esi */
            ii(0x100e_a92f, 1); popd(edx);                              /* pop edx */
            ii(0x100e_a930, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_a931, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_a932, 1); retd(); return;                         /* ret */
        }
    }
}
