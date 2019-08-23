using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_1d38-c2fb14b9")]
        public void Method_1012_1d38()
        {
            ii(0x1012_1d38, 5); pushd(0x80);                            /* push 0x80 */
            ii(0x1012_1d3d, 5); calld(Definitions.sys_check_available_stack_size, 0x4_4010); /* call 0x10165d52 */
            ii(0x1012_1d42, 1); pushd(esi);                             /* push esi */
            ii(0x1012_1d43, 1); pushd(edi);                             /* push edi */
            ii(0x1012_1d44, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_1d45, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_1d47, 6); sub(esp, 0x58);                         /* sub esp, 0x58 */
            ii(0x1012_1d4d, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1012_1d50, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x1012_1d53, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x1012_1d56, 3); mov(memd_a32[ss, ebp - 0x4], ecx);      /* mov [ebp-0x4], ecx */
            ii(0x1012_1d59, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1012_1d5c, 5); calld(0x1012_336c, 0x160b);             /* call 0x1012336c */
            ii(0x1012_1d61, 1); pushd(eax);                             /* push eax */
            ii(0x1012_1d62, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1012_1d67, 1); pushd(eax);                             /* push eax */
            ii(0x1012_1d68, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_1d6a, 1); pushd(eax);                             /* push eax */
            ii(0x1012_1d6b, 5); mov(eax, 0x14);                         /* mov eax, 0x14 */
            ii(0x1012_1d70, 1); pushd(eax);                             /* push eax */
            ii(0x1012_1d71, 5); mov(eax, 0xb9);                         /* mov eax, 0xb9 */
            ii(0x1012_1d76, 1); pushd(eax);                             /* push eax */
            ii(0x1012_1d77, 4); movsx(ecx, memw_a32[ss, ebp - 0x4]);    /* movsx ecx, word [ebp-0x4] */
            ii(0x1012_1d7b, 4); movsx(ebx, memw_a32[ss, ebp - 0x8]);    /* movsx ebx, word [ebp-0x8] */
            ii(0x1012_1d7f, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x1012_1d83, 3); imul(edx, edx, 0x1c);                   /* imul edx, edx, 0x1c */
            ii(0x1012_1d86, 6); mov(edx, memd_a32[ds, edx + 0x101b_b05d]); /* mov edx, [edx+0x101bb05d] */
            ii(0x1012_1d8c, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1012_1d8f, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1012_1d92, 5); calld(0x100e_ab9d, -0x3_71fa);          /* call 0x100eab9d */
            ii(0x1012_1d97, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1012_1d9b, 3); imul(eax, eax, 0x1c);                   /* imul eax, eax, 0x1c */
            ii(0x1012_1d9e, 6); mov(al, memb_a32[ds, eax + 0x101b_b061]); /* mov al, [eax+0x101bb061] */
            ii(0x1012_1da4, 3); mov(memb_a32[ss, ebp - 0x14], al);      /* mov [ebp-0x14], al */
            ii(0x1012_1da7, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1012_1dab, 3); imul(eax, eax, 0x1c);                   /* imul eax, eax, 0x1c */
            ii(0x1012_1dae, 6); mov(al, memb_a32[ds, eax + 0x101b_b05c]); /* mov al, [eax+0x101bb05c] */
            ii(0x1012_1db4, 3); mov(memb_a32[ss, ebp - 0x18], al);      /* mov [ebp-0x18], al */
            ii(0x1012_1db7, 5); jmpd(0x1012_1e80, 0xc4); goto l_0x1012_1e80; /* jmp 0x10121e80 */
        l_0x1012_1dbc:
            ii(0x1012_1dbc, 5); mov(eax, 0x1e);                         /* mov eax, 0x1e */
            ii(0x1012_1dc1, 5); calld(Definitions.sys_new_arr, 0x4_424a); /* call 0x10166010 */
            ii(0x1012_1dc6, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1012_1dc8, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1012_1dcc, 3); imul(eax, eax, 0x1c);                   /* imul eax, eax, 0x1c */
            ii(0x1012_1dcf, 6); mov(memd_a32[ds, eax + 0x101b_b070], edx); /* mov [eax+0x101bb070], edx */
            ii(0x1012_1dd5, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1012_1dd8, 6); cmp(memw_a32[ds, eax + 0x40], 0x6cd);   /* cmp word [eax+0x40], 0x6cd */
            ii(0x1012_1dde, 2); if(jnzd(0x1012_1deb, 0xb)) goto l_0x1012_1deb; /* jnz 0x10121deb */
            ii(0x1012_1de0, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1012_1de3, 3); mov(al, memb_a32[ds, eax + 0x3e]);      /* mov al, [eax+0x3e] */
            ii(0x1012_1de6, 2); add(al, 0x63);                          /* add al, 0x63 */
            ii(0x1012_1de8, 3); mov(memb_a32[ss, ebp - 0x14], al);      /* mov [ebp-0x14], al */
        l_0x1012_1deb:
            ii(0x1012_1deb, 5); mov(ecx, 0x1e);                         /* mov ecx, 0x1e */
            ii(0x1012_1df0, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1012_1df4, 3); imul(eax, eax, 0x1c);                   /* imul eax, eax, 0x1c */
            ii(0x1012_1df7, 6); mov(ebx, memd_a32[ds, eax + 0x101b_b070]); /* mov ebx, [eax+0x101bb070] */
            ii(0x1012_1dfd, 4); movsx(edx, memb_a32[ss, ebp - 0x14]);   /* movsx edx, byte [ebp-0x14] */
            ii(0x1012_1e01, 5); mov(eax, 0x101c_39c8);                  /* mov eax, 0x101c39c8 */
            ii(0x1012_1e06, 5); calld(0x1010_6281, -0x1_bb8a);          /* call 0x10106281 */
            ii(0x1012_1e0b, 7); mov(memd_a32[ss, ebp - 0x20], 0x181);   /* mov dword [ebp-0x20], 0x181 */
            ii(0x1012_1e12, 5); jmpd(0x1012_1ea0, 0x89); goto l_0x1012_1ea0; /* jmp 0x10121ea0 */
        l_0x1012_1e17:
            ii(0x1012_1e17, 5); mov(eax, 0x1e);                         /* mov eax, 0x1e */
            ii(0x1012_1e1c, 5); calld(Definitions.sys_new_arr, 0x4_41ef); /* call 0x10166010 */
            ii(0x1012_1e21, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1012_1e23, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1012_1e27, 3); imul(eax, eax, 0x1c);                   /* imul eax, eax, 0x1c */
            ii(0x1012_1e2a, 6); mov(memd_a32[ds, eax + 0x101b_b070], edx); /* mov [eax+0x101bb070], edx */
            ii(0x1012_1e30, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1012_1e34, 3); imul(eax, eax, 0x1c);                   /* imul eax, eax, 0x1c */
            ii(0x1012_1e37, 7); cmp(memb_a32[ds, eax + 0x101b_b05c], 0x3); /* cmp byte [eax+0x101bb05c], 0x3 */
            ii(0x1012_1e3e, 2); if(jnzd(0x1012_1e49, 0x9)) goto l_0x1012_1e49; /* jnz 0x10121e49 */
            ii(0x1012_1e40, 7); mov(memd_a32[ss, ebp - 0x24], 0x10);    /* mov dword [ebp-0x24], 0x10 */
            ii(0x1012_1e47, 2); jmpd(0x1012_1e50, 0x7); goto l_0x1012_1e50; /* jmp 0x10121e50 */
        l_0x1012_1e49:
            ii(0x1012_1e49, 7); mov(memd_a32[ss, ebp - 0x24], 0xa);     /* mov dword [ebp-0x24], 0xa */
        l_0x1012_1e50:
            ii(0x1012_1e50, 3); mov(ebx, memd_a32[ss, ebp - 0x24]);     /* mov ebx, [ebp-0x24] */
            ii(0x1012_1e53, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1012_1e57, 3); imul(eax, eax, 0x1c);                   /* imul eax, eax, 0x1c */
            ii(0x1012_1e5a, 6); mov(edx, memd_a32[ds, eax + 0x101b_b070]); /* mov edx, [eax+0x101bb070] */
            ii(0x1012_1e60, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1012_1e64, 3); imul(eax, eax, 0x1c);                   /* imul eax, eax, 0x1c */
            ii(0x1012_1e67, 6); mov(eax, memd_a32[ds, eax + 0x101b_b072]); /* mov eax, [eax+0x101bb072] */
            ii(0x1012_1e6d, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1012_1e70, 5); calld(/* sys */ 0x1017_93f8, 0x5_7583); /* call 0x101793f8 */
            ii(0x1012_1e75, 7); mov(memd_a32[ss, ebp - 0x20], 0x180);   /* mov dword [ebp-0x20], 0x180 */
            ii(0x1012_1e7c, 2); jmpd(0x1012_1ea0, 0x22); goto l_0x1012_1ea0; /* jmp 0x10121ea0 */
        l_0x1012_1e7e:
            ii(0x1012_1e7e, 2); jmpd(0x1012_1ea0, 0x20); goto l_0x1012_1ea0; /* jmp 0x10121ea0 */
        l_0x1012_1e80:
            ii(0x1012_1e80, 3); mov(al, memb_a32[ss, ebp - 0x18]);      /* mov al, [ebp-0x18] */
            ii(0x1012_1e83, 3); mov(memb_a32[ss, ebp - 0x28], al);      /* mov [ebp-0x28], al */
            ii(0x1012_1e86, 4); cmp(memb_a32[ss, ebp - 0x28], 0x2);     /* cmp byte [ebp-0x28], 0x2 */
            ii(0x1012_1e8a, 2); if(jbd(0x1012_1e9e, 0x12)) goto l_0x1012_1e9e; /* jb 0x10121e9e */
            ii(0x1012_1e8c, 4); cmp(memb_a32[ss, ebp - 0x28], 0x3);     /* cmp byte [ebp-0x28], 0x3 */
            ii(0x1012_1e90, 2); if(jbed(0x1012_1e17, -0x7b)) goto l_0x1012_1e17; /* jbe 0x10121e17 */
            ii(0x1012_1e92, 4); cmp(memb_a32[ss, ebp - 0x28], 0x4);     /* cmp byte [ebp-0x28], 0x4 */
            ii(0x1012_1e96, 6); if(jzd(0x1012_1dbc, -0xe0)) goto l_0x1012_1dbc; /* jz 0x10121dbc */
            ii(0x1012_1e9c, 2); jmpd(0x1012_1e7e, -0x20); goto l_0x1012_1e7e; /* jmp 0x10121e7e */
        l_0x1012_1e9e:
            ii(0x1012_1e9e, 2); jmpd(0x1012_1e7e, -0x22); goto l_0x1012_1e7e; /* jmp 0x10121e7e */
        l_0x1012_1ea0:
            ii(0x1012_1ea0, 4); movsx(eax, memw_a32[ss, ebp - 0x20]);   /* movsx eax, word [ebp-0x20] */
            ii(0x1012_1ea4, 5); calld(Definitions.my_get_res_data_by_id, 0x1_212f); /* call 0x10133fd8 */
            ii(0x1012_1ea9, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
            ii(0x1012_1eac, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x1012_1eaf, 3); mov(ax, memw_a32[ds, eax]);             /* mov ax, [eax] */
            ii(0x1012_1eb2, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
            ii(0x1012_1eb5, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1012_1eb9, 3); imul(eax, eax, 0x1c);                   /* imul eax, eax, 0x1c */
            ii(0x1012_1ebc, 6); mov(eax, memd_a32[ds, eax + 0x101b_b05d]); /* mov eax, [eax+0x101bb05d] */
            ii(0x1012_1ec2, 6); calld_abs(memd_a32[ds, 0x101b_ddf4]);   /* call dword [0x101bddf4] */
            ii(0x1012_1ec8, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x1012_1ecb, 5); add(eax, 0xa);                          /* add eax, 0xa */
            ii(0x1012_1ed0, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
            ii(0x1012_1ed3, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x1012_1ed6, 2); mov(edx, memd_a32[ds, eax]);            /* mov edx, [eax] */
            ii(0x1012_1ed8, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1012_1edb, 5); mov(eax, 0x14);                         /* mov eax, 0x14 */
            ii(0x1012_1ee0, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1012_1ee2, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1012_1ee4, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1012_1ee6, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1012_1ee9, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1012_1eeb, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x1012_1eed, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x1012_1ef1, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1012_1ef3, 3); mov(memd_a32[ss, ebp - 0x38], eax);     /* mov [ebp-0x38], eax */
            ii(0x1012_1ef6, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1012_1ef9, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1012_1efc, 1); pushd(eax);                             /* push eax */
            ii(0x1012_1efd, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x1012_1f02, 4); movsx(ebx, memw_a32[ss, ebp - 0x38]);   /* movsx ebx, word [ebp-0x38] */
            ii(0x1012_1f06, 4); movsx(edx, memw_a32[ss, ebp - 0x34]);   /* movsx edx, word [ebp-0x34] */
            ii(0x1012_1f0a, 4); movsx(eax, memw_a32[ss, ebp - 0x20]);   /* movsx eax, word [ebp-0x20] */
            ii(0x1012_1f0e, 5); calld(0x100e_8ef1, -0x3_9022);          /* call 0x100e8ef1 */
            ii(0x1012_1f13, 5); mov(eax, 0xd);                          /* mov eax, 0xd */
            ii(0x1012_1f18, 5); calld(Definitions.sys_new, 0x4_3ee3);   /* call 0x10165e00 */
            ii(0x1012_1f1d, 3); mov(memd_a32[ss, ebp - 0x3c], eax);     /* mov [ebp-0x3c], eax */
            ii(0x1012_1f20, 3); mov(eax, memd_a32[ss, ebp - 0x3c]);     /* mov eax, [ebp-0x3c] */
            ii(0x1012_1f23, 3); mov(memd_a32[ss, ebp - 0x40], eax);     /* mov [ebp-0x40], eax */
            ii(0x1012_1f26, 4); cmp(memd_a32[ss, ebp - 0x40], 0);       /* cmp dword [ebp-0x40], 0x0 */
            ii(0x1012_1f2a, 2); if(jzd(0x1012_1f51, 0x25)) goto l_0x1012_1f51; /* jz 0x10121f51 */
            ii(0x1012_1f2c, 5); mov(eax, 0x14);                         /* mov eax, 0x14 */
            ii(0x1012_1f31, 1); pushd(eax);                             /* push eax */
            ii(0x1012_1f32, 4); movsx(ecx, memw_a32[ss, ebp - 0x30]);   /* movsx ecx, word [ebp-0x30] */
            ii(0x1012_1f36, 4); movsx(ebx, memw_a32[ss, ebp - 0x4]);    /* movsx ebx, word [ebp-0x4] */
            ii(0x1012_1f3a, 4); movsx(edx, memw_a32[ss, ebp - 0x34]);   /* movsx edx, word [ebp-0x34] */
            ii(0x1012_1f3e, 3); mov(eax, memd_a32[ss, ebp - 0x3c]);     /* mov eax, [ebp-0x3c] */
            ii(0x1012_1f41, 5); calld(0x100d_7bdc, -0x4_a36a);          /* call 0x100d7bdc */
            ii(0x1012_1f46, 3); mov(memd_a32[ss, ebp - 0x44], eax);     /* mov [ebp-0x44], eax */
            ii(0x1012_1f49, 3); mov(eax, memd_a32[ss, ebp - 0x44]);     /* mov eax, [ebp-0x44] */
            ii(0x1012_1f4c, 3); mov(memd_a32[ss, ebp - 0x48], eax);     /* mov [ebp-0x48], eax */
            ii(0x1012_1f4f, 2); jmpd(0x1012_1f57, 0x6); goto l_0x1012_1f57; /* jmp 0x10121f57 */
        l_0x1012_1f51:
            ii(0x1012_1f51, 3); mov(eax, memd_a32[ss, ebp - 0x40]);     /* mov eax, [ebp-0x40] */
            ii(0x1012_1f54, 3); mov(memd_a32[ss, ebp - 0x48], eax);     /* mov [ebp-0x48], eax */
        l_0x1012_1f57:
            ii(0x1012_1f57, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x1012_1f5b, 3); imul(edx, edx, 0x1c);                   /* imul edx, edx, 0x1c */
            ii(0x1012_1f5e, 3); mov(eax, memd_a32[ss, ebp - 0x48]);     /* mov eax, [ebp-0x48] */
            ii(0x1012_1f61, 6); mov(memd_a32[ds, edx + 0x101b_b06c], eax); /* mov [edx+0x101bb06c], eax */
            ii(0x1012_1f67, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1012_1f6a, 3); add(edx, 0x17);                         /* add edx, 0x17 */
            ii(0x1012_1f6d, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1012_1f71, 3); imul(eax, eax, 0x1c);                   /* imul eax, eax, 0x1c */
            ii(0x1012_1f74, 6); mov(eax, memd_a32[ds, eax + 0x101b_b06c]); /* mov eax, [eax+0x101bb06c] */
            ii(0x1012_1f7a, 5); calld(0x100d_7d74, -0x4_a20b);          /* call 0x100d7d74 */
            ii(0x1012_1f7f, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1012_1f84, 1); pushd(eax);                             /* push eax */
            ii(0x1012_1f85, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1012_1f8a, 1); pushd(eax);                             /* push eax */
            ii(0x1012_1f8b, 5); pushd(0xa2);                            /* push 0xa2 */
            ii(0x1012_1f90, 5); mov(eax, 0x14);                         /* mov eax, 0x14 */
            ii(0x1012_1f95, 1); pushd(eax);                             /* push eax */
            ii(0x1012_1f96, 4); movsx(eax, memw_a32[ss, ebp - 0x30]);   /* movsx eax, word [ebp-0x30] */
            ii(0x1012_1f9a, 1); pushd(eax);                             /* push eax */
            ii(0x1012_1f9b, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1012_1f9f, 1); pushd(eax);                             /* push eax */
            ii(0x1012_1fa0, 4); movsx(ecx, memw_a32[ss, ebp - 0x34]);   /* movsx ecx, word [ebp-0x34] */
            ii(0x1012_1fa4, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1012_1fa8, 3); imul(eax, eax, 0x1c);                   /* imul eax, eax, 0x1c */
            ii(0x1012_1fab, 6); mov(ebx, memd_a32[ds, eax + 0x101b_b070]); /* mov ebx, [eax+0x101bb070] */
            ii(0x1012_1fb1, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1012_1fb4, 3); mov(edx, memd_a32[ds, eax + 0x25]);     /* mov edx, [eax+0x25] */
            ii(0x1012_1fb7, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1012_1fba, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1012_1fbd, 3); mov(eax, memd_a32[ds, eax + 0x2d]);     /* mov eax, [eax+0x2d] */
            ii(0x1012_1fc0, 5); calld(0x100e_9ae5, -0x3_84e0);          /* call 0x100e9ae5 */
            ii(0x1012_1fc5, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x1012_1fca, 5); calld(Definitions.sys_new, 0x4_3e31);   /* call 0x10165e00 */
            ii(0x1012_1fcf, 3); mov(memd_a32[ss, ebp - 0x4c], eax);     /* mov [ebp-0x4c], eax */
            ii(0x1012_1fd2, 3); mov(eax, memd_a32[ss, ebp - 0x4c]);     /* mov eax, [ebp-0x4c] */
            ii(0x1012_1fd5, 3); mov(memd_a32[ss, ebp - 0x50], eax);     /* mov [ebp-0x50], eax */
            ii(0x1012_1fd8, 4); cmp(memd_a32[ss, ebp - 0x50], 0);       /* cmp dword [ebp-0x50], 0x0 */
            ii(0x1012_1fdc, 2); if(jzd(0x1012_2003, 0x25)) goto l_0x1012_2003; /* jz 0x10122003 */
            ii(0x1012_1fde, 5); mov(eax, 0x14);                         /* mov eax, 0x14 */
            ii(0x1012_1fe3, 1); pushd(eax);                             /* push eax */
            ii(0x1012_1fe4, 4); movsx(ecx, memw_a32[ss, ebp - 0x30]);   /* movsx ecx, word [ebp-0x30] */
            ii(0x1012_1fe8, 4); movsx(ebx, memw_a32[ss, ebp - 0x4]);    /* movsx ebx, word [ebp-0x4] */
            ii(0x1012_1fec, 4); movsx(edx, memw_a32[ss, ebp - 0x34]);   /* movsx edx, word [ebp-0x34] */
            ii(0x1012_1ff0, 3); mov(eax, memd_a32[ss, ebp - 0x4c]);     /* mov eax, [ebp-0x4c] */
            ii(0x1012_1ff3, 5); calld(0x100c_e39d, -0x5_3c5b);          /* call 0x100ce39d */
            ii(0x1012_1ff8, 3); mov(memd_a32[ss, ebp - 0x54], eax);     /* mov [ebp-0x54], eax */
            ii(0x1012_1ffb, 3); mov(eax, memd_a32[ss, ebp - 0x54]);     /* mov eax, [ebp-0x54] */
            ii(0x1012_1ffe, 3); mov(memd_a32[ss, ebp - 0x58], eax);     /* mov [ebp-0x58], eax */
            ii(0x1012_2001, 2); jmpd(0x1012_2009, 0x6); goto l_0x1012_2009; /* jmp 0x10122009 */
        l_0x1012_2003:
            ii(0x1012_2003, 3); mov(eax, memd_a32[ss, ebp - 0x50]);     /* mov eax, [ebp-0x50] */
            ii(0x1012_2006, 3); mov(memd_a32[ss, ebp - 0x58], eax);     /* mov [ebp-0x58], eax */
        l_0x1012_2009:
            ii(0x1012_2009, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x1012_200d, 3); imul(edx, edx, 0x1c);                   /* imul edx, edx, 0x1c */
            ii(0x1012_2010, 3); mov(eax, memd_a32[ss, ebp - 0x58]);     /* mov eax, [ebp-0x58] */
            ii(0x1012_2013, 6); mov(memd_a32[ds, edx + 0x101b_b068], eax); /* mov [edx+0x101bb068], eax */
            ii(0x1012_2019, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x1012_201d, 6); add(edx, 0x3ea);                        /* add edx, 0x3ea */
            ii(0x1012_2023, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1012_2027, 3); imul(eax, eax, 0x1c);                   /* imul eax, eax, 0x1c */
            ii(0x1012_202a, 6); mov(eax, memd_a32[ds, eax + 0x101b_b068]); /* mov eax, [eax+0x101bb068] */
            ii(0x1012_2030, 5); calld(0x100d_5164, -0x4_ced1);          /* call 0x100d5164 */
            ii(0x1012_2035, 5); mov(edx, 0x4dd);                        /* mov edx, 0x4dd */
            ii(0x1012_203a, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1012_203e, 3); imul(eax, eax, 0x1c);                   /* imul eax, eax, 0x1c */
            ii(0x1012_2041, 6); mov(eax, memd_a32[ds, eax + 0x101b_b068]); /* mov eax, [eax+0x101bb068] */
            ii(0x1012_2047, 5); calld(0x100d_50d4, -0x4_cf78);          /* call 0x100d50d4 */
            ii(0x1012_204c, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1012_204f, 3); mov(edx, memd_a32[ds, eax + 0x29]);     /* mov edx, [eax+0x29] */
            ii(0x1012_2052, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1012_2056, 3); imul(eax, eax, 0x1c);                   /* imul eax, eax, 0x1c */
            ii(0x1012_2059, 6); mov(eax, memd_a32[ds, eax + 0x101b_b068]); /* mov eax, [eax+0x101bb068] */
            ii(0x1012_205f, 5); calld(0x100c_f85c, -0x5_2808);          /* call 0x100cf85c */
            ii(0x1012_2064, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_2066, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_2067, 1); popd(edi);                              /* pop edi */
            ii(0x1012_2068, 1); popd(esi);                              /* pop esi */
            ii(0x1012_2069, 1); retd();                                 /* ret */
        }
    }
}
