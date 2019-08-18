using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_9446-9053653a")]
        public void /* sys */ Method_1017_9446()
        {
            ii(0x1017_9446, 1); pushd(ebx);                             /* push ebx */
            ii(0x1017_9447, 3); mov(bx, ax);                            /* mov bx, ax */
            ii(0x1017_944a, 2); mov(ah, 0x3e);                          /* mov ah, 0x3e */
            ii(0x1017_944c, 2); @int(0x21);                             /* int 0x21 */
            ii(0x1017_944e, 5); calld(/* sys */ 0x1018_dc28, 0x1_47d5); /* call 0x1018dc28 */
            ii(0x1017_9453, 1); popd(ebx);                              /* pop ebx */
            ii(0x1017_9454, 1); retd(); return;                         /* ret */
        }
    }
}
