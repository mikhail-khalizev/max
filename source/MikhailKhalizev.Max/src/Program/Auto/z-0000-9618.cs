using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x9618-bb3693ac")]
        public void Method_0000_9618()
        {
            ii(0x9618, 1);  push(bp);                                  /* push bp */
            ii(0x9619, 2);  mov(bp, sp);                               /* mov bp, sp */
            ii(0x961b, 2);  mov(dx, di);                               /* mov dx, di */
            ii(0x961d, 2);  mov(bx, si);                               /* mov bx, si */
            ii(0x961f, 2);  mov(ax, ds);                               /* mov ax, ds */
            ii(0x9621, 2);  mov(es, ax);                               /* mov es, ax */
            ii(0x9623, 3);  mov(si, memw[ss, bp + 4]);                 /* mov si, [bp+0x4] */
            ii(0x9626, 3);  mov(di, memw[ss, bp + 6]);                 /* mov di, [bp+0x6] */
            ii(0x9629, 2);  xor(ax, ax);                               /* xor ax, ax */
            ii(0x962b, 3);  mov(cx, 0xffff);                           /* mov cx, 0xffff */
            ii(0x962e, 2);  repne(() => scasb());                      /* repne scasb */
            ii(0x9630, 2);  not(cx);                                   /* not cx */
            ii(0x9632, 2);  sub(di, cx);                               /* sub di, cx */
            ii(0x9634, 2);  repe(() => cmpsb());                       /* repe cmpsb */
            ii(0x9636, 2);  if(jz(0x963d, 5)) goto l_0x963d;           /* jz 0x963d */
            ii(0x9638, 2);  sbb(ax, ax);                               /* sbb ax, ax */
            ii(0x963a, 3);  sbb(ax, 0xffff);                           /* sbb ax, 0xffff */
        l_0x963d:
            ii(0x963d, 2);  mov(si, bx);                               /* mov si, bx */
            ii(0x963f, 2);  mov(di, dx);                               /* mov di, dx */
            ii(0x9641, 1);  pop(bp);                                   /* pop bp */
            ii(0x9642, 1);  ret();                                     /* ret */
        }
    }
}
