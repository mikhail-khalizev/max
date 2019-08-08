using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("d297b6c6-e00c-4974-8a29-81ff3fe1800d")]
        public void Method_0015_389a()
        {
            ii(0x15_389a, 1); pushw(bp);                                /* push bp */
            ii(0x15_389b, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x15_389d, 1); pushw(di);                                /* push di */
            ii(0x15_389e, 3); les(di, ss, bp + 0x6);                    /* les di, [bp+0x6] */
            ii(0x15_38a1, 2); mov(bx, di);                              /* mov bx, di */
            ii(0x15_38a3, 2); xor(ax, ax);                              /* xor ax, ax */
            ii(0x15_38a5, 3); mov(cx, 0xffff);                          /* mov cx, 0xffff */
            ii(0x15_38a8, 2); repne_a16(() => scasb_a16());             /* repne scasb */
            ii(0x15_38aa, 1); inc(cx);                                  /* inc cx */
            ii(0x15_38ab, 2); neg(cx);                                  /* neg cx */
            ii(0x15_38ad, 3); mov(al, memb_a16[ss, bp + 0xa]);          /* mov al, [bp+0xa] */
            ii(0x15_38b0, 2); mov(di, bx);                              /* mov di, bx */
            ii(0x15_38b2, 2); repne_a16(() => scasb_a16());             /* repne scasb */
            ii(0x15_38b4, 1); dec(di);                                  /* dec di */
            ii(0x15_38b5, 3); cmp(memb_a16[es, di], al);                /* cmp [es:di], al */
            ii(0x15_38b8, 2); if(jzw(0x15_38be, 0x4)) goto l_0x15_38be; /* jz 0x38be */
            ii(0x15_38ba, 2); xor(di, di);                              /* xor di, di */
            ii(0x15_38bc, 2); mov(es, di);                              /* mov es, di */
        l_0x15_38be:
            ii(0x15_38be, 2); mov(ax, di);                              /* mov ax, di */
            ii(0x15_38c0, 2); mov(dx, es);                              /* mov dx, es */
            ii(0x15_38c2, 1); popw(di);                                 /* pop di */
            ii(0x15_38c3, 2); mov(sp, bp);                              /* mov sp, bp */
            ii(0x15_38c5, 1); popw(bp);                                 /* pop bp */
            ii(0x15_38c6, 1); retfw(); return;                          /* retf */
        }
    }
}