using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_d9ca-a2001a89")]
        public void Method_0018_d9ca()
        {
            ii(0x18_d9ca, 1);  push(bp);                               /* push bp */
            ii(0x18_d9cb, 2);  mov(bp, sp);                            /* mov bp, sp */
            ii(0x18_d9cd, 1);  push(si);                               /* push si */
            ii(0x18_d9ce, 1);  push(di);                               /* push di */
            ii(0x18_d9cf, 1);  push(ds);                               /* push ds */
            ii(0x18_d9d0, 3);  call(0x18_db82, 0x1af);                 /* call 0xdb82 */
            ii(0x18_d9d3, 2);  xor(si, si);                            /* xor si, si */
            ii(0x18_d9d5, 2);  xor(di, di);                            /* xor di, di */
            ii(0x18_d9d7, 3);  lsl(cx, bx);                            /* lsl cx, bx */
            ii(0x18_d9da, 2);  if(jcxz(0x18_da01, 0x25)) goto l_0x18_da01;/* jcxz 0xda01 */
            ii(0x18_d9dc, 1);  push(ds);                               /* push ds */
            ii(0x18_d9dd, 1);  pop(es);                                /* pop es */
            ii(0x18_d9de, 1);  push(bx);                               /* push bx */
            ii(0x18_d9df, 1);  pop(ds);                                /* pop ds */
            ii(0x18_d9e0, 3);  add(cx, 1);                             /* add cx, 0x1 */
            ii(0x18_d9e3, 2);  rcr(cx, 1);                             /* rcr cx, 1 */
            ii(0x18_d9e5, 1);  cld();                                  /* cld */
            ii(0x18_d9e6, 2);  rep(() => movsw());                     /* rep movsw */
            ii(0x18_d9e8, 2);  if(jae(0x18_d9eb, 1)) goto l_0x18_d9eb; /* jae 0xd9eb */
            ii(0x18_d9ea, 1);  movsb();                                /* movsb */
        l_0x18_d9eb:
            ii(0x18_d9eb, 2);  mov(bx, ss);                            /* mov bx, ss */
            ii(0x18_d9ed, 3);  cmp(bx, memw[ss, bp + 8]);              /* cmp bx, [bp+0x8] */
            ii(0x18_d9f0, 2);  if(jnz(0x18_da01, 0xf)) goto l_0x18_da01;/* jnz 0xda01 */
            ii(0x18_d9f2, 3);  mov(cx, memw[ss, bp + 6]);              /* mov cx, [bp+0x6] */
            ii(0x18_d9f5, 3);  mov(dx, memw[ss, bp + 4]);              /* mov dx, [bp+0x4] */
            ii(0x18_d9f8, 3);  mov(ax, 6);                             /* mov ax, 0x6 */
            ii(0x18_d9fb, 1);  push(cs);                               /* push cs */
            ii(0x18_d9fc, 3);  call(0x18_a3b9, -0x3646);               /* call 0xa3b9 */
            ii(0x18_d9ff, 1);  push(ss);                               /* push ss */
            ii(0x18_da00, 1);  pop(ss);                                /* pop ss */
        l_0x18_da01:
            ii(0x18_da01, 1);  pop(ds);                                /* pop ds */
            ii(0x18_da02, 1);  pop(di);                                /* pop di */
            ii(0x18_da03, 1);  pop(si);                                /* pop si */
            ii(0x18_da04, 1);  pop(bp);                                /* pop bp */
            ii(0x18_da05, 1);  ret();                                  /* ret */
        }
    }
}
