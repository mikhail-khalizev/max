using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("03b17a84-354b-4be9-b5f8-8f758fd8d209")]
        public void Method_0015_2950()
        {
            ii(0x15_2950, 1); pushw(cx);                                /* push cx */
            ii(0x15_2951, 2); or(cl, cl);                               /* or cl, cl */
            ii(0x15_2953, 2); if(jnzw(0x15_2973, 0x1e)) goto l_0x15_2973; /* jnz 0x2973 */
            ii(0x15_2955, 3); mov(si, 0x494e);                          /* mov si, 0x494e */
            ii(0x15_2958, 3); mov(di, 0x494e);                          /* mov di, 0x494e */
            ii(0x15_295b, 3); callw(0x15_29df, 0x81);                   /* call 0x29df */
            ii(0x15_295e, 3); mov(si, 0x3f84);                          /* mov si, 0x3f84 */
            ii(0x15_2961, 3); mov(di, 0x3f88);                          /* mov di, 0x3f88 */
            ii(0x15_2964, 3); callw(0x15_29df, 0x78);                   /* call 0x29df */
            ii(0x15_2967, 6); cmp(memw_a16[ds, 0x3f68], 0xd6d6);        /* cmp word [0x3f68], 0xd6d6 */
            ii(0x15_296d, 2); if(jnzw(0x15_2973, 0x4)) goto l_0x15_2973; /* jnz 0x2973 */
            ii(0x15_296f, 4); callw_abs(memw_a16[ds, 0x3f6e]);          /* call word [0x3f6e] */
        l_0x15_2973:
            ii(0x15_2973, 3); mov(si, 0x3f88);                          /* mov si, 0x3f88 */
            ii(0x15_2976, 3); mov(di, 0x3f88);                          /* mov di, 0x3f88 */
            ii(0x15_2979, 3); callw(0x15_29df, 0x63);                   /* call 0x29df */
            ii(0x15_297c, 3); mov(si, 0x3f88);                          /* mov si, 0x3f88 */
            ii(0x15_297f, 3); mov(di, 0x3f88);                          /* mov di, 0x3f88 */
            ii(0x15_2982, 3); callw(0x15_29df, 0x5a);                   /* call 0x29df */
            ii(0x15_2985, 1); nop();                                    /* nop */
            ii(0x15_2986, 1); pushw(cs);                                /* push cs */
            ii(0x15_2987, 3); callw(0x15_2767, -0x223);                 /* call 0x2767 */
            ii(0x15_298a, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x15_298c, 2); if(jzw(0x15_299f, 0x11)) goto l_0x15_299f; /* jz 0x299f */
            ii(0x15_298e, 1); popw(ax);                                 /* pop ax */
            ii(0x15_298f, 2); or(ah, ah);                               /* or ah, ah */
            ii(0x15_2991, 1); pushw(ax);                                /* push ax */
            ii(0x15_2992, 2); if(jnzw(0x15_299f, 0xb)) goto l_0x15_299f; /* jnz 0x299f */
            ii(0x15_2994, 4); cmp(memw_a16[ss, bp + 0x6], 0);           /* cmp word [bp+0x6], 0x0 */
            ii(0x15_2998, 2); if(jnzw(0x15_299f, 0x5)) goto l_0x15_299f; /* jnz 0x299f */
            ii(0x15_299a, 5); mov(memw_a16[ss, bp + 0x6], 0xff);        /* mov word [bp+0x6], 0xff */
        l_0x15_299f:
            ii(0x15_299f, 3); callw(0x15_29b2, 0x10);                   /* call 0x29b2 */
            ii(0x15_29a2, 1); popw(ax);                                 /* pop ax */
            ii(0x15_29a3, 2); or(ah, ah);                               /* or ah, ah */
            ii(0x15_29a5, 2); if(jnzw(0x15_29ae, 0x7)) goto l_0x15_29ae; /* jnz 0x29ae */
            ii(0x15_29a7, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x15_29aa, 2); mov(ah, 0x4c);                            /* mov ah, 0x4c */
            ii(0x15_29ac, 2); @int(0x21);                               /* int 0x21 */
        l_0x15_29ae:
            ii(0x15_29ae, 1); popw(di);                                 /* pop di */
            ii(0x15_29af, 1); popw(si);                                 /* pop si */
            ii(0x15_29b0, 1); popw(bp);                                 /* pop bp */
            ii(0x15_29b1, 1); retfw(); return;                          /* retf */
        }
    }
}
