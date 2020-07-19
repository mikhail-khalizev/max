using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_cb74-b70b8a0f")]
        public void Method_1009_cb74()
        {
            ii(0x1009_cb74, 1);  push(ebx);                            /* push ebx */
            ii(0x1009_cb75, 1);  push(ecx);                            /* push ecx */
            ii(0x1009_cb76, 1);  push(edx);                            /* push edx */
            ii(0x1009_cb77, 1);  push(esi);                            /* push esi */
            ii(0x1009_cb78, 1);  push(edi);                            /* push edi */
            ii(0x1009_cb79, 1);  push(ebp);                            /* push ebp */
            ii(0x1009_cb7a, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1009_cb7c, 6);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x1009_cb82, 4);  mov(memb[ss, ebp - 4], 0);            /* mov byte [ebp-0x4], 0x0 */
            ii(0x1009_cb86, 3);  mov(al, memb[ss, ebp - 4]);           /* mov al, [ebp-0x4] */
            ii(0x1009_cb89, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1009_cb8b, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1009_cb8c, 1);  pop(edi);                             /* pop edi */
            ii(0x1009_cb8d, 1);  pop(esi);                             /* pop esi */
            ii(0x1009_cb8e, 1);  pop(edx);                             /* pop edx */
            ii(0x1009_cb8f, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1009_cb90, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1009_cb91, 1);  ret();                                /* ret */
        }
    }
}
