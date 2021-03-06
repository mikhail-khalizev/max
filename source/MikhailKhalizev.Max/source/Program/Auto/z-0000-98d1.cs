using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x98d1-a9872dd2")]
        public void Method_0000_98d1()
        {
            ii(0x98d1, 4);  enter(0x16, 0);                            /* enter 0x16, 0x0 */
            ii(0x98d5, 1);  push(di);                                  /* push di */
            ii(0x98d6, 1);  push(si);                                  /* push si */
            ii(0x98d7, 3);  call(0x773a, -0x21a0);                     /* call 0x773a */
            ii(0x98da, 3);  mov(ax, memw[ss, bp + 4]);                 /* mov ax, [bp+0x4] */
            ii(0x98dd, 2);  sub(dx, dx);                               /* sub dx, dx */
            ii(0x98df, 2);  mov(cx, ax);                               /* mov cx, ax */
            ii(0x98e1, 2);  mov(bx, dx);                               /* mov bx, dx */
            ii(0x98e3, 3);  mov(memw[ss, bp - 6], dx);                 /* mov [bp-0x6], dx */
            ii(0x98e6, 3);  mov(memw[ss, bp - 4], ax);                 /* mov [bp-0x4], ax */
            ii(0x98e9, 3);  sub(ax, 8);                                /* sub ax, 0x8 */
            ii(0x98ec, 3);  mov(memw[ss, bp - 14], dx);                /* mov [bp-0xe], dx */
            ii(0x98ef, 3);  mov(memw[ss, bp - 12], ax);                /* mov [bp-0xc], ax */
            ii(0x98f2, 3);  or(bl, 8);                                 /* or bl, 0x8 */
            ii(0x98f5, 3);  mov(memw[ss, bp - 10], cx);                /* mov [bp-0xa], cx */
            ii(0x98f8, 3);  mov(memw[ss, bp - 8], bx);                 /* mov [bp-0x8], bx */
            ii(0x98fb, 2);  mov(es, bx);                               /* mov es, bx */
            ii(0x98fd, 2);  mov(bx, cx);                               /* mov bx, cx */
            ii(0x98ff, 3);  mov(si, memw[es, bx]);                     /* mov si, [es:bx] */
            ii(0x9902, 1);  inc(si);                                   /* inc si */
            ii(0x9903, 2);  shr(si, 1);                                /* shr si, 1 */
            ii(0x9905, 2);  jmp(0x9972, 0x6b); goto l_0x9972;          /* jmp 0x9972 */
        l_0x9907:
            ii(0x9907, 2);  mov(bx, si);                               /* mov bx, si */
            ii(0x9909, 2);  shl(bx, 1);                                /* shl bx, 1 */
            ii(0x990b, 3);  add(bx, memw[ss, bp - 14]);                /* add bx, [bp-0xe] */
            ii(0x990e, 3);  mov(es, memw[ss, bp - 12]);                /* mov es, [bp-0xc] */
            ii(0x9911, 3);  mov(di, memw[es, bx]);                     /* mov di, [es:bx] */
            ii(0x9914, 4);  cmp(di, 0x80);                             /* cmp di, 0x80 */
            ii(0x9918, 2);  if(jb(0x9972, 0x58)) goto l_0x9972;        /* jb 0x9972 */
            ii(0x991a, 3);  add(di, memw[ss, bp + 6]);                 /* add di, [bp+0x6] */
            ii(0x991d, 2);  mov(bx, si);                               /* mov bx, si */
            ii(0x991f, 2);  shl(bx, 1);                                /* shl bx, 1 */
            ii(0x9921, 2);  mov(ax, bx);                               /* mov ax, bx */
            ii(0x9923, 3);  add(bx, memw[ss, bp - 14]);                /* add bx, [bp-0xe] */
            ii(0x9926, 3);  mov(memw[es, bx], di);                     /* mov [es:bx], di */
            ii(0x9929, 2);  mov(cx, di);                               /* mov cx, di */
            ii(0x992b, 2);  sub(dx, dx);                               /* sub dx, dx */
            ii(0x992d, 3);  mov(memw[ss, bp - 22], cx);                /* mov [bp-0x16], cx */
            ii(0x9930, 3);  or(dl, 8);                                 /* or dl, 0x8 */
            ii(0x9933, 3);  mov(memw[ss, bp - 10], cx);                /* mov [bp-0xa], cx */
            ii(0x9936, 3);  mov(memw[ss, bp - 8], dx);                 /* mov [bp-0x8], dx */
            ii(0x9939, 2);  mov(es, dx);                               /* mov es, dx */
            ii(0x993b, 2);  mov(bx, di);                               /* mov bx, di */
            ii(0x993d, 4);  mov(cl, memb[es, bx + 5]);                 /* mov cl, [es:bx+0x5] */
            ii(0x9941, 3);  mov(memb[ss, bp - 2], cl);                 /* mov [bp-0x2], cl */
            ii(0x9944, 5);  mov(memb[es, bx + 5], 0x92);               /* mov byte [es:bx+0x5], 0x92 */
            ii(0x9949, 2);  mov(bx, ax);                               /* mov bx, ax */
            ii(0x994b, 3);  add(bx, memw[ss, bp - 6]);                 /* add bx, [bp-0x6] */
            ii(0x994e, 3);  mov(es, memw[ss, bp - 4]);                 /* mov es, [bp-0x4] */
            ii(0x9951, 3);  mov(ax, memw[ss, bp - 22]);                /* mov ax, [bp-0x16] */
            ii(0x9954, 3);  mov(cx, memw[es, bx]);                     /* mov cx, [es:bx] */
            ii(0x9957, 2);  mov(es, ax);                               /* mov es, ax */
            ii(0x9959, 2);  mov(bx, cx);                               /* mov bx, cx */
            ii(0x995b, 5);  cmp(memw[es, bx], 0x80);                   /* cmp word [es:bx], 0x80 */
            ii(0x9960, 2);  if(jb(0x9968, 6)) goto l_0x9968;           /* jb 0x9968 */
            ii(0x9962, 3);  mov(dx, memw[ss, bp + 6]);                 /* mov dx, [bp+0x6] */
            ii(0x9965, 3);  add(memw[es, bx], dx);                     /* add [es:bx], dx */
        l_0x9968:
            ii(0x9968, 3);  mov(al, memb[ss, bp - 2]);                 /* mov al, [bp-0x2] */
            ii(0x996b, 3);  les(bx, memw[ss, bp - 10]);                /* les bx, [bp-0xa] */
            ii(0x996e, 4);  mov(memb[es, bx + 5], al);                 /* mov [es:bx+0x5], al */
        l_0x9972:
            ii(0x9972, 1);  dec(si);                                   /* dec si */
            ii(0x9973, 2);  if(jns(0x9907, -0x6e)) goto l_0x9907;      /* jns 0x9907 */
            ii(0x9975, 3);  call(0x6f71, -0x2a07);                     /* call 0x6f71 */
            ii(0x9978, 1);  pop(si);                                   /* pop si */
            ii(0x9979, 1);  pop(di);                                   /* pop di */
            ii(0x997a, 1);  leave();                                   /* leave */
            ii(0x997b, 1);  ret();                                     /* ret */
        }
    }
}
