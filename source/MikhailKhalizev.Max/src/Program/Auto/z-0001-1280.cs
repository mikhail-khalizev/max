using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("5e58e6a6-2b83-4dc2-95ce-1bead5e44f27")]
        public void Method_0001_1280()
        {
            ii(0x1_1280, 5);  test(memb_a16[ds, 0x1582], 0x1);          /* test byte [0x1582], 0x1 */
            ii(0x1_1285, 4);  jnzw_func(0x1_1311, 0x88);                /* jnz 0x1311 */
            ii(0x1_1289, 1);  pushw(cs);                                /* push cs */
            ii(0x1_128a, 3);  callw(0x1_1230, -0x5d);                   /* call 0x1230 */
            ii(0x1_128d, 2);  or(ax, ax);                               /* or ax, ax */
            ii(0x1_128f, 4);  jzw_func(0x1_130e, 0x7b);                 /* jz 0x130e */
            ii(0x1_1293, 1);  popw(ax);                                 /* pop ax */
            ii(0x1_1294, 1);  inc(ax);                                  /* inc ax */
            ii(0x1_1295, 1);  pushw(ax);                                /* push ax */
            ii(0x1_1296, 2);  jmpw_func(0x1_12fb, 0x63); return;        /* jmp 0x12fb */
        }
    }
}
