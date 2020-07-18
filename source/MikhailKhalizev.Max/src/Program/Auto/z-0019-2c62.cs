using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_2c62-fb3528f7")]
        public void Method_0019_2c62()
        {
            ii(0x19_2c62, 1);  push(bp);                               /* push bp */
            ii(0x19_2c63, 2);  mov(bp, sp);                            /* mov bp, sp */
            ii(0x19_2c65, 1);  push(si);                               /* push si */
            ii(0x19_2c66, 1);  push(di);                               /* push di */
            ii(0x19_2c67, 1);  push(ds);                               /* push ds */
            ii(0x19_2c68, 1);  pop(es);                                /* pop es */
            ii(0x19_2c69, 3);  mov(dx, memw[ss, bp + 6]);              /* mov dx, [bp+0x6] */
            ii(0x19_2c6c, 3);  mov(si, 0x3ff8);                        /* mov si, 0x3ff8 */
        l_0x19_2c6f:
            ii(0x19_2c6f, 1);  lodsw();                                /* lodsw */
            ii(0x19_2c70, 2);  cmp(ax, dx);                            /* cmp ax, dx */
            ii(0x19_2c72, 2);  if(jz(0x19_2c84, 0x10)) goto l_0x19_2c84;/* jz 0x2c84 */
            ii(0x19_2c74, 1);  inc(ax);                                /* inc ax */
            ii(0x19_2c75, 1);  xchg(si, ax);                           /* xchg si, ax */
            ii(0x19_2c76, 2);  if(jz(0x19_2c84, 0xc)) goto l_0x19_2c84;/* jz 0x2c84 */
            ii(0x19_2c78, 1);  xchg(di, ax);                           /* xchg di, ax */
            ii(0x19_2c79, 2);  xor(ax, ax);                            /* xor ax, ax */
            ii(0x19_2c7b, 3);  mov(cx, 0xffff);                        /* mov cx, 0xffff */
            ii(0x19_2c7e, 2);  repne(() => scasb());                   /* repne scasb */
            ii(0x19_2c80, 2);  mov(si, di);                            /* mov si, di */
            ii(0x19_2c82, 2);  jmp(0x19_2c6f, -0x15); goto l_0x19_2c6f;/* jmp 0x2c6f */
        l_0x19_2c84:
            ii(0x19_2c84, 1);  xchg(si, ax);                           /* xchg si, ax */
            ii(0x19_2c85, 1);  pop(di);                                /* pop di */
            ii(0x19_2c86, 1);  pop(si);                                /* pop si */
            ii(0x19_2c87, 2);  mov(sp, bp);                            /* mov sp, bp */
            ii(0x19_2c89, 1);  pop(bp);                                /* pop bp */
            ii(0x19_2c8a, 3);  retf(2);                                /* retf 0x2 */
        }
    }
}
