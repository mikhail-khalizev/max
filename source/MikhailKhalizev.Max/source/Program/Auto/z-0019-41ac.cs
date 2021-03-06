using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_41ac-e67c11ae")]
        public void Method_0019_41ac()
        {
            ii(0x19_41ac, 1);  push(bp);                               /* push bp */
            ii(0x19_41ad, 2);  mov(bp, sp);                            /* mov bp, sp */
            ii(0x19_41af, 1);  push(si);                               /* push si */
            ii(0x19_41b0, 1);  push(di);                               /* push di */
            ii(0x19_41b1, 1);  push(ds);                               /* push ds */
            ii(0x19_41b2, 3);  mov(ax, memw[ss, bp + 6]);              /* mov ax, [bp+0x6] */
            ii(0x19_41b5, 3);  lds(bx, memw[ss, bp + 10]);             /* lds bx, [bp+0xa] */
            ii(0x19_41b8, 3);  push(memw[ds, bx + 16]);                /* push word [bx+0x10] */
            ii(0x19_41bb, 3);  mov(dx, memw[ds, bx + 14]);             /* mov dx, [bx+0xe] */
            ii(0x19_41be, 3);  mov(si, memw[ds, bx + 6]);              /* mov si, [bx+0x6] */
            ii(0x19_41c1, 3);  mov(di, memw[ds, bx + 4]);              /* mov di, [bx+0x4] */
            ii(0x19_41c4, 3);  mov(cx, memw[ds, bx + 2]);              /* mov cx, [bx+0x2] */
            ii(0x19_41c7, 3);  call(0x19_40cc, -0xfe);                 /* call 0x40cc */
            ii(0x19_41ca, 2);  mov(es, cx);                            /* mov es, cx */
            ii(0x19_41cc, 2);  mov(cx, memw[ds, bx]);                  /* mov cx, [bx] */
            ii(0x19_41ce, 3);  call(0x19_40cc, -0x105);                /* call 0x40cc */
            ii(0x19_41d1, 2);  mov(ds, cx);                            /* mov ds, cx */
            ii(0x19_41d3, 1);  pop(cx);                                /* pop cx */
            ii(0x19_41d4, 3);  mov(ax, memw[ss, bp + 6]);              /* mov ax, [bp+0x6] */
            ii(0x19_41d7, 3);  mov(bx, memw[ss, bp + 8]);              /* mov bx, [bp+0x8] */
            ii(0x19_41da, 3);  call(0x19_40b7, -0x126);                /* call 0x40b7 */
            ii(0x19_41dd, 2);  if(jz(0x19_41f3, 0x14)) goto l_0x19_41f3;/* jz 0x41f3 */
            ii(0x19_41df, 4);  movzx(edx, dx);                         /* movzx edx, dx */
            ii(0x19_41e3, 4);  movzx(esi, si);                         /* movzx esi, si */
            ii(0x19_41e7, 4);  movzx(edi, di);                         /* movzx edi, di */
            ii(0x19_41eb, 4);  movzx(ebx, bx);                         /* movzx ebx, bx */
            ii(0x19_41ef, 4);  movzx(ecx, cx);                         /* movzx ecx, cx */
        l_0x19_41f3:
            ii(0x19_41f3, 2);  @int(0x31);                             /* int 0x31 */
            ii(0x19_41f5, 1);  push(bx);                               /* push bx */
            ii(0x19_41f6, 1);  push(ds);                               /* push ds */
            ii(0x19_41f7, 3);  lds(bx, memw[ss, bp + 10]);             /* lds bx, [bp+0xa] */
            ii(0x19_41fa, 3);  jmp_func(0x19_4166, -0x97);             /* jmp 0x4166 */
        }
    }
}
