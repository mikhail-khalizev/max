using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a6e6fbe6-4516-4aa8-bd30-d78f6843ff6b")]
        public void Method_0013_7476()
        {
            ii(0x13_7476, 4); enterw(0xa, 0);                           /* enter 0xa, 0x0 */
            ii(0x13_747a, 1); pushw(di);                                /* push di */
            ii(0x13_747b, 1); pushw(si);                                /* push si */
            ii(0x13_747c, 1); pushw(ds);                                /* push ds */
            ii(0x13_747d, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x13_7480, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x13_7482, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x13_7485, 1); inc(ax);                                  /* inc ax */
            ii(0x13_7486, 1); cwd();                                    /* cwd */
            ii(0x13_7487, 2); mov(dh, dl);                              /* mov dh, dl */
            ii(0x13_7489, 2); mov(dl, ah);                              /* mov dl, ah */
            ii(0x13_748b, 2); mov(ah, al);                              /* mov ah, al */
            ii(0x13_748d, 2); sub(al, al);                              /* sub al, al */
            ii(0x13_748f, 3); sub(ax, 0x1);                             /* sub ax, 0x1 */
            ii(0x13_7492, 3); sbb(dx, 0);                               /* sbb dx, 0x0 */
            ii(0x13_7495, 3); mov(memw_a16[ss, bp - 0xa], ax);          /* mov [bp-0xa], ax */
            ii(0x13_7498, 3); mov(memw_a16[ss, bp - 0x8], dx);          /* mov [bp-0x8], dx */
            ii(0x13_749b, 1); pushw(dx);                                /* push dx */
            ii(0x13_749c, 1); pushw(ax);                                /* push ax */
            ii(0x13_749d, 4); callw_a16_far_ind(ds, 0x1e9e);            /* call far word [0x1e9e] */
            ii(0x13_74a1, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x13_74a4, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x13_74a7, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x13_74aa, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x13_74ac, 2); if(jnzw(0x13_74b6, 0x8)) goto l_0x13_74b6; /* jnz 0x74b6 */
            ii(0x13_74ae, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x13_74b0, 1); cwd();                                    /* cwd */
            ii(0x13_74b1, 1); popw(ds);                                 /* pop ds */
            ii(0x13_74b2, 1); popw(si);                                 /* pop si */
            ii(0x13_74b3, 1); popw(di);                                 /* pop di */
            ii(0x13_74b4, 1); leavew();                                 /* leave */
            ii(0x13_74b5, 1); retfw(); return;                          /* retf */
        l_0x13_74b6:
            ii(0x13_74b6, 3); mov(dx, memw_a16[ss, bp - 0x2]);          /* mov dx, [bp-0x2] */
            ii(0x13_74b9, 3); add(memw_a16[ss, bp - 0xa], ax);          /* add [bp-0xa], ax */
            ii(0x13_74bc, 3); adc(memw_a16[ss, bp - 0x8], dx);          /* adc [bp-0x8], dx */
            ii(0x13_74bf, 2); neg(ax);                                  /* neg ax */
            ii(0x13_74c1, 2); sub(ah, ah);                              /* sub ah, ah */
            ii(0x13_74c3, 3); mov(memw_a16[ss, bp - 0x6], ax);          /* mov [bp-0x6], ax */
            ii(0x13_74c6, 2); sub(dx, dx);                              /* sub dx, dx */
            ii(0x13_74c8, 1); pushw(dx);                                /* push dx */
            ii(0x13_74c9, 1); pushw(ax);                                /* push ax */
            ii(0x13_74ca, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x13_74cd, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x13_74d0, 2); mov(si, ax);                              /* mov si, ax */
            ii(0x13_74d2, 2); mov(di, dx);                              /* mov di, dx */
            ii(0x13_74d4, 4); callw_a16_far_ind(ds, 0x1ea2);            /* call far word [0x1ea2] */
            ii(0x13_74d8, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x13_74db, 3); mov(al, memb_a16[ss, bp - 0xa]);          /* mov al, [bp-0xa] */
            ii(0x13_74de, 2); sub(ah, ah);                              /* sub ah, ah */
            ii(0x13_74e0, 1); pushw(di);                                /* push di */
            ii(0x13_74e1, 1); pushw(ax);                                /* push ax */
            ii(0x13_74e2, 3); mov(ax, memw_a16[ss, bp - 0xa]);          /* mov ax, [bp-0xa] */
            ii(0x13_74e5, 3); mov(dx, memw_a16[ss, bp - 0x8]);          /* mov dx, [bp-0x8] */
            ii(0x13_74e8, 2); sub(al, al);                              /* sub al, al */
            ii(0x13_74ea, 1); pushw(dx);                                /* push dx */
            ii(0x13_74eb, 1); pushw(ax);                                /* push ax */
            ii(0x13_74ec, 4); callw_a16_far_ind(ds, 0x1ea2);            /* call far word [0x1ea2] */
            ii(0x13_74f0, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x13_74f3, 3); add(memw_a16[ss, bp - 0x4], si);          /* add [bp-0x4], si */
            ii(0x13_74f6, 3); adc(memw_a16[ss, bp - 0x2], di);          /* adc [bp-0x2], di */
            ii(0x13_74f9, 3); mov(ax, memw_a16[ss, bp - 0x4]);          /* mov ax, [bp-0x4] */
            ii(0x13_74fc, 3); mov(dx, memw_a16[ss, bp - 0x2]);          /* mov dx, [bp-0x2] */
            ii(0x13_74ff, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_7501, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_7503, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_7505, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_7507, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_7509, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_750b, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_750d, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_750f, 1); popw(ds);                                 /* pop ds */
            ii(0x13_7510, 1); popw(si);                                 /* pop si */
            ii(0x13_7511, 1); popw(di);                                 /* pop di */
            ii(0x13_7512, 1); leavew();                                 /* leave */
            ii(0x13_7513, 1); retfw(); return;                          /* retf */
        }
    }
}
