using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("f7471e6f-aa6f-45ac-b345-d0c2c5aa58b6")]
        public void Method_0015_3b80()
        {
            ii(0x15_3b80, 1); pushw(bp);                                /* push bp */
            ii(0x15_3b81, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x15_3b83, 1); pushw(di);                                /* push di */
            ii(0x15_3b84, 1); pushw(si);                                /* push si */
            ii(0x15_3b85, 1); pushw(ds);                                /* push ds */
            ii(0x15_3b86, 3); mov(cx, memw_a16[ss, bp + 0xe]);          /* mov cx, [bp+0xe] */
            ii(0x15_3b89, 2); if(jcxzw(0x15_3bb2, 0x27)) goto l_0x15_3bb2; /* jcxz 0x3bb2 */
            ii(0x15_3b8b, 2); mov(bx, cx);                              /* mov bx, cx */
            ii(0x15_3b8d, 3); les(di, ss, bp + 0x6);                    /* les di, [bp+0x6] */
            ii(0x15_3b90, 2); mov(si, di);                              /* mov si, di */
            ii(0x15_3b92, 2); xor(ax, ax);                              /* xor ax, ax */
            ii(0x15_3b94, 2); repne_a16(() => scasb_a16());             /* repne scasb */
            ii(0x15_3b96, 2); neg(cx);                                  /* neg cx */
            ii(0x15_3b98, 2); add(cx, bx);                              /* add cx, bx */
            ii(0x15_3b9a, 2); mov(di, si);                              /* mov di, si */
            ii(0x15_3b9c, 3); lds(si, ss, bp + 0xa);                    /* lds si, [bp+0xa] */
            ii(0x15_3b9f, 2); repe_a16(() => cmpsb_a16());              /* repe cmpsb */
            ii(0x15_3ba1, 3); mov(al, memb_a16[ds, si - 0x1]);          /* mov al, [si-0x1] */
            ii(0x15_3ba4, 2); xor(cx, cx);                              /* xor cx, cx */
            ii(0x15_3ba6, 4); cmp(al, memb_a16[es, di - 0x1]);          /* cmp al, [es:di-0x1] */
            ii(0x15_3baa, 2); if(jaw(0x15_3bb0, 0x4)) goto l_0x15_3bb0; /* ja 0x3bb0 */
            ii(0x15_3bac, 2); if(jzw(0x15_3bb2, 0x4)) goto l_0x15_3bb2; /* jz 0x3bb2 */
            ii(0x15_3bae, 1); dec(cx);                                  /* dec cx */
            ii(0x15_3baf, 1); dec(cx);                                  /* dec cx */
        l_0x15_3bb0:
            ii(0x15_3bb0, 2); not(cx);                                  /* not cx */
        l_0x15_3bb2:
            ii(0x15_3bb2, 2); mov(ax, cx);                              /* mov ax, cx */
            ii(0x15_3bb4, 1); popw(ds);                                 /* pop ds */
            ii(0x15_3bb5, 1); popw(si);                                 /* pop si */
            ii(0x15_3bb6, 1); popw(di);                                 /* pop di */
            ii(0x15_3bb7, 2); mov(sp, bp);                              /* mov sp, bp */
            ii(0x15_3bb9, 1); popw(bp);                                 /* pop bp */
            ii(0x15_3bba, 1); retfw(); return;                          /* retf */
        }
    }
}
