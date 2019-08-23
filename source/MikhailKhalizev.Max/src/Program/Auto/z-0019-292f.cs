using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_292f-eec9b88b")]
        public void Method_0019_292f()
        {
            ii(0x19_292f, 1); push(bp);                                 /* push bp */
            ii(0x19_2930, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x19_2932, 2); xor(cx, cx);                              /* xor cx, cx */
            ii(0x19_2934, 2); jmp(0x19_2950, 0x1a); goto l_0x19_2950;   /* jmp 0x2950 */
        //  ii(0x19_2936, 1); push(bp);                                 /* push bp */
        //  ii(0x19_2937, 2); mov(bp, sp);                              /* mov bp, sp */
        //  ii(0x19_2939, 3); mov(cx, 0x1);                             /* mov cx, 0x1 */
        //  ii(0x19_293c, 2); jmp(0x19_2950, 0x12); goto l_0x19_2950;   /* jmp 0x2950 */
        //  ii(0x19_293e, 1); push(bp);                                 /* push bp */
        //  ii(0x19_293f, 2); mov(bp, sp);                              /* mov bp, sp */
        //  ii(0x19_2941, 1); push(si);                                 /* push si */
        //  ii(0x19_2942, 1); push(di);                                 /* push di */
        //  ii(0x19_2943, 3); mov(cx, 0x100);                           /* mov cx, 0x100 */
        //  ii(0x19_2946, 2); jmp(0x19_2950, 0x8); goto l_0x19_2950;    /* jmp 0x2950 */
        //  ii(0x19_2948, 1); push(bp);                                 /* push bp */
        //  ii(0x19_2949, 2); mov(bp, sp);                              /* mov bp, sp */
        //  ii(0x19_294b, 1); push(si);                                 /* push si */
        //  ii(0x19_294c, 1); push(di);                                 /* push di */
        //  ii(0x19_294d, 3); mov(cx, 0x101);                           /* mov cx, 0x101 */
        l_0x19_2950:
            ii(0x19_2950, 1); push(cx);                                 /* push cx */
            ii(0x19_2951, 2); or(cl, cl);                               /* or cl, cl */
            ii(0x19_2953, 2); if(jnz(0x19_2973, 0x1e)) goto l_0x19_2973; /* jnz 0x2973 */
            ii(0x19_2955, 3); mov(si, 0x494e);                          /* mov si, 0x494e */
            ii(0x19_2958, 3); mov(di, 0x494e);                          /* mov di, 0x494e */
            ii(0x19_295b, 3); call(0x19_29df, 0x81);                    /* call 0x29df */
            ii(0x19_295e, 3); mov(si, 0x3f84);                          /* mov si, 0x3f84 */
            ii(0x19_2961, 3); mov(di, 0x3f88);                          /* mov di, 0x3f88 */
            ii(0x19_2964, 3); call(0x19_29df, 0x78);                    /* call 0x29df */
            ii(0x19_2967, 6); cmp(memw[ds, 0x3f68], 0xd6d6);            /* cmp word [0x3f68], 0xd6d6 */
            ii(0x19_296d, 2); if(jnz(0x19_2973, 0x4)) goto l_0x19_2973; /* jnz 0x2973 */
            ii(0x19_296f, 4); call_abs(memw[ds, 0x3f6e]);               /* call word [0x3f6e] */
        l_0x19_2973:
            ii(0x19_2973, 3); mov(si, 0x3f88);                          /* mov si, 0x3f88 */
            ii(0x19_2976, 3); mov(di, 0x3f88);                          /* mov di, 0x3f88 */
            ii(0x19_2979, 3); call(0x19_29df, 0x63);                    /* call 0x29df */
            ii(0x19_297c, 3); mov(si, 0x3f88);                          /* mov si, 0x3f88 */
            ii(0x19_297f, 3); mov(di, 0x3f88);                          /* mov di, 0x3f88 */
            ii(0x19_2982, 3); call(0x19_29df, 0x5a);                    /* call 0x29df */
            ii(0x19_2985, 1); nop();                                    /* nop */
            ii(0x19_2986, 1); push(cs);                                 /* push cs */
            ii(0x19_2987, 3); call(0x19_2767, -0x223);                  /* call 0x2767 */
            ii(0x19_298a, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x19_298c, 2); if(jz(0x19_299f, 0x11)) goto l_0x19_299f; /* jz 0x299f */
            ii(0x19_298e, 1); pop(ax);                                  /* pop ax */
            ii(0x19_298f, 2); or(ah, ah);                               /* or ah, ah */
            ii(0x19_2991, 1); push(ax);                                 /* push ax */
            ii(0x19_2992, 2); if(jnz(0x19_299f, 0xb)) goto l_0x19_299f; /* jnz 0x299f */
            ii(0x19_2994, 4); cmp(memw[ss, bp + 0x6], 0);               /* cmp word [bp+0x6], 0x0 */
            ii(0x19_2998, 2); if(jnz(0x19_299f, 0x5)) goto l_0x19_299f; /* jnz 0x299f */
            ii(0x19_299a, 5); mov(memw[ss, bp + 0x6], 0xff);            /* mov word [bp+0x6], 0xff */
        l_0x19_299f:
            ii(0x19_299f, 3); call(0x19_29b2, 0x10);                    /* call 0x29b2 */
            ii(0x19_29a2, 1); pop(ax);                                  /* pop ax */
            ii(0x19_29a3, 2); or(ah, ah);                               /* or ah, ah */
            ii(0x19_29a5, 2); if(jnz(0x19_29ae, 0x7)) goto l_0x19_29ae; /* jnz 0x29ae */
            ii(0x19_29a7, 3); mov(ax, memw[ss, bp + 0x6]);              /* mov ax, [bp+0x6] */
            ii(0x19_29aa, 2); mov(ah, 0x4c);                            /* mov ah, 0x4c */
            ii(0x19_29ac, 2); @int(0x21);                               /* int 0x21 */
        l_0x19_29ae:
            ii(0x19_29ae, 1); pop(di);                                  /* pop di */
            ii(0x19_29af, 1); pop(si);                                  /* pop si */
            ii(0x19_29b0, 1); pop(bp);                                  /* pop bp */
            ii(0x19_29b1, 1); retf();                                   /* retf */
        }
    }
}
