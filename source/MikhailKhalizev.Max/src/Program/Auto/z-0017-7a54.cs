using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_7a54-516caf37")]
        public void Method_0017_7a54()
        {
            ii(0x17_7a54, 4); enterw(0x4, 0);                           /* enter 0x4, 0x0 */
            ii(0x17_7a58, 1); pushw(ds);                                /* push ds */
            ii(0x17_7a59, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x17_7a5c, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x17_7a5e, 1); nop();                                    /* nop */
            ii(0x17_7a5f, 1); pushw(cs);                                /* push cs */
            ii(0x17_7a60, 3); callw(0x17_8ff5, 0x1592);                 /* call 0x8ff5 */
            ii(0x17_7a63, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x17_7a66, 3); cmp(ax, 0xffff);                          /* cmp ax, 0xffff */
            ii(0x17_7a69, 2); if(jnzw(0x17_7a84, 0x19)) goto l_0x17_7a84; /* jnz 0x7a84 */
            ii(0x17_7a6b, 1); pushw(cs);                                /* push cs */
            ii(0x17_7a6c, 3); callw(0x17_7aa0, 0x31);                   /* call 0x7aa0 */
            ii(0x17_7a6f, 3); mov(memw_a16[ss, bp - 0x2], ax);          /* mov [bp-0x2], ax */
            ii(0x17_7a72, 2); pushw(0);                                 /* push 0x0 */
            ii(0x17_7a74, 1); pushw(ax);                                /* push ax */
            ii(0x17_7a75, 1); pushw(cs);                                /* push cs */
            ii(0x17_7a76, 3); callw(0x17_7bea, 0x171);                  /* call 0x7bea */
            ii(0x17_7a79, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x17_7a7c, 3); mov(ax, memw_a16[ss, bp - 0x2]);          /* mov ax, [bp-0x2] */
            ii(0x17_7a7f, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x17_7a82, 2); jmpw(0x17_7a97, 0x13); goto l_0x17_7a97;  /* jmp 0x7a97 */
        l_0x17_7a84:
            ii(0x17_7a84, 3); mov(ax, memw_a16[ds, 0x1fbe]);            /* mov ax, [0x1fbe] */
            ii(0x17_7a87, 4); or(ax, memw_a16[ds, 0x1fbc]);             /* or ax, [0x1fbc] */
            ii(0x17_7a8b, 2); if(jzw(0x17_7a97, 0xa)) goto l_0x17_7a97; /* jz 0x7a97 */
            ii(0x17_7a8d, 5); sub(memw_a16[ds, 0x1fbc], 0x1);           /* sub word [0x1fbc], 0x1 */
            ii(0x17_7a92, 5); sbb(memw_a16[ds, 0x1fbe], 0);             /* sbb word [0x1fbe], 0x0 */
        l_0x17_7a97:
            ii(0x17_7a97, 3); mov(ax, memw_a16[ss, bp - 0x4]);          /* mov ax, [bp-0x4] */
            ii(0x17_7a9a, 1); popw(ds);                                 /* pop ds */
            ii(0x17_7a9b, 1); leavew();                                 /* leave */
            ii(0x17_7a9c, 1); retfw(); return;                          /* retf */
        }
    }
}
