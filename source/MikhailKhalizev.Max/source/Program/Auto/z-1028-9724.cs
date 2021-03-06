using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1028_9724-20c3ae44")]
        public void Method_1028_9724()
        {
            ii(0x1028_9724, 6);  mov(cl, memb[ds, 0x13d]);             /* mov cl, [0x13d] */
            ii(0x1028_972a, 4);  mov(dx, 0x21);                        /* mov dx, 0x21 */
            ii(0x1028_972e, 3);  cmp(cl, 0x10);                        /* cmp cl, 0x10 */
            ii(0x1028_9731, 6);  if(jb(0x1028_973b, 4)) goto l_0x1028_973b;/* jb 0x1028973b */
            ii(0x1028_9737, 4);  mov(dx, 0xa1);                        /* mov dx, 0xa1 */
        l_0x1028_973b:
            ii(0x1028_973b, 1);  inb(al, dx);                          /* in al, dx */
            ii(0x1028_973c, 6);  mov(bl, memb[ds, 0x141]);             /* mov bl, [0x141] */
            ii(0x1028_9742, 2);  or(al, bl);                           /* or al, bl */
            ii(0x1028_9744, 1);  outb(dx, al);                         /* out dx, al */
            ii(0x1028_9745, 1);  ret();                                /* ret */
        }
    }
}
