using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_9285-e61dc9c6")]
        public void /* sys */ Method_1017_9285()
        {
            ii(0x1017_9285, 1); pushd(edx);                             /* push edx */
            ii(0x1017_9286, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1017_9288, 5); mov(eax, memd_a32[ds, 0x101b_e580]);    /* mov eax, [0x101be580] */
            ii(0x1017_928d, 6); mov(memd_a32[ds, 0x101b_e580], edx);    /* mov [0x101be580], edx */
            ii(0x1017_9293, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1017_9295, 2); if(jnzd(0x1017_92a0, 0x9)) goto l_0x1017_92a0; /* jnz 0x101792a0 */
            ii(0x1017_9297, 2); mov(ah, 0x8);                           /* mov ah, 0x8 */
            ii(0x1017_9299, 2); @int(0x21);                             /* int 0x21 */
            ii(0x1017_929b, 5); and(eax, 0xff);                         /* and eax, 0xff */
        l_0x1017_92a0:
            ii(0x1017_92a0, 1); popd(edx);                              /* pop edx */
            ii(0x1017_92a1, 1); retd();                                 /* ret */
        }
    }
}
