using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_d54f-961f7b36")]
        public void Method_0017_d54f()
        {
            ii(0x17_d54f, 1);  push(bp);                               /* push bp */
            ii(0x17_d550, 2);  mov(bp, sp);                            /* mov bp, sp */
            ii(0x17_d552, 2);  xor(cx, cx);                            /* xor cx, cx */
            ii(0x17_d554, 2);  jmp(0x17_d570, 0x1a); goto l_0x17_d570; /* jmp 0xd570 */
        //  ii(0x17_d556, 1);  push(bp);                               /* push bp */
        //  ii(0x17_d557, 2);  mov(bp, sp);                            /* mov bp, sp */
        //  ii(0x17_d559, 3);  mov(cx, 1);                             /* mov cx, 0x1 */
        //  ii(0x17_d55c, 2);  jmp(0x17_d570, 0x12); goto l_0x17_d570; /* jmp 0xd570 */
        //  ii(0x17_d55e, 1);  push(bp);                               /* push bp */
        //  ii(0x17_d55f, 2);  mov(bp, sp);                            /* mov bp, sp */
        //  ii(0x17_d561, 1);  push(si);                               /* push si */
        //  ii(0x17_d562, 1);  push(di);                               /* push di */
        //  ii(0x17_d563, 3);  mov(cx, 0x100);                         /* mov cx, 0x100 */
        //  ii(0x17_d566, 2);  jmp(0x17_d570, 8); goto l_0x17_d570;    /* jmp 0xd570 */
        //  ii(0x17_d568, 1);  push(bp);                               /* push bp */
        //  ii(0x17_d569, 2);  mov(bp, sp);                            /* mov bp, sp */
        //  ii(0x17_d56b, 1);  push(si);                               /* push si */
        //  ii(0x17_d56c, 1);  push(di);                               /* push di */
        //  ii(0x17_d56d, 3);  mov(cx, 0x101);                         /* mov cx, 0x101 */
        l_0x17_d570:
            ii(0x17_d570, 1);  push(cx);                               /* push cx */
            ii(0x17_d571, 2);  or(cl, cl);                             /* or cl, cl */
            ii(0x17_d573, 2);  if(jnz(0x17_d593, 0x1e)) goto l_0x17_d593;/* jnz 0xd593 */
            ii(0x17_d575, 3);  mov(si, 0x1ee8);                        /* mov si, 0x1ee8 */
            ii(0x17_d578, 3);  mov(di, 0x1ee8);                        /* mov di, 0x1ee8 */
            ii(0x17_d57b, 3);  call(0x17_d5ff, 0x81);                  /* call 0xd5ff */
            ii(0x17_d57e, 3);  mov(si, 0x1dc8);                        /* mov si, 0x1dc8 */
            ii(0x17_d581, 3);  mov(di, 0x1dc8);                        /* mov di, 0x1dc8 */
            ii(0x17_d584, 3);  call(0x17_d5ff, 0x78);                  /* call 0xd5ff */
            ii(0x17_d587, 6);  cmp(memw[ds, 0x1dac], 0xd6d6);          /* cmp word [0x1dac], 0xd6d6 */
            ii(0x17_d58d, 2);  if(jnz(0x17_d593, 4)) goto l_0x17_d593; /* jnz 0xd593 */
            ii(0x17_d58f, 4);  call_abs(memw[ds, 0x1db2]);             /* call word [0x1db2] */
        l_0x17_d593:
            ii(0x17_d593, 3);  mov(si, 0x1dc8);                        /* mov si, 0x1dc8 */
            ii(0x17_d596, 3);  mov(di, 0x1dc8);                        /* mov di, 0x1dc8 */
            ii(0x17_d599, 3);  call(0x17_d5ff, 0x63);                  /* call 0xd5ff */
            ii(0x17_d59c, 3);  mov(si, 0x1dc8);                        /* mov si, 0x1dc8 */
            ii(0x17_d59f, 3);  mov(di, 0x1dc8);                        /* mov di, 0x1dc8 */
            ii(0x17_d5a2, 3);  call(0x17_d5ff, 0x5a);                  /* call 0xd5ff */
            ii(0x17_d5a5, 1);  nop();                                  /* nop */
            ii(0x17_d5a6, 1);  push(cs);                               /* push cs */
            ii(0x17_d5a7, 3);  call(0x17_e20f, 0xc65);                 /* call 0xe20f */
            ii(0x17_d5aa, 2);  or(ax, ax);                             /* or ax, ax */
            ii(0x17_d5ac, 2);  if(jz(0x17_d5bf, 0x11)) goto l_0x17_d5bf;/* jz 0xd5bf */
            ii(0x17_d5ae, 1);  pop(ax);                                /* pop ax */
            ii(0x17_d5af, 2);  or(ah, ah);                             /* or ah, ah */
            ii(0x17_d5b1, 1);  push(ax);                               /* push ax */
            ii(0x17_d5b2, 2);  if(jnz(0x17_d5bf, 0xb)) goto l_0x17_d5bf;/* jnz 0xd5bf */
            ii(0x17_d5b4, 4);  cmp(memw[ss, bp + 6], 0);               /* cmp word [bp+0x6], 0x0 */
            ii(0x17_d5b8, 2);  if(jnz(0x17_d5bf, 5)) goto l_0x17_d5bf; /* jnz 0xd5bf */
            ii(0x17_d5ba, 5);  mov(memw[ss, bp + 6], 0xff);            /* mov word [bp+0x6], 0xff */
        l_0x17_d5bf:
            ii(0x17_d5bf, 3);  call(0x17_d5d2, 0x10);                  /* call 0xd5d2 */
            ii(0x17_d5c2, 1);  pop(ax);                                /* pop ax */
            ii(0x17_d5c3, 2);  or(ah, ah);                             /* or ah, ah */
            ii(0x17_d5c5, 2);  if(jnz(0x17_d5ce, 7)) goto l_0x17_d5ce; /* jnz 0xd5ce */
            ii(0x17_d5c7, 3);  mov(ax, memw[ss, bp + 6]);              /* mov ax, [bp+0x6] */
            ii(0x17_d5ca, 2);  mov(ah, 0x4c);                          /* mov ah, 0x4c */
            ii(0x17_d5cc, 2);  @int(0x21);                             /* int 0x21 */
        l_0x17_d5ce:
            ii(0x17_d5ce, 1);  pop(di);                                /* pop di */
            ii(0x17_d5cf, 1);  pop(si);                                /* pop si */
            ii(0x17_d5d0, 1);  pop(bp);                                /* pop bp */
            ii(0x17_d5d1, 1);  retf();                                 /* retf */
        }
    }
}
