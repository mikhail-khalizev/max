using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("56984244-358d-448c-a7dd-0aecdd6e0583")]
        public void Method_0014_ac8d()
        {
            ii(0x14_ac8d, 4); mov(es, memw_a16[ds, 0xc2e]);             /* mov es, [0xc2e] */
            ii(0x14_ac91, 3); mov(memw_a16[es, bx], ax);                /* mov [es:bx], ax */
            ii(0x14_ac94, 4); mov(memw_a16[es, bx + 0x2], si);          /* mov [es:bx+0x2], si */
        }
    }
}
