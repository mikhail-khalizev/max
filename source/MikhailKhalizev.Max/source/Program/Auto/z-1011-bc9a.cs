using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_bc9a-b9e6b968")]
        public void Method_1011_bc9a()
        {
            ii(0x1011_bc9a, 5);  push(0x20);                           /* push 0x20 */
            ii(0x1011_bc9f, 5);  call(Definitions.sys_check_available_stack_size, 0x4_a0ae);/* call 0x10165d52 */
            ii(0x1011_bca4, 1);  push(ebx);                            /* push ebx */
            ii(0x1011_bca5, 1);  push(ecx);                            /* push ecx */
            ii(0x1011_bca6, 1);  push(esi);                            /* push esi */
            ii(0x1011_bca7, 1);  push(edi);                            /* push edi */
            ii(0x1011_bca8, 1);  push(ebp);                            /* push ebp */
            ii(0x1011_bca9, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1011_bcab, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1011_bcb1, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1011_bcb4, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1011_bcb7, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_bcba, 3);  mov(edx, memd[ds, eax + 20]);         /* mov edx, [eax+0x14] */
            ii(0x1011_bcbd, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1011_bcc0, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_bcc3, 5);  call(0x1013_c0fa, 0x2_0432);          /* call 0x1013c0fa */
            ii(0x1011_bcc8, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_bccb, 3);  mov(edx, memd[ds, eax + 22]);         /* mov edx, [eax+0x16] */
            ii(0x1011_bcce, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1011_bcd1, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_bcd4, 5);  call(0x1013_c0fa, 0x2_0421);          /* call 0x1013c0fa */
            ii(0x1011_bcd9, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1011_bcdb, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1011_bcdc, 1);  pop(edi);                             /* pop edi */
            ii(0x1011_bcdd, 1);  pop(esi);                             /* pop esi */
            ii(0x1011_bcde, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1011_bcdf, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1011_bce0, 1);  ret();                                /* ret */
        }
    }
}
