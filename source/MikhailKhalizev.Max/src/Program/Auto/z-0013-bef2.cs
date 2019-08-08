using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("1d421758-61b4-4a97-91a8-6548276511b2")]
        public void Method_0013_bef2()
        {
            ii(0x13_bef2, 4); enterw(0x2e, 0);                          /* enter 0x2e, 0x0 */
            ii(0x13_bef6, 1); pushw(di);                                /* push di */
            ii(0x13_bef7, 1); pushw(si);                                /* push si */
            ii(0x13_bef8, 1); pushw(ds);                                /* push ds */
            ii(0x13_bef9, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x13_befc, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x13_befe, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x13_bf00, 3); mov(memw_a16[ss, bp - 0x10], ax);         /* mov [bp-0x10], ax */
            ii(0x13_bf03, 3); mov(memw_a16[ss, bp - 0x12], ax);         /* mov [bp-0x12], ax */
            ii(0x13_bf06, 3); mov(memw_a16[ss, bp - 0x2], ax);          /* mov [bp-0x2], ax */
            ii(0x13_bf09, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x13_bf0c, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x13_bf0f, 1); pushw(cs);                                /* push cs */
            ii(0x13_bf10, 3); callw(0x13_c79c, 0x889);                  /* call 0xc79c */
            ii(0x13_bf13, 3); add(sp, 0x2);                             /* add sp, 0x2 */
            ii(0x13_bf16, 3); mov(memw_a16[ss, bp - 0x1e], ax);         /* mov [bp-0x1e], ax */
            ii(0x13_bf19, 3); mov(memw_a16[ss, bp - 0x1c], dx);         /* mov [bp-0x1c], dx */
            ii(0x13_bf1c, 3); mov(memw_a16[ss, bp - 0x16], ax);         /* mov [bp-0x16], ax */
            ii(0x13_bf1f, 3); mov(memw_a16[ss, bp - 0x14], dx);         /* mov [bp-0x14], dx */
            ii(0x13_bf22, 3); cmp(ax, 0xffff);                          /* cmp ax, 0xffff */
            ii(0x13_bf25, 2); if(jnzw(0x13_bf2e, 0x7)) goto l_0x13_bf2e; /* jnz 0xbf2e */
            ii(0x13_bf27, 2); cmp(dx, ax);                              /* cmp dx, ax */
            ii(0x13_bf29, 2); if(jnzw(0x13_bf2e, 0x3)) goto l_0x13_bf2e; /* jnz 0xbf2e */
            ii(0x13_bf2b, 3); jmpw(0x13_c444, 0x516); goto l_0x13_c444; /* jmp 0xc444 */
        l_0x13_bf2e:
            ii(0x13_bf2e, 3); add(ax, 0);                               /* add ax, 0x0 */
            ii(0x13_bf31, 3); adc(dx, 0x1);                             /* adc dx, 0x1 */
            ii(0x13_bf34, 2); mov(dh, dl);                              /* mov dh, dl */
            ii(0x13_bf36, 2); mov(dl, ah);                              /* mov dl, ah */
            ii(0x13_bf38, 2); mov(ah, al);                              /* mov ah, al */
            ii(0x13_bf3a, 2); sub(al, al);                              /* sub al, al */
            ii(0x13_bf3c, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_bf3e, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_bf40, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_bf42, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_bf44, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_bf46, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_bf48, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_bf4a, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_bf4c, 3); les(bx, ss, bp + 0xc);                    /* les bx, [bp+0xc] */
            ii(0x13_bf4f, 3); mov(memw_a16[es, bx], ax);                /* mov [es:bx], ax */
            ii(0x13_bf52, 4); mov(memw_a16[es, bx + 0x2], dx);          /* mov [es:bx+0x2], dx */
            ii(0x13_bf56, 3); mov(ax, memw_a16[ss, bp - 0x16]);         /* mov ax, [bp-0x16] */
            ii(0x13_bf59, 3); mov(dx, memw_a16[ss, bp - 0x14]);         /* mov dx, [bp-0x14] */
            ii(0x13_bf5c, 3); add(ax, memw_a16[ss, bp + 0x8]);          /* add ax, [bp+0x8] */
            ii(0x13_bf5f, 3); adc(dx, memw_a16[ss, bp + 0xa]);          /* adc dx, [bp+0xa] */
            ii(0x13_bf62, 4); cmp(dx, memw_a16[ds, 0x4fd2]);            /* cmp dx, [0x4fd2] */
            ii(0x13_bf66, 2); if(jbw(0x13_bf78, 0x10)) goto l_0x13_bf78; /* jb 0xbf78 */
            ii(0x13_bf68, 2); if(jaw(0x13_bf70, 0x6)) goto l_0x13_bf70; /* ja 0xbf70 */
            ii(0x13_bf6a, 4); cmp(ax, memw_a16[ds, 0x4fd0]);            /* cmp ax, [0x4fd0] */
            ii(0x13_bf6e, 2); if(jbew(0x13_bf78, 0x8)) goto l_0x13_bf78; /* jbe 0xbf78 */
        l_0x13_bf70:
            ii(0x13_bf70, 3); mov(ax, 0x8016);                          /* mov ax, 0x8016 */
            ii(0x13_bf73, 1); popw(ds);                                 /* pop ds */
            ii(0x13_bf74, 1); popw(si);                                 /* pop si */
            ii(0x13_bf75, 1); popw(di);                                 /* pop di */
            ii(0x13_bf76, 1); leavew();                                 /* leave */
            ii(0x13_bf77, 1); retfw(); return;                          /* retf */
        l_0x13_bf78:
            ii(0x13_bf78, 3); pushw(memw_a16[ss, bp - 0x1c]);           /* push word [bp-0x1c] */
            ii(0x13_bf7b, 3); pushw(memw_a16[ss, bp - 0x1e]);           /* push word [bp-0x1e] */
            ii(0x13_bf7e, 4); pushw(memw_a16[ds, 0x4ff6]);              /* push word [0x4ff6] */
            ii(0x13_bf82, 4); pushw(memw_a16[ds, 0x4ff4]);              /* push word [0x4ff4] */
            ii(0x13_bf86, 3); callw(0x13_90c4, -0x2ec5);                /* call 0x90c4 */
            ii(0x13_bf89, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x13_bf8c, 3); cmp(ax, memw_a16[ss, bp + 0x6]);          /* cmp ax, [bp+0x6] */
            ii(0x13_bf8f, 2); if(jnzw(0x13_bfa4, 0x13)) goto l_0x13_bfa4; /* jnz 0xbfa4 */
            ii(0x13_bf91, 4); add(memw_a16[ss, bp - 0x4], 0x1);         /* add word [bp-0x4], 0x1 */
            ii(0x13_bf95, 4); adc(memw_a16[ss, bp - 0x2], 0);           /* adc word [bp-0x2], 0x0 */
            ii(0x13_bf99, 4); add(memw_a16[ss, bp - 0x1e], 0x1);        /* add word [bp-0x1e], 0x1 */
            ii(0x13_bf9d, 4); adc(memw_a16[ss, bp - 0x1c], 0);          /* adc word [bp-0x1c], 0x0 */
            ii(0x13_bfa1, 2); jmpw(0x13_bf78, -0x2b); goto l_0x13_bf78; /* jmp 0xbf78 */
        //    ii(0x13_bfa3, 1); nop();                                    /* nop */
        l_0x13_bfa4:
            ii(0x13_bfa4, 3); mov(ax, memw_a16[ss, bp + 0x8]);          /* mov ax, [bp+0x8] */
            ii(0x13_bfa7, 3); mov(dx, memw_a16[ss, bp + 0xa]);          /* mov dx, [bp+0xa] */
            ii(0x13_bfaa, 3); cmp(memw_a16[ss, bp - 0x2], dx);          /* cmp [bp-0x2], dx */
            ii(0x13_bfad, 2); if(jbw(0x13_bfe8, 0x39)) goto l_0x13_bfe8; /* jb 0xbfe8 */
            ii(0x13_bfaf, 2); if(jaw(0x13_bfb6, 0x5)) goto l_0x13_bfb6; /* ja 0xbfb6 */
            ii(0x13_bfb1, 3); cmp(memw_a16[ss, bp - 0x4], ax);          /* cmp [bp-0x4], ax */
            ii(0x13_bfb4, 2); if(jbew(0x13_bfe8, 0x32)) goto l_0x13_bfe8; /* jbe 0xbfe8 */
        l_0x13_bfb6:
            ii(0x13_bfb6, 3); mov(cx, memw_a16[ss, bp - 0x4]);          /* mov cx, [bp-0x4] */
            ii(0x13_bfb9, 3); mov(bx, memw_a16[ss, bp - 0x2]);          /* mov bx, [bp-0x2] */
            ii(0x13_bfbc, 2); sub(cx, ax);                              /* sub cx, ax */
            ii(0x13_bfbe, 2); sbb(bx, dx);                              /* sbb bx, dx */
            ii(0x13_bfc0, 1); pushw(bx);                                /* push bx */
            ii(0x13_bfc1, 1); pushw(cx);                                /* push cx */
            ii(0x13_bfc2, 3); add(ax, memw_a16[ss, bp - 0x16]);         /* add ax, [bp-0x16] */
            ii(0x13_bfc5, 3); adc(dx, memw_a16[ss, bp - 0x14]);         /* adc dx, [bp-0x14] */
            ii(0x13_bfc8, 1); pushw(dx);                                /* push dx */
            ii(0x13_bfc9, 1); pushw(ax);                                /* push ax */
            ii(0x13_bfca, 2); mov(si, cx);                              /* mov si, cx */
            ii(0x13_bfcc, 2); mov(di, bx);                              /* mov di, bx */
            ii(0x13_bfce, 1); pushw(cs);                                /* push cs */
            ii(0x13_bfcf, 3); callw(0x13_c560, 0x58e);                  /* call 0xc560 */
            ii(0x13_bfd2, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x13_bfd5, 4); add(memw_a16[ds, 0x1fac], si);            /* add [0x1fac], si */
            ii(0x13_bfd9, 4); adc(memw_a16[ds, 0x1fae], di);            /* adc [0x1fae], di */
            ii(0x13_bfdd, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x13_bfdf, 1); popw(ds);                                 /* pop ds */
            ii(0x13_bfe0, 1); popw(si);                                 /* pop si */
            ii(0x13_bfe1, 1); popw(di);                                 /* pop di */
            ii(0x13_bfe2, 1); leavew();                                 /* leave */
            ii(0x13_bfe3, 1); retfw(); return;                          /* retf */
        //  ii(0x13_bfe4, 4); Недостижимый код.
        l_0x13_bfe8:
            ii(0x13_bfe8, 3); mov(ax, memw_a16[ss, bp - 0x4]);          /* mov ax, [bp-0x4] */
            ii(0x13_bfeb, 3); mov(dx, memw_a16[ss, bp - 0x2]);          /* mov dx, [bp-0x2] */
            ii(0x13_bfee, 3); mov(memw_a16[ss, bp - 0x12], ax);         /* mov [bp-0x12], ax */
            ii(0x13_bff1, 3); mov(memw_a16[ss, bp - 0x10], dx);         /* mov [bp-0x10], dx */
        l_0x13_bff4:
            ii(0x13_bff4, 3); pushw(memw_a16[ss, bp - 0x1c]);           /* push word [bp-0x1c] */
            ii(0x13_bff7, 3); pushw(memw_a16[ss, bp - 0x1e]);           /* push word [bp-0x1e] */
            ii(0x13_bffa, 4); add(memw_a16[ss, bp - 0x1e], 0x1);        /* add word [bp-0x1e], 0x1 */
            ii(0x13_bffe, 4); adc(memw_a16[ss, bp - 0x1c], 0);          /* adc word [bp-0x1c], 0x0 */
            ii(0x13_c002, 4); pushw(memw_a16[ds, 0x4ff6]);              /* push word [0x4ff6] */
            ii(0x13_c006, 4); pushw(memw_a16[ds, 0x4ff4]);              /* push word [0x4ff4] */
            ii(0x13_c00a, 3); callw(0x13_90c4, -0x2f49);                /* call 0x90c4 */
            ii(0x13_c00d, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x13_c010, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x13_c012, 2); if(jnzw(0x13_c030, 0x1c)) goto l_0x13_c030; /* jnz 0xc030 */
            ii(0x13_c014, 3); mov(ax, memw_a16[ss, bp + 0x8]);          /* mov ax, [bp+0x8] */
            ii(0x13_c017, 3); mov(dx, memw_a16[ss, bp + 0xa]);          /* mov dx, [bp+0xa] */
            ii(0x13_c01a, 4); add(memw_a16[ss, bp - 0x12], 0x1);        /* add word [bp-0x12], 0x1 */
            ii(0x13_c01e, 4); adc(memw_a16[ss, bp - 0x10], 0);          /* adc word [bp-0x10], 0x0 */
            ii(0x13_c022, 3); cmp(memw_a16[ss, bp - 0x12], ax);         /* cmp [bp-0x12], ax */
            ii(0x13_c025, 2); if(jnzw(0x13_c02e, 0x7)) goto l_0x13_c02e; /* jnz 0xc02e */
            ii(0x13_c027, 3); cmp(memw_a16[ss, bp - 0x10], dx);         /* cmp [bp-0x10], dx */
            ii(0x13_c02a, 2); if(jnzw(0x13_c02e, 0x2)) goto l_0x13_c02e; /* jnz 0xc02e */
            ii(0x13_c02c, 2); jmpw(0x13_c030, 0x2); goto l_0x13_c030;   /* jmp 0xc030 */
        l_0x13_c02e:
            ii(0x13_c02e, 2); jmpw(0x13_bff4, -0x3c); goto l_0x13_bff4; /* jmp 0xbff4 */
        l_0x13_c030:
            ii(0x13_c030, 3); mov(ax, memw_a16[ss, bp + 0x8]);          /* mov ax, [bp+0x8] */
            ii(0x13_c033, 3); mov(dx, memw_a16[ss, bp + 0xa]);          /* mov dx, [bp+0xa] */
            ii(0x13_c036, 3); cmp(memw_a16[ss, bp - 0x12], ax);         /* cmp [bp-0x12], ax */
            ii(0x13_c039, 2); if(jzw(0x13_c03e, 0x3)) goto l_0x13_c03e; /* jz 0xc03e */
            ii(0x13_c03b, 3); jmpw(0x13_c0e0, 0xa2); goto l_0x13_c0e0;  /* jmp 0xc0e0 */
        l_0x13_c03e:
            ii(0x13_c03e, 3); cmp(memw_a16[ss, bp - 0x10], dx);         /* cmp [bp-0x10], dx */
            ii(0x13_c041, 2); if(jzw(0x13_c046, 0x3)) goto l_0x13_c046; /* jz 0xc046 */
            ii(0x13_c043, 3); jmpw(0x13_c0e0, 0x9a); goto l_0x13_c0e0;  /* jmp 0xc0e0 */
        l_0x13_c046:
            ii(0x13_c046, 2); pushw(0x1);                               /* push 0x1 */
            ii(0x13_c048, 3); sub(ax, memw_a16[ss, bp - 0x4]);          /* sub ax, [bp-0x4] */
            ii(0x13_c04b, 3); sbb(dx, memw_a16[ss, bp - 0x2]);          /* sbb dx, [bp-0x2] */
            ii(0x13_c04e, 1); pushw(dx);                                /* push dx */
            ii(0x13_c04f, 1); pushw(ax);                                /* push ax */
            ii(0x13_c050, 3); mov(ax, memw_a16[ss, bp - 0x4]);          /* mov ax, [bp-0x4] */
            ii(0x13_c053, 3); mov(dx, memw_a16[ss, bp - 0x2]);          /* mov dx, [bp-0x2] */
            ii(0x13_c056, 2); mov(dh, dl);                              /* mov dh, dl */
            ii(0x13_c058, 2); mov(dl, ah);                              /* mov dl, ah */
            ii(0x13_c05a, 2); mov(ah, al);                              /* mov ah, al */
            ii(0x13_c05c, 2); sub(al, al);                              /* sub al, al */
            ii(0x13_c05e, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_c060, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_c062, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_c064, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_c066, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_c068, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_c06a, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_c06c, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_c06e, 3); les(bx, ss, bp + 0xc);                    /* les bx, [bp+0xc] */
            ii(0x13_c071, 3); add(ax, memw_a16[es, bx]);                /* add ax, [es:bx] */
            ii(0x13_c074, 4); adc(dx, memw_a16[es, bx + 0x2]);          /* adc dx, [es:bx+0x2] */
            ii(0x13_c078, 1); pushw(dx);                                /* push dx */
            ii(0x13_c079, 1); pushw(ax);                                /* push ax */
            ii(0x13_c07a, 3); mov(al, memb_a16[ds, 0x51a7]);            /* mov al, [0x51a7] */
            ii(0x13_c07d, 2); sub(ah, ah);                              /* sub ah, ah */
            ii(0x13_c07f, 1); pushw(ax);                                /* push ax */
            ii(0x13_c080, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x13_c083, 1); pushw(cs);                                /* push cs */
            ii(0x13_c084, 3); callw(0x13_c48e, 0x407);                  /* call 0xc48e */
            ii(0x13_c087, 3); add(sp, 0xe);                             /* add sp, 0xe */
            ii(0x13_c08a, 3); mov(ax, memw_a16[ss, bp - 0x4]);          /* mov ax, [bp-0x4] */
            ii(0x13_c08d, 3); mov(dx, memw_a16[ss, bp - 0x2]);          /* mov dx, [bp-0x2] */
            ii(0x13_c090, 3); sub(ax, memw_a16[ss, bp + 0x8]);          /* sub ax, [bp+0x8] */
            ii(0x13_c093, 3); sbb(dx, memw_a16[ss, bp + 0xa]);          /* sbb dx, [bp+0xa] */
            ii(0x13_c096, 4); add(memw_a16[ds, 0x1fc4], ax);            /* add [0x1fc4], ax */
            ii(0x13_c09a, 4); adc(memw_a16[ds, 0x1fc6], dx);            /* adc [0x1fc6], dx */
            ii(0x13_c09e, 4); add(memw_a16[ds, 0x1fac], ax);            /* add [0x1fac], ax */
            ii(0x13_c0a2, 4); adc(memw_a16[ds, 0x1fae], dx);            /* adc [0x1fae], dx */
            ii(0x13_c0a6, 5); cmp(memw_a16[ds, 0x1fae], 0);             /* cmp word [0x1fae], 0x0 */
            ii(0x13_c0ab, 2); if(jgew(0x13_c0b5, 0x8)) goto l_0x13_c0b5; /* jge 0xc0b5 */
            ii(0x13_c0ad, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x13_c0af, 3); mov(memw_a16[ds, 0x1fae], ax);            /* mov [0x1fae], ax */
            ii(0x13_c0b2, 3); mov(memw_a16[ds, 0x1fac], ax);            /* mov [0x1fac], ax */
        l_0x13_c0b5:
            ii(0x13_c0b5, 3); mov(ax, memw_a16[ss, bp - 0x4]);          /* mov ax, [bp-0x4] */
            ii(0x13_c0b8, 3); mov(dx, memw_a16[ss, bp - 0x2]);          /* mov dx, [bp-0x2] */
            ii(0x13_c0bb, 3); sub(ax, memw_a16[ss, bp + 0x8]);          /* sub ax, [bp+0x8] */
            ii(0x13_c0be, 3); sbb(dx, memw_a16[ss, bp + 0xa]);          /* sbb dx, [bp+0xa] */
            ii(0x13_c0c1, 4); add(memw_a16[ds, 0x1fbc], ax);            /* add [0x1fbc], ax */
            ii(0x13_c0c5, 4); adc(memw_a16[ds, 0x1fbe], dx);            /* adc [0x1fbe], dx */
            ii(0x13_c0c9, 5); cmp(memw_a16[ds, 0x1fbe], 0);             /* cmp word [0x1fbe], 0x0 */
            ii(0x13_c0ce, 2); if(jgew(0x13_c0d8, 0x8)) goto l_0x13_c0d8; /* jge 0xc0d8 */
            ii(0x13_c0d0, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x13_c0d2, 3); mov(memw_a16[ds, 0x1fbe], ax);            /* mov [0x1fbe], ax */
            ii(0x13_c0d5, 3); mov(memw_a16[ds, 0x1fbc], ax);            /* mov [0x1fbc], ax */
        l_0x13_c0d8:
            ii(0x13_c0d8, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x13_c0da, 1); popw(ds);                                 /* pop ds */
            ii(0x13_c0db, 1); popw(si);                                 /* pop si */
            ii(0x13_c0dc, 1); popw(di);                                 /* pop di */
            ii(0x13_c0dd, 1); leavew();                                 /* leave */
            ii(0x13_c0de, 1); retfw(); return;                          /* retf */
        //  ii(0x13_c0df, 1); Недостижимый код.
        l_0x13_c0e0:
            ii(0x13_c0e0, 3); sub(ax, memw_a16[ss, bp - 0x4]);          /* sub ax, [bp-0x4] */
            ii(0x13_c0e3, 3); sbb(dx, memw_a16[ss, bp - 0x2]);          /* sbb dx, [bp-0x2] */
            ii(0x13_c0e6, 4); cmp(dx, memw_a16[ds, 0x1fc6]);            /* cmp dx, [0x1fc6] */
            ii(0x13_c0ea, 2); if(jlw(0x13_c0fc, 0x10)) goto l_0x13_c0fc; /* jl 0xc0fc */
            ii(0x13_c0ec, 2); if(jgw(0x13_c0f4, 0x6)) goto l_0x13_c0f4; /* jg 0xc0f4 */
            ii(0x13_c0ee, 4); cmp(ax, memw_a16[ds, 0x1fc4]);            /* cmp ax, [0x1fc4] */
            ii(0x13_c0f2, 2); if(jbew(0x13_c0fc, 0x8)) goto l_0x13_c0fc; /* jbe 0xc0fc */
        l_0x13_c0f4:
            ii(0x13_c0f4, 3); mov(ax, 0x8016);                          /* mov ax, 0x8016 */
            ii(0x13_c0f7, 1); popw(ds);                                 /* pop ds */
            ii(0x13_c0f8, 1); popw(si);                                 /* pop si */
            ii(0x13_c0f9, 1); popw(di);                                 /* pop di */
            ii(0x13_c0fa, 1); leavew();                                 /* leave */
            ii(0x13_c0fb, 1); retfw(); return;                          /* retf */
        l_0x13_c0fc:
            ii(0x13_c0fc, 3); mov(ax, memw_a16[ds, 0x1a]);              /* mov ax, [0x1a] */
            ii(0x13_c0ff, 4); or(ax, memw_a16[ds, 0x18]);               /* or ax, [0x18] */
            ii(0x13_c103, 2); if(jzw(0x13_c162, 0x5d)) goto l_0x13_c162; /* jz 0xc162 */
            ii(0x13_c105, 3); mov(ax, memw_a16[ss, bp - 0x4]);          /* mov ax, [bp-0x4] */
            ii(0x13_c108, 3); mov(dx, memw_a16[ss, bp - 0x2]);          /* mov dx, [bp-0x2] */
            ii(0x13_c10b, 4); sub(ax, memw_a16[ds, 0x1fc4]);            /* sub ax, [0x1fc4] */
            ii(0x13_c10f, 4); sbb(dx, memw_a16[ds, 0x1fc6]);            /* sbb dx, [0x1fc6] */
            ii(0x13_c113, 4); sub(ax, memw_a16[ds, 0x1fc0]);            /* sub ax, [0x1fc0] */
            ii(0x13_c117, 4); sbb(dx, memw_a16[ds, 0x1fc2]);            /* sbb dx, [0x1fc2] */
            ii(0x13_c11b, 4); add(ax, memw_a16[ds, 0x1fb4]);            /* add ax, [0x1fb4] */
            ii(0x13_c11f, 4); adc(dx, memw_a16[ds, 0x1fb6]);            /* adc dx, [0x1fb6] */
            ii(0x13_c123, 3); add(ax, 0x4);                             /* add ax, 0x4 */
            ii(0x13_c126, 3); adc(dx, 0);                               /* adc dx, 0x0 */
            ii(0x13_c129, 3); mov(memw_a16[ss, bp - 0x1a], ax);         /* mov [bp-0x1a], ax */
            ii(0x13_c12c, 3); mov(memw_a16[ss, bp - 0x18], dx);         /* mov [bp-0x18], dx */
            ii(0x13_c12f, 4); mov(cx, memw_a16[ds, 0x1f50]);            /* mov cx, [0x1f50] */
            ii(0x13_c133, 4); mov(bx, memw_a16[ds, 0x1f52]);            /* mov bx, [0x1f52] */
            ii(0x13_c137, 2); cmp(dx, bx);                              /* cmp dx, bx */
            ii(0x13_c139, 2); if(jlw(0x13_c162, 0x27)) goto l_0x13_c162; /* jl 0xc162 */
            ii(0x13_c13b, 2); if(jgw(0x13_c141, 0x4)) goto l_0x13_c141; /* jg 0xc141 */
            ii(0x13_c13d, 2); cmp(ax, cx);                              /* cmp ax, cx */
            ii(0x13_c13f, 2); if(jbew(0x13_c162, 0x21)) goto l_0x13_c162; /* jbe 0xc162 */
        l_0x13_c141:
            ii(0x13_c141, 2); sub(ax, cx);                              /* sub ax, cx */
            ii(0x13_c143, 2); sbb(dx, bx);                              /* sbb dx, bx */
            ii(0x13_c145, 3); mov(memw_a16[ss, bp - 0x2a], ax);         /* mov [bp-0x2a], ax */
            ii(0x13_c148, 3); mov(memw_a16[ss, bp - 0x28], dx);         /* mov [bp-0x28], dx */
            ii(0x13_c14b, 1); pushw(dx);                                /* push dx */
            ii(0x13_c14c, 1); pushw(ax);                                /* push ax */
            ii(0x13_c14d, 1); nop();                                    /* nop */
            ii(0x13_c14e, 1); pushw(cs);                                /* push cs */
            ii(0x13_c14f, 3); callw(0x13_8ba6, -0x35ac);                /* call 0x8ba6 */
            ii(0x13_c152, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x13_c155, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x13_c157, 2); if(jnzw(0x13_c162, 0x9)) goto l_0x13_c162; /* jnz 0xc162 */
            ii(0x13_c159, 3); mov(ax, 0x8014);                          /* mov ax, 0x8014 */
            ii(0x13_c15c, 1); popw(ds);                                 /* pop ds */
            ii(0x13_c15d, 1); popw(si);                                 /* pop si */
            ii(0x13_c15e, 1); popw(di);                                 /* pop di */
            ii(0x13_c15f, 1); leavew();                                 /* leave */
            ii(0x13_c160, 1); retfw(); return;                          /* retf */
        //  ii(0x13_c161, 1); Недостижимый код.
        l_0x13_c162:
            ii(0x13_c162, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x13_c165, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x13_c168, 1); pushw(cs);                                /* push cs */
            ii(0x13_c169, 3); callw(0x13_bbf8, -0x574);                 /* call 0xbbf8 */
            ii(0x13_c16c, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x13_c16f, 3); mov(memw_a16[ss, bp - 0x1e], ax);         /* mov [bp-0x1e], ax */
            ii(0x13_c172, 3); mov(memw_a16[ss, bp - 0x1c], dx);         /* mov [bp-0x1c], dx */
            ii(0x13_c175, 3); cmp(ax, 0xffff);                          /* cmp ax, 0xffff */
            ii(0x13_c178, 2); if(jnzw(0x13_c181, 0x7)) goto l_0x13_c181; /* jnz 0xc181 */
            ii(0x13_c17a, 2); cmp(dx, ax);                              /* cmp dx, ax */
            ii(0x13_c17c, 2); if(jnzw(0x13_c181, 0x3)) goto l_0x13_c181; /* jnz 0xc181 */
            ii(0x13_c17e, 3); jmpw(0x13_c43c, 0x2bb); goto l_0x13_c43c; /* jmp 0xc43c */
        l_0x13_c181:
            ii(0x13_c181, 3); add(ax, 0);                               /* add ax, 0x0 */
            ii(0x13_c184, 3); adc(dx, 0x1);                             /* adc dx, 0x1 */
            ii(0x13_c187, 2); mov(dh, dl);                              /* mov dh, dl */
            ii(0x13_c189, 2); mov(dl, ah);                              /* mov dl, ah */
            ii(0x13_c18b, 2); mov(ah, al);                              /* mov ah, al */
            ii(0x13_c18d, 2); sub(al, al);                              /* sub al, al */
            ii(0x13_c18f, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_c191, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_c193, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_c195, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_c197, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_c199, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_c19b, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_c19d, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_c19f, 3); mov(memw_a16[ss, bp - 0xa], ax);          /* mov [bp-0xa], ax */
            ii(0x13_c1a2, 3); mov(memw_a16[ss, bp - 0x8], dx);          /* mov [bp-0x8], dx */
            ii(0x13_c1a5, 3); les(bx, ss, bp + 0xc);                    /* les bx, [bp+0xc] */
            ii(0x13_c1a8, 3); mov(memw_a16[es, bx], ax);                /* mov [es:bx], ax */
            ii(0x13_c1ab, 4); mov(memw_a16[es, bx + 0x2], dx);          /* mov [es:bx+0x2], dx */
            ii(0x13_c1af, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x13_c1b1, 3); mov(memw_a16[ss, bp - 0x10], ax);         /* mov [bp-0x10], ax */
            ii(0x13_c1b4, 3); mov(memw_a16[ss, bp - 0x12], ax);         /* mov [bp-0x12], ax */
            ii(0x13_c1b7, 2); jmpw(0x13_c1c2, 0x9); goto l_0x13_c1c2;   /* jmp 0xc1c2 */
        //    ii(0x13_c1b9, 1); nop();                                    /* nop */
        l_0x13_c1ba:
            ii(0x13_c1ba, 4); add(memw_a16[ss, bp - 0x12], 0x1);        /* add word [bp-0x12], 0x1 */
            ii(0x13_c1be, 4); adc(memw_a16[ss, bp - 0x10], 0);          /* adc word [bp-0x10], 0x0 */
        l_0x13_c1c2:
            ii(0x13_c1c2, 3); mov(ax, memw_a16[ss, bp - 0x4]);          /* mov ax, [bp-0x4] */
            ii(0x13_c1c5, 3); mov(dx, memw_a16[ss, bp - 0x2]);          /* mov dx, [bp-0x2] */
            ii(0x13_c1c8, 3); cmp(memw_a16[ss, bp - 0x10], dx);         /* cmp [bp-0x10], dx */
            ii(0x13_c1cb, 2); if(jbew(0x13_c1d0, 0x3)) goto l_0x13_c1d0; /* jbe 0xc1d0 */
            ii(0x13_c1cd, 3); jmpw(0x13_c39e, 0x1ce); goto l_0x13_c39e; /* jmp 0xc39e */
        l_0x13_c1d0:
            ii(0x13_c1d0, 2); if(jbw(0x13_c1da, 0x8)) goto l_0x13_c1da; /* jb 0xc1da */
            ii(0x13_c1d2, 3); cmp(memw_a16[ss, bp - 0x12], ax);         /* cmp [bp-0x12], ax */
            ii(0x13_c1d5, 2); if(jbw(0x13_c1da, 0x3)) goto l_0x13_c1da; /* jb 0xc1da */
            ii(0x13_c1d7, 3); jmpw(0x13_c39e, 0x1c4); goto l_0x13_c39e; /* jmp 0xc39e */
        l_0x13_c1da:
            ii(0x13_c1da, 3); mov(ax, memw_a16[ss, bp - 0x12]);         /* mov ax, [bp-0x12] */
            ii(0x13_c1dd, 3); mov(dx, memw_a16[ss, bp - 0x10]);         /* mov dx, [bp-0x10] */
            ii(0x13_c1e0, 3); add(ax, memw_a16[ss, bp - 0x16]);         /* add ax, [bp-0x16] */
            ii(0x13_c1e3, 3); adc(dx, memw_a16[ss, bp - 0x14]);         /* adc dx, [bp-0x14] */
            ii(0x13_c1e6, 1); pushw(dx);                                /* push dx */
            ii(0x13_c1e7, 1); pushw(ax);                                /* push ax */
            ii(0x13_c1e8, 4); pushw(memw_a16[ds, 0x4ff6]);              /* push word [0x4ff6] */
            ii(0x13_c1ec, 4); pushw(memw_a16[ds, 0x4ff4]);              /* push word [0x4ff4] */
            ii(0x13_c1f0, 2); mov(si, ax);                              /* mov si, ax */
            ii(0x13_c1f2, 2); mov(di, dx);                              /* mov di, dx */
            ii(0x13_c1f4, 3); callw(0x13_90c4, -0x3133);                /* call 0x90c4 */
            ii(0x13_c1f7, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x13_c1fa, 1); pushw(ax);                                /* push ax */
            ii(0x13_c1fb, 3); mov(ax, memw_a16[ss, bp - 0x12]);         /* mov ax, [bp-0x12] */
            ii(0x13_c1fe, 3); mov(dx, memw_a16[ss, bp - 0x10]);         /* mov dx, [bp-0x10] */
            ii(0x13_c201, 3); add(ax, memw_a16[ss, bp - 0x1e]);         /* add ax, [bp-0x1e] */
            ii(0x13_c204, 3); adc(dx, memw_a16[ss, bp - 0x1c]);         /* adc dx, [bp-0x1c] */
            ii(0x13_c207, 1); pushw(dx);                                /* push dx */
            ii(0x13_c208, 1); pushw(ax);                                /* push ax */
            ii(0x13_c209, 4); pushw(memw_a16[ds, 0x4ff6]);              /* push word [0x4ff6] */
            ii(0x13_c20d, 4); pushw(memw_a16[ds, 0x4ff4]);              /* push word [0x4ff4] */
            ii(0x13_c211, 3); mov(memw_a16[ss, bp - 0x2e], ax);         /* mov [bp-0x2e], ax */
            ii(0x13_c214, 3); mov(memw_a16[ss, bp - 0x2c], dx);         /* mov [bp-0x2c], dx */
            ii(0x13_c217, 3); callw(0x13_91e3, -0x3037);                /* call 0x91e3 */
            ii(0x13_c21a, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x13_c21d, 1); pushw(di);                                /* push di */
            ii(0x13_c21e, 1); pushw(si);                                /* push si */
            ii(0x13_c21f, 4); pushw(memw_a16[ds, 0x1fa6]);              /* push word [0x1fa6] */
            ii(0x13_c223, 4); pushw(memw_a16[ds, 0x1fa4]);              /* push word [0x1fa4] */
            ii(0x13_c227, 3); callw(0x13_90c4, -0x3166);                /* call 0x90c4 */
            ii(0x13_c22a, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x13_c22d, 1); pushw(ax);                                /* push ax */
            ii(0x13_c22e, 3); pushw(memw_a16[ss, bp - 0x2c]);           /* push word [bp-0x2c] */
            ii(0x13_c231, 3); pushw(memw_a16[ss, bp - 0x2e]);           /* push word [bp-0x2e] */
            ii(0x13_c234, 4); pushw(memw_a16[ds, 0x1fa6]);              /* push word [0x1fa6] */
            ii(0x13_c238, 4); pushw(memw_a16[ds, 0x1fa4]);              /* push word [0x1fa4] */
            ii(0x13_c23c, 3); callw(0x13_91e3, -0x305c);                /* call 0x91e3 */
            ii(0x13_c23f, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x13_c242, 1); pushw(di);                                /* push di */
            ii(0x13_c243, 1); pushw(si);                                /* push si */
            ii(0x13_c244, 4); pushw(memw_a16[ds, 0x4f8e]);              /* push word [0x4f8e] */
            ii(0x13_c248, 4); pushw(memw_a16[ds, 0x4f8c]);              /* push word [0x4f8c] */
            ii(0x13_c24c, 3); callw(0x13_9208, -0x3047);                /* call 0x9208 */
            ii(0x13_c24f, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x13_c252, 3); mov(memw_a16[ss, bp - 0x22], ax);         /* mov [bp-0x22], ax */
            ii(0x13_c255, 3); mov(memw_a16[ss, bp - 0x20], dx);         /* mov [bp-0x20], dx */
            ii(0x13_c258, 1); pushw(dx);                                /* push dx */
            ii(0x13_c259, 1); pushw(ax);                                /* push ax */
            ii(0x13_c25a, 3); pushw(memw_a16[ss, bp - 0x2c]);           /* push word [bp-0x2c] */
            ii(0x13_c25d, 3); pushw(memw_a16[ss, bp - 0x2e]);           /* push word [bp-0x2e] */
            ii(0x13_c260, 4); pushw(memw_a16[ds, 0x4f8e]);              /* push word [0x4f8e] */
            ii(0x13_c264, 4); pushw(memw_a16[ds, 0x4f8c]);              /* push word [0x4f8c] */
            ii(0x13_c268, 3); callw(0x13_9235, -0x3036);                /* call 0x9235 */
            ii(0x13_c26b, 3); add(sp, 0xc);                             /* add sp, 0xc */
            ii(0x13_c26e, 2); pushw(0);                                 /* push 0x0 */
            ii(0x13_c270, 1); pushw(di);                                /* push di */
            ii(0x13_c271, 1); pushw(si);                                /* push si */
            ii(0x13_c272, 4); pushw(memw_a16[ds, 0x4ff6]);              /* push word [0x4ff6] */
            ii(0x13_c276, 4); pushw(memw_a16[ds, 0x4ff4]);              /* push word [0x4ff4] */
            ii(0x13_c27a, 3); callw(0x13_91e3, -0x309a);                /* call 0x91e3 */
            ii(0x13_c27d, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x13_c280, 2); pushw(0);                                 /* push 0x0 */
            ii(0x13_c282, 1); pushw(di);                                /* push di */
            ii(0x13_c283, 1); pushw(si);                                /* push si */
            ii(0x13_c284, 4); pushw(memw_a16[ds, 0x1fa6]);              /* push word [0x1fa6] */
            ii(0x13_c288, 4); pushw(memw_a16[ds, 0x1fa4]);              /* push word [0x1fa4] */
            ii(0x13_c28c, 3); callw(0x13_91e3, -0x30ac);                /* call 0x91e3 */
            ii(0x13_c28f, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x13_c292, 4); test(memb_a16[ss, bp - 0x22], 0x1);       /* test byte [bp-0x22], 0x1 */
            ii(0x13_c296, 2); if(jzw(0x13_c302, 0x6a)) goto l_0x13_c302; /* jz 0xc302 */
            ii(0x13_c298, 5); mov(memw_a16[ss, bp - 0x6], 0);           /* mov word [bp-0x6], 0x0 */
            ii(0x13_c29d, 2); jmpw(0x13_c2a3, 0x4); goto l_0x13_c2a3;   /* jmp 0xc2a3 */
        //    ii(0x13_c29f, 1); nop();                                    /* nop */
        l_0x13_c2a0:
            ii(0x13_c2a0, 3); inc(memw_a16[ss, bp - 0x6]);              /* inc word [bp-0x6] */
        l_0x13_c2a3:
            ii(0x13_c2a3, 3); mov(ax, memw_a16[ss, bp - 0x6]);          /* mov ax, [bp-0x6] */
            ii(0x13_c2a6, 4); cmp(memw_a16[ds, 0x519e], ax);            /* cmp [0x519e], ax */
            ii(0x13_c2aa, 2); if(jbew(0x13_c300, 0x54)) goto l_0x13_c300; /* jbe 0xc300 */
            ii(0x13_c2ac, 3); mov(ax, memw_a16[ss, bp - 0x22]);         /* mov ax, [bp-0x22] */
            ii(0x13_c2af, 3); mov(dx, memw_a16[ss, bp - 0x20]);         /* mov dx, [bp-0x20] */
            ii(0x13_c2b2, 2); mov(al, ah);                              /* mov al, ah */
            ii(0x13_c2b4, 2); mov(ah, dl);                              /* mov ah, dl */
            ii(0x13_c2b6, 2); mov(dl, dh);                              /* mov dl, dh */
            ii(0x13_c2b8, 2); sub(dh, dh);                              /* sub dh, dh */
            ii(0x13_c2ba, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x13_c2bc, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x13_c2be, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x13_c2c0, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x13_c2c2, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x13_c2c4, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x13_c2c6, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x13_c2c8, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x13_c2ca, 3); mov(bx, memw_a16[ss, bp - 0x6]);          /* mov bx, [bp-0x6] */
            ii(0x13_c2cd, 3); shl(bx, 0x2);                             /* shl bx, 0x2 */
            ii(0x13_c2d0, 4); les(si, ds, 0x4fa0);                      /* les si, [0x4fa0] */
            ii(0x13_c2d4, 3); cmp(memw_a16[es, bx + si], ax);           /* cmp [es:bx+si], ax */
            ii(0x13_c2d7, 2); if(jnzw(0x13_c2fe, 0x25)) goto l_0x13_c2fe; /* jnz 0xc2fe */
            ii(0x13_c2d9, 4); cmp(memw_a16[es, bx + si + 0x2], dx);     /* cmp [es:bx+si+0x2], dx */
            ii(0x13_c2dd, 2); if(jnzw(0x13_c2fe, 0x1f)) goto l_0x13_c2fe; /* jnz 0xc2fe */
            ii(0x13_c2df, 3); mov(ax, memw_a16[ss, bp - 0x12]);         /* mov ax, [bp-0x12] */
            ii(0x13_c2e2, 3); mov(dx, memw_a16[ss, bp - 0x10]);         /* mov dx, [bp-0x10] */
            ii(0x13_c2e5, 3); add(ax, memw_a16[ss, bp - 0x1e]);         /* add ax, [bp-0x1e] */
            ii(0x13_c2e8, 3); adc(dx, memw_a16[ss, bp - 0x1c]);         /* adc dx, [bp-0x1c] */
            ii(0x13_c2eb, 3); add(ax, 0);                               /* add ax, 0x0 */
            ii(0x13_c2ee, 3); adc(dx, 0x1);                             /* adc dx, 0x1 */
            ii(0x13_c2f1, 4); les(si, ds, 0x4fa4);                      /* les si, [0x4fa4] */
            ii(0x13_c2f5, 3); mov(memw_a16[es, bx + si], ax);           /* mov [es:bx+si], ax */
            ii(0x13_c2f8, 4); mov(memw_a16[es, bx + si + 0x2], dx);     /* mov [es:bx+si+0x2], dx */
            ii(0x13_c2fc, 2); jmpw(0x13_c300, 0x2); goto l_0x13_c300;   /* jmp 0xc300 */
        l_0x13_c2fe:
            ii(0x13_c2fe, 2); jmpw(0x13_c2a0, -0x60); goto l_0x13_c2a0; /* jmp 0xc2a0 */
        l_0x13_c300:
            ii(0x13_c300, 2); jmpw(0x13_c363, 0x61); goto l_0x13_c363;  /* jmp 0xc363 */
        l_0x13_c302:
            ii(0x13_c302, 3); mov(ax, memw_a16[ss, bp - 0x12]);         /* mov ax, [bp-0x12] */
            ii(0x13_c305, 3); mov(dx, memw_a16[ss, bp - 0x10]);         /* mov dx, [bp-0x10] */
            ii(0x13_c308, 3); add(ax, memw_a16[ss, bp - 0x16]);         /* add ax, [bp-0x16] */
            ii(0x13_c30b, 3); adc(dx, memw_a16[ss, bp - 0x14]);         /* adc dx, [bp-0x14] */
            ii(0x13_c30e, 1); pushw(dx);                                /* push dx */
            ii(0x13_c30f, 1); pushw(ax);                                /* push ax */
            ii(0x13_c310, 3); callw(0x13_8f06, -0x340d);                /* call 0x8f06 */
            ii(0x13_c313, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x13_c316, 3); mov(memw_a16[ss, bp - 0x26], ax);         /* mov [bp-0x26], ax */
            ii(0x13_c319, 3); mov(memw_a16[ss, bp - 0x24], dx);         /* mov [bp-0x24], dx */
            ii(0x13_c31c, 3); cmp(ax, 0xffff);                          /* cmp ax, 0xffff */
            ii(0x13_c31f, 2); if(jnzw(0x13_c325, 0x4)) goto l_0x13_c325; /* jnz 0xc325 */
            ii(0x13_c321, 2); or(dx, dx);                               /* or dx, dx */
            ii(0x13_c323, 2); if(jzw(0x13_c363, 0x3e)) goto l_0x13_c363; /* jz 0xc363 */
        l_0x13_c325:
            ii(0x13_c325, 1); pushw(dx);                                /* push dx */
            ii(0x13_c326, 1); pushw(ax);                                /* push ax */
            ii(0x13_c327, 4); pushw(memw_a16[ds, 0x4fb6]);              /* push word [0x4fb6] */
            ii(0x13_c32b, 4); pushw(memw_a16[ds, 0x4fb4]);              /* push word [0x4fb4] */
            ii(0x13_c32f, 3); callw(0x13_9208, -0x312a);                /* call 0x9208 */
            ii(0x13_c332, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x13_c335, 3); mov(memw_a16[ss, bp - 0xe], ax);          /* mov [bp-0xe], ax */
            ii(0x13_c338, 3); mov(memw_a16[ss, bp - 0xc], dx);          /* mov [bp-0xc], dx */
            ii(0x13_c33b, 3); xor(ax, memw_a16[ss, bp - 0x1e]);         /* xor ax, [bp-0x1e] */
            ii(0x13_c33e, 3); xor(dx, memw_a16[ss, bp - 0x1c]);         /* xor dx, [bp-0x1c] */
            ii(0x13_c341, 2); sub(dh, dh);                              /* sub dh, dh */
            ii(0x13_c343, 3); xor(memw_a16[ss, bp - 0xe], ax);          /* xor [bp-0xe], ax */
            ii(0x13_c346, 3); xor(memw_a16[ss, bp - 0xc], dx);          /* xor [bp-0xc], dx */
            ii(0x13_c349, 3); pushw(memw_a16[ss, bp - 0xc]);            /* push word [bp-0xc] */
            ii(0x13_c34c, 3); pushw(memw_a16[ss, bp - 0xe]);            /* push word [bp-0xe] */
            ii(0x13_c34f, 3); pushw(memw_a16[ss, bp - 0x24]);           /* push word [bp-0x24] */
            ii(0x13_c352, 3); pushw(memw_a16[ss, bp - 0x26]);           /* push word [bp-0x26] */
            ii(0x13_c355, 4); pushw(memw_a16[ds, 0x4fb6]);              /* push word [0x4fb6] */
            ii(0x13_c359, 4); pushw(memw_a16[ds, 0x4fb4]);              /* push word [0x4fb4] */
            ii(0x13_c35d, 3); callw(0x13_9235, -0x312b);                /* call 0x9235 */
            ii(0x13_c360, 3); add(sp, 0xc);                             /* add sp, 0xc */
        l_0x13_c363:
            ii(0x13_c363, 4); and(memb_a16[ss, bp - 0x22], -0x2 /* 0xfe */); /* and byte [bp-0x22], 0xfe */
            ii(0x13_c367, 3); mov(ax, memw_a16[ss, bp - 0x22]);         /* mov ax, [bp-0x22] */
            ii(0x13_c36a, 3); and(ah, 0xf);                             /* and ah, 0xf */
            ii(0x13_c36d, 3); mov(memw_a16[ss, bp - 0x22], ax);         /* mov [bp-0x22], ax */
            ii(0x13_c370, 5); mov(memw_a16[ss, bp - 0x20], 0);          /* mov word [bp-0x20], 0x0 */
            ii(0x13_c375, 4); and(memb_a16[ss, bp - 0x21], -0xf /* 0xf1 */); /* and byte [bp-0x21], 0xf1 */
            ii(0x13_c379, 3); pushw(memw_a16[ss, bp - 0x20]);           /* push word [bp-0x20] */
            ii(0x13_c37c, 3); pushw(memw_a16[ss, bp - 0x22]);           /* push word [bp-0x22] */
            ii(0x13_c37f, 3); mov(ax, memw_a16[ss, bp - 0x12]);         /* mov ax, [bp-0x12] */
            ii(0x13_c382, 3); mov(dx, memw_a16[ss, bp - 0x10]);         /* mov dx, [bp-0x10] */
            ii(0x13_c385, 3); add(ax, memw_a16[ss, bp - 0x16]);         /* add ax, [bp-0x16] */
            ii(0x13_c388, 3); adc(dx, memw_a16[ss, bp - 0x14]);         /* adc dx, [bp-0x14] */
            ii(0x13_c38b, 1); pushw(dx);                                /* push dx */
            ii(0x13_c38c, 1); pushw(ax);                                /* push ax */
            ii(0x13_c38d, 4); pushw(memw_a16[ds, 0x4f8e]);              /* push word [0x4f8e] */
            ii(0x13_c391, 4); pushw(memw_a16[ds, 0x4f8c]);              /* push word [0x4f8c] */
            ii(0x13_c395, 3); callw(0x13_9235, -0x3163);                /* call 0x9235 */
            ii(0x13_c398, 3); add(sp, 0xc);                             /* add sp, 0xc */
            ii(0x13_c39b, 3); jmpw(0x13_c1ba, -0x1e4); goto l_0x13_c1ba; /* jmp 0xc1ba */
        l_0x13_c39e:
            ii(0x13_c39e, 1); nop();                                    /* nop */
            ii(0x13_c39f, 1); pushw(cs);                                /* push cs */
            ii(0x13_c3a0, 3); callw(0x13_8e97, -0x350c);                /* call 0x8e97 */
            ii(0x13_c3a3, 2); pushw(0x1);                               /* push 0x1 */
            ii(0x13_c3a5, 3); mov(ax, memw_a16[ss, bp + 0x8]);          /* mov ax, [bp+0x8] */
            ii(0x13_c3a8, 3); mov(dx, memw_a16[ss, bp + 0xa]);          /* mov dx, [bp+0xa] */
            ii(0x13_c3ab, 3); sub(ax, memw_a16[ss, bp - 0x4]);          /* sub ax, [bp-0x4] */
            ii(0x13_c3ae, 3); sbb(dx, memw_a16[ss, bp - 0x2]);          /* sbb dx, [bp-0x2] */
            ii(0x13_c3b1, 1); pushw(dx);                                /* push dx */
            ii(0x13_c3b2, 1); pushw(ax);                                /* push ax */
            ii(0x13_c3b3, 3); mov(ax, memw_a16[ss, bp - 0x4]);          /* mov ax, [bp-0x4] */
            ii(0x13_c3b6, 3); mov(dx, memw_a16[ss, bp - 0x2]);          /* mov dx, [bp-0x2] */
            ii(0x13_c3b9, 2); mov(dh, dl);                              /* mov dh, dl */
            ii(0x13_c3bb, 2); mov(dl, ah);                              /* mov dl, ah */
            ii(0x13_c3bd, 2); mov(ah, al);                              /* mov ah, al */
            ii(0x13_c3bf, 2); sub(al, al);                              /* sub al, al */
            ii(0x13_c3c1, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_c3c3, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_c3c5, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_c3c7, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_c3c9, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_c3cb, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_c3cd, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_c3cf, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_c3d1, 3); add(ax, memw_a16[ss, bp - 0xa]);          /* add ax, [bp-0xa] */
            ii(0x13_c3d4, 3); adc(dx, memw_a16[ss, bp - 0x8]);          /* adc dx, [bp-0x8] */
            ii(0x13_c3d7, 1); pushw(dx);                                /* push dx */
            ii(0x13_c3d8, 1); pushw(ax);                                /* push ax */
            ii(0x13_c3d9, 3); mov(al, memb_a16[ds, 0x51a7]);            /* mov al, [0x51a7] */
            ii(0x13_c3dc, 2); sub(ah, ah);                              /* sub ah, ah */
            ii(0x13_c3de, 1); pushw(ax);                                /* push ax */
            ii(0x13_c3df, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x13_c3e2, 1); pushw(cs);                                /* push cs */
            ii(0x13_c3e3, 3); callw(0x13_c48e, 0xa8);                   /* call 0xc48e */
            ii(0x13_c3e6, 3); add(sp, 0xe);                             /* add sp, 0xe */
            ii(0x13_c3e9, 3); mov(ax, memw_a16[ss, bp - 0x4]);          /* mov ax, [bp-0x4] */
            ii(0x13_c3ec, 3); mov(dx, memw_a16[ss, bp - 0x2]);          /* mov dx, [bp-0x2] */
            ii(0x13_c3ef, 3); sub(ax, memw_a16[ss, bp + 0x8]);          /* sub ax, [bp+0x8] */
            ii(0x13_c3f2, 3); sbb(dx, memw_a16[ss, bp + 0xa]);          /* sbb dx, [bp+0xa] */
            ii(0x13_c3f5, 4); add(memw_a16[ds, 0x1fc4], ax);            /* add [0x1fc4], ax */
            ii(0x13_c3f9, 4); adc(memw_a16[ds, 0x1fc6], dx);            /* adc [0x1fc6], dx */
            ii(0x13_c3fd, 4); add(memw_a16[ds, 0x1fac], ax);            /* add [0x1fac], ax */
            ii(0x13_c401, 4); adc(memw_a16[ds, 0x1fae], dx);            /* adc [0x1fae], dx */
            ii(0x13_c405, 5); cmp(memw_a16[ds, 0x1fae], 0);             /* cmp word [0x1fae], 0x0 */
            ii(0x13_c40a, 2); if(jgew(0x13_c414, 0x8)) goto l_0x13_c414; /* jge 0xc414 */
            ii(0x13_c40c, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x13_c40e, 3); mov(memw_a16[ds, 0x1fae], ax);            /* mov [0x1fae], ax */
            ii(0x13_c411, 3); mov(memw_a16[ds, 0x1fac], ax);            /* mov [0x1fac], ax */
        l_0x13_c414:
            ii(0x13_c414, 3); mov(ax, memw_a16[ss, bp - 0x4]);          /* mov ax, [bp-0x4] */
            ii(0x13_c417, 3); mov(dx, memw_a16[ss, bp - 0x2]);          /* mov dx, [bp-0x2] */
            ii(0x13_c41a, 3); sub(ax, memw_a16[ss, bp + 0x8]);          /* sub ax, [bp+0x8] */
            ii(0x13_c41d, 3); sbb(dx, memw_a16[ss, bp + 0xa]);          /* sbb dx, [bp+0xa] */
            ii(0x13_c420, 4); add(memw_a16[ds, 0x1fbc], ax);            /* add [0x1fbc], ax */
            ii(0x13_c424, 4); adc(memw_a16[ds, 0x1fbe], dx);            /* adc [0x1fbe], dx */
            ii(0x13_c428, 5); cmp(memw_a16[ds, 0x1fbe], 0);             /* cmp word [0x1fbe], 0x0 */
            ii(0x13_c42d, 2); if(jgew(0x13_c437, 0x8)) goto l_0x13_c437; /* jge 0xc437 */
            ii(0x13_c42f, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x13_c431, 3); mov(memw_a16[ds, 0x1fbe], ax);            /* mov [0x1fbe], ax */
            ii(0x13_c434, 3); mov(memw_a16[ds, 0x1fbc], ax);            /* mov [0x1fbc], ax */
        l_0x13_c437:
            ii(0x13_c437, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x13_c439, 2); jmpw(0x13_c44a, 0xf); goto l_0x13_c44a;   /* jmp 0xc44a */
        //    ii(0x13_c43b, 1); nop();                                    /* nop */
        l_0x13_c43c:
            ii(0x13_c43c, 3); mov(ax, 0x8012);                          /* mov ax, 0x8012 */
            ii(0x13_c43f, 2); jmpw(0x13_c44a, 0x9); goto l_0x13_c44a;   /* jmp 0xc44a */
        //    ii(0x13_c441, 1); nop();                                    /* nop */
        //    ii(0x13_c442, 2); jmpw(0x13_c44a, 0x6); goto l_0x13_c44a;   /* jmp 0xc44a */
        l_0x13_c444:
            ii(0x13_c444, 3); mov(ax, 0x8023);                          /* mov ax, 0x8023 */
            ii(0x13_c447, 2); jmpw(0x13_c44a, 0x1); goto l_0x13_c44a;   /* jmp 0xc44a */
        //    ii(0x13_c449, 1); nop();                                    /* nop */
        l_0x13_c44a:
            ii(0x13_c44a, 1); popw(ds);                                 /* pop ds */
            ii(0x13_c44b, 1); popw(si);                                 /* pop si */
            ii(0x13_c44c, 1); popw(di);                                 /* pop di */
            ii(0x13_c44d, 1); leavew();                                 /* leave */
            ii(0x13_c44e, 1); retfw(); return;                          /* retf */
        }
    }
}
