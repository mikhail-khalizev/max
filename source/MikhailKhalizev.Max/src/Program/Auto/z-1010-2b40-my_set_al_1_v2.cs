using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_2b40-44b9eb0e")]
        public void my_set_al_1_v2()
        {
            ii(0x1010_2b40, 1);  push(ebx);                            /* push ebx */
            ii(0x1010_2b41, 1);  push(ecx);                            /* push ecx */
            ii(0x1010_2b42, 1);  push(edx);                            /* push edx */
            ii(0x1010_2b43, 1);  push(esi);                            /* push esi */
            ii(0x1010_2b44, 1);  push(edi);                            /* push edi */
            ii(0x1010_2b45, 1);  push(ebp);                            /* push ebp */
            ii(0x1010_2b46, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1010_2b48, 6);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x1010_2b4e, 4);  mov(memb[ss, ebp - 4], 1);            /* mov byte [ebp-0x4], 0x1 */
            ii(0x1010_2b52, 3);  mov(al, memb[ss, ebp - 4]);           /* mov al, [ebp-0x4] */
            ii(0x1010_2b55, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1010_2b57, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1010_2b58, 1);  pop(edi);                             /* pop edi */
            ii(0x1010_2b59, 1);  pop(esi);                             /* pop esi */
            ii(0x1010_2b5a, 1);  pop(edx);                             /* pop edx */
            ii(0x1010_2b5b, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1010_2b5c, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1010_2b5d, 1);  ret();                                /* ret */
        }
    }
}
