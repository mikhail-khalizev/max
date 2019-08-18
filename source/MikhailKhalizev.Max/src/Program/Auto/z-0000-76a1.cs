using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("e011fda4-c245-4f0e-afd4-7567f6ee6a74")]
        public void Method_0000_76a1()
        {
            ii(0x76a1, 4);    enterw(0x4, 0);                           /* enter 0x4, 0x0 */
            ii(0x76a5, 5);    cmp(memb_a16[ds, 0x980], 0x1);            /* cmp byte [0x980], 0x1 */
            ii(0x76aa, 2);    if(jzw(0x76cf, 0x23)) goto l_0x76cf;      /* jz 0x76cf */
            ii(0x76ac, 5);    cmp(memb_a16[ds, 0x980], 0x3);            /* cmp byte [0x980], 0x3 */
            ii(0x76b1, 2);    if(jgew(0x76cf, 0x1c)) goto l_0x76cf;     /* jge 0x76cf */
            ii(0x76b3, 2);    pushw(0);                                 /* push 0x0 */
            ii(0x76b5, 3);    pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x76b8, 3);    callw(0x5c08, -0x1ab3);                   /* call 0x5c08 */
            ii(0x76bb, 1);    popw(bx);                                 /* pop bx */
            ii(0x76bc, 1);    popw(bx);                                 /* pop bx */
            ii(0x76bd, 3);    mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x76c0, 3);    mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x76c3, 2);    or(dx, ax);                               /* or dx, ax */
            ii(0x76c5, 2);    if(jzw(0x76cf, 0x8)) goto l_0x76cf;       /* jz 0x76cf */
        l_0x76c7:
            ii(0x76c7, 3);    mov(ax, memw_a16[ss, bp - 0x4]);          /* mov ax, [bp-0x4] */
            ii(0x76ca, 3);    mov(dx, memw_a16[ss, bp - 0x2]);          /* mov dx, [bp-0x2] */
            ii(0x76cd, 1);    leavew();                                 /* leave */
            ii(0x76ce, 1);    retw(); return;                           /* ret */
        l_0x76cf:
            ii(0x76cf, 3);    callw(0x4f61, -0x2771);                   /* call 0x4f61 */
            ii(0x76d2, 3);    pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x76d5, 3);    callw(0x76fc, 0x24);                      /* call 0x76fc */
            ii(0x76d8, 1);    popw(bx);                                 /* pop bx */
            ii(0x76d9, 3);    mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x76dc, 3);    mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x76df, 3);    callw(0x572a, -0x1fb8);                   /* call 0x572a */
            ii(0x76e2, 3);    mov(ax, memw_a16[ss, bp - 0x2]);          /* mov ax, [bp-0x2] */
            ii(0x76e5, 3);    or(ax, memw_a16[ss, bp - 0x4]);           /* or ax, [bp-0x4] */
            ii(0x76e8, 2);    if(jnzw(0x76c7, -0x23)) goto l_0x76c7;    /* jnz 0x76c7 */
            ii(0x76ea, 2);    pushw(0);                                 /* push 0x0 */
            ii(0x76ec, 3);    pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x76ef, 3);    callw(0x5c08, -0x1aea);                   /* call 0x5c08 */
            ii(0x76f2, 1);    popw(bx);                                 /* pop bx */
            ii(0x76f3, 1);    popw(bx);                                 /* pop bx */
            ii(0x76f4, 3);    mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x76f7, 3);    mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x76fa, 2);    jmpw(0x76c7, -0x35); goto l_0x76c7;       /* jmp 0x76c7 */
        }
    }
}
