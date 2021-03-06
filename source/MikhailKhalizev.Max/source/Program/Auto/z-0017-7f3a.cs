using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_7f3a-dde37674")]
        public void Method_0017_7f3a()
        {
            ii(0x17_7f3a, 4);  enter(2, 0);                            /* enter 0x2, 0x0 */
            ii(0x17_7f3e, 1);  push(si);                               /* push si */
            ii(0x17_7f3f, 1);  push(ds);                               /* push ds */
            ii(0x17_7f40, 3);  mov(ax, 0x3e68);                        /* mov ax, 0x3e68 */
            ii(0x17_7f43, 2);  mov(ds, ax);                            /* mov ds, ax */
            ii(0x17_7f45, 5);  mov(memw[ss, bp - 2], 0);               /* mov word [bp-0x2], 0x0 */
            ii(0x17_7f4a, 2);  jmp(0x17_7f4f, 3); goto l_0x17_7f4f;    /* jmp 0x7f4f */
        l_0x17_7f4c:
            ii(0x17_7f4c, 3);  inc(memw[ss, bp - 2]);                  /* inc word [bp-0x2] */
        l_0x17_7f4f:
            ii(0x17_7f4f, 3);  mov(ax, memw[ds, 0x519e]);              /* mov ax, [0x519e] */
            ii(0x17_7f52, 3);  cmp(memw[ss, bp - 2], ax);              /* cmp [bp-0x2], ax */
            ii(0x17_7f55, 2);  if(jae(0x17_7f86, 0x2f)) goto l_0x17_7f86;/* jae 0x7f86 */
            ii(0x17_7f57, 3);  mov(ax, memw[ss, bp + 6]);              /* mov ax, [bp+0x6] */
            ii(0x17_7f5a, 3);  mov(dx, memw[ss, bp + 8]);              /* mov dx, [bp+0x8] */
            ii(0x17_7f5d, 3);  mov(bx, memw[ss, bp - 2]);              /* mov bx, [bp-0x2] */
            ii(0x17_7f60, 3);  shl(bx, 2);                             /* shl bx, 0x2 */
            ii(0x17_7f63, 4);  les(si, memw[ds, 0x4fa0]);              /* les si, [0x4fa0] */
            ii(0x17_7f67, 3);  cmp(memw[es, bx + si], ax);             /* cmp [es:bx+si], ax */
            ii(0x17_7f6a, 2);  if(jnz(0x17_7f84, 0x18)) goto l_0x17_7f84;/* jnz 0x7f84 */
            ii(0x17_7f6c, 4);  cmp(memw[es, bx + si + 2], dx);         /* cmp [es:bx+si+0x2], dx */
            ii(0x17_7f70, 2);  if(jnz(0x17_7f84, 0x12)) goto l_0x17_7f84;/* jnz 0x7f84 */
            ii(0x17_7f72, 4);  les(si, memw[ds, 0x4fa4]);              /* les si, [0x4fa4] */
            ii(0x17_7f76, 2);  sub(ax, ax);                            /* sub ax, ax */
            ii(0x17_7f78, 4);  mov(memw[es, bx + si + 2], ax);         /* mov [es:bx+si+0x2], ax */
            ii(0x17_7f7c, 3);  mov(memw[es, bx + si], ax);             /* mov [es:bx+si], ax */
            ii(0x17_7f7f, 1);  pop(ds);                                /* pop ds */
            ii(0x17_7f80, 1);  pop(si);                                /* pop si */
            ii(0x17_7f81, 1);  leave();                                /* leave */
            ii(0x17_7f82, 1);  retf(); return;                         /* retf */
        //  ii(0x17_7f83, 1);  Недостижимый код.
        l_0x17_7f84:
            ii(0x17_7f84, 2);  jmp(0x17_7f4c, -0x3a); goto l_0x17_7f4c;/* jmp 0x7f4c */
        l_0x17_7f86:
            ii(0x17_7f86, 1);  pop(ds);                                /* pop ds */
            ii(0x17_7f87, 1);  pop(si);                                /* pop si */
            ii(0x17_7f88, 1);  leave();                                /* leave */
            ii(0x17_7f89, 1);  retf();                                 /* retf */
        }
    }
}
