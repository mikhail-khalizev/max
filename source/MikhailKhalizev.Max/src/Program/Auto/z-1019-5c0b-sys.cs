using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_5c0b-cf80088d")]
        public void /* sys */ Method_1019_5c0b()
        {
            ii(0x1019_5c0b, 1); push(ecx);                              /* push ecx */
            ii(0x1019_5c0c, 2); mov(ecx, edx);                          /* mov ecx, edx */
            ii(0x1019_5c0e, 3); cmp(ebx, 0xa);                          /* cmp ebx, 0xa */
            ii(0x1019_5c11, 2); if(jnz(0x1019_5c1d, 0xa)) goto l_0x1019_5c1d; /* jnz 0x10195c1d */
            ii(0x1019_5c13, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1019_5c15, 2); if(jge(0x1019_5c1d, 0x6)) goto l_0x1019_5c1d; /* jge 0x10195c1d */
            ii(0x1019_5c17, 2); neg(eax);                               /* neg eax */
            ii(0x1019_5c19, 3); mov(memb[ds, edx], 0x2d);               /* mov byte [edx], 0x2d */
            ii(0x1019_5c1c, 1); inc(edx);                               /* inc edx */
        l_0x1019_5c1d:
            ii(0x1019_5c1d, 5); call(/* sys */ 0x1019_5bc1, -0x61);     /* call 0x10195bc1 */
            ii(0x1019_5c22, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1019_5c24, 1); pop(ecx);                               /* pop ecx */
            ii(0x1019_5c25, 1); ret();                                  /* ret */
        }
    }
}
