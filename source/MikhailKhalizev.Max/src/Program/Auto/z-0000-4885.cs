using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("38e7ce5d-156d-4317-826f-916ae1344031")]
        public void Method_0000_4885()
        {
            ii(0x4885, 1);    pushw(ss);                                /* push ss */
            ii(0x4886, 1);    popw(ds);                                 /* pop ds */
            ii(0x4887, 1);    retw();                                   /* ret */
        }
    }
}
