using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_cbbb-ae0589d5")]
        public void Method_100a_cbbb()
        {
            ii(0x100a_cbbb, 5); pushd(0x64);                            /* push 0x64 */
            ii(0x100a_cbc0, 5); calld(Definitions.sys_check_available_stack_size, 0xb_918d); /* call 0x10165d52 */
            ii(0x100a_cbc5, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_cbc6, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_cbc7, 1); pushd(esi);                             /* push esi */
            ii(0x100a_cbc8, 1); pushd(edi);                             /* push edi */
            ii(0x100a_cbc9, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_cbca, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_cbcc, 6); sub(esp, 0x48);                         /* sub esp, 0x48 */
            ii(0x100a_cbd2, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_cbd5, 3); mov(memb_a32[ss, ebp - 0x4], dl);       /* mov [ebp-0x4], dl */
            ii(0x100a_cbd8, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100a_cbdb, 5); calld(Definitions.my_ctor_0x101b_4184, -0x3_60f0); /* call 0x10076af0 */
            ii(0x100a_cbe0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_cbe3, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_cbe6, 5); calld(0x1007_6574, -0x3_6677);          /* call 0x10076574 */
            ii(0x100a_cbeb, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_cbed, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_cbf0, 4); mov(ax, memw_a32[ds, eax + 0x22]);      /* mov ax, [eax+0x22] */
            ii(0x100a_cbf4, 4); sub(ax, memw_a32[ds, edx + 0x1a]);      /* sub ax, [edx+0x1a] */
            ii(0x100a_cbf8, 4); mov(memw_a32[ss, ebp - 0xc], ax);       /* mov [ebp-0xc], ax */
            ii(0x100a_cbfc, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_cbff, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_cc02, 5); calld(0x1007_6574, -0x3_6693);          /* call 0x10076574 */
            ii(0x100a_cc07, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_cc09, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_cc0c, 4); mov(ax, memw_a32[ds, eax + 0x24]);      /* mov ax, [eax+0x24] */
            ii(0x100a_cc10, 4); sub(ax, memw_a32[ds, edx + 0x1c]);      /* sub ax, [edx+0x1c] */
            ii(0x100a_cc14, 4); mov(memw_a32[ss, ebp - 0xa], ax);       /* mov [ebp-0xa], ax */
            ii(0x100a_cc18, 4); movsx(edx, memw_a32[ss, ebp - 0xa]);    /* movsx edx, word [ebp-0xa] */
            ii(0x100a_cc1c, 4); movsx(eax, memw_a32[ss, ebp - 0xa]);    /* movsx eax, word [ebp-0xa] */
            ii(0x100a_cc20, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x100a_cc23, 2); mov(ebx, edx);                          /* mov ebx, edx */
            ii(0x100a_cc25, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x100a_cc29, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x100a_cc2d, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x100a_cc30, 2); add(ebx, eax);                          /* add ebx, eax */
            ii(0x100a_cc32, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_cc35, 3); mov(eax, memd_a32[ds, eax + 0x15]);     /* mov eax, [eax+0x15] */
            ii(0x100a_cc38, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_cc3b, 2); cmp(ebx, eax);                          /* cmp ebx, eax */
            ii(0x100a_cc3d, 2); if(jgd(0x100a_cc51, 0x12)) goto l_0x100a_cc51; /* jg 0x100acc51 */
            ii(0x100a_cc3f, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100a_cc44, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_cc47, 5); calld(0x100a_d02d, 0x3e1);              /* call 0x100ad02d */
            ii(0x100a_cc4c, 5); jmpd(0x100a_cdca, 0x179); goto l_0x100a_cdca; /* jmp 0x100acdca */
        l_0x100a_cc51:
            ii(0x100a_cc51, 4); or(memb_a32[ss, ebp - 0x10], 0x1);      /* or byte [ebp-0x10], 0x1 */
            ii(0x100a_cc55, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100a_cc58, 5); calld(Definitions.my_ctor_0x101b_3b58, -0x2_1bb9); /* call 0x1008b0a4 */
            ii(0x100a_cc5d, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100a_cc60, 4); and(memb_a32[ss, ebp - 0x10], -0x2 /* 0xfe */); /* and byte [ebp-0x10], 0xfe */
            ii(0x100a_cc64, 5); mov(eax, 0x20);                         /* mov eax, 0x20 */
            ii(0x100a_cc69, 5); calld(Definitions.sys_new, 0xb_9192);   /* call 0x10165e00 */
            ii(0x100a_cc6e, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x100a_cc71, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100a_cc74, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x100a_cc77, 4); cmp(memd_a32[ss, ebp - 0x20], 0);       /* cmp dword [ebp-0x20], 0x0 */
            ii(0x100a_cc7b, 2); if(jzd(0x100a_ccb2, 0x35)) goto l_0x100a_ccb2; /* jz 0x100accb2 */
            ii(0x100a_cc7d, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100a_cc80, 3); add(edx, 0x22);                         /* add edx, 0x22 */
            ii(0x100a_cc83, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100a_cc86, 5); calld(0x1007_5e64, -0x3_6e27);          /* call 0x10075e64 */
            ii(0x100a_cc8b, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x100a_cc8d, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x100a_cc92, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_cc95, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_cc98, 5); calld(0x1007_65d0, -0x3_66cd);          /* call 0x100765d0 */
            ii(0x100a_cc9d, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_cc9f, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100a_cca2, 5); calld(0x100a_beeb, -0xdbc);             /* call 0x100abeeb */
            ii(0x100a_cca7, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x100a_ccaa, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x100a_ccad, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
            ii(0x100a_ccb0, 2); jmpd(0x100a_ccb8, 0x6); goto l_0x100a_ccb8; /* jmp 0x100accb8 */
        l_0x100a_ccb2:
            ii(0x100a_ccb2, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x100a_ccb5, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
        l_0x100a_ccb8:
            ii(0x100a_ccb8, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x100a_ccbb, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
            ii(0x100a_ccbe, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_ccc1, 4); mov(memb_a32[ds, eax + 0x47], 0);       /* mov byte [eax+0x47], 0x0 */
            ii(0x100a_ccc5, 4); movsx(edx, memw_a32[ss, ebp - 0xa]);    /* movsx edx, word [ebp-0xa] */
            ii(0x100a_ccc9, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x100a_cccd, 5); calld(0x100a_5f65, -0x6d6d);            /* call 0x100a5f65 */
            ii(0x100a_ccd2, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100a_ccd5, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100a_ccd7, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100a_ccda, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100a_ccdc, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x100a_ccde, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
            ii(0x100a_cce1, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_cce4, 3); mov(edx, memd_a32[ds, eax + 0x15]);     /* mov edx, [eax+0x15] */
            ii(0x100a_cce7, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100a_ccea, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x100a_cced, 5); calld(0x1011_d85d, 0x7_0b6b);           /* call 0x1011d85d */
            ii(0x100a_ccf2, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_ccf5, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_ccf8, 5); calld(0x1007_6574, -0x3_6789);          /* call 0x10076574 */
            ii(0x100a_ccfd, 5); calld(0x1007_623c, -0x3_6ac6);          /* call 0x1007623c */
            ii(0x100a_cd02, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_cd04, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x100a_cd07, 4); cmp(ax, memw_a32[ds, edx + 0x10]);      /* cmp ax, [edx+0x10] */
            ii(0x100a_cd0b, 2); if(jld(0x100a_cd17, 0xa)) goto l_0x100a_cd17; /* jl 0x100acd17 */
            ii(0x100a_cd0d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_cd10, 5); cmp(memw_a32[ds, eax + 0x26], -0x1 /* 0xff */); /* cmp word [eax+0x26], 0xffff */
            ii(0x100a_cd15, 2); if(jzd(0x100a_cd2a, 0x13)) goto l_0x100a_cd2a; /* jz 0x100acd2a */
        l_0x100a_cd17:
            ii(0x100a_cd17, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_cd1a, 3); mov(edx, memd_a32[ds, eax + 0x16]);     /* mov edx, [eax+0x16] */
            ii(0x100a_cd1d, 3); sar(edx, 0x18);                         /* sar edx, 0x18 */
            ii(0x100a_cd20, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x100a_cd23, 5); calld(0x1011_d801, 0x7_0ad9);           /* call 0x1011d801 */
            ii(0x100a_cd28, 2); jmpd(0x100a_cd37, 0xd); goto l_0x100a_cd37; /* jmp 0x100acd37 */
        l_0x100a_cd2a:
            ii(0x100a_cd2a, 5); mov(edx, 0x3);                          /* mov edx, 0x3 */
            ii(0x100a_cd2f, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x100a_cd32, 5); calld(0x1011_d801, 0x7_0aca);           /* call 0x1011d801 */
        l_0x100a_cd37:
            ii(0x100a_cd37, 4); cmp(memb_a32[ss, ebp - 0x4], 0);        /* cmp byte [ebp-0x4], 0x0 */
            ii(0x100a_cd3b, 2); if(jzd(0x100a_cd5e, 0x21)) goto l_0x100a_cd5e; /* jz 0x100acd5e */
            ii(0x100a_cd3d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_cd40, 5); cmp(memw_a32[ds, eax + 0x26], -0x1 /* 0xff */); /* cmp word [eax+0x26], 0xffff */
            ii(0x100a_cd45, 2); if(jnzd(0x100a_cd4d, 0x6)) goto l_0x100a_cd4d; /* jnz 0x100acd4d */
            ii(0x100a_cd47, 4); mov(memb_a32[ss, ebp - 0x38], 0x1);     /* mov byte [ebp-0x38], 0x1 */
            ii(0x100a_cd4b, 2); jmpd(0x100a_cd51, 0x4); goto l_0x100a_cd51; /* jmp 0x100acd51 */
        l_0x100a_cd4d:
            ii(0x100a_cd4d, 4); mov(memb_a32[ss, ebp - 0x38], 0);       /* mov byte [ebp-0x38], 0x0 */
        l_0x100a_cd51:
            ii(0x100a_cd51, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_cd53, 3); mov(dl, memb_a32[ss, ebp - 0x38]);      /* mov dl, [ebp-0x38] */
            ii(0x100a_cd56, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x100a_cd59, 5); calld(0x100a_c163, -0xbfb);             /* call 0x100ac163 */
        l_0x100a_cd5e:
            ii(0x100a_cd5e, 5); mov(eax, 0x1f);                         /* mov eax, 0x1f */
            ii(0x100a_cd63, 5); calld(Definitions.sys_new, 0xb_9098);   /* call 0x10165e00 */
            ii(0x100a_cd68, 3); mov(memd_a32[ss, ebp - 0x3c], eax);     /* mov [ebp-0x3c], eax */
            ii(0x100a_cd6b, 3); mov(eax, memd_a32[ss, ebp - 0x3c]);     /* mov eax, [ebp-0x3c] */
            ii(0x100a_cd6e, 3); mov(memd_a32[ss, ebp - 0x40], eax);     /* mov [ebp-0x40], eax */
            ii(0x100a_cd71, 4); cmp(memd_a32[ss, ebp - 0x40], 0);       /* cmp dword [ebp-0x40], 0x0 */
            ii(0x100a_cd75, 2); if(jzd(0x100a_cd9b, 0x24)) goto l_0x100a_cd9b; /* jz 0x100acd9b */
            ii(0x100a_cd77, 5); mov(eax, 0x100a_d995);                  /* mov eax, 0x100ad995 */
            ii(0x100a_cd7c, 1); pushd(eax);                             /* push eax */
            ii(0x100a_cd7d, 5); mov(ecx, 0x100a_d2cc);                  /* mov ecx, 0x100ad2cc */
            ii(0x100a_cd82, 3); mov(ebx, memd_a32[ss, ebp - 0x30]);     /* mov ebx, [ebp-0x30] */
            ii(0x100a_cd85, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100a_cd88, 3); mov(eax, memd_a32[ss, ebp - 0x3c]);     /* mov eax, [ebp-0x3c] */
            ii(0x100a_cd8b, 5); calld(0x100a_ba72, -0x131e);            /* call 0x100aba72 */
            ii(0x100a_cd90, 3); mov(memd_a32[ss, ebp - 0x44], eax);     /* mov [ebp-0x44], eax */
            ii(0x100a_cd93, 3); mov(eax, memd_a32[ss, ebp - 0x44]);     /* mov eax, [ebp-0x44] */
            ii(0x100a_cd96, 3); mov(memd_a32[ss, ebp - 0x48], eax);     /* mov [ebp-0x48], eax */
            ii(0x100a_cd99, 2); jmpd(0x100a_cda1, 0x6); goto l_0x100a_cda1; /* jmp 0x100acda1 */
        l_0x100a_cd9b:
            ii(0x100a_cd9b, 3); mov(eax, memd_a32[ss, ebp - 0x40]);     /* mov eax, [ebp-0x40] */
            ii(0x100a_cd9e, 3); mov(memd_a32[ss, ebp - 0x48], eax);     /* mov [ebp-0x48], eax */
        l_0x100a_cda1:
            ii(0x100a_cda1, 3); mov(edx, memd_a32[ss, ebp - 0x48]);     /* mov edx, [ebp-0x48] */
            ii(0x100a_cda4, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100a_cda7, 5); calld(0x1008_afe4, -0x2_1dc8);          /* call 0x1008afe4 */
            ii(0x100a_cdac, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100a_cdaf, 5); calld(0x1008_af84, -0x2_1e30);          /* call 0x1008af84 */
            ii(0x100a_cdb4, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_cdb6, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100a_cdbb, 5); calld(0x100a_4d50, -0x8070);            /* call 0x100a4d50 */
            ii(0x100a_cdc0, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_cdc2, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100a_cdc5, 5); calld(0x1008_8b7c, -0x2_424e);          /* call 0x10088b7c */
        l_0x100a_cdca:
            ii(0x100a_cdca, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_cdcc, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_cdcd, 1); popd(edi);                              /* pop edi */
            ii(0x100a_cdce, 1); popd(esi);                              /* pop esi */
            ii(0x100a_cdcf, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_cdd0, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_cdd1, 1); retd(); return;                         /* ret */
        }
    }
}
