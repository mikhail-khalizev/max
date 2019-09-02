using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_c836-b634852c")]
        public void Method_0017_c836()
        {
            ii(0x17_c836, 4); enter(0xa, 0);                            /* enter 0xa, 0x0 */
            ii(0x17_c83a, 1); push(ds);                                 /* push ds */
            ii(0x17_c83b, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x17_c83e, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x17_c840, 3); mov(ax, memw[ss, bp + 0xa]);              /* mov ax, [bp+0xa] */
            ii(0x17_c843, 3); mov(dx, memw[ss, bp + 0xc]);              /* mov dx, [bp+0xc] */
            ii(0x17_c846, 2); mov(al, ah);                              /* mov al, ah */
            ii(0x17_c848, 2); mov(ah, dl);                              /* mov ah, dl */
            ii(0x17_c84a, 2); mov(dl, dh);                              /* mov dl, dh */
            ii(0x17_c84c, 2); sub(dh, dh);                              /* sub dh, dh */
            ii(0x17_c84e, 2); shr(dx, 1);                               /* shr dx, 1 */
            ii(0x17_c850, 2); rcr(ax, 1);                               /* rcr ax, 1 */
            ii(0x17_c852, 2); shr(dx, 1);                               /* shr dx, 1 */
            ii(0x17_c854, 2); rcr(ax, 1);                               /* rcr ax, 1 */
            ii(0x17_c856, 2); shr(dx, 1);                               /* shr dx, 1 */
            ii(0x17_c858, 2); rcr(ax, 1);                               /* rcr ax, 1 */
            ii(0x17_c85a, 2); shr(dx, 1);                               /* shr dx, 1 */
            ii(0x17_c85c, 2); rcr(ax, 1);                               /* rcr ax, 1 */
            ii(0x17_c85e, 3); mov(memw[ss, bp - 2], ax);                /* mov [bp-0x2], ax */
            ii(0x17_c861, 5); test(memw[ss, bp + 0xa], 0xfff);          /* test word [bp+0xa], 0xfff */
            ii(0x17_c866, 2); if(jz(0x17_c86c, 4)) goto l_0x17_c86c;    /* jz 0xc86c */
            ii(0x17_c868, 1); inc(ax);                                  /* inc ax */
            ii(0x17_c869, 3); mov(memw[ss, bp - 2], ax);                /* mov [bp-0x2], ax */
        l_0x17_c86c:
            ii(0x17_c86c, 3); mov(ax, memw[ss, bp + 6]);                /* mov ax, [bp+0x6] */
            ii(0x17_c86f, 3); mov(dx, memw[ss, bp + 8]);                /* mov dx, [bp+0x8] */
            ii(0x17_c872, 2); mov(al, ah);                              /* mov al, ah */
            ii(0x17_c874, 2); mov(ah, dl);                              /* mov ah, dl */
            ii(0x17_c876, 2); mov(dl, dh);                              /* mov dl, dh */
            ii(0x17_c878, 2); sub(dh, dh);                              /* sub dh, dh */
            ii(0x17_c87a, 2); shr(dx, 1);                               /* shr dx, 1 */
            ii(0x17_c87c, 2); rcr(ax, 1);                               /* rcr ax, 1 */
            ii(0x17_c87e, 2); shr(dx, 1);                               /* shr dx, 1 */
            ii(0x17_c880, 2); rcr(ax, 1);                               /* rcr ax, 1 */
            ii(0x17_c882, 2); shr(dx, 1);                               /* shr dx, 1 */
            ii(0x17_c884, 2); rcr(ax, 1);                               /* rcr ax, 1 */
            ii(0x17_c886, 2); shr(dx, 1);                               /* shr dx, 1 */
            ii(0x17_c888, 2); rcr(ax, 1);                               /* rcr ax, 1 */
            ii(0x17_c88a, 3); mov(memw[ss, bp - 4], ax);                /* mov [bp-0x4], ax */
            ii(0x17_c88d, 2); push(0);                                  /* push 0x0 */
            ii(0x17_c88f, 1); push(ax);                                 /* push ax */
            ii(0x17_c890, 4); push(memw[ds, 0x4ff6]);                   /* push word [0x4ff6] */
            ii(0x17_c894, 4); push(memw[ds, 0x4ff4]);                   /* push word [0x4ff4] */
            ii(0x17_c898, 3); call(0x17_90c4, -0x37d7);                 /* call 0x90c4 */
            ii(0x17_c89b, 3); add(sp, 8);                               /* add sp, 0x8 */
            ii(0x17_c89e, 3); mov(memw[ss, bp - 0xa], ax);              /* mov [bp-0xa], ax */
            ii(0x17_c8a1, 5); mov(memw[ss, bp - 8], 0);                 /* mov word [bp-0x8], 0x0 */
            ii(0x17_c8a6, 5); mov(memw[ss, bp - 6], 0);                 /* mov word [bp-0x6], 0x0 */
            ii(0x17_c8ab, 2); jmp(0x17_c8b4, 7); goto l_0x17_c8b4;      /* jmp 0xc8b4 */
        //  ii(0x17_c8ad, 1); nop();                                    /* nop */
        l_0x17_c8ae:
            ii(0x17_c8ae, 3); inc(memw[ss, bp - 6]);                    /* inc word [bp-0x6] */
            ii(0x17_c8b1, 3); inc(memw[ss, bp - 4]);                    /* inc word [bp-0x4] */
        l_0x17_c8b4:
            ii(0x17_c8b4, 3); mov(ax, memw[ss, bp - 6]);                /* mov ax, [bp-0x6] */
            ii(0x17_c8b7, 3); cmp(memw[ss, bp - 2], ax);                /* cmp [bp-0x2], ax */
            ii(0x17_c8ba, 2); if(jle(0x17_c8d8, 0x1c)) goto l_0x17_c8d8; /* jle 0xc8d8 */
            ii(0x17_c8bc, 3); mov(al, memb[ss, bp + 0xe]);              /* mov al, [bp+0xe] */
            ii(0x17_c8bf, 2); sub(ah, ah);                              /* sub ah, ah */
            ii(0x17_c8c1, 1); push(ax);                                 /* push ax */
            ii(0x17_c8c2, 2); push(0);                                  /* push 0x0 */
            ii(0x17_c8c4, 3); push(memw[ss, bp - 4]);                   /* push word [bp-0x4] */
            ii(0x17_c8c7, 4); push(memw[ds, 0x1fa6]);                   /* push word [0x1fa6] */
            ii(0x17_c8cb, 4); push(memw[ds, 0x1fa4]);                   /* push word [0x1fa4] */
            ii(0x17_c8cf, 3); call(0x17_91e3, -0x36ef);                 /* call 0x91e3 */
            ii(0x17_c8d2, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x17_c8d5, 2); jmp(0x17_c8ae, -0x29); goto l_0x17_c8ae;  /* jmp 0xc8ae */
        //  ii(0x17_c8d7, 1); nop();                                    /* nop */
        l_0x17_c8d8:
            ii(0x17_c8d8, 3); mov(ax, memw[ss, bp - 0xa]);              /* mov ax, [bp-0xa] */
            ii(0x17_c8db, 3); mov(dx, memw[ss, bp - 8]);                /* mov dx, [bp-0x8] */
            ii(0x17_c8de, 1); pop(ds);                                  /* pop ds */
            ii(0x17_c8df, 1); leave();                                  /* leave */
            ii(0x17_c8e0, 1); retf();                                   /* retf */
        }
    }
}
