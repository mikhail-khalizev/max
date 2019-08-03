using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("323cc164-5088-4bf3-ad4e-e0fe28fe92d6")]
        public void /* sys */ Method_1018_b6e0()
        {
            ii(0x1018_b6e0, 1); pushd(ecx);                             /* push ecx */
            ii(0x1018_b6e1, 1); pushd(esi);                             /* push esi */
            ii(0x1018_b6e2, 1); pushd(edi);                             /* push edi */
            ii(0x1018_b6e3, 1); pushd(ebp);                             /* push ebp */
            ii(0x1018_b6e4, 3); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1018_b6e7, 2); mov(ebp, eax);                          /* mov ebp, eax */
            ii(0x1018_b6e9, 2); mov(edi, edx);                          /* mov edi, edx */
            ii(0x1018_b6eb, 3); mov(memd_a32[ss, esp], ebx);            /* mov [esp], ebx */
            ii(0x1018_b6ee, 6); cmp(memd_a32[ds, eax], 0xfeba_feba);    /* cmp dword [eax], 0xfebafeba */
            ii(0x1018_b6f4, 6); if(jnzd(0x1018_b755, 0x5b)) goto l_0x1018_b755; /* jnz 0x1018b755 */
            ii(0x1018_b6fa, 3); mov(ebx, memd_a32[ds, eax + 0x4]);      /* mov ebx, [eax+0x4] */
            ii(0x1018_b6fd, 2); test(ebx, ebx);                         /* test ebx, ebx */
            ii(0x1018_b6ff, 2); if(jnzd(0x1018_b708, 0x7)) goto l_0x1018_b708; /* jnz 0x1018b708 */
            ii(0x1018_b701, 3); mov(eax, memd_a32[ss, esp]);            /* mov eax, [esp] */
            ii(0x1018_b704, 2); mov(memd_a32[ds, eax], ebx);            /* mov [eax], ebx */
            ii(0x1018_b706, 2); jmpd(0x1018_b755, 0x4d); goto l_0x1018_b755; /* jmp 0x1018b755 */
        l_0x1018_b708:
            ii(0x1018_b708, 1); dec(ebx);                               /* dec ebx */
            ii(0x1018_b709, 2); xor(esi, esi);                          /* xor esi, esi */
            ii(0x1018_b70b, 2); test(ebx, ebx);                         /* test ebx, ebx */
            ii(0x1018_b70d, 2); if(jld(0x1018_b737, 0x28)) goto l_0x1018_b737; /* jl 0x1018b737 */
        l_0x1018_b70f:
            ii(0x1018_b70f, 3); lea(ecx, ebx + esi);                    /* lea ecx, [ebx+esi] */
            ii(0x1018_b712, 3); mov(edx, memd_a32[ss, ebp + 0x20]);     /* mov edx, [ebp+0x20] */
            ii(0x1018_b715, 2); sar(ecx, 0x1);                          /* sar ecx, 1 */
            ii(0x1018_b717, 2); mov(eax, edi);                          /* mov eax, edi */
            ii(0x1018_b719, 3); mov(edx, memd_a32[ds, edx + ecx * 8]);  /* mov edx, [edx+ecx*8] */
            ii(0x1018_b71c, 5); calld(Definitions.sys_strcasecmp, -0x255f1); /* call 0x10166130 */
            ii(0x1018_b721, 4); mov(memd_a32[ss, esp + 0x4], eax);      /* mov [esp+0x4], eax */
            ii(0x1018_b725, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1018_b727, 2); if(jzd(0x1018_b737, 0xe)) goto l_0x1018_b737; /* jz 0x1018b737 */
            ii(0x1018_b729, 2); if(jged(0x1018_b730, 0x5)) goto l_0x1018_b730; /* jge 0x1018b730 */
            ii(0x1018_b72b, 3); lea(ebx, ecx - 0x1);                    /* lea ebx, [ecx-0x1] */
            ii(0x1018_b72e, 2); jmpd(0x1018_b733, 0x3); goto l_0x1018_b733; /* jmp 0x1018b733 */
        l_0x1018_b730:
            ii(0x1018_b730, 3); lea(esi, ecx + 0x1);                    /* lea esi, [ecx+0x1] */
        l_0x1018_b733:
            ii(0x1018_b733, 2); cmp(ebx, esi);                          /* cmp ebx, esi */
            ii(0x1018_b735, 2); if(jged(0x1018_b70f, -0x28)) goto l_0x1018_b70f; /* jge 0x1018b70f */
        l_0x1018_b737:
            ii(0x1018_b737, 4); mov(esi, memd_a32[ss, esp + 0x4]);      /* mov esi, [esp+0x4] */
            ii(0x1018_b73b, 2); test(esi, esi);                         /* test esi, esi */
            ii(0x1018_b73d, 2); if(jnzd(0x1018_b748, 0x9)) goto l_0x1018_b748; /* jnz 0x1018b748 */
            ii(0x1018_b73f, 3); mov(eax, memd_a32[ss, esp]);            /* mov eax, [esp] */
            ii(0x1018_b742, 2); mov(memd_a32[ds, eax], ecx);            /* mov [eax], ecx */
            ii(0x1018_b744, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_b746, 2); jmpd(0x1018_b75a, 0x12); goto l_0x1018_b75a; /* jmp 0x1018b75a */
        l_0x1018_b748:
            ii(0x1018_b748, 2); if(jged(0x1018_b74f, 0x5)) goto l_0x1018_b74f; /* jge 0x1018b74f */
            ii(0x1018_b74a, 3); mov(eax, memd_a32[ss, esp]);            /* mov eax, [esp] */
            ii(0x1018_b74d, 2); jmpd(0x1018_b753, 0x4); goto l_0x1018_b753; /* jmp 0x1018b753 */
        l_0x1018_b74f:
            ii(0x1018_b74f, 3); mov(eax, memd_a32[ss, esp]);            /* mov eax, [esp] */
            ii(0x1018_b752, 1); inc(ecx);                               /* inc ecx */
        l_0x1018_b753:
            ii(0x1018_b753, 2); mov(memd_a32[ds, eax], ecx);            /* mov [eax], ecx */
        l_0x1018_b755:
            ii(0x1018_b755, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
        l_0x1018_b75a:
            ii(0x1018_b75a, 3); add(esp, 0x8);                          /* add esp, 0x8 */
            ii(0x1018_b75d, 1); popd(ebp);                              /* pop ebp */
            ii(0x1018_b75e, 1); popd(edi);                              /* pop edi */
            ii(0x1018_b75f, 1); popd(esi);                              /* pop esi */
            ii(0x1018_b760, 1); popd(ecx);                              /* pop ecx */
            ii(0x1018_b761, 1); retd(); return;                         /* ret */
        }
    }
}