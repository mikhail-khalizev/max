using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x7066-9026c58e")]
        public void Method_0000_7066()
        {
            ii(0x7066, 4);  enter(0x4a, 0);                            /* enter 0x4a, 0x0 */
            ii(0x706a, 1);  push(di);                                  /* push di */
            ii(0x706b, 1);  push(si);                                  /* push si */
            ii(0x706c, 5);  mov(memw[ss, bp - 30], 0);                 /* mov word [bp-0x1e], 0x0 */
            ii(0x7071, 5);  mov(memw[ss, bp - 68], 0);                 /* mov word [bp-0x44], 0x0 */
        l_0x7076:
            ii(0x7076, 2);  push(0x1c);                                /* push 0x1c */
            ii(0x7078, 2);  push(1);                                   /* push 0x1 */
            ii(0x707a, 3);  lea(ax, memw[ss, bp - 60]);                /* lea ax, [bp-0x3c] */
            ii(0x707d, 1);  push(ax);                                  /* push ax */
            ii(0x707e, 3);  call(0x6def, -0x292);                      /* call 0x6def */
            ii(0x7081, 3);  add(sp, 6);                                /* add sp, 0x6 */
            ii(0x7084, 2);  push(4);                                   /* push 0x4 */
            ii(0x7086, 3);  push(0x11f4);                              /* push 0x11f4 */
            ii(0x7089, 3);  call(0x9d82, 0x2cf6);                      /* call 0x9d82 */
            ii(0x708c, 1);  pop(bx);                                   /* pop bx */
            ii(0x708d, 1);  pop(bx);                                   /* pop bx */
            ii(0x708e, 5);  add(memw[ds, 0x11da], 0x30);               /* add word [0x11da], 0x30 */
            ii(0x7093, 5);  adc(memw[ds, 0x11dc], 0);                  /* adc word [0x11dc], 0x0 */
            ii(0x7098, 4);  push(memw[ds, 0x11dc]);                    /* push word [0x11dc] */
            ii(0x709c, 4);  push(memw[ds, 0x11da]);                    /* push word [0x11da] */
            ii(0x70a0, 3);  call(0x9d6a, 0x2cc7);                      /* call 0x9d6a */
            ii(0x70a3, 1);  pop(bx);                                   /* pop bx */
            ii(0x70a4, 1);  pop(bx);                                   /* pop bx */
            ii(0x70a5, 2);  push(0x10);                                /* push 0x10 */
            ii(0x70a7, 3);  lea(ax, memw[ss, bp - 22]);                /* lea ax, [bp-0x16] */
            ii(0x70aa, 1);  push(ax);                                  /* push ax */
            ii(0x70ab, 3);  call(0x9d82, 0x2cd4);                      /* call 0x9d82 */
            ii(0x70ae, 1);  pop(bx);                                   /* pop bx */
            ii(0x70af, 1);  pop(bx);                                   /* pop bx */
            ii(0x70b0, 5);  cmp(memb[ds, 0x11f1], 0);                  /* cmp byte [0x11f1], 0x0 */
            ii(0x70b5, 2);  if(jz(0x70be, 7)) goto l_0x70be;           /* jz 0x70be */
            ii(0x70b7, 3);  call(0x700c, -0xae);                       /* call 0x700c */
            ii(0x70ba, 2);  or(ax, ax);                                /* or ax, ax */
            ii(0x70bc, 2);  if(jnz(0x7076, -0x48)) goto l_0x7076;      /* jnz 0x7076 */
        l_0x70be:
            ii(0x70be, 4);  cmp(memw[ss, bp - 8], 0);                  /* cmp word [bp-0x8], 0x0 */
            ii(0x70c2, 2);  if(jz(0x70d1, 0xd)) goto l_0x70d1;         /* jz 0x70d1 */
            ii(0x70c4, 5);  cmp(memw[ds, 0xa], 0);                     /* cmp word [0xa], 0x0 */
            ii(0x70c9, 2);  if(jnz(0x70d1, 6)) goto l_0x70d1;          /* jnz 0x70d1 */
            ii(0x70cb, 3);  mov(ax, memw[ss, bp - 8]);                 /* mov ax, [bp-0x8] */
            ii(0x70ce, 3);  mov(memw[ds, 0xe], ax);                    /* mov [0xe], ax */
        l_0x70d1:
            ii(0x70d1, 3);  mov(ax, memw[ss, bp - 14]);                /* mov ax, [bp-0xe] */
            ii(0x70d4, 3);  mov(memw[ss, bp - 62], ax);                /* mov [bp-0x3e], ax */
            ii(0x70d7, 4);  cmp(ax, memw[ds, 0x97c]);                  /* cmp ax, [0x97c] */
            ii(0x70db, 2);  if(jbe(0x70e3, 6)) goto l_0x70e3;          /* jbe 0x70e3 */
            ii(0x70dd, 3);  add(ah, 2);                                /* add ah, 0x2 */
            ii(0x70e0, 3);  mov(memw[ds, 0x97c], ax);                  /* mov [0x97c], ax */
        l_0x70e3:
            ii(0x70e3, 3);  mov(ax, memw[ds, 0x97c]);                  /* mov ax, [0x97c] */
            ii(0x70e6, 3);  cmp(memw[ss, bp - 62], ax);                /* cmp [bp-0x3e], ax */
            ii(0x70e9, 2);  if(jbe(0x70f1, 6)) goto l_0x70f1;          /* jbe 0x70f1 */
            ii(0x70eb, 6);  mov(memw[ds, 0x97c], 0xffff);              /* mov word [0x97c], 0xffff */
        l_0x70f1:
            ii(0x70f1, 3);  mov(ax, memw[ss, bp - 12]);                /* mov ax, [bp-0xc] */
            ii(0x70f4, 3);  mov(memw[ds, 0x11f2], ax);                 /* mov [0x11f2], ax */
            ii(0x70f7, 3);  cmp(ax, 0x80);                             /* cmp ax, 0x80 */
            ii(0x70fa, 2);  if(jae(0x7102, 6)) goto l_0x7102;          /* jae 0x7102 */
            ii(0x70fc, 6);  mov(memw[ds, 0x11f2], 0x80);               /* mov word [0x11f2], 0x80 */
        l_0x7102:
            ii(0x7102, 4);  cmp(memw[ss, bp + 4], 0);                  /* cmp word [bp+0x4], 0x0 */
            ii(0x7106, 2);  if(jnz(0x711f, 0x17)) goto l_0x711f;       /* jnz 0x711f */
            ii(0x7108, 3);  call(0x58aa, -0x1861);                     /* call 0x58aa */
            ii(0x710b, 3);  mov(ax, memw[ss, bp - 36]);                /* mov ax, [bp-0x24] */
            ii(0x710e, 3);  mov(memw[ds, 0x97c], ax);                  /* mov [0x97c], ax */
            ii(0x7111, 3);  call(0x7726, 0x612);                       /* call 0x7726 */
            ii(0x7114, 3);  mov(al, memb[ss, bp - 10]);                /* mov al, [bp-0xa] */
            ii(0x7117, 3);  mov(memb[ds, 0x980], al);                  /* mov [0x980], al */
            ii(0x711a, 3);  call(0x9426, 0x2309);                      /* call 0x9426 */
            ii(0x711d, 2);  jmp(0x7122, 3); goto l_0x7122;             /* jmp 0x7122 */
        l_0x711f:
            ii(0x711f, 3);  call(0x7726, 0x604);                       /* call 0x7726 */
        l_0x7122:
            ii(0x7122, 4);  cmp(memw[ss, bp + 4], 0);                  /* cmp word [bp+0x4], 0x0 */
            ii(0x7126, 2);  if(jge(0x7132, 0xa)) goto l_0x7132;        /* jge 0x7132 */
            ii(0x7128, 5);  mov(memw[ss, bp + 4], 0);                  /* mov word [bp+0x4], 0x0 */
            ii(0x712d, 5);  and(memb[ds, 0x14], -9 /* 0xf7 */);        /* and byte [0x14], 0xf7 */
        l_0x7132:
            ii(0x7132, 4);  test(memb[ss, bp - 18], 2);                /* test byte [bp-0x12], 0x2 */
            ii(0x7136, 2);  if(jz(0x7142, 0xa)) goto l_0x7142;         /* jz 0x7142 */
            ii(0x7138, 5);  mov(memw[ss, bp + 4], 0xffff);             /* mov word [bp+0x4], 0xffff */
            ii(0x713d, 5);  or(memb[ds, 0x14], 8);                     /* or byte [0x14], 0x8 */
        l_0x7142:
            ii(0x7142, 4);  cmp(memw[ss, bp + 4], 0);                  /* cmp word [bp+0x4], 0x0 */
            ii(0x7146, 2);  if(jz(0x7189, 0x41)) goto l_0x7189;        /* jz 0x7189 */
            ii(0x7148, 3);  mov(ax, memw[ds, 0x11f2]);                 /* mov ax, [0x11f2] */
            ii(0x714b, 2);  neg(ax);                                   /* neg ax */
            ii(0x714d, 3);  mov(memw[ss, bp - 68], ax);                /* mov [bp-0x44], ax */
            ii(0x7150, 4);  test(memb[ss, bp - 18], 1);                /* test byte [bp-0x12], 0x1 */
            ii(0x7154, 2);  if(jz(0x717a, 0x24)) goto l_0x717a;        /* jz 0x717a */
            ii(0x7156, 3);  mov(ax, memw[ss, bp - 62]);                /* mov ax, [bp-0x3e] */
            ii(0x7159, 1);  inc(ax);                                   /* inc ax */
            ii(0x715a, 3);  shr(ax, 3);                                /* shr ax, 0x3 */
            ii(0x715d, 3);  mul(memw[ss, bp + 4]);                     /* mul word [bp+0x4] */
            ii(0x7160, 2);  neg(ax);                                   /* neg ax */
            ii(0x7162, 1);  push(ax);                                  /* push ax */
            ii(0x7163, 3);  call(0x796c, 0x806);                       /* call 0x796c */
            ii(0x7166, 1);  pop(bx);                                   /* pop bx */
            ii(0x7167, 3);  shl(ax, 3);                                /* shl ax, 0x3 */
            ii(0x716a, 3);  mov(memw[ds, 0x11f2], ax);                 /* mov [0x11f2], ax */
            ii(0x716d, 3);  mov(bx, memw[ss, bp + 6]);                 /* mov bx, [bp+0x6] */
            ii(0x7170, 3);  mov(memw[ds, bx + 8], ax);                 /* mov [bx+0x8], ax */
            ii(0x7173, 2);  or(ax, ax);                                /* or ax, ax */
            ii(0x7175, 2);  if(jnz(0x717a, 3)) goto l_0x717a;          /* jnz 0x717a */
            ii(0x7177, 3);  jmp(0x75b9, 0x43f); goto l_0x75b9;         /* jmp 0x75b9 */
        l_0x717a:
            ii(0x717a, 3);  mov(ax, memw[ds, 0x11f2]);                 /* mov ax, [0x11f2] */
            ii(0x717d, 3);  add(memw[ss, bp - 68], ax);                /* add [bp-0x44], ax */
            ii(0x7180, 3);  mov(ax, memw[ss, bp - 68]);                /* mov ax, [bp-0x44] */
            ii(0x7183, 3);  add(memw[ss, bp - 46], ax);                /* add [bp-0x2e], ax */
            ii(0x7186, 3);  add(memw[ss, bp - 38], ax);                /* add [bp-0x26], ax */
        l_0x7189:
            ii(0x7189, 3);  mov(ax, memw[ss, bp - 22]);                /* mov ax, [bp-0x16] */
            ii(0x718c, 4);  or(memw[ds, 0x14], ax);                    /* or [0x14], ax */
            ii(0x7190, 3);  mov(ax, memw[ds, 0x11da]);                 /* mov ax, [0x11da] */
            ii(0x7193, 4);  mov(dx, memw[ds, 0x11dc]);                 /* mov dx, [0x11dc] */
            ii(0x7197, 3);  add(ax, 0x80);                             /* add ax, 0x80 */
            ii(0x719a, 3);  adc(dx, 0);                                /* adc dx, 0x0 */
            ii(0x719d, 1);  push(dx);                                  /* push dx */
            ii(0x719e, 1);  push(ax);                                  /* push ax */
            ii(0x719f, 3);  call(0x9d6a, 0x2bc8);                      /* call 0x9d6a */
            ii(0x71a2, 1);  pop(bx);                                   /* pop bx */
            ii(0x71a3, 1);  pop(bx);                                   /* pop bx */
            ii(0x71a4, 3);  call(0x572a, -0x1a7d);                     /* call 0x572a */
            ii(0x71a7, 3);  mov(ax, memw[ss, bp - 62]);                /* mov ax, [bp-0x3e] */
            ii(0x71aa, 3);  sub(ax, 0x7f);                             /* sub ax, 0x7f */
            ii(0x71ad, 3);  mov(memw[ds, 0x11ee], ax);                 /* mov [0x11ee], ax */
            ii(0x71b0, 1);  push(ax);                                  /* push ax */
            ii(0x71b1, 4);  push(memw[ds, 0x11f2]);                    /* push word [0x11f2] */
            ii(0x71b5, 2);  push(8);                                   /* push 0x8 */
            ii(0x71b7, 3);  call(0x7829, 0x66f);                       /* call 0x7829 */
            ii(0x71ba, 3);  add(sp, 6);                                /* add sp, 0x6 */
            ii(0x71bd, 3);  mov(ax, memw[ds, 0x11f2]);                 /* mov ax, [0x11f2] */
            ii(0x71c0, 4);  add(memw[ds, 0x11ee], ax);                 /* add [0x11ee], ax */
            ii(0x71c4, 5);  mov(memw[ss, bp - 6], 0);                  /* mov word [bp-0x6], 0x0 */
            ii(0x71c9, 5);  mov(memw[ss, bp - 4], 8);                  /* mov word [bp-0x4], 0x8 */
            ii(0x71ce, 5);  mov(memw[ss, bp - 66], 0);                 /* mov word [bp-0x42], 0x0 */
            ii(0x71d3, 5);  mov(memw[ss, bp - 64], 0x50);              /* mov word [bp-0x40], 0x50 */
            ii(0x71d8, 3);  mov(es, memw[ss, bp - 4]);                 /* mov es, [bp-0x4] */
        l_0x71db:
            ii(0x71db, 5);  sub(memw[ds, 0x11ee], 8);                  /* sub word [0x11ee], 0x8 */
            ii(0x71e0, 4);  mov(bx, memw[ds, 0x11ee]);                 /* mov bx, [0x11ee] */
            ii(0x71e4, 3);  and(bl, 0xf8);                             /* and bl, 0xf8 */
            ii(0x71e7, 3);  add(bx, memw[ss, bp - 6]);                 /* add bx, [bp-0x6] */
            ii(0x71ea, 5);  cmp(memb[es, bx + 5], 0);                  /* cmp byte [es:bx+0x5], 0x0 */
            ii(0x71ef, 2);  if(jz(0x71db, -0x16)) goto l_0x71db;       /* jz 0x71db */
            ii(0x71f1, 3);  mov(ax, memw[ds, 0x11f2]);                 /* mov ax, [0x11f2] */
            ii(0x71f4, 3);  mov(memw[ss, bp - 24], ax);                /* mov [bp-0x18], ax */
        l_0x71f7:
            ii(0x71f7, 3);  mov(ax, memw[ss, bp - 24]);                /* mov ax, [bp-0x18] */
            ii(0x71fa, 3);  mov(memw[ss, bp - 28], ax);                /* mov [bp-0x1c], ax */
            ii(0x71fd, 2);  and(al, 0xf8);                             /* and al, 0xf8 */
            ii(0x71ff, 3);  add(ax, memw[ss, bp - 6]);                 /* add ax, [bp-0x6] */
            ii(0x7202, 3);  mov(dx, memw[ss, bp - 4]);                 /* mov dx, [bp-0x4] */
            ii(0x7205, 3);  mov(bx, 0x11e4);                           /* mov bx, 0x11e4 */
            ii(0x7208, 1);  push(si);                                  /* push si */
            ii(0x7209, 1);  push(di);                                  /* push di */
            ii(0x720a, 1);  push(ds);                                  /* push ds */
            ii(0x720b, 2);  mov(di, bx);                               /* mov di, bx */
            ii(0x720d, 2);  mov(si, ax);                               /* mov si, ax */
            ii(0x720f, 1);  push(ds);                                  /* push ds */
            ii(0x7210, 1);  pop(es);                                   /* pop es */
            ii(0x7211, 2);  mov(ds, dx);                               /* mov ds, dx */
            ii(0x7213, 1);  movsw();                                   /* movsw */
            ii(0x7214, 1);  movsw();                                   /* movsw */
            ii(0x7215, 1);  movsw();                                   /* movsw */
            ii(0x7216, 1);  movsw();                                   /* movsw */
            ii(0x7217, 1);  pop(ds);                                   /* pop ds */
            ii(0x7218, 1);  pop(di);                                   /* pop di */
            ii(0x7219, 1);  pop(si);                                   /* pop si */
            ii(0x721a, 4);  mov(si, memw[ds, 0x11e4]);                 /* mov si, [0x11e4] */
            ii(0x721e, 3);  mov(al, memb[ds, 0x11e9]);                 /* mov al, [0x11e9] */
            ii(0x7221, 2);  sub(ah, ah);                               /* sub ah, ah */
            ii(0x7223, 3);  mov(memw[ss, bp - 2], ax);                 /* mov [bp-0x2], ax */
            ii(0x7226, 2);  or(ax, ax);                                /* or ax, ax */
            ii(0x7228, 2);  if(jnz(0x722d, 3)) goto l_0x722d;          /* jnz 0x722d */
            ii(0x722a, 3);  jmp(0x744f, 0x222); goto l_0x744f;         /* jmp 0x744f */
        l_0x722d:
            ii(0x722d, 3);  mov(ax, memw[ds, 0x11ea]);                 /* mov ax, [0x11ea] */
            ii(0x7230, 3);  and(ah, 0x1f);                             /* and ah, 0x1f */
            ii(0x7233, 3);  mov(memw[ss, bp - 74], ax);                /* mov [bp-0x4a], ax */
            ii(0x7236, 2);  sub(di, di);                               /* sub di, di */
            ii(0x7238, 2);  or(si, si);                                /* or si, si */
            ii(0x723a, 2);  if(jz(0x7243, 7)) goto l_0x7243;           /* jz 0x7243 */
            ii(0x723c, 1);  push(si);                                  /* push si */
            ii(0x723d, 3);  call(0x4f7d, -0x22c3);                     /* call 0x4f7d */
            ii(0x7240, 1);  pop(bx);                                   /* pop bx */
            ii(0x7241, 2);  mov(di, ax);                               /* mov di, ax */
        l_0x7243:
            ii(0x7243, 5);  test(memb[ds, 0x11eb], 0x20);              /* test byte [0x11eb], 0x20 */
            ii(0x7248, 2);  if(jz(0x724c, 2)) goto l_0x724c;           /* jz 0x724c */
            ii(0x724a, 2);  sub(si, si);                               /* sub si, si */
        l_0x724c:
            ii(0x724c, 3);  cmp(memw[ss, bp - 74], di);                /* cmp [bp-0x4a], di */
            ii(0x724f, 2);  if(jbe(0x7254, 3)) goto l_0x7254;          /* jbe 0x7254 */
            ii(0x7251, 3);  mov(di, memw[ss, bp - 74]);                /* mov di, [bp-0x4a] */
        l_0x7254:
            ii(0x7254, 2);  sub(ax, ax);                               /* sub ax, ax */
            ii(0x7256, 3);  mov(memw[ds, 0x1204], ax);                 /* mov [0x1204], ax */
            ii(0x7259, 3);  mov(memw[ds, 0x1202], ax);                 /* mov [0x1202], ax */
            ii(0x725c, 2);  or(di, di);                                /* or di, di */
            ii(0x725e, 2);  if(jnz(0x7263, 3)) goto l_0x7263;          /* jnz 0x7263 */
            ii(0x7260, 3);  jmp(0x7368, 0x105); goto l_0x7368;         /* jmp 0x7368 */
        l_0x7263:
            ii(0x7263, 5);  test(memb[ds, 0x11eb], 0x80);              /* test byte [0x11eb], 0x80 */
            ii(0x7268, 2);  if(jnz(0x726d, 3)) goto l_0x726d;          /* jnz 0x726d */
            ii(0x726a, 3);  jmp(0x734b, 0xde); goto l_0x734b;          /* jmp 0x734b */
        l_0x726d:
            ii(0x726d, 3);  mov(ax, memw[ss, bp - 46]);                /* mov ax, [bp-0x2e] */
            ii(0x7270, 3);  cmp(memw[ss, bp - 24], ax);                /* cmp [bp-0x18], ax */
            ii(0x7273, 2);  if(jz(0x727e, 9)) goto l_0x727e;           /* jz 0x727e */
            ii(0x7275, 3);  mov(al, memb[ss, bp - 2]);                 /* mov al, [bp-0x2] */
            ii(0x7278, 2);  and(al, 0x18);                             /* and al, 0x18 */
            ii(0x727a, 2);  cmp(al, 0x18);                             /* cmp al, 0x18 */
            ii(0x727c, 2);  if(jnz(0x7285, 7)) goto l_0x7285;          /* jnz 0x7285 */
        l_0x727e:
            ii(0x727e, 5);  mov(memw[ss, bp - 32], 7);                 /* mov word [bp-0x20], 0x7 */
            ii(0x7283, 2);  jmp(0x728e, 9); goto l_0x728e;             /* jmp 0x728e */
        l_0x7285:
            ii(0x7285, 5);  mov(memw[ss, bp - 32], 0);                 /* mov word [bp-0x20], 0x0 */
            ii(0x728a, 4);  or(memb[ss, bp - 2], 0x60);                /* or byte [bp-0x2], 0x60 */
        l_0x728e:
            ii(0x728e, 3);  call(0x4f61, -0x2330);                     /* call 0x4f61 */
            ii(0x7291, 3);  mov(ax, memw[ss, bp - 32]);                /* mov ax, [bp-0x20] */
            ii(0x7294, 2);  add(ax, di);                               /* add ax, di */
            ii(0x7296, 3);  mov(memw[ss, bp - 26], ax);                /* mov [bp-0x1a], ax */
            ii(0x7299, 3);  cmp(ax, 8);                                /* cmp ax, 0x8 */
            ii(0x729c, 2);  if(jae(0x72a3, 5)) goto l_0x72a3;          /* jae 0x72a3 */
            ii(0x729e, 5);  mov(memw[ss, bp - 26], 8);                 /* mov word [bp-0x1a], 0x8 */
        l_0x72a3:
            ii(0x72a3, 3);  push(memw[ss, bp - 26]);                   /* push word [bp-0x1a] */
            ii(0x72a6, 3);  call(0x76fc, 0x453);                       /* call 0x76fc */
            ii(0x72a9, 1);  pop(bx);                                   /* pop bx */
            ii(0x72aa, 3);  mov(memw[ds, 0x1202], ax);                 /* mov [0x1202], ax */
            ii(0x72ad, 4);  mov(memw[ds, 0x1204], dx);                 /* mov [0x1204], dx */
            ii(0x72b1, 3);  mov(memw[ss, bp - 26], ax);                /* mov [bp-0x1a], ax */
            ii(0x72b4, 2);  or(ax, ax);                                /* or ax, ax */
            ii(0x72b6, 2);  if(jnz(0x72be, 6)) goto l_0x72be;          /* jnz 0x72be */
            ii(0x72b8, 2);  push(3);                                   /* push 0x3 */
            ii(0x72ba, 3);  call(0x604d, -0x1270);                     /* call 0x604d */
            ii(0x72bd, 1);  pop(bx);                                   /* pop bx */
        l_0x72be:
            ii(0x72be, 3);  mov(ax, memw[ds, 0x1202]);                 /* mov ax, [0x1202] */
            ii(0x72c1, 3);  add(ax, memw[ss, bp - 32]);                /* add ax, [bp-0x20] */
            ii(0x72c4, 3);  mov(cx, memw[ss, bp - 32]);                /* mov cx, [bp-0x20] */
            ii(0x72c7, 2);  not(cx);                                   /* not cx */
            ii(0x72c9, 2);  and(cx, ax);                               /* and cx, ax */
            ii(0x72cb, 2);  sub(ax, ax);                               /* sub ax, ax */
            ii(0x72cd, 4);  mov(memw[ds, 0x1202], cx);                 /* mov [0x1202], cx */
            ii(0x72d1, 3);  mov(memw[ds, 0x1204], ax);                 /* mov [0x1204], ax */
            ii(0x72d4, 3);  mov(memw[ss, bp - 28], cx);                /* mov [bp-0x1c], cx */
            ii(0x72d7, 4);  cmp(cx, memw[ds, 0x97c]);                  /* cmp cx, [0x97c] */
            ii(0x72db, 2);  if(jb(0x72e3, 6)) goto l_0x72e3;           /* jb 0x72e3 */
        l_0x72dd:
            ii(0x72dd, 2);  push(4);                                   /* push 0x4 */
            ii(0x72df, 3);  call(0x604d, -0x1295);                     /* call 0x604d */
            ii(0x72e2, 1);  pop(bx);                                   /* pop bx */
        l_0x72e3:
            ii(0x72e3, 3);  push(memw[ss, bp - 28]);                   /* push word [bp-0x1c] */
            ii(0x72e6, 3);  push(memw[ss, bp - 24]);                   /* push word [bp-0x18] */
            ii(0x72e9, 3);  call(0x9d4c, 0x2a60);                      /* call 0x9d4c */
            ii(0x72ec, 1);  pop(bx);                                   /* pop bx */
            ii(0x72ed, 1);  pop(bx);                                   /* pop bx */
            ii(0x72ee, 3);  mov(cx, 0x1210);                           /* mov cx, 0x1210 */
            ii(0x72f1, 3);  add(cx, 0x64);                             /* add cx, 0x64 */
            ii(0x72f4, 2);  cmp(ax, cx);                               /* cmp ax, cx */
            ii(0x72f6, 2);  if(jg(0x72fe, 6)) goto l_0x72fe;           /* jg 0x72fe */
            ii(0x72f8, 2);  push(5);                                   /* push 0x5 */
            ii(0x72fa, 3);  call(0x9dbd, 0x2ac0);                      /* call 0x9dbd */
            ii(0x72fd, 1);  pop(bx);                                   /* pop bx */
        l_0x72fe:
            ii(0x72fe, 3);  call(0x572a, -0x1bd7);                     /* call 0x572a */
            ii(0x7301, 3);  mov(bx, memw[ss, bp - 28]);                /* mov bx, [bp-0x1c] */
            ii(0x7304, 3);  and(bl, 0xf8);                             /* and bl, 0xf8 */
            ii(0x7307, 3);  add(bx, memw[ss, bp - 6]);                 /* add bx, [bp-0x6] */
            ii(0x730a, 3);  mov(es, memw[ss, bp - 4]);                 /* mov es, [bp-0x4] */
            ii(0x730d, 5);  cmp(memb[es, bx + 5], 0);                  /* cmp byte [es:bx+0x5], 0x0 */
            ii(0x7312, 2);  if(jz(0x7319, 5)) goto l_0x7319;           /* jz 0x7319 */
            ii(0x7314, 3);  call(0x4f61, -0x23b6);                     /* call 0x4f61 */
            ii(0x7317, 2);  jmp(0x72dd, -0x3c); goto l_0x72dd;         /* jmp 0x72dd */
        l_0x7319:
            ii(0x7319, 4);  cmp(memw[ss, bp - 32], 0);                 /* cmp word [bp-0x20], 0x0 */
            ii(0x731d, 2);  if(jz(0x7346, 0x27)) goto l_0x7346;        /* jz 0x7346 */
            ii(0x731f, 3);  mov(ax, memw[ss, bp - 46]);                /* mov ax, [bp-0x2e] */
            ii(0x7322, 3);  cmp(memw[ss, bp - 24], ax);                /* cmp [bp-0x18], ax */
            ii(0x7325, 2);  if(jnz(0x732d, 6)) goto l_0x732d;          /* jnz 0x732d */
            ii(0x7327, 3);  mov(ax, memw[ss, bp - 28]);                /* mov ax, [bp-0x1c] */
            ii(0x732a, 3);  mov(memw[ss, bp - 46], ax);                /* mov [bp-0x2e], ax */
        l_0x732d:
            ii(0x732d, 3);  mov(ax, memw[ss, bp - 38]);                /* mov ax, [bp-0x26] */
            ii(0x7330, 3);  cmp(memw[ss, bp - 24], ax);                /* cmp [bp-0x18], ax */
            ii(0x7333, 2);  if(jnz(0x733b, 6)) goto l_0x733b;          /* jnz 0x733b */
            ii(0x7335, 3);  mov(ax, memw[ss, bp - 28]);                /* mov ax, [bp-0x1c] */
            ii(0x7338, 3);  mov(memw[ss, bp - 38], ax);                /* mov [bp-0x26], ax */
        l_0x733b:
            ii(0x733b, 3);  push(memw[ss, bp - 26]);                   /* push word [bp-0x1a] */
            ii(0x733e, 3);  push(memw[ss, bp - 28]);                   /* push word [bp-0x1c] */
            ii(0x7341, 3);  call(0x5c21, -0x1723);                     /* call 0x5c21 */
            ii(0x7344, 1);  pop(bx);                                   /* pop bx */
            ii(0x7345, 1);  pop(bx);                                   /* pop bx */
        l_0x7346:
            ii(0x7346, 3);  inc(memw[ss, bp - 30]);                    /* inc word [bp-0x1e] */
            ii(0x7349, 2);  jmp(0x7368, 0x1d); goto l_0x7368;          /* jmp 0x7368 */
        l_0x734b:
            ii(0x734b, 1);  push(di);                                  /* push di */
            ii(0x734c, 3);  call(0x76a1, 0x352);                       /* call 0x76a1 */
            ii(0x734f, 1);  pop(bx);                                   /* pop bx */
            ii(0x7350, 3);  mov(memw[ds, 0x1202], ax);                 /* mov [0x1202], ax */
            ii(0x7353, 4);  mov(memw[ds, 0x1204], dx);                 /* mov [0x1204], dx */
            ii(0x7357, 2);  mov(ax, dx);                               /* mov ax, dx */
            ii(0x7359, 4);  or(ax, memw[ds, 0x1202]);                  /* or ax, [0x1202] */
            ii(0x735d, 2);  if(jnz(0x7368, 9)) goto l_0x7368;          /* jnz 0x7368 */
            ii(0x735f, 3);  call(0x4f61, -0x2401);                     /* call 0x4f61 */
            ii(0x7362, 2);  push(6);                                   /* push 0x6 */
            ii(0x7364, 3);  call(0x604d, -0x131a);                     /* call 0x604d */
            ii(0x7367, 1);  pop(bx);                                   /* pop bx */
        l_0x7368:
            ii(0x7368, 5);  mov(memb[ds, 0x11e9], 0xf2);               /* mov byte [0x11e9], 0xf2 */
            ii(0x736d, 6);  mov(memw[ds, 0x11e4], 0);                  /* mov word [0x11e4], 0x0 */
            ii(0x7373, 2);  or(di, di);                                /* or di, di */
            ii(0x7375, 2);  if(jz(0x7390, 0x19)) goto l_0x7390;        /* jz 0x7390 */
            ii(0x7377, 2);  mov(ax, di);                               /* mov ax, di */
            ii(0x7379, 3);  shl(ax, 4);                                /* shl ax, 0x4 */
            ii(0x737c, 1);  dec(ax);                                   /* dec ax */
            ii(0x737d, 3);  mov(memw[ds, 0x11e4], ax);                 /* mov [0x11e4], ax */
            ii(0x7380, 3);  mov(bx, memw[ss, bp - 28]);                /* mov bx, [bp-0x1c] */
            ii(0x7383, 3);  shr(bx, 3);                                /* shr bx, 0x3 */
            ii(0x7386, 3);  add(bx, memw[ss, bp - 66]);                /* add bx, [bp-0x42] */
            ii(0x7389, 3);  mov(es, memw[ss, bp - 64]);                /* mov es, [bp-0x40] */
            ii(0x738c, 4);  mov(memb[es, bx], 1);                      /* mov byte [es:bx], 0x1 */
        l_0x7390:
            ii(0x7390, 5);  test(memb[ds, 0x11eb], 0x40);              /* test byte [0x11eb], 0x40 */
            ii(0x7395, 2);  if(jz(0x73a7, 0x10)) goto l_0x73a7;        /* jz 0x73a7 */
            ii(0x7397, 3);  mov(bx, memw[ss, bp - 28]);                /* mov bx, [bp-0x1c] */
            ii(0x739a, 3);  shr(bx, 3);                                /* shr bx, 0x3 */
            ii(0x739d, 3);  add(bx, memw[ss, bp - 66]);                /* add bx, [bp-0x42] */
            ii(0x73a0, 3);  mov(es, memw[ss, bp - 64]);                /* mov es, [bp-0x40] */
            ii(0x73a3, 4);  or(memb[es, bx], 2);                       /* or byte [es:bx], 0x2 */
        l_0x73a7:
            ii(0x73a7, 3);  mov(ax, memw[ds, 0x1202]);                 /* mov ax, [0x1202] */
            ii(0x73aa, 3);  shl(ax, 4);                                /* shl ax, 0x4 */
            ii(0x73ad, 3);  mov(memw[ds, 0x11e6], ax);                 /* mov [0x11e6], ax */
            ii(0x73b0, 3);  mov(ax, memw[ds, 0x1202]);                 /* mov ax, [0x1202] */
            ii(0x73b3, 4);  mov(dx, memw[ds, 0x1204]);                 /* mov dx, [0x1204] */
            ii(0x73b7, 2);  mov(cl, 0xc);                              /* mov cl, 0xc */
            ii(0x73b9, 3);  call(0x6550, -0xe6c);                      /* call 0x6550 */
            ii(0x73bc, 3);  mov(memb[ds, 0x11e8], al);                 /* mov [0x11e8], al */
            ii(0x73bf, 3);  mov(ax, memw[ds, 0x1204]);                 /* mov ax, [0x1204] */
            ii(0x73c2, 3);  sar(ax, 4);                                /* sar ax, 0x4 */
            ii(0x73c5, 2);  mov(ah, al);                               /* mov ah, al */
            ii(0x73c7, 2);  sub(al, al);                               /* sub al, al */
            ii(0x73c9, 3);  mov(memw[ds, 0x11ea], ax);                 /* mov [0x11ea], ax */
            ii(0x73cc, 3);  mov(ax, memw[ss, bp - 28]);                /* mov ax, [bp-0x1c] */
            ii(0x73cf, 2);  and(al, 0xf8);                             /* and al, 0xf8 */
            ii(0x73d1, 3);  add(ax, memw[ss, bp - 6]);                 /* add ax, [bp-0x6] */
            ii(0x73d4, 3);  mov(dx, memw[ss, bp - 4]);                 /* mov dx, [bp-0x4] */
            ii(0x73d7, 1);  push(si);                                  /* push si */
            ii(0x73d8, 1);  push(di);                                  /* push di */
            ii(0x73d9, 2);  mov(di, ax);                               /* mov di, ax */
            ii(0x73db, 3);  mov(si, 0x11e4);                           /* mov si, 0x11e4 */
            ii(0x73de, 2);  mov(es, dx);                               /* mov es, dx */
            ii(0x73e0, 1);  movsw();                                   /* movsw */
            ii(0x73e1, 1);  movsw();                                   /* movsw */
            ii(0x73e2, 1);  movsw();                                   /* movsw */
            ii(0x73e3, 1);  movsw();                                   /* movsw */
            ii(0x73e4, 1);  pop(di);                                   /* pop di */
            ii(0x73e5, 1);  pop(si);                                   /* pop si */
            ii(0x73e6, 2);  or(si, si);                                /* or si, si */
            ii(0x73e8, 2);  if(jz(0x73fd, 0x13)) goto l_0x73fd;        /* jz 0x73fd */
            ii(0x73ea, 4);  test(si, 0xf);                             /* test si, 0xf */
            ii(0x73ee, 2);  if(jz(0x73f1, 1)) goto l_0x73f1;           /* jz 0x73f1 */
            ii(0x73f0, 1);  inc(si);                                   /* inc si */
        l_0x73f1:
            ii(0x73f1, 1);  push(si);                                  /* push si */
            ii(0x73f2, 2);  push(0);                                   /* push 0x0 */
            ii(0x73f4, 3);  push(memw[ss, bp - 28]);                   /* push word [bp-0x1c] */
            ii(0x73f7, 3);  call(0x7829, 0x42f);                       /* call 0x7829 */
            ii(0x73fa, 3);  add(sp, 6);                                /* add sp, 0x6 */
        l_0x73fd:
            ii(0x73fd, 4);  cmp(memw[ss, bp - 74], 0);                 /* cmp word [bp-0x4a], 0x0 */
            ii(0x7401, 2);  if(jz(0x741a, 0x17)) goto l_0x741a;        /* jz 0x741a */
            ii(0x7403, 3);  mov(di, memw[ss, bp - 74]);                /* mov di, [bp-0x4a] */
            ii(0x7406, 3);  shl(di, 4);                                /* shl di, 0x4 */
            ii(0x7409, 2);  sub(di, si);                               /* sub di, si */
            ii(0x740b, 2);  if(jz(0x741a, 0xd)) goto l_0x741a;         /* jz 0x741a */
            ii(0x740d, 2);  push(0);                                   /* push 0x0 */
            ii(0x740f, 1);  push(di);                                  /* push di */
            ii(0x7410, 1);  push(si);                                  /* push si */
            ii(0x7411, 3);  push(memw[ss, bp - 28]);                   /* push word [bp-0x1c] */
            ii(0x7414, 3);  call(0x5c17, -0x1800);                     /* call 0x5c17 */
            ii(0x7417, 3);  add(sp, 8);                                /* add sp, 0x8 */
        l_0x741a:
            ii(0x741a, 3);  mov(al, memb[ss, bp - 2]);                 /* mov al, [bp-0x2] */
            ii(0x741d, 3);  mov(memb[ds, 0x11e9], al);                 /* mov [0x11e9], al */
            ii(0x7420, 3);  mov(bx, memw[ss, bp - 28]);                /* mov bx, [bp-0x1c] */
            ii(0x7423, 3);  and(bl, 0xf8);                             /* and bl, 0xf8 */
            ii(0x7426, 3);  add(bx, memw[ss, bp - 6]);                 /* add bx, [bp-0x6] */
            ii(0x7429, 3);  mov(es, memw[ss, bp - 4]);                 /* mov es, [bp-0x4] */
            ii(0x742c, 4);  mov(memb[es, bx + 5], al);                 /* mov [es:bx+0x5], al */
            ii(0x7430, 3);  mov(ax, memw[ss, bp - 24]);                /* mov ax, [bp-0x18] */
            ii(0x7433, 3);  cmp(memw[ss, bp - 28], ax);                /* cmp [bp-0x1c], ax */
            ii(0x7436, 2);  if(jz(0x744f, 0x17)) goto l_0x744f;        /* jz 0x744f */
            ii(0x7438, 2);  and(al, 0xf8);                             /* and al, 0xf8 */
            ii(0x743a, 3);  add(ax, memw[ss, bp - 6]);                 /* add ax, [bp-0x6] */
            ii(0x743d, 3);  mov(dx, memw[ss, bp - 4]);                 /* mov dx, [bp-0x4] */
            ii(0x7440, 1);  push(si);                                  /* push si */
            ii(0x7441, 1);  push(di);                                  /* push di */
            ii(0x7442, 2);  mov(di, ax);                               /* mov di, ax */
            ii(0x7444, 3);  mov(si, 0x11e4);                           /* mov si, 0x11e4 */
            ii(0x7447, 2);  mov(es, dx);                               /* mov es, dx */
            ii(0x7449, 1);  movsw();                                   /* movsw */
            ii(0x744a, 1);  movsw();                                   /* movsw */
            ii(0x744b, 1);  movsw();                                   /* movsw */
            ii(0x744c, 1);  movsw();                                   /* movsw */
            ii(0x744d, 1);  pop(di);                                   /* pop di */
            ii(0x744e, 1);  pop(si);                                   /* pop si */
        l_0x744f:
            ii(0x744f, 3);  mov(ax, memw[ds, 0x11ee]);                 /* mov ax, [0x11ee] */
            ii(0x7452, 4);  add(memw[ss, bp - 24], 8);                 /* add word [bp-0x18], 0x8 */
            ii(0x7456, 3);  cmp(memw[ss, bp - 24], ax);                /* cmp [bp-0x18], ax */
            ii(0x7459, 2);  if(ja(0x745e, 3)) goto l_0x745e;           /* ja 0x745e */
            ii(0x745b, 3);  jmp(0x71f7, -0x267); goto l_0x71f7;        /* jmp 0x71f7 */
        l_0x745e:
            ii(0x745e, 4);  cmp(memw[ss, bp + 4], 0);                  /* cmp word [bp+0x4], 0x0 */
            ii(0x7462, 2);  if(jg(0x746e, 0xa)) goto l_0x746e;         /* jg 0x746e */
            ii(0x7464, 3);  shr(ax, 3);                                /* shr ax, 0x3 */
            ii(0x7467, 3);  les(bx, memw[ss, bp - 6]);                 /* les bx, [bp-0x6] */
            ii(0x746a, 4);  mov(memw[es, bx + 2], ax);                 /* mov [es:bx+0x2], ax */
        l_0x746e:
            ii(0x746e, 3);  mov(ax, memw[ss, bp - 44]);                /* mov ax, [bp-0x2c] */
            ii(0x7471, 3);  sub(ax, 0xc);                              /* sub ax, 0xc */
            ii(0x7474, 2);  and(al, 0xfe);                             /* and al, 0xfe */
            ii(0x7476, 3);  mov(bx, memw[ss, bp + 6]);                 /* mov bx, [bp+0x6] */
            ii(0x7479, 3);  mov(memw[ds, bx + 14], ax);                /* mov [bx+0xe], ax */
            ii(0x747c, 3);  mov(ax, memw[ss, bp - 46]);                /* mov ax, [bp-0x2e] */
            ii(0x747f, 3);  mov(memw[ds, bx + 2], ax);                 /* mov [bx+0x2], ax */
            ii(0x7482, 3);  mov(ax, memw[ss, bp - 38]);                /* mov ax, [bp-0x26] */
            ii(0x7485, 3);  mov(memw[ds, bx + 34], ax);                /* mov [bx+0x22], ax */
            ii(0x7488, 3);  mov(ax, memw[ss, bp - 40]);                /* mov ax, [bp-0x28] */
            ii(0x748b, 3);  mov(memw[ds, bx + 30], ax);                /* mov [bx+0x1e], ax */
            ii(0x748e, 3);  mov(ax, memw[ds, 0x11f2]);                 /* mov ax, [0x11f2] */
            ii(0x7491, 3);  mov(memw[ds, bx + 10], ax);                /* mov [bx+0xa], ax */
            ii(0x7494, 3);  mov(ax, memw[ss, bp - 24]);                /* mov ax, [bp-0x18] */
            ii(0x7497, 3);  sub(ax, 0x18);                             /* sub ax, 0x18 */
            ii(0x749a, 3);  mov(memw[ds, bx + 8], ax);                 /* mov [bx+0x8], ax */
            ii(0x749d, 3);  call(0x4f61, -0x253f);                     /* call 0x4f61 */
            ii(0x74a0, 3);  push(memw[ss, bp + 6]);                    /* push word [bp+0x6] */
            ii(0x74a3, 3);  push(memw[ss, bp + 4]);                    /* push word [bp+0x4] */
            ii(0x74a6, 3);  call(0x6d44, -0x765);                      /* call 0x6d44 */
            ii(0x74a9, 1);  pop(bx);                                   /* pop bx */
            ii(0x74aa, 1);  pop(bx);                                   /* pop bx */
            ii(0x74ab, 4);  cmp(memw[ss, bp + 4], 0);                  /* cmp word [bp+0x4], 0x0 */
            ii(0x74af, 2);  if(jl(0x74be, 0xd)) goto l_0x74be;         /* jl 0x74be */
            ii(0x74b1, 3);  call(0x9d97, 0x28e3);                      /* call 0x9d97 */
            ii(0x74b4, 2);  sub(ax, ax);                               /* sub ax, ax */
            ii(0x74b6, 3);  mov(memw[ds, 0x11dc], ax);                 /* mov [0x11dc], ax */
            ii(0x74b9, 3);  mov(memw[ds, 0x11da], ax);                 /* mov [0x11da], ax */
            ii(0x74bc, 2);  jmp(0x74cc, 0xe); goto l_0x74cc;           /* jmp 0x74cc */
        l_0x74be:
            ii(0x74be, 3);  mov(ax, memw[ds, 0x11f4]);                 /* mov ax, [0x11f4] */
            ii(0x74c1, 4);  mov(dx, memw[ds, 0x11f6]);                 /* mov dx, [0x11f6] */
            ii(0x74c5, 3);  mov(memw[ds, 0x11da], ax);                 /* mov [0x11da], ax */
            ii(0x74c8, 4);  mov(memw[ds, 0x11dc], dx);                 /* mov [0x11dc], dx */
        l_0x74cc:
            ii(0x74cc, 4);  sub(memw[ss, bp - 24], 8);                 /* sub word [bp-0x18], 0x8 */
            ii(0x74d0, 4);  cmp(memw[ss, bp - 42], 0);                 /* cmp word [bp-0x2a], 0x0 */
            ii(0x74d4, 2);  if(jz(0x7527, 0x51)) goto l_0x7527;        /* jz 0x7527 */
            ii(0x74d6, 3);  call(0x572a, -0x1daf);                     /* call 0x572a */
            ii(0x74d9, 2);  push(1);                                   /* push 0x1 */
            ii(0x74db, 3);  call(0x5006, -0x24d8);                     /* call 0x5006 */
            ii(0x74de, 1);  pop(bx);                                   /* pop bx */
            ii(0x74df, 4);  cmp(memw[ss, bp - 68], 0);                 /* cmp word [bp-0x44], 0x0 */
            ii(0x74e3, 2);  if(jz(0x750a, 0x25)) goto l_0x750a;        /* jz 0x750a */
            ii(0x74e5, 3);  push(memw[ss, bp - 68]);                   /* push word [bp-0x44] */
            ii(0x74e8, 3);  push(memw[ss, bp - 24]);                   /* push word [bp-0x18] */
            ii(0x74eb, 3);  mov(ax, memw[ss, bp - 68]);                /* mov ax, [bp-0x44] */
            ii(0x74ee, 3);  add(memw[ss, bp - 42], ax);                /* add [bp-0x2a], ax */
            ii(0x74f1, 3);  push(memw[ss, bp - 42]);                   /* push word [bp-0x2a] */
            ii(0x74f4, 3);  call(0x7b20, 0x629);                       /* call 0x7b20 */
            ii(0x74f7, 3);  add(sp, 6);                                /* add sp, 0x6 */
            ii(0x74fa, 2);  jmp(0x750a, 0xe); goto l_0x750a;           /* jmp 0x750a */
        l_0x74fc:
            ii(0x74fc, 3);  push(memw[ss, bp - 24]);                   /* push word [bp-0x18] */
            ii(0x74ff, 3);  push(memw[ss, bp - 42]);                   /* push word [bp-0x2a] */
            ii(0x7502, 3);  call(0x7bb9, 0x6b4);                       /* call 0x7bb9 */
            ii(0x7505, 1);  pop(bx);                                   /* pop bx */
            ii(0x7506, 1);  pop(bx);                                   /* pop bx */
            ii(0x7507, 3);  call(0x9d53, 0x2849);                      /* call 0x9d53 */
        l_0x750a:
            ii(0x750a, 3);  dec(memw[ss, bp - 30]);                    /* dec word [bp-0x1e] */
            ii(0x750d, 2);  if(jns(0x74fc, -0x13)) goto l_0x74fc;      /* jns 0x74fc */
            ii(0x750f, 3);  push(memw[ss, bp - 42]);                   /* push word [bp-0x2a] */
            ii(0x7512, 3);  call(0x5826, -0x1cef);                     /* call 0x5826 */
            ii(0x7515, 1);  pop(bx);                                   /* pop bx */
            ii(0x7516, 3);  mov(ax, memw[ss, bp - 42]);                /* mov ax, [bp-0x2a] */
            ii(0x7519, 3);  sub(ax, 8);                                /* sub ax, 0x8 */
            ii(0x751c, 3);  mov(bx, memw[ss, bp + 6]);                 /* mov bx, [bp+0x6] */
            ii(0x751f, 3);  mov(memw[ds, bx + 8], ax);                 /* mov [bx+0x8], ax */
            ii(0x7522, 3);  call(0x4f61, -0x25c4);                     /* call 0x4f61 */
            ii(0x7525, 2);  jmp(0x756c, 0x45); goto l_0x756c;          /* jmp 0x756c */
        l_0x7527:
            ii(0x7527, 4);  cmp(memw[ss, bp - 68], 0);                 /* cmp word [bp-0x44], 0x0 */
            ii(0x752b, 2);  if(jz(0x7538, 0xb)) goto l_0x7538;         /* jz 0x7538 */
            ii(0x752d, 3);  push(memw[ss, bp - 68]);                   /* push word [bp-0x44] */
            ii(0x7530, 3);  push(memw[ss, bp - 24]);                   /* push word [bp-0x18] */
            ii(0x7533, 3);  call(0x78c1, 0x38b);                       /* call 0x78c1 */
            ii(0x7536, 1);  pop(bx);                                   /* pop bx */
            ii(0x7537, 1);  pop(bx);                                   /* pop bx */
        l_0x7538:
            ii(0x7538, 4);  cmp(memw[ss, bp - 30], 0);                 /* cmp word [bp-0x1e], 0x0 */
            ii(0x753c, 2);  if(jle(0x756c, 0x2e)) goto l_0x756c;       /* jle 0x756c */
            ii(0x753e, 3);  push(memw[ss, bp - 24]);                   /* push word [bp-0x18] */
            ii(0x7541, 3);  call(0x59df, -0x1b65);                     /* call 0x59df */
            ii(0x7544, 1);  pop(bx);                                   /* pop bx */
            ii(0x7545, 3);  mov(al, memb[ds, 0x11e9]);                 /* mov al, [0x11e9] */
            ii(0x7548, 2);  and(al, 0x18);                             /* and al, 0x18 */
            ii(0x754a, 2);  cmp(al, 0x10);                             /* cmp al, 0x10 */
            ii(0x754c, 2);  if(jz(0x7554, 6)) goto l_0x7554;           /* jz 0x7554 */
            ii(0x754e, 2);  push(7);                                   /* push 0x7 */
            ii(0x7550, 3);  call(0x604d, -0x1506);                     /* call 0x604d */
            ii(0x7553, 1);  pop(bx);                                   /* pop bx */
        l_0x7554:
            ii(0x7554, 5);  cmp(memw[ds, 0x11e4], 0);                  /* cmp word [0x11e4], 0x0 */
            ii(0x7559, 2);  if(jz(0x756c, 0x11)) goto l_0x756c;        /* jz 0x756c */
            ii(0x755b, 2);  jmp(0x7567, 0xa); goto l_0x7567;           /* jmp 0x7567 */
        l_0x755d:
            ii(0x755d, 3);  push(memw[ss, bp - 24]);                   /* push word [bp-0x18] */
            ii(0x7560, 3);  call(0x7a3d, 0x4da);                       /* call 0x7a3d */
            ii(0x7563, 1);  pop(bx);                                   /* pop bx */
            ii(0x7564, 3);  call(0x9d53, 0x27ec);                      /* call 0x9d53 */
        l_0x7567:
            ii(0x7567, 3);  dec(memw[ss, bp - 30]);                    /* dec word [bp-0x1e] */
            ii(0x756a, 2);  if(jns(0x755d, -0xf)) goto l_0x755d;       /* jns 0x755d */
        l_0x756c:
            ii(0x756c, 4);  cmp(memw[ss, bp - 30], 0);                 /* cmp word [bp-0x1e], 0x0 */
            ii(0x7570, 2);  if(jl(0x7578, 6)) goto l_0x7578;           /* jl 0x7578 */
            ii(0x7572, 4);  test(memb[ss, bp - 18], 1);                /* test byte [bp-0x12], 0x1 */
            ii(0x7576, 2);  if(jz(0x7585, 0xd)) goto l_0x7585;         /* jz 0x7585 */
        l_0x7578:
            ii(0x7578, 4);  cmp(memw[ss, bp - 42], 0);                 /* cmp word [bp-0x2a], 0x0 */
            ii(0x757c, 2);  if(jnz(0x7585, 7)) goto l_0x7585;          /* jnz 0x7585 */
            ii(0x757e, 3);  push(memw[ss, bp - 24]);                   /* push word [bp-0x18] */
            ii(0x7581, 3);  call(0x7b02, 0x57e);                       /* call 0x7b02 */
            ii(0x7584, 1);  pop(bx);                                   /* pop bx */
        l_0x7585:
            ii(0x7585, 3);  mov(ax, 0x28);                             /* mov ax, 0x28 */
            ii(0x7588, 3);  mov(bx, memw[ss, bp + 6]);                 /* mov bx, [bp+0x6] */
            ii(0x758b, 3);  mov(memw[ds, bx + 4], ax);                 /* mov [bx+0x4], ax */
            ii(0x758e, 3);  mov(memw[ds, bx + 6], ax);                 /* mov [bx+0x6], ax */
            ii(0x7591, 5);  mov(memw[ds, bx + 38], 0x200);             /* mov word [bx+0x26], 0x200 */
            ii(0x7596, 4);  cmp(memw[ss, bp + 4], 0);                  /* cmp word [bp+0x4], 0x0 */
            ii(0x759a, 2);  if(jg(0x75b9, 0x1d)) goto l_0x75b9;        /* jg 0x75b9 */
            ii(0x759c, 3);  call(0x6d67, -0x838);                      /* call 0x6d67 */
            ii(0x759f, 3);  mov(ax, memw[ds, 0xcec]);                  /* mov ax, [0xcec] */
            ii(0x75a2, 3);  mov(memw[ds, 0x97e], ax);                  /* mov [0x97e], ax */
            ii(0x75a5, 3);  mov(cx, 0x2c);                             /* mov cx, 0x2c */
            ii(0x75a8, 2);  mov(dx, ax);                               /* mov dx, ax */
            ii(0x75aa, 3);  mov(memw[ss, bp - 72], cx);                /* mov [bp-0x48], cx */
            ii(0x75ad, 3);  mov(memw[ss, bp - 70], dx);                /* mov [bp-0x46], dx */
            ii(0x75b0, 2);  mov(es, ax);                               /* mov es, ax */
            ii(0x75b2, 2);  mov(bx, cx);                               /* mov bx, cx */
            ii(0x75b4, 5);  mov(memw[es, bx], 0x30);                   /* mov word [es:bx], 0x30 */
        l_0x75b9:
            ii(0x75b9, 1);  pop(si);                                   /* pop si */
            ii(0x75ba, 1);  pop(di);                                   /* pop di */
            ii(0x75bb, 1);  leave();                                   /* leave */
            ii(0x75bc, 1);  ret();                                     /* ret */
        }
    }
}
