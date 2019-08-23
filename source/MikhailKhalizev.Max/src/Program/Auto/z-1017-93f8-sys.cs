using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_93f8-cf80088d")]
        public void /* sys */ Method_1017_93f8()
        {
            ii(0x1017_93f8, 1); push(ecx);                              /* push ecx */
            ii(0x1017_93f9, 2); mov(ecx, edx);                          /* mov ecx, edx */
            ii(0x1017_93fb, 3); cmp(ebx, 0xa);                          /* cmp ebx, 0xa */
            ii(0x1017_93fe, 2); if(jnz(0x1017_940a, 0xa)) goto l_0x1017_940a; /* jnz 0x1017940a */
            ii(0x1017_9400, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1017_9402, 2); if(jge(0x1017_940a, 0x6)) goto l_0x1017_940a; /* jge 0x1017940a */
            ii(0x1017_9404, 2); neg(eax);                               /* neg eax */
            ii(0x1017_9406, 3); mov(memb[ds, edx], 0x2d);               /* mov byte [edx], 0x2d */
            ii(0x1017_9409, 1); inc(edx);                               /* inc edx */
        l_0x1017_940a:
            ii(0x1017_940a, 5); call(/* sys */ 0x1017_93ae, -0x61);     /* call 0x101793ae */
            ii(0x1017_940f, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1017_9411, 1); pop(ecx);                               /* pop ecx */
            ii(0x1017_9412, 1); ret();                                  /* ret */
        }
    }
}
