using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("572494a5-0f03-48a1-989c-abe70bd90fdc")]
        public void Method_0000_91b8()
        {
            ii(0x91b8, 3);    mov(ax, memw_a16[ss, bp - 0x4]);          /* mov ax, [bp-0x4] */
            ii(0x91bb, 3);    mov(dx, memw_a16[ss, bp - 0x2]);          /* mov dx, [bp-0x2] */
            ii(0x91be, 3);    add(ax, 0x3ff);                           /* add ax, 0x3ff */
            ii(0x91c1, 3);    adc(dx, 0);                               /* adc dx, 0x0 */
            ii(0x91c4, 3);    mov(memw_a16[ss, bp - 0x1a], ax);         /* mov [bp-0x1a], ax */
            ii(0x91c7, 3);    mov(memw_a16[ss, bp - 0x18], dx);         /* mov [bp-0x18], dx */
            ii(0x91ca, 4);    cmp(dx, memw_a16[ds, 0x9e]);              /* cmp dx, [0x9e] */
            ii(0x91ce, 2);    jaw_func(0x91f7, 0x27);                   /* ja 0x91f7 */
            ii(0x91d0, 2);    if(jbw(0x91d8, 0x6)) goto l_0x91d8;       /* jb 0x91d8 */
            ii(0x91d2, 4);    cmp(ax, memw_a16[ds, 0x9c]);              /* cmp ax, [0x9c] */
            ii(0x91d6, 2);    jaew_func(0x91f7, 0x1f);                  /* jae 0x91f7 */
        l_0x91d8:
            ii(0x91d8, 1);    pushw(dx);                                /* push dx */
            ii(0x91d9, 1);    pushw(ax);                                /* push ax */
            ii(0x91da, 3);    callw(0x8d9d, -0x440);                    /* call 0x8d9d */
        }
    }
}
