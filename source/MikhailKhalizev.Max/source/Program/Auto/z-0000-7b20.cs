using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x7b20-c8cb18ae")]
        public void Method_0000_7b20()
        {
            ii(0x7b20, 4);  enter(0x10, 0);                            /* enter 0x10, 0x0 */
            ii(0x7b24, 1);  push(di);                                  /* push di */
            ii(0x7b25, 1);  push(si);                                  /* push si */
            ii(0x7b26, 5);  mov(memw[ss, bp - 8], 0);                  /* mov word [bp-0x8], 0x0 */
            ii(0x7b2b, 5);  mov(memw[ss, bp - 6], 8);                  /* mov word [bp-0x6], 0x8 */
        l_0x7b30:
            ii(0x7b30, 3);  mov(ax, memw[ss, bp + 4]);                 /* mov ax, [bp+0x4] */
            ii(0x7b33, 5);  mov(memw[ss, bp - 4], 0);                  /* mov word [bp-0x4], 0x0 */
            ii(0x7b38, 3);  mov(memw[ss, bp - 2], ax);                 /* mov [bp-0x2], ax */
        l_0x7b3b:
            ii(0x7b3b, 3);  les(bx, memw[ss, bp - 4]);                 /* les bx, [bp-0x4] */
            ii(0x7b3e, 3);  mov(ax, memw[es, bx]);                     /* mov ax, [es:bx] */
            ii(0x7b41, 3);  mov(memw[ss, bp - 16], ax);                /* mov [bp-0x10], ax */
            ii(0x7b44, 3);  mov(ax, memw[ss, bp + 8]);                 /* mov ax, [bp+0x8] */
            ii(0x7b47, 3);  add(memw[es, bx], ax);                     /* add [es:bx], ax */
            ii(0x7b4a, 3);  mov(cx, memw[ss, bp - 16]);                /* mov cx, [bp-0x10] */
            ii(0x7b4d, 3);  and(cl, 0xf8);                             /* and cl, 0xf8 */
            ii(0x7b50, 2);  add(ax, cx);                               /* add ax, cx */
            ii(0x7b52, 2);  mov(si, ax);                               /* mov si, ax */
            ii(0x7b54, 3);  mov(memw[ss, bp - 8], ax);                 /* mov [bp-0x8], ax */
            ii(0x7b57, 3);  les(bx, memw[ss, bp - 8]);                 /* les bx, [bp-0x8] */
            ii(0x7b5a, 4);  mov(al, memb[es, bx + 5]);                 /* mov al, [es:bx+0x5] */
            ii(0x7b5e, 2);  sub(ah, ah);                               /* sub ah, ah */
            ii(0x7b60, 3);  mov(memw[ss, bp - 14], ax);                /* mov [bp-0xe], ax */
            ii(0x7b63, 5);  mov(memb[es, bx + 5], 0x92);               /* mov byte [es:bx+0x5], 0x92 */
            ii(0x7b68, 4);  add(memw[ss, bp - 4], 2);                  /* add word [bp-0x4], 0x2 */
            ii(0x7b6c, 3);  les(bx, memw[ss, bp - 4]);                 /* les bx, [bp-0x4] */
            ii(0x7b6f, 3);  mov(di, memw[es, bx]);                     /* mov di, [es:bx] */
            ii(0x7b72, 3);  lea(ax, memw[ds, bx + 2]);                 /* lea ax, [bx+0x2] */
            ii(0x7b75, 3);  mov(memw[ss, bp - 4], ax);                 /* mov [bp-0x4], ax */
            ii(0x7b78, 2);  jmp(0x7b95, 0x1b); goto l_0x7b95;          /* jmp 0x7b95 */
        l_0x7b7a:
            ii(0x7b7a, 3);  les(bx, memw[ss, bp - 4]);                 /* les bx, [bp-0x4] */
            ii(0x7b7d, 4);  add(memw[ss, bp - 4], 2);                  /* add word [bp-0x4], 0x2 */
            ii(0x7b81, 3);  mov(bx, memw[es, bx]);                     /* mov bx, [es:bx] */
            ii(0x7b84, 2);  mov(cx, si);                               /* mov cx, si */
            ii(0x7b86, 2);  mov(es, cx);                               /* mov es, cx */
            ii(0x7b88, 5);  cmp(memw[es, bx], 0x80);                   /* cmp word [es:bx], 0x80 */
            ii(0x7b8d, 2);  if(jb(0x7b95, 6)) goto l_0x7b95;           /* jb 0x7b95 */
            ii(0x7b8f, 3);  mov(ax, memw[ss, bp + 8]);                 /* mov ax, [bp+0x8] */
            ii(0x7b92, 3);  add(memw[es, bx], ax);                     /* add [es:bx], ax */
        l_0x7b95:
            ii(0x7b95, 1);  dec(di);                                   /* dec di */
            ii(0x7b96, 2);  if(jns(0x7b7a, -0x1e)) goto l_0x7b7a;      /* jns 0x7b7a */
            ii(0x7b98, 3);  mov(al, memb[ss, bp - 14]);                /* mov al, [bp-0xe] */
            ii(0x7b9b, 3);  les(bx, memw[ss, bp - 8]);                 /* les bx, [bp-0x8] */
            ii(0x7b9e, 4);  mov(memb[es, bx + 5], al);                 /* mov [es:bx+0x5], al */
            ii(0x7ba2, 4);  test(memb[ss, bp - 16], 3);                /* test byte [bp-0x10], 0x3 */
            ii(0x7ba6, 2);  if(jz(0x7b3b, -0x6d)) goto l_0x7b3b;       /* jz 0x7b3b */
            ii(0x7ba8, 4);  add(memw[ss, bp + 4], 8);                  /* add word [bp+0x4], 0x8 */
            ii(0x7bac, 4);  test(memb[ss, bp - 16], 2);                /* test byte [bp-0x10], 0x2 */
            ii(0x7bb0, 2);  if(jnz(0x7bb5, 3)) goto l_0x7bb5;          /* jnz 0x7bb5 */
            ii(0x7bb2, 3);  jmp(0x7b30, -0x85); goto l_0x7b30;         /* jmp 0x7b30 */
        l_0x7bb5:
            ii(0x7bb5, 1);  pop(si);                                   /* pop si */
            ii(0x7bb6, 1);  pop(di);                                   /* pop di */
            ii(0x7bb7, 1);  leave();                                   /* leave */
            ii(0x7bb8, 1);  ret();                                     /* ret */
        }
    }
}
