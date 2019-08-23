using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_a99f-acacb6fc")]
        public void Method_0018_a99f()
        {
            ii(0x18_a99f, 3); call(0x18_ab18, 0x176);                   /* call 0xab18 */
            ii(0x18_a9a2, 2); if(jae(0x18_a9ac, 0x8)) goto l_0x18_a9ac; /* jae 0xa9ac */
            ii(0x18_a9a4, 3); call(0x18_a893, -0x114);                  /* call 0xa893 */
            ii(0x18_a9a7, 3); mov(ax, memw[ds, bx + 0x16]);             /* mov ax, [bx+0x16] */
            ii(0x18_a9aa, 2); jmp(0x18_aa14, 0x68); goto l_0x18_aa14;   /* jmp 0xaa14 */
        l_0x18_a9ac:
            ii(0x18_a9ac, 3); mov(dx, memw[ss, bp + 0x14]);             /* mov dx, [bp+0x14] */
            ii(0x18_a9af, 3); mov(si, memw[ss, bp + 0x12]);             /* mov si, [bp+0x12] */
        l_0x18_a9b2:
            ii(0x18_a9b2, 1); sti();                                    /* sti */
            ii(0x18_a9b3, 4); mov(di, memw[ds, 0xa]);                   /* mov di, [0xa] */
            ii(0x18_a9b7, 3); mov(memw[ds, bx + 0x12], di);             /* mov [bx+0x12], di */
            ii(0x18_a9ba, 2); mov(cx, dx);                              /* mov cx, dx */
            ii(0x18_a9bc, 4); cmp(cx, memw[ds, 0xe]);                   /* cmp cx, [0xe] */
            ii(0x18_a9c0, 2); if(jbe(0x18_a9c6, 0x4)) goto l_0x18_a9c6; /* jbe 0xa9c6 */
            ii(0x18_a9c2, 4); mov(cx, memw[ds, 0xe]);                   /* mov cx, [0xe] */
        l_0x18_a9c6:
            ii(0x18_a9c6, 3); mov(memw[ds, bx + 0x14], cx);             /* mov [bx+0x14], cx */
            ii(0x18_a9c9, 3); mov(ax, memw[ss, bp + 0x16]);             /* mov ax, [bp+0x16] */
            ii(0x18_a9cc, 3); mov(memw[ds, bx + 0x16], ax);             /* mov [bx+0x16], ax */
            ii(0x18_a9cf, 1); push(cx);                                 /* push cx */
            ii(0x18_a9d0, 1); push(ds);                                 /* push ds */
            ii(0x18_a9d1, 3); mov(ds, memw[ss, bp + 0x4]);              /* mov ds, [bp+0x4] */
            ii(0x18_a9d4, 1); cli();                                    /* cli */
            ii(0x18_a9d5, 2); mov(ax, cx);                              /* mov ax, cx */
            ii(0x18_a9d7, 1); push(si);                                 /* push si */
            ii(0x18_a9d8, 2); add(si, cx);                              /* add si, cx */
            ii(0x18_a9da, 1); pop(si);                                  /* pop si */
            ii(0x18_a9db, 2); if(jae(0x18_a9f0, 0x13)) goto l_0x18_a9f0; /* jae 0xa9f0 */
            ii(0x18_a9dd, 2); if(jz(0x18_a9f0, 0x11)) goto l_0x18_a9f0; /* jz 0xa9f0 */
            ii(0x18_a9df, 2); mov(cx, si);                              /* mov cx, si */
            ii(0x18_a9e1, 1); push(cx);                                 /* push cx */
            ii(0x18_a9e2, 2); neg(cx);                                  /* neg cx */
            ii(0x18_a9e4, 2); rep(() => movsb());                       /* rep movsb */
            ii(0x18_a9e6, 2); mov(cx, ds);                              /* mov cx, ds */
            ii(0x18_a9e8, 3); add(cx, 0x8);                             /* add cx, 0x8 */
            ii(0x18_a9eb, 2); mov(ds, cx);                              /* mov ds, cx */
            ii(0x18_a9ed, 1); pop(cx);                                  /* pop cx */
            ii(0x18_a9ee, 2); add(cx, ax);                              /* add cx, ax */
        l_0x18_a9f0:
            ii(0x18_a9f0, 2); shr(cx, 0x1);                             /* shr cx, 1 */
            ii(0x18_a9f2, 2); rep(() => movsw());                       /* rep movsw */
            ii(0x18_a9f4, 2); rcl(cx, 0x1);                             /* rcl cx, 1 */
            ii(0x18_a9f6, 2); rep(() => movsb());                       /* rep movsb */
            ii(0x18_a9f8, 1); pop(ds);                                  /* pop ds */
            ii(0x18_a9f9, 3); call(0x18_a893, -0x169);                  /* call 0xa893 */
            ii(0x18_a9fc, 1); sti();                                    /* sti */
            ii(0x18_a9fd, 3); mov(ax, memw[ds, bx + 0x16]);             /* mov ax, [bx+0x16] */
            ii(0x18_aa00, 1); pop(cx);                                  /* pop cx */
            ii(0x18_aa01, 4); test(memb[ds, bx + 0x26], 0x1);           /* test byte [bx+0x26], 0x1 */
            ii(0x18_aa05, 2); if(jnz(0x18_aa14, 0xd)) goto l_0x18_aa14; /* jnz 0xaa14 */
            ii(0x18_aa07, 2); sub(dx, ax);                              /* sub dx, ax */
            ii(0x18_aa09, 2); if(jz(0x18_aa0f, 0x4)) goto l_0x18_aa0f;  /* jz 0xaa0f */
            ii(0x18_aa0b, 2); cmp(ax, cx);                              /* cmp ax, cx */
            ii(0x18_aa0d, 2); if(jz(0x18_a9b2, -0x5d)) goto l_0x18_a9b2; /* jz 0xa9b2 */
        l_0x18_aa0f:
            ii(0x18_aa0f, 3); mov(ax, memw[ss, bp + 0x14]);             /* mov ax, [bp+0x14] */
            ii(0x18_aa12, 2); sub(ax, dx);                              /* sub ax, dx */
        l_0x18_aa14:
            ii(0x18_aa14, 3); mov(memw[ss, bp + 0x16], ax);             /* mov [bp+0x16], ax */
            ii(0x18_aa17, 3); if(jmp_func(0x18_a82f, -0x1eb)) return;   /* jmp 0xa82f */
        }
    }
}
