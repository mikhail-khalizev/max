using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_245c-7dce9f2")]
        public void /* sys */ sys_free_with_check_memory_corrupt()
        {
            ii(0x1018_245c, 1); pushd(ebx);                             /* push ebx */
            ii(0x1018_245d, 1); pushd(ecx);                             /* push ecx */
            ii(0x1018_245e, 1); pushd(edx);                             /* push edx */
            ii(0x1018_245f, 1); pushd(esi);                             /* push esi */
            ii(0x1018_2460, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x1018_2462, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1018_2464, 2); if(jzd(0x1018_24a0, 0x3a)) goto l_0x1018_24a0; /* jz 0x101824a0 */
            ii(0x1018_2466, 3); lea(esi, eax - 0x8);                    /* lea esi, [eax-0x8] */
            ii(0x1018_2469, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1018_246b, 5); calld(Definitions.sys_check_memory_corrupt, 0x170); /* call 0x101825e0 */
            ii(0x1018_2470, 5); pushd(0xcc);                            /* push 0xcc */
            ii(0x1018_2475, 6); mov(ebx, memd_a32[ds, 0x101b_e82c]);    /* mov ebx, [0x101be82c] */
            ii(0x1018_247b, 2); mov(edx, memd_a32[ds, esi]);            /* mov edx, [esi] */
            ii(0x1018_247d, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1018_247f, 2); sub(ebx, edx);                          /* sub ebx, edx */
            ii(0x1018_2481, 2); mov(ecx, edx);                          /* mov ecx, edx */
            ii(0x1018_2483, 6); mov(memd_a32[ds, 0x101b_e82c], ebx);    /* mov [0x101be82c], ebx */
            ii(0x1018_2489, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1018_248e, 5); calld(/* sys */ 0x1016_ad78, -0x1_771b); /* call 0x1016ad78 */
            ii(0x1018_2493, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1018_2495, 5); calld(Definitions.sys_free, -0x1_73d9); /* call 0x1016b0c1 */
            ii(0x1018_249a, 6); dec(memd_a32[ds, 0x101b_e824]);         /* dec dword [0x101be824] */
        l_0x1018_24a0:
            ii(0x1018_24a0, 1); popd(esi);                              /* pop esi */
            ii(0x1018_24a1, 1); popd(edx);                              /* pop edx */
            ii(0x1018_24a2, 1); popd(ecx);                              /* pop ecx */
            ii(0x1018_24a3, 1); popd(ebx);                              /* pop ebx */
            ii(0x1018_24a4, 1); retd(); return;                         /* ret */
        }
    }
}
