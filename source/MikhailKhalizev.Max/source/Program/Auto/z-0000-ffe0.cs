using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xffe0-2116cdf0")]
        public void Method_0000_ffe0()
        {
            ii(0xffe0, 4);  enter(0xc, 0);                             /* enter 0xc, 0x0 */
            ii(0xffe4, 1);  push(di);                                  /* push di */
            ii(0xffe5, 1);  push(si);                                  /* push si */
            ii(0xffe6, 3);  mov(ax, memw[ss, bp + 4]);                 /* mov ax, [bp+0x4] */
            ii(0xffe9, 3);  mov(dx, memw[ss, bp + 6]);                 /* mov dx, [bp+0x6] */
            ii(0xffec, 4);  cmp(memw[ds, 0x9a], dx);                   /* cmp [0x9a], dx */
            ii(0xfff0, 2);  if(jbe(0xfff5, 3)) goto l_0xfff5;          /* jbe 0xfff5 */
            ii(0xfff2, 3);  jmp(0x1_0268, 0x273); goto l_0x1_0268;     /* jmp 0x268 */
        l_0xfff5:
            ii(0xfff5, 2);  if(jb(0xfffd, 6)) goto l_0xfffd;           /* jb 0xfffd */
            ii(0xfff7, 4);  cmp(memw[ds, 0x98], ax);                   /* cmp [0x98], ax */
            ii(0xfffb, 2);  if(ja(0x1_0009, 0xc)) goto l_0x1_0009;     /* ja 0x9 */
        l_0xfffd:
            ii(0xfffd, 3);  add(ax, memw[ss, bp + 8]);                 /* add ax, [bp+0x8] */
            ii(0x1_0000, 3);  adc(dx, memw[ss, bp + 10]);              /* adc dx, [bp+0xa] */
            ii(0x1_0003, 4);  cmp(dx, memw[ds, 0x9e]);                 /* cmp dx, [0x9e] */
            ii(0x1_0007, 2);  if(jbe(0x1_000c, 3)) goto l_0x1_000c;    /* jbe 0xc */
        l_0x1_0009:
            ii(0x1_0009, 3);  jmp(0x1_0268, 0x25c); goto l_0x1_0268;   /* jmp 0x268 */
        l_0x1_000c:
            ii(0x1_000c, 2);  if(jb(0x1_0014, 6)) goto l_0x1_0014;     /* jb 0x14 */
            ii(0x1_000e, 4);  cmp(ax, memw[ds, 0x9c]);                 /* cmp ax, [0x9c] */
            ii(0x1_0012, 2);  if(ja(0x1_001c, 8)) goto l_0x1_001c;     /* ja 0x1c */
        l_0x1_0014:
            ii(0x1_0014, 3);  mov(ax, memw[ss, bp + 10]);              /* mov ax, [bp+0xa] */
            ii(0x1_0017, 3);  or(ax, memw[ss, bp + 8]);                /* or ax, [bp+0x8] */
            ii(0x1_001a, 2);  if(jnz(0x1_001f, 3)) goto l_0x1_001f;    /* jnz 0x1f */
        l_0x1_001c:
            ii(0x1_001c, 3);  jmp(0x1_0268, 0x249); goto l_0x1_0268;   /* jmp 0x268 */
        l_0x1_001f:
            ii(0x1_001f, 5);  test(memb[ds, 0x47], 0x80);              /* test byte [0x47], 0x80 */
            ii(0x1_0024, 2);  if(jz(0x1_002c, 6)) goto l_0x1_002c;     /* jz 0x2c */
            ii(0x1_0026, 3);  push(0x111c);                            /* push 0x111c */
            ii(0x1_0029, 3);  call(0xffd4, -0x58);                     /* call 0xffd4 */
        l_0x1_002c:
            ii(0x1_002c, 1);  cli();                                   /* cli */
            ii(0x1_002d, 2);  push(0);                                 /* push 0x0 */
            ii(0x1_002f, 3);  mov(ax, memw[ds, 0x98]);                 /* mov ax, [0x98] */
            ii(0x1_0032, 4);  mov(dx, memw[ds, 0x9a]);                 /* mov dx, [0x9a] */
            ii(0x1_0036, 3);  mov(memw[ss, bp - 8], ax);               /* mov [bp-0x8], ax */
            ii(0x1_0039, 3);  mov(memw[ss, bp - 6], dx);               /* mov [bp-0x6], dx */
        l_0x1_003c:
            ii(0x1_003c, 1);  push(dx);                                /* push dx */
            ii(0x1_003d, 1);  push(ax);                                /* push ax */
            ii(0x1_003e, 3);  call(0x1_1b21, 0x1ae0);                  /* call 0x1b21 */
            ii(0x1_0041, 3);  add(sp, 6);                              /* add sp, 0x6 */
            ii(0x1_0044, 3);  mov(memw[ss, bp - 4], ax);               /* mov [bp-0x4], ax */
            ii(0x1_0047, 3);  mov(memw[ss, bp - 2], dx);               /* mov [bp-0x2], dx */
            ii(0x1_004a, 3);  mov(ax, memw[ss, bp + 4]);               /* mov ax, [bp+0x4] */
            ii(0x1_004d, 3);  mov(dx, memw[ss, bp + 6]);               /* mov dx, [bp+0x6] */
            ii(0x1_0050, 3);  cmp(memw[ss, bp - 2], dx);               /* cmp [bp-0x2], dx */
            ii(0x1_0053, 2);  if(ja(0x1_0074, 0x1f)) goto l_0x1_0074;  /* ja 0x74 */
            ii(0x1_0055, 2);  if(jb(0x1_005c, 5)) goto l_0x1_005c;     /* jb 0x5c */
            ii(0x1_0057, 3);  cmp(memw[ss, bp - 4], ax);               /* cmp [bp-0x4], ax */
            ii(0x1_005a, 2);  if(jae(0x1_0074, 0x18)) goto l_0x1_0074; /* jae 0x74 */
        l_0x1_005c:
            ii(0x1_005c, 3);  mov(ax, memw[ss, bp - 2]);               /* mov ax, [bp-0x2] */
            ii(0x1_005f, 3);  or(ax, memw[ss, bp - 4]);                /* or ax, [bp-0x4] */
            ii(0x1_0062, 2);  if(jz(0x1_0074, 0x10)) goto l_0x1_0074;  /* jz 0x74 */
            ii(0x1_0064, 3);  mov(ax, memw[ss, bp - 4]);               /* mov ax, [bp-0x4] */
            ii(0x1_0067, 3);  mov(dx, memw[ss, bp - 2]);               /* mov dx, [bp-0x2] */
            ii(0x1_006a, 3);  mov(memw[ss, bp - 8], ax);               /* mov [bp-0x8], ax */
            ii(0x1_006d, 3);  mov(memw[ss, bp - 6], dx);               /* mov [bp-0x6], dx */
            ii(0x1_0070, 2);  push(0);                                 /* push 0x0 */
            ii(0x1_0072, 2);  jmp(0x1_003c, -0x38); goto l_0x1_003c;   /* jmp 0x3c */
        l_0x1_0074:
            ii(0x1_0074, 3);  mov(ax, memw[ss, bp + 4]);               /* mov ax, [bp+0x4] */
            ii(0x1_0077, 3);  mov(dx, memw[ss, bp + 6]);               /* mov dx, [bp+0x6] */
            ii(0x1_007a, 3);  cmp(memw[ss, bp - 4], ax);               /* cmp [bp-0x4], ax */
            ii(0x1_007d, 2);  if(jnz(0x1_0087, 8)) goto l_0x1_0087;    /* jnz 0x87 */
            ii(0x1_007f, 3);  cmp(memw[ss, bp - 2], dx);               /* cmp [bp-0x2], dx */
            ii(0x1_0082, 2);  if(jnz(0x1_0087, 3)) goto l_0x1_0087;    /* jnz 0x87 */
            ii(0x1_0084, 3);  jmp(0x1_025b, 0x1d4); goto l_0x1_025b;   /* jmp 0x25b */
        l_0x1_0087:
            ii(0x1_0087, 3);  mov(ax, memw[ss, bp - 2]);               /* mov ax, [bp-0x2] */
            ii(0x1_008a, 3);  or(ax, memw[ss, bp - 4]);                /* or ax, [bp-0x4] */
            ii(0x1_008d, 2);  if(jz(0x1_00ad, 0x1e)) goto l_0x1_00ad;  /* jz 0xad */
            ii(0x1_008f, 3);  mov(ax, memw[ss, bp + 8]);               /* mov ax, [bp+0x8] */
            ii(0x1_0092, 3);  mov(dx, memw[ss, bp + 10]);              /* mov dx, [bp+0xa] */
            ii(0x1_0095, 3);  add(ax, memw[ss, bp + 4]);               /* add ax, [bp+0x4] */
            ii(0x1_0098, 3);  adc(dx, memw[ss, bp + 6]);               /* adc dx, [bp+0x6] */
            ii(0x1_009b, 3);  cmp(dx, memw[ss, bp - 2]);               /* cmp dx, [bp-0x2] */
            ii(0x1_009e, 2);  if(jb(0x1_00ad, 0xd)) goto l_0x1_00ad;   /* jb 0xad */
            ii(0x1_00a0, 2);  if(jbe(0x1_00a5, 3)) goto l_0x1_00a5;    /* jbe 0xa5 */
            ii(0x1_00a2, 3);  jmp(0x1_025b, 0x1b6); goto l_0x1_025b;   /* jmp 0x25b */
        l_0x1_00a5:
            ii(0x1_00a5, 3);  cmp(ax, memw[ss, bp - 4]);               /* cmp ax, [bp-0x4] */
            ii(0x1_00a8, 2);  if(jbe(0x1_00ad, 3)) goto l_0x1_00ad;    /* jbe 0xad */
            ii(0x1_00aa, 3);  jmp(0x1_025b, 0x1ae); goto l_0x1_025b;   /* jmp 0x25b */
        l_0x1_00ad:
            ii(0x1_00ad, 2);  push(4);                                 /* push 0x4 */
            ii(0x1_00af, 3);  push(memw[ss, bp - 6]);                  /* push word [bp-0x6] */
            ii(0x1_00b2, 3);  push(memw[ss, bp - 8]);                  /* push word [bp-0x8] */
            ii(0x1_00b5, 3);  call(0x1_1b21, 0x1a69);                  /* call 0x1b21 */
            ii(0x1_00b8, 3);  add(sp, 6);                              /* add sp, 0x6 */
            ii(0x1_00bb, 3);  add(ax, memw[ss, bp - 8]);               /* add ax, [bp-0x8] */
            ii(0x1_00be, 3);  adc(dx, memw[ss, bp - 6]);               /* adc dx, [bp-0x6] */
            ii(0x1_00c1, 3);  cmp(dx, memw[ss, bp + 6]);               /* cmp dx, [bp+0x6] */
            ii(0x1_00c4, 2);  if(jb(0x1_00d0, 0xa)) goto l_0x1_00d0;   /* jb 0xd0 */
            ii(0x1_00c6, 2);  if(ja(0x1_00cd, 5)) goto l_0x1_00cd;     /* ja 0xcd */
            ii(0x1_00c8, 3);  cmp(ax, memw[ss, bp + 4]);               /* cmp ax, [bp+0x4] */
            ii(0x1_00cb, 2);  if(jbe(0x1_00d0, 3)) goto l_0x1_00d0;    /* jbe 0xd0 */
        l_0x1_00cd:
            ii(0x1_00cd, 3);  jmp(0x1_025b, 0x18b); goto l_0x1_025b;   /* jmp 0x25b */
        l_0x1_00d0:
            ii(0x1_00d0, 3);  push(memw[ss, bp + 6]);                  /* push word [bp+0x6] */
            ii(0x1_00d3, 3);  push(memw[ss, bp + 4]);                  /* push word [bp+0x4] */
            ii(0x1_00d6, 2);  push(0);                                 /* push 0x0 */
            ii(0x1_00d8, 3);  push(memw[ss, bp - 6]);                  /* push word [bp-0x6] */
            ii(0x1_00db, 3);  push(memw[ss, bp - 8]);                  /* push word [bp-0x8] */
            ii(0x1_00de, 3);  call(0x1_1b37, 0x1a56);                  /* call 0x1b37 */
            ii(0x1_00e1, 3);  add(sp, 0xa);                            /* add sp, 0xa */
            ii(0x1_00e4, 3);  push(memw[ss, bp - 2]);                  /* push word [bp-0x2] */
            ii(0x1_00e7, 3);  push(memw[ss, bp - 4]);                  /* push word [bp-0x4] */
            ii(0x1_00ea, 2);  push(0);                                 /* push 0x0 */
            ii(0x1_00ec, 3);  push(memw[ss, bp + 6]);                  /* push word [bp+0x6] */
            ii(0x1_00ef, 3);  push(memw[ss, bp + 4]);                  /* push word [bp+0x4] */
            ii(0x1_00f2, 3);  call(0x1_1b37, 0x1a42);                  /* call 0x1b37 */
            ii(0x1_00f5, 3);  add(sp, 0xa);                            /* add sp, 0xa */
            ii(0x1_00f8, 3);  mov(ax, memw[ss, bp + 8]);               /* mov ax, [bp+0x8] */
            ii(0x1_00fb, 3);  mov(dx, memw[ss, bp + 10]);              /* mov dx, [bp+0xa] */
            ii(0x1_00fe, 3);  mov(memw[ss, bp - 12], ax);              /* mov [bp-0xc], ax */
            ii(0x1_0101, 3);  mov(memw[ss, bp - 10], dx);              /* mov [bp-0xa], dx */
            ii(0x1_0104, 2);  push(4);                                 /* push 0x4 */
            ii(0x1_0106, 3);  push(memw[ss, bp - 6]);                  /* push word [bp-0x6] */
            ii(0x1_0109, 3);  push(memw[ss, bp - 8]);                  /* push word [bp-0x8] */
            ii(0x1_010c, 3);  call(0x1_1b21, 0x1a12);                  /* call 0x1b21 */
            ii(0x1_010f, 3);  add(sp, 6);                              /* add sp, 0x6 */
            ii(0x1_0112, 3);  add(ax, memw[ss, bp - 8]);               /* add ax, [bp-0x8] */
            ii(0x1_0115, 3);  adc(dx, memw[ss, bp - 6]);               /* adc dx, [bp-0x6] */
            ii(0x1_0118, 3);  cmp(ax, memw[ss, bp + 4]);               /* cmp ax, [bp+0x4] */
            ii(0x1_011b, 2);  if(jnz(0x1_016e, 0x51)) goto l_0x1_016e; /* jnz 0x16e */
            ii(0x1_011d, 3);  cmp(dx, memw[ss, bp + 6]);               /* cmp dx, [bp+0x6] */
            ii(0x1_0120, 2);  if(jnz(0x1_016e, 0x4c)) goto l_0x1_016e; /* jnz 0x16e */
            ii(0x1_0122, 2);  push(4);                                 /* push 0x4 */
            ii(0x1_0124, 3);  push(memw[ss, bp - 6]);                  /* push word [bp-0x6] */
            ii(0x1_0127, 3);  push(memw[ss, bp - 8]);                  /* push word [bp-0x8] */
            ii(0x1_012a, 3);  call(0x1_1b21, 0x19f4);                  /* call 0x1b21 */
            ii(0x1_012d, 3);  add(sp, 6);                              /* add sp, 0x6 */
            ii(0x1_0130, 3);  add(ax, memw[ss, bp - 12]);              /* add ax, [bp-0xc] */
            ii(0x1_0133, 3);  adc(dx, memw[ss, bp - 10]);              /* adc dx, [bp-0xa] */
            ii(0x1_0136, 3);  mov(memw[ss, bp - 12], ax);              /* mov [bp-0xc], ax */
            ii(0x1_0139, 3);  mov(memw[ss, bp - 10], dx);              /* mov [bp-0xa], dx */
            ii(0x1_013c, 1);  push(dx);                                /* push dx */
            ii(0x1_013d, 1);  push(ax);                                /* push ax */
            ii(0x1_013e, 2);  push(4);                                 /* push 0x4 */
            ii(0x1_0140, 3);  push(memw[ss, bp - 6]);                  /* push word [bp-0x6] */
            ii(0x1_0143, 3);  push(memw[ss, bp - 8]);                  /* push word [bp-0x8] */
            ii(0x1_0146, 3);  call(0x1_1b37, 0x19ee);                  /* call 0x1b37 */
            ii(0x1_0149, 3);  add(sp, 0xa);                            /* add sp, 0xa */
            ii(0x1_014c, 3);  push(memw[ss, bp - 2]);                  /* push word [bp-0x2] */
            ii(0x1_014f, 3);  push(memw[ss, bp - 4]);                  /* push word [bp-0x4] */
            ii(0x1_0152, 2);  push(0);                                 /* push 0x0 */
            ii(0x1_0154, 3);  push(memw[ss, bp - 6]);                  /* push word [bp-0x6] */
            ii(0x1_0157, 3);  push(memw[ss, bp - 8]);                  /* push word [bp-0x8] */
            ii(0x1_015a, 3);  call(0x1_1b37, 0x19da);                  /* call 0x1b37 */
            ii(0x1_015d, 3);  add(sp, 0xa);                            /* add sp, 0xa */
            ii(0x1_0160, 3);  mov(ax, memw[ss, bp - 8]);               /* mov ax, [bp-0x8] */
            ii(0x1_0163, 3);  mov(dx, memw[ss, bp - 6]);               /* mov dx, [bp-0x6] */
            ii(0x1_0166, 3);  mov(memw[ss, bp + 4], ax);               /* mov [bp+0x4], ax */
            ii(0x1_0169, 3);  mov(memw[ss, bp + 6], dx);               /* mov [bp+0x6], dx */
            ii(0x1_016c, 2);  jmp(0x1_0182, 0x14); goto l_0x1_0182;    /* jmp 0x182 */
        l_0x1_016e:
            ii(0x1_016e, 3);  push(memw[ss, bp + 10]);                 /* push word [bp+0xa] */
            ii(0x1_0171, 3);  push(memw[ss, bp + 8]);                  /* push word [bp+0x8] */
            ii(0x1_0174, 2);  push(4);                                 /* push 0x4 */
            ii(0x1_0176, 3);  push(memw[ss, bp + 6]);                  /* push word [bp+0x6] */
            ii(0x1_0179, 3);  push(memw[ss, bp + 4]);                  /* push word [bp+0x4] */
            ii(0x1_017c, 3);  call(0x1_1b37, 0x19b8);                  /* call 0x1b37 */
            ii(0x1_017f, 3);  add(sp, 0xa);                            /* add sp, 0xa */
        l_0x1_0182:
            ii(0x1_0182, 2);  push(4);                                 /* push 0x4 */
            ii(0x1_0184, 3);  push(memw[ss, bp + 6]);                  /* push word [bp+0x6] */
            ii(0x1_0187, 3);  push(memw[ss, bp + 4]);                  /* push word [bp+0x4] */
            ii(0x1_018a, 3);  call(0x1_1b21, 0x1994);                  /* call 0x1b21 */
            ii(0x1_018d, 3);  add(sp, 6);                              /* add sp, 0x6 */
            ii(0x1_0190, 3);  add(ax, memw[ss, bp + 4]);               /* add ax, [bp+0x4] */
            ii(0x1_0193, 3);  adc(dx, memw[ss, bp + 6]);               /* adc dx, [bp+0x6] */
            ii(0x1_0196, 3);  cmp(ax, memw[ss, bp - 4]);               /* cmp ax, [bp-0x4] */
            ii(0x1_0199, 2);  if(jnz(0x1_01f4, 0x59)) goto l_0x1_01f4; /* jnz 0x1f4 */
            ii(0x1_019b, 3);  cmp(dx, memw[ss, bp - 2]);               /* cmp dx, [bp-0x2] */
            ii(0x1_019e, 2);  if(jnz(0x1_01f4, 0x54)) goto l_0x1_01f4; /* jnz 0x1f4 */
            ii(0x1_01a0, 2);  push(4);                                 /* push 0x4 */
            ii(0x1_01a2, 1);  push(dx);                                /* push dx */
            ii(0x1_01a3, 1);  push(ax);                                /* push ax */
            ii(0x1_01a4, 3);  call(0x1_1b21, 0x197a);                  /* call 0x1b21 */
            ii(0x1_01a7, 3);  add(sp, 6);                              /* add sp, 0x6 */
            ii(0x1_01aa, 2);  push(4);                                 /* push 0x4 */
            ii(0x1_01ac, 3);  push(memw[ss, bp + 6]);                  /* push word [bp+0x6] */
            ii(0x1_01af, 3);  push(memw[ss, bp + 4]);                  /* push word [bp+0x4] */
            ii(0x1_01b2, 2);  mov(si, ax);                             /* mov si, ax */
            ii(0x1_01b4, 2);  mov(di, dx);                             /* mov di, dx */
            ii(0x1_01b6, 3);  call(0x1_1b21, 0x1968);                  /* call 0x1b21 */
            ii(0x1_01b9, 3);  add(sp, 6);                              /* add sp, 0x6 */
            ii(0x1_01bc, 2);  add(si, ax);                             /* add si, ax */
            ii(0x1_01be, 2);  adc(di, dx);                             /* adc di, dx */
            ii(0x1_01c0, 3);  mov(memw[ss, bp - 12], si);              /* mov [bp-0xc], si */
            ii(0x1_01c3, 3);  mov(memw[ss, bp - 10], di);              /* mov [bp-0xa], di */
            ii(0x1_01c6, 1);  push(di);                                /* push di */
            ii(0x1_01c7, 1);  push(si);                                /* push si */
            ii(0x1_01c8, 2);  push(4);                                 /* push 0x4 */
            ii(0x1_01ca, 3);  push(memw[ss, bp + 6]);                  /* push word [bp+0x6] */
            ii(0x1_01cd, 3);  push(memw[ss, bp + 4]);                  /* push word [bp+0x4] */
            ii(0x1_01d0, 3);  call(0x1_1b37, 0x1964);                  /* call 0x1b37 */
            ii(0x1_01d3, 3);  add(sp, 0xa);                            /* add sp, 0xa */
            ii(0x1_01d6, 2);  push(0);                                 /* push 0x0 */
            ii(0x1_01d8, 3);  push(memw[ss, bp - 2]);                  /* push word [bp-0x2] */
            ii(0x1_01db, 3);  push(memw[ss, bp - 4]);                  /* push word [bp-0x4] */
            ii(0x1_01de, 3);  call(0x1_1b21, 0x1940);                  /* call 0x1b21 */
            ii(0x1_01e1, 3);  add(sp, 6);                              /* add sp, 0x6 */
            ii(0x1_01e4, 1);  push(dx);                                /* push dx */
            ii(0x1_01e5, 1);  push(ax);                                /* push ax */
            ii(0x1_01e6, 2);  push(0);                                 /* push 0x0 */
            ii(0x1_01e8, 3);  push(memw[ss, bp + 6]);                  /* push word [bp+0x6] */
            ii(0x1_01eb, 3);  push(memw[ss, bp + 4]);                  /* push word [bp+0x4] */
            ii(0x1_01ee, 3);  call(0x1_1b37, 0x1946);                  /* call 0x1b37 */
            ii(0x1_01f1, 3);  add(sp, 0xa);                            /* add sp, 0xa */
        l_0x1_01f4:
            ii(0x1_01f4, 3);  push(memw[ss, bp + 10]);                 /* push word [bp+0xa] */
            ii(0x1_01f7, 3);  push(memw[ss, bp + 8]);                  /* push word [bp+0x8] */
            ii(0x1_01fa, 3);  call(0xfd72, -0x48b);                    /* call 0xfd72 */
            ii(0x1_01fd, 1);  pop(bx);                                 /* pop bx */
            ii(0x1_01fe, 1);  pop(bx);                                 /* pop bx */
            ii(0x1_01ff, 1);  sti();                                   /* sti */
            ii(0x1_0200, 5);  cmp(memb[ds, 0x2e], 0xb);                /* cmp byte [0x2e], 0xb */
            ii(0x1_0205, 2);  if(jnz(0x1_025b, 0x54)) goto l_0x1_025b; /* jnz 0x25b */
            ii(0x1_0207, 4);  mov(ah, memb[ds, 0x15]);                 /* mov ah, [0x15] */
            ii(0x1_020b, 3);  and(ax, 0x4000);                         /* and ax, 0x4000 */
            ii(0x1_020e, 3);  cmp(ax, 1);                              /* cmp ax, 0x1 */
            ii(0x1_0211, 2);  sbb(ax, ax);                             /* sbb ax, ax */
            ii(0x1_0213, 1);  inc(ax);                                 /* inc ax */
            ii(0x1_0214, 4);  mov(cl, memb[ds, 0x47]);                 /* mov cl, [0x47] */
            ii(0x1_0218, 3);  and(cl, 0x80);                           /* and cl, 0x80 */
            ii(0x1_021b, 3);  cmp(cl, 1);                              /* cmp cl, 0x1 */
            ii(0x1_021e, 2);  sbb(cx, cx);                             /* sbb cx, cx */
            ii(0x1_0220, 1);  inc(cx);                                 /* inc cx */
            ii(0x1_0221, 2);  xor(ax, cx);                             /* xor ax, cx */
            ii(0x1_0223, 2);  if(jz(0x1_025b, 0x36)) goto l_0x1_025b;  /* jz 0x25b */
            ii(0x1_0225, 5);  cmp(memb[ds, 0x9f8], 1);                 /* cmp byte [0x9f8], 0x1 */
            ii(0x1_022a, 2);  sbb(ax, ax);                             /* sbb ax, ax */
            ii(0x1_022c, 3);  and(ah, 7);                              /* and ah, 0x7 */
            ii(0x1_022f, 3);  add(ah, -0x10 /* 0xf0 */);               /* add ah, 0xf0 */
            ii(0x1_0232, 1);  push(ax);                                /* push ax */
            ii(0x1_0233, 3);  mov(ax, memw[ss, bp - 12]);              /* mov ax, [bp-0xc] */
            ii(0x1_0236, 3);  mov(dx, memw[ss, bp - 10]);              /* mov dx, [bp-0xa] */
            ii(0x1_0239, 3);  add(ax, memw[ss, bp + 4]);               /* add ax, [bp+0x4] */
            ii(0x1_023c, 3);  adc(dx, memw[ss, bp + 6]);               /* adc dx, [bp+0x6] */
            ii(0x1_023f, 3);  sub(ax, 1);                              /* sub ax, 0x1 */
            ii(0x1_0242, 3);  sbb(dx, 0);                              /* sbb dx, 0x0 */
            ii(0x1_0245, 1);  push(dx);                                /* push dx */
            ii(0x1_0246, 1);  push(ax);                                /* push ax */
            ii(0x1_0247, 3);  mov(ax, memw[ss, bp + 4]);               /* mov ax, [bp+0x4] */
            ii(0x1_024a, 3);  mov(dx, memw[ss, bp + 6]);               /* mov dx, [bp+0x6] */
            ii(0x1_024d, 3);  add(ax, 1);                              /* add ax, 0x1 */
            ii(0x1_0250, 3);  adc(dx, 0);                              /* adc dx, 0x0 */
            ii(0x1_0253, 1);  push(dx);                                /* push dx */
            ii(0x1_0254, 1);  push(ax);                                /* push ax */
            ii(0x1_0255, 3);  call(0x1_3364, 0x310c);                  /* call 0x3364 */
            ii(0x1_0258, 3);  add(sp, 0xa);                            /* add sp, 0xa */
        l_0x1_025b:
            ii(0x1_025b, 5);  test(memb[ds, 0x47], 0x80);              /* test byte [0x47], 0x80 */
            ii(0x1_0260, 2);  if(jz(0x1_0268, 6)) goto l_0x1_0268;     /* jz 0x268 */
            ii(0x1_0262, 3);  push(0x111b);                            /* push 0x111b */
            ii(0x1_0265, 3);  call(0xffd4, -0x294);                    /* call 0xffd4 */
        l_0x1_0268:
            ii(0x1_0268, 1);  pop(si);                                 /* pop si */
            ii(0x1_0269, 1);  pop(di);                                 /* pop di */
            ii(0x1_026a, 1);  leave();                                 /* leave */
            ii(0x1_026b, 1);  ret();                                   /* ret */
        }
    }
}
