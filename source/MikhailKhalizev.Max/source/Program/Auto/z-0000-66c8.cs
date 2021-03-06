using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x66c8-fa62eb4f")]
        public void Method_0000_66c8()
        {
            ii(0x66c8, 4);  enter(0xbc, 0);                            /* enter 0xbc, 0x0 */
            ii(0x66cc, 3);  mov(al, memb[ds, 0xe72]);                  /* mov al, [0xe72] */
            ii(0x66cf, 4);  inc(memb[ds, 0xe72]);                      /* inc byte [0xe72] */
            ii(0x66d3, 2);  or(al, al);                                /* or al, al */
            ii(0x66d5, 2);  if(jz(0x66da, 3)) goto l_0x66da;           /* jz 0x66da */
            ii(0x66d7, 3);  jmp(0x685a, 0x180); goto l_0x685a;         /* jmp 0x685a */
        l_0x66da:
            ii(0x66da, 5);  cmp(memw[ds, 0xe70], 0);                   /* cmp word [0xe70], 0x0 */
            ii(0x66df, 2);  if(jge(0x66e8, 7)) goto l_0x66e8;          /* jge 0x66e8 */
            ii(0x66e1, 3);  push(0x1190);                              /* push 0x1190 */
            ii(0x66e4, 3);  call(0x95a8, 0x2ec1);                      /* call 0x95a8 */
            ii(0x66e7, 1);  pop(bx);                                   /* pop bx */
        l_0x66e8:
            ii(0x66e8, 5);  cmp(memw[ds, 0xe70], 0);                   /* cmp word [0xe70], 0x0 */
            ii(0x66ed, 2);  if(jge(0x66f2, 3)) goto l_0x66f2;          /* jge 0x66f2 */
            ii(0x66ef, 3);  jmp(0x685a, 0x168); goto l_0x685a;         /* jmp 0x685a */
        l_0x66f2:
            ii(0x66f2, 2);  sub(ax, ax);                               /* sub ax, ax */
            ii(0x66f4, 4);  mov(memw[ss, bp - 186], ax);               /* mov [bp-0xba], ax */
            ii(0x66f8, 3);  mov(memw[ss, bp - 2], ax);                 /* mov [bp-0x2], ax */
            ii(0x66fb, 4);  mov(memw[ss, bp - 184], ax);               /* mov [bp-0xb8], ax */
            ii(0x66ff, 4);  mov(memw[ss, bp - 182], ax);               /* mov [bp-0xb6], ax */
            ii(0x6703, 3);  push(0xb0);                                /* push 0xb0 */
            ii(0x6706, 1);  push(ax);                                  /* push ax */
            ii(0x6707, 4);  lea(ax, memw[ss, bp - 178]);               /* lea ax, [bp-0xb2] */
            ii(0x670b, 1);  push(ax);                                  /* push ax */
            ii(0x670c, 3);  call(0x663f, -0xd0);                       /* call 0x663f */
            ii(0x670f, 3);  add(sp, 6);                                /* add sp, 0x6 */
            ii(0x6712, 2);  or(ax, ax);                                /* or ax, ax */
            ii(0x6714, 2);  if(jnz(0x6719, 3)) goto l_0x6719;          /* jnz 0x6719 */
            ii(0x6716, 3);  jmp(0x67a3, 0x8a); goto l_0x67a3;          /* jmp 0x67a3 */
        l_0x6719:
            ii(0x6719, 5);  cmp(memb[ss, bp - 178], 0x42);             /* cmp byte [bp-0xb2], 0x42 */
            ii(0x671e, 2);  if(jnz(0x6727, 7)) goto l_0x6727;          /* jnz 0x6727 */
            ii(0x6720, 5);  cmp(memb[ss, bp - 177], 0x57);             /* cmp byte [bp-0xb1], 0x57 */
            ii(0x6725, 2);  if(jz(0x6729, 2)) goto l_0x6729;           /* jz 0x6729 */
        l_0x6727:
            ii(0x6727, 2);  jmp(0x67a3, 0x7a); goto l_0x67a3;          /* jmp 0x67a3 */
        l_0x6729:
            ii(0x6729, 4);  mov(ax, memw[ss, bp - 130]);               /* mov ax, [bp-0x82] */
            ii(0x672d, 4);  or(memw[ds, 0x14], ax);                    /* or [0x14], ax */
            ii(0x6731, 4);  mov(ax, memw[ss, bp - 182]);               /* mov ax, [bp-0xb6] */
            ii(0x6735, 4);  cmp(memw[ss, bp - 168], ax);               /* cmp [bp-0xa8], ax */
            ii(0x6739, 2);  if(jbe(0x6743, 8)) goto l_0x6743;          /* jbe 0x6743 */
            ii(0x673b, 4);  mov(ax, memw[ss, bp - 168]);               /* mov ax, [bp-0xa8] */
            ii(0x673f, 4);  mov(memw[ss, bp - 182], ax);               /* mov [bp-0xb6], ax */
        l_0x6743:
            ii(0x6743, 4);  mov(ax, memw[ss, bp - 184]);               /* mov ax, [bp-0xb8] */
            ii(0x6747, 4);  cmp(memw[ss, bp - 166], ax);               /* cmp [bp-0xa6], ax */
            ii(0x674b, 2);  if(jbe(0x6755, 8)) goto l_0x6755;          /* jbe 0x6755 */
            ii(0x674d, 4);  mov(ax, memw[ss, bp - 166]);               /* mov ax, [bp-0xa6] */
            ii(0x6751, 4);  mov(memw[ss, bp - 184], ax);               /* mov [bp-0xb8], ax */
        l_0x6755:
            ii(0x6755, 3);  mov(ax, memw[ss, bp - 2]);                 /* mov ax, [bp-0x2] */
            ii(0x6758, 4);  cmp(memw[ss, bp - 138], ax);               /* cmp [bp-0x8a], ax */
            ii(0x675c, 2);  if(jbe(0x6765, 7)) goto l_0x6765;          /* jbe 0x6765 */
            ii(0x675e, 4);  mov(ax, memw[ss, bp - 138]);               /* mov ax, [bp-0x8a] */
            ii(0x6762, 3);  mov(memw[ss, bp - 2], ax);                 /* mov [bp-0x2], ax */
        l_0x6765:
            ii(0x6765, 4);  mov(ax, memw[ss, bp - 186]);               /* mov ax, [bp-0xba] */
            ii(0x6769, 4);  cmp(memw[ss, bp - 140], ax);               /* cmp [bp-0x8c], ax */
            ii(0x676d, 2);  if(jbe(0x6777, 8)) goto l_0x6777;          /* jbe 0x6777 */
            ii(0x676f, 4);  mov(ax, memw[ss, bp - 140]);               /* mov ax, [bp-0x8c] */
            ii(0x6773, 4);  mov(memw[ss, bp - 186], ax);               /* mov [bp-0xba], ax */
        l_0x6777:
            ii(0x6777, 4);  mov(ax, memw[ss, bp - 148]);               /* mov ax, [bp-0x94] */
            ii(0x677b, 4);  or(ax, memw[ss, bp - 150]);                /* or ax, [bp-0x96] */
            ii(0x677f, 2);  if(jz(0x67a3, 0x22)) goto l_0x67a3;        /* jz 0x67a3 */
            ii(0x6781, 4);  push(memw[ss, bp - 148]);                  /* push word [bp-0x94] */
            ii(0x6785, 4);  push(memw[ss, bp - 150]);                  /* push word [bp-0x96] */
            ii(0x6789, 3);  call(0x95ba, 0x2e2e);                      /* call 0x95ba */
            ii(0x678c, 1);  pop(bx);                                   /* pop bx */
            ii(0x678d, 1);  pop(bx);                                   /* pop bx */
            ii(0x678e, 3);  push(0xb0);                                /* push 0xb0 */
            ii(0x6791, 4);  lea(ax, memw[ss, bp - 178]);               /* lea ax, [bp-0xb2] */
            ii(0x6795, 1);  push(ax);                                  /* push ax */
            ii(0x6796, 3);  call(0x95d2, 0x2e39);                      /* call 0x95d2 */
            ii(0x6799, 1);  pop(bx);                                   /* pop bx */
            ii(0x679a, 1);  pop(bx);                                   /* pop bx */
            ii(0x679b, 3);  cmp(ax, 0xb0);                             /* cmp ax, 0xb0 */
            ii(0x679e, 2);  if(jnz(0x67a3, 3)) goto l_0x67a3;          /* jnz 0x67a3 */
            ii(0x67a0, 3);  jmp(0x6719, -0x8a); goto l_0x6719;         /* jmp 0x6719 */
        l_0x67a3:
            ii(0x67a3, 5);  cmp(memw[ss, bp - 182], 0);                /* cmp word [bp-0xb6], 0x0 */
            ii(0x67a8, 2);  if(jz(0x67b7, 0xd)) goto l_0x67b7;         /* jz 0x67b7 */
            ii(0x67aa, 4);  mov(ax, memw[ss, bp - 182]);               /* mov ax, [bp-0xb6] */
            ii(0x67ae, 4);  cmp(memw[ds, 0xecc], ax);                  /* cmp [0xecc], ax */
            ii(0x67b2, 2);  if(jbe(0x67b7, 3)) goto l_0x67b7;          /* jbe 0x67b7 */
            ii(0x67b4, 3);  mov(memw[ds, 0x120e], ax);                 /* mov [0x120e], ax */
        l_0x67b7:
            ii(0x67b7, 4);  mov(ax, memw[ss, bp - 186]);               /* mov ax, [bp-0xba] */
            ii(0x67bb, 4);  mov(memw[ss, bp - 180], ax);               /* mov [bp-0xb4], ax */
            ii(0x67bf, 2);  or(ax, ax);                                /* or ax, ax */
            ii(0x67c1, 2);  if(jz(0x67d4, 0x11)) goto l_0x67d4;        /* jz 0x67d4 */
            ii(0x67c3, 5);  mov(memb[ds, 0xa16], 2);                   /* mov byte [0xa16], 0x2 */
            ii(0x67c8, 3);  mov(ax, memw[ss, bp - 2]);                 /* mov ax, [bp-0x2] */
            ii(0x67cb, 4);  cmp(memw[ds, 0x1206], ax);                 /* cmp [0x1206], ax */
            ii(0x67cf, 2);  if(jae(0x67d4, 3)) goto l_0x67d4;          /* jae 0x67d4 */
            ii(0x67d1, 3);  mov(memw[ds, 0x1206], ax);                 /* mov [0x1206], ax */
        l_0x67d4:
            ii(0x67d4, 5);  cmp(memb[ds, 0x2e], 0);                    /* cmp byte [0x2e], 0x0 */
            ii(0x67d9, 2);  if(jnz(0x67ef, 0x14)) goto l_0x67ef;       /* jnz 0x67ef */
            ii(0x67db, 4);  mov(ax, memw[ss, bp - 184]);               /* mov ax, [bp-0xb8] */
            ii(0x67df, 4);  mov(memw[ss, bp - 180], ax);               /* mov [bp-0xb4], ax */
            ii(0x67e3, 3);  mov(ax, memw[ss, bp - 2]);                 /* mov ax, [bp-0x2] */
            ii(0x67e6, 4);  cmp(memw[ds, 0x1206], ax);                 /* cmp [0x1206], ax */
            ii(0x67ea, 2);  if(jae(0x67ef, 3)) goto l_0x67ef;          /* jae 0x67ef */
            ii(0x67ec, 3);  mov(memw[ds, 0x1206], ax);                 /* mov [0x1206], ax */
        l_0x67ef:
            ii(0x67ef, 5);  cmp(memw[ss, bp - 180], 0);                /* cmp word [bp-0xb4], 0x0 */
            ii(0x67f4, 2);  if(jz(0x6811, 0x1b)) goto l_0x6811;        /* jz 0x6811 */
            ii(0x67f6, 6);  cmp(memw[ss, bp - 180], 0x7fff);           /* cmp word [bp-0xb4], 0x7fff */
            ii(0x67fc, 2);  if(jz(0x6811, 0x13)) goto l_0x6811;        /* jz 0x6811 */
            ii(0x67fe, 5);  test(memb[ds, 0x11d2], 1);                 /* test byte [0x11d2], 0x1 */
            ii(0x6803, 2);  if(jnz(0x6811, 0xc)) goto l_0x6811;        /* jnz 0x6811 */
            ii(0x6805, 4);  mov(ax, memw[ss, bp - 180]);               /* mov ax, [bp-0xb4] */
            ii(0x6809, 3);  mov(memw[ds, 0xecc], ax);                  /* mov [0xecc], ax */
            ii(0x680c, 5);  or(memb[ds, 0x11d2], 1);                   /* or byte [0x11d2], 0x1 */
        l_0x6811:
            ii(0x6811, 5);  test(memb[ds, 0x15], 0x20);                /* test byte [0x15], 0x20 */
            ii(0x6816, 2);  if(jz(0x683d, 0x25)) goto l_0x683d;        /* jz 0x683d */
            ii(0x6818, 5);  cmp(memb[ds, 0x2e], 0);                    /* cmp byte [0x2e], 0x0 */
            ii(0x681d, 2);  if(jz(0x683d, 0x1e)) goto l_0x683d;        /* jz 0x683d */
            ii(0x681f, 5);  test(memb[ds, 0x11d2], 4);                 /* test byte [0x11d2], 0x4 */
            ii(0x6824, 2);  if(jnz(0x682c, 6)) goto l_0x682c;          /* jnz 0x682c */
            ii(0x6826, 6);  mov(memw[ds, 0xece], 0xfffe);              /* mov word [0xece], 0xfffe */
        l_0x682c:
            ii(0x682c, 5);  test(memb[ds, 0x11d2], 1);                 /* test byte [0x11d2], 0x1 */
            ii(0x6831, 2);  if(jnz(0x683d, 0xa)) goto l_0x683d;        /* jnz 0x683d */
            ii(0x6833, 3);  mov(ax, memw[ds, 0xece]);                  /* mov ax, [0xece] */
            ii(0x6836, 4);  sub(ax, memw[ds, 0xeca]);                  /* sub ax, [0xeca] */
            ii(0x683a, 3);  mov(memw[ds, 0xecc], ax);                  /* mov [0xecc], ax */
        l_0x683d:
            ii(0x683d, 6);  cmp(memw[ds, 0xecc], 0x3c00);              /* cmp word [0xecc], 0x3c00 */
            ii(0x6843, 2);  if(ja(0x6855, 0x10)) goto l_0x6855;        /* ja 0x6855 */
            ii(0x6845, 6);  cmp(memw[ds, 0xeca], 0x4000);              /* cmp word [0xeca], 0x4000 */
            ii(0x684b, 2);  if(ja(0x6855, 8)) goto l_0x6855;           /* ja 0x6855 */
            ii(0x684d, 6);  cmp(memw[ds, 0xece], 0x4000);              /* cmp word [0xece], 0x4000 */
            ii(0x6853, 2);  if(jbe(0x685a, 5)) goto l_0x685a;          /* jbe 0x685a */
        l_0x6855:
            ii(0x6855, 5);  or(memb[ds, 0x15], 0x20);                  /* or byte [0x15], 0x20 */
        l_0x685a:
            ii(0x685a, 1);  leave();                                   /* leave */
            ii(0x685b, 1);  ret();                                     /* ret */
        }
    }
}
