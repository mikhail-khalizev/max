using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x75bd-f7b2e3f7")]
        public void Method_0000_75bd()
        {
            ii(0x75bd, 5);  cmp(memw[ds, 0xe70], 0);                   /* cmp word [0xe70], 0x0 */
            ii(0x75c2, 2);  if(jge(0x75cb, 7)) goto l_0x75cb;          /* jge 0x75cb */
            ii(0x75c4, 3);  push(0x1190);                              /* push 0x1190 */
            ii(0x75c7, 3);  call(0x9d58, 0x278e);                      /* call 0x9d58 */
            ii(0x75ca, 1);  pop(bx);                                   /* pop bx */
        l_0x75cb:
            ii(0x75cb, 5);  cmp(memw[ds, 0xe70], 0);                   /* cmp word [0xe70], 0x0 */
            ii(0x75d0, 2);  if(jge(0x75d8, 6)) goto l_0x75d8;          /* jge 0x75d8 */
            ii(0x75d2, 2);  push(-8 /* 0xf8 */);                       /* push 0xfff8 */
            ii(0x75d4, 3);  call(0x604d, -0x158a);                     /* call 0x604d */
            ii(0x75d7, 1);  pop(bx);                                   /* pop bx */
        l_0x75d8:
            ii(0x75d8, 4);  push(memw[ds, 0x996]);                     /* push word [0x996] */
            ii(0x75dc, 2);  push(0);                                   /* push 0x0 */
            ii(0x75de, 3);  call(0x7066, -0x57b);                      /* call 0x7066 */
            ii(0x75e1, 1);  pop(bx);                                   /* pop bx */
            ii(0x75e2, 1);  pop(bx);                                   /* pop bx */
            ii(0x75e3, 1);  ret();                                     /* ret */
        }
    }
}
