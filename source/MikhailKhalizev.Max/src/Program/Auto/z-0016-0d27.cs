using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("3ec08dec-2648-4a4f-8c2a-33d105d26cb7")]
        public void Method_0016_0d27()
        {
            ii(0x16_0d27, 4); enterw(0x82, 0);                          /* enter 0x82, 0x0 */
            ii(0x16_0d2b, 1); pushw(si);                                /* push si */
            ii(0x16_0d2c, 1); pushw(ds);                                /* push ds */
            ii(0x16_0d2d, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x16_0d30, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x16_0d32, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x16_0d35, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x16_0d38, 3); callw(0x15_ff2f, -0xe0c);                 /* call 0xff2f */
            ii(0x16_0d3b, 3); cmp(ax, 0x6e);                            /* cmp ax, 0x6e */
            ii(0x16_0d3e, 2); if(jlew(0x16_0d45, 0x5)) goto l_0x16_0d45; /* jle 0xd45 */
            ii(0x16_0d40, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x16_0d42, 3); jmpw(0x16_0de1, 0x9c); goto l_0x16_0de1;  /* jmp 0xde1 */
        l_0x16_0d45:
            ii(0x16_0d45, 3); lea(ax, bp - 0x80);                       /* lea ax, [bp-0x80] */
            ii(0x16_0d48, 1); pushw(ss);                                /* push ss */
            ii(0x16_0d49, 1); pushw(ax);                                /* push ax */
            ii(0x16_0d4a, 4); cmp(memw_a16[ss, bp + 0xc], 0);           /* cmp word [bp+0xc], 0x0 */
            ii(0x16_0d4e, 2); if(jzw(0x16_0d55, 0x5)) goto l_0x16_0d55; /* jz 0xd55 */
            ii(0x16_0d50, 3); mov(ax, 0x389c);                          /* mov ax, 0x389c */
            ii(0x16_0d53, 2); jmpw(0x16_0d58, 0x3); goto l_0x16_0d58;   /* jmp 0xd58 */
        l_0x16_0d55:
            ii(0x16_0d55, 3); mov(ax, 0x38a1);                          /* mov ax, 0x38a1 */
        l_0x16_0d58:
            ii(0x16_0d58, 1); pushw(ds);                                /* push ds */
            ii(0x16_0d59, 1); pushw(ax);                                /* push ax */
            ii(0x16_0d5a, 3); callw(0x15_ff6c, -0xdf1);                 /* call 0xff6c */
            ii(0x16_0d5d, 3); lea(ax, bp - 0x80);                       /* lea ax, [bp-0x80] */
            ii(0x16_0d60, 1); pushw(ss);                                /* push ss */
            ii(0x16_0d61, 1); pushw(ax);                                /* push ax */
            ii(0x16_0d62, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x16_0d65, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x16_0d68, 3); callw(0x15_ff4a, -0xe21);                 /* call 0xff4a */
            ii(0x16_0d6b, 3); lea(ax, bp - 0x80);                       /* lea ax, [bp-0x80] */
            ii(0x16_0d6e, 1); pushw(ss);                                /* push ss */
            ii(0x16_0d6f, 1); pushw(ax);                                /* push ax */
            ii(0x16_0d70, 3); callw(0x15_ff2f, -0xe44);                 /* call 0xff2f */
            ii(0x16_0d73, 4); mov(memw_a16[ss, bp - 0x82], ax);         /* mov [bp-0x82], ax */
            ii(0x16_0d77, 2); mov(si, ax);                              /* mov si, ax */
            ii(0x16_0d79, 4); mov(memb_a16[ss, bp + si - 0x80], 0x20);  /* mov byte [bp+si-0x80], 0x20 */
            ii(0x16_0d7d, 2); pushw(0);                                 /* push 0x0 */
            ii(0x16_0d7f, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x16_0d82, 2); pushw(0x10);                              /* push 0x10 */
            ii(0x16_0d84, 2); pushw(0x4);                               /* push 0x4 */
            ii(0x16_0d86, 1); inc(si);                                  /* inc si */
            ii(0x16_0d87, 4); mov(memw_a16[ss, bp - 0x82], si);         /* mov [bp-0x82], si */
            ii(0x16_0d8b, 3); lea(ax, bp + si - 0x80);                  /* lea ax, [bp+si-0x80] */
            ii(0x16_0d8e, 1); pushw(ss);                                /* push ss */
            ii(0x16_0d8f, 1); pushw(ax);                                /* push ax */
            ii(0x16_0d90, 1); pushw(cs);                                /* push cs */
            ii(0x16_0d91, 3); callw(0x16_03cb, -0x9c9);                 /* call 0x3cb */
            ii(0x16_0d94, 3); lea(si, si + 0x4);                        /* lea si, [si+0x4] */
            ii(0x16_0d97, 4); mov(memw_a16[ss, bp - 0x82], si);         /* mov [bp-0x82], si */
            ii(0x16_0d9b, 4); mov(memb_a16[ss, bp + si - 0x80], 0x3b);  /* mov byte [bp+si-0x80], 0x3b */
            ii(0x16_0d9f, 1); inc(si);                                  /* inc si */
            ii(0x16_0da0, 4); mov(memw_a16[ss, bp - 0x82], si);         /* mov [bp-0x82], si */
            ii(0x16_0da4, 4); mov(memb_a16[ss, bp + si - 0x80], 0x20);  /* mov byte [bp+si-0x80], 0x20 */
            ii(0x16_0da8, 1); inc(si);                                  /* inc si */
            ii(0x16_0da9, 4); mov(memw_a16[ss, bp - 0x82], si);         /* mov [bp-0x82], si */
            ii(0x16_0dad, 4); mov(memb_a16[ss, bp + si - 0x80], 0x67);  /* mov byte [bp+si-0x80], 0x67 */
            ii(0x16_0db1, 1); inc(si);                                  /* inc si */
            ii(0x16_0db2, 4); mov(memw_a16[ss, bp - 0x82], si);         /* mov [bp-0x82], si */
            ii(0x16_0db6, 4); mov(memb_a16[ss, bp + si - 0x80], 0x6f);  /* mov byte [bp+si-0x80], 0x6f */
            ii(0x16_0dba, 3); lea(ax, si + 0x1);                        /* lea ax, [si+0x1] */
            ii(0x16_0dbd, 4); mov(memw_a16[ss, bp - 0x82], ax);         /* mov [bp-0x82], ax */
            ii(0x16_0dc1, 2); mov(si, ax);                              /* mov si, ax */
            ii(0x16_0dc3, 4); mov(memb_a16[ss, bp + si - 0x80], 0);     /* mov byte [bp+si-0x80], 0x0 */
            ii(0x16_0dc7, 3); lea(ax, si + 0x1);                        /* lea ax, [si+0x1] */
            ii(0x16_0dca, 4); mov(memw_a16[ss, bp - 0x82], ax);         /* mov [bp-0x82], ax */
            ii(0x16_0dce, 5); test(memb_a16[ds, 0x36f6], 0x20);         /* test byte [0x36f6], 0x20 */
            ii(0x16_0dd3, 2); if(jnzw(0x16_0de1, 0xc)) goto l_0x16_0de1; /* jnz 0xde1 */
            ii(0x16_0dd5, 3); lea(ax, bp - 0x80);                       /* lea ax, [bp-0x80] */
            ii(0x16_0dd8, 1); pushw(ss);                                /* push ss */
            ii(0x16_0dd9, 1); pushw(ax);                                /* push ax */
            ii(0x16_0dda, 5); callw_far_abs(0x80, 0x4f2c);              /* call word 0x80:0x4f2c */
            ii(0x16_0ddf, 1); popw(bx);                                 /* pop bx */
            ii(0x16_0de0, 1); popw(bx);                                 /* pop bx */
        l_0x16_0de1:
            ii(0x16_0de1, 1); popw(ds);                                 /* pop ds */
            ii(0x16_0de2, 1); popw(si);                                 /* pop si */
            ii(0x16_0de3, 1); leavew();                                 /* leave */
            ii(0x16_0de4, 3); retfw(0x8); return;                       /* retf 0x8 */
        }
    }
}
