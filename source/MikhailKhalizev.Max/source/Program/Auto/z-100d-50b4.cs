using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_50b4-b70b8a0f")]
        public void Method_100d_50b4()
        {
            ii(0x100d_50b4, 1);  push(ebx);                            /* push ebx */
            ii(0x100d_50b5, 1);  push(ecx);                            /* push ecx */
            ii(0x100d_50b6, 1);  push(edx);                            /* push edx */
            ii(0x100d_50b7, 1);  push(esi);                            /* push esi */
            ii(0x100d_50b8, 1);  push(edi);                            /* push edi */
            ii(0x100d_50b9, 1);  push(ebp);                            /* push ebp */
            ii(0x100d_50ba, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100d_50bc, 6);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x100d_50c2, 4);  mov(memb[ss, ebp - 4], 0);            /* mov byte [ebp-0x4], 0x0 */
            ii(0x100d_50c6, 3);  mov(al, memb[ss, ebp - 4]);           /* mov al, [ebp-0x4] */
            ii(0x100d_50c9, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100d_50cb, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100d_50cc, 1);  pop(edi);                             /* pop edi */
            ii(0x100d_50cd, 1);  pop(esi);                             /* pop esi */
            ii(0x100d_50ce, 1);  pop(edx);                             /* pop edx */
            ii(0x100d_50cf, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100d_50d0, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100d_50d1, 1);  ret();                                /* ret */
        }
    }
}
