using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("63ce26c1-8740-41d2-9c96-68ffa2856046")]
        public void Method_1028_9702()
        {
            ii(0x1028_9702, 6); mov(cl, memb_a32[ds, 0x13d]);           /* mov cl, [0x13d] */
            ii(0x1028_9708, 4); mov(dx, 0x21);                          /* mov dx, 0x21 */
            ii(0x1028_970c, 3); cmp(cl, 0x10);                          /* cmp cl, 0x10 */
            ii(0x1028_970f, 6); if(jbd(0x1028_9719, 0x4)) goto l_0x1028_9719; /* jb 0x10289719 */
            ii(0x1028_9715, 4); mov(dx, 0xa1);                          /* mov dx, 0xa1 */
        l_0x1028_9719:
            ii(0x1028_9719, 1); inb(al, dx);                            /* in al, dx */
            ii(0x1028_971a, 6); mov(bl, memb_a32[ds, 0x13f]);           /* mov bl, [0x13f] */
            ii(0x1028_9720, 2); and(al, bl);                            /* and al, bl */
            ii(0x1028_9722, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1028_9723, 1); retd(); return;                         /* ret */
        }
    }
}
