using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_5551-59bfc715")]
        public void Method_1014_5551()
        {
            ii(0x1014_5551, 5);  push(0x20);                           /* push 0x20 */
            ii(0x1014_5556, 5);  call(Definitions.sys_check_available_stack_size, 0x2_07f7);/* call 0x10165d52 */
            ii(0x1014_555b, 1);  push(ebx);                            /* push ebx */
            ii(0x1014_555c, 1);  push(ecx);                            /* push ecx */
            ii(0x1014_555d, 1);  push(esi);                            /* push esi */
            ii(0x1014_555e, 1);  push(edi);                            /* push edi */
            ii(0x1014_555f, 1);  push(ebp);                            /* push ebp */
            ii(0x1014_5560, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1014_5562, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1014_5568, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1014_556b, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1014_556e, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1014_5571, 3);  add(edx, 0x14);                       /* add edx, 0x14 */
            ii(0x1014_5574, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_5577, 5);  call(Definitions.my_string_ctor_string, -0x3ad6);/* call 0x10141aa6 */
            ii(0x1014_557c, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_557f, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1014_5581, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1014_5582, 1);  pop(edi);                             /* pop edi */
            ii(0x1014_5583, 1);  pop(esi);                             /* pop esi */
            ii(0x1014_5584, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1014_5585, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1014_5586, 1);  ret();                                /* ret */
        }
    }
}
