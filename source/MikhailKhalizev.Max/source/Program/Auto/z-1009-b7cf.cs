using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_b7cf-7915b7c6")]
        public void Method_1009_b7cf()
        {
            ii(0x1009_b7cf, 5);  push(0x20);                           /* push 0x20 */
            ii(0x1009_b7d4, 5);  call(Definitions.sys_check_available_stack_size, 0xc_a579);/* call 0x10165d52 */
            ii(0x1009_b7d9, 1);  push(ebx);                            /* push ebx */
            ii(0x1009_b7da, 1);  push(ecx);                            /* push ecx */
            ii(0x1009_b7db, 1);  push(esi);                            /* push esi */
            ii(0x1009_b7dc, 1);  push(edi);                            /* push edi */
            ii(0x1009_b7dd, 1);  push(ebp);                            /* push ebp */
            ii(0x1009_b7de, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1009_b7e0, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1009_b7e6, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1009_b7e9, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1009_b7ec, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1009_b7ef, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_b7f2, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x1009_b7f5, 5);  call(0x1008_aab4, -0x1_0d46);         /* call 0x1008aab4 */
            ii(0x1009_b7fa, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1009_b7fc, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1009_b7fd, 1);  pop(edi);                             /* pop edi */
            ii(0x1009_b7fe, 1);  pop(esi);                             /* pop esi */
            ii(0x1009_b7ff, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1009_b800, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1009_b801, 1);  ret();                                /* ret */
        }
    }
}
