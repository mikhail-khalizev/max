using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_f55c-ba4780f6")]
        public void Method_0018_f55c()
        {
            ii(0x18_f55c, 3); if(callw_up(0x18_fa00, 0x4a1)) return;    /* call 0xfa00 */
            ii(0x18_f55f, 2); xor(bp, ax);                              /* xor bp, ax */
            ii(0x18_f561, 1); popfw();                                  /* popfw */
            ii(0x18_f562, 2); add(al, 0x34);                            /* add al, 0x34 */
            ii(0x18_f564, 3); callw(0x18_fa00, 0x499);                  /* call 0xfa00 */
            ii(0x18_f567, 3); xor(ax, 0x95e8);                          /* xor ax, 0x95e8 */
            ii(0x18_f56a, 2); add(al, 0x36);                            /* add al, 0x36 */
            ii(0x18_f56c, 3); callw(0x18_fa00, 0x491);                  /* call 0xfa00 */
            ii(0x18_f56f, 1); aaa();                                    /* aaa */
            ii(0x18_f570, 3); callw(0x18_fa00, 0x48d);                  /* call 0xfa00 */
            ii(0x18_f573, 2); cmp(al, ch);                              /* cmp al, ch */
            ii(0x18_f575, 2); mov(memw_a16[ds, si], ax);                /* mov [si], ax */
            ii(0x18_f577, 2); cmp(ax, bp);                              /* cmp ax, bp */
            ii(0x18_f579, 2); test(memw_a16[ds, si], ax);               /* test [si], ax */
            ii(0x18_f57b, 2); cmp(ch, al);                              /* cmp ch, al */
            ii(0x18_f57d, 4); add(memw_a16[ds, si], 0xe83b);            /* add word [si], 0xe83b */
            ii(0x18_f581, 2); if(jgew(0x18_f587, 0x4)) goto l_0x18_f587; /* jge 0xf587 */
            ii(0x18_f583, 2); cmp(al, -0x18 /* 0xe8 */);                /* cmp al, 0xe8 */
            ii(0x18_f585, 2); if(jnsw_func(0x18_f58b, 0x4)) return;     /* jns 0xf58b */
        l_0x18_f587:
            ii(0x18_f587, 3); cmp(ax, 0x75e8);                          /* cmp ax, 0x75e8 */
        }
    }
}
