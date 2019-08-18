using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c2266f6c-87e7-4653-b087-354a15fef51f")]
        public void /* sys */ Method_1017_20b7()
        {
            ii(0x1017_20b7, 1); pushd(ebx);                             /* push ebx */
            ii(0x1017_20b8, 1); pushd(ecx);                             /* push ecx */
            ii(0x1017_20b9, 1); pushd(esi);                             /* push esi */
            ii(0x1017_20ba, 1); pushd(edi);                             /* push edi */
            ii(0x1017_20bb, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1017_20bd, 2); mov(edi, edx);                          /* mov edi, edx */
            ii(0x1017_20bf, 5); calld(/* sys */ 0x1018_d5d3, 0x1_b50f); /* call 0x1018d5d3 */
            ii(0x1017_20c4, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1017_20c6, 3); lea(edx, ecx + 0x4);                    /* lea edx, [ecx+0x4] */
            ii(0x1017_20c9, 3); mov(memb_a32[ds, ecx], 0x74);           /* mov byte [ecx], 0x74 */
            ii(0x1017_20cc, 2); mov(esi, ecx);                          /* mov esi, ecx */
        l_0x1017_20ce:
            ii(0x1017_20ce, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1017_20d0, 3); and(eax, 0xf);                          /* and eax, 0xf */
            ii(0x1017_20d3, 5); calld(/* sys */ 0x1017_20ab, -0x2d);    /* call 0x101720ab */
            ii(0x1017_20d8, 2); mov(memb_a32[ds, edx], al);             /* mov [edx], al */
            ii(0x1017_20da, 1); dec(edx);                               /* dec edx */
            ii(0x1017_20db, 3); shr(ebx, 0x4);                          /* shr ebx, 0x4 */
            ii(0x1017_20de, 2); cmp(edx, esi);                          /* cmp edx, esi */
            ii(0x1017_20e0, 2); if(jnzd(0x1017_20ce, -0x14)) goto l_0x1017_20ce; /* jnz 0x101720ce */
            ii(0x1017_20e2, 2); mov(eax, edi);                          /* mov eax, edi */
            ii(0x1017_20e4, 3); sar(eax, 0x4);                          /* sar eax, 0x4 */
            ii(0x1017_20e7, 3); and(eax, 0xf);                          /* and eax, 0xf */
            ii(0x1017_20ea, 4); mov(memb_a32[ds, ecx + 0x5], 0x5f);     /* mov byte [ecx+0x5], 0x5f */
            ii(0x1017_20ee, 5); calld(/* sys */ 0x1017_20ab, -0x48);    /* call 0x101720ab */
            ii(0x1017_20f3, 3); mov(memb_a32[ds, ecx + 0x6], al);       /* mov [ecx+0x6], al */
            ii(0x1017_20f6, 2); mov(eax, edi);                          /* mov eax, edi */
            ii(0x1017_20f8, 3); and(eax, 0xf);                          /* and eax, 0xf */
            ii(0x1017_20fb, 5); calld(/* sys */ 0x1017_20ab, -0x55);    /* call 0x101720ab */
            ii(0x1017_2100, 4); mov(memb_a32[ds, ecx + 0x8], 0x2e);     /* mov byte [ecx+0x8], 0x2e */
            ii(0x1017_2104, 4); mov(memb_a32[ds, ecx + 0x9], 0x74);     /* mov byte [ecx+0x9], 0x74 */
            ii(0x1017_2108, 4); mov(memb_a32[ds, ecx + 0xa], 0x6d);     /* mov byte [ecx+0xa], 0x6d */
            ii(0x1017_210c, 4); mov(memb_a32[ds, ecx + 0xb], 0x70);     /* mov byte [ecx+0xb], 0x70 */
            ii(0x1017_2110, 4); mov(memb_a32[ds, ecx + 0xc], 0);        /* mov byte [ecx+0xc], 0x0 */
            ii(0x1017_2114, 3); mov(memb_a32[ds, ecx + 0x7], al);       /* mov [ecx+0x7], al */
            ii(0x1017_2117, 1); popd(edi);                              /* pop edi */
            ii(0x1017_2118, 1); popd(esi);                              /* pop esi */
            ii(0x1017_2119, 1); popd(ecx);                              /* pop ecx */
            ii(0x1017_211a, 1); popd(ebx);                              /* pop ebx */
            ii(0x1017_211b, 1); retd(); return;                         /* ret */
        }
    }
}
