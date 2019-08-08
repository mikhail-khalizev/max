using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("35a1c6c8-17fb-4825-a79f-22b59b9c7bef")]
        public void Method_0000_75bd()
        {
            ii(0x75bd, 5);    cmp(memw_a16[ds, 0xe70], 0);              /* cmp word [0xe70], 0x0 */
            ii(0x75c2, 2);    if(jgew(0x75cb, 0x7)) goto l_0x75cb;      /* jge 0x75cb */
            ii(0x75c4, 3);    pushw(0x1190);                            /* push 0x1190 */
            ii(0x75c7, 3);    callw(0x9d58, 0x278e);                    /* call 0x9d58 */
            ii(0x75ca, 1);    popw(bx);                                 /* pop bx */
        l_0x75cb:
            ii(0x75cb, 5);    cmp(memw_a16[ds, 0xe70], 0);              /* cmp word [0xe70], 0x0 */
            ii(0x75d0, 2);    if(jgew(0x75d8, 0x6)) goto l_0x75d8;      /* jge 0x75d8 */
            ii(0x75d2, 2);    pushw(-0x8 /* 0xf8 */);                   /* push 0xfff8 */
            ii(0x75d4, 3);    callw(0x604d, -0x158a);                   /* call 0x604d */
            ii(0x75d7, 1);    popw(bx);                                 /* pop bx */
        l_0x75d8:
            ii(0x75d8, 4);    pushw(memw_a16[ds, 0x996]);               /* push word [0x996] */
            ii(0x75dc, 2);    pushw(0);                                 /* push 0x0 */
            ii(0x75de, 3);    callw(0x7066, -0x57b);                    /* call 0x7066 */
            ii(0x75e1, 1);    popw(bx);                                 /* pop bx */
            ii(0x75e2, 1);    popw(bx);                                 /* pop bx */
            ii(0x75e3, 1);    retw(); return;                           /* ret */
        }
    }
}
