using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("9d3c3b3a-f33a-46db-aa87-3bec38da0cff")]
        public void /* sys */ Method_1017_b140()
        {
            ii(0x1017_b140, 1); pushd(ebp);                             /* push ebp */
            ii(0x1017_b141, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1017_b143, 1); pushd(esi);                             /* push esi */
            ii(0x1017_b144, 1); pushd(edi);                             /* push edi */
            ii(0x1017_b145, 3); sub(esp, 0x30);                         /* sub esp, 0x30 */
            ii(0x1017_b148, 3); mov(memb_a32[ss, ebp - 0xc], al);       /* mov [ebp-0xc], al */
            ii(0x1017_b14b, 3); mov(memd_a32[ss, ebp - 0x14], edx);     /* mov [ebp-0x14], edx */
            ii(0x1017_b14e, 3); mov(esi, memd_a32[ss, ebp - 0x14]);     /* mov esi, [ebp-0x14] */
            ii(0x1017_b151, 3); mov(edi, memd_a32[ss, ebp + 0x14]);     /* mov edi, [ebp+0x14] */
            ii(0x1017_b154, 3); lea(eax, ebx - 0x1);                    /* lea eax, [ebx-0x1] */
            ii(0x1017_b157, 3); lea(ebx, ecx + 0x2);                    /* lea ebx, [ecx+0x2] */
            ii(0x1017_b15a, 3); sub(esi, 0x2);                          /* sub esi, 0x2 */
            ii(0x1017_b15d, 3); mov(memd_a32[ss, ebp - 0x1c], ebx);     /* mov [ebp-0x1c], ebx */
            ii(0x1017_b160, 2); mov(ebx, esi);                          /* mov ebx, esi */
            ii(0x1017_b162, 2); sub(ebx, edi);                          /* sub ebx, edi */
            ii(0x1017_b164, 3); mov(memd_a32[ss, ebp - 0x18], ebx);     /* mov [ebp-0x18], ebx */
            ii(0x1017_b167, 3); mov(bl, memb_a32[ss, ebp - 0x14]);      /* mov bl, [ebp-0x14] */
            ii(0x1017_b16a, 3); sub(bl, 0x2);                           /* sub bl, 0x2 */
            ii(0x1017_b16d, 3); mov(memb_a32[ss, ebp - 0x32], bl);      /* mov [ebp-0x32], bl */
            ii(0x1017_b170, 2); mov(ebx, ecx);                          /* mov ebx, ecx */
            ii(0x1017_b172, 6); and(ebx, 0x200);                        /* and ebx, 0x200 */
            ii(0x1017_b178, 3); shr(ebx, 0x2);                          /* shr ebx, 0x2 */
            ii(0x1017_b17b, 3); mov(memd_a32[ss, ebp - 0x10], ebx);     /* mov [ebp-0x10], ebx */
            ii(0x1017_b17e, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1017_b180, 6); and(ebx, 0x200);                        /* and ebx, 0x200 */
            ii(0x1017_b186, 3); mov(edi, memd_a32[ss, ebp - 0x10]);     /* mov edi, [ebp-0x10] */
            ii(0x1017_b189, 3); shr(ebx, 0x3);                          /* shr ebx, 0x3 */
            ii(0x1017_b18c, 2); or(ebx, edi);                           /* or ebx, edi */
            ii(0x1017_b18e, 2); mov(edi, esi);                          /* mov edi, esi */
            ii(0x1017_b190, 6); and(edi, 0x200);                        /* and edi, 0x200 */
            ii(0x1017_b196, 3); mov(edx, memd_a32[ss, ebp + 0x10]);     /* mov edx, [ebp+0x10] */
            ii(0x1017_b199, 3); shr(edi, 0x4);                          /* shr edi, 0x4 */
            ii(0x1017_b19c, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1017_b19e, 2); or(ebx, edi);                           /* or ebx, edi */
            ii(0x1017_b1a0, 2); mov(edi, edx);                          /* mov edi, edx */
            ii(0x1017_b1a2, 6); and(edi, 0x100);                        /* and edi, 0x100 */
            ii(0x1017_b1a8, 3); shr(edi, 0x5);                          /* shr edi, 0x5 */
            ii(0x1017_b1ab, 2); or(edi, ebx);                           /* or edi, ebx */
            ii(0x1017_b1ad, 2); mov(ebx, ecx);                          /* mov ebx, ecx */
            ii(0x1017_b1af, 3); mov(memb_a32[ss, ebp - 0x28], cl);      /* mov [ebp-0x28], cl */
            ii(0x1017_b1b2, 6); and(ebx, 0x100);                        /* and ebx, 0x100 */
            ii(0x1017_b1b8, 3); mov(memb_a32[ss, ebp - 0x26], al);      /* mov [ebp-0x26], al */
            ii(0x1017_b1bb, 3); shr(ebx, 0x6);                          /* shr ebx, 0x6 */
            ii(0x1017_b1be, 2); or(ebx, edi);                           /* or ebx, edi */
            ii(0x1017_b1c0, 2); mov(edi, eax);                          /* mov edi, eax */
            ii(0x1017_b1c2, 3); mov(ah, memb_a32[ss, ebp - 0x1c]);      /* mov ah, [ebp-0x1c] */
            ii(0x1017_b1c5, 6); and(edi, 0x100);                        /* and edi, 0x100 */
            ii(0x1017_b1cb, 3); mov(al, memb_a32[ss, ebp - 0x18]);      /* mov al, [ebp-0x18] */
            ii(0x1017_b1ce, 3); and(ah, 0xf);                           /* and ah, 0xf */
            ii(0x1017_b1d1, 3); mov(memb_a32[ss, ebp - 0x22], al);      /* mov [ebp-0x22], al */
            ii(0x1017_b1d4, 3); shr(edi, 0x7);                          /* shr edi, 0x7 */
            ii(0x1017_b1d7, 3); mov(memb_a32[ss, ebp - 0x27], ah);      /* mov [ebp-0x27], ah */
            ii(0x1017_b1da, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x1017_b1dd, 2); or(edi, ebx);                           /* or edi, ebx */
            ii(0x1017_b1df, 2); mov(ebx, esi);                          /* mov ebx, esi */
            ii(0x1017_b1e1, 1); pushd(eax);                             /* push eax */
            ii(0x1017_b1e2, 6); and(ebx, 0x100);                        /* and ebx, 0x100 */
            ii(0x1017_b1e8, 3); shr(ebx, 0x8);                          /* shr ebx, 0x8 */
            ii(0x1017_b1eb, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1017_b1ed, 2); or(ebx, edi);                           /* or ebx, edi */
            ii(0x1017_b1ef, 3); mov(esi, memd_a32[ss, ebp + 0x8]);      /* mov esi, [ebp+0x8] */
            ii(0x1017_b1f2, 3); mov(memb_a32[ss, ebp - 0x31], bl);      /* mov [ebp-0x31], bl */
            ii(0x1017_b1f5, 2); mov(ebx, edx);                          /* mov ebx, edx */
            ii(0x1017_b1f7, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x1017_b1fa, 6); and(ebx, 0x200);                        /* and ebx, 0x200 */
            ii(0x1017_b200, 3); shl(esi, 0x7);                          /* shl esi, 0x7 */
            ii(0x1017_b203, 3); shr(ebx, 0x4);                          /* shr ebx, 0x4 */
            ii(0x1017_b206, 3); mov(edi, memd_a32[ss, ebp + 0xc]);      /* mov edi, [ebp+0xc] */
            ii(0x1017_b209, 2); or(ebx, esi);                           /* or ebx, esi */
            ii(0x1017_b20b, 1); pushd(eax);                             /* push eax */
            ii(0x1017_b20c, 2); or(ebx, edi);                           /* or ebx, edi */
            ii(0x1017_b20e, 3); mov(memb_a32[ss, ebp - 0x23], dl);      /* mov [ebp-0x23], dl */
            ii(0x1017_b211, 3); mov(memb_a32[ss, ebp - 0x2f], bl);      /* mov [ebp-0x2f], bl */
            ii(0x1017_b214, 5); calld(/* sys */ 0x1019_4286, 0x1_906d); /* call 0x10194286 */
            ii(0x1017_b219, 3); add(esp, 0x8);                          /* add esp, 0x8 */
            ii(0x1017_b21c, 3); lea(esp, ebp - 0x8);                    /* lea esp, [ebp-0x8] */
            ii(0x1017_b21f, 1); popd(edi);                              /* pop edi */
            ii(0x1017_b220, 1); popd(esi);                              /* pop esi */
            ii(0x1017_b221, 1); popd(ebp);                              /* pop ebp */
            ii(0x1017_b222, 3); retd(0x10); return;                     /* ret 0x10 */
        }
    }
}
