using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x6470-74b7bb39")]
        public void Method_0000_6470()
        {
            ii(0x6470, 1);  push(bp);                                  /* push bp */
            ii(0x6471, 2);  mov(bp, sp);                               /* mov bp, sp */
            ii(0x6473, 1);  push(si);                                  /* push si */
            ii(0x6474, 1);  push(di);                                  /* push di */
            ii(0x6475, 3);  mov(di, memw[ss, bp + 4]);                 /* mov di, [bp+0x4] */
            ii(0x6478, 2);  mov(ax, memw[ds, di]);                     /* mov ax, [di] */
            ii(0x647a, 3);  mov(bx, memw[ds, di + 2]);                 /* mov bx, [di+0x2] */
            ii(0x647d, 3);  mov(cx, memw[ds, di + 4]);                 /* mov cx, [di+0x4] */
            ii(0x6480, 3);  mov(dx, memw[ds, di + 6]);                 /* mov dx, [di+0x6] */
            ii(0x6483, 3);  mov(si, memw[ds, di + 8]);                 /* mov si, [di+0x8] */
            ii(0x6486, 3);  mov(di, memw[ds, di + 10]);                /* mov di, [di+0xa] */
            ii(0x6489, 2);  @int(0x21);                                /* int 0x21 */
            ii(0x648b, 1);  push(di);                                  /* push di */
            ii(0x648c, 3);  mov(di, memw[ss, bp + 6]);                 /* mov di, [bp+0x6] */
            ii(0x648f, 2);  mov(memw[ds, di], ax);                     /* mov [di], ax */
            ii(0x6491, 3);  mov(memw[ds, di + 2], bx);                 /* mov [di+0x2], bx */
            ii(0x6494, 3);  mov(memw[ds, di + 4], cx);                 /* mov [di+0x4], cx */
            ii(0x6497, 3);  mov(memw[ds, di + 6], dx);                 /* mov [di+0x6], dx */
            ii(0x649a, 3);  mov(memw[ds, di + 8], si);                 /* mov [di+0x8], si */
            ii(0x649d, 3);  pop(memw[ds, di + 10]);                    /* pop word [di+0xa] */
            ii(0x64a0, 2);  if(jb(0x64a6, 4)) goto l_0x64a6;           /* jb 0x64a6 */
            ii(0x64a2, 2);  xor(si, si);                               /* xor si, si */
            ii(0x64a4, 2);  jmp(0x64ae, 8); goto l_0x64ae;             /* jmp 0x64ae */
        l_0x64a6:
            ii(0x64a6, 3);  call(0x657e, 0xd5);                        /* call 0x657e */
            ii(0x64a9, 3);  mov(si, 1);                                /* mov si, 0x1 */
            ii(0x64ac, 2);  mov(ax, memw[ds, di]);                     /* mov ax, [di] */
        l_0x64ae:
            ii(0x64ae, 3);  mov(memw[ds, di + 12], si);                /* mov [di+0xc], si */
            ii(0x64b1, 1);  pop(di);                                   /* pop di */
            ii(0x64b2, 1);  pop(si);                                   /* pop si */
            ii(0x64b3, 2);  mov(sp, bp);                               /* mov sp, bp */
            ii(0x64b5, 1);  pop(bp);                                   /* pop bp */
            ii(0x64b6, 1);  ret();                                     /* ret */
        }
    }
}
