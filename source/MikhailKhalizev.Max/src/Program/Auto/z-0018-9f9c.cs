using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_9f9c-5926c55f")]
        public void Method_0018_9f9c()
        {
            ii(0x18_9f9c, 3); mov(ds, memw_a16[ss, bp + 0x2]);          /* mov ds, [bp+0x2] */
            ii(0x18_9f9f, 2); pushd(eax);                               /* push eax */
            ii(0x18_9fa1, 2); pushd(ebx);                               /* push ebx */
            ii(0x18_9fa3, 5); lar(ebx, memw_a16[ss, bp + 0x2]);         /* lar ebx, word [bp+0x2] */
            ii(0x18_9fa8, 5); bt(ebx, 0x16);                            /* bt ebx, 0x16 */
            ii(0x18_9fad, 6); mov(ebx, 0);                              /* mov ebx, 0x0 */
            ii(0x18_9fb3, 2); if(jaew_func(0x18_9fb6, 0x1)) return;     /* jae 0x9fb6 */
        }
    }
}
