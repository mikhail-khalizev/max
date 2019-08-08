using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("7a00c7c8-e333-41bd-9880-712973bb9746")]
        public void Method_0000_8022()
        {
            ii(0x8022, 1);    pushw(bp);                                /* push bp */
            ii(0x8023, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x8025, 1);    pushw(di);                                /* push di */
            ii(0x8026, 1);    pushw(si);                                /* push si */
            ii(0x8027, 5);    cmp(memw_a16[ds, 0xed6], 0);              /* cmp word [0xed6], 0x0 */
            ii(0x802c, 2);    if(jzw(0x8055, 0x27)) goto l_0x8055;      /* jz 0x5895 */
            ii(0x802e, 4);    les(bx, ds, 0xed4);                       /* les bx, [0xed4] */
            ii(0x8032, 4);    mov(si, memw_a16[es, bx + 0x2]);          /* mov si, [es:bx+0x2] */
            ii(0x8036, 2);    jmpw(0x8039, 0x1); goto l_0x8039;         /* jmp 0x5879 */
        l_0x8038:
            ii(0x8038, 1);    dec(si);                                  /* dec si */
        l_0x8039:
            ii(0x8039, 3);    cmp(si, 0x10);                            /* cmp si, 0x10 */
            ii(0x803c, 2);    if(jlw(0x8055, 0x17)) goto l_0x8055;      /* jl 0x5895 */
            ii(0x803e, 3);    mov(ax, memw_a16[ss, bp + 0x4]);          /* mov ax, [bp+0x4] */
            ii(0x8041, 2);    mov(di, si);                              /* mov di, si */
            ii(0x8043, 2);    shl(di, 0x1);                             /* shl di, 1 */
            ii(0x8045, 3);    cmp(memw_a16[es, bx + di], ax);           /* cmp [es:bx+di], ax */
            ii(0x8048, 2);    if(jnzw(0x8038, -0x12)) goto l_0x8038;    /* jnz 0x5878 */
            ii(0x804a, 2);    mov(ax, si);                              /* mov ax, si */
            ii(0x804c, 2);    mov(cl, 0x3);                             /* mov cl, 0x3 */
            ii(0x804e, 2);    shl(ax, cl);                              /* shl ax, cl */
            ii(0x8050, 3);    add(ax, memw_a16[es, bx]);                /* add ax, [es:bx] */
            ii(0x8053, 2);    jmpw(0x8057, 0x2); goto l_0x8057;         /* jmp 0x5897 */
        l_0x8055:
            ii(0x8055, 2);    sub(ax, ax);                              /* sub ax, ax */
        l_0x8057:
            ii(0x8057, 1);    popw(si);                                 /* pop si */
            ii(0x8058, 1);    popw(di);                                 /* pop di */
            ii(0x8059, 2);    mov(sp, bp);                              /* mov sp, bp */
            ii(0x805b, 1);    popw(bp);                                 /* pop bp */
            ii(0x805c, 1);    retw(); return;                           /* ret */
        }
    }
}
