using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("cfcd3d66-3af3-4c7b-9a86-c8a252cf4532")]
        public void Method_1013_eba7()
        {
            ii(0x1013_eba7, 5); pushd(0x100);                           /* push 0x100 */
            ii(0x1013_ebac, 5); calld(Definitions.sys_check_available_stack_size, 0x271a1); /* call 0x10165d52 */
            ii(0x1013_ebb1, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_ebb2, 1); pushd(esi);                             /* push esi */
            ii(0x1013_ebb3, 1); pushd(edi);                             /* push edi */
            ii(0x1013_ebb4, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_ebb5, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_ebb7, 6); sub(esp, 0xec);                         /* sub esp, 0xec */
            ii(0x1013_ebbd, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1013_ebc0, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1013_ebc3, 3); mov(memb_a32[ss, ebp - 0x4], bl);       /* mov [ebp-0x4], bl */
            ii(0x1013_ebc6, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1013_ebca, 5); calld(Definitions.my_get_res_data_by_id_malloc, -0xa9e4); /* call 0x101341eb */
            ii(0x1013_ebcf, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1013_ebd2, 4); cmp(memd_a32[ss, ebp - 0x10], 0);       /* cmp dword [ebp-0x10], 0x0 */
            ii(0x1013_ebd6, 2); if(jnzd(0x1013_ebe1, 0x9)) goto l_0x1013_ebe1; /* jnz 0x1013ebe1 */
            ii(0x1013_ebd8, 4); mov(memb_a32[ss, ebp - 0x14], 0x6);     /* mov byte [ebp-0x14], 0x6 */
            ii(0x1013_ebdc, 5); jmpd(0x1013_f08b, 0x4aa); goto l_0x1013_f08b; /* jmp 0x1013f08b */
        l_0x1013_ebe1:
            ii(0x1013_ebe1, 4); mov(memb_a32[ss, ebp - 0x78], 0);       /* mov byte [ebp-0x78], 0x0 */
            ii(0x1013_ebe5, 4); cmp(memb_a32[ss, ebp - 0x4], 0x3);      /* cmp byte [ebp-0x4], 0x3 */
            ii(0x1013_ebe9, 2); if(jnzd(0x1013_ebfa, 0xf)) goto l_0x1013_ebfa; /* jnz 0x1013ebfa */
            ii(0x1013_ebeb, 5); mov(edx, 0x101c_3e38);                  /* mov edx, 0x101c3e38 */
            ii(0x1013_ebf0, 3); lea(eax, ebp - 0x78);                   /* lea eax, [ebp-0x78] */
            ii(0x1013_ebf3, 5); calld(Definitions.sys_strcpy, 0x272d7); /* call 0x10165ecf */
            ii(0x1013_ebf8, 2); jmpd(0x1013_ec1c, 0x22); goto l_0x1013_ec1c; /* jmp 0x1013ec1c */
        l_0x1013_ebfa:
            ii(0x1013_ebfa, 4); cmp(memb_a32[ss, ebp - 0x4], 0x4);      /* cmp byte [ebp-0x4], 0x4 */
            ii(0x1013_ebfe, 2); if(jnzd(0x1013_ec0f, 0xf)) goto l_0x1013_ec0f; /* jnz 0x1013ec0f */
            ii(0x1013_ec00, 5); mov(edx, 0x101c_402c);                  /* mov edx, 0x101c402c */
            ii(0x1013_ec05, 3); lea(eax, ebp - 0x78);                   /* lea eax, [ebp-0x78] */
            ii(0x1013_ec08, 5); calld(Definitions.sys_strcpy, 0x272c2); /* call 0x10165ecf */
            ii(0x1013_ec0d, 2); jmpd(0x1013_ec1c, 0xd); goto l_0x1013_ec1c; /* jmp 0x1013ec1c */
        l_0x1013_ec0f:
            ii(0x1013_ec0f, 5); mov(edx, 0x101c_3fc8);                  /* mov edx, 0x101c3fc8 */
            ii(0x1013_ec14, 3); lea(eax, ebp - 0x78);                   /* lea eax, [ebp-0x78] */
            ii(0x1013_ec17, 5); calld(Definitions.sys_strcpy, 0x272b3); /* call 0x10165ecf */
        l_0x1013_ec1c:
            ii(0x1013_ec1c, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1013_ec1f, 3); lea(eax, ebp - 0x78);                   /* lea eax, [ebp-0x78] */
            ii(0x1013_ec22, 5); calld(Definitions.sys_strcat, 0x2730a); /* call 0x10165f31 */
            ii(0x1013_ec27, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_ec2a, 5); calld(Definitions.sys_delete, 0x27335); /* call 0x10165f64 */
            ii(0x1013_ec2f, 5); mov(edx, StringDefinitions.Rb4);        /* mov edx, 0x101acd43 */
            ii(0x1013_ec34, 3); lea(eax, ebp - 0x78);                   /* lea eax, [ebp-0x78] */
            ii(0x1013_ec37, 5); calld(Definitions.my_fopen, -0x4f81d);  /* call 0x100ef41f */
            ii(0x1013_ec3c, 3); mov(memd_a32[ss, ebp - 0x7c], eax);     /* mov [ebp-0x7c], eax */
            ii(0x1013_ec3f, 4); cmp(memd_a32[ss, ebp - 0x7c], 0);       /* cmp dword [ebp-0x7c], 0x0 */
            ii(0x1013_ec43, 2); if(jnzd(0x1013_ec4e, 0x9)) goto l_0x1013_ec4e; /* jnz 0x1013ec4e */
            ii(0x1013_ec45, 4); mov(memb_a32[ss, ebp - 0x14], 0x6);     /* mov byte [ebp-0x14], 0x6 */
            ii(0x1013_ec49, 5); jmpd(0x1013_f08b, 0x43d); goto l_0x1013_f08b; /* jmp 0x1013f08b */
        l_0x1013_ec4e:
            ii(0x1013_ec4e, 3); mov(ecx, memd_a32[ss, ebp - 0x7c]);     /* mov ecx, [ebp-0x7c] */
            ii(0x1013_ec51, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1013_ec56, 5); mov(edx, 0x4);                          /* mov edx, 0x4 */
            ii(0x1013_ec5b, 6); lea(eax, ebp - 0xa0);                   /* lea eax, [ebp-0xa0] */
            ii(0x1013_ec61, 5); calld(Definitions.my_fread, -0x4f7d7);  /* call 0x100ef48f */
            ii(0x1013_ec66, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1013_ec68, 2); if(jnzd(0x1013_ec7b, 0x11)) goto l_0x1013_ec7b; /* jnz 0x1013ec7b */
            ii(0x1013_ec6a, 3); mov(eax, memd_a32[ss, ebp - 0x7c]);     /* mov eax, [ebp-0x7c] */
            ii(0x1013_ec6d, 5); calld(Definitions.sys_fclose, 0x333f7); /* call 0x10172069 */
            ii(0x1013_ec72, 4); mov(memb_a32[ss, ebp - 0x14], 0x4);     /* mov byte [ebp-0x14], 0x4 */
            ii(0x1013_ec76, 5); jmpd(0x1013_f08b, 0x410); goto l_0x1013_f08b; /* jmp 0x1013f08b */
        l_0x1013_ec7b:
            ii(0x1013_ec7b, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_ec7e, 10); mov(memd_a32[ds, eax + 0xdbd], 0x4300); /* mov dword [eax+0xdbd], 0x4300 */
            ii(0x1013_ec88, 5); mov(ebx, 0x4);                          /* mov ebx, 0x4 */
            ii(0x1013_ec8d, 5); mov(edx, StringDefinitions.Riff2);      /* mov edx, 0x101acd46 */
            ii(0x1013_ec92, 6); lea(eax, ebp - 0xa0);                   /* lea eax, [ebp-0xa0] */
            ii(0x1013_ec98, 5); calld(Definitions.sys_strncmp, 0x3a4bf); /* call 0x1017915c */
            ii(0x1013_ec9d, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1013_ec9f, 6); if(jnzd(0x1013_ed46, 0xa1)) goto l_0x1013_ed46; /* jnz 0x1013ed46 */
            ii(0x1013_eca5, 3); mov(ecx, memd_a32[ss, ebp - 0x7c]);     /* mov ecx, [ebp-0x7c] */
            ii(0x1013_eca8, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1013_ecad, 5); mov(edx, 0x20);                         /* mov edx, 0x20 */
            ii(0x1013_ecb2, 6); lea(eax, ebp - 0x9c);                   /* lea eax, [ebp-0x9c] */
            ii(0x1013_ecb8, 5); calld(Definitions.my_fread, -0x4f82e);  /* call 0x100ef48f */
            ii(0x1013_ecbd, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1013_ecbf, 2); if(jnzd(0x1013_ecd2, 0x11)) goto l_0x1013_ecd2; /* jnz 0x1013ecd2 */
            ii(0x1013_ecc1, 3); mov(eax, memd_a32[ss, ebp - 0x7c]);     /* mov eax, [ebp-0x7c] */
            ii(0x1013_ecc4, 5); calld(Definitions.sys_fclose, 0x333a0); /* call 0x10172069 */
            ii(0x1013_ecc9, 4); mov(memb_a32[ss, ebp - 0x14], 0x4);     /* mov byte [ebp-0x14], 0x4 */
            ii(0x1013_eccd, 5); jmpd(0x1013_f08b, 0x3b9); goto l_0x1013_f08b; /* jmp 0x1013f08b */
        l_0x1013_ecd2:
            ii(0x1013_ecd2, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1013_ecd7, 6); mov(edx, memd_a32[ss, ebp - 0x90]);     /* mov edx, [ebp-0x90] */
            ii(0x1013_ecdd, 3); sub(edx, 0xc);                          /* sub edx, 0xc */
            ii(0x1013_ece0, 3); mov(eax, memd_a32[ss, ebp - 0x7c]);     /* mov eax, [ebp-0x7c] */
            ii(0x1013_ece3, 5); calld(Definitions.my_fseek, -0x4f893);  /* call 0x100ef455 */
            ii(0x1013_ece8, 3); mov(ecx, memd_a32[ss, ebp - 0x7c]);     /* mov ecx, [ebp-0x7c] */
            ii(0x1013_eceb, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1013_ecf0, 5); mov(edx, 0x4);                          /* mov edx, 0x4 */
            ii(0x1013_ecf5, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_ecf8, 5); add(eax, 0xdb5);                        /* add eax, 0xdb5 */
            ii(0x1013_ecfd, 5); calld(Definitions.my_fread, -0x4f873);  /* call 0x100ef48f */
            ii(0x1013_ed02, 4); movsx(eax, memw_a32[ss, ebp - 0x7e]);   /* movsx eax, word [ebp-0x7e] */
            ii(0x1013_ed06, 3); cmp(eax, 0x10);                         /* cmp eax, 0x10 */
            ii(0x1013_ed09, 2); if(jnzd(0x1013_ed17, 0xc)) goto l_0x1013_ed17; /* jnz 0x1013ed17 */
            ii(0x1013_ed0b, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_ed0e, 7); or(memb_a32[ds, eax + 0xdbd], -0x80 /* 0x80 */); /* or byte [eax+0xdbd], 0x80 */
            ii(0x1013_ed15, 2); jmpd(0x1013_ed21, 0xa); goto l_0x1013_ed21; /* jmp 0x1013ed21 */
        l_0x1013_ed17:
            ii(0x1013_ed17, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_ed1a, 7); or(memb_a32[ds, eax + 0xdbd], 0x20);    /* or byte [eax+0xdbd], 0x20 */
        l_0x1013_ed21:
            ii(0x1013_ed21, 7); movsx(eax, memw_a32[ss, ebp - 0x8a]);   /* movsx eax, word [ebp-0x8a] */
            ii(0x1013_ed28, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x1013_ed2b, 2); if(jnzd(0x1013_ed41, 0x14)) goto l_0x1013_ed41; /* jnz 0x1013ed41 */
            ii(0x1013_ed2d, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_ed30, 7); or(memb_a32[ds, eax + 0xdbd], 0x10);    /* or byte [eax+0xdbd], 0x10 */
            ii(0x1013_ed37, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_ed3a, 7); and(memb_a32[ds, eax + 0xdbe], -0x3 /* 0xfd */); /* and byte [eax+0xdbe], 0xfd */
        l_0x1013_ed41:
            ii(0x1013_ed41, 5); jmpd(0x1013_ee55, 0x10f); goto l_0x1013_ee55; /* jmp 0x1013ee55 */
        l_0x1013_ed46:
            ii(0x1013_ed46, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1013_ed4b, 5); mov(edx, 0xffff_fffc);                  /* mov edx, 0xfffffffc */
            ii(0x1013_ed50, 3); mov(eax, memd_a32[ss, ebp - 0x7c]);     /* mov eax, [ebp-0x7c] */
            ii(0x1013_ed53, 5); calld(Definitions.my_fseek, -0x4f903);  /* call 0x100ef455 */
            ii(0x1013_ed58, 3); mov(ecx, memd_a32[ss, ebp - 0x7c]);     /* mov ecx, [ebp-0x7c] */
            ii(0x1013_ed5b, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1013_ed60, 5); mov(edx, 0x1a);                         /* mov edx, 0x1a */
            ii(0x1013_ed65, 5); mov(eax, 0x101c_804c);                  /* mov eax, 0x101c804c */
            ii(0x1013_ed6a, 5); calld(Definitions.my_fread, -0x4f8e0);  /* call 0x100ef48f */
            ii(0x1013_ed6f, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1013_ed71, 2); if(jnzd(0x1013_ed84, 0x11)) goto l_0x1013_ed84; /* jnz 0x1013ed84 */
            ii(0x1013_ed73, 3); mov(eax, memd_a32[ss, ebp - 0x7c]);     /* mov eax, [ebp-0x7c] */
            ii(0x1013_ed76, 5); calld(Definitions.sys_fclose, 0x332ee); /* call 0x10172069 */
            ii(0x1013_ed7b, 4); mov(memb_a32[ss, ebp - 0x14], 0x4);     /* mov byte [ebp-0x14], 0x4 */
            ii(0x1013_ed7f, 5); jmpd(0x1013_f08b, 0x307); goto l_0x1013_f08b; /* jmp 0x1013f08b */
        l_0x1013_ed84:
            ii(0x1013_ed84, 3); mov(ecx, memd_a32[ss, ebp - 0x7c]);     /* mov ecx, [ebp-0x7c] */
            ii(0x1013_ed87, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1013_ed8c, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1013_ed91, 6); lea(eax, ebp - 0xa4);                   /* lea eax, [ebp-0xa4] */
            ii(0x1013_ed97, 5); calld(Definitions.my_fread, -0x4f90d);  /* call 0x100ef48f */
            ii(0x1013_ed9c, 6); mov(memd_a32[ss, ebp - 0xa8], eax);     /* mov [ebp-0xa8], eax */
            ii(0x1013_eda2, 7); cmp(memd_a32[ss, ebp - 0xa8], 0);       /* cmp dword [ebp-0xa8], 0x0 */
            ii(0x1013_eda9, 2); if(jzd(0x1013_edb8, 0xd)) goto l_0x1013_edb8; /* jz 0x1013edb8 */
            ii(0x1013_edab, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_edad, 6); mov(al, memb_a32[ss, ebp - 0xa4]);      /* mov al, [ebp-0xa4] */
            ii(0x1013_edb3, 3); cmp(eax, 0x9);                          /* cmp eax, 0x9 */
            ii(0x1013_edb6, 2); if(jzd(0x1013_edc9, 0x11)) goto l_0x1013_edc9; /* jz 0x1013edc9 */
        l_0x1013_edb8:
            ii(0x1013_edb8, 3); mov(eax, memd_a32[ss, ebp - 0x7c]);     /* mov eax, [ebp-0x7c] */
            ii(0x1013_edbb, 5); calld(Definitions.sys_fclose, 0x332a9); /* call 0x10172069 */
            ii(0x1013_edc0, 4); mov(memb_a32[ss, ebp - 0x14], 0xa);     /* mov byte [ebp-0x14], 0xa */
            ii(0x1013_edc4, 5); jmpd(0x1013_f08b, 0x2c2); goto l_0x1013_f08b; /* jmp 0x1013f08b */
        l_0x1013_edc9:
            ii(0x1013_edc9, 3); mov(ecx, memd_a32[ss, ebp - 0x7c]);     /* mov ecx, [ebp-0x7c] */
            ii(0x1013_edcc, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1013_edd1, 5); mov(edx, 0x3);                          /* mov edx, 0x3 */
            ii(0x1013_edd6, 5); mov(eax, 0x101c_8068);                  /* mov eax, 0x101c8068 */
            ii(0x1013_eddb, 5); calld(Definitions.my_fread, -0x4f951);  /* call 0x100ef48f */
            ii(0x1013_ede0, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1013_ede2, 2); if(jnzd(0x1013_edf5, 0x11)) goto l_0x1013_edf5; /* jnz 0x1013edf5 */
            ii(0x1013_ede4, 3); mov(eax, memd_a32[ss, ebp - 0x7c]);     /* mov eax, [ebp-0x7c] */
            ii(0x1013_ede7, 5); calld(Definitions.sys_fclose, 0x3327d); /* call 0x10172069 */
            ii(0x1013_edec, 4); mov(memb_a32[ss, ebp - 0x14], 0x9);     /* mov byte [ebp-0x14], 0x9 */
            ii(0x1013_edf0, 5); jmpd(0x1013_f08b, 0x296); goto l_0x1013_f08b; /* jmp 0x1013f08b */
        l_0x1013_edf5:
            ii(0x1013_edf5, 3); mov(ecx, memd_a32[ss, ebp - 0x7c]);     /* mov ecx, [ebp-0x7c] */
            ii(0x1013_edf8, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1013_edfd, 5); mov(edx, 0xc);                          /* mov edx, 0xc */
            ii(0x1013_ee02, 5); mov(eax, 0x101c_806c);                  /* mov eax, 0x101c806c */
            ii(0x1013_ee07, 5); calld(Definitions.my_fread, -0x4f97d);  /* call 0x100ef48f */
            ii(0x1013_ee0c, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1013_ee0e, 2); if(jnzd(0x1013_ee21, 0x11)) goto l_0x1013_ee21; /* jnz 0x1013ee21 */
            ii(0x1013_ee10, 3); mov(eax, memd_a32[ss, ebp - 0x7c]);     /* mov eax, [ebp-0x7c] */
            ii(0x1013_ee13, 5); calld(Definitions.sys_fclose, 0x33251); /* call 0x10172069 */
            ii(0x1013_ee18, 4); mov(memb_a32[ss, ebp - 0x14], 0x7);     /* mov byte [ebp-0x14], 0x7 */
            ii(0x1013_ee1c, 5); jmpd(0x1013_f08b, 0x26a); goto l_0x1013_f08b; /* jmp 0x1013f08b */
        l_0x1013_ee21:
            ii(0x1013_ee21, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_ee23, 5); mov(al, memb_a32[ds, 0x101c_806a]);     /* mov al, [0x101c806a] */
            ii(0x1013_ee28, 3); shl(eax, 0x10);                         /* shl eax, 0x10 */
            ii(0x1013_ee2b, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1013_ee2d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_ee2f, 7); mov(dx, memw_a32[ds, 0x101c_8068]);     /* mov dx, [0x101c8068] */
            ii(0x1013_ee36, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_ee39, 2); add(ebx, edx);                          /* add ebx, edx */
            ii(0x1013_ee3b, 6); mov(memd_a32[ds, eax + 0xdb5], ebx);    /* mov [eax+0xdb5], ebx */
            ii(0x1013_ee41, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_ee44, 7); sub(memd_a32[ds, eax + 0xdb5], 0xc);    /* sub dword [eax+0xdb5], 0xc */
            ii(0x1013_ee4b, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_ee4e, 7); or(memb_a32[ds, eax + 0xdbd], -0x80 /* 0x80 */); /* or byte [eax+0xdbd], 0x80 */
        l_0x1013_ee55:
            ii(0x1013_ee55, 4); cmp(memb_a32[ss, ebp - 0x4], 0x4);      /* cmp byte [ebp-0x4], 0x4 */
            ii(0x1013_ee59, 2); if(jnzd(0x1013_ee8d, 0x32)) goto l_0x1013_ee8d; /* jnz 0x1013ee8d */
            ii(0x1013_ee5b, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_ee5e, 6); mov(edx, memd_a32[ds, eax + 0xdb5]);    /* mov edx, [eax+0xdb5] */
            ii(0x1013_ee64, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_ee67, 6); mov(memd_a32[ds, eax + 0xdca], edx);    /* mov [eax+0xdca], edx */
            ii(0x1013_ee6d, 3); mov(eax, memd_a32[ss, ebp - 0x7c]);     /* mov eax, [ebp-0x7c] */
            ii(0x1013_ee70, 5); calld(Definitions.sys_ftell, 0x338d2);  /* call 0x10172747 */
            ii(0x1013_ee75, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1013_ee77, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_ee7a, 6); mov(memd_a32[ds, eax + 0xdc5], edx);    /* mov [eax+0xdc5], edx */
            ii(0x1013_ee80, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_ee83, 10); mov(memd_a32[ds, eax + 0xdb5], 0x3_de00); /* mov dword [eax+0xdb5], 0x3de00 */
        l_0x1013_ee8d:
            ii(0x1013_ee8d, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_ee90, 6); mov(eax, memd_a32[ds, eax + 0xdb5]);    /* mov eax, [eax+0xdb5] */
            ii(0x1013_ee96, 5); calld(Definitions.sys_new_arr, 0x27175); /* call 0x10166010 */
            ii(0x1013_ee9b, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1013_ee9d, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_eea0, 6); mov(memd_a32[ds, eax + 0xdb1], edx);    /* mov [eax+0xdb1], edx */
            ii(0x1013_eea6, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_eea9, 7); cmp(memd_a32[ds, eax + 0xdb1], 0);      /* cmp dword [eax+0xdb1], 0x0 */
            ii(0x1013_eeb0, 2); if(jnzd(0x1013_eec3, 0x11)) goto l_0x1013_eec3; /* jnz 0x1013eec3 */
            ii(0x1013_eeb2, 3); mov(eax, memd_a32[ss, ebp - 0x7c]);     /* mov eax, [ebp-0x7c] */
            ii(0x1013_eeb5, 5); calld(Definitions.sys_fclose, 0x331af); /* call 0x10172069 */
            ii(0x1013_eeba, 4); mov(memb_a32[ss, ebp - 0x14], 0x3);     /* mov byte [ebp-0x14], 0x3 */
            ii(0x1013_eebe, 5); jmpd(0x1013_f08b, 0x1c8); goto l_0x1013_f08b; /* jmp 0x1013f08b */
        l_0x1013_eec3:
            ii(0x1013_eec3, 3); mov(ecx, memd_a32[ss, ebp - 0x7c]);     /* mov ecx, [ebp-0x7c] */
            ii(0x1013_eec6, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_eec9, 6); mov(ebx, memd_a32[ds, eax + 0xdb5]);    /* mov ebx, [eax+0xdb5] */
            ii(0x1013_eecf, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1013_eed4, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_eed7, 6); mov(eax, memd_a32[ds, eax + 0xdb1]);    /* mov eax, [eax+0xdb1] */
            ii(0x1013_eedd, 5); calld(Definitions.my_fread, -0x4fa53);  /* call 0x100ef48f */
            ii(0x1013_eee2, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1013_eee4, 2); if(jnzd(0x1013_ef05, 0x1f)) goto l_0x1013_ef05; /* jnz 0x1013ef05 */
            ii(0x1013_eee6, 3); mov(eax, memd_a32[ss, ebp - 0x7c]);     /* mov eax, [ebp-0x7c] */
            ii(0x1013_eee9, 5); calld(Definitions.sys_fclose, 0x3317b); /* call 0x10172069 */
            ii(0x1013_eeee, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_eef1, 6); mov(eax, memd_a32[ds, eax + 0xdb1]);    /* mov eax, [eax+0xdb1] */
            ii(0x1013_eef7, 5); calld(Definitions.sys_delete, 0x27068); /* call 0x10165f64 */
            ii(0x1013_eefc, 4); mov(memb_a32[ss, ebp - 0x14], 0x2);     /* mov byte [ebp-0x14], 0x2 */
            ii(0x1013_ef00, 5); jmpd(0x1013_f08b, 0x186); goto l_0x1013_f08b; /* jmp 0x1013f08b */
        l_0x1013_ef05:
            ii(0x1013_ef05, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_ef08, 10); mov(memd_a32[ds, eax + 0xdb9], 0);     /* mov dword [eax+0xdb9], 0x0 */
            ii(0x1013_ef12, 4); cmp(memb_a32[ss, ebp - 0x4], 0x4);      /* cmp byte [ebp-0x4], 0x4 */
            ii(0x1013_ef16, 6); if(jnzd(0x1013_f025, 0x109)) goto l_0x1013_f025; /* jnz 0x1013f025 */
            ii(0x1013_ef1c, 3); mov(eax, memd_a32[ss, ebp - 0x7c]);     /* mov eax, [ebp-0x7c] */
            ii(0x1013_ef1f, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1013_ef22, 3); mov(memd_a32[ds, edx + 0x8], eax);      /* mov [edx+0x8], eax */
            ii(0x1013_ef25, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_ef28, 6); mov(edx, memd_a32[ds, eax + 0xdb5]);    /* mov edx, [eax+0xdb5] */
            ii(0x1013_ef2e, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_ef31, 6); cmp(edx, memd_a32[ds, eax + 0xdca]);    /* cmp edx, [eax+0xdca] */
            ii(0x1013_ef37, 2); if(jled(0x1013_ef7a, 0x41)) goto l_0x1013_ef7a; /* jle 0x1013ef7a */
            ii(0x1013_ef39, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_ef3c, 6); mov(eax, memd_a32[ds, eax + 0xdb5]);    /* mov eax, [eax+0xdb5] */
            ii(0x1013_ef42, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1013_ef45, 6); sub(eax, memd_a32[ds, edx + 0xdca]);    /* sub eax, [edx+0xdca] */
            ii(0x1013_ef4b, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1013_ef4d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_ef4f, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_ef52, 6); mov(ecx, memd_a32[ds, eax + 0xdb1]);    /* mov ecx, [eax+0xdb1] */
            ii(0x1013_ef58, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_ef5b, 6); mov(eax, memd_a32[ds, eax + 0xdca]);    /* mov eax, [eax+0xdca] */
            ii(0x1013_ef61, 2); add(eax, ecx);                          /* add eax, ecx */
            ii(0x1013_ef63, 5); calld(Definitions.sys_memset, 0x26e78); /* call 0x10165de0 */
            ii(0x1013_ef68, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_ef6b, 6); mov(edx, memd_a32[ds, eax + 0xdca]);    /* mov edx, [eax+0xdca] */
            ii(0x1013_ef71, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_ef74, 6); mov(memd_a32[ds, eax + 0xdb5], edx);    /* mov [eax+0xdb5], edx */
        l_0x1013_ef7a:
            ii(0x1013_ef7a, 5); mov(ebx, 0x9);                          /* mov ebx, 0x9 */
            ii(0x1013_ef7f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_ef81, 5); mov(eax, 0x101c_8078);                  /* mov eax, 0x101c8078 */
            ii(0x1013_ef86, 5); calld(Definitions.sys_memset, 0x26e55); /* call 0x10165de0 */
            ii(0x1013_ef8b, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_ef8e, 6); mov(eax, memd_a32[ds, eax + 0xdca]);    /* mov eax, [eax+0xdca] */
            ii(0x1013_ef94, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1013_ef97, 6); sub(eax, memd_a32[ds, edx + 0xdb5]);    /* sub eax, [edx+0xdb5] */
            ii(0x1013_ef9d, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1013_efa0, 6); mov(memd_a32[ds, edx + 0xdce], eax);    /* mov [edx+0xdce], eax */
            ii(0x1013_efa6, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_efa9, 6); mov(edx, memd_a32[ds, eax + 0xdb1]);    /* mov edx, [eax+0xdb1] */
            ii(0x1013_efaf, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_efb2, 3); mov(memd_a32[ds, eax + 0x12], edx);     /* mov [eax+0x12], edx */
            ii(0x1013_efb5, 7); mov(memb_a32[ds, 0x101c_8082], 0);      /* mov byte [0x101c8082], 0x0 */
            ii(0x1013_efbc, 7); mov(memb_a32[ds, 0x101c_8081], 0);      /* mov byte [0x101c8081], 0x0 */
        l_0x1013_efc3:
            ii(0x1013_efc3, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_efc6, 7); cmp(memd_a32[ds, eax + 0xdb5], 0);      /* cmp dword [eax+0xdb5], 0x0 */
            ii(0x1013_efcd, 2); if(jled(0x1013_efdb, 0xc)) goto l_0x1013_efdb; /* jle 0x1013efdb */
            ii(0x1013_efcf, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_efd1, 5); mov(al, memb_a32[ds, 0x101c_8081]);     /* mov al, [0x101c8081] */
            ii(0x1013_efd6, 3); cmp(eax, 0x9);                          /* cmp eax, 0x9 */
            ii(0x1013_efd9, 2); if(jnzd(0x1013_efdd, 0x2)) goto l_0x1013_efdd; /* jnz 0x1013efdd */
        l_0x1013_efdb:
            ii(0x1013_efdb, 2); jmpd(0x1013_f003, 0x26); goto l_0x1013_f003; /* jmp 0x1013f003 */
        l_0x1013_efdd:
            ii(0x1013_efdd, 5); mov(al, memb_a32[ds, 0x101c_8081]);     /* mov al, [0x101c8081] */
            ii(0x1013_efe2, 6); inc(memb_a32[ds, 0x101c_8081]);         /* inc byte [0x101c8081] */
            ii(0x1013_efe8, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1013_efed, 7); mov(memb_a32[ds, eax + 0x101c_8078], 0x1); /* mov byte [eax+0x101c8078], 0x1 */
            ii(0x1013_eff4, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_eff7, 10); sub(memd_a32[ds, eax + 0xdb5], 0x6e00); /* sub dword [eax+0xdb5], 0x6e00 */
            ii(0x1013_f001, 2); jmpd(0x1013_efc3, -0x40); goto l_0x1013_efc3; /* jmp 0x1013efc3 */
        l_0x1013_f003:
            ii(0x1013_f003, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_f005, 5); mov(al, memb_a32[ds, 0x101c_8081]);     /* mov al, [0x101c8081] */
            ii(0x1013_f00a, 3); cmp(eax, 0x9);                          /* cmp eax, 0x9 */
            ii(0x1013_f00d, 2); if(jnzd(0x1013_f016, 0x7)) goto l_0x1013_f016; /* jnz 0x1013f016 */
            ii(0x1013_f00f, 7); mov(memb_a32[ds, 0x101c_8081], 0);      /* mov byte [0x101c8081], 0x0 */
        l_0x1013_f016:
            ii(0x1013_f016, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_f019, 10); mov(memd_a32[ds, eax + 0xdb5], 0x6e00); /* mov dword [eax+0xdb5], 0x6e00 */
            ii(0x1013_f023, 2); jmpd(0x1013_f087, 0x62); goto l_0x1013_f087; /* jmp 0x1013f087 */
        l_0x1013_f025:
            ii(0x1013_f025, 3); mov(ecx, memd_a32[ss, ebp - 0x7c]);     /* mov ecx, [ebp-0x7c] */
            ii(0x1013_f028, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1013_f02d, 5); mov(edx, 0x44);                         /* mov edx, 0x44 */
            ii(0x1013_f032, 6); lea(eax, ebp - 0xec);                   /* lea eax, [ebp-0xec] */
            ii(0x1013_f038, 5); calld(Definitions.sys_fread, 0x3352f);  /* call 0x1017256c */
            ii(0x1013_f03d, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1013_f03f, 2); if(jzd(0x1013_f07f, 0x3e)) goto l_0x1013_f07f; /* jz 0x1013f07f */
            ii(0x1013_f041, 5); mov(ebx, 0x4);                          /* mov ebx, 0x4 */
            ii(0x1013_f046, 5); mov(edx, StringDefinitions.Smpl);       /* mov edx, 0x101acd4b */
            ii(0x1013_f04b, 6); lea(eax, ebp - 0xec);                   /* lea eax, [ebp-0xec] */
            ii(0x1013_f051, 5); calld(Definitions.sys_strncmp, 0x3a106); /* call 0x1017915c */
            ii(0x1013_f056, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1013_f058, 2); if(jnzd(0x1013_f07f, 0x25)) goto l_0x1013_f07f; /* jnz 0x1013f07f */
            ii(0x1013_f05a, 6); mov(eax, memd_a32[ss, ebp - 0xb8]);     /* mov eax, [ebp-0xb8] */
            ii(0x1013_f060, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1013_f062, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1013_f065, 6); mov(memd_a32[ds, edx + 0xdb9], eax);    /* mov [edx+0xdb9], eax */
            ii(0x1013_f06b, 6); mov(edx, memd_a32[ss, ebp - 0xb4]);     /* mov edx, [ebp-0xb4] */
            ii(0x1013_f071, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x1013_f073, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_f076, 3); add(edx, 0x2);                          /* add edx, 0x2 */
            ii(0x1013_f079, 6); mov(memd_a32[ds, eax + 0xdb5], edx);    /* mov [eax+0xdb5], edx */
        l_0x1013_f07f:
            ii(0x1013_f07f, 3); mov(eax, memd_a32[ss, ebp - 0x7c]);     /* mov eax, [ebp-0x7c] */
            ii(0x1013_f082, 5); calld(Definitions.sys_fclose, 0x32fe2); /* call 0x10172069 */
        l_0x1013_f087:
            ii(0x1013_f087, 4); mov(memb_a32[ss, ebp - 0x14], 0);       /* mov byte [ebp-0x14], 0x0 */
        l_0x1013_f08b:
            ii(0x1013_f08b, 3); mov(al, memb_a32[ss, ebp - 0x14]);      /* mov al, [ebp-0x14] */
            ii(0x1013_f08e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_f090, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_f091, 1); popd(edi);                              /* pop edi */
            ii(0x1013_f092, 1); popd(esi);                              /* pop esi */
            ii(0x1013_f093, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_f094, 1); retd(); return;                         /* ret */
        }
    }
}
