using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1_1b52-3a7e9928")]
        public void Method_0001_1b52()
        {
            ii(0x1_1b52, 3);  mov(dx, memw[ss, bp + 4]);               /* mov dx, [bp+0x4] */
            ii(0x1_1b55, 3);  mov(cx, memw[ss, bp + 6]);               /* mov cx, [bp+0x6] */
            ii(0x1_1b58, 2);  shl(dx, 1);                              /* shl dx, 1 */
            ii(0x1_1b5a, 2);  rcl(cx, 1);                              /* rcl cx, 1 */
            ii(0x1_1b5c, 2);  shl(dx, 1);                              /* shl dx, 1 */
            ii(0x1_1b5e, 2);  rcl(cx, 1);                              /* rcl cx, 1 */
            ii(0x1_1b60, 2);  shl(dx, 1);                              /* shl dx, 1 */
            ii(0x1_1b62, 2);  rcl(cx, 1);                              /* rcl cx, 1 */
            ii(0x1_1b64, 2);  shl(dx, 1);                              /* shl dx, 1 */
            ii(0x1_1b66, 2);  rcl(cx, 1);                              /* rcl cx, 1 */
            ii(0x1_1b68, 4);  mov(bx, memw[ds, 0xc38]);                /* mov bx, [0xc38] */
            ii(0x1_1b6c, 3);  test(bl, 3);                             /* test bl, 0x3 */
            ii(0x1_1b6f, 2);  if(jnz(0x1_1b83, 0x12)) goto l_0x1_1b83; /* jnz 0x1b83 */
            ii(0x1_1b71, 2);  push(8);                                 /* push 0x8 */
            ii(0x1_1b73, 1);  pop(ds);                                 /* pop ds */
            ii(0x1_1b74, 3);  mov(memw[ds, bx + 2], dx);               /* mov [bx+0x2], dx */
            ii(0x1_1b77, 3);  mov(memb[ds, bx + 4], cl);               /* mov [bx+0x4], cl */
            ii(0x1_1b7a, 3);  mov(memb[ds, bx + 7], ch);               /* mov [bx+0x7], ch */
        l_0x1_1b7d:
            ii(0x1_1b7d, 2);  mov(ds, bx);                             /* mov ds, bx */
            ii(0x1_1b7f, 3);  mov(bx, memw[ss, bp + 8]);               /* mov bx, [bp+0x8] */
            ii(0x1_1b82, 1);  ret(); return;                           /* ret */
        l_0x1_1b83:
            ii(0x1_1b83, 3);  mov(ax, 7);                              /* mov ax, 0x7 */
            ii(0x1_1b86, 1);  push(cs);                                /* push cs */
            ii(0x1_1b87, 3);  call(0xe389, -0x3801);                   /* call 0xe389 */
            ii(0x1_1b8a, 2);  jmp(0x1_1b7d, -0xf); goto l_0x1_1b7d;    /* jmp 0x1b7d */
        }
    }
}
