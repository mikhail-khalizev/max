using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("ced5f569-747b-45f0-b13f-c2a4b3b216be")]
        public void /* sys */ Method_1017_93f8()
        {
            ii(0x1017_93f8, 1); pushd(ecx);                             /* push ecx */
            ii(0x1017_93f9, 2); mov(ecx, edx);                          /* mov ecx, edx */
            ii(0x1017_93fb, 3); cmp(ebx, 0xa);                          /* cmp ebx, 0xa */
            ii(0x1017_93fe, 2); if(jnzd(0x1017_940a, 0xa)) goto l_0x1017_940a; /* jnz 0x10195c1d */
            ii(0x1017_9400, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1017_9402, 2); if(jged(0x1017_940a, 0x6)) goto l_0x1017_940a; /* jge 0x10195c1d */
            ii(0x1017_9404, 2); neg(eax);                               /* neg eax */
            ii(0x1017_9406, 3); mov(memb_a32[ds, edx], 0x2d);           /* mov byte [edx], 0x2d */
            ii(0x1017_9409, 1); inc(edx);                               /* inc edx */
        l_0x1017_940a:
            ii(0x1017_940a, 5); calld(/* sys */ 0x1017_93ae, -0x61);    /* call 0x10195bc1 */
            ii(0x1017_940f, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1017_9411, 1); popd(ecx);                              /* pop ecx */
            ii(0x1017_9412, 1); retd(); return;                         /* ret */
        }
    }
}