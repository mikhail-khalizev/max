using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("83228e6c-d326-43eb-84ff-8e4cd791bb25")]
        public void Method_0000_fcd2()
        {
            ii(0xfcd2, 4);    enterw(0xc, 0);                           /* enter 0xc, 0x0 */
            ii(0xfcd6, 1);    pushw(si);                                /* push si */
            ii(0xfcd7, 2);    sub(ax, ax);                              /* sub ax, ax */
            ii(0xfcd9, 3);    mov(memw_a16[ss, bp - 0xa], ax);          /* mov [bp-0xa], ax */
            ii(0xfcdc, 3);    mov(memw_a16[ss, bp - 0xc], ax);          /* mov [bp-0xc], ax */
            ii(0xfcdf, 2);    sub(si, si);                              /* sub si, si */
            ii(0xfce1, 1);    cli();                                    /* cli */
            ii(0xfce2, 2);    sub(ax, ax);                              /* sub ax, ax */
            ii(0xfce4, 3);    mov(memw_a16[ds, 0x11fc], ax);            /* mov [0x11fc], ax */
            ii(0xfce7, 3);    mov(memw_a16[ds, 0x11fa], ax);            /* mov [0x11fa], ax */
            ii(0xfcea, 3);    mov(ax, memw_a16[ds, 0x98]);              /* mov ax, [0x98] */
            ii(0xfced, 4);    mov(dx, memw_a16[ds, 0x9a]);              /* mov dx, [0x9a] */
            ii(0xfcf1, 3);    mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0xfcf4, 3);    mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0xfcf7, 4);    cmp(dx, memw_a16[ds, 0x9e]);              /* cmp dx, [0x9e] */
            ii(0xfcfb, 2);    if(jaw(0xfd68, 0x6b)) goto l_0xfd68;      /* ja 0xfd68 */
            ii(0xfcfd, 2);    if(jbw(0xfd05, 0x6)) goto l_0xfd05;       /* jb 0xfd05 */
            ii(0xfcff, 4);    cmp(ax, memw_a16[ds, 0x9c]);              /* cmp ax, [0x9c] */
            ii(0xfd03, 2);    if(jaew(0xfd68, 0x63)) goto l_0xfd68;     /* jae 0xfd68 */
        l_0xfd05:
            ii(0xfd05, 3);    mov(ax, memw_a16[ss, bp - 0x2]);          /* mov ax, [bp-0x2] */
            ii(0xfd08, 3);    or(ax, memw_a16[ss, bp - 0x4]);           /* or ax, [bp-0x4] */
            ii(0xfd0b, 2);    if(jzw(0xfd68, 0x5b)) goto l_0xfd68;      /* jz 0xfd68 */
            ii(0xfd0d, 2);    pushw(0x4);                               /* push 0x4 */
            ii(0xfd0f, 3);    pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0xfd12, 3);    pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0xfd15, 3);    callw(0x1_1b21, 0x1e09);                  /* call 0x1b21 */
            ii(0xfd18, 3);    add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0xfd1b, 3);    mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0xfd1e, 3);    mov(memw_a16[ss, bp - 0x6], dx);          /* mov [bp-0x6], dx */
            ii(0xfd21, 3);    add(memw_a16[ss, bp - 0xc], ax);          /* add [bp-0xc], ax */
            ii(0xfd24, 3);    adc(memw_a16[ss, bp - 0xa], dx);          /* adc [bp-0xa], dx */
            ii(0xfd27, 4);    cmp(dx, memw_a16[ds, 0x11fc]);            /* cmp dx, [0x11fc] */
            ii(0xfd2b, 2);    if(jbw(0xfd3c, 0xf)) goto l_0xfd3c;       /* jb 0xfd3c */
            ii(0xfd2d, 2);    if(jaw(0xfd35, 0x6)) goto l_0xfd35;       /* ja 0xfd35 */
            ii(0xfd2f, 4);    cmp(ax, memw_a16[ds, 0x11fa]);            /* cmp ax, [0x11fa] */
            ii(0xfd33, 2);    if(jbew(0xfd3c, 0x7)) goto l_0xfd3c;      /* jbe 0xfd3c */
        l_0xfd35:
            ii(0xfd35, 3);    mov(memw_a16[ds, 0x11fa], ax);            /* mov [0x11fa], ax */
            ii(0xfd38, 4);    mov(memw_a16[ds, 0x11fc], dx);            /* mov [0x11fc], dx */
        l_0xfd3c:
            ii(0xfd3c, 1);    dec(si);                                  /* dec si */
            ii(0xfd3d, 2);    if(jzw(0xfd4c, 0xd)) goto l_0xfd4c;       /* jz 0xfd4c */
            ii(0xfd3f, 3);    pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0xfd42, 3);    pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0xfd45, 3);    callw(0xfc9e, -0xaa);                     /* call 0xfc9e */
            ii(0xfd48, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0xfd4a, 2);    if(jnzw(0xfd52, 0x6)) goto l_0xfd52;      /* jnz 0xfd52 */
        l_0xfd4c:
            ii(0xfd4c, 2);    pushw(0x1c);                              /* push 0x1c */
            ii(0xfd4e, 3);    callw(0x1_1995, 0x1c44);                  /* call 0x1995 */
            ii(0xfd51, 1);    popw(bx);                                 /* pop bx */
        l_0xfd52:
            ii(0xfd52, 2);    pushw(0);                                 /* push 0x0 */
            ii(0xfd54, 3);    pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0xfd57, 3);    pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0xfd5a, 3);    callw(0x1_1b21, 0x1dc4);                  /* call 0x1b21 */
            ii(0xfd5d, 3);    add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0xfd60, 3);    mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0xfd63, 3);    mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0xfd66, 2);    jmpw(0xfd05, -0x63); goto l_0xfd05;       /* jmp 0xfd05 */
        l_0xfd68:
            ii(0xfd68, 1);    sti();                                    /* sti */
            ii(0xfd69, 3);    mov(ax, memw_a16[ss, bp - 0xc]);          /* mov ax, [bp-0xc] */
            ii(0xfd6c, 3);    mov(dx, memw_a16[ss, bp - 0xa]);          /* mov dx, [bp-0xa] */
            ii(0xfd6f, 1);    popw(si);                                 /* pop si */
            ii(0xfd70, 1);    leavew();                                 /* leave */
            ii(0xfd71, 1);    retw(); return;                           /* ret */
        }
    }
}
