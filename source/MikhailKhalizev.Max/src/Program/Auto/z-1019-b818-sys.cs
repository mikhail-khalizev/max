using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_b818-8558b660")]
        public void /* sys */ Method_1019_b818()
        {
            ii(0x1019_b818, 1); pushd(esi);                             /* push esi */
            ii(0x1019_b819, 1); pushd(edi);                             /* push edi */
            ii(0x1019_b81a, 1); pushd(ebp);                             /* push ebp */
            ii(0x1019_b81b, 3); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1019_b81e, 2); mov(edi, eax);                          /* mov edi, eax */
            ii(0x1019_b820, 2); mov(esi, edx);                          /* mov esi, edx */
            ii(0x1019_b822, 3); mov(memd_a32[ss, esp], ecx);            /* mov [esp], ecx */
            ii(0x1019_b825, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1019_b827, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1019_b829, 2); if(jged(0x1019_b831, 0x6)) goto l_0x1019_b831; /* jge 0x1019b831 */
            ii(0x1019_b82b, 2); mov(cl, 0x2d);                          /* mov cl, 0x2d */
            ii(0x1019_b82d, 2); neg(esi);                               /* neg esi */
            ii(0x1019_b82f, 2); jmpd(0x1019_b833, 0x2); goto l_0x1019_b833; /* jmp 0x1019b833 */
        l_0x1019_b831:
            ii(0x1019_b831, 2); mov(cl, 0x2b);                          /* mov cl, 0x2b */
        l_0x1019_b833:
            ii(0x1019_b833, 5); mov(ebx, 0x64);                         /* mov ebx, 0x64 */
            ii(0x1019_b838, 5); mov(edx, 0x3);                          /* mov edx, 0x3 */
            ii(0x1019_b83d, 2); cmp(esi, ebx);                          /* cmp esi, ebx */
            ii(0x1019_b83f, 2); if(jged(0x1019_b856, 0x15)) goto l_0x1019_b856; /* jge 0x1019b856 */
            ii(0x1019_b841, 5); mov(ebx, 0xa);                          /* mov ebx, 0xa */
            ii(0x1019_b846, 5); mov(edx, 0x2);                          /* mov edx, 0x2 */
            ii(0x1019_b84b, 2); cmp(esi, ebx);                          /* cmp esi, ebx */
            ii(0x1019_b84d, 2); if(jged(0x1019_b856, 0x7)) goto l_0x1019_b856; /* jge 0x1019b856 */
            ii(0x1019_b84f, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1019_b854, 2); mov(ebx, edx);                          /* mov ebx, edx */
        l_0x1019_b856:
            ii(0x1019_b856, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1019_b858, 2); if(jnzd(0x1019_b866, 0xc)) goto l_0x1019_b866; /* jnz 0x1019b866 */
            ii(0x1019_b85a, 5); mov(eax, 0x2);                          /* mov eax, 0x2 */
            ii(0x1019_b85f, 3); cmp(edx, 0x3);                          /* cmp edx, 0x3 */
            ii(0x1019_b862, 2); if(jnzd(0x1019_b866, 0x2)) goto l_0x1019_b866; /* jnz 0x1019b866 */
            ii(0x1019_b864, 2); mov(eax, edx);                          /* mov eax, edx */
        l_0x1019_b866:
            ii(0x1019_b866, 3); lea(ebp, eax + 0x1);                    /* lea ebp, [eax+0x1] */
            ii(0x1019_b869, 3); cmp(ebp, memd_a32[ss, esp]);            /* cmp ebp, [esp] */
            ii(0x1019_b86c, 2); if(jgd(0x1019_b8b2, 0x44)) goto l_0x1019_b8b2; /* jg 0x1019b8b2 */
            ii(0x1019_b86e, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1019_b870, 2); if(jgd(0x1019_b8af, 0x3d)) goto l_0x1019_b8af; /* jg 0x1019b8af */
            ii(0x1019_b872, 2); mov(memb_a32[ds, edi], cl);             /* mov [edi], cl */
        l_0x1019_b874:
            ii(0x1019_b874, 1); inc(edi);                               /* inc edi */
            ii(0x1019_b875, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x1019_b877, 2); if(jled(0x1019_b87f, 0x6)) goto l_0x1019_b87f; /* jle 0x1019b87f */
            ii(0x1019_b879, 1); dec(eax);                               /* dec eax */
            ii(0x1019_b87a, 3); mov(memb_a32[ds, edi], 0x30);           /* mov byte [edi], 0x30 */
            ii(0x1019_b87d, 2); jmpd(0x1019_b874, -0xb); goto l_0x1019_b874; /* jmp 0x1019b874 */
        l_0x1019_b87f:
            ii(0x1019_b87f, 2); mov(edx, esi);                          /* mov edx, esi */
            ii(0x1019_b881, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1019_b883, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1019_b886, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1019_b888, 2); mov(edx, esi);                          /* mov edx, esi */
            ii(0x1019_b88a, 3); add(eax, 0x30);                         /* add eax, 0x30 */
            ii(0x1019_b88d, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1019_b890, 2); mov(memb_a32[ds, edi], al);             /* mov [edi], al */
            ii(0x1019_b892, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1019_b894, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1019_b896, 2); mov(esi, edx);                          /* mov esi, edx */
            ii(0x1019_b898, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1019_b89a, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x1019_b89c, 5); mov(ebx, 0xa);                          /* mov ebx, 0xa */
            ii(0x1019_b8a1, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1019_b8a4, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1019_b8a6, 1); inc(edi);                               /* inc edi */
            ii(0x1019_b8a7, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1019_b8a9, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1019_b8ab, 2); if(jnzd(0x1019_b87f, -0x2e)) goto l_0x1019_b87f; /* jnz 0x1019b87f */
            ii(0x1019_b8ad, 2); jmpd(0x1019_b8b2, 0x3); goto l_0x1019_b8b2; /* jmp 0x1019b8b2 */
        l_0x1019_b8af:
            ii(0x1019_b8af, 3); lea(ebp, edx + 0x1);                    /* lea ebp, [edx+0x1] */
        l_0x1019_b8b2:
            ii(0x1019_b8b2, 2); mov(eax, ebp);                          /* mov eax, ebp */
            ii(0x1019_b8b4, 3); add(esp, 0x4);                          /* add esp, 0x4 */
            ii(0x1019_b8b7, 1); popd(ebp);                              /* pop ebp */
            ii(0x1019_b8b8, 1); popd(edi);                              /* pop edi */
        }
    }
}
