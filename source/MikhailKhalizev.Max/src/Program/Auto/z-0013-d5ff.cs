using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("04497b3f-15b1-4666-a201-950ee65d7948")]
        public void Method_0013_d5ff()
        {
        l_0x13_d5ff:
            ii(0x13_d5ff, 2); cmp(si, di);                              /* cmp si, di */
            ii(0x13_d601, 2); if(jaew(0x13_d611, 0xe)) goto l_0x13_d611; /* jae 0xd611 */
            ii(0x13_d603, 3); sub(di, 0x4);                             /* sub di, 0x4 */
            ii(0x13_d606, 2); mov(ax, memw_a16[ds, di]);                /* mov ax, [di] */
            ii(0x13_d608, 3); or(ax, memw_a16[ds, di + 0x2]);           /* or ax, [di+0x2] */
            ii(0x13_d60b, 2); if(jzw(0x13_d5ff, -0xe)) goto l_0x13_d5ff; /* jz 0xd5ff */
            ii(0x13_d60d, 2); callw_a16_far_ind(ds, di);                /* call far word [di] */
            ii(0x13_d60f, 2); jmpw(0x13_d5ff, -0x12); goto l_0x13_d5ff; /* jmp 0xd5ff */
        l_0x13_d611:
            ii(0x13_d611, 1); retw(); return;                           /* ret */
        }
    }
}
