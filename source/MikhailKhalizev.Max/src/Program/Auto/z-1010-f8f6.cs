using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_f8f6-c18fbd55")]
        public void Method_1010_f8f6()
        {
            ii(0x1010_f8f6, 5); pushd(0x54);                            /* push 0x54 */
            ii(0x1010_f8fb, 5); calld(Definitions.sys_check_available_stack_size, 0x5_6452); /* call 0x10165d52 */
            ii(0x1010_f900, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_f901, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_f902, 1); pushd(edx);                             /* push edx */
            ii(0x1010_f903, 1); pushd(esi);                             /* push esi */
            ii(0x1010_f904, 1); pushd(edi);                             /* push edi */
            ii(0x1010_f905, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_f906, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_f908, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x1010_f90e, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1010_f911, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
            ii(0x1010_f915, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_f918, 3); mov(eax, memd_a32[ds, eax + 0xc]);      /* mov eax, [eax+0xc] */
            ii(0x1010_f91b, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1010_f91e, 2); jmpd(0x1010_f96a, 0x4a); goto l_0x1010_f96a; /* jmp 0x1010f96a */
        l_0x1010_f920:
            ii(0x1010_f920, 5); mov(ebx, 0x5);                          /* mov ebx, 0x5 */
            ii(0x1010_f925, 5); mov(edx, 0x101b_ad3c);                  /* mov edx, 0x101bad3c */
            ii(0x1010_f92a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_f92d, 5); calld(0x1010_f6c6, -0x26c);             /* call 0x1010f6c6 */
            ii(0x1010_f932, 4); mov(memb_a32[ss, ebp - 0x8], 0x2);      /* mov byte [ebp-0x8], 0x2 */
            ii(0x1010_f936, 2); jmpd(0x1010_f986, 0x4e); goto l_0x1010_f986; /* jmp 0x1010f986 */
        l_0x1010_f938:
            ii(0x1010_f938, 5); mov(ebx, 0x6);                          /* mov ebx, 0x6 */
            ii(0x1010_f93d, 5); mov(edx, 0x101b_ad24);                  /* mov edx, 0x101bad24 */
            ii(0x1010_f942, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_f945, 5); calld(0x1010_f6c6, -0x284);             /* call 0x1010f6c6 */
            ii(0x1010_f94a, 4); mov(memb_a32[ss, ebp - 0x8], 0x1);      /* mov byte [ebp-0x8], 0x1 */
            ii(0x1010_f94e, 2); jmpd(0x1010_f986, 0x36); goto l_0x1010_f986; /* jmp 0x1010f986 */
        l_0x1010_f950:
            ii(0x1010_f950, 5); mov(ebx, 0x7);                          /* mov ebx, 0x7 */
            ii(0x1010_f955, 5); mov(edx, 0x101b_ad50);                  /* mov edx, 0x101bad50 */
            ii(0x1010_f95a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_f95d, 5); calld(0x1010_f6c6, -0x29c);             /* call 0x1010f6c6 */
            ii(0x1010_f962, 4); mov(memb_a32[ss, ebp - 0x8], 0x1);      /* mov byte [ebp-0x8], 0x1 */
            ii(0x1010_f966, 2); jmpd(0x1010_f986, 0x1e); goto l_0x1010_f986; /* jmp 0x1010f986 */
        l_0x1010_f968:
            ii(0x1010_f968, 2); jmpd(0x1010_f986, 0x1c); goto l_0x1010_f986; /* jmp 0x1010f986 */
        l_0x1010_f96a:
            ii(0x1010_f96a, 4); cmp(memd_a32[ss, ebp - 0x10], 0x1);     /* cmp dword [ebp-0x10], 0x1 */
            ii(0x1010_f96e, 2); if(jbd(0x1010_f97e, 0xe)) goto l_0x1010_f97e; /* jb 0x1010f97e */
            ii(0x1010_f970, 4); cmp(memd_a32[ss, ebp - 0x10], 0x1);     /* cmp dword [ebp-0x10], 0x1 */
            ii(0x1010_f974, 2); if(jbed(0x1010_f938, -0x3e)) goto l_0x1010_f938; /* jbe 0x1010f938 */
            ii(0x1010_f976, 4); cmp(memd_a32[ss, ebp - 0x10], 0x2);     /* cmp dword [ebp-0x10], 0x2 */
            ii(0x1010_f97a, 2); if(jzd(0x1010_f950, -0x2c)) goto l_0x1010_f950; /* jz 0x1010f950 */
            ii(0x1010_f97c, 2); jmpd(0x1010_f968, -0x16); goto l_0x1010_f968; /* jmp 0x1010f968 */
        l_0x1010_f97e:
            ii(0x1010_f97e, 4); cmp(memd_a32[ss, ebp - 0x10], 0);       /* cmp dword [ebp-0x10], 0x0 */
            ii(0x1010_f982, 2); if(jzd(0x1010_f920, -0x64)) goto l_0x1010_f920; /* jz 0x1010f920 */
            ii(0x1010_f984, 2); jmpd(0x1010_f968, -0x1e); goto l_0x1010_f968; /* jmp 0x1010f968 */
        l_0x1010_f986:
            ii(0x1010_f986, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_f989, 4); imul(eax, memd_a32[ds, eax + 0xc], 0x14); /* imul eax, [eax+0xc], 0x14 */
            ii(0x1010_f98d, 5); mov(edx, 0x101b_ab38);                  /* mov edx, 0x101bab38 */
            ii(0x1010_f992, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1010_f994, 3); mov(memd_a32[ss, ebp - 0x18], edx);     /* mov [ebp-0x18], edx */
            ii(0x1010_f997, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_f99a, 2); pushd(memd_a32[ds, eax]);               /* push dword [eax] */
            ii(0x1010_f99c, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1010_f99e, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1010_f9a1, 3); mov(ebx, memd_a32[ds, eax + 0x4]);      /* mov ebx, [eax+0x4] */
            ii(0x1010_f9a4, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1010_f9a7, 2); mov(edx, memd_a32[ds, eax]);            /* mov edx, [eax] */
            ii(0x1010_f9a9, 5); mov(eax, 0x22b);                        /* mov eax, 0x22b */
            ii(0x1010_f9ae, 5); calld(0x100e_8ef1, -0x2_6ac2);          /* call 0x100e8ef1 */
            ii(0x1010_f9b3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_f9b6, 3); mov(edx, memd_a32[ds, eax + 0xc]);      /* mov edx, [eax+0xc] */
            ii(0x1010_f9b9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_f9bc, 3); mov(memd_a32[ds, eax + 0x10], edx);     /* mov [eax+0x10], edx */
            ii(0x1010_f9bf, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1010_f9c2, 3); mov(edx, memd_a32[ds, eax + 0x10]);     /* mov edx, [eax+0x10] */
            ii(0x1010_f9c5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_f9c8, 5); add(eax, 0xe9);                         /* add eax, 0xe9 */
            ii(0x1010_f9cd, 5); calld(Definitions.sys_strcpy, 0x5_64fd); /* call 0x10165ecf */
            ii(0x1010_f9d2, 5); mov(eax, 0x3a);                         /* mov eax, 0x3a */
            ii(0x1010_f9d7, 5); calld(Definitions.sys_new, 0x5_6424);   /* call 0x10165e00 */
            ii(0x1010_f9dc, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1010_f9df, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1010_f9e2, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1010_f9e5, 4); cmp(memd_a32[ss, ebp - 0x1c], 0);       /* cmp dword [ebp-0x1c], 0x0 */
            ii(0x1010_f9e9, 2); if(jzd(0x1010_fa57, 0x6c)) goto l_0x1010_fa57; /* jz 0x1010fa57 */
            ii(0x1010_f9eb, 5); mov(eax, 0x5);                          /* mov eax, 0x5 */
            ii(0x1010_f9f0, 1); pushd(eax);                             /* push eax */
            ii(0x1010_f9f1, 5); mov(eax, 0xa2);                         /* mov eax, 0xa2 */
            ii(0x1010_f9f6, 1); pushd(eax);                             /* push eax */
            ii(0x1010_f9f7, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1010_f9fa, 4); mov(ax, memw_a32[ds, eax + 0xc]);       /* mov ax, [eax+0xc] */
            ii(0x1010_f9fe, 3); mov(edx, memd_a32[ss, ebp - 0x18]);     /* mov edx, [ebp-0x18] */
            ii(0x1010_fa01, 4); sub(ax, memw_a32[ds, edx + 0x4]);       /* sub ax, [edx+0x4] */
            ii(0x1010_fa05, 1); inc(eax);                               /* inc eax */
            ii(0x1010_fa06, 1); cwde();                                 /* cwde */
            ii(0x1010_fa07, 1); pushd(eax);                             /* push eax */
            ii(0x1010_fa08, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1010_fa0b, 4); mov(ax, memw_a32[ds, eax + 0x8]);       /* mov ax, [eax+0x8] */
            ii(0x1010_fa0f, 3); mov(edx, memd_a32[ss, ebp - 0x18]);     /* mov edx, [ebp-0x18] */
            ii(0x1010_fa12, 3); sub(ax, memw_a32[ds, edx]);             /* sub ax, [edx] */
            ii(0x1010_fa15, 3); sub(eax, 0xa);                          /* sub eax, 0xa */
            ii(0x1010_fa18, 1); cwde();                                 /* cwde */
            ii(0x1010_fa19, 1); pushd(eax);                             /* push eax */
            ii(0x1010_fa1a, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1010_fa1d, 3); mov(eax, memd_a32[ds, eax + 0x2]);      /* mov eax, [eax+0x2] */
            ii(0x1010_fa20, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1010_fa23, 1); pushd(eax);                             /* push eax */
            ii(0x1010_fa24, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1010_fa27, 3); mov(ax, memw_a32[ds, eax]);             /* mov ax, [eax] */
            ii(0x1010_fa2a, 5); add(eax, 0xa);                          /* add eax, 0xa */
            ii(0x1010_fa2f, 1); cwde();                                 /* cwde */
            ii(0x1010_fa30, 1); pushd(eax);                             /* push eax */
            ii(0x1010_fa31, 5); mov(ecx, 0x1e);                         /* mov ecx, 0x1e */
            ii(0x1010_fa36, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x1010_fa39, 6); add(ebx, 0xe9);                         /* add ebx, 0xe9 */
            ii(0x1010_fa3f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_fa42, 2); mov(edx, memd_a32[ds, eax]);            /* mov edx, [eax] */
            ii(0x1010_fa44, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1010_fa47, 5); calld(0x100e_af58, -0x2_4af4);          /* call 0x100eaf58 */
            ii(0x1010_fa4c, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1010_fa4f, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1010_fa52, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1010_fa55, 2); jmpd(0x1010_fa5d, 0x6); goto l_0x1010_fa5d; /* jmp 0x1010fa5d */
        l_0x1010_fa57:
            ii(0x1010_fa57, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1010_fa5a, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
        l_0x1010_fa5d:
            ii(0x1010_fa5d, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1010_fa60, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1010_fa63, 3); mov(memd_a32[ds, edx + 0x15], eax);     /* mov [edx+0x15], eax */
            ii(0x1010_fa66, 4); movsx(edx, memb_a32[ss, ebp - 0x8]);    /* movsx edx, byte [ebp-0x8] */
            ii(0x1010_fa6a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_fa6d, 3); mov(eax, memd_a32[ds, eax + 0x15]);     /* mov eax, [eax+0x15] */
            ii(0x1010_fa70, 5); calld(0x100d_60d4, -0x3_99a1);          /* call 0x100d60d4 */
            ii(0x1010_fa75, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_fa78, 3); mov(eax, memd_a32[ds, eax + 0x15]);     /* mov eax, [eax+0x15] */
            ii(0x1010_fa7b, 5); calld(0x100e_b180, -0x2_4900);          /* call 0x100eb180 */
            ii(0x1010_fa80, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1010_fa83, 6); add(edx, 0xe9);                         /* add edx, 0xe9 */
            ii(0x1010_fa89, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_fa8c, 3); mov(eax, memd_a32[ds, eax + 0x15]);     /* mov eax, [eax+0x15] */
            ii(0x1010_fa8f, 5); calld(0x100e_b14d, -0x2_4947);          /* call 0x100eb14d */
            ii(0x1010_fa94, 5); calld(0x100d_6104, -0x3_9995);          /* call 0x100d6104 */
            ii(0x1010_fa99, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_fa9b, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x1010_fa9d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_faa0, 3); mov(eax, memd_a32[ds, eax + 0x15]);     /* mov eax, [eax+0x15] */
            ii(0x1010_faa3, 5); calld(0x100e_b5e1, -0x2_44c7);          /* call 0x100eb5e1 */
            ii(0x1010_faa8, 4); cmp(memb_a32[ss, ebp - 0x8], 0);        /* cmp byte [ebp-0x8], 0x0 */
            ii(0x1010_faac, 2); if(jnzd(0x1010_fab9, 0xb)) goto l_0x1010_fab9; /* jnz 0x1010fab9 */
            ii(0x1010_faae, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_fab1, 3); mov(eax, memd_a32[ds, eax + 0x15]);     /* mov eax, [eax+0x15] */
            ii(0x1010_fab4, 5); calld(0x100e_b1b2, -0x2_4907);          /* call 0x100eb1b2 */
        l_0x1010_fab9:
            ii(0x1010_fab9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_fabc, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1010_fabe, 3); mov(eax, memd_a32[ds, eax + 0x12]);     /* mov eax, [eax+0x12] */
            ii(0x1010_fac1, 5); calld(Definitions.sys_display_draw_0, 0x5_79be); /* call 0x10167484 */
            ii(0x1010_fac6, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_fac8, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_fac9, 1); popd(edi);                              /* pop edi */
            ii(0x1010_faca, 1); popd(esi);                              /* pop esi */
            ii(0x1010_facb, 1); popd(edx);                              /* pop edx */
            ii(0x1010_facc, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_facd, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_face, 1); retd(); return;                         /* ret */
        }
    }
}
