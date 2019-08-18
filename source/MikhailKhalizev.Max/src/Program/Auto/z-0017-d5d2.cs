using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_d5d2-59f44522")]
        public void Method_0017_d5d2()
        {
            ii(0x17_d5d2, 4); mov(cx, memw_a16[ds, 0x1dbe]);            /* mov cx, [0x1dbe] */
            ii(0x17_d5d6, 2); if(jcxzw(0x17_d5df, 0x7)) goto l_0x17_d5df; /* jcxz 0xd5df */
            ii(0x17_d5d8, 3); mov(bx, 0x2);                             /* mov bx, 0x2 */
            ii(0x17_d5db, 4); callw_a16_far_ind(ds, 0x1dbc);            /* call far word [0x1dbc] */
        l_0x17_d5df:
            ii(0x17_d5df, 1); pushw(ds);                                /* push ds */
            ii(0x17_d5e0, 4); lds(dx, ds, 0x1c40);                      /* lds dx, [0x1c40] */
            ii(0x17_d5e4, 3); mov(ax, 0x2500);                          /* mov ax, 0x2500 */
            ii(0x17_d5e7, 2); @int(0x21);                               /* int 0x21 */
            ii(0x17_d5e9, 1); popw(ds);                                 /* pop ds */
            ii(0x17_d5ea, 5); cmp(memb_a16[ds, 0x1c7e], 0);             /* cmp byte [0x1c7e], 0x0 */
            ii(0x17_d5ef, 2); if(jzw(0x17_d5fe, 0xd)) goto l_0x17_d5fe; /* jz 0xd5fe */
            ii(0x17_d5f1, 1); pushw(ds);                                /* push ds */
            ii(0x17_d5f2, 3); mov(al, memb_a16[ds, 0x1c7f]);            /* mov al, [0x1c7f] */
            ii(0x17_d5f5, 4); lds(dx, ds, 0x1c80);                      /* lds dx, [0x1c80] */
            ii(0x17_d5f9, 2); mov(ah, 0x25);                            /* mov ah, 0x25 */
            ii(0x17_d5fb, 2); @int(0x21);                               /* int 0x21 */
            ii(0x17_d5fd, 1); popw(ds);                                 /* pop ds */
        l_0x17_d5fe:
            ii(0x17_d5fe, 1); retw(); return;                           /* ret */
        }
    }
}
