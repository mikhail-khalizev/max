using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("77b920bd-a25e-4266-91f5-8cacbb578e37")]
        public void Method_1009_3ff1()
        {
            ii(0x1009_3ff1, 5); pushd(0x3c);                            /* push 0x3c */
            ii(0x1009_3ff6, 5); calld(Definitions.sys_check_available_stack_size, 0xd_1d57); /* call 0x10165d52 */
            ii(0x1009_3ffb, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_3ffc, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_3ffd, 1); pushd(edx);                             /* push edx */
            ii(0x1009_3ffe, 1); pushd(esi);                             /* push esi */
            ii(0x1009_3fff, 1); pushd(edi);                             /* push edi */
            ii(0x1009_4000, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_4001, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_4003, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x1009_4009, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1009_400c, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x1009_4011, 5); calld(0x1007_6338, -0x1_dcde);          /* call 0x10076338 */
            ii(0x1009_4016, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_4018, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1009_401b, 5); calld(0x1007_64b8, -0x1_db68);          /* call 0x100764b8 */
            ii(0x1009_4020, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
            ii(0x1009_4027, 5); mov(ebx, 0xa);                          /* mov ebx, 0xa */
            ii(0x1009_402c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_402e, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1009_4031, 5); calld(Definitions.sys_memset, 0xd_1daa); /* call 0x10165de0 */
            ii(0x1009_4036, 2); jmpd(0x1009_4040, 0x8); goto l_0x1009_4040; /* jmp 0x10094040 */
        l_0x1009_4038:
            ii(0x1009_4038, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1009_403b, 5); calld(0x1007_6bf8, -0x1_d448);          /* call 0x10076bf8 */
        l_0x1009_4040:
            ii(0x1009_4040, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_4042, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1009_4045, 5); calld(0x1013_ad71, 0xa_6d27);           /* call 0x1013ad71 */
            ii(0x1009_404a, 2); test(al, al);                           /* test al, al */
            ii(0x1009_404c, 2); if(jzd(0x1009_4076, 0x28)) goto l_0x1009_4076; /* jz 0x10094076 */
            ii(0x1009_404e, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1009_4051, 5); calld(0x1007_63a0, -0x1_dcb6);          /* call 0x100763a0 */
            ii(0x1009_4056, 5); cmp(memw_a32[ds, eax + 0x8], 0x1e);     /* cmp word [eax+0x8], 0x1e */
            ii(0x1009_405b, 2); if(jnzd(0x1009_4074, 0x17)) goto l_0x1009_4074; /* jnz 0x10094074 */
            ii(0x1009_405d, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1009_4060, 5); calld(0x1007_63a0, -0x1_dcc5);          /* call 0x100763a0 */
            ii(0x1009_4065, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x1009_4068, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1009_406d, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1009_406f, 5); inc(memw_a32[ds, eax + ebp - 0x20]);    /* inc word [eax+ebp-0x20] */
        l_0x1009_4074:
            ii(0x1009_4074, 2); jmpd(0x1009_4038, -0x3e); goto l_0x1009_4038; /* jmp 0x10094038 */
        l_0x1009_4076:
            ii(0x1009_4076, 5); mov(eax, 0x101c_8184);                  /* mov eax, 0x101c8184 */
            ii(0x1009_407b, 5); calld(0x1007_6338, -0x1_dd48);          /* call 0x10076338 */
            ii(0x1009_4080, 3); lea(ebx, ebp - 0x14);                   /* lea ebx, [ebp-0x14] */
            ii(0x1009_4083, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_4085, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1009_4087, 5); calld(0x1007_643c, -0x1_dc50);          /* call 0x1007643c */
            ii(0x1009_408c, 2); jmpd(0x1009_4096, 0x8); goto l_0x1009_4096; /* jmp 0x10094096 */
        l_0x1009_408e:
            ii(0x1009_408e, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1009_4091, 5); calld(0x1007_6bf8, -0x1_d49e);          /* call 0x10076bf8 */
        l_0x1009_4096:
            ii(0x1009_4096, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_4098, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1009_409b, 5); calld(0x1013_ad71, 0xa_6cd1);           /* call 0x1013ad71 */
            ii(0x1009_40a0, 2); test(al, al);                           /* test al, al */
            ii(0x1009_40a2, 2); if(jzd(0x1009_4101, 0x5d)) goto l_0x1009_4101; /* jz 0x10094101 */
            ii(0x1009_40a4, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1009_40a7, 5); calld(0x1007_63a0, -0x1_dd0c);          /* call 0x100763a0 */
            ii(0x1009_40ac, 5); cmp(memw_a32[ds, eax + 0x8], 0x31);     /* cmp word [eax+0x8], 0x31 */
            ii(0x1009_40b1, 2); if(jnzd(0x1009_40c1, 0xe)) goto l_0x1009_40c1; /* jnz 0x100940c1 */
            ii(0x1009_40b3, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1009_40b6, 5); calld(0x1007_63a0, -0x1_dd1b);          /* call 0x100763a0 */
            ii(0x1009_40bb, 4); cmp(memb_a32[ds, eax + 0x3d], 0x4);     /* cmp byte [eax+0x3d], 0x4 */
            ii(0x1009_40bf, 2); if(jzd(0x1009_40c3, 0x2)) goto l_0x1009_40c3; /* jz 0x100940c3 */
        l_0x1009_40c1:
            ii(0x1009_40c1, 2); jmpd(0x1009_40d1, 0xe); goto l_0x1009_40d1; /* jmp 0x100940d1 */
        l_0x1009_40c3:
            ii(0x1009_40c3, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1009_40c6, 5); calld(0x1007_63a0, -0x1_dd2b);          /* call 0x100763a0 */
            ii(0x1009_40cb, 4); cmp(memb_a32[ds, eax + 0x3e], 0xb);     /* cmp byte [eax+0x3e], 0xb */
            ii(0x1009_40cf, 2); if(jzd(0x1009_40d3, 0x2)) goto l_0x1009_40d3; /* jz 0x100940d3 */
        l_0x1009_40d1:
            ii(0x1009_40d1, 2); jmpd(0x1009_40e6, 0x13); goto l_0x1009_40e6; /* jmp 0x100940e6 */
        l_0x1009_40d3:
            ii(0x1009_40d3, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1009_40d6, 5); calld(0x1007_63a0, -0x1_dd3b);          /* call 0x100763a0 */
            ii(0x1009_40db, 5); calld(0x1015_0a9e, 0xb_c9be);           /* call 0x10150a9e */
            ii(0x1009_40e0, 4); cmp(ax, 0x1e);                          /* cmp ax, 0x1e */
            ii(0x1009_40e4, 2); if(jzd(0x1009_40e8, 0x2)) goto l_0x1009_40e8; /* jz 0x100940e8 */
        l_0x1009_40e6:
            ii(0x1009_40e6, 2); jmpd(0x1009_40ff, 0x17); goto l_0x1009_40ff; /* jmp 0x100940ff */
        l_0x1009_40e8:
            ii(0x1009_40e8, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1009_40eb, 5); calld(0x1007_63a0, -0x1_dd50);          /* call 0x100763a0 */
            ii(0x1009_40f0, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x1009_40f3, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1009_40f8, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1009_40fa, 5); inc(memw_a32[ds, eax + ebp - 0x20]);    /* inc word [eax+ebp-0x20] */
        l_0x1009_40ff:
            ii(0x1009_40ff, 2); jmpd(0x1009_408e, -0x73); goto l_0x1009_408e; /* jmp 0x1009408e */
        l_0x1009_4101:
            ii(0x1009_4101, 7); mov(memd_a32[ss, ebp - 0xc], 0);        /* mov dword [ebp-0xc], 0x0 */
            ii(0x1009_4108, 2); jmpd(0x1009_4110, 0x6); goto l_0x1009_4110; /* jmp 0x10094110 */
        l_0x1009_410a:
            ii(0x1009_410a, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_410d, 3); inc(memd_a32[ss, ebp - 0xc]);           /* inc dword [ebp-0xc] */
        l_0x1009_4110:
            ii(0x1009_4110, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1009_4114, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x1009_4117, 2); if(jged(0x1009_413d, 0x24)) goto l_0x1009_413d; /* jge 0x1009413d */
            ii(0x1009_4119, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_411c, 4); cmp(ax, memw_a32[ss, ebp - 0x4]);       /* cmp ax, [ebp-0x4] */
            ii(0x1009_4120, 2); if(jzd(0x1009_413b, 0x19)) goto l_0x1009_413b; /* jz 0x1009413b */
            ii(0x1009_4122, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x1009_4126, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x1009_4128, 4); mov(edx, memd_a32[ds, edx + ebp - 0x22]); /* mov edx, [edx+ebp-0x22] */
            ii(0x1009_412c, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1009_412f, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1009_4133, 5); calld(0x1007_6e7c, -0x1_d2bc);          /* call 0x10076e7c */
            ii(0x1009_4138, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
        l_0x1009_413b:
            ii(0x1009_413b, 2); jmpd(0x1009_410a, -0x33); goto l_0x1009_410a; /* jmp 0x1009410a */
        l_0x1009_413d:
            ii(0x1009_413d, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_4140, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_4143, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_4145, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1009_4148, 5); calld(0x1007_5f6c, -0x1_e1e1);          /* call 0x10075f6c */
            ii(0x1009_414d, 2); jmpd(0x1009_4159, 0xa); goto l_0x1009_4159; /* jmp 0x10094159 */
        //    ii(0x1009_414f, 2); xor(edx, edx);                          /* xor edx, edx */
        //    ii(0x1009_4151, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
        //    ii(0x1009_4154, 5); calld(0x1007_5f6c, -0x1_e1ed);          /* call 0x10075f6c */
        l_0x1009_4159:
            ii(0x1009_4159, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_415c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_415e, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_415f, 1); popd(edi);                              /* pop edi */
            ii(0x1009_4160, 1); popd(esi);                              /* pop esi */
            ii(0x1009_4161, 1); popd(edx);                              /* pop edx */
            ii(0x1009_4162, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_4163, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_4164, 1); retd(); return;                         /* ret */
        }
    }
}
