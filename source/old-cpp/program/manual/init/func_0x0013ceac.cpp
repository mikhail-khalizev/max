FUNC_BEGIN(0x0013ceac, 0x8c7b0f8ebf5bae2d, 0x10, ({0xfa, 0x58, 0x66, 0x55, 0x8c, 0xd9, 0xbe, 0xc4, 0x50, 0x8c, 0x54, 0x79, 0x16, 0x7, 0x66, 0x89, 0x64, 0x75, 0xf, 0xb2, 0x64, 0x7b, 0x8e, 0xd9, 0x26, 0x67, 0x66, 0xff, 0x75, 0x2c, 0x26, 0x67, 0x66, 0xff, 0x75, 0x28, 0x26, 0x67, 0x66, 0xff, 0x75, 0x24, 0x26, 0x67, 0x66, 0xff, 0x75, 0x20, 0x26, 0x67, 0x66, 0xff, 0x75, 0x1c, 0x26, 0x67, 0x66, 0xff, 0x75, 0x18, 0x26, 0x67, 0x66, 0xff, 0x75, 0x14, 0x26, 0x67, 0x66, 0xff, 0x75, 0x10, 0x26, 0x67, 0x66, 0xff, 0x75, 0xc, 0x26, 0x67, 0x66, 0xff, 0x75, 0x8, 0x26, 0x67, 0x66, 0xff, 0x75, 0x4, 0x26, 0x67, 0xff, 0x75, 0x2, 0x26, 0x67, 0xff, 0x75, 0, 0x26, 0x67, 0x66, 0xff, 0x75, 0xfc, 0x8b, 0xec, 0x83, 0xc5, 0x4, 0x66, 0xf, 0xb7, 0xe4, 0x66, 0xf, 0xb7, 0xed, 0xfb, 0xff, 0xe0}))
    II(0x0013ceac, 0x1)   cli();                                /* cli  */
    II(0x0013cead, 0x1)   popw(ax);                             /* pop ax */
    II(0x0013ceae, 0x2)   pushd(ebp);                           /* push ebp */
    II(0x0013ceb0, 0x2)   mov(cx, ds);                          /* mov cx, ds */
    II(0x0013ceb2, 0x3)   mov(si, 0x50c4);                      /* mov si, 0x50c4 */
    II(0x0013ceb5, 0x3)   mov(memw_a16(ds, si + 0x79), ss);     /* mov [si+0x79], ss */
    II(0x0013ceb8, 0x1)   pushw(ss);                            /* push ss */
    II(0x0013ceb9, 0x1)   popw(es);                             /* pop es */
    II(0x0013ceba, 0x4)   mov(memd_a16(ds, si + 0x75), esp);    /* mov [si+0x75], esp */
    II(0x0013cebe, 0x4)   lss(sp, ds, si + 0x7b);               /* lss sp, [si+0x7b] */
    II(0x0013cec2, 0x2)   mov(ds, cx);                          /* mov ds, cx */
    II(0x0013cec4, 0x6)   pushd(memd_a32(es, ebp + 0x2c));      /* push dword [es:ebp+0x2c] */
    II(0x0013ceca, 0x6)   pushd(memd_a32(es, ebp + 0x28));      /* push dword [es:ebp+0x28] */
    II(0x0013ced0, 0x6)   pushd(memd_a32(es, ebp + 0x24));      /* push dword [es:ebp+0x24] */
    II(0x0013ced6, 0x6)   pushd(memd_a32(es, ebp + 0x20));      /* push dword [es:ebp+0x20] */
    II(0x0013cedc, 0x6)   pushd(memd_a32(es, ebp + 0x1c));      /* push dword [es:ebp+0x1c] */
    II(0x0013cee2, 0x6)   pushd(memd_a32(es, ebp + 0x18));      /* push dword [es:ebp+0x18] */
    II(0x0013cee8, 0x6)   pushd(memd_a32(es, ebp + 0x14));      /* push dword [es:ebp+0x14] */
    II(0x0013ceee, 0x6)   pushd(memd_a32(es, ebp + 0x10));      /* push dword [es:ebp+0x10] */
    II(0x0013cef4, 0x6)   pushd(memd_a32(es, ebp + 0xc));       /* push dword [es:ebp+0xc] */
    II(0x0013cefa, 0x6)   pushd(memd_a32(es, ebp + 0x8));       /* push dword [es:ebp+0x8] */
    II(0x0013cf00, 0x6)   pushd(memd_a32(es, ebp + 0x4));       /* push dword [es:ebp+0x4] */
    II(0x0013cf06, 0x5)   pushw(memw_a32(es, ebp + 0x2));       /* push word [es:ebp+0x2] */
    II(0x0013cf0b, 0x5)   pushw(memw_a32(es, ebp + 0));         /* push word [es:ebp+0x0] */
    II(0x0013cf10, 0x6)   pushd(memd_a32(es, ebp - 0x4));       /* push dword [es:ebp-0x4] */
    II(0x0013cf16, 0x2)   mov(bp, sp);                          /* mov bp, sp */
    II(0x0013cf18, 0x3)   add(bp, 0x4);                         /* add bp, 0x4 */
    II(0x0013cf1b, 0x4)   movzx(esp, sp);                       /* movzx esp, sp */
    II(0x0013cf1f, 0x4)   movzx(ebp, bp);                       /* movzx ebp, bp */
    II(0x0013cf23, 0x1)   sti();                                /* sti  */
    II(0x0013cf24, 0x2)   jmpw_abs(ax);                         /* jmp ax */
FUNC_END

