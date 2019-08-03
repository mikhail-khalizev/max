using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("d981e337-1a48-4168-ad93-2657ad7066bd")]
        public void Method_100f_ccb1()
        {
            ii(0x100f_ccb1, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x100f_ccb6, 5); calld(Definitions.sys_check_available_stack_size, 0x69097); /* call 0x10165d52 */
            ii(0x100f_ccbb, 1); pushd(ebx);                             /* push ebx */
            ii(0x100f_ccbc, 1); pushd(ecx);                             /* push ecx */
            ii(0x100f_ccbd, 1); pushd(edx);                             /* push edx */
            ii(0x100f_ccbe, 1); pushd(esi);                             /* push esi */
            ii(0x100f_ccbf, 1); pushd(edi);                             /* push edi */
            ii(0x100f_ccc0, 1); pushd(ebp);                             /* push ebp */
            ii(0x100f_ccc1, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_ccc3, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100f_ccc9, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100f_cccc, 7); mov(memd_a32[ss, ebp - 0xc], 0);        /* mov dword [ebp-0xc], 0x0 */
            ii(0x100f_ccd3, 2); jmpd(0x100f_ccdb, 0x6); goto l_0x100f_ccdb; /* jmp 0x100fccdb */
        l_0x100f_ccd5:
            ii(0x100f_ccd5, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100f_ccd8, 3); inc(memd_a32[ss, ebp - 0xc]);           /* inc dword [ebp-0xc] */
        l_0x100f_ccdb:
            ii(0x100f_ccdb, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100f_ccde, 7); cmp(ax, memw_a32[ds, 0x101c_8172]);     /* cmp ax, [0x101c8172] */
            ii(0x100f_cce5, 6); if(jged(0x100f_cd93, 0xa8)) goto l_0x100f_cd93; /* jge 0x100fcd93 */
            ii(0x100f_cceb, 7); mov(memd_a32[ss, ebp - 0x8], 0);        /* mov dword [ebp-0x8], 0x0 */
            ii(0x100f_ccf2, 2); jmpd(0x100f_ccfa, 0x6); goto l_0x100f_ccfa; /* jmp 0x100fccfa */
        l_0x100f_ccf4:
            ii(0x100f_ccf4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100f_ccf7, 3); inc(memd_a32[ss, ebp - 0x8]);           /* inc dword [ebp-0x8] */
        l_0x100f_ccfa:
            ii(0x100f_ccfa, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100f_ccfd, 7); cmp(ax, memw_a32[ds, 0x101c_8174]);     /* cmp ax, [0x101c8174] */
            ii(0x100f_cd04, 6); if(jged(0x100f_cd8e, 0x84)) goto l_0x100f_cd8e; /* jge 0x100fcd8e */
            ii(0x100f_cd0a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100f_cd0d, 1); dec(eax);                               /* dec eax */
            ii(0x100f_cd0e, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100f_cd11, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100f_cd14, 1); dec(eax);                               /* dec eax */
            ii(0x100f_cd15, 1); cwde();                                 /* cwde */
            ii(0x100f_cd16, 5); calld(0x100f_c58b, -0x790);             /* call 0x100fc58b */
            ii(0x100f_cd1b, 4); cmp(ax, memw_a32[ss, ebp - 0x4]);       /* cmp ax, [ebp-0x4] */
            ii(0x100f_cd1f, 2); if(jged(0x100f_cd35, 0x14)) goto l_0x100f_cd35; /* jge 0x100fcd35 */
            ii(0x100f_cd21, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x100f_cd25, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100f_cd28, 1); dec(eax);                               /* dec eax */
            ii(0x100f_cd29, 1); cwde();                                 /* cwde */
            ii(0x100f_cd2a, 5); calld(0x100f_c58b, -0x7a4);             /* call 0x100fc58b */
            ii(0x100f_cd2f, 4); cmp(ax, memw_a32[ss, ebp - 0x4]);       /* cmp ax, [ebp-0x4] */
            ii(0x100f_cd33, 2); if(jld(0x100f_cd37, 0x2)) goto l_0x100f_cd37; /* jl 0x100fcd37 */
        l_0x100f_cd35:
            ii(0x100f_cd35, 2); jmpd(0x100f_cd4d, 0x16); goto l_0x100f_cd4d; /* jmp 0x100fcd4d */
        l_0x100f_cd37:
            ii(0x100f_cd37, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100f_cd3a, 1); dec(eax);                               /* dec eax */
            ii(0x100f_cd3b, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100f_cd3e, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x100f_cd42, 5); calld(0x100f_c58b, -0x7bc);             /* call 0x100fc58b */
            ii(0x100f_cd47, 4); cmp(ax, memw_a32[ss, ebp - 0x4]);       /* cmp ax, [ebp-0x4] */
            ii(0x100f_cd4b, 2); if(jld(0x100f_cd4f, 0x2)) goto l_0x100f_cd4f; /* jl 0x100fcd4f */
        l_0x100f_cd4d:
            ii(0x100f_cd4d, 2); jmpd(0x100f_cd62, 0x13); goto l_0x100f_cd62; /* jmp 0x100fcd62 */
        l_0x100f_cd4f:
            ii(0x100f_cd4f, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x100f_cd53, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x100f_cd57, 5); calld(0x100f_c58b, -0x7d1);             /* call 0x100fc58b */
            ii(0x100f_cd5c, 4); cmp(ax, memw_a32[ss, ebp - 0x4]);       /* cmp ax, [ebp-0x4] */
            ii(0x100f_cd60, 2); if(jld(0x100f_cd64, 0x2)) goto l_0x100f_cd64; /* jl 0x100fcd64 */
        l_0x100f_cd62:
            ii(0x100f_cd62, 2); jmpd(0x100f_cd89, 0x25); goto l_0x100f_cd89; /* jmp 0x100fcd89 */
        l_0x100f_cd64:
            ii(0x100f_cd64, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100f_cd68, 6); mov(edx, memd_a32[ds, 0x101c_8170]);    /* mov edx, [0x101c8170] */
            ii(0x100f_cd6e, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100f_cd71, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x100f_cd74, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x100f_cd78, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100f_cd7a, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100f_cd7c, 6); mov(edx, memd_a32[ds, 0x101c_811c]);    /* mov edx, [0x101c811c] */
            ii(0x100f_cd82, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100f_cd84, 5); mov(memw_a32[ds, eax], 0x80);           /* mov word [eax], 0x80 */
        l_0x100f_cd89:
            ii(0x100f_cd89, 5); jmpd(0x100f_ccf4, -0x9a); goto l_0x100f_ccf4; /* jmp 0x100fccf4 */
        l_0x100f_cd8e:
            ii(0x100f_cd8e, 5); jmpd(0x100f_ccd5, -0xbe); goto l_0x100f_ccd5; /* jmp 0x100fccd5 */
        l_0x100f_cd93:
            ii(0x100f_cd93, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_cd95, 1); popd(ebp);                              /* pop ebp */
            ii(0x100f_cd96, 1); popd(edi);                              /* pop edi */
            ii(0x100f_cd97, 1); popd(esi);                              /* pop esi */
            ii(0x100f_cd98, 1); popd(edx);                              /* pop edx */
            ii(0x100f_cd99, 1); popd(ecx);                              /* pop ecx */
            ii(0x100f_cd9a, 1); popd(ebx);                              /* pop ebx */
            ii(0x100f_cd9b, 1); retd(); return;                         /* ret */
        }
    }
}
