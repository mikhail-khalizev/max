using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x6012-d87a1d1d")]
        public void Method_0000_6012()
        {
            ii(0x6012, 1);    pushw(bp);                                /* push bp */
            ii(0x6013, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x6015, 1);    pushw(di);                                /* push di */
            ii(0x6016, 1);    pushw(si);                                /* push si */
            ii(0x6017, 5);    cmp(memw_a16[ds, 0xed6], 0);              /* cmp word [0xed6], 0x0 */
            ii(0x601c, 2);    if(jzw(0x6045, 0x27)) goto l_0x6045;      /* jz 0x6045 */
            ii(0x601e, 4);    les(bx, ds, 0xed4);                       /* les bx, [0xed4] */
            ii(0x6022, 4);    mov(si, memw_a16[es, bx + 0x2]);          /* mov si, [es:bx+0x2] */
            ii(0x6026, 2);    jmpw(0x6029, 0x1); goto l_0x6029;         /* jmp 0x6029 */
        l_0x6028:
            ii(0x6028, 1);    dec(si);                                  /* dec si */
        l_0x6029:
            ii(0x6029, 3);    cmp(si, 0x10);                            /* cmp si, 0x10 */
            ii(0x602c, 2);    if(jlw(0x6045, 0x17)) goto l_0x6045;      /* jl 0x6045 */
            ii(0x602e, 3);    mov(ax, memw_a16[ss, bp + 0x4]);          /* mov ax, [bp+0x4] */
            ii(0x6031, 2);    mov(di, si);                              /* mov di, si */
            ii(0x6033, 2);    shl(di, 0x1);                             /* shl di, 1 */
            ii(0x6035, 3);    cmp(memw_a16[es, bx + di], ax);           /* cmp [es:bx+di], ax */
            ii(0x6038, 2);    if(jnzw(0x6028, -0x12)) goto l_0x6028;    /* jnz 0x6028 */
            ii(0x603a, 2);    mov(ax, si);                              /* mov ax, si */
            ii(0x603c, 2);    mov(cl, 0x3);                             /* mov cl, 0x3 */
            ii(0x603e, 2);    shl(ax, cl);                              /* shl ax, cl */
            ii(0x6040, 3);    add(ax, memw_a16[es, bx]);                /* add ax, [es:bx] */
            ii(0x6043, 2);    jmpw(0x6047, 0x2); goto l_0x6047;         /* jmp 0x6047 */
        l_0x6045:
            ii(0x6045, 2);    sub(ax, ax);                              /* sub ax, ax */
        l_0x6047:
            ii(0x6047, 1);    popw(si);                                 /* pop si */
            ii(0x6048, 1);    popw(di);                                 /* pop di */
            ii(0x6049, 2);    mov(sp, bp);                              /* mov sp, bp */
            ii(0x604b, 1);    popw(bp);                                 /* pop bp */
            ii(0x604c, 1);    retw(); return;                           /* ret */
        }
    }
}