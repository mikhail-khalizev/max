using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("dda3f28f-05b8-4ffe-84b5-9911402ed2b4")]
        public void Method_1014_b6bd()
        {
            ii(0x1014_b6bd, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1014_b6c2, 5); calld(Definitions.sys_check_available_stack_size, 0x1_a68b); /* call 0x10165d52 */
            ii(0x1014_b6c7, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_b6c8, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_b6c9, 1); pushd(edx);                             /* push edx */
            ii(0x1014_b6ca, 1); pushd(esi);                             /* push esi */
            ii(0x1014_b6cb, 1); pushd(edi);                             /* push edi */
            ii(0x1014_b6cc, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_b6cd, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_b6cf, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1014_b6d5, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1014_b6d8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_b6db, 4); cmp(memd_a32[ds, eax + 0x7e], 0);       /* cmp dword [eax+0x7e], 0x0 */
            ii(0x1014_b6df, 2); if(jzd(0x1014_b6f3, 0x12)) goto l_0x1014_b6f3; /* jz 0x1014b6f3 */
            ii(0x1014_b6e1, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1014_b6e4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_b6e7, 3); mov(eax, memd_a32[ds, eax + 0x7e]);     /* mov eax, [eax+0x7e] */
            ii(0x1014_b6ea, 5); calld(0x1008_aab4, -0xc_0c3b);          /* call 0x1008aab4 */
            ii(0x1014_b6ef, 2); test(al, al);                           /* test al, al */
            ii(0x1014_b6f1, 2); if(jnzd(0x1014_b6f8, 0x5)) goto l_0x1014_b6f8; /* jnz 0x1014b6f8 */
        l_0x1014_b6f3:
            ii(0x1014_b6f3, 5); jmpd(0x1014_b775, 0x7d); goto l_0x1014_b775; /* jmp 0x1014b775 */
        l_0x1014_b6f8:
            ii(0x1014_b6f8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_b6fb, 3); mov(eax, memd_a32[ds, eax + 0x7e]);     /* mov eax, [eax+0x7e] */
            ii(0x1014_b6fe, 5); calld(0x1007_6b90, -0xd_4b73);          /* call 0x10076b90 */
            ii(0x1014_b703, 1); cwde();                                 /* cwde */
            ii(0x1014_b704, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1014_b706, 2); if(jnzd(0x1014_b734, 0x2c)) goto l_0x1014_b734; /* jnz 0x1014b734 */
            ii(0x1014_b708, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_b70b, 3); mov(eax, memd_a32[ds, eax + 0x7e]);     /* mov eax, [eax+0x7e] */
            ii(0x1014_b70e, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_b711, 4); cmp(memd_a32[ss, ebp - 0x8], 0);        /* cmp dword [ebp-0x8], 0x0 */
            ii(0x1014_b715, 2); if(jzd(0x1014_b72b, 0x14)) goto l_0x1014_b72b; /* jz 0x1014b72b */
            ii(0x1014_b717, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_b719, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_b71c, 5); calld(Definitions.my_dtor_0x101b56fc, -0xc_2ae5); /* call 0x10088c3c */
            ii(0x1014_b721, 5); calld(Definitions.sys_delete, 0x1_a83e); /* call 0x10165f64 */
            ii(0x1014_b726, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1014_b729, 2); jmpd(0x1014_b732, 0x7); goto l_0x1014_b732; /* jmp 0x1014b732 */
        l_0x1014_b72b:
            ii(0x1014_b72b, 7); mov(memd_a32[ss, ebp - 0xc], 0);        /* mov dword [ebp-0xc], 0x0 */
        l_0x1014_b732:
            ii(0x1014_b732, 2); jmpd(0x1014_b764, 0x30); goto l_0x1014_b764; /* jmp 0x1014b764 */
        l_0x1014_b734:
            ii(0x1014_b734, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_b737, 3); mov(eax, memd_a32[ds, eax + 0x7e]);     /* mov eax, [eax+0x7e] */
            ii(0x1014_b73a, 5); calld(0x1007_6b90, -0xd_4baf);          /* call 0x10076b90 */
            ii(0x1014_b73f, 1); cwde();                                 /* cwde */
            ii(0x1014_b740, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1014_b743, 2); if(jnzd(0x1014_b75c, 0x17)) goto l_0x1014_b75c; /* jnz 0x1014b75c */
            ii(0x1014_b745, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_b748, 3); mov(eax, memd_a32[ds, eax + 0x7e]);     /* mov eax, [eax+0x7e] */
            ii(0x1014_b74b, 5); calld(0x1007_6338, -0xd_5418);          /* call 0x10076338 */
            ii(0x1014_b750, 5); calld(0x1007_653c, -0xd_5219);          /* call 0x1007653c */
            ii(0x1014_b755, 5); calld(0x1014_b6bd, -0x9d);              /* call 0x1014b6bd */
            ii(0x1014_b75a, 2); jmpd(0x1014_b764, 0x8); goto l_0x1014_b764; /* jmp 0x1014b764 */
        l_0x1014_b75c:
            ii(0x1014_b75c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_b75f, 5); calld(0x1007_5a79, -0xd_5ceb);          /* call 0x10075a79 */
        l_0x1014_b764:
            ii(0x1014_b764, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_b767, 7); mov(memd_a32[ds, eax + 0x7e], 0);       /* mov dword [eax+0x7e], 0x0 */
            ii(0x1014_b76e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_b771, 4); mov(memb_a32[ds, eax + 0x4f], 0);       /* mov byte [eax+0x4f], 0x0 */
        l_0x1014_b775:
            ii(0x1014_b775, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_b777, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_b778, 1); popd(edi);                              /* pop edi */
            ii(0x1014_b779, 1); popd(esi);                              /* pop esi */
            ii(0x1014_b77a, 1); popd(edx);                              /* pop edx */
            ii(0x1014_b77b, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_b77c, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_b77d, 1); retd(); return;                         /* ret */
        }
    }
}
