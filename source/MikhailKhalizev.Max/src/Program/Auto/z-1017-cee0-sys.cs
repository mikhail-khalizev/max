using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("4181d4f4-5279-48c5-8791-ec943dbc1939")]
        public void /* sys */ Method_1017_cee0()
        {
            ii(0x1017_cee0, 1); pushd(ecx);                             /* push ecx */
            ii(0x1017_cee1, 1); pushd(edx);                             /* push edx */
            ii(0x1017_cee2, 1); pushd(esi);                             /* push esi */
            ii(0x1017_cee3, 1); pushd(edi);                             /* push edi */
            ii(0x1017_cee4, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x1017_cee6, 2); mov(edi, eax);                          /* mov edi, eax */
            ii(0x1017_cee8, 1); pushd(es);                              /* push es */
            ii(0x1017_cee9, 2); mov(eax, ds);                           /* mov eax, ds */
            ii(0x1017_ceeb, 2); mov(es, eax);                           /* mov es, eax */
            ii(0x1017_ceed, 2); sub(ecx, ecx);                          /* sub ecx, ecx */
            ii(0x1017_ceef, 1); dec(ecx);                               /* dec ecx */
            ii(0x1017_cef0, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1017_cef2, 2); repne_a32(() => scasb_a32());           /* repne scasb */
            ii(0x1017_cef4, 2); not(ecx);                               /* not ecx */
            ii(0x1017_cef6, 1); dec(ecx);                               /* dec ecx */
            ii(0x1017_cef7, 1); popd(es);                               /* pop es */
            ii(0x1017_cef8, 1); inc(ecx);                               /* inc ecx */
            ii(0x1017_cef9, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1017_cefb, 5); calld(Definitions.sys_malloc, -0x1_1f22); /* call 0x1016afde */
            ii(0x1017_cf00, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1017_cf02, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1017_cf04, 2); if(jzd(0x1017_cf1e, 0x18)) goto l_0x1017_cf1e; /* jz 0x1017cf1e */
            ii(0x1017_cf06, 2); mov(edi, eax);                          /* mov edi, eax */
            ii(0x1017_cf08, 1); pushd(es);                              /* push es */
            ii(0x1017_cf09, 2); mov(eax, ds);                           /* mov eax, ds */
            ii(0x1017_cf0b, 2); mov(es, eax);                           /* mov es, eax */
            ii(0x1017_cf0d, 1); pushd(edi);                             /* push edi */
            ii(0x1017_cf0e, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1017_cf10, 3); shr(ecx, 0x2);                          /* shr ecx, 0x2 */
            ii(0x1017_cf13, 2); repne_a32(() => movsd_a32());           /* repne movsd */
            ii(0x1017_cf15, 2); mov(cl, al);                            /* mov cl, al */
            ii(0x1017_cf17, 3); and(cl, 0x3);                           /* and cl, 0x3 */
            ii(0x1017_cf1a, 2); repne_a32(() => movsb_a32());           /* repne movsb */
            ii(0x1017_cf1c, 1); popd(edi);                              /* pop edi */
            ii(0x1017_cf1d, 1); popd(es);                               /* pop es */
        l_0x1017_cf1e:
            ii(0x1017_cf1e, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1017_cf20, 1); popd(edi);                              /* pop edi */
            ii(0x1017_cf21, 1); popd(esi);                              /* pop esi */
            ii(0x1017_cf22, 1); popd(edx);                              /* pop edx */
            ii(0x1017_cf23, 1); popd(ecx);                              /* pop ecx */
            ii(0x1017_cf24, 1); retd(); return;                         /* ret */
        }
    }
}
