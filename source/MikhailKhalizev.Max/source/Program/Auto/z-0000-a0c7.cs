using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xa0c7-f9f40226")]
        public void Method_0000_a0c7()
        {
            ii(0xa0c7, 1);  push(ax);                                  /* push ax */
            ii(0xa0c8, 1);  pusha();                                   /* pusha */
            ii(0xa0c9, 1);  push(es);                                  /* push es */
            ii(0xa0ca, 1);  push(ds);                                  /* push ds */
            ii(0xa0cb, 1);  push(ss);                                  /* push ss */
            ii(0xa0cc, 2);  push(0);                                   /* push 0x0 */
            ii(0xa0ce, 2);  mov(si, sp);                               /* mov si, sp */
            ii(0xa0d0, 1);  push(ss);                                  /* push ss */
            ii(0xa0d1, 1);  pop(ds);                                   /* pop ds */
            ii(0xa0d2, 3);  mov(bx, memw[ds, si + 26]);                /* mov bx, [si+0x1a] */
            ii(0xa0d5, 3);  mov(al, memb[cs, bx]);                     /* mov al, [cs:bx] */
            ii(0xa0d8, 2);  or(al, al);                                /* or al, al */
            ii(0xa0da, 2);  if(js(0xa0f3, 0x17)) goto l_0xa0f3;        /* js 0xa0f3 */
            ii(0xa0dc, 3);  and(ax, 0x1f);                             /* and ax, 0x1f */
            ii(0xa0df, 3);  mov(memw[ds, si + 24], ax);                /* mov [si+0x18], ax */
            ii(0xa0e2, 3);  mov(ax, memw[ds, si + 52]);                /* mov ax, [si+0x34] */
            ii(0xa0e5, 3);  mov(memw[ds, si + 14], ax);                /* mov [si+0xe], ax */
            ii(0xa0e8, 3);  mov(ax, memw[ds, si + 56]);                /* mov ax, [si+0x38] */
            ii(0xa0eb, 3);  mov(memw[ds, si + 2], ax);                 /* mov [si+0x2], ax */
            ii(0xa0ee, 3);  mov(bx, 0xa);                              /* mov bx, 0xa */
            ii(0xa0f1, 2);  jmp(0xa0ff, 0xc); goto l_0xa0ff;           /* jmp 0xa0ff */
        l_0xa0f3:
            ii(0xa0f3, 3);  and(ax, 0x1f);                             /* and ax, 0x1f */
            ii(0xa0f6, 3);  mov(memw[ds, si + 24], ax);                /* mov [si+0x18], ax */
            ii(0xa0f9, 4);  add(memw[ds, si + 14], 0xa);               /* add word [si+0xe], 0xa */
            ii(0xa0fd, 2);  xor(bx, bx);                               /* xor bx, bx */
        l_0xa0ff:
            ii(0xa0ff, 5);  les(di, memw[cs, 0x17c2]);                 /* les di, [cs:0x17c2] */
            ii(0xa104, 2);  mov(ax, di);                               /* mov ax, di */
            ii(0xa106, 1);  cld();                                     /* cld */
            ii(0xa107, 3);  mov(cx, 0xd);                              /* mov cx, 0xd */
            ii(0xa10a, 2);  rep(() => movsw());                        /* rep movsw */
            ii(0xa10c, 2);  add(si, bx);                               /* add si, bx */
            ii(0xa10e, 2);  movsd();                                   /* movsd */
            ii(0xa110, 2);  movsd();                                   /* movsd */
            ii(0xa112, 2);  movsd();                                   /* movsd */
            ii(0xa114, 2);  movsd();                                   /* movsd */
            ii(0xa116, 2);  or(bx, bx);                                /* or bx, bx */
            ii(0xa118, 2);  if(jz(0xa13d, 0x23)) goto l_0xa13d;        /* jz 0xa13d */
            ii(0xa11a, 2);  mov(si, sp);                               /* mov si, sp */
            ii(0xa11c, 3);  mov(memw[ds, si + 56], es);                /* mov [si+0x38], es */
            ii(0xa11f, 3);  mov(memw[ds, si + 52], ax);                /* mov [si+0x34], ax */
            ii(0xa122, 3);  mov(memw[ds, si + 44], cs);                /* mov [si+0x2c], cs */
            ii(0xa125, 5);  mov(memw[ds, si + 40], 0x6b51);            /* mov word [si+0x28], 0x6b51 */
            ii(0xa12a, 2);  sub(ax, ax);                               /* sub ax, ax */
            ii(0xa12c, 3);  mov(memw[ds, si + 54], ax);                /* mov [si+0x36], ax */
            ii(0xa12f, 3);  mov(memw[ds, si + 42], ax);                /* mov [si+0x2a], ax */
            ii(0xa132, 3);  add(sp, 4);                                /* add sp, 0x4 */
            ii(0xa135, 1);  pop(ds);                                   /* pop ds */
            ii(0xa136, 1);  pop(es);                                   /* pop es */
            ii(0xa137, 1);  popa();                                    /* popa */
            ii(0xa138, 3);  add(sp, 4);                                /* add sp, 0x4 */
            ii(0xa13b, 2);  retfd(); return;                           /* o32 retf */
        l_0xa13d:
            ii(0xa13d, 1);  push(es);                                  /* push es */
            ii(0xa13e, 1);  pop(ss);                                   /* pop ss */
            ii(0xa13f, 2);  mov(sp, ax);                               /* mov sp, ax */
            ii(0xa141, 1);  sti();                                     /* sti */
            ii(0xa142, 2);  mov(bp, sp);                               /* mov bp, sp */
            ii(0xa144, 4);  cmp(memw[ss, bp + 24], 0xd);               /* cmp word [bp+0x18], 0xd */
            ii(0xa148, 2);  if(jz(0xa1bd, 0x73)) goto l_0xa1bd;        /* jz 0xa1bd */
            ii(0xa14a, 5);  if(jmp_far_ind(memw[cs, 0x17be])) return;  /* jmp far word [cs:0x17be] */
            ii(0xa14f, 2);  jmp(0xa167, 0x16); goto l_0xa167;          /* jmp 0xa167 */
        //  ii(0xa151, 22);  Недостижимый код.
        l_0xa167:
            ii(0xa167, 4);  mov(ax, memw[cs, 0x208e]);                 /* mov ax, [cs:0x208e] */
            ii(0xa16b, 2);  mov(ds, ax);                               /* mov ds, ax */
            ii(0xa16d, 4);  dec(memb[ds, 0xa9e]);                      /* dec byte [0xa9e] */
            ii(0xa171, 2);  if(jz(0xa184, 0x11)) goto l_0xa184;        /* jz 0xa184 */
            ii(0xa173, 4);  mov(memw[ds, 0x996], sp);                  /* mov [0x996], sp */
            ii(0xa177, 2);  mov(cx, ss);                               /* mov cx, ss */
            ii(0xa179, 2);  cmp(ax, cx);                               /* cmp ax, cx */
            ii(0xa17b, 2);  if(jz(0xa181, 4)) goto l_0xa181;           /* jz 0xa181 */
            ii(0xa17d, 4);  mov(sp, memw[ds, 0xf50]);                  /* mov sp, [0xf50] */
        l_0xa181:
            ii(0xa181, 3);  call(0x5690, -0x4af4);                     /* call 0x5690 */
        l_0xa184:
            ii(0xa184, 3);  if(jmp_func(0xa7ec, 0x665)) return;        /* jmp 0xa7ec */
        l_0xa187:
            ii(0xa187, 3);  mov(si, memw[ss, bp + 30]);                /* mov si, [bp+0x1e] */
            ii(0xa18a, 3);  mov(ds, memw[ss, bp + 34]);                /* mov ds, [bp+0x22] */
            ii(0xa18d, 1);  lodsw();                                   /* lodsw */
            ii(0xa18e, 3);  cmp(ax, 0x5eff);                           /* cmp ax, 0x5eff */
            ii(0xa191, 2);  if(jnz(0xa1b8, 0x25)) goto l_0xa1b8;       /* jnz 0xa1b8 */
            ii(0xa193, 1);  lodsb();                                   /* lodsb */
            ii(0xa194, 1);  cbw();                                     /* cbw */
            ii(0xa195, 3);  add(ax, memw[ss, bp + 12]);                /* add ax, [bp+0xc] */
            ii(0xa198, 1);  xchg(si, ax);                              /* xchg si, ax */
            ii(0xa199, 3);  mov(ds, memw[ss, bp + 2]);                 /* mov ds, [bp+0x2] */
            ii(0xa19c, 3);  mov(bx, memw[ds, si + 2]);                 /* mov bx, [si+0x2] */
            ii(0xa19f, 3);  mov(ax, 6);                                /* mov ax, 0x6 */
            ii(0xa1a2, 2);  @int(0x31);                                /* int 0x31 */
            ii(0xa1a4, 2);  if(jb(0xa1b8, 0x12)) goto l_0xa1b8;        /* jb 0xa1b8 */
            ii(0xa1a6, 5);  mov(es, memw[cs, 0x208e]);                 /* mov es, [cs:0x208e] */
            ii(0xa1ab, 5);  mov(bx, memw[es, 0xa9c]);                  /* mov bx, [es:0xa9c] */
            ii(0xa1b0, 3);  mov(memw[ds, si + 2], bx);                 /* mov [si+0x2], bx */
            ii(0xa1b3, 1);  inc(ax);                                   /* inc ax */
            ii(0xa1b4, 2);  @int(0x31);                                /* int 0x31 */
            ii(0xa1b6, 2);  if(jae(0xa236, 0x7e)) goto l_0xa236;       /* jae 0xa236 */
        l_0xa1b8:
            ii(0xa1b8, 5);  if(jmp_far_ind(memw[cs, 0x17be])) return;  /* jmp far word [cs:0x17be] */
        l_0xa1bd:
            ii(0xa1bd, 4);  lsl(ax, memw[ss, bp + 34]);                /* lsl ax, [bp+0x22] */
            ii(0xa1c1, 3);  sub(ax, memw[ss, bp + 30]);                /* sub ax, [bp+0x1e] */
            ii(0xa1c4, 2);  if(jbe(0xa1b8, -0xe)) goto l_0xa1b8;       /* jbe 0xa1b8 */
            ii(0xa1c6, 4);  cmp(memw[ss, bp + 26], 0);                 /* cmp word [bp+0x1a], 0x0 */
            ii(0xa1ca, 2);  if(jnz(0xa187, -0x45)) goto l_0xa187;      /* jnz 0xa187 */
            ii(0xa1cc, 3);  sub(ax, 4);                                /* sub ax, 0x4 */
            ii(0xa1cf, 2);  if(jbe(0xa1b8, -0x19)) goto l_0xa1b8;      /* jbe 0xa1b8 */
            ii(0xa1d1, 3);  mov(cx, memw[ss, bp + 4]);                 /* mov cx, [bp+0x4] */
            ii(0xa1d4, 2);  if(jcxz(0xa1b8, -0x1e)) goto l_0xa1b8;     /* jcxz 0xa1b8 */
            ii(0xa1d6, 3);  lsl(bx, cx);                               /* lsl bx, cx */
            ii(0xa1d9, 2);  mov(es, cx);                               /* mov es, cx */
            ii(0xa1db, 3);  mov(si, memw[ss, bp + 30]);                /* mov si, [bp+0x1e] */
            ii(0xa1de, 3);  mov(ds, memw[ss, bp + 34]);                /* mov ds, [bp+0x22] */
            ii(0xa1e1, 1);  cld();                                     /* cld */
            ii(0xa1e2, 1);  lodsw();                                   /* lodsw */
            ii(0xa1e3, 3);  mov(cx, 2);                                /* mov cx, 0x2 */
            ii(0xa1e6, 3);  mov(di, memw[ss, bp + 10]);                /* mov di, [bp+0xa] */
            ii(0xa1e9, 2);  cmp(bx, di);                               /* cmp bx, di */
            ii(0xa1eb, 2);  if(jbe(0xa1b8, -0x35)) goto l_0xa1b8;      /* jbe 0xa1b8 */
            ii(0xa1ed, 3);  mov(bx, memw[es, di]);                     /* mov bx, [es:di] */
            ii(0xa1f0, 3);  mov(dx, memw[ss, bp + 22]);                /* mov dx, [bp+0x16] */
            ii(0xa1f3, 3);  cmp(ax, 0x489);                            /* cmp ax, 0x489 */
            ii(0xa1f6, 2);  if(jz(0xa21a, 0x22)) goto l_0xa21a;        /* jz 0xa21a */
            ii(0xa1f8, 2);  sub(dx, bx);                               /* sub dx, bx */
            ii(0xa1fa, 2);  neg(dx);                                   /* neg dx */
            ii(0xa1fc, 3);  cmp(ax, 0x429);                            /* cmp ax, 0x429 */
            ii(0xa1ff, 2);  if(jz(0xa21a, 0x19)) goto l_0xa21a;        /* jz 0xa21a */
            ii(0xa201, 1);  inc(cx);                                   /* inc cx */
            ii(0xa202, 2);  mov(dx, bx);                               /* mov dx, bx */
            ii(0xa204, 2);  mov(dl, memb[ds, si]);                     /* mov dl, [si] */
            ii(0xa206, 3);  cmp(ax, 0x4c6);                            /* cmp ax, 0x4c6 */
            ii(0xa209, 2);  if(jz(0xa21a, 0xf)) goto l_0xa21a;         /* jz 0xa21a */
            ii(0xa20b, 2);  or(dl, bl);                                /* or dl, bl */
            ii(0xa20d, 3);  cmp(ax, 0xc80);                            /* cmp ax, 0xc80 */
            ii(0xa210, 2);  if(jz(0xa21a, 8)) goto l_0xa21a;           /* jz 0xa21a */
            ii(0xa212, 1);  inc(cx);                                   /* inc cx */
            ii(0xa213, 2);  mov(dx, memw[ds, si]);                     /* mov dx, [si] */
            ii(0xa215, 3);  cmp(ax, 0x4c7);                            /* cmp ax, 0x4c7 */
            ii(0xa218, 2);  if(jnz(0xa1b8, -0x62)) goto l_0xa1b8;      /* jnz 0xa1b8 */
        l_0xa21a:
            ii(0xa21a, 3);  add(memw[ss, bp + 30], cx);                /* add [bp+0x1e], cx */
            ii(0xa21d, 3);  mov(bx, memw[ss, bp + 4]);                 /* mov bx, [bp+0x4] */
            ii(0xa220, 3);  mov(ax, 0xa);                              /* mov ax, 0xa */
            ii(0xa223, 2);  @int(0x31);                                /* int 0x31 */
            ii(0xa225, 2);  if(jb(0xa1b8, -0x6f)) goto l_0xa1b8;       /* jb 0xa1b8 */
            ii(0xa227, 2);  mov(es, ax);                               /* mov es, ax */
            ii(0xa229, 2);  mov(bx, ax);                               /* mov bx, ax */
            ii(0xa22b, 3);  mov(di, memw[ss, bp + 10]);                /* mov di, [bp+0xa] */
            ii(0xa22e, 3);  mov(memw[es, di], dx);                     /* mov [es:di], dx */
            ii(0xa231, 3);  mov(ax, 1);                                /* mov ax, 0x1 */
            ii(0xa234, 2);  @int(0x31);                                /* int 0x31 */
        l_0xa236:
            ii(0xa236, 3);  mov(es, memw[ss, bp + 2]);                 /* mov es, [bp+0x2] */
            ii(0xa239, 3);  mov(di, memw[ss, bp + 14]);                /* mov di, [bp+0xe] */
            ii(0xa23c, 1);  dec(di);                                   /* dec di */
            ii(0xa23d, 1);  dec(di);                                   /* dec di */
            ii(0xa23e, 3);  lea(si, memw[ss, bp + 38]);                /* lea si, [bp+0x26] */
            ii(0xa241, 1);  push(ss);                                  /* push ss */
            ii(0xa242, 1);  pop(ds);                                   /* pop ds */
            ii(0xa243, 1);  std();                                     /* std */
            ii(0xa244, 3);  mov(cx, 0x15);                             /* mov cx, 0x15 */
            ii(0xa247, 2);  rep(() => movsw());                        /* rep movsw */
            ii(0xa249, 2);  mov(ax, es);                               /* mov ax, es */
            ii(0xa24b, 2);  mov(ss, ax);                               /* mov ss, ax */
            ii(0xa24d, 2);  mov(sp, di);                               /* mov sp, di */
            ii(0xa24f, 3);  add(sp, 6);                                /* add sp, 0x6 */
            ii(0xa252, 1);  pop(ds);                                   /* pop ds */
            ii(0xa253, 1);  pop(es);                                   /* pop es */
            ii(0xa254, 1);  popa();                                    /* popa */
            ii(0xa255, 3);  add(sp, 6);                                /* add sp, 0x6 */
            ii(0xa258, 2);  iretd();                                   /* iretd */
        }
    }
}
