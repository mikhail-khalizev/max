using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_09f2-57b1bbdf")]
        public void Method_1008_09f2()
        {
            ii(0x1008_09f2, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1008_09f7, 5);  call(Definitions.sys_check_available_stack_size, 0xe_5356);/* call 0x10165d52 */
            ii(0x1008_09fc, 1);  push(ebx);                            /* push ebx */
            ii(0x1008_09fd, 1);  push(ecx);                            /* push ecx */
            ii(0x1008_09fe, 1);  push(edx);                            /* push edx */
            ii(0x1008_09ff, 1);  push(esi);                            /* push esi */
            ii(0x1008_0a00, 1);  push(edi);                            /* push edi */
            ii(0x1008_0a01, 1);  push(ebp);                            /* push ebp */
            ii(0x1008_0a02, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1008_0a04, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1008_0a0a, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1008_0a0d, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_0a10, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x1008_0a13, 5);  call(0x1013_a794, 0xb_9d7c);          /* call 0x1013a794 */
            ii(0x1008_0a18, 3);  sub(eax, 6);                          /* sub eax, 0x6 */
            ii(0x1008_0a1b, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1008_0a1e, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_0a21, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1008_0a23, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1008_0a24, 1);  pop(edi);                             /* pop edi */
            ii(0x1008_0a25, 1);  pop(esi);                             /* pop esi */
            ii(0x1008_0a26, 1);  pop(edx);                             /* pop edx */
            ii(0x1008_0a27, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1008_0a28, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1008_0a29, 1);  ret();                                /* ret */
        }
    }
}
