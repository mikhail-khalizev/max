using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_07bc-e1a9421c")]
        public void Method_100e_07bc()
        {
            ii(0x100e_07bc, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100e_07c1, 5); calld(Definitions.sys_check_available_stack_size, 0x8_558c); /* call 0x10165d52 */
            ii(0x100e_07c6, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_07c7, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_07c8, 1); pushd(esi);                             /* push esi */
            ii(0x100e_07c9, 1); pushd(edi);                             /* push edi */
            ii(0x100e_07ca, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_07cb, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_07cd, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100e_07d3, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_07d6, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100e_07d9, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100e_07dc, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_07df, 5); calld(0x1013_acc5, 0x5_a4e1);           /* call 0x1013acc5 */
            ii(0x100e_07e4, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100e_07e7, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_07ea, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_07ec, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_07ed, 1); popd(edi);                              /* pop edi */
            ii(0x100e_07ee, 1); popd(esi);                              /* pop esi */
            ii(0x100e_07ef, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_07f0, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_07f1, 1); retd(); return;                         /* ret */
        }
    }
}
