using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_852e-bf97df7b")]
        public void Method_1015_852e()
        {
            ii(0x1015_852e, 5); pushd(0x5c);                            /* push 0x5c */
            ii(0x1015_8533, 5); calld(Definitions.sys_check_available_stack_size, 0xd81a); /* call 0x10165d52 */
            ii(0x1015_8538, 1); pushd(ebx);                             /* push ebx */
            ii(0x1015_8539, 1); pushd(ecx);                             /* push ecx */
            ii(0x1015_853a, 1); pushd(edx);                             /* push edx */
            ii(0x1015_853b, 1); pushd(esi);                             /* push esi */
            ii(0x1015_853c, 1); pushd(edi);                             /* push edi */
            ii(0x1015_853d, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_853e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_8540, 6); sub(esp, 0x3c);                         /* sub esp, 0x3c */
            ii(0x1015_8546, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1015_8549, 7); mov(memd_a32[ss, ebp - 0x14], 0x162);   /* mov dword [ebp-0x14], 0x162 */
            ii(0x1015_8550, 2); jmpd(0x1015_8555, 0x3); goto l_0x1015_8555; /* jmp 0x10158555 */
        l_0x1015_8552:
            ii(0x1015_8552, 3); inc(memd_a32[ss, ebp - 0x14]);          /* inc dword [ebp-0x14] */
        l_0x1015_8555:
            ii(0x1015_8555, 6); cmp(memw_a32[ss, ebp - 0x14], 0x167);   /* cmp word [ebp-0x14], 0x167 */
            ii(0x1015_855b, 2); if(jgd(0x1015_85ad, 0x50)) goto l_0x1015_85ad; /* jg 0x101585ad */
            ii(0x1015_855d, 5); calld(0x1014_82f4, -0x1_026e);          /* call 0x101482f4 */
            ii(0x1015_8562, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
            ii(0x1015_8565, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_8568, 1); pushd(eax);                             /* push eax */
            ii(0x1015_8569, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1015_856b, 5); mov(ebx, 0xb);                          /* mov ebx, 0xb */
            ii(0x1015_8570, 5); mov(edx, 0xd);                          /* mov edx, 0xd */
            ii(0x1015_8575, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x1015_8579, 5); calld(0x100e_8ef1, -0x6_f68d);          /* call 0x100e8ef1 */
            ii(0x1015_857e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_8581, 3); mov(eax, memd_a32[ds, eax + 0x12]);     /* mov eax, [eax+0x12] */
            ii(0x1015_8584, 5); calld(Definitions.sys_display_draw_0, 0xeefb); /* call 0x10167484 */
            ii(0x1015_8589, 5); calld(0x100d_5094, -0x8_34fa);          /* call 0x100d5094 */
            ii(0x1015_858e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_8590, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x1015_8592, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1015_8597, 5); calld(0x1010_0e32, -0x5_776a);          /* call 0x10100e32 */
        l_0x1015_859c:
            ii(0x1015_859c, 5); calld(0x1014_82f4, -0x1_02ad);          /* call 0x101482f4 */
            ii(0x1015_85a1, 3); sub(eax, memd_a32[ss, ebp - 0x30]);     /* sub eax, [ebp-0x30] */
            ii(0x1015_85a4, 5); cmp(eax, 0x6119);                       /* cmp eax, 0x6119 */
            ii(0x1015_85a9, 2); if(jbd(0x1015_859c, -0xf)) goto l_0x1015_859c; /* jb 0x1015859c */
            ii(0x1015_85ab, 2); jmpd(0x1015_8552, -0x5b); goto l_0x1015_8552; /* jmp 0x10158552 */
        l_0x1015_85ad:
            ii(0x1015_85ad, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x1015_85b2, 5); calld(Definitions.sys_new, 0xd849);     /* call 0x10165e00 */
            ii(0x1015_85b7, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1015_85ba, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1015_85bd, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x1015_85c0, 4); cmp(memd_a32[ss, ebp - 0x28], 0);       /* cmp dword [ebp-0x28], 0x0 */
            ii(0x1015_85c4, 2); if(jzd(0x1015_85ee, 0x28)) goto l_0x1015_85ee; /* jz 0x101585ee */
            ii(0x1015_85c6, 5); mov(eax, 0xb);                          /* mov eax, 0xb */
            ii(0x1015_85cb, 1); pushd(eax);                             /* push eax */
            ii(0x1015_85cc, 5); mov(ecx, 0xd);                          /* mov ecx, 0xd */
            ii(0x1015_85d1, 5); mov(ebx, 0x161);                        /* mov ebx, 0x161 */
            ii(0x1015_85d6, 5); mov(edx, 0x160);                        /* mov edx, 0x160 */
            ii(0x1015_85db, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1015_85de, 5); calld(Definitions.my_ctor_c17, -0x8_a1d4); /* call 0x100ce40f */
            ii(0x1015_85e3, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1015_85e6, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1015_85e9, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
            ii(0x1015_85ec, 2); jmpd(0x1015_85f4, 0x6); goto l_0x1015_85f4; /* jmp 0x101585f4 */
        l_0x1015_85ee:
            ii(0x1015_85ee, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1015_85f1, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
        l_0x1015_85f4:
            ii(0x1015_85f4, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x1015_85f7, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x1015_85fa, 5); mov(edx, 0xd);                          /* mov edx, 0xd */
            ii(0x1015_85ff, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1015_8602, 5); calld(0x100d_5134, -0x8_34d3);          /* call 0x100d5134 */
            ii(0x1015_8607, 5); mov(edx, 0x700d);                       /* mov edx, 0x700d */
            ii(0x1015_860c, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1015_860f, 5); calld(0x100d_5164, -0x8_34b0);          /* call 0x100d5164 */
            ii(0x1015_8614, 5); mov(edx, 0x4e6);                        /* mov edx, 0x4e6 */
            ii(0x1015_8619, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1015_861c, 5); calld(0x100d_50d4, -0x8_354d);          /* call 0x100d50d4 */
            ii(0x1015_8621, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_8624, 3); mov(edx, memd_a32[ds, eax + 0x12]);     /* mov edx, [eax+0x12] */
            ii(0x1015_8627, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1015_862a, 5); calld(0x100c_f85c, -0x8_8dd3);          /* call 0x100cf85c */
            ii(0x1015_862f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_8632, 3); mov(eax, memd_a32[ds, eax + 0x12]);     /* mov eax, [eax+0x12] */
            ii(0x1015_8635, 5); calld(Definitions.sys_display_draw_0, 0xee4a); /* call 0x10167484 */
            ii(0x1015_863a, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
            ii(0x1015_863e, 4); mov(memb_a32[ss, ebp - 0x10], 0);       /* mov byte [ebp-0x10], 0x0 */
            ii(0x1015_8642, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
        l_0x1015_8646:
            ii(0x1015_8646, 4); cmp(memb_a32[ss, ebp - 0x8], 0);        /* cmp byte [ebp-0x8], 0x0 */
            ii(0x1015_864a, 2); if(jnzd(0x1015_8652, 0x6)) goto l_0x1015_8652; /* jnz 0x10158652 */
            ii(0x1015_864c, 4); cmp(memb_a32[ss, ebp - 0x10], 0);       /* cmp byte [ebp-0x10], 0x0 */
            ii(0x1015_8650, 2); if(jzd(0x1015_8657, 0x5)) goto l_0x1015_8657; /* jz 0x10158657 */
        l_0x1015_8652:
            ii(0x1015_8652, 5); jmpd(0x1015_86d6, 0x7f); goto l_0x1015_86d6; /* jmp 0x101586d6 */
        l_0x1015_8657:
            ii(0x1015_8657, 5); calld(/* sys */ 0x1016_b208, 0x1_2bac); /* call 0x1016b208 */
            ii(0x1015_865c, 3); mov(memd_a32[ss, ebp - 0x38], eax);     /* mov [ebp-0x38], eax */
            ii(0x1015_865f, 7); cmp(memb_a32[ds, 0x101c_37d2], 0);      /* cmp byte [0x101c37d2], 0x0 */
            ii(0x1015_8666, 2); if(jzd(0x1015_866f, 0x7)) goto l_0x1015_866f; /* jz 0x1015866f */
            ii(0x1015_8668, 7); mov(memd_a32[ss, ebp - 0x38], 0x1b);    /* mov dword [ebp-0x38], 0x1b */
        l_0x1015_866f:
            ii(0x1015_866f, 4); cmp(memd_a32[ss, ebp - 0x38], 0xd);     /* cmp dword [ebp-0x38], 0xd */
            ii(0x1015_8673, 2); if(jnzd(0x1015_867b, 0x6)) goto l_0x1015_867b; /* jnz 0x1015867b */
            ii(0x1015_8675, 4); mov(memb_a32[ss, ebp - 0x8], 0x1);      /* mov byte [ebp-0x8], 0x1 */
            ii(0x1015_8679, 2); jmpd(0x1015_86be, 0x43); goto l_0x1015_86be; /* jmp 0x101586be */
        l_0x1015_867b:
            ii(0x1015_867b, 4); cmp(memd_a32[ss, ebp - 0x38], 0x1b);    /* cmp dword [ebp-0x38], 0x1b */
            ii(0x1015_867f, 2); if(jnzd(0x1015_8687, 0x6)) goto l_0x1015_8687; /* jnz 0x10158687 */
            ii(0x1015_8681, 4); mov(memb_a32[ss, ebp - 0x10], 0x1);     /* mov byte [ebp-0x10], 0x1 */
            ii(0x1015_8685, 2); jmpd(0x1015_86be, 0x37); goto l_0x1015_86be; /* jmp 0x101586be */
        l_0x1015_8687:
            ii(0x1015_8687, 7); cmp(memd_a32[ss, ebp - 0x38], 0x7000);  /* cmp dword [ebp-0x38], 0x7000 */
            ii(0x1015_868e, 2); if(jld(0x1015_8696, 0x6)) goto l_0x1015_8696; /* jl 0x10158696 */
            ii(0x1015_8690, 4); cmp(memb_a32[ss, ebp - 0xc], 0);        /* cmp byte [ebp-0xc], 0x0 */
            ii(0x1015_8694, 2); if(jzd(0x1015_8698, 0x2)) goto l_0x1015_8698; /* jz 0x10158698 */
        l_0x1015_8696:
            ii(0x1015_8696, 2); jmpd(0x1015_86be, 0x26); goto l_0x1015_86be; /* jmp 0x101586be */
        l_0x1015_8698:
            ii(0x1015_8698, 7); cmp(memd_a32[ss, ebp - 0x38], 0x700d);  /* cmp dword [ebp-0x38], 0x700d */
            ii(0x1015_869f, 2); if(jnzd(0x1015_86ab, 0xa)) goto l_0x1015_86ab; /* jnz 0x101586ab */
            ii(0x1015_86a1, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1015_86a4, 5); calld(0x100c_fbbe, -0x8_8aeb);          /* call 0x100cfbbe */
            ii(0x1015_86a9, 2); jmpd(0x1015_86ba, 0xf); goto l_0x1015_86ba; /* jmp 0x101586ba */
        l_0x1015_86ab:
            ii(0x1015_86ab, 5); mov(edx, 0x4e4);                        /* mov edx, 0x4e4 */
            ii(0x1015_86b0, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x1015_86b5, 5); calld(0x1013_dc59, -0x1_aa61);          /* call 0x1013dc59 */
        l_0x1015_86ba:
            ii(0x1015_86ba, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
        l_0x1015_86be:
            ii(0x1015_86be, 5); calld(0x100d_5094, -0x8_362f);          /* call 0x100d5094 */
            ii(0x1015_86c3, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_86c5, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x1015_86c7, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1015_86cc, 5); calld(0x1010_0e32, -0x5_789f);          /* call 0x10100e32 */
            ii(0x1015_86d1, 5); jmpd(0x1015_8646, -0x90); goto l_0x1015_8646; /* jmp 0x10158646 */
        l_0x1015_86d6:
            ii(0x1015_86d6, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1015_86d9, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1015_86dc, 4); cmp(memd_a32[ss, ebp - 0x18], 0);       /* cmp dword [ebp-0x18], 0x0 */
            ii(0x1015_86e0, 2); if(jzd(0x1015_86f6, 0x14)) goto l_0x1015_86f6; /* jz 0x101586f6 */
            ii(0x1015_86e2, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_86e4, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1015_86e7, 5); calld(Definitions.my_dtor_d2, -0x8_a1b4); /* call 0x100ce538 */
            ii(0x1015_86ec, 5); calld(Definitions.sys_delete, 0xd873);  /* call 0x10165f64 */
            ii(0x1015_86f1, 3); mov(memd_a32[ss, ebp - 0x3c], eax);     /* mov [ebp-0x3c], eax */
            ii(0x1015_86f4, 2); jmpd(0x1015_86fd, 0x7); goto l_0x1015_86fd; /* jmp 0x101586fd */
        l_0x1015_86f6:
            ii(0x1015_86f6, 7); mov(memd_a32[ss, ebp - 0x3c], 0);       /* mov dword [ebp-0x3c], 0x0 */
        l_0x1015_86fd:
            ii(0x1015_86fd, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_86ff, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x1015_8702, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
            ii(0x1015_8705, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x1015_8708, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_870a, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_870b, 1); popd(edi);                              /* pop edi */
            ii(0x1015_870c, 1); popd(esi);                              /* pop esi */
            ii(0x1015_870d, 1); popd(edx);                              /* pop edx */
            ii(0x1015_870e, 1); popd(ecx);                              /* pop ecx */
            ii(0x1015_870f, 1); popd(ebx);                              /* pop ebx */
            ii(0x1015_8710, 1); retd();                                 /* ret */
        }
    }
}
