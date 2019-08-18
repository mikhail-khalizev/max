using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_d0d3-fd369918")]
        public void Method_0017_d0d3()
        {
            ii(0x17_d0d3, 2); mov(ah, 0x30);                            /* mov ah, 0x30 */
            ii(0x17_d0d5, 2); @int(0x21);                               /* int 0x21 */
            ii(0x17_d0d7, 2); cmp(al, 0x2);                             /* cmp al, 0x2 */
            ii(0x17_d0d9, 2); if(jaew(0x17_d0e0, 0x5)) goto l_0x17_d0e0; /* jae 0xd0e0 */
            ii(0x17_d0db, 2); xor(ax, ax);                              /* xor ax, ax */
            ii(0x17_d0dd, 1); pushw(es);                                /* push es */
            ii(0x17_d0de, 1); pushw(ax);                                /* push ax */
            ii(0x17_d0df, 1); retfw(); return;                          /* retf */
        l_0x17_d0e0:
            ii(0x17_d0e0, 3); mov(di, 0x3e68);                          /* mov di, 0x3e68 */
            ii(0x17_d0e3, 2); mov(ax, di);                              /* mov ax, di */
            ii(0x17_d0e5, 3); lsl(ax, ax);                              /* lsl ax, ax */
            ii(0x17_d0e8, 4); mov(memw_a16[ss, 0x13f4], ax);            /* mov [ss:0x13f4], ax */
            ii(0x17_d0ec, 3); mov(bx, 0x13f6);                          /* mov bx, 0x13f6 */
            ii(0x17_d0ef, 3); mov(memw_a16[ss, bx], ss);                /* mov [ss:bx], ss */
            ii(0x17_d0f2, 3); and(sp, -0x2 /* 0xfe */);                 /* and sp, 0xfffe */
            ii(0x17_d0f5, 4); mov(memw_a16[ss, bx + 0x4], sp);          /* mov [ss:bx+0x4], sp */
            ii(0x17_d0f9, 3); mov(ax, 0xfffe);                          /* mov ax, 0xfffe */
            ii(0x17_d0fc, 1); pushw(ax);                                /* push ax */
            ii(0x17_d0fd, 4); mov(memw_a16[ss, bx + 0xa], sp);          /* mov [ss:bx+0xa], sp */
            ii(0x17_d101, 2); not(ax);                                  /* not ax */
            ii(0x17_d103, 1); pushw(ax);                                /* push ax */
            ii(0x17_d104, 4); mov(memw_a16[ss, bx + 0x6], sp);          /* mov [ss:bx+0x6], sp */
            ii(0x17_d108, 4); mov(memw_a16[ss, bx + 0x8], sp);          /* mov [ss:bx+0x8], sp */
            ii(0x17_d10c, 5); mov(memw_a16[ss, 0x13f0], sp);            /* mov [ss:0x13f0], sp */
            ii(0x17_d111, 2); add(si, di);                              /* add si, di */
            ii(0x17_d113, 5); mov(memw_a16[ss, 0x1c54], ds);            /* mov [ss:0x1c54], ds */
            ii(0x17_d118, 1); pushw(ss);                                /* push ss */
            ii(0x17_d119, 1); popw(es);                                 /* pop es */
            ii(0x17_d11a, 1); cld();                                    /* cld */
            ii(0x17_d11b, 3); mov(di, 0x1e8e);                          /* mov di, 0x1e8e */
            ii(0x17_d11e, 3); mov(cx, 0x51c0);                          /* mov cx, 0x51c0 */
            ii(0x17_d121, 2); sub(cx, di);                              /* sub cx, di */
            ii(0x17_d123, 2); xor(ax, ax);                              /* xor ax, ax */
            ii(0x17_d125, 2); rep_a16(() => stosb_a16());               /* rep stosb */
            ii(0x17_d127, 1); pushw(ss);                                /* push ss */
            ii(0x17_d128, 1); popw(ds);                                 /* pop ds */
            ii(0x17_d129, 4); mov(cx, memw_a16[ds, 0x1daa]);            /* mov cx, [0x1daa] */
            ii(0x17_d12d, 2); if(jcxzw(0x17_d131, 0x2)) goto l_0x17_d131; /* jcxz 0xd131 */
            ii(0x17_d12f, 2); callw_abs(cx);                            /* call cx */
        l_0x17_d131:
            ii(0x17_d131, 1); nop();                                    /* nop */
            ii(0x17_d132, 1); pushw(cs);                                /* push cs */
            ii(0x17_d133, 3); callw(0x17_d7c6, 0x690);                  /* call 0xd7c6 */
            ii(0x17_d136, 1); nop();                                    /* nop */
            ii(0x17_d137, 1); pushw(cs);                                /* push cs */
            ii(0x17_d138, 3); callw(0x17_d634, 0x4f9);                  /* call 0xd634 */
            ii(0x17_d13b, 2); xor(bp, bp);                              /* xor bp, bp */
            ii(0x17_d13d, 1); nop();                                    /* nop */
            ii(0x17_d13e, 1); pushw(cs);                                /* push cs */
            ii(0x17_d13f, 3); callw(0x17_d48a, 0x348);                  /* call 0xd48a */
            ii(0x17_d142, 1); pushw(ss);                                /* push ss */
            ii(0x17_d143, 1); popw(ds);                                 /* pop ds */
            ii(0x17_d144, 4); pushw(memw_a16[ds, 0x1c75]);              /* push word [0x1c75] */
            ii(0x17_d148, 4); pushw(memw_a16[ds, 0x1c73]);              /* push word [0x1c73] */
            ii(0x17_d14c, 4); pushw(memw_a16[ds, 0x1c71]);              /* push word [0x1c71] */
            ii(0x17_d150, 1); nop();                                    /* nop */
            ii(0x17_d151, 1); pushw(cs);                                /* push cs */
            ii(0x17_d152, 3); callw(0x17_8018, -0x513d);                /* call 0x8018 */
            ii(0x17_d155, 1); pushw(ax);                                /* push ax */
            ii(0x17_d156, 1); pushw(cs);                                /* push cs */
            ii(0x17_d157, 3); callw(0x17_d54f, 0x3f5);                  /* call 0xd54f */
            ii(0x17_d15a, 1); retw(); return;                           /* ret */
        }
    }
}
