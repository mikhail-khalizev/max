using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1_1073-ed106a99")]
        public void Method_0001_1073()
        {
            ii(0x1_1073, 1);  pushw(si);                                /* push si */
            ii(0x1_1074, 1);  pushw(di);                                /* push di */
            ii(0x1_1075, 1);  pushw(ds);                                /* push ds */
            ii(0x1_1076, 3);  mov(ax, 0x6);                             /* mov ax, 0x6 */
            ii(0x1_1079, 2);  mov(bx, cs);                              /* mov bx, cs */
            ii(0x1_107b, 2);  @int(0x31);                               /* int 0x31 */
            ii(0x1_107d, 1);  inc(ax);                                  /* inc ax */
            ii(0x1_107e, 3);  mov(bx, 0x60);                            /* mov bx, 0x60 */
            ii(0x1_1081, 2);  @int(0x31);                               /* int 0x31 */
            ii(0x1_1083, 3);  mov(ax, memw_a16[ds, 0x50]);              /* mov ax, [0x50] */
            ii(0x1_1086, 2);  mov(ds, bx);                              /* mov ds, bx */
            ii(0x1_1088, 1);  xchg(bx, ax);                             /* xchg bx, ax */
            ii(0x1_1089, 3);  mov(si, 0x4405);                          /* mov si, 0x4405 */
            ii(0x1_108c, 3);  mov(di, 0x4229);                          /* mov di, 0x4229 */
            ii(0x1_108f, 2);  xor(cx, cx);                              /* xor cx, cx */
        l_0x1_1091:
            ii(0x1_1091, 1);  lodsb_a16();                              /* lodsb */
            ii(0x1_1092, 1);  xchg(dx, ax);                             /* xchg dx, ax */
            ii(0x1_1093, 2);  mov(dh, dl);                              /* mov dh, dl */
            ii(0x1_1095, 3);  and(dl, 0x20);                            /* and dl, 0x20 */
            ii(0x1_1098, 3);  mov(ax, 0x52c0);                          /* mov ax, 0x52c0 */
            ii(0x1_109b, 2);  if(jnzw(0x1_10a0, 0x3)) goto l_0x1_10a0;  /* jnz 0x10a0 */
            ii(0x1_109d, 3);  mov(ax, 0x52b9);                          /* mov ax, 0x52b9 */
        l_0x1_10a0:
            ii(0x1_10a0, 2);  mov(memw_a16[ds, di], ax);                /* mov [di], ax */
            ii(0x1_10a2, 5);  mov(memw_a16[ds, di + 0x2], 0);           /* mov word [di+0x2], 0x0 */
            ii(0x1_10a7, 3);  mov(memw_a16[ds, di + 0x4], cs);          /* mov [di+0x4], cs */
            ii(0x1_10aa, 2);  mov(ah, 0x40);                            /* mov ah, 0x40 */
            ii(0x1_10ac, 2);  mov(al, cl);                              /* mov al, cl */
            ii(0x1_10ae, 2);  sub(al, bl);                              /* sub al, bl */
        l_0x1_10b0:
            ii(0x1_10b0, 2);  cmp(al, 0x8);                             /* cmp al, 0x8 */
            ii(0x1_10b2, 2);  if(jbw(0x1_10bc, 0x8)) goto l_0x1_10bc;   /* jb 0x10bc */
            ii(0x1_10b4, 2);  mov(al, cl);                              /* mov al, cl */
            ii(0x1_10b6, 2);  sub(al, bh);                              /* sub al, bh */
            ii(0x1_10b8, 2);  shl(ah, 0x1);                             /* shl ah, 1 */
            ii(0x1_10ba, 2);  if(jnzw(0x1_10b0, -0xc)) goto l_0x1_10b0; /* jnz 0x10b0 */
        l_0x1_10bc:
            ii(0x1_10bc, 2);  or(dl, ah);                               /* or dl, ah */
            ii(0x1_10be, 2);  or(dl, cl);                               /* or dl, cl */
            ii(0x1_10c0, 3);  mov(memb_a16[ds, di + 0xe], dl);          /* mov [di+0xe], dl */
            ii(0x1_10c3, 3);  cmp(cl, 0x8);                             /* cmp cl, 0x8 */
            ii(0x1_10c6, 2);  if(jbw(0x1_10df, 0x17)) goto l_0x1_10df;  /* jb 0x10df */
            ii(0x1_10c8, 3);  cmp(cl, 0xf);                             /* cmp cl, 0xf */
            ii(0x1_10cb, 2);  if(jzw(0x1_10df, 0x12)) goto l_0x1_10df;  /* jz 0x10df */
            ii(0x1_10cd, 2);  test(ah, ah);                             /* test ah, ah */
            ii(0x1_10cf, 3);  mov(ax, 0x5328);                          /* mov ax, 0x5328 */
            ii(0x1_10d2, 2);  if(jnzw(0x1_10d7, 0x3)) goto l_0x1_10d7;  /* jnz 0x10d7 */
            ii(0x1_10d4, 3);  mov(ax, 0x53ee);                          /* mov ax, 0x53ee */
        l_0x1_10d7:
            ii(0x1_10d7, 2);  sub(ax, di);                              /* sub ax, di */
            ii(0x1_10d9, 3);  sub(ax, 0x13);                            /* sub ax, 0x13 */
            ii(0x1_10dc, 3);  mov(memw_a16[ds, di + 0x11], ax);         /* mov [di+0x11], ax */
        l_0x1_10df:
            ii(0x1_10df, 3);  imul(ax, cx, 0x4);                        /* imul ax, cx, 0x4 */
            ii(0x1_10e2, 3);  test(dh, 0x1);                            /* test dh, 0x1 */
            ii(0x1_10e5, 4);  if(jnzw(0x1_10fd, 0x14)) goto l_0x1_10fd; /* jnz 0x10fd */
            ii(0x1_10e9, 3);  test(dh, 0x2);                            /* test dh, 0x2 */
            ii(0x1_10ec, 4);  if(jzw(0x1_10f5, 0x5)) goto l_0x1_10f5;   /* jz 0x10f5 */
            ii(0x1_10f0, 1);  lodsw_a16();                              /* lodsw */
            ii(0x1_10f1, 1);  xchg(dx, ax);                             /* xchg dx, ax */
            ii(0x1_10f2, 1);  lodsw_a16();                              /* lodsw */
            ii(0x1_10f3, 2);  jmpw(0x1_1102, 0xd); goto l_0x1_1102;     /* jmp 0x1102 */
        l_0x1_10f5:
            ii(0x1_10f5, 3);  add(ax, 0xc3c);                           /* add ax, 0xc3c */
            ii(0x1_10f8, 3);  mov(dx, 0x18);                            /* mov dx, 0x18 */
            ii(0x1_10fb, 2);  jmpw(0x1_1102, 0x5); goto l_0x1_1102;     /* jmp 0x1102 */
        l_0x1_10fd:
            ii(0x1_10fd, 3);  add(ax, 0);                               /* add ax, 0x0 */
            ii(0x1_1100, 2);  mov(dx, cs);                              /* mov dx, cs */
        l_0x1_1102:
            ii(0x1_1102, 3);  mov(memw_a16[ds, di + 0x16], ax);         /* mov [di+0x16], ax */
            ii(0x1_1105, 5);  mov(memw_a16[ds, di + 0x18], 0);          /* mov word [di+0x18], 0x0 */
            ii(0x1_110a, 3);  mov(memw_a16[ds, di + 0x1a], dx);         /* mov [di+0x1a], dx */
            ii(0x1_110d, 1);  inc(cx);                                  /* inc cx */
            ii(0x1_110e, 3);  add(di, 0x1c);                            /* add di, 0x1c */
            ii(0x1_1111, 3);  cmp(cx, 0x10);                            /* cmp cx, 0x10 */
            ii(0x1_1114, 4);  if(jbew(0x1_1091, -0x87)) goto l_0x1_1091; /* jbe 0x1091 */
            ii(0x1_1118, 1);  pushw(ds);                                /* push ds */
            ii(0x1_1119, 1);  popw(es);                                 /* pop es */
            ii(0x1_111a, 1);  popw(ds);                                 /* pop ds */
            ii(0x1_111b, 5);  test(memb_a16[ds, 0x47], 0x1);            /* test byte [0x47], 0x1 */
            ii(0x1_1120, 2);  if(jzw(0x1_1139, 0x17)) goto l_0x1_1139;  /* jz 0x1139 */
            ii(0x1_1122, 3);  mov(di, 0x43f0);                          /* mov di, 0x43f0 */
            ii(0x1_1125, 3);  mov(ax, 0x52c9);                          /* mov ax, 0x52c9 */
            ii(0x1_1128, 1);  stosw_a16();                              /* stosw */
            ii(0x1_1129, 3);  mov(ax, 0x70);                            /* mov ax, 0x70 */
            ii(0x1_112c, 1);  stosw_a16();                              /* stosw */
            ii(0x1_112d, 3);  mov(di, 0x43fa);                          /* mov di, 0x43fa */
            ii(0x1_1130, 3);  mov(ax, 0xed1);                           /* mov ax, 0xed1 */
            ii(0x1_1133, 1);  stosw_a16();                              /* stosw */
            ii(0x1_1134, 3);  mov(ax, 0x1a83);                          /* mov ax, 0x1a83 */
            ii(0x1_1137, 2);  jmpw(0x1_1141, 0x8); goto l_0x1_1141;     /* jmp 0x1141 */
        l_0x1_1139:
            ii(0x1_1139, 3);  cmp(bh, 0x10);                            /* cmp bh, 0x10 */
            ii(0x1_113c, 2);  if(jnzw(0x1_114b, 0xd)) goto l_0x1_114b;  /* jnz 0x114b */
            ii(0x1_113e, 3);  mov(ax, 0x7d80);                          /* mov ax, 0x7d80 */
        l_0x1_1141:
            ii(0x1_1141, 3);  mov(di, 0x43ff);                          /* mov di, 0x43ff */
            ii(0x1_1144, 1);  stosw_a16();                              /* stosw */
            ii(0x1_1145, 1);  inc(di);                                  /* inc di */
            ii(0x1_1146, 1);  inc(di);                                  /* inc di */
            ii(0x1_1147, 3);  mov(ax, 0x70);                            /* mov ax, 0x70 */
            ii(0x1_114a, 1);  stosw_a16();                              /* stosw */
        l_0x1_114b:
            ii(0x1_114b, 1);  popw(di);                                 /* pop di */
            ii(0x1_114c, 1);  popw(si);                                 /* pop si */
            ii(0x1_114d, 5);  if(jmpw_far_abs(0x18, 0x2089)) return;    /* jmp word 0x18:0x2089 */
        }
    }
}
