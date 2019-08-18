using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_af44-b27d19de")]
        public void Method_100a_af44()
        {
            ii(0x100a_af44, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100a_af49, 5); calld(Definitions.sys_check_available_stack_size, 0xb_ae04); /* call 0x10165d52 */
            ii(0x100a_af4e, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_af4f, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_af50, 1); pushd(esi);                             /* push esi */
            ii(0x100a_af51, 1); pushd(edi);                             /* push edi */
            ii(0x100a_af52, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_af53, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_af55, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100a_af5b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_af5e, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100a_af61, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100a_af64, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_af67, 5); calld(0x1007_6c98, -0x3_42d4);          /* call 0x10076c98 */
            ii(0x100a_af6c, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_af6f, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_af72, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_af74, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_af75, 1); popd(edi);                              /* pop edi */
            ii(0x100a_af76, 1); popd(esi);                              /* pop esi */
            ii(0x100a_af77, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_af78, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_af79, 1); retd(); return;                         /* ret */
        }
    }
}
