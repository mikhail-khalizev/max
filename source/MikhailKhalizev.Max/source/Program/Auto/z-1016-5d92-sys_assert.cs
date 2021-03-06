using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_5d92-1c5ee299")]
        public void /* sys */ sys_assert()
        {
            ii(0x1016_5d92, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1016_5d94, 2);  if(jnz(0x1016_5db0, 0x1a)) goto l_0x1016_5db0;/* jnz 0x10165db0 */
            ii(0x1016_5d96, 1);  push(ecx);                            /* push ecx */
            ii(0x1016_5d97, 1);  push(ebx);                            /* push ebx */
            ii(0x1016_5d98, 1);  push(edx);                            /* push edx */
            ii(0x1016_5d99, 5);  push(StringDefinitions.AssertionFailedHsFileHsLineD);/* push 0x101b2d4c */
            ii(0x1016_5d9e, 5);  push(0x101b_e5d4);                    /* push 0x101be5d4 */
            ii(0x1016_5da3, 5);  call(/* sys */ 0x1017_913b, 0x1_3393);/* call 0x1017913b */
            ii(0x1016_5da8, 3);  add(esp, 0x14);                       /* add esp, 0x14 */
            ii(0x1016_5dab, 5);  if(jmp_func(0x1018_1020, 0x1_b270)) return;/* jmp 0x10181020 */
        l_0x1016_5db0:
            ii(0x1016_5db0, 1);  ret();                                /* ret */
        }
    }
}
