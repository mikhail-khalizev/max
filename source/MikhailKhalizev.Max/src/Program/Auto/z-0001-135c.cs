using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c38c7e5b-c34a-4def-86b2-c8bfc580a80f")]
        public void Method_0001_135c()
        {
            ii(0x1_135c, 3);  mov(al, memb_a16[ds, 0x1582]);            /* mov al, [0x1582] */
            ii(0x1_135f, 2);  and(al, 0x1);                             /* and al, 0x1 */
            ii(0x1_1361, 1);  cbw();                                    /* cbw */
            ii(0x1_1362, 1);  retw(); return;                           /* ret */
        }
    }
}
