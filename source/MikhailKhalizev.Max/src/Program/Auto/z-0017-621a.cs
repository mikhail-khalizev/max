using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("cffef966-5cad-488b-9a44-94e036c43bcf")]
        public void Method_0017_621a()
        {
            ii(0x17_621a, 4); enterw(0xa, 0);                           /* enter 0xa, 0x0 */
            ii(0x17_621e, 1); pushw(ds);                                /* push ds */
            ii(0x17_621f, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x17_6222, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x17_6224, 3); mov(ax, memw_a16[ss, bp + 0x8]);          /* mov ax, [bp+0x8] */
            ii(0x17_6227, 3); mov(bx, memw_a16[ss, bp + 0x6]);          /* mov bx, [bp+0x6] */
            ii(0x17_622a, 3); mov(cx, 0x8);                             /* mov cx, 0x8 */
            ii(0x17_622d, 2); mov(es, cx);                              /* mov es, cx */
            ii(0x17_622f, 3); mov(memw_a16[ss, bp - 0x6], bx);          /* mov [bp-0x6], bx */
            ii(0x17_6232, 3); mov(memw_a16[ss, bp - 0x4], es);          /* mov [bp-0x4], es */
            ii(0x17_6235, 4); mov(memw_a16[es, bx + 0x2], ax);          /* mov [es:bx+0x2], ax */
            ii(0x17_6239, 3); mov(al, memb_a16[ss, bp + 0xa]);          /* mov al, [bp+0xa] */
            ii(0x17_623c, 4); mov(memb_a16[es, bx + 0x4], al);          /* mov [es:bx+0x4], al */
            ii(0x17_6240, 3); mov(al, memb_a16[ss, bp + 0xb]);          /* mov al, [bp+0xb] */
            ii(0x17_6243, 2); sub(ah, ah);                              /* sub ah, ah */
            ii(0x17_6245, 4); mov(memb_a16[es, bx + 0x7], al);          /* mov [es:bx+0x7], al */
            ii(0x17_6249, 3); mov(ax, memw_a16[ss, bp + 0xc]);          /* mov ax, [bp+0xc] */
            ii(0x17_624c, 3); mov(memw_a16[es, bx], ax);                /* mov [es:bx], ax */
            ii(0x17_624f, 3); mov(al, memb_a16[ss, bp + 0x10]);         /* mov al, [bp+0x10] */
            ii(0x17_6252, 4); mov(memb_a16[es, bx + 0x5], al);          /* mov [es:bx+0x5], al */
            ii(0x17_6256, 3); mov(al, memb_a16[ss, bp + 0x12]);         /* mov al, [bp+0x12] */
            ii(0x17_6259, 4); mov(memb_a16[es, bx + 0x6], al);          /* mov [es:bx+0x6], al */
            ii(0x17_625d, 1); popw(ds);                                 /* pop ds */
            ii(0x17_625e, 1); leavew();                                 /* leave */
            ii(0x17_625f, 1); retfw(); return;                          /* retf */
        }
    }
}
