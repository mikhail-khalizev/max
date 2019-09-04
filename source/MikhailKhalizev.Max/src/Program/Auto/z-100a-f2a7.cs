using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_f2a7-4b8b6c5f")]
        public void Method_100a_f2a7()
        {
            ii(0x100a_f2a7, 5); push(0x80);                             /* push 0x80 */
            ii(0x100a_f2ac, 5); call(Definitions.sys_check_available_stack_size, 0xb_6aa1); /* call 0x10165d52 */
            ii(0x100a_f2b1, 1); push(esi);                              /* push esi */
            ii(0x100a_f2b2, 1); push(edi);                              /* push edi */
            ii(0x100a_f2b3, 1); push(ebp);                              /* push ebp */
            ii(0x100a_f2b4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_f2b6, 6); sub(esp, 0x6c);                         /* sub esp, 0x6c */
            ii(0x100a_f2bc, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x100a_f2bf, 3); mov(memd[ss, ebp - 12], edx);           /* mov [ebp-0xc], edx */
            ii(0x100a_f2c2, 3); mov(memd[ss, ebp - 8], ebx);            /* mov [ebp-0x8], ebx */
            ii(0x100a_f2c5, 3); mov(memd[ss, ebp - 4], ecx);            /* mov [ebp-0x4], ecx */
            ii(0x100a_f2c8, 3); mov(edx, memd[ss, ebp - 16]);           /* mov edx, [ebp-0x10] */
            ii(0x100a_f2cb, 3); lea(eax, memd[ss, ebp - 24]);           /* lea eax, [ebp-0x18] */
            ii(0x100a_f2ce, 5); call(0x1008_a5f0, -0x2_4ce3);           /* call 0x1008a5f0 */
            ii(0x100a_f2d3, 4); or(memb[ss, ebp - 20], 1);              /* or byte [ebp-0x14], 0x1 */
            ii(0x100a_f2d7, 3); lea(eax, memd[ss, ebp - 28]);           /* lea eax, [ebp-0x1c] */
            ii(0x100a_f2da, 5); call(Definitions.my_ctor_0x101b_3b58, -0x2_423b); /* call 0x1008b0a4 */
            ii(0x100a_f2df, 3); mov(memd[ss, ebp - 32], eax);           /* mov [ebp-0x20], eax */
            ii(0x100a_f2e2, 4); and(memb[ss, ebp - 20], -2 /* 0xfe */); /* and byte [ebp-0x14], 0xfe */
            ii(0x100a_f2e6, 3); lea(edx, memd[ss, ebp - 24]);           /* lea edx, [ebp-0x18] */
            ii(0x100a_f2e9, 3); lea(eax, memd[ss, ebp - 24]);           /* lea eax, [ebp-0x18] */
            ii(0x100a_f2ec, 5); call(0x1008_a520, -0x2_4dd1);           /* call 0x1008a520 */
            ii(0x100a_f2f1, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_f2f4, 5); call(0x1007_6574, -0x3_8d85);           /* call 0x10076574 */
            ii(0x100a_f2f9, 5); call(0x1015_26ac, 0xa_33ae);            /* call 0x101526ac */
            ii(0x100a_f2fe, 5); call(0x1008_b4b4, -0x2_3e4f);           /* call 0x1008b4b4 */
            ii(0x100a_f303, 2); test(al, al);                           /* test al, al */
            ii(0x100a_f305, 2); if(jz(0x100a_f320, 0x19)) goto l_0x100a_f320; /* jz 0x100af320 */
            ii(0x100a_f307, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_f309, 3); lea(eax, memd[ss, ebp - 28]);           /* lea eax, [ebp-0x1c] */
            ii(0x100a_f30c, 5); call(0x1008_8b7c, -0x2_6795);           /* call 0x10088b7c */
            ii(0x100a_f311, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_f313, 3); lea(eax, memd[ss, ebp - 24]);           /* lea eax, [ebp-0x18] */
            ii(0x100a_f316, 5); call(0x1008_8d4c, -0x2_65cf);           /* call 0x10088d4c */
            ii(0x100a_f31b, 5); jmp(0x100a_f57f, 0x25f); goto l_0x100a_f57f; /* jmp 0x100af57f */
        l_0x100a_f320:
            ii(0x100a_f320, 4); cmp(memd[ss, ebp - 4], 0);              /* cmp dword [ebp-0x4], 0x0 */
            ii(0x100a_f324, 6); if(jnz(0x100a_f449, 0x11f)) goto l_0x100a_f449; /* jnz 0x100af449 */
            ii(0x100a_f32a, 5); mov(eax, 0x20);                         /* mov eax, 0x20 */
            ii(0x100a_f32f, 5); call(Definitions.sys_new, 0xb_6acc);    /* call 0x10165e00 */
            ii(0x100a_f334, 3); mov(memd[ss, ebp - 36], eax);           /* mov [ebp-0x24], eax */
            ii(0x100a_f337, 3); mov(eax, memd[ss, ebp - 36]);           /* mov eax, [ebp-0x24] */
            ii(0x100a_f33a, 3); mov(memd[ss, ebp - 40], eax);           /* mov [ebp-0x28], eax */
            ii(0x100a_f33d, 4); cmp(memd[ss, ebp - 40], 0);             /* cmp dword [ebp-0x28], 0x0 */
            ii(0x100a_f341, 2); if(jz(0x100a_f382, 0x3f)) goto l_0x100a_f382; /* jz 0x100af382 */
            ii(0x100a_f343, 3); lea(eax, memd[ss, ebp - 24]);           /* lea eax, [ebp-0x18] */
            ii(0x100a_f346, 5); call(0x1008_a520, -0x2_4e2b);           /* call 0x1008a520 */
            ii(0x100a_f34b, 3); lea(edx, memd[ds, eax + 26]);           /* lea edx, [eax+0x1a] */
            ii(0x100a_f34e, 3); lea(eax, memd[ss, ebp - 44]);           /* lea eax, [ebp-0x2c] */
            ii(0x100a_f351, 5); call(0x1007_5e64, -0x3_94f2);           /* call 0x10075e64 */
            ii(0x100a_f356, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x100a_f358, 5); mov(ebx, 1);                            /* mov ebx, 0x1 */
            ii(0x100a_f35d, 3); lea(eax, memd[ss, ebp - 24]);           /* lea eax, [ebp-0x18] */
            ii(0x100a_f360, 5); call(0x1008_a520, -0x2_4e45);           /* call 0x1008a520 */
            ii(0x100a_f365, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_f368, 5); call(0x1007_65d0, -0x3_8d9d);           /* call 0x100765d0 */
            ii(0x100a_f36d, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_f36f, 3); mov(eax, memd[ss, ebp - 36]);           /* mov eax, [ebp-0x24] */
            ii(0x100a_f372, 5); call(0x100a_beeb, -0x348c);             /* call 0x100abeeb */
            ii(0x100a_f377, 3); mov(memd[ss, ebp - 48], eax);           /* mov [ebp-0x30], eax */
            ii(0x100a_f37a, 3); mov(eax, memd[ss, ebp - 48]);           /* mov eax, [ebp-0x30] */
            ii(0x100a_f37d, 3); mov(memd[ss, ebp - 52], eax);           /* mov [ebp-0x34], eax */
            ii(0x100a_f380, 2); jmp(0x100a_f388, 6); goto l_0x100a_f388; /* jmp 0x100af388 */
        l_0x100a_f382:
            ii(0x100a_f382, 3); mov(eax, memd[ss, ebp - 40]);           /* mov eax, [ebp-0x28] */
            ii(0x100a_f385, 3); mov(memd[ss, ebp - 52], eax);           /* mov [ebp-0x34], eax */
        l_0x100a_f388:
            ii(0x100a_f388, 3); mov(eax, memd[ss, ebp - 52]);           /* mov eax, [ebp-0x34] */
            ii(0x100a_f38b, 3); mov(memd[ss, ebp - 56], eax);           /* mov [ebp-0x38], eax */
            ii(0x100a_f38e, 3); lea(eax, memd[ss, ebp - 24]);           /* lea eax, [ebp-0x18] */
            ii(0x100a_f391, 5); call(0x1008_a520, -0x2_4e76);           /* call 0x1008a520 */
            ii(0x100a_f396, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_f399, 5); call(0x1007_6574, -0x3_8e2a);           /* call 0x10076574 */
            ii(0x100a_f39e, 3); mov(al, memb[ds, eax + 78]);            /* mov al, [eax+0x4e] */
            ii(0x100a_f3a1, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x100a_f3a3, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x100a_f3a6, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100a_f3a9, 3); mov(eax, memd[ss, ebp - 56]);           /* mov eax, [ebp-0x38] */
            ii(0x100a_f3ac, 5); call(0x1011_d8ba, 0x6_e509);            /* call 0x1011d8ba */
            ii(0x100a_f3b1, 3); lea(eax, memd[ss, ebp - 24]);           /* lea eax, [ebp-0x18] */
            ii(0x100a_f3b4, 5); call(0x1008_a520, -0x2_4e99);           /* call 0x1008a520 */
            ii(0x100a_f3b9, 3); mov(edx, memd[ds, eax + 22]);           /* mov edx, [eax+0x16] */
            ii(0x100a_f3bc, 3); sar(edx, 0x18);                         /* sar edx, 0x18 */
            ii(0x100a_f3bf, 3); mov(eax, memd[ss, ebp - 56]);           /* mov eax, [ebp-0x38] */
            ii(0x100a_f3c2, 5); call(0x1011_d801, 0x6_e43a);            /* call 0x1011d801 */
            ii(0x100a_f3c7, 5); mov(eax, 0x1f);                         /* mov eax, 0x1f */
            ii(0x100a_f3cc, 5); call(Definitions.sys_new, 0xb_6a2f);    /* call 0x10165e00 */
            ii(0x100a_f3d1, 3); mov(memd[ss, ebp - 60], eax);           /* mov [ebp-0x3c], eax */
            ii(0x100a_f3d4, 3); mov(eax, memd[ss, ebp - 60]);           /* mov eax, [ebp-0x3c] */
            ii(0x100a_f3d7, 3); mov(memd[ss, ebp - 64], eax);           /* mov [ebp-0x40], eax */
            ii(0x100a_f3da, 4); cmp(memd[ss, ebp - 64], 0);             /* cmp dword [ebp-0x40], 0x0 */
            ii(0x100a_f3de, 2); if(jz(0x100a_f40b, 0x2b)) goto l_0x100a_f40b; /* jz 0x100af40b */
            ii(0x100a_f3e0, 5); mov(eax, 0x100a_d995);                  /* mov eax, 0x100ad995 */
            ii(0x100a_f3e5, 1); push(eax);                              /* push eax */
            ii(0x100a_f3e6, 5); mov(ecx, 0x100a_f587);                  /* mov ecx, 0x100af587 */
            ii(0x100a_f3eb, 3); mov(ebx, memd[ss, ebp - 56]);           /* mov ebx, [ebp-0x38] */
            ii(0x100a_f3ee, 3); lea(eax, memd[ss, ebp - 24]);           /* lea eax, [ebp-0x18] */
            ii(0x100a_f3f1, 5); call(0x1008_a57c, -0x2_4e7a);           /* call 0x1008a57c */
            ii(0x100a_f3f6, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_f3f8, 3); mov(eax, memd[ss, ebp - 60]);           /* mov eax, [ebp-0x3c] */
            ii(0x100a_f3fb, 5); call(0x100a_ba72, -0x398e);             /* call 0x100aba72 */
            ii(0x100a_f400, 3); mov(memd[ss, ebp - 68], eax);           /* mov [ebp-0x44], eax */
            ii(0x100a_f403, 3); mov(eax, memd[ss, ebp - 68]);           /* mov eax, [ebp-0x44] */
            ii(0x100a_f406, 3); mov(memd[ss, ebp - 72], eax);           /* mov [ebp-0x48], eax */
            ii(0x100a_f409, 2); jmp(0x100a_f411, 6); goto l_0x100a_f411; /* jmp 0x100af411 */
        l_0x100a_f40b:
            ii(0x100a_f40b, 3); mov(eax, memd[ss, ebp - 64]);           /* mov eax, [ebp-0x40] */
            ii(0x100a_f40e, 3); mov(memd[ss, ebp - 72], eax);           /* mov [ebp-0x48], eax */
        l_0x100a_f411:
            ii(0x100a_f411, 3); mov(edx, memd[ss, ebp - 72]);           /* mov edx, [ebp-0x48] */
            ii(0x100a_f414, 3); lea(eax, memd[ss, ebp - 28]);           /* lea eax, [ebp-0x1c] */
            ii(0x100a_f417, 5); call(0x1008_afe4, -0x2_4438);           /* call 0x1008afe4 */
            ii(0x100a_f41c, 3); lea(eax, memd[ss, ebp - 28]);           /* lea eax, [ebp-0x1c] */
            ii(0x100a_f41f, 5); call(0x1008_af84, -0x2_44a0);           /* call 0x1008af84 */
            ii(0x100a_f424, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_f426, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100a_f42b, 5); call(0x100a_4d50, -0xa6e0);             /* call 0x100a4d50 */
            ii(0x100a_f430, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_f432, 3); lea(eax, memd[ss, ebp - 28]);           /* lea eax, [ebp-0x1c] */
            ii(0x100a_f435, 5); call(0x1008_8b7c, -0x2_68be);           /* call 0x10088b7c */
            ii(0x100a_f43a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_f43c, 3); lea(eax, memd[ss, ebp - 24]);           /* lea eax, [ebp-0x18] */
            ii(0x100a_f43f, 5); call(0x1008_8d4c, -0x2_66f8);           /* call 0x10088d4c */
            ii(0x100a_f444, 5); jmp(0x100a_f57f, 0x136); goto l_0x100a_f57f; /* jmp 0x100af57f */
        l_0x100a_f449:
            ii(0x100a_f449, 3); lea(eax, memd[ss, ebp - 24]);           /* lea eax, [ebp-0x18] */
            ii(0x100a_f44c, 5); call(0x1008_a520, -0x2_4f31);           /* call 0x1008a520 */
            ii(0x100a_f451, 4); cmp(memb[ds, eax + 25], 0);             /* cmp byte [eax+0x19], 0x0 */
            ii(0x100a_f455, 2); if(jle(0x100a_f46d, 0x16)) goto l_0x100a_f46d; /* jle 0x100af46d */
            ii(0x100a_f457, 3); lea(eax, memd[ss, ebp - 24]);           /* lea eax, [ebp-0x18] */
            ii(0x100a_f45a, 5); call(0x1008_a520, -0x2_4f3f);           /* call 0x1008a520 */
            ii(0x100a_f45f, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_f462, 5); call(0x1007_6574, -0x3_8ef3);           /* call 0x10076574 */
            ii(0x100a_f467, 4); test(memb[ds, eax + 18], 0x40);         /* test byte [eax+0x12], 0x40 */
            ii(0x100a_f46b, 2); if(jnz(0x100a_f472, 5)) goto l_0x100a_f472; /* jnz 0x100af472 */
        l_0x100a_f46d:
            ii(0x100a_f46d, 5); jmp(0x100a_f55b, 0xe9); goto l_0x100a_f55b; /* jmp 0x100af55b */
        l_0x100a_f472:
            ii(0x100a_f472, 5); mov(eax, 0x24);                         /* mov eax, 0x24 */
            ii(0x100a_f477, 5); call(Definitions.sys_new, 0xb_6984);    /* call 0x10165e00 */
            ii(0x100a_f47c, 3); mov(memd[ss, ebp - 76], eax);           /* mov [ebp-0x4c], eax */
            ii(0x100a_f47f, 3); mov(eax, memd[ss, ebp - 76]);           /* mov eax, [ebp-0x4c] */
            ii(0x100a_f482, 3); mov(memd[ss, ebp - 80], eax);           /* mov [ebp-0x50], eax */
            ii(0x100a_f485, 4); cmp(memd[ss, ebp - 80], 0);             /* cmp dword [ebp-0x50], 0x0 */
            ii(0x100a_f489, 2); if(jz(0x100a_f4d0, 0x45)) goto l_0x100a_f4d0; /* jz 0x100af4d0 */
            ii(0x100a_f48b, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_f48e, 1); push(eax);                              /* push eax */
            ii(0x100a_f48f, 3); lea(eax, memd[ss, ebp - 24]);           /* lea eax, [ebp-0x18] */
            ii(0x100a_f492, 5); call(0x1008_a520, -0x2_4f77);           /* call 0x1008a520 */
            ii(0x100a_f497, 3); lea(edx, memd[ds, eax + 26]);           /* lea edx, [eax+0x1a] */
            ii(0x100a_f49a, 3); lea(eax, memd[ss, ebp - 84]);           /* lea eax, [ebp-0x54] */
            ii(0x100a_f49d, 5); call(0x1007_5e64, -0x3_963e);           /* call 0x10075e64 */
            ii(0x100a_f4a2, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x100a_f4a4, 5); mov(ebx, 2);                            /* mov ebx, 0x2 */
            ii(0x100a_f4a9, 3); lea(eax, memd[ss, ebp - 24]);           /* lea eax, [ebp-0x18] */
            ii(0x100a_f4ac, 5); call(0x1008_a520, -0x2_4f91);           /* call 0x1008a520 */
            ii(0x100a_f4b1, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_f4b4, 5); call(0x1007_65d0, -0x3_8ee9);           /* call 0x100765d0 */
            ii(0x100a_f4b9, 3); mov(esi, memd[ss, ebp - 76]);           /* mov esi, [ebp-0x4c] */
            ii(0x100a_f4bc, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_f4be, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x100a_f4c0, 5); call(0x100a_c198, -0x332d);             /* call 0x100ac198 */
            ii(0x100a_f4c5, 3); mov(memd[ss, ebp - 88], eax);           /* mov [ebp-0x58], eax */
            ii(0x100a_f4c8, 3); mov(eax, memd[ss, ebp - 88]);           /* mov eax, [ebp-0x58] */
            ii(0x100a_f4cb, 3); mov(memd[ss, ebp - 92], eax);           /* mov [ebp-0x5c], eax */
            ii(0x100a_f4ce, 2); jmp(0x100a_f4d6, 6); goto l_0x100a_f4d6; /* jmp 0x100af4d6 */
        l_0x100a_f4d0:
            ii(0x100a_f4d0, 3); mov(eax, memd[ss, ebp - 80]);           /* mov eax, [ebp-0x50] */
            ii(0x100a_f4d3, 3); mov(memd[ss, ebp - 92], eax);           /* mov [ebp-0x5c], eax */
        l_0x100a_f4d6:
            ii(0x100a_f4d6, 3); mov(eax, memd[ss, ebp - 92]);           /* mov eax, [ebp-0x5c] */
            ii(0x100a_f4d9, 3); mov(memd[ss, ebp - 56], eax);           /* mov [ebp-0x38], eax */
            ii(0x100a_f4dc, 5); mov(eax, 0x1f);                         /* mov eax, 0x1f */
            ii(0x100a_f4e1, 5); call(Definitions.sys_new, 0xb_691a);    /* call 0x10165e00 */
            ii(0x100a_f4e6, 3); mov(memd[ss, ebp - 96], eax);           /* mov [ebp-0x60], eax */
            ii(0x100a_f4e9, 3); mov(eax, memd[ss, ebp - 96]);           /* mov eax, [ebp-0x60] */
            ii(0x100a_f4ec, 3); mov(memd[ss, ebp - 100], eax);          /* mov [ebp-0x64], eax */
            ii(0x100a_f4ef, 4); cmp(memd[ss, ebp - 100], 0);            /* cmp dword [ebp-0x64], 0x0 */
            ii(0x100a_f4f3, 2); if(jz(0x100a_f520, 0x2b)) goto l_0x100a_f520; /* jz 0x100af520 */
            ii(0x100a_f4f5, 5); mov(eax, 0x100a_d995);                  /* mov eax, 0x100ad995 */
            ii(0x100a_f4fa, 1); push(eax);                              /* push eax */
            ii(0x100a_f4fb, 5); mov(ecx, 0x100a_f8d5);                  /* mov ecx, 0x100af8d5 */
            ii(0x100a_f500, 3); mov(ebx, memd[ss, ebp - 56]);           /* mov ebx, [ebp-0x38] */
            ii(0x100a_f503, 3); lea(eax, memd[ss, ebp - 24]);           /* lea eax, [ebp-0x18] */
            ii(0x100a_f506, 5); call(0x1008_a57c, -0x2_4f8f);           /* call 0x1008a57c */
            ii(0x100a_f50b, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_f50d, 3); mov(eax, memd[ss, ebp - 96]);           /* mov eax, [ebp-0x60] */
            ii(0x100a_f510, 5); call(0x100a_ba72, -0x3aa3);             /* call 0x100aba72 */
            ii(0x100a_f515, 3); mov(memd[ss, ebp - 104], eax);          /* mov [ebp-0x68], eax */
            ii(0x100a_f518, 3); mov(eax, memd[ss, ebp - 104]);          /* mov eax, [ebp-0x68] */
            ii(0x100a_f51b, 3); mov(memd[ss, ebp - 108], eax);          /* mov [ebp-0x6c], eax */
            ii(0x100a_f51e, 2); jmp(0x100a_f526, 6); goto l_0x100a_f526; /* jmp 0x100af526 */
        l_0x100a_f520:
            ii(0x100a_f520, 3); mov(eax, memd[ss, ebp - 100]);          /* mov eax, [ebp-0x64] */
            ii(0x100a_f523, 3); mov(memd[ss, ebp - 108], eax);          /* mov [ebp-0x6c], eax */
        l_0x100a_f526:
            ii(0x100a_f526, 3); mov(edx, memd[ss, ebp - 108]);          /* mov edx, [ebp-0x6c] */
            ii(0x100a_f529, 3); lea(eax, memd[ss, ebp - 28]);           /* lea eax, [ebp-0x1c] */
            ii(0x100a_f52c, 5); call(0x1008_afe4, -0x2_454d);           /* call 0x1008afe4 */
            ii(0x100a_f531, 3); lea(eax, memd[ss, ebp - 28]);           /* lea eax, [ebp-0x1c] */
            ii(0x100a_f534, 5); call(0x1008_af84, -0x2_45b5);           /* call 0x1008af84 */
            ii(0x100a_f539, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_f53b, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100a_f540, 5); call(0x100a_4d50, -0xa7f5);             /* call 0x100a4d50 */
            ii(0x100a_f545, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_f547, 3); lea(eax, memd[ss, ebp - 28]);           /* lea eax, [ebp-0x1c] */
            ii(0x100a_f54a, 5); call(0x1008_8b7c, -0x2_69d3);           /* call 0x10088b7c */
            ii(0x100a_f54f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_f551, 3); lea(eax, memd[ss, ebp - 24]);           /* lea eax, [ebp-0x18] */
            ii(0x100a_f554, 5); call(0x1008_8d4c, -0x2_680d);           /* call 0x10088d4c */
            ii(0x100a_f559, 2); jmp(0x100a_f57f, 0x24); goto l_0x100a_f57f; /* jmp 0x100af57f */
        l_0x100a_f55b:
            ii(0x100a_f55b, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100a_f55e, 3); lea(eax, memd[ss, ebp - 24]);           /* lea eax, [ebp-0x18] */
            ii(0x100a_f561, 5); call(0x1008_a520, -0x2_5046);           /* call 0x1008a520 */
            ii(0x100a_f566, 5); call(0x100a_fbb7, 0x64c);               /* call 0x100afbb7 */
            ii(0x100a_f56b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_f56d, 3); lea(eax, memd[ss, ebp - 28]);           /* lea eax, [ebp-0x1c] */
            ii(0x100a_f570, 5); call(0x1008_8b7c, -0x2_69f9);           /* call 0x10088b7c */
            ii(0x100a_f575, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_f577, 3); lea(eax, memd[ss, ebp - 24]);           /* lea eax, [ebp-0x18] */
            ii(0x100a_f57a, 5); call(0x1008_8d4c, -0x2_6833);           /* call 0x10088d4c */
        l_0x100a_f57f:
            ii(0x100a_f57f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_f581, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_f582, 1); pop(edi);                               /* pop edi */
            ii(0x100a_f583, 1); pop(esi);                               /* pop esi */
            ii(0x100a_f584, 3); ret(4);                                 /* ret 0x4 */
        }
    }
}
