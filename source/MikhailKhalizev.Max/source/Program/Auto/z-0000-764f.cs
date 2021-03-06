using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x764f-1fe8ff0f")]
        public void Method_0000_764f()
        {
            ii(0x764f, 4);  enter(4, 0);                               /* enter 0x4, 0x0 */
            ii(0x7653, 5);  cmp(memb[ds, 0x980], 1);                   /* cmp byte [0x980], 0x1 */
            ii(0x7658, 2);  if(jnz(0x7673, 0x19)) goto l_0x7673;       /* jnz 0x7673 */
            ii(0x765a, 3);  push(memw[ss, bp + 4]);                    /* push word [bp+0x4] */
            ii(0x765d, 3);  call(0x76fc, 0x9c);                        /* call 0x76fc */
            ii(0x7660, 1);  pop(bx);                                   /* pop bx */
            ii(0x7661, 3);  mov(memw[ss, bp - 4], ax);                 /* mov [bp-0x4], ax */
            ii(0x7664, 3);  mov(memw[ss, bp - 2], dx);                 /* mov [bp-0x2], dx */
            ii(0x7667, 2);  or(dx, ax);                                /* or dx, ax */
            ii(0x7669, 2);  if(jz(0x7673, 8)) goto l_0x7673;           /* jz 0x7673 */
        l_0x766b:
            ii(0x766b, 3);  mov(ax, memw[ss, bp - 4]);                 /* mov ax, [bp-0x4] */
            ii(0x766e, 3);  mov(dx, memw[ss, bp - 2]);                 /* mov dx, [bp-0x2] */
            ii(0x7671, 1);  leave();                                   /* leave */
            ii(0x7672, 1);  ret(); return;                             /* ret */
        l_0x7673:
            ii(0x7673, 5);  cmp(memb[ds, 0x980], 3);                   /* cmp byte [0x980], 0x3 */
            ii(0x7678, 2);  if(jge(0x7698, 0x1e)) goto l_0x7698;       /* jge 0x7698 */
            ii(0x767a, 3);  call(0x572a, -0x1f53);                     /* call 0x572a */
            ii(0x767d, 2);  push(0);                                   /* push 0x0 */
            ii(0x767f, 3);  push(memw[ss, bp + 4]);                    /* push word [bp+0x4] */
            ii(0x7682, 3);  call(0x5c08, -0x1a7d);                     /* call 0x5c08 */
            ii(0x7685, 1);  pop(bx);                                   /* pop bx */
            ii(0x7686, 1);  pop(bx);                                   /* pop bx */
            ii(0x7687, 3);  mov(memw[ss, bp - 4], ax);                 /* mov [bp-0x4], ax */
            ii(0x768a, 3);  mov(memw[ss, bp - 2], dx);                 /* mov [bp-0x2], dx */
            ii(0x768d, 3);  call(0x4f61, -0x272f);                     /* call 0x4f61 */
            ii(0x7690, 3);  mov(ax, memw[ss, bp - 2]);                 /* mov ax, [bp-0x2] */
            ii(0x7693, 3);  or(ax, memw[ss, bp - 4]);                  /* or ax, [bp-0x4] */
            ii(0x7696, 2);  if(jnz(0x766b, -0x2d)) goto l_0x766b;      /* jnz 0x766b */
        l_0x7698:
            ii(0x7698, 3);  push(memw[ss, bp + 4]);                    /* push word [bp+0x4] */
            ii(0x769b, 3);  call(0x76fc, 0x5e);                        /* call 0x76fc */
            ii(0x769e, 1);  pop(bx);                                   /* pop bx */
            ii(0x769f, 1);  leave();                                   /* leave */
            ii(0x76a0, 1);  ret();                                     /* ret */
        }
    }
}
