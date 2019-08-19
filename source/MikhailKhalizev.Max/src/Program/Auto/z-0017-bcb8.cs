using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_bcb8-79c31b86")]
        public void Method_0017_bcb8()
        {
            ii(0x17_bcb8, 4); enterw(0xe, 0);                           /* enter 0xe, 0x0 */
            ii(0x17_bcbc, 1); pushw(ds);                                /* push ds */
            ii(0x17_bcbd, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x17_bcc0, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x17_bcc2, 3); mov(ax, memw_a16[ds, 0x1fc4]);            /* mov ax, [0x1fc4] */
            ii(0x17_bcc5, 4); mov(dx, memw_a16[ds, 0x1fc6]);            /* mov dx, [0x1fc6] */
            ii(0x17_bcc9, 3); cmp(memw_a16[ss, bp + 0x8], dx);          /* cmp [bp+0x8], dx */
            ii(0x17_bccc, 2); if(jlw(0x17_bcdc, 0xe)) goto l_0x17_bcdc; /* jl 0xbcdc */
            ii(0x17_bcce, 2); if(jgw(0x17_bcd5, 0x5)) goto l_0x17_bcd5; /* jg 0xbcd5 */
            ii(0x17_bcd0, 3); cmp(memw_a16[ss, bp + 0x6], ax);          /* cmp [bp+0x6], ax */
            ii(0x17_bcd3, 2); if(jbew(0x17_bcdc, 0x7)) goto l_0x17_bcdc; /* jbe 0xbcdc */
        l_0x17_bcd5:
            ii(0x17_bcd5, 3); mov(ax, 0x8016);                          /* mov ax, 0x8016 */
            ii(0x17_bcd8, 1); popw(ds);                                 /* pop ds */
            ii(0x17_bcd9, 1); leavew();                                 /* leave */
            ii(0x17_bcda, 1); retfw(); return;                          /* retf */
        //  ii(0x17_bcdb, 1); Недостижимый код.
        l_0x17_bcdc:
            ii(0x17_bcdc, 3); mov(ax, memw_a16[ds, 0x1a]);              /* mov ax, [0x1a] */
            ii(0x17_bcdf, 4); or(ax, memw_a16[ds, 0x18]);               /* or ax, [0x18] */
            ii(0x17_bce3, 2); if(jzw(0x17_bd40, 0x5b)) goto l_0x17_bd40; /* jz 0xbd40 */
            ii(0x17_bce5, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x17_bce8, 3); mov(dx, memw_a16[ss, bp + 0x8]);          /* mov dx, [bp+0x8] */
            ii(0x17_bceb, 4); sub(ax, memw_a16[ds, 0x1fc4]);            /* sub ax, [0x1fc4] */
            ii(0x17_bcef, 4); sbb(dx, memw_a16[ds, 0x1fc6]);            /* sbb dx, [0x1fc6] */
            ii(0x17_bcf3, 4); sub(ax, memw_a16[ds, 0x1fc0]);            /* sub ax, [0x1fc0] */
            ii(0x17_bcf7, 4); sbb(dx, memw_a16[ds, 0x1fc2]);            /* sbb dx, [0x1fc2] */
            ii(0x17_bcfb, 4); add(ax, memw_a16[ds, 0x1fb4]);            /* add ax, [0x1fb4] */
            ii(0x17_bcff, 4); adc(dx, memw_a16[ds, 0x1fb6]);            /* adc dx, [0x1fb6] */
            ii(0x17_bd03, 3); add(ax, 0x4);                             /* add ax, 0x4 */
            ii(0x17_bd06, 3); adc(dx, 0);                               /* adc dx, 0x0 */
            ii(0x17_bd09, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x17_bd0c, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x17_bd0f, 4); mov(cx, memw_a16[ds, 0x1f50]);            /* mov cx, [0x1f50] */
            ii(0x17_bd13, 4); mov(bx, memw_a16[ds, 0x1f52]);            /* mov bx, [0x1f52] */
            ii(0x17_bd17, 2); cmp(dx, bx);                              /* cmp dx, bx */
            ii(0x17_bd19, 2); if(jlw(0x17_bd40, 0x25)) goto l_0x17_bd40; /* jl 0xbd40 */
            ii(0x17_bd1b, 2); if(jgw(0x17_bd21, 0x4)) goto l_0x17_bd21; /* jg 0xbd21 */
            ii(0x17_bd1d, 2); cmp(ax, cx);                              /* cmp ax, cx */
            ii(0x17_bd1f, 2); if(jbew(0x17_bd40, 0x1f)) goto l_0x17_bd40; /* jbe 0xbd40 */
        l_0x17_bd21:
            ii(0x17_bd21, 2); sub(ax, cx);                              /* sub ax, cx */
            ii(0x17_bd23, 2); sbb(dx, bx);                              /* sbb dx, bx */
            ii(0x17_bd25, 3); mov(memw_a16[ss, bp - 0xe], ax);          /* mov [bp-0xe], ax */
            ii(0x17_bd28, 3); mov(memw_a16[ss, bp - 0xc], dx);          /* mov [bp-0xc], dx */
            ii(0x17_bd2b, 1); pushw(dx);                                /* push dx */
            ii(0x17_bd2c, 1); pushw(ax);                                /* push ax */
            ii(0x17_bd2d, 1); nop();                                    /* nop */
            ii(0x17_bd2e, 1); pushw(cs);                                /* push cs */
            ii(0x17_bd2f, 3); callw(0x17_8ba6, -0x318c);                /* call 0x8ba6 */
            ii(0x17_bd32, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x17_bd35, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x17_bd37, 2); if(jnzw(0x17_bd40, 0x7)) goto l_0x17_bd40; /* jnz 0xbd40 */
            ii(0x17_bd39, 3); mov(ax, 0x8014);                          /* mov ax, 0x8014 */
            ii(0x17_bd3c, 1); popw(ds);                                 /* pop ds */
            ii(0x17_bd3d, 1); leavew();                                 /* leave */
            ii(0x17_bd3e, 1); retfw(); return;                          /* retf */
        //  ii(0x17_bd3f, 1); Недостижимый код.
        l_0x17_bd40:
            ii(0x17_bd40, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x17_bd43, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x17_bd46, 1); pushw(cs);                                /* push cs */
            ii(0x17_bd47, 3); callw(0x17_bbf8, -0x152);                 /* call 0xbbf8 */
            ii(0x17_bd4a, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x17_bd4d, 3); mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0x17_bd50, 3); mov(memw_a16[ss, bp - 0x6], dx);          /* mov [bp-0x6], dx */
            ii(0x17_bd53, 3); cmp(ax, 0xffff);                          /* cmp ax, 0xffff */
            ii(0x17_bd56, 2); if(jnzw(0x17_bd5f, 0x7)) goto l_0x17_bd5f; /* jnz 0xbd5f */
            ii(0x17_bd58, 2); cmp(dx, ax);                              /* cmp dx, ax */
            ii(0x17_bd5a, 2); if(jnzw(0x17_bd5f, 0x3)) goto l_0x17_bd5f; /* jnz 0xbd5f */
            ii(0x17_bd5c, 3); jmpw(0x17_be0c, 0xad); goto l_0x17_be0c;  /* jmp 0xbe0c */
        l_0x17_bd5f:
            ii(0x17_bd5f, 3); add(ax, 0);                               /* add ax, 0x0 */
            ii(0x17_bd62, 3); adc(dx, 0x1);                             /* adc dx, 0x1 */
            ii(0x17_bd65, 2); mov(dh, dl);                              /* mov dh, dl */
            ii(0x17_bd67, 2); mov(dl, ah);                              /* mov dl, ah */
            ii(0x17_bd69, 2); mov(ah, al);                              /* mov ah, al */
            ii(0x17_bd6b, 2); sub(al, al);                              /* sub al, al */
            ii(0x17_bd6d, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x17_bd6f, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x17_bd71, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x17_bd73, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x17_bd75, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x17_bd77, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x17_bd79, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x17_bd7b, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x17_bd7d, 3); les(bx, ss, bp + 0xa);                    /* les bx, [bp+0xa] */
            ii(0x17_bd80, 3); mov(memw_a16[es, bx], ax);                /* mov [es:bx], ax */
            ii(0x17_bd83, 4); mov(memw_a16[es, bx + 0x2], dx);          /* mov [es:bx+0x2], dx */
            ii(0x17_bd87, 3); mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0x17_bd8a, 3); mov(memw_a16[ss, bp - 0x6], dx);          /* mov [bp-0x6], dx */
            ii(0x17_bd8d, 1); pushw(cs);                                /* push cs */
            ii(0x17_bd8e, 3); callw(0x17_c6f0, 0x95f);                  /* call 0xc6f0 */
            ii(0x17_bd91, 3); les(bx, ss, bp + 0xa);                    /* les bx, [bp+0xa] */
            ii(0x17_bd94, 4); mov(memw_a16[es, bx + 0x4], ax);          /* mov [es:bx+0x4], ax */
            ii(0x17_bd98, 3); mov(memw_a16[ss, bp - 0xa], ax);          /* mov [bp-0xa], ax */
            ii(0x17_bd9b, 3); cmp(ax, 0xffff);                          /* cmp ax, 0xffff */
            ii(0x17_bd9e, 2); if(jzw(0x17_be04, 0x64)) goto l_0x17_be04; /* jz 0xbe04 */
            ii(0x17_bda0, 2); pushw(0x1);                               /* push 0x1 */
            ii(0x17_bda2, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x17_bda5, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x17_bda8, 4); pushw(memw_a16[es, bx + 0x2]);            /* push word [es:bx+0x2] */
            ii(0x17_bdac, 3); pushw(memw_a16[es, bx]);                  /* push word [es:bx] */
            ii(0x17_bdaf, 4); mov(cl, memb_a16[ds, 0x51a7]);            /* mov cl, [0x51a7] */
            ii(0x17_bdb3, 2); sub(ch, ch);                              /* sub ch, ch */
            ii(0x17_bdb5, 1); pushw(cx);                                /* push cx */
            ii(0x17_bdb6, 1); pushw(ax);                                /* push ax */
            ii(0x17_bdb7, 1); pushw(cs);                                /* push cs */
            ii(0x17_bdb8, 3); callw(0x17_c48e, 0x6d3);                  /* call 0xc48e */
            ii(0x17_bdbb, 3); add(sp, 0xe);                             /* add sp, 0xe */
            ii(0x17_bdbe, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x17_bdc1, 3); mov(dx, memw_a16[ss, bp + 0x8]);          /* mov dx, [bp+0x8] */
            ii(0x17_bdc4, 4); sub(memw_a16[ds, 0x1fc4], ax);            /* sub [0x1fc4], ax */
            ii(0x17_bdc8, 4); sbb(memw_a16[ds, 0x1fc6], dx);            /* sbb [0x1fc6], dx */
            ii(0x17_bdcc, 4); sub(memw_a16[ds, 0x1fac], ax);            /* sub [0x1fac], ax */
            ii(0x17_bdd0, 4); sbb(memw_a16[ds, 0x1fae], dx);            /* sbb [0x1fae], dx */
            ii(0x17_bdd4, 5); cmp(memw_a16[ds, 0x1fae], 0);             /* cmp word [0x1fae], 0x0 */
            ii(0x17_bdd9, 2); if(jgew(0x17_bde3, 0x8)) goto l_0x17_bde3; /* jge 0xbde3 */
            ii(0x17_bddb, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x17_bddd, 3); mov(memw_a16[ds, 0x1fae], ax);            /* mov [0x1fae], ax */
            ii(0x17_bde0, 3); mov(memw_a16[ds, 0x1fac], ax);            /* mov [0x1fac], ax */
        l_0x17_bde3:
            ii(0x17_bde3, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x17_bde6, 4); sub(memw_a16[ds, 0x1fbc], ax);            /* sub [0x1fbc], ax */
            ii(0x17_bdea, 4); sbb(memw_a16[ds, 0x1fbe], dx);            /* sbb [0x1fbe], dx */
            ii(0x17_bdee, 5); cmp(memw_a16[ds, 0x1fbe], 0);             /* cmp word [0x1fbe], 0x0 */
            ii(0x17_bdf3, 2); if(jgew(0x17_bdfd, 0x8)) goto l_0x17_bdfd; /* jge 0xbdfd */
            ii(0x17_bdf5, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x17_bdf7, 3); mov(memw_a16[ds, 0x1fbe], ax);            /* mov [0x1fbe], ax */
            ii(0x17_bdfa, 3); mov(memw_a16[ds, 0x1fbc], ax);            /* mov [0x1fbc], ax */
        l_0x17_bdfd:
            ii(0x17_bdfd, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x17_bdff, 1); popw(ds);                                 /* pop ds */
            ii(0x17_be00, 1); leavew();                                 /* leave */
            ii(0x17_be01, 1); retfw(); return;                          /* retf */
        //  ii(0x17_be02, 2); Недостижимый код.
        l_0x17_be04:
            ii(0x17_be04, 3); mov(ax, 0x8016);                          /* mov ax, 0x8016 */
            ii(0x17_be07, 1); popw(ds);                                 /* pop ds */
            ii(0x17_be08, 1); leavew();                                 /* leave */
            ii(0x17_be09, 1); retfw(); return;                          /* retf */
        //  ii(0x17_be0a, 2); Недостижимый код.
        l_0x17_be0c:
            ii(0x17_be0c, 3); mov(ax, 0x8013);                          /* mov ax, 0x8013 */
            ii(0x17_be0f, 1); popw(ds);                                 /* pop ds */
            ii(0x17_be10, 1); leavew();                                 /* leave */
            ii(0x17_be11, 1); retfw(); return;                          /* retf */
        }
    }
}
