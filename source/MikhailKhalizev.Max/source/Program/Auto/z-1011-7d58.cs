using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_7d58-a9ab9b3b")]
        public void Method_1011_7d58()
        {
            ii(0x1011_7d58, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1011_7d5d, 5);  call(Definitions.sys_check_available_stack_size, 0x4_dff0);/* call 0x10165d52 */
            ii(0x1011_7d62, 1);  push(ebx);                            /* push ebx */
            ii(0x1011_7d63, 1);  push(ecx);                            /* push ecx */
            ii(0x1011_7d64, 1);  push(esi);                            /* push esi */
            ii(0x1011_7d65, 1);  push(edi);                            /* push edi */
            ii(0x1011_7d66, 1);  push(ebp);                            /* push ebp */
            ii(0x1011_7d67, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1011_7d69, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1011_7d6f, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1011_7d72, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1011_7d75, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1011_7d78, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_7d7b, 5);  call(0x1007_6c98, -0xa_10e8);         /* call 0x10076c98 */
            ii(0x1011_7d80, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1011_7d83, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1011_7d86, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1011_7d88, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1011_7d89, 1);  pop(edi);                             /* pop edi */
            ii(0x1011_7d8a, 1);  pop(esi);                             /* pop esi */
            ii(0x1011_7d8b, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1011_7d8c, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1011_7d8d, 1);  ret();                                /* ret */
        }
    }
}
