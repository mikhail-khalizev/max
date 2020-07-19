using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_4e6c-b70b8a0f")]
        public void Method_100d_4e6c()
        {
            ii(0x100d_4e6c, 1);  push(ebx);                            /* push ebx */
            ii(0x100d_4e6d, 1);  push(ecx);                            /* push ecx */
            ii(0x100d_4e6e, 1);  push(edx);                            /* push edx */
            ii(0x100d_4e6f, 1);  push(esi);                            /* push esi */
            ii(0x100d_4e70, 1);  push(edi);                            /* push edi */
            ii(0x100d_4e71, 1);  push(ebp);                            /* push ebp */
            ii(0x100d_4e72, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100d_4e74, 6);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x100d_4e7a, 4);  mov(memb[ss, ebp - 4], 0);            /* mov byte [ebp-0x4], 0x0 */
            ii(0x100d_4e7e, 3);  mov(al, memb[ss, ebp - 4]);           /* mov al, [ebp-0x4] */
            ii(0x100d_4e81, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100d_4e83, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100d_4e84, 1);  pop(edi);                             /* pop edi */
            ii(0x100d_4e85, 1);  pop(esi);                             /* pop esi */
            ii(0x100d_4e86, 1);  pop(edx);                             /* pop edx */
            ii(0x100d_4e87, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100d_4e88, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100d_4e89, 1);  ret();                                /* ret */
        }
    }
}
