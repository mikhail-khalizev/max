using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("74123d15-4458-4aa6-b5dd-0d932e7803fd")]
        public void /* sys */ Method_1018_d4b6()
        {
            ii(0x1018_d4b6, 1); pushd(ecx);                             /* push ecx */
            ii(0x1018_d4b7, 2); mov(ecx, ebx);                          /* mov ecx, ebx */
            ii(0x1018_d4b9, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1018_d4bb, 2); mov(ah, 0x3f);                          /* mov ah, 0x3f */
            ii(0x1018_d4bd, 2); @int(0x21);                             /* int 0x21 */
            ii(0x1018_d4bf, 2); rcl(eax, 0x1);                          /* rcl eax, 1 */
            ii(0x1018_d4c1, 2); ror(eax, 0x1);                          /* ror eax, 1 */
            ii(0x1018_d4c3, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1018_d4c5, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1018_d4c7, 2); if(jged(0x1018_d4d3, 0xa)) goto l_0x1018_d4d3; /* jge 0x1018d4d3 */
            ii(0x1018_d4c9, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_d4cb, 3); mov(ax, dx);                            /* mov ax, dx */
            ii(0x1018_d4ce, 5); calld(/* sys */ 0x1018_dbb7, 0x6e4);    /* call 0x1018dbb7 */
        l_0x1018_d4d3:
            ii(0x1018_d4d3, 1); popd(ecx);                              /* pop ecx */
            ii(0x1018_d4d4, 1); retd(); return;                         /* ret */
        }
    }
}