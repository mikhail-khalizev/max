using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("de4e5e89-bc3f-4331-ad99-4cac57cfe9d2")]
        public void Method_0014_e868()
        {
            ii(0x14_e868, 2); pushw(0x20);                              /* push 0x20 */
            ii(0x14_e86a, 1); popw(ds);                                 /* pop ds */
            ii(0x14_e86b, 4); pushw(memw_a16[ds, 0xc14]);               /* push word [0xc14] */
            ii(0x14_e86f, 2); pushw(0x8);                               /* push 0x8 */
            ii(0x14_e871, 1); popw(ds);                                 /* pop ds */
            ii(0x14_e872, 2); mov(bx, cs);                              /* mov bx, cs */
            ii(0x14_e874, 3); mov(cx, memw_a16[ds, bx + 0x2]);          /* mov cx, [bx+0x2] */
            ii(0x14_e877, 3); mov(al, memb_a16[ds, bx + 0x4]);          /* mov al, [bx+0x4] */
            ii(0x14_e87a, 3); mov(ah, memb_a16[ds, bx + 0x7]);          /* mov ah, [bx+0x7] */
            ii(0x14_e87d, 1); popw(bx);                                 /* pop bx */
            ii(0x14_e87e, 3); add(bx, 0x8);                             /* add bx, 0x8 */
            ii(0x14_e881, 3); mov(memw_a16[ds, bx + 0x2], cx);          /* mov [bx+0x2], cx */
            ii(0x14_e884, 3); mov(memb_a16[ds, bx + 0x4], al);          /* mov [bx+0x4], al */
            ii(0x14_e887, 3); mov(memb_a16[ds, bx + 0x7], ah);          /* mov [bx+0x7], ah */
            ii(0x14_e88a, 4); mov(memw_a16[ds, bx], 0xffff);            /* mov word [bx], 0xffff */
            ii(0x14_e88e, 4); mov(memb_a16[ds, bx + 0x5], 0x92);        /* mov byte [bx+0x5], 0x92 */
            ii(0x14_e892, 2); mov(ds, bx);                              /* mov ds, bx */
            ii(0x14_e894, 1); retw(); return;                           /* ret */
        }
    }
}
