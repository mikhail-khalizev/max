using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("9ce3932b-a6c8-4d5b-a89d-7d54bd32a8b5")]
        public void Method_0015_e2a0()
        {
            ii(0x15_e2a0, 4); enterw(0x4, 0);                           /* enter 0x4, 0x0 */
            ii(0x15_e2a4, 1); pushw(ds);                                /* push ds */
            ii(0x15_e2a5, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x15_e2a8, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x15_e2aa, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x15_e2ad, 3); mov(bx, memw_a16[ss, bp + 0xa]);          /* mov bx, [bp+0xa] */
            ii(0x15_e2b0, 3); mov(cx, 0x8);                             /* mov cx, 0x8 */
            ii(0x15_e2b3, 2); mov(es, cx);                              /* mov es, cx */
            ii(0x15_e2b5, 4); mov(memw_a16[es, bx + 0x2], ax);          /* mov [es:bx+0x2], ax */
            ii(0x15_e2b9, 3); mov(al, memb_a16[ss, bp + 0x8]);          /* mov al, [bp+0x8] */
            ii(0x15_e2bc, 4); mov(memb_a16[es, bx + 0x4], al);          /* mov [es:bx+0x4], al */
            ii(0x15_e2c0, 3); mov(al, memb_a16[ss, bp + 0x9]);          /* mov al, [bp+0x9] */
            ii(0x15_e2c3, 2); sub(ah, ah);                              /* sub ah, ah */
            ii(0x15_e2c5, 4); mov(memb_a16[es, bx + 0x7], al);          /* mov [es:bx+0x7], al */
            ii(0x15_e2c9, 3); mov(ax, memw_a16[ss, bp + 0x4]);          /* mov ax, [bp+0x4] */
            ii(0x15_e2cc, 3); mov(memw_a16[es, bx], ax);                /* mov [es:bx], ax */
            ii(0x15_e2cf, 5); mov(memb_a16[es, bx + 0x6], 0);           /* mov byte [es:bx+0x6], 0x0 */
            ii(0x15_e2d4, 5); mov(memb_a16[es, bx + 0x5], 0x93);        /* mov byte [es:bx+0x5], 0x93 */
            ii(0x15_e2d9, 1); popw(ds);                                 /* pop ds */
            ii(0x15_e2da, 1); leavew();                                 /* leave */
            ii(0x15_e2db, 3); retw(0x8); return;                        /* ret 0x8 */
        }
    }
}
