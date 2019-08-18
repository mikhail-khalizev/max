using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("922dc0ac-d059-4cc1-8d2f-cd68aea24ec6")]
        public void Method_1014_bf44()
        {
            ii(0x1014_bf44, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1014_bf49, 5); calld(Definitions.sys_check_available_stack_size, 0x1_9e04); /* call 0x10165d52 */
            ii(0x1014_bf4e, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_bf4f, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_bf50, 1); pushd(edx);                             /* push edx */
            ii(0x1014_bf51, 1); pushd(esi);                             /* push esi */
            ii(0x1014_bf52, 1); pushd(edi);                             /* push edi */
            ii(0x1014_bf53, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_bf54, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_bf56, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1014_bf5c, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1014_bf5f, 7); mov(memd_a32[ss, ebp - 0x8], 0);        /* mov dword [ebp-0x8], 0x0 */
            ii(0x1014_bf66, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_bf69, 4); test(memb_a32[ds, eax + 0x6a], 0x4);    /* test byte [eax+0x6a], 0x4 */
            ii(0x1014_bf6d, 6); if(jnzd(0x1014_c0b2, 0x13f)) goto l_0x1014_c0b2; /* jnz 0x1014c0b2 */
            ii(0x1014_bf73, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_bf76, 4); or(memb_a32[ds, eax + 0x6a], 0x4);      /* or byte [eax+0x6a], 0x4 */
            ii(0x1014_bf7a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_bf7d, 4); test(memb_a32[ds, eax + 0x69], 0x1);    /* test byte [eax+0x69], 0x1 */
            ii(0x1014_bf81, 2); if(jzd(0x1014_bfa1, 0x1e)) goto l_0x1014_bfa1; /* jz 0x1014bfa1 */
            ii(0x1014_bf83, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1014_bf88, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_bf8b, 5); calld(0x1014_b7be, -0x7d2);             /* call 0x1014b7be */
            ii(0x1014_bf90, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_bf93, 4); cmp(memd_a32[ss, ebp - 0x8], 0);        /* cmp dword [ebp-0x8], 0x0 */
            ii(0x1014_bf97, 2); if(jzd(0x1014_bfa1, 0x8)) goto l_0x1014_bfa1; /* jz 0x1014bfa1 */
            ii(0x1014_bf99, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_bf9c, 5); calld(0x1014_bf44, -0x5d);              /* call 0x1014bf44 */
        l_0x1014_bfa1:
            ii(0x1014_bfa1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_bfa4, 4); test(memb_a32[ds, eax + 0x69], 0x2);    /* test byte [eax+0x69], 0x2 */
            ii(0x1014_bfa8, 2); if(jzd(0x1014_bfc8, 0x1e)) goto l_0x1014_bfc8; /* jz 0x1014bfc8 */
            ii(0x1014_bfaa, 5); mov(edx, 0x2);                          /* mov edx, 0x2 */
            ii(0x1014_bfaf, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_bfb2, 5); calld(0x1014_b7be, -0x7f9);             /* call 0x1014b7be */
            ii(0x1014_bfb7, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_bfba, 4); cmp(memd_a32[ss, ebp - 0x8], 0);        /* cmp dword [ebp-0x8], 0x0 */
            ii(0x1014_bfbe, 2); if(jzd(0x1014_bfc8, 0x8)) goto l_0x1014_bfc8; /* jz 0x1014bfc8 */
            ii(0x1014_bfc0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_bfc3, 5); calld(0x1014_bf44, -0x84);              /* call 0x1014bf44 */
        l_0x1014_bfc8:
            ii(0x1014_bfc8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_bfcb, 4); test(memb_a32[ds, eax + 0x69], 0x4);    /* test byte [eax+0x69], 0x4 */
            ii(0x1014_bfcf, 2); if(jzd(0x1014_bfef, 0x1e)) goto l_0x1014_bfef; /* jz 0x1014bfef */
            ii(0x1014_bfd1, 5); mov(edx, 0x4);                          /* mov edx, 0x4 */
            ii(0x1014_bfd6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_bfd9, 5); calld(0x1014_b7be, -0x820);             /* call 0x1014b7be */
            ii(0x1014_bfde, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_bfe1, 4); cmp(memd_a32[ss, ebp - 0x8], 0);        /* cmp dword [ebp-0x8], 0x0 */
            ii(0x1014_bfe5, 2); if(jzd(0x1014_bfef, 0x8)) goto l_0x1014_bfef; /* jz 0x1014bfef */
            ii(0x1014_bfe7, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_bfea, 5); calld(0x1014_bf44, -0xab);              /* call 0x1014bf44 */
        l_0x1014_bfef:
            ii(0x1014_bfef, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_bff2, 4); test(memb_a32[ds, eax + 0x69], 0x8);    /* test byte [eax+0x69], 0x8 */
            ii(0x1014_bff6, 2); if(jzd(0x1014_c016, 0x1e)) goto l_0x1014_c016; /* jz 0x1014c016 */
            ii(0x1014_bff8, 5); mov(edx, 0x8);                          /* mov edx, 0x8 */
            ii(0x1014_bffd, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_c000, 5); calld(0x1014_b7be, -0x847);             /* call 0x1014b7be */
            ii(0x1014_c005, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_c008, 4); cmp(memd_a32[ss, ebp - 0x8], 0);        /* cmp dword [ebp-0x8], 0x0 */
            ii(0x1014_c00c, 2); if(jzd(0x1014_c016, 0x8)) goto l_0x1014_c016; /* jz 0x1014c016 */
            ii(0x1014_c00e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_c011, 5); calld(0x1014_bf44, -0xd2);              /* call 0x1014bf44 */
        l_0x1014_c016:
            ii(0x1014_c016, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_c019, 4); test(memb_a32[ds, eax + 0x69], 0x20);   /* test byte [eax+0x69], 0x20 */
            ii(0x1014_c01d, 2); if(jzd(0x1014_c03d, 0x1e)) goto l_0x1014_c03d; /* jz 0x1014c03d */
            ii(0x1014_c01f, 5); mov(edx, 0x20);                         /* mov edx, 0x20 */
            ii(0x1014_c024, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_c027, 5); calld(0x1014_b7be, -0x86e);             /* call 0x1014b7be */
            ii(0x1014_c02c, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_c02f, 4); cmp(memd_a32[ss, ebp - 0x8], 0);        /* cmp dword [ebp-0x8], 0x0 */
            ii(0x1014_c033, 2); if(jzd(0x1014_c03d, 0x8)) goto l_0x1014_c03d; /* jz 0x1014c03d */
            ii(0x1014_c035, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_c038, 5); calld(0x1014_bf44, -0xf9);              /* call 0x1014bf44 */
        l_0x1014_c03d:
            ii(0x1014_c03d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_c040, 4); test(memb_a32[ds, eax + 0x69], 0x10);   /* test byte [eax+0x69], 0x10 */
            ii(0x1014_c044, 2); if(jzd(0x1014_c064, 0x1e)) goto l_0x1014_c064; /* jz 0x1014c064 */
            ii(0x1014_c046, 5); mov(edx, 0x10);                         /* mov edx, 0x10 */
            ii(0x1014_c04b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_c04e, 5); calld(0x1014_b7be, -0x895);             /* call 0x1014b7be */
            ii(0x1014_c053, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_c056, 4); cmp(memd_a32[ss, ebp - 0x8], 0);        /* cmp dword [ebp-0x8], 0x0 */
            ii(0x1014_c05a, 2); if(jzd(0x1014_c064, 0x8)) goto l_0x1014_c064; /* jz 0x1014c064 */
            ii(0x1014_c05c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_c05f, 5); calld(0x1014_bf44, -0x120);             /* call 0x1014bf44 */
        l_0x1014_c064:
            ii(0x1014_c064, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_c067, 4); test(memb_a32[ds, eax + 0x69], 0x80);   /* test byte [eax+0x69], 0x80 */
            ii(0x1014_c06b, 2); if(jzd(0x1014_c08b, 0x1e)) goto l_0x1014_c08b; /* jz 0x1014c08b */
            ii(0x1014_c06d, 5); mov(edx, 0x80);                         /* mov edx, 0x80 */
            ii(0x1014_c072, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_c075, 5); calld(0x1014_b7be, -0x8bc);             /* call 0x1014b7be */
            ii(0x1014_c07a, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_c07d, 4); cmp(memd_a32[ss, ebp - 0x8], 0);        /* cmp dword [ebp-0x8], 0x0 */
            ii(0x1014_c081, 2); if(jzd(0x1014_c08b, 0x8)) goto l_0x1014_c08b; /* jz 0x1014c08b */
            ii(0x1014_c083, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_c086, 5); calld(0x1014_bf44, -0x147);             /* call 0x1014bf44 */
        l_0x1014_c08b:
            ii(0x1014_c08b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_c08e, 4); test(memb_a32[ds, eax + 0x69], 0x40);   /* test byte [eax+0x69], 0x40 */
            ii(0x1014_c092, 2); if(jzd(0x1014_c0b2, 0x1e)) goto l_0x1014_c0b2; /* jz 0x1014c0b2 */
            ii(0x1014_c094, 5); mov(edx, 0x40);                         /* mov edx, 0x40 */
            ii(0x1014_c099, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_c09c, 5); calld(0x1014_b7be, -0x8e3);             /* call 0x1014b7be */
            ii(0x1014_c0a1, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_c0a4, 4); cmp(memd_a32[ss, ebp - 0x8], 0);        /* cmp dword [ebp-0x8], 0x0 */
            ii(0x1014_c0a8, 2); if(jzd(0x1014_c0b2, 0x8)) goto l_0x1014_c0b2; /* jz 0x1014c0b2 */
            ii(0x1014_c0aa, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_c0ad, 5); calld(0x1014_bf44, -0x16e);             /* call 0x1014bf44 */
        l_0x1014_c0b2:
            ii(0x1014_c0b2, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_c0b4, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_c0b5, 1); popd(edi);                              /* pop edi */
            ii(0x1014_c0b6, 1); popd(esi);                              /* pop esi */
            ii(0x1014_c0b7, 1); popd(edx);                              /* pop edx */
            ii(0x1014_c0b8, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_c0b9, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_c0ba, 1); retd(); return;                         /* ret */
        }
    }
}
