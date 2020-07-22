using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_52a8-cbf85b2b")]
        public void Method_100d_52a8()
        {
            ii(0x100d_52a8, 1);  push(ebx);                            /* push ebx */
            ii(0x100d_52a9, 1);  push(ecx);                            /* push ecx */
            ii(0x100d_52aa, 1);  push(edx);                            /* push edx */
            ii(0x100d_52ab, 1);  push(esi);                            /* push esi */
            ii(0x100d_52ac, 1);  push(edi);                            /* push edi */
            ii(0x100d_52ad, 1);  push(ebp);                            /* push ebp */
            ii(0x100d_52ae, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100d_52b0, 6);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x100d_52b6, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100d_52b9, 5);  mov(edx, 0x101c_3678);                /* mov edx, 0x101c3678 */
            ii(0x100d_52be, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_52c1, 5);  call(0x100d_4d78, -0x54e);            /* call 0x100d4d78 */
            ii(0x100d_52c6, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_52c9, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100d_52cb, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100d_52cc, 1);  pop(edi);                             /* pop edi */
            ii(0x100d_52cd, 1);  pop(esi);                             /* pop esi */
            ii(0x100d_52ce, 1);  pop(edx);                             /* pop edx */
            ii(0x100d_52cf, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100d_52d0, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100d_52d1, 1);  ret();                                /* ret */
        }
    }
}
