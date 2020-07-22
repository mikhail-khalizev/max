using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x4f4d-169195b7")]
        public void Method_0000_4f4d()
        {
            ii(0x4f4d, 1);  push(bp);                                  /* push bp */
            ii(0x4f4e, 2);  mov(bp, sp);                               /* mov bp, sp */
            ii(0x4f50, 3);  sub(sp, 4);                                /* sub sp, 0x4 */
            ii(0x4f53, 2);  jmp(0x4f6b, 0x16); goto l_0x4f6b;          /* jmp 0x4f6b */
        l_0x4f55:
            ii(0x4f55, 3);  mov(memw[ss, bp - 4], bx);                 /* mov [bp-0x4], bx */
            ii(0x4f58, 3);  inc(memw[ss, bp + 6]);                     /* inc word [bp+0x6] */
            ii(0x4f5b, 2);  mov(al, memb[ds, bx]);                     /* mov al, [bx] */
            ii(0x4f5d, 3);  mov(bx, memw[ss, bp + 4]);                 /* mov bx, [bp+0x4] */
            ii(0x4f60, 3);  inc(memw[ss, bp + 4]);                     /* inc word [bp+0x4] */
            ii(0x4f63, 2);  cmp(memb[ds, bx], al);                     /* cmp [bx], al */
            ii(0x4f65, 2);  if(jz(0x4f6b, 4)) goto l_0x4f6b;           /* jz 0x4f6b */
            ii(0x4f67, 2);  sub(ax, ax);                               /* sub ax, ax */
            ii(0x4f69, 2);  jmp(0x4f76, 0xb); goto l_0x4f76;           /* jmp 0x4f76 */
        l_0x4f6b:
            ii(0x4f6b, 3);  mov(bx, memw[ss, bp + 6]);                 /* mov bx, [bp+0x6] */
            ii(0x4f6e, 3);  cmp(memb[ds, bx], 0);                      /* cmp byte [bx], 0x0 */
            ii(0x4f71, 2);  if(jnz(0x4f55, -0x1e)) goto l_0x4f55;      /* jnz 0x4f55 */
            ii(0x4f73, 3);  mov(ax, 1);                                /* mov ax, 0x1 */
        l_0x4f76:
            ii(0x4f76, 2);  mov(sp, bp);                               /* mov sp, bp */
            ii(0x4f78, 1);  pop(bp);                                   /* pop bp */
            ii(0x4f79, 1);  ret();                                     /* ret */
        }
    }
}
