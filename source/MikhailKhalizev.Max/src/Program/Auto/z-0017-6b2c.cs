using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_6b2c-4abea5f3")]
        public void Method_0017_6b2c()
        {
            ii(0x17_6b2c, 4); enter(0x36, 0);                           /* enter 0x36, 0x0 */
            ii(0x17_6b30, 1); push(di);                                 /* push di */
            ii(0x17_6b31, 1); push(si);                                 /* push si */
            ii(0x17_6b32, 1); push(ds);                                 /* push ds */
            ii(0x17_6b33, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x17_6b36, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x17_6b38, 5); mov(memw[ss, bp - 0xc], 0);               /* mov word [bp-0xc], 0x0 */
            ii(0x17_6b3d, 5); mov(memw[ss, bp - 0x1c], 0);              /* mov word [bp-0x1c], 0x0 */
            ii(0x17_6b42, 3); mov(ax, memw[ds, 0x8c]);                  /* mov ax, [0x8c] */
            ii(0x17_6b45, 4); mov(dx, memw[ds, 0x8e]);                  /* mov dx, [0x8e] */
            ii(0x17_6b49, 2); mov(al, ah);                              /* mov al, ah */
            ii(0x17_6b4b, 2); mov(ah, dl);                              /* mov ah, dl */
            ii(0x17_6b4d, 2); mov(dl, dh);                              /* mov dl, dh */
            ii(0x17_6b4f, 2); sub(dh, dh);                              /* sub dh, dh */
            ii(0x17_6b51, 2); shr(dx, 1);                               /* shr dx, 1 */
            ii(0x17_6b53, 2); rcr(ax, 1);                               /* rcr ax, 1 */
            ii(0x17_6b55, 2); shr(dx, 1);                               /* shr dx, 1 */
            ii(0x17_6b57, 2); rcr(ax, 1);                               /* rcr ax, 1 */
            ii(0x17_6b59, 2); shr(dx, 1);                               /* shr dx, 1 */
            ii(0x17_6b5b, 2); rcr(ax, 1);                               /* rcr ax, 1 */
            ii(0x17_6b5d, 2); shr(dx, 1);                               /* shr dx, 1 */
            ii(0x17_6b5f, 2); rcr(ax, 1);                               /* rcr ax, 1 */
            ii(0x17_6b61, 3); mov(memw[ss, bp - 0xa], ax);              /* mov [bp-0xa], ax */
            ii(0x17_6b64, 3); mov(memw[ss, bp - 8], dx);                /* mov [bp-0x8], dx */
            ii(0x17_6b67, 2); mov(al, ah);                              /* mov al, ah */
            ii(0x17_6b69, 2); mov(ah, dl);                              /* mov ah, dl */
            ii(0x17_6b6b, 2); mov(dl, dh);                              /* mov dl, dh */
            ii(0x17_6b6d, 2); sub(dh, dh);                              /* sub dh, dh */
            ii(0x17_6b6f, 2); shr(dx, 1);                               /* shr dx, 1 */
            ii(0x17_6b71, 2); rcr(ax, 1);                               /* rcr ax, 1 */
            ii(0x17_6b73, 2); shr(dx, 1);                               /* shr dx, 1 */
            ii(0x17_6b75, 2); rcr(ax, 1);                               /* rcr ax, 1 */
            ii(0x17_6b77, 3); mov(memw[ss, bp - 2], ax);                /* mov [bp-0x2], ax */
            ii(0x17_6b7a, 3); mov(cx, memw[ss, bp - 0xa]);              /* mov cx, [bp-0xa] */
            ii(0x17_6b7d, 3); and(ch, 3);                               /* and ch, 0x3 */
            ii(0x17_6b80, 2); or(cx, cx);                               /* or cx, cx */
            ii(0x17_6b82, 2); if(jz(0x17_6b88, 4)) goto l_0x17_6b88;    /* jz 0x6b88 */
            ii(0x17_6b84, 1); inc(ax);                                  /* inc ax */
            ii(0x17_6b85, 3); mov(memw[ss, bp - 2], ax);                /* mov [bp-0x2], ax */
        l_0x17_6b88:
            ii(0x17_6b88, 3); mov(ax, memw[ss, bp - 0xa]);              /* mov ax, [bp-0xa] */
            ii(0x17_6b8b, 2); mov(cx, ax);                              /* mov cx, ax */
            ii(0x17_6b8d, 3); shl(ax, 2);                               /* shl ax, 0x2 */
            ii(0x17_6b90, 1); push(ax);                                 /* push ax */
            ii(0x17_6b91, 3); push(memw[ss, bp - 2]);                   /* push word [bp-0x2] */
            ii(0x17_6b94, 2); mov(si, ax);                              /* mov si, ax */
            ii(0x17_6b96, 2); mov(di, cx);                              /* mov di, cx */
            ii(0x17_6b98, 1); push(cs);                                 /* push cs */
            ii(0x17_6b99, 3); call(0x17_7476, 0x8da);                   /* call 0x7476 */
            ii(0x17_6b9c, 3); add(sp, 2);                               /* add sp, 0x2 */
            ii(0x17_6b9f, 3); mov(memw[ss, bp - 0x32], ax);             /* mov [bp-0x32], ax */
            ii(0x17_6ba2, 3); mov(memw[ss, bp - 0x30], dx);             /* mov [bp-0x30], dx */
            ii(0x17_6ba5, 1); push(dx);                                 /* push dx */
            ii(0x17_6ba6, 1); push(ax);                                 /* push ax */
            ii(0x17_6ba7, 1); nop();                                    /* nop */
            ii(0x17_6ba8, 1); push(cs);                                 /* push cs */
            ii(0x17_6ba9, 3); call(0x17_e96a, 0x7dbe);                  /* call 0xe96a */
            ii(0x17_6bac, 3); add(sp, 6);                               /* add sp, 0x6 */
            ii(0x17_6baf, 3); mov(memw[ss, bp - 0x20], ax);             /* mov [bp-0x20], ax */
            ii(0x17_6bb2, 3); mov(memw[ss, bp - 0x1e], dx);             /* mov [bp-0x1e], dx */
            ii(0x17_6bb5, 1); push(si);                                 /* push si */
            ii(0x17_6bb6, 1); push(dx);                                 /* push dx */
            ii(0x17_6bb7, 1); push(ax);                                 /* push ax */
            ii(0x17_6bb8, 1); nop();                                    /* nop */
            ii(0x17_6bb9, 1); push(cs);                                 /* push cs */
            ii(0x17_6bba, 3); call(0x17_8ed0, 0x2313);                  /* call 0x8ed0 */
            ii(0x17_6bbd, 3); add(sp, 6);                               /* add sp, 0x6 */
            ii(0x17_6bc0, 2); push(1);                                  /* push 0x1 */
            ii(0x17_6bc2, 1); push(cs);                                 /* push cs */
            ii(0x17_6bc3, 3); call(0x17_7476, 0x8b0);                   /* call 0x7476 */
            ii(0x17_6bc6, 3); add(sp, 2);                               /* add sp, 0x2 */
            ii(0x17_6bc9, 3); mov(memw[ds, 0x4f84], ax);                /* mov [0x4f84], ax */
            ii(0x17_6bcc, 4); mov(memw[ds, 0x4f86], dx);                /* mov [0x4f86], dx */
            ii(0x17_6bd0, 3); mov(ax, memw[ss, bp - 0x32]);             /* mov ax, [bp-0x32] */
            ii(0x17_6bd3, 3); mov(dx, memw[ss, bp - 0x30]);             /* mov dx, [bp-0x30] */
            ii(0x17_6bd6, 3); mov(memw[ss, bp - 0x2a], ax);             /* mov [bp-0x2a], ax */
            ii(0x17_6bd9, 3); mov(memw[ss, bp - 0x28], dx);             /* mov [bp-0x28], dx */
            ii(0x17_6bdc, 3); push(0x1000);                             /* push 0x1000 */
            ii(0x17_6bdf, 4); push(memw[ds, 0x4f86]);                   /* push word [0x4f86] */
            ii(0x17_6be3, 4); push(memw[ds, 0x4f84]);                   /* push word [0x4f84] */
            ii(0x17_6be7, 1); nop();                                    /* nop */
            ii(0x17_6be8, 1); push(cs);                                 /* push cs */
            ii(0x17_6be9, 3); call(0x17_e96a, 0x7d7e);                  /* call 0xe96a */
            ii(0x17_6bec, 3); add(sp, 6);                               /* add sp, 0x6 */
            ii(0x17_6bef, 3); mov(memw[ss, bp - 0x36], ax);             /* mov [bp-0x36], ax */
            ii(0x17_6bf2, 3); mov(memw[ss, bp - 0x34], dx);             /* mov [bp-0x34], dx */
            ii(0x17_6bf5, 3); mov(memw[ss, bp - 0x10], ax);             /* mov [bp-0x10], ax */
            ii(0x17_6bf8, 3); mov(memw[ss, bp - 0xe], dx);              /* mov [bp-0xe], dx */
            ii(0x17_6bfb, 3); push(0x1000);                             /* push 0x1000 */
            ii(0x17_6bfe, 1); push(dx);                                 /* push dx */
            ii(0x17_6bff, 1); push(ax);                                 /* push ax */
            ii(0x17_6c00, 1); nop();                                    /* nop */
            ii(0x17_6c01, 1); push(cs);                                 /* push cs */
            ii(0x17_6c02, 3); call(0x17_8ed0, 0x22cb);                  /* call 0x8ed0 */
            ii(0x17_6c05, 3); add(sp, 6);                               /* add sp, 0x6 */
            ii(0x17_6c08, 3); mov(ax, memw[ss, bp - 0xa]);              /* mov ax, [bp-0xa] */
            ii(0x17_6c0b, 3); mov(dx, memw[ss, bp - 8]);                /* mov dx, [bp-0x8] */
            ii(0x17_6c0e, 2); mov(al, ah);                              /* mov al, ah */
            ii(0x17_6c10, 2); mov(ah, dl);                              /* mov ah, dl */
            ii(0x17_6c12, 2); mov(dl, dh);                              /* mov dl, dh */
            ii(0x17_6c14, 2); sub(dh, dh);                              /* sub dh, dh */
            ii(0x17_6c16, 2); shr(dx, 1);                               /* shr dx, 1 */
            ii(0x17_6c18, 2); rcr(ax, 1);                               /* rcr ax, 1 */
            ii(0x17_6c1a, 2); shr(dx, 1);                               /* shr dx, 1 */
            ii(0x17_6c1c, 2); rcr(ax, 1);                               /* rcr ax, 1 */
            ii(0x17_6c1e, 3); mov(memw[ss, bp - 0x22], ax);             /* mov [bp-0x22], ax */
            ii(0x17_6c21, 4); test(di, 0x3ff);                          /* test di, 0x3ff */
            ii(0x17_6c25, 2); if(jz(0x17_6c2b, 4)) goto l_0x17_6c2b;    /* jz 0x6c2b */
            ii(0x17_6c27, 1); inc(ax);                                  /* inc ax */
            ii(0x17_6c28, 3); mov(memw[ss, bp - 0x22], ax);             /* mov [bp-0x22], ax */
        l_0x17_6c2b:
            ii(0x17_6c2b, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x17_6c2d, 3); mov(memw[ss, bp - 0x2c], ax);             /* mov [bp-0x2c], ax */
            ii(0x17_6c30, 3); mov(memw[ss, bp - 0x2e], ax);             /* mov [bp-0x2e], ax */
            ii(0x17_6c33, 2); jmp(0x17_6c3f, 0xa); goto l_0x17_6c3f;    /* jmp 0x6c3f */
        //  ii(0x17_6c35, 1); nop();                                    /* nop */
        l_0x17_6c36:
            ii(0x17_6c36, 5); add(memw[ss, bp - 0x2a], 0x1000);         /* add word [bp-0x2a], 0x1000 */
            ii(0x17_6c3b, 4); adc(memw[ss, bp - 0x28], 0);              /* adc word [bp-0x28], 0x0 */
        l_0x17_6c3f:
            ii(0x17_6c3f, 3); mov(ax, memw[ss, bp - 0x22]);             /* mov ax, [bp-0x22] */
            ii(0x17_6c42, 2); sub(dx, dx);                              /* sub dx, dx */
            ii(0x17_6c44, 3); cmp(dx, memw[ss, bp - 0x2c]);             /* cmp dx, [bp-0x2c] */
            ii(0x17_6c47, 2); if(jb(0x17_6c80, 0x37)) goto l_0x17_6c80; /* jb 0x6c80 */
            ii(0x17_6c49, 2); if(ja(0x17_6c50, 5)) goto l_0x17_6c50;    /* ja 0x6c50 */
            ii(0x17_6c4b, 3); cmp(ax, memw[ss, bp - 0x2e]);             /* cmp ax, [bp-0x2e] */
            ii(0x17_6c4e, 2); if(jb(0x17_6c80, 0x30)) goto l_0x17_6c80; /* jb 0x6c80 */
        l_0x17_6c50:
            ii(0x17_6c50, 3); les(bx, memw[ss, bp - 0x10]);             /* les bx, [bp-0x10] */
            ii(0x17_6c53, 3); mov(ax, memw[es, bx]);                    /* mov ax, [es:bx] */
            ii(0x17_6c56, 3); xor(ax, memw[ss, bp - 0x2a]);             /* xor ax, [bp-0x2a] */
            ii(0x17_6c59, 3); and(ah, 0xf);                             /* and ah, 0xf */
            ii(0x17_6c5c, 3); xor(ax, memw[ss, bp - 0x2a]);             /* xor ax, [bp-0x2a] */
            ii(0x17_6c5f, 3); xor(dx, memw[ss, bp - 0x28]);             /* xor dx, [bp-0x28] */
            ii(0x17_6c62, 3); mov(memw[es, bx], ax);                    /* mov [es:bx], ax */
            ii(0x17_6c65, 4); mov(memw[es, bx + 2], dx);                /* mov [es:bx+0x2], dx */
            ii(0x17_6c69, 4); or(memb[es, bx], 7);                      /* or byte [es:bx], 0x7 */
            ii(0x17_6c6d, 5); and(memw[es, bx], 0xf007);                /* and word [es:bx], 0xf007 */
            ii(0x17_6c72, 4); add(memw[ss, bp - 0x10], 4);              /* add word [bp-0x10], 0x4 */
            ii(0x17_6c76, 4); add(memw[ss, bp - 0x2e], 1);              /* add word [bp-0x2e], 0x1 */
            ii(0x17_6c7a, 4); adc(memw[ss, bp - 0x2c], 0);              /* adc word [bp-0x2c], 0x0 */
            ii(0x17_6c7e, 2); jmp(0x17_6c36, -0x4a); goto l_0x17_6c36;  /* jmp 0x6c36 */
        l_0x17_6c80:
            ii(0x17_6c80, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x17_6c82, 3); mov(memw[ss, bp - 0x28], ax);             /* mov [bp-0x28], ax */
            ii(0x17_6c85, 3); mov(memw[ss, bp - 0x2a], ax);             /* mov [bp-0x2a], ax */
            ii(0x17_6c88, 3); mov(memw[ss, bp - 0x2c], ax);             /* mov [bp-0x2c], ax */
            ii(0x17_6c8b, 3); mov(memw[ss, bp - 0x2e], ax);             /* mov [bp-0x2e], ax */
            ii(0x17_6c8e, 2); jmp(0x17_6c98, 8); goto l_0x17_6c98;      /* jmp 0x6c98 */
        l_0x17_6c90:
            ii(0x17_6c90, 4); add(memw[ss, bp - 0x2e], 1);              /* add word [bp-0x2e], 0x1 */
            ii(0x17_6c94, 4); adc(memw[ss, bp - 0x2c], 0);              /* adc word [bp-0x2c], 0x0 */
        l_0x17_6c98:
            ii(0x17_6c98, 3); mov(ax, memw[ds, 0x8c]);                  /* mov ax, [0x8c] */
            ii(0x17_6c9b, 4); mov(dx, memw[ds, 0x8e]);                  /* mov dx, [0x8e] */
            ii(0x17_6c9f, 2); mov(al, ah);                              /* mov al, ah */
            ii(0x17_6ca1, 2); mov(ah, dl);                              /* mov ah, dl */
            ii(0x17_6ca3, 2); mov(dl, dh);                              /* mov dl, dh */
            ii(0x17_6ca5, 2); sub(dh, dh);                              /* sub dh, dh */
            ii(0x17_6ca7, 2); shr(dx, 1);                               /* shr dx, 1 */
            ii(0x17_6ca9, 2); rcr(ax, 1);                               /* rcr ax, 1 */
            ii(0x17_6cab, 2); shr(dx, 1);                               /* shr dx, 1 */
            ii(0x17_6cad, 2); rcr(ax, 1);                               /* rcr ax, 1 */
            ii(0x17_6caf, 2); shr(dx, 1);                               /* shr dx, 1 */
            ii(0x17_6cb1, 2); rcr(ax, 1);                               /* rcr ax, 1 */
            ii(0x17_6cb3, 2); shr(dx, 1);                               /* shr dx, 1 */
            ii(0x17_6cb5, 2); rcr(ax, 1);                               /* rcr ax, 1 */
            ii(0x17_6cb7, 3); cmp(dx, memw[ss, bp - 0x2c]);             /* cmp dx, [bp-0x2c] */
            ii(0x17_6cba, 2); if(jb(0x17_6d20, 0x64)) goto l_0x17_6d20; /* jb 0x6d20 */
            ii(0x17_6cbc, 2); if(ja(0x17_6cc3, 5)) goto l_0x17_6cc3;    /* ja 0x6cc3 */
            ii(0x17_6cbe, 3); cmp(ax, memw[ss, bp - 0x2e]);             /* cmp ax, [bp-0x2e] */
            ii(0x17_6cc1, 2); if(jbe(0x17_6d20, 0x5d)) goto l_0x17_6d20; /* jbe 0x6d20 */
        l_0x17_6cc3:
            ii(0x17_6cc3, 3); mov(ax, memw[ss, bp - 0x2a]);             /* mov ax, [bp-0x2a] */
            ii(0x17_6cc6, 3); mov(dx, memw[ss, bp - 0x28]);             /* mov dx, [bp-0x28] */
            ii(0x17_6cc9, 2); mov(dh, dl);                              /* mov dh, dl */
            ii(0x17_6ccb, 2); mov(dl, ah);                              /* mov dl, ah */
            ii(0x17_6ccd, 2); mov(ah, al);                              /* mov ah, al */
            ii(0x17_6ccf, 2); sub(al, al);                              /* sub al, al */
            ii(0x17_6cd1, 2); shl(ax, 1);                               /* shl ax, 1 */
            ii(0x17_6cd3, 2); rcl(dx, 1);                               /* rcl dx, 1 */
            ii(0x17_6cd5, 2); shl(ax, 1);                               /* shl ax, 1 */
            ii(0x17_6cd7, 2); rcl(dx, 1);                               /* rcl dx, 1 */
            ii(0x17_6cd9, 2); shl(ax, 1);                               /* shl ax, 1 */
            ii(0x17_6cdb, 2); rcl(dx, 1);                               /* rcl dx, 1 */
            ii(0x17_6cdd, 2); shl(ax, 1);                               /* shl ax, 1 */
            ii(0x17_6cdf, 2); rcl(dx, 1);                               /* rcl dx, 1 */
            ii(0x17_6ce1, 2); mov(cx, ax);                              /* mov cx, ax */
            ii(0x17_6ce3, 2); mov(bx, dx);                              /* mov bx, dx */
            ii(0x17_6ce5, 3); mov(si, memw[ss, bp - 0x2e]);             /* mov si, [bp-0x2e] */
            ii(0x17_6ce8, 3); shl(si, 2);                               /* shl si, 0x2 */
            ii(0x17_6ceb, 3); add(si, memw[ss, bp - 0x20]);             /* add si, [bp-0x20] */
            ii(0x17_6cee, 3); mov(es, memw[ss, bp - 0x1e]);             /* mov es, [bp-0x1e] */
            ii(0x17_6cf1, 3); mov(memw[ss, bp - 0x10], si);             /* mov [bp-0x10], si */
            ii(0x17_6cf4, 3); mov(memw[ss, bp - 0xe], es);              /* mov [bp-0xe], es */
            ii(0x17_6cf7, 3); xor(ax, memw[es, si]);                    /* xor ax, [es:si] */
            ii(0x17_6cfa, 3); and(ah, 0xf);                             /* and ah, 0xf */
            ii(0x17_6cfd, 2); sub(dx, dx);                              /* sub dx, dx */
            ii(0x17_6cff, 2); xor(cx, ax);                              /* xor cx, ax */
            ii(0x17_6d01, 2); xor(bx, dx);                              /* xor bx, dx */
            ii(0x17_6d03, 3); mov(memw[es, si], cx);                    /* mov [es:si], cx */
            ii(0x17_6d06, 4); mov(memw[es, si + 2], bx);                /* mov [es:si+0x2], bx */
            ii(0x17_6d0a, 3); les(bx, memw[ss, bp - 0x10]);             /* les bx, [bp-0x10] */
            ii(0x17_6d0d, 4); or(memb[es, bx], 7);                      /* or byte [es:bx], 0x7 */
            ii(0x17_6d11, 4); add(memw[ss, bp - 0x10], 4);              /* add word [bp-0x10], 0x4 */
            ii(0x17_6d15, 4); add(memw[ss, bp - 0x2a], 1);              /* add word [bp-0x2a], 0x1 */
            ii(0x17_6d19, 4); adc(memw[ss, bp - 0x28], 0);              /* adc word [bp-0x28], 0x0 */
            ii(0x17_6d1d, 3); jmp(0x17_6c90, -0x90); goto l_0x17_6c90;  /* jmp 0x6c90 */
        l_0x17_6d20:
            ii(0x17_6d20, 3); mov(ax, memw[ss, bp - 0x36]);             /* mov ax, [bp-0x36] */
            ii(0x17_6d23, 3); mov(dx, memw[ss, bp - 0x34]);             /* mov dx, [bp-0x34] */
            ii(0x17_6d26, 1); pop(ds);                                  /* pop ds */
            ii(0x17_6d27, 1); pop(si);                                  /* pop si */
            ii(0x17_6d28, 1); pop(di);                                  /* pop di */
            ii(0x17_6d29, 1); leave();                                  /* leave */
            ii(0x17_6d2a, 1); retf();                                   /* retf */
        }
    }
}
