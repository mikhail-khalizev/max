using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_2163-32196aaa")]
        public void Method_0019_2163()
        {
            ii(0x19_2163, 2); mov(ah, 0x30);                            /* mov ah, 0x30 */
            ii(0x19_2165, 2); @int(0x21);                               /* int 0x21 */
            ii(0x19_2167, 2); cmp(al, 2);                               /* cmp al, 0x2 */
            ii(0x19_2169, 2); if(jae(0x19_2170, 5)) goto l_0x19_2170;   /* jae 0x2170 */
            ii(0x19_216b, 2); xor(ax, ax);                              /* xor ax, ax */
            ii(0x19_216d, 1); push(es);                                 /* push es */
            ii(0x19_216e, 1); push(ax);                                 /* push ax */
            ii(0x19_216f, 1); retf(); return;                           /* retf */
        l_0x19_2170:
            ii(0x19_2170, 3); mov(di, 0xa8);                            /* mov di, 0xa8 */
            ii(0x19_2173, 2); mov(ax, di);                              /* mov ax, di */
            ii(0x19_2175, 3); lsl(ax, ax);                              /* lsl ax, ax */
            ii(0x19_2178, 4); mov(memw[ss, 0x3b96], ax);                /* mov [ss:0x3b96], ax */
            ii(0x19_217c, 3); mov(bx, 0x3b98);                          /* mov bx, 0x3b98 */
            ii(0x19_217f, 3); mov(memw[ss, bx], ss);                    /* mov [ss:bx], ss */
            ii(0x19_2182, 3); and(sp, -2 /* 0xfe */);                   /* and sp, 0xfffe */
            ii(0x19_2185, 4); mov(memw[ss, bx + 4], sp);                /* mov [ss:bx+0x4], sp */
            ii(0x19_2189, 3); mov(ax, 0xfffe);                          /* mov ax, 0xfffe */
            ii(0x19_218c, 1); push(ax);                                 /* push ax */
            ii(0x19_218d, 4); mov(memw[ss, bx + 0xa], sp);              /* mov [ss:bx+0xa], sp */
            ii(0x19_2191, 2); not(ax);                                  /* not ax */
            ii(0x19_2193, 1); push(ax);                                 /* push ax */
            ii(0x19_2194, 4); mov(memw[ss, bx + 6], sp);                /* mov [ss:bx+0x6], sp */
            ii(0x19_2198, 4); mov(memw[ss, bx + 8], sp);                /* mov [ss:bx+0x8], sp */
            ii(0x19_219c, 5); mov(memw[ss, 0x3b92], sp);                /* mov [ss:0x3b92], sp */
            ii(0x19_21a1, 2); add(si, di);                              /* add si, di */
            ii(0x19_21a3, 5); mov(memw[ss, 0x3c18], ds);                /* mov [ss:0x3c18], ds */
            ii(0x19_21a8, 1); push(ss);                                 /* push ss */
            ii(0x19_21a9, 1); pop(es);                                  /* pop es */
            ii(0x19_21aa, 1); cld();                                    /* cld */
            ii(0x19_21ab, 3); mov(di, 0x40ac);                          /* mov di, 0x40ac */
            ii(0x19_21ae, 3); mov(cx, 0x4b50);                          /* mov cx, 0x4b50 */
            ii(0x19_21b1, 2); sub(cx, di);                              /* sub cx, di */
            ii(0x19_21b3, 2); xor(ax, ax);                              /* xor ax, ax */
            ii(0x19_21b5, 2); rep(() => stosb());                       /* rep stosb */
            ii(0x19_21b7, 1); push(ss);                                 /* push ss */
            ii(0x19_21b8, 1); pop(ds);                                  /* pop ds */
            ii(0x19_21b9, 4); mov(cx, memw[ds, 0x3f66]);                /* mov cx, [0x3f66] */
            ii(0x19_21bd, 2); if(jcxz(0x19_21c1, 2)) goto l_0x19_21c1;  /* jcxz 0x21c1 */
            ii(0x19_21bf, 2); call_abs(cx);                             /* call cx */
        l_0x19_21c1:
            ii(0x19_21c1, 1); nop();                                    /* nop */
            ii(0x19_21c2, 1); push(cs);                                 /* push cs */
            ii(0x19_21c3, 3); call(0x19_2bc2, 0x9fc);                   /* call 0x2bc2 */
            ii(0x19_21c6, 1); nop();                                    /* nop */
            ii(0x19_21c7, 1); push(cs);                                 /* push cs */
            ii(0x19_21c8, 3); call(0x19_2a14, 0x849);                   /* call 0x2a14 */
            ii(0x19_21cb, 2); xor(bp, bp);                              /* xor bp, bp */
            ii(0x19_21cd, 1); nop();                                    /* nop */
            ii(0x19_21ce, 1); push(cs);                                 /* push cs */
            ii(0x19_21cf, 3); call(0x19_286a, 0x698);                   /* call 0x286a */
            ii(0x19_21d2, 1); push(ss);                                 /* push ss */
            ii(0x19_21d3, 1); pop(ds);                                  /* pop ds */
            ii(0x19_21d4, 4); push(memw[ds, 0x3c3d]);                   /* push word [0x3c3d] */
            ii(0x19_21d8, 4); push(memw[ds, 0x3c3b]);                   /* push word [0x3c3b] */
            ii(0x19_21dc, 4); push(memw[ds, 0x3c39]);                   /* push word [0x3c39] */
            ii(0x19_21e0, 4); push(memw[ds, 0x3c37]);                   /* push word [0x3c37] */
            ii(0x19_21e4, 4); push(memw[ds, 0x3c35]);                   /* push word [0x3c35] */
            ii(0x19_21e8, 5); call_far_abs(0x88, 0x1fa);                /* call word 0x88:0x1fa */
            ii(0x19_21ed, 1); push(ax);                                 /* push ax */
            ii(0x19_21ee, 1); push(cs);                                 /* push cs */
            ii(0x19_21ef, 3); call(0x19_292f, 0x73d);                   /* call 0x292f */
            ii(0x19_21f2, 1); ret();                                    /* ret */
        }
    }
}
