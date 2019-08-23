using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_a850-a700b16d")]
        public void /* sys */ Method_1017_a850()
        {
            ii(0x1017_a850, 1); push(ebp);                              /* push ebp */
            ii(0x1017_a851, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1017_a853, 1); push(esi);                              /* push esi */
            ii(0x1017_a854, 1); push(edi);                              /* push edi */
            ii(0x1017_a855, 3); mov(ebx, memd[ss, ebp + 0x8]);          /* mov ebx, [ebp+0x8] */
            ii(0x1017_a858, 3); mov(edx, memd[ss, ebp + 0x10]);         /* mov edx, [ebp+0x10] */
            ii(0x1017_a85b, 3); mov(ecx, memd[ss, ebp + 0x1c]);         /* mov ecx, [ebp+0x1c] */
            ii(0x1017_a85e, 3); mov(eax, memd[ss, ebp + 0x20]);         /* mov eax, [ebp+0x20] */
            ii(0x1017_a861, 7); cmp(memd[ds, 0x1020_9c94], 0);          /* cmp dword [0x10209c94], 0x0 */
            ii(0x1017_a868, 2); if(jz(0x1017_a894, 0x2a)) goto l_0x1017_a894; /* jz 0x1017a894 */
            ii(0x1017_a86a, 6); mov(edi, memd[ds, 0x1020_9ccc]);        /* mov edi, [0x10209ccc] */
            ii(0x1017_a870, 2); test(edi, edi);                         /* test edi, edi */
            ii(0x1017_a872, 2); if(jnz(0x1017_a894, 0x20)) goto l_0x1017_a894; /* jnz 0x1017a894 */
            ii(0x1017_a874, 1); push(edi);                              /* push edi */
            ii(0x1017_a875, 3); mov(edi, memd[ss, ebp + 0x28]);         /* mov edi, [ebp+0x28] */
            ii(0x1017_a878, 1); push(edi);                              /* push edi */
            ii(0x1017_a879, 3); mov(esi, memd[ss, ebp + 0x24]);         /* mov esi, [ebp+0x24] */
            ii(0x1017_a87c, 1); push(esi);                              /* push esi */
            ii(0x1017_a87d, 1); push(eax);                              /* push eax */
            ii(0x1017_a87e, 1); push(ecx);                              /* push ecx */
            ii(0x1017_a87f, 3); mov(edi, memd[ss, ebp + 0x18]);         /* mov edi, [ebp+0x18] */
            ii(0x1017_a882, 1); push(edi);                              /* push edi */
            ii(0x1017_a883, 3); mov(eax, memd[ss, ebp + 0x14]);         /* mov eax, [ebp+0x14] */
            ii(0x1017_a886, 1); push(eax);                              /* push eax */
            ii(0x1017_a887, 1); push(edx);                              /* push edx */
            ii(0x1017_a888, 3); mov(edx, memd[ss, ebp + 0xc]);          /* mov edx, [ebp+0xc] */
            ii(0x1017_a88b, 1); push(edx);                              /* push edx */
            ii(0x1017_a88c, 1); push(ebx);                              /* push ebx */
            ii(0x1017_a88d, 5); call(/* sys */ 0x1019_3649, 0x1_8db7);  /* call 0x10193649 */
            ii(0x1017_a892, 2); jmp(0x1017_a8b3, 0x1f); goto l_0x1017_a8b3; /* jmp 0x1017a8b3 */
        l_0x1017_a894:
            ii(0x1017_a894, 2); push(0);                                /* push 0x0 */
            ii(0x1017_a896, 3); mov(esi, memd[ss, ebp + 0x28]);         /* mov esi, [ebp+0x28] */
            ii(0x1017_a899, 1); push(esi);                              /* push esi */
            ii(0x1017_a89a, 3); mov(edi, memd[ss, ebp + 0x24]);         /* mov edi, [ebp+0x24] */
            ii(0x1017_a89d, 1); push(edi);                              /* push edi */
            ii(0x1017_a89e, 1); push(eax);                              /* push eax */
            ii(0x1017_a89f, 1); push(ecx);                              /* push ecx */
            ii(0x1017_a8a0, 3); mov(eax, memd[ss, ebp + 0x18]);         /* mov eax, [ebp+0x18] */
            ii(0x1017_a8a3, 1); push(eax);                              /* push eax */
            ii(0x1017_a8a4, 3); mov(ecx, memd[ss, ebp + 0x14]);         /* mov ecx, [ebp+0x14] */
            ii(0x1017_a8a7, 1); push(ecx);                              /* push ecx */
            ii(0x1017_a8a8, 1); push(edx);                              /* push edx */
            ii(0x1017_a8a9, 3); mov(esi, memd[ss, ebp + 0xc]);          /* mov esi, [ebp+0xc] */
            ii(0x1017_a8ac, 1); push(esi);                              /* push esi */
            ii(0x1017_a8ad, 1); push(ebx);                              /* push ebx */
            ii(0x1017_a8ae, 5); call(/* sys */ 0x1019_33cd, 0x1_8b1a);  /* call 0x101933cd */
        l_0x1017_a8b3:
            ii(0x1017_a8b3, 3); add(esp, 0x28);                         /* add esp, 0x28 */
            ii(0x1017_a8b6, 3); lea(esp, memd[ss, ebp - 0x8]);          /* lea esp, [ebp-0x8] */
            ii(0x1017_a8b9, 1); pop(edi);                               /* pop edi */
            ii(0x1017_a8ba, 1); pop(esi);                               /* pop esi */
            ii(0x1017_a8bb, 1); pop(ebp);                               /* pop ebp */
            ii(0x1017_a8bc, 1); ret();                                  /* ret */
        }
    }
}
