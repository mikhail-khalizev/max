using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_a9d0-1f1a24b7")]
        public void Method_1008_a9d0()
        {
            ii(0x1008_a9d0, 5);  push(0x20);                           /* push 0x20 */
            ii(0x1008_a9d5, 5);  call(Definitions.sys_check_available_stack_size, 0xd_b378);/* call 0x10165d52 */
            ii(0x1008_a9da, 1);  push(ebx);                            /* push ebx */
            ii(0x1008_a9db, 1);  push(ecx);                            /* push ecx */
            ii(0x1008_a9dc, 1);  push(esi);                            /* push esi */
            ii(0x1008_a9dd, 1);  push(edi);                            /* push edi */
            ii(0x1008_a9de, 1);  push(ebp);                            /* push ebp */
            ii(0x1008_a9df, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1008_a9e1, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1008_a9e7, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1008_a9ea, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1008_a9ed, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_a9f0, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1008_a9f3, 6);  mov(memd[ds, edx + 221], eax);        /* mov [edx+0xdd], eax */
            ii(0x1008_a9f9, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1008_a9fb, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1008_a9fc, 1);  pop(edi);                             /* pop edi */
            ii(0x1008_a9fd, 1);  pop(esi);                             /* pop esi */
            ii(0x1008_a9fe, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1008_a9ff, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1008_aa00, 1);  ret();                                /* ret */
        }
    }
}
