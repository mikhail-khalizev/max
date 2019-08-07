using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("5c53f5f9-ea4f-4857-8968-f6e74410bb4f")]
        public void Method_0015_412f()
        {
            ii(0x15_412f, 1); pushw(bp);                                /* push bp */
            ii(0x15_4130, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x15_4132, 1); pushw(si);                                /* push si */
            ii(0x15_4133, 1); pushw(di);                                /* push di */
            ii(0x15_4134, 1); pushw(ds);                                /* push ds */
            ii(0x15_4135, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x15_4138, 3); lds(bx, ss, bp + 0x8);                    /* lds bx, [bp+0x8] */
            ii(0x15_413b, 3); mov(cx, memw_a16[ds, bx + 0x10]);         /* mov cx, [bx+0x10] */
            ii(0x15_413e, 3); mov(dx, memw_a16[ds, bx + 0xe]);          /* mov dx, [bx+0xe] */
            ii(0x15_4141, 3); mov(si, memw_a16[ds, bx + 0x6]);          /* mov si, [bx+0x6] */
            ii(0x15_4144, 3); mov(di, memw_a16[ds, bx + 0x4]);          /* mov di, [bx+0x4] */
            ii(0x15_4147, 3); mov(cx, memw_a16[ds, bx + 0x2]);          /* mov cx, [bx+0x2] */
            ii(0x15_414a, 3); callw(0x15_40cc, -0x81);                  /* call 0x40cc */
            ii(0x15_414d, 2); mov(es, cx);                              /* mov es, cx */
            ii(0x15_414f, 2); mov(cx, memw_a16[ds, bx]);                /* mov cx, [bx] */
            ii(0x15_4151, 3); callw(0x15_40cc, -0x88);                  /* call 0x40cc */
            ii(0x15_4154, 1); pushw(cx);                                /* push cx */
            ii(0x15_4155, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x15_4158, 3); mov(cx, memw_a16[ds, bx + 0x10]);         /* mov cx, [bx+0x10] */
            ii(0x15_415b, 3); mov(bx, memw_a16[ds, bx + 0xc]);          /* mov bx, [bx+0xc] */
            ii(0x15_415e, 1); popw(ds);                                 /* pop ds */
            ii(0x15_415f, 2); @int(0x21);                               /* int 0x21 */
            ii(0x15_4161, 1); pushw(bx);                                /* push bx */
            ii(0x15_4162, 1); pushw(ds);                                /* push ds */
            ii(0x15_4163, 3); lds(bx, ss, bp + 0x8);                    /* lds bx, [bp+0x8] */
            ii(0x15_4166, 2); popw(memw_a16[ds, bx]);                   /* pop word [bx] */
            ii(0x15_4168, 3); mov(memw_a16[ds, bx + 0x2], es);          /* mov [bx+0x2], es */
            ii(0x15_416b, 3); mov(memw_a16[ds, bx + 0x4], di);          /* mov [bx+0x4], di */
            ii(0x15_416e, 3); mov(memw_a16[ds, bx + 0x6], si);          /* mov [bx+0x6], si */
            ii(0x15_4171, 3); mov(memw_a16[ds, bx + 0xe], dx);          /* mov [bx+0xe], dx */
            ii(0x15_4174, 3); mov(memw_a16[ds, bx + 0x10], cx);         /* mov [bx+0x10], cx */
            ii(0x15_4177, 3); popw(memw_a16[ds, bx + 0xc]);             /* pop word [bx+0xc] */
            ii(0x15_417a, 3); mov(memw_a16[ds, bx + 0x12], ax);         /* mov [bx+0x12], ax */
            ii(0x15_417d, 1); popw(ds);                                 /* pop ds */
            ii(0x15_417e, 1); popw(di);                                 /* pop di */
            ii(0x15_417f, 1); popw(si);                                 /* pop si */
            ii(0x15_4180, 3); mov(ax, 0);                               /* mov ax, 0x0 */
            ii(0x15_4183, 1); cmc();                                    /* cmc */
            ii(0x15_4184, 2); rcl(ax, 0x1);                             /* rcl ax, 1 */
            ii(0x15_4186, 1); popw(bp);                                 /* pop bp */
            ii(0x15_4187, 1); retfw(); return;                          /* retf */
        }
    }
}
