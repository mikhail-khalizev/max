using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_8ba6-c26c20b5")]
        public void Method_0017_8ba6()
        {
            ii(0x17_8ba6, 4);  enter(6, 0);                            /* enter 0x6, 0x0 */
            ii(0x17_8baa, 1);  push(si);                               /* push si */
            ii(0x17_8bab, 1);  push(ds);                               /* push ds */
            ii(0x17_8bac, 3);  mov(ax, 0x3e68);                        /* mov ax, 0x3e68 */
            ii(0x17_8baf, 2);  mov(ds, ax);                            /* mov ds, ax */
            ii(0x17_8bb1, 3);  push(memw[ss, bp + 8]);                 /* push word [bp+0x8] */
            ii(0x17_8bb4, 3);  push(memw[ss, bp + 6]);                 /* push word [bp+0x6] */
            ii(0x17_8bb7, 1);  push(ds);                               /* push ds */
            ii(0x17_8bb8, 3);  push(0xab9);                            /* push 0xab9 */
            ii(0x17_8bbb, 1);  nop();                                  /* nop */
            ii(0x17_8bbc, 1);  push(cs);                               /* push cs */
            ii(0x17_8bbd, 3);  call(0x17_104f, -0x7b71);               /* call 0x104f */
            ii(0x17_8bc0, 3);  add(sp, 8);                             /* add sp, 0x8 */
            ii(0x17_8bc3, 3);  mov(ax, memw[ds, 0x18]);                /* mov ax, [0x18] */
            ii(0x17_8bc6, 4);  mov(dx, memw[ds, 0x1a]);                /* mov dx, [0x1a] */
            ii(0x17_8bca, 2);  shr(dx, 1);                             /* shr dx, 1 */
            ii(0x17_8bcc, 2);  rcr(ax, 1);                             /* rcr ax, 1 */
            ii(0x17_8bce, 2);  shr(dx, 1);                             /* shr dx, 1 */
            ii(0x17_8bd0, 2);  rcr(ax, 1);                             /* rcr ax, 1 */
            ii(0x17_8bd2, 3);  cmp(dx, memw[ss, bp + 8]);              /* cmp dx, [bp+0x8] */
            ii(0x17_8bd5, 2);  if(jb(0x17_8be4, 0xd)) goto l_0x17_8be4;/* jb 0x8be4 */
            ii(0x17_8bd7, 2);  if(ja(0x17_8bde, 5)) goto l_0x17_8bde;  /* ja 0x8bde */
            ii(0x17_8bd9, 3);  cmp(ax, memw[ss, bp + 6]);              /* cmp ax, [bp+0x6] */
            ii(0x17_8bdc, 2);  if(jbe(0x17_8be4, 6)) goto l_0x17_8be4; /* jbe 0x8be4 */
        l_0x17_8bde:
            ii(0x17_8bde, 3);  mov(memw[ss, bp + 6], ax);              /* mov [bp+0x6], ax */
            ii(0x17_8be1, 3);  mov(memw[ss, bp + 8], dx);              /* mov [bp+0x8], dx */
        l_0x17_8be4:
            ii(0x17_8be4, 3);  mov(ax, memw[ds, 0x1f50]);              /* mov ax, [0x1f50] */
            ii(0x17_8be7, 4);  mov(dx, memw[ds, 0x1f52]);              /* mov dx, [0x1f52] */
            ii(0x17_8beb, 3);  add(ax, memw[ss, bp + 6]);              /* add ax, [bp+0x6] */
            ii(0x17_8bee, 3);  adc(dx, memw[ss, bp + 8]);              /* adc dx, [bp+0x8] */
            ii(0x17_8bf1, 3);  mov(memw[ss, bp - 4], ax);              /* mov [bp-0x4], ax */
            ii(0x17_8bf4, 3);  mov(memw[ss, bp - 2], dx);              /* mov [bp-0x2], dx */
            ii(0x17_8bf7, 4);  mov(cx, memw[ds, 0x2c]);                /* mov cx, [0x2c] */
            ii(0x17_8bfb, 4);  mov(bx, memw[ds, 0x2e]);                /* mov bx, [0x2e] */
            ii(0x17_8bff, 2);  shr(bx, 1);                             /* shr bx, 1 */
            ii(0x17_8c01, 2);  rcr(cx, 1);                             /* rcr cx, 1 */
            ii(0x17_8c03, 2);  shr(bx, 1);                             /* shr bx, 1 */
            ii(0x17_8c05, 2);  rcr(cx, 1);                             /* rcr cx, 1 */
            ii(0x17_8c07, 2);  cmp(dx, bx);                            /* cmp dx, bx */
            ii(0x17_8c09, 2);  if(jb(0x17_8c18, 0xd)) goto l_0x17_8c18;/* jb 0x8c18 */
            ii(0x17_8c0b, 2);  if(ja(0x17_8c11, 4)) goto l_0x17_8c11;  /* ja 0x8c11 */
            ii(0x17_8c0d, 2);  cmp(ax, cx);                            /* cmp ax, cx */
            ii(0x17_8c0f, 2);  if(jbe(0x17_8c18, 7)) goto l_0x17_8c18; /* jbe 0x8c18 */
        l_0x17_8c11:
            ii(0x17_8c11, 2);  sub(ax, ax);                            /* sub ax, ax */
            ii(0x17_8c13, 1);  pop(ds);                                /* pop ds */
            ii(0x17_8c14, 1);  pop(si);                                /* pop si */
            ii(0x17_8c15, 1);  leave();                                /* leave */
            ii(0x17_8c16, 1);  retf(); return;                         /* retf */
        //  ii(0x17_8c17, 1);  Недостижимый код.
        l_0x17_8c18:
            ii(0x17_8c18, 1);  push(cs);                               /* push cs */
            ii(0x17_8c19, 3);  call(0x17_8d64, 0x148);                 /* call 0x8d64 */
            ii(0x17_8c1c, 4);  les(bx, memw[ds, 0xa30]);               /* les bx, [0xa30] */
            ii(0x17_8c20, 4);  mov(al, memb[es, bx + 19]);             /* mov al, [es:bx+0x13] */
            ii(0x17_8c24, 3);  mov(memb[ss, bp - 6], al);              /* mov [bp-0x6], al */
            ii(0x17_8c27, 2);  mov(ax, es);                            /* mov ax, es */
            ii(0x17_8c29, 4);  les(si, memw[ds, 0x1f60]);              /* les si, [0x1f60] */
            ii(0x17_8c2d, 4);  mov(cl, memb[es, si + 4]);              /* mov cl, [es:si+0x4] */
            ii(0x17_8c31, 2);  mov(es, ax);                            /* mov es, ax */
            ii(0x17_8c33, 4);  mov(memb[es, bx + 19], cl);             /* mov [es:bx+0x13], cl */
            ii(0x17_8c37, 2);  push(0);                                /* push 0x0 */
            ii(0x17_8c39, 3);  mov(ax, memw[ss, bp - 4]);              /* mov ax, [bp-0x4] */
            ii(0x17_8c3c, 3);  mov(dx, memw[ss, bp - 2]);              /* mov dx, [bp-0x2] */
            ii(0x17_8c3f, 2);  mov(dh, dl);                            /* mov dh, dl */
            ii(0x17_8c41, 2);  mov(dl, ah);                            /* mov dl, ah */
            ii(0x17_8c43, 2);  mov(ah, al);                            /* mov ah, al */
            ii(0x17_8c45, 2);  sub(al, al);                            /* sub al, al */
            ii(0x17_8c47, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x17_8c49, 2);  rcl(dx, 1);                             /* rcl dx, 1 */
            ii(0x17_8c4b, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x17_8c4d, 2);  rcl(dx, 1);                             /* rcl dx, 1 */
            ii(0x17_8c4f, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x17_8c51, 2);  rcl(dx, 1);                             /* rcl dx, 1 */
            ii(0x17_8c53, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x17_8c55, 2);  rcl(dx, 1);                             /* rcl dx, 1 */
            ii(0x17_8c57, 3);  sub(ax, 1);                             /* sub ax, 0x1 */
            ii(0x17_8c5a, 3);  sbb(dx, 0);                             /* sbb dx, 0x0 */
            ii(0x17_8c5d, 1);  push(dx);                               /* push dx */
            ii(0x17_8c5e, 1);  push(ax);                               /* push ax */
            ii(0x17_8c5f, 2);  push(0x13);                             /* push 0x13 */
            ii(0x17_8c61, 1);  nop();                                  /* nop */
            ii(0x17_8c62, 1);  push(cs);                               /* push cs */
            ii(0x17_8c63, 3);  call(0x17_d91c, 0x4cb6);                /* call 0xd91c */
            ii(0x17_8c66, 3);  add(sp, 8);                             /* add sp, 0x8 */
            ii(0x17_8c69, 2);  or(dx, dx);                             /* or dx, dx */
            ii(0x17_8c6b, 2);  if(jl(0x17_8c80, 0x13)) goto l_0x17_8c80;/* jl 0x8c80 */
            ii(0x17_8c6d, 2);  push(1);                                /* push 0x1 */
            ii(0x17_8c6f, 2);  push(0);                                /* push 0x0 */
            ii(0x17_8c71, 2);  push(0x13);                             /* push 0x13 */
            ii(0x17_8c73, 1);  nop();                                  /* nop */
            ii(0x17_8c74, 1);  push(cs);                               /* push cs */
            ii(0x17_8c75, 3);  call(0x17_d996, 0x4d1e);                /* call 0xd996 */
            ii(0x17_8c78, 3);  add(sp, 6);                             /* add sp, 0x6 */
            ii(0x17_8c7b, 3);  cmp(ax, 1);                             /* cmp ax, 0x1 */
            ii(0x17_8c7e, 2);  if(jge(0x17_8c92, 0x12)) goto l_0x17_8c92;/* jge 0x8c92 */
        l_0x17_8c80:
            ii(0x17_8c80, 3);  mov(al, memb[ss, bp - 6]);              /* mov al, [bp-0x6] */
            ii(0x17_8c83, 4);  les(bx, memw[ds, 0xa30]);               /* les bx, [0xa30] */
            ii(0x17_8c87, 4);  mov(memb[es, bx + 19], al);             /* mov [es:bx+0x13], al */
            ii(0x17_8c8b, 2);  sub(ax, ax);                            /* sub ax, ax */
            ii(0x17_8c8d, 1);  pop(ds);                                /* pop ds */
            ii(0x17_8c8e, 1);  pop(si);                                /* pop si */
            ii(0x17_8c8f, 1);  leave();                                /* leave */
            ii(0x17_8c90, 1);  retf(); return;                         /* retf */
        //  ii(0x17_8c91, 1);  Недостижимый код.
        l_0x17_8c92:
            ii(0x17_8c92, 4);  les(bx, memw[ds, 0x1f60]);              /* les bx, [0x1f60] */
            ii(0x17_8c96, 2);  sub(ax, ax);                            /* sub ax, ax */
            ii(0x17_8c98, 4);  mov(memw[es, bx + 2], ax);              /* mov [es:bx+0x2], ax */
            ii(0x17_8c9c, 3);  mov(memw[es, bx], ax);                  /* mov [es:bx], ax */
            ii(0x17_8c9f, 1);  push(ax);                               /* push ax */
            ii(0x17_8ca0, 1);  push(ax);                               /* push ax */
            ii(0x17_8ca1, 1);  push(ax);                               /* push ax */
            ii(0x17_8ca2, 2);  push(0x13);                             /* push 0x13 */
            ii(0x17_8ca4, 1);  nop();                                  /* nop */
            ii(0x17_8ca5, 1);  push(cs);                               /* push cs */
            ii(0x17_8ca6, 3);  call(0x17_d91c, 0x4c73);                /* call 0xd91c */
            ii(0x17_8ca9, 3);  add(sp, 8);                             /* add sp, 0x8 */
            ii(0x17_8cac, 1);  pusha();                                /* pusha */
            ii(0x17_8cad, 3);  mov(bx, 0x13);                          /* mov bx, 0x13 */
            ii(0x17_8cb0, 2);  mov(ah, 0x45);                          /* mov ah, 0x45 */
            ii(0x17_8cb2, 4);  call_far_ind(memw[ds, 0x1fe0]);         /* call far word [0x1fe0] */
            ii(0x17_8cb6, 2);  if(jb(0x17_8cc0, 8)) goto l_0x17_8cc0;  /* jb 0x8cc0 */
            ii(0x17_8cb8, 2);  mov(bx, ax);                            /* mov bx, ax */
            ii(0x17_8cba, 2);  mov(ah, 0x3e);                          /* mov ah, 0x3e */
            ii(0x17_8cbc, 4);  call_far_ind(memw[ds, 0x1fe0]);         /* call far word [0x1fe0] */
        l_0x17_8cc0:
            ii(0x17_8cc0, 1);  popa();                                 /* popa */
            ii(0x17_8cc1, 3);  mov(ax, memw[ss, bp - 4]);              /* mov ax, [bp-0x4] */
            ii(0x17_8cc4, 3);  mov(dx, memw[ss, bp - 2]);              /* mov dx, [bp-0x2] */
            ii(0x17_8cc7, 3);  mov(memw[ds, 0x1f50], ax);              /* mov [0x1f50], ax */
            ii(0x17_8cca, 4);  mov(memw[ds, 0x1f52], dx);              /* mov [0x1f52], dx */
            ii(0x17_8cce, 3);  mov(al, memb[ss, bp - 6]);              /* mov al, [bp-0x6] */
            ii(0x17_8cd1, 4);  les(bx, memw[ds, 0xa30]);               /* les bx, [0xa30] */
            ii(0x17_8cd5, 4);  mov(memb[es, bx + 19], al);             /* mov [es:bx+0x13], al */
            ii(0x17_8cd9, 3);  mov(ax, 1);                             /* mov ax, 0x1 */
            ii(0x17_8cdc, 1);  pop(ds);                                /* pop ds */
            ii(0x17_8cdd, 1);  pop(si);                                /* pop si */
            ii(0x17_8cde, 1);  leave();                                /* leave */
            ii(0x17_8cdf, 1);  retf();                                 /* retf */
        }
    }
}
