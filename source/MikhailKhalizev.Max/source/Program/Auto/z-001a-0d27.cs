using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1a_0d27-54f52939")]
        public void Method_001a_0d27()
        {
            ii(0x1a_0d27, 4);  enter(0x82, 0);                         /* enter 0x82, 0x0 */
            ii(0x1a_0d2b, 1);  push(si);                               /* push si */
            ii(0x1a_0d2c, 1);  push(ds);                               /* push ds */
            ii(0x1a_0d2d, 3);  mov(ax, 0xa8);                          /* mov ax, 0xa8 */
            ii(0x1a_0d30, 2);  mov(ds, ax);                            /* mov ds, ax */
            ii(0x1a_0d32, 3);  push(memw[ss, bp + 10]);                /* push word [bp+0xa] */
            ii(0x1a_0d35, 3);  push(memw[ss, bp + 8]);                 /* push word [bp+0x8] */
            ii(0x1a_0d38, 3);  call(0x19_ff2f, -0xe0c);                /* call 0xff2f */
            ii(0x1a_0d3b, 3);  cmp(ax, 0x6e);                          /* cmp ax, 0x6e */
            ii(0x1a_0d3e, 2);  if(jle(0x1a_0d45, 5)) goto l_0x1a_0d45; /* jle 0xd45 */
            ii(0x1a_0d40, 2);  sub(ax, ax);                            /* sub ax, ax */
            ii(0x1a_0d42, 3);  jmp(0x1a_0de1, 0x9c); goto l_0x1a_0de1; /* jmp 0xde1 */
        l_0x1a_0d45:
            ii(0x1a_0d45, 3);  lea(ax, memw[ss, bp - 128]);            /* lea ax, [bp-0x80] */
            ii(0x1a_0d48, 1);  push(ss);                               /* push ss */
            ii(0x1a_0d49, 1);  push(ax);                               /* push ax */
            ii(0x1a_0d4a, 4);  cmp(memw[ss, bp + 12], 0);              /* cmp word [bp+0xc], 0x0 */
            ii(0x1a_0d4e, 2);  if(jz(0x1a_0d55, 5)) goto l_0x1a_0d55;  /* jz 0xd55 */
            ii(0x1a_0d50, 3);  mov(ax, 0x389c);                        /* mov ax, 0x389c */
            ii(0x1a_0d53, 2);  jmp(0x1a_0d58, 3); goto l_0x1a_0d58;    /* jmp 0xd58 */
        l_0x1a_0d55:
            ii(0x1a_0d55, 3);  mov(ax, 0x38a1);                        /* mov ax, 0x38a1 */
        l_0x1a_0d58:
            ii(0x1a_0d58, 1);  push(ds);                               /* push ds */
            ii(0x1a_0d59, 1);  push(ax);                               /* push ax */
            ii(0x1a_0d5a, 3);  call(0x19_ff6c, -0xdf1);                /* call 0xff6c */
            ii(0x1a_0d5d, 3);  lea(ax, memw[ss, bp - 128]);            /* lea ax, [bp-0x80] */
            ii(0x1a_0d60, 1);  push(ss);                               /* push ss */
            ii(0x1a_0d61, 1);  push(ax);                               /* push ax */
            ii(0x1a_0d62, 3);  push(memw[ss, bp + 10]);                /* push word [bp+0xa] */
            ii(0x1a_0d65, 3);  push(memw[ss, bp + 8]);                 /* push word [bp+0x8] */
            ii(0x1a_0d68, 3);  call(0x19_ff4a, -0xe21);                /* call 0xff4a */
            ii(0x1a_0d6b, 3);  lea(ax, memw[ss, bp - 128]);            /* lea ax, [bp-0x80] */
            ii(0x1a_0d6e, 1);  push(ss);                               /* push ss */
            ii(0x1a_0d6f, 1);  push(ax);                               /* push ax */
            ii(0x1a_0d70, 3);  call(0x19_ff2f, -0xe44);                /* call 0xff2f */
            ii(0x1a_0d73, 4);  mov(memw[ss, bp - 130], ax);            /* mov [bp-0x82], ax */
            ii(0x1a_0d77, 2);  mov(si, ax);                            /* mov si, ax */
            ii(0x1a_0d79, 4);  mov(memb[ss, bp + si - 128], 0x20);     /* mov byte [bp+si-0x80], 0x20 */
            ii(0x1a_0d7d, 2);  push(0);                                /* push 0x0 */
            ii(0x1a_0d7f, 3);  push(memw[ss, bp + 6]);                 /* push word [bp+0x6] */
            ii(0x1a_0d82, 2);  push(0x10);                             /* push 0x10 */
            ii(0x1a_0d84, 2);  push(4);                                /* push 0x4 */
            ii(0x1a_0d86, 1);  inc(si);                                /* inc si */
            ii(0x1a_0d87, 4);  mov(memw[ss, bp - 130], si);            /* mov [bp-0x82], si */
            ii(0x1a_0d8b, 3);  lea(ax, memw[ss, bp + si - 128]);       /* lea ax, [bp+si-0x80] */
            ii(0x1a_0d8e, 1);  push(ss);                               /* push ss */
            ii(0x1a_0d8f, 1);  push(ax);                               /* push ax */
            ii(0x1a_0d90, 1);  push(cs);                               /* push cs */
            ii(0x1a_0d91, 3);  call(0x1a_03cb, -0x9c9);                /* call 0x3cb */
            ii(0x1a_0d94, 3);  lea(si, memw[ds, si + 4]);              /* lea si, [si+0x4] */
            ii(0x1a_0d97, 4);  mov(memw[ss, bp - 130], si);            /* mov [bp-0x82], si */
            ii(0x1a_0d9b, 4);  mov(memb[ss, bp + si - 128], 0x3b);     /* mov byte [bp+si-0x80], 0x3b */
            ii(0x1a_0d9f, 1);  inc(si);                                /* inc si */
            ii(0x1a_0da0, 4);  mov(memw[ss, bp - 130], si);            /* mov [bp-0x82], si */
            ii(0x1a_0da4, 4);  mov(memb[ss, bp + si - 128], 0x20);     /* mov byte [bp+si-0x80], 0x20 */
            ii(0x1a_0da8, 1);  inc(si);                                /* inc si */
            ii(0x1a_0da9, 4);  mov(memw[ss, bp - 130], si);            /* mov [bp-0x82], si */
            ii(0x1a_0dad, 4);  mov(memb[ss, bp + si - 128], 0x67);     /* mov byte [bp+si-0x80], 0x67 */
            ii(0x1a_0db1, 1);  inc(si);                                /* inc si */
            ii(0x1a_0db2, 4);  mov(memw[ss, bp - 130], si);            /* mov [bp-0x82], si */
            ii(0x1a_0db6, 4);  mov(memb[ss, bp + si - 128], 0x6f);     /* mov byte [bp+si-0x80], 0x6f */
            ii(0x1a_0dba, 3);  lea(ax, memw[ds, si + 1]);              /* lea ax, [si+0x1] */
            ii(0x1a_0dbd, 4);  mov(memw[ss, bp - 130], ax);            /* mov [bp-0x82], ax */
            ii(0x1a_0dc1, 2);  mov(si, ax);                            /* mov si, ax */
            ii(0x1a_0dc3, 4);  mov(memb[ss, bp + si - 128], 0);        /* mov byte [bp+si-0x80], 0x0 */
            ii(0x1a_0dc7, 3);  lea(ax, memw[ds, si + 1]);              /* lea ax, [si+0x1] */
            ii(0x1a_0dca, 4);  mov(memw[ss, bp - 130], ax);            /* mov [bp-0x82], ax */
            ii(0x1a_0dce, 5);  test(memb[ds, 0x36f6], 0x20);           /* test byte [0x36f6], 0x20 */
            ii(0x1a_0dd3, 2);  if(jnz(0x1a_0de1, 0xc)) goto l_0x1a_0de1;/* jnz 0xde1 */
            ii(0x1a_0dd5, 3);  lea(ax, memw[ss, bp - 128]);            /* lea ax, [bp-0x80] */
            ii(0x1a_0dd8, 1);  push(ss);                               /* push ss */
            ii(0x1a_0dd9, 1);  push(ax);                               /* push ax */
            ii(0x1a_0dda, 5);  call_far_abs(0x80, 0x4f2c);             /* call word 0x80:0x4f2c */
            ii(0x1a_0ddf, 1);  pop(bx);                                /* pop bx */
            ii(0x1a_0de0, 1);  pop(bx);                                /* pop bx */
        l_0x1a_0de1:
            ii(0x1a_0de1, 1);  pop(ds);                                /* pop ds */
            ii(0x1a_0de2, 1);  pop(si);                                /* pop si */
            ii(0x1a_0de3, 1);  leave();                                /* leave */
            ii(0x1a_0de4, 3);  retf(8);                                /* retf 0x8 */
        }
    }
}
