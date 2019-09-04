using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_5d83-fe3d2bc8")]
        public void /* sys */ Method_1016_5d83()
        {
            ii(0x1016_5d83, 5);  mov(eax, 0x101b_dd96);                /* mov eax, 0x101bdd96 */
            ii(0x1016_5d88, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x1016_5d8d, 5);  call(/* sys */ 0x1018_1002, 0x1_b270);/* call 0x10181002 */
        }
    }
}
