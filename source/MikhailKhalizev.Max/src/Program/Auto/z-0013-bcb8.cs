using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("79e3e6cb-7393-4d0c-b469-cfcfe8563af0")]
        public void Method_0013_bcb8()
        {
            ii(0x13_bcb8, 4); enterw(0xe, 0);                           /* enter 0xe, 0x0 */
            ii(0x13_bcbc, 1); pushw(ds);                                /* push ds */
            ii(0x13_bcbd, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x13_bcc0, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x13_bcc2, 3); mov(ax, memw_a16[ds, 0x1fc4]);            /* mov ax, [0x1fc4] */
            ii(0x13_bcc5, 4); mov(dx, memw_a16[ds, 0x1fc6]);            /* mov dx, [0x1fc6] */
            ii(0x13_bcc9, 3); cmp(memw_a16[ss, bp + 0x8], dx);          /* cmp [bp+0x8], dx */
            ii(0x13_bccc, 2); if(jlw(0x13_bcdc, 0xe)) goto l_0x13_bcdc; /* jl 0xbcdc */
            ii(0x13_bcce, 2); if(jgw(0x13_bcd5, 0x5)) goto l_0x13_bcd5; /* jg 0xbcd5 */
            ii(0x13_bcd0, 3); cmp(memw_a16[ss, bp + 0x6], ax);          /* cmp [bp+0x6], ax */
            ii(0x13_bcd3, 2); if(jbew(0x13_bcdc, 0x7)) goto l_0x13_bcdc; /* jbe 0xbcdc */
        l_0x13_bcd5:
            ii(0x13_bcd5, 3); mov(ax, 0x8016);                          /* mov ax, 0x8016 */
            ii(0x13_bcd8, 1); popw(ds);                                 /* pop ds */
            ii(0x13_bcd9, 1); leavew();                                 /* leave */
            ii(0x13_bcda, 1); retfw(); return;                          /* retf */
        //    ii(0x13_bcdb, 1); nop();                                    /* nop */
        l_0x13_bcdc:
            ii(0x13_bcdc, 3); mov(ax, memw_a16[ds, 0x1a]);              /* mov ax, [0x1a] */
            ii(0x13_bcdf, 4); or(ax, memw_a16[ds, 0x18]);               /* or ax, [0x18] */
            ii(0x13_bce3, 2); if(jzw(0x13_bd40, 0x5b)) goto l_0x13_bd40; /* jz 0xbd40 */
            ii(0x13_bce5, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x13_bce8, 3); mov(dx, memw_a16[ss, bp + 0x8]);          /* mov dx, [bp+0x8] */
            ii(0x13_bceb, 4); sub(ax, memw_a16[ds, 0x1fc4]);            /* sub ax, [0x1fc4] */
            ii(0x13_bcef, 4); sbb(dx, memw_a16[ds, 0x1fc6]);            /* sbb dx, [0x1fc6] */
            ii(0x13_bcf3, 4); sub(ax, memw_a16[ds, 0x1fc0]);            /* sub ax, [0x1fc0] */
            ii(0x13_bcf7, 4); sbb(dx, memw_a16[ds, 0x1fc2]);            /* sbb dx, [0x1fc2] */
            ii(0x13_bcfb, 4); add(ax, memw_a16[ds, 0x1fb4]);            /* add ax, [0x1fb4] */
            ii(0x13_bcff, 4); adc(dx, memw_a16[ds, 0x1fb6]);            /* adc dx, [0x1fb6] */
            ii(0x13_bd03, 3); add(ax, 0x4);                             /* add ax, 0x4 */
            ii(0x13_bd06, 3); adc(dx, 0);                               /* adc dx, 0x0 */
            ii(0x13_bd09, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x13_bd0c, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x13_bd0f, 4); mov(cx, memw_a16[ds, 0x1f50]);            /* mov cx, [0x1f50] */
            ii(0x13_bd13, 4); mov(bx, memw_a16[ds, 0x1f52]);            /* mov bx, [0x1f52] */
            ii(0x13_bd17, 2); cmp(dx, bx);                              /* cmp dx, bx */
            ii(0x13_bd19, 2); if(jlw(0x13_bd40, 0x25)) goto l_0x13_bd40; /* jl 0xbd40 */
            ii(0x13_bd1b, 2); if(jgw(0x13_bd21, 0x4)) goto l_0x13_bd21; /* jg 0xbd21 */
            ii(0x13_bd1d, 2); cmp(ax, cx);                              /* cmp ax, cx */
            ii(0x13_bd1f, 2); if(jbew(0x13_bd40, 0x1f)) goto l_0x13_bd40; /* jbe 0xbd40 */
        l_0x13_bd21:
            ii(0x13_bd21, 2); sub(ax, cx);                              /* sub ax, cx */
            ii(0x13_bd23, 2); sbb(dx, bx);                              /* sbb dx, bx */
            ii(0x13_bd25, 3); mov(memw_a16[ss, bp - 0xe], ax);          /* mov [bp-0xe], ax */
            ii(0x13_bd28, 3); mov(memw_a16[ss, bp - 0xc], dx);          /* mov [bp-0xc], dx */
            ii(0x13_bd2b, 1); pushw(dx);                                /* push dx */
            ii(0x13_bd2c, 1); pushw(ax);                                /* push ax */
            ii(0x13_bd2d, 1); nop();                                    /* nop */
            ii(0x13_bd2e, 1); pushw(cs);                                /* push cs */
            ii(0x13_bd2f, 3); callw(0x13_8ba6, -0x318c);                /* call 0x8ba6 */
            ii(0x13_bd32, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x13_bd35, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x13_bd37, 2); if(jnzw(0x13_bd40, 0x7)) goto l_0x13_bd40; /* jnz 0xbd40 */
            ii(0x13_bd39, 3); mov(ax, 0x8014);                          /* mov ax, 0x8014 */
            ii(0x13_bd3c, 1); popw(ds);                                 /* pop ds */
            ii(0x13_bd3d, 1); leavew();                                 /* leave */
            ii(0x13_bd3e, 1); retfw(); return;                          /* retf */
        //    ii(0x13_bd3f, 1); nop();                                    /* nop */
        l_0x13_bd40:
            ii(0x13_bd40, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x13_bd43, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x13_bd46, 1); pushw(cs);                                /* push cs */
            ii(0x13_bd47, 3); callw(0x13_bbf8, -0x152);                 /* call 0xbbf8 */
            ii(0x13_bd4a, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x13_bd4d, 3); mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0x13_bd50, 3); mov(memw_a16[ss, bp - 0x6], dx);          /* mov [bp-0x6], dx */
            ii(0x13_bd53, 3); cmp(ax, 0xffff);                          /* cmp ax, 0xffff */
            ii(0x13_bd56, 2); if(jnzw(0x13_bd5f, 0x7)) goto l_0x13_bd5f; /* jnz 0xbd5f */
            ii(0x13_bd58, 2); cmp(dx, ax);                              /* cmp dx, ax */
            ii(0x13_bd5a, 2); if(jnzw(0x13_bd5f, 0x3)) goto l_0x13_bd5f; /* jnz 0xbd5f */
            ii(0x13_bd5c, 3); jmpw(0x13_be0c, 0xad); goto l_0x13_be0c;  /* jmp 0xbe0c */
        l_0x13_bd5f:
            ii(0x13_bd5f, 3); add(ax, 0);                               /* add ax, 0x0 */
            ii(0x13_bd62, 3); adc(dx, 0x1);                             /* adc dx, 0x1 */
            ii(0x13_bd65, 2); mov(dh, dl);                              /* mov dh, dl */
            ii(0x13_bd67, 2); mov(dl, ah);                              /* mov dl, ah */
            ii(0x13_bd69, 2); mov(ah, al);                              /* mov ah, al */
            ii(0x13_bd6b, 2); sub(al, al);                              /* sub al, al */
            ii(0x13_bd6d, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_bd6f, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_bd71, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_bd73, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_bd75, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_bd77, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_bd79, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_bd7b, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_bd7d, 3); les(bx, ss, bp + 0xa);                    /* les bx, [bp+0xa] */
            ii(0x13_bd80, 3); mov(memw_a16[es, bx], ax);                /* mov [es:bx], ax */
            ii(0x13_bd83, 4); mov(memw_a16[es, bx + 0x2], dx);          /* mov [es:bx+0x2], dx */
            ii(0x13_bd87, 3); mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0x13_bd8a, 3); mov(memw_a16[ss, bp - 0x6], dx);          /* mov [bp-0x6], dx */
            ii(0x13_bd8d, 1); pushw(cs);                                /* push cs */
            ii(0x13_bd8e, 3); callw(0x13_c6f0, 0x95f);                  /* call 0xc6f0 */
            ii(0x13_bd91, 3); les(bx, ss, bp + 0xa);                    /* les bx, [bp+0xa] */
            ii(0x13_bd94, 4); mov(memw_a16[es, bx + 0x4], ax);          /* mov [es:bx+0x4], ax */
            ii(0x13_bd98, 3); mov(memw_a16[ss, bp - 0xa], ax);          /* mov [bp-0xa], ax */
            ii(0x13_bd9b, 3); cmp(ax, 0xffff);                          /* cmp ax, 0xffff */
            ii(0x13_bd9e, 2); if(jzw(0x13_be04, 0x64)) goto l_0x13_be04; /* jz 0xbe04 */
            ii(0x13_bda0, 2); pushw(0x1);                               /* push 0x1 */
            ii(0x13_bda2, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x13_bda5, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x13_bda8, 4); pushw(memw_a16[es, bx + 0x2]);            /* push word [es:bx+0x2] */
            ii(0x13_bdac, 3); pushw(memw_a16[es, bx]);                  /* push word [es:bx] */
            ii(0x13_bdaf, 4); mov(cl, memb_a16[ds, 0x51a7]);            /* mov cl, [0x51a7] */
            ii(0x13_bdb3, 2); sub(ch, ch);                              /* sub ch, ch */
            ii(0x13_bdb5, 1); pushw(cx);                                /* push cx */
            ii(0x13_bdb6, 1); pushw(ax);                                /* push ax */
            ii(0x13_bdb7, 1); pushw(cs);                                /* push cs */
            ii(0x13_bdb8, 3); callw(0x13_c48e, 0x6d3);                  /* call 0xc48e */
            ii(0x13_bdbb, 3); add(sp, 0xe);                             /* add sp, 0xe */
            ii(0x13_bdbe, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x13_bdc1, 3); mov(dx, memw_a16[ss, bp + 0x8]);          /* mov dx, [bp+0x8] */
            ii(0x13_bdc4, 4); sub(memw_a16[ds, 0x1fc4], ax);            /* sub [0x1fc4], ax */
            ii(0x13_bdc8, 4); sbb(memw_a16[ds, 0x1fc6], dx);            /* sbb [0x1fc6], dx */
            ii(0x13_bdcc, 4); sub(memw_a16[ds, 0x1fac], ax);            /* sub [0x1fac], ax */
            ii(0x13_bdd0, 4); sbb(memw_a16[ds, 0x1fae], dx);            /* sbb [0x1fae], dx */
            ii(0x13_bdd4, 5); cmp(memw_a16[ds, 0x1fae], 0);             /* cmp word [0x1fae], 0x0 */
            ii(0x13_bdd9, 2); if(jgew(0x13_bde3, 0x8)) goto l_0x13_bde3; /* jge 0xbde3 */
            ii(0x13_bddb, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x13_bddd, 3); mov(memw_a16[ds, 0x1fae], ax);            /* mov [0x1fae], ax */
            ii(0x13_bde0, 3); mov(memw_a16[ds, 0x1fac], ax);            /* mov [0x1fac], ax */
        l_0x13_bde3:
            ii(0x13_bde3, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x13_bde6, 4); sub(memw_a16[ds, 0x1fbc], ax);            /* sub [0x1fbc], ax */
            ii(0x13_bdea, 4); sbb(memw_a16[ds, 0x1fbe], dx);            /* sbb [0x1fbe], dx */
            ii(0x13_bdee, 5); cmp(memw_a16[ds, 0x1fbe], 0);             /* cmp word [0x1fbe], 0x0 */
            ii(0x13_bdf3, 2); if(jgew(0x13_bdfd, 0x8)) goto l_0x13_bdfd; /* jge 0xbdfd */
            ii(0x13_bdf5, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x13_bdf7, 3); mov(memw_a16[ds, 0x1fbe], ax);            /* mov [0x1fbe], ax */
            ii(0x13_bdfa, 3); mov(memw_a16[ds, 0x1fbc], ax);            /* mov [0x1fbc], ax */
        l_0x13_bdfd:
            ii(0x13_bdfd, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x13_bdff, 1); popw(ds);                                 /* pop ds */
            ii(0x13_be00, 1); leavew();                                 /* leave */
            ii(0x13_be01, 1); retfw(); return;                          /* retf */
        //    ii(0x13_be02, 2); jmpw(0x13_be0a, 0x6); goto l_0x13_be0a;   /* jmp 0xbe0a */
        l_0x13_be04:
            ii(0x13_be04, 3); mov(ax, 0x8016);                          /* mov ax, 0x8016 */
            ii(0x13_be07, 1); popw(ds);                                 /* pop ds */
            ii(0x13_be08, 1); leavew();                                 /* leave */
            ii(0x13_be09, 1); retfw(); return;                          /* retf */
        l_0x13_be0a:
            ii(0x13_be0a, 2); if(jmpw_func(0x13_be12, 0x6)) return;     /* jmp 0xbe12 */
        l_0x13_be0c:
            ii(0x13_be0c, 3); mov(ax, 0x8013);                          /* mov ax, 0x8013 */
            ii(0x13_be0f, 1); popw(ds);                                 /* pop ds */
            ii(0x13_be10, 1); leavew();                                 /* leave */
            ii(0x13_be11, 1); retfw(); return;                          /* retf */
        }
    }
}
