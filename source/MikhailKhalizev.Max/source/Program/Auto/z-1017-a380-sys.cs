using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_a380-f13df03e")]
        public void /* sys */ Method_1017_a380()
        {
            ii(0x1017_a380, 1);  push(ebp);                            /* push ebp */
            ii(0x1017_a381, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1017_a383, 7);  cmp(memd[ds, 0x101b_e418], -1 /* 0xff */);/* cmp dword [0x101be418], 0xffffffff */
            ii(0x1017_a38a, 2);  if(jz(0x1017_a396, 0xa)) goto l_0x1017_a396;/* jz 0x1017a396 */
            ii(0x1017_a38c, 10);  mov(memd[ds, 0x101b_e438], 1);       /* mov dword [0x101be438], 0x1 */
        l_0x1017_a396:
            ii(0x1017_a396, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1017_a398, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1017_a399, 1);  ret();                                /* ret */
        }
    }
}
