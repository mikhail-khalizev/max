using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_a094-2aa9918")]
        public void Method_1008_a094()
        {
            ii(0x1008_a094, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1008_a099, 5);  call(Definitions.sys_check_available_stack_size, 0xd_bcb4);/* call 0x10165d52 */
            ii(0x1008_a09e, 1);  push(ebx);                            /* push ebx */
            ii(0x1008_a09f, 1);  push(ecx);                            /* push ecx */
            ii(0x1008_a0a0, 1);  push(edx);                            /* push edx */
            ii(0x1008_a0a1, 1);  push(esi);                            /* push esi */
            ii(0x1008_a0a2, 1);  push(edi);                            /* push edi */
            ii(0x1008_a0a3, 1);  push(ebp);                            /* push ebp */
            ii(0x1008_a0a4, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1008_a0a6, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1008_a0ac, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1008_a0af, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_a0b2, 4);  mov(ax, memw[ds, eax + 123]);         /* mov ax, [eax+0x7b] */
            ii(0x1008_a0b6, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1008_a0b9, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_a0bc, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1008_a0be, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1008_a0bf, 1);  pop(edi);                             /* pop edi */
            ii(0x1008_a0c0, 1);  pop(esi);                             /* pop esi */
            ii(0x1008_a0c1, 1);  pop(edx);                             /* pop edx */
            ii(0x1008_a0c2, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1008_a0c3, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1008_a0c4, 1);  ret();                                /* ret */
        }
    }
}
