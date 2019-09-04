using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_bef2-6754e754")]
        public void Method_0017_bef2()
        {
            ii(0x17_bef2, 4); enter(0x2e, 0);                           /* enter 0x2e, 0x0 */
            ii(0x17_bef6, 1); push(di);                                 /* push di */
            ii(0x17_bef7, 1); push(si);                                 /* push si */
            ii(0x17_bef8, 1); push(ds);                                 /* push ds */
            ii(0x17_bef9, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x17_befc, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x17_befe, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x17_bf00, 3); mov(memw[ss, bp - 16], ax);               /* mov [bp-0x10], ax */
            ii(0x17_bf03, 3); mov(memw[ss, bp - 18], ax);               /* mov [bp-0x12], ax */
            ii(0x17_bf06, 3); mov(memw[ss, bp - 2], ax);                /* mov [bp-0x2], ax */
            ii(0x17_bf09, 3); mov(memw[ss, bp - 4], ax);                /* mov [bp-0x4], ax */
            ii(0x17_bf0c, 3); push(memw[ss, bp + 6]);                   /* push word [bp+0x6] */
            ii(0x17_bf0f, 1); push(cs);                                 /* push cs */
            ii(0x17_bf10, 3); call(0x17_c79c, 0x889);                   /* call 0xc79c */
            ii(0x17_bf13, 3); add(sp, 2);                               /* add sp, 0x2 */
            ii(0x17_bf16, 3); mov(memw[ss, bp - 30], ax);               /* mov [bp-0x1e], ax */
            ii(0x17_bf19, 3); mov(memw[ss, bp - 28], dx);               /* mov [bp-0x1c], dx */
            ii(0x17_bf1c, 3); mov(memw[ss, bp - 22], ax);               /* mov [bp-0x16], ax */
            ii(0x17_bf1f, 3); mov(memw[ss, bp - 20], dx);               /* mov [bp-0x14], dx */
            ii(0x17_bf22, 3); cmp(ax, 0xffff);                          /* cmp ax, 0xffff */
            ii(0x17_bf25, 2); if(jnz(0x17_bf2e, 7)) goto l_0x17_bf2e;   /* jnz 0xbf2e */
            ii(0x17_bf27, 2); cmp(dx, ax);                              /* cmp dx, ax */
            ii(0x17_bf29, 2); if(jnz(0x17_bf2e, 3)) goto l_0x17_bf2e;   /* jnz 0xbf2e */
            ii(0x17_bf2b, 3); jmp(0x17_c444, 0x516); goto l_0x17_c444;  /* jmp 0xc444 */
        l_0x17_bf2e:
            ii(0x17_bf2e, 3); add(ax, 0);                               /* add ax, 0x0 */
            ii(0x17_bf31, 3); adc(dx, 1);                               /* adc dx, 0x1 */
            ii(0x17_bf34, 2); mov(dh, dl);                              /* mov dh, dl */
            ii(0x17_bf36, 2); mov(dl, ah);                              /* mov dl, ah */
            ii(0x17_bf38, 2); mov(ah, al);                              /* mov ah, al */
            ii(0x17_bf3a, 2); sub(al, al);                              /* sub al, al */
            ii(0x17_bf3c, 2); shl(ax, 1);                               /* shl ax, 1 */
            ii(0x17_bf3e, 2); rcl(dx, 1);                               /* rcl dx, 1 */
            ii(0x17_bf40, 2); shl(ax, 1);                               /* shl ax, 1 */
            ii(0x17_bf42, 2); rcl(dx, 1);                               /* rcl dx, 1 */
            ii(0x17_bf44, 2); shl(ax, 1);                               /* shl ax, 1 */
            ii(0x17_bf46, 2); rcl(dx, 1);                               /* rcl dx, 1 */
            ii(0x17_bf48, 2); shl(ax, 1);                               /* shl ax, 1 */
            ii(0x17_bf4a, 2); rcl(dx, 1);                               /* rcl dx, 1 */
            ii(0x17_bf4c, 3); les(bx, memw[ss, bp + 12]);               /* les bx, [bp+0xc] */
            ii(0x17_bf4f, 3); mov(memw[es, bx], ax);                    /* mov [es:bx], ax */
            ii(0x17_bf52, 4); mov(memw[es, bx + 2], dx);                /* mov [es:bx+0x2], dx */
            ii(0x17_bf56, 3); mov(ax, memw[ss, bp - 22]);               /* mov ax, [bp-0x16] */
            ii(0x17_bf59, 3); mov(dx, memw[ss, bp - 20]);               /* mov dx, [bp-0x14] */
            ii(0x17_bf5c, 3); add(ax, memw[ss, bp + 8]);                /* add ax, [bp+0x8] */
            ii(0x17_bf5f, 3); adc(dx, memw[ss, bp + 10]);               /* adc dx, [bp+0xa] */
            ii(0x17_bf62, 4); cmp(dx, memw[ds, 0x4fd2]);                /* cmp dx, [0x4fd2] */
            ii(0x17_bf66, 2); if(jb(0x17_bf78, 0x10)) goto l_0x17_bf78; /* jb 0xbf78 */
            ii(0x17_bf68, 2); if(ja(0x17_bf70, 6)) goto l_0x17_bf70;    /* ja 0xbf70 */
            ii(0x17_bf6a, 4); cmp(ax, memw[ds, 0x4fd0]);                /* cmp ax, [0x4fd0] */
            ii(0x17_bf6e, 2); if(jbe(0x17_bf78, 8)) goto l_0x17_bf78;   /* jbe 0xbf78 */
        l_0x17_bf70:
            ii(0x17_bf70, 3); mov(ax, 0x8016);                          /* mov ax, 0x8016 */
            ii(0x17_bf73, 1); pop(ds);                                  /* pop ds */
            ii(0x17_bf74, 1); pop(si);                                  /* pop si */
            ii(0x17_bf75, 1); pop(di);                                  /* pop di */
            ii(0x17_bf76, 1); leave();                                  /* leave */
            ii(0x17_bf77, 1); retf(); return;                           /* retf */
        l_0x17_bf78:
            ii(0x17_bf78, 3); push(memw[ss, bp - 28]);                  /* push word [bp-0x1c] */
            ii(0x17_bf7b, 3); push(memw[ss, bp - 30]);                  /* push word [bp-0x1e] */
            ii(0x17_bf7e, 4); push(memw[ds, 0x4ff6]);                   /* push word [0x4ff6] */
            ii(0x17_bf82, 4); push(memw[ds, 0x4ff4]);                   /* push word [0x4ff4] */
            ii(0x17_bf86, 3); call(0x17_90c4, -0x2ec5);                 /* call 0x90c4 */
            ii(0x17_bf89, 3); add(sp, 8);                               /* add sp, 0x8 */
            ii(0x17_bf8c, 3); cmp(ax, memw[ss, bp + 6]);                /* cmp ax, [bp+0x6] */
            ii(0x17_bf8f, 2); if(jnz(0x17_bfa4, 0x13)) goto l_0x17_bfa4; /* jnz 0xbfa4 */
            ii(0x17_bf91, 4); add(memw[ss, bp - 4], 1);                 /* add word [bp-0x4], 0x1 */
            ii(0x17_bf95, 4); adc(memw[ss, bp - 2], 0);                 /* adc word [bp-0x2], 0x0 */
            ii(0x17_bf99, 4); add(memw[ss, bp - 30], 1);                /* add word [bp-0x1e], 0x1 */
            ii(0x17_bf9d, 4); adc(memw[ss, bp - 28], 0);                /* adc word [bp-0x1c], 0x0 */
            ii(0x17_bfa1, 2); jmp(0x17_bf78, -0x2b); goto l_0x17_bf78;  /* jmp 0xbf78 */
        //  ii(0x17_bfa3, 1); nop();                                    /* nop */
        l_0x17_bfa4:
            ii(0x17_bfa4, 3); mov(ax, memw[ss, bp + 8]);                /* mov ax, [bp+0x8] */
            ii(0x17_bfa7, 3); mov(dx, memw[ss, bp + 10]);               /* mov dx, [bp+0xa] */
            ii(0x17_bfaa, 3); cmp(memw[ss, bp - 2], dx);                /* cmp [bp-0x2], dx */
            ii(0x17_bfad, 2); if(jb(0x17_bfe8, 0x39)) goto l_0x17_bfe8; /* jb 0xbfe8 */
            ii(0x17_bfaf, 2); if(ja(0x17_bfb6, 5)) goto l_0x17_bfb6;    /* ja 0xbfb6 */
            ii(0x17_bfb1, 3); cmp(memw[ss, bp - 4], ax);                /* cmp [bp-0x4], ax */
            ii(0x17_bfb4, 2); if(jbe(0x17_bfe8, 0x32)) goto l_0x17_bfe8; /* jbe 0xbfe8 */
        l_0x17_bfb6:
            ii(0x17_bfb6, 3); mov(cx, memw[ss, bp - 4]);                /* mov cx, [bp-0x4] */
            ii(0x17_bfb9, 3); mov(bx, memw[ss, bp - 2]);                /* mov bx, [bp-0x2] */
            ii(0x17_bfbc, 2); sub(cx, ax);                              /* sub cx, ax */
            ii(0x17_bfbe, 2); sbb(bx, dx);                              /* sbb bx, dx */
            ii(0x17_bfc0, 1); push(bx);                                 /* push bx */
            ii(0x17_bfc1, 1); push(cx);                                 /* push cx */
            ii(0x17_bfc2, 3); add(ax, memw[ss, bp - 22]);               /* add ax, [bp-0x16] */
            ii(0x17_bfc5, 3); adc(dx, memw[ss, bp - 20]);               /* adc dx, [bp-0x14] */
            ii(0x17_bfc8, 1); push(dx);                                 /* push dx */
            ii(0x17_bfc9, 1); push(ax);                                 /* push ax */
            ii(0x17_bfca, 2); mov(si, cx);                              /* mov si, cx */
            ii(0x17_bfcc, 2); mov(di, bx);                              /* mov di, bx */
            ii(0x17_bfce, 1); push(cs);                                 /* push cs */
            ii(0x17_bfcf, 3); call(0x17_c560, 0x58e);                   /* call 0xc560 */
            ii(0x17_bfd2, 3); add(sp, 8);                               /* add sp, 0x8 */
            ii(0x17_bfd5, 4); add(memw[ds, 0x1fac], si);                /* add [0x1fac], si */
            ii(0x17_bfd9, 4); adc(memw[ds, 0x1fae], di);                /* adc [0x1fae], di */
            ii(0x17_bfdd, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x17_bfdf, 1); pop(ds);                                  /* pop ds */
            ii(0x17_bfe0, 1); pop(si);                                  /* pop si */
            ii(0x17_bfe1, 1); pop(di);                                  /* pop di */
            ii(0x17_bfe2, 1); leave();                                  /* leave */
            ii(0x17_bfe3, 1); retf(); return;                           /* retf */
        //  ii(0x17_bfe4, 4); Недостижимый код.
        l_0x17_bfe8:
            ii(0x17_bfe8, 3); mov(ax, memw[ss, bp - 4]);                /* mov ax, [bp-0x4] */
            ii(0x17_bfeb, 3); mov(dx, memw[ss, bp - 2]);                /* mov dx, [bp-0x2] */
            ii(0x17_bfee, 3); mov(memw[ss, bp - 18], ax);               /* mov [bp-0x12], ax */
            ii(0x17_bff1, 3); mov(memw[ss, bp - 16], dx);               /* mov [bp-0x10], dx */
        l_0x17_bff4:
            ii(0x17_bff4, 3); push(memw[ss, bp - 28]);                  /* push word [bp-0x1c] */
            ii(0x17_bff7, 3); push(memw[ss, bp - 30]);                  /* push word [bp-0x1e] */
            ii(0x17_bffa, 4); add(memw[ss, bp - 30], 1);                /* add word [bp-0x1e], 0x1 */
            ii(0x17_bffe, 4); adc(memw[ss, bp - 28], 0);                /* adc word [bp-0x1c], 0x0 */
            ii(0x17_c002, 4); push(memw[ds, 0x4ff6]);                   /* push word [0x4ff6] */
            ii(0x17_c006, 4); push(memw[ds, 0x4ff4]);                   /* push word [0x4ff4] */
            ii(0x17_c00a, 3); call(0x17_90c4, -0x2f49);                 /* call 0x90c4 */
            ii(0x17_c00d, 3); add(sp, 8);                               /* add sp, 0x8 */
            ii(0x17_c010, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x17_c012, 2); if(jnz(0x17_c030, 0x1c)) goto l_0x17_c030; /* jnz 0xc030 */
            ii(0x17_c014, 3); mov(ax, memw[ss, bp + 8]);                /* mov ax, [bp+0x8] */
            ii(0x17_c017, 3); mov(dx, memw[ss, bp + 10]);               /* mov dx, [bp+0xa] */
            ii(0x17_c01a, 4); add(memw[ss, bp - 18], 1);                /* add word [bp-0x12], 0x1 */
            ii(0x17_c01e, 4); adc(memw[ss, bp - 16], 0);                /* adc word [bp-0x10], 0x0 */
            ii(0x17_c022, 3); cmp(memw[ss, bp - 18], ax);               /* cmp [bp-0x12], ax */
            ii(0x17_c025, 2); if(jnz(0x17_c02e, 7)) goto l_0x17_c02e;   /* jnz 0xc02e */
            ii(0x17_c027, 3); cmp(memw[ss, bp - 16], dx);               /* cmp [bp-0x10], dx */
            ii(0x17_c02a, 2); if(jnz(0x17_c02e, 2)) goto l_0x17_c02e;   /* jnz 0xc02e */
            ii(0x17_c02c, 2); jmp(0x17_c030, 2); goto l_0x17_c030;      /* jmp 0xc030 */
        l_0x17_c02e:
            ii(0x17_c02e, 2); jmp(0x17_bff4, -0x3c); goto l_0x17_bff4;  /* jmp 0xbff4 */
        l_0x17_c030:
            ii(0x17_c030, 3); mov(ax, memw[ss, bp + 8]);                /* mov ax, [bp+0x8] */
            ii(0x17_c033, 3); mov(dx, memw[ss, bp + 10]);               /* mov dx, [bp+0xa] */
            ii(0x17_c036, 3); cmp(memw[ss, bp - 18], ax);               /* cmp [bp-0x12], ax */
            ii(0x17_c039, 2); if(jz(0x17_c03e, 3)) goto l_0x17_c03e;    /* jz 0xc03e */
            ii(0x17_c03b, 3); jmp(0x17_c0e0, 0xa2); goto l_0x17_c0e0;   /* jmp 0xc0e0 */
        l_0x17_c03e:
            ii(0x17_c03e, 3); cmp(memw[ss, bp - 16], dx);               /* cmp [bp-0x10], dx */
            ii(0x17_c041, 2); if(jz(0x17_c046, 3)) goto l_0x17_c046;    /* jz 0xc046 */
            ii(0x17_c043, 3); jmp(0x17_c0e0, 0x9a); goto l_0x17_c0e0;   /* jmp 0xc0e0 */
        l_0x17_c046:
            ii(0x17_c046, 2); push(1);                                  /* push 0x1 */
            ii(0x17_c048, 3); sub(ax, memw[ss, bp - 4]);                /* sub ax, [bp-0x4] */
            ii(0x17_c04b, 3); sbb(dx, memw[ss, bp - 2]);                /* sbb dx, [bp-0x2] */
            ii(0x17_c04e, 1); push(dx);                                 /* push dx */
            ii(0x17_c04f, 1); push(ax);                                 /* push ax */
            ii(0x17_c050, 3); mov(ax, memw[ss, bp - 4]);                /* mov ax, [bp-0x4] */
            ii(0x17_c053, 3); mov(dx, memw[ss, bp - 2]);                /* mov dx, [bp-0x2] */
            ii(0x17_c056, 2); mov(dh, dl);                              /* mov dh, dl */
            ii(0x17_c058, 2); mov(dl, ah);                              /* mov dl, ah */
            ii(0x17_c05a, 2); mov(ah, al);                              /* mov ah, al */
            ii(0x17_c05c, 2); sub(al, al);                              /* sub al, al */
            ii(0x17_c05e, 2); shl(ax, 1);                               /* shl ax, 1 */
            ii(0x17_c060, 2); rcl(dx, 1);                               /* rcl dx, 1 */
            ii(0x17_c062, 2); shl(ax, 1);                               /* shl ax, 1 */
            ii(0x17_c064, 2); rcl(dx, 1);                               /* rcl dx, 1 */
            ii(0x17_c066, 2); shl(ax, 1);                               /* shl ax, 1 */
            ii(0x17_c068, 2); rcl(dx, 1);                               /* rcl dx, 1 */
            ii(0x17_c06a, 2); shl(ax, 1);                               /* shl ax, 1 */
            ii(0x17_c06c, 2); rcl(dx, 1);                               /* rcl dx, 1 */
            ii(0x17_c06e, 3); les(bx, memw[ss, bp + 12]);               /* les bx, [bp+0xc] */
            ii(0x17_c071, 3); add(ax, memw[es, bx]);                    /* add ax, [es:bx] */
            ii(0x17_c074, 4); adc(dx, memw[es, bx + 2]);                /* adc dx, [es:bx+0x2] */
            ii(0x17_c078, 1); push(dx);                                 /* push dx */
            ii(0x17_c079, 1); push(ax);                                 /* push ax */
            ii(0x17_c07a, 3); mov(al, memb[ds, 0x51a7]);                /* mov al, [0x51a7] */
            ii(0x17_c07d, 2); sub(ah, ah);                              /* sub ah, ah */
            ii(0x17_c07f, 1); push(ax);                                 /* push ax */
            ii(0x17_c080, 3); push(memw[ss, bp + 6]);                   /* push word [bp+0x6] */
            ii(0x17_c083, 1); push(cs);                                 /* push cs */
            ii(0x17_c084, 3); call(0x17_c48e, 0x407);                   /* call 0xc48e */
            ii(0x17_c087, 3); add(sp, 0xe);                             /* add sp, 0xe */
            ii(0x17_c08a, 3); mov(ax, memw[ss, bp - 4]);                /* mov ax, [bp-0x4] */
            ii(0x17_c08d, 3); mov(dx, memw[ss, bp - 2]);                /* mov dx, [bp-0x2] */
            ii(0x17_c090, 3); sub(ax, memw[ss, bp + 8]);                /* sub ax, [bp+0x8] */
            ii(0x17_c093, 3); sbb(dx, memw[ss, bp + 10]);               /* sbb dx, [bp+0xa] */
            ii(0x17_c096, 4); add(memw[ds, 0x1fc4], ax);                /* add [0x1fc4], ax */
            ii(0x17_c09a, 4); adc(memw[ds, 0x1fc6], dx);                /* adc [0x1fc6], dx */
            ii(0x17_c09e, 4); add(memw[ds, 0x1fac], ax);                /* add [0x1fac], ax */
            ii(0x17_c0a2, 4); adc(memw[ds, 0x1fae], dx);                /* adc [0x1fae], dx */
            ii(0x17_c0a6, 5); cmp(memw[ds, 0x1fae], 0);                 /* cmp word [0x1fae], 0x0 */
            ii(0x17_c0ab, 2); if(jge(0x17_c0b5, 8)) goto l_0x17_c0b5;   /* jge 0xc0b5 */
            ii(0x17_c0ad, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x17_c0af, 3); mov(memw[ds, 0x1fae], ax);                /* mov [0x1fae], ax */
            ii(0x17_c0b2, 3); mov(memw[ds, 0x1fac], ax);                /* mov [0x1fac], ax */
        l_0x17_c0b5:
            ii(0x17_c0b5, 3); mov(ax, memw[ss, bp - 4]);                /* mov ax, [bp-0x4] */
            ii(0x17_c0b8, 3); mov(dx, memw[ss, bp - 2]);                /* mov dx, [bp-0x2] */
            ii(0x17_c0bb, 3); sub(ax, memw[ss, bp + 8]);                /* sub ax, [bp+0x8] */
            ii(0x17_c0be, 3); sbb(dx, memw[ss, bp + 10]);               /* sbb dx, [bp+0xa] */
            ii(0x17_c0c1, 4); add(memw[ds, 0x1fbc], ax);                /* add [0x1fbc], ax */
            ii(0x17_c0c5, 4); adc(memw[ds, 0x1fbe], dx);                /* adc [0x1fbe], dx */
            ii(0x17_c0c9, 5); cmp(memw[ds, 0x1fbe], 0);                 /* cmp word [0x1fbe], 0x0 */
            ii(0x17_c0ce, 2); if(jge(0x17_c0d8, 8)) goto l_0x17_c0d8;   /* jge 0xc0d8 */
            ii(0x17_c0d0, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x17_c0d2, 3); mov(memw[ds, 0x1fbe], ax);                /* mov [0x1fbe], ax */
            ii(0x17_c0d5, 3); mov(memw[ds, 0x1fbc], ax);                /* mov [0x1fbc], ax */
        l_0x17_c0d8:
            ii(0x17_c0d8, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x17_c0da, 1); pop(ds);                                  /* pop ds */
            ii(0x17_c0db, 1); pop(si);                                  /* pop si */
            ii(0x17_c0dc, 1); pop(di);                                  /* pop di */
            ii(0x17_c0dd, 1); leave();                                  /* leave */
            ii(0x17_c0de, 1); retf(); return;                           /* retf */
        //  ii(0x17_c0df, 1); Недостижимый код.
        l_0x17_c0e0:
            ii(0x17_c0e0, 3); sub(ax, memw[ss, bp - 4]);                /* sub ax, [bp-0x4] */
            ii(0x17_c0e3, 3); sbb(dx, memw[ss, bp - 2]);                /* sbb dx, [bp-0x2] */
            ii(0x17_c0e6, 4); cmp(dx, memw[ds, 0x1fc6]);                /* cmp dx, [0x1fc6] */
            ii(0x17_c0ea, 2); if(jl(0x17_c0fc, 0x10)) goto l_0x17_c0fc; /* jl 0xc0fc */
            ii(0x17_c0ec, 2); if(jg(0x17_c0f4, 6)) goto l_0x17_c0f4;    /* jg 0xc0f4 */
            ii(0x17_c0ee, 4); cmp(ax, memw[ds, 0x1fc4]);                /* cmp ax, [0x1fc4] */
            ii(0x17_c0f2, 2); if(jbe(0x17_c0fc, 8)) goto l_0x17_c0fc;   /* jbe 0xc0fc */
        l_0x17_c0f4:
            ii(0x17_c0f4, 3); mov(ax, 0x8016);                          /* mov ax, 0x8016 */
            ii(0x17_c0f7, 1); pop(ds);                                  /* pop ds */
            ii(0x17_c0f8, 1); pop(si);                                  /* pop si */
            ii(0x17_c0f9, 1); pop(di);                                  /* pop di */
            ii(0x17_c0fa, 1); leave();                                  /* leave */
            ii(0x17_c0fb, 1); retf(); return;                           /* retf */
        l_0x17_c0fc:
            ii(0x17_c0fc, 3); mov(ax, memw[ds, 0x1a]);                  /* mov ax, [0x1a] */
            ii(0x17_c0ff, 4); or(ax, memw[ds, 0x18]);                   /* or ax, [0x18] */
            ii(0x17_c103, 2); if(jz(0x17_c162, 0x5d)) goto l_0x17_c162; /* jz 0xc162 */
            ii(0x17_c105, 3); mov(ax, memw[ss, bp - 4]);                /* mov ax, [bp-0x4] */
            ii(0x17_c108, 3); mov(dx, memw[ss, bp - 2]);                /* mov dx, [bp-0x2] */
            ii(0x17_c10b, 4); sub(ax, memw[ds, 0x1fc4]);                /* sub ax, [0x1fc4] */
            ii(0x17_c10f, 4); sbb(dx, memw[ds, 0x1fc6]);                /* sbb dx, [0x1fc6] */
            ii(0x17_c113, 4); sub(ax, memw[ds, 0x1fc0]);                /* sub ax, [0x1fc0] */
            ii(0x17_c117, 4); sbb(dx, memw[ds, 0x1fc2]);                /* sbb dx, [0x1fc2] */
            ii(0x17_c11b, 4); add(ax, memw[ds, 0x1fb4]);                /* add ax, [0x1fb4] */
            ii(0x17_c11f, 4); adc(dx, memw[ds, 0x1fb6]);                /* adc dx, [0x1fb6] */
            ii(0x17_c123, 3); add(ax, 4);                               /* add ax, 0x4 */
            ii(0x17_c126, 3); adc(dx, 0);                               /* adc dx, 0x0 */
            ii(0x17_c129, 3); mov(memw[ss, bp - 26], ax);               /* mov [bp-0x1a], ax */
            ii(0x17_c12c, 3); mov(memw[ss, bp - 24], dx);               /* mov [bp-0x18], dx */
            ii(0x17_c12f, 4); mov(cx, memw[ds, 0x1f50]);                /* mov cx, [0x1f50] */
            ii(0x17_c133, 4); mov(bx, memw[ds, 0x1f52]);                /* mov bx, [0x1f52] */
            ii(0x17_c137, 2); cmp(dx, bx);                              /* cmp dx, bx */
            ii(0x17_c139, 2); if(jl(0x17_c162, 0x27)) goto l_0x17_c162; /* jl 0xc162 */
            ii(0x17_c13b, 2); if(jg(0x17_c141, 4)) goto l_0x17_c141;    /* jg 0xc141 */
            ii(0x17_c13d, 2); cmp(ax, cx);                              /* cmp ax, cx */
            ii(0x17_c13f, 2); if(jbe(0x17_c162, 0x21)) goto l_0x17_c162; /* jbe 0xc162 */
        l_0x17_c141:
            ii(0x17_c141, 2); sub(ax, cx);                              /* sub ax, cx */
            ii(0x17_c143, 2); sbb(dx, bx);                              /* sbb dx, bx */
            ii(0x17_c145, 3); mov(memw[ss, bp - 42], ax);               /* mov [bp-0x2a], ax */
            ii(0x17_c148, 3); mov(memw[ss, bp - 40], dx);               /* mov [bp-0x28], dx */
            ii(0x17_c14b, 1); push(dx);                                 /* push dx */
            ii(0x17_c14c, 1); push(ax);                                 /* push ax */
            ii(0x17_c14d, 1); nop();                                    /* nop */
            ii(0x17_c14e, 1); push(cs);                                 /* push cs */
            ii(0x17_c14f, 3); call(0x17_8ba6, -0x35ac);                 /* call 0x8ba6 */
            ii(0x17_c152, 3); add(sp, 4);                               /* add sp, 0x4 */
            ii(0x17_c155, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x17_c157, 2); if(jnz(0x17_c162, 9)) goto l_0x17_c162;   /* jnz 0xc162 */
            ii(0x17_c159, 3); mov(ax, 0x8014);                          /* mov ax, 0x8014 */
            ii(0x17_c15c, 1); pop(ds);                                  /* pop ds */
            ii(0x17_c15d, 1); pop(si);                                  /* pop si */
            ii(0x17_c15e, 1); pop(di);                                  /* pop di */
            ii(0x17_c15f, 1); leave();                                  /* leave */
            ii(0x17_c160, 1); retf(); return;                           /* retf */
        //  ii(0x17_c161, 1); Недостижимый код.
        l_0x17_c162:
            ii(0x17_c162, 3); push(memw[ss, bp + 10]);                  /* push word [bp+0xa] */
            ii(0x17_c165, 3); push(memw[ss, bp + 8]);                   /* push word [bp+0x8] */
            ii(0x17_c168, 1); push(cs);                                 /* push cs */
            ii(0x17_c169, 3); call(0x17_bbf8, -0x574);                  /* call 0xbbf8 */
            ii(0x17_c16c, 3); add(sp, 4);                               /* add sp, 0x4 */
            ii(0x17_c16f, 3); mov(memw[ss, bp - 30], ax);               /* mov [bp-0x1e], ax */
            ii(0x17_c172, 3); mov(memw[ss, bp - 28], dx);               /* mov [bp-0x1c], dx */
            ii(0x17_c175, 3); cmp(ax, 0xffff);                          /* cmp ax, 0xffff */
            ii(0x17_c178, 2); if(jnz(0x17_c181, 7)) goto l_0x17_c181;   /* jnz 0xc181 */
            ii(0x17_c17a, 2); cmp(dx, ax);                              /* cmp dx, ax */
            ii(0x17_c17c, 2); if(jnz(0x17_c181, 3)) goto l_0x17_c181;   /* jnz 0xc181 */
            ii(0x17_c17e, 3); jmp(0x17_c43c, 0x2bb); goto l_0x17_c43c;  /* jmp 0xc43c */
        l_0x17_c181:
            ii(0x17_c181, 3); add(ax, 0);                               /* add ax, 0x0 */
            ii(0x17_c184, 3); adc(dx, 1);                               /* adc dx, 0x1 */
            ii(0x17_c187, 2); mov(dh, dl);                              /* mov dh, dl */
            ii(0x17_c189, 2); mov(dl, ah);                              /* mov dl, ah */
            ii(0x17_c18b, 2); mov(ah, al);                              /* mov ah, al */
            ii(0x17_c18d, 2); sub(al, al);                              /* sub al, al */
            ii(0x17_c18f, 2); shl(ax, 1);                               /* shl ax, 1 */
            ii(0x17_c191, 2); rcl(dx, 1);                               /* rcl dx, 1 */
            ii(0x17_c193, 2); shl(ax, 1);                               /* shl ax, 1 */
            ii(0x17_c195, 2); rcl(dx, 1);                               /* rcl dx, 1 */
            ii(0x17_c197, 2); shl(ax, 1);                               /* shl ax, 1 */
            ii(0x17_c199, 2); rcl(dx, 1);                               /* rcl dx, 1 */
            ii(0x17_c19b, 2); shl(ax, 1);                               /* shl ax, 1 */
            ii(0x17_c19d, 2); rcl(dx, 1);                               /* rcl dx, 1 */
            ii(0x17_c19f, 3); mov(memw[ss, bp - 10], ax);               /* mov [bp-0xa], ax */
            ii(0x17_c1a2, 3); mov(memw[ss, bp - 8], dx);                /* mov [bp-0x8], dx */
            ii(0x17_c1a5, 3); les(bx, memw[ss, bp + 12]);               /* les bx, [bp+0xc] */
            ii(0x17_c1a8, 3); mov(memw[es, bx], ax);                    /* mov [es:bx], ax */
            ii(0x17_c1ab, 4); mov(memw[es, bx + 2], dx);                /* mov [es:bx+0x2], dx */
            ii(0x17_c1af, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x17_c1b1, 3); mov(memw[ss, bp - 16], ax);               /* mov [bp-0x10], ax */
            ii(0x17_c1b4, 3); mov(memw[ss, bp - 18], ax);               /* mov [bp-0x12], ax */
            ii(0x17_c1b7, 2); jmp(0x17_c1c2, 9); goto l_0x17_c1c2;      /* jmp 0xc1c2 */
        //  ii(0x17_c1b9, 1); nop();                                    /* nop */
        l_0x17_c1ba:
            ii(0x17_c1ba, 4); add(memw[ss, bp - 18], 1);                /* add word [bp-0x12], 0x1 */
            ii(0x17_c1be, 4); adc(memw[ss, bp - 16], 0);                /* adc word [bp-0x10], 0x0 */
        l_0x17_c1c2:
            ii(0x17_c1c2, 3); mov(ax, memw[ss, bp - 4]);                /* mov ax, [bp-0x4] */
            ii(0x17_c1c5, 3); mov(dx, memw[ss, bp - 2]);                /* mov dx, [bp-0x2] */
            ii(0x17_c1c8, 3); cmp(memw[ss, bp - 16], dx);               /* cmp [bp-0x10], dx */
            ii(0x17_c1cb, 2); if(jbe(0x17_c1d0, 3)) goto l_0x17_c1d0;   /* jbe 0xc1d0 */
            ii(0x17_c1cd, 3); jmp(0x17_c39e, 0x1ce); goto l_0x17_c39e;  /* jmp 0xc39e */
        l_0x17_c1d0:
            ii(0x17_c1d0, 2); if(jb(0x17_c1da, 8)) goto l_0x17_c1da;    /* jb 0xc1da */
            ii(0x17_c1d2, 3); cmp(memw[ss, bp - 18], ax);               /* cmp [bp-0x12], ax */
            ii(0x17_c1d5, 2); if(jb(0x17_c1da, 3)) goto l_0x17_c1da;    /* jb 0xc1da */
            ii(0x17_c1d7, 3); jmp(0x17_c39e, 0x1c4); goto l_0x17_c39e;  /* jmp 0xc39e */
        l_0x17_c1da:
            ii(0x17_c1da, 3); mov(ax, memw[ss, bp - 18]);               /* mov ax, [bp-0x12] */
            ii(0x17_c1dd, 3); mov(dx, memw[ss, bp - 16]);               /* mov dx, [bp-0x10] */
            ii(0x17_c1e0, 3); add(ax, memw[ss, bp - 22]);               /* add ax, [bp-0x16] */
            ii(0x17_c1e3, 3); adc(dx, memw[ss, bp - 20]);               /* adc dx, [bp-0x14] */
            ii(0x17_c1e6, 1); push(dx);                                 /* push dx */
            ii(0x17_c1e7, 1); push(ax);                                 /* push ax */
            ii(0x17_c1e8, 4); push(memw[ds, 0x4ff6]);                   /* push word [0x4ff6] */
            ii(0x17_c1ec, 4); push(memw[ds, 0x4ff4]);                   /* push word [0x4ff4] */
            ii(0x17_c1f0, 2); mov(si, ax);                              /* mov si, ax */
            ii(0x17_c1f2, 2); mov(di, dx);                              /* mov di, dx */
            ii(0x17_c1f4, 3); call(0x17_90c4, -0x3133);                 /* call 0x90c4 */
            ii(0x17_c1f7, 3); add(sp, 8);                               /* add sp, 0x8 */
            ii(0x17_c1fa, 1); push(ax);                                 /* push ax */
            ii(0x17_c1fb, 3); mov(ax, memw[ss, bp - 18]);               /* mov ax, [bp-0x12] */
            ii(0x17_c1fe, 3); mov(dx, memw[ss, bp - 16]);               /* mov dx, [bp-0x10] */
            ii(0x17_c201, 3); add(ax, memw[ss, bp - 30]);               /* add ax, [bp-0x1e] */
            ii(0x17_c204, 3); adc(dx, memw[ss, bp - 28]);               /* adc dx, [bp-0x1c] */
            ii(0x17_c207, 1); push(dx);                                 /* push dx */
            ii(0x17_c208, 1); push(ax);                                 /* push ax */
            ii(0x17_c209, 4); push(memw[ds, 0x4ff6]);                   /* push word [0x4ff6] */
            ii(0x17_c20d, 4); push(memw[ds, 0x4ff4]);                   /* push word [0x4ff4] */
            ii(0x17_c211, 3); mov(memw[ss, bp - 46], ax);               /* mov [bp-0x2e], ax */
            ii(0x17_c214, 3); mov(memw[ss, bp - 44], dx);               /* mov [bp-0x2c], dx */
            ii(0x17_c217, 3); call(0x17_91e3, -0x3037);                 /* call 0x91e3 */
            ii(0x17_c21a, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x17_c21d, 1); push(di);                                 /* push di */
            ii(0x17_c21e, 1); push(si);                                 /* push si */
            ii(0x17_c21f, 4); push(memw[ds, 0x1fa6]);                   /* push word [0x1fa6] */
            ii(0x17_c223, 4); push(memw[ds, 0x1fa4]);                   /* push word [0x1fa4] */
            ii(0x17_c227, 3); call(0x17_90c4, -0x3166);                 /* call 0x90c4 */
            ii(0x17_c22a, 3); add(sp, 8);                               /* add sp, 0x8 */
            ii(0x17_c22d, 1); push(ax);                                 /* push ax */
            ii(0x17_c22e, 3); push(memw[ss, bp - 44]);                  /* push word [bp-0x2c] */
            ii(0x17_c231, 3); push(memw[ss, bp - 46]);                  /* push word [bp-0x2e] */
            ii(0x17_c234, 4); push(memw[ds, 0x1fa6]);                   /* push word [0x1fa6] */
            ii(0x17_c238, 4); push(memw[ds, 0x1fa4]);                   /* push word [0x1fa4] */
            ii(0x17_c23c, 3); call(0x17_91e3, -0x305c);                 /* call 0x91e3 */
            ii(0x17_c23f, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x17_c242, 1); push(di);                                 /* push di */
            ii(0x17_c243, 1); push(si);                                 /* push si */
            ii(0x17_c244, 4); push(memw[ds, 0x4f8e]);                   /* push word [0x4f8e] */
            ii(0x17_c248, 4); push(memw[ds, 0x4f8c]);                   /* push word [0x4f8c] */
            ii(0x17_c24c, 3); call(0x17_9208, -0x3047);                 /* call 0x9208 */
            ii(0x17_c24f, 3); add(sp, 8);                               /* add sp, 0x8 */
            ii(0x17_c252, 3); mov(memw[ss, bp - 34], ax);               /* mov [bp-0x22], ax */
            ii(0x17_c255, 3); mov(memw[ss, bp - 32], dx);               /* mov [bp-0x20], dx */
            ii(0x17_c258, 1); push(dx);                                 /* push dx */
            ii(0x17_c259, 1); push(ax);                                 /* push ax */
            ii(0x17_c25a, 3); push(memw[ss, bp - 44]);                  /* push word [bp-0x2c] */
            ii(0x17_c25d, 3); push(memw[ss, bp - 46]);                  /* push word [bp-0x2e] */
            ii(0x17_c260, 4); push(memw[ds, 0x4f8e]);                   /* push word [0x4f8e] */
            ii(0x17_c264, 4); push(memw[ds, 0x4f8c]);                   /* push word [0x4f8c] */
            ii(0x17_c268, 3); call(0x17_9235, -0x3036);                 /* call 0x9235 */
            ii(0x17_c26b, 3); add(sp, 0xc);                             /* add sp, 0xc */
            ii(0x17_c26e, 2); push(0);                                  /* push 0x0 */
            ii(0x17_c270, 1); push(di);                                 /* push di */
            ii(0x17_c271, 1); push(si);                                 /* push si */
            ii(0x17_c272, 4); push(memw[ds, 0x4ff6]);                   /* push word [0x4ff6] */
            ii(0x17_c276, 4); push(memw[ds, 0x4ff4]);                   /* push word [0x4ff4] */
            ii(0x17_c27a, 3); call(0x17_91e3, -0x309a);                 /* call 0x91e3 */
            ii(0x17_c27d, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x17_c280, 2); push(0);                                  /* push 0x0 */
            ii(0x17_c282, 1); push(di);                                 /* push di */
            ii(0x17_c283, 1); push(si);                                 /* push si */
            ii(0x17_c284, 4); push(memw[ds, 0x1fa6]);                   /* push word [0x1fa6] */
            ii(0x17_c288, 4); push(memw[ds, 0x1fa4]);                   /* push word [0x1fa4] */
            ii(0x17_c28c, 3); call(0x17_91e3, -0x30ac);                 /* call 0x91e3 */
            ii(0x17_c28f, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x17_c292, 4); test(memb[ss, bp - 34], 1);               /* test byte [bp-0x22], 0x1 */
            ii(0x17_c296, 2); if(jz(0x17_c302, 0x6a)) goto l_0x17_c302; /* jz 0xc302 */
            ii(0x17_c298, 5); mov(memw[ss, bp - 6], 0);                 /* mov word [bp-0x6], 0x0 */
            ii(0x17_c29d, 2); jmp(0x17_c2a3, 4); goto l_0x17_c2a3;      /* jmp 0xc2a3 */
        //  ii(0x17_c29f, 1); nop();                                    /* nop */
        l_0x17_c2a0:
            ii(0x17_c2a0, 3); inc(memw[ss, bp - 6]);                    /* inc word [bp-0x6] */
        l_0x17_c2a3:
            ii(0x17_c2a3, 3); mov(ax, memw[ss, bp - 6]);                /* mov ax, [bp-0x6] */
            ii(0x17_c2a6, 4); cmp(memw[ds, 0x519e], ax);                /* cmp [0x519e], ax */
            ii(0x17_c2aa, 2); if(jbe(0x17_c300, 0x54)) goto l_0x17_c300; /* jbe 0xc300 */
            ii(0x17_c2ac, 3); mov(ax, memw[ss, bp - 34]);               /* mov ax, [bp-0x22] */
            ii(0x17_c2af, 3); mov(dx, memw[ss, bp - 32]);               /* mov dx, [bp-0x20] */
            ii(0x17_c2b2, 2); mov(al, ah);                              /* mov al, ah */
            ii(0x17_c2b4, 2); mov(ah, dl);                              /* mov ah, dl */
            ii(0x17_c2b6, 2); mov(dl, dh);                              /* mov dl, dh */
            ii(0x17_c2b8, 2); sub(dh, dh);                              /* sub dh, dh */
            ii(0x17_c2ba, 2); shr(dx, 1);                               /* shr dx, 1 */
            ii(0x17_c2bc, 2); rcr(ax, 1);                               /* rcr ax, 1 */
            ii(0x17_c2be, 2); shr(dx, 1);                               /* shr dx, 1 */
            ii(0x17_c2c0, 2); rcr(ax, 1);                               /* rcr ax, 1 */
            ii(0x17_c2c2, 2); shr(dx, 1);                               /* shr dx, 1 */
            ii(0x17_c2c4, 2); rcr(ax, 1);                               /* rcr ax, 1 */
            ii(0x17_c2c6, 2); shr(dx, 1);                               /* shr dx, 1 */
            ii(0x17_c2c8, 2); rcr(ax, 1);                               /* rcr ax, 1 */
            ii(0x17_c2ca, 3); mov(bx, memw[ss, bp - 6]);                /* mov bx, [bp-0x6] */
            ii(0x17_c2cd, 3); shl(bx, 2);                               /* shl bx, 0x2 */
            ii(0x17_c2d0, 4); les(si, memw[ds, 0x4fa0]);                /* les si, [0x4fa0] */
            ii(0x17_c2d4, 3); cmp(memw[es, bx + si], ax);               /* cmp [es:bx+si], ax */
            ii(0x17_c2d7, 2); if(jnz(0x17_c2fe, 0x25)) goto l_0x17_c2fe; /* jnz 0xc2fe */
            ii(0x17_c2d9, 4); cmp(memw[es, bx + si + 2], dx);           /* cmp [es:bx+si+0x2], dx */
            ii(0x17_c2dd, 2); if(jnz(0x17_c2fe, 0x1f)) goto l_0x17_c2fe; /* jnz 0xc2fe */
            ii(0x17_c2df, 3); mov(ax, memw[ss, bp - 18]);               /* mov ax, [bp-0x12] */
            ii(0x17_c2e2, 3); mov(dx, memw[ss, bp - 16]);               /* mov dx, [bp-0x10] */
            ii(0x17_c2e5, 3); add(ax, memw[ss, bp - 30]);               /* add ax, [bp-0x1e] */
            ii(0x17_c2e8, 3); adc(dx, memw[ss, bp - 28]);               /* adc dx, [bp-0x1c] */
            ii(0x17_c2eb, 3); add(ax, 0);                               /* add ax, 0x0 */
            ii(0x17_c2ee, 3); adc(dx, 1);                               /* adc dx, 0x1 */
            ii(0x17_c2f1, 4); les(si, memw[ds, 0x4fa4]);                /* les si, [0x4fa4] */
            ii(0x17_c2f5, 3); mov(memw[es, bx + si], ax);               /* mov [es:bx+si], ax */
            ii(0x17_c2f8, 4); mov(memw[es, bx + si + 2], dx);           /* mov [es:bx+si+0x2], dx */
            ii(0x17_c2fc, 2); jmp(0x17_c300, 2); goto l_0x17_c300;      /* jmp 0xc300 */
        l_0x17_c2fe:
            ii(0x17_c2fe, 2); jmp(0x17_c2a0, -0x60); goto l_0x17_c2a0;  /* jmp 0xc2a0 */
        l_0x17_c300:
            ii(0x17_c300, 2); jmp(0x17_c363, 0x61); goto l_0x17_c363;   /* jmp 0xc363 */
        l_0x17_c302:
            ii(0x17_c302, 3); mov(ax, memw[ss, bp - 18]);               /* mov ax, [bp-0x12] */
            ii(0x17_c305, 3); mov(dx, memw[ss, bp - 16]);               /* mov dx, [bp-0x10] */
            ii(0x17_c308, 3); add(ax, memw[ss, bp - 22]);               /* add ax, [bp-0x16] */
            ii(0x17_c30b, 3); adc(dx, memw[ss, bp - 20]);               /* adc dx, [bp-0x14] */
            ii(0x17_c30e, 1); push(dx);                                 /* push dx */
            ii(0x17_c30f, 1); push(ax);                                 /* push ax */
            ii(0x17_c310, 3); call(0x17_8f06, -0x340d);                 /* call 0x8f06 */
            ii(0x17_c313, 3); add(sp, 4);                               /* add sp, 0x4 */
            ii(0x17_c316, 3); mov(memw[ss, bp - 38], ax);               /* mov [bp-0x26], ax */
            ii(0x17_c319, 3); mov(memw[ss, bp - 36], dx);               /* mov [bp-0x24], dx */
            ii(0x17_c31c, 3); cmp(ax, 0xffff);                          /* cmp ax, 0xffff */
            ii(0x17_c31f, 2); if(jnz(0x17_c325, 4)) goto l_0x17_c325;   /* jnz 0xc325 */
            ii(0x17_c321, 2); or(dx, dx);                               /* or dx, dx */
            ii(0x17_c323, 2); if(jz(0x17_c363, 0x3e)) goto l_0x17_c363; /* jz 0xc363 */
        l_0x17_c325:
            ii(0x17_c325, 1); push(dx);                                 /* push dx */
            ii(0x17_c326, 1); push(ax);                                 /* push ax */
            ii(0x17_c327, 4); push(memw[ds, 0x4fb6]);                   /* push word [0x4fb6] */
            ii(0x17_c32b, 4); push(memw[ds, 0x4fb4]);                   /* push word [0x4fb4] */
            ii(0x17_c32f, 3); call(0x17_9208, -0x312a);                 /* call 0x9208 */
            ii(0x17_c332, 3); add(sp, 8);                               /* add sp, 0x8 */
            ii(0x17_c335, 3); mov(memw[ss, bp - 14], ax);               /* mov [bp-0xe], ax */
            ii(0x17_c338, 3); mov(memw[ss, bp - 12], dx);               /* mov [bp-0xc], dx */
            ii(0x17_c33b, 3); xor(ax, memw[ss, bp - 30]);               /* xor ax, [bp-0x1e] */
            ii(0x17_c33e, 3); xor(dx, memw[ss, bp - 28]);               /* xor dx, [bp-0x1c] */
            ii(0x17_c341, 2); sub(dh, dh);                              /* sub dh, dh */
            ii(0x17_c343, 3); xor(memw[ss, bp - 14], ax);               /* xor [bp-0xe], ax */
            ii(0x17_c346, 3); xor(memw[ss, bp - 12], dx);               /* xor [bp-0xc], dx */
            ii(0x17_c349, 3); push(memw[ss, bp - 12]);                  /* push word [bp-0xc] */
            ii(0x17_c34c, 3); push(memw[ss, bp - 14]);                  /* push word [bp-0xe] */
            ii(0x17_c34f, 3); push(memw[ss, bp - 36]);                  /* push word [bp-0x24] */
            ii(0x17_c352, 3); push(memw[ss, bp - 38]);                  /* push word [bp-0x26] */
            ii(0x17_c355, 4); push(memw[ds, 0x4fb6]);                   /* push word [0x4fb6] */
            ii(0x17_c359, 4); push(memw[ds, 0x4fb4]);                   /* push word [0x4fb4] */
            ii(0x17_c35d, 3); call(0x17_9235, -0x312b);                 /* call 0x9235 */
            ii(0x17_c360, 3); add(sp, 0xc);                             /* add sp, 0xc */
        l_0x17_c363:
            ii(0x17_c363, 4); and(memb[ss, bp - 34], -2 /* 0xfe */);    /* and byte [bp-0x22], 0xfe */
            ii(0x17_c367, 3); mov(ax, memw[ss, bp - 34]);               /* mov ax, [bp-0x22] */
            ii(0x17_c36a, 3); and(ah, 0xf);                             /* and ah, 0xf */
            ii(0x17_c36d, 3); mov(memw[ss, bp - 34], ax);               /* mov [bp-0x22], ax */
            ii(0x17_c370, 5); mov(memw[ss, bp - 32], 0);                /* mov word [bp-0x20], 0x0 */
            ii(0x17_c375, 4); and(memb[ss, bp - 33], -0xf /* 0xf1 */);  /* and byte [bp-0x21], 0xf1 */
            ii(0x17_c379, 3); push(memw[ss, bp - 32]);                  /* push word [bp-0x20] */
            ii(0x17_c37c, 3); push(memw[ss, bp - 34]);                  /* push word [bp-0x22] */
            ii(0x17_c37f, 3); mov(ax, memw[ss, bp - 18]);               /* mov ax, [bp-0x12] */
            ii(0x17_c382, 3); mov(dx, memw[ss, bp - 16]);               /* mov dx, [bp-0x10] */
            ii(0x17_c385, 3); add(ax, memw[ss, bp - 22]);               /* add ax, [bp-0x16] */
            ii(0x17_c388, 3); adc(dx, memw[ss, bp - 20]);               /* adc dx, [bp-0x14] */
            ii(0x17_c38b, 1); push(dx);                                 /* push dx */
            ii(0x17_c38c, 1); push(ax);                                 /* push ax */
            ii(0x17_c38d, 4); push(memw[ds, 0x4f8e]);                   /* push word [0x4f8e] */
            ii(0x17_c391, 4); push(memw[ds, 0x4f8c]);                   /* push word [0x4f8c] */
            ii(0x17_c395, 3); call(0x17_9235, -0x3163);                 /* call 0x9235 */
            ii(0x17_c398, 3); add(sp, 0xc);                             /* add sp, 0xc */
            ii(0x17_c39b, 3); jmp(0x17_c1ba, -0x1e4); goto l_0x17_c1ba; /* jmp 0xc1ba */
        l_0x17_c39e:
            ii(0x17_c39e, 1); nop();                                    /* nop */
            ii(0x17_c39f, 1); push(cs);                                 /* push cs */
            ii(0x17_c3a0, 3); call(0x17_8e97, -0x350c);                 /* call 0x8e97 */
            ii(0x17_c3a3, 2); push(1);                                  /* push 0x1 */
            ii(0x17_c3a5, 3); mov(ax, memw[ss, bp + 8]);                /* mov ax, [bp+0x8] */
            ii(0x17_c3a8, 3); mov(dx, memw[ss, bp + 10]);               /* mov dx, [bp+0xa] */
            ii(0x17_c3ab, 3); sub(ax, memw[ss, bp - 4]);                /* sub ax, [bp-0x4] */
            ii(0x17_c3ae, 3); sbb(dx, memw[ss, bp - 2]);                /* sbb dx, [bp-0x2] */
            ii(0x17_c3b1, 1); push(dx);                                 /* push dx */
            ii(0x17_c3b2, 1); push(ax);                                 /* push ax */
            ii(0x17_c3b3, 3); mov(ax, memw[ss, bp - 4]);                /* mov ax, [bp-0x4] */
            ii(0x17_c3b6, 3); mov(dx, memw[ss, bp - 2]);                /* mov dx, [bp-0x2] */
            ii(0x17_c3b9, 2); mov(dh, dl);                              /* mov dh, dl */
            ii(0x17_c3bb, 2); mov(dl, ah);                              /* mov dl, ah */
            ii(0x17_c3bd, 2); mov(ah, al);                              /* mov ah, al */
            ii(0x17_c3bf, 2); sub(al, al);                              /* sub al, al */
            ii(0x17_c3c1, 2); shl(ax, 1);                               /* shl ax, 1 */
            ii(0x17_c3c3, 2); rcl(dx, 1);                               /* rcl dx, 1 */
            ii(0x17_c3c5, 2); shl(ax, 1);                               /* shl ax, 1 */
            ii(0x17_c3c7, 2); rcl(dx, 1);                               /* rcl dx, 1 */
            ii(0x17_c3c9, 2); shl(ax, 1);                               /* shl ax, 1 */
            ii(0x17_c3cb, 2); rcl(dx, 1);                               /* rcl dx, 1 */
            ii(0x17_c3cd, 2); shl(ax, 1);                               /* shl ax, 1 */
            ii(0x17_c3cf, 2); rcl(dx, 1);                               /* rcl dx, 1 */
            ii(0x17_c3d1, 3); add(ax, memw[ss, bp - 10]);               /* add ax, [bp-0xa] */
            ii(0x17_c3d4, 3); adc(dx, memw[ss, bp - 8]);                /* adc dx, [bp-0x8] */
            ii(0x17_c3d7, 1); push(dx);                                 /* push dx */
            ii(0x17_c3d8, 1); push(ax);                                 /* push ax */
            ii(0x17_c3d9, 3); mov(al, memb[ds, 0x51a7]);                /* mov al, [0x51a7] */
            ii(0x17_c3dc, 2); sub(ah, ah);                              /* sub ah, ah */
            ii(0x17_c3de, 1); push(ax);                                 /* push ax */
            ii(0x17_c3df, 3); push(memw[ss, bp + 6]);                   /* push word [bp+0x6] */
            ii(0x17_c3e2, 1); push(cs);                                 /* push cs */
            ii(0x17_c3e3, 3); call(0x17_c48e, 0xa8);                    /* call 0xc48e */
            ii(0x17_c3e6, 3); add(sp, 0xe);                             /* add sp, 0xe */
            ii(0x17_c3e9, 3); mov(ax, memw[ss, bp - 4]);                /* mov ax, [bp-0x4] */
            ii(0x17_c3ec, 3); mov(dx, memw[ss, bp - 2]);                /* mov dx, [bp-0x2] */
            ii(0x17_c3ef, 3); sub(ax, memw[ss, bp + 8]);                /* sub ax, [bp+0x8] */
            ii(0x17_c3f2, 3); sbb(dx, memw[ss, bp + 10]);               /* sbb dx, [bp+0xa] */
            ii(0x17_c3f5, 4); add(memw[ds, 0x1fc4], ax);                /* add [0x1fc4], ax */
            ii(0x17_c3f9, 4); adc(memw[ds, 0x1fc6], dx);                /* adc [0x1fc6], dx */
            ii(0x17_c3fd, 4); add(memw[ds, 0x1fac], ax);                /* add [0x1fac], ax */
            ii(0x17_c401, 4); adc(memw[ds, 0x1fae], dx);                /* adc [0x1fae], dx */
            ii(0x17_c405, 5); cmp(memw[ds, 0x1fae], 0);                 /* cmp word [0x1fae], 0x0 */
            ii(0x17_c40a, 2); if(jge(0x17_c414, 8)) goto l_0x17_c414;   /* jge 0xc414 */
            ii(0x17_c40c, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x17_c40e, 3); mov(memw[ds, 0x1fae], ax);                /* mov [0x1fae], ax */
            ii(0x17_c411, 3); mov(memw[ds, 0x1fac], ax);                /* mov [0x1fac], ax */
        l_0x17_c414:
            ii(0x17_c414, 3); mov(ax, memw[ss, bp - 4]);                /* mov ax, [bp-0x4] */
            ii(0x17_c417, 3); mov(dx, memw[ss, bp - 2]);                /* mov dx, [bp-0x2] */
            ii(0x17_c41a, 3); sub(ax, memw[ss, bp + 8]);                /* sub ax, [bp+0x8] */
            ii(0x17_c41d, 3); sbb(dx, memw[ss, bp + 10]);               /* sbb dx, [bp+0xa] */
            ii(0x17_c420, 4); add(memw[ds, 0x1fbc], ax);                /* add [0x1fbc], ax */
            ii(0x17_c424, 4); adc(memw[ds, 0x1fbe], dx);                /* adc [0x1fbe], dx */
            ii(0x17_c428, 5); cmp(memw[ds, 0x1fbe], 0);                 /* cmp word [0x1fbe], 0x0 */
            ii(0x17_c42d, 2); if(jge(0x17_c437, 8)) goto l_0x17_c437;   /* jge 0xc437 */
            ii(0x17_c42f, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x17_c431, 3); mov(memw[ds, 0x1fbe], ax);                /* mov [0x1fbe], ax */
            ii(0x17_c434, 3); mov(memw[ds, 0x1fbc], ax);                /* mov [0x1fbc], ax */
        l_0x17_c437:
            ii(0x17_c437, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x17_c439, 2); jmp(0x17_c44a, 0xf); goto l_0x17_c44a;    /* jmp 0xc44a */
        //  ii(0x17_c43b, 1); nop();                                    /* nop */
        l_0x17_c43c:
            ii(0x17_c43c, 3); mov(ax, 0x8012);                          /* mov ax, 0x8012 */
            ii(0x17_c43f, 2); jmp(0x17_c44a, 9); goto l_0x17_c44a;      /* jmp 0xc44a */
        //  ii(0x17_c441, 1); nop();                                    /* nop */
        //  ii(0x17_c442, 2); jmp(0x17_c44a, 6); goto l_0x17_c44a;      /* jmp 0xc44a */
        l_0x17_c444:
            ii(0x17_c444, 3); mov(ax, 0x8023);                          /* mov ax, 0x8023 */
            ii(0x17_c447, 2); jmp(0x17_c44a, 1); goto l_0x17_c44a;      /* jmp 0xc44a */
        //  ii(0x17_c449, 1); nop();                                    /* nop */
        l_0x17_c44a:
            ii(0x17_c44a, 1); pop(ds);                                  /* pop ds */
            ii(0x17_c44b, 1); pop(si);                                  /* pop si */
            ii(0x17_c44c, 1); pop(di);                                  /* pop di */
            ii(0x17_c44d, 1); leave();                                  /* leave */
            ii(0x17_c44e, 1); retf();                                   /* retf */
        }
    }
}
