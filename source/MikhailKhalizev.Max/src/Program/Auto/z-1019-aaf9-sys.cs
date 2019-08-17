using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("d84280cf-2352-4870-95ce-8ea9a9945d14")]
        public void /* sys */ Method_1019_aaf9()
        {
            ii(0x1019_aaf9, 1); pushd(ebx);                             /* push ebx */
            ii(0x1019_aafa, 1); pushd(ecx);                             /* push ecx */
            ii(0x1019_aafb, 1); pushd(edx);                             /* push edx */
            ii(0x1019_aafc, 1); pushd(esi);                             /* push esi */
            ii(0x1019_aafd, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1019_aaff, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1019_ab02, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1019_ab04, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1019_ab07, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1019_ab09, 5); mov(esi, 0x101b_e5a0);                  /* mov esi, 0x101be5a0 */
            ii(0x1019_ab0e, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1019_ab10, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1019_ab12, 2); add(esi, eax);                          /* add esi, eax */
            ii(0x1019_ab14, 5); mov(eax, memd_a32[ds, 0x1020_b70c]);    /* mov eax, [0x1020b70c] */
            ii(0x1019_ab19, 2); jmpd(0x1019_ab46, 0x2b); goto l_0x1019_ab46; /* jmp 0x1019ab46 */
        l_0x1019_ab1b:
            ii(0x1019_ab1b, 2); mov(ecx, memd_a32[ds, eax]);            /* mov ecx, [eax] */
            ii(0x1019_ab1d, 3); mov(eax, memd_a32[ds, eax + 0x4]);      /* mov eax, [eax+0x4] */
            ii(0x1019_ab20, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1019_ab25, 4); test(memb_a32[ds, eax + 0xd], 0x40);    /* test byte [eax+0xd], 0x40 */
            ii(0x1019_ab29, 2); if(jnzd(0x1019_ab3e, 0x13)) goto l_0x1019_ab3e; /* jnz 0x1019ab3e */
            ii(0x1019_ab2b, 4); test(memb_a32[ds, eax + 0xd], 0x8);     /* test byte [eax+0xd], 0x8 */
            ii(0x1019_ab2f, 2); if(jnzd(0x1019_ab3e, 0xd)) goto l_0x1019_ab3e; /* jnz 0x1019ab3e */
            ii(0x1019_ab31, 2); cmp(eax, esi);                          /* cmp eax, esi */
            ii(0x1019_ab33, 2); if(jbd(0x1019_ab44, 0xf)) goto l_0x1019_ab44; /* jb 0x1019ab44 */
            ii(0x1019_ab35, 5); cmp(eax, 0x101b_e622);                  /* cmp eax, 0x101be622 */
            ii(0x1019_ab3a, 2); if(jaed(0x1019_ab3e, 0x2)) goto l_0x1019_ab3e; /* jae 0x1019ab3e */
            ii(0x1019_ab3c, 2); xor(edx, edx);                          /* xor edx, edx */
        l_0x1019_ab3e:
            ii(0x1019_ab3e, 5); calld(/* sys */ 0x1017_2096, -0x2_8aad); /* call 0x10172096 */
            ii(0x1019_ab43, 1); inc(ebx);                               /* inc ebx */
        l_0x1019_ab44:
            ii(0x1019_ab44, 2); mov(eax, ecx);                          /* mov eax, ecx */
        l_0x1019_ab46:
            ii(0x1019_ab46, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1019_ab48, 2); if(jnzd(0x1019_ab1b, -0x2f)) goto l_0x1019_ab1b; /* jnz 0x1019ab1b */
            ii(0x1019_ab4a, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1019_ab4c, 1); popd(esi);                              /* pop esi */
            ii(0x1019_ab4d, 1); popd(edx);                              /* pop edx */
            ii(0x1019_ab4e, 1); popd(ecx);                              /* pop ecx */
            ii(0x1019_ab4f, 1); popd(ebx);                              /* pop ebx */
            ii(0x1019_ab50, 1); retd(); return;                         /* ret */
        }
    }
}
