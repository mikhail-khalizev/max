using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x3658-7f8ab8ab")]
        public void Method_0000_3658()
        {
            ii(0x3658, 1);  cld();                                     /* cld */
            ii(0x3659, 1);  push(ss);                                  /* push ss */
            ii(0x365a, 1);  pop(ds);                                   /* pop ds */
            ii(0x365b, 4);  inc(memb[ds, 0x9f8]);                      /* inc byte [0x9f8] */
            ii(0x365f, 2);  if(jnz(0x36c2, 0x61)) goto l_0x36c2;       /* jnz 0x36c2 */
            ii(0x3661, 3);  push(0xf8a);                               /* push 0xf8a */
            ii(0x3664, 3);  call(0x4888, 0x1221);                      /* call 0x4888 */
            ii(0x3667, 1);  pop(cx);                                   /* pop cx */
            ii(0x3668, 1);  push(es);                                  /* push es */
            ii(0x3669, 2);  xor(di, di);                               /* xor di, di */
            ii(0x366b, 3);  mov(cx, 0x200);                            /* mov cx, 0x200 */
            ii(0x366e, 2);  mov(ax, cs);                               /* mov ax, cs */
            ii(0x3670, 4);  mov(bx, memw[ds, 0x56]);                   /* mov bx, [0x56] */
            ii(0x3674, 4);  mov(dx, memw[ds, 0x58]);                   /* mov dx, [0x58] */
        l_0x3678:
            ii(0x3678, 2);  if(jcxz(0x369e, 0x24)) goto l_0x369e;      /* jcxz 0x369e */
            ii(0x367a, 2);  repne(() => scasw());                      /* repne scasw */
            ii(0x367c, 2);  if(jnz(0x369e, 0x20)) goto l_0x369e;       /* jnz 0x369e */
            ii(0x367e, 4);  test(di, 2);                               /* test di, 0x2 */
            ii(0x3682, 2);  if(jnz(0x3678, -0xc)) goto l_0x3678;       /* jnz 0x3678 */
            ii(0x3684, 6);  cmp(memw[es, di - 4], 0x12cc);             /* cmp word [es:di-0x4], 0x12cc */
            ii(0x368a, 2);  if(jz(0x3678, -0x14)) goto l_0x3678;       /* jz 0x3678 */
            ii(0x368c, 6);  cmp(memw[es, di - 4], 0x14d8);             /* cmp word [es:di-0x4], 0x14d8 */
            ii(0x3692, 2);  if(jz(0x3678, -0x1c)) goto l_0x3678;       /* jz 0x3678 */
            ii(0x3694, 4);  mov(memw[es, di - 4], bx);                 /* mov [es:di-0x4], bx */
            ii(0x3698, 4);  mov(memw[es, di - 2], dx);                 /* mov [es:di-0x2], dx */
            ii(0x369c, 2);  jmp(0x3678, -0x26); goto l_0x3678;         /* jmp 0x3678 */
        l_0x369e:
            ii(0x369e, 1);  pop(es);                                   /* pop es */
            ii(0x369f, 5);  cmp(memb[ds, 0xcda], 0);                   /* cmp byte [0xcda], 0x0 */
            ii(0x36a4, 2);  if(jnz(0x36ad, 7)) goto l_0x36ad;          /* jnz 0x36ad */
            ii(0x36a6, 4);  inc(memb[ds, 0xcda]);                      /* inc byte [0xcda] */
            ii(0x36aa, 3);  call(0x4a31, 0x1384);                      /* call 0x4a31 */
        l_0x36ad:
            ii(0x36ad, 5);  cmp(memw[ds, 0xa14], 0);                   /* cmp word [0xa14], 0x0 */
            ii(0x36b2, 2);  if(jz(0x36b7, 3)) goto l_0x36b7;           /* jz 0x36b7 */
            ii(0x36b4, 3);  call(0x4cb4, 0x15fd);                      /* call 0x4cb4 */
        l_0x36b7:
            ii(0x36b7, 1);  cli();                                     /* cli */
            ii(0x36b8, 3);  call(0x375c, 0xa1);                        /* call 0x375c */
            ii(0x36bb, 1);  sti();                                     /* sti */
            ii(0x36bc, 3);  call(0x50fa, 0x1a3b);                      /* call 0x50fa */
            ii(0x36bf, 3);  call(0x499d, 0x12db);                      /* call 0x499d */
        l_0x36c2:
            ii(0x36c2, 5);  cmp(memb[ds, 0x2e], 0xb);                  /* cmp byte [0x2e], 0xb */
            ii(0x36c7, 2);  if(jnz(0x36ce, 5)) goto l_0x36ce;          /* jnz 0x36ce */
            ii(0x36c9, 3);  call(0x61e3, 0x2b17);                      /* call 0x61e3 */
            ii(0x36cc, 2);  jmp(0x3702, 0x34); goto l_0x3702;          /* jmp 0x3702 */
        l_0x36ce:
            ii(0x36ce, 5);  test(memb[ds, 0x47], 0x80);                /* test byte [0x47], 0x80 */
            ii(0x36d3, 2);  if(jz(0x36e8, 0x13)) goto l_0x36e8;        /* jz 0x36e8 */
            ii(0x36d5, 3);  mov(ax, 0xbfde);                           /* mov ax, 0xbfde */
            ii(0x36d8, 3);  mov(bx, 0xa);                              /* mov bx, 0xa */
            ii(0x36db, 3);  call(0x44e4, 0xe06);                       /* call 0x44e4 */
            ii(0x36de, 2);  or(ax, ax);                                /* or ax, ax */
            ii(0x36e0, 2);  if(jl(0x36e8, 6)) goto l_0x36e8;           /* jl 0x36e8 */
            ii(0x36e2, 6);  mov(memw[ds, 0xadc], 0);                   /* mov word [0xadc], 0x0 */
        l_0x36e8:
            ii(0x36e8, 5);  cmp(memb[ds, 0x2e], 2);                    /* cmp byte [0x2e], 0x2 */
            ii(0x36ed, 2);  if(jle(0x3702, 0x13)) goto l_0x3702;       /* jle 0x3702 */
            ii(0x36ef, 5);  test(memb[ds, 0x47], 1);                   /* test byte [0x47], 0x1 */
            ii(0x36f4, 2);  if(jz(0x3702, 0xc)) goto l_0x3702;         /* jz 0x3702 */
            ii(0x36f6, 1);  cli();                                     /* cli */
            ii(0x36f7, 2);  mov(al, 0xf);                              /* mov al, 0xf */
            ii(0x36f9, 2);  outb(0x70, al);                            /* out 0x70, al */
            ii(0x36fb, 2);  jmp(0x36fd, 0); goto l_0x36fd;             /* jmp 0x36fd */
        l_0x36fd:
            ii(0x36fd, 2);  xor(al, al);                               /* xor al, al */
            ii(0x36ff, 2);  outb(0x71, al);                            /* out 0x71, al */
            ii(0x3701, 1);  sti();                                     /* sti */
        l_0x3702:
            ii(0x3702, 3);  call(0x53e7, 0x1ce2);                      /* call 0x53e7 */
            ii(0x3705, 4);  mov(es, memw[ds, 0xcec]);                  /* mov es, [0xcec] */
            ii(0x3709, 3);  mov(ax, memw[ds, 0x9b8]);                  /* mov ax, [0x9b8] */
            ii(0x370c, 4);  mov(memw[es, 0x2c], ax);                   /* mov [es:0x2c], ax */
            ii(0x3710, 1);  push(es);                                  /* push es */
            ii(0x3711, 4);  push(memw[ds, 0x120a]);                    /* push word [0x120a] */
            ii(0x3715, 3);  call(0x5301, 0x1be9);                      /* call 0x5301 */
            ii(0x3718, 1);  pop(cx);                                   /* pop cx */
            ii(0x3719, 2);  xor(bx, bx);                               /* xor bx, bx */
            ii(0x371b, 2);  mov(es, bx);                               /* mov es, bx */
            ii(0x371d, 5);  test(memb[ds, 0x47], 0x80);                /* test byte [0x47], 0x80 */
            ii(0x3722, 2);  if(jz(0x372f, 0xb)) goto l_0x372f;         /* jz 0x372f */
            ii(0x3724, 3);  mov(ax, 0xbfde);                           /* mov ax, 0xbfde */
            ii(0x3727, 3);  mov(bx, 0x15);                             /* mov bx, 0x15 */
            ii(0x372a, 3);  mov(cx, 5);                                /* mov cx, 0x5 */
            ii(0x372d, 2);  @int(0x15);                                /* int 0x15 */
        l_0x372f:
            ii(0x372f, 1);  pop(es);                                   /* pop es */
            ii(0x3730, 7);  cmp(memw[es, 0xa], 0x10);                  /* cmp word [es:0xa], 0x10 */
            ii(0x3737, 2);  if(jnz(0x3750, 0x17)) goto l_0x3750;       /* jnz 0x3750 */
            ii(0x3739, 2);  mov(ax, cs);                               /* mov ax, cs */
            ii(0x373b, 5);  cmp(memw[es, 0xc], ax);                    /* cmp [es:0xc], ax */
            ii(0x3740, 2);  if(jnz(0x3750, 0xe)) goto l_0x3750;        /* jnz 0x3750 */
            ii(0x3742, 3);  mov(ax, memw[ds, 0x10c2]);                 /* mov ax, [0x10c2] */
            ii(0x3745, 4);  mov(memw[es, 0xa], ax);                    /* mov [es:0xa], ax */
            ii(0x3749, 3);  mov(ax, memw[ds, 0x10c4]);                 /* mov ax, [0x10c4] */
            ii(0x374c, 4);  mov(memw[es, 0xc], ax);                    /* mov [es:0xc], ax */
        l_0x3750:
            ii(0x3750, 5);  cmp(memb[ds, 0x2f], 3);                    /* cmp byte [0x2f], 0x3 */
            ii(0x3755, 2);  if(jb(0x375b, 4)) goto l_0x375b;           /* jb 0x375b */
            ii(0x3757, 4);  mov(eax, memd[ds, 0x10f2]);                /* mov eax, [0x10f2] */
        l_0x375b:
            ii(0x375b, 1);  ret();                                     /* ret */
        }
    }
}
