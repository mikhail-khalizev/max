using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_412f-9d813529")]
        public void Method_0019_412f()
        {
            ii(0x19_412f, 1); push(bp);                                 /* push bp */
            ii(0x19_4130, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x19_4132, 1); push(si);                                 /* push si */
            ii(0x19_4133, 1); push(di);                                 /* push di */
            ii(0x19_4134, 1); push(ds);                                 /* push ds */
            ii(0x19_4135, 3); mov(ax, memw[ss, bp + 0x6]);              /* mov ax, [bp+0x6] */
            ii(0x19_4138, 3); lds(bx, ss, bp + 0x8);                    /* lds bx, [bp+0x8] */
            ii(0x19_413b, 3); mov(cx, memw[ds, bx + 0x10]);             /* mov cx, [bx+0x10] */
            ii(0x19_413e, 3); mov(dx, memw[ds, bx + 0xe]);              /* mov dx, [bx+0xe] */
            ii(0x19_4141, 3); mov(si, memw[ds, bx + 0x6]);              /* mov si, [bx+0x6] */
            ii(0x19_4144, 3); mov(di, memw[ds, bx + 0x4]);              /* mov di, [bx+0x4] */
            ii(0x19_4147, 3); mov(cx, memw[ds, bx + 0x2]);              /* mov cx, [bx+0x2] */
            ii(0x19_414a, 3); call(0x19_40cc, -0x81);                   /* call 0x40cc */
            ii(0x19_414d, 2); mov(es, cx);                              /* mov es, cx */
            ii(0x19_414f, 2); mov(cx, memw[ds, bx]);                    /* mov cx, [bx] */
            ii(0x19_4151, 3); call(0x19_40cc, -0x88);                   /* call 0x40cc */
            ii(0x19_4154, 1); push(cx);                                 /* push cx */
            ii(0x19_4155, 3); mov(ax, memw[ss, bp + 0x6]);              /* mov ax, [bp+0x6] */
            ii(0x19_4158, 3); mov(cx, memw[ds, bx + 0x10]);             /* mov cx, [bx+0x10] */
            ii(0x19_415b, 3); mov(bx, memw[ds, bx + 0xc]);              /* mov bx, [bx+0xc] */
            ii(0x19_415e, 1); pop(ds);                                  /* pop ds */
            ii(0x19_415f, 2); @int(0x21);                               /* int 0x21 */
            ii(0x19_4161, 1); push(bx);                                 /* push bx */
            ii(0x19_4162, 1); push(ds);                                 /* push ds */
            ii(0x19_4163, 3); lds(bx, ss, bp + 0x8);                    /* lds bx, [bp+0x8] */
            ii(0x19_4166, 2); pop(memw[ds, bx]);                        /* pop word [bx] */
            ii(0x19_4168, 3); mov(memw[ds, bx + 0x2], es);              /* mov [bx+0x2], es */
            ii(0x19_416b, 3); mov(memw[ds, bx + 0x4], di);              /* mov [bx+0x4], di */
            ii(0x19_416e, 3); mov(memw[ds, bx + 0x6], si);              /* mov [bx+0x6], si */
            ii(0x19_4171, 3); mov(memw[ds, bx + 0xe], dx);              /* mov [bx+0xe], dx */
            ii(0x19_4174, 3); mov(memw[ds, bx + 0x10], cx);             /* mov [bx+0x10], cx */
            ii(0x19_4177, 3); pop(memw[ds, bx + 0xc]);                  /* pop word [bx+0xc] */
            ii(0x19_417a, 3); mov(memw[ds, bx + 0x12], ax);             /* mov [bx+0x12], ax */
            ii(0x19_417d, 1); pop(ds);                                  /* pop ds */
            ii(0x19_417e, 1); pop(di);                                  /* pop di */
            ii(0x19_417f, 1); pop(si);                                  /* pop si */
            ii(0x19_4180, 3); mov(ax, 0);                               /* mov ax, 0x0 */
            ii(0x19_4183, 1); cmc();                                    /* cmc */
            ii(0x19_4184, 2); rcl(ax, 0x1);                             /* rcl ax, 1 */
            ii(0x19_4186, 1); pop(bp);                                  /* pop bp */
            ii(0x19_4187, 1); retf();                                   /* retf */
        }
    }
}
