using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xa877-f9f40226")]
        public void Method_0000_a877()
        {
            ii(0xa877, 1);  push(ax);                                  /* push ax */
            ii(0xa878, 1);  pusha();                                   /* pusha */
            ii(0xa879, 1);  push(es);                                  /* push es */
            ii(0xa87a, 1);  push(ds);                                  /* push ds */
            ii(0xa87b, 1);  push(ss);                                  /* push ss */
            ii(0xa87c, 2);  push(0);                                   /* push 0x0 */
            ii(0xa87e, 2);  mov(si, sp);                               /* mov si, sp */
            ii(0xa880, 1);  push(ss);                                  /* push ss */
            ii(0xa881, 1);  pop(ds);                                   /* pop ds */
            ii(0xa882, 3);  mov(bx, memw[ds, si + 26]);                /* mov bx, [si+0x1a] */
            ii(0xa885, 3);  mov(al, memb[cs, bx]);                     /* mov al, [cs:bx] */
            ii(0xa888, 2);  or(al, al);                                /* or al, al */
            ii(0xa88a, 2);  if(js(0xa8a3, 0x17)) goto l_0xa8a3;        /* js 0xa8a3 */
            ii(0xa88c, 3);  and(ax, 0x1f);                             /* and ax, 0x1f */
            ii(0xa88f, 3);  mov(memw[ds, si + 24], ax);                /* mov [si+0x18], ax */
            ii(0xa892, 3);  mov(ax, memw[ds, si + 52]);                /* mov ax, [si+0x34] */
            ii(0xa895, 3);  mov(memw[ds, si + 14], ax);                /* mov [si+0xe], ax */
            ii(0xa898, 3);  mov(ax, memw[ds, si + 56]);                /* mov ax, [si+0x38] */
            ii(0xa89b, 3);  mov(memw[ds, si + 2], ax);                 /* mov [si+0x2], ax */
            ii(0xa89e, 3);  mov(bx, 0xa);                              /* mov bx, 0xa */
            ii(0xa8a1, 2);  jmp(0xa8af, 0xc); goto l_0xa8af;           /* jmp 0xa8af */
        l_0xa8a3:
            ii(0xa8a3, 3);  and(ax, 0x1f);                             /* and ax, 0x1f */
            ii(0xa8a6, 3);  mov(memw[ds, si + 24], ax);                /* mov [si+0x18], ax */
            ii(0xa8a9, 4);  add(memw[ds, si + 14], 0xa);               /* add word [si+0xe], 0xa */
            ii(0xa8ad, 2);  xor(bx, bx);                               /* xor bx, bx */
        l_0xa8af:
            ii(0xa8af, 5);  les(di, memw[cs, 0x17c2]);                 /* les di, [cs:0x17c2] */
            ii(0xa8b4, 2);  mov(ax, di);                               /* mov ax, di */
            ii(0xa8b6, 1);  cld();                                     /* cld */
            ii(0xa8b7, 3);  mov(cx, 0xd);                              /* mov cx, 0xd */
            ii(0xa8ba, 2);  rep(() => movsw());                        /* rep movsw */
            ii(0xa8bc, 2);  add(si, bx);                               /* add si, bx */
            ii(0xa8be, 2);  movsd();                                   /* movsd */
            ii(0xa8c0, 2);  movsd();                                   /* movsd */
            ii(0xa8c2, 2);  movsd();                                   /* movsd */
            ii(0xa8c4, 2);  movsd();                                   /* movsd */
            ii(0xa8c6, 2);  or(bx, bx);                                /* or bx, bx */
            ii(0xa8c8, 2);  if(jz(0xa8ed, 0x23)) goto l_0xa8ed;        /* jz 0xa8ed */
            ii(0xa8ca, 2);  mov(si, sp);                               /* mov si, sp */
            ii(0xa8cc, 3);  mov(memw[ds, si + 56], es);                /* mov [si+0x38], es */
            ii(0xa8cf, 3);  mov(memw[ds, si + 52], ax);                /* mov [si+0x34], ax */
            ii(0xa8d2, 3);  mov(memw[ds, si + 44], cs);                /* mov [si+0x2c], cs */
            ii(0xa8d5, 5);  mov(memw[ds, si + 40], 0x6b51);            /* mov word [si+0x28], 0x6b51 */
            ii(0xa8da, 2);  sub(ax, ax);                               /* sub ax, ax */
            ii(0xa8dc, 3);  mov(memw[ds, si + 54], ax);                /* mov [si+0x36], ax */
            ii(0xa8df, 3);  mov(memw[ds, si + 42], ax);                /* mov [si+0x2a], ax */
            ii(0xa8e2, 3);  add(sp, 4);                                /* add sp, 0x4 */
            ii(0xa8e5, 1);  pop(ds);                                   /* pop ds */
            ii(0xa8e6, 1);  pop(es);                                   /* pop es */
            ii(0xa8e7, 1);  popa();                                    /* popa */
            ii(0xa8e8, 3);  add(sp, 4);                                /* add sp, 0x4 */
            ii(0xa8eb, 2);  retfd(); return;                           /* o32 retf */
        l_0xa8ed:
            ii(0xa8ed, 1);  push(es);                                  /* push es */
            ii(0xa8ee, 1);  pop(ss);                                   /* pop ss */
            ii(0xa8ef, 2);  mov(sp, ax);                               /* mov sp, ax */
            ii(0xa8f1, 1);  sti();                                     /* sti */
            ii(0xa8f2, 2);  mov(bp, sp);                               /* mov bp, sp */
            ii(0xa8f4, 4);  cmp(memw[ss, bp + 24], 0xd);               /* cmp word [bp+0x18], 0xd */
            ii(0xa8f8, 2);  if(jz(0xa96d, 0x73)) goto l_0xa96d;        /* jz 0xa96d */
            ii(0xa8fa, 5);  if(jmp_far_ind(memw[cs, 0x17be])) return;  /* jmp far word [cs:0x17be] */
            ii(0xa8ff, 2);  jmp(0xa917, 0x16); goto l_0xa917;          /* jmp 0xa917 */
        //  ii(0xa901, 2);  push(edx);                                 /* push edx */
        //  ii(0xa903, 6);  mov(edx, memd[cs, 0x6d66]);                /* mov edx, [cs:0x6d66] */
        //  ii(0xa909, 5);  mov(cx, memw[cs, 0x6d6a]);                 /* mov cx, [cs:0x6d6a] */
        //  ii(0xa90e, 2);  mov(bl, 0x21);                             /* mov bl, 0x21 */
        //  ii(0xa910, 3);  mov(ax, 0x205);                            /* mov ax, 0x205 */
        //  ii(0xa913, 2);  @int(0x31);                                /* int 0x31 */
        //  ii(0xa915, 2);  pop(edx);                                  /* pop edx */
        l_0xa917:
            ii(0xa917, 4);  mov(ax, memw[cs, 0x208e]);                 /* mov ax, [cs:0x208e] */
            ii(0xa91b, 2);  mov(ds, ax);                               /* mov ds, ax */
            ii(0xa91d, 4);  dec(memb[ds, 0xa9e]);                      /* dec byte [0xa9e] */
            ii(0xa921, 2);  if(jz(0xa934, 0x11)) goto l_0xa934;        /* jz 0xa934 */
            ii(0xa923, 4);  mov(memw[ds, 0x996], sp);                  /* mov [0x996], sp */
            ii(0xa927, 2);  mov(cx, ss);                               /* mov cx, ss */
            ii(0xa929, 2);  cmp(ax, cx);                               /* cmp ax, cx */
            ii(0xa92b, 2);  if(jz(0xa931, 4)) goto l_0xa931;           /* jz 0xa931 */
            ii(0xa92d, 4);  mov(sp, memw[ds, 0xf50]);                  /* mov sp, [0xf50] */
        l_0xa931:
            ii(0xa931, 3);  call(0x5e40, -0x4af4);                     /* call 0x5e40 */
        l_0xa934:
            ii(0xa934, 3);  if(jmp_func(0xaf9c, 0x665)) return;        /* jmp 0xaf9c */
        l_0xa937:
            ii(0xa937, 3);  mov(si, memw[ss, bp + 30]);                /* mov si, [bp+0x1e] */
            ii(0xa93a, 3);  mov(ds, memw[ss, bp + 34]);                /* mov ds, [bp+0x22] */
            ii(0xa93d, 1);  lodsw();                                   /* lodsw */
            ii(0xa93e, 3);  cmp(ax, 0x5eff);                           /* cmp ax, 0x5eff */
            ii(0xa941, 2);  if(jnz(0xa968, 0x25)) goto l_0xa968;       /* jnz 0xa968 */
            ii(0xa943, 1);  lodsb();                                   /* lodsb */
            ii(0xa944, 1);  cbw();                                     /* cbw */
            ii(0xa945, 3);  add(ax, memw[ss, bp + 12]);                /* add ax, [bp+0xc] */
            ii(0xa948, 1);  xchg(si, ax);                              /* xchg si, ax */
            ii(0xa949, 3);  mov(ds, memw[ss, bp + 2]);                 /* mov ds, [bp+0x2] */
            ii(0xa94c, 3);  mov(bx, memw[ds, si + 2]);                 /* mov bx, [si+0x2] */
            ii(0xa94f, 3);  mov(ax, 6);                                /* mov ax, 0x6 */
            ii(0xa952, 2);  @int(0x31);                                /* int 0x31 */
            ii(0xa954, 2);  if(jb(0xa968, 0x12)) goto l_0xa968;        /* jb 0xa968 */
            ii(0xa956, 5);  mov(es, memw[cs, 0x208e]);                 /* mov es, [cs:0x208e] */
            ii(0xa95b, 5);  mov(bx, memw[es, 0xa9c]);                  /* mov bx, [es:0xa9c] */
            ii(0xa960, 3);  mov(memw[ds, si + 2], bx);                 /* mov [si+0x2], bx */
            ii(0xa963, 1);  inc(ax);                                   /* inc ax */
            ii(0xa964, 2);  @int(0x31);                                /* int 0x31 */
            ii(0xa966, 2);  if(jae(0xa9e6, 0x7e)) goto l_0xa9e6;       /* jae 0xa9e6 */
        l_0xa968:
            ii(0xa968, 5);  if(jmp_far_ind(memw[cs, 0x17be])) return;  /* jmp far word [cs:0x17be] */
        l_0xa96d:
            ii(0xa96d, 4);  lsl(ax, memw[ss, bp + 34]);                /* lsl ax, [bp+0x22] */
            ii(0xa971, 3);  sub(ax, memw[ss, bp + 30]);                /* sub ax, [bp+0x1e] */
            ii(0xa974, 2);  if(jbe(0xa968, -0xe)) goto l_0xa968;       /* jbe 0xa968 */
            ii(0xa976, 4);  cmp(memw[ss, bp + 26], 0);                 /* cmp word [bp+0x1a], 0x0 */
            ii(0xa97a, 2);  if(jnz(0xa937, -0x45)) goto l_0xa937;      /* jnz 0xa937 */
            ii(0xa97c, 3);  sub(ax, 4);                                /* sub ax, 0x4 */
            ii(0xa97f, 2);  if(jbe(0xa968, -0x19)) goto l_0xa968;      /* jbe 0xa968 */
            ii(0xa981, 3);  mov(cx, memw[ss, bp + 4]);                 /* mov cx, [bp+0x4] */
            ii(0xa984, 2);  if(jcxz(0xa968, -0x1e)) goto l_0xa968;     /* jcxz 0xa968 */
            ii(0xa986, 3);  lsl(bx, cx);                               /* lsl bx, cx */
            ii(0xa989, 2);  mov(es, cx);                               /* mov es, cx */
            ii(0xa98b, 3);  mov(si, memw[ss, bp + 30]);                /* mov si, [bp+0x1e] */
            ii(0xa98e, 3);  mov(ds, memw[ss, bp + 34]);                /* mov ds, [bp+0x22] */
            ii(0xa991, 1);  cld();                                     /* cld */
            ii(0xa992, 1);  lodsw();                                   /* lodsw */
            ii(0xa993, 3);  mov(cx, 2);                                /* mov cx, 0x2 */
            ii(0xa996, 3);  mov(di, memw[ss, bp + 10]);                /* mov di, [bp+0xa] */
            ii(0xa999, 2);  cmp(bx, di);                               /* cmp bx, di */
            ii(0xa99b, 2);  if(jbe(0xa968, -0x35)) goto l_0xa968;      /* jbe 0xa968 */
            ii(0xa99d, 3);  mov(bx, memw[es, di]);                     /* mov bx, [es:di] */
            ii(0xa9a0, 3);  mov(dx, memw[ss, bp + 22]);                /* mov dx, [bp+0x16] */
            ii(0xa9a3, 3);  cmp(ax, 0x489);                            /* cmp ax, 0x489 */
            ii(0xa9a6, 2);  if(jz(0xa9ca, 0x22)) goto l_0xa9ca;        /* jz 0xa9ca */
            ii(0xa9a8, 2);  sub(dx, bx);                               /* sub dx, bx */
            ii(0xa9aa, 2);  neg(dx);                                   /* neg dx */
            ii(0xa9ac, 3);  cmp(ax, 0x429);                            /* cmp ax, 0x429 */
            ii(0xa9af, 2);  if(jz(0xa9ca, 0x19)) goto l_0xa9ca;        /* jz 0xa9ca */
            ii(0xa9b1, 1);  inc(cx);                                   /* inc cx */
            ii(0xa9b2, 2);  mov(dx, bx);                               /* mov dx, bx */
            ii(0xa9b4, 2);  mov(dl, memb[ds, si]);                     /* mov dl, [si] */
            ii(0xa9b6, 3);  cmp(ax, 0x4c6);                            /* cmp ax, 0x4c6 */
            ii(0xa9b9, 2);  if(jz(0xa9ca, 0xf)) goto l_0xa9ca;         /* jz 0xa9ca */
            ii(0xa9bb, 2);  or(dl, bl);                                /* or dl, bl */
            ii(0xa9bd, 3);  cmp(ax, 0xc80);                            /* cmp ax, 0xc80 */
            ii(0xa9c0, 2);  if(jz(0xa9ca, 8)) goto l_0xa9ca;           /* jz 0xa9ca */
            ii(0xa9c2, 1);  inc(cx);                                   /* inc cx */
            ii(0xa9c3, 2);  mov(dx, memw[ds, si]);                     /* mov dx, [si] */
            ii(0xa9c5, 3);  cmp(ax, 0x4c7);                            /* cmp ax, 0x4c7 */
            ii(0xa9c8, 2);  if(jnz(0xa968, -0x62)) goto l_0xa968;      /* jnz 0xa968 */
        l_0xa9ca:
            ii(0xa9ca, 3);  add(memw[ss, bp + 30], cx);                /* add [bp+0x1e], cx */
            ii(0xa9cd, 3);  mov(bx, memw[ss, bp + 4]);                 /* mov bx, [bp+0x4] */
            ii(0xa9d0, 3);  mov(ax, 0xa);                              /* mov ax, 0xa */
            ii(0xa9d3, 2);  @int(0x31);                                /* int 0x31 */
            ii(0xa9d5, 2);  if(jb(0xa968, -0x6f)) goto l_0xa968;       /* jb 0xa968 */
            ii(0xa9d7, 2);  mov(es, ax);                               /* mov es, ax */
            ii(0xa9d9, 2);  mov(bx, ax);                               /* mov bx, ax */
            ii(0xa9db, 3);  mov(di, memw[ss, bp + 10]);                /* mov di, [bp+0xa] */
            ii(0xa9de, 3);  mov(memw[es, di], dx);                     /* mov [es:di], dx */
            ii(0xa9e1, 3);  mov(ax, 1);                                /* mov ax, 0x1 */
            ii(0xa9e4, 2);  @int(0x31);                                /* int 0x31 */
        l_0xa9e6:
            ii(0xa9e6, 3);  mov(es, memw[ss, bp + 2]);                 /* mov es, [bp+0x2] */
            ii(0xa9e9, 3);  mov(di, memw[ss, bp + 14]);                /* mov di, [bp+0xe] */
            ii(0xa9ec, 1);  dec(di);                                   /* dec di */
            ii(0xa9ed, 1);  dec(di);                                   /* dec di */
            ii(0xa9ee, 3);  lea(si, memw[ss, bp + 38]);                /* lea si, [bp+0x26] */
            ii(0xa9f1, 1);  push(ss);                                  /* push ss */
            ii(0xa9f2, 1);  pop(ds);                                   /* pop ds */
            ii(0xa9f3, 1);  std();                                     /* std */
            ii(0xa9f4, 3);  mov(cx, 0x15);                             /* mov cx, 0x15 */
            ii(0xa9f7, 2);  rep(() => movsw());                        /* rep movsw */
            ii(0xa9f9, 2);  mov(ax, es);                               /* mov ax, es */
            ii(0xa9fb, 2);  mov(ss, ax);                               /* mov ss, ax */
            ii(0xa9fd, 2);  mov(sp, di);                               /* mov sp, di */
            ii(0xa9ff, 3);  add(sp, 6);                                /* add sp, 0x6 */
            ii(0xaa02, 1);  pop(ds);                                   /* pop ds */
            ii(0xaa03, 1);  pop(es);                                   /* pop es */
            ii(0xaa04, 1);  popa();                                    /* popa */
            ii(0xaa05, 3);  add(sp, 6);                                /* add sp, 0x6 */
            ii(0xaa08, 2);  iretd();                                   /* iretd */
        }
    }
}
