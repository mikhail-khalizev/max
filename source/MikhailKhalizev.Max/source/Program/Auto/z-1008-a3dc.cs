using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_a3dc-ee192bbb")]
        public void Method_1008_a3dc()
        {
            ii(0x1008_a3dc, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1008_a3e1, 5);  call(Definitions.sys_check_available_stack_size, 0xd_b96c);/* call 0x10165d52 */
            ii(0x1008_a3e6, 1);  push(ebx);                            /* push ebx */
            ii(0x1008_a3e7, 1);  push(ecx);                            /* push ecx */
            ii(0x1008_a3e8, 1);  push(esi);                            /* push esi */
            ii(0x1008_a3e9, 1);  push(edi);                            /* push edi */
            ii(0x1008_a3ea, 1);  push(ebp);                            /* push ebp */
            ii(0x1008_a3eb, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1008_a3ed, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1008_a3f3, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1008_a3f6, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1008_a3f9, 4);  movsx(edx, memw[ss, ebp - 4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x1008_a3fd, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_a400, 5);  call(0x1008_b410, 0x100b);            /* call 0x1008b410 */
            ii(0x1008_a405, 3);  add(eax, 6);                          /* add eax, 0x6 */
            ii(0x1008_a408, 5);  call(0x1008_b440, 0x1033);            /* call 0x1008b440 */
            ii(0x1008_a40d, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1008_a410, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1008_a413, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1008_a415, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1008_a416, 1);  pop(edi);                             /* pop edi */
            ii(0x1008_a417, 1);  pop(esi);                             /* pop esi */
            ii(0x1008_a418, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1008_a419, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1008_a41a, 1);  ret();                                /* ret */
        }
    }
}
