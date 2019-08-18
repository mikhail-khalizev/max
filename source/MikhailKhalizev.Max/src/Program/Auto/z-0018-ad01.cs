using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_ad01-d6a72f31")]
        public void Method_0018_ad01()
        {
            ii(0x18_ad01, 1); pushw(bx);                                /* push bx */
            ii(0x18_ad02, 3); mov(bl, memb_a16[ss, bp + 0x16]);         /* mov bl, [bp+0x16] */
            ii(0x18_ad05, 2); xor(bh, bh);                              /* xor bh, bh */
            ii(0x18_ad07, 4); cmp(memb_a16[ds, 0x2e], bh);              /* cmp [0x2e], bh */
            ii(0x18_ad0b, 2); if(jzw(0x18_ad12, 0x5)) goto l_0x18_ad12; /* jz 0xad12 */
            ii(0x18_ad0d, 3); cmp(bl, 0xd);                             /* cmp bl, 0xd */
            ii(0x18_ad10, 2); if(jzw(0x18_ad29, 0x17)) goto l_0x18_ad29; /* jz 0xad29 */
        l_0x18_ad12:
            ii(0x18_ad12, 3); mov(ax, 0x204);                           /* mov ax, 0x204 */
            ii(0x18_ad15, 2); pushd(edx);                               /* push edx */
            ii(0x18_ad17, 1); popw(dx);                                 /* pop dx */
            ii(0x18_ad18, 1); pushw(cs);                                /* push cs */
            ii(0x18_ad19, 3); callw(0x18_a3b9, -0x963);                 /* call 0xa3b9 */
            ii(0x18_ad1c, 1); pushw(dx);                                /* push dx */
            ii(0x18_ad1d, 2); popd(edx);                                /* pop edx */
        l_0x18_ad1f:
            ii(0x18_ad1f, 3); mov(memw_a16[ss, bp + 0x6], cx);          /* mov [bp+0x6], cx */
            ii(0x18_ad22, 3); mov(memw_a16[ss, bp + 0x10], dx);         /* mov [bp+0x10], dx */
            ii(0x18_ad25, 1); popw(bx);                                 /* pop bx */
            ii(0x18_ad26, 3); if(jmpw_func(0x18_a838, -0x4f1)) return;  /* jmp 0xa838 */
        l_0x18_ad29:
            ii(0x18_ad29, 2); pushw(0x10);                              /* push 0x10 */
            ii(0x18_ad2b, 3); shl(bx, 0x3);                             /* shl bx, 0x3 */
            ii(0x18_ad2e, 1); popw(es);                                 /* pop es */
            ii(0x18_ad2f, 4); mov(cx, memw_a16[es, bx + 0x2]);          /* mov cx, [es:bx+0x2] */
            ii(0x18_ad33, 3); mov(dx, memw_a16[es, bx]);                /* mov dx, [es:bx] */
            ii(0x18_ad36, 2); jmpw(0x18_ad1f, -0x19); goto l_0x18_ad1f; /* jmp 0xad1f */
        }
    }
}
