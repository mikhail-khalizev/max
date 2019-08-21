using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xe05a-ee94dbc")]
        public void Method_0000_e05a()
        {
            ii(0xe05a, 1);    pushfw();                                 /* pushfw */
            ii(0xe05b, 1);    cli();                                    /* cli */
            ii(0xe05c, 2);    pushw(0x20);                              /* push 0x20 */
            ii(0xe05e, 1);    popw(ds);                                 /* pop ds */
            ii(0xe05f, 3);    sub(sp, 0x4);                             /* sub sp, 0x4 */
            ii(0xe062, 1);    pushw(bp);                                /* push bp */
            ii(0xe063, 2);    mov(bp, ss);                              /* mov bp, ss */
            ii(0xe065, 3);    cmp(bp, 0x20);                            /* cmp bp, 0x20 */
            ii(0xe068, 2);    if(jzw(0xe06f, 0x5)) goto l_0xe06f;       /* jz 0xe06f */
            ii(0xe06a, 5);    sub(memw_a16[ds, 0xf52], 0x8);            /* sub word [0xf52], 0x8 */
        l_0xe06f:
            ii(0xe06f, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0xe071, 1);    pushw(bx);                                /* push bx */
            ii(0xe072, 4);    mov(bx, memw_a16[ds, 0x996]);             /* mov bx, [0x996] */
            ii(0xe076, 3);    sub(bx, 0x10);                            /* sub bx, 0x10 */
            ii(0xe079, 4);    test(memb_a16[ds, bx + 0xf], 0x2);        /* test byte [bx+0xf], 0x2 */
            ii(0xe07d, 2);    if(jzw(0xe083, 0x4)) goto l_0xe083;       /* jz 0xe083 */
            ii(0xe07f, 4);    or(memb_a16[ss, bp + 0x7], 0x2);          /* or byte [bp+0x7], 0x2 */
        l_0xe083:
            ii(0xe083, 1);    pushw(bx);                                /* push bx */
            ii(0xe084, 3);    mov(bx, memw_a16[ds, bx + 0x2]);          /* mov bx, [bx+0x2] */
            ii(0xe087, 5);    if(jmpw_far_abs(0x18, 0x1009)) return;    /* jmp word 0x18:0x1009 */
        }
    }
}
