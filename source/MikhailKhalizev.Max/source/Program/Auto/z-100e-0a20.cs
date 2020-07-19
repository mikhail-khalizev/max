using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_0a20-c502b1ca")]
        public void Method_100e_0a20()
        {
            ii(0x100e_0a20, 1);  push(ebx);                            /* push ebx */
            ii(0x100e_0a21, 1);  push(ecx);                            /* push ecx */
            ii(0x100e_0a22, 1);  push(edx);                            /* push edx */
            ii(0x100e_0a23, 1);  push(esi);                            /* push esi */
            ii(0x100e_0a24, 1);  push(edi);                            /* push edi */
            ii(0x100e_0a25, 1);  push(ebp);                            /* push ebp */
            ii(0x100e_0a26, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100e_0a28, 6);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x100e_0a2e, 7);  mov(memd[ss, ebp - 4], 5);            /* mov dword [ebp-0x4], 0x5 */
            ii(0x100e_0a35, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_0a38, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100e_0a3a, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100e_0a3b, 1);  pop(edi);                             /* pop edi */
            ii(0x100e_0a3c, 1);  pop(esi);                             /* pop esi */
            ii(0x100e_0a3d, 1);  pop(edx);                             /* pop edx */
            ii(0x100e_0a3e, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100e_0a3f, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100e_0a40, 1);  ret();                                /* ret */
        }
    }
}
