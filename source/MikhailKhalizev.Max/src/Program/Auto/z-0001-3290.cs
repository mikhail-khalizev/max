using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1_3290-6d77f75")]
        public void Method_0001_3290()
        {
            ii(0x1_3290, 5);  test(memb[ds, 0x1582], 1);                /* test byte [0x1582], 0x1 */
            ii(0x1_3295, 4);  if(jnz_func(0x1_3321, 0x88)) return;      /* jnz 0x3321 */
            ii(0x1_3299, 1);  push(cs);                                 /* push cs */
            ii(0x1_329a, 3);  call(0x1_3240, -0x5d);                    /* call 0x3240 */
            ii(0x1_329d, 2);  or(ax, ax);                               /* or ax, ax */
            ii(0x1_329f, 4);  if(jz_func(0x1_331e, 0x7b)) return;       /* jz 0x331e */
            ii(0x1_32a3, 1);  pop(ax);                                  /* pop ax */
            ii(0x1_32a4, 1);  inc(ax);                                  /* inc ax */
            ii(0x1_32a5, 1);  push(ax);                                 /* push ax */
            ii(0x1_32a6, 2);  if(jmp_func(0x1_330b, 0x63)) return;      /* jmp 0x330b */
        }
    }
}
