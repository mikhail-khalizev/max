using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_495c-951fc28f")]
        public void Method_1016_495c()
        {
            ii(0x1016_495c, 1);  push(ebx);                            /* push ebx */
            ii(0x1016_495d, 1);  push(ecx);                            /* push ecx */
            ii(0x1016_495e, 1);  push(edx);                            /* push edx */
            ii(0x1016_495f, 1);  push(esi);                            /* push esi */
            ii(0x1016_4960, 1);  push(edi);                            /* push edi */
            ii(0x1016_4961, 1);  push(ebp);                            /* push ebp */
            ii(0x1016_4962, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1016_4964, 6);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x1016_496a, 7);  mov(memd[ss, ebp - 4], 0x7fff);       /* mov dword [ebp-0x4], 0x7fff */
            ii(0x1016_4971, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_4974, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1016_4976, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1016_4977, 1);  pop(edi);                             /* pop edi */
            ii(0x1016_4978, 1);  pop(esi);                             /* pop esi */
            ii(0x1016_4979, 1);  pop(edx);                             /* pop edx */
            ii(0x1016_497a, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1016_497b, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1016_497c, 1);  ret();                                /* ret */
        }
    }
}
