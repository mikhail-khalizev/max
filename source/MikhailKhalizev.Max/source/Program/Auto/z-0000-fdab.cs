using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xfdab-9d00b9d0")]
        public void Method_0000_fdab()
        {
            ii(0xfdab, 4);  enter(0x16, 0);                            /* enter 0x16, 0x0 */
        l_0xfdaf:
            ii(0xfdaf, 2);  sub(ax, ax);                               /* sub ax, ax */
            ii(0xfdb1, 3);  mov(memw[ds, 0x11fc], ax);                 /* mov [0x11fc], ax */
            ii(0xfdb4, 3);  mov(memw[ds, 0x11fa], ax);                 /* mov [0x11fa], ax */
            ii(0xfdb7, 3);  mov(memw[ss, bp - 20], ax);                /* mov [bp-0x14], ax */
        l_0xfdba:
            ii(0xfdba, 1);  cli();                                     /* cli */
            ii(0xfdbb, 3);  mov(ax, memw[ds, 0x98]);                   /* mov ax, [0x98] */
            ii(0xfdbe, 4);  mov(dx, memw[ds, 0x9a]);                   /* mov dx, [0x9a] */
            ii(0xfdc2, 3);  mov(memw[ss, bp - 8], ax);                 /* mov [bp-0x8], ax */
            ii(0xfdc5, 3);  mov(memw[ss, bp - 6], dx);                 /* mov [bp-0x6], dx */
            ii(0xfdc8, 4);  cmp(dx, memw[ds, 0x9e]);                   /* cmp dx, [0x9e] */
            ii(0xfdcc, 2);  if(ja(0xfde4, 0x16)) goto l_0xfde4;        /* ja 0xfde4 */
            ii(0xfdce, 2);  if(jb(0xfdd6, 6)) goto l_0xfdd6;           /* jb 0xfdd6 */
            ii(0xfdd0, 4);  cmp(ax, memw[ds, 0x9c]);                   /* cmp ax, [0x9c] */
            ii(0xfdd4, 2);  if(jae(0xfde4, 0xe)) goto l_0xfde4;        /* jae 0xfde4 */
        l_0xfdd6:
            ii(0xfdd6, 4);  cmp(memw[ss, bp + 6], 0);                  /* cmp word [bp+0x6], 0x0 */
            ii(0xfdda, 2);  if(jg(0xfde9, 0xd)) goto l_0xfde9;         /* jg 0xfde9 */
            ii(0xfddc, 2);  if(jl(0xfde4, 6)) goto l_0xfde4;           /* jl 0xfde4 */
            ii(0xfdde, 4);  cmp(memw[ss, bp + 4], 0);                  /* cmp word [bp+0x4], 0x0 */
            ii(0xfde2, 2);  if(jnz(0xfde9, 5)) goto l_0xfde9;          /* jnz 0xfde9 */
        l_0xfde4:
            ii(0xfde4, 2);  sub(ax, ax);                               /* sub ax, ax */
            ii(0xfde6, 1);  cwd();                                     /* cwd */
            ii(0xfde7, 1);  leave();                                   /* leave */
            ii(0xfde8, 1);  ret(); return;                             /* ret */
        l_0xfde9:
            ii(0xfde9, 2);  push(0);                                   /* push 0x0 */
            ii(0xfdeb, 3);  push(memw[ss, bp - 6]);                    /* push word [bp-0x6] */
            ii(0xfdee, 3);  push(memw[ss, bp - 8]);                    /* push word [bp-0x8] */
            ii(0xfdf1, 3);  call(0x1_1b21, 0x1d2d);                    /* call 0x1b21 */
            ii(0xfdf4, 3);  add(sp, 6);                                /* add sp, 0x6 */
            ii(0xfdf7, 3);  mov(memw[ss, bp - 4], ax);                 /* mov [bp-0x4], ax */
            ii(0xfdfa, 3);  mov(memw[ss, bp - 2], dx);                 /* mov [bp-0x2], dx */
        l_0xfdfd:
            ii(0xfdfd, 3);  mov(ax, memw[ss, bp - 2]);                 /* mov ax, [bp-0x2] */
            ii(0xfe00, 3);  or(ax, memw[ss, bp - 4]);                  /* or ax, [bp-0x4] */
            ii(0xfe03, 2);  if(jnz(0xfe08, 3)) goto l_0xfe08;          /* jnz 0xfe08 */
            ii(0xfe05, 3);  jmp(0xff65, 0x15d); goto l_0xff65;         /* jmp 0xff65 */
        l_0xfe08:
            ii(0xfe08, 2);  push(4);                                   /* push 0x4 */
            ii(0xfe0a, 3);  push(memw[ss, bp - 2]);                    /* push word [bp-0x2] */
            ii(0xfe0d, 3);  push(memw[ss, bp - 4]);                    /* push word [bp-0x4] */
            ii(0xfe10, 3);  call(0x1_1b21, 0x1d0e);                    /* call 0x1b21 */
            ii(0xfe13, 3);  add(sp, 6);                                /* add sp, 0x6 */
            ii(0xfe16, 3);  mov(memw[ss, bp - 18], ax);                /* mov [bp-0x12], ax */
            ii(0xfe19, 3);  mov(memw[ss, bp - 16], dx);                /* mov [bp-0x10], dx */
            ii(0xfe1c, 3);  cmp(dx, memw[ss, bp + 6]);                 /* cmp dx, [bp+0x6] */
            ii(0xfe1f, 2);  if(jge(0xfe24, 3)) goto l_0xfe24;          /* jge 0xfe24 */
            ii(0xfe21, 3);  jmp(0xff02, 0xde); goto l_0xff02;          /* jmp 0xff02 */
        l_0xfe24:
            ii(0xfe24, 2);  if(jg(0xfe2e, 8)) goto l_0xfe2e;           /* jg 0xfe2e */
            ii(0xfe26, 3);  cmp(ax, memw[ss, bp + 4]);                 /* cmp ax, [bp+0x4] */
            ii(0xfe29, 2);  if(jae(0xfe2e, 3)) goto l_0xfe2e;          /* jae 0xfe2e */
            ii(0xfe2b, 3);  jmp(0xff02, 0xd4); goto l_0xff02;          /* jmp 0xff02 */
        l_0xfe2e:
            ii(0xfe2e, 5);  cmp(memb[ds, 0x2e], 0xb);                  /* cmp byte [0x2e], 0xb */
            ii(0xfe33, 2);  if(jnz(0xfe68, 0x33)) goto l_0xfe68;       /* jnz 0xfe68 */
            ii(0xfe35, 3);  call(0x1_336c, 0x3534);                    /* call 0x336c */
            ii(0xfe38, 2);  or(ax, ax);                                /* or ax, ax */
            ii(0xfe3a, 2);  if(jnz(0xfe68, 0x2c)) goto l_0xfe68;       /* jnz 0xfe68 */
            ii(0xfe3c, 3);  mov(ax, memw[ss, bp + 4]);                 /* mov ax, [bp+0x4] */
            ii(0xfe3f, 3);  mov(dx, memw[ss, bp + 6]);                 /* mov dx, [bp+0x6] */
            ii(0xfe42, 3);  add(ax, memw[ss, bp - 4]);                 /* add ax, [bp-0x4] */
            ii(0xfe45, 3);  adc(dx, memw[ss, bp - 2]);                 /* adc dx, [bp-0x2] */
            ii(0xfe48, 1);  push(dx);                                  /* push dx */
            ii(0xfe49, 1);  push(ax);                                  /* push ax */
            ii(0xfe4a, 3);  push(memw[ss, bp - 2]);                    /* push word [bp-0x2] */
            ii(0xfe4d, 3);  push(memw[ss, bp - 4]);                    /* push word [bp-0x4] */
            ii(0xfe50, 3);  call(0x1_32a8, 0x3455);                    /* call 0x32a8 */
            ii(0xfe53, 3);  add(sp, 8);                                /* add sp, 0x8 */
            ii(0xfe56, 3);  mov(memw[ss, bp - 14], ax);                /* mov [bp-0xe], ax */
            ii(0xfe59, 2);  or(ax, ax);                                /* or ax, ax */
            ii(0xfe5b, 2);  if(jle(0xfe61, 4)) goto l_0xfe61;          /* jle 0xfe61 */
            ii(0xfe5d, 1);  sti();                                     /* sti */
            ii(0xfe5e, 3);  jmp(0xfdaf, -0xb2); goto l_0xfdaf;         /* jmp 0xfdaf */
        l_0xfe61:
            ii(0xfe61, 2);  or(ax, ax);                                /* or ax, ax */
            ii(0xfe63, 2);  if(jge(0xfe68, 3)) goto l_0xfe68;          /* jge 0xfe68 */
            ii(0xfe65, 3);  jmp(0xff65, 0xfd); goto l_0xff65;          /* jmp 0xff65 */
        l_0xfe68:
            ii(0xfe68, 3);  mov(ax, memw[ss, bp - 18]);                /* mov ax, [bp-0x12] */
            ii(0xfe6b, 3);  mov(dx, memw[ss, bp - 16]);                /* mov dx, [bp-0x10] */
            ii(0xfe6e, 3);  cmp(memw[ss, bp + 4], ax);                 /* cmp [bp+0x4], ax */
            ii(0xfe71, 2);  if(jnz(0xfe78, 5)) goto l_0xfe78;          /* jnz 0xfe78 */
            ii(0xfe73, 3);  cmp(memw[ss, bp + 6], dx);                 /* cmp [bp+0x6], dx */
            ii(0xfe76, 2);  if(jz(0xfeac, 0x34)) goto l_0xfeac;        /* jz 0xfeac */
        l_0xfe78:
            ii(0xfe78, 3);  sub(ax, memw[ss, bp + 4]);                 /* sub ax, [bp+0x4] */
            ii(0xfe7b, 3);  sbb(dx, memw[ss, bp + 6]);                 /* sbb dx, [bp+0x6] */
            ii(0xfe7e, 1);  push(dx);                                  /* push dx */
            ii(0xfe7f, 1);  push(ax);                                  /* push ax */
            ii(0xfe80, 2);  push(4);                                   /* push 0x4 */
            ii(0xfe82, 3);  mov(ax, memw[ss, bp + 4]);                 /* mov ax, [bp+0x4] */
            ii(0xfe85, 3);  mov(dx, memw[ss, bp + 6]);                 /* mov dx, [bp+0x6] */
            ii(0xfe88, 3);  add(ax, memw[ss, bp - 4]);                 /* add ax, [bp-0x4] */
            ii(0xfe8b, 3);  adc(dx, memw[ss, bp - 2]);                 /* adc dx, [bp-0x2] */
            ii(0xfe8e, 1);  push(dx);                                  /* push dx */
            ii(0xfe8f, 1);  push(ax);                                  /* push ax */
            ii(0xfe90, 2);  push(0);                                   /* push 0x0 */
            ii(0xfe92, 3);  push(memw[ss, bp - 6]);                    /* push word [bp-0x6] */
            ii(0xfe95, 3);  push(memw[ss, bp - 8]);                    /* push word [bp-0x8] */
            ii(0xfe98, 3);  call(0x1_1b37, 0x1c9c);                    /* call 0x1b37 */
            ii(0xfe9b, 3);  add(sp, 0xa);                              /* add sp, 0xa */
            ii(0xfe9e, 3);  mov(memw[ss, bp - 8], ax);                 /* mov [bp-0x8], ax */
            ii(0xfea1, 3);  mov(memw[ss, bp - 6], dx);                 /* mov [bp-0x6], dx */
            ii(0xfea4, 1);  push(dx);                                  /* push dx */
            ii(0xfea5, 1);  push(ax);                                  /* push ax */
            ii(0xfea6, 3);  call(0x1_1b37, 0x1c8e);                    /* call 0x1b37 */
            ii(0xfea9, 3);  add(sp, 0xa);                              /* add sp, 0xa */
        l_0xfeac:
            ii(0xfeac, 2);  push(0);                                   /* push 0x0 */
            ii(0xfeae, 3);  push(memw[ss, bp - 2]);                    /* push word [bp-0x2] */
            ii(0xfeb1, 3);  push(memw[ss, bp - 4]);                    /* push word [bp-0x4] */
            ii(0xfeb4, 3);  call(0x1_1b21, 0x1c6a);                    /* call 0x1b21 */
            ii(0xfeb7, 3);  add(sp, 6);                                /* add sp, 0x6 */
            ii(0xfeba, 1);  push(dx);                                  /* push dx */
            ii(0xfebb, 1);  push(ax);                                  /* push ax */
            ii(0xfebc, 2);  push(0);                                   /* push 0x0 */
            ii(0xfebe, 3);  push(memw[ss, bp - 6]);                    /* push word [bp-0x6] */
            ii(0xfec1, 3);  push(memw[ss, bp - 8]);                    /* push word [bp-0x8] */
            ii(0xfec4, 3);  call(0x1_1b37, 0x1c70);                    /* call 0x1b37 */
            ii(0xfec7, 3);  add(sp, 0xa);                              /* add sp, 0xa */
            ii(0xfeca, 3);  mov(memw[ss, bp - 8], ax);                 /* mov [bp-0x8], ax */
            ii(0xfecd, 3);  mov(memw[ss, bp - 6], dx);                 /* mov [bp-0x6], dx */
            ii(0xfed0, 2);  or(dx, ax);                                /* or dx, ax */
            ii(0xfed2, 2);  if(jz(0xfee5, 0x11)) goto l_0xfee5;        /* jz 0xfee5 */
            ii(0xfed4, 3);  push(memw[ss, bp - 6]);                    /* push word [bp-0x6] */
            ii(0xfed7, 1);  push(ax);                                  /* push ax */
            ii(0xfed8, 3);  call(0xfc9e, -0x23d);                      /* call 0xfc9e */
            ii(0xfedb, 2);  or(ax, ax);                                /* or ax, ax */
            ii(0xfedd, 2);  if(jnz(0xfee5, 6)) goto l_0xfee5;          /* jnz 0xfee5 */
            ii(0xfedf, 2);  push(0x1d);                                /* push 0x1d */
            ii(0xfee1, 3);  call(0x1_1995, 0x1ab1);                    /* call 0x1995 */
            ii(0xfee4, 1);  pop(bx);                                   /* pop bx */
        l_0xfee5:
            ii(0xfee5, 3);  mov(ax, memw[ss, bp + 4]);                 /* mov ax, [bp+0x4] */
            ii(0xfee8, 3);  mov(dx, memw[ss, bp + 6]);                 /* mov dx, [bp+0x6] */
            ii(0xfeeb, 2);  neg(ax);                                   /* neg ax */
            ii(0xfeed, 3);  adc(dx, 0);                                /* adc dx, 0x0 */
            ii(0xfef0, 2);  neg(dx);                                   /* neg dx */
            ii(0xfef2, 1);  push(dx);                                  /* push dx */
            ii(0xfef3, 1);  push(ax);                                  /* push ax */
            ii(0xfef4, 3);  call(0xfd72, -0x185);                      /* call 0xfd72 */
            ii(0xfef7, 1);  pop(bx);                                   /* pop bx */
            ii(0xfef8, 1);  pop(bx);                                   /* pop bx */
            ii(0xfef9, 1);  sti();                                     /* sti */
            ii(0xfefa, 3);  mov(ax, memw[ss, bp - 4]);                 /* mov ax, [bp-0x4] */
            ii(0xfefd, 3);  mov(dx, memw[ss, bp - 2]);                 /* mov dx, [bp-0x2] */
            ii(0xff00, 1);  leave();                                   /* leave */
            ii(0xff01, 1);  ret(); return;                             /* ret */
        l_0xff02:
            ii(0xff02, 4);  cmp(memw[ds, 0x11fc], dx);                 /* cmp [0x11fc], dx */
            ii(0xff06, 2);  if(ja(0xff17, 0xf)) goto l_0xff17;         /* ja 0xff17 */
            ii(0xff08, 2);  if(jb(0xff10, 6)) goto l_0xff10;           /* jb 0xff10 */
            ii(0xff0a, 4);  cmp(memw[ds, 0x11fa], ax);                 /* cmp [0x11fa], ax */
            ii(0xff0e, 2);  if(jae(0xff17, 7)) goto l_0xff17;          /* jae 0xff17 */
        l_0xff10:
            ii(0xff10, 3);  mov(memw[ds, 0x11fa], ax);                 /* mov [0x11fa], ax */
            ii(0xff13, 4);  mov(memw[ds, 0x11fc], dx);                 /* mov [0x11fc], dx */
        l_0xff17:
            ii(0xff17, 2);  push(0);                                   /* push 0x0 */
            ii(0xff19, 3);  mov(ax, memw[ss, bp - 4]);                 /* mov ax, [bp-0x4] */
            ii(0xff1c, 3);  mov(dx, memw[ss, bp - 2]);                 /* mov dx, [bp-0x2] */
            ii(0xff1f, 3);  mov(memw[ss, bp - 8], ax);                 /* mov [bp-0x8], ax */
            ii(0xff22, 3);  mov(memw[ss, bp - 6], dx);                 /* mov [bp-0x6], dx */
            ii(0xff25, 1);  push(dx);                                  /* push dx */
            ii(0xff26, 1);  push(ax);                                  /* push ax */
            ii(0xff27, 3);  call(0x1_1b21, 0x1bf7);                    /* call 0x1b21 */
            ii(0xff2a, 3);  add(sp, 6);                                /* add sp, 0x6 */
            ii(0xff2d, 3);  mov(memw[ss, bp - 4], ax);                 /* mov [bp-0x4], ax */
            ii(0xff30, 3);  mov(memw[ss, bp - 2], dx);                 /* mov [bp-0x2], dx */
            ii(0xff33, 2);  or(dx, ax);                                /* or dx, ax */
            ii(0xff35, 2);  if(jnz(0xff3a, 3)) goto l_0xff3a;          /* jnz 0xff3a */
            ii(0xff37, 3);  jmp(0xfdfd, -0x13d); goto l_0xfdfd;        /* jmp 0xfdfd */
        l_0xff3a:
            ii(0xff3a, 3);  mov(ax, memw[ss, bp - 8]);                 /* mov ax, [bp-0x8] */
            ii(0xff3d, 3);  mov(dx, memw[ss, bp - 6]);                 /* mov dx, [bp-0x6] */
            ii(0xff40, 3);  cmp(memw[ss, bp - 2], dx);                 /* cmp [bp-0x2], dx */
            ii(0xff43, 2);  if(jb(0xff5c, 0x17)) goto l_0xff5c;        /* jb 0xff5c */
            ii(0xff45, 2);  if(ja(0xff4c, 5)) goto l_0xff4c;           /* ja 0xff4c */
            ii(0xff47, 3);  cmp(memw[ss, bp - 4], ax);                 /* cmp [bp-0x4], ax */
            ii(0xff4a, 2);  if(jb(0xff5c, 0x10)) goto l_0xff5c;        /* jb 0xff5c */
        l_0xff4c:
            ii(0xff4c, 3);  push(memw[ss, bp - 2]);                    /* push word [bp-0x2] */
            ii(0xff4f, 3);  push(memw[ss, bp - 4]);                    /* push word [bp-0x4] */
            ii(0xff52, 3);  call(0xfc9e, -0x2b7);                      /* call 0xfc9e */
            ii(0xff55, 2);  or(ax, ax);                                /* or ax, ax */
            ii(0xff57, 2);  if(jz(0xff5c, 3)) goto l_0xff5c;           /* jz 0xff5c */
            ii(0xff59, 3);  jmp(0xfdfd, -0x15f); goto l_0xfdfd;        /* jmp 0xfdfd */
        l_0xff5c:
            ii(0xff5c, 2);  push(0x1d);                                /* push 0x1d */
            ii(0xff5e, 3);  call(0x1_1995, 0x1a34);                    /* call 0x1995 */
            ii(0xff61, 1);  pop(bx);                                   /* pop bx */
            ii(0xff62, 3);  jmp(0xfdfd, -0x168); goto l_0xfdfd;        /* jmp 0xfdfd */
        l_0xff65:
            ii(0xff65, 1);  sti();                                     /* sti */
            ii(0xff66, 5);  cmp(memw[ds, 0x1206], 0);                  /* cmp word [0x1206], 0x0 */
            ii(0xff6b, 2);  if(jnz(0xff70, 3)) goto l_0xff70;          /* jnz 0xff70 */
            ii(0xff6d, 3);  jmp(0xfde4, -0x18c); goto l_0xfde4;        /* jmp 0xfde4 */
        l_0xff70:
            ii(0xff70, 3);  mov(ax, memw[ss, bp - 20]);                /* mov ax, [bp-0x14] */
            ii(0xff73, 3);  inc(memw[ss, bp - 20]);                    /* inc word [bp-0x14] */
            ii(0xff76, 2);  or(ax, ax);                                /* or ax, ax */
            ii(0xff78, 2);  if(jz(0xff7d, 3)) goto l_0xff7d;           /* jz 0xff7d */
            ii(0xff7a, 3);  jmp(0xfde4, -0x199); goto l_0xfde4;        /* jmp 0xfde4 */
        l_0xff7d:
            ii(0xff7d, 3);  mov(ax, memw[ds, 0x1206]);                 /* mov ax, [0x1206] */
            ii(0xff80, 3);  shr(ax, 6);                                /* shr ax, 0x6 */
            ii(0xff83, 2);  mov(dx, ax);                               /* mov dx, ax */
            ii(0xff85, 3);  mov(ax, memw[ds, 0x1206]);                 /* mov ax, [0x1206] */
            ii(0xff88, 3);  shl(ax, 0xa);                              /* shl ax, 0xa */
            ii(0xff8b, 2);  mov(bx, dx);                               /* mov bx, dx */
            ii(0xff8d, 1);  cwd();                                     /* cwd */
            ii(0xff8e, 2);  or(dx, bx);                                /* or dx, bx */
            ii(0xff90, 3);  mov(memw[ss, bp - 18], ax);                /* mov [bp-0x12], ax */
            ii(0xff93, 3);  mov(memw[ss, bp - 16], dx);                /* mov [bp-0x10], dx */
            ii(0xff96, 3);  push(memw[ss, bp + 6]);                    /* push word [bp+0x6] */
            ii(0xff99, 3);  push(memw[ss, bp + 4]);                    /* push word [bp+0x4] */
            ii(0xff9c, 3);  call(0x1_1ba7, 0x1c08);                    /* call 0x1ba7 */
            ii(0xff9f, 1);  pop(bx);                                   /* pop bx */
            ii(0xffa0, 1);  pop(bx);                                   /* pop bx */
            ii(0xffa1, 3);  cmp(dx, memw[ss, bp - 16]);                /* cmp dx, [bp-0x10] */
            ii(0xffa4, 2);  if(jl(0xffb3, 0xd)) goto l_0xffb3;         /* jl 0xffb3 */
            ii(0xffa6, 2);  if(jg(0xffad, 5)) goto l_0xffad;           /* jg 0xffad */
            ii(0xffa8, 3);  cmp(ax, memw[ss, bp - 18]);                /* cmp ax, [bp-0x12] */
            ii(0xffab, 2);  if(jbe(0xffb3, 6)) goto l_0xffb3;          /* jbe 0xffb3 */
        l_0xffad:
            ii(0xffad, 3);  mov(memw[ss, bp - 18], ax);                /* mov [bp-0x12], ax */
            ii(0xffb0, 3);  mov(memw[ss, bp - 16], dx);                /* mov [bp-0x10], dx */
        l_0xffb3:
            ii(0xffb3, 2);  push(1);                                   /* push 0x1 */
            ii(0xffb5, 3);  mov(ax, memw[ds, 0xaa8]);                  /* mov ax, [0xaa8] */
            ii(0xffb8, 4);  mov(dx, memw[ds, 0xaaa]);                  /* mov dx, [0xaaa] */
            ii(0xffbc, 3);  add(ax, memw[ss, bp - 18]);                /* add ax, [bp-0x12] */
            ii(0xffbf, 3);  adc(dx, memw[ss, bp - 16]);                /* adc dx, [bp-0x10] */
            ii(0xffc2, 1);  push(dx);                                  /* push dx */
            ii(0xffc3, 1);  push(ax);                                  /* push ax */
            ii(0xffc4, 3);  call(0x1_1642, 0x167b);                    /* call 0x1642 */
            ii(0xffc7, 3);  add(sp, 6);                                /* add sp, 0x6 */
            ii(0xffca, 2);  or(dx, ax);                                /* or dx, ax */
            ii(0xffcc, 2);  if(jz(0xffd1, 3)) goto l_0xffd1;           /* jz 0xffd1 */
            ii(0xffce, 3);  jmp(0xfdba, -0x217); goto l_0xfdba;        /* jmp 0xfdba */
        l_0xffd1:
            ii(0xffd1, 3);  jmp(0xfde4, -0x1f0); goto l_0xfde4;        /* jmp 0xfde4 */
        }
    }
}
