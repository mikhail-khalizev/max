using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_5de0-6b09193d")]
        public void /* sys */ sys_memset()
        {
            ii(0x1016_5de0, 1);  push(eax);                            /* push eax */
            ii(0x1016_5de1, 1);  push(ecx);                            /* push ecx */
            ii(0x1016_5de2, 2);  mov(dh, dl);                          /* mov dh, dl */
            ii(0x1016_5de4, 3);  shl(edx, 8);                          /* shl edx, 0x8 */
            ii(0x1016_5de7, 2);  mov(dl, dh);                          /* mov dl, dh */
            ii(0x1016_5de9, 3);  shl(edx, 8);                          /* shl edx, 0x8 */
            ii(0x1016_5dec, 2);  mov(dl, dh);                          /* mov dl, dh */
            ii(0x1016_5dee, 2);  mov(ecx, ebx);                        /* mov ecx, ebx */
            ii(0x1016_5df0, 5);  call(/* sys */ 0x1018_1040, 0x1_b24b);/* call 0x10181040 */
            ii(0x1016_5df5, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1016_5df6, 1);  pop(eax);                             /* pop eax */
            ii(0x1016_5df7, 1);  ret();                                /* ret */
        }
    }
}
