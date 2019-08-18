using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("03e2e5c2-5dde-41cd-994f-1b008a9051f3")]
        public void /* sys */ Method_1019_5c0b()
        {
            ii(0x1019_5c0b, 1); pushd(ecx);                             /* push ecx */
            ii(0x1019_5c0c, 2); mov(ecx, edx);                          /* mov ecx, edx */
            ii(0x1019_5c0e, 3); cmp(ebx, 0xa);                          /* cmp ebx, 0xa */
            ii(0x1019_5c11, 2); if(jnzd(0x1019_5c1d, 0xa)) goto l_0x1019_5c1d; /* jnz 0x10195c1d */
            ii(0x1019_5c13, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1019_5c15, 2); if(jged(0x1019_5c1d, 0x6)) goto l_0x1019_5c1d; /* jge 0x10195c1d */
            ii(0x1019_5c17, 2); neg(eax);                               /* neg eax */
            ii(0x1019_5c19, 3); mov(memb_a32[ds, edx], 0x2d);           /* mov byte [edx], 0x2d */
            ii(0x1019_5c1c, 1); inc(edx);                               /* inc edx */
        l_0x1019_5c1d:
            ii(0x1019_5c1d, 5); calld(/* sys */ 0x1019_5bc1, -0x61);    /* call 0x10195bc1 */
            ii(0x1019_5c22, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1019_5c24, 1); popd(ecx);                              /* pop ecx */
            ii(0x1019_5c25, 1); retd(); return;                         /* ret */
        }
    }
}
