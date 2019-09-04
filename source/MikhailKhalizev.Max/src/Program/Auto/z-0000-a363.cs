using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xa363-2e3be89a")]
        public void Method_0000_a363()
        {
            ii(0xa363, 3);  mov(ax, memw[ds, 0xcde]);                  /* mov ax, [0xcde] */
            ii(0xa366, 1);  inc(ax);                                   /* inc ax */
            ii(0xa367, 2);  and(al, 0xfe);                             /* and al, 0xfe */
            ii(0xa369, 2);  mov(bx, sp);                               /* mov bx, sp */
            ii(0xa36b, 3);  mov(cx, memw[ds, bx + 2]);                 /* mov cx, [bx+0x2] */
            ii(0xa36e, 2);  add(cx, ax);                               /* add cx, ax */
            ii(0xa370, 2);  if(jb(0xa37d, 0xb)) goto l_0xa37d;         /* jb 0xa37d */
            ii(0xa372, 4);  cmp(cx, memw[ds, 0xce6]);                  /* cmp cx, [0xce6] */
            ii(0xa376, 2);  if(ja(0xa37d, 5)) goto l_0xa37d;           /* ja 0xa37d */
            ii(0xa378, 4);  mov(memw[ds, 0xcde], cx);                  /* mov [0xcde], cx */
            ii(0xa37c, 1);  ret(); return;                             /* ret */
        l_0xa37d:
            ii(0xa37d, 3);  mov(ax, 0xffff);                           /* mov ax, 0xffff */
            ii(0xa380, 1);  ret();                                     /* ret */
        }
    }
}
