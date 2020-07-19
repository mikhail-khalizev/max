using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x8dff-3d800b7a")]
        public void Method_0000_8dff()
        {
            ii(0x8dff, 4);  enter(2, 0);                               /* enter 0x2, 0x0 */
            ii(0x8e03, 5);  mov(memw[ss, bp - 2], 2);                  /* mov word [bp-0x2], 0x2 */
        l_0x8e08:
            ii(0x8e08, 4);  push(memw[ds, 0x11dc]);                    /* push word [0x11dc] */
            ii(0x8e0c, 4);  push(memw[ds, 0x11da]);                    /* push word [0x11da] */
            ii(0x8e10, 3);  call(0xbd7a, 0x2f67);                      /* call 0xbd7a */
            ii(0x8e13, 1);  pop(bx);                                   /* pop bx */
            ii(0x8e14, 1);  pop(bx);                                   /* pop bx */
            ii(0x8e15, 3);  push(memw[ss, bp + 8]);                    /* push word [bp+0x8] */
            ii(0x8e18, 3);  push(memw[ss, bp + 4]);                    /* push word [bp+0x4] */
            ii(0x8e1b, 3);  call(0xbd92, 0x2f74);                      /* call 0xbd92 */
            ii(0x8e1e, 1);  pop(bx);                                   /* pop bx */
            ii(0x8e1f, 1);  pop(bx);                                   /* pop bx */
            ii(0x8e20, 3);  cmp(ax, memw[ss, bp + 8]);                 /* cmp ax, [bp+0x8] */
            ii(0x8e23, 2);  if(jnz(0x8e72, 0x4d)) goto l_0x8e72;       /* jnz 0x8e72 */
            ii(0x8e25, 3);  mov(bx, memw[ss, bp + 4]);                 /* mov bx, [bp+0x4] */
            ii(0x8e28, 3);  cmp(memb[ds, bx], 0x4d);                   /* cmp byte [bx], 0x4d */
            ii(0x8e2b, 2);  if(jnz(0x8e43, 0x16)) goto l_0x8e43;       /* jnz 0x8e43 */
            ii(0x8e2d, 4);  cmp(memb[ds, bx + 1], 0x46);               /* cmp byte [bx+0x1], 0x46 */
            ii(0x8e31, 2);  if(jnz(0x8e43, 0x10)) goto l_0x8e43;       /* jnz 0x8e43 */
            ii(0x8e33, 3);  mov(ax, memw[ds, bx + 2]);                 /* mov ax, [bx+0x2] */
            ii(0x8e36, 3);  mov(dx, memw[ds, bx + 4]);                 /* mov dx, [bx+0x4] */
        l_0x8e39:
            ii(0x8e39, 4);  add(memw[ds, 0x11da], ax);                 /* add [0x11da], ax */
            ii(0x8e3d, 4);  adc(memw[ds, 0x11dc], dx);                 /* adc [0x11dc], dx */
            ii(0x8e41, 2);  jmp(0x8e6c, 0x29); goto l_0x8e6c;          /* jmp 0x8e6c */
        l_0x8e43:
            ii(0x8e43, 3);  cmp(memb[ds, bx], 0x4d);                   /* cmp byte [bx], 0x4d */
            ii(0x8e46, 2);  if(jnz(0x8e55, 0xd)) goto l_0x8e55;        /* jnz 0x8e55 */
            ii(0x8e48, 4);  cmp(memb[ds, bx + 1], 0x5a);               /* cmp byte [bx+0x1], 0x5a */
            ii(0x8e4c, 2);  if(jnz(0x8e55, 7)) goto l_0x8e55;          /* jnz 0x8e55 */
            ii(0x8e4e, 1);  push(bx);                                  /* push bx */
            ii(0x8e4f, 3);  call(0x8dbb, -0x97);                       /* call 0x8dbb */
            ii(0x8e52, 1);  pop(bx);                                   /* pop bx */
            ii(0x8e53, 2);  jmp(0x8e39, -0x1c); goto l_0x8e39;         /* jmp 0x8e39 */
        l_0x8e55:
            ii(0x8e55, 3);  cmp(memb[ds, bx], 0x42);                   /* cmp byte [bx], 0x42 */
            ii(0x8e58, 2);  if(jnz(0x8e65, 0xb)) goto l_0x8e65;        /* jnz 0x8e65 */
            ii(0x8e5a, 4);  cmp(memb[ds, bx + 1], 0x57);               /* cmp byte [bx+0x1], 0x57 */
            ii(0x8e5e, 2);  if(jnz(0x8e65, 5)) goto l_0x8e65;          /* jnz 0x8e65 */
            ii(0x8e60, 3);  mov(ax, 1);                                /* mov ax, 0x1 */
            ii(0x8e63, 1);  leave();                                   /* leave */
            ii(0x8e64, 1);  ret(); return;                             /* ret */
        l_0x8e65:
            ii(0x8e65, 2);  mov(ah, 0xd);                              /* mov ah, 0xd */
            ii(0x8e67, 2);  @int(0x21);                                /* int 0x21 */
            ii(0x8e69, 3);  dec(memw[ss, bp - 2]);                     /* dec word [bp-0x2] */
        l_0x8e6c:
            ii(0x8e6c, 4);  cmp(memw[ss, bp - 2], 0);                  /* cmp word [bp-0x2], 0x0 */
            ii(0x8e70, 2);  if(jge(0x8e08, -0x6a)) goto l_0x8e08;      /* jge 0x8e08 */
        l_0x8e72:
            ii(0x8e72, 4);  cmp(memw[ss, bp + 6], 0);                  /* cmp word [bp+0x6], 0x0 */
            ii(0x8e76, 2);  if(jz(0x8e7e, 6)) goto l_0x8e7e;           /* jz 0x8e7e */
            ii(0x8e78, 2);  push(-2 /* 0xfe */);                       /* push 0xfffe */
            ii(0x8e7a, 3);  call(0x805d, -0xe20);                      /* call 0x805d */
            ii(0x8e7d, 1);  pop(bx);                                   /* pop bx */
        l_0x8e7e:
            ii(0x8e7e, 2);  sub(ax, ax);                               /* sub ax, ax */
            ii(0x8e80, 3);  mov(memw[ds, 0x11dc], ax);                 /* mov [0x11dc], ax */
            ii(0x8e83, 3);  mov(memw[ds, 0x11da], ax);                 /* mov [0x11da], ax */
            ii(0x8e86, 1);  leave();                                   /* leave */
            ii(0x8e87, 1);  ret();                                     /* ret */
        }
    }
}
