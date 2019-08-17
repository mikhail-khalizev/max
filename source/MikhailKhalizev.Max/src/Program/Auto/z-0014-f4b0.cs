using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("4d8ff360-6869-4c36-8719-d66cb038e9d2")]
        public void Method_0014_f4b0()
        {
            ii(0x14_f4b0, 3); callw(0x14_fa00, 0x54d);                  /* call 0xfa00 */
            ii(0x14_f4b3, 2); or(al, ch);                               /* or al, ch */
            ii(0x14_f4b5, 1); dec(cx);                                  /* dec cx */
            ii(0x14_f4b6, 3); add(ax, 0xe809);                          /* add ax, 0xe809 */
            ii(0x14_f4b9, 1); inc(bp);                                  /* inc bp */
            ii(0x14_f4ba, 3); add(ax, 0xe80a);                          /* add ax, 0xe80a */
            ii(0x14_f4bd, 1); inc(cx);                                  /* inc cx */
            ii(0x14_f4be, 3); add(ax, 0xe80b);                          /* add ax, 0xe80b */
            ii(0x14_f4c1, 3); cmp(ax, 0xc05);                           /* cmp ax, 0xc05 */
            ii(0x14_f4c4, 3); callw(0x14_fa00, 0x539);                  /* call 0xfa00 */
        }
    }
}
