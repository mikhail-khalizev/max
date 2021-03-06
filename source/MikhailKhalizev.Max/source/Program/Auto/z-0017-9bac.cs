using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_9bac-9ea29f5a")]
        public void Method_0017_9bac()
        {
            ii(0x17_9bac, 4);  enter(4, 0);                            /* enter 0x4, 0x0 */
            ii(0x17_9bb0, 1);  push(ds);                               /* push ds */
            ii(0x17_9bb1, 3);  mov(ax, 0x3e68);                        /* mov ax, 0x3e68 */
            ii(0x17_9bb4, 2);  mov(ds, ax);                            /* mov ds, ax */
            ii(0x17_9bb6, 3);  les(bx, memw[ss, bp + 6]);              /* les bx, [bp+0x6] */
            ii(0x17_9bb9, 5);  cmp(memw[es, bx + 8], 0);               /* cmp word [es:bx+0x8], 0x0 */
            ii(0x17_9bbe, 2);  if(jz(0x17_9bd4, 0x14)) goto l_0x17_9bd4;/* jz 0x9bd4 */
            ii(0x17_9bc0, 6);  mov(memw[es, bx + 32], 0x8023);         /* mov word [es:bx+0x20], 0x8023 */
            ii(0x17_9bc6, 6);  mov(memw[es, bx + 34], 0);              /* mov word [es:bx+0x22], 0x0 */
            ii(0x17_9bcc, 5);  or(memb[es, bx + 44], 1);               /* or byte [es:bx+0x2c], 0x1 */
            ii(0x17_9bd1, 1);  pop(ds);                                /* pop ds */
            ii(0x17_9bd2, 1);  leave();                                /* leave */
            ii(0x17_9bd3, 1);  retf(); return;                         /* retf */
        l_0x17_9bd4:
            ii(0x17_9bd4, 4);  mov(ax, memw[es, bx + 4]);              /* mov ax, [es:bx+0x4] */
            ii(0x17_9bd8, 3);  mov(memw[ss, bp - 4], ax);              /* mov [bp-0x4], ax */
            ii(0x17_9bdb, 1);  push(ax);                               /* push ax */
            ii(0x17_9bdc, 1);  push(cs);                               /* push cs */
            ii(0x17_9bdd, 3);  call(0x17_be16, 0x2236);                /* call 0xbe16 */
            ii(0x17_9be0, 3);  add(sp, 2);                             /* add sp, 0x2 */
            ii(0x17_9be3, 3);  mov(memw[ss, bp - 2], ax);              /* mov [bp-0x2], ax */
            ii(0x17_9be6, 2);  or(ax, ax);                             /* or ax, ax */
            ii(0x17_9be8, 2);  if(jz(0x17_9c02, 0x18)) goto l_0x17_9c02;/* jz 0x9c02 */
            ii(0x17_9bea, 3);  les(bx, memw[ss, bp + 6]);              /* les bx, [bp+0x6] */
            ii(0x17_9bed, 4);  mov(memw[es, bx + 32], ax);             /* mov [es:bx+0x20], ax */
            ii(0x17_9bf1, 6);  mov(memw[es, bx + 34], 0);              /* mov word [es:bx+0x22], 0x0 */
            ii(0x17_9bf7, 5);  or(memb[es, bx + 44], 1);               /* or byte [es:bx+0x2c], 0x1 */
            ii(0x17_9bfc, 1);  pop(ds);                                /* pop ds */
            ii(0x17_9bfd, 1);  leave();                                /* leave */
            ii(0x17_9bfe, 1);  retf(); return;                         /* retf */
        //  ii(0x17_9bff, 3);  Недостижимый код.
        l_0x17_9c02:
            ii(0x17_9c02, 3);  push(memw[ss, bp - 4]);                 /* push word [bp-0x4] */
            ii(0x17_9c05, 1);  push(cs);                               /* push cs */
            ii(0x17_9c06, 3);  call(0x17_c76a, 0x2b61);                /* call 0xc76a */
            ii(0x17_9c09, 3);  add(sp, 2);                             /* add sp, 0x2 */
            ii(0x17_9c0c, 3);  les(bx, memw[ss, bp + 6]);              /* les bx, [bp+0x6] */
            ii(0x17_9c0f, 5);  and(memb[es, bx + 44], -2 /* 0xfe */);  /* and byte [es:bx+0x2c], 0xfe */
            ii(0x17_9c14, 1);  pop(ds);                                /* pop ds */
            ii(0x17_9c15, 1);  leave();                                /* leave */
            ii(0x17_9c16, 1);  retf();                                 /* retf */
        }
    }
}
