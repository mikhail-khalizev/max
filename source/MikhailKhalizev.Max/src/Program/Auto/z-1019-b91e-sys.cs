using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_b91e-4c8fbe5e")]
        public void /* sys */ Method_1019_b91e()
        {
            ii(0x1019_b91e, 1); push(ebp);                              /* push ebp */
            ii(0x1019_b91f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1019_b921, 1); push(ecx);                              /* push ecx */
            ii(0x1019_b922, 1); push(esi);                              /* push esi */
            ii(0x1019_b923, 1); push(edi);                              /* push edi */
            ii(0x1019_b924, 3); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1019_b927, 2); mov(edi, eax);                          /* mov edi, eax */
            ii(0x1019_b929, 2); mov(esi, edx);                          /* mov esi, edx */
            ii(0x1019_b92b, 2); cmp(edx, ebx);                          /* cmp edx, ebx */
            ii(0x1019_b92d, 2); if(jz(0x1019_b987, 0x58)) goto l_0x1019_b987; /* jz 0x1019b987 */
            ii(0x1019_b92f, 3); mov(memd[ss, ebp - 0x14], edi);         /* mov [ebp-0x14], edi */
            ii(0x1019_b932, 3); mov(al, memb[ds, eax + 0x1]);           /* mov al, [eax+0x1] */
            ii(0x1019_b935, 3); lea(edx, memd[ds, ebx + edi]);          /* lea edx, [ebx+edi] */
            ii(0x1019_b938, 3); mov(memb[ss, ebp - 0x10], al);          /* mov [ebp-0x10], al */
            ii(0x1019_b93b, 3); lea(eax, memd[ds, esi + edi]);          /* lea eax, [esi+edi] */
        l_0x1019_b93e:
            ii(0x1019_b93e, 1); dec(eax);                               /* dec eax */
            ii(0x1019_b93f, 1); dec(edx);                               /* dec edx */
            ii(0x1019_b940, 2); mov(cl, memb[ds, eax]);                 /* mov cl, [eax] */
            ii(0x1019_b942, 1); dec(esi);                               /* dec esi */
            ii(0x1019_b943, 2); mov(memb[ds, edx], cl);                 /* mov [edx], cl */
            ii(0x1019_b945, 3); mov(ecx, memd[ss, ebp - 0x14]);         /* mov ecx, [ebp-0x14] */
            ii(0x1019_b948, 1); dec(ebx);                               /* dec ebx */
            ii(0x1019_b949, 2); cmp(eax, ecx);                          /* cmp eax, ecx */
            ii(0x1019_b94b, 2); if(jnz(0x1019_b93e, -0xf)) goto l_0x1019_b93e; /* jnz 0x1019b93e */
            ii(0x1019_b94d, 2); xor(eax, ecx);                          /* xor eax, ecx */
            ii(0x1019_b94f, 2); mov(al, memb[ds, edi]);                 /* mov al, [edi] */
            ii(0x1019_b951, 3); cmp(eax, 0x2e);                         /* cmp eax, 0x2e */
            ii(0x1019_b954, 2); if(jnz(0x1019_b95d, 0x7)) goto l_0x1019_b95d; /* jnz 0x1019b95d */
            ii(0x1019_b956, 1); dec(ebx);                               /* dec ebx */
            ii(0x1019_b957, 4); mov(memb[ds, edi + ebx], 0x30);         /* mov byte [edi+ebx], 0x30 */
            ii(0x1019_b95b, 2); jmp(0x1019_b97b, 0x1e); goto l_0x1019_b97b; /* jmp 0x1019b97b */
        l_0x1019_b95d:
            ii(0x1019_b95d, 3); cmp(eax, 0x2b);                         /* cmp eax, 0x2b */
            ii(0x1019_b960, 2); if(jz(0x1019_b967, 0x5)) goto l_0x1019_b967; /* jz 0x1019b967 */
            ii(0x1019_b962, 3); cmp(eax, 0x2d);                         /* cmp eax, 0x2d */
            ii(0x1019_b965, 2); if(jnz(0x1019_b97b, 0x14)) goto l_0x1019_b97b; /* jnz 0x1019b97b */
        l_0x1019_b967:
            ii(0x1019_b967, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1019_b969, 3); mov(al, memb[ss, ebp - 0x10]);          /* mov al, [ebp-0x10] */
            ii(0x1019_b96c, 3); cmp(eax, 0x2e);                         /* cmp eax, 0x2e */
            ii(0x1019_b96f, 2); if(jnz(0x1019_b97b, 0xa)) goto l_0x1019_b97b; /* jnz 0x1019b97b */
            ii(0x1019_b971, 4); mov(memb[ds, edi + ebx], 0x30);         /* mov byte [edi+ebx], 0x30 */
            ii(0x1019_b975, 1); dec(ebx);                               /* dec ebx */
            ii(0x1019_b976, 2); mov(dl, memb[ds, edi]);                 /* mov dl, [edi] */
            ii(0x1019_b978, 3); mov(memb[ds, edi + ebx], dl);           /* mov [edi+ebx], dl */
        l_0x1019_b97b:
            ii(0x1019_b97b, 5); mov(edx, 0x20);                         /* mov edx, 0x20 */
            ii(0x1019_b980, 2); mov(eax, edi);                          /* mov eax, edi */
            ii(0x1019_b982, 5); call(Definitions.sys_memset, -0x3_5ba7); /* call 0x10165de0 */
        l_0x1019_b987:
            ii(0x1019_b987, 3); lea(esp, memd[ss, ebp - 0xc]);          /* lea esp, [ebp-0xc] */
            ii(0x1019_b98a, 1); pop(edi);                               /* pop edi */
            ii(0x1019_b98b, 1); pop(esi);                               /* pop esi */
            ii(0x1019_b98c, 1); pop(ecx);                               /* pop ecx */
            ii(0x1019_b98d, 1); pop(ebp);                               /* pop ebp */
            ii(0x1019_b98e, 1); ret();                                  /* ret */
        }
    }
}
