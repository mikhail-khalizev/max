using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_ec09-58b822b6")]
        public void Method_0019_ec09()
        {
            ii(0x19_ec09, 4); enter(0xc, 0);                            /* enter 0xc, 0x0 */
            ii(0x19_ec0d, 1); push(di);                                 /* push di */
            ii(0x19_ec0e, 1); push(si);                                 /* push si */
            ii(0x19_ec0f, 5); call_far_abs(0x80, 0x5740);               /* call word 0x80:0x5740 */
            ii(0x19_ec14, 3); mov(memw[ds, 0x2e08], ax);                /* mov [0x2e08], ax */
            ii(0x19_ec17, 5); cmp(memw[ds, 0x2e08], 0);                 /* cmp word [0x2e08], 0x0 */
            ii(0x19_ec1c, 2); if(jz(0x19_ec21, 3)) goto l_0x19_ec21;    /* jz 0xec21 */
            ii(0x19_ec1e, 3); jmp(0x19_ec27, 6); goto l_0x19_ec27;      /* jmp 0xec27 */
        l_0x19_ec21:
            ii(0x19_ec21, 3); mov(ax, 0);                               /* mov ax, 0x0 */
            ii(0x19_ec24, 3); jmp(0x19_ec7c, 0x55); goto l_0x19_ec7c;   /* jmp 0xec7c */
        l_0x19_ec27:
            ii(0x19_ec27, 5); mov(memw[ss, bp - 4], 0x53);              /* mov word [bp-0x4], 0x53 */
            ii(0x19_ec2c, 5); mov(memw[ss, bp - 2], 0x98);              /* mov word [bp-0x2], 0x98 */
            ii(0x19_ec31, 3); lea(ax, memw[ss, bp - 12]);               /* lea ax, [bp-0xc] */
            ii(0x19_ec34, 1); push(ss);                                 /* push ss */
            ii(0x19_ec35, 1); push(ax);                                 /* push ax */
            ii(0x19_ec36, 3); push(memw[ss, bp - 2]);                   /* push word [bp-0x2] */
            ii(0x19_ec39, 5); call_far_abs(0x80, 0x4f82);               /* call word 0x80:0x4f82 */
            ii(0x19_ec3e, 3); add(sp, 6);                               /* add sp, 0x6 */
            ii(0x19_ec41, 4); or(memb[ss, bp - 6], 0x40);               /* or byte [bp-0x6], 0x40 */
            ii(0x19_ec45, 3); mov(al, memb[ss, bp - 7]);                /* mov al, [bp-0x7] */
            ii(0x19_ec48, 2); and(al, 0xfa);                            /* and al, 0xfa */
            ii(0x19_ec4a, 2); or(al, 0x9a);                             /* or al, 0x9a */
            ii(0x19_ec4c, 3); mov(memb[ss, bp - 7], al);                /* mov [bp-0x7], al */
            ii(0x19_ec4f, 3); lea(ax, memw[ss, bp - 12]);               /* lea ax, [bp-0xc] */
            ii(0x19_ec52, 1); push(ss);                                 /* push ss */
            ii(0x19_ec53, 1); push(ax);                                 /* push ax */
            ii(0x19_ec54, 3); push(memw[ss, bp - 2]);                   /* push word [bp-0x2] */
            ii(0x19_ec57, 5); call_far_abs(0x80, 0x4ff4);               /* call word 0x80:0x4ff4 */
            ii(0x19_ec5c, 3); add(sp, 6);                               /* add sp, 0x6 */
            ii(0x19_ec5f, 5); call_far_abs(0x98, 0xfc);                 /* call word 0x98:0xfc */
            ii(0x19_ec64, 3); mov(memw[ss, bp - 4], ax);                /* mov [bp-0x4], ax */
            ii(0x19_ec67, 3); mov(memw[ss, bp - 2], dx);                /* mov [bp-0x2], dx */
            ii(0x19_ec6a, 3); mov(ax, memw[ss, bp - 2]);                /* mov ax, [bp-0x2] */
            ii(0x19_ec6d, 3); mov(memw[ds, 0x2e04], ax);                /* mov [0x2e04], ax */
            ii(0x19_ec70, 3); mov(ax, memw[ss, bp - 4]);                /* mov ax, [bp-0x4] */
            ii(0x19_ec73, 3); mov(memw[ds, 0x2e06], ax);                /* mov [0x2e06], ax */
            ii(0x19_ec76, 3); mov(ax, memw[ds, 0x2e04]);                /* mov ax, [0x2e04] */
            ii(0x19_ec79, 3); jmp(0x19_ec7c, 0); goto l_0x19_ec7c;      /* jmp 0xec7c */
        l_0x19_ec7c:
            ii(0x19_ec7c, 1); pop(si);                                  /* pop si */
            ii(0x19_ec7d, 1); pop(di);                                  /* pop di */
            ii(0x19_ec7e, 1); leave();                                  /* leave */
            ii(0x19_ec7f, 1); retf();                                   /* retf */
        }
    }
}
