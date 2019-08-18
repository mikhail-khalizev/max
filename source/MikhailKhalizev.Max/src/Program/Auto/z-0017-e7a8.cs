using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_e7a8-e38168d2")]
        public void Method_0017_e7a8()
        {
            ii(0x17_e7a8, 4); enterw(0x18, 0);                          /* enter 0x18, 0x0 */
            ii(0x17_e7ac, 1); pushw(ds);                                /* push ds */
            ii(0x17_e7ad, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x17_e7b0, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x17_e7b2, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x17_e7b5, 1); dec(ax);                                  /* dec ax */
            ii(0x17_e7b6, 3); shr(ax, 0x4);                             /* shr ax, 0x4 */
            ii(0x17_e7b9, 1); inc(ax);                                  /* inc ax */
            ii(0x17_e7ba, 3); mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0x17_e7bd, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x17_e7bf, 3); mov(memw_a16[ss, bp - 0x16], ax);         /* mov [bp-0x16], ax */
            ii(0x17_e7c2, 3); mov(memw_a16[ss, bp - 0x18], ax);         /* mov [bp-0x18], ax */
            ii(0x17_e7c5, 1); pushw(ax);                                /* push ax */
            ii(0x17_e7c6, 1); pushw(ax);                                /* push ax */
            ii(0x17_e7c7, 3); lea(ax, bp - 0x14);                       /* lea ax, [bp-0x14] */
            ii(0x17_e7ca, 1); pushw(ss);                                /* push ss */
            ii(0x17_e7cb, 1); pushw(ax);                                /* push ax */
            ii(0x17_e7cc, 3); pushw(0x4800);                            /* push 0x4800 */
            ii(0x17_e7cf, 1); nop();                                    /* nop */
            ii(0x17_e7d0, 1); pushw(cs);                                /* push cs */
            ii(0x17_e7d1, 3); callw(0x17_eb40, 0x36c);                  /* call 0xeb40 */
            ii(0x17_e7d4, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x17_e7d7, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x17_e7d9, 2); if(jzw(0x17_e7e1, 0x6)) goto l_0x17_e7e1; /* jz 0xe7e1 */
            ii(0x17_e7db, 3); mov(ax, memw_a16[ss, bp - 0x2]);          /* mov ax, [bp-0x2] */
            ii(0x17_e7de, 3); mov(memw_a16[ss, bp - 0x16], ax);         /* mov [bp-0x16], ax */
        l_0x17_e7e1:
            ii(0x17_e7e1, 3); mov(ax, memw_a16[ss, bp - 0x18]);         /* mov ax, [bp-0x18] */
            ii(0x17_e7e4, 3); mov(dx, memw_a16[ss, bp - 0x16]);         /* mov dx, [bp-0x16] */
            ii(0x17_e7e7, 1); popw(ds);                                 /* pop ds */
            ii(0x17_e7e8, 1); leavew();                                 /* leave */
            ii(0x17_e7e9, 1); retfw(); return;                          /* retf */
        //  ii(0x17_e7ea, 66); Недостижимый (и не декодированный) код.
        //    ii(0x17_e82c, 4); enterw(0x14, 0);                          /* enter 0x14, 0x0 */
        //    ii(0x17_e830, 1); pushw(ds);                                /* push ds */
        //    ii(0x17_e831, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
        //    ii(0x17_e834, 2); mov(ds, ax);                              /* mov ds, ax */
        //    ii(0x17_e836, 5); mov(memw_a16[ss, bp - 0x6], 0x100);       /* mov word [bp-0x6], 0x100 */
        //    ii(0x17_e83b, 2); pushw(0);                                 /* push 0x0 */
        //    ii(0x17_e83d, 2); pushw(0);                                 /* push 0x0 */
        //    ii(0x17_e83f, 3); lea(ax, bp - 0x14);                       /* lea ax, [bp-0x14] */
        //    ii(0x17_e842, 1); pushw(ss);                                /* push ss */
        //    ii(0x17_e843, 1); pushw(ax);                                /* push ax */
        //    ii(0x17_e844, 2); pushw(-0x1 /* 0xff */);                   /* push 0xffff */
        //    ii(0x17_e846, 1); nop();                                    /* nop */
        //    ii(0x17_e847, 1); pushw(cs);                                /* push cs */
        //    ii(0x17_e848, 3); callw(0x17_eb40, 0x2f5);                  /* call 0xeb40 */
        //    ii(0x17_e84b, 3); add(sp, 0xa);                             /* add sp, 0xa */
        //    ii(0x17_e84e, 3); mov(dx, memw_a16[ss, bp - 0x6]);          /* mov dx, [bp-0x6] */
        //    ii(0x17_e851, 2); sub(ax, ax);                              /* sub ax, ax */
        //    ii(0x17_e853, 3); add(ax, memw_a16[ss, bp - 0x2]);          /* add ax, [bp-0x2] */
        //    ii(0x17_e856, 3); adc(dx, 0);                               /* adc dx, 0x0 */
        //    ii(0x17_e859, 2); mov(cl, 0x4);                             /* mov cl, 0x4 */
        l_0x17_e85b:
            ii(0x17_e85b, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x17_e85d, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x17_e85f, 2); dec(cl);                                  /* dec cl */
            ii(0x17_e861, 2); if(jnzw(0x17_e85b, -0x8)) goto l_0x17_e85b; /* jnz 0xe85b */
            ii(0x17_e863, 1); popw(ds);                                 /* pop ds */
            ii(0x17_e864, 1); leavew();                                 /* leave */
            ii(0x17_e865, 1); retfw(); return;                          /* retf */
        }
    }
}
