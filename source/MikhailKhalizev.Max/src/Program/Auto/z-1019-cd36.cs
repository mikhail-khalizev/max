using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_cd36-60060eb9")]
        public void Method_1019_cd36()
        {
            ii(0x1019_cd36, 1); push(ebx);                              /* push ebx */
            ii(0x1019_cd37, 1); push(ecx);                              /* push ecx */
            ii(0x1019_cd38, 1); push(edx);                              /* push edx */
            ii(0x1019_cd39, 1); push(ebp);                              /* push ebp */
            ii(0x1019_cd3a, 1); push(esi);                              /* push esi */
            ii(0x1019_cd3b, 1); push(edx);                              /* push edx */
            ii(0x1019_cd3c, 2); mov(ebp, eax);                          /* mov ebp, eax */
            ii(0x1019_cd3e, 3); mov(ecx, memd[ss, ebp]);                /* mov ecx, [ebp] */
            ii(0x1019_cd41, 3); mov(ebx, memd[ss, ebp + 4]);            /* mov ebx, [ebp+0x4] */
            ii(0x1019_cd44, 2); mov(ebp, ebx);                          /* mov ebp, ebx */
            ii(0x1019_cd46, 6); and(ebp, 0xfff0_0000);                  /* and ebp, 0xfff00000 */
            ii(0x1019_cd4c, 2); xor(ebx, ebp);                          /* xor ebx, ebp */
            ii(0x1019_cd4e, 6); xor(ebx, 0x10_0000);                    /* xor ebx, 0x100000 */
            ii(0x1019_cd54, 3); shr(ebp, 0x14);                         /* shr ebp, 0x14 */
            ii(0x1019_cd57, 6); sub(ebp, 0x433);                        /* sub ebp, 0x433 */
            ii(0x1019_cd5d, 2); if(jz(0x1019_cd94, 0x35)) goto l_0x1019_cd94; /* jz 0x1019cd94 */
            ii(0x1019_cd5f, 2); if(jbe(0x1019_cd6a, 9)) goto l_0x1019_cd6a; /* jbe 0x1019cd6a */
        l_0x1019_cd61:
            ii(0x1019_cd61, 2); shl(ecx, 1);                            /* shl ecx, 1 */
            ii(0x1019_cd63, 2); rcl(ebx, 1);                            /* rcl ebx, 1 */
            ii(0x1019_cd65, 1); dec(ebp);                               /* dec ebp */
            ii(0x1019_cd66, 2); if(jnz(0x1019_cd61, -7)) goto l_0x1019_cd61; /* jnz 0x1019cd61 */
            ii(0x1019_cd68, 2); jmp(0x1019_cd94, 0x2a); goto l_0x1019_cd94; /* jmp 0x1019cd94 */
        l_0x1019_cd6a:
            ii(0x1019_cd6a, 2); sub(eax, eax);                          /* sub eax, eax */
            ii(0x1019_cd6c, 2); sub(esi, esi);                          /* sub esi, esi */
        l_0x1019_cd6e:
            ii(0x1019_cd6e, 2); shr(ebx, 1);                            /* shr ebx, 1 */
            ii(0x1019_cd70, 2); rcr(ecx, 1);                            /* rcr ecx, 1 */
            ii(0x1019_cd72, 2); rcr(eax, 1);                            /* rcr eax, 1 */
            ii(0x1019_cd74, 2); adc(esi, esi);                          /* adc esi, esi */
            ii(0x1019_cd76, 1); inc(ebp);                               /* inc ebp */
            ii(0x1019_cd77, 2); if(jnz(0x1019_cd6e, -0xb)) goto l_0x1019_cd6e; /* jnz 0x1019cd6e */
            ii(0x1019_cd79, 5); cmp(eax, 0x8000_0000);                  /* cmp eax, 0x80000000 */
            ii(0x1019_cd7e, 2); if(jb(0x1019_cd94, 0x14)) goto l_0x1019_cd94; /* jb 0x1019cd94 */
            ii(0x1019_cd80, 2); if(jnz(0x1019_cd8e, 0xc)) goto l_0x1019_cd8e; /* jnz 0x1019cd8e */
            ii(0x1019_cd82, 2); or(esi, esi);                           /* or esi, esi */
            ii(0x1019_cd84, 2); if(jnz(0x1019_cd8e, 8)) goto l_0x1019_cd8e; /* jnz 0x1019cd8e */
            ii(0x1019_cd86, 6); test(ecx, 1);                           /* test ecx, 0x1 */
            ii(0x1019_cd8c, 2); if(jz(0x1019_cd94, 6)) goto l_0x1019_cd94; /* jz 0x1019cd94 */
        l_0x1019_cd8e:
            ii(0x1019_cd8e, 3); add(ecx, 1);                            /* add ecx, 0x1 */
            ii(0x1019_cd91, 3); adc(ebx, 0);                            /* adc ebx, 0x0 */
        l_0x1019_cd94:
            ii(0x1019_cd94, 1); pop(ebp);                               /* pop ebp */
            ii(0x1019_cd95, 3); mov(memd[ss, ebp], ecx);                /* mov [ebp], ecx */
            ii(0x1019_cd98, 3); mov(memd[ss, ebp + 4], ebx);            /* mov [ebp+0x4], ebx */
            ii(0x1019_cd9b, 1); pop(esi);                               /* pop esi */
            ii(0x1019_cd9c, 1); pop(ebp);                               /* pop ebp */
            ii(0x1019_cd9d, 1); pop(edx);                               /* pop edx */
            ii(0x1019_cd9e, 1); pop(ecx);                               /* pop ecx */
            ii(0x1019_cd9f, 1); pop(ebx);                               /* pop ebx */
            ii(0x1019_cda0, 1); ret();                                  /* ret */
        }
    }
}
