using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_0a90-44b9eb0e")]
        public void Method_1012_0a90()
        {
            ii(0x1012_0a90, 1);  push(ebx);                            /* push ebx */
            ii(0x1012_0a91, 1);  push(ecx);                            /* push ecx */
            ii(0x1012_0a92, 1);  push(edx);                            /* push edx */
            ii(0x1012_0a93, 1);  push(esi);                            /* push esi */
            ii(0x1012_0a94, 1);  push(edi);                            /* push edi */
            ii(0x1012_0a95, 1);  push(ebp);                            /* push ebp */
            ii(0x1012_0a96, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1012_0a98, 6);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x1012_0a9e, 4);  mov(memb[ss, ebp - 4], 1);            /* mov byte [ebp-0x4], 0x1 */
            ii(0x1012_0aa2, 3);  mov(al, memb[ss, ebp - 4]);           /* mov al, [ebp-0x4] */
            ii(0x1012_0aa5, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1012_0aa7, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1012_0aa8, 1);  pop(edi);                             /* pop edi */
            ii(0x1012_0aa9, 1);  pop(esi);                             /* pop esi */
            ii(0x1012_0aaa, 1);  pop(edx);                             /* pop edx */
            ii(0x1012_0aab, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1012_0aac, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1012_0aad, 1);  ret();                                /* ret */
        }
    }
}
