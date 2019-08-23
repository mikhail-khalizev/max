using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xaa5f-3d006f99")]
        public void Method_0000_aa5f()
        {
            ii(0xaa5f, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0xaa61, 3);    mov(memw_a16[ds, 0xece], ax);             /* mov [0xece], ax */
            ii(0xaa64, 2);    if(jzw(0xaac3, 0x5d)) goto l_0xaac3;      /* jz 0xaac3 */
            ii(0xaa66, 4);    cmp(ax, memw_a16[ds, 0xecc]);             /* cmp ax, [0xecc] */
            ii(0xaa6a, 2);    if(jbw(0xaa6f, 0x3)) goto l_0xaa6f;       /* jb 0xaa6f */
            ii(0xaa6c, 3);    mov(ax, memw_a16[ds, 0xecc]);             /* mov ax, [0xecc] */
        l_0xaa6f:
            ii(0xaa6f, 3);    mov(memw_a16[ds, 0xecc], ax);             /* mov [0xecc], ax */
            ii(0xaa72, 1);    xchg(dx, ax);                             /* xchg dx, ax */
            ii(0xaa73, 2);    mov(ah, 0x9);                             /* mov ah, 0x9 */
            ii(0xaa75, 4);    callw_a16_far_ind(ds, 0xaec);             /* call far word [0xaec] */
            ii(0xaa79, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0xaa7b, 2);    if(jzw(0xaac3, 0x46)) goto l_0xaac3;      /* jz 0xaac3 */
            ii(0xaa7d, 4);    mov(memw_a16[ds, 0xadc], dx);             /* mov [0xadc], dx */
            ii(0xaa81, 2);    mov(ah, 0xc);                             /* mov ah, 0xc */
            ii(0xaa83, 4);    callw_a16_far_ind(ds, 0xaec);             /* call far word [0xaec] */
            ii(0xaa87, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0xaa89, 2);    if(jnzw(0xaa90, 0x5)) goto l_0xaa90;      /* jnz 0xaa90 */
            ii(0xaa8b, 3);    callw(0x5b97, -0x4ef7);                   /* call 0x5b97 */
            ii(0xaa8e, 2);    jmpw(0xaac3, 0x33); goto l_0xaac3;        /* jmp 0xaac3 */
        l_0xaa90:
            ii(0xaa90, 3);    add(bx, 0xf);                             /* add bx, 0xf */
            ii(0xaa93, 3);    adc(dx, 0);                               /* adc dx, 0x0 */
            ii(0xaa96, 3);    mov(cx, 0x4);                             /* mov cx, 0x4 */
        l_0xaa99:
            ii(0xaa99, 2);    shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0xaa9b, 2);    rcr(bx, 0x1);                             /* rcr bx, 1 */
            ii(0xaa9d, 2);    if(loopw_a16(0xaa99, -0x6)) goto l_0xaa99; /* loop 0xaa99 */
            ii(0xaa9f, 4);    mov(memw_a16[ds, 0x98], bx);              /* mov [0x98], bx */
            ii(0xaaa3, 4);    mov(memw_a16[ds, 0x9a], dx);              /* mov [0x9a], dx */
            ii(0xaaa7, 6);    mov(memw_a16[ds, 0xaa6], 0x3e5a);         /* mov word [0xaa6], 0x3e5a */
            ii(0xaaad, 6);    mov(memw_a16[ds, 0xaa4], 0x3e25);         /* mov word [0xaa4], 0x3e25 */
            ii(0xaab3, 3);    mov(ax, 0x400);                           /* mov ax, 0x400 */
            ii(0xaab6, 4);    mul(memw_a16[ds, 0xecc]);                 /* mul word [0xecc] */
            ii(0xaaba, 3);    mov(memw_a16[ds, 0xaa8], ax);             /* mov [0xaa8], ax */
            ii(0xaabd, 4);    mov(memw_a16[ds, 0xaaa], dx);             /* mov [0xaaa], dx */
            ii(0xaac1, 2);    jmpw(0xaac9, 0x6); goto l_0xaac9;         /* jmp 0xaac9 */
        l_0xaac3:
            ii(0xaac3, 6);    mov(memw_a16[ds, 0xecc], 0);              /* mov word [0xecc], 0x0 */
        l_0xaac9:
            ii(0xaac9, 2);    mov(al, 0x1);                             /* mov al, 0x1 */
            ii(0xaacb, 1);    retw();                                   /* ret */
        }
    }
}
