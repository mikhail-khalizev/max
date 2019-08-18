using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_eadb-712b4b28")]
        public void Method_0017_eadb()
        {
            ii(0x17_eadb, 1); nop();                                    /* nop */
            ii(0x17_eadc, 2); xor(ax, ax);                              /* xor ax, ax */
            ii(0x17_eade, 3); lar(ax, cx);                              /* lar ax, cx */
            ii(0x17_eae1, 2); jmpw(0x17_eae3, 0); goto l_0x17_eae3;     /* jmp 0xeae3 */
        l_0x17_eae3:
            ii(0x17_eae3, 2); if(jnzw(0x17_eaea, 0x5)) goto l_0x17_eaea; /* jnz 0xeaea */
            ii(0x17_eae5, 3); test(ah, 0x10);                           /* test ah, 0x10 */
            ii(0x17_eae8, 2); if(jnzw(0x17_eaec, 0x2)) goto l_0x17_eaec; /* jnz 0xeaec */
        l_0x17_eaea:
            ii(0x17_eaea, 2); xor(cx, cx);                              /* xor cx, cx */
        l_0x17_eaec:
            ii(0x17_eaec, 1); retw(); return;                           /* ret */
        }
    }
}
