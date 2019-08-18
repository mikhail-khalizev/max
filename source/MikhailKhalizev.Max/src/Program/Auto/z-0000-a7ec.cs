using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xa7ec-294ff348")]
        public void Method_0000_a7ec()
        {
            ii(0xa7ec, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0xa7ee, 3);    mov(di, memw_a16[ss, bp + 0x2]);          /* mov di, [bp+0x2] */
            ii(0xa7f1, 4);    mov(ax, memw_a16[cs, 0x208e]);            /* mov ax, [cs:0x208e] */
            ii(0xa7f5, 2);    mov(ds, ax);                              /* mov ds, ax */
            ii(0xa7f7, 2);    mov(ss, ax);                              /* mov ss, ax */
            ii(0xa7f9, 4);    mov(sp, memw_a16[ds, 0xf50]);             /* mov sp, [0xf50] */
            ii(0xa7fd, 1);    pushw(di);                                /* push di */
            ii(0xa7fe, 5);    mov(dx, memw_a16[cs, 0xf6f]);             /* mov dx, [cs:0xf6f] */
            ii(0xa803, 5);    mov(cx, memw_a16[cs, 0xf71]);             /* mov cx, [cs:0xf71] */
            ii(0xa808, 3);    mov(ax, 0x304);                           /* mov ax, 0x304 */
            ii(0xa80b, 2);    @int(0x31);                               /* int 0x31 */
            ii(0xa80d, 2);    pushd(edx);                               /* push edx */
            ii(0xa80f, 3);    xor(edx, edx);                            /* xor edx, edx */
            ii(0xa812, 3);    mov(si, 0xf8a);                           /* mov si, 0xf8a */
            ii(0xa815, 2);    mov(bl, 0x8);                             /* mov bl, 0x8 */
            ii(0xa817, 3);    mov(ax, 0x201);                           /* mov ax, 0x201 */
        l_0xa81a:
            ii(0xa81a, 2);    mov(dx, memw_a16[ds, si]);                /* mov dx, [si] */
            ii(0xa81c, 3);    mov(cx, memw_a16[ds, si + 0x2]);          /* mov cx, [si+0x2] */
            ii(0xa81f, 2);    @int(0x31);                               /* int 0x31 */
            ii(0xa821, 2);    inc(bl);                                  /* inc bl */
            ii(0xa823, 3);    add(si, 0x4);                             /* add si, 0x4 */
            ii(0xa826, 3);    cmp(bl, 0x2e);                            /* cmp bl, 0x2e */
            ii(0xa829, 2);    if(jbew(0xa81a, -0x11)) goto l_0xa81a;    /* jbe 0xa81a */
            ii(0xa82b, 2);    mov(bl, 0);                               /* mov bl, 0x0 */
        l_0xa82d:
            ii(0xa82d, 3);    mov(ax, 0x200);                           /* mov ax, 0x200 */
            ii(0xa830, 2);    @int(0x31);                               /* int 0x31 */
            ii(0xa832, 4);    cmp(cx, memw_a16[ds, 0x9b6]);             /* cmp cx, [0x9b6] */
            ii(0xa836, 2);    if(jnzw(0xa845, 0xd)) goto l_0xa845;      /* jnz 0xa845 */
            ii(0xa838, 4);    mov(dx, memw_a16[ds, 0x56]);              /* mov dx, [0x56] */
            ii(0xa83c, 4);    mov(cx, memw_a16[ds, 0x58]);              /* mov cx, [0x58] */
            ii(0xa840, 3);    mov(ax, 0x201);                           /* mov ax, 0x201 */
            ii(0xa843, 2);    @int(0x31);                               /* int 0x31 */
        l_0xa845:
            ii(0xa845, 2);    inc(bl);                                  /* inc bl */
            ii(0xa847, 2);    if(jnzw(0xa82d, -0x1c)) goto l_0xa82d;    /* jnz 0xa82d */
            ii(0xa849, 1);    pushw(ds);                                /* push ds */
            ii(0xa84a, 1);    popw(es);                                 /* pop es */
            ii(0xa84b, 3);    mov(di, 0xc0);                            /* mov di, 0xc0 */
            ii(0xa84e, 1);    pushw(cs);                                /* push cs */
            ii(0xa84f, 3);    callw(0xac29, 0x3d7);                     /* call 0xac29 */
            ii(0xa852, 4);    mov(es, memw_a16[ds, 0xc4c]);             /* mov es, [0xc4c] */
            ii(0xa856, 2);    xor(di, di);                              /* xor di, di */
            ii(0xa858, 1);    pushw(cs);                                /* push cs */
            ii(0xa859, 3);    callw(0xabb6, 0x35a);                     /* call 0xabb6 */
            ii(0xa85c, 2);    popd(edx);                                /* pop edx */
            ii(0xa85e, 1);    popw(ax);                                 /* pop ax */
            ii(0xa85f, 2);    mov(ah, 0x4c);                            /* mov ah, 0x4c */
            ii(0xa861, 2);    @int(0x21);                               /* int 0x21 */
            ii(0xa863, 3);    cmp(ax, 0xbf02);                          /* cmp ax, 0xbf02 */
            ii(0xa866, 2);    if(jzw(0xa87a, 0x12)) goto l_0xa87a;      /* jz 0xa87a */
            ii(0xa868, 3);    cmp(ax, 0xbfdc);                          /* cmp ax, 0xbfdc */
            ii(0xa86b, 2);    if(jzw(0xa872, 0x5)) goto l_0xa872;       /* jz 0xa872 */
            ii(0xa86d, 5);    if(jmpw_a16_far_ind(cs, 0x12c4)) return;  /* jmp far word [cs:0x12c4] */
        l_0xa872:
            ii(0xa872, 3);    mov(si, 0x98);                            /* mov si, 0x98 */
            ii(0xa875, 5);    mov(dx, memw_a16[cs, 0]);                 /* mov dx, [cs:0x0] */
        l_0xa87a:
            ii(0xa87a, 1);    iretw(); return;                          /* iretw */
        }
    }
}
