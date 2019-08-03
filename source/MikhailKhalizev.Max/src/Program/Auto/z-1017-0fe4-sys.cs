using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c51f0e98-8437-4cb3-afbb-5ecad1ca8565")]
        public void /* sys */ Method_1017_0fe4()
        {
            ii(0x1017_0fe4, 1); pushd(ebx);                             /* push ebx */
            ii(0x1017_0fe5, 1); pushd(edx);                             /* push edx */
            ii(0x1017_0fe6, 1); pushd(esi);                             /* push esi */
            ii(0x1017_0fe7, 1); pushd(edi);                             /* push edi */
            ii(0x1017_0fe8, 6); mov(esi, memd_a32[ds, 0x101b_e1c0]);    /* mov esi, [0x101be1c0] */
            ii(0x1017_0fee, 2); mov(edi, eax);                          /* mov edi, eax */
            ii(0x1017_0ff0, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1017_0ff2, 2); if(jzd(0x1017_1018, 0x24)) goto l_0x1017_1018; /* jz 0x10171018 */
            ii(0x1017_0ff4, 4); cmp(memd_a32[ds, esi + 0x3c], 0xa);     /* cmp dword [esi+0x3c], 0xa */
            ii(0x1017_0ff8, 2); if(jged(0x1017_1018, 0x1e)) goto l_0x1017_1018; /* jge 0x10171018 */
            ii(0x1017_0ffa, 2); mov(ebx, esi);                          /* mov ebx, esi */
            ii(0x1017_0ffc, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1017_0ffe, 2); xor(eax, eax);                          /* xor eax, eax */
        l_0x1017_1000:
            ii(0x1017_1000, 5); cmp(memb_a32[ds, ebx + eax + 0x48], 0); /* cmp byte [ebx+eax+0x48], 0x0 */
            ii(0x1017_1005, 2); if(jnzd(0x1017_100d, 0x6)) goto l_0x1017_100d; /* jnz 0x1017100d */
            ii(0x1017_1007, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1017_1009, 2); mov(memd_a32[ds, edi], edx);            /* mov [edi], edx */
            ii(0x1017_100b, 2); jmpd(0x1017_101d, 0x10); goto l_0x1017_101d; /* jmp 0x1017101d */
        l_0x1017_100d:
            ii(0x1017_100d, 3); add(eax, 0x24);                         /* add eax, 0x24 */
            ii(0x1017_1010, 1); inc(edx);                               /* inc edx */
            ii(0x1017_1011, 5); cmp(eax, 0x168);                        /* cmp eax, 0x168 */
            ii(0x1017_1016, 2); if(jld(0x1017_1000, -0x18)) goto l_0x1017_1000; /* jl 0x10171000 */
        l_0x1017_1018:
            ii(0x1017_1018, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
        l_0x1017_101d:
            ii(0x1017_101d, 6); mov(memd_a32[ds, 0x101b_e1c0], esi);    /* mov [0x101be1c0], esi */
            ii(0x1017_1023, 1); popd(edi);                              /* pop edi */
            ii(0x1017_1024, 1); popd(esi);                              /* pop esi */
            ii(0x1017_1025, 1); popd(edx);                              /* pop edx */
            ii(0x1017_1026, 1); popd(ebx);                              /* pop ebx */
            ii(0x1017_1027, 1); retd(); return;                         /* ret */
        }
    }
}
