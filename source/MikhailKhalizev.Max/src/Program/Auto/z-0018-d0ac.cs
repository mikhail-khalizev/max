using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_d0ac-3c13f7b2")]
        public void Method_0018_d0ac()
        {
            ii(0x18_d0ac, 4); enter(0xa, 0);                            /* enter 0xa, 0x0 */
            ii(0x18_d0b0, 1); push(di);                                 /* push di */
            ii(0x18_d0b1, 1); push(si);                                 /* push si */
            ii(0x18_d0b2, 2); sub(si, si);                              /* sub si, si */
            ii(0x18_d0b4, 3); lea(ax, memw[ss, bp - 10]);               /* lea ax, [bp-0xa] */
            ii(0x18_d0b7, 1); push(ax);                                 /* push ax */
            ii(0x18_d0b8, 3); push(memw[ss, bp + 4]);                   /* push word [bp+0x4] */
            ii(0x18_d0bb, 3); call(0x18_dc8e, 0xbd0);                   /* call 0xdc8e */
            ii(0x18_d0be, 1); pop(bx);                                  /* pop bx */
            ii(0x18_d0bf, 1); pop(bx);                                  /* pop bx */
            ii(0x18_d0c0, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x18_d0c2, 2); if(jz(0x18_d0f4, 0x30)) goto l_0x18_d0f4; /* jz 0xd0f4 */
            ii(0x18_d0c4, 4); test(memb[ss, bp - 2], 0x7f);             /* test byte [bp-0x2], 0x7f */
            ii(0x18_d0c8, 2); if(jz(0x18_d0f4, 0x2a)) goto l_0x18_d0f4; /* jz 0xd0f4 */
            ii(0x18_d0ca, 2); push(1);                                  /* push 0x1 */
            ii(0x18_d0cc, 3); call(0x18_dcef, 0xc20);                   /* call 0xdcef */
            ii(0x18_d0cf, 1); pop(bx);                                  /* pop bx */
            ii(0x18_d0d0, 2); mov(si, ax);                              /* mov si, ax */
            ii(0x18_d0d2, 2); or(si, si);                               /* or si, si */
            ii(0x18_d0d4, 2); if(jz(0x18_d0f4, 0x1e)) goto l_0x18_d0f4; /* jz 0xd0f4 */
            ii(0x18_d0d6, 3); mov(al, memb[ss, bp + 6]);                /* mov al, [bp+0x6] */
            ii(0x18_d0d9, 3); mov(memb[ss, bp - 2], al);                /* mov [bp-0x2], al */
            ii(0x18_d0dc, 3); lea(ax, memw[ss, bp - 10]);               /* lea ax, [bp-0xa] */
            ii(0x18_d0df, 1); push(ax);                                 /* push ax */
            ii(0x18_d0e0, 1); push(si);                                 /* push si */
            ii(0x18_d0e1, 3); call(0x18_dc28, 0xb44);                   /* call 0xdc28 */
            ii(0x18_d0e4, 1); pop(bx);                                  /* pop bx */
            ii(0x18_d0e5, 1); pop(bx);                                  /* pop bx */
            ii(0x18_d0e6, 3); mov(bx, memw[ss, bp + 4]);                /* mov bx, [bp+0x4] */
            ii(0x18_d0e9, 3); shr(bx, 3);                               /* shr bx, 0x3 */
            ii(0x18_d0ec, 4); les(di, memw[ds, 0xaa0]);                 /* les di, [0xaa0] */
            ii(0x18_d0f0, 4); or(memb[es, bx + di], 0x10);              /* or byte [es:bx+di], 0x10 */
        l_0x18_d0f4:
            ii(0x18_d0f4, 2); mov(ax, si);                              /* mov ax, si */
            ii(0x18_d0f6, 1); pop(si);                                  /* pop si */
            ii(0x18_d0f7, 1); pop(di);                                  /* pop di */
            ii(0x18_d0f8, 1); leave();                                  /* leave */
            ii(0x18_d0f9, 1); ret();                                    /* ret */
        }
    }
}
