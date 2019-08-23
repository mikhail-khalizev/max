using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_5f8c-40ad3fd")]
        public void /* sys */ Method_1018_5f8c()
        {
            ii(0x1018_5f8c, 1); pushd(ecx);                             /* push ecx */
            ii(0x1018_5f8d, 1); pushd(esi);                             /* push esi */
            ii(0x1018_5f8e, 1); pushd(edi);                             /* push edi */
            ii(0x1018_5f8f, 1); pushd(ebp);                             /* push ebp */
            ii(0x1018_5f90, 2); mov(edi, ebx);                          /* mov edi, ebx */
            ii(0x1018_5f92, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x1018_5f94, 1); movsd_a32();                            /* movsd */
            ii(0x1018_5f95, 1); movsd_a32();                            /* movsd */
            ii(0x1018_5f96, 1); movsd_a32();                            /* movsd */
            ii(0x1018_5f97, 1); movsd_a32();                            /* movsd */
            ii(0x1018_5f98, 2); mov(ecx, memd_a32[ds, eax]);            /* mov ecx, [eax] */
            ii(0x1018_5f9a, 3); cmp(ecx, memd_a32[ds, edx + 0x8]);      /* cmp ecx, [edx+0x8] */
            ii(0x1018_5f9d, 2); if(jgd(0x1018_5fb8, 0x19)) goto l_0x1018_5fb8; /* jg 0x10185fb8 */
            ii(0x1018_5f9f, 3); mov(ecx, memd_a32[ds, eax + 0x8]);      /* mov ecx, [eax+0x8] */
            ii(0x1018_5fa2, 2); mov(edi, memd_a32[ds, edx]);            /* mov edi, [edx] */
            ii(0x1018_5fa4, 2); cmp(ecx, edi);                          /* cmp ecx, edi */
            ii(0x1018_5fa6, 2); if(jld(0x1018_5fb8, 0x10)) goto l_0x1018_5fb8; /* jl 0x10185fb8 */
            ii(0x1018_5fa8, 3); mov(ecx, memd_a32[ds, eax + 0x4]);      /* mov ecx, [eax+0x4] */
            ii(0x1018_5fab, 3); cmp(ecx, memd_a32[ds, edx + 0xc]);      /* cmp ecx, [edx+0xc] */
            ii(0x1018_5fae, 2); if(jgd(0x1018_5fb8, 0x8)) goto l_0x1018_5fb8; /* jg 0x10185fb8 */
            ii(0x1018_5fb0, 3); mov(ecx, memd_a32[ds, eax + 0xc]);      /* mov ecx, [eax+0xc] */
            ii(0x1018_5fb3, 3); cmp(ecx, memd_a32[ds, edx + 0x4]);      /* cmp ecx, [edx+0x4] */
            ii(0x1018_5fb6, 2); if(jged(0x1018_5fc2, 0xa)) goto l_0x1018_5fc2; /* jge 0x10185fc2 */
        l_0x1018_5fb8:
            ii(0x1018_5fb8, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1018_5fbd, 1); popd(ebp);                              /* pop ebp */
            ii(0x1018_5fbe, 1); popd(edi);                              /* pop edi */
            ii(0x1018_5fbf, 1); popd(esi);                              /* pop esi */
            ii(0x1018_5fc0, 1); popd(ecx);                              /* pop ecx */
            ii(0x1018_5fc1, 1); retd(); return;                         /* ret */
        l_0x1018_5fc2:
            ii(0x1018_5fc2, 2); cmp(edi, memd_a32[ds, eax]);            /* cmp edi, [eax] */
            ii(0x1018_5fc4, 2); if(jled(0x1018_5fc8, 0x2)) goto l_0x1018_5fc8; /* jle 0x10185fc8 */
            ii(0x1018_5fc6, 2); mov(memd_a32[ds, ebx], edi);            /* mov [ebx], edi */
        l_0x1018_5fc8:
            ii(0x1018_5fc8, 3); mov(ecx, memd_a32[ds, eax + 0x8]);      /* mov ecx, [eax+0x8] */
            ii(0x1018_5fcb, 3); mov(ebp, memd_a32[ds, edx + 0x8]);      /* mov ebp, [edx+0x8] */
            ii(0x1018_5fce, 2); cmp(ecx, ebp);                          /* cmp ecx, ebp */
            ii(0x1018_5fd0, 2); if(jled(0x1018_5fd5, 0x3)) goto l_0x1018_5fd5; /* jle 0x10185fd5 */
            ii(0x1018_5fd2, 3); mov(memd_a32[ds, ebx + 0x8], ebp);      /* mov [ebx+0x8], ebp */
        l_0x1018_5fd5:
            ii(0x1018_5fd5, 3); mov(ecx, memd_a32[ds, eax + 0x4]);      /* mov ecx, [eax+0x4] */
            ii(0x1018_5fd8, 3); mov(esi, memd_a32[ds, edx + 0x4]);      /* mov esi, [edx+0x4] */
            ii(0x1018_5fdb, 2); cmp(ecx, esi);                          /* cmp ecx, esi */
            ii(0x1018_5fdd, 2); if(jged(0x1018_5fe2, 0x3)) goto l_0x1018_5fe2; /* jge 0x10185fe2 */
            ii(0x1018_5fdf, 3); mov(memd_a32[ds, ebx + 0x4], esi);      /* mov [ebx+0x4], esi */
        l_0x1018_5fe2:
            ii(0x1018_5fe2, 3); mov(eax, memd_a32[ds, eax + 0xc]);      /* mov eax, [eax+0xc] */
            ii(0x1018_5fe5, 3); mov(edi, memd_a32[ds, edx + 0xc]);      /* mov edi, [edx+0xc] */
            ii(0x1018_5fe8, 2); cmp(eax, edi);                          /* cmp eax, edi */
            ii(0x1018_5fea, 2); if(jled(0x1018_5fef, 0x3)) goto l_0x1018_5fef; /* jle 0x10185fef */
            ii(0x1018_5fec, 3); mov(memd_a32[ds, ebx + 0xc], edi);      /* mov [ebx+0xc], edi */
        l_0x1018_5fef:
            ii(0x1018_5fef, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_5ff1, 1); popd(ebp);                              /* pop ebp */
            ii(0x1018_5ff2, 1); popd(edi);                              /* pop edi */
            ii(0x1018_5ff3, 1); popd(esi);                              /* pop esi */
            ii(0x1018_5ff4, 1); popd(ecx);                              /* pop ecx */
            ii(0x1018_5ff5, 1); retd();                                 /* ret */
        }
    }
}
