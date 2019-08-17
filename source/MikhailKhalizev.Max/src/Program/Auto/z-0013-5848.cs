using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("b271e32b-83eb-47c5-88bd-35d70f65d677")]
        public void Method_0013_5848()
        {
            ii(0x13_5848, 4); enterw(0xe, 0);                           /* enter 0xe, 0x0 */
            ii(0x13_584c, 1); pushw(si);                                /* push si */
            ii(0x13_584d, 1); pushw(ds);                                /* push ds */
            ii(0x13_584e, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x13_5851, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x13_5853, 5); test(memb_a16[ds, 0x19a2], 0x1);          /* test byte [0x19a2], 0x1 */
            ii(0x13_5858, 2); if(jzw(0x13_5872, 0x18)) goto l_0x13_5872; /* jz 0x5872 */
            ii(0x13_585a, 3); mov(ax, 0xe3c);                           /* mov ax, 0xe3c */
            ii(0x13_585d, 3); mov(bx, 0);                               /* mov bx, 0x0 */
            ii(0x13_5860, 2); @int(0x10);                               /* int 0x10 */
            ii(0x13_5862, 3); mov(ax, 0xe0d);                           /* mov ax, 0xe0d */
            ii(0x13_5865, 3); mov(bx, 0);                               /* mov bx, 0x0 */
            ii(0x13_5868, 2); @int(0x10);                               /* int 0x10 */
            ii(0x13_586a, 3); mov(ax, 0xe0a);                           /* mov ax, 0xe0a */
            ii(0x13_586d, 3); mov(bx, 0);                               /* mov bx, 0x0 */
            ii(0x13_5870, 2); @int(0x10);                               /* int 0x10 */
        l_0x13_5872:
            ii(0x13_5872, 5); cmp(memw_a16[ds, 0x982], 0);              /* cmp word [0x982], 0x0 */
            ii(0x13_5877, 2); if(jlew_func(0x13_587e, 0x5)) return;     /* jle 0x587e */
            ii(0x13_5879, 1); nop();                                    /* nop */
            ii(0x13_587a, 1); pushw(cs);                                /* push cs */
            ii(0x13_587b, 3); callw(0x13_83d4, 0x2b56);                 /* call 0x83d4 */
        }
    }
}
