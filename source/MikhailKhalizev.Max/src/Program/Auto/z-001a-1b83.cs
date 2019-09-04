using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1a_1b83-1fc163f0")]
        public void Method_001a_1b83()
        {
            ii(0x1a_1b83, 1);  push(bp);                               /* push bp */
            ii(0x1a_1b84, 2);  mov(bp, sp);                            /* mov bp, sp */
            ii(0x1a_1b86, 1);  push(ds);                               /* push ds */
            ii(0x1a_1b87, 3);  mov(ax, 0xa8);                          /* mov ax, 0xa8 */
            ii(0x1a_1b8a, 2);  mov(ds, ax);                            /* mov ds, ax */
            ii(0x1a_1b8c, 3);  mov(ax, memw[ds, 0x3b1c]);              /* mov ax, [0x3b1c] */
            ii(0x1a_1b8f, 4);  or(ax, memw[ds, 0x3b1a]);               /* or ax, [0x3b1a] */
            ii(0x1a_1b93, 2);  if(jnz(0x1a_1ba6, 0x11)) goto l_0x1a_1ba6;/* jnz 0x1ba6 */
            ii(0x1a_1b95, 1);  push(ds);                               /* push ds */
            ii(0x1a_1b96, 3);  push(0x3b11);                           /* push 0x3b11 */
            ii(0x1a_1b99, 1);  push(cs);                               /* push cs */
            ii(0x1a_1b9a, 3);  call(0x1a_1b48, -0x55);                 /* call 0x1b48 */
            ii(0x1a_1b9d, 1);  pop(bx);                                /* pop bx */
            ii(0x1a_1b9e, 1);  pop(bx);                                /* pop bx */
            ii(0x1a_1b9f, 3);  mov(memw[ds, 0x3b1a], ax);              /* mov [0x3b1a], ax */
            ii(0x1a_1ba2, 4);  mov(memw[ds, 0x3b1c], dx);              /* mov [0x3b1c], dx */
        l_0x1a_1ba6:
            ii(0x1a_1ba6, 3);  mov(ax, memw[ds, 0x3b1c]);              /* mov ax, [0x3b1c] */
            ii(0x1a_1ba9, 4);  or(ax, memw[ds, 0x3b1a]);               /* or ax, [0x3b1a] */
            ii(0x1a_1bad, 2);  if(jnz(0x1a_1bb4, 5)) goto l_0x1a_1bb4; /* jnz 0x1bb4 */
            ii(0x1a_1baf, 3);  mov(ax, memw[ss, bp + 6]);              /* mov ax, [bp+0x6] */
            ii(0x1a_1bb2, 2);  jmp(0x1a_1bc7, 0x13); goto l_0x1a_1bc7; /* jmp 0x1bc7 */
        l_0x1a_1bb4:
            ii(0x1a_1bb4, 3);  push(memw[ss, bp + 14]);                /* push word [bp+0xe] */
            ii(0x1a_1bb7, 3);  push(memw[ss, bp + 12]);                /* push word [bp+0xc] */
            ii(0x1a_1bba, 3);  push(memw[ss, bp + 10]);                /* push word [bp+0xa] */
            ii(0x1a_1bbd, 3);  push(memw[ss, bp + 8]);                 /* push word [bp+0x8] */
            ii(0x1a_1bc0, 3);  push(memw[ss, bp + 6]);                 /* push word [bp+0x6] */
            ii(0x1a_1bc3, 4);  call_far_ind(memw[ds, 0x3b1a]);         /* call far word [0x3b1a] */
        l_0x1a_1bc7:
            ii(0x1a_1bc7, 1);  pop(ds);                                /* pop ds */
            ii(0x1a_1bc8, 1);  leave();                                /* leave */
            ii(0x1a_1bc9, 3);  retf(0xa);                              /* retf 0xa */
        }
    }
}
