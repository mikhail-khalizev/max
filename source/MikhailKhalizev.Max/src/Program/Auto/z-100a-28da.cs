using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("d569bc58-42d2-4af2-bb8c-b90ff9250c88")]
        public void Method_100a_28da()
        {
            ii(0x100a_28da, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100a_28df, 5); calld(Definitions.sys_check_available_stack_size, 0xc_346e); /* call 0x10165d52 */
            ii(0x100a_28e4, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_28e5, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_28e6, 1); pushd(esi);                             /* push esi */
            ii(0x100a_28e7, 1); pushd(edi);                             /* push edi */
            ii(0x100a_28e8, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_28e9, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_28eb, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100a_28f1, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_28f4, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100a_28f7, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_28f9, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_28fa, 1); popd(edi);                              /* pop edi */
            ii(0x100a_28fb, 1); popd(esi);                              /* pop esi */
            ii(0x100a_28fc, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_28fd, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_28fe, 1); retd(); return;                         /* ret */
        }
    }
}
