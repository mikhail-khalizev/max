using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_af8c-dce203c")]
        public void /* sys */ Method_1016_af8c()
        {
            ii(0x1016_af8c, 1); push(esi);                              /* push esi */
            ii(0x1016_af8d, 1); push(edi);                              /* push edi */
            ii(0x1016_af8e, 1); push(ebp);                              /* push ebp */
            ii(0x1016_af8f, 3); sub(esp, 4);                            /* sub esp, 0x4 */
            ii(0x1016_af92, 2); mov(esi, edx);                          /* mov esi, edx */
            ii(0x1016_af94, 2); mov(ebp, ebx);                          /* mov ebp, ebx */
            ii(0x1016_af96, 2); mov(edx, ecx);                          /* mov edx, ecx */
            ii(0x1016_af98, 4); mov(ecx, memd[ss, esp + 24]);           /* mov ecx, [esp+0x18] */
            ii(0x1016_af9c, 2); xor(edi, edi);                          /* xor edi, edi */
            ii(0x1016_af9e, 2); test(ebx, ebx);                         /* test ebx, ebx */
            ii(0x1016_afa0, 2); if(jle(0x1016_afd5, 0x33)) goto l_0x1016_afd5; /* jle 0x1016afd5 */
            ii(0x1016_afa2, 2); sub(edx, esi);                          /* sub edx, esi */
            ii(0x1016_afa4, 3); mov(memd[ss, esp], edx);                /* mov [esp], edx */
        l_0x1016_afa7:
            ii(0x1016_afa7, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_afa9, 2); test(esi, esi);                         /* test esi, esi */
            ii(0x1016_afab, 2); if(jle(0x1016_afcb, 0x1e)) goto l_0x1016_afcb; /* jle 0x1016afcb */
        l_0x1016_afad:
            ii(0x1016_afad, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1016_afaf, 2); mov(bl, memb[ds, eax]);                 /* mov bl, [eax] */
            ii(0x1016_afb1, 4); cmp(ebx, memd[ss, esp + 20]);           /* cmp ebx, [esp+0x14] */
            ii(0x1016_afb5, 2); if(jnz(0x1016_afbb, 4)) goto l_0x1016_afbb; /* jnz 0x1016afbb */
            ii(0x1016_afb7, 2); mov(memb[ds, eax], cl);                 /* mov [eax], cl */
            ii(0x1016_afb9, 2); jmp(0x1016_afc5, 0xa); goto l_0x1016_afc5; /* jmp 0x1016afc5 */
        l_0x1016_afbb:
            ii(0x1016_afbb, 2); cmp(ebx, ecx);                          /* cmp ebx, ecx */
            ii(0x1016_afbd, 2); if(jnz(0x1016_afc5, 6)) goto l_0x1016_afc5; /* jnz 0x1016afc5 */
            ii(0x1016_afbf, 4); mov(bl, memb[ss, esp + 20]);            /* mov bl, [esp+0x14] */
            ii(0x1016_afc3, 2); mov(memb[ds, eax], bl);                 /* mov [eax], bl */
        l_0x1016_afc5:
            ii(0x1016_afc5, 1); inc(edx);                               /* inc edx */
            ii(0x1016_afc6, 1); inc(eax);                               /* inc eax */
            ii(0x1016_afc7, 2); cmp(edx, esi);                          /* cmp edx, esi */
            ii(0x1016_afc9, 2); if(jl(0x1016_afad, -0x1e)) goto l_0x1016_afad; /* jl 0x1016afad */
        l_0x1016_afcb:
            ii(0x1016_afcb, 3); mov(edx, memd[ss, esp]);                /* mov edx, [esp] */
            ii(0x1016_afce, 1); inc(edi);                               /* inc edi */
            ii(0x1016_afcf, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1016_afd1, 2); cmp(edi, ebp);                          /* cmp edi, ebp */
            ii(0x1016_afd3, 2); if(jl(0x1016_afa7, -0x2e)) goto l_0x1016_afa7; /* jl 0x1016afa7 */
        l_0x1016_afd5:
            ii(0x1016_afd5, 3); add(esp, 4);                            /* add esp, 0x4 */
            ii(0x1016_afd8, 1); pop(ebp);                               /* pop ebp */
            ii(0x1016_afd9, 1); pop(edi);                               /* pop edi */
            ii(0x1016_afda, 1); pop(esi);                               /* pop esi */
            ii(0x1016_afdb, 3); ret(8);                                 /* ret 0x8 */
        }
    }
}
