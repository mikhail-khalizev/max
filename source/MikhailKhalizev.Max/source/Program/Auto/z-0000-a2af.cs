using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xa2af-3d006f99")]
        public void Method_0000_a2af()
        {
            ii(0xa2af, 2);  or(ax, ax);                                /* or ax, ax */
            ii(0xa2b1, 3);  mov(memw[ds, 0xece], ax);                  /* mov [0xece], ax */
            ii(0xa2b4, 2);  if(jz(0xa313, 0x5d)) goto l_0xa313;        /* jz 0xa313 */
            ii(0xa2b6, 4);  cmp(ax, memw[ds, 0xecc]);                  /* cmp ax, [0xecc] */
            ii(0xa2ba, 2);  if(jb(0xa2bf, 3)) goto l_0xa2bf;           /* jb 0xa2bf */
            ii(0xa2bc, 3);  mov(ax, memw[ds, 0xecc]);                  /* mov ax, [0xecc] */
        l_0xa2bf:
            ii(0xa2bf, 3);  mov(memw[ds, 0xecc], ax);                  /* mov [0xecc], ax */
            ii(0xa2c2, 1);  xchg(dx, ax);                              /* xchg dx, ax */
            ii(0xa2c3, 2);  mov(ah, 9);                                /* mov ah, 0x9 */
            ii(0xa2c5, 4);  call_far_ind(memw[ds, 0xaec]);             /* call far word [0xaec] */
            ii(0xa2c9, 2);  or(ax, ax);                                /* or ax, ax */
            ii(0xa2cb, 2);  if(jz(0xa313, 0x46)) goto l_0xa313;        /* jz 0xa313 */
            ii(0xa2cd, 4);  mov(memw[ds, 0xadc], dx);                  /* mov [0xadc], dx */
            ii(0xa2d1, 2);  mov(ah, 0xc);                              /* mov ah, 0xc */
            ii(0xa2d3, 4);  call_far_ind(memw[ds, 0xaec]);             /* call far word [0xaec] */
            ii(0xa2d7, 2);  or(ax, ax);                                /* or ax, ax */
            ii(0xa2d9, 2);  if(jnz(0xa2e0, 5)) goto l_0xa2e0;          /* jnz 0xa2e0 */
            ii(0xa2db, 3);  call(0x53e7, -0x4ef7);                     /* call 0x53e7 */
            ii(0xa2de, 2);  jmp(0xa313, 0x33); goto l_0xa313;          /* jmp 0xa313 */
        l_0xa2e0:
            ii(0xa2e0, 3);  add(bx, 0xf);                              /* add bx, 0xf */
            ii(0xa2e3, 3);  adc(dx, 0);                                /* adc dx, 0x0 */
            ii(0xa2e6, 3);  mov(cx, 4);                                /* mov cx, 0x4 */
        l_0xa2e9:
            ii(0xa2e9, 2);  shr(dx, 1);                                /* shr dx, 1 */
            ii(0xa2eb, 2);  rcr(bx, 1);                                /* rcr bx, 1 */
            ii(0xa2ed, 2);  if(loop(0xa2e9, -6)) goto l_0xa2e9;        /* loop 0xa2e9 */
            ii(0xa2ef, 4);  mov(memw[ds, 0x98], bx);                   /* mov [0x98], bx */
            ii(0xa2f3, 4);  mov(memw[ds, 0x9a], dx);                   /* mov [0x9a], dx */
            ii(0xa2f7, 6);  mov(memw[ds, 0xaa6], 0x3e5a);              /* mov word [0xaa6], 0x3e5a */
            ii(0xa2fd, 6);  mov(memw[ds, 0xaa4], 0x3e25);              /* mov word [0xaa4], 0x3e25 */
            ii(0xa303, 3);  mov(ax, 0x400);                            /* mov ax, 0x400 */
            ii(0xa306, 4);  mul(memw[ds, 0xecc]);                      /* mul word [0xecc] */
            ii(0xa30a, 3);  mov(memw[ds, 0xaa8], ax);                  /* mov [0xaa8], ax */
            ii(0xa30d, 4);  mov(memw[ds, 0xaaa], dx);                  /* mov [0xaaa], dx */
            ii(0xa311, 2);  jmp(0xa319, 6); goto l_0xa319;             /* jmp 0xa319 */
        l_0xa313:
            ii(0xa313, 6);  mov(memw[ds, 0xecc], 0);                   /* mov word [0xecc], 0x0 */
        l_0xa319:
            ii(0xa319, 2);  mov(al, 1);                                /* mov al, 0x1 */
            ii(0xa31b, 1);  ret();                                     /* ret */
        }
    }
}
