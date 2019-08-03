using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("7f2026d0-403c-49c9-8d36-a87cb76943ca")]
        public void /* sys */ Method_1018_0fe0()
        {
            ii(0x1018_0fe0, 1); pushd(ebx);                             /* push ebx */
            ii(0x1018_0fe1, 1); pushd(ecx);                             /* push ecx */
            ii(0x1018_0fe2, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1018_0fe4, 2); mov(ecx, edx);                          /* mov ecx, edx */
            ii(0x1018_0fe6, 2); mov(edx, ds);                           /* mov edx, ds */
            ii(0x1018_0fe8, 5); calld(/* sys */ 0x1019_5b64, 0x14b77);  /* call 0x10195b64 */
            ii(0x1018_0fed, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1018_0fef, 2); if(jnzd(0x1018_0ffa, 0x9)) goto l_0x1018_0ffa; /* jnz 0x10180ffa */
            ii(0x1018_0ff1, 2); mov(edx, ecx);                          /* mov edx, ecx */
            ii(0x1018_0ff3, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1018_0ff5, 5); calld(/* sys */ 0x1018_0ffd, 0x3);      /* call 0x10180ffd */
        l_0x1018_0ffa:
            ii(0x1018_0ffa, 1); popd(ecx);                              /* pop ecx */
            ii(0x1018_0ffb, 1); popd(ebx);                              /* pop ebx */
            ii(0x1018_0ffc, 1); retd(); return;                         /* ret */
        }
    }
}