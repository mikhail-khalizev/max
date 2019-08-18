using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("04155327-56c4-4a1e-90b2-2d7453c09bc6")]
        public void Method_0019_32a4()
        {
            ii(0x19_32a4, 1); pushw(bp);                                /* push bp */
            ii(0x19_32a5, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x19_32a7, 3); sub(sp, 0x4);                             /* sub sp, 0x4 */
            ii(0x19_32aa, 1); pushw(si);                                /* push si */
            ii(0x19_32ab, 3); mov(ax, memw_a16[ds, 0x3c3b]);            /* mov ax, [0x3c3b] */
            ii(0x19_32ae, 4); mov(dx, memw_a16[ds, 0x3c3d]);            /* mov dx, [0x3c3d] */
            ii(0x19_32b2, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x19_32b5, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x19_32b8, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x19_32ba, 2); if(jzw(0x19_332a, 0x6e)) goto l_0x19_332a; /* jz 0x332a */
            ii(0x19_32bc, 3); mov(ax, memw_a16[ss, bp + 0x8]);          /* mov ax, [bp+0x8] */
            ii(0x19_32bf, 3); or(ax, memw_a16[ss, bp + 0x6]);           /* or ax, [bp+0x6] */
            ii(0x19_32c2, 2); if(jzw(0x19_332a, 0x66)) goto l_0x19_332a; /* jz 0x332a */
            ii(0x19_32c4, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x19_32c7, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x19_32ca, 1); nop();                                    /* nop */
            ii(0x19_32cb, 1); pushw(cs);                                /* push cs */
            ii(0x19_32cc, 3); callw(0x19_3b68, 0x899);                  /* call 0x3b68 */
            ii(0x19_32cf, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x19_32d2, 2); mov(si, ax);                              /* mov si, ax */
        l_0x19_32d4:
            ii(0x19_32d4, 3); les(bx, ss, bp - 0x4);                    /* les bx, [bp-0x4] */
            ii(0x19_32d7, 4); mov(ax, memw_a16[es, bx + 0x2]);          /* mov ax, [es:bx+0x2] */
            ii(0x19_32db, 3); or(ax, memw_a16[es, bx]);                 /* or ax, [es:bx] */
            ii(0x19_32de, 2); if(jzw(0x19_332a, 0x4a)) goto l_0x19_332a; /* jz 0x332a */
            ii(0x19_32e0, 4); pushw(memw_a16[es, bx + 0x2]);            /* push word [es:bx+0x2] */
            ii(0x19_32e4, 3); pushw(memw_a16[es, bx]);                  /* push word [es:bx] */
            ii(0x19_32e7, 1); nop();                                    /* nop */
            ii(0x19_32e8, 1); pushw(cs);                                /* push cs */
            ii(0x19_32e9, 3); callw(0x19_3b68, 0x87c);                  /* call 0x3b68 */
            ii(0x19_32ec, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x19_32ef, 2); cmp(ax, si);                              /* cmp ax, si */
            ii(0x19_32f1, 2); if(jlew(0x19_3324, 0x31)) goto l_0x19_3324; /* jle 0x3324 */
            ii(0x19_32f3, 3); les(bx, ss, bp - 0x4);                    /* les bx, [bp-0x4] */
            ii(0x19_32f6, 3); les(bx, es, bx);                          /* les bx, [es:bx] */
            ii(0x19_32f9, 4); cmp(memb_a16[es, bx + si], 0x3d);         /* cmp byte [es:bx+si], 0x3d */
            ii(0x19_32fd, 2); if(jnzw(0x19_3324, 0x25)) goto l_0x19_3324; /* jnz 0x3324 */
            ii(0x19_32ff, 1); pushw(si);                                /* push si */
            ii(0x19_3300, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x19_3303, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x19_3306, 1); pushw(es);                                /* push es */
            ii(0x19_3307, 1); pushw(bx);                                /* push bx */
            ii(0x19_3308, 1); nop();                                    /* nop */
            ii(0x19_3309, 1); pushw(cs);                                /* push cs */
            ii(0x19_330a, 3); callw(0x19_3b80, 0x873);                  /* call 0x3b80 */
            ii(0x19_330d, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x19_3310, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x19_3312, 2); if(jnzw(0x19_3324, 0x10)) goto l_0x19_3324; /* jnz 0x3324 */
            ii(0x19_3314, 3); les(bx, ss, bp - 0x4);                    /* les bx, [bp-0x4] */
            ii(0x19_3317, 3); mov(ax, memw_a16[es, bx]);                /* mov ax, [es:bx] */
            ii(0x19_331a, 4); mov(dx, memw_a16[es, bx + 0x2]);          /* mov dx, [es:bx+0x2] */
            ii(0x19_331e, 2); add(ax, si);                              /* add ax, si */
            ii(0x19_3320, 1); inc(ax);                                  /* inc ax */
            ii(0x19_3321, 2); jmpw(0x19_332d, 0xa); goto l_0x19_332d;   /* jmp 0x332d */
        //    ii(0x19_3323, 1); nop();                                    /* nop */
        l_0x19_3324:
            ii(0x19_3324, 4); add(memw_a16[ss, bp - 0x4], 0x4);         /* add word [bp-0x4], 0x4 */
            ii(0x19_3328, 2); jmpw(0x19_32d4, -0x56); goto l_0x19_32d4; /* jmp 0x32d4 */
        l_0x19_332a:
            ii(0x19_332a, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x19_332c, 1); cwd();                                    /* cwd */
        l_0x19_332d:
            ii(0x19_332d, 1); popw(si);                                 /* pop si */
            ii(0x19_332e, 2); mov(sp, bp);                              /* mov sp, bp */
            ii(0x19_3330, 1); popw(bp);                                 /* pop bp */
            ii(0x19_3331, 1); retfw(); return;                          /* retf */
        }
    }
}
