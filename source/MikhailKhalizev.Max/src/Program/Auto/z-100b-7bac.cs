using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_7bac-92e48e0f")]
        public void Method_100b_7bac()
        {
            ii(0x100b_7bac, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100b_7bb1, 5); calld(Definitions.sys_check_available_stack_size, 0xa_e19c); /* call 0x10165d52 */
            ii(0x100b_7bb6, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_7bb7, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_7bb8, 1); pushd(esi);                             /* push esi */
            ii(0x100b_7bb9, 1); pushd(edi);                             /* push edi */
            ii(0x100b_7bba, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_7bbb, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_7bbd, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100b_7bc3, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_7bc6, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100b_7bc9, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100b_7bcc, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_7bcf, 5); calld(0x1013_a66b, 0x8_2a97);           /* call 0x1013a66b */
            ii(0x100b_7bd4, 3); mov(memb_a32[ss, ebp - 0xc], al);       /* mov [ebp-0xc], al */
            ii(0x100b_7bd7, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x100b_7bda, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_7bdc, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_7bdd, 1); popd(edi);                              /* pop edi */
            ii(0x100b_7bde, 1); popd(esi);                              /* pop esi */
            ii(0x100b_7bdf, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_7be0, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_7be1, 1); retd(); return;                         /* ret */
        }
    }
}
