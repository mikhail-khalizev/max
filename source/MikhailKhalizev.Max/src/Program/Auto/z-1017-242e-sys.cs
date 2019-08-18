using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_242e-336f2f80")]
        public void /* sys */ Method_1017_242e()
        {
            ii(0x1017_242e, 1); pushd(ebx);                             /* push ebx */
            ii(0x1017_242f, 1); pushd(ecx);                             /* push ecx */
            ii(0x1017_2430, 1); pushd(esi);                             /* push esi */
            ii(0x1017_2431, 1); pushd(edi);                             /* push edi */
            ii(0x1017_2432, 4); and(memb_a32[ds, edx + 0xc], -0x11 /* 0xef */); /* and byte [edx+0xc], 0xef */
            ii(0x1017_2436, 3); cmp(eax, memd_a32[ds, edx + 0x4]);      /* cmp eax, [edx+0x4] */
            ii(0x1017_2439, 2); if(jgd(0x1017_245a, 0x1f)) goto l_0x1017_245a; /* jg 0x1017245a */
            ii(0x1017_243b, 3); mov(ebx, memd_a32[ds, edx + 0x8]);      /* mov ebx, [edx+0x8] */
            ii(0x1017_243e, 2); mov(ecx, memd_a32[ds, edx]);            /* mov ecx, [edx] */
            ii(0x1017_2440, 2); sub(ebx, ecx);                          /* sub ebx, ecx */
            ii(0x1017_2442, 2); cmp(eax, ebx);                          /* cmp eax, ebx */
            ii(0x1017_2444, 2); if(jld(0x1017_245a, 0x14)) goto l_0x1017_245a; /* jl 0x1017245a */
            ii(0x1017_2446, 3); mov(edi, memd_a32[ds, edx + 0x4]);      /* mov edi, [edx+0x4] */
            ii(0x1017_2449, 3); lea(esi, ecx + eax);                    /* lea esi, [ecx+eax] */
            ii(0x1017_244c, 2); sub(edi, eax);                          /* sub edi, eax */
            ii(0x1017_244e, 2); mov(memd_a32[ds, edx], esi);            /* mov [edx], esi */
            ii(0x1017_2450, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1017_2452, 3); mov(memd_a32[ds, edx + 0x4], edi);      /* mov [edx+0x4], edi */
            ii(0x1017_2455, 1); popd(edi);                              /* pop edi */
            ii(0x1017_2456, 1); popd(esi);                              /* pop esi */
            ii(0x1017_2457, 1); popd(ecx);                              /* pop ecx */
            ii(0x1017_2458, 1); popd(ebx);                              /* pop ebx */
            ii(0x1017_2459, 1); retd(); return;                         /* ret */
        l_0x1017_245a:
            ii(0x1017_245a, 3); mov(eax, memd_a32[ds, edx + 0x8]);      /* mov eax, [edx+0x8] */
            ii(0x1017_245d, 7); mov(memd_a32[ds, edx + 0x4], 0);        /* mov dword [edx+0x4], 0x0 */
            ii(0x1017_2464, 2); mov(memd_a32[ds, edx], eax);            /* mov [edx], eax */
            ii(0x1017_2466, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1017_246b, 1); popd(edi);                              /* pop edi */
            ii(0x1017_246c, 1); popd(esi);                              /* pop esi */
            ii(0x1017_246d, 1); popd(ecx);                              /* pop ecx */
            ii(0x1017_246e, 1); popd(ebx);                              /* pop ebx */
            ii(0x1017_246f, 1); retd(); return;                         /* ret */
        }
    }
}
