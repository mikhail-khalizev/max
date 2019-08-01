using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("78d516a6-cb09-43c5-9f93-b4c9025bdeaa")]
        public void Method_0013_f569()
        {
            ii(0x13_f569, 4); enterw(0x8, 0);                           /* enter 0x8, 0x0 */
            ii(0x13_f56d, 1); pushw(ds);                                /* push ds */
            ii(0x13_f56e, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x13_f571, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x13_f573, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x13_f575, 3); mov(memw_a16[ss, bp - 0x2], ax);          /* mov [bp-0x2], ax */
            ii(0x13_f578, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x13_f57b, 3); mov(memw_a16[ss, bp - 0x6], ax);          /* mov [bp-0x6], ax */
            ii(0x13_f57e, 3); mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0x13_f581, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x13_f584, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x13_f587, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x13_f58a, 3); pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x13_f58d, 3); lea(ax, bp - 0x4);                        /* lea ax, [bp-0x4] */
            ii(0x13_f590, 1); pushw(ss);                                /* push ss */
            ii(0x13_f591, 1); pushw(ax);                                /* push ax */
            ii(0x13_f592, 3); lea(ax, bp - 0x8);                        /* lea ax, [bp-0x8] */
            ii(0x13_f595, 1); pushw(ss);                                /* push ss */
            ii(0x13_f596, 1); pushw(ax);                                /* push ax */
            ii(0x13_f597, 3); callw(0x13_f4f0, -0xaa);                  /* call 0xf4f0 */
            ii(0x13_f59a, 3); mov(ax, memw_a16[ss, bp - 0x8]);          /* mov ax, [bp-0x8] */
            ii(0x13_f59d, 3); mov(dx, memw_a16[ss, bp - 0x6]);          /* mov dx, [bp-0x6] */
            ii(0x13_f5a0, 1); popw(ds);                                 /* pop ds */
            ii(0x13_f5a1, 1); leavew();                                 /* leave */
            ii(0x13_f5a2, 3); retw(0x8); return;                        /* ret 0x8 */
        }
    }
}
