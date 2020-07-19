using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_acb8-df68d77c")]
        public void Method_100a_acb8()
        {
            ii(0x100a_acb8, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100a_acbd, 5);  call(Definitions.sys_check_available_stack_size, 0xb_b090);/* call 0x10165d52 */
            ii(0x100a_acc2, 1);  push(ebx);                            /* push ebx */
            ii(0x100a_acc3, 1);  push(ecx);                            /* push ecx */
            ii(0x100a_acc4, 1);  push(esi);                            /* push esi */
            ii(0x100a_acc5, 1);  push(edi);                            /* push edi */
            ii(0x100a_acc6, 1);  push(ebp);                            /* push ebp */
            ii(0x100a_acc7, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100a_acc9, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x100a_accf, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100a_acd2, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100a_acd5, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100a_acd8, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_acdb, 5);  call(0x1013_a66b, 0x8_f98b);          /* call 0x1013a66b */
            ii(0x100a_ace0, 3);  mov(memb[ss, ebp - 12], al);          /* mov [ebp-0xc], al */
            ii(0x100a_ace3, 3);  mov(al, memb[ss, ebp - 12]);          /* mov al, [ebp-0xc] */
            ii(0x100a_ace6, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100a_ace8, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100a_ace9, 1);  pop(edi);                             /* pop edi */
            ii(0x100a_acea, 1);  pop(esi);                             /* pop esi */
            ii(0x100a_aceb, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100a_acec, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100a_aced, 1);  ret();                                /* ret */
        }
    }
}
