using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x4cb4-384fe75c")]
        public void Method_0000_4cb4()
        {
            ii(0x4cb4, 6);  test(memw[ds, 0x1582], 1);                 /* test word [0x1582], 0x1 */
            ii(0x4cba, 2);  if(jz(0x4cc9, 0xd)) goto l_0x4cc9;         /* jz 0x4cc9 */
            ii(0x4cbc, 3);  mov(ax, 0x1706);                           /* mov ax, 0x1706 */
            ii(0x4cbf, 3);  mov(memw[ds, 0x9c0], ax);                  /* mov [0x9c0], ax */
            ii(0x4cc2, 3);  mov(ax, 2);                                /* mov ax, 0x2 */
            ii(0x4cc5, 4);  call_far_ind(memw[ds, 0x155c]);            /* call far word [0x155c] */
        l_0x4cc9:
            ii(0x4cc9, 1);  ret();                                     /* ret */
        }
    }
}
