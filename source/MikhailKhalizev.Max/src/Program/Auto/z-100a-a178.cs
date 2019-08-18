using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("3c1ea2d3-ef0e-4263-97b6-c2811646a5b7")]
        public void Method_100a_a178()
        {
            ii(0x100a_a178, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100a_a17d, 5); calld(Definitions.sys_check_available_stack_size, 0xb_bbd0); /* call 0x10165d52 */
            ii(0x100a_a182, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_a183, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_a184, 1); pushd(esi);                             /* push esi */
            ii(0x100a_a185, 1); pushd(edi);                             /* push edi */
            ii(0x100a_a186, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_a187, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_a189, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100a_a18f, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_a192, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100a_a195, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100a_a19a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_a19d, 5); calld(0x1007_5e24, -0x3_437e);          /* call 0x10075e24 */
            ii(0x100a_a1a2, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_a1a5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_a1a8, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_a1ab, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_a1ae, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_a1b0, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_a1b1, 1); popd(edi);                              /* pop edi */
            ii(0x100a_a1b2, 1); popd(esi);                              /* pop esi */
            ii(0x100a_a1b3, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_a1b4, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_a1b5, 1); retd(); return;                         /* ret */
        }
    }
}
