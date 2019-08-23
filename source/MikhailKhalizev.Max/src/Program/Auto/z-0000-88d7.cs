using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x88d7-41b1436")]
        public void Method_0000_88d7()
        {
            ii(0x88d7, 4);    enterw(0x8, 0);                           /* enter 0x8, 0x0 */
            ii(0x88db, 5);    mov(memw_a16[ss, bp - 0x4], 0x47b2);      /* mov word [bp-0x4], 0x47b2 */
            ii(0x88e0, 5);    mov(memw_a16[ss, bp - 0x2], 0x35f);       /* mov word [bp-0x2], 0x35f */
            ii(0x88e5, 3);    mov(memw_a16[ss, bp - 0x6], ds);          /* mov [bp-0x6], ds */
            ii(0x88e8, 5);    cmp(memw_a16[ds, 0xe70], 0);              /* cmp word [0xe70], 0x0 */
            ii(0x88ed, 2);    if(jgew(0x88f6, 0x7)) goto l_0x88f6;      /* jge 0x88f6 */
            ii(0x88ef, 3);    pushw(0x1190);                            /* push 0x1190 */
            ii(0x88f2, 3);    callw(0x9d58, 0x1463);                    /* call 0x9d58 */
            ii(0x88f5, 1);    popw(bx);                                 /* pop bx */
        l_0x88f6:
            ii(0x88f6, 5);    cmp(memw_a16[ds, 0xe70], 0);              /* cmp word [0xe70], 0x0 */
            ii(0x88fb, 2);    if(jgew(0x8903, 0x6)) goto l_0x8903;      /* jge 0x8903 */
            ii(0x88fd, 2);    pushw(-0x8 /* 0xf8 */);                   /* push 0xfff8 */
            ii(0x88ff, 3);    callw(0x604d, -0x28b5);                   /* call 0x604d */
            ii(0x8902, 1);    popw(bx);                                 /* pop bx */
        l_0x8903:
            ii(0x8903, 3);    mov(ax, memw_a16[ds, 0xc26]);             /* mov ax, [0xc26] */
            ii(0x8906, 3);    mov(memw_a16[ss, bp - 0x2], ax);          /* mov [bp-0x2], ax */
            ii(0x8909, 1);    pushw(ds);                                /* push ds */
            ii(0x890a, 3);    pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x890d, 2);    pushw(0);                                 /* push 0x0 */
            ii(0x890f, 3);    callw_a16_far_ind(ss, bp - 0x4);          /* call far word [bp-0x4] */
            ii(0x8912, 3);    mov(ax, memw_a16[ss, bp - 0x6]);          /* mov ax, [bp-0x6] */
            ii(0x8915, 6);    mov(memw_a16[ds, 0x42], 0x9fa);           /* mov word [0x42], 0x9fa */
            ii(0x891b, 3);    mov(memw_a16[ds, 0x44], ax);              /* mov [0x44], ax */
            ii(0x891e, 1);    leavew();                                 /* leave */
            ii(0x891f, 1);    retw();                                   /* ret */
        }
    }
}
