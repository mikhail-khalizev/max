using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_95b4-30cc301a")]
        public void /* sys */ Method_1016_95b4()
        {
            ii(0x1016_95b4, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_95b5, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_95b6, 1); pushd(esi);                             /* push esi */
            ii(0x1016_95b7, 1); pushd(edi);                             /* push edi */
            ii(0x1016_95b8, 3); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1016_95bb, 2); mov(edi, eax);                          /* mov edi, eax */
            ii(0x1016_95bd, 2); mov(esi, edx);                          /* mov esi, edx */
            ii(0x1016_95bf, 3); mov(ecx, memd_a32[ds, edx + 0xc]);      /* mov ecx, [edx+0xc] */
            ii(0x1016_95c2, 3); mov(ebx, memd_a32[ds, edx + 0x8]);      /* mov ebx, [edx+0x8] */
            ii(0x1016_95c5, 2); mov(eax, memd_a32[ds, esi]);            /* mov eax, [esi] */
            ii(0x1016_95c7, 3); mov(edx, memd_a32[ds, edx + 0x4]);      /* mov edx, [edx+0x4] */
            ii(0x1016_95ca, 5); calld(/* sys */ 0x1016_c1f0, 0x2c21);   /* call 0x1016c1f0 */
            ii(0x1016_95cf, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_95d1, 2); if(jzd(0x1016_9612, 0x3f)) goto l_0x1016_9612; /* jz 0x10169612 */
            ii(0x1016_95d3, 4); cmp(memd_a32[ds, edi + 0x4c], 0);       /* cmp dword [edi+0x4c], 0x0 */
            ii(0x1016_95d7, 2); if(jzd(0x1016_9612, 0x39)) goto l_0x1016_9612; /* jz 0x10169612 */
            ii(0x1016_95d9, 2); mov(edx, esp);                          /* mov edx, esp */
            ii(0x1016_95db, 4); lea(eax, esp + 0x4);                    /* lea eax, [esp+0x4] */
            ii(0x1016_95df, 5); calld(/* sys */ 0x1016_c298, 0x2cb4);   /* call 0x1016c298 */
            ii(0x1016_95e4, 4); mov(ebx, memd_a32[ss, esp + 0x4]);      /* mov ebx, [esp+0x4] */
            ii(0x1016_95e8, 2); mov(eax, memd_a32[ds, esi]);            /* mov eax, [esi] */
            ii(0x1016_95ea, 2); sub(ebx, eax);                          /* sub ebx, eax */
            ii(0x1016_95ec, 4); mov(memd_a32[ss, esp + 0x4], ebx);      /* mov [esp+0x4], ebx */
            ii(0x1016_95f0, 3); mov(ecx, memd_a32[ss, esp]);            /* mov ecx, [esp] */
            ii(0x1016_95f3, 3); mov(eax, memd_a32[ds, esi + 0x4]);      /* mov eax, [esi+0x4] */
            ii(0x1016_95f6, 2); sub(ecx, eax);                          /* sub ecx, eax */
            ii(0x1016_95f8, 3); mov(memd_a32[ss, esp], ecx);            /* mov [esp], ecx */
            ii(0x1016_95fb, 3); mov(eax, memd_a32[ds, edi + 0x10]);     /* mov eax, [edi+0x10] */
            ii(0x1016_95fe, 3); sub(eax, memd_a32[ds, edi + 0x8]);      /* sub eax, [edi+0x8] */
            ii(0x1016_9601, 1); inc(eax);                               /* inc eax */
            ii(0x1016_9602, 3); imul(eax, ecx);                         /* imul eax, ecx */
            ii(0x1016_9605, 3); mov(edx, memd_a32[ds, edi + 0x4c]);     /* mov edx, [edi+0x4c] */
            ii(0x1016_9608, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1016_960a, 3); mov(al, memb_a32[ds, edx + eax]);       /* mov al, [edx+eax] */
            ii(0x1016_960d, 5); and(eax, 0xff);                         /* and eax, 0xff */
        l_0x1016_9612:
            ii(0x1016_9612, 3); add(esp, 0x8);                          /* add esp, 0x8 */
            ii(0x1016_9615, 1); popd(edi);                              /* pop edi */
            ii(0x1016_9616, 1); popd(esi);                              /* pop esi */
            ii(0x1016_9617, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_9618, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_9619, 1); retd();                                 /* ret */
        }
    }
}
