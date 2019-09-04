using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_7aa0-f06e1b2f")]
        public void Method_0017_7aa0()
        {
            ii(0x17_7aa0, 4);  enter(6, 0);                            /* enter 0x6, 0x0 */
            ii(0x17_7aa4, 1);  push(di);                               /* push di */
            ii(0x17_7aa5, 1);  push(si);                               /* push si */
            ii(0x17_7aa6, 1);  push(ds);                               /* push ds */
            ii(0x17_7aa7, 3);  mov(ax, 0x3e68);                        /* mov ax, 0x3e68 */
            ii(0x17_7aaa, 2);  mov(ds, ax);                            /* mov ds, ax */
            ii(0x17_7aac, 5);  mov(memw[ss, bp - 6], 0);               /* mov word [bp-0x6], 0x0 */
        l_0x17_7ab1:
            ii(0x17_7ab1, 4);  cmp(memw[ss, bp - 6], 0);               /* cmp word [bp-0x6], 0x0 */
            ii(0x17_7ab5, 2);  if(jnz(0x17_7b16, 0x5f)) goto l_0x17_7b16;/* jnz 0x7b16 */
            ii(0x17_7ab7, 4);  mov(bx, memw[ds, 0x5198]);              /* mov bx, [0x5198] */
            ii(0x17_7abb, 3);  shl(bx, 2);                             /* shl bx, 0x2 */
            ii(0x17_7abe, 4);  les(si, memw[ds, 0x4fa4]);              /* les si, [0x4fa4] */
            ii(0x17_7ac2, 3);  mov(ax, memw[es, bx + si]);             /* mov ax, [es:bx+si] */
            ii(0x17_7ac5, 4);  mov(dx, memw[es, bx + si + 2]);         /* mov dx, [es:bx+si+0x2] */
            ii(0x17_7ac9, 3);  mov(memw[ss, bp - 4], ax);              /* mov [bp-0x4], ax */
            ii(0x17_7acc, 3);  mov(memw[ss, bp - 2], dx);              /* mov [bp-0x2], dx */
            ii(0x17_7acf, 2);  mov(ax, bx);                            /* mov ax, bx */
            ii(0x17_7ad1, 4);  les(bx, memw[ds, 0x4f9c]);              /* les bx, [0x4f9c] */
            ii(0x17_7ad5, 4);  mov(si, memw[ds, 0x5198]);              /* mov si, [0x5198] */
            ii(0x17_7ad9, 3);  mov(cl, memb[es, bx + si]);             /* mov cl, [es:bx+si] */
            ii(0x17_7adc, 2);  mov(dx, cx);                            /* mov dx, cx */
            ii(0x17_7ade, 3);  and(cl, 0x80);                          /* and cl, 0x80 */
            ii(0x17_7ae1, 3);  cmp(cl, -0x80 /* 0x80 */);              /* cmp cl, 0x80 */
            ii(0x17_7ae4, 2);  if(jz(0x17_7afd, 0x17)) goto l_0x17_7afd;/* jz 0x7afd */
            ii(0x17_7ae6, 2);  mov(bx, ax);                            /* mov bx, ax */
            ii(0x17_7ae8, 4);  les(di, memw[ds, 0x4fa0]);              /* les di, [0x4fa0] */
            ii(0x17_7aec, 4);  mov(ax, memw[es, bx + di + 2]);         /* mov ax, [es:bx+di+0x2] */
            ii(0x17_7af0, 3);  or(ax, memw[es, bx + di]);              /* or ax, [es:bx+di] */
            ii(0x17_7af3, 2);  if(jz(0x17_7afd, 8)) goto l_0x17_7afd;  /* jz 0x7afd */
            ii(0x17_7af5, 3);  test(dl, 0x7f);                         /* test dl, 0x7f */
            ii(0x17_7af8, 2);  if(jnz(0x17_7afd, 3)) goto l_0x17_7afd; /* jnz 0x7afd */
            ii(0x17_7afa, 3);  mov(memw[ss, bp - 6], si);              /* mov [bp-0x6], si */
        l_0x17_7afd:
            ii(0x17_7afd, 2);  or(si, si);                             /* or si, si */
            ii(0x17_7aff, 2);  if(jz(0x17_7b08, 7)) goto l_0x17_7b08;  /* jz 0x7b08 */
            ii(0x17_7b01, 4);  dec(memw[ds, 0x5198]);                  /* dec word [0x5198] */
            ii(0x17_7b05, 2);  jmp(0x17_7b13, 0xc); goto l_0x17_7b13;  /* jmp 0x7b13 */
        //  ii(0x17_7b07, 1);  nop();                                  /* nop */
        l_0x17_7b08:
            ii(0x17_7b08, 3);  mov(ax, memw[ds, 0x50bc]);              /* mov ax, [0x50bc] */
            ii(0x17_7b0b, 1);  dec(ax);                                /* dec ax */
            ii(0x17_7b0c, 3);  mov(memw[ds, 0x5198], ax);              /* mov [0x5198], ax */
            ii(0x17_7b0f, 1);  push(cs);                               /* push cs */
            ii(0x17_7b10, 3);  call(0x17_7b24, 0x11);                  /* call 0x7b24 */
        l_0x17_7b13:
            ii(0x17_7b13, 2);  jmp(0x17_7ab1, -0x64); goto l_0x17_7ab1;/* jmp 0x7ab1 */
        //  ii(0x17_7b15, 1);  nop();                                  /* nop */
        l_0x17_7b16:
            ii(0x17_7b16, 3);  mov(ax, memw[ss, bp - 6]);              /* mov ax, [bp-0x6] */
            ii(0x17_7b19, 1);  pop(ds);                                /* pop ds */
            ii(0x17_7b1a, 1);  pop(si);                                /* pop si */
            ii(0x17_7b1b, 1);  pop(di);                                /* pop di */
            ii(0x17_7b1c, 1);  leave();                                /* leave */
            ii(0x17_7b1d, 1);  retf();                                 /* retf */
        }
    }
}
