using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_389a-5f6b010a")]
        public void Method_0019_389a()
        {
            ii(0x19_389a, 1);  push(bp);                               /* push bp */
            ii(0x19_389b, 2);  mov(bp, sp);                            /* mov bp, sp */
            ii(0x19_389d, 1);  push(di);                               /* push di */
            ii(0x19_389e, 3);  les(di, memw[ss, bp + 6]);              /* les di, [bp+0x6] */
            ii(0x19_38a1, 2);  mov(bx, di);                            /* mov bx, di */
            ii(0x19_38a3, 2);  xor(ax, ax);                            /* xor ax, ax */
            ii(0x19_38a5, 3);  mov(cx, 0xffff);                        /* mov cx, 0xffff */
            ii(0x19_38a8, 2);  repne(() => scasb());                   /* repne scasb */
            ii(0x19_38aa, 1);  inc(cx);                                /* inc cx */
            ii(0x19_38ab, 2);  neg(cx);                                /* neg cx */
            ii(0x19_38ad, 3);  mov(al, memb[ss, bp + 10]);             /* mov al, [bp+0xa] */
            ii(0x19_38b0, 2);  mov(di, bx);                            /* mov di, bx */
            ii(0x19_38b2, 2);  repne(() => scasb());                   /* repne scasb */
            ii(0x19_38b4, 1);  dec(di);                                /* dec di */
            ii(0x19_38b5, 3);  cmp(memb[es, di], al);                  /* cmp [es:di], al */
            ii(0x19_38b8, 2);  if(jz(0x19_38be, 4)) goto l_0x19_38be;  /* jz 0x38be */
            ii(0x19_38ba, 2);  xor(di, di);                            /* xor di, di */
            ii(0x19_38bc, 2);  mov(es, di);                            /* mov es, di */
        l_0x19_38be:
            ii(0x19_38be, 2);  mov(ax, di);                            /* mov ax, di */
            ii(0x19_38c0, 2);  mov(dx, es);                            /* mov dx, es */
            ii(0x19_38c2, 1);  pop(di);                                /* pop di */
            ii(0x19_38c3, 2);  mov(sp, bp);                            /* mov sp, bp */
            ii(0x19_38c5, 1);  pop(bp);                                /* pop bp */
            ii(0x19_38c6, 1);  retf();                                 /* retf */
        }
    }
}
