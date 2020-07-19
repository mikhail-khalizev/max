using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_52d4-7e93caef")]
        public void Method_100d_52d4()
        {
            ii(0x100d_52d4, 1);  push(ebx);                            /* push ebx */
            ii(0x100d_52d5, 1);  push(ecx);                            /* push ecx */
            ii(0x100d_52d6, 1);  push(edx);                            /* push edx */
            ii(0x100d_52d7, 1);  push(esi);                            /* push esi */
            ii(0x100d_52d8, 1);  push(edi);                            /* push edi */
            ii(0x100d_52d9, 1);  push(ebp);                            /* push ebp */
            ii(0x100d_52da, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100d_52dc, 6);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x100d_52e2, 7);  mov(memd[ss, ebp - 4], 0);            /* mov dword [ebp-0x4], 0x0 */
            ii(0x100d_52e9, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_52ec, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100d_52ee, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100d_52ef, 1);  pop(edi);                             /* pop edi */
            ii(0x100d_52f0, 1);  pop(esi);                             /* pop esi */
            ii(0x100d_52f1, 1);  pop(edx);                             /* pop edx */
            ii(0x100d_52f2, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100d_52f3, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100d_52f4, 1);  ret();                                /* ret */
        }
    }
}
