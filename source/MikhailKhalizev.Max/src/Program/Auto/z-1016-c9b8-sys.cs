using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("2bc15926-a614-4503-b275-a33990b5b8bf")]
        public void /* sys */ Method_1016_c9b8()
        {
            ii(0x1016_c9b8, 1); pushd(eax);                             /* push eax */
            ii(0x1016_c9b9, 5); mov(eax, 0);                            /* mov eax, 0x0 */
            ii(0x1016_c9be, 5); mov(edx, 0xff);                         /* mov edx, 0xff */
            ii(0x1016_c9c3, 5); calld(/* sys */ 0x1018_7ebd, 0x1_b4f5); /* call 0x10187ebd */
            ii(0x1016_c9c8, 1); popd(eax);                              /* pop eax */
            ii(0x1016_c9c9, 2); mov(ah, 0x4c);                          /* mov ah, 0x4c */
            ii(0x1016_c9cb, 2); @int(0x21);                             /* int 0x21 */
            ii(0x1016_c9cd, 3); lea(eax, eax + 0);                      /* lea eax, [eax] */
        }
    }
}
