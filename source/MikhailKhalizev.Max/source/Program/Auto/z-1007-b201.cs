using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_b201-bab8b018")]
        public void Method_1007_b201()
        {
            ii(0x1007_b201, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1007_b206, 5);  call(Definitions.sys_check_available_stack_size, 0xe_ab47);/* call 0x10165d52 */
            ii(0x1007_b20b, 1);  push(ebx);                            /* push ebx */
            ii(0x1007_b20c, 1);  push(ecx);                            /* push ecx */
            ii(0x1007_b20d, 1);  push(edx);                            /* push edx */
            ii(0x1007_b20e, 1);  push(esi);                            /* push esi */
            ii(0x1007_b20f, 1);  push(edi);                            /* push edi */
            ii(0x1007_b210, 1);  push(ebp);                            /* push ebp */
            ii(0x1007_b211, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1007_b213, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1007_b219, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1007_b21c, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_b21f, 3);  add(eax, 0x2d);                       /* add eax, 0x2d */
            ii(0x1007_b222, 5);  call(0x1008_a4a0, 0xf279);            /* call 0x1008a4a0 */
            ii(0x1007_b227, 1);  cwde();                               /* cwde */
            ii(0x1007_b228, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1007_b22b, 3);  add(eax, 4);                          /* add eax, 0x4 */
            ii(0x1007_b22e, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1007_b231, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_b234, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1007_b236, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1007_b237, 1);  pop(edi);                             /* pop edi */
            ii(0x1007_b238, 1);  pop(esi);                             /* pop esi */
            ii(0x1007_b239, 1);  pop(edx);                             /* pop edx */
            ii(0x1007_b23a, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1007_b23b, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1007_b23c, 1);  ret();                                /* ret */
        }
    }
}
