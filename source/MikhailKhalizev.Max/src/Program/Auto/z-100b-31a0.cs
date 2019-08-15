using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("bb69495e-5a41-4d55-9c99-d17337ccd583")]
        public void Method_100b_31a0()
        {
            ii(0x100b_31a0, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100b_31a5, 5); calld(Definitions.sys_check_available_stack_size, 0xb_2ba8); /* call 0x10165d52 */
            ii(0x100b_31aa, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_31ab, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_31ac, 1); pushd(edx);                             /* push edx */
            ii(0x100b_31ad, 1); pushd(esi);                             /* push esi */
            ii(0x100b_31ae, 1); pushd(edi);                             /* push edi */
            ii(0x100b_31af, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_31b0, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_31b2, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100b_31b8, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100b_31bb, 4); mov(memb_a32[ss, ebp - 0x8], 0x26);     /* mov byte [ebp-0x8], 0x26 */
            ii(0x100b_31bf, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x100b_31c2, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_31c4, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_31c5, 1); popd(edi);                              /* pop edi */
            ii(0x100b_31c6, 1); popd(esi);                              /* pop esi */
            ii(0x100b_31c7, 1); popd(edx);                              /* pop edx */
            ii(0x100b_31c8, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_31c9, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_31ca, 1); retd(); return;                         /* ret */
        }
    }
}
