using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_eb64-2e7b69bd")]
        public void Method_0017_eb64()
        {
            ii(0x17_eb64, 1); push(bp);                                 /* push bp */
            ii(0x17_eb65, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x17_eb67, 1); push(si);                                 /* push si */
            ii(0x17_eb68, 1); push(di);                                 /* push di */
            ii(0x17_eb69, 1); push(ds);                                 /* push ds */
            ii(0x17_eb6a, 3); lds(bx, memw[ss, bp + 10]);               /* lds bx, [bp+0xa] */
            ii(0x17_eb6d, 3); push(memw[ds, bx + 16]);                  /* push word [bx+0x10] */
            ii(0x17_eb70, 3); mov(dx, memw[ds, bx + 14]);               /* mov dx, [bx+0xe] */
            ii(0x17_eb73, 3); mov(si, memw[ds, bx + 6]);                /* mov si, [bx+0x6] */
            ii(0x17_eb76, 3); mov(di, memw[ds, bx + 4]);                /* mov di, [bx+0x4] */
            ii(0x17_eb79, 3); mov(cx, memw[ds, bx + 2]);                /* mov cx, [bx+0x2] */
            ii(0x17_eb7c, 3); call(0x17_eadb, -0xa4);                   /* call 0xeadb */
            ii(0x17_eb7f, 2); mov(es, cx);                              /* mov es, cx */
            ii(0x17_eb81, 2); mov(cx, memw[ds, bx]);                    /* mov cx, [bx] */
            ii(0x17_eb83, 3); call(0x17_eadb, -0xab);                   /* call 0xeadb */
            ii(0x17_eb86, 2); mov(ds, cx);                              /* mov ds, cx */
            ii(0x17_eb88, 1); pop(cx);                                  /* pop cx */
            ii(0x17_eb89, 3); mov(ax, memw[ss, bp + 6]);                /* mov ax, [bp+0x6] */
            ii(0x17_eb8c, 3); mov(bx, memw[ss, bp + 8]);                /* mov bx, [bp+0x8] */
            ii(0x17_eb8f, 2); @int(0x31);                               /* int 0x31 */
            ii(0x17_eb91, 1); push(bx);                                 /* push bx */
            ii(0x17_eb92, 1); push(ds);                                 /* push ds */
            ii(0x17_eb93, 3); lds(bx, memw[ss, bp + 10]);               /* lds bx, [bp+0xa] */
            ii(0x17_eb96, 2); if(jmp_func(0x17_eb1e, -0x7a)) return;    /* jmp 0xeb1e */
        }
    }
}
