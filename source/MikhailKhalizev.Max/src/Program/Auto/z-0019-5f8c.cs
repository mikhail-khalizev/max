using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("3d9b1a4d-6e73-4eb2-82a4-fc1ce1066508")]
        public void Method_0019_5f8c()
        {
            ii(0x19_5f8c, 4); enterw(0x10, 0);                          /* enter 0x10, 0x0 */
            ii(0x19_5f90, 1); pushw(di);                                /* push di */
            ii(0x19_5f91, 1); pushw(si);                                /* push si */
            ii(0x19_5f92, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x19_5f94, 3); mov(memw_a16[ss, bp - 0x2], ax);          /* mov [bp-0x2], ax */
            ii(0x19_5f97, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x19_5f9a, 4); mov(es, memw_a16[ds, 0x3f94]);            /* mov es, [0x3f94] */
            ii(0x19_5f9e, 4); mov(ax, memw_a16[es, 0x3b78]);            /* mov ax, [es:0x3b78] */
            ii(0x19_5fa2, 5); mov(memw_a16[ss, bp - 0x8], 0);           /* mov word [bp-0x8], 0x0 */
            ii(0x19_5fa7, 3); mov(memw_a16[ss, bp - 0x6], ax);          /* mov [bp-0x6], ax */
            ii(0x19_5faa, 3); les(bx, ss, bp - 0x8);                    /* les bx, [bp-0x8] */
            ii(0x19_5fad, 4); mov(ax, memw_a16[es, bx + 0xe]);          /* mov ax, [es:bx+0xe] */
            ii(0x19_5fb1, 3); mov(memw_a16[ds, 0x4898], ax);            /* mov [0x4898], ax */
            ii(0x19_5fb4, 5); mov(memw_a16[ss, bp - 0xa], 0);           /* mov word [bp-0xa], 0x0 */
            ii(0x19_5fb9, 3); jmpw(0x19_5fbf, 0x3); goto l_0x19_5fbf;   /* jmp 0x5fbf */
        l_0x19_5fbc:
            ii(0x19_5fbc, 3); inc(memw_a16[ss, bp - 0xa]);              /* inc word [bp-0xa] */
        l_0x19_5fbf:
            ii(0x19_5fbf, 4); cmp(memw_a16[ss, bp - 0xa], 0x10);        /* cmp word [bp-0xa], 0x10 */
            ii(0x19_5fc3, 2); if(jlw(0x19_5fc8, 0x3)) goto l_0x19_5fc8; /* jl 0x5fc8 */
            ii(0x19_5fc5, 3); jmpw(0x19_5fd7, 0xf); goto l_0x19_5fd7;   /* jmp 0x5fd7 */
        l_0x19_5fc8:
            ii(0x19_5fc8, 3); callw(0x19_79a9, 0x19de);                 /* call 0x79a9 */
            ii(0x19_5fcb, 3); mov(bx, memw_a16[ss, bp - 0xa]);          /* mov bx, [bp-0xa] */
            ii(0x19_5fce, 2); shl(bx, 0x1);                             /* shl bx, 1 */
            ii(0x19_5fd0, 4); mov(memw_a16[ds, bx + 0x4870], ax);       /* mov [bx+0x4870], ax */
            ii(0x19_5fd4, 3); jmpw(0x19_5fbc, -0x1b); goto l_0x19_5fbc; /* jmp 0x5fbc */
        l_0x19_5fd7:
            ii(0x19_5fd7, 6); mov(memw_a16[ds, 0x1274], 0);             /* mov word [0x1274], 0x0 */
            ii(0x19_5fdd, 3); callw(0x19_79a9, 0x19c9);                 /* call 0x79a9 */
            ii(0x19_5fe0, 3); mov(memw_a16[ds, 0x4896], ax);            /* mov [0x4896], ax */
            ii(0x19_5fe3, 6); mov(memw_a16[ds, 0x489a], 0);             /* mov word [0x489a], 0x0 */
            ii(0x19_5fe9, 3); mov(ax, memw_a16[ds, 0x12a8]);            /* mov ax, [0x12a8] */
            ii(0x19_5fec, 3); mov(memw_a16[ss, bp - 0x10], ax);         /* mov [bp-0x10], ax */
            ii(0x19_5fef, 5); mov(memw_a16[ss, bp - 0xe], 0);           /* mov word [bp-0xe], 0x0 */
            ii(0x19_5ff4, 3); mov(ax, memw_a16[ds, 0x12aa]);            /* mov ax, [0x12aa] */
            ii(0x19_5ff7, 3); mov(memw_a16[ss, bp - 0xc], ax);          /* mov [bp-0xc], ax */
            ii(0x19_5ffa, 3); lea(ax, bp - 0x10);                       /* lea ax, [bp-0x10] */
            ii(0x19_5ffd, 1); pushw(ss);                                /* push ss */
            ii(0x19_5ffe, 1); pushw(ax);                                /* push ax */
            ii(0x19_5fff, 2); pushw(0x21);                              /* push 0x21 */
            ii(0x19_6001, 5); callw_far_abs(0x80, 0xb38);               /* call word 0x80:0xb38 */
            ii(0x19_6006, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x19_6009, 1); pushw(ds);                                /* push ds */
            ii(0x19_600a, 3); pushw(0x1218);                            /* push 0x1218 */
            ii(0x19_600d, 1); pushw(ds);                                /* push ds */
            ii(0x19_600e, 3); pushw(0x120a);                            /* push 0x120a */
            ii(0x19_6011, 3); callw(0x18_fcad, -0x6367);                /* call 0xfcad */
            ii(0x19_6014, 3); mov(memw_a16[ds, 0x1286], ax);            /* mov [0x1286], ax */
            ii(0x19_6017, 4); mov(memw_a16[ds, 0x1288], dx);            /* mov [0x1288], dx */
            ii(0x19_601b, 1); pushw(ds);                                /* push ds */
            ii(0x19_601c, 3); pushw(0x1234);                            /* push 0x1234 */
            ii(0x19_601f, 1); pushw(ds);                                /* push ds */
            ii(0x19_6020, 3); pushw(0x1221);                            /* push 0x1221 */
            ii(0x19_6023, 3); callw(0x18_fcad, -0x6379);                /* call 0xfcad */
            ii(0x19_6026, 3); mov(memw_a16[ds, 0x1292], ax);            /* mov [0x1292], ax */
            ii(0x19_6029, 4); mov(memw_a16[ds, 0x1294], dx);            /* mov [0x1294], dx */
            ii(0x19_602d, 1); pushw(ds);                                /* push ds */
            ii(0x19_602e, 3); pushw(0x124f);                            /* push 0x124f */
            ii(0x19_6031, 1); pushw(ds);                                /* push ds */
            ii(0x19_6032, 3); pushw(0x1242);                            /* push 0x1242 */
            ii(0x19_6035, 3); lea(ax, bp - 0x4);                        /* lea ax, [bp-0x4] */
            ii(0x19_6038, 1); pushw(ss);                                /* push ss */
            ii(0x19_6039, 1); pushw(ax);                                /* push ax */
            ii(0x19_603a, 1); pushw(ds);                                /* push ds */
            ii(0x19_603b, 3); pushw(0x128a);                            /* push 0x128a */
            ii(0x19_603e, 3); callw(0x18_fc34, -0x640d);                /* call 0xfc34 */
            ii(0x19_6041, 1); pushw(ds);                                /* push ds */
            ii(0x19_6042, 3); pushw(0x1260);                            /* push 0x1260 */
            ii(0x19_6045, 1); pushw(ds);                                /* push ds */
            ii(0x19_6046, 3); pushw(0x1255);                            /* push 0x1255 */
            ii(0x19_6049, 3); lea(ax, bp - 0x4);                        /* lea ax, [bp-0x4] */
            ii(0x19_604c, 1); pushw(ss);                                /* push ss */
            ii(0x19_604d, 1); pushw(ax);                                /* push ax */
            ii(0x19_604e, 1); pushw(ds);                                /* push ds */
            ii(0x19_604f, 3); pushw(0x128e);                            /* push 0x128e */
            ii(0x19_6052, 3); callw(0x18_fc34, -0x6421);                /* call 0xfc34 */
            ii(0x19_6055, 1); pushw(ds);                                /* push ds */
            ii(0x19_6056, 3); pushw(0x126b);                            /* push 0x126b */
            ii(0x19_6059, 1); pushw(ds);                                /* push ds */
            ii(0x19_605a, 3); pushw(0x1266);                            /* push 0x1266 */
            ii(0x19_605d, 3); lea(ax, bp - 0x4);                        /* lea ax, [bp-0x4] */
            ii(0x19_6060, 1); pushw(ss);                                /* push ss */
            ii(0x19_6061, 1); pushw(ax);                                /* push ax */
            ii(0x19_6062, 3); pushw(0xa8);                              /* push 0xa8 */
            ii(0x19_6065, 3); pushw(0xd8c);                             /* push 0xd8c */
            ii(0x19_6068, 3); callw(0x18_fc34, -0x6437);                /* call 0xfc34 */
            ii(0x19_606b, 1); popw(si);                                 /* pop si */
            ii(0x19_606c, 1); popw(di);                                 /* pop di */
            ii(0x19_606d, 1); leavew();                                 /* leave */
            ii(0x19_606e, 1); retfw(); return;                          /* retf */
        }
    }
}
