using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("296f3133-02ff-4248-b00d-de78d72d7245")]
        public void Method_0018_e4a2()
        {
            ii(0x18_e4a2, 2); mov(ah, 0x48);                            /* mov ah, 0x48 */
            ii(0x18_e4a4, 3); callw(0x18_e480, -0x27);                  /* call 0xe480 */
            ii(0x18_e4a7, 4); mov(memw_a32[ss, ebp + 0x18], ax);        /* mov [ebp+0x18], ax */
            ii(0x18_e4ab, 1); xchg(bx, ax);                             /* xchg bx, ax */
            ii(0x18_e4ac, 2); pushw(0x8);                               /* push 0x8 */
            ii(0x18_e4ae, 1); popw(ds);                                 /* pop ds */
            ii(0x18_e4af, 3); mov(dl, memb_a16[ds, bx + 0x4]);          /* mov dl, [bx+0x4] */
            ii(0x18_e4b2, 3); mov(ax, memw_a16[ds, bx + 0x2]);          /* mov ax, [bx+0x2] */
            ii(0x18_e4b5, 2); mov(dh, 0);                               /* mov dh, 0x0 */
            ii(0x18_e4b7, 3); mov(cx, 0x10);                            /* mov cx, 0x10 */
            ii(0x18_e4ba, 2); div(cx);                                  /* div cx */
            ii(0x18_e4bc, 4); mov(memw_a32[ss, ebp + 0x20], ax);        /* mov [ebp+0x20], ax */
            ii(0x18_e4c0, 2); pushw(0x50);                              /* push 0x50 */
            ii(0x18_e4c2, 1); popw(ds);                                 /* pop ds */
            ii(0x18_e4c3, 3); shr(bx, 0x3);                             /* shr bx, 0x3 */
        l_0x18_e4c6:
            ii(0x18_e4c6, 3); or(memb_a16[ds, bx], -0x10 /* 0xf0 */);   /* or byte [bx], 0xf0 */
            ii(0x18_e4c9, 1); inc(bx);                                  /* inc bx */
            ii(0x18_e4ca, 4); test(memb_a16[ds, bx - 0x1], 0x2);        /* test byte [bx-0x1], 0x2 */
            ii(0x18_e4ce, 2); if(jnzw(0x18_e4c6, -0xa)) goto l_0x18_e4c6; /* jnz 0xe4c6 */
            ii(0x18_e4d0, 3); if(jmpw_func(0x18_e067, -0x46c)) return;  /* jmp 0xe067 */
        }
    }
}
