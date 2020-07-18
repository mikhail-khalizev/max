using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_db82-3a7e9928")]
        public void Method_0018_db82()
        {
            ii(0x18_db82, 3);  mov(dx, memw[ss, bp + 4]);              /* mov dx, [bp+0x4] */
            ii(0x18_db85, 3);  mov(cx, memw[ss, bp + 6]);              /* mov cx, [bp+0x6] */
            ii(0x18_db88, 2);  shl(dx, 1);                             /* shl dx, 1 */
            ii(0x18_db8a, 2);  rcl(cx, 1);                             /* rcl cx, 1 */
            ii(0x18_db8c, 2);  shl(dx, 1);                             /* shl dx, 1 */
            ii(0x18_db8e, 2);  rcl(cx, 1);                             /* rcl cx, 1 */
            ii(0x18_db90, 2);  shl(dx, 1);                             /* shl dx, 1 */
            ii(0x18_db92, 2);  rcl(cx, 1);                             /* rcl cx, 1 */
            ii(0x18_db94, 2);  shl(dx, 1);                             /* shl dx, 1 */
            ii(0x18_db96, 2);  rcl(cx, 1);                             /* rcl cx, 1 */
            ii(0x18_db98, 4);  mov(bx, memw[ds, 0xc38]);               /* mov bx, [0xc38] */
            ii(0x18_db9c, 3);  test(bl, 3);                            /* test bl, 0x3 */
            ii(0x18_db9f, 2);  if(jnz(0x18_dbb3, 0x12)) goto l_0x18_dbb3;/* jnz 0xdbb3 */
            ii(0x18_dba1, 2);  push(8);                                /* push 0x8 */
            ii(0x18_dba3, 1);  pop(ds);                                /* pop ds */
            ii(0x18_dba4, 3);  mov(memw[ds, bx + 2], dx);              /* mov [bx+0x2], dx */
            ii(0x18_dba7, 3);  mov(memb[ds, bx + 4], cl);              /* mov [bx+0x4], cl */
            ii(0x18_dbaa, 3);  mov(memb[ds, bx + 7], ch);              /* mov [bx+0x7], ch */
        l_0x18_dbad:
            ii(0x18_dbad, 2);  mov(ds, bx);                            /* mov ds, bx */
            ii(0x18_dbaf, 3);  mov(bx, memw[ss, bp + 8]);              /* mov bx, [bp+0x8] */
            ii(0x18_dbb2, 1);  ret(); return;                          /* ret */
        l_0x18_dbb3:
            ii(0x18_dbb3, 3);  mov(ax, 7);                             /* mov ax, 0x7 */
            ii(0x18_dbb6, 1);  push(cs);                               /* push cs */
            ii(0x18_dbb7, 3);  call(0x18_a3b9, -0x3801);               /* call 0xa3b9 */
            ii(0x18_dbba, 2);  jmp(0x18_dbad, -0xf); goto l_0x18_dbad; /* jmp 0xdbad */
        }
    }
}
