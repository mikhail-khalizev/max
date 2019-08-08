using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("bf75cdeb-44c6-44de-8bd0-e27878cfcafd")]
        public void Method_100e_e881()
        {
            ii(0x100e_e881, 5); pushd(0xf0);                            /* push 0xf0 */
            ii(0x100e_e886, 5); calld(Definitions.sys_check_available_stack_size, 0x7_74c7); /* call 0x10165d52 */
            ii(0x100e_e88b, 1); pushd(esi);                             /* push esi */
            ii(0x100e_e88c, 1); pushd(edi);                             /* push edi */
            ii(0x100e_e88d, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_e88e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_e890, 6); sub(esp, 0xd0);                         /* sub esp, 0xd0 */
            ii(0x100e_e896, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100e_e899, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x100e_e89c, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x100e_e89f, 3); mov(memb_a32[ss, ebp - 0x4], cl);       /* mov [ebp-0x4], cl */
            ii(0x100e_e8a2, 7); mov(memd_a32[ss, ebp - 0x1c], 0x9);     /* mov dword [ebp-0x1c], 0x9 */
            ii(0x100e_e8a9, 4); mov(memb_a32[ss, ebp - 0x18], 0);       /* mov byte [ebp-0x18], 0x0 */
            ii(0x100e_e8ad, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x100e_e8b1, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100e_e8b3, 5); calld(0x100e_cd4d, -0x1b6b);            /* call 0x100ecd4d */
            ii(0x100e_e8b8, 3); mov(memb_a32[ss, ebp - 0x14], al);      /* mov [ebp-0x14], al */
            ii(0x100e_e8bb, 4); cmp(memb_a32[ss, ebp - 0x14], 0);       /* cmp byte [ebp-0x14], 0x0 */
            ii(0x100e_e8bf, 2); if(jnzd(0x100e_e8e8, 0x27)) goto l_0x100e_e8e8; /* jnz 0x100ee8e8 */
            ii(0x100e_e8c1, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100e_e8c3, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x100e_e8c8, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100e_e8ca, 4); mov(eax, memd_a32[ds, eax + ebp - 0x2a]); /* mov eax, [eax+ebp-0x2a] */
            ii(0x100e_e8ce, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100e_e8d1, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x100e_e8d4, 2); if(jnzd(0x100e_e8dc, 0x6)) goto l_0x100e_e8dc; /* jnz 0x100ee8dc */
            ii(0x100e_e8d6, 4); mov(memb_a32[ss, ebp - 0x20], 0x1);     /* mov byte [ebp-0x20], 0x1 */
            ii(0x100e_e8da, 2); jmpd(0x100e_e8e0, 0x4); goto l_0x100e_e8e0; /* jmp 0x100ee8e0 */
        l_0x100e_e8dc:
            ii(0x100e_e8dc, 4); mov(memb_a32[ss, ebp - 0x20], 0);       /* mov byte [ebp-0x20], 0x0 */
        l_0x100e_e8e0:
            ii(0x100e_e8e0, 3); mov(al, memb_a32[ss, ebp - 0x20]);      /* mov al, [ebp-0x20] */
            ii(0x100e_e8e3, 3); mov(memb_a32[ss, ebp - 0x18], al);      /* mov [ebp-0x18], al */
            ii(0x100e_e8e6, 2); jmpd(0x100e_e8fe, 0x16); goto l_0x100e_e8fe; /* jmp 0x100ee8fe */
        l_0x100e_e8e8:
            ii(0x100e_e8e8, 4); cmp(memb_a32[ss, ebp - 0x14], 0x2);     /* cmp byte [ebp-0x14], 0x2 */
            ii(0x100e_e8ec, 2); if(jnzd(0x100e_e8f4, 0x6)) goto l_0x100e_e8f4; /* jnz 0x100ee8f4 */
            ii(0x100e_e8ee, 4); mov(memb_a32[ss, ebp - 0x2c], 0x1);     /* mov byte [ebp-0x2c], 0x1 */
            ii(0x100e_e8f2, 2); jmpd(0x100e_e8f8, 0x4); goto l_0x100e_e8f8; /* jmp 0x100ee8f8 */
        l_0x100e_e8f4:
            ii(0x100e_e8f4, 4); mov(memb_a32[ss, ebp - 0x2c], 0);       /* mov byte [ebp-0x2c], 0x0 */
        l_0x100e_e8f8:
            ii(0x100e_e8f8, 3); mov(al, memb_a32[ss, ebp - 0x2c]);      /* mov al, [ebp-0x2c] */
            ii(0x100e_e8fb, 3); mov(memb_a32[ss, ebp - 0x18], al);      /* mov [ebp-0x18], al */
        l_0x100e_e8fe:
            ii(0x100e_e8fe, 7); cmp(memd_a32[ds, 0x101c_5624], 0);      /* cmp dword [0x101c5624], 0x0 */
            ii(0x100e_e905, 2); if(jzd(0x100e_e90c, 0x5)) goto l_0x100e_e90c; /* jz 0x100ee90c */
            ii(0x100e_e907, 5); calld(0x1012_9753, 0x3_ae47);           /* call 0x10129753 */
        l_0x100e_e90c:
            ii(0x100e_e90c, 7); cmp(memd_a32[ds, 0x101c_5624], 0);      /* cmp dword [0x101c5624], 0x0 */
            ii(0x100e_e913, 2); if(jzd(0x100e_e937, 0x22)) goto l_0x100e_e937; /* jz 0x100ee937 */
            ii(0x100e_e915, 4); cmp(memb_a32[ss, ebp - 0x4], 0);        /* cmp byte [ebp-0x4], 0x0 */
            ii(0x100e_e919, 2); if(jnzd(0x100e_e921, 0x6)) goto l_0x100e_e921; /* jnz 0x100ee921 */
            ii(0x100e_e91b, 4); mov(memb_a32[ss, ebp - 0x30], 0x1);     /* mov byte [ebp-0x30], 0x1 */
            ii(0x100e_e91f, 2); jmpd(0x100e_e925, 0x4); goto l_0x100e_e925; /* jmp 0x100ee925 */
        l_0x100e_e921:
            ii(0x100e_e921, 4); mov(memb_a32[ss, ebp - 0x30], 0);       /* mov byte [ebp-0x30], 0x0 */
        l_0x100e_e925:
            ii(0x100e_e925, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_e927, 3); mov(dl, memb_a32[ss, ebp - 0x30]);      /* mov dl, [ebp-0x30] */
            ii(0x100e_e92a, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100e_e92c, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x100e_e931, 1); cwde();                                 /* cwde */
            ii(0x100e_e932, 5); calld(0x1012_b16c, 0x3_c835);           /* call 0x1012b16c */
        l_0x100e_e937:
            ii(0x100e_e937, 4); movsx(edx, memw_a32[ss, ebp - 0x1c]);   /* movsx edx, word [ebp-0x1c] */
            ii(0x100e_e93b, 5); calld(/* sys */ 0x1016_5e9b, 0x7_755b); /* call 0x10165e9b */
            ii(0x100e_e940, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x100e_e943, 3); shr(eax, 0xf);                          /* shr eax, 0xf */
            ii(0x100e_e946, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x100e_e949, 9); mov(memw_a32[ds, 0x101b_8674], 0x32);   /* mov word [0x101b8674], 0x32 */
            ii(0x100e_e952, 5); calld(0x100e_f348, 0x9f1);              /* call 0x100ef348 */
            ii(0x100e_e957, 1); cwde();                                 /* cwde */
            ii(0x100e_e958, 5); calld(0x100f_3499, 0x4b3c);             /* call 0x100f3499 */
            ii(0x100e_e95d, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
            ii(0x100e_e960, 4); or(memb_a32[ss, ebp - 0x38], 0x1);      /* or byte [ebp-0x38], 0x1 */
            ii(0x100e_e964, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x100e_e967, 5); calld(Definitions.my_string_ctor, 0x5_317c); /* call 0x10141ae8 */
            ii(0x100e_e96c, 3); mov(memd_a32[ss, ebp - 0x40], eax);     /* mov [ebp-0x40], eax */
            ii(0x100e_e96f, 4); and(memb_a32[ss, ebp - 0x38], -0x2 /* 0xfe */); /* and byte [ebp-0x38], 0xfe */
            ii(0x100e_e973, 4); cmp(memb_a32[ss, ebp - 0x18], 0);       /* cmp byte [ebp-0x18], 0x0 */
            ii(0x100e_e977, 2); if(jzd(0x100e_e988, 0xf)) goto l_0x100e_e988; /* jz 0x100ee988 */
            ii(0x100e_e979, 5); mov(eax, 0x3e);                         /* mov eax, 0x3e */
            ii(0x100e_e97e, 5); calld(0x1007_5fdc, -0x7_89a7);          /* call 0x10075fdc */
            ii(0x100e_e983, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x100e_e986, 2); if(jzd(0x100e_e98d, 0x5)) goto l_0x100e_e98d; /* jz 0x100ee98d */
        l_0x100e_e988:
            ii(0x100e_e988, 5); jmpd(0x100e_ea39, 0xac); goto l_0x100e_ea39; /* jmp 0x100eea39 */
        l_0x100e_e98d:
            ii(0x100e_e98d, 5); mov(edx, 0x101c_3f00);                  /* mov edx, 0x101c3f00 */
            ii(0x100e_e992, 3); lea(eax, ebp - 0x44);                   /* lea eax, [ebp-0x44] */
            ii(0x100e_e995, 5); calld(Definitions.my_string_ctor_char_ptr, 0x5_30a1); /* call 0x10141a3b */
            ii(0x100e_e99a, 4); or(memb_a32[ss, ebp - 0x38], 0x1);      /* or byte [ebp-0x38], 0x1 */
            ii(0x100e_e99e, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x100e_e9a1, 5); calld(Definitions.my_string_ctor, 0x5_3142); /* call 0x10141ae8 */
            ii(0x100e_e9a6, 3); mov(memd_a32[ss, ebp - 0x4c], eax);     /* mov [ebp-0x4c], eax */
            ii(0x100e_e9a9, 4); and(memb_a32[ss, ebp - 0x38], -0x2 /* 0xfe */); /* and byte [ebp-0x38], 0xfe */
            ii(0x100e_e9ad, 5); mov(eax, memd_a32[ds, 0x101c_3980]);    /* mov eax, [0x101c3980] */
            ii(0x100e_e9b2, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100e_e9b5, 1); pushd(eax);                             /* push eax */
            ii(0x100e_e9b6, 5); mov(eax, StringDefinitions.WinICam);    /* mov eax, 0x101a1fb4 */
            ii(0x100e_e9bb, 1); pushd(eax);                             /* push eax */
            ii(0x100e_e9bc, 5); mov(eax, 0x1e);                         /* mov eax, 0x1e */
            ii(0x100e_e9c1, 1); pushd(eax);                             /* push eax */
            ii(0x100e_e9c2, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x100e_e9c5, 1); pushd(eax);                             /* push eax */
            ii(0x100e_e9c6, 5); calld(0x1014_2037, 0x5_366c);           /* call 0x10142037 */
            ii(0x100e_e9cb, 3); add(esp, 0x10);                         /* add esp, 0x10 */
            ii(0x100e_e9ce, 3); lea(edx, ebp - 0x48);                   /* lea edx, [ebp-0x48] */
            ii(0x100e_e9d1, 3); lea(eax, ebp - 0x44);                   /* lea eax, [ebp-0x44] */
            ii(0x100e_e9d4, 5); calld(Definitions.my_string_append_string, 0x5_32b0); /* call 0x10141c89 */
            ii(0x100e_e9d9, 5); mov(edx, StringDefinitions.Rt4);        /* mov edx, 0x101a1fbe */
            ii(0x100e_e9de, 3); lea(eax, ebp - 0x44);                   /* lea eax, [ebp-0x44] */
            ii(0x100e_e9e1, 5); calld(Definitions.my_strobj_c_str_v2, -0x6_521e); /* call 0x100897c8 */
            ii(0x100e_e9e6, 5); calld(Definitions.my_fopen, 0xa34);     /* call 0x100ef41f */
            ii(0x100e_e9eb, 3); mov(memd_a32[ss, ebp - 0x50], eax);     /* mov [ebp-0x50], eax */
            ii(0x100e_e9ee, 4); cmp(memd_a32[ss, ebp - 0x50], 0);       /* cmp dword [ebp-0x50], 0x0 */
            ii(0x100e_e9f2, 2); if(jzd(0x100e_ea25, 0x31)) goto l_0x100e_ea25; /* jz 0x100eea25 */
        l_0x100e_e9f4:
            ii(0x100e_e9f4, 3); mov(eax, memd_a32[ss, ebp - 0x50]);     /* mov eax, [ebp-0x50] */
            ii(0x100e_e9f7, 5); calld(/* sys */ 0x1017_1f05, 0x8_3509); /* call 0x10171f05 */
            ii(0x100e_e9fc, 3); mov(memd_a32[ss, ebp - 0x54], eax);     /* mov [ebp-0x54], eax */
            ii(0x100e_e9ff, 4); cmp(memd_a32[ss, ebp - 0x54], -0x1 /* 0xff */); /* cmp dword [ebp-0x54], 0xffffffff */
            ii(0x100e_ea03, 2); if(jzd(0x100e_ea14, 0xf)) goto l_0x100e_ea14; /* jz 0x100eea14 */
            ii(0x100e_ea05, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_ea07, 3); mov(dl, memb_a32[ss, ebp - 0x54]);      /* mov dl, [ebp-0x54] */
            ii(0x100e_ea0a, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x100e_ea0d, 5); calld(Definitions.my_string_append_char, 0x5_33d8); /* call 0x10141dea */
            ii(0x100e_ea12, 2); jmpd(0x100e_e9f4, -0x20); goto l_0x100e_e9f4; /* jmp 0x100ee9f4 */
        l_0x100e_ea14:
            ii(0x100e_ea14, 3); mov(eax, memd_a32[ss, ebp - 0x50]);     /* mov eax, [ebp-0x50] */
            ii(0x100e_ea17, 5); calld(Definitions.sys_fclose, 0x8_364d); /* call 0x10172069 */
            ii(0x100e_ea1c, 9); mov(memw_a32[ds, 0x101b_8674], 0xa);    /* mov word [0x101b8674], 0xa */
        l_0x100e_ea25:
            ii(0x100e_ea25, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_ea27, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x100e_ea2a, 5); calld(Definitions.my_string_dtor, 0x5_30fb); /* call 0x10141b2a */
            ii(0x100e_ea2f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_ea31, 3); lea(eax, ebp - 0x44);                   /* lea eax, [ebp-0x44] */
            ii(0x100e_ea34, 5); calld(Definitions.my_string_dtor, 0x5_30f1); /* call 0x10141b2a */
        l_0x100e_ea39:
            ii(0x100e_ea39, 4); or(memb_a32[ss, ebp - 0x38], 0x1);      /* or byte [ebp-0x38], 0x1 */
            ii(0x100e_ea3d, 4); movsx(eax, memw_a32[ss, ebp - 0x1c]);   /* movsx eax, word [ebp-0x1c] */
            ii(0x100e_ea41, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100e_ea43, 6); mov(edx, memd_a32[ds, eax + 0x101b_8676]); /* mov edx, [eax+0x101b8676] */
            ii(0x100e_ea49, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100e_ea4c, 3); lea(eax, ebp - 0x6c);                   /* lea eax, [ebp-0x6c] */
            ii(0x100e_ea4f, 5); calld(0x100d_67d8, -0x1_827c);          /* call 0x100d67d8 */
            ii(0x100e_ea54, 3); mov(memd_a32[ss, ebp - 0x70], eax);     /* mov [ebp-0x70], eax */
            ii(0x100e_ea57, 4); and(memb_a32[ss, ebp - 0x38], -0x2 /* 0xfe */); /* and byte [ebp-0x38], 0xfe */
            ii(0x100e_ea5b, 7); mov(memb_a32[ds, 0x101c_3984], 0x1);    /* mov byte [0x101c3984], 0x1 */
            ii(0x100e_ea62, 7); mov(memb_a32[ds, 0x101c_3970], 0);      /* mov byte [0x101c3970], 0x0 */
            ii(0x100e_ea69, 7); mov(memb_a32[ds, 0x101c_37d2], 0);      /* mov byte [0x101c37d2], 0x0 */
            ii(0x100e_ea70, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x100e_ea75, 5); calld(0x1013_d08a, 0x4_e610);           /* call 0x1013d08a */
            ii(0x100e_ea7a, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100e_ea7c, 5); calld(0x100f_448c, 0x5a0b);             /* call 0x100f448c */
            ii(0x100e_ea81, 5); mov(edx, 0x10);                         /* mov edx, 0x10 */
            ii(0x100e_ea86, 3); lea(eax, ebp - 0x6c);                   /* lea eax, [ebp-0x6c] */
            ii(0x100e_ea89, 5); calld(0x100e_f318, 0x88a);              /* call 0x100ef318 */
            ii(0x100e_ea8e, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100e_ea93, 5); calld(/* sys */ 0x1016_a24c, 0x7_b7b4); /* call 0x1016a24c */
            ii(0x100e_ea98, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100e_ea9d, 5); calld(0x1012_0d94, 0x3_22f2);           /* call 0x10120d94 */
            ii(0x100e_eaa2, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100e_eaa7, 3); lea(eax, ebp - 0x6c);                   /* lea eax, [ebp-0x6c] */
            ii(0x100e_eaaa, 5); calld(0x100e_f2e8, 0x839);              /* call 0x100ef2e8 */
            ii(0x100e_eaaf, 5); calld(0x100d_6124, -0x1_8990);          /* call 0x100d6124 */
            ii(0x100e_eab4, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_eab6, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x100e_eab8, 3); lea(eax, ebp - 0x6c);                   /* lea eax, [ebp-0x6c] */
            ii(0x100e_eabb, 5); calld(0x100d_6adf, -0x1_7fe1);          /* call 0x100d6adf */
            ii(0x100e_eac0, 6); lea(edx, ebp - 0x8c);                   /* lea edx, [ebp-0x8c] */
            ii(0x100e_eac6, 3); lea(eax, ebp - 0x6c);                   /* lea eax, [ebp-0x6c] */
            ii(0x100e_eac9, 5); calld(0x100d_6a11, -0x1_80bd);          /* call 0x100d6a11 */
            ii(0x100e_eace, 10); mov(memd_a32[ss, ebp - 0x90], 0);      /* mov dword [ebp-0x90], 0x0 */
            ii(0x100e_ead8, 2); jmpd(0x100e_eae6, 0xc); goto l_0x100e_eae6; /* jmp 0x100eeae6 */
        l_0x100e_eada:
            ii(0x100e_eada, 6); mov(eax, memd_a32[ss, ebp - 0x90]);     /* mov eax, [ebp-0x90] */
            ii(0x100e_eae0, 6); inc(memd_a32[ss, ebp - 0x90]);          /* inc dword [ebp-0x90] */
        l_0x100e_eae6:
            ii(0x100e_eae6, 7); movsx(eax, memw_a32[ss, ebp - 0x90]);   /* movsx eax, word [ebp-0x90] */
            ii(0x100e_eaed, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x100e_eaf0, 2); if(jged(0x100e_eb04, 0x12)) goto l_0x100e_eb04; /* jge 0x100eeb04 */
            ii(0x100e_eaf2, 7); movsx(eax, memw_a32[ss, ebp - 0x90]);   /* movsx eax, word [ebp-0x90] */
            ii(0x100e_eaf9, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100e_eafb, 7); mov(memw_a32[ds, eax + ebp - 0x28], 0); /* mov word [eax+ebp-0x28], 0x0 */
            ii(0x100e_eb02, 2); jmpd(0x100e_eada, -0x2a); goto l_0x100e_eada; /* jmp 0x100eeada */
        l_0x100e_eb04:
            ii(0x100e_eb04, 10); mov(memd_a32[ss, ebp - 0x90], 0);      /* mov dword [ebp-0x90], 0x0 */
            ii(0x100e_eb0e, 2); jmpd(0x100e_eb1c, 0xc); goto l_0x100e_eb1c; /* jmp 0x100eeb1c */
        l_0x100e_eb10:
            ii(0x100e_eb10, 6); mov(eax, memd_a32[ss, ebp - 0x90]);     /* mov eax, [ebp-0x90] */
            ii(0x100e_eb16, 6); inc(memd_a32[ss, ebp - 0x90]);          /* inc dword [ebp-0x90] */
        l_0x100e_eb1c:
            ii(0x100e_eb1c, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x100e_eb20, 7); movsx(edx, memw_a32[ss, ebp - 0x90]);   /* movsx edx, word [ebp-0x90] */
            ii(0x100e_eb27, 1); dec(eax);                               /* dec eax */
            ii(0x100e_eb28, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100e_eb2a, 6); if(jged(0x100e_ebd5, 0xa5)) goto l_0x100e_ebd5; /* jge 0x100eebd5 */
            ii(0x100e_eb30, 6); mov(eax, memd_a32[ss, ebp - 0x90]);     /* mov eax, [ebp-0x90] */
            ii(0x100e_eb36, 1); inc(eax);                               /* inc eax */
            ii(0x100e_eb37, 6); mov(memd_a32[ss, ebp - 0x94], eax);     /* mov [ebp-0x94], eax */
            ii(0x100e_eb3d, 2); jmpd(0x100e_eb4b, 0xc); goto l_0x100e_eb4b; /* jmp 0x100eeb4b */
        l_0x100e_eb3f:
            ii(0x100e_eb3f, 6); mov(eax, memd_a32[ss, ebp - 0x94]);     /* mov eax, [ebp-0x94] */
            ii(0x100e_eb45, 6); inc(memd_a32[ss, ebp - 0x94]);          /* inc dword [ebp-0x94] */
        l_0x100e_eb4b:
            ii(0x100e_eb4b, 6); mov(eax, memd_a32[ss, ebp - 0x94]);     /* mov eax, [ebp-0x94] */
            ii(0x100e_eb51, 4); cmp(ax, memw_a32[ss, ebp - 0xc]);       /* cmp ax, [ebp-0xc] */
            ii(0x100e_eb55, 2); if(jged(0x100e_ebd0, 0x79)) goto l_0x100e_ebd0; /* jge 0x100eebd0 */
            ii(0x100e_eb57, 7); movsx(eax, memw_a32[ss, ebp - 0x94]);   /* movsx eax, word [ebp-0x94] */
            ii(0x100e_eb5e, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100e_eb60, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x100e_eb63, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100e_eb65, 3); movsx(edx, memw_a32[ds, edx]);          /* movsx edx, word [edx] */
            ii(0x100e_eb68, 7); movsx(eax, memw_a32[ss, ebp - 0x90]);   /* movsx eax, word [ebp-0x90] */
            ii(0x100e_eb6f, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100e_eb71, 3); add(eax, memd_a32[ss, ebp - 0x10]);     /* add eax, [ebp-0x10] */
            ii(0x100e_eb74, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100e_eb77, 5); calld(0x100e_c365, -0x2817);            /* call 0x100ec365 */
            ii(0x100e_eb7c, 1); cwde();                                 /* cwde */
            ii(0x100e_eb7d, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_eb7f, 2); if(jged(0x100e_ebcb, 0x4a)) goto l_0x100e_ebcb; /* jge 0x100eebcb */
            ii(0x100e_eb81, 7); movsx(eax, memw_a32[ss, ebp - 0x94]);   /* movsx eax, word [ebp-0x94] */
            ii(0x100e_eb88, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100e_eb8a, 3); add(eax, memd_a32[ss, ebp - 0x10]);     /* add eax, [ebp-0x10] */
            ii(0x100e_eb8d, 3); mov(ax, memw_a32[ds, eax]);             /* mov ax, [eax] */
            ii(0x100e_eb90, 6); mov(memd_a32[ss, ebp - 0x98], eax);     /* mov [ebp-0x98], eax */
            ii(0x100e_eb96, 7); movsx(eax, memw_a32[ss, ebp - 0x90]);   /* movsx eax, word [ebp-0x90] */
            ii(0x100e_eb9d, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100e_eb9f, 3); add(eax, memd_a32[ss, ebp - 0x10]);     /* add eax, [ebp-0x10] */
            ii(0x100e_eba2, 7); movsx(edx, memw_a32[ss, ebp - 0x94]);   /* movsx edx, word [ebp-0x94] */
            ii(0x100e_eba9, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x100e_ebab, 3); add(edx, memd_a32[ss, ebp - 0x10]);     /* add edx, [ebp-0x10] */
            ii(0x100e_ebae, 3); mov(ax, memw_a32[ds, eax]);             /* mov ax, [eax] */
            ii(0x100e_ebb1, 3); mov(memw_a32[ds, edx], ax);             /* mov [edx], ax */
            ii(0x100e_ebb4, 7); movsx(eax, memw_a32[ss, ebp - 0x90]);   /* movsx eax, word [ebp-0x90] */
            ii(0x100e_ebbb, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100e_ebbd, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x100e_ebc0, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100e_ebc2, 6); mov(eax, memd_a32[ss, ebp - 0x98]);     /* mov eax, [ebp-0x98] */
            ii(0x100e_ebc8, 3); mov(memw_a32[ds, edx], ax);             /* mov [edx], ax */
        l_0x100e_ebcb:
            ii(0x100e_ebcb, 5); jmpd(0x100e_eb3f, -0x91); goto l_0x100e_eb3f; /* jmp 0x100eeb3f */
        l_0x100e_ebd0:
            ii(0x100e_ebd0, 5); jmpd(0x100e_eb10, -0xc5); goto l_0x100e_eb10; /* jmp 0x100eeb10 */
        l_0x100e_ebd5:
            ii(0x100e_ebd5, 10); mov(memd_a32[ss, ebp - 0x90], 0);      /* mov dword [ebp-0x90], 0x0 */
            ii(0x100e_ebdf, 2); jmpd(0x100e_ebed, 0xc); goto l_0x100e_ebed; /* jmp 0x100eebed */
        l_0x100e_ebe1:
            ii(0x100e_ebe1, 6); mov(eax, memd_a32[ss, ebp - 0x90]);     /* mov eax, [ebp-0x90] */
            ii(0x100e_ebe7, 6); inc(memd_a32[ss, ebp - 0x90]);          /* inc dword [ebp-0x90] */
        l_0x100e_ebed:
            ii(0x100e_ebed, 6); mov(eax, memd_a32[ss, ebp - 0x90]);     /* mov eax, [ebp-0x90] */
            ii(0x100e_ebf3, 4); cmp(ax, memw_a32[ss, ebp - 0xc]);       /* cmp ax, [ebp-0xc] */
            ii(0x100e_ebf7, 2); if(jged(0x100e_ec18, 0x1f)) goto l_0x100e_ec18; /* jge 0x100eec18 */
            ii(0x100e_ebf9, 6); mov(edx, memd_a32[ss, ebp - 0x90]);     /* mov edx, [ebp-0x90] */
            ii(0x100e_ebff, 1); inc(edx);                               /* inc edx */
            ii(0x100e_ec00, 7); movsx(eax, memw_a32[ss, ebp - 0x90]);   /* movsx eax, word [ebp-0x90] */
            ii(0x100e_ec07, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100e_ec09, 3); add(eax, memd_a32[ss, ebp - 0x10]);     /* add eax, [ebp-0x10] */
            ii(0x100e_ec0c, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100e_ec0f, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100e_ec11, 5); mov(memw_a32[ds, eax + ebp - 0x28], dx); /* mov [eax+ebp-0x28], dx */
            ii(0x100e_ec16, 2); jmpd(0x100e_ebe1, -0x37); goto l_0x100e_ebe1; /* jmp 0x100eebe1 */
        l_0x100e_ec18:
            ii(0x100e_ec18, 4); cmp(memb_a32[ss, ebp - 0x18], 0);       /* cmp byte [ebp-0x18], 0x0 */
            ii(0x100e_ec1c, 2); if(jzd(0x100e_ec4d, 0x2f)) goto l_0x100e_ec4d; /* jz 0x100eec4d */
            ii(0x100e_ec1e, 5); calld(0x100d_5470, -0x1_97b3);          /* call 0x100d5470 */
            ii(0x100e_ec23, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100e_ec26, 5); mov(ebx, 0x464);                        /* mov ebx, 0x464 */
            ii(0x100e_ec2b, 5); mov(edx, 0x464);                        /* mov edx, 0x464 */
            ii(0x100e_ec30, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x100e_ec35, 5); calld(0x1013_daea, 0x4_eeb0);           /* call 0x1013daea */
            ii(0x100e_ec3a, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100e_ec3c, 5); mov(edx, 0x6b1);                        /* mov edx, 0x6b1 */
            ii(0x100e_ec41, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x100e_ec46, 5); calld(0x1013_cf8e, 0x4_e343);           /* call 0x1013cf8e */
            ii(0x100e_ec4b, 2); jmpd(0x100e_ec5e, 0x11); goto l_0x100e_ec5e; /* jmp 0x100eec5e */
        l_0x100e_ec4d:
            ii(0x100e_ec4d, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100e_ec4f, 5); mov(edx, 0x6b2);                        /* mov edx, 0x6b2 */
            ii(0x100e_ec54, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x100e_ec59, 5); calld(0x1013_cf8e, 0x4_e330);           /* call 0x1013cf8e */
        l_0x100e_ec5e:
            ii(0x100e_ec5e, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x100e_ec61, 5); calld(0x100e_aef0, -0x3d76);            /* call 0x100eaef0 */
            ii(0x100e_ec66, 1); cwde();                                 /* cwde */
            ii(0x100e_ec67, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_ec69, 2); if(jled(0x100e_eca3, 0x38)) goto l_0x100e_eca3; /* jle 0x100eeca3 */
            ii(0x100e_ec6b, 3); mov(eax, memd_a32[ss, ebp - 0x7a]);     /* mov eax, [ebp-0x7a] */
            ii(0x100e_ec6e, 5); calld(Definitions.sys_display_draw_0, 0x7_8811); /* call 0x10167484 */
            ii(0x100e_ec73, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100e_ec75, 1); pushd(eax);                             /* push eax */
            ii(0x100e_ec76, 5); mov(eax, 0x190);                        /* mov eax, 0x190 */
            ii(0x100e_ec7b, 1); pushd(eax);                             /* push eax */
            ii(0x100e_ec7c, 5); mov(eax, 0x258);                        /* mov eax, 0x258 */
            ii(0x100e_ec81, 1); pushd(eax);                             /* push eax */
            ii(0x100e_ec82, 5); mov(ecx, 0x14);                         /* mov ecx, 0x14 */
            ii(0x100e_ec87, 5); mov(ebx, 0x14);                         /* mov ebx, 0x14 */
            ii(0x100e_ec8c, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x100e_ec8f, 5); calld(Definitions.my_strobj_c_str_v2, -0x6_54cc); /* call 0x100897c8 */
            ii(0x100e_ec94, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_ec96, 6); lea(eax, ebp - 0x8c);                   /* lea eax, [ebp-0x8c] */
            ii(0x100e_ec9c, 5); calld(0x100e_d950, -0x1351);            /* call 0x100ed950 */
            ii(0x100e_eca1, 2); jmpd(0x100e_ecba, 0x17); goto l_0x100e_ecba; /* jmp 0x100eecba */
        l_0x100e_eca3:
            ii(0x100e_eca3, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x100e_eca5, 3); mov(cl, memb_a32[ss, ebp - 0x4]);       /* mov cl, [ebp-0x4] */
            ii(0x100e_eca8, 4); movsx(ebx, memw_a32[ss, ebp - 0x8]);    /* movsx ebx, word [ebp-0x8] */
            ii(0x100e_ecac, 3); lea(edx, ebp - 0x28);                   /* lea edx, [ebp-0x28] */
            ii(0x100e_ecaf, 6); lea(eax, ebp - 0x8c);                   /* lea eax, [ebp-0x8c] */
            ii(0x100e_ecb5, 5); calld(0x100e_da52, -0x1268);            /* call 0x100eda52 */
        l_0x100e_ecba:
            ii(0x100e_ecba, 5); mov(eax, 0x5);                          /* mov eax, 0x5 */
            ii(0x100e_ecbf, 5); calld(/* sys */ 0x1016_a24c, 0x7_b588); /* call 0x1016a24c */
            ii(0x100e_ecc4, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x100e_ecc9, 5); calld(Definitions.sys_new, 0x7_7132);   /* call 0x10165e00 */
            ii(0x100e_ecce, 6); mov(memd_a32[ss, ebp - 0x9c], eax);     /* mov [ebp-0x9c], eax */
            ii(0x100e_ecd4, 6); mov(eax, memd_a32[ss, ebp - 0x9c]);     /* mov eax, [ebp-0x9c] */
            ii(0x100e_ecda, 6); mov(memd_a32[ss, ebp - 0xa0], eax);     /* mov [ebp-0xa0], eax */
            ii(0x100e_ece0, 7); cmp(memd_a32[ss, ebp - 0xa0], 0);       /* cmp dword [ebp-0xa0], 0x0 */
            ii(0x100e_ece7, 2); if(jzd(0x100e_ed1d, 0x34)) goto l_0x100e_ed1d; /* jz 0x100eed1d */
            ii(0x100e_ece9, 5); mov(eax, 0x1ca);                        /* mov eax, 0x1ca */
            ii(0x100e_ecee, 1); pushd(eax);                             /* push eax */
            ii(0x100e_ecef, 5); mov(ecx, 0x125);                        /* mov ecx, 0x125 */
            ii(0x100e_ecf4, 5); mov(ebx, 0x15b);                        /* mov ebx, 0x15b */
            ii(0x100e_ecf9, 5); mov(edx, 0x15a);                        /* mov edx, 0x15a */
            ii(0x100e_ecfe, 6); mov(eax, memd_a32[ss, ebp - 0x9c]);     /* mov eax, [ebp-0x9c] */
            ii(0x100e_ed04, 5); calld(Definitions.my_ctor_c17, -0x2_08fa); /* call 0x100ce40f */
            ii(0x100e_ed09, 6); mov(memd_a32[ss, ebp - 0xa4], eax);     /* mov [ebp-0xa4], eax */
            ii(0x100e_ed0f, 6); mov(eax, memd_a32[ss, ebp - 0xa4]);     /* mov eax, [ebp-0xa4] */
            ii(0x100e_ed15, 6); mov(memd_a32[ss, ebp - 0xa8], eax);     /* mov [ebp-0xa8], eax */
            ii(0x100e_ed1b, 2); jmpd(0x100e_ed29, 0xc); goto l_0x100e_ed29; /* jmp 0x100eed29 */
        l_0x100e_ed1d:
            ii(0x100e_ed1d, 6); mov(eax, memd_a32[ss, ebp - 0xa0]);     /* mov eax, [ebp-0xa0] */
            ii(0x100e_ed23, 6); mov(memd_a32[ss, ebp - 0xa8], eax);     /* mov [ebp-0xa8], eax */
        l_0x100e_ed29:
            ii(0x100e_ed29, 6); mov(eax, memd_a32[ss, ebp - 0xa8]);     /* mov eax, [ebp-0xa8] */
            ii(0x100e_ed2f, 6); mov(memd_a32[ss, ebp - 0xac], eax);     /* mov [ebp-0xac], eax */
            ii(0x100e_ed35, 6); lea(eax, ebp - 0xb0);                   /* lea eax, [ebp-0xb0] */
            ii(0x100e_ed3b, 5); calld(0x100d_5224, -0x1_9b1c);          /* call 0x100d5224 */
            ii(0x100e_ed40, 1); pushd(eax);                             /* push eax */
            ii(0x100e_ed41, 6); lea(eax, ebp - 0xb4);                   /* lea eax, [ebp-0xb4] */
            ii(0x100e_ed47, 5); calld(0x100d_5250, -0x1_9afc);          /* call 0x100d5250 */
            ii(0x100e_ed4c, 1); pushd(eax);                             /* push eax */
            ii(0x100e_ed4d, 6); lea(eax, ebp - 0xb8);                   /* lea eax, [ebp-0xb8] */
            ii(0x100e_ed53, 5); calld(0x100d_527c, -0x1_9adc);          /* call 0x100d527c */
            ii(0x100e_ed58, 1); pushd(eax);                             /* push eax */
            ii(0x100e_ed59, 6); lea(eax, ebp - 0xbc);                   /* lea eax, [ebp-0xbc] */
            ii(0x100e_ed5f, 5); calld(0x100d_52a8, -0x1_9abc);          /* call 0x100d52a8 */
            ii(0x100e_ed64, 1); pushd(eax);                             /* push eax */
            ii(0x100e_ed65, 5); calld(0x100d_52d4, -0x1_9a96);          /* call 0x100d52d4 */
            ii(0x100e_ed6a, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100e_ed6d, 5); calld(0x100d_52f8, -0x1_9a7a);          /* call 0x100d52f8 */
            ii(0x100e_ed72, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x100e_ed75, 5); mov(edx, StringDefinitions.Ok2);        /* mov edx, 0x101a1fc1 */
            ii(0x100e_ed7a, 6); mov(eax, memd_a32[ss, ebp - 0xac]);     /* mov eax, [ebp-0xac] */
            ii(0x100e_ed80, 5); calld(0x100c_ef64, -0x1_fe21);          /* call 0x100cef64 */
            ii(0x100e_ed85, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100e_ed8a, 5); calld(/* sys */ 0x1016_a24c, 0x7_b4bd); /* call 0x1016a24c */
            ii(0x100e_ed8f, 5); mov(edx, 0x1b);                         /* mov edx, 0x1b */
            ii(0x100e_ed94, 6); mov(eax, memd_a32[ss, ebp - 0xac]);     /* mov eax, [ebp-0xac] */
            ii(0x100e_ed9a, 5); calld(0x100d_5134, -0x1_9c6b);          /* call 0x100d5134 */
            ii(0x100e_ed9f, 3); mov(edx, memd_a32[ss, ebp - 0x7a]);     /* mov edx, [ebp-0x7a] */
            ii(0x100e_eda2, 6); mov(eax, memd_a32[ss, ebp - 0xac]);     /* mov eax, [ebp-0xac] */
            ii(0x100e_eda8, 5); calld(0x100c_f85c, -0x1_f551);          /* call 0x100cf85c */
            ii(0x100e_edad, 3); mov(eax, memd_a32[ss, ebp - 0x7a]);     /* mov eax, [ebp-0x7a] */
            ii(0x100e_edb0, 5); calld(Definitions.sys_display_draw_0, 0x7_86cf); /* call 0x10167484 */
            ii(0x100e_edb5, 7); mov(memb_a32[ss, ebp - 0xc0], 0);       /* mov byte [ebp-0xc0], 0x0 */
            ii(0x100e_edbc, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_edbe, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100e_edc3, 5); calld(0x1007_6630, -0x7_8798);          /* call 0x10076630 */
            ii(0x100e_edc8, 5); calld(0x1014_82f4, 0x5_9527);           /* call 0x101482f4 */
            ii(0x100e_edcd, 6); mov(memd_a32[ss, ebp - 0xc4], eax);     /* mov [ebp-0xc4], eax */
        l_0x100e_edd3:
            ii(0x100e_edd3, 5); calld(/* sys */ 0x1016_b208, 0x7_c430); /* call 0x1016b208 */
            ii(0x100e_edd8, 6); mov(memd_a32[ss, ebp - 0xc8], eax);     /* mov [ebp-0xc8], eax */
            ii(0x100e_edde, 5); jmpd(0x100e_ee9c, 0xb9); goto l_0x100e_ee9c; /* jmp 0x100eee9c */
        l_0x100e_ede3:
            ii(0x100e_ede3, 7); mov(memb_a32[ss, ebp - 0xc0], 0x1);     /* mov byte [ebp-0xc0], 0x1 */
            ii(0x100e_edea, 5); jmpd(0x100e_eed0, 0xe1); goto l_0x100e_eed0; /* jmp 0x100eeed0 */
        l_0x100e_edef:
            ii(0x100e_edef, 4); movsx(eax, memw_a32[ss, ebp - 0x1c]);   /* movsx eax, word [ebp-0x1c] */
            ii(0x100e_edf3, 1); inc(eax);                               /* inc eax */
            ii(0x100e_edf4, 5); mov(ebx, 0x9);                          /* mov ebx, 0x9 */
            ii(0x100e_edf9, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_edfb, 2); div(ebx);                               /* div ebx */
            ii(0x100e_edfd, 3); mov(memd_a32[ss, ebp - 0x1c], edx);     /* mov [ebp-0x1c], edx */
            ii(0x100e_ee00, 5); calld(0x100d_533c, -0x1_9ac9);          /* call 0x100d533c */
            ii(0x100e_ee05, 1); cwde();                                 /* cwde */
            ii(0x100e_ee06, 1); pushd(eax);                             /* push eax */
            ii(0x100e_ee07, 5); calld(0x100d_5360, -0x1_9aac);          /* call 0x100d5360 */
            ii(0x100e_ee0c, 1); cwde();                                 /* cwde */
            ii(0x100e_ee0d, 1); pushd(eax);                             /* push eax */
            ii(0x100e_ee0e, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100e_ee10, 1); pushd(eax);                             /* push eax */
            ii(0x100e_ee11, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x100e_ee16, 4); movsx(ebx, memw_a32[ss, ebp - 0x7c]);   /* movsx ebx, word [ebp-0x7c] */
            ii(0x100e_ee1a, 6); lea(edx, ebp - 0x8c);                   /* lea edx, [ebp-0x8c] */
            ii(0x100e_ee20, 4); movsx(eax, memw_a32[ss, ebp - 0x1c]);   /* movsx eax, word [ebp-0x1c] */
            ii(0x100e_ee24, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100e_ee26, 6); mov(eax, memd_a32[ds, eax + 0x101b_8676]); /* mov eax, [eax+0x101b8676] */
            ii(0x100e_ee2c, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100e_ee2f, 5); calld(0x100e_8c51, -0x61e3);            /* call 0x100e8c51 */
            ii(0x100e_ee34, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x100e_ee37, 5); calld(0x100e_aef0, -0x3f4c);            /* call 0x100eaef0 */
            ii(0x100e_ee3c, 1); cwde();                                 /* cwde */
            ii(0x100e_ee3d, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_ee3f, 2); if(jled(0x100e_ee79, 0x38)) goto l_0x100e_ee79; /* jle 0x100eee79 */
            ii(0x100e_ee41, 3); mov(eax, memd_a32[ss, ebp - 0x7a]);     /* mov eax, [ebp-0x7a] */
            ii(0x100e_ee44, 5); calld(Definitions.sys_display_draw_0, 0x7_863b); /* call 0x10167484 */
            ii(0x100e_ee49, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100e_ee4b, 1); pushd(eax);                             /* push eax */
            ii(0x100e_ee4c, 5); mov(eax, 0x190);                        /* mov eax, 0x190 */
            ii(0x100e_ee51, 1); pushd(eax);                             /* push eax */
            ii(0x100e_ee52, 5); mov(eax, 0x258);                        /* mov eax, 0x258 */
            ii(0x100e_ee57, 1); pushd(eax);                             /* push eax */
            ii(0x100e_ee58, 5); mov(ecx, 0x14);                         /* mov ecx, 0x14 */
            ii(0x100e_ee5d, 5); mov(ebx, 0x14);                         /* mov ebx, 0x14 */
            ii(0x100e_ee62, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x100e_ee65, 5); calld(Definitions.my_strobj_c_str_v2, -0x6_56a2); /* call 0x100897c8 */
            ii(0x100e_ee6a, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_ee6c, 6); lea(eax, ebp - 0x8c);                   /* lea eax, [ebp-0x8c] */
            ii(0x100e_ee72, 5); calld(0x100e_d950, -0x1527);            /* call 0x100ed950 */
            ii(0x100e_ee77, 2); jmpd(0x100e_ee90, 0x17); goto l_0x100e_ee90; /* jmp 0x100eee90 */
        l_0x100e_ee79:
            ii(0x100e_ee79, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x100e_ee7b, 3); mov(cl, memb_a32[ss, ebp - 0x4]);       /* mov cl, [ebp-0x4] */
            ii(0x100e_ee7e, 4); movsx(ebx, memw_a32[ss, ebp - 0x8]);    /* movsx ebx, word [ebp-0x8] */
            ii(0x100e_ee82, 3); lea(edx, ebp - 0x28);                   /* lea edx, [ebp-0x28] */
            ii(0x100e_ee85, 6); lea(eax, ebp - 0x8c);                   /* lea eax, [ebp-0x8c] */
            ii(0x100e_ee8b, 5); calld(0x100e_da52, -0x143e);            /* call 0x100eda52 */
        l_0x100e_ee90:
            ii(0x100e_ee90, 3); mov(eax, memd_a32[ss, ebp - 0x7a]);     /* mov eax, [ebp-0x7a] */
            ii(0x100e_ee93, 5); calld(Definitions.sys_display_draw_0, 0x7_85ec); /* call 0x10167484 */
            ii(0x100e_ee98, 2); jmpd(0x100e_eed0, 0x36); goto l_0x100e_eed0; /* jmp 0x100eeed0 */
        l_0x100e_ee9a:
            ii(0x100e_ee9a, 2); jmpd(0x100e_eed0, 0x34); goto l_0x100e_eed0; /* jmp 0x100eeed0 */
        l_0x100e_ee9c:
            ii(0x100e_ee9c, 7); cmp(memd_a32[ss, ebp - 0xc8], 0x1b);    /* cmp dword [ebp-0xc8], 0x1b */
            ii(0x100e_eea3, 2); if(jbd(0x100e_eec1, 0x1c)) goto l_0x100e_eec1; /* jb 0x100eeec1 */
            ii(0x100e_eea5, 7); cmp(memd_a32[ss, ebp - 0xc8], 0x1b);    /* cmp dword [ebp-0xc8], 0x1b */
            ii(0x100e_eeac, 6); if(jbed(0x100e_ede3, -0xcf)) goto l_0x100e_ede3; /* jbe 0x100eede3 */
            ii(0x100e_eeb2, 7); cmp(memd_a32[ss, ebp - 0xc8], 0x20);    /* cmp dword [ebp-0xc8], 0x20 */
            ii(0x100e_eeb9, 6); if(jzd(0x100e_edef, -0xd0)) goto l_0x100e_edef; /* jz 0x100eedef */
            ii(0x100e_eebf, 2); jmpd(0x100e_ee9a, -0x27); goto l_0x100e_ee9a; /* jmp 0x100eee9a */
        l_0x100e_eec1:
            ii(0x100e_eec1, 7); cmp(memd_a32[ss, ebp - 0xc8], 0xd);     /* cmp dword [ebp-0xc8], 0xd */
            ii(0x100e_eec8, 6); if(jzd(0x100e_ede3, -0xeb)) goto l_0x100e_ede3; /* jz 0x100eede3 */
            ii(0x100e_eece, 2); jmpd(0x100e_ee9a, -0x36); goto l_0x100e_ee9a; /* jmp 0x100eee9a */
        l_0x100e_eed0:
            ii(0x100e_eed0, 7); cmp(memb_a32[ss, ebp - 0xc0], 0);       /* cmp byte [ebp-0xc0], 0x0 */
            ii(0x100e_eed7, 6); if(jzd(0x100e_edd3, -0x10a)) goto l_0x100e_edd3; /* jz 0x100eedd3 */
            ii(0x100e_eedd, 6); mov(eax, memd_a32[ss, ebp - 0xac]);     /* mov eax, [ebp-0xac] */
            ii(0x100e_eee3, 6); mov(memd_a32[ss, ebp - 0xcc], eax);     /* mov [ebp-0xcc], eax */
            ii(0x100e_eee9, 7); cmp(memd_a32[ss, ebp - 0xcc], 0);       /* cmp dword [ebp-0xcc], 0x0 */
            ii(0x100e_eef0, 2); if(jzd(0x100e_ef0c, 0x1a)) goto l_0x100e_ef0c; /* jz 0x100eef0c */
            ii(0x100e_eef2, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_eef4, 6); mov(eax, memd_a32[ss, ebp - 0xcc]);     /* mov eax, [ebp-0xcc] */
            ii(0x100e_eefa, 5); calld(Definitions.my_dtor_d2, -0x2_09c7); /* call 0x100ce538 */
            ii(0x100e_eeff, 5); calld(Definitions.sys_delete, 0x7_7060); /* call 0x10165f64 */
            ii(0x100e_ef04, 6); mov(memd_a32[ss, ebp - 0xd0], eax);     /* mov [ebp-0xd0], eax */
            ii(0x100e_ef0a, 2); jmpd(0x100e_ef16, 0xa); goto l_0x100e_ef16; /* jmp 0x100eef16 */
        l_0x100e_ef0c:
            ii(0x100e_ef0c, 10); mov(memd_a32[ss, ebp - 0xd0], 0);      /* mov dword [ebp-0xd0], 0x0 */
        l_0x100e_ef16:
            ii(0x100e_ef16, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_ef18, 3); lea(eax, ebp - 0x6c);                   /* lea eax, [ebp-0x6c] */
            ii(0x100e_ef1b, 5); calld(0x100d_6999, -0x1_8587);          /* call 0x100d6999 */
            ii(0x100e_ef20, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100e_ef22, 3); mov(edx, memd_a32[ss, ebp - 0x34]);     /* mov edx, [ebp-0x34] */
            ii(0x100e_ef25, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100e_ef27, 5); calld(0x100f_39b4, 0x4a88);             /* call 0x100f39b4 */
            ii(0x100e_ef2c, 7); mov(memb_a32[ds, 0x101c_391e], 0x3);    /* mov byte [0x101c391e], 0x3 */
            ii(0x100e_ef33, 5); mov(eax, 0x3e);                         /* mov eax, 0x3e */
            ii(0x100e_ef38, 5); calld(0x1007_5fdc, -0x7_8f61);          /* call 0x10075fdc */
            ii(0x100e_ef3d, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x100e_ef40, 2); if(jnzd(0x100e_ef48, 0x6)) goto l_0x100e_ef48; /* jnz 0x100eef48 */
            ii(0x100e_ef42, 4); cmp(memb_a32[ss, ebp - 0x18], 0);       /* cmp byte [ebp-0x18], 0x0 */
            ii(0x100e_ef46, 2); if(jnzd(0x100e_ef4a, 0x2)) goto l_0x100e_ef4a; /* jnz 0x100eef4a */
        l_0x100e_ef48:
            ii(0x100e_ef48, 2); jmpd(0x100e_ef95, 0x4b); goto l_0x100e_ef95; /* jmp 0x100eef95 */
        l_0x100e_ef4a:
            ii(0x100e_ef4a, 6); mov(edx, memd_a32[ds, 0x101c_3980]);    /* mov edx, [0x101c3980] */
            ii(0x100e_ef50, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100e_ef53, 1); inc(edx);                               /* inc edx */
            ii(0x100e_ef54, 5); mov(eax, 0x3d);                         /* mov eax, 0x3d */
            ii(0x100e_ef59, 5); calld(0x100c_aafc, -0x2_4462);          /* call 0x100caafc */
            ii(0x100e_ef5e, 6); mov(edx, memd_a32[ds, 0x101c_3980]);    /* mov edx, [0x101c3980] */
            ii(0x100e_ef64, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100e_ef67, 5); mov(eax, 0x41);                         /* mov eax, 0x41 */
            ii(0x100e_ef6c, 5); calld(0x1007_5fdc, -0x7_8f95);          /* call 0x10075fdc */
            ii(0x100e_ef71, 1); inc(edx);                               /* inc edx */
            ii(0x100e_ef72, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100e_ef74, 2); if(jled(0x100e_ef8b, 0x15)) goto l_0x100e_ef8b; /* jle 0x100eef8b */
            ii(0x100e_ef76, 5); mov(eax, memd_a32[ds, 0x101c_3980]);    /* mov eax, [0x101c3980] */
            ii(0x100e_ef7b, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100e_ef7e, 3); lea(edx, eax + 0x1);                    /* lea edx, [eax+0x1] */
            ii(0x100e_ef81, 5); mov(eax, 0x41);                         /* mov eax, 0x41 */
            ii(0x100e_ef86, 5); calld(0x100c_aafc, -0x2_448f);          /* call 0x100caafc */
        l_0x100e_ef8b:
            ii(0x100e_ef8b, 5); mov(eax, 0x101c_39c8);                  /* mov eax, 0x101c39c8 */
            ii(0x100e_ef90, 5); calld(0x1010_6084, 0x1_70ef);           /* call 0x10106084 */
        l_0x100e_ef95:
            ii(0x100e_ef95, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_ef97, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x100e_ef9a, 5); calld(Definitions.my_string_dtor, 0x5_2b8b); /* call 0x10141b2a */
            ii(0x100e_ef9f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_efa1, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_efa2, 1); popd(edi);                              /* pop edi */
            ii(0x100e_efa3, 1); popd(esi);                              /* pop esi */
            ii(0x100e_efa4, 1); retd(); return;                         /* ret */
        }
    }
}
