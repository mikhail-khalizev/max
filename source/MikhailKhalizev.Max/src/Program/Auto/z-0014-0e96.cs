using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("9c3b8909-7218-4b6c-aaa9-66e84e5dd47c")]
        public void Method_0014_0e96()
        {
            ii(0x14_0e96, 4); enterw(0x4, 0);                           /* enter 0x4, 0x0 */
            ii(0x14_0e9a, 1); pushw(ds);                                /* push ds */
            ii(0x14_0e9b, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x14_0e9e, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x14_0ea0, 1); pushw(ds);                                /* push ds */
            ii(0x14_0ea1, 3); pushw(0x1b6c);                            /* push 0x1b6c */
            ii(0x14_0ea4, 1); nop();                                    /* nop */
            ii(0x14_0ea5, 1); pushw(cs);                                /* push cs */
            ii(0x14_0ea6, 3); callw(0x13_edf0, -0x20b9);                /* call 0xedf0 */
            ii(0x14_0ea9, 1); popw(bx);                                 /* pop bx */
            ii(0x14_0eaa, 1); popw(bx);                                 /* pop bx */
            ii(0x14_0eab, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x14_0eae, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x14_0eb1, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x14_0eb3, 2); if(jzw(0x14_0ed4, 0x1f)) goto l_0x14_0ed4; /* jz 0xed4 */
            ii(0x14_0eb5, 1); pushw(ds);                                /* push ds */
            ii(0x14_0eb6, 3); pushw(0x1b73);                            /* push 0x1b73 */
            ii(0x14_0eb9, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x14_0ebc, 1); pushw(ax);                                /* push ax */
            ii(0x14_0ebd, 1); nop();                                    /* nop */
            ii(0x14_0ebe, 1); pushw(cs);                                /* push cs */
            ii(0x14_0ebf, 3); callw(0x13_ec70, -0x2252);                /* call 0xec70 */
            ii(0x14_0ec2, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x14_0ec5, 3); mov(memw_a16[ds, 0x1b60], ax);            /* mov [0x1b60], ax */
            ii(0x14_0ec8, 4); mov(memw_a16[ds, 0x1b62], dx);            /* mov [0x1b62], dx */
            ii(0x14_0ecc, 2); mov(ax, dx);                              /* mov ax, dx */
            ii(0x14_0ece, 4); or(ax, memw_a16[ds, 0x1b60]);             /* or ax, [0x1b60] */
            ii(0x14_0ed2, 2); if(jnzw(0x14_0edd, 0x9)) goto l_0x14_0edd; /* jnz 0xedd */
        l_0x14_0ed4:
            ii(0x14_0ed4, 3); pushw(0xee);                              /* push 0xee */
            ii(0x14_0ed7, 1); nop();                                    /* nop */
            ii(0x14_0ed8, 1); pushw(cs);                                /* push cs */
            ii(0x14_0ed9, 3); callw(0x13_d54f, -0x398d);                /* call 0xd54f */
            ii(0x14_0edc, 1); popw(bx);                                 /* pop bx */
        l_0x14_0edd:
            ii(0x14_0edd, 1); pushw(ds);                                /* push ds */
            ii(0x14_0ede, 3); pushw(0x1b7c);                            /* push 0x1b7c */
            ii(0x14_0ee1, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x14_0ee4, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x14_0ee7, 1); nop();                                    /* nop */
            ii(0x14_0ee8, 1); pushw(cs);                                /* push cs */
            ii(0x14_0ee9, 3); callw(0x13_ec70, -0x227c);                /* call 0xec70 */
            ii(0x14_0eec, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x14_0eef, 3); mov(memw_a16[ds, 0x1b64], ax);            /* mov [0x1b64], ax */
            ii(0x14_0ef2, 4); mov(memw_a16[ds, 0x1b66], dx);            /* mov [0x1b66], dx */
            ii(0x14_0ef6, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x14_0ef9, 3); mov(dx, memw_a16[ss, bp + 0x8]);          /* mov dx, [bp+0x8] */
            ii(0x14_0efc, 3); mov(memw_a16[ds, 0x1b68], ax);            /* mov [0x1b68], ax */
            ii(0x14_0eff, 4); mov(memw_a16[ds, 0x1b6a], dx);            /* mov [0x1b6a], dx */
            ii(0x14_0f03, 1); pushw(cs);                                /* push cs */
            ii(0x14_0f04, 3); callw(0x14_0e76, -0x91);                  /* call 0xe76 */
            ii(0x14_0f07, 1); popw(ds);                                 /* pop ds */
            ii(0x14_0f08, 1); leavew();                                 /* leave */
            ii(0x14_0f09, 3); retfw(0x4); return;                       /* retf 0x4 */
        }
    }
}
