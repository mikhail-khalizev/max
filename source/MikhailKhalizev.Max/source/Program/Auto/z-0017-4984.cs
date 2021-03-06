using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_4984-d55a9205")]
        public void Method_0017_4984()
        {
            ii(0x17_4984, 4);  enter(0xc, 0);                          /* enter 0xc, 0x0 */
            ii(0x17_4988, 1);  push(si);                               /* push si */
            ii(0x17_4989, 1);  push(ds);                               /* push ds */
            ii(0x17_498a, 3);  mov(ax, 0x3e68);                        /* mov ax, 0x3e68 */
            ii(0x17_498d, 2);  mov(ds, ax);                            /* mov ds, ax */
            ii(0x17_498f, 5);  mov(memw[ss, bp - 10], 8);              /* mov word [bp-0xa], 0x8 */
            ii(0x17_4994, 3);  mov(ax, memw[ss, bp + 6]);              /* mov ax, [bp+0x6] */
            ii(0x17_4997, 3);  mov(memw[ss, bp - 12], ax);             /* mov [bp-0xc], ax */
            ii(0x17_499a, 3);  les(bx, memw[ss, bp - 12]);             /* les bx, [bp-0xc] */
            ii(0x17_499d, 4);  mov(al, memb[es, bx + 6]);              /* mov al, [es:bx+0x6] */
            ii(0x17_49a1, 2);  sub(ah, ah);                            /* sub ah, ah */
            ii(0x17_49a3, 2);  sub(dx, dx);                            /* sub dx, dx */
            ii(0x17_49a5, 3);  mov(memw[ss, bp - 4], ax);              /* mov [bp-0x4], ax */
            ii(0x17_49a8, 3);  mov(memw[ss, bp - 2], dx);              /* mov [bp-0x2], dx */
            ii(0x17_49ab, 2);  mov(cx, ax);                            /* mov cx, ax */
            ii(0x17_49ad, 2);  mov(si, dx);                            /* mov si, dx */
            ii(0x17_49af, 2);  test(al, 0x80);                         /* test al, 0x80 */
            ii(0x17_49b1, 2);  if(jz(0x17_49dc, 0x29)) goto l_0x17_49dc;/* jz 0x49dc */
            ii(0x17_49b3, 2);  mov(dx, ax);                            /* mov dx, ax */
            ii(0x17_49b5, 2);  sub(ax, ax);                            /* sub ax, ax */
            ii(0x17_49b7, 3);  add(ax, memw[es, bx]);                  /* add ax, [es:bx] */
            ii(0x17_49ba, 2);  adc(dx, si);                            /* adc dx, si */
            ii(0x17_49bc, 2);  mov(dh, dl);                            /* mov dh, dl */
            ii(0x17_49be, 2);  mov(dl, ah);                            /* mov dl, ah */
            ii(0x17_49c0, 2);  mov(ah, al);                            /* mov ah, al */
            ii(0x17_49c2, 2);  sub(al, al);                            /* sub al, al */
            ii(0x17_49c4, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x17_49c6, 2);  rcl(dx, 1);                             /* rcl dx, 1 */
            ii(0x17_49c8, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x17_49ca, 2);  rcl(dx, 1);                             /* rcl dx, 1 */
            ii(0x17_49cc, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x17_49ce, 2);  rcl(dx, 1);                             /* rcl dx, 1 */
            ii(0x17_49d0, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x17_49d2, 2);  rcl(dx, 1);                             /* rcl dx, 1 */
            ii(0x17_49d4, 3);  mov(memw[ss, bp - 8], ax);              /* mov [bp-0x8], ax */
            ii(0x17_49d7, 3);  mov(memw[ss, bp - 6], dx);              /* mov [bp-0x6], dx */
            ii(0x17_49da, 2);  jmp(0x17_49eb, 0xf); goto l_0x17_49eb;  /* jmp 0x49eb */
        l_0x17_49dc:
            ii(0x17_49dc, 3);  mov(al, memb[ss, bp - 4]);              /* mov al, [bp-0x4] */
            ii(0x17_49df, 3);  and(ax, 0xf);                           /* and ax, 0xf */
            ii(0x17_49e2, 3);  mov(cx, memw[es, bx]);                  /* mov cx, [es:bx] */
            ii(0x17_49e5, 3);  mov(memw[ss, bp - 8], cx);              /* mov [bp-0x8], cx */
            ii(0x17_49e8, 3);  mov(memw[ss, bp - 6], ax);              /* mov [bp-0x6], ax */
        l_0x17_49eb:
            ii(0x17_49eb, 5);  test(memw[ss, bp - 6], 0xffff);         /* test word [bp-0x6], 0xffff */
            ii(0x17_49f0, 2);  if(jz(0x17_49fe, 0xc)) goto l_0x17_49fe;/* jz 0x49fe */
            ii(0x17_49f2, 3);  mov(ax, 1);                             /* mov ax, 0x1 */
            ii(0x17_49f5, 1);  pop(ds);                                /* pop ds */
            ii(0x17_49f6, 1);  pop(si);                                /* pop si */
            ii(0x17_49f7, 1);  leave();                                /* leave */
            ii(0x17_49f8, 1);  retf(); return;                         /* retf */
        //  ii(0x17_49f9, 5);  Недостижимый код.
        l_0x17_49fe:
            ii(0x17_49fe, 2);  sub(ax, ax);                            /* sub ax, ax */
            ii(0x17_4a00, 1);  pop(ds);                                /* pop ds */
            ii(0x17_4a01, 1);  pop(si);                                /* pop si */
            ii(0x17_4a02, 1);  leave();                                /* leave */
            ii(0x17_4a03, 1);  retf();                                 /* retf */
        }
    }
}
