using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_abbc-2c4cf527")]
        public void /* sys */ Method_1016_abbc()
        {
            ii(0x1016_abbc, 1); push(ebx);                              /* push ebx */
            ii(0x1016_abbd, 1); push(esi);                              /* push esi */
            ii(0x1016_abbe, 1); push(edi);                              /* push edi */
            ii(0x1016_abbf, 1); push(ebp);                              /* push ebp */
            ii(0x1016_abc0, 3); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1016_abc3, 4); mov(edx, memd[ss, esp + 0x18]);         /* mov edx, [esp+0x18] */
            ii(0x1016_abc7, 4); mov(ebp, memd[ss, esp + 0x28]);         /* mov ebp, [esp+0x28] */
            ii(0x1016_abcb, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1016_abcd, 4); mov(ecx, memd[ss, esp + 0x20]);         /* mov ecx, [esp+0x20] */
            ii(0x1016_abd1, 3); mov(memd[ss, esp], ebx);                /* mov [esp], ebx */
            ii(0x1016_abd4, 2); test(ecx, ecx);                         /* test ecx, ecx */
            ii(0x1016_abd6, 2); if(jle(0x1016_ac1b, 0x43)) goto l_0x1016_ac1b; /* jle 0x1016ac1b */
        l_0x1016_abd8:
            ii(0x1016_abd8, 4); mov(ecx, memd[ss, esp + 0x1c]);         /* mov ecx, [esp+0x1c] */
            ii(0x1016_abdc, 2); mov(esi, edx);                          /* mov esi, edx */
            ii(0x1016_abde, 2); mov(edi, ebp);                          /* mov edi, ebp */
            ii(0x1016_abe0, 1); push(edi);                              /* push edi */
            ii(0x1016_abe1, 2); mov(ebx, ecx);                          /* mov ebx, ecx */
            ii(0x1016_abe3, 3); and(ebx, 0x3);                          /* and ebx, 0x3 */
            ii(0x1016_abe6, 6); test(ecx, 0xffff_fffc);                 /* test ecx, 0xfffffffc */
            ii(0x1016_abec, 2); if(jz(0x1016_abf3, 0x5)) goto l_0x1016_abf3; /* jz 0x1016abf3 */
            ii(0x1016_abee, 3); shr(ecx, 0x2);                          /* shr ecx, 0x2 */
            ii(0x1016_abf1, 2); rep(() => movsd());                     /* rep movsd */
        l_0x1016_abf3:
            ii(0x1016_abf3, 6); test(ebx, 0x7);                         /* test ebx, 0x7 */
            ii(0x1016_abf9, 2); if(jz(0x1016_abff, 0x4)) goto l_0x1016_abff; /* jz 0x1016abff */
            ii(0x1016_abfb, 2); mov(ecx, ebx);                          /* mov ecx, ebx */
            ii(0x1016_abfd, 2); rep(() => movsb());                     /* rep movsb */
        l_0x1016_abff:
            ii(0x1016_abff, 1); pop(edi);                               /* pop edi */
            ii(0x1016_ac00, 4); mov(esi, memd[ss, esp + 0x24]);         /* mov esi, [esp+0x24] */
            ii(0x1016_ac04, 4); mov(edi, memd[ss, esp + 0x2c]);         /* mov edi, [esp+0x2c] */
            ii(0x1016_ac08, 3); mov(eax, memd[ss, esp]);                /* mov eax, [esp] */
            ii(0x1016_ac0b, 4); mov(ebx, memd[ss, esp + 0x20]);         /* mov ebx, [esp+0x20] */
            ii(0x1016_ac0f, 1); inc(eax);                               /* inc eax */
            ii(0x1016_ac10, 2); add(edx, esi);                          /* add edx, esi */
            ii(0x1016_ac12, 2); add(ebp, edi);                          /* add ebp, edi */
            ii(0x1016_ac14, 3); mov(memd[ss, esp], eax);                /* mov [esp], eax */
            ii(0x1016_ac17, 2); cmp(eax, ebx);                          /* cmp eax, ebx */
            ii(0x1016_ac19, 2); if(jl(0x1016_abd8, -0x43)) goto l_0x1016_abd8; /* jl 0x1016abd8 */
        l_0x1016_ac1b:
            ii(0x1016_ac1b, 3); add(esp, 0x4);                          /* add esp, 0x4 */
            ii(0x1016_ac1e, 1); pop(ebp);                               /* pop ebp */
            ii(0x1016_ac1f, 1); pop(edi);                               /* pop edi */
            ii(0x1016_ac20, 1); pop(esi);                               /* pop esi */
            ii(0x1016_ac21, 1); pop(ebx);                               /* pop ebx */
            ii(0x1016_ac22, 1); ret();                                  /* ret */
        }
    }
}
