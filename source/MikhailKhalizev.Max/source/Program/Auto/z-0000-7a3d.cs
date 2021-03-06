using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x7a3d-2f438374")]
        public void Method_0000_7a3d()
        {
            ii(0x7a3d, 4);  enter(0x12, 0);                            /* enter 0x12, 0x0 */
            ii(0x7a41, 1);  push(di);                                  /* push di */
            ii(0x7a42, 1);  push(si);                                  /* push si */
            ii(0x7a43, 3);  call(0x572a, -0x231c);                     /* call 0x572a */
            ii(0x7a46, 3);  mov(ax, memw[ss, bp + 4]);                 /* mov ax, [bp+0x4] */
            ii(0x7a49, 2);  sub(dx, dx);                               /* sub dx, dx */
            ii(0x7a4b, 2);  mov(cx, ax);                               /* mov cx, ax */
            ii(0x7a4d, 2);  mov(bx, dx);                               /* mov bx, dx */
            ii(0x7a4f, 3);  mov(memw[ss, bp - 6], dx);                 /* mov [bp-0x6], dx */
            ii(0x7a52, 3);  mov(memw[ss, bp - 4], ax);                 /* mov [bp-0x4], ax */
            ii(0x7a55, 3);  sub(ax, 8);                                /* sub ax, 0x8 */
            ii(0x7a58, 3);  mov(memw[ss, bp - 14], dx);                /* mov [bp-0xe], dx */
            ii(0x7a5b, 3);  mov(memw[ss, bp - 12], ax);                /* mov [bp-0xc], ax */
            ii(0x7a5e, 3);  or(bl, 8);                                 /* or bl, 0x8 */
            ii(0x7a61, 2);  mov(es, bx);                               /* mov es, bx */
            ii(0x7a63, 2);  mov(bx, cx);                               /* mov bx, cx */
            ii(0x7a65, 3);  mov(si, memw[es, bx]);                     /* mov si, [es:bx] */
            ii(0x7a68, 1);  inc(si);                                   /* inc si */
            ii(0x7a69, 2);  shr(si, 1);                                /* shr si, 1 */
            ii(0x7a6b, 2);  jmp(0x7ae0, 0x73); goto l_0x7ae0;          /* jmp 0x7ae0 */
        l_0x7a6d:
            ii(0x7a6d, 2);  mov(bx, si);                               /* mov bx, si */
            ii(0x7a6f, 2);  shl(bx, 1);                                /* shl bx, 1 */
            ii(0x7a71, 3);  add(bx, memw[ss, bp - 14]);                /* add bx, [bp-0xe] */
            ii(0x7a74, 3);  mov(es, memw[ss, bp - 12]);                /* mov es, [bp-0xc] */
            ii(0x7a77, 3);  mov(di, memw[es, bx]);                     /* mov di, [es:bx] */
            ii(0x7a7a, 4);  cmp(di, 0x80);                             /* cmp di, 0x80 */
            ii(0x7a7e, 2);  if(jb(0x7ae0, 0x60)) goto l_0x7ae0;        /* jb 0x7ae0 */
            ii(0x7a80, 3);  cmp(memw[ss, bp + 6], di);                 /* cmp [bp+0x6], di */
            ii(0x7a83, 2);  if(jnz(0x7a92, 0xd)) goto l_0x7a92;        /* jnz 0x7a92 */
            ii(0x7a85, 3);  mov(ax, memw[ss, bp + 8]);                 /* mov ax, [bp+0x8] */
            ii(0x7a88, 2);  mov(bx, si);                               /* mov bx, si */
            ii(0x7a8a, 2);  shl(bx, 1);                                /* shl bx, 1 */
            ii(0x7a8c, 3);  add(bx, memw[ss, bp - 14]);                /* add bx, [bp-0xe] */
            ii(0x7a8f, 3);  mov(memw[es, bx], ax);                     /* mov [es:bx], ax */
        l_0x7a92:
            ii(0x7a92, 3);  mov(ax, memw[ss, bp + 6]);                 /* mov ax, [bp+0x6] */
            ii(0x7a95, 2);  mov(bx, si);                               /* mov bx, si */
            ii(0x7a97, 2);  shl(bx, 1);                                /* shl bx, 1 */
            ii(0x7a99, 3);  add(bx, memw[ss, bp - 6]);                 /* add bx, [bp-0x6] */
            ii(0x7a9c, 3);  mov(es, memw[ss, bp - 4]);                 /* mov es, [bp-0x4] */
            ii(0x7a9f, 3);  mov(bx, memw[es, bx]);                     /* mov bx, [es:bx] */
            ii(0x7aa2, 2);  mov(cx, di);                               /* mov cx, di */
            ii(0x7aa4, 2);  mov(es, cx);                               /* mov es, cx */
            ii(0x7aa6, 3);  mov(memw[ss, bp - 18], bx);                /* mov [bp-0x12], bx */
            ii(0x7aa9, 3);  mov(memw[ss, bp - 16], es);                /* mov [bp-0x10], es */
            ii(0x7aac, 3);  cmp(memw[es, bx], ax);                     /* cmp [es:bx], ax */
            ii(0x7aaf, 2);  if(jnz(0x7ae0, 0x2f)) goto l_0x7ae0;       /* jnz 0x7ae0 */
            ii(0x7ab1, 2);  mov(ax, di);                               /* mov ax, di */
            ii(0x7ab3, 2);  and(al, 0xf8);                             /* and al, 0xf8 */
            ii(0x7ab5, 2);  mov(bx, ax);                               /* mov bx, ax */
            ii(0x7ab7, 3);  mov(cx, 8);                                /* mov cx, 0x8 */
            ii(0x7aba, 2);  mov(es, cx);                               /* mov es, cx */
            ii(0x7abc, 4);  mov(al, memb[es, bx + 5]);                 /* mov al, [es:bx+0x5] */
            ii(0x7ac0, 3);  mov(memb[ss, bp - 2], al);                 /* mov [bp-0x2], al */
            ii(0x7ac3, 5);  mov(memb[es, bx + 5], 0xf2);               /* mov byte [es:bx+0x5], 0xf2 */
            ii(0x7ac8, 3);  mov(ax, memw[ss, bp + 8]);                 /* mov ax, [bp+0x8] */
            ii(0x7acb, 2);  mov(cx, bx);                               /* mov cx, bx */
            ii(0x7acd, 2);  mov(dx, es);                               /* mov dx, es */
            ii(0x7acf, 3);  les(bx, memw[ss, bp - 18]);                /* les bx, [bp-0x12] */
            ii(0x7ad2, 3);  mov(memw[es, bx], ax);                     /* mov [es:bx], ax */
            ii(0x7ad5, 3);  mov(al, memb[ss, bp - 2]);                 /* mov al, [bp-0x2] */
            ii(0x7ad8, 2);  mov(es, dx);                               /* mov es, dx */
            ii(0x7ada, 2);  mov(bx, cx);                               /* mov bx, cx */
            ii(0x7adc, 4);  mov(memb[es, bx + 5], al);                 /* mov [es:bx+0x5], al */
        l_0x7ae0:
            ii(0x7ae0, 1);  dec(si);                                   /* dec si */
            ii(0x7ae1, 2);  if(jns(0x7a6d, -0x76)) goto l_0x7a6d;      /* jns 0x7a6d */
            ii(0x7ae3, 3);  mov(ax, memw[ss, bp + 6]);                 /* mov ax, [bp+0x6] */
            ii(0x7ae6, 2);  and(al, 0xf8);                             /* and al, 0xf8 */
            ii(0x7ae8, 2);  mov(bx, ax);                               /* mov bx, ax */
            ii(0x7aea, 3);  mov(cx, 8);                                /* mov cx, 0x8 */
            ii(0x7aed, 2);  mov(es, cx);                               /* mov es, cx */
            ii(0x7aef, 5);  mov(memb[es, bx + 5], 0x80);               /* mov byte [es:bx+0x5], 0x80 */
            ii(0x7af4, 3);  mov(ax, memw[ss, bp + 8]);                 /* mov ax, [bp+0x8] */
            ii(0x7af7, 4);  mov(memw[es, bx + 6], ax);                 /* mov [es:bx+0x6], ax */
            ii(0x7afb, 3);  call(0x4f61, -0x2b9d);                     /* call 0x4f61 */
            ii(0x7afe, 1);  pop(si);                                   /* pop si */
            ii(0x7aff, 1);  pop(di);                                   /* pop di */
            ii(0x7b00, 1);  leave();                                   /* leave */
            ii(0x7b01, 1);  ret();                                     /* ret */
        }
    }
}
