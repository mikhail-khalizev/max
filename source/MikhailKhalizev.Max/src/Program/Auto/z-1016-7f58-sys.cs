using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_7f58-437395ff")]
        public void /* sys */ Method_1016_7f58()
        {
            ii(0x1016_7f58, 1); push(ebx);                              /* push ebx */
            ii(0x1016_7f59, 1); push(ecx);                              /* push ecx */
            ii(0x1016_7f5a, 1); push(edx);                              /* push edx */
            ii(0x1016_7f5b, 1); push(esi);                              /* push esi */
            ii(0x1016_7f5c, 1); push(edi);                              /* push edi */
            ii(0x1016_7f5d, 1); push(ebp);                              /* push ebp */
            ii(0x1016_7f5e, 3); sub(esp, 4);                            /* sub esp, 0x4 */
            ii(0x1016_7f61, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x1016_7f63, 7); cmp(memd[ds, 0x101b_ddbc], 0);          /* cmp dword [0x101bddbc], 0x0 */
            ii(0x1016_7f6a, 2); if(jnz(0x1016_7f76, 0xa)) goto l_0x1016_7f76; /* jnz 0x10167f76 */
            ii(0x1016_7f6c, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1016_7f71, 5); jmp(0x1016_7fdd, 0x67); goto l_0x1016_7fdd; /* jmp 0x10167fdd */
        l_0x1016_7f76:
            ii(0x1016_7f76, 5); mov(eax, memd[ds, 0x101c_b2d8]);        /* mov eax, [0x101cb2d8] */
            ii(0x1016_7f7b, 1); dec(eax);                               /* dec eax */
            ii(0x1016_7f7c, 3); mov(memd[ss, esp], eax);                /* mov [esp], eax */
            ii(0x1016_7f7f, 3); cmp(eax, 1);                            /* cmp eax, 0x1 */
            ii(0x1016_7f82, 2); if(jl(0x1016_7fdb, 0x57)) goto l_0x1016_7fdb; /* jl 0x10167fdb */
            ii(0x1016_7f84, 7); lea(ebp, memd[ds, eax * 4]);            /* lea ebp, [eax*4] */
        l_0x1016_7f8b:
            ii(0x1016_7f8b, 6); mov(eax, memd[ss, ebp + 0x101c_b1fc]);  /* mov eax, [ebp+0x101cb1fc] */
            ii(0x1016_7f91, 4); cmp(memd[ds, eax + 60], 0);             /* cmp dword [eax+0x3c], 0x0 */
            ii(0x1016_7f95, 2); if(jz(0x1016_7fc0, 0x29)) goto l_0x1016_7fc0; /* jz 0x10167fc0 */
            ii(0x1016_7f97, 2); mov(edi, ebp);                          /* mov edi, ebp */
            ii(0x1016_7f99, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_7f9b, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1016_7f9d, 2); jmp(0x1016_7fb2, 0x13); goto l_0x1016_7fb2; /* jmp 0x10167fb2 */
        l_0x1016_7f9f:
            ii(0x1016_7f9f, 4); cmp(esi, memd[ds, ebx + eax + 40]);     /* cmp esi, [ebx+eax+0x28] */
            ii(0x1016_7fa3, 2); if(jnz(0x1016_7fae, 9)) goto l_0x1016_7fae; /* jnz 0x10167fae */
            ii(0x1016_7fa5, 5); call(/* sys */ 0x1018_4dd0, 0x1_ce26);  /* call 0x10184dd0 */
            ii(0x1016_7faa, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x1016_7fac, 2); jmp(0x1016_7fc0, 0x12); goto l_0x1016_7fc0; /* jmp 0x10167fc0 */
        l_0x1016_7fae:
            ii(0x1016_7fae, 3); add(ebx, 0x24);                         /* add ebx, 0x24 */
            ii(0x1016_7fb1, 1); inc(edx);                               /* inc edx */
        l_0x1016_7fb2:
            ii(0x1016_7fb2, 6); mov(eax, memd[ds, edi + 0x101c_b1fc]);  /* mov eax, [edi+0x101cb1fc] */
            ii(0x1016_7fb8, 3); mov(eax, memd[ds, eax + 60]);           /* mov eax, [eax+0x3c] */
            ii(0x1016_7fbb, 3); cmp(edx, memd[ds, eax + 20]);           /* cmp edx, [eax+0x14] */
            ii(0x1016_7fbe, 2); if(jl(0x1016_7f9f, -0x21)) goto l_0x1016_7f9f; /* jl 0x10167f9f */
        l_0x1016_7fc0:
            ii(0x1016_7fc0, 6); mov(eax, memd[ss, ebp + 0x101c_b1fc]);  /* mov eax, [ebp+0x101cb1fc] */
            ii(0x1016_7fc6, 4); test(memb[ds, eax + 4], 0x10);          /* test byte [eax+0x4], 0x10 */
            ii(0x1016_7fca, 2); if(jnz(0x1016_7fdb, 0xf)) goto l_0x1016_7fdb; /* jnz 0x10167fdb */
            ii(0x1016_7fcc, 3); mov(ecx, memd[ss, esp]);                /* mov ecx, [esp] */
            ii(0x1016_7fcf, 1); dec(ecx);                               /* dec ecx */
            ii(0x1016_7fd0, 3); sub(ebp, 4);                            /* sub ebp, 0x4 */
            ii(0x1016_7fd3, 3); mov(memd[ss, esp], ecx);                /* mov [esp], ecx */
            ii(0x1016_7fd6, 3); cmp(ebp, 4);                            /* cmp ebp, 0x4 */
            ii(0x1016_7fd9, 2); if(jge(0x1016_7f8b, -0x50)) goto l_0x1016_7f8b; /* jge 0x10167f8b */
        l_0x1016_7fdb:
            ii(0x1016_7fdb, 2); mov(eax, esi);                          /* mov eax, esi */
        l_0x1016_7fdd:
            ii(0x1016_7fdd, 3); add(esp, 4);                            /* add esp, 0x4 */
            ii(0x1016_7fe0, 1); pop(ebp);                               /* pop ebp */
            ii(0x1016_7fe1, 1); pop(edi);                               /* pop edi */
            ii(0x1016_7fe2, 1); pop(esi);                               /* pop esi */
            ii(0x1016_7fe3, 1); pop(edx);                               /* pop edx */
            ii(0x1016_7fe4, 1); pop(ecx);                               /* pop ecx */
            ii(0x1016_7fe5, 1); pop(ebx);                               /* pop ebx */
            ii(0x1016_7fe6, 1); ret();                                  /* ret */
        }
    }
}
