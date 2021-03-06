using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x4f0d-8bfa9ef3")]
        public void Method_0000_4f0d()
        {
            ii(0x4f0d, 1);  push(bp);                                  /* push bp */
            ii(0x4f0e, 2);  mov(bp, sp);                               /* mov bp, sp */
            ii(0x4f10, 3);  sub(sp, 2);                                /* sub sp, 0x2 */
            ii(0x4f13, 3);  push(memw[ss, bp + 4]);                    /* push word [bp+0x4] */
            ii(0x4f16, 3);  mov(ax, 0x1190);                           /* mov ax, 0x1190 */
            ii(0x4f19, 1);  push(ax);                                  /* push ax */
            ii(0x4f1a, 3);  call(0x4ee1, -0x3c);                       /* call 0x4ee1 */
            ii(0x4f1d, 1);  pop(bx);                                   /* pop bx */
            ii(0x4f1e, 1);  pop(bx);                                   /* pop bx */
            ii(0x4f1f, 3);  mov(ax, 0x1190);                           /* mov ax, 0x1190 */
            ii(0x4f22, 1);  push(ax);                                  /* push ax */
            ii(0x4f23, 3);  call(0x5c10, 0xcea);                       /* call 0x5c10 */
            ii(0x4f26, 1);  pop(bx);                                   /* pop bx */
            ii(0x4f27, 3);  mov(memw[ss, bp - 2], ax);                 /* mov [bp-0x2], ax */
            ii(0x4f2a, 3);  mov(memw[ds, 0x11f8], ax);                 /* mov [0x11f8], ax */
            ii(0x4f2d, 2);  jmp(0x4f44, 0x15); goto l_0x4f44;          /* jmp 0x4f44 */
        l_0x4f2f:
            ii(0x4f2f, 3);  mov(bx, memw[ss, bp - 2]);                 /* mov bx, [bp-0x2] */
            ii(0x4f32, 5);  cmp(memb[ds, bx + 0x1190], 0x5c);          /* cmp byte [bx+0x1190], 0x5c */
            ii(0x4f37, 2);  if(jz(0x4f49, 0x10)) goto l_0x4f49;        /* jz 0x4f49 */
            ii(0x4f39, 5);  cmp(memb[ds, bx + 0x1190], 0x2e);          /* cmp byte [bx+0x1190], 0x2e */
            ii(0x4f3e, 2);  if(jnz(0x4f44, 4)) goto l_0x4f44;          /* jnz 0x4f44 */
            ii(0x4f40, 4);  mov(memw[ds, 0x11f8], bx);                 /* mov [0x11f8], bx */
        l_0x4f44:
            ii(0x4f44, 3);  dec(memw[ss, bp - 2]);                     /* dec word [bp-0x2] */
            ii(0x4f47, 2);  if(jns(0x4f2f, -0x1a)) goto l_0x4f2f;      /* jns 0x4f2f */
        l_0x4f49:
            ii(0x4f49, 2);  mov(sp, bp);                               /* mov sp, bp */
            ii(0x4f4b, 1);  pop(bp);                                   /* pop bp */
            ii(0x4f4c, 1);  ret();                                     /* ret */
        }
    }
}
