using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_5ec8-f56034ea")]
        public void Method_0019_5ec8()
        {
            ii(0x19_5ec8, 4); enterw(0xa, 0);                           /* enter 0xa, 0x0 */
            ii(0x19_5ecc, 1); pushw(di);                                /* push di */
            ii(0x19_5ecd, 1); pushw(si);                                /* push si */
            ii(0x19_5ece, 1); pushw(ds);                                /* push ds */
            ii(0x19_5ecf, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x19_5ed2, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x19_5ed4, 5); cmp(memw_a16[ds, 0x1208], 0);             /* cmp word [0x1208], 0x0 */
            ii(0x19_5ed9, 2); if(jnzw(0x19_5ede, 0x3)) goto l_0x19_5ede; /* jnz 0x5ede */
            ii(0x19_5edb, 3); jmpw(0x19_5eee, 0x10); goto l_0x19_5eee;  /* jmp 0x5eee */
        l_0x19_5ede:
            ii(0x19_5ede, 1); pushw(ds);                                /* push ds */
            ii(0x19_5edf, 3); pushw(0x1175);                            /* push 0x1175 */
            ii(0x19_5ee2, 3); pushw(0x7d0);                             /* push 0x7d0 */
            ii(0x19_5ee5, 3); callw(0x19_104e, -0x4e9a);                /* call 0x104e */
            ii(0x19_5ee8, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x19_5eeb, 3); jmpw(0x19_5f76, 0x88); goto l_0x19_5f76;  /* jmp 0x5f76 */
        l_0x19_5eee:
            ii(0x19_5eee, 4); inc(memw_a16[ds, 0x1208]);                /* inc word [0x1208] */
            ii(0x19_5ef2, 1); pushw(ds);                                /* push ds */
            ii(0x19_5ef3, 3); pushw(0x118b);                            /* push 0x118b */
            ii(0x19_5ef6, 3); callw(0x19_1066, -0x4e93);                /* call 0x1066 */
            ii(0x19_5ef9, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x19_5efc, 2); pushw(0);                                 /* push 0x0 */
            ii(0x19_5efe, 1); nop();                                    /* nop */
            ii(0x19_5eff, 1); pushw(cs);                                /* push cs */
            ii(0x19_5f00, 3); callw(0x18_f57c, -0x6987);                /* call 0xf57c */
            ii(0x19_5f03, 3); add(sp, 0x2);                             /* add sp, 0x2 */
            ii(0x19_5f06, 5); mov(memw_a16[ss, bp - 0xa], 0);           /* mov word [bp-0xa], 0x0 */
            ii(0x19_5f0b, 3); jmpw(0x19_5f11, 0x3); goto l_0x19_5f11;   /* jmp 0x5f11 */
        l_0x19_5f0e:
            ii(0x19_5f0e, 3); inc(memw_a16[ss, bp - 0xa]);              /* inc word [bp-0xa] */
        l_0x19_5f11:
            ii(0x19_5f11, 3); mov(bx, memw_a16[ss, bp - 0xa]);          /* mov bx, [bp-0xa] */
            ii(0x19_5f14, 3); shl(bx, 0x2);                             /* shl bx, 0x2 */
            ii(0x19_5f17, 4); mov(ax, memw_a16[ds, bx + 0x11f2]);       /* mov ax, [bx+0x11f2] */
            ii(0x19_5f1b, 4); or(ax, memw_a16[ds, bx + 0x11f0]);        /* or ax, [bx+0x11f0] */
            ii(0x19_5f1f, 2); if(jnzw(0x19_5f24, 0x3)) goto l_0x19_5f24; /* jnz 0x5f24 */
            ii(0x19_5f21, 3); jmpw(0x19_5f69, 0x45); goto l_0x19_5f69;  /* jmp 0x5f69 */
        l_0x19_5f24:
            ii(0x19_5f24, 3); mov(bx, memw_a16[ss, bp - 0xa]);          /* mov bx, [bp-0xa] */
            ii(0x19_5f27, 3); shl(bx, 0x2);                             /* shl bx, 0x2 */
            ii(0x19_5f2a, 4); pushw(memw_a16[ds, bx + 0x11f2]);         /* push word [bx+0x11f2] */
            ii(0x19_5f2e, 4); pushw(memw_a16[ds, bx + 0x11f0]);         /* push word [bx+0x11f0] */
            ii(0x19_5f32, 1); pushw(ds);                                /* push ds */
            ii(0x19_5f33, 3); pushw(0x11b0);                            /* push 0x11b0 */
            ii(0x19_5f36, 3); callw(0x18_fcad, -0x628c);                /* call 0xfcad */
            ii(0x19_5f39, 3); mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0x19_5f3c, 3); mov(memw_a16[ss, bp - 0x6], dx);          /* mov [bp-0x6], dx */
            ii(0x19_5f3f, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x19_5f41, 2); if(jnzw(0x19_5f46, 0x3)) goto l_0x19_5f46; /* jnz 0x5f46 */
            ii(0x19_5f43, 3); jmpw(0x19_5f66, 0x20); goto l_0x19_5f66;  /* jmp 0x5f66 */
        l_0x19_5f46:
            ii(0x19_5f46, 3); mov(bx, memw_a16[ss, bp - 0xa]);          /* mov bx, [bp-0xa] */
            ii(0x19_5f49, 3); shl(bx, 0x2);                             /* shl bx, 0x2 */
            ii(0x19_5f4c, 4); pushw(memw_a16[ds, bx + 0x11f2]);         /* push word [bx+0x11f2] */
            ii(0x19_5f50, 4); pushw(memw_a16[ds, bx + 0x11f0]);         /* push word [bx+0x11f0] */
            ii(0x19_5f54, 1); pushw(ds);                                /* push ds */
            ii(0x19_5f55, 3); pushw(0x11b7);                            /* push 0x11b7 */
            ii(0x19_5f58, 3); callw(0x19_1066, -0x4ef5);                /* call 0x1066 */
            ii(0x19_5f5b, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x19_5f5e, 2); pushw(0);                                 /* push 0x0 */
            ii(0x19_5f60, 3); callw_a16_far_ind(ss, bp - 0x8);          /* call far word [bp-0x8] */
            ii(0x19_5f63, 3); add(sp, 0x2);                             /* add sp, 0x2 */
        l_0x19_5f66:
            ii(0x19_5f66, 3); jmpw(0x19_5f0e, -0x5b); goto l_0x19_5f0e; /* jmp 0x5f0e */
        l_0x19_5f69:
            ii(0x19_5f69, 1); pushw(ds);                                /* push ds */
            ii(0x19_5f6a, 3); pushw(0x11ce);                            /* push 0x11ce */
            ii(0x19_5f6d, 3); callw(0x19_1066, -0x4f0a);                /* call 0x1066 */
            ii(0x19_5f70, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x19_5f73, 3); callw(0x19_55db, -0x99b);                 /* call 0x55db */
        l_0x19_5f76:
            ii(0x19_5f76, 1); popw(ds);                                 /* pop ds */
            ii(0x19_5f77, 1); popw(si);                                 /* pop si */
            ii(0x19_5f78, 1); popw(di);                                 /* pop di */
            ii(0x19_5f79, 1); leavew();                                 /* leave */
            ii(0x19_5f7a, 1); retfw(); return;                          /* retf */
        //  ii(0x19_5f7b, 244); Недостижимый (и не декодированный) код.
        //    ii(0x19_606f, 4); enterw(0x16, 0);                          /* enter 0x16, 0x0 */
        //    ii(0x19_6073, 1); pushw(di);                                /* push di */
        //    ii(0x19_6074, 1); pushw(si);                                /* push si */
        //    ii(0x19_6075, 5); callw_far_abs(0x80, 0x51a8);              /* call word 0x80:0x51a8 */
        //    ii(0x19_607a, 3); cmp(ax, 0);                               /* cmp ax, 0x0 */
        //    ii(0x19_607d, 2); if(jnzw(0x19_6082, 0x3)) goto l_0x19_6082; /* jnz 0x6082 */
        //    ii(0x19_607f, 3); jmpw(0x19_60a0, 0x1e); goto l_0x19_60a0;  /* jmp 0x60a0 */
        l_0x19_6082:
            ii(0x19_6082, 4); cmp(memw_a16[ss, bp + 0x6], 0x8);         /* cmp word [bp+0x6], 0x8 */
            ii(0x19_6086, 2); if(jnzw(0x19_608b, 0x3)) goto l_0x19_608b; /* jnz 0x608b */
            ii(0x19_6088, 3); jmpw(0x19_609d, 0x12); goto l_0x19_609d;  /* jmp 0x609d */
        l_0x19_608b:
            ii(0x19_608b, 4); cmp(memw_a16[ss, bp + 0x6], 0x9);         /* cmp word [bp+0x6], 0x9 */
            ii(0x19_608f, 2); if(jnzw(0x19_6094, 0x3)) goto l_0x19_6094; /* jnz 0x6094 */
            ii(0x19_6091, 3); jmpw(0x19_609d, 0x9); goto l_0x19_609d;   /* jmp 0x609d */
        l_0x19_6094:
            ii(0x19_6094, 4); cmp(memw_a16[ss, bp + 0x6], 0x1c);        /* cmp word [bp+0x6], 0x1c */
            ii(0x19_6098, 2); if(jzw(0x19_609d, 0x3)) goto l_0x19_609d; /* jz 0x609d */
            ii(0x19_609a, 3); jmpw(0x19_60a0, 0x3); goto l_0x19_60a0;   /* jmp 0x60a0 */
        l_0x19_609d:
            ii(0x19_609d, 3); jmpw(0x19_60d0, 0x30); goto l_0x19_60d0;  /* jmp 0x60d0 */
        l_0x19_60a0:
            ii(0x19_60a0, 4); mov(memb_a16[ss, bp - 0x7], 0x17);        /* mov byte [bp-0x7], 0x17 */
            ii(0x19_60a4, 3); mov(al, memb_a16[ss, bp + 0x8]);          /* mov al, [bp+0x8] */
            ii(0x19_60a7, 3); mov(memb_a16[ss, bp - 0x8], al);          /* mov [bp-0x8], al */
            ii(0x19_60aa, 4); mov(memb_a16[ss, bp - 0xd], 0xff);        /* mov byte [bp-0xd], 0xff */
            ii(0x19_60ae, 3); mov(al, memb_a16[ss, bp + 0x6]);          /* mov al, [bp+0x6] */
            ii(0x19_60b1, 3); mov(memb_a16[ss, bp - 0xe], al);          /* mov [bp-0xe], al */
            ii(0x19_60b4, 3); mov(ax, 0);                               /* mov ax, 0x0 */
            ii(0x19_60b7, 3); mov(memw_a16[ss, bp - 0x10], ax);         /* mov [bp-0x10], ax */
            ii(0x19_60ba, 3); mov(memw_a16[ss, bp - 0x16], ax);         /* mov [bp-0x16], ax */
            ii(0x19_60bd, 3); lea(ax, bp - 0x16);                       /* lea ax, [bp-0x16] */
            ii(0x19_60c0, 1); pushw(ss);                                /* push ss */
            ii(0x19_60c1, 1); pushw(ax);                                /* push ax */
            ii(0x19_60c2, 3); lea(ax, bp - 0xe);                        /* lea ax, [bp-0xe] */
            ii(0x19_60c5, 1); pushw(ss);                                /* push ss */
            ii(0x19_60c6, 1); pushw(ax);                                /* push ax */
            ii(0x19_60c7, 1); pushw(ss);                                /* push ss */
            ii(0x19_60c8, 1); pushw(ax);                                /* push ax */
            ii(0x19_60c9, 4); callw_a16_far_ind(ds, 0x1286);            /* call far word [0x1286] */
            ii(0x19_60cd, 3); add(sp, 0xc);                             /* add sp, 0xc */
        l_0x19_60d0:
            ii(0x19_60d0, 1); popw(si);                                 /* pop si */
            ii(0x19_60d1, 1); popw(di);                                 /* pop di */
            ii(0x19_60d2, 1); leavew();                                 /* leave */
            ii(0x19_60d3, 1); retfw(); return;                          /* retf */
        }
    }
}
