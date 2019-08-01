using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("56381c0e-5793-41eb-8918-596b5537a64a")]
        public void Method_0013_eb64()
        {
            ii(0x13_eb64, 1); pushw(bp);                                /* push bp */
            ii(0x13_eb65, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x13_eb67, 1); pushw(si);                                /* push si */
            ii(0x13_eb68, 1); pushw(di);                                /* push di */
            ii(0x13_eb69, 1); pushw(ds);                                /* push ds */
            ii(0x13_eb6a, 3); lds(bx, ss, bp + 0xa);                    /* lds bx, [bp+0xa] */
            ii(0x13_eb6d, 3); pushw(memw_a16[ds, bx + 0x10]);           /* push word [bx+0x10] */
            ii(0x13_eb70, 3); mov(dx, memw_a16[ds, bx + 0xe]);          /* mov dx, [bx+0xe] */
            ii(0x13_eb73, 3); mov(si, memw_a16[ds, bx + 0x6]);          /* mov si, [bx+0x6] */
            ii(0x13_eb76, 3); mov(di, memw_a16[ds, bx + 0x4]);          /* mov di, [bx+0x4] */
            ii(0x13_eb79, 3); mov(cx, memw_a16[ds, bx + 0x2]);          /* mov cx, [bx+0x2] */
            ii(0x13_eb7c, 3); callw(0x13_eadb, -0xa4);                  /* call 0xeadb */
            ii(0x13_eb7f, 2); mov(es, cx);                              /* mov es, cx */
            ii(0x13_eb81, 2); mov(cx, memw_a16[ds, bx]);                /* mov cx, [bx] */
            ii(0x13_eb83, 3); callw(0x13_eadb, -0xab);                  /* call 0xeadb */
            ii(0x13_eb86, 2); mov(ds, cx);                              /* mov ds, cx */
            ii(0x13_eb88, 1); popw(cx);                                 /* pop cx */
            ii(0x13_eb89, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x13_eb8c, 3); mov(bx, memw_a16[ss, bp + 0x8]);          /* mov bx, [bp+0x8] */
            ii(0x13_eb8f, 2); @int(0x31);                               /* int 0x31 */
            ii(0x13_eb91, 1); pushw(bx);                                /* push bx */
            ii(0x13_eb92, 1); pushw(ds);                                /* push ds */
            ii(0x13_eb93, 3); lds(bx, ss, bp + 0xa);                    /* lds bx, [bp+0xa] */
            ii(0x13_eb96, 2); jmpw_func(0x13_eb1e, -0x7a); return;      /* jmp 0xeb1e */
        }
    }
}
