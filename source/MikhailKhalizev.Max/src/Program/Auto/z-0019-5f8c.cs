using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_5f8c-50a6a6c2")]
        public void Method_0019_5f8c()
        {
            ii(0x19_5f8c, 4); enter(0x10, 0);                           /* enter 0x10, 0x0 */
            ii(0x19_5f90, 1); push(di);                                 /* push di */
            ii(0x19_5f91, 1); push(si);                                 /* push si */
            ii(0x19_5f92, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x19_5f94, 3); mov(memw[ss, bp - 2], ax);                /* mov [bp-0x2], ax */
            ii(0x19_5f97, 3); mov(memw[ss, bp - 4], ax);                /* mov [bp-0x4], ax */
            ii(0x19_5f9a, 4); mov(es, memw[ds, 0x3f94]);                /* mov es, [0x3f94] */
            ii(0x19_5f9e, 4); mov(ax, memw[es, 0x3b78]);                /* mov ax, [es:0x3b78] */
            ii(0x19_5fa2, 5); mov(memw[ss, bp - 8], 0);                 /* mov word [bp-0x8], 0x0 */
            ii(0x19_5fa7, 3); mov(memw[ss, bp - 6], ax);                /* mov [bp-0x6], ax */
            ii(0x19_5faa, 3); les(bx, memw[ss, bp - 8]);                /* les bx, [bp-0x8] */
            ii(0x19_5fad, 4); mov(ax, memw[es, bx + 14]);               /* mov ax, [es:bx+0xe] */
            ii(0x19_5fb1, 3); mov(memw[ds, 0x4898], ax);                /* mov [0x4898], ax */
            ii(0x19_5fb4, 5); mov(memw[ss, bp - 10], 0);                /* mov word [bp-0xa], 0x0 */
            ii(0x19_5fb9, 3); jmp(0x19_5fbf, 3); goto l_0x19_5fbf;      /* jmp 0x5fbf */
        l_0x19_5fbc:
            ii(0x19_5fbc, 3); inc(memw[ss, bp - 10]);                   /* inc word [bp-0xa] */
        l_0x19_5fbf:
            ii(0x19_5fbf, 4); cmp(memw[ss, bp - 10], 0x10);             /* cmp word [bp-0xa], 0x10 */
            ii(0x19_5fc3, 2); if(jl(0x19_5fc8, 3)) goto l_0x19_5fc8;    /* jl 0x5fc8 */
            ii(0x19_5fc5, 3); jmp(0x19_5fd7, 0xf); goto l_0x19_5fd7;    /* jmp 0x5fd7 */
        l_0x19_5fc8:
            ii(0x19_5fc8, 3); call(0x19_79a9, 0x19de);                  /* call 0x79a9 */
            ii(0x19_5fcb, 3); mov(bx, memw[ss, bp - 10]);               /* mov bx, [bp-0xa] */
            ii(0x19_5fce, 2); shl(bx, 1);                               /* shl bx, 1 */
            ii(0x19_5fd0, 4); mov(memw[ds, bx + 18544], ax);            /* mov [bx+0x4870], ax */
            ii(0x19_5fd4, 3); jmp(0x19_5fbc, -0x1b); goto l_0x19_5fbc;  /* jmp 0x5fbc */
        l_0x19_5fd7:
            ii(0x19_5fd7, 6); mov(memw[ds, 0x1274], 0);                 /* mov word [0x1274], 0x0 */
            ii(0x19_5fdd, 3); call(0x19_79a9, 0x19c9);                  /* call 0x79a9 */
            ii(0x19_5fe0, 3); mov(memw[ds, 0x4896], ax);                /* mov [0x4896], ax */
            ii(0x19_5fe3, 6); mov(memw[ds, 0x489a], 0);                 /* mov word [0x489a], 0x0 */
            ii(0x19_5fe9, 3); mov(ax, memw[ds, 0x12a8]);                /* mov ax, [0x12a8] */
            ii(0x19_5fec, 3); mov(memw[ss, bp - 16], ax);               /* mov [bp-0x10], ax */
            ii(0x19_5fef, 5); mov(memw[ss, bp - 14], 0);                /* mov word [bp-0xe], 0x0 */
            ii(0x19_5ff4, 3); mov(ax, memw[ds, 0x12aa]);                /* mov ax, [0x12aa] */
            ii(0x19_5ff7, 3); mov(memw[ss, bp - 12], ax);               /* mov [bp-0xc], ax */
            ii(0x19_5ffa, 3); lea(ax, memw[ss, bp - 16]);               /* lea ax, [bp-0x10] */
            ii(0x19_5ffd, 1); push(ss);                                 /* push ss */
            ii(0x19_5ffe, 1); push(ax);                                 /* push ax */
            ii(0x19_5fff, 2); push(0x21);                               /* push 0x21 */
            ii(0x19_6001, 5); call_far_abs(0x80, 0xb38);                /* call word 0x80:0xb38 */
            ii(0x19_6006, 3); add(sp, 6);                               /* add sp, 0x6 */
            ii(0x19_6009, 1); push(ds);                                 /* push ds */
            ii(0x19_600a, 3); push(0x1218);                             /* push 0x1218 */
            ii(0x19_600d, 1); push(ds);                                 /* push ds */
            ii(0x19_600e, 3); push(0x120a);                             /* push 0x120a */
            ii(0x19_6011, 3); call(0x18_fcad, -0x6367);                 /* call 0xfcad */
            ii(0x19_6014, 3); mov(memw[ds, 0x1286], ax);                /* mov [0x1286], ax */
            ii(0x19_6017, 4); mov(memw[ds, 0x1288], dx);                /* mov [0x1288], dx */
            ii(0x19_601b, 1); push(ds);                                 /* push ds */
            ii(0x19_601c, 3); push(0x1234);                             /* push 0x1234 */
            ii(0x19_601f, 1); push(ds);                                 /* push ds */
            ii(0x19_6020, 3); push(0x1221);                             /* push 0x1221 */
            ii(0x19_6023, 3); call(0x18_fcad, -0x6379);                 /* call 0xfcad */
            ii(0x19_6026, 3); mov(memw[ds, 0x1292], ax);                /* mov [0x1292], ax */
            ii(0x19_6029, 4); mov(memw[ds, 0x1294], dx);                /* mov [0x1294], dx */
            ii(0x19_602d, 1); push(ds);                                 /* push ds */
            ii(0x19_602e, 3); push(0x124f);                             /* push 0x124f */
            ii(0x19_6031, 1); push(ds);                                 /* push ds */
            ii(0x19_6032, 3); push(0x1242);                             /* push 0x1242 */
            ii(0x19_6035, 3); lea(ax, memw[ss, bp - 4]);                /* lea ax, [bp-0x4] */
            ii(0x19_6038, 1); push(ss);                                 /* push ss */
            ii(0x19_6039, 1); push(ax);                                 /* push ax */
            ii(0x19_603a, 1); push(ds);                                 /* push ds */
            ii(0x19_603b, 3); push(0x128a);                             /* push 0x128a */
            ii(0x19_603e, 3); call(0x18_fc34, -0x640d);                 /* call 0xfc34 */
            ii(0x19_6041, 1); push(ds);                                 /* push ds */
            ii(0x19_6042, 3); push(0x1260);                             /* push 0x1260 */
            ii(0x19_6045, 1); push(ds);                                 /* push ds */
            ii(0x19_6046, 3); push(0x1255);                             /* push 0x1255 */
            ii(0x19_6049, 3); lea(ax, memw[ss, bp - 4]);                /* lea ax, [bp-0x4] */
            ii(0x19_604c, 1); push(ss);                                 /* push ss */
            ii(0x19_604d, 1); push(ax);                                 /* push ax */
            ii(0x19_604e, 1); push(ds);                                 /* push ds */
            ii(0x19_604f, 3); push(0x128e);                             /* push 0x128e */
            ii(0x19_6052, 3); call(0x18_fc34, -0x6421);                 /* call 0xfc34 */
            ii(0x19_6055, 1); push(ds);                                 /* push ds */
            ii(0x19_6056, 3); push(0x126b);                             /* push 0x126b */
            ii(0x19_6059, 1); push(ds);                                 /* push ds */
            ii(0x19_605a, 3); push(0x1266);                             /* push 0x1266 */
            ii(0x19_605d, 3); lea(ax, memw[ss, bp - 4]);                /* lea ax, [bp-0x4] */
            ii(0x19_6060, 1); push(ss);                                 /* push ss */
            ii(0x19_6061, 1); push(ax);                                 /* push ax */
            ii(0x19_6062, 3); push(0xa8);                               /* push 0xa8 */
            ii(0x19_6065, 3); push(0xd8c);                              /* push 0xd8c */
            ii(0x19_6068, 3); call(0x18_fc34, -0x6437);                 /* call 0xfc34 */
            ii(0x19_606b, 1); pop(si);                                  /* pop si */
            ii(0x19_606c, 1); pop(di);                                  /* pop di */
            ii(0x19_606d, 1); leave();                                  /* leave */
            ii(0x19_606e, 1); retf();                                   /* retf */
        }
    }
}
