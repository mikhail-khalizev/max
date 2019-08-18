using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_54b4-a5b52fd")]
        public void Method_0017_54b4()
        {
            ii(0x17_54b4, 4); enterw(0x14, 0);                          /* enter 0x14, 0x0 */
            ii(0x17_54b8, 1); pushw(si);                                /* push si */
            ii(0x17_54b9, 1); pushw(ds);                                /* push ds */
            ii(0x17_54ba, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x17_54bd, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x17_54bf, 3); pushw(0x1000);                            /* push 0x1000 */
            ii(0x17_54c2, 1); nop();                                    /* nop */
            ii(0x17_54c3, 1); pushw(cs);                                /* push cs */
            ii(0x17_54c4, 3); callw(0x16_e7a8, -0x6d1f);                /* call 0xe7a8 */
            ii(0x17_54c7, 3); add(sp, 0x2);                             /* add sp, 0x2 */
            ii(0x17_54ca, 3); mov(memw_a16[ss, bp - 0x14], ax);         /* mov [bp-0x14], ax */
            ii(0x17_54cd, 3); mov(memw_a16[ss, bp - 0x12], dx);         /* mov [bp-0x12], dx */
            ii(0x17_54d0, 2); mov(ax, dx);                              /* mov ax, dx */
            ii(0x17_54d2, 3); or(ax, memw_a16[ss, bp - 0x14]);          /* or ax, [bp-0x14] */
            ii(0x17_54d5, 2); if(jnzw(0x17_54ea, 0x13)) goto l_0x17_54ea; /* jnz 0x54ea */
            ii(0x17_54d7, 1); pushw(ds);                                /* push ds */
            ii(0x17_54d8, 3); pushw(0x32c);                             /* push 0x32c */
            ii(0x17_54db, 1); nop();                                    /* nop */
            ii(0x17_54dc, 1); pushw(cs);                                /* push cs */
            ii(0x17_54dd, 3); callw(0x17_104f, -0x4491);                /* call 0x104f */
            ii(0x17_54e0, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x17_54e3, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x17_54e6, 1); popw(ds);                                 /* pop ds */
            ii(0x17_54e7, 1); popw(si);                                 /* pop si */
            ii(0x17_54e8, 1); leavew();                                 /* leave */
            ii(0x17_54e9, 1); retfw(); return;                          /* retf */
        l_0x17_54ea:
            ii(0x17_54ea, 5); mov(memw_a16[ss, bp - 0x2], 0xffc);       /* mov word [bp-0x2], 0xffc */
            ii(0x17_54ef, 5); mov(memw_a16[ss, bp - 0x8], 0x4ba8);      /* mov word [bp-0x8], 0x4ba8 */
            ii(0x17_54f4, 5); mov(memw_a16[ss, bp - 0x6], 0x3e58);      /* mov word [bp-0x6], 0x3e58 */
            ii(0x17_54f9, 2); mov(ax, dx);                              /* mov ax, dx */
            ii(0x17_54fb, 3); mov(memw_a16[ss, bp - 0xa], ax);          /* mov [bp-0xa], ax */
            ii(0x17_54fe, 1); nop();                                    /* nop */
            ii(0x17_54ff, 1); pushw(cs);                                /* push cs */
            ii(0x17_5500, 3); callw(0x17_9199, 0x3c96);                 /* call 0x9199 */
            ii(0x17_5503, 3); mov(memw_a16[ss, bp - 0xe], ax);          /* mov [bp-0xe], ax */
            ii(0x17_5506, 3); mov(memw_a16[ss, bp - 0xc], ax);          /* mov [bp-0xc], ax */
            ii(0x17_5509, 5); mov(memw_a16[ss, bp - 0x10], 0x1);        /* mov word [bp-0x10], 0x1 */
            ii(0x17_550e, 2); sub(cx, cx);                              /* sub cx, cx */
            ii(0x17_5510, 3); mov(memw_a16[ss, bp - 0x4], cx);          /* mov [bp-0x4], cx */
            ii(0x17_5513, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x17_5516, 3); mov(memw_a16[es, bx], cx);                /* mov [es:bx], cx */
            ii(0x17_5519, 4); mov(memw_a16[es, bx + 0x2], cx);          /* mov [es:bx+0x2], cx */
            ii(0x17_551d, 6); mov(memw_a16[es, bx + 0x4], 0xffc);       /* mov word [es:bx+0x4], 0xffc */
            ii(0x17_5523, 4); mov(memw_a16[es, bx + 0x6], cx);          /* mov [es:bx+0x6], cx */
            ii(0x17_5527, 3); mov(cx, memw_a16[ss, bp - 0xa]);          /* mov cx, [bp-0xa] */
            ii(0x17_552a, 4); mov(memw_a16[es, bx + 0x8], cx);          /* mov [es:bx+0x8], cx */
            ii(0x17_552e, 6); mov(memw_a16[es, bx + 0xa], 0);           /* mov word [es:bx+0xa], 0x0 */
            ii(0x17_5534, 6); mov(memw_a16[es, bx + 0xc], 0xffc);       /* mov word [es:bx+0xc], 0xffc */
            ii(0x17_553a, 6); mov(memw_a16[es, bx + 0xe], 0);           /* mov word [es:bx+0xe], 0x0 */
            ii(0x17_5540, 4); mov(memw_a16[es, bx + 0x10], cx);         /* mov [es:bx+0x10], cx */
            ii(0x17_5544, 6); mov(memw_a16[es, bx + 0x12], 0);          /* mov word [es:bx+0x12], 0x0 */
            ii(0x17_554a, 6); mov(memw_a16[es, bx + 0x14], 0xffc);      /* mov word [es:bx+0x14], 0xffc */
            ii(0x17_5550, 6); mov(memw_a16[es, bx + 0x16], 0);          /* mov word [es:bx+0x16], 0x0 */
            ii(0x17_5556, 4); mov(memw_a16[es, bx + 0x18], cx);         /* mov [es:bx+0x18], cx */
            ii(0x17_555a, 6); mov(memw_a16[es, bx + 0x1a], 0);          /* mov word [es:bx+0x1a], 0x0 */
            ii(0x17_5560, 3); mov(dx, memw_a16[ss, bp - 0x8]);          /* mov dx, [bp-0x8] */
            ii(0x17_5563, 4); mov(memw_a16[es, bx + 0x20], dx);         /* mov [es:bx+0x20], dx */
            ii(0x17_5567, 6); mov(memw_a16[es, bx + 0x22], 0);          /* mov word [es:bx+0x22], 0x0 */
            ii(0x17_556d, 6); mov(memw_a16[es, bx + 0x24], 0x1);        /* mov word [es:bx+0x24], 0x1 */
            ii(0x17_5573, 6); mov(memw_a16[es, bx + 0x26], 0);          /* mov word [es:bx+0x26], 0x0 */
            ii(0x17_5579, 2); sub(dx, dx);                              /* sub dx, dx */
            ii(0x17_557b, 4); mov(memw_a16[es, bx + 0x2a], dx);         /* mov [es:bx+0x2a], dx */
            ii(0x17_557f, 4); mov(memw_a16[es, bx + 0x28], dx);         /* mov [es:bx+0x28], dx */
            ii(0x17_5583, 4); mov(memw_a16[es, bx + 0x2e], dx);         /* mov [es:bx+0x2e], dx */
            ii(0x17_5587, 4); mov(memw_a16[es, bx + 0x2c], dx);         /* mov [es:bx+0x2c], dx */
            ii(0x17_558b, 4); mov(memw_a16[es, bx + 0x32], dx);         /* mov [es:bx+0x32], dx */
            ii(0x17_558f, 4); mov(memw_a16[es, bx + 0x30], dx);         /* mov [es:bx+0x30], dx */
            ii(0x17_5593, 4); mov(memw_a16[es, bx + 0x36], dx);         /* mov [es:bx+0x36], dx */
            ii(0x17_5597, 4); mov(memw_a16[es, bx + 0x34], dx);         /* mov [es:bx+0x34], dx */
            ii(0x17_559b, 3); mov(dx, 0xffc);                           /* mov dx, 0xffc */
            ii(0x17_559e, 2); sub(si, si);                              /* sub si, si */
            ii(0x17_55a0, 4); mov(memw_a16[es, bx + 0x38], dx);         /* mov [es:bx+0x38], dx */
            ii(0x17_55a4, 4); mov(memw_a16[es, bx + 0x3a], si);         /* mov [es:bx+0x3a], si */
            ii(0x17_55a8, 4); mov(memw_a16[es, bx + 0x3c], dx);         /* mov [es:bx+0x3c], dx */
            ii(0x17_55ac, 4); mov(memw_a16[es, bx + 0x3e], si);         /* mov [es:bx+0x3e], si */
            ii(0x17_55b0, 2); sub(dx, dx);                              /* sub dx, dx */
            ii(0x17_55b2, 4); mov(memw_a16[es, bx + 0x42], dx);         /* mov [es:bx+0x42], dx */
            ii(0x17_55b6, 4); mov(memw_a16[es, bx + 0x40], dx);         /* mov [es:bx+0x40], dx */
            ii(0x17_55ba, 4); mov(memw_a16[es, bx + 0x46], dx);         /* mov [es:bx+0x46], dx */
            ii(0x17_55be, 4); mov(memw_a16[es, bx + 0x44], dx);         /* mov [es:bx+0x44], dx */
            ii(0x17_55c2, 4); mov(memw_a16[es, bx + 0x48], ax);         /* mov [es:bx+0x48], ax */
            ii(0x17_55c6, 4); mov(memw_a16[es, bx + 0x4a], dx);         /* mov [es:bx+0x4a], dx */
            ii(0x17_55ca, 3); mov(dx, memw_a16[ss, bp - 0x6]);          /* mov dx, [bp-0x6] */
            ii(0x17_55cd, 4); mov(memw_a16[es, bx + 0x4c], dx);         /* mov [es:bx+0x4c], dx */
            ii(0x17_55d1, 4); mov(memw_a16[es, bx + 0x50], cx);         /* mov [es:bx+0x50], cx */
            ii(0x17_55d5, 4); mov(memw_a16[es, bx + 0x54], ax);         /* mov [es:bx+0x54], ax */
            ii(0x17_55d9, 4); mov(memw_a16[es, bx + 0x60], si);         /* mov [es:bx+0x60], si */
            ii(0x17_55dd, 4); mov(memw_a16[es, bx + 0x64], si);         /* mov [es:bx+0x64], si */
            ii(0x17_55e1, 4); mov(memw_a16[es, bx + 0x66], si);         /* mov [es:bx+0x66], si */
            ii(0x17_55e5, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x17_55e7, 1); popw(ds);                                 /* pop ds */
            ii(0x17_55e8, 1); popw(si);                                 /* pop si */
            ii(0x17_55e9, 1); leavew();                                 /* leave */
            ii(0x17_55ea, 1); retfw(); return;                          /* retf */
        }
    }
}
