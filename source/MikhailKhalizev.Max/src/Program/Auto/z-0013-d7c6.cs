using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("83d7e452-c88c-4ed0-b473-66597c80ce03")]
        public void Method_0013_d7c6()
        {
            ii(0x13_d7c6, 1); pushw(bp);                                /* push bp */
            ii(0x13_d7c7, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x13_d7c9, 1); pushw(ds);                                /* push ds */
            ii(0x13_d7ca, 4); mov(es, memw_a16[ds, 0x1c54]);            /* mov es, [0x1c54] */
            ii(0x13_d7ce, 5); mov(bx, memw_a16[es, 0x2c]);              /* mov bx, [es:0x2c] */
            ii(0x13_d7d3, 2); mov(es, bx);                              /* mov es, bx */
            ii(0x13_d7d5, 2); xor(ax, ax);                              /* xor ax, ax */
            ii(0x13_d7d7, 2); xor(si, si);                              /* xor si, si */
            ii(0x13_d7d9, 2); xor(di, di);                              /* xor di, di */
            ii(0x13_d7db, 3); mov(cx, 0xffff);                          /* mov cx, 0xffff */
            ii(0x13_d7de, 2); or(bx, bx);                               /* or bx, bx */
            ii(0x13_d7e0, 2); if(jzw(0x13_d7f0, 0xe)) goto l_0x13_d7f0; /* jz 0xd7f0 */
            ii(0x13_d7e2, 6); cmp(memb_a16[es, 0], 0);                  /* cmp byte [es:0x0], 0x0 */
            ii(0x13_d7e8, 2); if(jzw(0x13_d7f0, 0x6)) goto l_0x13_d7f0; /* jz 0xd7f0 */
        l_0x13_d7ea:
            ii(0x13_d7ea, 2); repne_a16(() => scasb_a16());             /* repne scasb */
            ii(0x13_d7ec, 1); inc(si);                                  /* inc si */
            ii(0x13_d7ed, 1); scasb_a16();                              /* scasb */
            ii(0x13_d7ee, 2); if(jnzw(0x13_d7ea, -0x6)) goto l_0x13_d7ea; /* jnz 0xd7ea */
        l_0x13_d7f0:
            ii(0x13_d7f0, 2); mov(ax, di);                              /* mov ax, di */
            ii(0x13_d7f2, 1); inc(ax);                                  /* inc ax */
            ii(0x13_d7f3, 2); and(al, 0xfe);                            /* and al, 0xfe */
            ii(0x13_d7f5, 1); inc(si);                                  /* inc si */
            ii(0x13_d7f6, 2); mov(di, si);                              /* mov di, si */
            ii(0x13_d7f8, 2); shl(si, 0x1);                             /* shl si, 1 */
            ii(0x13_d7fa, 3); mov(cx, 0x9);                             /* mov cx, 0x9 */
            ii(0x13_d7fd, 3); callw(0x13_e23c, 0xa3c);                  /* call 0xe23c */
            ii(0x13_d800, 1); pushw(ax);                                /* push ax */
            ii(0x13_d801, 2); mov(ax, si);                              /* mov ax, si */
            ii(0x13_d803, 3); callw(0x13_e23c, 0xa36);                  /* call 0xe23c */
            ii(0x13_d806, 3); mov(memw_a16[ds, 0x1c75], ax);            /* mov [0x1c75], ax */
            ii(0x13_d809, 1); pushw(es);                                /* push es */
            ii(0x13_d80a, 1); pushw(ds);                                /* push ds */
            ii(0x13_d80b, 1); popw(es);                                 /* pop es */
            ii(0x13_d80c, 1); popw(ds);                                 /* pop ds */
            ii(0x13_d80d, 2); mov(cx, di);                              /* mov cx, di */
            ii(0x13_d80f, 2); mov(bx, ax);                              /* mov bx, ax */
            ii(0x13_d811, 2); xor(si, si);                              /* xor si, si */
            ii(0x13_d813, 1); popw(di);                                 /* pop di */
            ii(0x13_d814, 1); dec(cx);                                  /* dec cx */
            ii(0x13_d815, 2); if(jcxzw(0x13_d83d, 0x26)) goto l_0x13_d83d; /* jcxz 0xd83d */
        l_0x13_d817:
            ii(0x13_d817, 2); mov(ax, memw_a16[ds, si]);                /* mov ax, [si] */
            ii(0x13_d819, 5); cmp(ax, memw_a16[ss, 0x1c32]);            /* cmp ax, [ss:0x1c32] */
            ii(0x13_d81e, 2); if(jnzw(0x13_d830, 0x10)) goto l_0x13_d830; /* jnz 0xd830 */
            ii(0x13_d820, 1); pushw(cx);                                /* push cx */
            ii(0x13_d821, 1); pushw(si);                                /* push si */
            ii(0x13_d822, 1); pushw(di);                                /* push di */
            ii(0x13_d823, 3); mov(di, 0x1c32);                          /* mov di, 0x1c32 */
            ii(0x13_d826, 3); mov(cx, 0x6);                             /* mov cx, 0x6 */
            ii(0x13_d829, 2); repe_a16(() => cmpsw_a16());              /* repe cmpsw */
            ii(0x13_d82b, 1); popw(di);                                 /* pop di */
            ii(0x13_d82c, 1); popw(si);                                 /* pop si */
            ii(0x13_d82d, 1); popw(cx);                                 /* pop cx */
            ii(0x13_d82e, 2); if(jzw(0x13_d835, 0x5)) goto l_0x13_d835; /* jz 0xd835 */
        l_0x13_d830:
            ii(0x13_d830, 3); mov(memw_a16[es, bx], di);                /* mov [es:bx], di */
            ii(0x13_d833, 1); inc(bx);                                  /* inc bx */
            ii(0x13_d834, 1); inc(bx);                                  /* inc bx */
        l_0x13_d835:
            ii(0x13_d835, 1); lodsb_a16();                              /* lodsb */
            ii(0x13_d836, 1); stosb_a16();                              /* stosb */
            ii(0x13_d837, 2); or(al, al);                               /* or al, al */
            ii(0x13_d839, 2); if(jnzw(0x13_d835, -0x6)) goto l_0x13_d835; /* jnz 0xd835 */
            ii(0x13_d83b, 2); if(loopw_a16(0x13_d817, -0x26)) goto l_0x13_d817; /* loop 0xd817 */
        l_0x13_d83d:
            ii(0x13_d83d, 3); mov(memw_a16[es, bx], cx);                /* mov [es:bx], cx */
            ii(0x13_d840, 1); popw(ds);                                 /* pop ds */
            ii(0x13_d841, 1); popw(bp);                                 /* pop bp */
            ii(0x13_d842, 1); retfw(); return;                          /* retf */
        }
    }
}
