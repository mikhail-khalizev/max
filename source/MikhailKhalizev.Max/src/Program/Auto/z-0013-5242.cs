using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("3e6245fb-04c9-4ee4-bbdd-b625a8e99001")]
        public void Method_0013_5242()
        {
            ii(0x13_5242, 4); enterw(0x2a, 0);                          /* enter 0x2a, 0x0 */
            ii(0x13_5246, 1); pushw(ds);                                /* push ds */
            ii(0x13_5247, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x13_524a, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x13_524c, 1); pushw(ds);                                /* push ds */
            ii(0x13_524d, 3); pushw(0x2a2);                             /* push 0x2a2 */
            ii(0x13_5250, 1); nop();                                    /* nop */
            ii(0x13_5251, 1); pushw(cs);                                /* push cs */
            ii(0x13_5252, 3); callw(0x12_edf0, -0x6465);                /* call 0xedf0 */
            ii(0x13_5255, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x13_5258, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x13_525b, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x13_525e, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x13_5260, 2); if(jnzw(0x13_5268, 0x6)) goto l_0x13_5268; /* jnz 0x5268 */
            ii(0x13_5262, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x13_5265, 3); jmpw(0x13_54b0, 0x248); goto l_0x13_54b0; /* jmp 0x54b0 */
        l_0x13_5268:
            ii(0x13_5268, 1); pushw(ds);                                /* push ds */
            ii(0x13_5269, 3); pushw(0x2ab);                             /* push 0x2ab */
            ii(0x13_526c, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x13_526f, 1); pushw(ax);                                /* push ax */
            ii(0x13_5270, 1); nop();                                    /* nop */
            ii(0x13_5271, 1); pushw(cs);                                /* push cs */
            ii(0x13_5272, 3); callw(0x12_ec70, -0x6605);                /* call 0xec70 */
            ii(0x13_5275, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x13_5278, 3); mov(memw_a16[ss, bp - 0x20], ax);         /* mov [bp-0x20], ax */
            ii(0x13_527b, 3); mov(memw_a16[ss, bp - 0x1e], dx);         /* mov [bp-0x1e], dx */
            ii(0x13_527e, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x13_5280, 2); if(jzw(0x13_52c4, 0x42)) goto l_0x13_52c4; /* jz 0x52c4 */
            ii(0x13_5282, 1); pushw(ds);                                /* push ds */
            ii(0x13_5283, 3); pushw(0x2b9);                             /* push 0x2b9 */
            ii(0x13_5286, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x13_5289, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x13_528c, 1); nop();                                    /* nop */
            ii(0x13_528d, 1); pushw(cs);                                /* push cs */
            ii(0x13_528e, 3); callw(0x12_ec70, -0x6621);                /* call 0xec70 */
            ii(0x13_5291, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x13_5294, 3); mov(memw_a16[ds, 0x1efc], ax);            /* mov [0x1efc], ax */
            ii(0x13_5297, 4); mov(memw_a16[ds, 0x1efe], dx);            /* mov [0x1efe], dx */
            ii(0x13_529b, 2); mov(ax, dx);                              /* mov ax, dx */
            ii(0x13_529d, 4); or(ax, memw_a16[ds, 0x1efc]);             /* or ax, [0x1efc] */
            ii(0x13_52a1, 2); if(jzw(0x13_52c4, 0x21)) goto l_0x13_52c4; /* jz 0x52c4 */
            ii(0x13_52a3, 1); pushw(ds);                                /* push ds */
            ii(0x13_52a4, 3); pushw(0x2c5);                             /* push 0x2c5 */
            ii(0x13_52a7, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x13_52aa, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x13_52ad, 1); nop();                                    /* nop */
            ii(0x13_52ae, 1); pushw(cs);                                /* push cs */
            ii(0x13_52af, 3); callw(0x12_ec70, -0x6642);                /* call 0xec70 */
            ii(0x13_52b2, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x13_52b5, 3); mov(memw_a16[ds, 0x4fc8], ax);            /* mov [0x4fc8], ax */
            ii(0x13_52b8, 4); mov(memw_a16[ds, 0x4fca], dx);            /* mov [0x4fca], dx */
            ii(0x13_52bc, 2); mov(ax, dx);                              /* mov ax, dx */
            ii(0x13_52be, 4); or(ax, memw_a16[ds, 0x4fc8]);             /* or ax, [0x4fc8] */
            ii(0x13_52c2, 2); if(jnzw(0x13_52d4, 0x10)) goto l_0x13_52d4; /* jnz 0x52d4 */
        l_0x13_52c4:
            ii(0x13_52c4, 3); pushw(0x8f6);                             /* push 0x8f6 */
            ii(0x13_52c7, 1); pushw(cs);                                /* push cs */
            ii(0x13_52c8, 3); callw(0x13_75b4, 0x22e9);                 /* call 0x75b4 */
            ii(0x13_52cb, 3); add(sp, 0x2);                             /* add sp, 0x2 */
            ii(0x13_52ce, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x13_52d1, 3); jmpw(0x13_54b0, 0x1dc); goto l_0x13_54b0; /* jmp 0x54b0 */
        l_0x13_52d4:
            ii(0x13_52d4, 1); pushw(ds);                                /* push ds */
            ii(0x13_52d5, 3); pushw(0x2ce);                             /* push 0x2ce */
            ii(0x13_52d8, 1); nop();                                    /* nop */
            ii(0x13_52d9, 1); pushw(cs);                                /* push cs */
            ii(0x13_52da, 3); callw(0x12_edf0, -0x64ed);                /* call 0xedf0 */
            ii(0x13_52dd, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x13_52e0, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x13_52e3, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x13_52e6, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x13_52e8, 2); if(jnzw(0x13_52f0, 0x6)) goto l_0x13_52f0; /* jnz 0x52f0 */
            ii(0x13_52ea, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x13_52ed, 3); jmpw(0x13_54b0, 0x1c0); goto l_0x13_54b0; /* jmp 0x54b0 */
        l_0x13_52f0:
            ii(0x13_52f0, 1); pushw(ds);                                /* push ds */
            ii(0x13_52f1, 3); pushw(0x2de);                             /* push 0x2de */
            ii(0x13_52f4, 1); pushw(ds);                                /* push ds */
            ii(0x13_52f5, 3); pushw(0x2d9);                             /* push 0x2d9 */
            ii(0x13_52f8, 3); callw(0x12_f569, -0x5d92);                /* call 0xf569 */
            ii(0x13_52fb, 3); mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0x13_52fe, 3); mov(memw_a16[ss, bp - 0x6], dx);          /* mov [bp-0x6], dx */
            ii(0x13_5301, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x13_5303, 2); if(jzw(0x13_531a, 0x15)) goto l_0x13_531a; /* jz 0x531a */
            ii(0x13_5305, 3); callw_a16_far_ind(ss, bp - 0x8);          /* call far word [bp-0x8] */
            ii(0x13_5308, 1); pushw(dx);                                /* push dx */
            ii(0x13_5309, 1); pushw(ax);                                /* push ax */
            ii(0x13_530a, 1); pushw(ds);                                /* push ds */
            ii(0x13_530b, 3); pushw(0x2e9);                             /* push 0x2e9 */
            ii(0x13_530e, 3); callw(0x12_f6b0, -0x5c61);                /* call 0xf6b0 */
            ii(0x13_5311, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x13_5313, 2); if(jgew(0x13_531a, 0x5)) goto l_0x13_531a; /* jge 0x531a */
            ii(0x13_5315, 5); mov(memb_a16[ds, 0x5], 0x1);              /* mov byte [0x5], 0x1 */
        l_0x13_531a:
            ii(0x13_531a, 1); pushw(ds);                                /* push ds */
            ii(0x13_531b, 3); pushw(0x2f1);                             /* push 0x2f1 */
            ii(0x13_531e, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x13_5321, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x13_5324, 1); nop();                                    /* nop */
            ii(0x13_5325, 1); pushw(cs);                                /* push cs */
            ii(0x13_5326, 3); callw(0x12_ec70, -0x66b9);                /* call 0xec70 */
            ii(0x13_5329, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x13_532c, 3); mov(memw_a16[ds, 0x1fdc], ax);            /* mov [0x1fdc], ax */
            ii(0x13_532f, 4); mov(memw_a16[ds, 0x1fde], dx);            /* mov [0x1fde], dx */
            ii(0x13_5333, 2); mov(ax, dx);                              /* mov ax, dx */
            ii(0x13_5335, 4); or(ax, memw_a16[ds, 0x1fdc]);             /* or ax, [0x1fdc] */
            ii(0x13_5339, 2); if(jzw(0x13_534a, 0xf)) goto l_0x13_534a; /* jz 0x534a */
            ii(0x13_533b, 4); callw_a16_far_ind(ds, 0x1fdc);            /* call far word [0x1fdc] */
            ii(0x13_533f, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x13_5341, 2); if(jzw(0x13_534a, 0x7)) goto l_0x13_534a; /* jz 0x534a */
            ii(0x13_5343, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x13_5346, 1); popw(ds);                                 /* pop ds */
            ii(0x13_5347, 1); leavew();                                 /* leave */
            ii(0x13_5348, 1); retfw(); return;                          /* retf */
        //  ii(0x13_5349, 1); Недостижимый код.
        l_0x13_534a:
            ii(0x13_534a, 1); pushw(ds);                                /* push ds */
            ii(0x13_534b, 3); pushw(0x2f6);                             /* push 0x2f6 */
            ii(0x13_534e, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x13_5351, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x13_5354, 1); nop();                                    /* nop */
            ii(0x13_5355, 1); pushw(cs);                                /* push cs */
            ii(0x13_5356, 3); callw(0x12_ec70, -0x66e9);                /* call 0xec70 */
            ii(0x13_5359, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x13_535c, 3); mov(memw_a16[ds, 0x4fac], ax);            /* mov [0x4fac], ax */
            ii(0x13_535f, 4); mov(memw_a16[ds, 0x4fae], dx);            /* mov [0x4fae], dx */
            ii(0x13_5363, 2); mov(ax, dx);                              /* mov ax, dx */
            ii(0x13_5365, 4); or(ax, memw_a16[ds, 0x4fac]);             /* or ax, [0x4fac] */
            ii(0x13_5369, 2); if(jnzw(0x13_5372, 0x7)) goto l_0x13_5372; /* jnz 0x5372 */
            ii(0x13_536b, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x13_536e, 1); popw(ds);                                 /* pop ds */
            ii(0x13_536f, 1); leavew();                                 /* leave */
            ii(0x13_5370, 1); retfw(); return;                          /* retf */
        //  ii(0x13_5371, 1); Недостижимый код.
        l_0x13_5372:
            ii(0x13_5372, 1); pushw(ds);                                /* push ds */
            ii(0x13_5373, 3); pushw(0x306);                             /* push 0x306 */
            ii(0x13_5376, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x13_5379, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x13_537c, 1); nop();                                    /* nop */
            ii(0x13_537d, 1); pushw(cs);                                /* push cs */
            ii(0x13_537e, 3); callw(0x12_ec70, -0x6711);                /* call 0xec70 */
            ii(0x13_5381, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x13_5384, 3); mov(memw_a16[ds, 0x4fb0], ax);            /* mov [0x4fb0], ax */
            ii(0x13_5387, 4); mov(memw_a16[ds, 0x4fb2], dx);            /* mov [0x4fb2], dx */
            ii(0x13_538b, 2); mov(ax, dx);                              /* mov ax, dx */
            ii(0x13_538d, 4); or(ax, memw_a16[ds, 0x4fb0]);             /* or ax, [0x4fb0] */
            ii(0x13_5391, 2); if(jnzw(0x13_539a, 0x7)) goto l_0x13_539a; /* jnz 0x539a */
            ii(0x13_5393, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x13_5396, 1); popw(ds);                                 /* pop ds */
            ii(0x13_5397, 1); leavew();                                 /* leave */
            ii(0x13_5398, 1); retfw(); return;                          /* retf */
        //  ii(0x13_5399, 1); Недостижимый код.
        l_0x13_539a:
            ii(0x13_539a, 1); pushw(ds);                                /* push ds */
            ii(0x13_539b, 3); pushw(0x314);                             /* push 0x314 */
            ii(0x13_539e, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x13_53a1, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x13_53a4, 1); nop();                                    /* nop */
            ii(0x13_53a5, 1); pushw(cs);                                /* push cs */
            ii(0x13_53a6, 3); callw(0x12_ec70, -0x6739);                /* call 0xec70 */
            ii(0x13_53a9, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x13_53ac, 3); mov(memw_a16[ds, 0x1f54], ax);            /* mov [0x1f54], ax */
            ii(0x13_53af, 4); mov(memw_a16[ds, 0x1f56], dx);            /* mov [0x1f56], dx */
            ii(0x13_53b3, 2); mov(ax, dx);                              /* mov ax, dx */
            ii(0x13_53b5, 4); or(ax, memw_a16[ds, 0x1f54]);             /* or ax, [0x1f54] */
            ii(0x13_53b9, 2); if(jnzw(0x13_53c2, 0x7)) goto l_0x13_53c2; /* jnz 0x53c2 */
            ii(0x13_53bb, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x13_53be, 1); popw(ds);                                 /* pop ds */
            ii(0x13_53bf, 1); leavew();                                 /* leave */
            ii(0x13_53c0, 1); retfw(); return;                          /* retf */
        //  ii(0x13_53c1, 1); Недостижимый код.
        l_0x13_53c2:
            ii(0x13_53c2, 1); pushw(ds);                                /* push ds */
            ii(0x13_53c3, 3); pushw(0x31c);                             /* push 0x31c */
            ii(0x13_53c6, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x13_53c9, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x13_53cc, 1); nop();                                    /* nop */
            ii(0x13_53cd, 1); pushw(cs);                                /* push cs */
            ii(0x13_53ce, 3); callw(0x12_ec70, -0x6761);                /* call 0xec70 */
            ii(0x13_53d1, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x13_53d4, 3); mov(memw_a16[ss, bp - 0x2a], ax);         /* mov [bp-0x2a], ax */
            ii(0x13_53d7, 3); mov(memw_a16[ss, bp - 0x28], dx);         /* mov [bp-0x28], dx */
            ii(0x13_53da, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x13_53dc, 2); if(jzw(0x13_544a, 0x6c)) goto l_0x13_544a; /* jz 0x544a */
            ii(0x13_53de, 3); pushw(0x3e58);                            /* push 0x3e58 */
            ii(0x13_53e1, 3); pushw(0x468a);                            /* push 0x468a */
            ii(0x13_53e4, 1); nop();                                    /* nop */
            ii(0x13_53e5, 1); pushw(cs);                                /* push cs */
            ii(0x13_53e6, 3); callw(0x12_e630, -0x6db9);                /* call 0xe630 */
            ii(0x13_53e9, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x13_53ec, 3); mov(memw_a16[ss, bp - 0x26], ax);         /* mov [bp-0x26], ax */
            ii(0x13_53ef, 3); mov(memw_a16[ss, bp - 0x24], dx);         /* mov [bp-0x24], dx */
            ii(0x13_53f2, 2); mov(ax, dx);                              /* mov ax, dx */
            ii(0x13_53f4, 3); or(ax, memw_a16[ss, bp - 0x26]);          /* or ax, [bp-0x26] */
            ii(0x13_53f7, 2); if(jzw(0x13_544a, 0x51)) goto l_0x13_544a; /* jz 0x544a */
            ii(0x13_53f9, 2); mov(ax, dx);                              /* mov ax, dx */
            ii(0x13_53fb, 3); mov(memw_a16[ss, bp - 0x22], ax);         /* mov [bp-0x22], ax */
            ii(0x13_53fe, 3); mov(ax, memw_a16[ss, bp - 0x20]);         /* mov ax, [bp-0x20] */
            ii(0x13_5401, 3); mov(dx, memw_a16[ss, bp - 0x1e]);         /* mov dx, [bp-0x1e] */
            ii(0x13_5404, 3); les(bx, ss, bp - 0x26);                   /* les bx, [bp-0x26] */
            ii(0x13_5407, 3); mov(memw_a16[es, bx], ax);                /* mov [es:bx], ax */
            ii(0x13_540a, 4); mov(memw_a16[es, bx + 0x2], dx);          /* mov [es:bx+0x2], dx */
            ii(0x13_540e, 5); mov(memw_a16[ss, bp - 0x26], 0x468e);     /* mov word [bp-0x26], 0x468e */
            ii(0x13_5413, 5); mov(memw_a16[ss, bp - 0x24], 0x3e58);     /* mov word [bp-0x24], 0x3e58 */
            ii(0x13_5418, 3); mov(ax, memw_a16[ss, bp - 0x22]);         /* mov ax, [bp-0x22] */
            ii(0x13_541b, 3); mov(memw_a16[ss, bp - 0x24], ax);         /* mov [bp-0x24], ax */
            ii(0x13_541e, 3); mov(ax, memw_a16[ss, bp - 0x2a]);         /* mov ax, [bp-0x2a] */
            ii(0x13_5421, 3); mov(dx, memw_a16[ss, bp - 0x28]);         /* mov dx, [bp-0x28] */
            ii(0x13_5424, 3); les(bx, ss, bp - 0x26);                   /* les bx, [bp-0x26] */
            ii(0x13_5427, 3); mov(memw_a16[es, bx], ax);                /* mov [es:bx], ax */
            ii(0x13_542a, 4); mov(memw_a16[es, bx + 0x2], dx);          /* mov [es:bx+0x2], dx */
            ii(0x13_542e, 3); pushw(memw_a16[ss, bp - 0x24]);           /* push word [bp-0x24] */
            ii(0x13_5431, 3); pushw(memw_a16[ss, bp - 0x26]);           /* push word [bp-0x26] */
            ii(0x13_5434, 1); nop();                                    /* nop */
            ii(0x13_5435, 1); pushw(cs);                                /* push cs */
            ii(0x13_5436, 3); callw(0x12_e758, -0x6ce1);                /* call 0xe758 */
            ii(0x13_5439, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x13_543c, 6); mov(memw_a16[ds, 0x1fe0], 0x4692);        /* mov word [0x1fe0], 0x4692 */
            ii(0x13_5442, 6); mov(memw_a16[ds, 0x1fe2], 0x3e58);        /* mov word [0x1fe2], 0x3e58 */
            ii(0x13_5448, 2); jmpw(0x13_5457, 0xd); goto l_0x13_5457;   /* jmp 0x5457 */
        l_0x13_544a:
            ii(0x13_544a, 3); mov(ax, memw_a16[ss, bp - 0x20]);         /* mov ax, [bp-0x20] */
            ii(0x13_544d, 3); mov(dx, memw_a16[ss, bp - 0x1e]);         /* mov dx, [bp-0x1e] */
            ii(0x13_5450, 3); mov(memw_a16[ds, 0x1fe0], ax);            /* mov [0x1fe0], ax */
            ii(0x13_5453, 4); mov(memw_a16[ds, 0x1fe2], dx);            /* mov [0x1fe2], dx */
        l_0x13_5457:
            ii(0x13_5457, 1); pushw(cs);                                /* push cs */
            ii(0x13_5458, 3); callw(0x13_7408, 0x1fad);                 /* call 0x7408 */
            ii(0x13_545b, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x13_545d, 3); mov(memw_a16[ss, bp - 0x1a], ax);         /* mov [bp-0x1a], ax */
            ii(0x13_5460, 3); mov(memw_a16[ss, bp - 0x1c], ax);         /* mov [bp-0x1c], ax */
            ii(0x13_5463, 5); mov(memw_a16[ss, bp - 0xa], 0xff00);      /* mov word [bp-0xa], 0xff00 */
            ii(0x13_5468, 5); mov(memw_a16[ss, bp - 0xe], 0xe00);       /* mov word [bp-0xe], 0xe00 */
            ii(0x13_546d, 3); lea(ax, bp - 0x1c);                       /* lea ax, [bp-0x1c] */
            ii(0x13_5470, 1); pushw(ss);                                /* push ss */
            ii(0x13_5471, 1); pushw(ax);                                /* push ax */
            ii(0x13_5472, 2); pushw(-0x1 /* 0xff */);                   /* push 0xffff */
            ii(0x13_5474, 1); nop();                                    /* nop */
            ii(0x13_5475, 1); pushw(cs);                                /* push cs */
            ii(0x13_5476, 3); callw(0x12_eaed, -0x698c);                /* call 0xeaed */
            ii(0x13_5479, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x13_547c, 3); mov(bx, memw_a16[ss, bp - 0xa]);          /* mov bx, [bp-0xa] */
            ii(0x13_547f, 3); mov(cx, memw_a16[ss, bp - 0xe]);          /* mov cx, [bp-0xe] */
            ii(0x13_5482, 2); mov(es, cx);                              /* mov es, cx */
            ii(0x13_5484, 4); mov(memw_a16[ds, 0x2018], bx);            /* mov [0x2018], bx */
            ii(0x13_5488, 4); mov(memw_a16[ds, 0x201a], es);            /* mov [0x201a], es */
            ii(0x13_548c, 4); mov(ax, memw_a16[es, bx + 0x4]);          /* mov ax, [es:bx+0x4] */
            ii(0x13_5490, 4); mov(dx, memw_a16[es, bx + 0x6]);          /* mov dx, [es:bx+0x6] */
            ii(0x13_5494, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_5496, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_5498, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_549a, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_549c, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_549e, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_54a0, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_54a2, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_54a4, 3); mov(memw_a16[ds, 0x8c], ax);              /* mov [0x8c], ax */
            ii(0x13_54a7, 4); mov(memw_a16[ds, 0x8e], dx);              /* mov [0x8e], dx */
            ii(0x13_54ab, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x13_54ad, 1); popw(ds);                                 /* pop ds */
            ii(0x13_54ae, 1); leavew();                                 /* leave */
            ii(0x13_54af, 1); retfw(); return;                          /* retf */
        l_0x13_54b0:
            ii(0x13_54b0, 1); popw(ds);                                 /* pop ds */
            ii(0x13_54b1, 1); leavew();                                 /* leave */
            ii(0x13_54b2, 1); retfw(); return;                          /* retf */
        }
    }
}
