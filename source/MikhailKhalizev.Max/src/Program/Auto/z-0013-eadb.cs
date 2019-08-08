using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("71b449b1-c56b-48fa-a687-f2c830e4be3d")]
        public void Method_0013_eadb()
        {
            ii(0x13_eadb, 1); nop();                                    /* nop */
            ii(0x13_eadc, 2); xor(ax, ax);                              /* xor ax, ax */
            ii(0x13_eade, 3); lar(ax, cx);                              /* lar ax, cx */
            ii(0x13_eae1, 2); jmpw(0x13_eae3, 0); goto l_0x13_eae3;     /* jmp 0xeae3 */
        l_0x13_eae3:
            ii(0x13_eae3, 2); if(jnzw(0x13_eaea, 0x5)) goto l_0x13_eaea; /* jnz 0xeaea */
            ii(0x13_eae5, 3); test(ah, 0x10);                           /* test ah, 0x10 */
            ii(0x13_eae8, 2); if(jnzw(0x13_eaec, 0x2)) goto l_0x13_eaec; /* jnz 0xeaec */
        l_0x13_eaea:
            ii(0x13_eaea, 2); xor(cx, cx);                              /* xor cx, cx */
        l_0x13_eaec:
            ii(0x13_eaec, 1); retw(); return;                           /* ret */
        }
    }
}
