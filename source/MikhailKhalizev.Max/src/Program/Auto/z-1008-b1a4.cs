using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_b1a4-6b4f9e11")]
        public void Method_1008_b1a4()
        {
            ii(0x1008_b1a4, 5);  push(0x20);                           /* push 0x20 */
            ii(0x1008_b1a9, 5);  call(Definitions.sys_check_available_stack_size, 0xd_aba4);/* call 0x10165d52 */
            ii(0x1008_b1ae, 1);  push(ebx);                            /* push ebx */
            ii(0x1008_b1af, 1);  push(ecx);                            /* push ecx */
            ii(0x1008_b1b0, 1);  push(esi);                            /* push esi */
            ii(0x1008_b1b1, 1);  push(edi);                            /* push edi */
            ii(0x1008_b1b2, 1);  push(ebp);                            /* push ebp */
            ii(0x1008_b1b3, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1008_b1b5, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1008_b1bb, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1008_b1be, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1008_b1c1, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_b1c4, 3);  mov(dx, memw[ds, eax]);               /* mov dx, [eax] */
            ii(0x1008_b1c7, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_b1ca, 3);  add(memw[ds, eax], dx);               /* add [eax], dx */
            ii(0x1008_b1cd, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_b1d0, 4);  mov(dx, memw[ds, eax + 2]);           /* mov dx, [eax+0x2] */
            ii(0x1008_b1d4, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_b1d7, 4);  add(memw[ds, eax + 2], dx);           /* add [eax+0x2], dx */
            ii(0x1008_b1db, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1008_b1dd, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1008_b1de, 1);  pop(edi);                             /* pop edi */
            ii(0x1008_b1df, 1);  pop(esi);                             /* pop esi */
            ii(0x1008_b1e0, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1008_b1e1, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1008_b1e2, 1);  ret();                                /* ret */
        }
    }
}
