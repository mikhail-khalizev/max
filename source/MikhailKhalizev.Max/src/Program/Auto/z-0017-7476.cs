using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_7476-959fc82b")]
        public void Method_0017_7476()
        {
            ii(0x17_7476, 4); enter(0xa, 0);                            /* enter 0xa, 0x0 */
            ii(0x17_747a, 1); push(di);                                 /* push di */
            ii(0x17_747b, 1); push(si);                                 /* push si */
            ii(0x17_747c, 1); push(ds);                                 /* push ds */
            ii(0x17_747d, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x17_7480, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x17_7482, 3); mov(ax, memw[ss, bp + 0x6]);              /* mov ax, [bp+0x6] */
            ii(0x17_7485, 1); inc(ax);                                  /* inc ax */
            ii(0x17_7486, 1); cwd();                                    /* cwd */
            ii(0x17_7487, 2); mov(dh, dl);                              /* mov dh, dl */
            ii(0x17_7489, 2); mov(dl, ah);                              /* mov dl, ah */
            ii(0x17_748b, 2); mov(ah, al);                              /* mov ah, al */
            ii(0x17_748d, 2); sub(al, al);                              /* sub al, al */
            ii(0x17_748f, 3); sub(ax, 0x1);                             /* sub ax, 0x1 */
            ii(0x17_7492, 3); sbb(dx, 0);                               /* sbb dx, 0x0 */
            ii(0x17_7495, 3); mov(memw[ss, bp - 0xa], ax);              /* mov [bp-0xa], ax */
            ii(0x17_7498, 3); mov(memw[ss, bp - 0x8], dx);              /* mov [bp-0x8], dx */
            ii(0x17_749b, 1); push(dx);                                 /* push dx */
            ii(0x17_749c, 1); push(ax);                                 /* push ax */
            ii(0x17_749d, 4); call_far_ind(memw[ds, 0x1e9e]);           /* call far word [0x1e9e] */
            ii(0x17_74a1, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x17_74a4, 3); mov(memw[ss, bp - 0x4], ax);              /* mov [bp-0x4], ax */
            ii(0x17_74a7, 3); mov(memw[ss, bp - 0x2], dx);              /* mov [bp-0x2], dx */
            ii(0x17_74aa, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x17_74ac, 2); if(jnz(0x17_74b6, 0x8)) goto l_0x17_74b6; /* jnz 0x74b6 */
            ii(0x17_74ae, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x17_74b0, 1); cwd();                                    /* cwd */
            ii(0x17_74b1, 1); pop(ds);                                  /* pop ds */
            ii(0x17_74b2, 1); pop(si);                                  /* pop si */
            ii(0x17_74b3, 1); pop(di);                                  /* pop di */
            ii(0x17_74b4, 1); leave();                                  /* leave */
            ii(0x17_74b5, 1); retf(); return;                           /* retf */
        l_0x17_74b6:
            ii(0x17_74b6, 3); mov(dx, memw[ss, bp - 0x2]);              /* mov dx, [bp-0x2] */
            ii(0x17_74b9, 3); add(memw[ss, bp - 0xa], ax);              /* add [bp-0xa], ax */
            ii(0x17_74bc, 3); adc(memw[ss, bp - 0x8], dx);              /* adc [bp-0x8], dx */
            ii(0x17_74bf, 2); neg(ax);                                  /* neg ax */
            ii(0x17_74c1, 2); sub(ah, ah);                              /* sub ah, ah */
            ii(0x17_74c3, 3); mov(memw[ss, bp - 0x6], ax);              /* mov [bp-0x6], ax */
            ii(0x17_74c6, 2); sub(dx, dx);                              /* sub dx, dx */
            ii(0x17_74c8, 1); push(dx);                                 /* push dx */
            ii(0x17_74c9, 1); push(ax);                                 /* push ax */
            ii(0x17_74ca, 3); push(memw[ss, bp - 0x2]);                 /* push word [bp-0x2] */
            ii(0x17_74cd, 3); push(memw[ss, bp - 0x4]);                 /* push word [bp-0x4] */
            ii(0x17_74d0, 2); mov(si, ax);                              /* mov si, ax */
            ii(0x17_74d2, 2); mov(di, dx);                              /* mov di, dx */
            ii(0x17_74d4, 4); call_far_ind(memw[ds, 0x1ea2]);           /* call far word [0x1ea2] */
            ii(0x17_74d8, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x17_74db, 3); mov(al, memb[ss, bp - 0xa]);              /* mov al, [bp-0xa] */
            ii(0x17_74de, 2); sub(ah, ah);                              /* sub ah, ah */
            ii(0x17_74e0, 1); push(di);                                 /* push di */
            ii(0x17_74e1, 1); push(ax);                                 /* push ax */
            ii(0x17_74e2, 3); mov(ax, memw[ss, bp - 0xa]);              /* mov ax, [bp-0xa] */
            ii(0x17_74e5, 3); mov(dx, memw[ss, bp - 0x8]);              /* mov dx, [bp-0x8] */
            ii(0x17_74e8, 2); sub(al, al);                              /* sub al, al */
            ii(0x17_74ea, 1); push(dx);                                 /* push dx */
            ii(0x17_74eb, 1); push(ax);                                 /* push ax */
            ii(0x17_74ec, 4); call_far_ind(memw[ds, 0x1ea2]);           /* call far word [0x1ea2] */
            ii(0x17_74f0, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x17_74f3, 3); add(memw[ss, bp - 0x4], si);              /* add [bp-0x4], si */
            ii(0x17_74f6, 3); adc(memw[ss, bp - 0x2], di);              /* adc [bp-0x2], di */
            ii(0x17_74f9, 3); mov(ax, memw[ss, bp - 0x4]);              /* mov ax, [bp-0x4] */
            ii(0x17_74fc, 3); mov(dx, memw[ss, bp - 0x2]);              /* mov dx, [bp-0x2] */
            ii(0x17_74ff, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x17_7501, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x17_7503, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x17_7505, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x17_7507, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x17_7509, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x17_750b, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x17_750d, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x17_750f, 1); pop(ds);                                  /* pop ds */
            ii(0x17_7510, 1); pop(si);                                  /* pop si */
            ii(0x17_7511, 1); pop(di);                                  /* pop di */
            ii(0x17_7512, 1); leave();                                  /* leave */
            ii(0x17_7513, 1); retf();                                   /* retf */
        }
    }
}
