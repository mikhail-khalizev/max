using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x973a-919acae4")]
        public void Method_0000_973a()
        {
            ii(0x973a, 1);  push(bp);                                  /* push bp */
            ii(0x973b, 2);  mov(bp, sp);                               /* mov bp, sp */
            ii(0x973d, 3);  sub(sp, 2);                                /* sub sp, 0x2 */
            ii(0x9740, 1);  push(si);                                  /* push si */
            ii(0x9741, 1);  push(di);                                  /* push di */
            ii(0x9742, 1);  push(ds);                                  /* push ds */
            ii(0x9743, 1);  pop(es);                                   /* pop es */
            ii(0x9744, 3);  mov(di, memw[ss, bp + 6]);                 /* mov di, [bp+0x6] */
            ii(0x9747, 2);  xor(ax, ax);                               /* xor ax, ax */
            ii(0x9749, 3);  mov(cx, 0xffff);                           /* mov cx, 0xffff */
            ii(0x974c, 2);  repne(() => scasb());                      /* repne scasb */
            ii(0x974e, 2);  not(cx);                                   /* not cx */
            ii(0x9750, 1);  dec(cx);                                   /* dec cx */
            ii(0x9751, 2);  if(jcxz(0x978d, 0x3a)) goto l_0x978d;      /* jcxz 0x978d */
            ii(0x9753, 1);  dec(cx);                                   /* dec cx */
            ii(0x9754, 3);  mov(memw[ss, bp - 2], cx);                 /* mov [bp-0x2], cx */
            ii(0x9757, 3);  mov(di, memw[ss, bp + 4]);                 /* mov di, [bp+0x4] */
            ii(0x975a, 2);  mov(bx, di);                               /* mov bx, di */
            ii(0x975c, 2);  xor(ax, ax);                               /* xor ax, ax */
            ii(0x975e, 3);  mov(cx, 0xffff);                           /* mov cx, 0xffff */
            ii(0x9761, 2);  repne(() => scasb());                      /* repne scasb */
            ii(0x9763, 2);  not(cx);                                   /* not cx */
            ii(0x9765, 1);  dec(cx);                                   /* dec cx */
            ii(0x9766, 2);  mov(dx, cx);                               /* mov dx, cx */
            ii(0x9768, 3);  sub(dx, memw[ss, bp - 2]);                 /* sub dx, [bp-0x2] */
            ii(0x976b, 2);  if(jbe(0x9792, 0x25)) goto l_0x9792;       /* jbe 0x9792 */
            ii(0x976d, 2);  mov(di, bx);                               /* mov di, bx */
        l_0x976f:
            ii(0x976f, 3);  mov(si, memw[ss, bp + 6]);                 /* mov si, [bp+0x6] */
            ii(0x9772, 1);  lodsb();                                   /* lodsb */
            ii(0x9773, 2);  mov(di, bx);                               /* mov di, bx */
            ii(0x9775, 2);  mov(cx, dx);                               /* mov cx, dx */
            ii(0x9777, 2);  repne(() => scasb());                      /* repne scasb */
            ii(0x9779, 2);  if(jnz(0x9792, 0x17)) goto l_0x9792;       /* jnz 0x9792 */
            ii(0x977b, 2);  mov(dx, cx);                               /* mov dx, cx */
            ii(0x977d, 2);  mov(bx, di);                               /* mov bx, di */
            ii(0x977f, 3);  mov(cx, memw[ss, bp - 2]);                 /* mov cx, [bp-0x2] */
            ii(0x9782, 2);  if(jcxz(0x9788, 4)) goto l_0x9788;         /* jcxz 0x9788 */
            ii(0x9784, 2);  repe(() => cmpsb());                       /* repe cmpsb */
            ii(0x9786, 2);  if(jnz(0x976f, -0x19)) goto l_0x976f;      /* jnz 0x976f */
        l_0x9788:
            ii(0x9788, 3);  lea(ax, memw[ds, bx - 1]);                 /* lea ax, [bx-0x1] */
            ii(0x978b, 2);  jmp(0x9794, 7); goto l_0x9794;             /* jmp 0x9794 */
        l_0x978d:
            ii(0x978d, 3);  mov(ax, memw[ss, bp + 4]);                 /* mov ax, [bp+0x4] */
            ii(0x9790, 2);  jmp(0x9794, 2); goto l_0x9794;             /* jmp 0x9794 */
        l_0x9792:
            ii(0x9792, 2);  xor(ax, ax);                               /* xor ax, ax */
        l_0x9794:
            ii(0x9794, 1);  pop(di);                                   /* pop di */
            ii(0x9795, 1);  pop(si);                                   /* pop si */
            ii(0x9796, 2);  mov(sp, bp);                               /* mov sp, bp */
            ii(0x9798, 1);  pop(bp);                                   /* pop bp */
            ii(0x9799, 1);  ret();                                     /* ret */
        }
    }
}
