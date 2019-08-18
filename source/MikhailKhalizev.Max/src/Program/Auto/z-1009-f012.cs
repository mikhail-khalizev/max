using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a6d1264d-7ab3-4e7d-b5c6-88cae75566ef")]
        public void Method_1009_f012()
        {
            ii(0x1009_f012, 5); pushd(0x40);                            /* push 0x40 */
            ii(0x1009_f017, 5); calld(Definitions.sys_check_available_stack_size, 0xc_6d36); /* call 0x10165d52 */
            ii(0x1009_f01c, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_f01d, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_f01e, 1); pushd(edx);                             /* push edx */
            ii(0x1009_f01f, 1); pushd(esi);                             /* push esi */
            ii(0x1009_f020, 1); pushd(edi);                             /* push edi */
            ii(0x1009_f021, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_f022, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_f024, 6); sub(esp, 0x24);                         /* sub esp, 0x24 */
            ii(0x1009_f02a, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1009_f02d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_f030, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1009_f033, 5); calld(0x1007_6338, -0x2_8d00);          /* call 0x10076338 */
            ii(0x1009_f038, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_f03a, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1009_f03d, 5); calld(0x1007_64b8, -0x2_8b8a);          /* call 0x100764b8 */
            ii(0x1009_f042, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_f044, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1009_f047, 5); calld(0x1013_ad71, 0x9_bd25);           /* call 0x1013ad71 */
            ii(0x1009_f04c, 2); test(al, al);                           /* test al, al */
            ii(0x1009_f04e, 2); if(jzd(0x1009_f05d, 0xd)) goto l_0x1009_f05d; /* jz 0x1009f05d */
            ii(0x1009_f050, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_f053, 3); mov(eax, memd_a32[ds, eax + 0x1f]);     /* mov eax, [eax+0x1f] */
            ii(0x1009_f056, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_f059, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1009_f05b, 2); if(jzd(0x1009_f062, 0x5)) goto l_0x1009_f062; /* jz 0x1009f062 */
        l_0x1009_f05d:
            ii(0x1009_f05d, 5); jmpd(0x1009_f183, 0x121); goto l_0x1009_f183; /* jmp 0x1009f183 */
        l_0x1009_f062:
            ii(0x1009_f062, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1009_f064, 5); mov(ebx, 0x3);                          /* mov ebx, 0x3 */
            ii(0x1009_f069, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1009_f06c, 5); calld(0x1007_63d4, -0x2_8c9d);          /* call 0x100763d4 */
            ii(0x1009_f071, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_f073, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_f076, 3); mov(eax, memd_a32[ds, eax + 0x7]);      /* mov eax, [eax+0x7] */
            ii(0x1009_f079, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_f07c, 6); imul(eax, eax, 0xc5);                   /* imul eax, eax, 0xc5 */
            ii(0x1009_f082, 5); mov(esi, 0x101c_31c4);                  /* mov esi, 0x101c31c4 */
            ii(0x1009_f087, 2); add(eax, esi);                          /* add eax, esi */
            ii(0x1009_f089, 5); calld(0x100c_1fd4, 0x2_2f46);           /* call 0x100c1fd4 */
            ii(0x1009_f08e, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1009_f091, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_f094, 3); mov(eax, memd_a32[ds, eax + 0x7]);      /* mov eax, [eax+0x7] */
            ii(0x1009_f097, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_f09a, 6); imul(eax, eax, 0xc5);                   /* imul eax, eax, 0xc5 */
            ii(0x1009_f0a0, 5); mov(edx, 0x101c_31c4);                  /* mov edx, 0x101c31c4 */
            ii(0x1009_f0a5, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1009_f0a7, 5); calld(0x100a_0054, 0xfa8);              /* call 0x100a0054 */
            ii(0x1009_f0ac, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1009_f0af, 7); mov(memd_a32[ss, ebp - 0x14], 0);       /* mov dword [ebp-0x14], 0x0 */
            ii(0x1009_f0b6, 4); cmp(memd_a32[ss, ebp - 0xc], 0);        /* cmp dword [ebp-0xc], 0x0 */
            ii(0x1009_f0ba, 2); if(jzd(0x1009_f0c2, 0x6)) goto l_0x1009_f0c2; /* jz 0x1009f0c2 */
            ii(0x1009_f0bc, 4); cmp(memd_a32[ss, ebp - 0x10], 0);       /* cmp dword [ebp-0x10], 0x0 */
            ii(0x1009_f0c0, 2); if(jnzd(0x1009_f0c7, 0x5)) goto l_0x1009_f0c7; /* jnz 0x1009f0c7 */
        l_0x1009_f0c2:
            ii(0x1009_f0c2, 5); jmpd(0x1009_f183, 0xbc); goto l_0x1009_f183; /* jmp 0x1009f183 */
        l_0x1009_f0c7:
            ii(0x1009_f0c7, 7); mov(memd_a32[ss, ebp - 0x18], 0);       /* mov dword [ebp-0x18], 0x0 */
            ii(0x1009_f0ce, 2); jmpd(0x1009_f0d6, 0x6); goto l_0x1009_f0d6; /* jmp 0x1009f0d6 */
        l_0x1009_f0d0:
            ii(0x1009_f0d0, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1009_f0d3, 3); inc(memd_a32[ss, ebp - 0x18]);          /* inc dword [ebp-0x18] */
        l_0x1009_f0d6:
            ii(0x1009_f0d6, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1009_f0d9, 7); cmp(ax, memw_a32[ds, 0x101c_8172]);     /* cmp ax, [0x101c8172] */
            ii(0x1009_f0e0, 2); if(jged(0x1009_f13d, 0x5b)) goto l_0x1009_f13d; /* jge 0x1009f13d */
            ii(0x1009_f0e2, 7); mov(memd_a32[ss, ebp - 0x1c], 0);       /* mov dword [ebp-0x1c], 0x0 */
            ii(0x1009_f0e9, 2); jmpd(0x1009_f0f1, 0x6); goto l_0x1009_f0f1; /* jmp 0x1009f0f1 */
        l_0x1009_f0eb:
            ii(0x1009_f0eb, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1009_f0ee, 3); inc(memd_a32[ss, ebp - 0x1c]);          /* inc dword [ebp-0x1c] */
        l_0x1009_f0f1:
            ii(0x1009_f0f1, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1009_f0f4, 7); cmp(ax, memw_a32[ds, 0x101c_8174]);     /* cmp ax, [0x101c8174] */
            ii(0x1009_f0fb, 2); if(jged(0x1009_f13b, 0x3e)) goto l_0x1009_f13b; /* jge 0x1009f13b */
            ii(0x1009_f0fd, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x1009_f101, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1009_f104, 3); add(eax, memd_a32[ss, ebp - 0x10]);     /* add eax, [ebp-0x10] */
            ii(0x1009_f107, 4); movsx(edx, memw_a32[ss, ebp - 0x1c]);   /* movsx edx, word [ebp-0x1c] */
            ii(0x1009_f10b, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1009_f10d, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1009_f10f, 3); movsx(eax, memb_a32[ds, eax]);          /* movsx eax, byte [eax] */
            ii(0x1009_f112, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1009_f114, 2); if(jled(0x1009_f131, 0x1b)) goto l_0x1009_f131; /* jle 0x1009f131 */
            ii(0x1009_f116, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x1009_f11a, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1009_f11d, 3); add(eax, memd_a32[ss, ebp - 0xc]);      /* add eax, [ebp-0xc] */
            ii(0x1009_f120, 4); movsx(edx, memw_a32[ss, ebp - 0x1c]);   /* movsx edx, word [ebp-0x1c] */
            ii(0x1009_f124, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x1009_f126, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1009_f128, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1009_f12a, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x1009_f12d, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1009_f12f, 2); if(jled(0x1009_f133, 0x2)) goto l_0x1009_f133; /* jle 0x1009f133 */
        l_0x1009_f131:
            ii(0x1009_f131, 2); jmpd(0x1009_f139, 0x6); goto l_0x1009_f139; /* jmp 0x1009f139 */
        l_0x1009_f133:
            ii(0x1009_f133, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1009_f136, 3); inc(memd_a32[ss, ebp - 0x14]);          /* inc dword [ebp-0x14] */
        l_0x1009_f139:
            ii(0x1009_f139, 2); jmpd(0x1009_f0eb, -0x50); goto l_0x1009_f0eb; /* jmp 0x1009f0eb */
        l_0x1009_f13b:
            ii(0x1009_f13b, 2); jmpd(0x1009_f0d0, -0x6d); goto l_0x1009_f0d0; /* jmp 0x1009f0d0 */
        l_0x1009_f13d:
            ii(0x1009_f13d, 3); fild(memw_a32[ss, ebp - 0x14]);         /* fild word [ebp-0x14] */
            ii(0x1009_f140, 5); calld(Definitions.sys_sqrt, 0xc_6f01);  /* call 0x10166046 */
            ii(0x1009_f145, 6); fmul(memq_a32[ds, 0x101a_07c9]);        /* fmul qword [0x101a07c9] */
            ii(0x1009_f14b, 5); calld(Definitions.sys_round, 0xc_6f2e); /* call 0x1016607e */
            ii(0x1009_f150, 3); fistp(memd_a32[ss, ebp - 0x20]);        /* fistp dword [ebp-0x20] */
            ii(0x1009_f153, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1009_f156, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1009_f159, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_f15c, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1009_f15f, 5); calld(0x1007_6b90, -0x2_85d4);          /* call 0x10076b90 */
            ii(0x1009_f164, 4); cmp(ax, memw_a32[ss, ebp - 0x14]);      /* cmp ax, [ebp-0x14] */
            ii(0x1009_f168, 2); if(jged(0x1009_f183, 0x19)) goto l_0x1009_f183; /* jge 0x1009f183 */
            ii(0x1009_f16a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_f16d, 4); inc(memw_a32[ds, eax + 0x21]);          /* inc word [eax+0x21] */
            ii(0x1009_f171, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_f174, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x1009_f177, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1009_f17a, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x1009_f17d, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1009_f180, 3); calld_abs(memd_a32[ds, edx + 0x78]);    /* call dword [edx+0x78] */
        l_0x1009_f183:
            ii(0x1009_f183, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_f186, 5); calld(0x1009_cd8f, -0x23fc);            /* call 0x1009cd8f */
            ii(0x1009_f18b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_f18d, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1009_f190, 5); calld(0x1007_5f6c, -0x2_9229);          /* call 0x10075f6c */
            ii(0x1009_f195, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_f197, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_f198, 1); popd(edi);                              /* pop edi */
            ii(0x1009_f199, 1); popd(esi);                              /* pop esi */
            ii(0x1009_f19a, 1); popd(edx);                              /* pop edx */
            ii(0x1009_f19b, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_f19c, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_f19d, 1); retd(); return;                         /* ret */
        }
    }
}
