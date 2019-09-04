using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_a688-25c7b073")]
        public void Method_0017_a688()
        {
            ii(0x17_a688, 4);  enter(0x2a, 0);                         /* enter 0x2a, 0x0 */
            ii(0x17_a68c, 1);  push(di);                               /* push di */
            ii(0x17_a68d, 1);  push(si);                               /* push si */
            ii(0x17_a68e, 1);  push(ds);                               /* push ds */
            ii(0x17_a68f, 3);  mov(ax, 0x3e68);                        /* mov ax, 0x3e68 */
            ii(0x17_a692, 2);  mov(ds, ax);                            /* mov ds, ax */
            ii(0x17_a694, 5);  mov(memw[ss, bp - 14], 0);              /* mov word [bp-0xe], 0x0 */
            ii(0x17_a699, 3);  les(bx, memw[ss, bp + 6]);              /* les bx, [bp+0x6] */
            ii(0x17_a69c, 4);  mov(ax, memw[es, bx + 20]);             /* mov ax, [es:bx+0x14] */
            ii(0x17_a6a0, 4);  mov(dx, memw[es, bx + 22]);             /* mov dx, [es:bx+0x16] */
            ii(0x17_a6a4, 3);  mov(memw[ss, bp - 12], ax);             /* mov [bp-0xc], ax */
            ii(0x17_a6a7, 3);  mov(memw[ss, bp - 10], dx);             /* mov [bp-0xa], dx */
            ii(0x17_a6aa, 4);  mov(ax, memw[es, bx + 28]);             /* mov ax, [es:bx+0x1c] */
            ii(0x17_a6ae, 4);  mov(dx, memw[es, bx + 30]);             /* mov dx, [es:bx+0x1e] */
            ii(0x17_a6b2, 3);  mov(memw[ss, bp - 4], ax);              /* mov [bp-0x4], ax */
            ii(0x17_a6b5, 3);  mov(memw[ss, bp - 2], dx);              /* mov [bp-0x2], dx */
            ii(0x17_a6b8, 6);  test(memw[es, bx + 10], 0xffff);        /* test word [es:bx+0xa], 0xffff */
            ii(0x17_a6be, 2);  if(jz(0x17_a6c8, 8)) goto l_0x17_a6c8;  /* jz 0xa6c8 */
            ii(0x17_a6c0, 5);  mov(memw[ss, bp - 14], 0x8023);         /* mov word [bp-0xe], 0x8023 */
            ii(0x17_a6c5, 3);  jmp(0x17_a8cc, 0x204); goto l_0x17_a8cc;/* jmp 0xa8cc */
        l_0x17_a6c8:
            ii(0x17_a6c8, 4);  mov(ax, memw[es, bx + 8]);              /* mov ax, [es:bx+0x8] */
            ii(0x17_a6cc, 3);  mov(memw[ss, bp - 40], ax);             /* mov [bp-0x28], ax */
            ii(0x17_a6cf, 1);  push(ax);                               /* push ax */
            ii(0x17_a6d0, 1);  push(cs);                               /* push cs */
            ii(0x17_a6d1, 3);  call(0x17_c79c, 0x20c8);                /* call 0xc79c */
            ii(0x17_a6d4, 3);  add(sp, 2);                             /* add sp, 0x2 */
            ii(0x17_a6d7, 3);  mov(memw[ss, bp - 18], ax);             /* mov [bp-0x12], ax */
            ii(0x17_a6da, 3);  mov(memw[ss, bp - 16], dx);             /* mov [bp-0x10], dx */
            ii(0x17_a6dd, 3);  cmp(ax, 0xffff);                        /* cmp ax, 0xffff */
            ii(0x17_a6e0, 2);  if(jnz(0x17_a6ee, 0xc)) goto l_0x17_a6ee;/* jnz 0xa6ee */
            ii(0x17_a6e2, 2);  cmp(dx, ax);                            /* cmp dx, ax */
            ii(0x17_a6e4, 2);  if(jnz(0x17_a6ee, 8)) goto l_0x17_a6ee; /* jnz 0xa6ee */
            ii(0x17_a6e6, 5);  mov(memw[ss, bp - 14], 0x8023);         /* mov word [bp-0xe], 0x8023 */
            ii(0x17_a6eb, 3);  jmp(0x17_a8cc, 0x1de); goto l_0x17_a8cc;/* jmp 0xa8cc */
        l_0x17_a6ee:
            ii(0x17_a6ee, 3);  mov(ax, memw[ss, bp - 12]);             /* mov ax, [bp-0xc] */
            ii(0x17_a6f1, 3);  mov(dx, memw[ss, bp - 10]);             /* mov dx, [bp-0xa] */
            ii(0x17_a6f4, 2);  mov(al, ah);                            /* mov al, ah */
            ii(0x17_a6f6, 2);  mov(ah, dl);                            /* mov ah, dl */
            ii(0x17_a6f8, 2);  mov(dl, dh);                            /* mov dl, dh */
            ii(0x17_a6fa, 2);  sub(dh, dh);                            /* sub dh, dh */
            ii(0x17_a6fc, 2);  shr(dx, 1);                             /* shr dx, 1 */
            ii(0x17_a6fe, 2);  rcr(ax, 1);                             /* rcr ax, 1 */
            ii(0x17_a700, 2);  shr(dx, 1);                             /* shr dx, 1 */
            ii(0x17_a702, 2);  rcr(ax, 1);                             /* rcr ax, 1 */
            ii(0x17_a704, 2);  shr(dx, 1);                             /* shr dx, 1 */
            ii(0x17_a706, 2);  rcr(ax, 1);                             /* rcr ax, 1 */
            ii(0x17_a708, 2);  shr(dx, 1);                             /* shr dx, 1 */
            ii(0x17_a70a, 2);  rcr(ax, 1);                             /* rcr ax, 1 */
            ii(0x17_a70c, 3);  add(memw[ss, bp - 18], ax);             /* add [bp-0x12], ax */
            ii(0x17_a70f, 3);  adc(memw[ss, bp - 16], dx);             /* adc [bp-0x10], dx */
            ii(0x17_a712, 3);  mov(ax, memw[ss, bp - 18]);             /* mov ax, [bp-0x12] */
            ii(0x17_a715, 3);  mov(dx, memw[ss, bp - 16]);             /* mov dx, [bp-0x10] */
            ii(0x17_a718, 3);  add(ax, 0);                             /* add ax, 0x0 */
            ii(0x17_a71b, 3);  adc(dx, 1);                             /* adc dx, 0x1 */
            ii(0x17_a71e, 2);  mov(dh, dl);                            /* mov dh, dl */
            ii(0x17_a720, 2);  mov(dl, ah);                            /* mov dl, ah */
            ii(0x17_a722, 2);  mov(ah, al);                            /* mov ah, al */
            ii(0x17_a724, 2);  sub(al, al);                            /* sub al, al */
            ii(0x17_a726, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x17_a728, 2);  rcl(dx, 1);                             /* rcl dx, 1 */
            ii(0x17_a72a, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x17_a72c, 2);  rcl(dx, 1);                             /* rcl dx, 1 */
            ii(0x17_a72e, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x17_a730, 2);  rcl(dx, 1);                             /* rcl dx, 1 */
            ii(0x17_a732, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x17_a734, 2);  rcl(dx, 1);                             /* rcl dx, 1 */
            ii(0x17_a736, 3);  mov(memw[ss, bp - 8], ax);              /* mov [bp-0x8], ax */
            ii(0x17_a739, 3);  mov(memw[ss, bp - 6], dx);              /* mov [bp-0x6], dx */
            ii(0x17_a73c, 3);  les(bx, memw[ss, bp + 6]);              /* les bx, [bp+0x6] */
            ii(0x17_a73f, 4);  mov(cx, memw[es, bx + 24]);             /* mov cx, [es:bx+0x18] */
            ii(0x17_a743, 4);  mov(si, memw[es, bx + 26]);             /* mov si, [es:bx+0x1a] */
            ii(0x17_a747, 3);  mov(memw[ss, bp - 34], cx);             /* mov [bp-0x22], cx */
            ii(0x17_a74a, 3);  mov(memw[ss, bp - 32], si);             /* mov [bp-0x20], si */
            ii(0x17_a74d, 2);  mov(di, ax);                            /* mov di, ax */
            ii(0x17_a74f, 2);  mov(bx, dx);                            /* mov bx, dx */
            ii(0x17_a751, 2);  mov(ax, cx);                            /* mov ax, cx */
            ii(0x17_a753, 2);  mov(dx, si);                            /* mov dx, si */
            ii(0x17_a755, 2);  mov(al, ah);                            /* mov al, ah */
            ii(0x17_a757, 2);  mov(ah, dl);                            /* mov ah, dl */
            ii(0x17_a759, 2);  mov(dl, dh);                            /* mov dl, dh */
            ii(0x17_a75b, 2);  sub(dh, dh);                            /* sub dh, dh */
            ii(0x17_a75d, 2);  shr(dx, 1);                             /* shr dx, 1 */
            ii(0x17_a75f, 2);  rcr(ax, 1);                             /* rcr ax, 1 */
            ii(0x17_a761, 2);  shr(dx, 1);                             /* shr dx, 1 */
            ii(0x17_a763, 2);  rcr(ax, 1);                             /* rcr ax, 1 */
            ii(0x17_a765, 2);  shr(dx, 1);                             /* shr dx, 1 */
            ii(0x17_a767, 2);  rcr(ax, 1);                             /* rcr ax, 1 */
            ii(0x17_a769, 2);  shr(dx, 1);                             /* shr dx, 1 */
            ii(0x17_a76b, 2);  rcr(ax, 1);                             /* rcr ax, 1 */
            ii(0x17_a76d, 3);  mov(memw[ss, bp - 22], ax);             /* mov [bp-0x16], ax */
            ii(0x17_a770, 3);  mov(memw[ss, bp - 20], dx);             /* mov [bp-0x14], dx */
            ii(0x17_a773, 3);  add(di, memw[ss, bp - 12]);             /* add di, [bp-0xc] */
            ii(0x17_a776, 3);  adc(bx, memw[ss, bp - 10]);             /* adc bx, [bp-0xa] */
            ii(0x17_a779, 1);  push(bx);                               /* push bx */
            ii(0x17_a77a, 1);  push(di);                               /* push di */
            ii(0x17_a77b, 1);  push(si);                               /* push si */
            ii(0x17_a77c, 1);  push(cx);                               /* push cx */
            ii(0x17_a77d, 1);  push(ds);                               /* push ds */
            ii(0x17_a77e, 3);  push(0x133f);                           /* push 0x133f */
            ii(0x17_a781, 1);  nop();                                  /* nop */
            ii(0x17_a782, 1);  push(cs);                               /* push cs */
            ii(0x17_a783, 3);  call(0x18_104f, 0x68c9);                /* call 0x104f */
            ii(0x17_a786, 3);  add(sp, 0xc);                           /* add sp, 0xc */
            ii(0x17_a789, 3);  les(bx, memw[ss, bp + 6]);              /* les bx, [bp+0x6] */
            ii(0x17_a78c, 5);  and(memb[es, bx + 44], -2 /* 0xfe */);  /* and byte [es:bx+0x2c], 0xfe */
            ii(0x17_a791, 3);  mov(ax, memw[ss, bp - 18]);             /* mov ax, [bp-0x12] */
            ii(0x17_a794, 3);  mov(dx, memw[ss, bp - 16]);             /* mov dx, [bp-0x10] */
            ii(0x17_a797, 3);  mov(memw[ss, bp - 26], ax);             /* mov [bp-0x1a], ax */
            ii(0x17_a79a, 3);  mov(memw[ss, bp - 24], dx);             /* mov [bp-0x18], dx */
            ii(0x17_a79d, 2);  sub(ax, ax);                            /* sub ax, ax */
            ii(0x17_a79f, 3);  mov(memw[ss, bp - 28], ax);             /* mov [bp-0x1c], ax */
            ii(0x17_a7a2, 3);  mov(memw[ss, bp - 30], ax);             /* mov [bp-0x1e], ax */
            ii(0x17_a7a5, 2);  jmp(0x17_a7b8, 0x11); goto l_0x17_a7b8; /* jmp 0xa7b8 */
        //  ii(0x17_a7a7, 1);  nop();                                  /* nop */
        l_0x17_a7a8:
            ii(0x17_a7a8, 4);  add(memw[ss, bp - 30], 1);              /* add word [bp-0x1e], 0x1 */
            ii(0x17_a7ac, 4);  adc(memw[ss, bp - 28], 0);              /* adc word [bp-0x1c], 0x0 */
            ii(0x17_a7b0, 4);  add(memw[ss, bp - 26], 1);              /* add word [bp-0x1a], 0x1 */
            ii(0x17_a7b4, 4);  adc(memw[ss, bp - 24], 0);              /* adc word [bp-0x18], 0x0 */
        l_0x17_a7b8:
            ii(0x17_a7b8, 3);  mov(ax, memw[ss, bp - 4]);              /* mov ax, [bp-0x4] */
            ii(0x17_a7bb, 3);  mov(dx, memw[ss, bp - 2]);              /* mov dx, [bp-0x2] */
            ii(0x17_a7be, 3);  cmp(memw[ss, bp - 28], dx);             /* cmp [bp-0x1c], dx */
            ii(0x17_a7c1, 2);  if(ja(0x17_a816, 0x53)) goto l_0x17_a816;/* ja 0xa816 */
            ii(0x17_a7c3, 2);  if(jb(0x17_a7ca, 5)) goto l_0x17_a7ca;  /* jb 0xa7ca */
            ii(0x17_a7c5, 3);  cmp(memw[ss, bp - 30], ax);             /* cmp [bp-0x1e], ax */
            ii(0x17_a7c8, 2);  if(jae(0x17_a816, 0x4c)) goto l_0x17_a816;/* jae 0xa816 */
        l_0x17_a7ca:
            ii(0x17_a7ca, 3);  push(memw[ss, bp - 24]);                /* push word [bp-0x18] */
            ii(0x17_a7cd, 3);  push(memw[ss, bp - 26]);                /* push word [bp-0x1a] */
            ii(0x17_a7d0, 4);  push(memw[ds, 0x1fa6]);                 /* push word [0x1fa6] */
            ii(0x17_a7d4, 4);  push(memw[ds, 0x1fa4]);                 /* push word [0x1fa4] */
            ii(0x17_a7d8, 3);  call(0x17_90c4, -0x1717);               /* call 0x90c4 */
            ii(0x17_a7db, 3);  add(sp, 8);                             /* add sp, 0x8 */
            ii(0x17_a7de, 3);  mov(memw[ss, bp - 42], ax);             /* mov [bp-0x2a], ax */
            ii(0x17_a7e1, 2);  or(ax, ax);                             /* or ax, ax */
            ii(0x17_a7e3, 2);  if(jnz(0x17_a7f0, 0xb)) goto l_0x17_a7f0;/* jnz 0xa7f0 */
            ii(0x17_a7e5, 5);  mov(memw[ss, bp - 14], 0x8002);         /* mov word [bp-0xe], 0x8002 */
            ii(0x17_a7ea, 3);  jmp(0x17_a8cc, 0xdf); goto l_0x17_a8cc; /* jmp 0xa8cc */
        //  ii(0x17_a7ed, 2);  jmp(0x17_a813, 0x24); goto l_0x17_a813; /* jmp 0xa813 */
        //  ii(0x17_a7ef, 1);  nop();                                  /* nop */
        l_0x17_a7f0:
            ii(0x17_a7f0, 3);  mov(al, memb[ds, 0x51a6]);              /* mov al, [0x51a6] */
            ii(0x17_a7f3, 2);  sub(ah, ah);                            /* sub ah, ah */
            ii(0x17_a7f5, 3);  cmp(ax, memw[ss, bp - 42]);             /* cmp ax, [bp-0x2a] */
            ii(0x17_a7f8, 2);  if(jz(0x17_a813, 0x19)) goto l_0x17_a813;/* jz 0xa813 */
            ii(0x17_a7fa, 3);  mov(al, memb[ds, 0x51b5]);              /* mov al, [0x51b5] */
            ii(0x17_a7fd, 3);  cmp(ax, memw[ss, bp - 42]);             /* cmp ax, [bp-0x2a] */
            ii(0x17_a800, 2);  if(jz(0x17_a813, 0x11)) goto l_0x17_a813;/* jz 0xa813 */
            ii(0x17_a802, 2);  push(0);                                /* push 0x0 */
            ii(0x17_a804, 2);  push(1);                                /* push 0x1 */
            ii(0x17_a806, 3);  push(memw[ss, bp - 24]);                /* push word [bp-0x18] */
            ii(0x17_a809, 3);  push(memw[ss, bp - 26]);                /* push word [bp-0x1a] */
            ii(0x17_a80c, 1);  push(cs);                               /* push cs */
            ii(0x17_a80d, 3);  call(0x17_c560, 0x1d50);                /* call 0xc560 */
            ii(0x17_a810, 3);  add(sp, 8);                             /* add sp, 0x8 */
        l_0x17_a813:
            ii(0x17_a813, 2);  jmp(0x17_a7a8, -0x6d); goto l_0x17_a7a8;/* jmp 0xa7a8 */
        //  ii(0x17_a815, 1);  nop();                                  /* nop */
        l_0x17_a816:
            ii(0x17_a816, 3);  mov(ax, memw[ss, bp - 18]);             /* mov ax, [bp-0x12] */
            ii(0x17_a819, 3);  mov(dx, memw[ss, bp - 16]);             /* mov dx, [bp-0x10] */
            ii(0x17_a81c, 3);  mov(memw[ss, bp - 26], ax);             /* mov [bp-0x1a], ax */
            ii(0x17_a81f, 3);  mov(memw[ss, bp - 24], dx);             /* mov [bp-0x18], dx */
            ii(0x17_a822, 4);  or(memb[ss, bp - 38], 7);               /* or byte [bp-0x26], 0x7 */
            ii(0x17_a826, 2);  sub(ax, ax);                            /* sub ax, ax */
            ii(0x17_a828, 3);  mov(memw[ss, bp - 28], ax);             /* mov [bp-0x1c], ax */
            ii(0x17_a82b, 3);  mov(memw[ss, bp - 30], ax);             /* mov [bp-0x1e], ax */
            ii(0x17_a82e, 2);  jmp(0x17_a848, 0x18); goto l_0x17_a848; /* jmp 0xa848 */
        l_0x17_a830:
            ii(0x17_a830, 4);  add(memw[ss, bp - 30], 1);              /* add word [bp-0x1e], 0x1 */
            ii(0x17_a834, 4);  adc(memw[ss, bp - 28], 0);              /* adc word [bp-0x1c], 0x0 */
            ii(0x17_a838, 4);  add(memw[ss, bp - 26], 1);              /* add word [bp-0x1a], 0x1 */
            ii(0x17_a83c, 4);  adc(memw[ss, bp - 24], 0);              /* adc word [bp-0x18], 0x0 */
            ii(0x17_a840, 4);  add(memw[ss, bp - 22], 1);              /* add word [bp-0x16], 0x1 */
            ii(0x17_a844, 4);  adc(memw[ss, bp - 20], 0);              /* adc word [bp-0x14], 0x0 */
        l_0x17_a848:
            ii(0x17_a848, 3);  mov(ax, memw[ss, bp - 4]);              /* mov ax, [bp-0x4] */
            ii(0x17_a84b, 3);  mov(dx, memw[ss, bp - 2]);              /* mov dx, [bp-0x2] */
            ii(0x17_a84e, 3);  cmp(memw[ss, bp - 28], dx);             /* cmp [bp-0x1c], dx */
            ii(0x17_a851, 2);  if(ja(0x17_a8c6, 0x73)) goto l_0x17_a8c6;/* ja 0xa8c6 */
            ii(0x17_a853, 2);  if(jb(0x17_a85a, 5)) goto l_0x17_a85a;  /* jb 0xa85a */
            ii(0x17_a855, 3);  cmp(memw[ss, bp - 30], ax);             /* cmp [bp-0x1e], ax */
            ii(0x17_a858, 2);  if(jae(0x17_a8c6, 0x6c)) goto l_0x17_a8c6;/* jae 0xa8c6 */
        l_0x17_a85a:
            ii(0x17_a85a, 3);  mov(al, memb[ds, 0x51a6]);              /* mov al, [0x51a6] */
            ii(0x17_a85d, 2);  sub(ah, ah);                            /* sub ah, ah */
            ii(0x17_a85f, 1);  push(ax);                               /* push ax */
            ii(0x17_a860, 3);  push(memw[ss, bp - 24]);                /* push word [bp-0x18] */
            ii(0x17_a863, 3);  push(memw[ss, bp - 26]);                /* push word [bp-0x1a] */
            ii(0x17_a866, 4);  push(memw[ds, 0x1fa6]);                 /* push word [0x1fa6] */
            ii(0x17_a86a, 4);  push(memw[ds, 0x1fa4]);                 /* push word [0x1fa4] */
            ii(0x17_a86e, 3);  call(0x17_91e3, -0x168e);               /* call 0x91e3 */
            ii(0x17_a871, 3);  add(sp, 0xa);                           /* add sp, 0xa */
            ii(0x17_a874, 3);  mov(ax, memw[ss, bp - 22]);             /* mov ax, [bp-0x16] */
            ii(0x17_a877, 3);  mov(dx, memw[ss, bp - 20]);             /* mov dx, [bp-0x14] */
            ii(0x17_a87a, 2);  mov(dh, dl);                            /* mov dh, dl */
            ii(0x17_a87c, 2);  mov(dl, ah);                            /* mov dl, ah */
            ii(0x17_a87e, 2);  mov(ah, al);                            /* mov ah, al */
            ii(0x17_a880, 2);  sub(al, al);                            /* sub al, al */
            ii(0x17_a882, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x17_a884, 2);  rcl(dx, 1);                             /* rcl dx, 1 */
            ii(0x17_a886, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x17_a888, 2);  rcl(dx, 1);                             /* rcl dx, 1 */
            ii(0x17_a88a, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x17_a88c, 2);  rcl(dx, 1);                             /* rcl dx, 1 */
            ii(0x17_a88e, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x17_a890, 2);  rcl(dx, 1);                             /* rcl dx, 1 */
            ii(0x17_a892, 2);  mov(cx, ax);                            /* mov cx, ax */
            ii(0x17_a894, 2);  mov(bx, dx);                            /* mov bx, dx */
            ii(0x17_a896, 3);  xor(ax, memw[ss, bp - 38]);             /* xor ax, [bp-0x26] */
            ii(0x17_a899, 3);  and(ah, 0xf);                           /* and ah, 0xf */
            ii(0x17_a89c, 2);  sub(dx, dx);                            /* sub dx, dx */
            ii(0x17_a89e, 2);  xor(cx, ax);                            /* xor cx, ax */
            ii(0x17_a8a0, 2);  xor(bx, dx);                            /* xor bx, dx */
            ii(0x17_a8a2, 3);  mov(memw[ss, bp - 38], cx);             /* mov [bp-0x26], cx */
            ii(0x17_a8a5, 3);  mov(memw[ss, bp - 36], bx);             /* mov [bp-0x24], bx */
            ii(0x17_a8a8, 2);  mov(dx, di);                            /* mov dx, di */
            ii(0x17_a8aa, 4);  mov(es, memw[ds, 0xaa]);                /* mov es, [0xaa] */
            ii(0x17_a8ae, 5);  mov(edi, memd[ds, 0x4f8c]);             /* mov edi, [0x4f8c] */
            ii(0x17_a8b3, 4);  mov(ebx, memd[ss, bp - 26]);            /* mov ebx, [bp-0x1a] */
            ii(0x17_a8b7, 4);  mov(eax, memd[ss, bp - 38]);            /* mov eax, [bp-0x26] */
            ii(0x17_a8bb, 6);  mov(memd_a32[es, edi + ebx * 4], eax);  /* mov [es:edi+ebx*4], eax */
            ii(0x17_a8c1, 2);  mov(di, dx);                            /* mov di, dx */
            ii(0x17_a8c3, 3);  jmp(0x17_a830, -0x96); goto l_0x17_a830;/* jmp 0xa830 */
        l_0x17_a8c6:
            ii(0x17_a8c6, 3);  mov(eax, cr3);                          /* mov eax, cr3 */
            ii(0x17_a8c9, 3);  mov(cr3, eax);                          /* mov cr3, eax */
        l_0x17_a8cc:
            ii(0x17_a8cc, 4);  cmp(memw[ss, bp - 14], 0);              /* cmp word [bp-0xe], 0x0 */
            ii(0x17_a8d0, 2);  if(jz(0x17_a8e6, 0x14)) goto l_0x17_a8e6;/* jz 0xa8e6 */
            ii(0x17_a8d2, 3);  mov(ax, memw[ss, bp - 14]);             /* mov ax, [bp-0xe] */
            ii(0x17_a8d5, 1);  cwd();                                  /* cwd */
            ii(0x17_a8d6, 3);  les(bx, memw[ss, bp + 6]);              /* les bx, [bp+0x6] */
            ii(0x17_a8d9, 4);  mov(memw[es, bx + 32], ax);             /* mov [es:bx+0x20], ax */
            ii(0x17_a8dd, 4);  mov(memw[es, bx + 34], dx);             /* mov [es:bx+0x22], dx */
            ii(0x17_a8e1, 5);  or(memb[es, bx + 44], 1);               /* or byte [es:bx+0x2c], 0x1 */
        l_0x17_a8e6:
            ii(0x17_a8e6, 1);  pop(ds);                                /* pop ds */
            ii(0x17_a8e7, 1);  pop(si);                                /* pop si */
            ii(0x17_a8e8, 1);  pop(di);                                /* pop di */
            ii(0x17_a8e9, 1);  leave();                                /* leave */
            ii(0x17_a8ea, 1);  retf();                                 /* retf */
        }
    }
}
