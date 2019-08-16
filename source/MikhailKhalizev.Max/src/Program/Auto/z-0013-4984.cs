using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a6b4ab60-d279-4a86-b4c2-d0ff4da79642")]
        public void Method_0013_4984()
        {
            ii(0x13_4984, 4); enterw(0xc, 0);                           /* enter 0xc, 0x0 */
            ii(0x13_4988, 1); pushw(si);                                /* push si */
            ii(0x13_4989, 1); pushw(ds);                                /* push ds */
            ii(0x13_498a, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x13_498d, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x13_498f, 5); mov(memw_a16[ss, bp - 0xa], 0x8);         /* mov word [bp-0xa], 0x8 */
            ii(0x13_4994, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x13_4997, 3); mov(memw_a16[ss, bp - 0xc], ax);          /* mov [bp-0xc], ax */
            ii(0x13_499a, 3); les(bx, ss, bp - 0xc);                    /* les bx, [bp-0xc] */
            ii(0x13_499d, 4); mov(al, memb_a16[es, bx + 0x6]);          /* mov al, [es:bx+0x6] */
            ii(0x13_49a1, 2); sub(ah, ah);                              /* sub ah, ah */
            ii(0x13_49a3, 2); sub(dx, dx);                              /* sub dx, dx */
            ii(0x13_49a5, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x13_49a8, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x13_49ab, 2); mov(cx, ax);                              /* mov cx, ax */
            ii(0x13_49ad, 2); mov(si, dx);                              /* mov si, dx */
            ii(0x13_49af, 2); test(al, 0x80);                           /* test al, 0x80 */
            ii(0x13_49b1, 2); if(jzw(0x13_49dc, 0x29)) goto l_0x13_49dc; /* jz 0x49dc */
            ii(0x13_49b3, 2); mov(dx, ax);                              /* mov dx, ax */
            ii(0x13_49b5, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x13_49b7, 3); add(ax, memw_a16[es, bx]);                /* add ax, [es:bx] */
            ii(0x13_49ba, 2); adc(dx, si);                              /* adc dx, si */
            ii(0x13_49bc, 2); mov(dh, dl);                              /* mov dh, dl */
            ii(0x13_49be, 2); mov(dl, ah);                              /* mov dl, ah */
            ii(0x13_49c0, 2); mov(ah, al);                              /* mov ah, al */
            ii(0x13_49c2, 2); sub(al, al);                              /* sub al, al */
            ii(0x13_49c4, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_49c6, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_49c8, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_49ca, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_49cc, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_49ce, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_49d0, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_49d2, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_49d4, 3); mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0x13_49d7, 3); mov(memw_a16[ss, bp - 0x6], dx);          /* mov [bp-0x6], dx */
            ii(0x13_49da, 2); jmpw(0x13_49eb, 0xf); goto l_0x13_49eb;   /* jmp 0x49eb */
        l_0x13_49dc:
            ii(0x13_49dc, 3); mov(al, memb_a16[ss, bp - 0x4]);          /* mov al, [bp-0x4] */
            ii(0x13_49df, 3); and(ax, 0xf);                             /* and ax, 0xf */
            ii(0x13_49e2, 3); mov(cx, memw_a16[es, bx]);                /* mov cx, [es:bx] */
            ii(0x13_49e5, 3); mov(memw_a16[ss, bp - 0x8], cx);          /* mov [bp-0x8], cx */
            ii(0x13_49e8, 3); mov(memw_a16[ss, bp - 0x6], ax);          /* mov [bp-0x6], ax */
        l_0x13_49eb:
            ii(0x13_49eb, 5); test(memw_a16[ss, bp - 0x6], 0xffff);     /* test word [bp-0x6], 0xffff */
            ii(0x13_49f0, 2); if(jzw(0x13_49fe, 0xc)) goto l_0x13_49fe; /* jz 0x49fe */
            ii(0x13_49f2, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x13_49f5, 1); popw(ds);                                 /* pop ds */
            ii(0x13_49f6, 1); popw(si);                                 /* pop si */
            ii(0x13_49f7, 1); leavew();                                 /* leave */
            ii(0x13_49f8, 1); retfw(); return;                          /* retf */
        //    ii(0x13_49f9, 1); popw(ds);                                 /* pop ds */
        //    ii(0x13_49fa, 1); popw(si);                                 /* pop si */
        //    ii(0x13_49fb, 1); leavew();                                 /* leave */
        //    ii(0x13_49fc, 1); retfw(); return;                          /* retf */
        //    ii(0x13_49fd, 1); nop();                                    /* nop */
        l_0x13_49fe:
            ii(0x13_49fe, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x13_4a00, 1); popw(ds);                                 /* pop ds */
            ii(0x13_4a01, 1); popw(si);                                 /* pop si */
            ii(0x13_4a02, 1); leavew();                                 /* leave */
            ii(0x13_4a03, 1); retfw(); return;                          /* retf */
        }
    }
}
