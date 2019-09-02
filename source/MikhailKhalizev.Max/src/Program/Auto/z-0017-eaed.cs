using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_eaed-5c2c2199")]
        public void Method_0017_eaed()
        {
            ii(0x17_eaed, 1); push(bp);                                 /* push bp */
            ii(0x17_eaee, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x17_eaf0, 1); push(si);                                 /* push si */
            ii(0x17_eaf1, 1); push(di);                                 /* push di */
            ii(0x17_eaf2, 1); push(ds);                                 /* push ds */
            ii(0x17_eaf3, 3); lds(bx, memw[ss, bp + 8]);                /* lds bx, [bp+0x8] */
            ii(0x17_eaf6, 3); mov(dx, memw[ds, bx + 14]);               /* mov dx, [bx+0xe] */
            ii(0x17_eaf9, 3); mov(si, memw[ds, bx + 6]);                /* mov si, [bx+0x6] */
            ii(0x17_eafc, 3); mov(di, memw[ds, bx + 4]);                /* mov di, [bx+0x4] */
            ii(0x17_eaff, 3); mov(cx, memw[ds, bx + 2]);                /* mov cx, [bx+0x2] */
            ii(0x17_eb02, 3); call(0x17_eadb, -0x2a);                   /* call 0xeadb */
            ii(0x17_eb05, 2); mov(es, cx);                              /* mov es, cx */
            ii(0x17_eb07, 2); mov(cx, memw[ds, bx]);                    /* mov cx, [bx] */
            ii(0x17_eb09, 3); call(0x17_eadb, -0x31);                   /* call 0xeadb */
            ii(0x17_eb0c, 1); push(cx);                                 /* push cx */
            ii(0x17_eb0d, 3); mov(ax, memw[ss, bp + 6]);                /* mov ax, [bp+0x6] */
            ii(0x17_eb10, 3); mov(cx, memw[ds, bx + 16]);               /* mov cx, [bx+0x10] */
            ii(0x17_eb13, 3); mov(bx, memw[ds, bx + 12]);               /* mov bx, [bx+0xc] */
            ii(0x17_eb16, 1); pop(ds);                                  /* pop ds */
            ii(0x17_eb17, 2); @int(0x21);                               /* int 0x21 */
            ii(0x17_eb19, 1); push(bx);                                 /* push bx */
            ii(0x17_eb1a, 1); push(ds);                                 /* push ds */
            ii(0x17_eb1b, 3); lds(bx, memw[ss, bp + 8]);                /* lds bx, [bp+0x8] */
        }
    }
}
