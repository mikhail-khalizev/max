using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a5b1c4de-5c5b-43b9-8c65-b57e40d38996")]
        public void Method_100a_2fc1()
        {
            ii(0x100a_2fc1, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100a_2fc6, 5); calld(Definitions.sys_check_available_stack_size, 0xc_2d87); /* call 0x10165d52 */
            ii(0x100a_2fcb, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_2fcc, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_2fcd, 1); pushd(esi);                             /* push esi */
            ii(0x100a_2fce, 1); pushd(edi);                             /* push edi */
            ii(0x100a_2fcf, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_2fd0, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_2fd2, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100a_2fd8, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_2fdb, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100a_2fde, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_2fe0, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_2fe1, 1); popd(edi);                              /* pop edi */
            ii(0x100a_2fe2, 1); popd(esi);                              /* pop esi */
            ii(0x100a_2fe3, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_2fe4, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_2fe5, 1); retd(); return;                         /* ret */
        }
    }
}
