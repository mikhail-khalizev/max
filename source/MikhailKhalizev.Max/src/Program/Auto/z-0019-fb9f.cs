using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_fb9f-1ab65da7")]
        public void Method_0019_fb9f()
        {
            ii(0x19_fb9f, 4); enterw(0x2, 0);                           /* enter 0x2, 0x0 */
            ii(0x19_fba3, 1); pushw(di);                                /* push di */
            ii(0x19_fba4, 1); pushw(si);                                /* push si */
            ii(0x19_fba5, 1); pushw(ds);                                /* push ds */
            ii(0x19_fba6, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x19_fba9, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x19_fbab, 5); mov(memw_a16[ss, bp - 0x2], 0x1);         /* mov word [bp-0x2], 0x1 */
            ii(0x19_fbb0, 3); callw(0x19_fa33, -0x180);                 /* call 0xfa33 */
            ii(0x19_fbb3, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x19_fbb5, 2); if(jzw(0x19_fbd1, 0x1a)) goto l_0x19_fbd1; /* jz 0xfbd1 */
            ii(0x19_fbb7, 3); mov(di, memw_a16[ss, bp + 0x4]);          /* mov di, [bp+0x4] */
            ii(0x19_fbba, 3); mov(si, memw_a16[ss, bp + 0x6]);          /* mov si, [bp+0x6] */
            ii(0x19_fbbd, 3); mov(cx, memw_a16[ss, bp + 0x8]);          /* mov cx, [bp+0x8] */
            ii(0x19_fbc0, 3); mov(bx, memw_a16[ss, bp + 0xa]);          /* mov bx, [bp+0xa] */
            ii(0x19_fbc3, 3); mov(ax, 0x600);                           /* mov ax, 0x600 */
            ii(0x19_fbc6, 2); @int(0x31);                               /* int 0x31 */
            ii(0x19_fbc8, 3); mov(ax, 0);                               /* mov ax, 0x0 */
            ii(0x19_fbcb, 1); cmc();                                    /* cmc */
            ii(0x19_fbcc, 2); rcl(ax, 0x1);                             /* rcl ax, 1 */
            ii(0x19_fbce, 3); mov(memw_a16[ss, bp - 0x2], ax);          /* mov [bp-0x2], ax */
        l_0x19_fbd1:
            ii(0x19_fbd1, 3); mov(ax, memw_a16[ss, bp - 0x2]);          /* mov ax, [bp-0x2] */
            ii(0x19_fbd4, 1); popw(ds);                                 /* pop ds */
            ii(0x19_fbd5, 1); popw(si);                                 /* pop si */
            ii(0x19_fbd6, 1); popw(di);                                 /* pop di */
            ii(0x19_fbd7, 1); leavew();                                 /* leave */
            ii(0x19_fbd8, 3); retw(0x8); return;                        /* ret 0x8 */
        }
    }
}
