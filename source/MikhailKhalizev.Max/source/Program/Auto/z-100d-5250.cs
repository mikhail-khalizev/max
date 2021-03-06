using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_5250-f35dcb81")]
        public void Method_100d_5250()
        {
            ii(0x100d_5250, 1);  push(ebx);                            /* push ebx */
            ii(0x100d_5251, 1);  push(ecx);                            /* push ecx */
            ii(0x100d_5252, 1);  push(edx);                            /* push edx */
            ii(0x100d_5253, 1);  push(esi);                            /* push esi */
            ii(0x100d_5254, 1);  push(edi);                            /* push edi */
            ii(0x100d_5255, 1);  push(ebp);                            /* push ebp */
            ii(0x100d_5256, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100d_5258, 6);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x100d_525e, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100d_5261, 5);  mov(edx, 0x101c_35a8);                /* mov edx, 0x101c35a8 */
            ii(0x100d_5266, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_5269, 5);  call(0x100d_4d78, -0x4f6);            /* call 0x100d4d78 */
            ii(0x100d_526e, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_5271, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100d_5273, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100d_5274, 1);  pop(edi);                             /* pop edi */
            ii(0x100d_5275, 1);  pop(esi);                             /* pop esi */
            ii(0x100d_5276, 1);  pop(edx);                             /* pop edx */
            ii(0x100d_5277, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100d_5278, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100d_5279, 1);  ret();                                /* ret */
        }
    }
}
