using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("6933845f-20e4-4a77-8991-12267cc34237")]
        public void Method_100c_cf62()
        {
            ii(0x100c_cf62, 5); pushd(0x60);                            /* push 0x60 */
            ii(0x100c_cf67, 5); calld(Definitions.sys_check_available_stack_size, 0x9_8de6); /* call 0x10165d52 */
            ii(0x100c_cf6c, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_cf6d, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_cf6e, 1); pushd(edx);                             /* push edx */
            ii(0x100c_cf6f, 1); pushd(esi);                             /* push esi */
            ii(0x100c_cf70, 1); pushd(edi);                             /* push edi */
            ii(0x100c_cf71, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_cf72, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_cf74, 6); sub(esp, 0x40);                         /* sub esp, 0x40 */
            ii(0x100c_cf7a, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100c_cf7d, 5); mov(eax, 0x101c_8184);                  /* mov eax, 0x101c8184 */
            ii(0x100c_cf82, 5); calld(0x1007_6338, -0x5_6c4f);          /* call 0x10076338 */
            ii(0x100c_cf87, 3); lea(ebx, ebp - 0x18);                   /* lea ebx, [ebp-0x18] */
            ii(0x100c_cf8a, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_cf8c, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100c_cf8e, 5); calld(0x1007_64b8, -0x5_6adb);          /* call 0x100764b8 */
            ii(0x100c_cf93, 7); mov(memd_a32[ss, ebp - 0x14], 0);       /* mov dword [ebp-0x14], 0x0 */
            ii(0x100c_cf9a, 7); mov(memd_a32[ss, ebp - 0xc], 0xffff_ffff); /* mov dword [ebp-0xc], 0xffffffff */
            ii(0x100c_cfa1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_cfa4, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100c_cfa7, 5); calld(0x1007_6574, -0x5_6a38);          /* call 0x10076574 */
            ii(0x100c_cfac, 4); test(memb_a32[ds, eax + 0x12], 0x40);   /* test byte [eax+0x12], 0x40 */
            ii(0x100c_cfb0, 2); if(jzd(0x100c_cfc1, 0xf)) goto l_0x100c_cfc1; /* jz 0x100ccfc1 */
            ii(0x100c_cfb2, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_cfb4, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_cfb7, 5); calld(0x1007_5f6c, -0x5_7050);          /* call 0x10075f6c */
            ii(0x100c_cfbc, 5); jmpd(0x100c_d24b, 0x28a); goto l_0x100c_d24b; /* jmp 0x100cd24b */
        l_0x100c_cfc1:
            ii(0x100c_cfc1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_cfc4, 5); calld(0x100c_bb8b, -0x143e);            /* call 0x100cbb8b */
            ii(0x100c_cfc9, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_cfcc, 5); cmp(memw_a32[ss, ebp - 0x8], 0xb);      /* cmp word [ebp-0x8], 0xb */
            ii(0x100c_cfd1, 2); if(jnzd(0x100c_cfdf, 0xc)) goto l_0x100c_cfdf; /* jnz 0x100ccfdf */
            ii(0x100c_cfd3, 7); mov(memd_a32[ss, ebp - 0xc], 0x4b);     /* mov dword [ebp-0xc], 0x4b */
            ii(0x100c_cfda, 5); jmpd(0x100c_d10e, 0x12f); goto l_0x100c_d10e; /* jmp 0x100cd10e */
        l_0x100c_cfdf:
            ii(0x100c_cfdf, 5); cmp(memw_a32[ss, ebp - 0x8], 0x9);      /* cmp word [ebp-0x8], 0x9 */
            ii(0x100c_cfe4, 2); if(jnzd(0x100c_cff2, 0xc)) goto l_0x100c_cff2; /* jnz 0x100ccff2 */
            ii(0x100c_cfe6, 7); mov(memd_a32[ss, ebp - 0xc], 0x3b);     /* mov dword [ebp-0xc], 0x3b */
            ii(0x100c_cfed, 5); jmpd(0x100c_d10e, 0x11c); goto l_0x100c_d10e; /* jmp 0x100cd10e */
        l_0x100c_cff2:
            ii(0x100c_cff2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_cff5, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100c_cff8, 5); calld(0x1007_6574, -0x5_6a89);          /* call 0x10076574 */
            ii(0x100c_cffd, 4); mov(ax, memw_a32[ds, eax + 0x1c]);      /* mov ax, [eax+0x1c] */
            ii(0x100c_d001, 1); inc(eax);                               /* inc eax */
            ii(0x100c_d002, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x100c_d005, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_d008, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100c_d00b, 5); calld(0x1007_6574, -0x5_6a9c);          /* call 0x10076574 */
            ii(0x100c_d010, 4); mov(ax, memw_a32[ds, eax + 0x1a]);      /* mov ax, [eax+0x1a] */
            ii(0x100c_d014, 1); dec(eax);                               /* dec eax */
            ii(0x100c_d015, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100c_d018, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100c_d01b, 5); calld(0x1007_6aac, -0x5_6574);          /* call 0x10076aac */
            ii(0x100c_d020, 5); mov(eax, memd_a32[ds, 0x101c_8172]);    /* mov eax, [0x101c8172] */
            ii(0x100c_d025, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_d028, 1); pushd(eax);                             /* push eax */
            ii(0x100c_d029, 6); mov(ecx, memd_a32[ds, 0x101c_8170]);    /* mov ecx, [0x101c8170] */
            ii(0x100c_d02f, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100c_d032, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_d034, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_d036, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x100c_d039, 5); calld(0x1008_b148, -0x4_1ef6);          /* call 0x1008b148 */
            ii(0x100c_d03e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_d041, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100c_d044, 5); calld(0x1007_6574, -0x5_6ad5);          /* call 0x10076574 */
            ii(0x100c_d049, 4); test(memb_a32[ds, eax + 0x12], 0x10);   /* test byte [eax+0x12], 0x10 */
            ii(0x100c_d04d, 2); if(jzd(0x100c_d058, 0x9)) goto l_0x100c_d058; /* jz 0x100cd058 */
            ii(0x100c_d04f, 7); mov(memd_a32[ss, ebp - 0x30], 0x3);     /* mov dword [ebp-0x30], 0x3 */
            ii(0x100c_d056, 2); jmpd(0x100c_d05f, 0x7); goto l_0x100c_d05f; /* jmp 0x100cd05f */
        l_0x100c_d058:
            ii(0x100c_d058, 7); mov(memd_a32[ss, ebp - 0x30], 0x2);     /* mov dword [ebp-0x30], 0x2 */
        l_0x100c_d05f:
            ii(0x100c_d05f, 7); mov(memd_a32[ss, ebp - 0x34], 0);       /* mov dword [ebp-0x34], 0x0 */
            ii(0x100c_d066, 2); jmpd(0x100c_d06c, 0x4); goto l_0x100c_d06c; /* jmp 0x100cd06c */
        l_0x100c_d068:
            ii(0x100c_d068, 4); add(memd_a32[ss, ebp - 0x34], 0x2);     /* add dword [ebp-0x34], 0x2 */
        l_0x100c_d06c:
            ii(0x100c_d06c, 4); movsx(eax, memw_a32[ss, ebp - 0x34]);   /* movsx eax, word [ebp-0x34] */
            ii(0x100c_d070, 3); cmp(eax, 0x8);                          /* cmp eax, 0x8 */
            ii(0x100c_d073, 6); if(jged(0x100c_d0f8, 0x7f)) goto l_0x100c_d0f8; /* jge 0x100cd0f8 */
            ii(0x100c_d079, 7); mov(memd_a32[ss, ebp - 0x38], 0);       /* mov dword [ebp-0x38], 0x0 */
            ii(0x100c_d080, 2); jmpd(0x100c_d088, 0x6); goto l_0x100c_d088; /* jmp 0x100cd088 */
        l_0x100c_d082:
            ii(0x100c_d082, 3); mov(eax, memd_a32[ss, ebp - 0x38]);     /* mov eax, [ebp-0x38] */
            ii(0x100c_d085, 3); inc(memd_a32[ss, ebp - 0x38]);          /* inc dword [ebp-0x38] */
        l_0x100c_d088:
            ii(0x100c_d088, 3); mov(eax, memd_a32[ss, ebp - 0x38]);     /* mov eax, [ebp-0x38] */
            ii(0x100c_d08b, 4); cmp(ax, memw_a32[ss, ebp - 0x30]);      /* cmp ax, [ebp-0x30] */
            ii(0x100c_d08f, 2); if(jged(0x100c_d0f3, 0x62)) goto l_0x100c_d0f3; /* jge 0x100cd0f3 */
            ii(0x100c_d091, 4); movsx(edx, memw_a32[ss, ebp - 0x34]);   /* movsx edx, word [ebp-0x34] */
            ii(0x100c_d095, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x100c_d098, 5); mov(eax, 0x101c_5348);                  /* mov eax, 0x101c5348 */
            ii(0x100c_d09d, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100c_d09f, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100c_d0a2, 5); calld(0x1008_b1a4, -0x4_1f03);          /* call 0x1008b1a4 */
            ii(0x100c_d0a7, 3); lea(edx, ebp - 0x1c);                   /* lea edx, [ebp-0x1c] */
            ii(0x100c_d0aa, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x100c_d0ad, 5); calld(0x1010_82ce, 0x3_b21c);           /* call 0x101082ce */
            ii(0x100c_d0b2, 2); test(al, al);                           /* test al, al */
            ii(0x100c_d0b4, 2); if(jzd(0x100c_d0f1, 0x3b)) goto l_0x100c_d0f1; /* jz 0x100cd0f1 */
            ii(0x100c_d0b6, 4); movsx(edx, memw_a32[ss, ebp - 0x1a]);   /* movsx edx, word [ebp-0x1a] */
            ii(0x100c_d0ba, 4); movsx(eax, memw_a32[ss, ebp - 0x1c]);   /* movsx eax, word [ebp-0x1c] */
            ii(0x100c_d0be, 5); calld(0x1007_3d48, -0x5_937b);          /* call 0x10073d48 */
            ii(0x100c_d0c3, 3); mov(memd_a32[ss, ebp - 0x3c], eax);     /* mov [ebp-0x3c], eax */
            ii(0x100c_d0c6, 4); movsx(eax, memw_a32[ss, ebp - 0x3c]);   /* movsx eax, word [ebp-0x3c] */
            ii(0x100c_d0ca, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x100c_d0cd, 2); if(jnzd(0x100c_d0d8, 0x9)) goto l_0x100c_d0d8; /* jnz 0x100cd0d8 */
            ii(0x100c_d0cf, 7); mov(memd_a32[ss, ebp - 0xc], 0x3b);     /* mov dword [ebp-0xc], 0x3b */
            ii(0x100c_d0d6, 2); jmpd(0x100c_d0f1, 0x19); goto l_0x100c_d0f1; /* jmp 0x100cd0f1 */
        l_0x100c_d0d8:
            ii(0x100c_d0d8, 4); movsx(eax, memw_a32[ss, ebp - 0x3c]);   /* movsx eax, word [ebp-0x3c] */
            ii(0x100c_d0dc, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x100c_d0df, 2); if(jnzd(0x100c_d0e8, 0x7)) goto l_0x100c_d0e8; /* jnz 0x100cd0e8 */
            ii(0x100c_d0e1, 5); cmp(memw_a32[ss, ebp - 0xc], -0x1 /* 0xff */); /* cmp word [ebp-0xc], 0xffff */
            ii(0x100c_d0e6, 2); if(jzd(0x100c_d0ea, 0x2)) goto l_0x100c_d0ea; /* jz 0x100cd0ea */
        l_0x100c_d0e8:
            ii(0x100c_d0e8, 2); jmpd(0x100c_d0f1, 0x7); goto l_0x100c_d0f1; /* jmp 0x100cd0f1 */
        l_0x100c_d0ea:
            ii(0x100c_d0ea, 7); mov(memd_a32[ss, ebp - 0xc], 0x4b);     /* mov dword [ebp-0xc], 0x4b */
        l_0x100c_d0f1:
            ii(0x100c_d0f1, 2); jmpd(0x100c_d082, -0x71); goto l_0x100c_d082; /* jmp 0x100cd082 */
        l_0x100c_d0f3:
            ii(0x100c_d0f3, 5); jmpd(0x100c_d068, -0x90); goto l_0x100c_d068; /* jmp 0x100cd068 */
        l_0x100c_d0f8:
            ii(0x100c_d0f8, 5); cmp(memw_a32[ss, ebp - 0xc], -0x1 /* 0xff */); /* cmp word [ebp-0xc], 0xffff */
            ii(0x100c_d0fd, 2); if(jnzd(0x100c_d10e, 0xf)) goto l_0x100c_d10e; /* jnz 0x100cd10e */
            ii(0x100c_d0ff, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_d101, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_d104, 5); calld(0x1007_5f6c, -0x5_719d);          /* call 0x10075f6c */
            ii(0x100c_d109, 5); jmpd(0x100c_d24b, 0x13d); goto l_0x100c_d24b; /* jmp 0x100cd24b */
        l_0x100c_d10e:
            ii(0x100c_d10e, 2); jmpd(0x100c_d118, 0x8); goto l_0x100c_d118; /* jmp 0x100cd118 */
        l_0x100c_d110:
            ii(0x100c_d110, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_d113, 5); calld(0x1007_6bf8, -0x5_6520);          /* call 0x10076bf8 */
        l_0x100c_d118:
            ii(0x100c_d118, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_d11a, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_d11d, 5); calld(0x1013_ad71, 0x6_dc4f);           /* call 0x1013ad71 */
            ii(0x100c_d122, 2); test(al, al);                           /* test al, al */
            ii(0x100c_d124, 6); if(jzd(0x100c_d233, 0x109)) goto l_0x100c_d233; /* jz 0x100cd233 */
            ii(0x100c_d12a, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_d12d, 5); calld(0x1007_63a0, -0x5_6d92);          /* call 0x100763a0 */
            ii(0x100c_d132, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_d134, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x100c_d137, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_d13a, 3); mov(eax, memd_a32[ds, eax + 0x7]);      /* mov eax, [eax+0x7] */
            ii(0x100c_d13d, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_d140, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100c_d142, 2); if(jnzd(0x100c_d156, 0x12)) goto l_0x100c_d156; /* jnz 0x100cd156 */
            ii(0x100c_d144, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_d147, 5); calld(0x1007_63a0, -0x5_6dac);          /* call 0x100763a0 */
            ii(0x100c_d14c, 4); mov(ax, memw_a32[ds, eax + 0x8]);       /* mov ax, [eax+0x8] */
            ii(0x100c_d150, 4); cmp(ax, memw_a32[ss, ebp - 0xc]);       /* cmp ax, [ebp-0xc] */
            ii(0x100c_d154, 2); if(jzd(0x100c_d158, 0x2)) goto l_0x100c_d158; /* jz 0x100cd158 */
        l_0x100c_d156:
            ii(0x100c_d156, 2); jmpd(0x100c_d16c, 0x14); goto l_0x100c_d16c; /* jmp 0x100cd16c */
        l_0x100c_d158:
            ii(0x100c_d158, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_d15b, 5); calld(0x1007_63a0, -0x5_6dc0);          /* call 0x100763a0 */
            ii(0x100c_d160, 3); mov(al, memb_a32[ds, eax + 0x4d]);      /* mov al, [eax+0x4d] */
            ii(0x100c_d163, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100c_d168, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_d16a, 2); if(jgd(0x100c_d16e, 0x2)) goto l_0x100c_d16e; /* jg 0x100cd16e */
        l_0x100c_d16c:
            ii(0x100c_d16c, 2); jmpd(0x100c_d1a2, 0x34); goto l_0x100c_d1a2; /* jmp 0x100cd1a2 */
        l_0x100c_d16e:
            ii(0x100c_d16e, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_d171, 5); calld(0x1007_63a0, -0x5_6dd6);          /* call 0x100763a0 */
            ii(0x100c_d176, 4); cmp(memb_a32[ds, eax + 0x3d], 0);       /* cmp byte [eax+0x3d], 0x0 */
            ii(0x100c_d17a, 2); if(jzd(0x100c_d1a0, 0x24)) goto l_0x100c_d1a0; /* jz 0x100cd1a0 */
            ii(0x100c_d17c, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_d17f, 5); calld(0x1007_63a0, -0x5_6de4);          /* call 0x100763a0 */
            ii(0x100c_d184, 4); cmp(memb_a32[ds, eax + 0x3d], 0x2);     /* cmp byte [eax+0x3d], 0x2 */
            ii(0x100c_d188, 2); if(jnzd(0x100c_d19e, 0x14)) goto l_0x100c_d19e; /* jnz 0x100cd19e */
            ii(0x100c_d18a, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_d18d, 5); calld(0x1007_63a0, -0x5_6df2);          /* call 0x100763a0 */
            ii(0x100c_d192, 3); mov(al, memb_a32[ds, eax + 0x4e]);      /* mov al, [eax+0x4e] */
            ii(0x100c_d195, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100c_d19a, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_d19c, 2); if(jzd(0x100c_d1a0, 0x2)) goto l_0x100c_d1a0; /* jz 0x100cd1a0 */
        l_0x100c_d19e:
            ii(0x100c_d19e, 2); jmpd(0x100c_d1a2, 0x2); goto l_0x100c_d1a2; /* jmp 0x100cd1a2 */
        l_0x100c_d1a0:
            ii(0x100c_d1a0, 2); jmpd(0x100c_d1a4, 0x2); goto l_0x100c_d1a4; /* jmp 0x100cd1a4 */
        l_0x100c_d1a2:
            ii(0x100c_d1a2, 2); jmpd(0x100c_d1bb, 0x17); goto l_0x100c_d1bb; /* jmp 0x100cd1bb */
        l_0x100c_d1a4:
            ii(0x100c_d1a4, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100c_d1a7, 3); add(edx, 0x13);                         /* add edx, 0x13 */
            ii(0x100c_d1aa, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_d1ad, 5); calld(0x1007_6408, -0x5_6daa);          /* call 0x10076408 */
            ii(0x100c_d1b2, 5); calld(0x1008_b4b4, -0x4_1d03);          /* call 0x1008b4b4 */
            ii(0x100c_d1b7, 2); test(al, al);                           /* test al, al */
            ii(0x100c_d1b9, 2); if(jnzd(0x100c_d1c0, 0x5)) goto l_0x100c_d1c0; /* jnz 0x100cd1c0 */
        l_0x100c_d1bb:
            ii(0x100c_d1bb, 5); jmpd(0x100c_d22e, 0x6e); goto l_0x100c_d22e; /* jmp 0x100cd22e */
        l_0x100c_d1c0:
            ii(0x100c_d1c0, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_d1c3, 5); calld(0x1007_63a0, -0x5_6e28);          /* call 0x100763a0 */
            ii(0x100c_d1c8, 5); calld(0x1015_26ac, 0x8_54df);           /* call 0x101526ac */
            ii(0x100c_d1cd, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_d1cf, 2); if(jzd(0x100c_d1f1, 0x20)) goto l_0x100c_d1f1; /* jz 0x100cd1f1 */
            ii(0x100c_d1d1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_d1d4, 3); mov(edx, memd_a32[ds, eax + 0xb]);      /* mov edx, [eax+0xb] */
            ii(0x100c_d1d7, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100c_d1da, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_d1dd, 5); calld(0x1007_63a0, -0x5_6e42);          /* call 0x100763a0 */
            ii(0x100c_d1e2, 5); calld(0x1015_26ac, 0x8_54c5);           /* call 0x101526ac */
            ii(0x100c_d1e7, 5); calld(0x100a_2bc4, -0x2_a628);          /* call 0x100a2bc4 */
            ii(0x100c_d1ec, 1); cwde();                                 /* cwde */
            ii(0x100c_d1ed, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_d1ef, 2); if(jled(0x100c_d22e, 0x3d)) goto l_0x100c_d22e; /* jle 0x100cd22e */
        l_0x100c_d1f1:
            ii(0x100c_d1f1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_d1f4, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100c_d1f7, 5); calld(0x1008_abbc, -0x4_2640);          /* call 0x1008abbc */
            ii(0x100c_d1fc, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_d1fe, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_d201, 5); calld(0x1007_636c, -0x5_6e9a);          /* call 0x1007636c */
            ii(0x100c_d206, 5); calld(0x100a_601a, -0x2_71f1);          /* call 0x100a601a */
            ii(0x100c_d20b, 3); mov(memd_a32[ss, ebp - 0x40], eax);     /* mov [ebp-0x40], eax */
            ii(0x100c_d20e, 4); cmp(memd_a32[ss, ebp - 0x14], 0);       /* cmp dword [ebp-0x14], 0x0 */
            ii(0x100c_d212, 2); if(jzd(0x100c_d21d, 0x9)) goto l_0x100c_d21d; /* jz 0x100cd21d */
            ii(0x100c_d214, 3); mov(eax, memd_a32[ss, ebp - 0x40]);     /* mov eax, [ebp-0x40] */
            ii(0x100c_d217, 4); cmp(ax, memw_a32[ss, ebp - 0x10]);      /* cmp ax, [ebp-0x10] */
            ii(0x100c_d21b, 2); if(jged(0x100c_d22e, 0x11)) goto l_0x100c_d22e; /* jge 0x100cd22e */
        l_0x100c_d21d:
            ii(0x100c_d21d, 3); mov(eax, memd_a32[ss, ebp - 0x40]);     /* mov eax, [ebp-0x40] */
            ii(0x100c_d220, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100c_d223, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_d226, 5); calld(0x1007_6408, -0x5_6e23);          /* call 0x10076408 */
            ii(0x100c_d22b, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
        l_0x100c_d22e:
            ii(0x100c_d22e, 5); jmpd(0x100c_d110, -0x123); goto l_0x100c_d110; /* jmp 0x100cd110 */
        l_0x100c_d233:
            ii(0x100c_d233, 3); mov(edx, memd_a32[ss, ebp - 0x14]);     /* mov edx, [ebp-0x14] */
            ii(0x100c_d236, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_d239, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100c_d23c, 5); calld(0x1007_6630, -0x5_6c11);          /* call 0x10076630 */
            ii(0x100c_d241, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_d243, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_d246, 5); calld(0x1007_5f6c, -0x5_72df);          /* call 0x10075f6c */
        l_0x100c_d24b:
            ii(0x100c_d24b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_d24d, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_d24e, 1); popd(edi);                              /* pop edi */
            ii(0x100c_d24f, 1); popd(esi);                              /* pop esi */
            ii(0x100c_d250, 1); popd(edx);                              /* pop edx */
            ii(0x100c_d251, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_d252, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_d253, 1); retd(); return;                         /* ret */
        }
    }
}
