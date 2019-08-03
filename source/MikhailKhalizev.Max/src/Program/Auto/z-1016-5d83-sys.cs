using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("7a5c0a04-7c8b-439c-b68f-ea342701ba51")]
        public void /* sys */ Method_1016_5d83()
        {
            ii(0x1016_5d83, 5); mov(eax, 0x101b_dd96);                  /* mov eax, 0x101bdd96 */
            ii(0x1016_5d88, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1016_5d8d, 5); calld(/* sys */ 0x1018_1002, 0x1b270);  /* call 0x10181002 */
        }
    }
}
