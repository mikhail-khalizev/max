using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_2b84-b70b8a0f")]
        public void Method_1010_2b84()
        {
            ii(0x1010_2b84, 1);  push(ebx);                            /* push ebx */
            ii(0x1010_2b85, 1);  push(ecx);                            /* push ecx */
            ii(0x1010_2b86, 1);  push(edx);                            /* push edx */
            ii(0x1010_2b87, 1);  push(esi);                            /* push esi */
            ii(0x1010_2b88, 1);  push(edi);                            /* push edi */
            ii(0x1010_2b89, 1);  push(ebp);                            /* push ebp */
            ii(0x1010_2b8a, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1010_2b8c, 6);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x1010_2b92, 4);  mov(memb[ss, ebp - 4], 0);            /* mov byte [ebp-0x4], 0x0 */
            ii(0x1010_2b96, 3);  mov(al, memb[ss, ebp - 4]);           /* mov al, [ebp-0x4] */
            ii(0x1010_2b99, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1010_2b9b, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1010_2b9c, 1);  pop(edi);                             /* pop edi */
            ii(0x1010_2b9d, 1);  pop(esi);                             /* pop esi */
            ii(0x1010_2b9e, 1);  pop(edx);                             /* pop edx */
            ii(0x1010_2b9f, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1010_2ba0, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1010_2ba1, 1);  ret();                                /* ret */
        }
    }
}
