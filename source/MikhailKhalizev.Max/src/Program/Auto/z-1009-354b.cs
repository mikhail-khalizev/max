using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("d18e5c29-89fa-4018-891c-b7d258de5f92")]
        public void Method_1009_354b()
        {
            ii(0x1009_354b, 5); pushd(0xa0);                            /* push 0xa0 */
            ii(0x1009_3550, 5); calld(Definitions.sys_check_available_stack_size, 0xd_27fd); /* call 0x10165d52 */
            ii(0x1009_3555, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_3556, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_3557, 1); pushd(edx);                             /* push edx */
            ii(0x1009_3558, 1); pushd(esi);                             /* push esi */
            ii(0x1009_3559, 1); pushd(edi);                             /* push edi */
            ii(0x1009_355a, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_355b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_355d, 6); sub(esp, 0x74);                         /* sub esp, 0x74 */
            ii(0x1009_3563, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1009_3566, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1009_3569, 5); calld(0x1007_20b1, -0x2_14bd);          /* call 0x100720b1 */
            ii(0x1009_356e, 3); lea(eax, ebp - 0x40);                   /* lea eax, [ebp-0x40] */
            ii(0x1009_3571, 5); calld(0x1007_20b1, -0x2_14c5);          /* call 0x100720b1 */
            ii(0x1009_3576, 7); mov(memd_a32[ss, ebp - 0x14], 0);       /* mov dword [ebp-0x14], 0x0 */
            ii(0x1009_357d, 7); mov(memd_a32[ss, ebp - 0xc], 0);        /* mov dword [ebp-0xc], 0x0 */
            ii(0x1009_3584, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
            ii(0x1009_358b, 4); or(memb_a32[ss, ebp - 0x8], 0x1);       /* or byte [ebp-0x8], 0x1 */
            ii(0x1009_358f, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1009_3592, 5); calld(0x1007_64fc, -0x1_d09b);          /* call 0x100764fc */
            ii(0x1009_3597, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1009_359a, 4); and(memb_a32[ss, ebp - 0x8], -0x2 /* 0xfe */); /* and byte [ebp-0x8], 0xfe */
            ii(0x1009_359e, 4); or(memb_a32[ss, ebp - 0x8], 0x1);       /* or byte [ebp-0x8], 0x1 */
            ii(0x1009_35a2, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1009_35a5, 5); calld(0x1009_c620, 0x9076);             /* call 0x1009c620 */
            ii(0x1009_35aa, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1009_35ad, 4); and(memb_a32[ss, ebp - 0x8], -0x2 /* 0xfe */); /* and byte [ebp-0x8], 0xfe */
            ii(0x1009_35b1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_35b4, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1009_35b7, 5); calld(0x1007_6338, -0x1_d284);          /* call 0x10076338 */
            ii(0x1009_35bc, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_35be, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1009_35c1, 5); calld(0x1007_643c, -0x1_d18a);          /* call 0x1007643c */
            ii(0x1009_35c6, 2); jmpd(0x1009_35d0, 0x8); goto l_0x1009_35d0; /* jmp 0x100935d0 */
        l_0x1009_35c8:
            ii(0x1009_35c8, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1009_35cb, 5); calld(0x1007_6bf8, -0x1_c9d8);          /* call 0x10076bf8 */
        l_0x1009_35d0:
            ii(0x1009_35d0, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_35d2, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1009_35d5, 5); calld(0x1013_ad71, 0xa_7797);           /* call 0x1013ad71 */
            ii(0x1009_35da, 2); test(al, al);                           /* test al, al */
            ii(0x1009_35dc, 6); if(jzd(0x1009_36e5, 0x103)) goto l_0x1009_36e5; /* jz 0x100936e5 */
            ii(0x1009_35e2, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1009_35e5, 5); calld(0x1007_63a0, -0x1_d24a);          /* call 0x100763a0 */
            ii(0x1009_35ea, 5); cmp(memw_a32[ds, eax + 0x8], 0x28);     /* cmp word [eax+0x8], 0x28 */
            ii(0x1009_35ef, 2); if(jnzd(0x1009_3621, 0x30)) goto l_0x1009_3621; /* jnz 0x10093621 */
            ii(0x1009_35f1, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1009_35f4, 5); calld(0x1007_63a0, -0x1_d259);          /* call 0x100763a0 */
            ii(0x1009_35f9, 3); mov(al, memb_a32[ds, eax + 0x4a]);      /* mov al, [eax+0x4a] */
            ii(0x1009_35fc, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1009_35fe, 3); add(memd_a32[ss, ebp - 0xc], eax);      /* add [ebp-0xc], eax */
            ii(0x1009_3601, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1009_3604, 5); calld(0x1007_63a0, -0x1_d269);          /* call 0x100763a0 */
            ii(0x1009_3609, 3); mov(al, memb_a32[ds, eax + 0x4c]);      /* mov al, [eax+0x4c] */
            ii(0x1009_360c, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1009_360e, 3); add(memd_a32[ss, ebp - 0x10], eax);     /* add [ebp-0x10], eax */
            ii(0x1009_3611, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1009_3614, 5); calld(0x1007_63a0, -0x1_d279);          /* call 0x100763a0 */
            ii(0x1009_3619, 3); mov(al, memb_a32[ds, eax + 0x4b]);      /* mov al, [eax+0x4b] */
            ii(0x1009_361c, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1009_361e, 3); add(memd_a32[ss, ebp - 0x14], eax);     /* add [ebp-0x14], eax */
        l_0x1009_3621:
            ii(0x1009_3621, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1009_3624, 5); calld(0x1007_63a0, -0x1_d289);          /* call 0x100763a0 */
            ii(0x1009_3629, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x1009_362c, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_362f, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x1009_3632, 6); mov(al, memb_a32[ds, eax + 0x101c_81d5]); /* mov al, [eax+0x101c81d5] */
            ii(0x1009_3638, 3); mov(memb_a32[ss, ebp - 0x44], al);      /* mov [ebp-0x44], al */
            ii(0x1009_363b, 5); jmpd(0x1009_36ba, 0x7a); goto l_0x1009_36ba; /* jmp 0x100936ba */
        l_0x1009_3640:
            ii(0x1009_3640, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1009_3643, 5); calld(0x1007_63a0, -0x1_d2a8);          /* call 0x100763a0 */
            ii(0x1009_3648, 4); mov(ax, memw_a32[ds, eax + 0x52]);      /* mov ax, [eax+0x52] */
            ii(0x1009_364c, 4); add(memw_a32[ss, ebp - 0x32], ax);      /* add [ebp-0x32], ax */
            ii(0x1009_3650, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1009_3653, 5); calld(0x1007_63a0, -0x1_d2b8);          /* call 0x100763a0 */
            ii(0x1009_3658, 5); calld(0x1007_623c, -0x1_d421);          /* call 0x1007623c */
            ii(0x1009_365d, 4); mov(ax, memw_a32[ds, eax + 0x19]);      /* mov ax, [eax+0x19] */
            ii(0x1009_3661, 4); add(memw_a32[ss, ebp - 0x3e], ax);      /* add [ebp-0x3e], ax */
            ii(0x1009_3665, 5); jmpd(0x1009_36e0, 0x76); goto l_0x1009_36e0; /* jmp 0x100936e0 */
        l_0x1009_366a:
            ii(0x1009_366a, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1009_366d, 5); calld(0x1007_63a0, -0x1_d2d2);          /* call 0x100763a0 */
            ii(0x1009_3672, 4); mov(ax, memw_a32[ds, eax + 0x52]);      /* mov ax, [eax+0x52] */
            ii(0x1009_3676, 4); add(memw_a32[ss, ebp - 0x30], ax);      /* add [ebp-0x30], ax */
            ii(0x1009_367a, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1009_367d, 5); calld(0x1007_63a0, -0x1_d2e2);          /* call 0x100763a0 */
            ii(0x1009_3682, 5); calld(0x1007_623c, -0x1_d44b);          /* call 0x1007623c */
            ii(0x1009_3687, 4); mov(ax, memw_a32[ds, eax + 0x19]);      /* mov ax, [eax+0x19] */
            ii(0x1009_368b, 4); add(memw_a32[ss, ebp - 0x3c], ax);      /* add [ebp-0x3c], ax */
            ii(0x1009_368f, 2); jmpd(0x1009_36e0, 0x4f); goto l_0x1009_36e0; /* jmp 0x100936e0 */
        l_0x1009_3691:
            ii(0x1009_3691, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1009_3694, 5); calld(0x1007_63a0, -0x1_d2f9);          /* call 0x100763a0 */
            ii(0x1009_3699, 4); mov(ax, memw_a32[ds, eax + 0x52]);      /* mov ax, [eax+0x52] */
            ii(0x1009_369d, 4); add(memw_a32[ss, ebp - 0x34], ax);      /* add [ebp-0x34], ax */
            ii(0x1009_36a1, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1009_36a4, 5); calld(0x1007_63a0, -0x1_d309);          /* call 0x100763a0 */
            ii(0x1009_36a9, 5); calld(0x1007_623c, -0x1_d472);          /* call 0x1007623c */
            ii(0x1009_36ae, 4); mov(ax, memw_a32[ds, eax + 0x19]);      /* mov ax, [eax+0x19] */
            ii(0x1009_36b2, 4); add(memw_a32[ss, ebp - 0x40], ax);      /* add [ebp-0x40], ax */
            ii(0x1009_36b6, 2); jmpd(0x1009_36e0, 0x28); goto l_0x1009_36e0; /* jmp 0x100936e0 */
        l_0x1009_36b8:
            ii(0x1009_36b8, 2); jmpd(0x1009_36e0, 0x26); goto l_0x1009_36e0; /* jmp 0x100936e0 */
        l_0x1009_36ba:
            ii(0x1009_36ba, 3); mov(al, memb_a32[ss, ebp - 0x44]);      /* mov al, [ebp-0x44] */
            ii(0x1009_36bd, 3); mov(memb_a32[ss, ebp - 0x48], al);      /* mov [ebp-0x48], al */
            ii(0x1009_36c0, 4); cmp(memb_a32[ss, ebp - 0x48], 0x2);     /* cmp byte [ebp-0x48], 0x2 */
            ii(0x1009_36c4, 2); if(jbd(0x1009_36d4, 0xe)) goto l_0x1009_36d4; /* jb 0x100936d4 */
            ii(0x1009_36c6, 4); cmp(memb_a32[ss, ebp - 0x48], 0x2);     /* cmp byte [ebp-0x48], 0x2 */
            ii(0x1009_36ca, 2); if(jbed(0x1009_366a, -0x62)) goto l_0x1009_366a; /* jbe 0x1009366a */
            ii(0x1009_36cc, 4); cmp(memb_a32[ss, ebp - 0x48], 0x3);     /* cmp byte [ebp-0x48], 0x3 */
            ii(0x1009_36d0, 2); if(jzd(0x1009_3691, -0x41)) goto l_0x1009_3691; /* jz 0x10093691 */
            ii(0x1009_36d2, 2); jmpd(0x1009_36b8, -0x1c); goto l_0x1009_36b8; /* jmp 0x100936b8 */
        l_0x1009_36d4:
            ii(0x1009_36d4, 4); cmp(memb_a32[ss, ebp - 0x48], 0x1);     /* cmp byte [ebp-0x48], 0x1 */
            ii(0x1009_36d8, 6); if(jzd(0x1009_3640, -0x9e)) goto l_0x1009_3640; /* jz 0x10093640 */
            ii(0x1009_36de, 2); jmpd(0x1009_36b8, -0x28); goto l_0x1009_36b8; /* jmp 0x100936b8 */
        l_0x1009_36e0:
            ii(0x1009_36e0, 5); jmpd(0x1009_35c8, -0x11d); goto l_0x1009_35c8; /* jmp 0x100935c8 */
        l_0x1009_36e5:
            ii(0x1009_36e5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_36e8, 3); mov(eax, memd_a32[ds, eax + 0x7]);      /* mov eax, [eax+0x7] */
            ii(0x1009_36eb, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_36ee, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1009_36f4, 6); mov(eax, memd_a32[ds, eax + 0x101c_a562]); /* mov eax, [eax+0x101ca562] */
            ii(0x1009_36fa, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1009_36fd, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_3700, 3); add(eax, 0x21);                         /* add eax, 0x21 */
            ii(0x1009_3703, 5); calld(0x1009_c6c8, 0x8fc0);             /* call 0x1009c6c8 */
            ii(0x1009_3708, 3); lea(ebx, ebp - 0x24);                   /* lea ebx, [ebp-0x24] */
            ii(0x1009_370b, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_370d, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1009_370f, 5); calld(0x1009_c560, 0x8e4c);             /* call 0x1009c560 */
            ii(0x1009_3714, 2); jmpd(0x1009_371e, 0x8); goto l_0x1009_371e; /* jmp 0x1009371e */
        l_0x1009_3716:
            ii(0x1009_3716, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1009_3719, 5); calld(0x1007_6bf8, -0x1_cb26);          /* call 0x10076bf8 */
        l_0x1009_371e:
            ii(0x1009_371e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_3720, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1009_3723, 5); calld(0x1013_ad71, 0xa_7649);           /* call 0x1013ad71 */
            ii(0x1009_3728, 2); test(al, al);                           /* test al, al */
            ii(0x1009_372a, 6); if(jzd(0x1009_3868, 0x138)) goto l_0x1009_3868; /* jz 0x10093868 */
            ii(0x1009_3730, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1009_3733, 5); calld(0x1009_c4f8, 0x8dc0);             /* call 0x1009c4f8 */
            ii(0x1009_3738, 5); calld(0x1009_c4c4, 0x8d87);             /* call 0x1009c4c4 */
            ii(0x1009_373d, 4); cmp(ax, 0x28);                          /* cmp ax, 0x28 */
            ii(0x1009_3741, 2); if(jnzd(0x1009_375e, 0x1b)) goto l_0x1009_375e; /* jnz 0x1009375e */
            ii(0x1009_3743, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1009_3746, 5); calld(0x1009_c4f8, 0x8dad);             /* call 0x1009c4f8 */
            ii(0x1009_374b, 3); mov(memd_a32[ss, ebp - 0x4c], eax);     /* mov [ebp-0x4c], eax */
            ii(0x1009_374e, 3); mov(eax, memd_a32[ss, ebp - 0x4c]);     /* mov eax, [ebp-0x4c] */
            ii(0x1009_3751, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x1009_3754, 3); mov(eax, memd_a32[ss, ebp - 0x4c]);     /* mov eax, [ebp-0x4c] */
            ii(0x1009_3757, 3); calld_abs(memd_a32[ds, edx + 0x70]);    /* call dword [edx+0x70] */
            ii(0x1009_375a, 2); test(al, al);                           /* test al, al */
            ii(0x1009_375c, 2); if(jnzd(0x1009_3760, 0x2)) goto l_0x1009_3760; /* jnz 0x10093760 */
        l_0x1009_375e:
            ii(0x1009_375e, 2); jmpd(0x1009_37b6, 0x56); goto l_0x1009_37b6; /* jmp 0x100937b6 */
        l_0x1009_3760:
            ii(0x1009_3760, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1009_3763, 5); calld(0x1009_c4f8, 0x8d90);             /* call 0x1009c4f8 */
            ii(0x1009_3768, 3); mov(memd_a32[ss, ebp - 0x50], eax);     /* mov [ebp-0x50], eax */
            ii(0x1009_376b, 3); mov(eax, memd_a32[ss, ebp - 0x50]);     /* mov eax, [ebp-0x50] */
            ii(0x1009_376e, 3); mov(ecx, memd_a32[ds, eax + 0x2]);      /* mov ecx, [eax+0x2] */
            ii(0x1009_3771, 3); lea(edx, ebp - 0x60);                   /* lea edx, [ebp-0x60] */
            ii(0x1009_3774, 3); mov(eax, memd_a32[ss, ebp - 0x50]);     /* mov eax, [ebp-0x50] */
            ii(0x1009_3777, 3); calld_abs(memd_a32[ds, ecx + 0x1c]);    /* call dword [ecx+0x1c] */
            ii(0x1009_377a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_377d, 3); mov(eax, memd_a32[ds, eax + 0x7]);      /* mov eax, [eax+0x7] */
            ii(0x1009_3780, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_3783, 1); pushd(eax);                             /* push eax */
            ii(0x1009_3784, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1009_3786, 1); pushd(eax);                             /* push eax */
            ii(0x1009_3787, 3); lea(eax, ebp - 0x64);                   /* lea eax, [ebp-0x64] */
            ii(0x1009_378a, 1); pushd(eax);                             /* push eax */
            ii(0x1009_378b, 3); lea(eax, ebp - 0x68);                   /* lea eax, [ebp-0x68] */
            ii(0x1009_378e, 1); pushd(eax);                             /* push eax */
            ii(0x1009_378f, 3); lea(ecx, ebp - 0x6c);                   /* lea ecx, [ebp-0x6c] */
            ii(0x1009_3792, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1009_3797, 4); movsx(edx, memw_a32[ss, ebp - 0x5c]);   /* movsx edx, word [ebp-0x5c] */
            ii(0x1009_379b, 4); movsx(eax, memw_a32[ss, ebp - 0x60]);   /* movsx eax, word [ebp-0x60] */
            ii(0x1009_379f, 5); calld(0x1014_2d0b, 0xa_f567);           /* call 0x10142d0b */
            ii(0x1009_37a4, 3); mov(eax, memd_a32[ss, ebp - 0x6c]);     /* mov eax, [ebp-0x6c] */
            ii(0x1009_37a7, 3); add(memd_a32[ss, ebp - 0xc], eax);      /* add [ebp-0xc], eax */
            ii(0x1009_37aa, 3); mov(eax, memd_a32[ss, ebp - 0x68]);     /* mov eax, [ebp-0x68] */
            ii(0x1009_37ad, 3); add(memd_a32[ss, ebp - 0x14], eax);     /* add [ebp-0x14], eax */
            ii(0x1009_37b0, 3); mov(eax, memd_a32[ss, ebp - 0x64]);     /* mov eax, [ebp-0x64] */
            ii(0x1009_37b3, 3); add(memd_a32[ss, ebp - 0x10], eax);     /* add [ebp-0x10], eax */
        l_0x1009_37b6:
            ii(0x1009_37b6, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1009_37b9, 5); calld(0x1009_c4f8, 0x8d3a);             /* call 0x1009c4f8 */
            ii(0x1009_37be, 5); calld(0x1009_c4c4, 0x8d01);             /* call 0x1009c4c4 */
            ii(0x1009_37c3, 1); cwde();                                 /* cwde */
            ii(0x1009_37c4, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x1009_37c7, 6); mov(al, memb_a32[ds, eax + 0x101c_81d5]); /* mov al, [eax+0x101c81d5] */
            ii(0x1009_37cd, 3); mov(memb_a32[ss, ebp - 0x70], al);      /* mov [ebp-0x70], al */
            ii(0x1009_37d0, 2); jmpd(0x1009_383d, 0x6b); goto l_0x1009_383d; /* jmp 0x1009383d */
        l_0x1009_37d2:
            ii(0x1009_37d2, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1009_37d5, 5); calld(0x1009_c4f8, 0x8d1e);             /* call 0x1009c4f8 */
            ii(0x1009_37da, 5); calld(0x1009_c4c4, 0x8ce5);             /* call 0x1009c4c4 */
            ii(0x1009_37df, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1009_37e2, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1009_37e5, 5); calld(0x1008_b104, -0x86e6);            /* call 0x1008b104 */
            ii(0x1009_37ea, 4); mov(ax, memw_a32[ds, eax + 0x19]);      /* mov ax, [eax+0x19] */
            ii(0x1009_37ee, 4); add(memw_a32[ss, ebp - 0x3e], ax);      /* add [ebp-0x3e], ax */
            ii(0x1009_37f2, 5); jmpd(0x1009_3863, 0x6c); goto l_0x1009_3863; /* jmp 0x10093863 */
        l_0x1009_37f7:
            ii(0x1009_37f7, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1009_37fa, 5); calld(0x1009_c4f8, 0x8cf9);             /* call 0x1009c4f8 */
            ii(0x1009_37ff, 5); calld(0x1009_c4c4, 0x8cc0);             /* call 0x1009c4c4 */
            ii(0x1009_3804, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1009_3807, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1009_380a, 5); calld(0x1008_b104, -0x870b);            /* call 0x1008b104 */
            ii(0x1009_380f, 4); mov(ax, memw_a32[ds, eax + 0x19]);      /* mov ax, [eax+0x19] */
            ii(0x1009_3813, 4); add(memw_a32[ss, ebp - 0x3c], ax);      /* add [ebp-0x3c], ax */
            ii(0x1009_3817, 2); jmpd(0x1009_3863, 0x4a); goto l_0x1009_3863; /* jmp 0x10093863 */
        l_0x1009_3819:
            ii(0x1009_3819, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1009_381c, 5); calld(0x1009_c4f8, 0x8cd7);             /* call 0x1009c4f8 */
            ii(0x1009_3821, 5); calld(0x1009_c4c4, 0x8c9e);             /* call 0x1009c4c4 */
            ii(0x1009_3826, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1009_3829, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1009_382c, 5); calld(0x1008_b104, -0x872d);            /* call 0x1008b104 */
            ii(0x1009_3831, 4); mov(ax, memw_a32[ds, eax + 0x19]);      /* mov ax, [eax+0x19] */
            ii(0x1009_3835, 4); add(memw_a32[ss, ebp - 0x40], ax);      /* add [ebp-0x40], ax */
            ii(0x1009_3839, 2); jmpd(0x1009_3863, 0x28); goto l_0x1009_3863; /* jmp 0x10093863 */
        l_0x1009_383b:
            ii(0x1009_383b, 2); jmpd(0x1009_3863, 0x26); goto l_0x1009_3863; /* jmp 0x10093863 */
        l_0x1009_383d:
            ii(0x1009_383d, 3); mov(al, memb_a32[ss, ebp - 0x70]);      /* mov al, [ebp-0x70] */
            ii(0x1009_3840, 3); mov(memb_a32[ss, ebp - 0x74], al);      /* mov [ebp-0x74], al */
            ii(0x1009_3843, 4); cmp(memb_a32[ss, ebp - 0x74], 0x2);     /* cmp byte [ebp-0x74], 0x2 */
            ii(0x1009_3847, 2); if(jbd(0x1009_3857, 0xe)) goto l_0x1009_3857; /* jb 0x10093857 */
            ii(0x1009_3849, 4); cmp(memb_a32[ss, ebp - 0x74], 0x2);     /* cmp byte [ebp-0x74], 0x2 */
            ii(0x1009_384d, 2); if(jbed(0x1009_37f7, -0x58)) goto l_0x1009_37f7; /* jbe 0x100937f7 */
            ii(0x1009_384f, 4); cmp(memb_a32[ss, ebp - 0x74], 0x3);     /* cmp byte [ebp-0x74], 0x3 */
            ii(0x1009_3853, 2); if(jzd(0x1009_3819, -0x3c)) goto l_0x1009_3819; /* jz 0x10093819 */
            ii(0x1009_3855, 2); jmpd(0x1009_383b, -0x1c); goto l_0x1009_383b; /* jmp 0x1009383b */
        l_0x1009_3857:
            ii(0x1009_3857, 4); cmp(memb_a32[ss, ebp - 0x74], 0x1);     /* cmp byte [ebp-0x74], 0x1 */
            ii(0x1009_385b, 6); if(jzd(0x1009_37d2, -0x8f)) goto l_0x1009_37d2; /* jz 0x100937d2 */
            ii(0x1009_3861, 2); jmpd(0x1009_383b, -0x28); goto l_0x1009_383b; /* jmp 0x1009383b */
        l_0x1009_3863:
            ii(0x1009_3863, 5); jmpd(0x1009_3716, -0x152); goto l_0x1009_3716; /* jmp 0x10093716 */
        l_0x1009_3868:
            ii(0x1009_3868, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1009_386c, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1009_386e, 2); if(jled(0x1009_388c, 0x1c)) goto l_0x1009_388c; /* jle 0x1009388c */
            ii(0x1009_3870, 4); movsx(edx, memw_a32[ss, ebp - 0x3e]);   /* movsx edx, word [ebp-0x3e] */
            ii(0x1009_3874, 3); lea(edx, edx + edx * 2);                /* lea edx, [edx+edx*2] */
            ii(0x1009_3877, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1009_3879, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1009_387c, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x1009_387f, 2); sbb(eax, edx);                          /* sbb eax, edx */
            ii(0x1009_3881, 3); sar(eax, 0x2);                          /* sar eax, 0x2 */
            ii(0x1009_3884, 4); movsx(edx, memw_a32[ss, ebp - 0x32]);   /* movsx edx, word [ebp-0x32] */
            ii(0x1009_3888, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1009_388a, 2); if(jged(0x1009_388e, 0x2)) goto l_0x1009_388e; /* jge 0x1009388e */
        l_0x1009_388c:
            ii(0x1009_388c, 2); jmpd(0x1009_3899, 0xb); goto l_0x1009_3899; /* jmp 0x10093899 */
        l_0x1009_388e:
            ii(0x1009_388e, 4); movsx(eax, memw_a32[ss, ebp - 0x3e]);   /* movsx eax, word [ebp-0x3e] */
            ii(0x1009_3892, 5); cmp(eax, 0x1f4);                        /* cmp eax, 0x1f4 */
            ii(0x1009_3897, 2); if(jld(0x1009_389b, 0x2)) goto l_0x1009_389b; /* jl 0x1009389b */
        l_0x1009_3899:
            ii(0x1009_3899, 2); jmpd(0x1009_38b0, 0x15); goto l_0x1009_38b0; /* jmp 0x100938b0 */
        l_0x1009_389b:
            ii(0x1009_389b, 5); mov(ecx, 0xa00);                        /* mov ecx, 0xa00 */
            ii(0x1009_38a0, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x1009_38a3, 5); mov(edx, 0x6);                          /* mov edx, 0x6 */
            ii(0x1009_38a8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_38ab, 5); calld(0x1009_6e02, 0x3552);             /* call 0x10096e02 */
        l_0x1009_38b0:
            ii(0x1009_38b0, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1009_38b4, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1009_38b6, 2); if(jled(0x1009_38d4, 0x1c)) goto l_0x1009_38d4; /* jle 0x100938d4 */
            ii(0x1009_38b8, 4); movsx(edx, memw_a32[ss, ebp - 0x3c]);   /* movsx edx, word [ebp-0x3c] */
            ii(0x1009_38bc, 3); lea(edx, edx + edx * 2);                /* lea edx, [edx+edx*2] */
            ii(0x1009_38bf, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1009_38c1, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1009_38c4, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x1009_38c7, 2); sbb(eax, edx);                          /* sbb eax, edx */
            ii(0x1009_38c9, 3); sar(eax, 0x2);                          /* sar eax, 0x2 */
            ii(0x1009_38cc, 4); movsx(edx, memw_a32[ss, ebp - 0x30]);   /* movsx edx, word [ebp-0x30] */
            ii(0x1009_38d0, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1009_38d2, 2); if(jged(0x1009_38d6, 0x2)) goto l_0x1009_38d6; /* jge 0x100938d6 */
        l_0x1009_38d4:
            ii(0x1009_38d4, 2); jmpd(0x1009_38e1, 0xb); goto l_0x1009_38e1; /* jmp 0x100938e1 */
        l_0x1009_38d6:
            ii(0x1009_38d6, 4); movsx(eax, memw_a32[ss, ebp - 0x3c]);   /* movsx eax, word [ebp-0x3c] */
            ii(0x1009_38da, 5); cmp(eax, 0x1f4);                        /* cmp eax, 0x1f4 */
            ii(0x1009_38df, 2); if(jld(0x1009_38e3, 0x2)) goto l_0x1009_38e3; /* jl 0x100938e3 */
        l_0x1009_38e1:
            ii(0x1009_38e1, 2); jmpd(0x1009_38f8, 0x15); goto l_0x1009_38f8; /* jmp 0x100938f8 */
        l_0x1009_38e3:
            ii(0x1009_38e3, 5); mov(ecx, 0xa00);                        /* mov ecx, 0xa00 */
            ii(0x1009_38e8, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x1009_38eb, 5); mov(edx, 0x7);                          /* mov edx, 0x7 */
            ii(0x1009_38f0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_38f3, 5); calld(0x1009_6e02, 0x350a);             /* call 0x10096e02 */
        l_0x1009_38f8:
            ii(0x1009_38f8, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x1009_38fc, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1009_38fe, 2); if(jled(0x1009_391c, 0x1c)) goto l_0x1009_391c; /* jle 0x1009391c */
            ii(0x1009_3900, 4); movsx(edx, memw_a32[ss, ebp - 0x40]);   /* movsx edx, word [ebp-0x40] */
            ii(0x1009_3904, 3); lea(edx, edx + edx * 2);                /* lea edx, [edx+edx*2] */
            ii(0x1009_3907, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1009_3909, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1009_390c, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x1009_390f, 2); sbb(eax, edx);                          /* sbb eax, edx */
            ii(0x1009_3911, 3); sar(eax, 0x2);                          /* sar eax, 0x2 */
            ii(0x1009_3914, 4); movsx(edx, memw_a32[ss, ebp - 0x34]);   /* movsx edx, word [ebp-0x34] */
            ii(0x1009_3918, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1009_391a, 2); if(jged(0x1009_391e, 0x2)) goto l_0x1009_391e; /* jge 0x1009391e */
        l_0x1009_391c:
            ii(0x1009_391c, 2); jmpd(0x1009_3929, 0xb); goto l_0x1009_3929; /* jmp 0x10093929 */
        l_0x1009_391e:
            ii(0x1009_391e, 4); movsx(eax, memw_a32[ss, ebp - 0x40]);   /* movsx eax, word [ebp-0x40] */
            ii(0x1009_3922, 5); cmp(eax, 0x1f4);                        /* cmp eax, 0x1f4 */
            ii(0x1009_3927, 2); if(jld(0x1009_392b, 0x2)) goto l_0x1009_392b; /* jl 0x1009392b */
        l_0x1009_3929:
            ii(0x1009_3929, 2); jmpd(0x1009_3939, 0xe); goto l_0x1009_3939; /* jmp 0x10093939 */
        l_0x1009_392b:
            ii(0x1009_392b, 5); mov(eax, 0x8);                          /* mov eax, 0x8 */
            ii(0x1009_3930, 5); calld(0x100c_dec2, 0x3_a58d);           /* call 0x100cdec2 */
            ii(0x1009_3935, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1009_3937, 2); if(jnzd(0x1009_393b, 0x2)) goto l_0x1009_393b; /* jnz 0x1009393b */
        l_0x1009_3939:
            ii(0x1009_3939, 2); jmpd(0x1009_3950, 0x15); goto l_0x1009_3950; /* jmp 0x10093950 */
        l_0x1009_393b:
            ii(0x1009_393b, 5); mov(ecx, 0xa00);                        /* mov ecx, 0xa00 */
            ii(0x1009_3940, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x1009_3943, 5); mov(edx, 0x8);                          /* mov edx, 0x8 */
            ii(0x1009_3948, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_394b, 5); calld(0x1009_6e02, 0x34b2);             /* call 0x10096e02 */
        l_0x1009_3950:
            ii(0x1009_3950, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_3952, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1009_3955, 5); calld(0x1009_ba6c, 0x8112);             /* call 0x1009ba6c */
            ii(0x1009_395a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_395c, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1009_395f, 5); calld(0x1007_5f6c, -0x1_d9f8);          /* call 0x10075f6c */
            ii(0x1009_3964, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_3966, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_3967, 1); popd(edi);                              /* pop edi */
            ii(0x1009_3968, 1); popd(esi);                              /* pop esi */
            ii(0x1009_3969, 1); popd(edx);                              /* pop edx */
            ii(0x1009_396a, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_396b, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_396c, 1); retd(); return;                         /* ret */
        }
    }
}
