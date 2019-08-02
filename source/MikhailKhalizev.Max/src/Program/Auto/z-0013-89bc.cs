using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("f0bfc075-012d-4aaf-b57d-f0b423e91612")]
        public void Method_0013_89bc()
        {
            ii(0x13_89bc, 4); enterw(0x4, 0);                           /* enter 0x4, 0x0 */
            ii(0x13_89c0, 1); pushw(ds);                                /* push ds */
            ii(0x13_89c1, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x13_89c4, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x13_89c6, 3); mov(ax, memw_a16[ss, bp + 0x8]);          /* mov ax, [bp+0x8] */
            ii(0x13_89c9, 3); mov(bx, memw_a16[ss, bp + 0x6]);          /* mov bx, [bp+0x6] */
            ii(0x13_89cc, 3); mov(cx, 0x8);                             /* mov cx, 0x8 */
            ii(0x13_89cf, 2); mov(es, cx);                              /* mov es, cx */
            ii(0x13_89d1, 3); mov(memw_a16[ss, bp - 0x4], bx);          /* mov [bp-0x4], bx */
            ii(0x13_89d4, 3); mov(memw_a16[ss, bp - 0x2], es);          /* mov [bp-0x2], es */
            ii(0x13_89d7, 4); mov(memw_a16[es, bx + 0x2], ax);          /* mov [es:bx+0x2], ax */
            ii(0x13_89db, 3); mov(al, memb_a16[ss, bp + 0xa]);          /* mov al, [bp+0xa] */
            ii(0x13_89de, 4); mov(memb_a16[es, bx + 0x4], al);          /* mov [es:bx+0x4], al */
            ii(0x13_89e2, 3); mov(al, memb_a16[ss, bp + 0xb]);          /* mov al, [bp+0xb] */
            ii(0x13_89e5, 4); mov(memb_a16[es, bx + 0x7], al);          /* mov [es:bx+0x7], al */
            ii(0x13_89e9, 1); popw(ds);                                 /* pop ds */
            ii(0x13_89ea, 1); leavew();                                 /* leave */
            ii(0x13_89eb, 1); retfw(); return;                          /* retf */
        }
    }
}
