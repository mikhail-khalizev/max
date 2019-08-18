using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_33cd-a526b0")]
        public void /* sys */ Method_1019_33cd()
        {
            ii(0x1019_33cd, 1); pushd(ebp);                             /* push ebp */
            ii(0x1019_33ce, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1019_33d0, 3); add(esp, -0x14 /* 0xec */);             /* add esp, 0xffffffec */
            ii(0x1019_33d3, 1); pushd(esi);                             /* push esi */
            ii(0x1019_33d4, 1); pushd(edi);                             /* push edi */
            ii(0x1019_33d5, 1); pushd(ebx);                             /* push ebx */
            ii(0x1019_33d6, 3); mov(ax, ds);                            /* mov ax, ds */
            ii(0x1019_33d9, 3); mov(es, ax);                            /* mov es, ax */
            ii(0x1019_33dc, 3); mov(eax, memd_a32[ss, ebp + 0x1c]);     /* mov eax, [ebp+0x1c] */
            ii(0x1019_33df, 3); shr(eax, 0x2);                          /* shr eax, 0x2 */
            ii(0x1019_33e2, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1019_33e5, 7); cmp(memd_a32[ds, 0x101b_e204], 0x4);    /* cmp dword [0x101be204], 0x4 */
            ii(0x1019_33ec, 2); if(jnzd(0x1019_33f9, 0xb)) goto l_0x1019_33f9; /* jnz 0x101933f9 */
            ii(0x1019_33ee, 3); mov(eax, memd_a32[ss, ebp + 0xc]);      /* mov eax, [ebp+0xc] */
            ii(0x1019_33f1, 3); sub(eax, memd_a32[ss, ebp + 0x1c]);     /* sub eax, [ebp+0x1c] */
            ii(0x1019_33f4, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1019_33f7, 2); jmpd(0x1019_3401, 0x8); goto l_0x1019_3401; /* jmp 0x10193401 */
        l_0x1019_33f9:
            ii(0x1019_33f9, 5); mov(eax, memd_a32[ds, 0x1020_9dc8]);    /* mov eax, [0x10209dc8] */
            ii(0x1019_33fe, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
        l_0x1019_3401:
            ii(0x1019_3401, 5); mov(eax, memd_a32[ds, Definitions.video_bytes_per_line]); /* mov eax, [0x10209c98] */
            ii(0x1019_3406, 4); cmp(memd_a32[ss, ebp + 0x2c], 0);       /* cmp dword [ebp+0x2c], 0x0 */
            ii(0x1019_340a, 2); if(jzd(0x1019_340e, 0x2)) goto l_0x1019_340e; /* jz 0x1019340e */
            ii(0x1019_340c, 2); add(eax, eax);                          /* add eax, eax */
        l_0x1019_340e:
            ii(0x1019_340e, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1019_3411, 3); sub(eax, memd_a32[ss, ebp + 0x1c]);     /* sub eax, [ebp+0x1c] */
            ii(0x1019_3414, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1019_3417, 3); mov(eax, memd_a32[ss, ebp + 0x18]);     /* mov eax, [ebp+0x18] */
            ii(0x1019_341a, 3); mul(memd_a32[ss, ebp + 0xc]);           /* mul dword [ebp+0xc] */
            ii(0x1019_341d, 3); add(eax, memd_a32[ss, ebp + 0x14]);     /* add eax, [ebp+0x14] */
            ii(0x1019_3420, 3); add(memd_a32[ss, ebp + 0x8], eax);      /* add [ebp+0x8], eax */
            ii(0x1019_3423, 3); mov(eax, memd_a32[ss, ebp + 0x14]);     /* mov eax, [ebp+0x14] */
            ii(0x1019_3426, 3); add(memd_a32[ss, ebp + 0x24], eax);     /* add [ebp+0x24], eax */
            ii(0x1019_3429, 3); mov(eax, memd_a32[ss, ebp + 0xc]);      /* mov eax, [ebp+0xc] */
            ii(0x1019_342c, 2); shr(eax, 0x1);                          /* shr eax, 1 */
            ii(0x1019_342e, 4); cmp(memd_a32[ss, ebp + 0x2c], 0);       /* cmp dword [ebp+0x2c], 0x0 */
            ii(0x1019_3432, 2); if(jzd(0x1019_343c, 0x8)) goto l_0x1019_343c; /* jz 0x1019343c */
            ii(0x1019_3434, 3); cmp(memd_a32[ss, ebp + 0x14], eax);     /* cmp [ebp+0x14], eax */
            ii(0x1019_3437, 2); if(jbd(0x1019_343c, 0x3)) goto l_0x1019_343c; /* jb 0x1019343c */
            ii(0x1019_3439, 3); sub(memd_a32[ss, ebp + 0x24], eax);     /* sub [ebp+0x24], eax */
        l_0x1019_343c:
            ii(0x1019_343c, 3); mov(eax, memd_a32[ss, ebp + 0x18]);     /* mov eax, [ebp+0x18] */
            ii(0x1019_343f, 3); add(memd_a32[ss, ebp + 0x28], eax);     /* add [ebp+0x28], eax */
            ii(0x1019_3442, 7); cmp(memd_a32[ds, 0x1020_9c90], 0);      /* cmp dword [0x10209c90], 0x0 */
            ii(0x1019_3449, 6); if(jnzd(0x1019_34e7, 0x98)) goto l_0x1019_34e7; /* jnz 0x101934e7 */
            ii(0x1019_344f, 6); mov(edi, memd_a32[ds, Definitions.video_win_start]); /* mov edi, [0x10209ca8] */
            ii(0x1019_3455, 3); mov(eax, memd_a32[ss, ebp + 0x28]);     /* mov eax, [ebp+0x28] */
            ii(0x1019_3458, 3); mul(memd_a32[ss, ebp - 0x10]);          /* mul dword [ebp-0x10] */
            ii(0x1019_345b, 3); add(eax, memd_a32[ss, ebp + 0x24]);     /* add eax, [ebp+0x24] */
            ii(0x1019_345e, 2); add(edi, eax);                          /* add edi, eax */
            ii(0x1019_3460, 7); test(memd_a32[ss, ebp + 0x2c], 0x1);    /* test dword [ebp+0x2c], 0x1 */
            ii(0x1019_3467, 2); if(jzd(0x1019_346f, 0x6)) goto l_0x1019_346f; /* jz 0x1019346f */
            ii(0x1019_3469, 6); add(edi, memd_a32[ds, Definitions.video_bytes_per_line]); /* add edi, [0x10209c98] */
        l_0x1019_346f:
            ii(0x1019_346f, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1019_3472, 3); mov(edx, memd_a32[ss, ebp - 0x14]);     /* mov edx, [ebp-0x14] */
            ii(0x1019_3475, 3); mov(esi, memd_a32[ss, ebp + 0x8]);      /* mov esi, [ebp+0x8] */
            ii(0x1019_3478, 3); mov(ebx, memd_a32[ss, ebp + 0x20]);     /* mov ebx, [ebp+0x20] */
            ii(0x1019_347b, 7); cmp(memd_a32[ds, 0x101b_e204], 0x3);    /* cmp dword [0x101be204], 0x3 */
            ii(0x1019_3482, 2); if(jnzd(0x1019_34d6, 0x52)) goto l_0x1019_34d6; /* jnz 0x101934d6 */
            ii(0x1019_3484, 3); sub(edi, 0x8);                          /* sub edi, 0x8 */
        l_0x1019_3487:
            ii(0x1019_3487, 3); mov(ecx, memd_a32[ss, ebp - 0x8]);      /* mov ecx, [ebp-0x8] */
            ii(0x1019_348a, 3); shr(ecx, 0x2);                          /* shr ecx, 0x2 */
            ii(0x1019_348d, 3); mov(eax, eax);                          /* mov eax, eax */
        l_0x1019_3490:
            ii(0x1019_3490, 2); mov(eax, memd_a32[ds, esi]);            /* mov eax, [esi] */
            ii(0x1019_3492, 3); mov(memd_a32[ds, edi + 0x8], eax);      /* mov [edi+0x8], eax */
            ii(0x1019_3495, 3); mov(eax, memd_a32[ds, esi + 0x3]);      /* mov eax, [esi+0x3] */
            ii(0x1019_3498, 3); mov(memd_a32[ds, edi + 0xc], eax);      /* mov [edi+0xc], eax */
            ii(0x1019_349b, 3); add(edi, 0x10);                         /* add edi, 0x10 */
            ii(0x1019_349e, 3); mov(eax, memd_a32[ds, esi + 0x6]);      /* mov eax, [esi+0x6] */
            ii(0x1019_34a1, 2); mov(memd_a32[ds, edi], eax);            /* mov [edi], eax */
            ii(0x1019_34a3, 3); mov(eax, memd_a32[ds, esi + 0x9]);      /* mov eax, [esi+0x9] */
            ii(0x1019_34a6, 3); mov(memd_a32[ds, edi + 0x4], eax);      /* mov [edi+0x4], eax */
            ii(0x1019_34a9, 3); add(esi, 0xc);                          /* add esi, 0xc */
            ii(0x1019_34ac, 1); dec(ecx);                               /* dec ecx */
            ii(0x1019_34ad, 2); if(jnzd(0x1019_3490, -0x1f)) goto l_0x1019_3490; /* jnz 0x10193490 */
            ii(0x1019_34af, 2); mov(eax, memd_a32[ds, esi]);            /* mov eax, [esi] */
            ii(0x1019_34b1, 3); mov(memd_a32[ds, edi + 0x8], eax);      /* mov [edi+0x8], eax */
            ii(0x1019_34b4, 3); mov(eax, memd_a32[ds, esi + 0x3]);      /* mov eax, [esi+0x3] */
            ii(0x1019_34b7, 3); mov(memd_a32[ds, edi + 0xc], eax);      /* mov [edi+0xc], eax */
            ii(0x1019_34ba, 3); add(edi, 0xc);                          /* add edi, 0xc */
            ii(0x1019_34bd, 3); mov(eax, memd_a32[ds, esi + 0x6]);      /* mov eax, [esi+0x6] */
            ii(0x1019_34c0, 3); mov(memd_a32[ds, edi + 0x4], eax);      /* mov [edi+0x4], eax */
            ii(0x1019_34c3, 3); add(esi, 0x9);                          /* add esi, 0x9 */
            ii(0x1019_34c6, 3); add(esi, memd_a32[ss, ebp - 0xc]);      /* add esi, [ebp-0xc] */
            ii(0x1019_34c9, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1019_34cb, 1); dec(ebx);                               /* dec ebx */
            ii(0x1019_34cc, 2); if(jnzd(0x1019_3487, -0x47)) goto l_0x1019_3487; /* jnz 0x10193487 */
            ii(0x1019_34ce, 3); add(edi, 0x8);                          /* add edi, 0x8 */
            ii(0x1019_34d1, 5); jmpd(0x1019_3644, 0x16e); goto l_0x1019_3644; /* jmp 0x10193644 */
        l_0x1019_34d6:
            ii(0x1019_34d6, 3); mov(ecx, memd_a32[ss, ebp - 0x8]);      /* mov ecx, [ebp-0x8] */
            ii(0x1019_34d9, 2); rep_a32(() => movsd_a32());             /* rep movsd */
            ii(0x1019_34db, 2); add(esi, eax);                          /* add esi, eax */
            ii(0x1019_34dd, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1019_34df, 1); dec(ebx);                               /* dec ebx */
            ii(0x1019_34e0, 2); if(jnzd(0x1019_34d6, -0xc)) goto l_0x1019_34d6; /* jnz 0x101934d6 */
            ii(0x1019_34e2, 5); jmpd(0x1019_3644, 0x15d); goto l_0x1019_3644; /* jmp 0x10193644 */
        l_0x1019_34e7:
            ii(0x1019_34e7, 3); mov(esi, memd_a32[ss, ebp + 0x8]);      /* mov esi, [ebp+0x8] */
            ii(0x1019_34ea, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1019_34ed, 3); mul(memd_a32[ss, ebp + 0x28]);          /* mul dword [ebp+0x28] */
            ii(0x1019_34f0, 7); test(memd_a32[ss, ebp + 0x2c], 0x1);    /* test dword [ebp+0x2c], 0x1 */
            ii(0x1019_34f7, 2); if(jzd(0x1019_34ff, 0x6)) goto l_0x1019_34ff; /* jz 0x101934ff */
            ii(0x1019_34f9, 6); add(eax, memd_a32[ds, Definitions.video_bytes_per_line]); /* add eax, [0x10209c98] */
        l_0x1019_34ff:
            ii(0x1019_34ff, 3); add(eax, memd_a32[ss, ebp + 0x24]);     /* add eax, [ebp+0x24] */
            ii(0x1019_3502, 5); mov(edx, 0);                            /* mov edx, 0x0 */
            ii(0x1019_3507, 6); div(memd_a32[ds, Definitions.video_win_granularity]); /* div dword [0x10209ca4] */
            ii(0x1019_350d, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1019_3510, 2); mov(edi, edx);                          /* mov edi, edx */
            ii(0x1019_3512, 6); add(edi, memd_a32[ds, Definitions.video_win_start]); /* add edi, [0x10209ca8] */
            ii(0x1019_3518, 2); mov(bh, 0);                             /* mov bh, 0x0 */
            ii(0x1019_351a, 6); mov(bl, memb_a32[ds, 0x1020_9cb0]);     /* mov bl, [0x10209cb0] */
            ii(0x1019_3520, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1019_3523, 6); calld_abs(memd_a32[ds, 0x1020_9c90]);   /* call dword [0x10209c90] */
        l_0x1019_3529:
            ii(0x1019_3529, 5); mov(eax, memd_a32[ds, Definitions.video_win_end]); /* mov eax, [0x10209cac] */
            ii(0x1019_352e, 2); sub(eax, edi);                          /* sub eax, edi */
            ii(0x1019_3530, 3); add(eax, memd_a32[ss, ebp - 0x10]);     /* add eax, [ebp-0x10] */
            ii(0x1019_3533, 3); sub(eax, memd_a32[ss, ebp + 0x1c]);     /* sub eax, [ebp+0x1c] */
            ii(0x1019_3536, 5); mov(edx, 0);                            /* mov edx, 0x0 */
            ii(0x1019_353b, 3); div(memd_a32[ss, ebp - 0x10]);          /* div dword [ebp-0x10] */
            ii(0x1019_353e, 3); cmp(memd_a32[ss, ebp + 0x20], eax);     /* cmp [ebp+0x20], eax */
            ii(0x1019_3541, 2); if(jaed(0x1019_3546, 0x3)) goto l_0x1019_3546; /* jae 0x10193546 */
            ii(0x1019_3543, 3); mov(eax, memd_a32[ss, ebp + 0x20]);     /* mov eax, [ebp+0x20] */
        l_0x1019_3546:
            ii(0x1019_3546, 2); or(eax, eax);                           /* or eax, eax */
            ii(0x1019_3548, 2); if(jzd(0x1019_35b7, 0x6d)) goto l_0x1019_35b7; /* jz 0x101935b7 */
            ii(0x1019_354a, 3); sub(memd_a32[ss, ebp + 0x20], eax);     /* sub [ebp+0x20], eax */
            ii(0x1019_354d, 3); mov(ebx, memd_a32[ss, ebp - 0xc]);      /* mov ebx, [ebp-0xc] */
            ii(0x1019_3550, 3); mov(edx, memd_a32[ss, ebp - 0x14]);     /* mov edx, [ebp-0x14] */
            ii(0x1019_3553, 7); cmp(memd_a32[ds, 0x101b_e204], 0x3);    /* cmp dword [0x101be204], 0x3 */
            ii(0x1019_355a, 2); if(jnzd(0x1019_35ab, 0x4f)) goto l_0x1019_35ab; /* jnz 0x101935ab */
            ii(0x1019_355c, 3); sub(edi, 0x8);                          /* sub edi, 0x8 */
        l_0x1019_355f:
            ii(0x1019_355f, 3); mov(ecx, memd_a32[ss, ebp - 0x8]);      /* mov ecx, [ebp-0x8] */
            ii(0x1019_3562, 3); shr(ecx, 0x2);                          /* shr ecx, 0x2 */
            ii(0x1019_3565, 3); mov(eax, eax);                          /* mov eax, eax */
        l_0x1019_3568:
            ii(0x1019_3568, 2); mov(ebx, memd_a32[ds, esi]);            /* mov ebx, [esi] */
            ii(0x1019_356a, 3); mov(memd_a32[ds, edi + 0x8], ebx);      /* mov [edi+0x8], ebx */
            ii(0x1019_356d, 3); mov(ebx, memd_a32[ds, esi + 0x3]);      /* mov ebx, [esi+0x3] */
            ii(0x1019_3570, 3); mov(memd_a32[ds, edi + 0xc], ebx);      /* mov [edi+0xc], ebx */
            ii(0x1019_3573, 3); add(edi, 0x10);                         /* add edi, 0x10 */
            ii(0x1019_3576, 3); mov(ebx, memd_a32[ds, esi + 0x6]);      /* mov ebx, [esi+0x6] */
            ii(0x1019_3579, 2); mov(memd_a32[ds, edi], ebx);            /* mov [edi], ebx */
            ii(0x1019_357b, 3); mov(ebx, memd_a32[ds, esi + 0x9]);      /* mov ebx, [esi+0x9] */
            ii(0x1019_357e, 3); mov(memd_a32[ds, edi + 0x4], ebx);      /* mov [edi+0x4], ebx */
            ii(0x1019_3581, 3); add(esi, 0xc);                          /* add esi, 0xc */
            ii(0x1019_3584, 1); dec(ecx);                               /* dec ecx */
            ii(0x1019_3585, 2); if(jnzd(0x1019_3568, -0x1f)) goto l_0x1019_3568; /* jnz 0x10193568 */
            ii(0x1019_3587, 2); mov(ebx, memd_a32[ds, esi]);            /* mov ebx, [esi] */
            ii(0x1019_3589, 3); mov(memd_a32[ds, edi + 0x8], ebx);      /* mov [edi+0x8], ebx */
            ii(0x1019_358c, 3); mov(ebx, memd_a32[ds, esi + 0x3]);      /* mov ebx, [esi+0x3] */
            ii(0x1019_358f, 3); mov(memd_a32[ds, edi + 0xc], ebx);      /* mov [edi+0xc], ebx */
            ii(0x1019_3592, 3); add(edi, 0xc);                          /* add edi, 0xc */
            ii(0x1019_3595, 3); mov(ebx, memd_a32[ds, esi + 0x6]);      /* mov ebx, [esi+0x6] */
            ii(0x1019_3598, 3); mov(memd_a32[ds, edi + 0x4], ebx);      /* mov [edi+0x4], ebx */
            ii(0x1019_359b, 3); add(esi, 0x9);                          /* add esi, 0x9 */
            ii(0x1019_359e, 3); add(esi, memd_a32[ss, ebp - 0xc]);      /* add esi, [ebp-0xc] */
            ii(0x1019_35a1, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1019_35a3, 1); dec(eax);                               /* dec eax */
            ii(0x1019_35a4, 2); if(jnzd(0x1019_355f, -0x47)) goto l_0x1019_355f; /* jnz 0x1019355f */
            ii(0x1019_35a6, 3); add(edi, 0x8);                          /* add edi, 0x8 */
            ii(0x1019_35a9, 2); jmpd(0x1019_35b7, 0xc); goto l_0x1019_35b7; /* jmp 0x101935b7 */
        l_0x1019_35ab:
            ii(0x1019_35ab, 3); mov(ecx, memd_a32[ss, ebp - 0x8]);      /* mov ecx, [ebp-0x8] */
            ii(0x1019_35ae, 2); rep_a32(() => movsd_a32());             /* rep movsd */
            ii(0x1019_35b0, 2); add(esi, ebx);                          /* add esi, ebx */
            ii(0x1019_35b2, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1019_35b4, 1); dec(eax);                               /* dec eax */
            ii(0x1019_35b5, 2); if(jnzd(0x1019_35ab, -0xc)) goto l_0x1019_35ab; /* jnz 0x101935ab */
        l_0x1019_35b7:
            ii(0x1019_35b7, 3); or(eax, memd_a32[ss, ebp + 0x20]);      /* or eax, [ebp+0x20] */
            ii(0x1019_35ba, 6); if(jzd(0x1019_3644, 0x84)) goto l_0x1019_3644; /* jz 0x10193644 */
            ii(0x1019_35c0, 6); mov(ecx, memd_a32[ds, Definitions.video_win_end]); /* mov ecx, [0x10209cac] */
            ii(0x1019_35c6, 2); sub(ecx, edi);                          /* sub ecx, edi */
            ii(0x1019_35c8, 3); sar(ecx, 0x2);                          /* sar ecx, 0x2 */
            ii(0x1019_35cb, 2); if(jnsd(0x1019_35d2, 0x5)) goto l_0x1019_35d2; /* jns 0x101935d2 */
            ii(0x1019_35cd, 5); mov(ecx, 0);                            /* mov ecx, 0x0 */
        l_0x1019_35d2:
            ii(0x1019_35d2, 1); pushd(ecx);                             /* push ecx */
            ii(0x1019_35d3, 7); cmp(memd_a32[ds, 0x101b_e204], 0x3);    /* cmp dword [0x101be204], 0x3 */
            ii(0x1019_35da, 2); if(jnzd(0x1019_35ef, 0x13)) goto l_0x1019_35ef; /* jnz 0x101935ef */
            ii(0x1019_35dc, 2); or(ecx, ecx);                           /* or ecx, ecx */
            ii(0x1019_35de, 2); if(jzd(0x1019_35ed, 0xd)) goto l_0x1019_35ed; /* jz 0x101935ed */
        l_0x1019_35e0:
            ii(0x1019_35e0, 2); mov(eax, memd_a32[ds, esi]);            /* mov eax, [esi] */
            ii(0x1019_35e2, 2); mov(memd_a32[ds, edi], eax);            /* mov [edi], eax */
            ii(0x1019_35e4, 3); add(esi, 0x3);                          /* add esi, 0x3 */
            ii(0x1019_35e7, 3); add(edi, 0x4);                          /* add edi, 0x4 */
            ii(0x1019_35ea, 1); dec(ecx);                               /* dec ecx */
            ii(0x1019_35eb, 2); if(jnzd(0x1019_35e0, -0xd)) goto l_0x1019_35e0; /* jnz 0x101935e0 */
        l_0x1019_35ed:
            ii(0x1019_35ed, 2); jmpd(0x1019_35f1, 0x2); goto l_0x1019_35f1; /* jmp 0x101935f1 */
        l_0x1019_35ef:
            ii(0x1019_35ef, 2); rep_a32(() => movsd_a32());             /* rep movsd */
        l_0x1019_35f1:
            ii(0x1019_35f1, 5); mov(eax, memd_a32[ds, Definitions.video_bank_count_in_win]); /* mov eax, [0x10209c9c] */
            ii(0x1019_35f6, 3); add(memd_a32[ss, ebp - 0x4], eax);      /* add [ebp-0x4], eax */
            ii(0x1019_35f9, 6); sub(edi, memd_a32[ds, Definitions.video_win_len]); /* sub edi, [0x10209ca0] */
            ii(0x1019_35ff, 2); mov(bh, 0);                             /* mov bh, 0x0 */
            ii(0x1019_3601, 6); mov(bl, memb_a32[ds, 0x1020_9cb0]);     /* mov bl, [0x10209cb0] */
            ii(0x1019_3607, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1019_360a, 6); calld_abs(memd_a32[ds, 0x1020_9c90]);   /* call dword [0x10209c90] */
            ii(0x1019_3610, 1); popd(eax);                              /* pop eax */
            ii(0x1019_3611, 3); mov(ecx, memd_a32[ss, ebp - 0x8]);      /* mov ecx, [ebp-0x8] */
            ii(0x1019_3614, 2); sub(ecx, eax);                          /* sub ecx, eax */
            ii(0x1019_3616, 7); cmp(memd_a32[ds, 0x101b_e204], 0x3);    /* cmp dword [0x101be204], 0x3 */
            ii(0x1019_361d, 2); if(jnzd(0x1019_3633, 0x14)) goto l_0x1019_3633; /* jnz 0x10193633 */
            ii(0x1019_361f, 1); nop();                                  /* nop */
            ii(0x1019_3620, 2); or(ecx, ecx);                           /* or ecx, ecx */
            ii(0x1019_3622, 2); if(jzd(0x1019_3631, 0xd)) goto l_0x1019_3631; /* jz 0x10193631 */
        l_0x1019_3624:
            ii(0x1019_3624, 2); mov(eax, memd_a32[ds, esi]);            /* mov eax, [esi] */
            ii(0x1019_3626, 2); mov(memd_a32[ds, edi], eax);            /* mov [edi], eax */
            ii(0x1019_3628, 3); add(esi, 0x3);                          /* add esi, 0x3 */
            ii(0x1019_362b, 3); add(edi, 0x4);                          /* add edi, 0x4 */
            ii(0x1019_362e, 1); dec(ecx);                               /* dec ecx */
            ii(0x1019_362f, 2); if(jnzd(0x1019_3624, -0xd)) goto l_0x1019_3624; /* jnz 0x10193624 */
        l_0x1019_3631:
            ii(0x1019_3631, 2); jmpd(0x1019_3635, 0x2); goto l_0x1019_3635; /* jmp 0x10193635 */
        l_0x1019_3633:
            ii(0x1019_3633, 2); rep_a32(() => movsd_a32());             /* rep movsd */
        l_0x1019_3635:
            ii(0x1019_3635, 3); add(esi, memd_a32[ss, ebp - 0xc]);      /* add esi, [ebp-0xc] */
            ii(0x1019_3638, 3); add(edi, memd_a32[ss, ebp - 0x14]);     /* add edi, [ebp-0x14] */
            ii(0x1019_363b, 3); dec(memd_a32[ss, ebp + 0x20]);          /* dec dword [ebp+0x20] */
            ii(0x1019_363e, 6); if(jnzd(0x1019_3529, -0x11b)) goto l_0x1019_3529; /* jnz 0x10193529 */
        l_0x1019_3644:
            ii(0x1019_3644, 1); popd(ebx);                              /* pop ebx */
            ii(0x1019_3645, 1); popd(edi);                              /* pop edi */
            ii(0x1019_3646, 1); popd(esi);                              /* pop esi */
            ii(0x1019_3647, 1); leaved();                               /* leave */
            ii(0x1019_3648, 1); retd(); return;                         /* ret */
        }
    }
}
