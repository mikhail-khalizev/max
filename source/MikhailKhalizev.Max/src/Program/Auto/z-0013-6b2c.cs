using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c57e37bc-7913-490b-99c7-d00172957384")]
        public void Method_0013_6b2c()
        {
            ii(0x13_6b2c, 4); enterw(0x36, 0);                          /* enter 0x36, 0x0 */
            ii(0x13_6b30, 1); pushw(di);                                /* push di */
            ii(0x13_6b31, 1); pushw(si);                                /* push si */
            ii(0x13_6b32, 1); pushw(ds);                                /* push ds */
            ii(0x13_6b33, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x13_6b36, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x13_6b38, 5); mov(memw_a16[ss, bp - 0xc], 0);           /* mov word [bp-0xc], 0x0 */
            ii(0x13_6b3d, 5); mov(memw_a16[ss, bp - 0x1c], 0);          /* mov word [bp-0x1c], 0x0 */
            ii(0x13_6b42, 3); mov(ax, memw_a16[ds, 0x8c]);              /* mov ax, [0x8c] */
            ii(0x13_6b45, 4); mov(dx, memw_a16[ds, 0x8e]);              /* mov dx, [0x8e] */
            ii(0x13_6b49, 2); mov(al, ah);                              /* mov al, ah */
            ii(0x13_6b4b, 2); mov(ah, dl);                              /* mov ah, dl */
            ii(0x13_6b4d, 2); mov(dl, dh);                              /* mov dl, dh */
            ii(0x13_6b4f, 2); sub(dh, dh);                              /* sub dh, dh */
            ii(0x13_6b51, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x13_6b53, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x13_6b55, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x13_6b57, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x13_6b59, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x13_6b5b, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x13_6b5d, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x13_6b5f, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x13_6b61, 3); mov(memw_a16[ss, bp - 0xa], ax);          /* mov [bp-0xa], ax */
            ii(0x13_6b64, 3); mov(memw_a16[ss, bp - 0x8], dx);          /* mov [bp-0x8], dx */
            ii(0x13_6b67, 2); mov(al, ah);                              /* mov al, ah */
            ii(0x13_6b69, 2); mov(ah, dl);                              /* mov ah, dl */
            ii(0x13_6b6b, 2); mov(dl, dh);                              /* mov dl, dh */
            ii(0x13_6b6d, 2); sub(dh, dh);                              /* sub dh, dh */
            ii(0x13_6b6f, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x13_6b71, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x13_6b73, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x13_6b75, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x13_6b77, 3); mov(memw_a16[ss, bp - 0x2], ax);          /* mov [bp-0x2], ax */
            ii(0x13_6b7a, 3); mov(cx, memw_a16[ss, bp - 0xa]);          /* mov cx, [bp-0xa] */
            ii(0x13_6b7d, 3); and(ch, 0x3);                             /* and ch, 0x3 */
            ii(0x13_6b80, 2); or(cx, cx);                               /* or cx, cx */
            ii(0x13_6b82, 2); if(jzw(0x13_6b88, 0x4)) goto l_0x13_6b88; /* jz 0x6b88 */
            ii(0x13_6b84, 1); inc(ax);                                  /* inc ax */
            ii(0x13_6b85, 3); mov(memw_a16[ss, bp - 0x2], ax);          /* mov [bp-0x2], ax */
        l_0x13_6b88:
            ii(0x13_6b88, 3); mov(ax, memw_a16[ss, bp - 0xa]);          /* mov ax, [bp-0xa] */
            ii(0x13_6b8b, 2); mov(cx, ax);                              /* mov cx, ax */
            ii(0x13_6b8d, 3); shl(ax, 0x2);                             /* shl ax, 0x2 */
            ii(0x13_6b90, 1); pushw(ax);                                /* push ax */
            ii(0x13_6b91, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x13_6b94, 2); mov(si, ax);                              /* mov si, ax */
            ii(0x13_6b96, 2); mov(di, cx);                              /* mov di, cx */
            ii(0x13_6b98, 1); pushw(cs);                                /* push cs */
            ii(0x13_6b99, 3); callw(0x13_7476, 0x8da);                  /* call 0x7476 */
            ii(0x13_6b9c, 3); add(sp, 0x2);                             /* add sp, 0x2 */
            ii(0x13_6b9f, 3); mov(memw_a16[ss, bp - 0x32], ax);         /* mov [bp-0x32], ax */
            ii(0x13_6ba2, 3); mov(memw_a16[ss, bp - 0x30], dx);         /* mov [bp-0x30], dx */
            ii(0x13_6ba5, 1); pushw(dx);                                /* push dx */
            ii(0x13_6ba6, 1); pushw(ax);                                /* push ax */
            ii(0x13_6ba7, 1); nop();                                    /* nop */
            ii(0x13_6ba8, 1); pushw(cs);                                /* push cs */
            ii(0x13_6ba9, 3); callw(0x13_e96a, 0x7dbe);                 /* call 0xe96a */
            ii(0x13_6bac, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x13_6baf, 3); mov(memw_a16[ss, bp - 0x20], ax);         /* mov [bp-0x20], ax */
            ii(0x13_6bb2, 3); mov(memw_a16[ss, bp - 0x1e], dx);         /* mov [bp-0x1e], dx */
            ii(0x13_6bb5, 1); pushw(si);                                /* push si */
            ii(0x13_6bb6, 1); pushw(dx);                                /* push dx */
            ii(0x13_6bb7, 1); pushw(ax);                                /* push ax */
            ii(0x13_6bb8, 1); nop();                                    /* nop */
            ii(0x13_6bb9, 1); pushw(cs);                                /* push cs */
            ii(0x13_6bba, 3); callw(0x13_8ed0, 0x2313);                 /* call 0x8ed0 */
            ii(0x13_6bbd, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x13_6bc0, 2); pushw(0x1);                               /* push 0x1 */
            ii(0x13_6bc2, 1); pushw(cs);                                /* push cs */
            ii(0x13_6bc3, 3); callw(0x13_7476, 0x8b0);                  /* call 0x7476 */
            ii(0x13_6bc6, 3); add(sp, 0x2);                             /* add sp, 0x2 */
            ii(0x13_6bc9, 3); mov(memw_a16[ds, 0x4f84], ax);            /* mov [0x4f84], ax */
            ii(0x13_6bcc, 4); mov(memw_a16[ds, 0x4f86], dx);            /* mov [0x4f86], dx */
            ii(0x13_6bd0, 3); mov(ax, memw_a16[ss, bp - 0x32]);         /* mov ax, [bp-0x32] */
            ii(0x13_6bd3, 3); mov(dx, memw_a16[ss, bp - 0x30]);         /* mov dx, [bp-0x30] */
            ii(0x13_6bd6, 3); mov(memw_a16[ss, bp - 0x2a], ax);         /* mov [bp-0x2a], ax */
            ii(0x13_6bd9, 3); mov(memw_a16[ss, bp - 0x28], dx);         /* mov [bp-0x28], dx */
            ii(0x13_6bdc, 3); pushw(0x1000);                            /* push 0x1000 */
            ii(0x13_6bdf, 4); pushw(memw_a16[ds, 0x4f86]);              /* push word [0x4f86] */
            ii(0x13_6be3, 4); pushw(memw_a16[ds, 0x4f84]);              /* push word [0x4f84] */
            ii(0x13_6be7, 1); nop();                                    /* nop */
            ii(0x13_6be8, 1); pushw(cs);                                /* push cs */
            ii(0x13_6be9, 3); callw(0x13_e96a, 0x7d7e);                 /* call 0xe96a */
            ii(0x13_6bec, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x13_6bef, 3); mov(memw_a16[ss, bp - 0x36], ax);         /* mov [bp-0x36], ax */
            ii(0x13_6bf2, 3); mov(memw_a16[ss, bp - 0x34], dx);         /* mov [bp-0x34], dx */
            ii(0x13_6bf5, 3); mov(memw_a16[ss, bp - 0x10], ax);         /* mov [bp-0x10], ax */
            ii(0x13_6bf8, 3); mov(memw_a16[ss, bp - 0xe], dx);          /* mov [bp-0xe], dx */
            ii(0x13_6bfb, 3); pushw(0x1000);                            /* push 0x1000 */
            ii(0x13_6bfe, 1); pushw(dx);                                /* push dx */
            ii(0x13_6bff, 1); pushw(ax);                                /* push ax */
            ii(0x13_6c00, 1); nop();                                    /* nop */
            ii(0x13_6c01, 1); pushw(cs);                                /* push cs */
            ii(0x13_6c02, 3); callw(0x13_8ed0, 0x22cb);                 /* call 0x8ed0 */
            ii(0x13_6c05, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x13_6c08, 3); mov(ax, memw_a16[ss, bp - 0xa]);          /* mov ax, [bp-0xa] */
            ii(0x13_6c0b, 3); mov(dx, memw_a16[ss, bp - 0x8]);          /* mov dx, [bp-0x8] */
            ii(0x13_6c0e, 2); mov(al, ah);                              /* mov al, ah */
            ii(0x13_6c10, 2); mov(ah, dl);                              /* mov ah, dl */
            ii(0x13_6c12, 2); mov(dl, dh);                              /* mov dl, dh */
            ii(0x13_6c14, 2); sub(dh, dh);                              /* sub dh, dh */
            ii(0x13_6c16, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x13_6c18, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x13_6c1a, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x13_6c1c, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x13_6c1e, 3); mov(memw_a16[ss, bp - 0x22], ax);         /* mov [bp-0x22], ax */
            ii(0x13_6c21, 4); test(di, 0x3ff);                          /* test di, 0x3ff */
            ii(0x13_6c25, 2); if(jzw(0x13_6c2b, 0x4)) goto l_0x13_6c2b; /* jz 0x6c2b */
            ii(0x13_6c27, 1); inc(ax);                                  /* inc ax */
            ii(0x13_6c28, 3); mov(memw_a16[ss, bp - 0x22], ax);         /* mov [bp-0x22], ax */
        l_0x13_6c2b:
            ii(0x13_6c2b, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x13_6c2d, 3); mov(memw_a16[ss, bp - 0x2c], ax);         /* mov [bp-0x2c], ax */
            ii(0x13_6c30, 3); mov(memw_a16[ss, bp - 0x2e], ax);         /* mov [bp-0x2e], ax */
            ii(0x13_6c33, 2); jmpw(0x13_6c3f, 0xa); goto l_0x13_6c3f;   /* jmp 0x6c3f */
        //  ii(0x13_6c35, 1); Недостижимый код.
l_0x13_6c36:
            ii(0x13_6c36, 5); add(memw_a16[ss, bp - 0x2a], 0x1000);     /* add word [bp-0x2a], 0x1000 */
            ii(0x13_6c3b, 4); adc(memw_a16[ss, bp - 0x28], 0);          /* adc word [bp-0x28], 0x0 */
        l_0x13_6c3f:
            ii(0x13_6c3f, 3); mov(ax, memw_a16[ss, bp - 0x22]);         /* mov ax, [bp-0x22] */
            ii(0x13_6c42, 2); sub(dx, dx);                              /* sub dx, dx */
            ii(0x13_6c44, 3); cmp(dx, memw_a16[ss, bp - 0x2c]);         /* cmp dx, [bp-0x2c] */
            ii(0x13_6c47, 2); if(jbw(0x13_6c80, 0x37)) goto l_0x13_6c80; /* jb 0x6c80 */
            ii(0x13_6c49, 2); if(jaw(0x13_6c50, 0x5)) goto l_0x13_6c50; /* ja 0x6c50 */
            ii(0x13_6c4b, 3); cmp(ax, memw_a16[ss, bp - 0x2e]);         /* cmp ax, [bp-0x2e] */
            ii(0x13_6c4e, 2); if(jbw(0x13_6c80, 0x30)) goto l_0x13_6c80; /* jb 0x6c80 */
        l_0x13_6c50:
            ii(0x13_6c50, 3); les(bx, ss, bp - 0x10);                   /* les bx, [bp-0x10] */
            ii(0x13_6c53, 3); mov(ax, memw_a16[es, bx]);                /* mov ax, [es:bx] */
            ii(0x13_6c56, 3); xor(ax, memw_a16[ss, bp - 0x2a]);         /* xor ax, [bp-0x2a] */
            ii(0x13_6c59, 3); and(ah, 0xf);                             /* and ah, 0xf */
            ii(0x13_6c5c, 3); xor(ax, memw_a16[ss, bp - 0x2a]);         /* xor ax, [bp-0x2a] */
            ii(0x13_6c5f, 3); xor(dx, memw_a16[ss, bp - 0x28]);         /* xor dx, [bp-0x28] */
            ii(0x13_6c62, 3); mov(memw_a16[es, bx], ax);                /* mov [es:bx], ax */
            ii(0x13_6c65, 4); mov(memw_a16[es, bx + 0x2], dx);          /* mov [es:bx+0x2], dx */
            ii(0x13_6c69, 4); or(memb_a16[es, bx], 0x7);                /* or byte [es:bx], 0x7 */
            ii(0x13_6c6d, 5); and(memw_a16[es, bx], 0xf007);            /* and word [es:bx], 0xf007 */
            ii(0x13_6c72, 4); add(memw_a16[ss, bp - 0x10], 0x4);        /* add word [bp-0x10], 0x4 */
            ii(0x13_6c76, 4); add(memw_a16[ss, bp - 0x2e], 0x1);        /* add word [bp-0x2e], 0x1 */
            ii(0x13_6c7a, 4); adc(memw_a16[ss, bp - 0x2c], 0);          /* adc word [bp-0x2c], 0x0 */
            ii(0x13_6c7e, 2); jmpw(0x13_6c36, -0x4a); goto l_0x13_6c36; /* jmp 0x6c36 */
        l_0x13_6c80:
            ii(0x13_6c80, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x13_6c82, 3); mov(memw_a16[ss, bp - 0x28], ax);         /* mov [bp-0x28], ax */
            ii(0x13_6c85, 3); mov(memw_a16[ss, bp - 0x2a], ax);         /* mov [bp-0x2a], ax */
            ii(0x13_6c88, 3); mov(memw_a16[ss, bp - 0x2c], ax);         /* mov [bp-0x2c], ax */
            ii(0x13_6c8b, 3); mov(memw_a16[ss, bp - 0x2e], ax);         /* mov [bp-0x2e], ax */
            ii(0x13_6c8e, 2); jmpw(0x13_6c98, 0x8); goto l_0x13_6c98;   /* jmp 0x6c98 */
        l_0x13_6c90:
            ii(0x13_6c90, 4); add(memw_a16[ss, bp - 0x2e], 0x1);        /* add word [bp-0x2e], 0x1 */
            ii(0x13_6c94, 4); adc(memw_a16[ss, bp - 0x2c], 0);          /* adc word [bp-0x2c], 0x0 */
        l_0x13_6c98:
            ii(0x13_6c98, 3); mov(ax, memw_a16[ds, 0x8c]);              /* mov ax, [0x8c] */
            ii(0x13_6c9b, 4); mov(dx, memw_a16[ds, 0x8e]);              /* mov dx, [0x8e] */
            ii(0x13_6c9f, 2); mov(al, ah);                              /* mov al, ah */
            ii(0x13_6ca1, 2); mov(ah, dl);                              /* mov ah, dl */
            ii(0x13_6ca3, 2); mov(dl, dh);                              /* mov dl, dh */
            ii(0x13_6ca5, 2); sub(dh, dh);                              /* sub dh, dh */
            ii(0x13_6ca7, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x13_6ca9, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x13_6cab, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x13_6cad, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x13_6caf, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x13_6cb1, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x13_6cb3, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x13_6cb5, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x13_6cb7, 3); cmp(dx, memw_a16[ss, bp - 0x2c]);         /* cmp dx, [bp-0x2c] */
            ii(0x13_6cba, 2); if(jbw(0x13_6d20, 0x64)) goto l_0x13_6d20; /* jb 0x6d20 */
            ii(0x13_6cbc, 2); if(jaw(0x13_6cc3, 0x5)) goto l_0x13_6cc3; /* ja 0x6cc3 */
            ii(0x13_6cbe, 3); cmp(ax, memw_a16[ss, bp - 0x2e]);         /* cmp ax, [bp-0x2e] */
            ii(0x13_6cc1, 2); if(jbew(0x13_6d20, 0x5d)) goto l_0x13_6d20; /* jbe 0x6d20 */
        l_0x13_6cc3:
            ii(0x13_6cc3, 3); mov(ax, memw_a16[ss, bp - 0x2a]);         /* mov ax, [bp-0x2a] */
            ii(0x13_6cc6, 3); mov(dx, memw_a16[ss, bp - 0x28]);         /* mov dx, [bp-0x28] */
            ii(0x13_6cc9, 2); mov(dh, dl);                              /* mov dh, dl */
            ii(0x13_6ccb, 2); mov(dl, ah);                              /* mov dl, ah */
            ii(0x13_6ccd, 2); mov(ah, al);                              /* mov ah, al */
            ii(0x13_6ccf, 2); sub(al, al);                              /* sub al, al */
            ii(0x13_6cd1, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_6cd3, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_6cd5, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_6cd7, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_6cd9, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_6cdb, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_6cdd, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_6cdf, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_6ce1, 2); mov(cx, ax);                              /* mov cx, ax */
            ii(0x13_6ce3, 2); mov(bx, dx);                              /* mov bx, dx */
            ii(0x13_6ce5, 3); mov(si, memw_a16[ss, bp - 0x2e]);         /* mov si, [bp-0x2e] */
            ii(0x13_6ce8, 3); shl(si, 0x2);                             /* shl si, 0x2 */
            ii(0x13_6ceb, 3); add(si, memw_a16[ss, bp - 0x20]);         /* add si, [bp-0x20] */
            ii(0x13_6cee, 3); mov(es, memw_a16[ss, bp - 0x1e]);         /* mov es, [bp-0x1e] */
            ii(0x13_6cf1, 3); mov(memw_a16[ss, bp - 0x10], si);         /* mov [bp-0x10], si */
            ii(0x13_6cf4, 3); mov(memw_a16[ss, bp - 0xe], es);          /* mov [bp-0xe], es */
            ii(0x13_6cf7, 3); xor(ax, memw_a16[es, si]);                /* xor ax, [es:si] */
            ii(0x13_6cfa, 3); and(ah, 0xf);                             /* and ah, 0xf */
            ii(0x13_6cfd, 2); sub(dx, dx);                              /* sub dx, dx */
            ii(0x13_6cff, 2); xor(cx, ax);                              /* xor cx, ax */
            ii(0x13_6d01, 2); xor(bx, dx);                              /* xor bx, dx */
            ii(0x13_6d03, 3); mov(memw_a16[es, si], cx);                /* mov [es:si], cx */
            ii(0x13_6d06, 4); mov(memw_a16[es, si + 0x2], bx);          /* mov [es:si+0x2], bx */
            ii(0x13_6d0a, 3); les(bx, ss, bp - 0x10);                   /* les bx, [bp-0x10] */
            ii(0x13_6d0d, 4); or(memb_a16[es, bx], 0x7);                /* or byte [es:bx], 0x7 */
            ii(0x13_6d11, 4); add(memw_a16[ss, bp - 0x10], 0x4);        /* add word [bp-0x10], 0x4 */
            ii(0x13_6d15, 4); add(memw_a16[ss, bp - 0x2a], 0x1);        /* add word [bp-0x2a], 0x1 */
            ii(0x13_6d19, 4); adc(memw_a16[ss, bp - 0x28], 0);          /* adc word [bp-0x28], 0x0 */
            ii(0x13_6d1d, 3); jmpw(0x13_6c90, -0x90); goto l_0x13_6c90; /* jmp 0x6c90 */
        l_0x13_6d20:
            ii(0x13_6d20, 3); mov(ax, memw_a16[ss, bp - 0x36]);         /* mov ax, [bp-0x36] */
            ii(0x13_6d23, 3); mov(dx, memw_a16[ss, bp - 0x34]);         /* mov dx, [bp-0x34] */
            ii(0x13_6d26, 1); popw(ds);                                 /* pop ds */
            ii(0x13_6d27, 1); popw(si);                                 /* pop si */
            ii(0x13_6d28, 1); popw(di);                                 /* pop di */
            ii(0x13_6d29, 1); leavew();                                 /* leave */
            ii(0x13_6d2a, 1); retfw(); return;                          /* retf */
        }
    }
}