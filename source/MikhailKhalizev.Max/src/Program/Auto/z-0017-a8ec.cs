using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_a8ec-419a9f9b")]
        public void Method_0017_a8ec()
        {
            ii(0x17_a8ec, 4);  enter(0x26, 0);                         /* enter 0x26, 0x0 */
            ii(0x17_a8f0, 1);  push(di);                               /* push di */
            ii(0x17_a8f1, 1);  push(si);                               /* push si */
            ii(0x17_a8f2, 1);  push(ds);                               /* push ds */
            ii(0x17_a8f3, 3);  mov(ax, 0x3e68);                        /* mov ax, 0x3e68 */
            ii(0x17_a8f6, 2);  mov(ds, ax);                            /* mov ds, ax */
            ii(0x17_a8f8, 5);  mov(memw[ss, bp - 14], 0);              /* mov word [bp-0xe], 0x0 */
            ii(0x17_a8fd, 3);  les(bx, memw[ss, bp + 6]);              /* les bx, [bp+0x6] */
            ii(0x17_a900, 4);  mov(ax, memw[es, bx + 20]);             /* mov ax, [es:bx+0x14] */
            ii(0x17_a904, 4);  mov(dx, memw[es, bx + 22]);             /* mov dx, [es:bx+0x16] */
            ii(0x17_a908, 3);  mov(memw[ss, bp - 12], ax);             /* mov [bp-0xc], ax */
            ii(0x17_a90b, 3);  mov(memw[ss, bp - 10], dx);             /* mov [bp-0xa], dx */
            ii(0x17_a90e, 4);  mov(ax, memw[es, bx + 28]);             /* mov ax, [es:bx+0x1c] */
            ii(0x17_a912, 4);  mov(dx, memw[es, bx + 30]);             /* mov dx, [es:bx+0x1e] */
            ii(0x17_a916, 3);  mov(memw[ss, bp - 4], ax);              /* mov [bp-0x4], ax */
            ii(0x17_a919, 3);  mov(memw[ss, bp - 2], dx);              /* mov [bp-0x2], dx */
            ii(0x17_a91c, 6);  test(memw[es, bx + 10], 0xffff);        /* test word [es:bx+0xa], 0xffff */
            ii(0x17_a922, 2);  if(jz(0x17_a92c, 8)) goto l_0x17_a92c;  /* jz 0xa92c */
            ii(0x17_a924, 5);  mov(memw[ss, bp - 14], 0x8023);         /* mov word [bp-0xe], 0x8023 */
            ii(0x17_a929, 3);  jmp(0x17_aaf6, 0x1ca); goto l_0x17_aaf6;/* jmp 0xaaf6 */
        l_0x17_a92c:
            ii(0x17_a92c, 4);  mov(ax, memw[es, bx + 8]);              /* mov ax, [es:bx+0x8] */
            ii(0x17_a930, 3);  mov(memw[ss, bp - 36], ax);             /* mov [bp-0x24], ax */
            ii(0x17_a933, 1);  push(ax);                               /* push ax */
            ii(0x17_a934, 1);  push(cs);                               /* push cs */
            ii(0x17_a935, 3);  call(0x17_c79c, 0x1e64);                /* call 0xc79c */
            ii(0x17_a938, 3);  add(sp, 2);                             /* add sp, 0x2 */
            ii(0x17_a93b, 3);  mov(memw[ss, bp - 18], ax);             /* mov [bp-0x12], ax */
            ii(0x17_a93e, 3);  mov(memw[ss, bp - 16], dx);             /* mov [bp-0x10], dx */
            ii(0x17_a941, 3);  cmp(ax, 0xffff);                        /* cmp ax, 0xffff */
            ii(0x17_a944, 2);  if(jnz(0x17_a952, 0xc)) goto l_0x17_a952;/* jnz 0xa952 */
            ii(0x17_a946, 2);  cmp(dx, ax);                            /* cmp dx, ax */
            ii(0x17_a948, 2);  if(jnz(0x17_a952, 8)) goto l_0x17_a952; /* jnz 0xa952 */
            ii(0x17_a94a, 5);  mov(memw[ss, bp - 14], 0x8023);         /* mov word [bp-0xe], 0x8023 */
            ii(0x17_a94f, 3);  jmp(0x17_aaf6, 0x1a4); goto l_0x17_aaf6;/* jmp 0xaaf6 */
        l_0x17_a952:
            ii(0x17_a952, 3);  mov(ax, memw[ss, bp - 12]);             /* mov ax, [bp-0xc] */
            ii(0x17_a955, 3);  mov(dx, memw[ss, bp - 10]);             /* mov dx, [bp-0xa] */
            ii(0x17_a958, 2);  mov(al, ah);                            /* mov al, ah */
            ii(0x17_a95a, 2);  mov(ah, dl);                            /* mov ah, dl */
            ii(0x17_a95c, 2);  mov(dl, dh);                            /* mov dl, dh */
            ii(0x17_a95e, 2);  sub(dh, dh);                            /* sub dh, dh */
            ii(0x17_a960, 2);  shr(dx, 1);                             /* shr dx, 1 */
            ii(0x17_a962, 2);  rcr(ax, 1);                             /* rcr ax, 1 */
            ii(0x17_a964, 2);  shr(dx, 1);                             /* shr dx, 1 */
            ii(0x17_a966, 2);  rcr(ax, 1);                             /* rcr ax, 1 */
            ii(0x17_a968, 2);  shr(dx, 1);                             /* shr dx, 1 */
            ii(0x17_a96a, 2);  rcr(ax, 1);                             /* rcr ax, 1 */
            ii(0x17_a96c, 2);  shr(dx, 1);                             /* shr dx, 1 */
            ii(0x17_a96e, 2);  rcr(ax, 1);                             /* rcr ax, 1 */
            ii(0x17_a970, 3);  add(memw[ss, bp - 18], ax);             /* add [bp-0x12], ax */
            ii(0x17_a973, 3);  adc(memw[ss, bp - 16], dx);             /* adc [bp-0x10], dx */
            ii(0x17_a976, 3);  mov(ax, memw[ss, bp - 18]);             /* mov ax, [bp-0x12] */
            ii(0x17_a979, 3);  mov(dx, memw[ss, bp - 16]);             /* mov dx, [bp-0x10] */
            ii(0x17_a97c, 3);  add(ax, 0);                             /* add ax, 0x0 */
            ii(0x17_a97f, 3);  adc(dx, 1);                             /* adc dx, 0x1 */
            ii(0x17_a982, 2);  mov(dh, dl);                            /* mov dh, dl */
            ii(0x17_a984, 2);  mov(dl, ah);                            /* mov dl, ah */
            ii(0x17_a986, 2);  mov(ah, al);                            /* mov ah, al */
            ii(0x17_a988, 2);  sub(al, al);                            /* sub al, al */
            ii(0x17_a98a, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x17_a98c, 2);  rcl(dx, 1);                             /* rcl dx, 1 */
            ii(0x17_a98e, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x17_a990, 2);  rcl(dx, 1);                             /* rcl dx, 1 */
            ii(0x17_a992, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x17_a994, 2);  rcl(dx, 1);                             /* rcl dx, 1 */
            ii(0x17_a996, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x17_a998, 2);  rcl(dx, 1);                             /* rcl dx, 1 */
            ii(0x17_a99a, 3);  mov(memw[ss, bp - 8], ax);              /* mov [bp-0x8], ax */
            ii(0x17_a99d, 3);  mov(memw[ss, bp - 6], dx);              /* mov [bp-0x6], dx */
            ii(0x17_a9a0, 3);  les(bx, memw[ss, bp + 6]);              /* les bx, [bp+0x6] */
            ii(0x17_a9a3, 4);  mov(cx, memw[es, bx + 24]);             /* mov cx, [es:bx+0x18] */
            ii(0x17_a9a7, 4);  mov(si, memw[es, bx + 26]);             /* mov si, [es:bx+0x1a] */
            ii(0x17_a9ab, 3);  mov(memw[ss, bp - 34], cx);             /* mov [bp-0x22], cx */
            ii(0x17_a9ae, 3);  mov(memw[ss, bp - 32], si);             /* mov [bp-0x20], si */
            ii(0x17_a9b1, 3);  add(ax, memw[ss, bp - 12]);             /* add ax, [bp-0xc] */
            ii(0x17_a9b4, 3);  adc(dx, memw[ss, bp - 10]);             /* adc dx, [bp-0xa] */
            ii(0x17_a9b7, 1);  push(dx);                               /* push dx */
            ii(0x17_a9b8, 1);  push(ax);                               /* push ax */
            ii(0x17_a9b9, 1);  push(si);                               /* push si */
            ii(0x17_a9ba, 1);  push(cx);                               /* push cx */
            ii(0x17_a9bb, 1);  push(ds);                               /* push ds */
            ii(0x17_a9bc, 3);  push(0x1355);                           /* push 0x1355 */
            ii(0x17_a9bf, 1);  nop();                                  /* nop */
            ii(0x17_a9c0, 1);  push(cs);                               /* push cs */
            ii(0x17_a9c1, 3);  call(0x18_104f, 0x668b);                /* call 0x104f */
            ii(0x17_a9c4, 3);  add(sp, 0xc);                           /* add sp, 0xc */
            ii(0x17_a9c7, 3);  les(bx, memw[ss, bp + 6]);              /* les bx, [bp+0x6] */
            ii(0x17_a9ca, 5);  and(memb[es, bx + 44], -2 /* 0xfe */);  /* and byte [es:bx+0x2c], 0xfe */
            ii(0x17_a9cf, 3);  mov(ax, memw[ss, bp - 18]);             /* mov ax, [bp-0x12] */
            ii(0x17_a9d2, 3);  mov(dx, memw[ss, bp - 16]);             /* mov dx, [bp-0x10] */
            ii(0x17_a9d5, 3);  mov(memw[ss, bp - 22], ax);             /* mov [bp-0x16], ax */
            ii(0x17_a9d8, 3);  mov(memw[ss, bp - 20], dx);             /* mov [bp-0x14], dx */
            ii(0x17_a9db, 2);  sub(ax, ax);                            /* sub ax, ax */
            ii(0x17_a9dd, 3);  mov(memw[ss, bp - 24], ax);             /* mov [bp-0x18], ax */
            ii(0x17_a9e0, 3);  mov(memw[ss, bp - 26], ax);             /* mov [bp-0x1a], ax */
            ii(0x17_a9e3, 2);  jmp(0x17_a9f6, 0x11); goto l_0x17_a9f6; /* jmp 0xa9f6 */
        //  ii(0x17_a9e5, 1);  nop();                                  /* nop */
        l_0x17_a9e6:
            ii(0x17_a9e6, 4);  add(memw[ss, bp - 26], 1);              /* add word [bp-0x1a], 0x1 */
            ii(0x17_a9ea, 4);  adc(memw[ss, bp - 24], 0);              /* adc word [bp-0x18], 0x0 */
            ii(0x17_a9ee, 4);  add(memw[ss, bp - 22], 1);              /* add word [bp-0x16], 0x1 */
            ii(0x17_a9f2, 4);  adc(memw[ss, bp - 20], 0);              /* adc word [bp-0x14], 0x0 */
        l_0x17_a9f6:
            ii(0x17_a9f6, 3);  mov(ax, memw[ss, bp - 4]);              /* mov ax, [bp-0x4] */
            ii(0x17_a9f9, 3);  mov(dx, memw[ss, bp - 2]);              /* mov dx, [bp-0x2] */
            ii(0x17_a9fc, 3);  cmp(memw[ss, bp - 24], dx);             /* cmp [bp-0x18], dx */
            ii(0x17_a9ff, 2);  if(ja(0x17_aa54, 0x53)) goto l_0x17_aa54;/* ja 0xaa54 */
            ii(0x17_aa01, 2);  if(jb(0x17_aa08, 5)) goto l_0x17_aa08;  /* jb 0xaa08 */
            ii(0x17_aa03, 3);  cmp(memw[ss, bp - 26], ax);             /* cmp [bp-0x1a], ax */
            ii(0x17_aa06, 2);  if(jae(0x17_aa54, 0x4c)) goto l_0x17_aa54;/* jae 0xaa54 */
        l_0x17_aa08:
            ii(0x17_aa08, 3);  push(memw[ss, bp - 20]);                /* push word [bp-0x14] */
            ii(0x17_aa0b, 3);  push(memw[ss, bp - 22]);                /* push word [bp-0x16] */
            ii(0x17_aa0e, 4);  push(memw[ds, 0x1fa6]);                 /* push word [0x1fa6] */
            ii(0x17_aa12, 4);  push(memw[ds, 0x1fa4]);                 /* push word [0x1fa4] */
            ii(0x17_aa16, 3);  call(0x17_90c4, -0x1955);               /* call 0x90c4 */
            ii(0x17_aa19, 3);  add(sp, 8);                             /* add sp, 0x8 */
            ii(0x17_aa1c, 3);  mov(memw[ss, bp - 38], ax);             /* mov [bp-0x26], ax */
            ii(0x17_aa1f, 2);  or(ax, ax);                             /* or ax, ax */
            ii(0x17_aa21, 2);  if(jnz(0x17_aa2e, 0xb)) goto l_0x17_aa2e;/* jnz 0xaa2e */
            ii(0x17_aa23, 5);  mov(memw[ss, bp - 14], 0x8002);         /* mov word [bp-0xe], 0x8002 */
            ii(0x17_aa28, 3);  jmp(0x17_aaf6, 0xcb); goto l_0x17_aaf6; /* jmp 0xaaf6 */
        //  ii(0x17_aa2b, 2);  jmp(0x17_aa51, 0x24); goto l_0x17_aa51; /* jmp 0xaa51 */
        //  ii(0x17_aa2d, 1);  nop();                                  /* nop */
        l_0x17_aa2e:
            ii(0x17_aa2e, 3);  mov(al, memb[ds, 0x51a6]);              /* mov al, [0x51a6] */
            ii(0x17_aa31, 2);  sub(ah, ah);                            /* sub ah, ah */
            ii(0x17_aa33, 3);  cmp(ax, memw[ss, bp - 38]);             /* cmp ax, [bp-0x26] */
            ii(0x17_aa36, 2);  if(jz(0x17_aa51, 0x19)) goto l_0x17_aa51;/* jz 0xaa51 */
            ii(0x17_aa38, 3);  mov(al, memb[ds, 0x51b5]);              /* mov al, [0x51b5] */
            ii(0x17_aa3b, 3);  cmp(ax, memw[ss, bp - 38]);             /* cmp ax, [bp-0x26] */
            ii(0x17_aa3e, 2);  if(jz(0x17_aa51, 0x11)) goto l_0x17_aa51;/* jz 0xaa51 */
            ii(0x17_aa40, 2);  push(0);                                /* push 0x0 */
            ii(0x17_aa42, 2);  push(1);                                /* push 0x1 */
            ii(0x17_aa44, 3);  push(memw[ss, bp - 20]);                /* push word [bp-0x14] */
            ii(0x17_aa47, 3);  push(memw[ss, bp - 22]);                /* push word [bp-0x16] */
            ii(0x17_aa4a, 1);  push(cs);                               /* push cs */
            ii(0x17_aa4b, 3);  call(0x17_c560, 0x1b12);                /* call 0xc560 */
            ii(0x17_aa4e, 3);  add(sp, 8);                             /* add sp, 0x8 */
        l_0x17_aa51:
            ii(0x17_aa51, 2);  jmp(0x17_a9e6, -0x6d); goto l_0x17_a9e6;/* jmp 0xa9e6 */
        //  ii(0x17_aa53, 1);  nop();                                  /* nop */
        l_0x17_aa54:
            ii(0x17_aa54, 3);  mov(ax, memw[ss, bp - 18]);             /* mov ax, [bp-0x12] */
            ii(0x17_aa57, 3);  mov(dx, memw[ss, bp - 16]);             /* mov dx, [bp-0x10] */
            ii(0x17_aa5a, 3);  mov(memw[ss, bp - 22], ax);             /* mov [bp-0x16], ax */
            ii(0x17_aa5d, 3);  mov(memw[ss, bp - 20], dx);             /* mov [bp-0x14], dx */
            ii(0x17_aa60, 4);  or(memb[ss, bp - 30], 7);               /* or byte [bp-0x1e], 0x7 */
            ii(0x17_aa64, 2);  sub(ax, ax);                            /* sub ax, ax */
            ii(0x17_aa66, 3);  mov(memw[ss, bp - 24], ax);             /* mov [bp-0x18], ax */
            ii(0x17_aa69, 3);  mov(memw[ss, bp - 26], ax);             /* mov [bp-0x1a], ax */
            ii(0x17_aa6c, 2);  jmp(0x17_aa87, 0x19); goto l_0x17_aa87; /* jmp 0xaa87 */
        l_0x17_aa6e:
            ii(0x17_aa6e, 4);  add(memw[ss, bp - 26], 1);              /* add word [bp-0x1a], 0x1 */
            ii(0x17_aa72, 4);  adc(memw[ss, bp - 24], 0);              /* adc word [bp-0x18], 0x0 */
            ii(0x17_aa76, 4);  add(memw[ss, bp - 22], 1);              /* add word [bp-0x16], 0x1 */
            ii(0x17_aa7a, 4);  adc(memw[ss, bp - 20], 0);              /* adc word [bp-0x14], 0x0 */
            ii(0x17_aa7e, 5);  add(memw[ss, bp - 34], 0x1000);         /* add word [bp-0x22], 0x1000 */
            ii(0x17_aa83, 4);  adc(memw[ss, bp - 32], 0);              /* adc word [bp-0x20], 0x0 */
        l_0x17_aa87:
            ii(0x17_aa87, 3);  mov(ax, memw[ss, bp - 4]);              /* mov ax, [bp-0x4] */
            ii(0x17_aa8a, 3);  mov(dx, memw[ss, bp - 2]);              /* mov dx, [bp-0x2] */
            ii(0x17_aa8d, 3);  cmp(memw[ss, bp - 24], dx);             /* cmp [bp-0x18], dx */
            ii(0x17_aa90, 2);  if(ja(0x17_aaf0, 0x5e)) goto l_0x17_aaf0;/* ja 0xaaf0 */
            ii(0x17_aa92, 2);  if(jb(0x17_aa99, 5)) goto l_0x17_aa99;  /* jb 0xaa99 */
            ii(0x17_aa94, 3);  cmp(memw[ss, bp - 26], ax);             /* cmp [bp-0x1a], ax */
            ii(0x17_aa97, 2);  if(jae(0x17_aaf0, 0x57)) goto l_0x17_aaf0;/* jae 0xaaf0 */
        l_0x17_aa99:
            ii(0x17_aa99, 3);  mov(al, memb[ds, 0x51a6]);              /* mov al, [0x51a6] */
            ii(0x17_aa9c, 2);  sub(ah, ah);                            /* sub ah, ah */
            ii(0x17_aa9e, 1);  push(ax);                               /* push ax */
            ii(0x17_aa9f, 3);  push(memw[ss, bp - 20]);                /* push word [bp-0x14] */
            ii(0x17_aaa2, 3);  push(memw[ss, bp - 22]);                /* push word [bp-0x16] */
            ii(0x17_aaa5, 4);  push(memw[ds, 0x1fa6]);                 /* push word [0x1fa6] */
            ii(0x17_aaa9, 4);  push(memw[ds, 0x1fa4]);                 /* push word [0x1fa4] */
            ii(0x17_aaad, 3);  call(0x17_91e3, -0x18cd);               /* call 0x91e3 */
            ii(0x17_aab0, 3);  add(sp, 0xa);                           /* add sp, 0xa */
            ii(0x17_aab3, 3);  push(memw[ss, bp - 32]);                /* push word [bp-0x20] */
            ii(0x17_aab6, 3);  push(memw[ss, bp - 34]);                /* push word [bp-0x22] */
            ii(0x17_aab9, 1);  nop();                                  /* nop */
            ii(0x17_aaba, 1);  push(cs);                               /* push cs */
            ii(0x17_aabb, 3);  call(0x17_567a, -0x5444);               /* call 0x567a */
            ii(0x17_aabe, 3);  add(sp, 4);                             /* add sp, 0x4 */
            ii(0x17_aac1, 3);  and(ax, 0xf000);                        /* and ax, 0xf000 */
            ii(0x17_aac4, 3);  mov(cx, memw[ss, bp - 30]);             /* mov cx, [bp-0x1e] */
            ii(0x17_aac7, 3);  and(ch, 0xf);                           /* and ch, 0xf */
            ii(0x17_aaca, 2);  or(ax, cx);                             /* or ax, cx */
            ii(0x17_aacc, 3);  mov(memw[ss, bp - 30], ax);             /* mov [bp-0x1e], ax */
            ii(0x17_aacf, 3);  mov(memw[ss, bp - 28], dx);             /* mov [bp-0x1c], dx */
            ii(0x17_aad2, 2);  mov(dx, di);                            /* mov dx, di */
            ii(0x17_aad4, 4);  mov(es, memw[ds, 0xaa]);                /* mov es, [0xaa] */
            ii(0x17_aad8, 5);  mov(edi, memd[ds, 0x4f8c]);             /* mov edi, [0x4f8c] */
            ii(0x17_aadd, 4);  mov(ebx, memd[ss, bp - 22]);            /* mov ebx, [bp-0x16] */
            ii(0x17_aae1, 4);  mov(eax, memd[ss, bp - 30]);            /* mov eax, [bp-0x1e] */
            ii(0x17_aae5, 6);  mov(memd_a32[es, edi + ebx * 4], eax);  /* mov [es:edi+ebx*4], eax */
            ii(0x17_aaeb, 2);  mov(di, dx);                            /* mov di, dx */
            ii(0x17_aaed, 3);  jmp(0x17_aa6e, -0x82); goto l_0x17_aa6e;/* jmp 0xaa6e */
        l_0x17_aaf0:
            ii(0x17_aaf0, 3);  mov(eax, cr3);                          /* mov eax, cr3 */
            ii(0x17_aaf3, 3);  mov(cr3, eax);                          /* mov cr3, eax */
        l_0x17_aaf6:
            ii(0x17_aaf6, 4);  cmp(memw[ss, bp - 14], 0);              /* cmp word [bp-0xe], 0x0 */
            ii(0x17_aafa, 2);  if(jz(0x17_ab10, 0x14)) goto l_0x17_ab10;/* jz 0xab10 */
            ii(0x17_aafc, 3);  mov(ax, memw[ss, bp - 14]);             /* mov ax, [bp-0xe] */
            ii(0x17_aaff, 1);  cwd();                                  /* cwd */
            ii(0x17_ab00, 3);  les(bx, memw[ss, bp + 6]);              /* les bx, [bp+0x6] */
            ii(0x17_ab03, 4);  mov(memw[es, bx + 32], ax);             /* mov [es:bx+0x20], ax */
            ii(0x17_ab07, 4);  mov(memw[es, bx + 34], dx);             /* mov [es:bx+0x22], dx */
            ii(0x17_ab0b, 5);  or(memb[es, bx + 44], 1);               /* or byte [es:bx+0x2c], 0x1 */
        l_0x17_ab10:
            ii(0x17_ab10, 1);  pop(ds);                                /* pop ds */
            ii(0x17_ab11, 1);  pop(si);                                /* pop si */
            ii(0x17_ab12, 1);  pop(di);                                /* pop di */
            ii(0x17_ab13, 1);  leave();                                /* leave */
            ii(0x17_ab14, 1);  retf();                                 /* retf */
        }
    }
}
