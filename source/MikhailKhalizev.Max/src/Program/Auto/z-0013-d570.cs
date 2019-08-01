using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("bd54d3f1-92fc-4270-a893-bdaa1069ba47")]
        public void Method_0013_d570()
        {
            ii(0x13_d570, 1); pushw(cx);                                /* push cx */
            ii(0x13_d571, 2); or(cl, cl);                               /* or cl, cl */
            ii(0x13_d573, 2); if(jnzw(0x13_d593, 0x1e)) goto l_0x13_d593; /* jnz 0xd593 */
            ii(0x13_d575, 3); mov(si, 0x1ee8);                          /* mov si, 0x1ee8 */
            ii(0x13_d578, 3); mov(di, 0x1ee8);                          /* mov di, 0x1ee8 */
            ii(0x13_d57b, 3); callw(0x13_d5ff, 0x81);                   /* call 0xd5ff */
            ii(0x13_d57e, 3); mov(si, 0x1dc8);                          /* mov si, 0x1dc8 */
            ii(0x13_d581, 3); mov(di, 0x1dc8);                          /* mov di, 0x1dc8 */
            ii(0x13_d584, 3); callw(0x13_d5ff, 0x78);                   /* call 0xd5ff */
            ii(0x13_d587, 6); cmp(memw_a16[ds, 0x1dac], 0xd6d6);        /* cmp word [0x1dac], 0xd6d6 */
            ii(0x13_d58d, 2); if(jnzw(0x13_d593, 0x4)) goto l_0x13_d593; /* jnz 0xd593 */
            ii(0x13_d58f, 4); callw_abs(memw_a16[ds, 0x1db2]);          /* call word [0x1db2] */
        l_0x13_d593:
            ii(0x13_d593, 3); mov(si, 0x1dc8);                          /* mov si, 0x1dc8 */
            ii(0x13_d596, 3); mov(di, 0x1dc8);                          /* mov di, 0x1dc8 */
            ii(0x13_d599, 3); callw(0x13_d5ff, 0x63);                   /* call 0xd5ff */
            ii(0x13_d59c, 3); mov(si, 0x1dc8);                          /* mov si, 0x1dc8 */
            ii(0x13_d59f, 3); mov(di, 0x1dc8);                          /* mov di, 0x1dc8 */
            ii(0x13_d5a2, 3); callw(0x13_d5ff, 0x5a);                   /* call 0xd5ff */
            ii(0x13_d5a5, 1); nop();                                    /* nop */
            ii(0x13_d5a6, 1); pushw(cs);                                /* push cs */
            ii(0x13_d5a7, 3); callw(0x13_e20f, 0xc65);                  /* call 0xe20f */
            ii(0x13_d5aa, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x13_d5ac, 2); if(jzw(0x13_d5bf, 0x11)) goto l_0x13_d5bf; /* jz 0xd5bf */
            ii(0x13_d5ae, 1); popw(ax);                                 /* pop ax */
            ii(0x13_d5af, 2); or(ah, ah);                               /* or ah, ah */
            ii(0x13_d5b1, 1); pushw(ax);                                /* push ax */
            ii(0x13_d5b2, 2); if(jnzw(0x13_d5bf, 0xb)) goto l_0x13_d5bf; /* jnz 0xd5bf */
            ii(0x13_d5b4, 4); cmp(memw_a16[ss, bp + 0x6], 0);           /* cmp word [bp+0x6], 0x0 */
            ii(0x13_d5b8, 2); if(jnzw(0x13_d5bf, 0x5)) goto l_0x13_d5bf; /* jnz 0xd5bf */
            ii(0x13_d5ba, 5); mov(memw_a16[ss, bp + 0x6], 0xff);        /* mov word [bp+0x6], 0xff */
        l_0x13_d5bf:
            ii(0x13_d5bf, 3); callw(0x13_d5d2, 0x10);                   /* call 0xd5d2 */
            ii(0x13_d5c2, 1); popw(ax);                                 /* pop ax */
            ii(0x13_d5c3, 2); or(ah, ah);                               /* or ah, ah */
            ii(0x13_d5c5, 2); if(jnzw(0x13_d5ce, 0x7)) goto l_0x13_d5ce; /* jnz 0xd5ce */
            ii(0x13_d5c7, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x13_d5ca, 2); mov(ah, 0x4c);                            /* mov ah, 0x4c */
            ii(0x13_d5cc, 2); @int(0x21);                               /* int 0x21 */
        l_0x13_d5ce:
            ii(0x13_d5ce, 1); popw(di);                                 /* pop di */
            ii(0x13_d5cf, 1); popw(si);                                 /* pop si */
            ii(0x13_d5d0, 1); popw(bp);                                 /* pop bp */
            ii(0x13_d5d1, 1); retfw(); return;                          /* retf */
        }
    }
}
