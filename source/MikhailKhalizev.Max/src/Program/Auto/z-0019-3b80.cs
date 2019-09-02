using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_3b80-fa903c54")]
        public void Method_0019_3b80()
        {
            ii(0x19_3b80, 1); push(bp);                                 /* push bp */
            ii(0x19_3b81, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x19_3b83, 1); push(di);                                 /* push di */
            ii(0x19_3b84, 1); push(si);                                 /* push si */
            ii(0x19_3b85, 1); push(ds);                                 /* push ds */
            ii(0x19_3b86, 3); mov(cx, memw[ss, bp + 0xe]);              /* mov cx, [bp+0xe] */
            ii(0x19_3b89, 2); if(jcxz(0x19_3bb2, 0x27)) goto l_0x19_3bb2; /* jcxz 0x3bb2 */
            ii(0x19_3b8b, 2); mov(bx, cx);                              /* mov bx, cx */
            ii(0x19_3b8d, 3); les(di, memw[ss, bp + 6]);                /* les di, [bp+0x6] */
            ii(0x19_3b90, 2); mov(si, di);                              /* mov si, di */
            ii(0x19_3b92, 2); xor(ax, ax);                              /* xor ax, ax */
            ii(0x19_3b94, 2); repne(() => scasb());                     /* repne scasb */
            ii(0x19_3b96, 2); neg(cx);                                  /* neg cx */
            ii(0x19_3b98, 2); add(cx, bx);                              /* add cx, bx */
            ii(0x19_3b9a, 2); mov(di, si);                              /* mov di, si */
            ii(0x19_3b9c, 3); lds(si, memw[ss, bp + 0xa]);              /* lds si, [bp+0xa] */
            ii(0x19_3b9f, 2); repe(() => cmpsb());                      /* repe cmpsb */
            ii(0x19_3ba1, 3); mov(al, memb[ds, si - 1]);                /* mov al, [si-0x1] */
            ii(0x19_3ba4, 2); xor(cx, cx);                              /* xor cx, cx */
            ii(0x19_3ba6, 4); cmp(al, memb[es, di - 1]);                /* cmp al, [es:di-0x1] */
            ii(0x19_3baa, 2); if(ja(0x19_3bb0, 4)) goto l_0x19_3bb0;    /* ja 0x3bb0 */
            ii(0x19_3bac, 2); if(jz(0x19_3bb2, 4)) goto l_0x19_3bb2;    /* jz 0x3bb2 */
            ii(0x19_3bae, 1); dec(cx);                                  /* dec cx */
            ii(0x19_3baf, 1); dec(cx);                                  /* dec cx */
        l_0x19_3bb0:
            ii(0x19_3bb0, 2); not(cx);                                  /* not cx */
        l_0x19_3bb2:
            ii(0x19_3bb2, 2); mov(ax, cx);                              /* mov ax, cx */
            ii(0x19_3bb4, 1); pop(ds);                                  /* pop ds */
            ii(0x19_3bb5, 1); pop(si);                                  /* pop si */
            ii(0x19_3bb6, 1); pop(di);                                  /* pop di */
            ii(0x19_3bb7, 2); mov(sp, bp);                              /* mov sp, bp */
            ii(0x19_3bb9, 1); pop(bp);                                  /* pop bp */
            ii(0x19_3bba, 1); retf();                                   /* retf */
        }
    }
}
