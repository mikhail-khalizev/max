using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c0f4bdde-2827-46b7-a33b-d0444f52d295")]
        public void /* sys */ sys_display_copy_to_video_memory_1()
        {
            ii(0x1018_cdf4, 1); pushd(ebp);                             /* push ebp */
            ii(0x1018_cdf5, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1018_cdf7, 3); add(esp, -0x10 /* 0xf0 */);             /* add esp, 0xfffffff0 */
            ii(0x1018_cdfa, 1); pushd(eax);                             /* push eax */
            ii(0x1018_cdfb, 1); pushd(ebx);                             /* push ebx */
            ii(0x1018_cdfc, 1); pushd(ecx);                             /* push ecx */
            ii(0x1018_cdfd, 1); pushd(edx);                             /* push edx */
            ii(0x1018_cdfe, 1); pushd(esi);                             /* push esi */
            ii(0x1018_cdff, 1); pushd(edi);                             /* push edi */
            ii(0x1018_ce00, 3); mov(eax, memd_a32[ss, ebp + 0xc]);      /* mov eax, [ebp+0xc] */
            ii(0x1018_ce03, 3); sub(eax, memd_a32[ss, ebp + 0x1c]);     /* sub eax, [ebp+0x1c] */
            ii(0x1018_ce06, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1018_ce09, 5); mov(eax, memd_a32[ds, 0x1020_88f8]);    /* mov eax, [0x102088f8] */
            ii(0x1018_ce0e, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1018_ce11, 3); sub(eax, memd_a32[ss, ebp + 0x1c]);     /* sub eax, [ebp+0x1c] */
            ii(0x1018_ce14, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1018_ce17, 3); mov(eax, memd_a32[ss, ebp + 0x18]);     /* mov eax, [ebp+0x18] */
            ii(0x1018_ce1a, 3); mul(memd_a32[ss, ebp + 0xc]);           /* mul dword [ebp+0xc] */
            ii(0x1018_ce1d, 3); add(eax, memd_a32[ss, ebp + 0x14]);     /* add eax, [ebp+0x14] */
            ii(0x1018_ce20, 3); add(memd_a32[ss, ebp + 0x8], eax);      /* add [ebp+0x8], eax */
            ii(0x1018_ce23, 7); cmp(memd_a32[ds, 0x1020_88fc], 0);      /* cmp dword [0x102088fc], 0x0 */
            ii(0x1018_ce2a, 2); if(jnzd(0x1018_ce5a, 0x2e)) goto l_0x1018_ce5a; /* jnz 0x1018ce5a */
            ii(0x1018_ce2c, 6); mov(edi, memd_a32[ds, Definitions.video_win_start_v2]); /* mov edi, [0x10208918] */
            ii(0x1018_ce32, 3); mov(eax, memd_a32[ss, ebp + 0x28]);     /* mov eax, [ebp+0x28] */
            ii(0x1018_ce35, 3); mul(memd_a32[ss, ebp - 0xc]);           /* mul dword [ebp-0xc] */
            ii(0x1018_ce38, 3); add(eax, memd_a32[ss, ebp + 0x24]);     /* add eax, [ebp+0x24] */
            ii(0x1018_ce3b, 2); add(edi, eax);                          /* add edi, eax */
            ii(0x1018_ce3d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1018_ce40, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1018_ce43, 3); mov(esi, memd_a32[ss, ebp + 0x8]);      /* mov esi, [ebp+0x8] */
            ii(0x1018_ce46, 3); mov(ebx, memd_a32[ss, ebp + 0x20]);     /* mov ebx, [ebp+0x20] */
        l_0x1018_ce49:
            ii(0x1018_ce49, 3); mov(ecx, memd_a32[ss, ebp + 0x1c]);     /* mov ecx, [ebp+0x1c] */
            ii(0x1018_ce4c, 2); rep_a32(() => movsb_a32());             /* rep movsb */
            ii(0x1018_ce4e, 2); add(esi, eax);                          /* add esi, eax */
            ii(0x1018_ce50, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1018_ce52, 1); dec(ebx);                               /* dec ebx */
            ii(0x1018_ce53, 2); if(jnzd(0x1018_ce49, -0xc)) goto l_0x1018_ce49; /* jnz 0x1018ce49 */
            ii(0x1018_ce55, 5); jmpd(0x1018_cf0c, 0xb2); goto l_0x1018_cf0c; /* jmp 0x1018cf0c */
        l_0x1018_ce5a:
            ii(0x1018_ce5a, 3); mov(esi, memd_a32[ss, ebp + 0x8]);      /* mov esi, [ebp+0x8] */
            ii(0x1018_ce5d, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1018_ce60, 3); mul(memd_a32[ss, ebp + 0x28]);          /* mul dword [ebp+0x28] */
            ii(0x1018_ce63, 3); add(eax, memd_a32[ss, ebp + 0x24]);     /* add eax, [ebp+0x24] */
            ii(0x1018_ce66, 5); mov(edx, 0);                            /* mov edx, 0x0 */
            ii(0x1018_ce6b, 6); div(memd_a32[ds, 0x1020_8908]);         /* div dword [0x10208908] */
            ii(0x1018_ce71, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1018_ce74, 2); mov(edi, edx);                          /* mov edi, edx */
            ii(0x1018_ce76, 6); add(edi, memd_a32[ds, Definitions.video_win_start_v2]); /* add edi, [0x10208918] */
            ii(0x1018_ce7c, 2); mov(bh, 0);                             /* mov bh, 0x0 */
            ii(0x1018_ce7e, 6); mov(bl, memb_a32[ds, 0x1020_8900]);     /* mov bl, [0x10208900] */
            ii(0x1018_ce84, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1018_ce87, 6); calld_abs(memd_a32[ds, 0x1020_88fc]);   /* call dword [0x102088fc] */ /* Вызов '0x1018_cda8'. */
        l_0x1018_ce8d:
            ii(0x1018_ce8d, 5); mov(eax, memd_a32[ds, 0x1020_8910]);    /* mov eax, [0x10208910] */
            ii(0x1018_ce92, 2); sub(eax, edi);                          /* sub eax, edi */
            ii(0x1018_ce94, 3); add(eax, memd_a32[ss, ebp - 0xc]);      /* add eax, [ebp-0xc] */
            ii(0x1018_ce97, 3); sub(eax, memd_a32[ss, ebp + 0x1c]);     /* sub eax, [ebp+0x1c] */
            ii(0x1018_ce9a, 5); mov(edx, 0);                            /* mov edx, 0x0 */
            ii(0x1018_ce9f, 3); div(memd_a32[ss, ebp - 0xc]);           /* div dword [ebp-0xc] */
            ii(0x1018_cea2, 3); cmp(memd_a32[ss, ebp + 0x20], eax);     /* cmp [ebp+0x20], eax */
            ii(0x1018_cea5, 2); if(jaed(0x1018_ceaa, 0x3)) goto l_0x1018_ceaa; /* jae 0x1018ceaa */
            ii(0x1018_cea7, 3); mov(eax, memd_a32[ss, ebp + 0x20]);     /* mov eax, [ebp+0x20] */
        l_0x1018_ceaa:
            ii(0x1018_ceaa, 2); or(eax, eax);                           /* or eax, eax */
            ii(0x1018_ceac, 2); if(jzd(0x1018_cec3, 0x15)) goto l_0x1018_cec3; /* jz 0x1018cec3 */
            ii(0x1018_ceae, 3); sub(memd_a32[ss, ebp + 0x20], eax);     /* sub [ebp+0x20], eax */
            ii(0x1018_ceb1, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x1018_ceb4, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
        l_0x1018_ceb7:
            ii(0x1018_ceb7, 3); mov(ecx, memd_a32[ss, ebp + 0x1c]);     /* mov ecx, [ebp+0x1c] */
            ii(0x1018_ceba, 2); rep_a32(() => movsb_a32());             /* rep movsb */
            ii(0x1018_cebc, 2); add(esi, ebx);                          /* add esi, ebx */
            ii(0x1018_cebe, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1018_cec0, 1); dec(eax);                               /* dec eax */
            ii(0x1018_cec1, 2); if(jnzd(0x1018_ceb7, -0xc)) goto l_0x1018_ceb7; /* jnz 0x1018ceb7 */
        l_0x1018_cec3:
            ii(0x1018_cec3, 3); or(eax, memd_a32[ss, ebp + 0x20]);      /* or eax, [ebp+0x20] */
            ii(0x1018_cec6, 2); if(jzd(0x1018_cf0c, 0x44)) goto l_0x1018_cf0c; /* jz 0x1018cf0c */
            ii(0x1018_cec8, 6); mov(ecx, memd_a32[ds, 0x1020_8910]);    /* mov ecx, [0x10208910] */
            ii(0x1018_cece, 2); sub(ecx, edi);                          /* sub ecx, edi */
            ii(0x1018_ced0, 2); if(jnsd(0x1018_ced7, 0x5)) goto l_0x1018_ced7; /* jns 0x1018ced7 */
            ii(0x1018_ced2, 5); mov(ecx, 0);                            /* mov ecx, 0x0 */
        l_0x1018_ced7:
            ii(0x1018_ced7, 1); pushd(ecx);                             /* push ecx */
            ii(0x1018_ced8, 2); rep_a32(() => movsb_a32());             /* rep movsb */
            ii(0x1018_ceda, 5); mov(eax, memd_a32[ds, 0x1020_88f0]);    /* mov eax, [0x102088f0] */
            ii(0x1018_cedf, 3); add(memd_a32[ss, ebp - 0x4], eax);      /* add [ebp-0x4], eax */
            ii(0x1018_cee2, 6); sub(edi, memd_a32[ds, 0x1020_8914]);    /* sub edi, [0x10208914] */
            ii(0x1018_cee8, 2); mov(bh, 0);                             /* mov bh, 0x0 */
            ii(0x1018_ceea, 6); mov(bl, memb_a32[ds, 0x1020_8900]);     /* mov bl, [0x10208900] */
            ii(0x1018_cef0, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1018_cef3, 6); calld_abs(memd_a32[ds, 0x1020_88fc]);   /* call dword [0x102088fc] */ /* Вызов '0x1018_cda8'. */
            ii(0x1018_cef9, 1); popd(eax);                              /* pop eax */
            ii(0x1018_cefa, 3); mov(ecx, memd_a32[ss, ebp + 0x1c]);     /* mov ecx, [ebp+0x1c] */
            ii(0x1018_cefd, 2); sub(ecx, eax);                          /* sub ecx, eax */
            ii(0x1018_ceff, 2); rep_a32(() => movsb_a32());             /* rep movsb */
            ii(0x1018_cf01, 3); add(esi, memd_a32[ss, ebp - 0x8]);      /* add esi, [ebp-0x8] */
            ii(0x1018_cf04, 3); add(edi, memd_a32[ss, ebp - 0x10]);     /* add edi, [ebp-0x10] */
            ii(0x1018_cf07, 3); dec(memd_a32[ss, ebp + 0x20]);          /* dec dword [ebp+0x20] */
            ii(0x1018_cf0a, 2); if(jnzd(0x1018_ce8d, -0x7f)) goto l_0x1018_ce8d; /* jnz 0x1018ce8d */
        l_0x1018_cf0c:
            ii(0x1018_cf0c, 1); popd(edi);                              /* pop edi */
            ii(0x1018_cf0d, 1); popd(esi);                              /* pop esi */
            ii(0x1018_cf0e, 1); popd(edx);                              /* pop edx */
            ii(0x1018_cf0f, 1); popd(ecx);                              /* pop ecx */
            ii(0x1018_cf10, 1); popd(ebx);                              /* pop ebx */
            ii(0x1018_cf11, 1); popd(eax);                              /* pop eax */
            ii(0x1018_cf12, 1); leaved();                               /* leave */
            ii(0x1018_cf13, 1); retd(); return;                         /* ret */
        }
    }
}