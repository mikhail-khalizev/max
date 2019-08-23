using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_bbf8-89b3f2f1")]
        public void Method_1009_bbf8()
        {
            ii(0x1009_bbf8, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1009_bbfd, 5); calld(Definitions.sys_check_available_stack_size, 0xc_a150); /* call 0x10165d52 */
            ii(0x1009_bc02, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_bc03, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_bc04, 1); pushd(esi);                             /* push esi */
            ii(0x1009_bc05, 1); pushd(edi);                             /* push edi */
            ii(0x1009_bc06, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_bc07, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_bc09, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1009_bc0f, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_bc12, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1009_bc15, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1009_bc1a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_bc1d, 5); calld(Definitions.my_dtor_0x101b_6edc, 0x9_f023); /* call 0x1013ac45 */
            ii(0x1009_bc22, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_bc25, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_bc28, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1009_bc2b, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_bc2e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_bc30, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_bc31, 1); popd(edi);                              /* pop edi */
            ii(0x1009_bc32, 1); popd(esi);                              /* pop esi */
            ii(0x1009_bc33, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_bc34, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_bc35, 1); retd();                                 /* ret */
        }
    }
}
