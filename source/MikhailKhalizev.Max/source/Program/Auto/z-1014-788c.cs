using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_788c-25d00fee")]
        public void Method_1014_788c()
        {
            ii(0x1014_788c, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1014_7891, 5);  call(Definitions.sys_check_available_stack_size, 0x1_e4bc);/* call 0x10165d52 */
            ii(0x1014_7896, 1);  push(ebx);                            /* push ebx */
            ii(0x1014_7897, 1);  push(ecx);                            /* push ecx */
            ii(0x1014_7898, 1);  push(esi);                            /* push esi */
            ii(0x1014_7899, 1);  push(edi);                            /* push edi */
            ii(0x1014_789a, 1);  push(ebp);                            /* push ebp */
            ii(0x1014_789b, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1014_789d, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1014_78a3, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1014_78a6, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1014_78a9, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x1014_78ae, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_78b1, 5);  call(0x1013_a1be, -0xd6f8);           /* call 0x1013a1be */
            ii(0x1014_78b6, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1014_78b9, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_78bc, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1014_78bf, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1014_78c2, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1014_78c4, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1014_78c5, 1);  pop(edi);                             /* pop edi */
            ii(0x1014_78c6, 1);  pop(esi);                             /* pop esi */
            ii(0x1014_78c7, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1014_78c8, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1014_78c9, 1);  ret();                                /* ret */
        }
    }
}
