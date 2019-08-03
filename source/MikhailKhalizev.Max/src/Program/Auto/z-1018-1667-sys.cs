using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("dcded682-5187-4d2f-848b-3164dc9c5bc1")]
        public void /* sys */ Method_1018_1667()
        {
            ii(0x1018_1667, 1); pushd(ecx);                             /* push ecx */
            ii(0x1018_1668, 1); pushd(esi);                             /* push esi */
            ii(0x1018_1669, 1); pushd(edi);                             /* push edi */
            ii(0x1018_166a, 1); pushd(ebp);                             /* push ebp */
            ii(0x1018_166b, 3); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1018_166e, 2); mov(ebp, edx);                          /* mov ebp, edx */
            ii(0x1018_1670, 3); mov(memd_a32[ss, esp], ebx);            /* mov [esp], ebx */
            ii(0x1018_1673, 5); mov(ebx, 0x10);                         /* mov ebx, 0x10 */
            ii(0x1018_1678, 2); mov(edi, ebp);                          /* mov edi, ebp */
            ii(0x1018_167a, 5); calld(/* sys */ 0x1017_93f8, -0x8287);  /* call 0x101793f8 */
            ii(0x1018_167f, 1); pushd(es);                              /* push es */
            ii(0x1018_1680, 2); mov(eax, ds);                           /* mov eax, ds */
            ii(0x1018_1682, 2); mov(es, eax);                           /* mov es, eax */
            ii(0x1018_1684, 2); sub(ecx, ecx);                          /* sub ecx, ecx */
            ii(0x1018_1686, 1); dec(ecx);                               /* dec ecx */
            ii(0x1018_1687, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_1689, 2); repne_a32(() => scasb_a32());           /* repne scasb */
            ii(0x1018_168b, 2); not(ecx);                               /* not ecx */
            ii(0x1018_168d, 1); dec(ecx);                               /* dec ecx */
            ii(0x1018_168e, 1); popd(es);                               /* pop es */
            ii(0x1018_168f, 3); mov(eax, memd_a32[ss, esp]);            /* mov eax, [esp] */
            ii(0x1018_1692, 2); mov(esi, ebp);                          /* mov esi, ebp */
            ii(0x1018_1694, 1); dec(eax);                               /* dec eax */
            ii(0x1018_1695, 3); lea(edx, ecx + ebp);                    /* lea edx, [ecx+ebp] */
            ii(0x1018_1698, 3); lea(ebx, eax + ebp);                    /* lea ebx, [eax+ebp] */
            ii(0x1018_169b, 2); jmpd(0x1018_16a4, 0x7); goto l_0x1018_16a4; /* jmp 0x101816a4 */
        l_0x1018_169d:
            ii(0x1018_169d, 1); dec(edx);                               /* dec edx */
            ii(0x1018_169e, 2); mov(cl, memb_a32[ds, edx]);             /* mov cl, [edx] */
            ii(0x1018_16a0, 1); dec(eax);                               /* dec eax */
            ii(0x1018_16a1, 2); mov(memb_a32[ds, ebx], cl);             /* mov [ebx], cl */
            ii(0x1018_16a3, 1); dec(ebx);                               /* dec ebx */
        l_0x1018_16a4:
            ii(0x1018_16a4, 2); cmp(edx, esi);                          /* cmp edx, esi */
            ii(0x1018_16a6, 2); if(jnzd(0x1018_169d, -0xb)) goto l_0x1018_169d; /* jnz 0x1018169d */
            ii(0x1018_16a8, 3); lea(edx, eax + ebp);                    /* lea edx, [eax+ebp] */
        l_0x1018_16ab:
            ii(0x1018_16ab, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1018_16ad, 2); if(jld(0x1018_16b6, 0x7)) goto l_0x1018_16b6; /* jl 0x101816b6 */
            ii(0x1018_16af, 1); dec(eax);                               /* dec eax */
            ii(0x1018_16b0, 3); mov(memb_a32[ds, edx], 0x30);           /* mov byte [edx], 0x30 */
            ii(0x1018_16b3, 1); dec(edx);                               /* dec edx */
            ii(0x1018_16b4, 2); jmpd(0x1018_16ab, -0xb); goto l_0x1018_16ab; /* jmp 0x101816ab */
        l_0x1018_16b6:
            ii(0x1018_16b6, 3); add(ebp, memd_a32[ss, esp]);            /* add ebp, [esp] */
            ii(0x1018_16b9, 4); mov(memb_a32[ss, ebp + 0], 0);          /* mov byte [ebp], 0x0 */
            ii(0x1018_16bd, 3); add(esp, 0x4);                          /* add esp, 0x4 */
            ii(0x1018_16c0, 1); popd(ebp);                              /* pop ebp */
            ii(0x1018_16c1, 1); popd(edi);                              /* pop edi */
            ii(0x1018_16c2, 1); popd(esi);                              /* pop esi */
            ii(0x1018_16c3, 1); popd(ecx);                              /* pop ecx */
            ii(0x1018_16c4, 1); retd(); return;                         /* ret */
        }
    }
}
