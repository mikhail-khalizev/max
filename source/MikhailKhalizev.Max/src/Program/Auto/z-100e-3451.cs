using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_3451-10e87675")]
        public void Method_100e_3451()
        {
            ii(0x100e_3451, 5); pushd(0x64);                            /* push 0x64 */
            ii(0x100e_3456, 5); calld(Definitions.sys_check_available_stack_size, 0x8_28f7); /* call 0x10165d52 */
            ii(0x100e_345b, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_345c, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_345d, 1); pushd(esi);                             /* push esi */
            ii(0x100e_345e, 1); pushd(edi);                             /* push edi */
            ii(0x100e_345f, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_3460, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_3462, 6); sub(esp, 0x48);                         /* sub esp, 0x48 */
            ii(0x100e_3468, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_346b, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100e_346e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_3471, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
            ii(0x100e_3474, 3); mov(edx, memd_a32[ss, ebp - 0x2c]);     /* mov edx, [ebp-0x2c] */
            ii(0x100e_3477, 3); add(edx, 0x18);                         /* add edx, 0x18 */
            ii(0x100e_347a, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100e_347d, 5); calld(0x1007_6668, -0x6_ce1a);          /* call 0x10076668 */
            ii(0x100e_3482, 4); or(memb_a32[ss, ebp - 0xc], 0x1);       /* or byte [ebp-0xc], 0x1 */
            ii(0x100e_3486, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x100e_3489, 5); calld(Definitions.my_ctor_0x101b_56fc, -0x5_a812); /* call 0x10088c7c */
            ii(0x100e_348e, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x100e_3491, 4); and(memb_a32[ss, ebp - 0xc], -0x2 /* 0xfe */); /* and byte [ebp-0xc], 0xfe */
            ii(0x100e_3495, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x100e_3498, 3); add(eax, 0x1c);                         /* add eax, 0x1c */
            ii(0x100e_349b, 5); calld(0x1007_6338, -0x6_d168);          /* call 0x10076338 */
            ii(0x100e_34a0, 3); lea(ebx, ebp - 0x24);                   /* lea ebx, [ebp-0x24] */
            ii(0x100e_34a3, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_34a5, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100e_34a7, 5); calld(0x1007_64b8, -0x6_cff4);          /* call 0x100764b8 */
            ii(0x100e_34ac, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100e_34af, 5); calld(0x1007_6574, -0x6_cf40);          /* call 0x10076574 */
            ii(0x100e_34b4, 4); mov(ax, memw_a32[ds, eax + 0x1c]);      /* mov ax, [eax+0x1c] */
            ii(0x100e_34b8, 1); inc(eax);                               /* inc eax */
            ii(0x100e_34b9, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x100e_34bc, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100e_34bf, 5); calld(0x1007_6574, -0x6_cf50);          /* call 0x10076574 */
            ii(0x100e_34c4, 4); mov(ax, memw_a32[ds, eax + 0x1a]);      /* mov ax, [eax+0x1a] */
            ii(0x100e_34c8, 1); dec(eax);                               /* dec eax */
            ii(0x100e_34c9, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100e_34cc, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100e_34cf, 5); calld(0x1007_6aac, -0x6_ca28);          /* call 0x10076aac */
            ii(0x100e_34d4, 5); mov(eax, memd_a32[ds, 0x101c_8172]);    /* mov eax, [0x101c8172] */
            ii(0x100e_34d9, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100e_34dc, 1); pushd(eax);                             /* push eax */
            ii(0x100e_34dd, 6); mov(ecx, memd_a32[ds, 0x101c_8170]);    /* mov ecx, [0x101c8170] */
            ii(0x100e_34e3, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100e_34e6, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100e_34e8, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_34ea, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x100e_34ed, 5); calld(0x1008_b148, -0x5_83aa);          /* call 0x1008b148 */
            ii(0x100e_34f2, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100e_34f5, 5); calld(0x1007_6574, -0x6_cf86);          /* call 0x10076574 */
            ii(0x100e_34fa, 4); test(memb_a32[ds, eax + 0x12], 0x10);   /* test byte [eax+0x12], 0x10 */
            ii(0x100e_34fe, 2); if(jzd(0x100e_3510, 0x10)) goto l_0x100e_3510; /* jz 0x100e3510 */
            ii(0x100e_3500, 7); mov(memd_a32[ss, ebp - 0x14], 0x3);     /* mov dword [ebp-0x14], 0x3 */
            ii(0x100e_3507, 3); mov(eax, memd_a32[ss, ebp - 0x1a]);     /* mov eax, [ebp-0x1a] */
            ii(0x100e_350a, 4); inc(memw_a32[ss, ebp - 0x1a]);          /* inc word [ebp-0x1a] */
            ii(0x100e_350e, 2); jmpd(0x100e_3517, 0x7); goto l_0x100e_3517; /* jmp 0x100e3517 */
        l_0x100e_3510:
            ii(0x100e_3510, 7); mov(memd_a32[ss, ebp - 0x14], 0x2);     /* mov dword [ebp-0x14], 0x2 */
        l_0x100e_3517:
            ii(0x100e_3517, 2); jmpd(0x100e_3521, 0x8); goto l_0x100e_3521; /* jmp 0x100e3521 */
        l_0x100e_3519:
            ii(0x100e_3519, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100e_351c, 5); calld(0x1007_6bf8, -0x6_c929);          /* call 0x10076bf8 */
        l_0x100e_3521:
            ii(0x100e_3521, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_3523, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100e_3526, 5); calld(0x1013_ad71, 0x5_7846);           /* call 0x1013ad71 */
            ii(0x100e_352b, 2); test(al, al);                           /* test al, al */
            ii(0x100e_352d, 2); if(jzd(0x100e_3545, 0x16)) goto l_0x100e_3545; /* jz 0x100e3545 */
            ii(0x100e_352f, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100e_3532, 5); calld(0x1007_63d4, -0x6_d163);          /* call 0x100763d4 */
            ii(0x100e_3537, 3); lea(ebx, ebp - 0x38);                   /* lea ebx, [ebp-0x38] */
            ii(0x100e_353a, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_353c, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100e_353e, 5); calld(0x1008_ab1c, -0x5_8a27);          /* call 0x1008ab1c */
            ii(0x100e_3543, 2); jmpd(0x100e_3519, -0x2c); goto l_0x100e_3519; /* jmp 0x100e3519 */
        l_0x100e_3545:
            ii(0x100e_3545, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x100e_3548, 5); calld(0x100e_3b27, 0x5da);              /* call 0x100e3b27 */
            ii(0x100e_354d, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
            ii(0x100e_3554, 2); jmpd(0x100e_355a, 0x4); goto l_0x100e_355a; /* jmp 0x100e355a */
        l_0x100e_3556:
            ii(0x100e_3556, 4); add(memd_a32[ss, ebp - 0x10], 0x2);     /* add dword [ebp-0x10], 0x2 */
        l_0x100e_355a:
            ii(0x100e_355a, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x100e_355e, 3); cmp(eax, 0x8);                          /* cmp eax, 0x8 */
            ii(0x100e_3561, 2); if(jged(0x100e_3570, 0xd)) goto l_0x100e_3570; /* jge 0x100e3570 */
            ii(0x100e_3563, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x100e_3566, 5); calld(0x1007_6b90, -0x6_c9db);          /* call 0x10076b90 */
            ii(0x100e_356b, 1); cwde();                                 /* cwde */
            ii(0x100e_356c, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_356e, 2); if(jgd(0x100e_3575, 0x5)) goto l_0x100e_3575; /* jg 0x100e3575 */
        l_0x100e_3570:
            ii(0x100e_3570, 5); jmpd(0x100e_36f4, 0x17f); goto l_0x100e_36f4; /* jmp 0x100e36f4 */
        l_0x100e_3575:
            ii(0x100e_3575, 7); mov(memd_a32[ss, ebp - 0x18], 0);       /* mov dword [ebp-0x18], 0x0 */
            ii(0x100e_357c, 2); jmpd(0x100e_3584, 0x6); goto l_0x100e_3584; /* jmp 0x100e3584 */
        l_0x100e_357e:
            ii(0x100e_357e, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100e_3581, 3); inc(memd_a32[ss, ebp - 0x18]);          /* inc dword [ebp-0x18] */
        l_0x100e_3584:
            ii(0x100e_3584, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100e_3587, 4); cmp(ax, memw_a32[ss, ebp - 0x14]);      /* cmp ax, [ebp-0x14] */
            ii(0x100e_358b, 2); if(jged(0x100e_359a, 0xd)) goto l_0x100e_359a; /* jge 0x100e359a */
            ii(0x100e_358d, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x100e_3590, 5); calld(0x1007_6b90, -0x6_ca05);          /* call 0x10076b90 */
            ii(0x100e_3595, 1); cwde();                                 /* cwde */
            ii(0x100e_3596, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_3598, 2); if(jgd(0x100e_359f, 0x5)) goto l_0x100e_359f; /* jg 0x100e359f */
        l_0x100e_359a:
            ii(0x100e_359a, 5); jmpd(0x100e_36ef, 0x150); goto l_0x100e_36ef; /* jmp 0x100e36ef */
        l_0x100e_359f:
            ii(0x100e_359f, 4); movsx(edx, memw_a32[ss, ebp - 0x10]);   /* movsx edx, word [ebp-0x10] */
            ii(0x100e_35a3, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x100e_35a6, 5); mov(eax, 0x101c_5348);                  /* mov eax, 0x101c5348 */
            ii(0x100e_35ab, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100e_35ad, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100e_35b0, 5); calld(0x1008_b1a4, -0x5_8411);          /* call 0x1008b1a4 */
            ii(0x100e_35b5, 3); lea(edx, ebp - 0x1c);                   /* lea edx, [ebp-0x1c] */
            ii(0x100e_35b8, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x100e_35bb, 5); calld(0x1010_82ce, 0x2_4d0e);           /* call 0x101082ce */
            ii(0x100e_35c0, 2); test(al, al);                           /* test al, al */
            ii(0x100e_35c2, 6); if(jzd(0x100e_36ea, 0x122)) goto l_0x100e_36ea; /* jz 0x100e36ea */
            ii(0x100e_35c8, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x100e_35cb, 5); calld(0x1007_6338, -0x6_d298);          /* call 0x10076338 */
            ii(0x100e_35d0, 3); lea(ebx, ebp - 0x24);                   /* lea ebx, [ebp-0x24] */
            ii(0x100e_35d3, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_35d5, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100e_35d7, 5); calld(0x1007_643c, -0x6_d1a0);          /* call 0x1007643c */
            ii(0x100e_35dc, 2); jmpd(0x100e_35e6, 0x8); goto l_0x100e_35e6; /* jmp 0x100e35e6 */
        l_0x100e_35de:
            ii(0x100e_35de, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100e_35e1, 5); calld(0x1007_6bf8, -0x6_c9ee);          /* call 0x10076bf8 */
        l_0x100e_35e6:
            ii(0x100e_35e6, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_35e8, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100e_35eb, 5); calld(0x1013_ad71, 0x5_7781);           /* call 0x1013ad71 */
            ii(0x100e_35f0, 2); test(al, al);                           /* test al, al */
            ii(0x100e_35f2, 2); if(jzd(0x100e_362a, 0x36)) goto l_0x100e_362a; /* jz 0x100e362a */
            ii(0x100e_35f4, 5); mov(eax, 0x2);                          /* mov eax, 0x2 */
            ii(0x100e_35f9, 1); pushd(eax);                             /* push eax */
            ii(0x100e_35fa, 4); movsx(ecx, memw_a32[ss, ebp - 0x1a]);   /* movsx ecx, word [ebp-0x1a] */
            ii(0x100e_35fe, 4); movsx(ebx, memw_a32[ss, ebp - 0x1c]);   /* movsx ebx, word [ebp-0x1c] */
            ii(0x100e_3602, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100e_3605, 5); calld(0x1007_63a0, -0x6_d26a);          /* call 0x100763a0 */
            ii(0x100e_360a, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x100e_360d, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x100e_360f, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100e_3612, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100e_3615, 5); calld(0x1007_63a0, -0x6_d27a);          /* call 0x100763a0 */
            ii(0x100e_361a, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x100e_361d, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100e_3620, 5); calld(0x1007_02b9, -0x7_336c);          /* call 0x100702b9 */
            ii(0x100e_3625, 3); test(ax, ax);                           /* test ax, ax */
            ii(0x100e_3628, 2); if(jzd(0x100e_35de, -0x4c)) goto l_0x100e_35de; /* jz 0x100e35de */
        l_0x100e_362a:
            ii(0x100e_362a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_362c, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100e_362f, 5); calld(0x1013_ad71, 0x5_773d);           /* call 0x1013ad71 */
            ii(0x100e_3634, 2); test(al, al);                           /* test al, al */
            ii(0x100e_3636, 6); if(jzd(0x100e_36ea, 0xae)) goto l_0x100e_36ea; /* jz 0x100e36ea */
            ii(0x100e_363c, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100e_363f, 5); calld(0x1007_63d4, -0x6_d270);          /* call 0x100763d4 */
            ii(0x100e_3644, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_3646, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100e_3649, 5); calld(0x1007_6574, -0x6_d0da);          /* call 0x10076574 */
            ii(0x100e_364e, 5); calld(0x1008_a998, -0x5_8cbb);          /* call 0x1008a998 */
            ii(0x100e_3653, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100e_3656, 5); calld(0x1007_6574, -0x6_d0e7);          /* call 0x10076574 */
            ii(0x100e_365b, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_365d, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100e_3660, 4); mov(memw_a32[ds, edx + 0x41], ax);      /* mov [edx+0x41], ax */
            ii(0x100e_3664, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100e_3667, 5); calld(0x1007_6574, -0x6_d0f8);          /* call 0x10076574 */
            ii(0x100e_366c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_366e, 3); mov(eax, memd_a32[ss, ebp - 0x1a]);     /* mov eax, [ebp-0x1a] */
            ii(0x100e_3671, 4); mov(memw_a32[ds, edx + 0x43], ax);      /* mov [edx+0x43], ax */
            ii(0x100e_3675, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x100e_367a, 5); mov(edx, 0x5);                          /* mov edx, 0x5 */
            ii(0x100e_367f, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100e_3682, 5); calld(0x1007_65d0, -0x6_d0b7);          /* call 0x100765d0 */
            ii(0x100e_3687, 5); calld(0x1016_3053, 0x7_f9c7);           /* call 0x10163053 */
            ii(0x100e_368c, 7); cmp(memd_a32[ds, 0x101c_5624], 0);      /* cmp dword [0x101c5624], 0x0 */
            ii(0x100e_3693, 2); if(jzd(0x100e_36ae, 0x19)) goto l_0x100e_36ae; /* jz 0x100e36ae */
            ii(0x100e_3695, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x100e_369a, 5); mov(edx, 0x5);                          /* mov edx, 0x5 */
            ii(0x100e_369f, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100e_36a2, 5); calld(0x1007_65d0, -0x6_d0d7);          /* call 0x100765d0 */
            ii(0x100e_36a7, 5); calld(0x100e_0e24, -0x2888);            /* call 0x100e0e24 */
            ii(0x100e_36ac, 2); jmpd(0x100e_36d6, 0x28); goto l_0x100e_36d6; /* jmp 0x100e36d6 */
        l_0x100e_36ae:
            ii(0x100e_36ae, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100e_36b1, 5); calld(0x1007_6574, -0x6_d142);          /* call 0x10076574 */
            ii(0x100e_36b6, 4); cmp(memb_a32[ds, eax + 0x3d], 0x5);     /* cmp byte [eax+0x3d], 0x5 */
            ii(0x100e_36ba, 2); if(jnzd(0x100e_36d6, 0x1a)) goto l_0x100e_36d6; /* jnz 0x100e36d6 */
            ii(0x100e_36bc, 5); calld(0x1016_2cb8, 0x7_f5f7);           /* call 0x10162cb8 */
            ii(0x100e_36c1, 5); calld(0x100d_5094, -0xe632);            /* call 0x100d5094 */
            ii(0x100e_36c6, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_36c8, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x100e_36ca, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100e_36cf, 5); calld(0x1010_0e32, 0x1_d75e);           /* call 0x10100e32 */
            ii(0x100e_36d4, 2); jmpd(0x100e_36ae, -0x28); goto l_0x100e_36ae; /* jmp 0x100e36ae */
        l_0x100e_36d6:
            ii(0x100e_36d6, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100e_36d9, 5); calld(0x1008_ab8c, -0x5_8b52);          /* call 0x1008ab8c */
            ii(0x100e_36de, 3); lea(ebx, ebp - 0x38);                   /* lea ebx, [ebp-0x38] */
            ii(0x100e_36e1, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_36e3, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100e_36e5, 5); calld(0x1008_aaec, -0x5_8bfe);          /* call 0x1008aaec */
        l_0x100e_36ea:
            ii(0x100e_36ea, 5); jmpd(0x100e_357e, -0x171); goto l_0x100e_357e; /* jmp 0x100e357e */
        l_0x100e_36ef:
            ii(0x100e_36ef, 5); jmpd(0x100e_3556, -0x19e); goto l_0x100e_3556; /* jmp 0x100e3556 */
        l_0x100e_36f4:
            ii(0x100e_36f4, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100e_36f9, 5); calld(0x1007_65d0, -0x6_d12e);          /* call 0x100765d0 */
            ii(0x100e_36fe, 5); calld(0x100f_fa70, 0x1_c36d);           /* call 0x100ffa70 */
            ii(0x100e_3703, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_3705, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100e_3708, 5); calld(0x1007_5f6c, -0x6_d7a1);          /* call 0x10075f6c */
            ii(0x100e_370d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_370f, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x100e_3712, 5); calld(Definitions.my_dtor_0x101b_56fc, -0x5_aadb); /* call 0x10088c3c */
            ii(0x100e_3717, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_3719, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100e_371c, 5); calld(0x1007_5f2c, -0x6_d7f5);          /* call 0x10075f2c */
            ii(0x100e_3721, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_3723, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_3724, 1); popd(edi);                              /* pop edi */
            ii(0x100e_3725, 1); popd(esi);                              /* pop esi */
            ii(0x100e_3726, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_3727, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_3728, 1); retd();                                 /* ret */
        }
    }
}
