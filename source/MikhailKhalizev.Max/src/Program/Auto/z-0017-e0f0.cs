using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_e0f0-e3c6b8ff")]
        public void Method_0017_e0f0()
        {
            ii(0x17_e0f0, 1);  push(bp);                               /* push bp */
            ii(0x17_e0f1, 2);  mov(bp, sp);                            /* mov bp, sp */
            ii(0x17_e0f3, 2);  mov(cx, ds);                            /* mov cx, ds */
            ii(0x17_e0f5, 3);  lds(bx, memw[ss, bp + 6]);              /* lds bx, [bp+0x6] */
            ii(0x17_e0f8, 2);  mov(dx, bx);                            /* mov dx, bx */
            ii(0x17_e0fa, 2);  jmp(0x17_e107, 0xb); goto l_0x17_e107;  /* jmp 0xe107 */
        l_0x17_e0fc:
            ii(0x17_e0fc, 2);  sub(al, 0x61);                          /* sub al, 0x61 */
            ii(0x17_e0fe, 2);  cmp(al, 0x1a);                          /* cmp al, 0x1a */
            ii(0x17_e100, 2);  if(jae(0x17_e106, 4)) goto l_0x17_e106; /* jae 0xe106 */
            ii(0x17_e102, 2);  add(al, 0x41);                          /* add al, 0x41 */
            ii(0x17_e104, 2);  mov(memb[ds, bx], al);                  /* mov [bx], al */
        l_0x17_e106:
            ii(0x17_e106, 1);  inc(bx);                                /* inc bx */
        l_0x17_e107:
            ii(0x17_e107, 2);  mov(al, memb[ds, bx]);                  /* mov al, [bx] */
            ii(0x17_e109, 2);  or(al, al);                             /* or al, al */
            ii(0x17_e10b, 2);  if(jnz(0x17_e0fc, -0x11)) goto l_0x17_e0fc;/* jnz 0xe0fc */
            ii(0x17_e10d, 1);  xchg(dx, ax);                           /* xchg dx, ax */
            ii(0x17_e10e, 2);  mov(dx, ds);                            /* mov dx, ds */
            ii(0x17_e110, 2);  mov(ds, cx);                            /* mov ds, cx */
            ii(0x17_e112, 1);  pop(bp);                                /* pop bp */
            ii(0x17_e113, 1);  retf();                                 /* retf */
        }
    }
}
