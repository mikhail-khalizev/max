using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("9ce1e5e6-3504-4cf2-9b05-1f63e82cbfe1")]
        public void /* sys */ sys_display_copy_to_video_memory_2()
        {
            ii(0x1018_d034, 1); pushd(ebp);                             /* push ebp */
            ii(0x1018_d035, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1018_d037, 3); add(esp, -0x14 /* 0xec */);             /* add esp, 0xffffffec */
            ii(0x1018_d03a, 1); pushd(eax);                             /* push eax */
            ii(0x1018_d03b, 1); pushd(ebx);                             /* push ebx */
            ii(0x1018_d03c, 1); pushd(ecx);                             /* push ecx */
            ii(0x1018_d03d, 1); pushd(edx);                             /* push edx */
            ii(0x1018_d03e, 1); pushd(esi);                             /* push esi */
            ii(0x1018_d03f, 1); pushd(edi);                             /* push edi */
            ii(0x1018_d040, 3); mov(eax, memd_a32[ss, ebp + 0x1c]);     /* mov eax, [ebp+0x1c] */
            ii(0x1018_d043, 3); shr(eax, 0x2);                          /* shr eax, 0x2 */
            ii(0x1018_d046, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1018_d049, 3); mov(eax, memd_a32[ss, ebp + 0xc]);      /* mov eax, [ebp+0xc] */
            ii(0x1018_d04c, 3); sub(eax, memd_a32[ss, ebp + 0x1c]);     /* sub eax, [ebp+0x1c] */
            ii(0x1018_d04f, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1018_d052, 5); mov(eax, memd_a32[ds, 0x1020_88f8]);    /* mov eax, [0x102088f8] */
            ii(0x1018_d057, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1018_d05a, 3); sub(eax, memd_a32[ss, ebp + 0x1c]);     /* sub eax, [ebp+0x1c] */
            ii(0x1018_d05d, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1018_d060, 3); mov(eax, memd_a32[ss, ebp + 0x18]);     /* mov eax, [ebp+0x18] */
            ii(0x1018_d063, 3); mul(memd_a32[ss, ebp + 0xc]);           /* mul dword [ebp+0xc] */
            ii(0x1018_d066, 3); add(eax, memd_a32[ss, ebp + 0x14]);     /* add eax, [ebp+0x14] */
            ii(0x1018_d069, 3); add(memd_a32[ss, ebp + 0x8], eax);      /* add [ebp+0x8], eax */
            ii(0x1018_d06c, 7); cmp(memd_a32[ds, 0x1020_88fc], 0);      /* cmp dword [0x102088fc], 0x0 */
            ii(0x1018_d073, 2); if(jnzd(0x1018_d0a3, 0x2e)) goto l_0x1018_d0a3; /* jnz 0x1018d0a3 */
            ii(0x1018_d075, 6); mov(edi, memd_a32[ds, Definitions.video_win_start_v2]); /* mov edi, [0x10208918] */
            ii(0x1018_d07b, 3); mov(eax, memd_a32[ss, ebp + 0x28]);     /* mov eax, [ebp+0x28] */
            ii(0x1018_d07e, 3); mul(memd_a32[ss, ebp - 0x10]);          /* mul dword [ebp-0x10] */
            ii(0x1018_d081, 3); add(eax, memd_a32[ss, ebp + 0x24]);     /* add eax, [ebp+0x24] */
            ii(0x1018_d084, 2); add(edi, eax);                          /* add edi, eax */
            ii(0x1018_d086, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1018_d089, 3); mov(edx, memd_a32[ss, ebp - 0x14]);     /* mov edx, [ebp-0x14] */
            ii(0x1018_d08c, 3); mov(esi, memd_a32[ss, ebp + 0x8]);      /* mov esi, [ebp+0x8] */
            ii(0x1018_d08f, 3); mov(ebx, memd_a32[ss, ebp + 0x20]);     /* mov ebx, [ebp+0x20] */
        l_0x1018_d092:
            ii(0x1018_d092, 3); mov(ecx, memd_a32[ss, ebp - 0x8]);      /* mov ecx, [ebp-0x8] */
            ii(0x1018_d095, 2); rep_a32(() => movsd_a32());             /* rep movsd */
            ii(0x1018_d097, 2); add(esi, eax);                          /* add esi, eax */
            ii(0x1018_d099, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1018_d09b, 1); dec(ebx);                               /* dec ebx */
            ii(0x1018_d09c, 2); if(jnzd(0x1018_d092, -0xc)) goto l_0x1018_d092; /* jnz 0x1018d092 */
            ii(0x1018_d09e, 5); jmpd(0x1018_d15c, 0xb9); goto l_0x1018_d15c; /* jmp 0x1018d15c */
        l_0x1018_d0a3:
            ii(0x1018_d0a3, 3); mov(esi, memd_a32[ss, ebp + 0x8]);      /* mov esi, [ebp+0x8] */
            ii(0x1018_d0a6, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1018_d0a9, 3); mul(memd_a32[ss, ebp + 0x28]);          /* mul dword [ebp+0x28] */
            ii(0x1018_d0ac, 3); add(eax, memd_a32[ss, ebp + 0x24]);     /* add eax, [ebp+0x24] */
            ii(0x1018_d0af, 5); mov(edx, 0);                            /* mov edx, 0x0 */
            ii(0x1018_d0b4, 6); div(memd_a32[ds, 0x1020_8908]);         /* div dword [0x10208908] */
            ii(0x1018_d0ba, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1018_d0bd, 2); mov(edi, edx);                          /* mov edi, edx */
            ii(0x1018_d0bf, 6); add(edi, memd_a32[ds, Definitions.video_win_start_v2]); /* add edi, [0x10208918] */
            ii(0x1018_d0c5, 2); mov(bh, 0);                             /* mov bh, 0x0 */
            ii(0x1018_d0c7, 6); mov(bl, memb_a32[ds, 0x1020_8900]);     /* mov bl, [0x10208900] */
            ii(0x1018_d0cd, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1018_d0d0, 6); calld_abs(memd_a32[ds, 0x1020_88fc]);   /* call dword [0x102088fc] */ /* Вызов '0x1018_cda8'. */
        l_0x1018_d0d6:
            ii(0x1018_d0d6, 5); mov(eax, memd_a32[ds, 0x1020_8910]);    /* mov eax, [0x10208910] */
            ii(0x1018_d0db, 2); sub(eax, edi);                          /* sub eax, edi */
            ii(0x1018_d0dd, 3); add(eax, memd_a32[ss, ebp - 0x10]);     /* add eax, [ebp-0x10] */
            ii(0x1018_d0e0, 3); sub(eax, memd_a32[ss, ebp + 0x1c]);     /* sub eax, [ebp+0x1c] */
            ii(0x1018_d0e3, 5); mov(edx, 0);                            /* mov edx, 0x0 */
            ii(0x1018_d0e8, 3); div(memd_a32[ss, ebp - 0x10]);          /* div dword [ebp-0x10] */
            ii(0x1018_d0eb, 3); cmp(memd_a32[ss, ebp + 0x20], eax);     /* cmp [ebp+0x20], eax */
            ii(0x1018_d0ee, 2); if(jaed(0x1018_d0f3, 0x3)) goto l_0x1018_d0f3; /* jae 0x1018d0f3 */
            ii(0x1018_d0f0, 3); mov(eax, memd_a32[ss, ebp + 0x20]);     /* mov eax, [ebp+0x20] */
        l_0x1018_d0f3:
            ii(0x1018_d0f3, 2); or(eax, eax);                           /* or eax, eax */
            ii(0x1018_d0f5, 2); if(jzd(0x1018_d10c, 0x15)) goto l_0x1018_d10c; /* jz 0x1018d10c */
            ii(0x1018_d0f7, 3); sub(memd_a32[ss, ebp + 0x20], eax);     /* sub [ebp+0x20], eax */
            ii(0x1018_d0fa, 3); mov(ebx, memd_a32[ss, ebp - 0xc]);      /* mov ebx, [ebp-0xc] */
            ii(0x1018_d0fd, 3); mov(edx, memd_a32[ss, ebp - 0x14]);     /* mov edx, [ebp-0x14] */
        l_0x1018_d100:
            ii(0x1018_d100, 3); mov(ecx, memd_a32[ss, ebp - 0x8]);      /* mov ecx, [ebp-0x8] */
            ii(0x1018_d103, 2); rep_a32(() => movsd_a32());             /* rep movsd */
            ii(0x1018_d105, 2); add(esi, ebx);                          /* add esi, ebx */
            ii(0x1018_d107, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1018_d109, 1); dec(eax);                               /* dec eax */
            ii(0x1018_d10a, 2); if(jnzd(0x1018_d100, -0xc)) goto l_0x1018_d100; /* jnz 0x1018d100 */
        l_0x1018_d10c:
            ii(0x1018_d10c, 3); or(eax, memd_a32[ss, ebp + 0x20]);      /* or eax, [ebp+0x20] */
            ii(0x1018_d10f, 2); if(jzd(0x1018_d15c, 0x4b)) goto l_0x1018_d15c; /* jz 0x1018d15c */
            ii(0x1018_d111, 6); mov(ecx, memd_a32[ds, 0x1020_8910]);    /* mov ecx, [0x10208910] */
            ii(0x1018_d117, 2); sub(ecx, edi);                          /* sub ecx, edi */
            ii(0x1018_d119, 3); sar(ecx, 0x2);                          /* sar ecx, 0x2 */
            ii(0x1018_d11c, 2); if(jnsd(0x1018_d123, 0x5)) goto l_0x1018_d123; /* jns 0x1018d123 */
            ii(0x1018_d11e, 5); mov(ecx, 0);                            /* mov ecx, 0x0 */
        l_0x1018_d123:
            ii(0x1018_d123, 1); pushd(ecx);                             /* push ecx */
            ii(0x1018_d124, 2); rep_a32(() => movsd_a32());             /* rep movsd */
            ii(0x1018_d126, 5); mov(eax, memd_a32[ds, 0x1020_88f0]);    /* mov eax, [0x102088f0] */
            ii(0x1018_d12b, 3); add(memd_a32[ss, ebp - 0x4], eax);      /* add [ebp-0x4], eax */
            ii(0x1018_d12e, 6); sub(edi, memd_a32[ds, 0x1020_8914]);    /* sub edi, [0x10208914] */
            ii(0x1018_d134, 2); mov(bh, 0);                             /* mov bh, 0x0 */
            ii(0x1018_d136, 6); mov(bl, memb_a32[ds, 0x1020_8900]);     /* mov bl, [0x10208900] */
            ii(0x1018_d13c, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1018_d13f, 6); calld_abs(memd_a32[ds, 0x1020_88fc]);   /* call dword [0x102088fc] */ /* Вызов '0x1018_cda8'. */
            ii(0x1018_d145, 1); popd(eax);                              /* pop eax */
            ii(0x1018_d146, 3); mov(ecx, memd_a32[ss, ebp - 0x8]);      /* mov ecx, [ebp-0x8] */
            ii(0x1018_d149, 2); sub(ecx, eax);                          /* sub ecx, eax */
            ii(0x1018_d14b, 2); rep_a32(() => movsd_a32());             /* rep movsd */
            ii(0x1018_d14d, 3); add(esi, memd_a32[ss, ebp - 0xc]);      /* add esi, [ebp-0xc] */
            ii(0x1018_d150, 3); add(edi, memd_a32[ss, ebp - 0x14]);     /* add edi, [ebp-0x14] */
            ii(0x1018_d153, 3); dec(memd_a32[ss, ebp + 0x20]);          /* dec dword [ebp+0x20] */
            ii(0x1018_d156, 6); if(jnzd(0x1018_d0d6, -0x86)) goto l_0x1018_d0d6; /* jnz 0x1018d0d6 */
        l_0x1018_d15c:
            ii(0x1018_d15c, 1); popd(edi);                              /* pop edi */
            ii(0x1018_d15d, 1); popd(esi);                              /* pop esi */
            ii(0x1018_d15e, 1); popd(edx);                              /* pop edx */
            ii(0x1018_d15f, 1); popd(ecx);                              /* pop ecx */
            ii(0x1018_d160, 1); popd(ebx);                              /* pop ebx */
            ii(0x1018_d161, 1); popd(eax);                              /* pop eax */
            ii(0x1018_d162, 1); leaved();                               /* leave */
            ii(0x1018_d163, 1); retd(); return;                         /* ret */
        }
    }
}
