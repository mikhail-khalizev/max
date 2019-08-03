using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("9245a15d-6216-43d7-9393-8f975d9527cb")]
        public void /* sys */ Method_1019_ab51()
        {
            ii(0x1019_ab51, 1); pushd(edx);                             /* push edx */
            ii(0x1019_ab52, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1019_ab54, 2); mov(ah, 0x41);                          /* mov ah, 0x41 */
            ii(0x1019_ab56, 2); @int(0x21);                             /* int 0x21 */
            ii(0x1019_ab58, 2); rcl(eax, 0x1);                          /* rcl eax, 1 */
            ii(0x1019_ab5a, 2); ror(eax, 0x1);                          /* ror eax, 1 */
            ii(0x1019_ab5c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1019_ab5e, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1019_ab60, 2); if(jged(0x1019_ab6e, 0xc)) goto l_0x1019_ab6e; /* jge 0x1019ab6e */
            ii(0x1019_ab62, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1019_ab64, 3); mov(ax, dx);                            /* mov ax, dx */
            ii(0x1019_ab67, 5); calld(/* sys */ 0x1018_dbb7, -0xcfb5);  /* call 0x1018dbb7 */
            ii(0x1019_ab6c, 1); popd(edx);                              /* pop edx */
            ii(0x1019_ab6d, 1); retd(); return;                         /* ret */
        l_0x1019_ab6e:
            ii(0x1019_ab6e, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1019_ab70, 1); popd(edx);                              /* pop edx */
            ii(0x1019_ab71, 1); retd(); return;                         /* ret */
        }
    }
}
