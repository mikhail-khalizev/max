using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("49a1e4c7-3bde-437d-a206-acca0537d6b2")]
        public void Method_0018_0bc2()
        {
            ii(0x18_0bc2, 4); enterw(0x2, 0);                           /* enter 0x2, 0x0 */
            ii(0x18_0bc6, 1); pushw(di);                                /* push di */
            ii(0x18_0bc7, 1); pushw(si);                                /* push si */
            ii(0x18_0bc8, 1); pushw(ds);                                /* push ds */
            ii(0x18_0bc9, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x18_0bcc, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x18_0bce, 5); mov(memw_a16[ss, bp - 0x2], 0x1);         /* mov word [bp-0x2], 0x1 */
            ii(0x18_0bd3, 3); callw(0x18_0a56, -0x180);                 /* call 0xa56 */
            ii(0x18_0bd6, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x18_0bd8, 2); if(jzw(0x18_0bf4, 0x1a)) goto l_0x18_0bf4; /* jz 0xbf4 */
            ii(0x18_0bda, 3); mov(di, memw_a16[ss, bp + 0x4]);          /* mov di, [bp+0x4] */
            ii(0x18_0bdd, 3); mov(si, memw_a16[ss, bp + 0x6]);          /* mov si, [bp+0x6] */
            ii(0x18_0be0, 3); mov(cx, memw_a16[ss, bp + 0x8]);          /* mov cx, [bp+0x8] */
            ii(0x18_0be3, 3); mov(bx, memw_a16[ss, bp + 0xa]);          /* mov bx, [bp+0xa] */
            ii(0x18_0be6, 3); mov(ax, 0x600);                           /* mov ax, 0x600 */
            ii(0x18_0be9, 2); @int(0x31);                               /* int 0x31 */
            ii(0x18_0beb, 3); mov(ax, 0);                               /* mov ax, 0x0 */
            ii(0x18_0bee, 1); cmc();                                    /* cmc */
            ii(0x18_0bef, 2); rcl(ax, 0x1);                             /* rcl ax, 1 */
            ii(0x18_0bf1, 3); mov(memw_a16[ss, bp - 0x2], ax);          /* mov [bp-0x2], ax */
        l_0x18_0bf4:
            ii(0x18_0bf4, 3); mov(ax, memw_a16[ss, bp - 0x2]);          /* mov ax, [bp-0x2] */
            ii(0x18_0bf7, 1); popw(ds);                                 /* pop ds */
            ii(0x18_0bf8, 1); popw(si);                                 /* pop si */
            ii(0x18_0bf9, 1); popw(di);                                 /* pop di */
            ii(0x18_0bfa, 1); leavew();                                 /* leave */
            ii(0x18_0bfb, 3); retw(0x8); return;                        /* ret 0x8 */
        }
    }
}
