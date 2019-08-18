using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1_3083-ed106a99")]
        public void Method_0001_3083()
        {
            ii(0x1_3083, 1);  pushw(si);                                /* push si */
            ii(0x1_3084, 1);  pushw(di);                                /* push di */
            ii(0x1_3085, 1);  pushw(ds);                                /* push ds */
            ii(0x1_3086, 3);  mov(ax, 0x6);                             /* mov ax, 0x6 */
            ii(0x1_3089, 2);  mov(bx, cs);                              /* mov bx, cs */
            ii(0x1_308b, 2);  @int(0x31);                               /* int 0x31 */
            ii(0x1_308d, 1);  inc(ax);                                  /* inc ax */
            ii(0x1_308e, 3);  mov(bx, 0x60);                            /* mov bx, 0x60 */
            ii(0x1_3091, 2);  @int(0x31);                               /* int 0x31 */
            ii(0x1_3093, 3);  mov(ax, memw_a16[ds, 0x50]);              /* mov ax, [0x50] */
            ii(0x1_3096, 2);  mov(ds, bx);                              /* mov ds, bx */
            ii(0x1_3098, 1);  xchg(bx, ax);                             /* xchg bx, ax */
            ii(0x1_3099, 3);  mov(si, 0x4405);                          /* mov si, 0x4405 */
            ii(0x1_309c, 3);  mov(di, 0x4229);                          /* mov di, 0x4229 */
            ii(0x1_309f, 2);  xor(cx, cx);                              /* xor cx, cx */
        l_0x1_30a1:
            ii(0x1_30a1, 1);  lodsb_a16();                              /* lodsb */
            ii(0x1_30a2, 1);  xchg(dx, ax);                             /* xchg dx, ax */
            ii(0x1_30a3, 2);  mov(dh, dl);                              /* mov dh, dl */
            ii(0x1_30a5, 3);  and(dl, 0x20);                            /* and dl, 0x20 */
            ii(0x1_30a8, 3);  mov(ax, 0x52c0);                          /* mov ax, 0x52c0 */
            ii(0x1_30ab, 2);  if(jnzw(0x1_30b0, 0x3)) goto l_0x1_30b0;  /* jnz 0x30b0 */
            ii(0x1_30ad, 3);  mov(ax, 0x52b9);                          /* mov ax, 0x52b9 */
        l_0x1_30b0:
            ii(0x1_30b0, 2);  mov(memw_a16[ds, di], ax);                /* mov [di], ax */
            ii(0x1_30b2, 5);  mov(memw_a16[ds, di + 0x2], 0);           /* mov word [di+0x2], 0x0 */
            ii(0x1_30b7, 3);  mov(memw_a16[ds, di + 0x4], cs);          /* mov [di+0x4], cs */
            ii(0x1_30ba, 2);  mov(ah, 0x40);                            /* mov ah, 0x40 */
            ii(0x1_30bc, 2);  mov(al, cl);                              /* mov al, cl */
            ii(0x1_30be, 2);  sub(al, bl);                              /* sub al, bl */
        l_0x1_30c0:
            ii(0x1_30c0, 2);  cmp(al, 0x8);                             /* cmp al, 0x8 */
            ii(0x1_30c2, 2);  if(jbw(0x1_30cc, 0x8)) goto l_0x1_30cc;   /* jb 0x30cc */
            ii(0x1_30c4, 2);  mov(al, cl);                              /* mov al, cl */
            ii(0x1_30c6, 2);  sub(al, bh);                              /* sub al, bh */
            ii(0x1_30c8, 2);  shl(ah, 0x1);                             /* shl ah, 1 */
            ii(0x1_30ca, 2);  if(jnzw(0x1_30c0, -0xc)) goto l_0x1_30c0; /* jnz 0x30c0 */
        l_0x1_30cc:
            ii(0x1_30cc, 2);  or(dl, ah);                               /* or dl, ah */
            ii(0x1_30ce, 2);  or(dl, cl);                               /* or dl, cl */
            ii(0x1_30d0, 3);  mov(memb_a16[ds, di + 0xe], dl);          /* mov [di+0xe], dl */
            ii(0x1_30d3, 3);  cmp(cl, 0x8);                             /* cmp cl, 0x8 */
            ii(0x1_30d6, 2);  if(jbw(0x1_30ef, 0x17)) goto l_0x1_30ef;  /* jb 0x30ef */
            ii(0x1_30d8, 3);  cmp(cl, 0xf);                             /* cmp cl, 0xf */
            ii(0x1_30db, 2);  if(jzw(0x1_30ef, 0x12)) goto l_0x1_30ef;  /* jz 0x30ef */
            ii(0x1_30dd, 2);  test(ah, ah);                             /* test ah, ah */
            ii(0x1_30df, 3);  mov(ax, 0x5328);                          /* mov ax, 0x5328 */
            ii(0x1_30e2, 2);  if(jnzw(0x1_30e7, 0x3)) goto l_0x1_30e7;  /* jnz 0x30e7 */
            ii(0x1_30e4, 3);  mov(ax, 0x53ee);                          /* mov ax, 0x53ee */
        l_0x1_30e7:
            ii(0x1_30e7, 2);  sub(ax, di);                              /* sub ax, di */
            ii(0x1_30e9, 3);  sub(ax, 0x13);                            /* sub ax, 0x13 */
            ii(0x1_30ec, 3);  mov(memw_a16[ds, di + 0x11], ax);         /* mov [di+0x11], ax */
        l_0x1_30ef:
            ii(0x1_30ef, 3);  imul(ax, cx, 0x4);                        /* imul ax, cx, 0x4 */
            ii(0x1_30f2, 3);  test(dh, 0x1);                            /* test dh, 0x1 */
            ii(0x1_30f5, 4);  if(jnzw(0x1_310d, 0x14)) goto l_0x1_310d; /* jnz 0x310d */
            ii(0x1_30f9, 3);  test(dh, 0x2);                            /* test dh, 0x2 */
            ii(0x1_30fc, 4);  if(jzw(0x1_3105, 0x5)) goto l_0x1_3105;   /* jz 0x3105 */
            ii(0x1_3100, 1);  lodsw_a16();                              /* lodsw */
            ii(0x1_3101, 1);  xchg(dx, ax);                             /* xchg dx, ax */
            ii(0x1_3102, 1);  lodsw_a16();                              /* lodsw */
            ii(0x1_3103, 2);  jmpw(0x1_3112, 0xd); goto l_0x1_3112;     /* jmp 0x3112 */
        l_0x1_3105:
            ii(0x1_3105, 3);  add(ax, 0xc3c);                           /* add ax, 0xc3c */
            ii(0x1_3108, 3);  mov(dx, 0x18);                            /* mov dx, 0x18 */
            ii(0x1_310b, 2);  jmpw(0x1_3112, 0x5); goto l_0x1_3112;     /* jmp 0x3112 */
        l_0x1_310d:
            ii(0x1_310d, 3);  add(ax, 0);                               /* add ax, 0x0 */
            ii(0x1_3110, 2);  mov(dx, cs);                              /* mov dx, cs */
        l_0x1_3112:
            ii(0x1_3112, 3);  mov(memw_a16[ds, di + 0x16], ax);         /* mov [di+0x16], ax */
            ii(0x1_3115, 5);  mov(memw_a16[ds, di + 0x18], 0);          /* mov word [di+0x18], 0x0 */
            ii(0x1_311a, 3);  mov(memw_a16[ds, di + 0x1a], dx);         /* mov [di+0x1a], dx */
            ii(0x1_311d, 1);  inc(cx);                                  /* inc cx */
            ii(0x1_311e, 3);  add(di, 0x1c);                            /* add di, 0x1c */
            ii(0x1_3121, 3);  cmp(cx, 0x10);                            /* cmp cx, 0x10 */
            ii(0x1_3124, 4);  if(jbew(0x1_30a1, -0x87)) goto l_0x1_30a1; /* jbe 0x30a1 */
            ii(0x1_3128, 1);  pushw(ds);                                /* push ds */
            ii(0x1_3129, 1);  popw(es);                                 /* pop es */
            ii(0x1_312a, 1);  popw(ds);                                 /* pop ds */
            ii(0x1_312b, 5);  test(memb_a16[ds, 0x47], 0x1);            /* test byte [0x47], 0x1 */
            ii(0x1_3130, 2);  if(jzw(0x1_3149, 0x17)) goto l_0x1_3149;  /* jz 0x3149 */
            ii(0x1_3132, 3);  mov(di, 0x43f0);                          /* mov di, 0x43f0 */
            ii(0x1_3135, 3);  mov(ax, 0x52c9);                          /* mov ax, 0x52c9 */
            ii(0x1_3138, 1);  stosw_a16();                              /* stosw */
            ii(0x1_3139, 3);  mov(ax, 0x70);                            /* mov ax, 0x70 */
            ii(0x1_313c, 1);  stosw_a16();                              /* stosw */
            ii(0x1_313d, 3);  mov(di, 0x43fa);                          /* mov di, 0x43fa */
            ii(0x1_3140, 3);  mov(ax, 0xed1);                           /* mov ax, 0xed1 */
            ii(0x1_3143, 1);  stosw_a16();                              /* stosw */
            ii(0x1_3144, 3);  mov(ax, 0x1a83);                          /* mov ax, 0x1a83 */
            ii(0x1_3147, 2);  jmpw(0x1_3151, 0x8); goto l_0x1_3151;     /* jmp 0x3151 */
        l_0x1_3149:
            ii(0x1_3149, 3);  cmp(bh, 0x10);                            /* cmp bh, 0x10 */
            ii(0x1_314c, 2);  if(jnzw(0x1_315b, 0xd)) goto l_0x1_315b;  /* jnz 0x315b */
            ii(0x1_314e, 3);  mov(ax, 0x7d80);                          /* mov ax, 0x7d80 */
        l_0x1_3151:
            ii(0x1_3151, 3);  mov(di, 0x43ff);                          /* mov di, 0x43ff */
            ii(0x1_3154, 1);  stosw_a16();                              /* stosw */
            ii(0x1_3155, 1);  inc(di);                                  /* inc di */
            ii(0x1_3156, 1);  inc(di);                                  /* inc di */
            ii(0x1_3157, 3);  mov(ax, 0x70);                            /* mov ax, 0x70 */
            ii(0x1_315a, 1);  stosw_a16();                              /* stosw */
        l_0x1_315b:
            ii(0x1_315b, 1);  popw(di);                                 /* pop di */
            ii(0x1_315c, 1);  popw(si);                                 /* pop si */
            ii(0x1_315d, 5);  if(jmpw_far_abs(0x18, 0x2089)) return;    /* jmp word 0x18:0x2089 */
        }
    }
}
