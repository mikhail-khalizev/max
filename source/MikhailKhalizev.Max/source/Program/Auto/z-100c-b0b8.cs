using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_b0b8-2fcdcb56")]
        public void Method_100c_b0b8()
        {
            ii(0x100c_b0b8, 5);  push(0x20);                           /* push 0x20 */
            ii(0x100c_b0bd, 5);  call(Definitions.sys_check_available_stack_size, 0x9_ac90);/* call 0x10165d52 */
            ii(0x100c_b0c2, 1);  push(ebx);                            /* push ebx */
            ii(0x100c_b0c3, 1);  push(ecx);                            /* push ecx */
            ii(0x100c_b0c4, 1);  push(esi);                            /* push esi */
            ii(0x100c_b0c5, 1);  push(edi);                            /* push edi */
            ii(0x100c_b0c6, 1);  push(ebp);                            /* push ebp */
            ii(0x100c_b0c7, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100c_b0c9, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x100c_b0cf, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100c_b0d2, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100c_b0d5, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100c_b0d8, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_b0db, 3);  add(eax, 0x10);                       /* add eax, 0x10 */
            ii(0x100c_b0de, 5);  call(0x1008_8b44, -0x4_259f);         /* call 0x10088b44 */
            ii(0x100c_b0e3, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100c_b0e5, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100c_b0e6, 1);  pop(edi);                             /* pop edi */
            ii(0x100c_b0e7, 1);  pop(esi);                             /* pop esi */
            ii(0x100c_b0e8, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100c_b0e9, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100c_b0ea, 1);  ret();                                /* ret */
        }
    }
}
