using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_0bd0-404994bb")]
        public void Method_100e_0bd0()
        {
            ii(0x100e_0bd0, 1);  push(ebx);                            /* push ebx */
            ii(0x100e_0bd1, 1);  push(ecx);                            /* push ecx */
            ii(0x100e_0bd2, 1);  push(edx);                            /* push edx */
            ii(0x100e_0bd3, 1);  push(esi);                            /* push esi */
            ii(0x100e_0bd4, 1);  push(edi);                            /* push edi */
            ii(0x100e_0bd5, 1);  push(ebp);                            /* push ebp */
            ii(0x100e_0bd6, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100e_0bd8, 6);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x100e_0bde, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100e_0be1, 5);  mov(edx, 0x101c_35a8);                /* mov edx, 0x101c35a8 */
            ii(0x100e_0be6, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_0be9, 5);  call(0x100d_4d78, -0xbe76);           /* call 0x100d4d78 */
            ii(0x100e_0bee, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_0bf1, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100e_0bf3, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100e_0bf4, 1);  pop(edi);                             /* pop edi */
            ii(0x100e_0bf5, 1);  pop(esi);                             /* pop esi */
            ii(0x100e_0bf6, 1);  pop(edx);                             /* pop edx */
            ii(0x100e_0bf7, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100e_0bf8, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100e_0bf9, 1);  ret();                                /* ret */
        }
    }
}
