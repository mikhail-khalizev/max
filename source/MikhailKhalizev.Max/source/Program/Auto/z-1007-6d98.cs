using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_6d98-bf6c6bfc")]
        public void Method_1007_6d98()
        {
            ii(0x1007_6d98, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1007_6d9d, 5);  call(Definitions.sys_check_available_stack_size, 0xe_efb0);/* call 0x10165d52 */
            ii(0x1007_6da2, 1);  push(ebx);                            /* push ebx */
            ii(0x1007_6da3, 1);  push(ecx);                            /* push ecx */
            ii(0x1007_6da4, 1);  push(esi);                            /* push esi */
            ii(0x1007_6da5, 1);  push(edi);                            /* push edi */
            ii(0x1007_6da6, 1);  push(ebp);                            /* push ebp */
            ii(0x1007_6da7, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1007_6da9, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1007_6daf, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1007_6db2, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1007_6db5, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1007_6db8, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_6dbb, 5);  call(0x1007_6e00, 0x40);              /* call 0x10076e00 */
            ii(0x1007_6dc0, 3);  mov(memb[ss, ebp - 12], al);          /* mov [ebp-0xc], al */
            ii(0x1007_6dc3, 3);  mov(al, memb[ss, ebp - 12]);          /* mov al, [ebp-0xc] */
            ii(0x1007_6dc6, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1007_6dc8, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1007_6dc9, 1);  pop(edi);                             /* pop edi */
            ii(0x1007_6dca, 1);  pop(esi);                             /* pop esi */
            ii(0x1007_6dcb, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1007_6dcc, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1007_6dcd, 1);  ret();                                /* ret */
        }
    }
}
