using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_9cf8-938d59e6")]
        public void Method_1009_9cf8()
        {
            ii(0x1009_9cf8, 5);  push(0x20);                           /* push 0x20 */
            ii(0x1009_9cfd, 5);  call(Definitions.sys_check_available_stack_size, 0xc_c050);/* call 0x10165d52 */
            ii(0x1009_9d02, 1);  push(ebx);                            /* push ebx */
            ii(0x1009_9d03, 1);  push(ecx);                            /* push ecx */
            ii(0x1009_9d04, 1);  push(edx);                            /* push edx */
            ii(0x1009_9d05, 1);  push(esi);                            /* push esi */
            ii(0x1009_9d06, 1);  push(edi);                            /* push edi */
            ii(0x1009_9d07, 1);  push(ebp);                            /* push ebp */
            ii(0x1009_9d08, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1009_9d0a, 6);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x1009_9d10, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1009_9d13, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_9d16, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x1009_9d19, 5);  call(0x1009_c3c0, 0x26a2);            /* call 0x1009c3c0 */
            ii(0x1009_9d1e, 5);  call(0x1009_39b6, -0x636d);           /* call 0x100939b6 */
            ii(0x1009_9d23, 2);  test(al, al);                         /* test al, al */
            ii(0x1009_9d25, 2);  if(jz(0x1009_9d34, 0xd)) goto l_0x1009_9d34;/* jz 0x10099d34 */
            ii(0x1009_9d27, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x1009_9d2c, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_9d2f, 5);  call(0x100a_2a04, 0x8cd0);            /* call 0x100a2a04 */
        l_0x1009_9d34:
            ii(0x1009_9d34, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1009_9d36, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1009_9d37, 1);  pop(edi);                             /* pop edi */
            ii(0x1009_9d38, 1);  pop(esi);                             /* pop esi */
            ii(0x1009_9d39, 1);  pop(edx);                             /* pop edx */
            ii(0x1009_9d3a, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1009_9d3b, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1009_9d3c, 1);  ret();                                /* ret */
        }
    }
}
