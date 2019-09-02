using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_aab0-83dd024c")]
        public void /* sys */ Method_1017_aab0()
        {
            ii(0x1017_aab0, 1); push(ebp);                              /* push ebp */
            ii(0x1017_aab1, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1017_aab3, 1); push(esi);                              /* push esi */
            ii(0x1017_aab4, 1); push(edi);                              /* push edi */
            ii(0x1017_aab5, 3); sub(esp, 0x40);                         /* sub esp, 0x40 */
            ii(0x1017_aab8, 3); mov(memd[ss, ebp - 0x34], eax);         /* mov [ebp-0x34], eax */
            ii(0x1017_aabb, 2); mov(esi, edx);                          /* mov esi, edx */
            ii(0x1017_aabd, 3); mov(memd[ss, ebp - 0x40], ebx);         /* mov [ebp-0x40], ebx */
            ii(0x1017_aac0, 3); mov(memd[ss, ebp - 0x30], ecx);         /* mov [ebp-0x30], ecx */
            ii(0x1017_aac3, 7); mov(memd[ss, ebp - 0x44], 0x1020_9750); /* mov dword [ebp-0x44], 0x10209750 */
            ii(0x1017_aaca, 2); test(esi, esi);                         /* test esi, esi */
            ii(0x1017_aacc, 6); if(jle(0x1017_ab7c, 0xaa)) goto l_0x1017_ab7c; /* jle 0x1017ab7c */
            ii(0x1017_aad2, 3); imul(edx, ebx, 0);                      /* imul edx, ebx, 0x0 */
            ii(0x1017_aad5, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1017_aad7, 1); dec(eax);                               /* dec eax */
            ii(0x1017_aad8, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
            ii(0x1017_aadb, 7); lea(eax, memd[ds, ebx * 4]);            /* lea eax, [ebx*4] */
            ii(0x1017_aae2, 3); lea(edi, memd[ds, ebx - 1]);            /* lea edi, [ebx-0x1] */
            ii(0x1017_aae5, 2); sub(eax, ebx);                          /* sub eax, ebx */
            ii(0x1017_aae7, 3); mov(ebx, memd[ss, ebp - 0x34]);         /* mov ebx, [ebp-0x34] */
            ii(0x1017_aaea, 3); mov(memd[ss, ebp - 0x2c], eax);         /* mov [ebp-0x2c], eax */
            ii(0x1017_aaed, 7); lea(eax, memd[ds, ebx * 4]);            /* lea eax, [ebx*4] */
            ii(0x1017_aaf4, 2); sub(eax, ebx);                          /* sub eax, ebx */
            ii(0x1017_aaf6, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1017_aaf8, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1017_aafa, 3); mov(memd[ss, ebp - 0x3c], edx);         /* mov [ebp-0x3c], edx */
            ii(0x1017_aafd, 3); shl(eax, 6);                            /* shl eax, 0x6 */
            ii(0x1017_ab00, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1017_ab02, 2); sub(eax, esi);                          /* sub eax, esi */
            ii(0x1017_ab04, 3); mov(memd[ss, ebp - 0xc], edx);          /* mov [ebp-0xc], edx */
            ii(0x1017_ab07, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
        l_0x1017_ab0a:
            ii(0x1017_ab0a, 4); cmp(memd[ss, ebp - 0x40], 0);           /* cmp dword [ebp-0x40], 0x0 */
            ii(0x1017_ab0e, 2); if(jle(0x1017_ab61, 0x51)) goto l_0x1017_ab61; /* jle 0x1017ab61 */
            ii(0x1017_ab10, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1017_ab13, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1017_ab15, 3); mov(ecx, memd[ss, ebp - 0x24]);         /* mov ecx, [ebp-0x24] */
            ii(0x1017_ab18, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1017_ab1b, 2); idiv(ecx);                              /* idiv ecx */
            ii(0x1017_ab1d, 3); mov(esi, memd[ss, ebp - 0x3c]);         /* mov esi, [ebp-0x3c] */
            ii(0x1017_ab20, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1017_ab22, 5); mov(ecx, 0x1020_9750);                  /* mov ecx, 0x10209750 */
            ii(0x1017_ab27, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x1017_ab2a, 3); mov(eax, memd[ss, ebp - 0x40]);         /* mov eax, [ebp-0x40] */
            ii(0x1017_ab2d, 2); add(ecx, esi);                          /* add ecx, esi */
            ii(0x1017_ab2f, 3); imul(esi, eax, 0x3f);                   /* imul esi, eax, 0x3f */
        l_0x1017_ab32:
            ii(0x1017_ab32, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x1017_ab34, 3); mov(al, memb[ss, ebp - 0x20]);          /* mov al, [ebp-0x20] */
            ii(0x1017_ab37, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1017_ab3a, 2); mov(memb[ds, ecx], al);                 /* mov [ecx], al */
            ii(0x1017_ab3c, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1017_ab3e, 2); idiv(edi);                              /* idiv edi */
            ii(0x1017_ab40, 3); lea(edx, memd[ds, eax + eax * 4]);      /* lea edx, [eax+eax*4] */
            ii(0x1017_ab43, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1017_ab45, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1017_ab48, 3); shl(edx, 3);                            /* shl edx, 0x3 */
            ii(0x1017_ab4b, 2); sbb(eax, edx);                          /* sbb eax, edx */
            ii(0x1017_ab4d, 3); sar(eax, 3);                            /* sar eax, 0x3 */
            ii(0x1017_ab50, 3); add(ecx, 3);                            /* add ecx, 0x3 */
            ii(0x1017_ab53, 4); mov(memb[ds, ecx - 2], 0);              /* mov byte [ecx-0x2], 0x0 */
            ii(0x1017_ab57, 3); add(ebx, 0x3f);                         /* add ebx, 0x3f */
            ii(0x1017_ab5a, 3); mov(memb[ds, ecx - 1], al);             /* mov [ecx-0x1], al */
            ii(0x1017_ab5d, 2); cmp(ebx, esi);                          /* cmp ebx, esi */
            ii(0x1017_ab5f, 2); if(jl(0x1017_ab32, -0x2f)) goto l_0x1017_ab32; /* jl 0x1017ab32 */
        l_0x1017_ab61:
            ii(0x1017_ab61, 3); mov(eax, memd[ss, ebp - 0x2c]);         /* mov eax, [ebp-0x2c] */
            ii(0x1017_ab64, 3); mov(ebx, memd[ss, ebp - 0x3c]);         /* mov ebx, [ebp-0x3c] */
            ii(0x1017_ab67, 3); mov(ecx, memd[ss, ebp - 0xc]);          /* mov ecx, [ebp-0xc] */
            ii(0x1017_ab6a, 3); mov(esi, memd[ss, ebp - 0x1c]);         /* mov esi, [ebp-0x1c] */
            ii(0x1017_ab6d, 2); add(ebx, eax);                          /* add ebx, eax */
            ii(0x1017_ab6f, 3); add(ecx, 0x3f);                         /* add ecx, 0x3f */
            ii(0x1017_ab72, 3); mov(memd[ss, ebp - 0x3c], ebx);         /* mov [ebp-0x3c], ebx */
            ii(0x1017_ab75, 3); mov(memd[ss, ebp - 0xc], ecx);          /* mov [ebp-0xc], ecx */
            ii(0x1017_ab78, 2); cmp(ecx, esi);                          /* cmp ecx, esi */
            ii(0x1017_ab7a, 2); if(jl(0x1017_ab0a, -0x72)) goto l_0x1017_ab0a; /* jl 0x1017ab0a */
        l_0x1017_ab7c:
            ii(0x1017_ab7c, 3); mov(edi, memd[ss, ebp + 8]);            /* mov edi, [ebp+0x8] */
            ii(0x1017_ab7f, 2); test(edi, edi);                         /* test edi, edi */
            ii(0x1017_ab81, 6); if(jle(0x1017_ac34, 0xad)) goto l_0x1017_ac34; /* jle 0x1017ac34 */
            ii(0x1017_ab87, 3); lea(eax, memd[ds, edi - 1]);            /* lea eax, [edi-0x1] */
            ii(0x1017_ab8a, 3); mov(edx, memd[ss, ebp + 0xc]);          /* mov edx, [ebp+0xc] */
            ii(0x1017_ab8d, 3); mov(memd[ss, ebp - 0x28], eax);         /* mov [ebp-0x28], eax */
            ii(0x1017_ab90, 7); lea(eax, memd[ds, edx * 4]);            /* lea eax, [edx*4] */
            ii(0x1017_ab97, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1017_ab99, 3); imul(edx, edx, 0);                      /* imul edx, edx, 0x0 */
            ii(0x1017_ab9c, 3); mov(ebx, memd[ss, ebp - 0x30]);         /* mov ebx, [ebp-0x30] */
            ii(0x1017_ab9f, 3); mov(memd[ss, ebp - 0x48], eax);         /* mov [ebp-0x48], eax */
            ii(0x1017_aba2, 7); lea(eax, memd[ds, ebx * 4]);            /* lea eax, [ebx*4] */
            ii(0x1017_aba9, 2); sub(eax, ebx);                          /* sub eax, ebx */
            ii(0x1017_abab, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1017_abad, 3); mov(memd[ss, ebp - 0x14], edx);         /* mov [ebp-0x14], edx */
            ii(0x1017_abb0, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1017_abb2, 3); mov(edx, memd[ss, ebp + 8]);            /* mov edx, [ebp+0x8] */
            ii(0x1017_abb5, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1017_abb8, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1017_abba, 3); shl(eax, 6);                            /* shl eax, 0x6 */
            ii(0x1017_abbd, 3); mov(edi, memd[ss, ebp + 0xc]);          /* mov edi, [ebp+0xc] */
            ii(0x1017_abc0, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1017_abc2, 1); dec(edi);                               /* dec edi */
            ii(0x1017_abc3, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
        l_0x1017_abc6:
            ii(0x1017_abc6, 4); cmp(memd[ss, ebp + 0xc], 0);            /* cmp dword [ebp+0xc], 0x0 */
            ii(0x1017_abca, 2); if(jle(0x1017_ac19, 0x4d)) goto l_0x1017_ac19; /* jle 0x1017ac19 */
            ii(0x1017_abcc, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1017_abcf, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1017_abd1, 3); mov(ebx, memd[ss, ebp - 0x28]);         /* mov ebx, [ebp-0x28] */
            ii(0x1017_abd4, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1017_abd7, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1017_abd9, 3); mov(ecx, memd[ss, ebp - 0x44]);         /* mov ecx, [ebp-0x44] */
            ii(0x1017_abdc, 3); add(ecx, memd[ss, ebp - 0x14]);         /* add ecx, [ebp-0x14] */
            ii(0x1017_abdf, 3); mov(memd[ss, ebp - 0x38], eax);         /* mov [ebp-0x38], eax */
            ii(0x1017_abe2, 3); mov(eax, memd[ss, ebp + 0xc]);          /* mov eax, [ebp+0xc] */
            ii(0x1017_abe5, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1017_abe7, 3); imul(esi, eax, 0x3f);                   /* imul esi, eax, 0x3f */
        l_0x1017_abea:
            ii(0x1017_abea, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x1017_abec, 3); mov(al, memb[ss, ebp - 0x38]);          /* mov al, [ebp-0x38] */
            ii(0x1017_abef, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1017_abf2, 3); mov(memb[ds, ecx + 1], al);             /* mov [ecx+0x1], al */
            ii(0x1017_abf5, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1017_abf7, 2); idiv(edi);                              /* idiv edi */
            ii(0x1017_abf9, 3); lea(edx, memd[ds, eax + eax * 4]);      /* lea edx, [eax+eax*4] */
            ii(0x1017_abfc, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1017_abfe, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1017_ac01, 3); shl(edx, 3);                            /* shl edx, 0x3 */
            ii(0x1017_ac04, 2); sbb(eax, edx);                          /* sbb eax, edx */
            ii(0x1017_ac06, 3); sar(eax, 3);                            /* sar eax, 0x3 */
            ii(0x1017_ac09, 3); mov(memb[ds, ecx], 0);                  /* mov byte [ecx], 0x0 */
            ii(0x1017_ac0c, 3); add(ecx, 3);                            /* add ecx, 0x3 */
            ii(0x1017_ac0f, 3); add(ebx, 0x3f);                         /* add ebx, 0x3f */
            ii(0x1017_ac12, 3); mov(memb[ds, ecx - 1], al);             /* mov [ecx-0x1], al */
            ii(0x1017_ac15, 2); cmp(ebx, esi);                          /* cmp ebx, esi */
            ii(0x1017_ac17, 2); if(jl(0x1017_abea, -0x2f)) goto l_0x1017_abea; /* jl 0x1017abea */
        l_0x1017_ac19:
            ii(0x1017_ac19, 3); mov(eax, memd[ss, ebp - 0x48]);         /* mov eax, [ebp-0x48] */
            ii(0x1017_ac1c, 3); mov(edx, memd[ss, ebp - 0x14]);         /* mov edx, [ebp-0x14] */
            ii(0x1017_ac1f, 3); mov(ebx, memd[ss, ebp - 0x10]);         /* mov ebx, [ebp-0x10] */
            ii(0x1017_ac22, 3); mov(ecx, memd[ss, ebp - 0x18]);         /* mov ecx, [ebp-0x18] */
            ii(0x1017_ac25, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1017_ac27, 3); add(ebx, 0x3f);                         /* add ebx, 0x3f */
            ii(0x1017_ac2a, 3); mov(memd[ss, ebp - 0x14], edx);         /* mov [ebp-0x14], edx */
            ii(0x1017_ac2d, 3); mov(memd[ss, ebp - 0x10], ebx);         /* mov [ebp-0x10], ebx */
            ii(0x1017_ac30, 2); cmp(ebx, ecx);                          /* cmp ebx, ecx */
            ii(0x1017_ac32, 2); if(jl(0x1017_abc6, -0x6e)) goto l_0x1017_abc6; /* jl 0x1017abc6 */
        l_0x1017_ac34:
            ii(0x1017_ac34, 3); lea(esp, memd[ss, ebp - 8]);            /* lea esp, [ebp-0x8] */
            ii(0x1017_ac37, 1); pop(edi);                               /* pop edi */
            ii(0x1017_ac38, 1); pop(esi);                               /* pop esi */
            ii(0x1017_ac39, 1); pop(ebp);                               /* pop ebp */
            ii(0x1017_ac3a, 3); ret(8);                                 /* ret 0x8 */
        }
    }
}
