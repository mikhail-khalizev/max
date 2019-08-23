using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_acb8-df68d77c")]
        public void Method_100a_acb8()
        {
            ii(0x100a_acb8, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100a_acbd, 5); calld(Definitions.sys_check_available_stack_size, 0xb_b090); /* call 0x10165d52 */
            ii(0x100a_acc2, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_acc3, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_acc4, 1); pushd(esi);                             /* push esi */
            ii(0x100a_acc5, 1); pushd(edi);                             /* push edi */
            ii(0x100a_acc6, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_acc7, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_acc9, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100a_accf, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_acd2, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100a_acd5, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100a_acd8, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_acdb, 5); calld(0x1013_a66b, 0x8_f98b);           /* call 0x1013a66b */
            ii(0x100a_ace0, 3); mov(memb_a32[ss, ebp - 0xc], al);       /* mov [ebp-0xc], al */
            ii(0x100a_ace3, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x100a_ace6, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_ace8, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_ace9, 1); popd(edi);                              /* pop edi */
            ii(0x100a_acea, 1); popd(esi);                              /* pop esi */
            ii(0x100a_aceb, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_acec, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_aced, 1); retd();                                 /* ret */
        }
    }
}
