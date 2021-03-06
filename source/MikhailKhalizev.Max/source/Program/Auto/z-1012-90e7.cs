using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_90e7-97333b77")]
        public void Method_1012_90e7()
        {
            ii(0x1012_90e7, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1012_90ec, 5);  call(Definitions.sys_check_available_stack_size, 0x3_cc61);/* call 0x10165d52 */
            ii(0x1012_90f1, 1);  push(esi);                            /* push esi */
            ii(0x1012_90f2, 1);  push(edi);                            /* push edi */
            ii(0x1012_90f3, 1);  push(ebp);                            /* push ebp */
            ii(0x1012_90f4, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1012_90f6, 6);  sub(esp, 0x14);                       /* sub esp, 0x14 */
            ii(0x1012_90fc, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1012_90ff, 3);  mov(memd[ss, ebp - 12], edx);         /* mov [ebp-0xc], edx */
            ii(0x1012_9102, 3);  mov(memd[ss, ebp - 8], ebx);          /* mov [ebp-0x8], ebx */
            ii(0x1012_9105, 3);  mov(memd[ss, ebp - 4], ecx);          /* mov [ebp-0x4], ecx */
            ii(0x1012_9108, 7);  mov(memb[ds, 0x101c_5c1c], 0xe);      /* mov byte [0x101c5c1c], 0xe */
            ii(0x1012_910f, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1012_9112, 6);  mov(memw[ds, 0x101c_5c1d], ax);       /* mov [0x101c5c1d], ax */
            ii(0x1012_9118, 9);  mov(memw[ds, 0x101c_5c1f], 6);        /* mov word [0x101c5c1f], 0x6 */
            ii(0x1012_9121, 7);  mov(memd[ss, ebp - 20], 0x101c_5c21); /* mov dword [ebp-0x14], 0x101c5c21 */
            ii(0x1012_9128, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1012_912b, 3);  mov(edx, memd[ss, ebp - 20]);         /* mov edx, [ebp-0x14] */
            ii(0x1012_912e, 3);  mov(memw[ds, edx], ax);               /* mov [edx], ax */
            ii(0x1012_9131, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_9134, 3);  mov(edx, memd[ss, ebp - 20]);         /* mov edx, [ebp-0x14] */
            ii(0x1012_9137, 4);  mov(memw[ds, edx + 2], ax);           /* mov [edx+0x2], ax */
            ii(0x1012_913b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_913e, 3);  mov(edx, memd[ss, ebp - 20]);         /* mov edx, [ebp-0x14] */
            ii(0x1012_9141, 4);  mov(memw[ds, edx + 4], ax);           /* mov [edx+0x4], ax */
            ii(0x1012_9145, 5);  mov(eax, 4);                          /* mov eax, 0x4 */
            ii(0x1012_914a, 5);  call(0x1012_5be9, -0x3566);           /* call 0x10125be9 */
            ii(0x1012_914f, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1012_9151, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1012_9152, 1);  pop(edi);                             /* pop edi */
            ii(0x1012_9153, 1);  pop(esi);                             /* pop esi */
            ii(0x1012_9154, 1);  ret();                                /* ret */
        }
    }
}
