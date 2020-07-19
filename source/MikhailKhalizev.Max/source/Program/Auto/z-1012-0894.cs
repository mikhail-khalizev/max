using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_0894-e089e60e")]
        public void Method_1012_0894()
        {
            ii(0x1012_0894, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1012_0899, 5);  call(Definitions.sys_check_available_stack_size, 0x4_54b4);/* call 0x10165d52 */
            ii(0x1012_089e, 1);  push(ebx);                            /* push ebx */
            ii(0x1012_089f, 1);  push(ecx);                            /* push ecx */
            ii(0x1012_08a0, 1);  push(edx);                            /* push edx */
            ii(0x1012_08a1, 1);  push(esi);                            /* push esi */
            ii(0x1012_08a2, 1);  push(edi);                            /* push edi */
            ii(0x1012_08a3, 1);  push(ebp);                            /* push ebp */
            ii(0x1012_08a4, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1012_08a6, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1012_08ac, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1012_08af, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_08b2, 5);  call(0x1007_6b58, -0xa_9d5f);         /* call 0x10076b58 */
            ii(0x1012_08b7, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1012_08ba, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_08bd, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1012_08bf, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1012_08c0, 1);  pop(edi);                             /* pop edi */
            ii(0x1012_08c1, 1);  pop(esi);                             /* pop esi */
            ii(0x1012_08c2, 1);  pop(edx);                             /* pop edx */
            ii(0x1012_08c3, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1012_08c4, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1012_08c5, 1);  ret();                                /* ret */
        }
    }
}
