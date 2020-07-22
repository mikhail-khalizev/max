using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_54a5-469cd7b2")]
        public void Method_1014_54a5()
        {
            ii(0x1014_54a5, 5);  push(0x20);                           /* push 0x20 */
            ii(0x1014_54aa, 5);  call(Definitions.sys_check_available_stack_size, 0x2_08a3);/* call 0x10165d52 */
            ii(0x1014_54af, 1);  push(ebx);                            /* push ebx */
            ii(0x1014_54b0, 1);  push(ecx);                            /* push ecx */
            ii(0x1014_54b1, 1);  push(esi);                            /* push esi */
            ii(0x1014_54b2, 1);  push(edi);                            /* push edi */
            ii(0x1014_54b3, 1);  push(ebp);                            /* push ebp */
            ii(0x1014_54b4, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1014_54b6, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1014_54bc, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1014_54bf, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1014_54c2, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1014_54c5, 3);  add(edx, 0x14);                       /* add edx, 0x14 */
            ii(0x1014_54c8, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_54cb, 5);  call(Definitions.my_string_ctor_string, -0x3a2a);/* call 0x10141aa6 */
            ii(0x1014_54d0, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_54d3, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1014_54d5, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1014_54d6, 1);  pop(edi);                             /* pop edi */
            ii(0x1014_54d7, 1);  pop(esi);                             /* pop esi */
            ii(0x1014_54d8, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1014_54d9, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1014_54da, 1);  ret();                                /* ret */
        }
    }
}
