using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_5aaa-b9c7f688")]
        public void Method_0017_5aaa()
        {
            ii(0x17_5aaa, 4);  enter(0x36, 0);                         /* enter 0x36, 0x0 */
            ii(0x17_5aae, 1);  push(di);                               /* push di */
            ii(0x17_5aaf, 1);  push(si);                               /* push si */
            ii(0x17_5ab0, 1);  push(ds);                               /* push ds */
            ii(0x17_5ab1, 3);  mov(ax, 0x3e68);                        /* mov ax, 0x3e68 */
            ii(0x17_5ab4, 2);  mov(ds, ax);                            /* mov ds, ax */
            ii(0x17_5ab6, 2);  push(3);                                /* push 0x3 */
            ii(0x17_5ab8, 1);  nop();                                  /* nop */
            ii(0x17_5ab9, 1);  push(cs);                               /* push cs */
            ii(0x17_5aba, 3);  call(0x16_e77a, -0x7343);               /* call 0xe77a */
            ii(0x17_5abd, 3);  add(sp, 2);                             /* add sp, 0x2 */
            ii(0x17_5ac0, 3);  mov(memw[ss, bp - 28], ax);             /* mov [bp-0x1c], ax */
            ii(0x17_5ac3, 3);  push(0x1000);                           /* push 0x1000 */
            ii(0x17_5ac6, 1);  nop();                                  /* nop */
            ii(0x17_5ac7, 1);  push(cs);                               /* push cs */
            ii(0x17_5ac8, 3);  call(0x16_e7a8, -0x7323);               /* call 0xe7a8 */
            ii(0x17_5acb, 3);  add(sp, 2);                             /* add sp, 0x2 */
            ii(0x17_5ace, 3);  mov(memw[ds, 0x4f80], ax);              /* mov [0x4f80], ax */
            ii(0x17_5ad1, 4);  mov(memw[ds, 0x4f82], dx);              /* mov [0x4f82], dx */
            ii(0x17_5ad5, 2);  mov(ax, dx);                            /* mov ax, dx */
            ii(0x17_5ad7, 4);  or(ax, memw[ds, 0x4f80]);               /* or ax, [0x4f80] */
            ii(0x17_5adb, 2);  if(jnz(0x17_5afc, 0x1f)) goto l_0x17_5afc;/* jnz 0x5afc */
            ii(0x17_5add, 1);  push(ds);                               /* push ds */
            ii(0x17_5ade, 3);  push(0x358);                            /* push 0x358 */
            ii(0x17_5ae1, 3);  push(0x90a);                            /* push 0x90a */
            ii(0x17_5ae4, 1);  push(cs);                               /* push cs */
            ii(0x17_5ae5, 3);  call(0x17_75b4, 0x1acc);                /* call 0x75b4 */
            ii(0x17_5ae8, 3);  add(sp, 6);                             /* add sp, 0x6 */
            ii(0x17_5aeb, 3);  push(memw[ss, bp - 28]);                /* push word [bp-0x1c] */
            ii(0x17_5aee, 1);  nop();                                  /* nop */
            ii(0x17_5aef, 1);  push(cs);                               /* push cs */
            ii(0x17_5af0, 3);  call(0x16_e77a, -0x7379);               /* call 0xe77a */
            ii(0x17_5af3, 3);  add(sp, 2);                             /* add sp, 0x2 */
            ii(0x17_5af6, 3);  mov(ax, 1);                             /* mov ax, 0x1 */
            ii(0x17_5af9, 3);  jmp(0x17_6154, 0x658); goto l_0x17_6154;/* jmp 0x6154 */
        l_0x17_5afc:
            ii(0x17_5afc, 5);  cmp(memw[ds, 0x984], 0);                /* cmp word [0x984], 0x0 */
            ii(0x17_5b01, 2);  if(jz(0x17_5b22, 0x1f)) goto l_0x17_5b22;/* jz 0x5b22 */
            ii(0x17_5b03, 2);  push(0x14);                             /* push 0x14 */
            ii(0x17_5b05, 1);  nop();                                  /* nop */
            ii(0x17_5b06, 1);  push(cs);                               /* push cs */
            ii(0x17_5b07, 3);  call(0x16_e7a8, -0x7362);               /* call 0xe7a8 */
            ii(0x17_5b0a, 3);  add(sp, 2);                             /* add sp, 0x2 */
            ii(0x17_5b0d, 3);  mov(memw[ds, 0x4fc4], ax);              /* mov [0x4fc4], ax */
            ii(0x17_5b10, 4);  mov(memw[ds, 0x4fc6], dx);              /* mov [0x4fc6], dx */
            ii(0x17_5b14, 2);  mov(ax, dx);                            /* mov ax, dx */
            ii(0x17_5b16, 4);  or(ax, memw[ds, 0x4fc4]);               /* or ax, [0x4fc4] */
            ii(0x17_5b1a, 2);  if(jnz(0x17_5b22, 6)) goto l_0x17_5b22; /* jnz 0x5b22 */
            ii(0x17_5b1c, 6);  mov(memw[ds, 0x984], 0);                /* mov word [0x984], 0x0 */
        l_0x17_5b22:
            ii(0x17_5b22, 3);  push(memw[ss, bp - 28]);                /* push word [bp-0x1c] */
            ii(0x17_5b25, 1);  nop();                                  /* nop */
            ii(0x17_5b26, 1);  push(cs);                               /* push cs */
            ii(0x17_5b27, 3);  call(0x16_e77a, -0x73b0);               /* call 0xe77a */
            ii(0x17_5b2a, 3);  add(sp, 2);                             /* add sp, 0x2 */
            ii(0x17_5b2d, 3);  mov(ax, memw[ds, 0x201c]);              /* mov ax, [0x201c] */
            ii(0x17_5b30, 4);  mov(dx, memw[ds, 0x201e]);              /* mov dx, [0x201e] */
            ii(0x17_5b34, 3);  mov(memw[ds, 0x4fd0], ax);              /* mov [0x4fd0], ax */
            ii(0x17_5b37, 4);  mov(memw[ds, 0x4fd2], dx);              /* mov [0x4fd2], dx */
            ii(0x17_5b3b, 3);  mov(al, memb[ds, 0x519d]);              /* mov al, [0x519d] */
            ii(0x17_5b3e, 3);  shr(al, 2);                             /* shr al, 0x2 */
            ii(0x17_5b41, 2);  sub(ah, ah);                            /* sub ah, ah */
            ii(0x17_5b43, 3);  mov(memw[ss, bp - 6], ax);              /* mov [bp-0x6], ax */
            ii(0x17_5b46, 2);  or(ax, ax);                             /* or ax, ax */
            ii(0x17_5b48, 2);  if(jnz(0x17_5b50, 6)) goto l_0x17_5b50; /* jnz 0x5b50 */
            ii(0x17_5b4a, 1);  inc(ax);                                /* inc ax */
            ii(0x17_5b4b, 3);  mov(memw[ss, bp - 6], ax);              /* mov [bp-0x6], ax */
            ii(0x17_5b4e, 2);  jmp(0x17_5b5b, 0xb); goto l_0x17_5b5b;  /* jmp 0x5b5b */
        l_0x17_5b50:
            ii(0x17_5b50, 6);  test(memw[ds, 0x519c], 0x3ff);          /* test word [0x519c], 0x3ff */
            ii(0x17_5b56, 2);  if(jz(0x17_5b5b, 3)) goto l_0x17_5b5b;  /* jz 0x5b5b */
            ii(0x17_5b58, 3);  inc(memw[ss, bp - 6]);                  /* inc word [bp-0x6] */
        l_0x17_5b5b:
            ii(0x17_5b5b, 3);  push(memw[ss, bp - 6]);                 /* push word [bp-0x6] */
            ii(0x17_5b5e, 1);  push(cs);                               /* push cs */
            ii(0x17_5b5f, 3);  call(0x17_7476, 0x1914);                /* call 0x7476 */
            ii(0x17_5b62, 3);  add(sp, 2);                             /* add sp, 0x2 */
            ii(0x17_5b65, 3);  mov(memw[ds, 0x4fe4], ax);              /* mov [0x4fe4], ax */
            ii(0x17_5b68, 4);  mov(memw[ds, 0x4fe6], dx);              /* mov [0x4fe6], dx */
            ii(0x17_5b6c, 2);  mov(ax, dx);                            /* mov ax, dx */
            ii(0x17_5b6e, 4);  or(ax, memw[ds, 0x4fe4]);               /* or ax, [0x4fe4] */
            ii(0x17_5b72, 2);  if(jnz(0x17_5b88, 0x14)) goto l_0x17_5b88;/* jnz 0x5b88 */
            ii(0x17_5b74, 1);  push(ds);                               /* push ds */
            ii(0x17_5b75, 3);  push(0x364);                            /* push 0x364 */
            ii(0x17_5b78, 3);  push(0x90a);                            /* push 0x90a */
            ii(0x17_5b7b, 1);  push(cs);                               /* push cs */
            ii(0x17_5b7c, 3);  call(0x17_75b4, 0x1a35);                /* call 0x75b4 */
            ii(0x17_5b7f, 3);  add(sp, 6);                             /* add sp, 0x6 */
            ii(0x17_5b82, 3);  mov(ax, 1);                             /* mov ax, 0x1 */
            ii(0x17_5b85, 3);  jmp(0x17_6154, 0x5cc); goto l_0x17_6154;/* jmp 0x6154 */
        l_0x17_5b88:
            ii(0x17_5b88, 5);  cmp(memw[ds, 0x51a0], 0);               /* cmp word [0x51a0], 0x0 */
            ii(0x17_5b8d, 2);  if(jnz(0x17_5bae, 0x1f)) goto l_0x17_5bae;/* jnz 0x5bae */
            ii(0x17_5b8f, 1);  push(cs);                               /* push cs */
            ii(0x17_5b90, 3);  call(0x17_6b2c, 0xf99);                 /* call 0x6b2c */
            ii(0x17_5b93, 3);  mov(memw[ds, 0x992], ax);               /* mov [0x992], ax */
            ii(0x17_5b96, 4);  mov(memw[ds, 0x994], dx);               /* mov [0x994], dx */
            ii(0x17_5b9a, 1);  push(cs);                               /* push cs */
            ii(0x17_5b9b, 3);  call(0x17_564a, -0x554);                /* call 0x564a */
            ii(0x17_5b9e, 3);  mov(ax, memw[ds, 0x4fe4]);              /* mov ax, [0x4fe4] */
            ii(0x17_5ba1, 4);  mov(dx, memw[ds, 0x4fe6]);              /* mov dx, [0x4fe6] */
            ii(0x17_5ba5, 3);  mov(memw[ds, 0x4fe8], ax);              /* mov [0x4fe8], ax */
            ii(0x17_5ba8, 4);  mov(memw[ds, 0x4fea], dx);              /* mov [0x4fea], dx */
            ii(0x17_5bac, 2);  jmp(0x17_5c20, 0x72); goto l_0x17_5c20; /* jmp 0x5c20 */
        l_0x17_5bae:
            ii(0x17_5bae, 3);  push(0x2000);                           /* push 0x2000 */
            ii(0x17_5bb1, 4);  les(bx, memw[ds, 0x2018]);              /* les bx, [0x2018] */
            ii(0x17_5bb5, 4);  mov(ax, memw[es, bx + 18]);             /* mov ax, [es:bx+0x12] */
            ii(0x17_5bb9, 2);  sub(dx, dx);                            /* sub dx, dx */
            ii(0x17_5bbb, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x17_5bbd, 2);  rcl(dx, 1);                             /* rcl dx, 1 */
            ii(0x17_5bbf, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x17_5bc1, 2);  rcl(dx, 1);                             /* rcl dx, 1 */
            ii(0x17_5bc3, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x17_5bc5, 2);  rcl(dx, 1);                             /* rcl dx, 1 */
            ii(0x17_5bc7, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x17_5bc9, 2);  rcl(dx, 1);                             /* rcl dx, 1 */
            ii(0x17_5bcb, 1);  push(dx);                               /* push dx */
            ii(0x17_5bcc, 1);  push(ax);                               /* push ax */
            ii(0x17_5bcd, 1);  nop();                                  /* nop */
            ii(0x17_5bce, 1);  push(cs);                               /* push cs */
            ii(0x17_5bcf, 3);  call(0x16_e96a, -0x7268);               /* call 0xe96a */
            ii(0x17_5bd2, 3);  add(sp, 6);                             /* add sp, 0x6 */
            ii(0x17_5bd5, 3);  mov(memw[ds, 0x992], ax);               /* mov [0x992], ax */
            ii(0x17_5bd8, 4);  mov(memw[ds, 0x994], dx);               /* mov [0x994], dx */
            ii(0x17_5bdc, 4);  push(memw[ds, 0x4fe6]);                 /* push word [0x4fe6] */
            ii(0x17_5be0, 4);  push(memw[ds, 0x4fe4]);                 /* push word [0x4fe4] */
            ii(0x17_5be4, 1);  push(cs);                               /* push cs */
            ii(0x17_5be5, 3);  call(0x17_567a, -0x56e);                /* call 0x567a */
            ii(0x17_5be8, 3);  add(sp, 4);                             /* add sp, 0x4 */
            ii(0x17_5beb, 3);  mov(memw[ds, 0x4fe8], ax);              /* mov [0x4fe8], ax */
            ii(0x17_5bee, 4);  mov(memw[ds, 0x4fea], dx);              /* mov [0x4fea], dx */
            ii(0x17_5bf2, 5);  mov(memw[ss, bp - 20], 0);              /* mov word [bp-0x14], 0x0 */
            ii(0x17_5bf7, 2);  jmp(0x17_5bfd, 4); goto l_0x17_5bfd;    /* jmp 0x5bfd */
        //  ii(0x17_5bf9, 1);  nop();                                  /* nop */
        l_0x17_5bfa:
            ii(0x17_5bfa, 3);  inc(memw[ss, bp - 20]);                 /* inc word [bp-0x14] */
        l_0x17_5bfd:
            ii(0x17_5bfd, 5);  cmp(memw[ss, bp - 20], 0x400);          /* cmp word [bp-0x14], 0x400 */
            ii(0x17_5c02, 2);  if(jae(0x17_5c20, 0x1c)) goto l_0x17_5c20;/* jae 0x5c20 */
            ii(0x17_5c04, 3);  mov(bx, memw[ss, bp - 20]);             /* mov bx, [bp-0x14] */
            ii(0x17_5c07, 3);  shl(bx, 2);                             /* shl bx, 0x2 */
            ii(0x17_5c0a, 4);  les(si, memw[ds, 0x992]);               /* les si, [0x992] */
            ii(0x17_5c0e, 3);  mov(ax, memw[es, bx + si]);             /* mov ax, [es:bx+si] */
            ii(0x17_5c11, 4);  mov(dx, memw[es, bx + si + 2]);         /* mov dx, [es:bx+si+0x2] */
            ii(0x17_5c15, 4);  mov(memw[ds, bx + 0x3f60], ax);         /* mov [bx+0x3f60], ax */
            ii(0x17_5c19, 4);  mov(memw[ds, bx + 0x3f62], dx);         /* mov [bx+0x3f62], dx */
            ii(0x17_5c1d, 2);  jmp(0x17_5bfa, -0x25); goto l_0x17_5bfa;/* jmp 0x5bfa */
        //  ii(0x17_5c1f, 1);  nop();                                  /* nop */
        l_0x17_5c20:
            ii(0x17_5c20, 3);  mov(ax, memw[ds, 0x4fe8]);              /* mov ax, [0x4fe8] */
            ii(0x17_5c23, 4);  mov(dx, memw[ds, 0x4fea]);              /* mov dx, [0x4fea] */
            ii(0x17_5c27, 2);  mov(al, ah);                            /* mov al, ah */
            ii(0x17_5c29, 2);  mov(ah, dl);                            /* mov ah, dl */
            ii(0x17_5c2b, 2);  mov(dl, dh);                            /* mov dl, dh */
            ii(0x17_5c2d, 2);  sub(dh, dh);                            /* sub dh, dh */
            ii(0x17_5c2f, 2);  shr(dx, 1);                             /* shr dx, 1 */
            ii(0x17_5c31, 2);  rcr(ax, 1);                             /* rcr ax, 1 */
            ii(0x17_5c33, 2);  shr(dx, 1);                             /* shr dx, 1 */
            ii(0x17_5c35, 2);  rcr(ax, 1);                             /* rcr ax, 1 */
            ii(0x17_5c37, 2);  shr(dx, 1);                             /* shr dx, 1 */
            ii(0x17_5c39, 2);  rcr(ax, 1);                             /* rcr ax, 1 */
            ii(0x17_5c3b, 2);  shr(dx, 1);                             /* shr dx, 1 */
            ii(0x17_5c3d, 2);  rcr(ax, 1);                             /* rcr ax, 1 */
            ii(0x17_5c3f, 3);  mov(memw[ss, bp - 10], ax);             /* mov [bp-0xa], ax */
            ii(0x17_5c42, 3);  mov(memw[ss, bp - 8], dx);              /* mov [bp-0x8], dx */
            ii(0x17_5c45, 5);  mov(memw[ss, bp - 54], 0x3fc);          /* mov word [bp-0x36], 0x3fc */
            ii(0x17_5c4a, 5);  mov(memw[ss, bp - 52], 0);              /* mov word [bp-0x34], 0x0 */
            ii(0x17_5c4f, 5);  mov(memw[ss, bp - 20], 0);              /* mov word [bp-0x14], 0x0 */
            ii(0x17_5c54, 2);  jmp(0x17_5c69, 0x13); goto l_0x17_5c69; /* jmp 0x5c69 */
        l_0x17_5c56:
            ii(0x17_5c56, 3);  inc(memw[ss, bp - 20]);                 /* inc word [bp-0x14] */
            ii(0x17_5c59, 4);  add(memw[ss, bp - 10], 1);              /* add word [bp-0xa], 0x1 */
            ii(0x17_5c5d, 4);  adc(memw[ss, bp - 8], 0);               /* adc word [bp-0x8], 0x0 */
            ii(0x17_5c61, 4);  add(memw[ss, bp - 54], 1);              /* add word [bp-0x36], 0x1 */
            ii(0x17_5c65, 4);  adc(memw[ss, bp - 52], 0);              /* adc word [bp-0x34], 0x0 */
        l_0x17_5c69:
            ii(0x17_5c69, 3);  mov(ax, memw[ss, bp - 6]);              /* mov ax, [bp-0x6] */
            ii(0x17_5c6c, 3);  cmp(memw[ss, bp - 20], ax);             /* cmp [bp-0x14], ax */
            ii(0x17_5c6f, 2);  if(jae(0x17_5cca, 0x59)) goto l_0x17_5cca;/* jae 0x5cca */
            ii(0x17_5c71, 3);  mov(ax, memw[ss, bp - 10]);             /* mov ax, [bp-0xa] */
            ii(0x17_5c74, 3);  mov(dx, memw[ss, bp - 8]);              /* mov dx, [bp-0x8] */
            ii(0x17_5c77, 2);  mov(dh, dl);                            /* mov dh, dl */
            ii(0x17_5c79, 2);  mov(dl, ah);                            /* mov dl, ah */
            ii(0x17_5c7b, 2);  mov(ah, al);                            /* mov ah, al */
            ii(0x17_5c7d, 2);  sub(al, al);                            /* sub al, al */
            ii(0x17_5c7f, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x17_5c81, 2);  rcl(dx, 1);                             /* rcl dx, 1 */
            ii(0x17_5c83, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x17_5c85, 2);  rcl(dx, 1);                             /* rcl dx, 1 */
            ii(0x17_5c87, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x17_5c89, 2);  rcl(dx, 1);                             /* rcl dx, 1 */
            ii(0x17_5c8b, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x17_5c8d, 2);  rcl(dx, 1);                             /* rcl dx, 1 */
            ii(0x17_5c8f, 2);  mov(cx, ax);                            /* mov cx, ax */
            ii(0x17_5c91, 3);  mov(bx, memw[ss, bp - 54]);             /* mov bx, [bp-0x36] */
            ii(0x17_5c94, 3);  shl(bx, 2);                             /* shl bx, 0x2 */
            ii(0x17_5c97, 4);  les(si, memw[ds, 0x992]);               /* les si, [0x992] */
            ii(0x17_5c9b, 3);  xor(ax, memw[es, bx + si]);             /* xor ax, [es:bx+si] */
            ii(0x17_5c9e, 3);  and(ah, 0xf);                           /* and ah, 0xf */
            ii(0x17_5ca1, 2);  mov(di, dx);                            /* mov di, dx */
            ii(0x17_5ca3, 2);  sub(dx, dx);                            /* sub dx, dx */
            ii(0x17_5ca5, 2);  xor(cx, ax);                            /* xor cx, ax */
            ii(0x17_5ca7, 2);  xor(di, dx);                            /* xor di, dx */
            ii(0x17_5ca9, 3);  mov(memw[es, bx + si], cx);             /* mov [es:bx+si], cx */
            ii(0x17_5cac, 4);  mov(memw[es, bx + si + 2], di);         /* mov [es:bx+si+0x2], di */
            ii(0x17_5cb0, 4);  les(si, memw[ds, 0x992]);               /* les si, [0x992] */
            ii(0x17_5cb4, 4);  or(memb[es, bx + si], 1);               /* or byte [es:bx+si], 0x1 */
            ii(0x17_5cb8, 4);  les(si, memw[ds, 0x992]);               /* les si, [0x992] */
            ii(0x17_5cbc, 4);  or(memb[es, bx + si], 2);               /* or byte [es:bx+si], 0x2 */
            ii(0x17_5cc0, 4);  les(si, memw[ds, 0x992]);               /* les si, [0x992] */
            ii(0x17_5cc4, 4);  or(memb[es, bx + si], 4);               /* or byte [es:bx+si], 0x4 */
            ii(0x17_5cc8, 2);  jmp(0x17_5c56, -0x74); goto l_0x17_5c56;/* jmp 0x5c56 */
        l_0x17_5cca:
            ii(0x17_5cca, 1);  nop();                                  /* nop */
            ii(0x17_5ccb, 1);  push(cs);                               /* push cs */
            ii(0x17_5ccc, 3);  call(0x17_8e97, 0x31c8);                /* call 0x8e97 */
            ii(0x17_5ccf, 3);  mov(ah, memb[ss, bp - 6]);              /* mov ah, [bp-0x6] */
            ii(0x17_5cd2, 3);  shl(ah, 4);                             /* shl ah, 0x4 */
            ii(0x17_5cd5, 2);  sub(al, al);                            /* sub al, al */
            ii(0x17_5cd7, 1);  push(ax);                               /* push ax */
            ii(0x17_5cd8, 4);  push(memw[ds, 0x4fe6]);                 /* push word [0x4fe6] */
            ii(0x17_5cdc, 4);  push(memw[ds, 0x4fe4]);                 /* push word [0x4fe4] */
            ii(0x17_5ce0, 2);  mov(si, ax);                            /* mov si, ax */
            ii(0x17_5ce2, 1);  nop();                                  /* nop */
            ii(0x17_5ce3, 1);  push(cs);                               /* push cs */
            ii(0x17_5ce4, 3);  call(0x16_e96a, -0x737d);               /* call 0xe96a */
            ii(0x17_5ce7, 3);  add(sp, 6);                             /* add sp, 0x6 */
            ii(0x17_5cea, 3);  mov(memw[ds, 0x4fec], ax);              /* mov [0x4fec], ax */
            ii(0x17_5ced, 4);  mov(memw[ds, 0x4fee], dx);              /* mov [0x4fee], dx */
            ii(0x17_5cf1, 1);  push(si);                               /* push si */
            ii(0x17_5cf2, 1);  push(dx);                               /* push dx */
            ii(0x17_5cf3, 1);  push(ax);                               /* push ax */
            ii(0x17_5cf4, 1);  nop();                                  /* nop */
            ii(0x17_5cf5, 1);  push(cs);                               /* push cs */
            ii(0x17_5cf6, 3);  call(0x17_8ed0, 0x31d7);                /* call 0x8ed0 */
            ii(0x17_5cf9, 3);  add(sp, 6);                             /* add sp, 0x6 */
            ii(0x17_5cfc, 3);  mov(ax, memw[ds, 0x519c]);              /* mov ax, [0x519c] */
            ii(0x17_5cff, 3);  mov(memw[ss, bp - 6], ax);              /* mov [bp-0x6], ax */
            ii(0x17_5d02, 5);  mov(memw[ss, bp - 42], 0);              /* mov word [bp-0x2a], 0x0 */
            ii(0x17_5d07, 5);  mov(memw[ss, bp - 40], 0xff00);         /* mov word [bp-0x28], 0xff00 */
            ii(0x17_5d0c, 1);  nop();                                  /* nop */
            ii(0x17_5d0d, 1);  push(cs);                               /* push cs */
            ii(0x17_5d0e, 3);  call(0x16_e82c, -0x74e5);               /* call 0xe82c */
            ii(0x17_5d11, 2);  mov(al, ah);                            /* mov al, ah */
            ii(0x17_5d13, 2);  mov(ah, dl);                            /* mov ah, dl */
            ii(0x17_5d15, 2);  mov(dl, dh);                            /* mov dl, dh */
            ii(0x17_5d17, 2);  shl(dh, 1);                             /* shl dh, 1 */
            ii(0x17_5d19, 2);  sbb(dh, dh);                            /* sbb dh, dh */
            ii(0x17_5d1b, 2);  sar(dx, 1);                             /* sar dx, 1 */
            ii(0x17_5d1d, 2);  rcr(ax, 1);                             /* rcr ax, 1 */
            ii(0x17_5d1f, 2);  sar(dx, 1);                             /* sar dx, 1 */
            ii(0x17_5d21, 2);  rcr(ax, 1);                             /* rcr ax, 1 */
            ii(0x17_5d23, 3);  mov(memw[ss, bp - 36], ax);             /* mov [bp-0x24], ax */
            ii(0x17_5d26, 3);  mov(memw[ss, bp - 34], dx);             /* mov [bp-0x22], dx */
            ii(0x17_5d29, 2);  mov(al, ah);                            /* mov al, ah */
            ii(0x17_5d2b, 2);  mov(ah, dl);                            /* mov ah, dl */
            ii(0x17_5d2d, 2);  mov(dl, dh);                            /* mov dl, dh */
            ii(0x17_5d2f, 2);  sub(dh, dh);                            /* sub dh, dh */
            ii(0x17_5d31, 3);  sub(memw[ss, bp - 36], ax);             /* sub [bp-0x24], ax */
            ii(0x17_5d34, 3);  sbb(memw[ss, bp - 34], dx);             /* sbb [bp-0x22], dx */
            ii(0x17_5d37, 3);  mov(ax, memw[ds, 0x30]);                /* mov ax, [0x30] */
            ii(0x17_5d3a, 4);  mov(dx, memw[ds, 0x32]);                /* mov dx, [0x32] */
            ii(0x17_5d3e, 4);  mov(cx, memw[ds, 0x28]);                /* mov cx, [0x28] */
            ii(0x17_5d42, 4);  mov(bx, memw[ds, 0x2a]);                /* mov bx, [0x2a] */
            ii(0x17_5d46, 3);  sub(memw[ss, bp - 36], cx);             /* sub [bp-0x24], cx */
            ii(0x17_5d49, 3);  sbb(memw[ss, bp - 34], bx);             /* sbb [bp-0x22], bx */
            ii(0x17_5d4c, 3);  cmp(memw[ss, bp - 34], dx);             /* cmp [bp-0x22], dx */
            ii(0x17_5d4f, 2);  if(jb(0x17_5d5e, 0xd)) goto l_0x17_5d5e;/* jb 0x5d5e */
            ii(0x17_5d51, 2);  if(ja(0x17_5d58, 5)) goto l_0x17_5d58;  /* ja 0x5d58 */
            ii(0x17_5d53, 3);  cmp(memw[ss, bp - 36], ax);             /* cmp [bp-0x24], ax */
            ii(0x17_5d56, 2);  if(jbe(0x17_5d5e, 6)) goto l_0x17_5d5e; /* jbe 0x5d5e */
        l_0x17_5d58:
            ii(0x17_5d58, 3);  mov(memw[ss, bp - 36], ax);             /* mov [bp-0x24], ax */
            ii(0x17_5d5b, 3);  mov(memw[ss, bp - 34], dx);             /* mov [bp-0x22], dx */
        l_0x17_5d5e:
            ii(0x17_5d5e, 3);  mov(ax, memw[ss, bp - 36]);             /* mov ax, [bp-0x24] */
            ii(0x17_5d61, 3);  mov(dx, memw[ss, bp - 34]);             /* mov dx, [bp-0x22] */
            ii(0x17_5d64, 4);  cmp(memw[ds, 0x36], dx);                /* cmp [0x36], dx */
            ii(0x17_5d68, 2);  if(jb(0x17_5d84, 0x1a)) goto l_0x17_5d84;/* jb 0x5d84 */
            ii(0x17_5d6a, 2);  if(ja(0x17_5d72, 6)) goto l_0x17_5d72;  /* ja 0x5d72 */
            ii(0x17_5d6c, 4);  cmp(memw[ds, 0x34], ax);                /* cmp [0x34], ax */
            ii(0x17_5d70, 2);  if(jbe(0x17_5d84, 0x12)) goto l_0x17_5d84;/* jbe 0x5d84 */
        l_0x17_5d72:
            ii(0x17_5d72, 3);  push(0x90e);                            /* push 0x90e */
            ii(0x17_5d75, 1);  push(cs);                               /* push cs */
            ii(0x17_5d76, 3);  call(0x17_75b4, 0x183b);                /* call 0x75b4 */
            ii(0x17_5d79, 3);  add(sp, 2);                             /* add sp, 0x2 */
            ii(0x17_5d7c, 3);  mov(ax, 1);                             /* mov ax, 0x1 */
            ii(0x17_5d7f, 1);  pop(ds);                                /* pop ds */
            ii(0x17_5d80, 1);  pop(si);                                /* pop si */
            ii(0x17_5d81, 1);  pop(di);                                /* pop di */
            ii(0x17_5d82, 1);  leave();                                /* leave */
            ii(0x17_5d83, 1);  retf(); return;                         /* retf */
        l_0x17_5d84:
            ii(0x17_5d84, 2);  and(al, 0xfc);                          /* and al, 0xfc */
            ii(0x17_5d86, 3);  and(dx, 0x3f);                          /* and dx, 0x3f */
            ii(0x17_5d89, 2);  shr(dx, 1);                             /* shr dx, 1 */
            ii(0x17_5d8b, 2);  rcr(ax, 1);                             /* rcr ax, 1 */
            ii(0x17_5d8d, 2);  shr(dx, 1);                             /* shr dx, 1 */
            ii(0x17_5d8f, 2);  rcr(ax, 1);                             /* rcr ax, 1 */
            ii(0x17_5d91, 1);  push(dx);                               /* push dx */
            ii(0x17_5d92, 1);  push(ax);                               /* push ax */
            ii(0x17_5d93, 1);  push(cs);                               /* push cs */
            ii(0x17_5d94, 3);  call(0x17_6260, 0x4c9);                 /* call 0x6260 */
            ii(0x17_5d97, 3);  add(sp, 4);                             /* add sp, 0x4 */
            ii(0x17_5d9a, 2);  or(ax, ax);                             /* or ax, ax */
            ii(0x17_5d9c, 2);  if(jz(0x17_5da6, 8)) goto l_0x17_5da6;  /* jz 0x5da6 */
            ii(0x17_5d9e, 3);  mov(ax, 1);                             /* mov ax, 0x1 */
            ii(0x17_5da1, 1);  pop(ds);                                /* pop ds */
            ii(0x17_5da2, 1);  pop(si);                                /* pop si */
            ii(0x17_5da3, 1);  pop(di);                                /* pop di */
            ii(0x17_5da4, 1);  leave();                                /* leave */
            ii(0x17_5da5, 1);  retf(); return;                         /* retf */
        l_0x17_5da6:
            ii(0x17_5da6, 5);  mov(memw[ss, bp - 26], 1);              /* mov word [bp-0x1a], 0x1 */
            ii(0x17_5dab, 2);  jmp(0x17_5db1, 4); goto l_0x17_5db1;    /* jmp 0x5db1 */
        //  ii(0x17_5dad, 1);  nop();                                  /* nop */
        l_0x17_5dae:
            ii(0x17_5dae, 3);  inc(memw[ss, bp - 26]);                 /* inc word [bp-0x1a] */
        l_0x17_5db1:
            ii(0x17_5db1, 3);  mov(ax, memw[ss, bp - 6]);              /* mov ax, [bp-0x6] */
            ii(0x17_5db4, 3);  cmp(memw[ss, bp - 26], ax);             /* cmp [bp-0x1a], ax */
            ii(0x17_5db7, 2);  if(ja(0x17_5e28, 0x6f)) goto l_0x17_5e28;/* ja 0x5e28 */
            ii(0x17_5db9, 1);  push(cs);                               /* push cs */
            ii(0x17_5dba, 3);  call(0x17_615a, 0x39d);                 /* call 0x615a */
            ii(0x17_5dbd, 3);  mov(memw[ss, bp - 4], ax);              /* mov [bp-0x4], ax */
            ii(0x17_5dc0, 3);  mov(memw[ss, bp - 2], dx);              /* mov [bp-0x2], dx */
            ii(0x17_5dc3, 2);  or(dx, ax);                             /* or dx, ax */
            ii(0x17_5dc5, 2);  if(jnz(0x17_5dde, 0x17)) goto l_0x17_5dde;/* jnz 0x5dde */
            ii(0x17_5dc7, 1);  push(ds);                               /* push ds */
            ii(0x17_5dc8, 3);  push(0x36e);                            /* push 0x36e */
            ii(0x17_5dcb, 3);  push(0x90a);                            /* push 0x90a */
            ii(0x17_5dce, 1);  push(cs);                               /* push cs */
            ii(0x17_5dcf, 3);  call(0x17_75b4, 0x17e2);                /* call 0x75b4 */
            ii(0x17_5dd2, 3);  add(sp, 6);                             /* add sp, 0x6 */
            ii(0x17_5dd5, 3);  mov(ax, 1);                             /* mov ax, 0x1 */
            ii(0x17_5dd8, 1);  pop(ds);                                /* pop ds */
            ii(0x17_5dd9, 1);  pop(si);                                /* pop si */
            ii(0x17_5dda, 1);  pop(di);                                /* pop di */
            ii(0x17_5ddb, 1);  leave();                                /* leave */
            ii(0x17_5ddc, 1);  retf(); return;                         /* retf */
        //  ii(0x17_5ddd, 1);  Недостижимый код.
        l_0x17_5dde:
            ii(0x17_5dde, 3);  mov(bx, memw[ss, bp - 26]);             /* mov bx, [bp-0x1a] */
            ii(0x17_5de1, 3);  shl(bx, 2);                             /* shl bx, 0x2 */
            ii(0x17_5de4, 4);  les(si, memw[ds, 0x4fec]);              /* les si, [0x4fec] */
            ii(0x17_5de8, 3);  mov(ax, memw[es, bx + si]);             /* mov ax, [es:bx+si] */
            ii(0x17_5deb, 3);  xor(ax, memw[ss, bp - 4]);              /* xor ax, [bp-0x4] */
            ii(0x17_5dee, 3);  and(ah, 0xf);                           /* and ah, 0xf */
            ii(0x17_5df1, 2);  sub(dx, dx);                            /* sub dx, dx */
            ii(0x17_5df3, 3);  xor(ax, memw[ss, bp - 4]);              /* xor ax, [bp-0x4] */
            ii(0x17_5df6, 3);  xor(dx, memw[ss, bp - 2]);              /* xor dx, [bp-0x2] */
            ii(0x17_5df9, 3);  mov(memw[es, bx + si], ax);             /* mov [es:bx+si], ax */
            ii(0x17_5dfc, 4);  mov(memw[es, bx + si + 2], dx);         /* mov [es:bx+si+0x2], dx */
            ii(0x17_5e00, 4);  les(si, memw[ds, 0x4fec]);              /* les si, [0x4fec] */
            ii(0x17_5e04, 4);  or(memb[es, bx + si], 1);               /* or byte [es:bx+si], 0x1 */
            ii(0x17_5e08, 4);  les(si, memw[ds, 0x4fec]);              /* les si, [0x4fec] */
            ii(0x17_5e0c, 4);  or(memb[es, bx + si], 2);               /* or byte [es:bx+si], 0x2 */
            ii(0x17_5e10, 4);  les(si, memw[ds, 0x4fec]);              /* les si, [0x4fec] */
            ii(0x17_5e14, 4);  or(memb[es, bx + si], 4);               /* or byte [es:bx+si], 0x4 */
            ii(0x17_5e18, 1);  nop();                                  /* nop */
            ii(0x17_5e19, 1);  push(cs);                               /* push cs */
            ii(0x17_5e1a, 3);  call(0x17_8e97, 0x307a);                /* call 0x8e97 */
            ii(0x17_5e1d, 5);  add(memw[ss, bp - 4], 0x1000);          /* add word [bp-0x4], 0x1000 */
            ii(0x17_5e22, 4);  adc(memw[ss, bp - 2], 0);               /* adc word [bp-0x2], 0x0 */
            ii(0x17_5e26, 2);  jmp(0x17_5dae, -0x7a); goto l_0x17_5dae;/* jmp 0x5dae */
        l_0x17_5e28:
            ii(0x17_5e28, 2);  push(-1 /* 0xff */);                    /* push 0xffff */
            ii(0x17_5e2a, 3);  push(0xff00);                           /* push 0xff00 */
            ii(0x17_5e2d, 2);  push(0);                                /* push 0x0 */
            ii(0x17_5e2f, 1);  nop();                                  /* nop */
            ii(0x17_5e30, 1);  push(cs);                               /* push cs */
            ii(0x17_5e31, 3);  call(0x16_e96a, -0x74ca);               /* call 0xe96a */
            ii(0x17_5e34, 3);  add(sp, 6);                             /* add sp, 0x6 */
            ii(0x17_5e37, 3);  mov(memw[ss, bp - 24], ax);             /* mov [bp-0x18], ax */
            ii(0x17_5e3a, 3);  mov(memw[ss, bp - 22], dx);             /* mov [bp-0x16], dx */
            ii(0x17_5e3d, 3);  mov(memw[ds, 0x4ff0], ax);              /* mov [0x4ff0], ax */
            ii(0x17_5e40, 4);  mov(memw[ds, 0x4ff2], dx);              /* mov [0x4ff2], dx */
            ii(0x17_5e44, 3);  push(0x80);                             /* push 0x80 */
            ii(0x17_5e47, 3);  push(0x92);                             /* push 0x92 */
            ii(0x17_5e4a, 3);  mov(ax, memw[ss, bp - 6]);              /* mov ax, [bp-0x6] */
            ii(0x17_5e4d, 2);  sub(dx, dx);                            /* sub dx, dx */
            ii(0x17_5e4f, 1);  push(dx);                               /* push dx */
            ii(0x17_5e50, 1);  push(ax);                               /* push ax */
            ii(0x17_5e51, 3);  push(0xff00);                           /* push 0xff00 */
            ii(0x17_5e54, 1);  push(dx);                               /* push dx */
            ii(0x17_5e55, 3);  push(memw[ss, bp - 22]);                /* push word [bp-0x16] */
            ii(0x17_5e58, 2);  mov(si, ax);                            /* mov si, ax */
            ii(0x17_5e5a, 2);  mov(di, dx);                            /* mov di, dx */
            ii(0x17_5e5c, 1);  push(cs);                               /* push cs */
            ii(0x17_5e5d, 3);  call(0x17_621a, 0x3ba);                 /* call 0x621a */
            ii(0x17_5e60, 3);  add(sp, 0xe);                           /* add sp, 0xe */
            ii(0x17_5e63, 2);  mov(ax, si);                            /* mov ax, si */
            ii(0x17_5e65, 2);  mov(dx, di);                            /* mov dx, di */
            ii(0x17_5e67, 2);  mov(dh, dl);                            /* mov dh, dl */
            ii(0x17_5e69, 2);  mov(dl, ah);                            /* mov dl, ah */
            ii(0x17_5e6b, 2);  mov(ah, al);                            /* mov ah, al */
            ii(0x17_5e6d, 2);  sub(al, al);                            /* sub al, al */
            ii(0x17_5e6f, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x17_5e71, 2);  rcl(dx, 1);                             /* rcl dx, 1 */
            ii(0x17_5e73, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x17_5e75, 2);  rcl(dx, 1);                             /* rcl dx, 1 */
            ii(0x17_5e77, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x17_5e79, 2);  rcl(dx, 1);                             /* rcl dx, 1 */
            ii(0x17_5e7b, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x17_5e7d, 2);  rcl(dx, 1);                             /* rcl dx, 1 */
            ii(0x17_5e7f, 1);  push(dx);                               /* push dx */
            ii(0x17_5e80, 1);  push(ax);                               /* push ax */
            ii(0x17_5e81, 1);  push(di);                               /* push di */
            ii(0x17_5e82, 3);  push(0x1000);                           /* push 0x1000 */
            ii(0x17_5e85, 3);  push(memw[ss, bp - 22]);                /* push word [bp-0x16] */
            ii(0x17_5e88, 1);  nop();                                  /* nop */
            ii(0x17_5e89, 1);  push(cs);                               /* push cs */
            ii(0x17_5e8a, 3);  call(0x17_925c, 0x33cf);                /* call 0x925c */
            ii(0x17_5e8d, 3);  add(sp, 0xa);                           /* add sp, 0xa */
            ii(0x17_5e90, 1);  push(di);                               /* push di */
            ii(0x17_5e91, 3);  push(0x1000);                           /* push 0x1000 */
            ii(0x17_5e94, 3);  mov(ax, memw[ds, 0x34]);                /* mov ax, [0x34] */
            ii(0x17_5e97, 4);  mov(dx, memw[ds, 0x36]);                /* mov dx, [0x36] */
            ii(0x17_5e9b, 2);  mov(dh, dl);                            /* mov dh, dl */
            ii(0x17_5e9d, 2);  mov(dl, ah);                            /* mov dl, ah */
            ii(0x17_5e9f, 2);  mov(ah, al);                            /* mov ah, al */
            ii(0x17_5ea1, 2);  sub(al, al);                            /* sub al, al */
            ii(0x17_5ea3, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x17_5ea5, 2);  rcl(dx, 1);                             /* rcl dx, 1 */
            ii(0x17_5ea7, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x17_5ea9, 2);  rcl(dx, 1);                             /* rcl dx, 1 */
            ii(0x17_5eab, 3);  mov(memw[ss, bp - 14], ax);             /* mov [bp-0xe], ax */
            ii(0x17_5eae, 3);  mov(memw[ss, bp - 12], dx);             /* mov [bp-0xc], dx */
            ii(0x17_5eb1, 1);  push(dx);                               /* push dx */
            ii(0x17_5eb2, 1);  push(ax);                               /* push ax */
            ii(0x17_5eb3, 1);  nop();                                  /* nop */
            ii(0x17_5eb4, 1);  push(cs);                               /* push cs */
            ii(0x17_5eb5, 3);  call(0x17_dddc, 0x7f24);                /* call 0xdddc */
            ii(0x17_5eb8, 3);  mov(memw[ds, 0xa6], ax);                /* mov [0xa6], ax */
            ii(0x17_5ebb, 4);  mov(memw[ds, 0xa8], dx);                /* mov [0xa8], dx */
            ii(0x17_5ebf, 1);  nop();                                  /* nop */
            ii(0x17_5ec0, 1);  push(cs);                               /* push cs */
            ii(0x17_5ec1, 3);  call(0x17_8e97, 0x2fd3);                /* call 0x8e97 */
            ii(0x17_5ec4, 3);  mov(ax, memw[ds, 0x4ff2]);              /* mov ax, [0x4ff2] */
            ii(0x17_5ec7, 3);  mov(memw[ds, 0xaa], ax);                /* mov [0xaa], ax */
            ii(0x17_5eca, 1);  push(ax);                               /* push ax */
            ii(0x17_5ecb, 3);  call(0x17_90ae, 0x31e0);                /* call 0x90ae */
            ii(0x17_5ece, 3);  add(sp, 2);                             /* add sp, 0x2 */
            ii(0x17_5ed1, 3);  mov(ax, memw[ds, 0x201c]);              /* mov ax, [0x201c] */
            ii(0x17_5ed4, 4);  mov(dx, memw[ds, 0x201e]);              /* mov dx, [0x201e] */
            ii(0x17_5ed8, 2);  mov(dh, dl);                            /* mov dh, dl */
            ii(0x17_5eda, 2);  mov(dl, ah);                            /* mov dl, ah */
            ii(0x17_5edc, 2);  mov(ah, al);                            /* mov ah, al */
            ii(0x17_5ede, 2);  sub(al, al);                            /* sub al, al */
            ii(0x17_5ee0, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x17_5ee2, 2);  rcl(dx, 1);                             /* rcl dx, 1 */
            ii(0x17_5ee4, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x17_5ee6, 2);  rcl(dx, 1);                             /* rcl dx, 1 */
            ii(0x17_5ee8, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x17_5eea, 2);  rcl(dx, 1);                             /* rcl dx, 1 */
            ii(0x17_5eec, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x17_5eee, 2);  rcl(dx, 1);                             /* rcl dx, 1 */
            ii(0x17_5ef0, 1);  push(dx);                               /* push dx */
            ii(0x17_5ef1, 1);  push(ax);                               /* push ax */
            ii(0x17_5ef2, 1);  nop();                                  /* nop */
            ii(0x17_5ef3, 1);  push(cs);                               /* push cs */
            ii(0x17_5ef4, 3);  call(0x17_812e, 0x2237);                /* call 0x812e */
            ii(0x17_5ef7, 3);  add(sp, 4);                             /* add sp, 0x4 */
            ii(0x17_5efa, 2);  or(ax, ax);                             /* or ax, ax */
            ii(0x17_5efc, 2);  if(jz(0x17_5f06, 8)) goto l_0x17_5f06;  /* jz 0x5f06 */
            ii(0x17_5efe, 3);  mov(ax, 1);                             /* mov ax, 0x1 */
            ii(0x17_5f01, 1);  pop(ds);                                /* pop ds */
            ii(0x17_5f02, 1);  pop(si);                                /* pop si */
            ii(0x17_5f03, 1);  pop(di);                                /* pop di */
            ii(0x17_5f04, 1);  leave();                                /* leave */
            ii(0x17_5f05, 1);  retf(); return;                         /* retf */
        l_0x17_5f06:
            ii(0x17_5f06, 1);  push(di);                               /* push di */
            ii(0x17_5f07, 1);  push(di);                               /* push di */
            ii(0x17_5f08, 3);  push(0x3e58);                           /* push 0x3e58 */
            ii(0x17_5f0b, 3);  push(0x3c20);                           /* push 0x3c20 */
            ii(0x17_5f0e, 1);  nop();                                  /* nop */
            ii(0x17_5f0f, 1);  push(cs);                               /* push cs */
            ii(0x17_5f10, 3);  call(0x17_c7f4, 0x68e1);                /* call 0xc7f4 */
            ii(0x17_5f13, 3);  add(sp, 8);                             /* add sp, 0x8 */
            ii(0x17_5f16, 3);  mov(memb[ds, 0x51a7], al);              /* mov [0x51a7], al */
            ii(0x17_5f19, 1);  push(di);                               /* push di */
            ii(0x17_5f1a, 1);  push(di);                               /* push di */
            ii(0x17_5f1b, 3);  push(0x3e58);                           /* push 0x3e58 */
            ii(0x17_5f1e, 3);  push(0x45a4);                           /* push 0x45a4 */
            ii(0x17_5f21, 1);  nop();                                  /* nop */
            ii(0x17_5f22, 1);  push(cs);                               /* push cs */
            ii(0x17_5f23, 3);  call(0x17_c7f4, 0x68ce);                /* call 0xc7f4 */
            ii(0x17_5f26, 3);  add(sp, 8);                             /* add sp, 0x8 */
            ii(0x17_5f29, 3);  mov(memb[ds, 0x51a6], al);              /* mov [0x51a6], al */
            ii(0x17_5f2c, 1);  push(di);                               /* push di */
            ii(0x17_5f2d, 1);  push(di);                               /* push di */
            ii(0x17_5f2e, 3);  push(0x3e58);                           /* push 0x3e58 */
            ii(0x17_5f31, 3);  push(0x4602);                           /* push 0x4602 */
            ii(0x17_5f34, 1);  nop();                                  /* nop */
            ii(0x17_5f35, 1);  push(cs);                               /* push cs */
            ii(0x17_5f36, 3);  call(0x17_c7f4, 0x68bb);                /* call 0xc7f4 */
            ii(0x17_5f39, 3);  add(sp, 8);                             /* add sp, 0x8 */
            ii(0x17_5f3c, 3);  mov(memb[ds, 0x51b5], al);              /* mov [0x51b5], al */
            ii(0x17_5f3f, 3);  mov(ax, memw[ds, 0x201c]);              /* mov ax, [0x201c] */
            ii(0x17_5f42, 4);  mov(dx, memw[ds, 0x201e]);              /* mov dx, [0x201e] */
            ii(0x17_5f46, 3);  mov(memw[ds, 0x1fc8], ax);              /* mov [0x1fc8], ax */
            ii(0x17_5f49, 4);  mov(memw[ds, 0x1fca], dx);              /* mov [0x1fca], dx */
            ii(0x17_5f4d, 2);  mov(dh, dl);                            /* mov dh, dl */
            ii(0x17_5f4f, 2);  mov(dl, ah);                            /* mov dl, ah */
            ii(0x17_5f51, 2);  mov(ah, al);                            /* mov ah, al */
            ii(0x17_5f53, 2);  sub(al, al);                            /* sub al, al */
            ii(0x17_5f55, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x17_5f57, 2);  rcl(dx, 1);                             /* rcl dx, 1 */
            ii(0x17_5f59, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x17_5f5b, 2);  rcl(dx, 1);                             /* rcl dx, 1 */
            ii(0x17_5f5d, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x17_5f5f, 2);  rcl(dx, 1);                             /* rcl dx, 1 */
            ii(0x17_5f61, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x17_5f63, 2);  rcl(dx, 1);                             /* rcl dx, 1 */
            ii(0x17_5f65, 3);  add(ax, 0xffff);                        /* add ax, 0xffff */
            ii(0x17_5f68, 4);  adc(dx, 0xfff);                         /* adc dx, 0xfff */
            ii(0x17_5f6c, 3);  mov(memw[ds, 0x4fd8], ax);              /* mov [0x4fd8], ax */
            ii(0x17_5f6f, 4);  mov(memw[ds, 0x4fda], dx);              /* mov [0x4fda], dx */
            ii(0x17_5f73, 2);  sub(ax, ax);                            /* sub ax, ax */
            ii(0x17_5f75, 3);  mov(memw[ss, bp - 2], ax);              /* mov [bp-0x2], ax */
            ii(0x17_5f78, 3);  mov(memw[ss, bp - 4], ax);              /* mov [bp-0x4], ax */
            ii(0x17_5f7b, 2);  jmp(0x17_5f86, 9); goto l_0x17_5f86;    /* jmp 0x5f86 */
        //  ii(0x17_5f7d, 1);  nop();                                  /* nop */
        l_0x17_5f7e:
            ii(0x17_5f7e, 4);  add(memw[ss, bp - 4], 1);               /* add word [bp-0x4], 0x1 */
            ii(0x17_5f82, 4);  adc(memw[ss, bp - 2], 0);               /* adc word [bp-0x2], 0x0 */
        l_0x17_5f86:
            ii(0x17_5f86, 3);  mov(ax, memw[ds, 0x201c]);              /* mov ax, [0x201c] */
            ii(0x17_5f89, 4);  mov(dx, memw[ds, 0x201e]);              /* mov dx, [0x201e] */
            ii(0x17_5f8d, 3);  cmp(memw[ss, bp - 2], dx);              /* cmp [bp-0x2], dx */
            ii(0x17_5f90, 2);  if(ja(0x17_5ff8, 0x66)) goto l_0x17_5ff8;/* ja 0x5ff8 */
            ii(0x17_5f92, 2);  if(jb(0x17_5f99, 5)) goto l_0x17_5f99;  /* jb 0x5f99 */
            ii(0x17_5f94, 3);  cmp(memw[ss, bp - 4], ax);              /* cmp [bp-0x4], ax */
            ii(0x17_5f97, 2);  if(jae(0x17_5ff8, 0x5f)) goto l_0x17_5ff8;/* jae 0x5ff8 */
        l_0x17_5f99:
            ii(0x17_5f99, 2);  push(0);                                /* push 0x0 */
            ii(0x17_5f9b, 3);  push(memw[ss, bp - 2]);                 /* push word [bp-0x2] */
            ii(0x17_5f9e, 3);  push(memw[ss, bp - 4]);                 /* push word [bp-0x4] */
            ii(0x17_5fa1, 4);  push(memw[ds, 0x1fa6]);                 /* push word [0x1fa6] */
            ii(0x17_5fa5, 4);  push(memw[ds, 0x1fa4]);                 /* push word [0x1fa4] */
            ii(0x17_5fa9, 3);  call(0x17_91e3, 0x3237);                /* call 0x91e3 */
            ii(0x17_5fac, 3);  add(sp, 0xa);                           /* add sp, 0xa */
            ii(0x17_5faf, 2);  push(0);                                /* push 0x0 */
            ii(0x17_5fb1, 3);  push(memw[ss, bp - 2]);                 /* push word [bp-0x2] */
            ii(0x17_5fb4, 3);  push(memw[ss, bp - 4]);                 /* push word [bp-0x4] */
            ii(0x17_5fb7, 4);  push(memw[ds, 0x4ff6]);                 /* push word [0x4ff6] */
            ii(0x17_5fbb, 4);  push(memw[ds, 0x4ff4]);                 /* push word [0x4ff4] */
            ii(0x17_5fbf, 3);  call(0x17_91e3, 0x3221);                /* call 0x91e3 */
            ii(0x17_5fc2, 3);  add(sp, 0xa);                           /* add sp, 0xa */
            ii(0x17_5fc5, 2);  push(0);                                /* push 0x0 */
            ii(0x17_5fc7, 2);  push(0);                                /* push 0x0 */
            ii(0x17_5fc9, 3);  push(memw[ss, bp - 2]);                 /* push word [bp-0x2] */
            ii(0x17_5fcc, 3);  push(memw[ss, bp - 4]);                 /* push word [bp-0x4] */
            ii(0x17_5fcf, 4);  push(memw[ds, 0x4f8e]);                 /* push word [0x4f8e] */
            ii(0x17_5fd3, 4);  push(memw[ds, 0x4f8c]);                 /* push word [0x4f8c] */
            ii(0x17_5fd7, 3);  call(0x17_9235, 0x325b);                /* call 0x9235 */
            ii(0x17_5fda, 3);  add(sp, 0xc);                           /* add sp, 0xc */
            ii(0x17_5fdd, 2);  push(0);                                /* push 0x0 */
            ii(0x17_5fdf, 2);  push(0);                                /* push 0x0 */
            ii(0x17_5fe1, 3);  push(memw[ss, bp - 2]);                 /* push word [bp-0x2] */
            ii(0x17_5fe4, 3);  push(memw[ss, bp - 4]);                 /* push word [bp-0x4] */
            ii(0x17_5fe7, 4);  push(memw[ds, 0x4fb6]);                 /* push word [0x4fb6] */
            ii(0x17_5feb, 4);  push(memw[ds, 0x4fb4]);                 /* push word [0x4fb4] */
            ii(0x17_5fef, 3);  call(0x17_9235, 0x3243);                /* call 0x9235 */
            ii(0x17_5ff2, 3);  add(sp, 0xc);                           /* add sp, 0xc */
            ii(0x17_5ff5, 2);  jmp(0x17_5f7e, -0x79); goto l_0x17_5f7e;/* jmp 0x5f7e */
        //  ii(0x17_5ff7, 1);  nop();                                  /* nop */
        l_0x17_5ff8:
            ii(0x17_5ff8, 2);  push(1);                                /* push 0x1 */
            ii(0x17_5ffa, 3);  mov(ax, memw[ss, bp - 4]);              /* mov ax, [bp-0x4] */
            ii(0x17_5ffd, 3);  mov(dx, memw[ss, bp - 2]);              /* mov dx, [bp-0x2] */
            ii(0x17_6000, 3);  sub(ax, 1);                             /* sub ax, 0x1 */
            ii(0x17_6003, 3);  sbb(dx, 0);                             /* sbb dx, 0x0 */
            ii(0x17_6006, 1);  push(dx);                               /* push dx */
            ii(0x17_6007, 1);  push(ax);                               /* push ax */
            ii(0x17_6008, 4);  push(memw[ds, 0x4ff6]);                 /* push word [0x4ff6] */
            ii(0x17_600c, 4);  push(memw[ds, 0x4ff4]);                 /* push word [0x4ff4] */
            ii(0x17_6010, 3);  call(0x17_91e3, 0x31d0);                /* call 0x91e3 */
            ii(0x17_6013, 3);  add(sp, 0xa);                           /* add sp, 0xa */
            ii(0x17_6016, 3);  mov(ax, memw[ds, 0x201c]);              /* mov ax, [0x201c] */
            ii(0x17_6019, 4);  mov(dx, memw[ds, 0x201e]);              /* mov dx, [0x201e] */
            ii(0x17_601d, 2);  mov(al, ah);                            /* mov al, ah */
            ii(0x17_601f, 2);  mov(ah, dl);                            /* mov ah, dl */
            ii(0x17_6021, 2);  mov(dl, dh);                            /* mov dl, dh */
            ii(0x17_6023, 2);  sub(dh, dh);                            /* sub dh, dh */
            ii(0x17_6025, 2);  shr(dx, 1);                             /* shr dx, 1 */
            ii(0x17_6027, 2);  rcr(ax, 1);                             /* rcr ax, 1 */
            ii(0x17_6029, 2);  shr(dx, 1);                             /* shr dx, 1 */
            ii(0x17_602b, 2);  rcr(ax, 1);                             /* rcr ax, 1 */
            ii(0x17_602d, 3);  mov(memw[ss, bp - 20], ax);             /* mov [bp-0x14], ax */
            ii(0x17_6030, 6);  test(memw[ds, 0x201c], 0x3ff);          /* test word [0x201c], 0x3ff */
            ii(0x17_6036, 2);  if(jz(0x17_603c, 4)) goto l_0x17_603c;  /* jz 0x603c */
            ii(0x17_6038, 1);  inc(ax);                                /* inc ax */
            ii(0x17_6039, 3);  mov(memw[ss, bp - 20], ax);             /* mov [bp-0x14], ax */
        l_0x17_603c:
            ii(0x17_603c, 4);  add(memw[ss, bp - 20], 0x40);           /* add word [bp-0x14], 0x40 */
            ii(0x17_6040, 3);  mov(ax, memw[ds, 0x4f8c]);              /* mov ax, [0x4f8c] */
            ii(0x17_6043, 4);  mov(dx, memw[ds, 0x4f8e]);              /* mov dx, [0x4f8e] */
            ii(0x17_6047, 3);  mov(memw[ss, bp - 10], ax);             /* mov [bp-0xa], ax */
            ii(0x17_604a, 3);  mov(memw[ss, bp - 8], dx);              /* mov [bp-0x8], dx */
            ii(0x17_604d, 5);  mov(memw[ss, bp - 38], 0x40);           /* mov word [bp-0x26], 0x40 */
            ii(0x17_6052, 2);  jmp(0x17_6060, 0xc); goto l_0x17_6060;  /* jmp 0x6060 */
        l_0x17_6054:
            ii(0x17_6054, 3);  inc(memw[ss, bp - 38]);                 /* inc word [bp-0x26] */
            ii(0x17_6057, 5);  add(memw[ss, bp - 10], 0x1000);         /* add word [bp-0xa], 0x1000 */
            ii(0x17_605c, 4);  adc(memw[ss, bp - 8], 0);               /* adc word [bp-0x8], 0x0 */
        l_0x17_6060:
            ii(0x17_6060, 3);  mov(ax, memw[ss, bp - 38]);             /* mov ax, [bp-0x26] */
            ii(0x17_6063, 3);  cmp(memw[ss, bp - 20], ax);             /* cmp [bp-0x14], ax */
            ii(0x17_6066, 2);  if(jbe(0x17_60c2, 0x5a)) goto l_0x17_60c2;/* jbe 0x60c2 */
            ii(0x17_6068, 3);  push(memw[ss, bp - 8]);                 /* push word [bp-0x8] */
            ii(0x17_606b, 3);  push(memw[ss, bp - 10]);                /* push word [bp-0xa] */
            ii(0x17_606e, 1);  push(cs);                               /* push cs */
            ii(0x17_606f, 3);  call(0x17_61ca, 0x158);                 /* call 0x61ca */
            ii(0x17_6072, 3);  add(sp, 4);                             /* add sp, 0x4 */
            ii(0x17_6075, 2);  mov(dh, dl);                            /* mov dh, dl */
            ii(0x17_6077, 2);  mov(dl, ah);                            /* mov dl, ah */
            ii(0x17_6079, 2);  mov(ah, al);                            /* mov ah, al */
            ii(0x17_607b, 2);  sub(al, al);                            /* sub al, al */
            ii(0x17_607d, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x17_607f, 2);  rcl(dx, 1);                             /* rcl dx, 1 */
            ii(0x17_6081, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x17_6083, 2);  rcl(dx, 1);                             /* rcl dx, 1 */
            ii(0x17_6085, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x17_6087, 2);  rcl(dx, 1);                             /* rcl dx, 1 */
            ii(0x17_6089, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x17_608b, 2);  rcl(dx, 1);                             /* rcl dx, 1 */
            ii(0x17_608d, 3);  mov(bx, memw[ss, bp - 38]);             /* mov bx, [bp-0x26] */
            ii(0x17_6090, 3);  shl(bx, 2);                             /* shl bx, 0x2 */
            ii(0x17_6093, 4);  les(si, memw[ds, 0x992]);               /* les si, [0x992] */
            ii(0x17_6097, 3);  mov(cx, memw[es, bx + si]);             /* mov cx, [es:bx+si] */
            ii(0x17_609a, 3);  and(ch, 0xf);                           /* and ch, 0xf */
            ii(0x17_609d, 2);  sub(di, di);                            /* sub di, di */
            ii(0x17_609f, 2);  or(ax, cx);                             /* or ax, cx */
            ii(0x17_60a1, 3);  mov(memw[es, bx + si], ax);             /* mov [es:bx+si], ax */
            ii(0x17_60a4, 4);  mov(memw[es, bx + si + 2], dx);         /* mov [es:bx+si+0x2], dx */
            ii(0x17_60a8, 4);  les(si, memw[ds, 0x992]);               /* les si, [0x992] */
            ii(0x17_60ac, 4);  or(memb[es, bx + si], 1);               /* or byte [es:bx+si], 0x1 */
            ii(0x17_60b0, 4);  les(si, memw[ds, 0x992]);               /* les si, [0x992] */
            ii(0x17_60b4, 4);  or(memb[es, bx + si], 2);               /* or byte [es:bx+si], 0x2 */
            ii(0x17_60b8, 4);  les(si, memw[ds, 0x992]);               /* les si, [0x992] */
            ii(0x17_60bc, 4);  or(memb[es, bx + si], 4);               /* or byte [es:bx+si], 0x4 */
            ii(0x17_60c0, 2);  jmp(0x17_6054, -0x6e); goto l_0x17_6054;/* jmp 0x6054 */
        l_0x17_60c2:
            ii(0x17_60c2, 1);  nop();                                  /* nop */
            ii(0x17_60c3, 1);  push(cs);                               /* push cs */
            ii(0x17_60c4, 3);  call(0x17_8e97, 0x2dd0);                /* call 0x8e97 */
            ii(0x17_60c7, 3);  mov(ax, memw[ds, 0x24]);                /* mov ax, [0x24] */
            ii(0x17_60ca, 4);  mov(dx, memw[ds, 0x26]);                /* mov dx, [0x26] */
            ii(0x17_60ce, 2);  mov(dh, dl);                            /* mov dh, dl */
            ii(0x17_60d0, 2);  mov(dl, ah);                            /* mov dl, ah */
            ii(0x17_60d2, 2);  mov(ah, al);                            /* mov ah, al */
            ii(0x17_60d4, 2);  sub(al, al);                            /* sub al, al */
            ii(0x17_60d6, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x17_60d8, 2);  rcl(dx, 1);                             /* rcl dx, 1 */
            ii(0x17_60da, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x17_60dc, 2);  rcl(dx, 1);                             /* rcl dx, 1 */
            ii(0x17_60de, 3);  mov(memw[ds, 0x1fa8], ax);              /* mov [0x1fa8], ax */
            ii(0x17_60e1, 4);  mov(memw[ds, 0x1faa], dx);              /* mov [0x1faa], dx */
            ii(0x17_60e5, 3);  mov(ax, memw[ds, 0x24]);                /* mov ax, [0x24] */
            ii(0x17_60e8, 4);  mov(dx, memw[ds, 0x26]);                /* mov dx, [0x26] */
            ii(0x17_60ec, 2);  and(al, 0xfc);                          /* and al, 0xfc */
            ii(0x17_60ee, 3);  and(dx, 0x3f);                          /* and dx, 0x3f */
            ii(0x17_60f1, 2);  shr(dx, 1);                             /* shr dx, 1 */
            ii(0x17_60f3, 2);  rcr(ax, 1);                             /* rcr ax, 1 */
            ii(0x17_60f5, 2);  shr(dx, 1);                             /* shr dx, 1 */
            ii(0x17_60f7, 2);  rcr(ax, 1);                             /* rcr ax, 1 */
            ii(0x17_60f9, 3);  mov(memw[ds, 0x1fc4], ax);              /* mov [0x1fc4], ax */
            ii(0x17_60fc, 4);  mov(memw[ds, 0x1fc6], dx);              /* mov [0x1fc6], dx */
            ii(0x17_6100, 3);  mov(memw[ds, 0x1fb8], ax);              /* mov [0x1fb8], ax */
            ii(0x17_6103, 4);  mov(memw[ds, 0x1fba], dx);              /* mov [0x1fba], dx */
            ii(0x17_6107, 3);  mov(memw[ds, 0x1fac], ax);              /* mov [0x1fac], ax */
            ii(0x17_610a, 4);  mov(memw[ds, 0x1fae], dx);              /* mov [0x1fae], dx */
            ii(0x17_610e, 3);  mov(memw[ds, 0x1fb4], ax);              /* mov [0x1fb4], ax */
            ii(0x17_6111, 4);  mov(memw[ds, 0x1fb6], dx);              /* mov [0x1fb6], dx */
            ii(0x17_6115, 3);  mov(ax, memw[ds, 0x1fc0]);              /* mov ax, [0x1fc0] */
            ii(0x17_6118, 4);  mov(dx, memw[ds, 0x1fc2]);              /* mov dx, [0x1fc2] */
            ii(0x17_611c, 3);  mov(memw[ds, 0x1fb8], ax);              /* mov [0x1fb8], ax */
            ii(0x17_611f, 4);  mov(memw[ds, 0x1fba], dx);              /* mov [0x1fba], dx */
            ii(0x17_6123, 3);  mov(memw[ds, 0x1fbc], ax);              /* mov [0x1fbc], ax */
            ii(0x17_6126, 4);  mov(memw[ds, 0x1fbe], dx);              /* mov [0x1fbe], dx */
            ii(0x17_612a, 3);  sub(ax, 0xc);                           /* sub ax, 0xc */
            ii(0x17_612d, 3);  sbb(dx, 0);                             /* sbb dx, 0x0 */
            ii(0x17_6130, 3);  mov(memw[ds, 0x1fb0], ax);              /* mov [0x1fb0], ax */
            ii(0x17_6133, 4);  mov(memw[ds, 0x1fb2], dx);              /* mov [0x1fb2], dx */
            ii(0x17_6137, 3);  push(0x1000);                           /* push 0x1000 */
            ii(0x17_613a, 2);  push(0x40);                             /* push 0x40 */
            ii(0x17_613c, 2);  push(0);                                /* push 0x0 */
            ii(0x17_613e, 1);  nop();                                  /* nop */
            ii(0x17_613f, 1);  push(cs);                               /* push cs */
            ii(0x17_6140, 3);  call(0x16_e96a, -0x77d9);               /* call 0xe96a */
            ii(0x17_6143, 3);  add(sp, 6);                             /* add sp, 0x6 */
            ii(0x17_6146, 3);  mov(memw[ds, 0x1fe8], ax);              /* mov [0x1fe8], ax */
            ii(0x17_6149, 4);  mov(memw[ds, 0x1fea], dx);              /* mov [0x1fea], dx */
            ii(0x17_614d, 2);  sub(ax, ax);                            /* sub ax, ax */
            ii(0x17_614f, 1);  pop(ds);                                /* pop ds */
            ii(0x17_6150, 1);  pop(si);                                /* pop si */
            ii(0x17_6151, 1);  pop(di);                                /* pop di */
            ii(0x17_6152, 1);  leave();                                /* leave */
            ii(0x17_6153, 1);  retf(); return;                         /* retf */
        l_0x17_6154:
            ii(0x17_6154, 1);  pop(ds);                                /* pop ds */
            ii(0x17_6155, 1);  pop(si);                                /* pop si */
            ii(0x17_6156, 1);  pop(di);                                /* pop di */
            ii(0x17_6157, 1);  leave();                                /* leave */
            ii(0x17_6158, 1);  retf();                                 /* retf */
        }
    }
}
