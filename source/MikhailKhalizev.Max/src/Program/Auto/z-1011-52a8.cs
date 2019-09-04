using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_52a8-b70b8a0f")]
        public void Method_1011_52a8()
        {
            ii(0x1011_52a8, 1);  push(ebx);                            /* push ebx */
            ii(0x1011_52a9, 1);  push(ecx);                            /* push ecx */
            ii(0x1011_52aa, 1);  push(edx);                            /* push edx */
            ii(0x1011_52ab, 1);  push(esi);                            /* push esi */
            ii(0x1011_52ac, 1);  push(edi);                            /* push edi */
            ii(0x1011_52ad, 1);  push(ebp);                            /* push ebp */
            ii(0x1011_52ae, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1011_52b0, 6);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x1011_52b6, 4);  mov(memb[ss, ebp - 4], 0);            /* mov byte [ebp-0x4], 0x0 */
            ii(0x1011_52ba, 3);  mov(al, memb[ss, ebp - 4]);           /* mov al, [ebp-0x4] */
            ii(0x1011_52bd, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1011_52bf, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1011_52c0, 1);  pop(edi);                             /* pop edi */
            ii(0x1011_52c1, 1);  pop(esi);                             /* pop esi */
            ii(0x1011_52c2, 1);  pop(edx);                             /* pop edx */
            ii(0x1011_52c3, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1011_52c4, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1011_52c5, 1);  ret();                                /* ret */
        }
    }
}
