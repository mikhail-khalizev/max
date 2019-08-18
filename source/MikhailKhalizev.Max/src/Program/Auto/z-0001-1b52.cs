using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("b83caf25-0b24-4a54-9586-fc72dc25776f")]
        public void Method_0001_1b52()
        {
            ii(0x1_1b52, 3);  mov(dx, memw_a16[ss, bp + 0x4]);          /* mov dx, [bp+0x4] */
            ii(0x1_1b55, 3);  mov(cx, memw_a16[ss, bp + 0x6]);          /* mov cx, [bp+0x6] */
            ii(0x1_1b58, 2);  shl(dx, 0x1);                             /* shl dx, 1 */
            ii(0x1_1b5a, 2);  rcl(cx, 0x1);                             /* rcl cx, 1 */
            ii(0x1_1b5c, 2);  shl(dx, 0x1);                             /* shl dx, 1 */
            ii(0x1_1b5e, 2);  rcl(cx, 0x1);                             /* rcl cx, 1 */
            ii(0x1_1b60, 2);  shl(dx, 0x1);                             /* shl dx, 1 */
            ii(0x1_1b62, 2);  rcl(cx, 0x1);                             /* rcl cx, 1 */
            ii(0x1_1b64, 2);  shl(dx, 0x1);                             /* shl dx, 1 */
            ii(0x1_1b66, 2);  rcl(cx, 0x1);                             /* rcl cx, 1 */
            ii(0x1_1b68, 4);  mov(bx, memw_a16[ds, 0xc38]);             /* mov bx, [0xc38] */
            ii(0x1_1b6c, 3);  test(bl, 0x3);                            /* test bl, 0x3 */
            ii(0x1_1b6f, 2);  if(jnzw(0x1_1b83, 0x12)) goto l_0x1_1b83; /* jnz 0x1b83 */
            ii(0x1_1b71, 2);  pushw(0x8);                               /* push 0x8 */
            ii(0x1_1b73, 1);  popw(ds);                                 /* pop ds */
            ii(0x1_1b74, 3);  mov(memw_a16[ds, bx + 0x2], dx);          /* mov [bx+0x2], dx */
            ii(0x1_1b77, 3);  mov(memb_a16[ds, bx + 0x4], cl);          /* mov [bx+0x4], cl */
            ii(0x1_1b7a, 3);  mov(memb_a16[ds, bx + 0x7], ch);          /* mov [bx+0x7], ch */
        l_0x1_1b7d:
            ii(0x1_1b7d, 2);  mov(ds, bx);                              /* mov ds, bx */
            ii(0x1_1b7f, 3);  mov(bx, memw_a16[ss, bp + 0x8]);          /* mov bx, [bp+0x8] */
            ii(0x1_1b82, 1);  retw(); return;                           /* ret */
        l_0x1_1b83:
            ii(0x1_1b83, 3);  mov(ax, 0x7);                             /* mov ax, 0x7 */
            ii(0x1_1b86, 1);  pushw(cs);                                /* push cs */
            ii(0x1_1b87, 3);  callw(0xe389, -0x3801);                   /* call 0xe389 */
            ii(0x1_1b8a, 2);  jmpw(0x1_1b7d, -0xf); goto l_0x1_1b7d;    /* jmp 0x1b7d */
        }
    }
}
