using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("396922bf-49a1-4517-941e-51de24e6a4ee")]
        public void Method_100a_11a0()
        {
            ii(0x100a_11a0, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100a_11a5, 5); calld(Definitions.sys_check_available_stack_size, 0xc_4ba8); /* call 0x10165d52 */
            ii(0x100a_11aa, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_11ab, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_11ac, 1); pushd(edx);                             /* push edx */
            ii(0x100a_11ad, 1); pushd(esi);                             /* push esi */
            ii(0x100a_11ae, 1); pushd(edi);                             /* push edi */
            ii(0x100a_11af, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_11b0, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_11b2, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100a_11b8, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100a_11bb, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_11bd, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_11be, 1); popd(edi);                              /* pop edi */
            ii(0x100a_11bf, 1); popd(esi);                              /* pop esi */
            ii(0x100a_11c0, 1); popd(edx);                              /* pop edx */
            ii(0x100a_11c1, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_11c2, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_11c3, 1); retd(); return;                         /* ret */
        }
    }
}
