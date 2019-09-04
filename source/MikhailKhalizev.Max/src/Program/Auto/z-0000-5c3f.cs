using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x5c3f-fabebabb")]
        public void Method_0000_5c3f()
        {
            ii(0x5c3f, 2);  mov(bx, sp);                               /* mov bx, sp */
            ii(0x5c41, 1);  push(di);                                  /* push di */
            ii(0x5c42, 1);  push(si);                                  /* push si */
            ii(0x5c43, 4);  mov(di, memw[ss, bx + 4]);                 /* mov di, [ss:bx+0x4] */
            ii(0x5c47, 5);  cmp(memw[ds, 0xa12], 0);                   /* cmp word [0xa12], 0x0 */
            ii(0x5c4c, 2);  if(jnz(0x5caa, 0x5c)) goto l_0x5caa;       /* jnz 0x5caa */
            ii(0x5c4e, 3);  call(0x5cc4, 0x73);                        /* call 0x5cc4 */
            ii(0x5c51, 2);  shr(ax, 1);                                /* shr ax, 1 */
            ii(0x5c53, 1);  xchg(cx, ax);                              /* xchg cx, ax */
            ii(0x5c54, 3);  add(di, 0xf);                              /* add di, 0xf */
            ii(0x5c57, 3);  and(di, -0x10 /* 0xf0 */);                 /* and di, 0xfff0 */
            ii(0x5c5a, 2);  mov(ax, di);                               /* mov ax, di */
            ii(0x5c5c, 3);  shr(ax, 4);                                /* shr ax, 0x4 */
            ii(0x5c5f, 4);  mov(bx, memw[ds, 0xa10]);                  /* mov bx, [0xa10] */
            ii(0x5c63, 2);  mov(dx, cs);                               /* mov dx, cs */
            ii(0x5c65, 2);  sub(bx, dx);                               /* sub bx, dx */
            ii(0x5c67, 2);  sub(bx, ax);                               /* sub bx, ax */
            ii(0x5c69, 2);  add(ax, dx);                               /* add ax, dx */
            ii(0x5c6b, 1);  cld();                                     /* cld */
            ii(0x5c6c, 4);  xchg(memw[ds, 0xa10], ax);                 /* xchg [0xa10], ax */
            ii(0x5c70, 2);  xor(si, si);                               /* xor si, si */
            ii(0x5c72, 2);  mov(ds, ax);                               /* mov ds, ax */
            ii(0x5c74, 2);  mov(es, dx);                               /* mov es, dx */
            ii(0x5c76, 2);  rep(() => movsw());                        /* rep movsw */
            ii(0x5c78, 1);  push(ss);                                  /* push ss */
            ii(0x5c79, 1);  pop(ds);                                   /* pop ds */
            ii(0x5c7a, 1);  push(bx);                                  /* push bx */
            ii(0x5c7b, 3);  call(0x5cce, 0x50);                        /* call 0x5cce */
            ii(0x5c7e, 1);  pop(cx);                                   /* pop cx */
            ii(0x5c7f, 3);  shl(cx, 3);                                /* shl cx, 0x3 */
        l_0x5c82:
            ii(0x5c82, 1);  push(cs);                                  /* push cs */
            ii(0x5c83, 1);  pop(es);                                   /* pop es */
            ii(0x5c84, 3);  mov(ax, 0xcccc);                           /* mov ax, 0xcccc */
            ii(0x5c87, 2);  mov(bx, di);                               /* mov bx, di */
            ii(0x5c89, 2);  rep(() => stosw());                        /* rep stosw */
            ii(0x5c8b, 3);  add(bx, 0xf);                              /* add bx, 0xf */
            ii(0x5c8e, 3);  shr(bx, 4);                                /* shr bx, 0x4 */
            ii(0x5c91, 4);  add(bx, memw[ds, 0x9b6]);                  /* add bx, [0x9b6] */
            ii(0x5c95, 3);  mov(ax, memw[ds, 0xcec]);                  /* mov ax, [0xcec] */
            ii(0x5c98, 2);  sub(bx, ax);                               /* sub bx, ax */
            ii(0x5c9a, 4);  mov(memw[ds, 0x5a], bx);                   /* mov [0x5a], bx */
            ii(0x5c9e, 2);  mov(es, ax);                               /* mov es, ax */
            ii(0x5ca0, 2);  mov(ah, 0x4a);                             /* mov ah, 0x4a */
            ii(0x5ca2, 2);  @int(0x21);                                /* int 0x21 */
            ii(0x5ca4, 1);  pop(si);                                   /* pop si */
            ii(0x5ca5, 1);  pop(di);                                   /* pop di */
            ii(0x5ca6, 1);  pop(ax);                                   /* pop ax */
            ii(0x5ca7, 1);  pop(sp);                                   /* pop sp */
            ii(0x5ca8, 1);  pop(bp);                                   /* pop bp */
            ii(0x5ca9, 1);  ret(); return;                             /* ret */
        l_0x5caa:
            ii(0x5caa, 4);  mov(cx, memw[ds, 0xcec]);                  /* mov cx, [0xcec] */
            ii(0x5cae, 1);  dec(cx);                                   /* dec cx */
            ii(0x5caf, 2);  mov(es, cx);                               /* mov es, cx */
            ii(0x5cb1, 5);  add(cx, memw[es, 3]);                      /* add cx, [es:0x3] */
            ii(0x5cb6, 1);  inc(cx);                                   /* inc cx */
            ii(0x5cb7, 2);  mov(ax, cs);                               /* mov ax, cs */
            ii(0x5cb9, 2);  sub(cx, ax);                               /* sub cx, ax */
            ii(0x5cbb, 3);  shl(cx, 4);                                /* shl cx, 0x4 */
            ii(0x5cbe, 2);  sub(cx, di);                               /* sub cx, di */
            ii(0x5cc0, 2);  shr(cx, 1);                                /* shr cx, 1 */
            ii(0x5cc2, 2);  jmp(0x5c82, -0x42); goto l_0x5c82;         /* jmp 0x5c82 */
        }
    }
}
