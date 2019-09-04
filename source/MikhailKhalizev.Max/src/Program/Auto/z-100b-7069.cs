using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_7069-23778d7e")]
        public void Method_100b_7069()
        {
            ii(0x100b_7069, 5);  push(0x20);                           /* push 0x20 */
            ii(0x100b_706e, 5);  call(Definitions.sys_check_available_stack_size, 0xa_ecdf);/* call 0x10165d52 */
            ii(0x100b_7073, 1);  push(ebx);                            /* push ebx */
            ii(0x100b_7074, 1);  push(ecx);                            /* push ecx */
            ii(0x100b_7075, 1);  push(esi);                            /* push esi */
            ii(0x100b_7076, 1);  push(edi);                            /* push edi */
            ii(0x100b_7077, 1);  push(ebp);                            /* push ebp */
            ii(0x100b_7078, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100b_707a, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x100b_7080, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100b_7083, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100b_7086, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100b_7089, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_708c, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x100b_708f, 5);  call(0x1008_aab4, -0x2_c5e0);         /* call 0x1008aab4 */
            ii(0x100b_7094, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100b_7096, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100b_7097, 1);  pop(edi);                             /* pop edi */
            ii(0x100b_7098, 1);  pop(esi);                             /* pop esi */
            ii(0x100b_7099, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100b_709a, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100b_709b, 1);  ret();                                /* ret */
        }
    }
}
