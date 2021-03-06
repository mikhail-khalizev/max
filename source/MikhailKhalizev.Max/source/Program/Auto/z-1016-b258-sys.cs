using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_b258-93656920")]
        public void /* sys */ Method_1016_b258()
        {
            ii(0x1016_b258, 5);  call(/* sys */ 0x1016_b390, 0x133);   /* call 0x1016b390 */
            ii(0x1016_b25d, 5);  call(/* sys */ 0x1018_63bc, 0x1_b15a);/* call 0x101863bc */
            ii(0x1016_b262, 3);  cmp(eax, 3);                          /* cmp eax, 0x3 */
            ii(0x1016_b265, 2);  if(jz(0x1016_b26c, 5)) goto l_0x1016_b26c;/* jz 0x1016b26c */
            ii(0x1016_b267, 5);  call(/* sys */ 0x1016_be9c, 0xc30);   /* call 0x1016be9c */
        l_0x1016_b26c:
            ii(0x1016_b26c, 5);  call(/* sys */ 0x1016_7ea0, -0x33d1); /* call 0x10167ea0 */
            ii(0x1016_b271, 3);  cmp(eax, -1 /* 0xff */);              /* cmp eax, 0xffffffff */
            ii(0x1016_b274, 2);  if(jnz_func(0x1016_b280, 0xa)) return;/* jnz 0x1016b280 */
            ii(0x1016_b276, 5);  call(/* sys */ 0x1017_2c3c, 0x79c1);  /* call 0x10172c3c */
            ii(0x1016_b27b, 3);  cmp(eax, -1 /* 0xff */);              /* cmp eax, 0xffffffff */
            ii(0x1016_b27e, 2);  jz_func(0x1016_b255, -0x2b);          /* jz 0x1016b255 */
        }
    }
}
