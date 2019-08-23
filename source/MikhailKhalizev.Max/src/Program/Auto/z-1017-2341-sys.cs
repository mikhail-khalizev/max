using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_2341-7e5981ec")]
        public void /* sys */ Method_1017_2341()
        {
            ii(0x1017_2341, 1); pushd(ecx);                             /* push ecx */
            ii(0x1017_2342, 1); pushd(esi);                             /* push esi */
            ii(0x1017_2343, 1); pushd(edi);                             /* push edi */
            ii(0x1017_2344, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x1017_2346, 2); mov(ecx, ebx);                          /* mov ecx, ebx */
            ii(0x1017_2348, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1017_234a, 5); calld(/* sys */ 0x1017_21ac, -0x1a3);   /* call 0x101721ac */
            ii(0x1017_234f, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1017_2351, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1017_2353, 2); if(jzd(0x1017_2376, 0x21)) goto l_0x1017_2376; /* jz 0x10172376 */
            ii(0x1017_2355, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1017_2357, 5); calld(/* sys */ 0x1018_d4d6, 0x1_b17a); /* call 0x1018d4d6 */
            ii(0x1017_235c, 2); mov(edi, eax);                          /* mov edi, eax */
            ii(0x1017_235e, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1017_2360, 2); if(jzd(0x1017_2374, 0x12)) goto l_0x1017_2374; /* jz 0x10172374 */
            ii(0x1017_2362, 1); pushd(eax);                             /* push eax */
            ii(0x1017_2363, 2); mov(dl, memb_a32[ds, edx]);             /* mov dl, [edx] */
            ii(0x1017_2365, 6); and(edx, 0xff);                         /* and edx, 0xff */
            ii(0x1017_236b, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1017_236d, 5); calld(/* sys */ 0x1017_227d, -0xf5);    /* call 0x1017227d */
            ii(0x1017_2372, 2); mov(edi, eax);                          /* mov edi, eax */
        l_0x1017_2374:
            ii(0x1017_2374, 2); mov(eax, edi);                          /* mov eax, edi */
        l_0x1017_2376:
            ii(0x1017_2376, 1); popd(edi);                              /* pop edi */
            ii(0x1017_2377, 1); popd(esi);                              /* pop esi */
            ii(0x1017_2378, 1); popd(ecx);                              /* pop ecx */
            ii(0x1017_2379, 1); retd();                                 /* ret */
        }
    }
}
