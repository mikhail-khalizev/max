using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("2b5008cc-9f7e-4772-8b4b-2ebf8dff25cd")]
        public void Method_0017_eaed()
        {
            ii(0x17_eaed, 1); pushw(bp);                                /* push bp */
            ii(0x17_eaee, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x17_eaf0, 1); pushw(si);                                /* push si */
            ii(0x17_eaf1, 1); pushw(di);                                /* push di */
            ii(0x17_eaf2, 1); pushw(ds);                                /* push ds */
            ii(0x17_eaf3, 3); lds(bx, ss, bp + 0x8);                    /* lds bx, [bp+0x8] */
            ii(0x17_eaf6, 3); mov(dx, memw_a16[ds, bx + 0xe]);          /* mov dx, [bx+0xe] */
            ii(0x17_eaf9, 3); mov(si, memw_a16[ds, bx + 0x6]);          /* mov si, [bx+0x6] */
            ii(0x17_eafc, 3); mov(di, memw_a16[ds, bx + 0x4]);          /* mov di, [bx+0x4] */
            ii(0x17_eaff, 3); mov(cx, memw_a16[ds, bx + 0x2]);          /* mov cx, [bx+0x2] */
            ii(0x17_eb02, 3); callw(0x17_eadb, -0x2a);                  /* call 0xeadb */
            ii(0x17_eb05, 2); mov(es, cx);                              /* mov es, cx */
            ii(0x17_eb07, 2); mov(cx, memw_a16[ds, bx]);                /* mov cx, [bx] */
            ii(0x17_eb09, 3); callw(0x17_eadb, -0x31);                  /* call 0xeadb */
            ii(0x17_eb0c, 1); pushw(cx);                                /* push cx */
            ii(0x17_eb0d, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x17_eb10, 3); mov(cx, memw_a16[ds, bx + 0x10]);         /* mov cx, [bx+0x10] */
            ii(0x17_eb13, 3); mov(bx, memw_a16[ds, bx + 0xc]);          /* mov bx, [bx+0xc] */
            ii(0x17_eb16, 1); popw(ds);                                 /* pop ds */
            ii(0x17_eb17, 2); @int(0x21);                               /* int 0x21 */
            ii(0x17_eb19, 1); pushw(bx);                                /* push bx */
            ii(0x17_eb1a, 1); pushw(ds);                                /* push ds */
            ii(0x17_eb1b, 3); lds(bx, ss, bp + 0x8);                    /* lds bx, [bp+0x8] */
        }
    }
}
