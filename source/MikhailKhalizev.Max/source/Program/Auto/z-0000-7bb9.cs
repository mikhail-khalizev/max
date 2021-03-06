using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x7bb9-106a02d9")]
        public void Method_0000_7bb9()
        {
            ii(0x7bb9, 4);  enter(0x14, 0);                            /* enter 0x14, 0x0 */
            ii(0x7bbd, 1);  push(di);                                  /* push di */
            ii(0x7bbe, 1);  push(si);                                  /* push si */
            ii(0x7bbf, 5);  mov(memw[ss, bp - 8], 0);                  /* mov word [bp-0x8], 0x0 */
            ii(0x7bc4, 5);  mov(memw[ss, bp - 6], 8);                  /* mov word [bp-0x6], 0x8 */
        l_0x7bc9:
            ii(0x7bc9, 3);  mov(ax, memw[ss, bp + 4]);                 /* mov ax, [bp+0x4] */
            ii(0x7bcc, 5);  mov(memw[ss, bp - 4], 0);                  /* mov word [bp-0x4], 0x0 */
            ii(0x7bd1, 3);  mov(memw[ss, bp - 2], ax);                 /* mov [bp-0x2], ax */
        l_0x7bd4:
            ii(0x7bd4, 3);  les(bx, memw[ss, bp - 4]);                 /* les bx, [bp-0x4] */
            ii(0x7bd7, 3);  mov(si, memw[es, bx]);                     /* mov si, [es:bx] */
            ii(0x7bda, 3);  mov(memw[ss, bp - 16], si);                /* mov [bp-0x10], si */
            ii(0x7bdd, 3);  and(si, -8 /* 0xf8 */);                    /* and si, 0xfff8 */
            ii(0x7be0, 3);  cmp(si, memw[ss, bp + 8]);                 /* cmp si, [bp+0x8] */
            ii(0x7be3, 2);  if(jnz(0x7bf4, 0xf)) goto l_0x7bf4;        /* jnz 0x7bf4 */
            ii(0x7be5, 3);  mov(al, memb[ss, bp - 16]);                /* mov al, [bp-0x10] */
            ii(0x7be8, 3);  xor(al, memb[ss, bp + 10]);                /* xor al, [bp+0xa] */
            ii(0x7beb, 3);  and(ax, 7);                                /* and ax, 0x7 */
            ii(0x7bee, 3);  xor(ax, memw[ss, bp + 10]);                /* xor ax, [bp+0xa] */
            ii(0x7bf1, 3);  mov(memw[es, bx], ax);                     /* mov [es:bx], ax */
        l_0x7bf4:
            ii(0x7bf4, 3);  mov(memw[ss, bp - 8], si);                 /* mov [bp-0x8], si */
            ii(0x7bf7, 3);  mov(memw[ss, bp - 10], si);                /* mov [bp-0xa], si */
            ii(0x7bfa, 3);  les(bx, memw[ss, bp - 8]);                 /* les bx, [bp-0x8] */
            ii(0x7bfd, 4);  mov(al, memb[es, bx + 5]);                 /* mov al, [es:bx+0x5] */
            ii(0x7c01, 2);  sub(ah, ah);                               /* sub ah, ah */
            ii(0x7c03, 3);  mov(memw[ss, bp - 14], ax);                /* mov [bp-0xe], ax */
            ii(0x7c06, 5);  mov(memb[es, bx + 5], 0x92);               /* mov byte [es:bx+0x5], 0x92 */
            ii(0x7c0b, 4);  add(memw[ss, bp - 4], 2);                  /* add word [bp-0x4], 0x2 */
            ii(0x7c0f, 3);  les(bx, memw[ss, bp - 4]);                 /* les bx, [bp-0x4] */
            ii(0x7c12, 3);  mov(di, memw[es, bx]);                     /* mov di, [es:bx] */
            ii(0x7c15, 3);  lea(ax, memw[ds, bx + 2]);                 /* lea ax, [bx+0x2] */
            ii(0x7c18, 3);  mov(memw[ss, bp - 4], ax);                 /* mov [bp-0x4], ax */
            ii(0x7c1b, 2);  jmp(0x7c3c, 0x1f); goto l_0x7c3c;          /* jmp 0x7c3c */
        l_0x7c1d:
            ii(0x7c1d, 3);  les(bx, memw[ss, bp - 4]);                 /* les bx, [bp-0x4] */
            ii(0x7c20, 4);  add(memw[ss, bp - 4], 2);                  /* add word [bp-0x4], 0x2 */
            ii(0x7c24, 3);  mov(ax, memw[es, bx]);                     /* mov ax, [es:bx] */
            ii(0x7c27, 3);  mov(dx, memw[ss, bp - 10]);                /* mov dx, [bp-0xa] */
            ii(0x7c2a, 2);  mov(es, dx);                               /* mov es, dx */
            ii(0x7c2c, 2);  mov(bx, ax);                               /* mov bx, ax */
            ii(0x7c2e, 3);  mov(cx, memw[ss, bp + 8]);                 /* mov cx, [bp+0x8] */
            ii(0x7c31, 3);  cmp(memw[es, bx], cx);                     /* cmp [es:bx], cx */
            ii(0x7c34, 2);  if(jnz(0x7c3c, 6)) goto l_0x7c3c;          /* jnz 0x7c3c */
            ii(0x7c36, 3);  mov(cx, memw[ss, bp + 10]);                /* mov cx, [bp+0xa] */
            ii(0x7c39, 3);  mov(memw[es, bx], cx);                     /* mov [es:bx], cx */
        l_0x7c3c:
            ii(0x7c3c, 1);  dec(di);                                   /* dec di */
            ii(0x7c3d, 2);  if(jns(0x7c1d, -0x22)) goto l_0x7c1d;      /* jns 0x7c1d */
            ii(0x7c3f, 3);  mov(al, memb[ss, bp - 14]);                /* mov al, [bp-0xe] */
            ii(0x7c42, 3);  les(bx, memw[ss, bp - 8]);                 /* les bx, [bp-0x8] */
            ii(0x7c45, 4);  mov(memb[es, bx + 5], al);                 /* mov [es:bx+0x5], al */
            ii(0x7c49, 4);  test(memb[ss, bp - 16], 3);                /* test byte [bp-0x10], 0x3 */
            ii(0x7c4d, 2);  if(jz(0x7bd4, -0x7b)) goto l_0x7bd4;       /* jz 0x7bd4 */
            ii(0x7c4f, 4);  add(memw[ss, bp + 4], 8);                  /* add word [bp+0x4], 0x8 */
            ii(0x7c53, 4);  test(memb[ss, bp - 16], 2);                /* test byte [bp-0x10], 0x2 */
            ii(0x7c57, 2);  if(jnz(0x7c5c, 3)) goto l_0x7c5c;          /* jnz 0x7c5c */
            ii(0x7c59, 3);  jmp(0x7bc9, -0x93); goto l_0x7bc9;         /* jmp 0x7bc9 */
        l_0x7c5c:
            ii(0x7c5c, 3);  mov(ax, memw[ss, bp + 8]);                 /* mov ax, [bp+0x8] */
            ii(0x7c5f, 3);  mov(memw[ss, bp - 8], ax);                 /* mov [bp-0x8], ax */
            ii(0x7c62, 3);  les(bx, memw[ss, bp - 8]);                 /* les bx, [bp-0x8] */
            ii(0x7c65, 5);  mov(memb[es, bx + 5], 0x80);               /* mov byte [es:bx+0x5], 0x80 */
            ii(0x7c6a, 3);  mov(ax, memw[ss, bp + 10]);                /* mov ax, [bp+0xa] */
            ii(0x7c6d, 3);  les(bx, memw[ss, bp - 8]);                 /* les bx, [bp-0x8] */
            ii(0x7c70, 4);  mov(memw[es, bx + 6], ax);                 /* mov [es:bx+0x6], ax */
            ii(0x7c74, 1);  pop(si);                                   /* pop si */
            ii(0x7c75, 1);  pop(di);                                   /* pop di */
            ii(0x7c76, 1);  leave();                                   /* leave */
            ii(0x7c77, 1);  ret();                                     /* ret */
        }
    }
}
