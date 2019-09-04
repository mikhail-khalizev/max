using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_bbb4-a6ce4da9")]
        public void Method_0019_bbb4()
        {
            ii(0x19_bbb4, 4);  enter(0x36, 0);                         /* enter 0x36, 0x0 */
            ii(0x19_bbb8, 1);  push(si);                               /* push si */
            ii(0x19_bbb9, 3);  mov(ax, memw[ss, bp + 18]);             /* mov ax, [bp+0x12] */
            ii(0x19_bbbc, 3);  mov(memw[ss, bp - 14], ax);             /* mov [bp-0xe], ax */
        l_0x19_bbbf:
            ii(0x19_bbbf, 3);  mov(ax, memw[ss, bp + 14]);             /* mov ax, [bp+0xe] */
            ii(0x19_bbc2, 3);  or(ax, memw[ss, bp + 12]);              /* or ax, [bp+0xc] */
            ii(0x19_bbc5, 2);  if(jnz(0x19_bbca, 3)) goto l_0x19_bbca; /* jnz 0xbbca */
            ii(0x19_bbc7, 3);  jmp(0x19_c1ed, 0x623); goto l_0x19_c1ed;/* jmp 0xc1ed */
        l_0x19_bbca:
            ii(0x19_bbca, 5);  mov(memw[ss, bp - 40], 0);              /* mov word [bp-0x28], 0x0 */
            ii(0x19_bbcf, 2);  sub(ax, ax);                            /* sub ax, ax */
            ii(0x19_bbd1, 3);  mov(memw[ss, bp - 36], ax);             /* mov [bp-0x24], ax */
            ii(0x19_bbd4, 3);  mov(memw[ss, bp - 38], ax);             /* mov [bp-0x26], ax */
            ii(0x19_bbd7, 3);  mov(ax, memw[ss, bp + 16]);             /* mov ax, [bp+0x10] */
            ii(0x19_bbda, 3);  mov(memw[ss, bp - 16], ax);             /* mov [bp-0x10], ax */
            ii(0x19_bbdd, 3);  les(bx, memw[ss, bp - 16]);             /* les bx, [bp-0x10] */
            ii(0x19_bbe0, 3);  mov(al, memb[es, bx]);                  /* mov al, [es:bx] */
            ii(0x19_bbe3, 2);  mov(cx, ax);                            /* mov cx, ax */
            ii(0x19_bbe5, 3);  and(ax, 0xf);                           /* and ax, 0xf */
            ii(0x19_bbe8, 3);  mov(memw[ss, bp - 4], ax);              /* mov [bp-0x4], ax */
            ii(0x19_bbeb, 2);  mov(dx, cx);                            /* mov dx, cx */
            ii(0x19_bbed, 3);  and(cl, 0x20);                          /* and cl, 0x20 */
            ii(0x19_bbf0, 3);  cmp(cl, 1);                             /* cmp cl, 0x1 */
            ii(0x19_bbf3, 2);  sbb(cx, cx);                            /* sbb cx, cx */
            ii(0x19_bbf5, 1);  inc(cx);                                /* inc cx */
            ii(0x19_bbf6, 3);  mov(memw[ss, bp - 50], cx);             /* mov [bp-0x32], cx */
            ii(0x19_bbf9, 3);  mov(memw[ss, bp - 8], cx);              /* mov [bp-0x8], cx */
            ii(0x19_bbfc, 4);  mov(cl, memb[es, bx + 1]);              /* mov cl, [es:bx+0x1] */
            ii(0x19_bc00, 2);  mov(bx, cx);                            /* mov bx, cx */
            ii(0x19_bc02, 3);  and(cx, 4);                             /* and cx, 0x4 */
            ii(0x19_bc05, 3);  mov(memw[ss, bp - 44], cx);             /* mov [bp-0x2c], cx */
            ii(0x19_bc08, 5);  mov(memw[ss, bp - 42], 0);              /* mov word [bp-0x2a], 0x0 */
            ii(0x19_bc0d, 3);  and(dl, 0x10);                          /* and dl, 0x10 */
            ii(0x19_bc10, 3);  mov(memb[ss, bp - 2], dl);              /* mov [bp-0x2], dl */
            ii(0x19_bc13, 3);  mov(memw[ss, bp - 54], bx);             /* mov [bp-0x36], bx */
            ii(0x19_bc16, 3);  cmp(ax, 2);                             /* cmp ax, 0x2 */
            ii(0x19_bc19, 2);  if(jnz(0x19_bc1f, 4)) goto l_0x19_bc1f; /* jnz 0xbc1f */
            ii(0x19_bc1b, 2);  mov(al, 1);                             /* mov al, 0x1 */
            ii(0x19_bc1d, 2);  jmp(0x19_bc21, 2); goto l_0x19_bc21;    /* jmp 0xbc21 */
        l_0x19_bc1f:
            ii(0x19_bc1f, 2);  sub(al, al);                            /* sub al, al */
        l_0x19_bc21:
            ii(0x19_bc21, 3);  mov(memb[ss, bp - 6], al);              /* mov [bp-0x6], al */
            ii(0x19_bc24, 3);  mov(al, memb[ss, bp - 54]);             /* mov al, [bp-0x36] */
            ii(0x19_bc27, 2);  sub(ah, ah);                            /* sub ah, ah */
            ii(0x19_bc29, 3);  mov(memw[ss, bp - 52], ax);             /* mov [bp-0x34], ax */
            ii(0x19_bc2c, 2);  sub(cx, cx);                            /* sub cx, cx */
            ii(0x19_bc2e, 3);  mov(memw[ss, bp - 28], cx);             /* mov [bp-0x1c], cx */
            ii(0x19_bc31, 3);  mov(memw[ss, bp - 30], cx);             /* mov [bp-0x1e], cx */
            ii(0x19_bc34, 3);  and(ax, 3);                             /* and ax, 0x3 */
            ii(0x19_bc37, 2);  if(jz(0x19_bc6f, 0x36)) goto l_0x19_bc6f;/* jz 0xbc6f */
            ii(0x19_bc39, 3);  sub(ax, 1);                             /* sub ax, 0x1 */
            ii(0x19_bc3c, 2);  if(jb(0x19_bc4c, 0xe)) goto l_0x19_bc4c;/* jb 0xbc4c */
            ii(0x19_bc3e, 3);  sub(ax, 1);                             /* sub ax, 0x1 */
            ii(0x19_bc41, 2);  if(ja(0x19_bc46, 3)) goto l_0x19_bc46;  /* ja 0xbc46 */
            ii(0x19_bc43, 3);  jmp(0x19_bded, 0x1a7); goto l_0x19_bded;/* jmp 0xbded */
        l_0x19_bc46:
            ii(0x19_bc46, 1);  dec(ax);                                /* dec ax */
            ii(0x19_bc47, 2);  if(jnz(0x19_bc4c, 3)) goto l_0x19_bc4c; /* jnz 0xbc4c */
            ii(0x19_bc49, 3);  jmp(0x19_c07c, 0x430); goto l_0x19_c07c;/* jmp 0xc07c */
        l_0x19_bc4c:
            ii(0x19_bc4c, 1);  push(ds);                               /* push ds */
            ii(0x19_bc4d, 3);  push(0x213e);                           /* push 0x213e */
            ii(0x19_bc50, 3);  push(0xce8);                            /* push 0xce8 */
            ii(0x19_bc53, 3);  call(0x1a_1056, 0x5400);                /* call 0x1056 */
            ii(0x19_bc56, 3);  add(sp, 6);                             /* add sp, 0x6 */
            ii(0x19_bc59, 5);  mov(memw[ss, bp - 40], 0);              /* mov word [bp-0x28], 0x0 */
            ii(0x19_bc5e, 2);  sub(ax, ax);                            /* sub ax, ax */
            ii(0x19_bc60, 3);  mov(memw[ss, bp - 36], ax);             /* mov [bp-0x24], ax */
            ii(0x19_bc63, 3);  mov(memw[ss, bp - 38], ax);             /* mov [bp-0x26], ax */
            ii(0x19_bc66, 3);  mov(memw[ss, bp - 10], ax);             /* mov [bp-0xa], ax */
            ii(0x19_bc69, 3);  mov(memw[ss, bp - 12], ax);             /* mov [bp-0xc], ax */
            ii(0x19_bc6c, 3);  jmp(0x19_bddf, 0x170); goto l_0x19_bddf;/* jmp 0xbddf */
        l_0x19_bc6f:
            ii(0x19_bc6f, 4);  test(memb[ss, bp - 52], 0x40);          /* test byte [bp-0x34], 0x40 */
            ii(0x19_bc73, 2);  if(jnz(0x19_bc78, 3)) goto l_0x19_bc78; /* jnz 0xbc78 */
            ii(0x19_bc75, 3);  jmp(0x19_bd26, 0xae); goto l_0x19_bd26; /* jmp 0xbd26 */
        l_0x19_bc78:
            ii(0x19_bc78, 3);  cmp(memw[ss, bp - 50], cx);             /* cmp [bp-0x32], cx */
            ii(0x19_bc7b, 2);  if(jz(0x19_bcd3, 0x56)) goto l_0x19_bcd3;/* jz 0xbcd3 */
            ii(0x19_bc7d, 3);  mov(bx, memw[ss, bp - 16]);             /* mov bx, [bp-0x10] */
            ii(0x19_bc80, 4);  mov(ax, memw[es, bx + 3]);              /* mov ax, [es:bx+0x3] */
            ii(0x19_bc84, 3);  mov(memw[ss, bp - 22], ax);             /* mov [bp-0x16], ax */
            ii(0x19_bc87, 4);  mov(al, memb[es, bx + 2]);              /* mov al, [es:bx+0x2] */
            ii(0x19_bc8b, 2);  sub(ah, ah);                            /* sub ah, ah */
            ii(0x19_bc8d, 1);  dec(ax);                                /* dec ax */
            ii(0x19_bc8e, 3);  mov(memw[ss, bp - 50], ax);             /* mov [bp-0x32], ax */
            ii(0x19_bc91, 4);  cmp(memb[ss, bp - 6], 0);               /* cmp byte [bp-0x6], 0x0 */
            ii(0x19_bc95, 2);  if(jz(0x19_bcab, 0x14)) goto l_0x19_bcab;/* jz 0xbcab */
            ii(0x19_bc97, 2);  sub(ax, ax);                            /* sub ax, ax */
            ii(0x19_bc99, 3);  mov(memw[ss, bp - 24], ax);             /* mov [bp-0x18], ax */
            ii(0x19_bc9c, 3);  mov(memw[ss, bp - 26], ax);             /* mov [bp-0x1a], ax */
            ii(0x19_bc9f, 3);  lea(ax, memw[ds, bx + 5]);              /* lea ax, [bx+0x5] */
        l_0x19_bca2:
            ii(0x19_bca2, 3);  mov(memw[ss, bp - 12], ax);             /* mov [bp-0xc], ax */
            ii(0x19_bca5, 3);  mov(memw[ss, bp - 10], es);             /* mov [bp-0xa], es */
            ii(0x19_bca8, 3);  jmp(0x19_bdc4, 0x119); goto l_0x19_bdc4;/* jmp 0xbdc4 */
        l_0x19_bcab:
            ii(0x19_bcab, 4);  test(memb[ss, bp - 52], 0x10);          /* test byte [bp-0x34], 0x10 */
            ii(0x19_bcaf, 2);  if(jz(0x19_bcc4, 0x13)) goto l_0x19_bcc4;/* jz 0xbcc4 */
            ii(0x19_bcb1, 4);  mov(ax, memw[es, bx + 5]);              /* mov ax, [es:bx+0x5] */
            ii(0x19_bcb5, 4);  mov(dx, memw[es, bx + 7]);              /* mov dx, [es:bx+0x7] */
            ii(0x19_bcb9, 3);  mov(memw[ss, bp - 26], ax);             /* mov [bp-0x1a], ax */
            ii(0x19_bcbc, 3);  mov(memw[ss, bp - 24], dx);             /* mov [bp-0x18], dx */
            ii(0x19_bcbf, 3);  lea(ax, memw[ds, bx + 9]);              /* lea ax, [bx+0x9] */
            ii(0x19_bcc2, 2);  jmp(0x19_bca2, -0x22); goto l_0x19_bca2;/* jmp 0xbca2 */
        l_0x19_bcc4:
            ii(0x19_bcc4, 4);  mov(ax, memw[es, bx + 5]);              /* mov ax, [es:bx+0x5] */
            ii(0x19_bcc8, 3);  mov(memw[ss, bp - 26], ax);             /* mov [bp-0x1a], ax */
            ii(0x19_bccb, 3);  mov(memw[ss, bp - 24], cx);             /* mov [bp-0x18], cx */
            ii(0x19_bcce, 3);  lea(ax, memw[ds, bx + 7]);              /* lea ax, [bx+0x7] */
            ii(0x19_bcd1, 2);  jmp(0x19_bca2, -0x31); goto l_0x19_bca2;/* jmp 0xbca2 */
        l_0x19_bcd3:
            ii(0x19_bcd3, 3);  mov(bx, memw[ss, bp - 16]);             /* mov bx, [bp-0x10] */
            ii(0x19_bcd6, 4);  mov(ax, memw[es, bx + 4]);              /* mov ax, [es:bx+0x4] */
            ii(0x19_bcda, 3);  mov(memw[ss, bp - 22], ax);             /* mov [bp-0x16], ax */
            ii(0x19_bcdd, 3);  lea(ax, memw[ds, bx + 2]);              /* lea ax, [bx+0x2] */
            ii(0x19_bce0, 3);  mov(memw[ss, bp - 12], ax);             /* mov [bp-0xc], ax */
            ii(0x19_bce3, 3);  mov(memw[ss, bp - 10], es);             /* mov [bp-0xa], es */
            ii(0x19_bce6, 4);  cmp(memb[ss, bp - 6], 0);               /* cmp byte [bp-0x6], 0x0 */
            ii(0x19_bcea, 2);  if(jz(0x19_bcf7, 0xb)) goto l_0x19_bcf7;/* jz 0xbcf7 */
        l_0x19_bcec:
            ii(0x19_bcec, 2);  sub(ax, ax);                            /* sub ax, ax */
            ii(0x19_bcee, 3);  mov(memw[ss, bp - 24], ax);             /* mov [bp-0x18], ax */
            ii(0x19_bcf1, 3);  mov(memw[ss, bp - 26], ax);             /* mov [bp-0x1a], ax */
            ii(0x19_bcf4, 3);  jmp(0x19_bdc4, 0xcd); goto l_0x19_bdc4; /* jmp 0xbdc4 */
        l_0x19_bcf7:
            ii(0x19_bcf7, 3);  mov(ax, memw[ss, bp - 16]);             /* mov ax, [bp-0x10] */
            ii(0x19_bcfa, 2);  mov(dx, es);                            /* mov dx, es */
            ii(0x19_bcfc, 3);  add(ax, 6);                             /* add ax, 0x6 */
            ii(0x19_bcff, 3);  mov(memw[ss, bp - 30], ax);             /* mov [bp-0x1e], ax */
            ii(0x19_bd02, 3);  mov(memw[ss, bp - 28], dx);             /* mov [bp-0x1c], dx */
            ii(0x19_bd05, 4);  test(memb[ss, bp - 52], 0x10);          /* test byte [bp-0x34], 0x10 */
            ii(0x19_bd09, 2);  if(jnz(0x19_bd0e, 3)) goto l_0x19_bd0e; /* jnz 0xbd0e */
            ii(0x19_bd0b, 3);  jmp(0x19_bdb2, 0xa4); goto l_0x19_bdb2; /* jmp 0xbdb2 */
        l_0x19_bd0e:
            ii(0x19_bd0e, 2);  mov(bx, ax);                            /* mov bx, ax */
            ii(0x19_bd10, 3);  mov(cx, memw[es, bx]);                  /* mov cx, [es:bx] */
            ii(0x19_bd13, 4);  mov(si, memw[es, bx + 2]);              /* mov si, [es:bx+0x2] */
            ii(0x19_bd17, 3);  mov(memw[ss, bp - 26], cx);             /* mov [bp-0x1a], cx */
            ii(0x19_bd1a, 3);  mov(memw[ss, bp - 24], si);             /* mov [bp-0x18], si */
            ii(0x19_bd1d, 3);  add(ax, 4);                             /* add ax, 0x4 */
            ii(0x19_bd20, 3);  mov(memw[ss, bp - 30], ax);             /* mov [bp-0x1e], ax */
            ii(0x19_bd23, 3);  jmp(0x19_bdc4, 0x9e); goto l_0x19_bdc4; /* jmp 0xbdc4 */
        l_0x19_bd26:
            ii(0x19_bd26, 3);  cmp(memw[ss, bp - 50], cx);             /* cmp [bp-0x32], cx */
            ii(0x19_bd29, 2);  if(jz(0x19_bd7d, 0x52)) goto l_0x19_bd7d;/* jz 0xbd7d */
            ii(0x19_bd2b, 3);  mov(bx, memw[ss, bp - 16]);             /* mov bx, [bp-0x10] */
            ii(0x19_bd2e, 4);  mov(al, memb[es, bx + 3]);              /* mov al, [es:bx+0x3] */
            ii(0x19_bd32, 2);  sub(ah, ah);                            /* sub ah, ah */
            ii(0x19_bd34, 3);  mov(memw[ss, bp - 22], ax);             /* mov [bp-0x16], ax */
            ii(0x19_bd37, 4);  mov(al, memb[es, bx + 2]);              /* mov al, [es:bx+0x2] */
            ii(0x19_bd3b, 1);  dec(ax);                                /* dec ax */
            ii(0x19_bd3c, 3);  mov(memw[ss, bp - 50], ax);             /* mov [bp-0x32], ax */
            ii(0x19_bd3f, 4);  cmp(memb[ss, bp - 6], 0);               /* cmp byte [bp-0x6], 0x0 */
            ii(0x19_bd43, 2);  if(jz(0x19_bd53, 0xe)) goto l_0x19_bd53;/* jz 0xbd53 */
            ii(0x19_bd45, 2);  sub(ax, ax);                            /* sub ax, ax */
            ii(0x19_bd47, 3);  mov(memw[ss, bp - 24], ax);             /* mov [bp-0x18], ax */
            ii(0x19_bd4a, 3);  mov(memw[ss, bp - 26], ax);             /* mov [bp-0x1a], ax */
            ii(0x19_bd4d, 3);  lea(ax, memw[ds, bx + 4]);              /* lea ax, [bx+0x4] */
            ii(0x19_bd50, 3);  jmp(0x19_bca2, -0xb1); goto l_0x19_bca2;/* jmp 0xbca2 */
        l_0x19_bd53:
            ii(0x19_bd53, 4);  test(memb[ss, bp - 52], 0x10);          /* test byte [bp-0x34], 0x10 */
            ii(0x19_bd57, 2);  if(jz(0x19_bd6d, 0x14)) goto l_0x19_bd6d;/* jz 0xbd6d */
            ii(0x19_bd59, 4);  mov(ax, memw[es, bx + 4]);              /* mov ax, [es:bx+0x4] */
            ii(0x19_bd5d, 4);  mov(dx, memw[es, bx + 6]);              /* mov dx, [es:bx+0x6] */
            ii(0x19_bd61, 3);  mov(memw[ss, bp - 26], ax);             /* mov [bp-0x1a], ax */
            ii(0x19_bd64, 3);  mov(memw[ss, bp - 24], dx);             /* mov [bp-0x18], dx */
            ii(0x19_bd67, 3);  lea(ax, memw[ds, bx + 8]);              /* lea ax, [bx+0x8] */
            ii(0x19_bd6a, 3);  jmp(0x19_bca2, -0xcb); goto l_0x19_bca2;/* jmp 0xbca2 */
        l_0x19_bd6d:
            ii(0x19_bd6d, 4);  mov(ax, memw[es, bx + 4]);              /* mov ax, [es:bx+0x4] */
            ii(0x19_bd71, 3);  mov(memw[ss, bp - 26], ax);             /* mov [bp-0x1a], ax */
            ii(0x19_bd74, 3);  mov(memw[ss, bp - 24], cx);             /* mov [bp-0x18], cx */
            ii(0x19_bd77, 3);  lea(ax, memw[ds, bx + 6]);              /* lea ax, [bx+0x6] */
            ii(0x19_bd7a, 3);  jmp(0x19_bca2, -0xdb); goto l_0x19_bca2;/* jmp 0xbca2 */
        l_0x19_bd7d:
            ii(0x19_bd7d, 3);  mov(bx, memw[ss, bp - 16]);             /* mov bx, [bp-0x10] */
            ii(0x19_bd80, 4);  mov(al, memb[es, bx + 4]);              /* mov al, [es:bx+0x4] */
            ii(0x19_bd84, 2);  sub(ah, ah);                            /* sub ah, ah */
            ii(0x19_bd86, 3);  mov(memw[ss, bp - 22], ax);             /* mov [bp-0x16], ax */
            ii(0x19_bd89, 3);  lea(ax, memw[ds, bx + 2]);              /* lea ax, [bx+0x2] */
            ii(0x19_bd8c, 3);  mov(memw[ss, bp - 12], ax);             /* mov [bp-0xc], ax */
            ii(0x19_bd8f, 3);  mov(memw[ss, bp - 10], es);             /* mov [bp-0xa], es */
            ii(0x19_bd92, 4);  cmp(memb[ss, bp - 6], 0);               /* cmp byte [bp-0x6], 0x0 */
            ii(0x19_bd96, 2);  if(jz(0x19_bd9b, 3)) goto l_0x19_bd9b;  /* jz 0xbd9b */
            ii(0x19_bd98, 3);  jmp(0x19_bcec, -0xaf); goto l_0x19_bcec;/* jmp 0xbcec */
        l_0x19_bd9b:
            ii(0x19_bd9b, 3);  mov(ax, memw[ss, bp - 16]);             /* mov ax, [bp-0x10] */
            ii(0x19_bd9e, 2);  mov(dx, es);                            /* mov dx, es */
            ii(0x19_bda0, 3);  add(ax, 5);                             /* add ax, 0x5 */
            ii(0x19_bda3, 3);  mov(memw[ss, bp - 30], ax);             /* mov [bp-0x1e], ax */
            ii(0x19_bda6, 3);  mov(memw[ss, bp - 28], dx);             /* mov [bp-0x1c], dx */
            ii(0x19_bda9, 4);  test(memb[ss, bp - 52], 0x10);          /* test byte [bp-0x34], 0x10 */
            ii(0x19_bdad, 2);  if(jz(0x19_bdb2, 3)) goto l_0x19_bdb2;  /* jz 0xbdb2 */
            ii(0x19_bdaf, 3);  jmp(0x19_bd0e, -0xa4); goto l_0x19_bd0e;/* jmp 0xbd0e */
        l_0x19_bdb2:
            ii(0x19_bdb2, 3);  les(bx, memw[ss, bp - 30]);             /* les bx, [bp-0x1e] */
            ii(0x19_bdb5, 4);  add(memw[ss, bp - 30], 2);              /* add word [bp-0x1e], 0x2 */
            ii(0x19_bdb9, 3);  mov(ax, memw[es, bx]);                  /* mov ax, [es:bx] */
            ii(0x19_bdbc, 3);  mov(memw[ss, bp - 26], ax);             /* mov [bp-0x1a], ax */
            ii(0x19_bdbf, 5);  mov(memw[ss, bp - 24], 0);              /* mov word [bp-0x18], 0x0 */
        l_0x19_bdc4:
            ii(0x19_bdc4, 3);  push(memw[ss, bp + 22]);                /* push word [bp+0x16] */
            ii(0x19_bdc7, 3);  push(memw[ss, bp + 20]);                /* push word [bp+0x14] */
            ii(0x19_bdca, 3);  push(memw[ss, bp - 22]);                /* push word [bp-0x16] */
            ii(0x19_bdcd, 3);  push(memw[ss, bp - 24]);                /* push word [bp-0x18] */
            ii(0x19_bdd0, 3);  push(memw[ss, bp - 26]);                /* push word [bp-0x1a] */
            ii(0x19_bdd3, 3);  lea(ax, memw[ss, bp - 40]);             /* lea ax, [bp-0x28] */
            ii(0x19_bdd6, 1);  push(ss);                               /* push ss */
            ii(0x19_bdd7, 1);  push(ax);                               /* push ax */
            ii(0x19_bdd8, 3);  mov(al, memb[ss, bp - 2]);              /* mov al, [bp-0x2] */
            ii(0x19_bddb, 1);  push(ax);                               /* push ax */
            ii(0x19_bddc, 3);  call(0x19_d0ec, 0x130d);                /* call 0xd0ec */
        l_0x19_bddf:
            ii(0x19_bddf, 3);  mov(ax, memw[ss, bp - 10]);             /* mov ax, [bp-0xa] */
            ii(0x19_bde2, 3);  or(ax, memw[ss, bp - 12]);              /* or ax, [bp-0xc] */
            ii(0x19_bde5, 2);  if(jz(0x19_bdea, 3)) goto l_0x19_bdea;  /* jz 0xbdea */
            ii(0x19_bde7, 3);  jmp(0x19_c153, 0x369); goto l_0x19_c153;/* jmp 0xc153 */
        l_0x19_bdea:
            ii(0x19_bdea, 3);  jmp(0x19_c1ed, 0x400); goto l_0x19_c1ed;/* jmp 0xc1ed */
        l_0x19_bded:
            ii(0x19_bded, 4);  test(memb[ss, bp - 52], 0x40);          /* test byte [bp-0x34], 0x40 */
            ii(0x19_bdf1, 2);  if(jnz(0x19_bdf6, 3)) goto l_0x19_bdf6; /* jnz 0xbdf6 */
            ii(0x19_bdf3, 3);  jmp(0x19_befa, 0x104); goto l_0x19_befa;/* jmp 0xbefa */
        l_0x19_bdf6:
            ii(0x19_bdf6, 3);  cmp(memw[ss, bp - 50], cx);             /* cmp [bp-0x32], cx */
            ii(0x19_bdf9, 2);  if(jnz(0x19_bdfe, 3)) goto l_0x19_bdfe; /* jnz 0xbdfe */
            ii(0x19_bdfb, 3);  jmp(0x19_be84, 0x86); goto l_0x19_be84; /* jmp 0xbe84 */
        l_0x19_bdfe:
            ii(0x19_bdfe, 3);  mov(bx, memw[ss, bp - 16]);             /* mov bx, [bp-0x10] */
            ii(0x19_be01, 4);  mov(ax, memw[es, bx + 3]);              /* mov ax, [es:bx+0x3] */
            ii(0x19_be05, 3);  mov(memw[ss, bp - 20], ax);             /* mov [bp-0x14], ax */
            ii(0x19_be08, 3);  mov(memw[ss, bp - 18], cx);             /* mov [bp-0x12], cx */
            ii(0x19_be0b, 4);  mov(al, memb[es, bx + 2]);              /* mov al, [es:bx+0x2] */
            ii(0x19_be0f, 2);  sub(ah, ah);                            /* sub ah, ah */
            ii(0x19_be11, 1);  dec(ax);                                /* dec ax */
            ii(0x19_be12, 3);  mov(memw[ss, bp - 50], ax);             /* mov [bp-0x32], ax */
            ii(0x19_be15, 4);  test(memb[ss, bp - 52], 0x10);          /* test byte [bp-0x34], 0x10 */
            ii(0x19_be19, 2);  if(jz(0x19_be55, 0x3a)) goto l_0x19_be55;/* jz 0xbe55 */
            ii(0x19_be1b, 4);  mov(ax, memw[es, bx + 5]);              /* mov ax, [es:bx+0x5] */
            ii(0x19_be1f, 4);  mov(dx, memw[es, bx + 7]);              /* mov dx, [es:bx+0x7] */
            ii(0x19_be23, 3);  mov(memw[ss, bp - 48], ax);             /* mov [bp-0x30], ax */
            ii(0x19_be26, 3);  mov(memw[ss, bp - 46], dx);             /* mov [bp-0x2e], dx */
            ii(0x19_be29, 3);  lea(ax, memw[ds, bx + 9]);              /* lea ax, [bx+0x9] */
            ii(0x19_be2c, 3);  mov(memw[ss, bp - 12], ax);             /* mov [bp-0xc], ax */
            ii(0x19_be2f, 3);  mov(memw[ss, bp - 10], es);             /* mov [bp-0xa], es */
            ii(0x19_be32, 3);  mov(cx, memw[ss, bp - 42]);             /* mov cx, [bp-0x2a] */
            ii(0x19_be35, 3);  or(cx, memw[ss, bp - 44]);              /* or cx, [bp-0x2c] */
            ii(0x19_be38, 2);  if(jnz(0x19_be3d, 3)) goto l_0x19_be3d; /* jnz 0xbe3d */
            ii(0x19_be3a, 3);  jmp(0x19_c01e, 0x1e1); goto l_0x19_c01e;/* jmp 0xc01e */
        l_0x19_be3d:
            ii(0x19_be3d, 2);  mov(bx, ax);                            /* mov bx, ax */
            ii(0x19_be3f, 3);  mov(cx, memw[es, bx]);                  /* mov cx, [es:bx] */
            ii(0x19_be42, 4);  mov(dx, memw[es, bx + 2]);              /* mov dx, [es:bx+0x2] */
            ii(0x19_be46, 3);  mov(memw[ss, bp - 44], cx);             /* mov [bp-0x2c], cx */
            ii(0x19_be49, 3);  mov(memw[ss, bp - 42], dx);             /* mov [bp-0x2a], dx */
            ii(0x19_be4c, 3);  add(ax, 4);                             /* add ax, 0x4 */
        l_0x19_be4f:
            ii(0x19_be4f, 3);  mov(memw[ss, bp - 12], ax);             /* mov [bp-0xc], ax */
            ii(0x19_be52, 3);  jmp(0x19_c01e, 0x1c9); goto l_0x19_c01e;/* jmp 0xc01e */
        l_0x19_be55:
            ii(0x19_be55, 4);  mov(ax, memw[es, bx + 5]);              /* mov ax, [es:bx+0x5] */
            ii(0x19_be59, 3);  mov(memw[ss, bp - 48], ax);             /* mov [bp-0x30], ax */
            ii(0x19_be5c, 3);  mov(memw[ss, bp - 46], cx);             /* mov [bp-0x2e], cx */
            ii(0x19_be5f, 3);  lea(ax, memw[ds, bx + 7]);              /* lea ax, [bx+0x7] */
            ii(0x19_be62, 3);  mov(memw[ss, bp - 12], ax);             /* mov [bp-0xc], ax */
            ii(0x19_be65, 3);  mov(memw[ss, bp - 10], es);             /* mov [bp-0xa], es */
            ii(0x19_be68, 3);  mov(cx, memw[ss, bp - 42]);             /* mov cx, [bp-0x2a] */
            ii(0x19_be6b, 3);  or(cx, memw[ss, bp - 44]);              /* or cx, [bp-0x2c] */
            ii(0x19_be6e, 2);  if(jnz(0x19_be73, 3)) goto l_0x19_be73; /* jnz 0xbe73 */
            ii(0x19_be70, 3);  jmp(0x19_c01e, 0x1ab); goto l_0x19_c01e;/* jmp 0xc01e */
        l_0x19_be73:
            ii(0x19_be73, 2);  mov(bx, ax);                            /* mov bx, ax */
            ii(0x19_be75, 3);  mov(cx, memw[es, bx]);                  /* mov cx, [es:bx] */
            ii(0x19_be78, 3);  mov(memw[ss, bp - 44], cx);             /* mov [bp-0x2c], cx */
            ii(0x19_be7b, 5);  mov(memw[ss, bp - 42], 0);              /* mov word [bp-0x2a], 0x0 */
            ii(0x19_be80, 1);  inc(ax);                                /* inc ax */
            ii(0x19_be81, 1);  inc(ax);                                /* inc ax */
            ii(0x19_be82, 2);  jmp(0x19_be4f, -0x35); goto l_0x19_be4f;/* jmp 0xbe4f */
        l_0x19_be84:
            ii(0x19_be84, 3);  mov(bx, memw[ss, bp - 16]);             /* mov bx, [bp-0x10] */
            ii(0x19_be87, 4);  mov(ax, memw[es, bx + 4]);              /* mov ax, [es:bx+0x4] */
            ii(0x19_be8b, 3);  mov(memw[ss, bp - 20], ax);             /* mov [bp-0x14], ax */
            ii(0x19_be8e, 3);  mov(memw[ss, bp - 18], cx);             /* mov [bp-0x12], cx */
            ii(0x19_be91, 3);  lea(ax, memw[ds, bx + 2]);              /* lea ax, [bx+0x2] */
            ii(0x19_be94, 3);  mov(memw[ss, bp - 12], ax);             /* mov [bp-0xc], ax */
            ii(0x19_be97, 3);  mov(memw[ss, bp - 10], es);             /* mov [bp-0xa], es */
            ii(0x19_be9a, 3);  lea(ax, memw[ds, bx + 6]);              /* lea ax, [bx+0x6] */
            ii(0x19_be9d, 3);  mov(memw[ss, bp - 30], ax);             /* mov [bp-0x1e], ax */
            ii(0x19_bea0, 3);  mov(memw[ss, bp - 28], es);             /* mov [bp-0x1c], es */
            ii(0x19_bea3, 4);  test(memb[ss, bp - 52], 0x10);          /* test byte [bp-0x34], 0x10 */
            ii(0x19_bea7, 2);  if(jz(0x19_bec0, 0x17)) goto l_0x19_bec0;/* jz 0xbec0 */
            ii(0x19_bea9, 2);  mov(bx, ax);                            /* mov bx, ax */
            ii(0x19_beab, 3);  mov(cx, memw[es, bx]);                  /* mov cx, [es:bx] */
            ii(0x19_beae, 4);  mov(dx, memw[es, bx + 2]);              /* mov dx, [es:bx+0x2] */
            ii(0x19_beb2, 3);  mov(memw[ss, bp - 48], cx);             /* mov [bp-0x30], cx */
            ii(0x19_beb5, 3);  mov(memw[ss, bp - 46], dx);             /* mov [bp-0x2e], dx */
            ii(0x19_beb8, 3);  add(ax, 4);                             /* add ax, 0x4 */
            ii(0x19_bebb, 3);  mov(memw[ss, bp - 30], ax);             /* mov [bp-0x1e], ax */
            ii(0x19_bebe, 2);  jmp(0x19_bed2, 0x12); goto l_0x19_bed2; /* jmp 0xbed2 */
        l_0x19_bec0:
            ii(0x19_bec0, 3);  les(bx, memw[ss, bp - 30]);             /* les bx, [bp-0x1e] */
            ii(0x19_bec3, 4);  add(memw[ss, bp - 30], 2);              /* add word [bp-0x1e], 0x2 */
            ii(0x19_bec7, 3);  mov(ax, memw[es, bx]);                  /* mov ax, [es:bx] */
            ii(0x19_beca, 3);  mov(memw[ss, bp - 48], ax);             /* mov [bp-0x30], ax */
            ii(0x19_becd, 5);  mov(memw[ss, bp - 46], 0);              /* mov word [bp-0x2e], 0x0 */
        l_0x19_bed2:
            ii(0x19_bed2, 3);  mov(ax, memw[ss, bp - 42]);             /* mov ax, [bp-0x2a] */
            ii(0x19_bed5, 3);  or(ax, memw[ss, bp - 44]);              /* or ax, [bp-0x2c] */
            ii(0x19_bed8, 2);  if(jz(0x19_bee0, 6)) goto l_0x19_bee0;  /* jz 0xbee0 */
            ii(0x19_beda, 4);  test(memb[ss, bp - 52], 0x20);          /* test byte [bp-0x34], 0x20 */
            ii(0x19_bede, 2);  if(jnz(0x19_bee3, 3)) goto l_0x19_bee3; /* jnz 0xbee3 */
        l_0x19_bee0:
            ii(0x19_bee0, 3);  jmp(0x19_c004, 0x121); goto l_0x19_c004;/* jmp 0xc004 */
        l_0x19_bee3:
            ii(0x19_bee3, 3);  les(bx, memw[ss, bp - 30]);             /* les bx, [bp-0x1e] */
            ii(0x19_bee6, 4);  add(memw[ss, bp - 30], 4);              /* add word [bp-0x1e], 0x4 */
        l_0x19_beea:
            ii(0x19_beea, 3);  mov(ax, memw[es, bx]);                  /* mov ax, [es:bx] */
            ii(0x19_beed, 4);  mov(dx, memw[es, bx + 2]);              /* mov dx, [es:bx+0x2] */
            ii(0x19_bef1, 3);  mov(memw[ss, bp - 44], ax);             /* mov [bp-0x2c], ax */
            ii(0x19_bef4, 3);  mov(memw[ss, bp - 42], dx);             /* mov [bp-0x2a], dx */
            ii(0x19_bef7, 3);  jmp(0x19_c01e, 0x124); goto l_0x19_c01e;/* jmp 0xc01e */
        l_0x19_befa:
            ii(0x19_befa, 3);  cmp(memw[ss, bp - 50], cx);             /* cmp [bp-0x32], cx */
            ii(0x19_befd, 2);  if(jnz(0x19_bf02, 3)) goto l_0x19_bf02; /* jnz 0xbf02 */
            ii(0x19_beff, 3);  jmp(0x19_bf89, 0x87); goto l_0x19_bf89; /* jmp 0xbf89 */
        l_0x19_bf02:
            ii(0x19_bf02, 3);  mov(bx, memw[ss, bp - 16]);             /* mov bx, [bp-0x10] */
            ii(0x19_bf05, 4);  mov(al, memb[es, bx + 3]);              /* mov al, [es:bx+0x3] */
            ii(0x19_bf09, 2);  sub(ah, ah);                            /* sub ah, ah */
            ii(0x19_bf0b, 3);  mov(memw[ss, bp - 20], ax);             /* mov [bp-0x14], ax */
            ii(0x19_bf0e, 3);  mov(memw[ss, bp - 18], cx);             /* mov [bp-0x12], cx */
            ii(0x19_bf11, 4);  mov(al, memb[es, bx + 2]);              /* mov al, [es:bx+0x2] */
            ii(0x19_bf15, 1);  dec(ax);                                /* dec ax */
            ii(0x19_bf16, 3);  mov(memw[ss, bp - 50], ax);             /* mov [bp-0x32], ax */
            ii(0x19_bf19, 4);  test(memb[ss, bp - 52], 0x80);          /* test byte [bp-0x34], 0x80 */
            ii(0x19_bf1d, 2);  if(jz(0x19_bf30, 0x11)) goto l_0x19_bf30;/* jz 0xbf30 */
            ii(0x19_bf1f, 4);  mov(al, memb[es, bx + 4]);              /* mov al, [es:bx+0x4] */
            ii(0x19_bf23, 2);  sub(ah, ah);                            /* sub ah, ah */
            ii(0x19_bf25, 3);  mov(memw[ss, bp - 48], ax);             /* mov [bp-0x30], ax */
            ii(0x19_bf28, 3);  mov(memw[ss, bp - 46], cx);             /* mov [bp-0x2e], cx */
            ii(0x19_bf2b, 3);  lea(ax, memw[ds, bx + 5]);              /* lea ax, [bx+0x5] */
            ii(0x19_bf2e, 2);  jmp(0x19_bf56, 0x26); goto l_0x19_bf56; /* jmp 0xbf56 */
        l_0x19_bf30:
            ii(0x19_bf30, 4);  test(memb[ss, bp - 52], 0x10);          /* test byte [bp-0x34], 0x10 */
            ii(0x19_bf34, 2);  if(jz(0x19_bf49, 0x13)) goto l_0x19_bf49;/* jz 0xbf49 */
            ii(0x19_bf36, 4);  mov(ax, memw[es, bx + 4]);              /* mov ax, [es:bx+0x4] */
            ii(0x19_bf3a, 4);  mov(dx, memw[es, bx + 6]);              /* mov dx, [es:bx+0x6] */
            ii(0x19_bf3e, 3);  mov(memw[ss, bp - 48], ax);             /* mov [bp-0x30], ax */
            ii(0x19_bf41, 3);  mov(memw[ss, bp - 46], dx);             /* mov [bp-0x2e], dx */
            ii(0x19_bf44, 3);  lea(ax, memw[ds, bx + 8]);              /* lea ax, [bx+0x8] */
            ii(0x19_bf47, 2);  jmp(0x19_bf56, 0xd); goto l_0x19_bf56;  /* jmp 0xbf56 */
        l_0x19_bf49:
            ii(0x19_bf49, 4);  mov(ax, memw[es, bx + 4]);              /* mov ax, [es:bx+0x4] */
            ii(0x19_bf4d, 3);  mov(memw[ss, bp - 48], ax);             /* mov [bp-0x30], ax */
            ii(0x19_bf50, 3);  mov(memw[ss, bp - 46], cx);             /* mov [bp-0x2e], cx */
            ii(0x19_bf53, 3);  lea(ax, memw[ds, bx + 6]);              /* lea ax, [bx+0x6] */
        l_0x19_bf56:
            ii(0x19_bf56, 3);  mov(memw[ss, bp - 12], ax);             /* mov [bp-0xc], ax */
            ii(0x19_bf59, 3);  mov(memw[ss, bp - 10], es);             /* mov [bp-0xa], es */
            ii(0x19_bf5c, 3);  mov(ax, memw[ss, bp - 42]);             /* mov ax, [bp-0x2a] */
            ii(0x19_bf5f, 3);  or(ax, memw[ss, bp - 44]);              /* or ax, [bp-0x2c] */
            ii(0x19_bf62, 2);  if(jz(0x19_bf74, 0x10)) goto l_0x19_bf74;/* jz 0xbf74 */
            ii(0x19_bf64, 4);  test(memb[ss, bp - 52], 0x20);          /* test byte [bp-0x34], 0x20 */
            ii(0x19_bf68, 2);  if(jz(0x19_bf74, 0xa)) goto l_0x19_bf74;/* jz 0xbf74 */
            ii(0x19_bf6a, 3);  mov(bx, memw[ss, bp - 12]);             /* mov bx, [bp-0xc] */
            ii(0x19_bf6d, 4);  add(memw[ss, bp - 12], 4);              /* add word [bp-0xc], 0x4 */
            ii(0x19_bf71, 3);  jmp(0x19_beea, -0x8a); goto l_0x19_beea;/* jmp 0xbeea */
        l_0x19_bf74:
            ii(0x19_bf74, 3);  mov(ax, memw[ss, bp - 42]);             /* mov ax, [bp-0x2a] */
            ii(0x19_bf77, 3);  or(ax, memw[ss, bp - 44]);              /* or ax, [bp-0x2c] */
            ii(0x19_bf7a, 2);  if(jnz(0x19_bf7f, 3)) goto l_0x19_bf7f; /* jnz 0xbf7f */
            ii(0x19_bf7c, 3);  jmp(0x19_c01e, 0x9f); goto l_0x19_c01e; /* jmp 0xc01e */
        l_0x19_bf7f:
            ii(0x19_bf7f, 3);  les(bx, memw[ss, bp - 12]);             /* les bx, [bp-0xc] */
            ii(0x19_bf82, 4);  add(memw[ss, bp - 12], 2);              /* add word [bp-0xc], 0x2 */
            ii(0x19_bf86, 3);  jmp(0x19_c013, 0x8a); goto l_0x19_c013; /* jmp 0xc013 */
        l_0x19_bf89:
            ii(0x19_bf89, 3);  mov(bx, memw[ss, bp - 16]);             /* mov bx, [bp-0x10] */
            ii(0x19_bf8c, 4);  mov(al, memb[es, bx + 4]);              /* mov al, [es:bx+0x4] */
            ii(0x19_bf90, 2);  sub(ah, ah);                            /* sub ah, ah */
            ii(0x19_bf92, 3);  mov(memw[ss, bp - 20], ax);             /* mov [bp-0x14], ax */
            ii(0x19_bf95, 3);  mov(memw[ss, bp - 18], cx);             /* mov [bp-0x12], cx */
            ii(0x19_bf98, 3);  lea(ax, memw[ds, bx + 2]);              /* lea ax, [bx+0x2] */
            ii(0x19_bf9b, 3);  mov(memw[ss, bp - 12], ax);             /* mov [bp-0xc], ax */
            ii(0x19_bf9e, 3);  mov(memw[ss, bp - 10], es);             /* mov [bp-0xa], es */
            ii(0x19_bfa1, 3);  lea(ax, memw[ds, bx + 5]);              /* lea ax, [bx+0x5] */
            ii(0x19_bfa4, 3);  mov(memw[ss, bp - 30], ax);             /* mov [bp-0x1e], ax */
            ii(0x19_bfa7, 3);  mov(memw[ss, bp - 28], es);             /* mov [bp-0x1c], es */
            ii(0x19_bfaa, 4);  test(memb[ss, bp - 52], 0x80);          /* test byte [bp-0x34], 0x80 */
            ii(0x19_bfae, 2);  if(jz(0x19_bfc5, 0x15)) goto l_0x19_bfc5;/* jz 0xbfc5 */
            ii(0x19_bfb0, 2);  mov(bx, ax);                            /* mov bx, ax */
            ii(0x19_bfb2, 3);  mov(cl, memb[es, bx]);                  /* mov cl, [es:bx] */
            ii(0x19_bfb5, 2);  sub(ch, ch);                            /* sub ch, ch */
            ii(0x19_bfb7, 3);  mov(memw[ss, bp - 48], cx);             /* mov [bp-0x30], cx */
            ii(0x19_bfba, 5);  mov(memw[ss, bp - 46], 0);              /* mov word [bp-0x2e], 0x0 */
            ii(0x19_bfbf, 1);  inc(ax);                                /* inc ax */
            ii(0x19_bfc0, 3);  mov(memw[ss, bp - 30], ax);             /* mov [bp-0x1e], ax */
            ii(0x19_bfc3, 2);  jmp(0x19_bff3, 0x2e); goto l_0x19_bff3; /* jmp 0xbff3 */
        l_0x19_bfc5:
            ii(0x19_bfc5, 4);  test(memb[ss, bp - 52], 0x10);          /* test byte [bp-0x34], 0x10 */
            ii(0x19_bfc9, 2);  if(jz(0x19_bfe1, 0x16)) goto l_0x19_bfe1;/* jz 0xbfe1 */
            ii(0x19_bfcb, 3);  les(bx, memw[ss, bp - 30]);             /* les bx, [bp-0x1e] */
            ii(0x19_bfce, 4);  add(memw[ss, bp - 30], 4);              /* add word [bp-0x1e], 0x4 */
            ii(0x19_bfd2, 3);  mov(ax, memw[es, bx]);                  /* mov ax, [es:bx] */
            ii(0x19_bfd5, 4);  mov(dx, memw[es, bx + 2]);              /* mov dx, [es:bx+0x2] */
            ii(0x19_bfd9, 3);  mov(memw[ss, bp - 48], ax);             /* mov [bp-0x30], ax */
            ii(0x19_bfdc, 3);  mov(memw[ss, bp - 46], dx);             /* mov [bp-0x2e], dx */
            ii(0x19_bfdf, 2);  jmp(0x19_bff3, 0x12); goto l_0x19_bff3; /* jmp 0xbff3 */
        l_0x19_bfe1:
            ii(0x19_bfe1, 3);  les(bx, memw[ss, bp - 30]);             /* les bx, [bp-0x1e] */
            ii(0x19_bfe4, 4);  add(memw[ss, bp - 30], 2);              /* add word [bp-0x1e], 0x2 */
            ii(0x19_bfe8, 3);  mov(ax, memw[es, bx]);                  /* mov ax, [es:bx] */
            ii(0x19_bfeb, 3);  mov(memw[ss, bp - 48], ax);             /* mov [bp-0x30], ax */
            ii(0x19_bfee, 5);  mov(memw[ss, bp - 46], 0);              /* mov word [bp-0x2e], 0x0 */
        l_0x19_bff3:
            ii(0x19_bff3, 3);  mov(ax, memw[ss, bp - 42]);             /* mov ax, [bp-0x2a] */
            ii(0x19_bff6, 3);  or(ax, memw[ss, bp - 44]);              /* or ax, [bp-0x2c] */
            ii(0x19_bff9, 2);  if(jz(0x19_c004, 9)) goto l_0x19_c004;  /* jz 0xc004 */
            ii(0x19_bffb, 4);  test(memb[ss, bp - 52], 0x20);          /* test byte [bp-0x34], 0x20 */
            ii(0x19_bfff, 2);  if(jz(0x19_c004, 3)) goto l_0x19_c004;  /* jz 0xc004 */
            ii(0x19_c001, 3);  jmp(0x19_bee3, -0x121); goto l_0x19_bee3;/* jmp 0xbee3 */
        l_0x19_c004:
            ii(0x19_c004, 3);  mov(ax, memw[ss, bp - 42]);             /* mov ax, [bp-0x2a] */
            ii(0x19_c007, 3);  or(ax, memw[ss, bp - 44]);              /* or ax, [bp-0x2c] */
            ii(0x19_c00a, 2);  if(jz(0x19_c01e, 0x12)) goto l_0x19_c01e;/* jz 0xc01e */
            ii(0x19_c00c, 3);  les(bx, memw[ss, bp - 30]);             /* les bx, [bp-0x1e] */
            ii(0x19_c00f, 4);  add(memw[ss, bp - 30], 2);              /* add word [bp-0x1e], 0x2 */
        l_0x19_c013:
            ii(0x19_c013, 3);  mov(ax, memw[es, bx]);                  /* mov ax, [es:bx] */
            ii(0x19_c016, 3);  mov(memw[ss, bp - 44], ax);             /* mov [bp-0x2c], ax */
            ii(0x19_c019, 5);  mov(memw[ss, bp - 42], 0);              /* mov word [bp-0x2a], 0x0 */
        l_0x19_c01e:
            ii(0x19_c01e, 4);  test(memb[ss, bp - 52], 0x80);          /* test byte [bp-0x34], 0x80 */
            ii(0x19_c022, 2);  if(jz(0x19_c031, 0xd)) goto l_0x19_c031;/* jz 0xc031 */
            ii(0x19_c024, 3);  mov(al, memb[ss, bp - 48]);             /* mov al, [bp-0x30] */
            ii(0x19_c027, 2);  sub(ah, ah);                            /* sub ah, ah */
            ii(0x19_c029, 3);  mov(memw[ss, bp - 48], ax);             /* mov [bp-0x30], ax */
            ii(0x19_c02c, 5);  mov(memw[ss, bp - 46], 0);              /* mov word [bp-0x2e], 0x0 */
        l_0x19_c031:
            ii(0x19_c031, 3);  mov(al, memb[ss, bp - 52]);             /* mov al, [bp-0x34] */
            ii(0x19_c034, 2);  and(al, 3);                             /* and al, 0x3 */
            ii(0x19_c036, 2);  cmp(al, 1);                             /* cmp al, 0x1 */
            ii(0x19_c038, 2);  if(jnz(0x19_c05b, 0x21)) goto l_0x19_c05b;/* jnz 0xc05b */
            ii(0x19_c03a, 3);  push(memw[ss, bp + 22]);                /* push word [bp+0x16] */
            ii(0x19_c03d, 3);  push(memw[ss, bp + 20]);                /* push word [bp+0x14] */
            ii(0x19_c040, 3);  push(memw[ss, bp - 18]);                /* push word [bp-0x12] */
            ii(0x19_c043, 3);  push(memw[ss, bp - 20]);                /* push word [bp-0x14] */
            ii(0x19_c046, 3);  push(memw[ss, bp - 46]);                /* push word [bp-0x2e] */
            ii(0x19_c049, 3);  push(memw[ss, bp - 48]);                /* push word [bp-0x30] */
            ii(0x19_c04c, 3);  lea(ax, memw[ss, bp - 40]);             /* lea ax, [bp-0x28] */
            ii(0x19_c04f, 1);  push(ss);                               /* push ss */
            ii(0x19_c050, 1);  push(ax);                               /* push ax */
            ii(0x19_c051, 3);  mov(al, memb[ss, bp - 2]);              /* mov al, [bp-0x2] */
            ii(0x19_c054, 1);  push(ax);                               /* push ax */
            ii(0x19_c055, 3);  call(0x19_d3d8, 0x1380);                /* call 0xd3d8 */
            ii(0x19_c058, 3);  jmp(0x19_bddf, -0x27c); goto l_0x19_bddf;/* jmp 0xbddf */
        l_0x19_c05b:
            ii(0x19_c05b, 3);  push(memw[ss, bp + 22]);                /* push word [bp+0x16] */
            ii(0x19_c05e, 3);  push(memw[ss, bp + 20]);                /* push word [bp+0x14] */
            ii(0x19_c061, 3);  push(memw[ss, bp - 18]);                /* push word [bp-0x12] */
            ii(0x19_c064, 3);  push(memw[ss, bp - 20]);                /* push word [bp-0x14] */
            ii(0x19_c067, 3);  push(memw[ss, bp - 46]);                /* push word [bp-0x2e] */
            ii(0x19_c06a, 3);  push(memw[ss, bp - 48]);                /* push word [bp-0x30] */
            ii(0x19_c06d, 3);  lea(ax, memw[ss, bp - 40]);             /* lea ax, [bp-0x28] */
            ii(0x19_c070, 1);  push(ss);                               /* push ss */
            ii(0x19_c071, 1);  push(ax);                               /* push ax */
            ii(0x19_c072, 3);  mov(al, memb[ss, bp - 2]);              /* mov al, [bp-0x2] */
            ii(0x19_c075, 1);  push(ax);                               /* push ax */
            ii(0x19_c076, 3);  call(0x19_d295, 0x121c);                /* call 0xd295 */
            ii(0x19_c079, 3);  jmp(0x19_bddf, -0x29d); goto l_0x19_bddf;/* jmp 0xbddf */
        l_0x19_c07c:
            ii(0x19_c07c, 3);  cmp(memw[ss, bp - 50], cx);             /* cmp [bp-0x32], cx */
            ii(0x19_c07f, 2);  if(jz(0x19_c0d4, 0x53)) goto l_0x19_c0d4;/* jz 0xc0d4 */
            ii(0x19_c081, 3);  mov(bx, memw[ss, bp - 16]);             /* mov bx, [bp-0x10] */
            ii(0x19_c084, 4);  mov(al, memb[es, bx + 2]);              /* mov al, [es:bx+0x2] */
            ii(0x19_c088, 2);  sub(ah, ah);                            /* sub ah, ah */
            ii(0x19_c08a, 1);  dec(ax);                                /* dec ax */
            ii(0x19_c08b, 3);  mov(memw[ss, bp - 50], ax);             /* mov [bp-0x32], ax */
            ii(0x19_c08e, 4);  mov(al, memb[es, bx + 3]);              /* mov al, [es:bx+0x3] */
            ii(0x19_c092, 2);  sub(ah, ah);                            /* sub ah, ah */
            ii(0x19_c094, 3);  mov(memw[ss, bp - 48], ax);             /* mov [bp-0x30], ax */
            ii(0x19_c097, 3);  mov(memw[ss, bp - 46], cx);             /* mov [bp-0x2e], cx */
            ii(0x19_c09a, 3);  lea(ax, memw[ds, bx + 4]);              /* lea ax, [bx+0x4] */
            ii(0x19_c09d, 3);  mov(memw[ss, bp - 12], ax);             /* mov [bp-0xc], ax */
            ii(0x19_c0a0, 3);  mov(memw[ss, bp - 10], es);             /* mov [bp-0xa], es */
            ii(0x19_c0a3, 3);  mov(cx, memw[ss, bp - 42]);             /* mov cx, [bp-0x2a] */
            ii(0x19_c0a6, 3);  or(cx, memw[ss, bp - 44]);              /* or cx, [bp-0x2c] */
            ii(0x19_c0a9, 2);  if(jnz(0x19_c0ae, 3)) goto l_0x19_c0ae; /* jnz 0xc0ae */
            ii(0x19_c0ab, 3);  jmp(0x19_c13f, 0x91); goto l_0x19_c13f; /* jmp 0xc13f */
        l_0x19_c0ae:
            ii(0x19_c0ae, 4);  test(memb[ss, bp - 52], 0x20);          /* test byte [bp-0x34], 0x20 */
            ii(0x19_c0b2, 2);  if(jz(0x19_c0cb, 0x17)) goto l_0x19_c0cb;/* jz 0xc0cb */
            ii(0x19_c0b4, 2);  mov(bx, ax);                            /* mov bx, ax */
            ii(0x19_c0b6, 3);  mov(cx, memw[es, bx]);                  /* mov cx, [es:bx] */
            ii(0x19_c0b9, 4);  mov(dx, memw[es, bx + 2]);              /* mov dx, [es:bx+0x2] */
            ii(0x19_c0bd, 3);  mov(memw[ss, bp - 44], cx);             /* mov [bp-0x2c], cx */
            ii(0x19_c0c0, 3);  mov(memw[ss, bp - 42], dx);             /* mov [bp-0x2a], dx */
            ii(0x19_c0c3, 3);  add(ax, 4);                             /* add ax, 0x4 */
            ii(0x19_c0c6, 3);  mov(memw[ss, bp - 12], ax);             /* mov [bp-0xc], ax */
            ii(0x19_c0c9, 2);  jmp(0x19_c13f, 0x74); goto l_0x19_c13f; /* jmp 0xc13f */
        l_0x19_c0cb:
            ii(0x19_c0cb, 3);  les(bx, memw[ss, bp - 12]);             /* les bx, [bp-0xc] */
            ii(0x19_c0ce, 4);  add(memw[ss, bp - 12], 2);              /* add word [bp-0xc], 0x2 */
            ii(0x19_c0d2, 2);  jmp(0x19_c134, 0x60); goto l_0x19_c134; /* jmp 0xc134 */
        l_0x19_c0d4:
            ii(0x19_c0d4, 3);  mov(ax, memw[ss, bp - 16]);             /* mov ax, [bp-0x10] */
            ii(0x19_c0d7, 2);  mov(dx, es);                            /* mov dx, es */
            ii(0x19_c0d9, 1);  inc(ax);                                /* inc ax */
            ii(0x19_c0da, 1);  inc(ax);                                /* inc ax */
            ii(0x19_c0db, 3);  mov(memw[ss, bp - 12], ax);             /* mov [bp-0xc], ax */
            ii(0x19_c0de, 3);  mov(memw[ss, bp - 10], dx);             /* mov [bp-0xa], dx */
            ii(0x19_c0e1, 3);  mov(ax, memw[ss, bp - 16]);             /* mov ax, [bp-0x10] */
            ii(0x19_c0e4, 3);  add(ax, 4);                             /* add ax, 0x4 */
            ii(0x19_c0e7, 3);  mov(memw[ss, bp - 30], ax);             /* mov [bp-0x1e], ax */
            ii(0x19_c0ea, 3);  mov(memw[ss, bp - 28], dx);             /* mov [bp-0x1c], dx */
            ii(0x19_c0ed, 2);  mov(bx, ax);                            /* mov bx, ax */
            ii(0x19_c0ef, 3);  mov(cl, memb[es, bx]);                  /* mov cl, [es:bx] */
            ii(0x19_c0f2, 2);  sub(ch, ch);                            /* sub ch, ch */
            ii(0x19_c0f4, 3);  mov(memw[ss, bp - 48], cx);             /* mov [bp-0x30], cx */
            ii(0x19_c0f7, 5);  mov(memw[ss, bp - 46], 0);              /* mov word [bp-0x2e], 0x0 */
            ii(0x19_c0fc, 1);  inc(ax);                                /* inc ax */
            ii(0x19_c0fd, 3);  mov(memw[ss, bp - 30], ax);             /* mov [bp-0x1e], ax */
            ii(0x19_c100, 3);  mov(cx, memw[ss, bp - 42]);             /* mov cx, [bp-0x2a] */
            ii(0x19_c103, 3);  or(cx, memw[ss, bp - 44]);              /* or cx, [bp-0x2c] */
            ii(0x19_c106, 2);  if(jz(0x19_c125, 0x1d)) goto l_0x19_c125;/* jz 0xc125 */
            ii(0x19_c108, 4);  test(memb[ss, bp - 52], 0x20);          /* test byte [bp-0x34], 0x20 */
            ii(0x19_c10c, 2);  if(jz(0x19_c125, 0x17)) goto l_0x19_c125;/* jz 0xc125 */
            ii(0x19_c10e, 2);  mov(bx, ax);                            /* mov bx, ax */
            ii(0x19_c110, 3);  mov(cx, memw[es, bx]);                  /* mov cx, [es:bx] */
            ii(0x19_c113, 4);  mov(si, memw[es, bx + 2]);              /* mov si, [es:bx+0x2] */
            ii(0x19_c117, 3);  mov(memw[ss, bp - 44], cx);             /* mov [bp-0x2c], cx */
            ii(0x19_c11a, 3);  mov(memw[ss, bp - 42], si);             /* mov [bp-0x2a], si */
            ii(0x19_c11d, 3);  add(ax, 4);                             /* add ax, 0x4 */
            ii(0x19_c120, 3);  mov(memw[ss, bp - 30], ax);             /* mov [bp-0x1e], ax */
            ii(0x19_c123, 2);  jmp(0x19_c13f, 0x1a); goto l_0x19_c13f; /* jmp 0xc13f */
        l_0x19_c125:
            ii(0x19_c125, 3);  mov(ax, memw[ss, bp - 42]);             /* mov ax, [bp-0x2a] */
            ii(0x19_c128, 3);  or(ax, memw[ss, bp - 44]);              /* or ax, [bp-0x2c] */
            ii(0x19_c12b, 2);  if(jz(0x19_c13f, 0x12)) goto l_0x19_c13f;/* jz 0xc13f */
            ii(0x19_c12d, 3);  les(bx, memw[ss, bp - 30]);             /* les bx, [bp-0x1e] */
            ii(0x19_c130, 4);  add(memw[ss, bp - 30], 2);              /* add word [bp-0x1e], 0x2 */
        l_0x19_c134:
            ii(0x19_c134, 3);  mov(ax, memw[es, bx]);                  /* mov ax, [es:bx] */
            ii(0x19_c137, 3);  mov(memw[ss, bp - 44], ax);             /* mov [bp-0x2c], ax */
            ii(0x19_c13a, 5);  mov(memw[ss, bp - 42], 0);              /* mov word [bp-0x2a], 0x0 */
        l_0x19_c13f:
            ii(0x19_c13f, 3);  push(memw[ss, bp + 22]);                /* push word [bp+0x16] */
            ii(0x19_c142, 3);  push(memw[ss, bp + 20]);                /* push word [bp+0x14] */
            ii(0x19_c145, 3);  push(memw[ss, bp - 48]);                /* push word [bp-0x30] */
            ii(0x19_c148, 3);  lea(ax, memw[ss, bp - 40]);             /* lea ax, [bp-0x28] */
            ii(0x19_c14b, 1);  push(ss);                               /* push ss */
            ii(0x19_c14c, 1);  push(ax);                               /* push ax */
            ii(0x19_c14d, 3);  call(0x19_ce70, 0xd20);                 /* call 0xce70 */
            ii(0x19_c150, 3);  jmp(0x19_bddf, -0x374); goto l_0x19_bddf;/* jmp 0xbddf */
        l_0x19_c153:
            ii(0x19_c153, 3);  mov(ax, memw[ss, bp - 36]);             /* mov ax, [bp-0x24] */
            ii(0x19_c156, 3);  or(ax, memw[ss, bp - 38]);              /* or ax, [bp-0x26] */
            ii(0x19_c159, 2);  if(jnz(0x19_c167, 0xc)) goto l_0x19_c167;/* jnz 0xc167 */
            ii(0x19_c15b, 4);  cmp(memw[ss, bp - 40], 0);              /* cmp word [bp-0x28], 0x0 */
            ii(0x19_c15f, 2);  if(jnz(0x19_c167, 6)) goto l_0x19_c167; /* jnz 0xc167 */
            ii(0x19_c161, 3);  mov(ax, 0x521);                         /* mov ax, 0x521 */
            ii(0x19_c164, 3);  jmp(0x19_c1ef, 0x88); goto l_0x19_c1ef; /* jmp 0xc1ef */
        l_0x19_c167:
            ii(0x19_c167, 3);  mov(ax, memw[ss, bp - 44]);             /* mov ax, [bp-0x2c] */
            ii(0x19_c16a, 3);  mov(dx, memw[ss, bp - 42]);             /* mov dx, [bp-0x2a] */
            ii(0x19_c16d, 3);  add(memw[ss, bp - 38], ax);             /* add [bp-0x26], ax */
            ii(0x19_c170, 3);  adc(memw[ss, bp - 36], dx);             /* adc [bp-0x24], dx */
            ii(0x19_c173, 3);  push(memw[ss, bp - 10]);                /* push word [bp-0xa] */
            ii(0x19_c176, 3);  push(memw[ss, bp - 12]);                /* push word [bp-0xc] */
            ii(0x19_c179, 3);  inc(memw[ss, bp - 50]);                 /* inc word [bp-0x32] */
            ii(0x19_c17c, 3);  mov(ax, memw[ss, bp - 50]);             /* mov ax, [bp-0x32] */
            ii(0x19_c17f, 1);  push(ax);                               /* push ax */
            ii(0x19_c180, 3);  push(memw[ss, bp - 36]);                /* push word [bp-0x24] */
            ii(0x19_c183, 3);  push(memw[ss, bp - 38]);                /* push word [bp-0x26] */
            ii(0x19_c186, 3);  push(memw[ss, bp - 40]);                /* push word [bp-0x28] */
            ii(0x19_c189, 3);  push(memw[ss, bp - 4]);                 /* push word [bp-0x4] */
            ii(0x19_c18c, 3);  push(memw[ss, bp + 6]);                 /* push word [bp+0x6] */
            ii(0x19_c18f, 3);  push(memw[ss, bp + 4]);                 /* push word [bp+0x4] */
            ii(0x19_c192, 3);  push(memw[ss, bp + 10]);                /* push word [bp+0xa] */
            ii(0x19_c195, 3);  push(memw[ss, bp + 8]);                 /* push word [bp+0x8] */
            ii(0x19_c198, 1);  push(cs);                               /* push cs */
            ii(0x19_c199, 3);  call(0x19_ba47, -0x755);                /* call 0xba47 */
            ii(0x19_c19c, 3);  add(sp, 0x16);                          /* add sp, 0x16 */
            ii(0x19_c19f, 3);  mov(ax, memw[ss, bp - 12]);             /* mov ax, [bp-0xc] */
            ii(0x19_c1a2, 3);  sub(ax, memw[ss, bp - 16]);             /* sub ax, [bp-0x10] */
            ii(0x19_c1a5, 3);  mov(memw[ss, bp - 32], ax);             /* mov [bp-0x20], ax */
            ii(0x19_c1a8, 4);  cmp(memw[ss, bp - 8], 0);               /* cmp word [bp-0x8], 0x0 */
            ii(0x19_c1ac, 2);  if(jz(0x19_c1b7, 9)) goto l_0x19_c1b7;  /* jz 0xc1b7 */
            ii(0x19_c1ae, 3);  mov(cx, memw[ss, bp - 50]);             /* mov cx, [bp-0x32] */
            ii(0x19_c1b1, 2);  shl(cx, 1);                             /* shl cx, 1 */
            ii(0x19_c1b3, 2);  add(ax, cx);                            /* add ax, cx */
            ii(0x19_c1b5, 2);  jmp(0x19_c1d9, 0x22); goto l_0x19_c1d9; /* jmp 0xc1d9 */
        l_0x19_c1b7:
            ii(0x19_c1b7, 3);  mov(ax, memw[ss, bp - 28]);             /* mov ax, [bp-0x1c] */
            ii(0x19_c1ba, 3);  or(ax, memw[ss, bp - 30]);              /* or ax, [bp-0x1e] */
            ii(0x19_c1bd, 2);  if(jnz(0x19_c1d3, 0x14)) goto l_0x19_c1d3;/* jnz 0xc1d3 */
            ii(0x19_c1bf, 3);  mov(al, memb[ss, bp - 52]);             /* mov al, [bp-0x34] */
            ii(0x19_c1c2, 3);  and(ax, 0x40);                          /* and ax, 0x40 */
            ii(0x19_c1c5, 3);  cmp(ax, 1);                             /* cmp ax, 0x1 */
            ii(0x19_c1c8, 2);  sbb(ax, ax);                            /* sbb ax, ax */
            ii(0x19_c1ca, 1);  inc(ax);                                /* inc ax */
            ii(0x19_c1cb, 1);  inc(ax);                                /* inc ax */
            ii(0x19_c1cc, 1);  inc(ax);                                /* inc ax */
            ii(0x19_c1cd, 1);  inc(ax);                                /* inc ax */
            ii(0x19_c1ce, 3);  add(memw[ss, bp - 32], ax);             /* add [bp-0x20], ax */
            ii(0x19_c1d1, 2);  jmp(0x19_c1dc, 9); goto l_0x19_c1dc;    /* jmp 0xc1dc */
        l_0x19_c1d3:
            ii(0x19_c1d3, 3);  mov(ax, memw[ss, bp - 30]);             /* mov ax, [bp-0x1e] */
            ii(0x19_c1d6, 3);  sub(ax, memw[ss, bp - 16]);             /* sub ax, [bp-0x10] */
        l_0x19_c1d9:
            ii(0x19_c1d9, 3);  mov(memw[ss, bp - 32], ax);             /* mov [bp-0x20], ax */
        l_0x19_c1dc:
            ii(0x19_c1dc, 3);  mov(ax, memw[ss, bp - 32]);             /* mov ax, [bp-0x20] */
            ii(0x19_c1df, 3);  add(memw[ss, bp + 16], ax);             /* add [bp+0x10], ax */
            ii(0x19_c1e2, 2);  sub(dx, dx);                            /* sub dx, dx */
            ii(0x19_c1e4, 3);  sub(memw[ss, bp + 12], ax);             /* sub [bp+0xc], ax */
            ii(0x19_c1e7, 3);  sbb(memw[ss, bp + 14], dx);             /* sbb [bp+0xe], dx */
            ii(0x19_c1ea, 3);  jmp(0x19_bbbf, -0x62e); goto l_0x19_bbbf;/* jmp 0xbbbf */
        l_0x19_c1ed:
            ii(0x19_c1ed, 2);  sub(ax, ax);                            /* sub ax, ax */
        l_0x19_c1ef:
            ii(0x19_c1ef, 1);  pop(si);                                /* pop si */
            ii(0x19_c1f0, 1);  leave();                                /* leave */
            ii(0x19_c1f1, 3);  ret(0x14);                              /* ret 0x14 */
        }
    }
}
