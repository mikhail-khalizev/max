using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("be7988d1-da18-481e-9a4e-fefa849bf09b")]
        public void Method_0000_8dd1()
        {
            ii(0x8dd1, 3);    add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x8dd4, 3);    mov(ax, memw_a16[ds, 0xf08]);             /* mov ax, [0xf08] */
            ii(0x8dd7, 4);    mov(dx, memw_a16[ds, 0xf0a]);             /* mov dx, [0xf0a] */
            ii(0x8ddb, 3);    cmp(memw_a16[ss, bp - 0x4], ax);          /* cmp [bp-0x4], ax */
            ii(0x8dde, 2);    if(jnzw(0x8dea, 0xa)) goto l_0x8dea;      /* jnz 0x8dea */
            ii(0x8de0, 3);    cmp(memw_a16[ss, bp - 0x2], dx);          /* cmp [bp-0x2], dx */
            ii(0x8de3, 2);    if(jnzw(0x8dea, 0x5)) goto l_0x8dea;      /* jnz 0x8dea */
            ii(0x8de5, 3);    mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x8de8, 1);    leavew();                                 /* leave */
            ii(0x8de9, 1);    retw(); return;                           /* ret */
        l_0x8dea:
            ii(0x8dea, 2);    sub(ax, ax);                              /* sub ax, ax */
            ii(0x8dec, 1);    leavew();                                 /* leave */
            ii(0x8ded, 1);    retw(); return;                           /* ret */
        }
    }
}
