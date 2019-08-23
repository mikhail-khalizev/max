using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_3ed0-b689313a")]
        public void Method_100b_3ed0()
        {
            ii(0x100b_3ed0, 5); pushd(0x60);                            /* push 0x60 */
            ii(0x100b_3ed5, 5); calld(Definitions.sys_check_available_stack_size, 0xb_1e78); /* call 0x10165d52 */
            ii(0x100b_3eda, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_3edb, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_3edc, 1); pushd(edx);                             /* push edx */
            ii(0x100b_3edd, 1); pushd(esi);                             /* push esi */
            ii(0x100b_3ede, 1); pushd(edi);                             /* push edi */
            ii(0x100b_3edf, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_3ee0, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_3ee2, 6); sub(esp, 0x40);                         /* sub esp, 0x40 */
            ii(0x100b_3ee8, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100b_3eeb, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_3eed, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_3ef0, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_3ef3, 5); calld(0x1013_ad11, 0x8_6e19);           /* call 0x1013ad11 */
            ii(0x100b_3ef8, 2); test(al, al);                           /* test al, al */
            ii(0x100b_3efa, 6); if(jnzd(0x100b_43a7, 0x4a7)) goto l_0x100b_43a7; /* jnz 0x100b43a7 */
            ii(0x100b_3f00, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100b_3f02, 5); mov(al, memb_a32[ds, 0x101c_37c9]);     /* mov al, [0x101c37c9] */
            ii(0x100b_3f07, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_3f09, 2); if(jnzd(0x100b_3f20, 0x15)) goto l_0x100b_3f20; /* jnz 0x100b3f20 */
            ii(0x100b_3f0b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_3f0e, 3); mov(eax, memd_a32[ds, eax + 0x7]);      /* mov eax, [eax+0x7] */
            ii(0x100b_3f11, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100b_3f14, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_3f16, 6); mov(dl, memb_a32[ds, 0x101c_37c8]);     /* mov dl, [0x101c37c8] */
            ii(0x100b_3f1c, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100b_3f1e, 2); if(jnzd(0x100b_3f22, 0x2)) goto l_0x100b_3f22; /* jnz 0x100b3f22 */
        l_0x100b_3f20:
            ii(0x100b_3f20, 2); jmpd(0x100b_3f27, 0x5); goto l_0x100b_3f27; /* jmp 0x100b3f27 */
        l_0x100b_3f22:
            ii(0x100b_3f22, 5); jmpd(0x100b_43a7, 0x480); goto l_0x100b_43a7; /* jmp 0x100b43a7 */
        l_0x100b_3f27:
            ii(0x100b_3f27, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100b_3f29, 5); mov(al, memb_a32[ds, 0x101c_37c9]);     /* mov al, [0x101c37c9] */
            ii(0x100b_3f2e, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x100b_3f31, 6); if(jzd(0x100b_43a7, 0x470)) goto l_0x100b_43a7; /* jz 0x100b43a7 */
            ii(0x100b_3f37, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_3f3a, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_3f3d, 5); calld(0x1007_6574, -0x3_d9ce);          /* call 0x10076574 */
            ii(0x100b_3f42, 5); calld(0x1015_26ac, 0x9_e765);           /* call 0x101526ac */
            ii(0x100b_3f47, 3); cmp(eax, memd_a32[ss, ebp - 0x4]);      /* cmp eax, [ebp-0x4] */
            ii(0x100b_3f4a, 2); if(jnzd(0x100b_3f5d, 0x11)) goto l_0x100b_3f5d; /* jnz 0x100b3f5d */
            ii(0x100b_3f4c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_3f4e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_3f51, 3); add(eax, 0x1b);                         /* add eax, 0x1b */
            ii(0x100b_3f54, 5); calld(0x1013_ad71, 0x8_6e18);           /* call 0x1013ad71 */
            ii(0x100b_3f59, 2); test(al, al);                           /* test al, al */
            ii(0x100b_3f5b, 2); if(jzd(0x100b_3f62, 0x5)) goto l_0x100b_3f62; /* jz 0x100b3f62 */
        l_0x100b_3f5d:
            ii(0x100b_3f5d, 5); jmpd(0x100b_43a7, 0x445); goto l_0x100b_43a7; /* jmp 0x100b43a7 */
        l_0x100b_3f62:
            ii(0x100b_3f62, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_3f65, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_3f68, 5); calld(0x1007_6574, -0x3_d9f9);          /* call 0x10076574 */
            ii(0x100b_3f6d, 4); cmp(memb_a32[ds, eax + 0x3d], 0x10);    /* cmp byte [eax+0x3d], 0x10 */
            ii(0x100b_3f71, 2); if(jzd(0x100b_3f84, 0x11)) goto l_0x100b_3f84; /* jz 0x100b3f84 */
            ii(0x100b_3f73, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_3f76, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_3f79, 5); calld(0x1007_6574, -0x3_da0a);          /* call 0x10076574 */
            ii(0x100b_3f7e, 4); cmp(memb_a32[ds, eax + 0x3d], 0x4);     /* cmp byte [eax+0x3d], 0x4 */
            ii(0x100b_3f82, 2); if(jnzd(0x100b_3f86, 0x2)) goto l_0x100b_3f86; /* jnz 0x100b3f86 */
        l_0x100b_3f84:
            ii(0x100b_3f84, 2); jmpd(0x100b_3f97, 0x11); goto l_0x100b_3f97; /* jmp 0x100b3f97 */
        l_0x100b_3f86:
            ii(0x100b_3f86, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_3f89, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_3f8c, 5); calld(0x1007_6574, -0x3_da1d);          /* call 0x10076574 */
            ii(0x100b_3f91, 4); cmp(memb_a32[ds, eax + 0x3d], 0);       /* cmp byte [eax+0x3d], 0x0 */
            ii(0x100b_3f95, 2); if(jnzd(0x100b_3f99, 0x2)) goto l_0x100b_3f99; /* jnz 0x100b3f99 */
        l_0x100b_3f97:
            ii(0x100b_3f97, 2); jmpd(0x100b_3f9e, 0x5); goto l_0x100b_3f9e; /* jmp 0x100b3f9e */
        l_0x100b_3f99:
            ii(0x100b_3f99, 5); jmpd(0x100b_43a7, 0x409); goto l_0x100b_43a7; /* jmp 0x100b43a7 */
        l_0x100b_3f9e:
            ii(0x100b_3f9e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_3fa0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_3fa3, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100b_3fa6, 5); calld(0x1013_ad11, 0x8_6d66);           /* call 0x1013ad11 */
            ii(0x100b_3fab, 2); test(al, al);                           /* test al, al */
            ii(0x100b_3fad, 6); if(jnzd(0x100b_43a7, 0x3f4)) goto l_0x100b_43a7; /* jnz 0x100b43a7 */
            ii(0x100b_3fb3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_3fb6, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_3fb9, 5); calld(0x1007_6574, -0x3_da4a);          /* call 0x10076574 */
            ii(0x100b_3fbe, 4); cmp(memb_a32[ds, eax + 0x3d], 0);       /* cmp byte [eax+0x3d], 0x0 */
            ii(0x100b_3fc2, 2); if(jnzd(0x100b_4032, 0x6e)) goto l_0x100b_4032; /* jnz 0x100b4032 */
            ii(0x100b_3fc4, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100b_3fc6, 1); pushd(eax);                             /* push eax */
            ii(0x100b_3fc7, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x100b_3fc9, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100b_3fcb, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_3fcd, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100b_3fd0, 5); calld(0x1008_b148, -0x2_8e8d);          /* call 0x1008b148 */
            ii(0x100b_3fd5, 3); lea(edx, ebp - 0x24);                   /* lea edx, [ebp-0x24] */
            ii(0x100b_3fd8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_3fdb, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100b_3fde, 5); calld(0x1007_6574, -0x3_da6f);          /* call 0x10076574 */
            ii(0x100b_3fe3, 5); calld(0x1015_2532, 0x9_e54a);           /* call 0x10152532 */
            ii(0x100b_3fe8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_3feb, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_3fee, 5); calld(0x1007_6574, -0x3_da7f);          /* call 0x10076574 */
            ii(0x100b_3ff3, 3); mov(ebx, memd_a32[ds, eax + 0x1a]);     /* mov ebx, [eax+0x1a] */
            ii(0x100b_3ff6, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100b_3ff9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_3ffc, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_3fff, 5); calld(0x1007_6574, -0x3_da90);          /* call 0x10076574 */
            ii(0x100b_4004, 3); mov(edx, memd_a32[ds, eax + 0x18]);     /* mov edx, [eax+0x18] */
            ii(0x100b_4007, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100b_400a, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x100b_400d, 5); calld(0x1007_6aac, -0x3_d566);          /* call 0x10076aac */
            ii(0x100b_4012, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_4014, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100b_4017, 5); calld(0x1010_82ce, 0x5_42b2);           /* call 0x101082ce */
            ii(0x100b_401c, 2); test(al, al);                           /* test al, al */
            ii(0x100b_401e, 2); if(jnzd(0x100b_4032, 0x12)) goto l_0x100b_4032; /* jnz 0x100b4032 */
            ii(0x100b_4020, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100b_4025, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_4028, 5); calld(0x100a_28ff, -0x1_172e);          /* call 0x100a28ff */
            ii(0x100b_402d, 5); jmpd(0x100b_43a7, 0x375); goto l_0x100b_43a7; /* jmp 0x100b43a7 */
        l_0x100b_4032:
            ii(0x100b_4032, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100b_4035, 5); calld(Definitions.my_ctor_0x101b_4184, -0x3_d54a); /* call 0x10076af0 */
            ii(0x100b_403a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_403d, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_4040, 5); calld(0x1007_6574, -0x3_dad1);          /* call 0x10076574 */
            ii(0x100b_4045, 4); cmp(memb_a32[ds, eax + 0x3d], 0x10);    /* cmp byte [eax+0x3d], 0x10 */
            ii(0x100b_4049, 2); if(jnzd(0x100b_405c, 0x11)) goto l_0x100b_405c; /* jnz 0x100b405c */
            ii(0x100b_404b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_404e, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100b_4051, 5); calld(0x1007_6574, -0x3_dae2);          /* call 0x10076574 */
            ii(0x100b_4056, 4); cmp(memb_a32[ds, eax + 0x3d], 0x4);     /* cmp byte [eax+0x3d], 0x4 */
            ii(0x100b_405a, 2); if(jnzd(0x100b_405e, 0x2)) goto l_0x100b_405e; /* jnz 0x100b405e */
        l_0x100b_405c:
            ii(0x100b_405c, 2); jmpd(0x100b_406f, 0x11); goto l_0x100b_406f; /* jmp 0x100b406f */
        l_0x100b_405e:
            ii(0x100b_405e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_4061, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100b_4064, 5); calld(0x1007_6574, -0x3_daf5);          /* call 0x10076574 */
            ii(0x100b_4069, 4); cmp(memb_a32[ds, eax + 0x3d], 0);       /* cmp byte [eax+0x3d], 0x0 */
            ii(0x100b_406d, 2); if(jnzd(0x100b_4071, 0x2)) goto l_0x100b_4071; /* jnz 0x100b4071 */
        l_0x100b_406f:
            ii(0x100b_406f, 2); jmpd(0x100b_4076, 0x5); goto l_0x100b_4076; /* jmp 0x100b4076 */
        l_0x100b_4071:
            ii(0x100b_4071, 5); jmpd(0x100b_43a7, 0x331); goto l_0x100b_43a7; /* jmp 0x100b43a7 */
        l_0x100b_4076:
            ii(0x100b_4076, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_4079, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100b_407c, 5); calld(0x1007_6574, -0x3_db0d);          /* call 0x10076574 */
            ii(0x100b_4081, 4); mov(ax, memw_a32[ds, eax + 0x1a]);      /* mov ax, [eax+0x1a] */
            ii(0x100b_4085, 1); dec(eax);                               /* dec eax */
            ii(0x100b_4086, 4); mov(memw_a32[ss, ebp - 0x14], ax);      /* mov [ebp-0x14], ax */
            ii(0x100b_408a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_408d, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100b_4090, 5); calld(0x1007_6574, -0x3_db21);          /* call 0x10076574 */
            ii(0x100b_4095, 4); mov(ax, memw_a32[ds, eax + 0x1c]);      /* mov ax, [eax+0x1c] */
            ii(0x100b_4099, 4); mov(memw_a32[ss, ebp - 0x12], ax);      /* mov [ebp-0x12], ax */
            ii(0x100b_409d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_40a0, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100b_40a3, 5); calld(0x1007_6574, -0x3_db34);          /* call 0x10076574 */
            ii(0x100b_40a8, 4); test(memb_a32[ds, eax + 0x12], 0x10);   /* test byte [eax+0x12], 0x10 */
            ii(0x100b_40ac, 2); if(jzd(0x100b_40b7, 0x9)) goto l_0x100b_40b7; /* jz 0x100b40b7 */
            ii(0x100b_40ae, 7); mov(memd_a32[ss, ebp - 0x10], 0x2);     /* mov dword [ebp-0x10], 0x2 */
            ii(0x100b_40b5, 2); jmpd(0x100b_40be, 0x7); goto l_0x100b_40be; /* jmp 0x100b40be */
        l_0x100b_40b7:
            ii(0x100b_40b7, 7); mov(memd_a32[ss, ebp - 0x10], 0x1);     /* mov dword [ebp-0x10], 0x1 */
        l_0x100b_40be:
            ii(0x100b_40be, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100b_40c1, 4); add(memw_a32[ss, ebp - 0x12], ax);      /* add [ebp-0x12], ax */
            ii(0x100b_40c5, 7); mov(memd_a32[ss, ebp - 0xc], 0);        /* mov dword [ebp-0xc], 0x0 */
            ii(0x100b_40cc, 2); jmpd(0x100b_40d2, 0x4); goto l_0x100b_40d2; /* jmp 0x100b40d2 */
        l_0x100b_40ce:
            ii(0x100b_40ce, 4); add(memd_a32[ss, ebp - 0xc], 0x2);      /* add dword [ebp-0xc], 0x2 */
        l_0x100b_40d2:
            ii(0x100b_40d2, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x100b_40d6, 3); cmp(eax, 0x8);                          /* cmp eax, 0x8 */
            ii(0x100b_40d9, 6); if(jged(0x100b_4288, 0x1a9)) goto l_0x100b_4288; /* jge 0x100b4288 */
            ii(0x100b_40df, 7); mov(memd_a32[ss, ebp - 0x8], 0);        /* mov dword [ebp-0x8], 0x0 */
            ii(0x100b_40e6, 2); jmpd(0x100b_40ee, 0x6); goto l_0x100b_40ee; /* jmp 0x100b40ee */
        l_0x100b_40e8:
            ii(0x100b_40e8, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_40eb, 3); inc(memd_a32[ss, ebp - 0x8]);           /* inc dword [ebp-0x8] */
        l_0x100b_40ee:
            ii(0x100b_40ee, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x100b_40f2, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x100b_40f6, 1); inc(eax);                               /* inc eax */
            ii(0x100b_40f7, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100b_40f9, 6); if(jged(0x100b_4283, 0x184)) goto l_0x100b_4283; /* jge 0x100b4283 */
            ii(0x100b_40ff, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x100b_4103, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x100b_4106, 5); mov(eax, 0x101c_5348);                  /* mov eax, 0x101c5348 */
            ii(0x100b_410b, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100b_410d, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100b_4110, 5); calld(0x1008_b1a4, -0x2_8f71);          /* call 0x1008b1a4 */
            ii(0x100b_4115, 5); mov(eax, 0x2);                          /* mov eax, 0x2 */
            ii(0x100b_411a, 1); pushd(eax);                             /* push eax */
            ii(0x100b_411b, 4); movsx(ecx, memw_a32[ss, ebp - 0x12]);   /* movsx ecx, word [ebp-0x12] */
            ii(0x100b_411f, 4); movsx(ebx, memw_a32[ss, ebp - 0x14]);   /* movsx ebx, word [ebp-0x14] */
            ii(0x100b_4123, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_4126, 3); mov(edx, memd_a32[ds, eax + 0x7]);      /* mov edx, [eax+0x7] */
            ii(0x100b_4129, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100b_412c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_412f, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_4132, 5); calld(0x1007_6574, -0x3_dbc3);          /* call 0x10076574 */
            ii(0x100b_4137, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x100b_413a, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100b_413d, 5); calld(0x1007_02b9, -0x4_3e89);          /* call 0x100702b9 */
            ii(0x100b_4142, 3); test(ax, ax);                           /* test ax, ax */
            ii(0x100b_4145, 6); if(jzd(0x100b_427e, 0x133)) goto l_0x100b_427e; /* jz 0x100b427e */
            ii(0x100b_414b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_414e, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_4151, 5); calld(0x1007_6574, -0x3_dbe2);          /* call 0x10076574 */
            ii(0x100b_4156, 3); mov(al, memb_a32[ds, eax + 0x3d]);      /* mov al, [eax+0x3d] */
            ii(0x100b_4159, 3); mov(memb_a32[ss, ebp - 0x2c], al);      /* mov [ebp-0x2c], al */
            ii(0x100b_415c, 5); jmpd(0x100b_424f, 0xee); goto l_0x100b_424f; /* jmp 0x100b424f */
        l_0x100b_4161:
            ii(0x100b_4161, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_4164, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_4167, 5); calld(0x1007_6574, -0x3_dbf8);          /* call 0x10076574 */
            ii(0x100b_416c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_416e, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100b_4171, 4); mov(memw_a32[ds, edx + 0x41], ax);      /* mov [edx+0x41], ax */
            ii(0x100b_4175, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_4178, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_417b, 5); calld(0x1007_6574, -0x3_dc0c);          /* call 0x10076574 */
            ii(0x100b_4180, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_4182, 3); mov(eax, memd_a32[ss, ebp - 0x12]);     /* mov eax, [ebp-0x12] */
            ii(0x100b_4185, 4); mov(memw_a32[ds, edx + 0x43], ax);      /* mov [edx+0x43], ax */
            ii(0x100b_4189, 5); mov(ebx, 0x6);                          /* mov ebx, 0x6 */
            ii(0x100b_418e, 5); mov(edx, 0x5);                          /* mov edx, 0x5 */
            ii(0x100b_4193, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_4196, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_4199, 5); calld(0x1007_65d0, -0x3_dbce);          /* call 0x100765d0 */
            ii(0x100b_419e, 5); calld(0x1016_3053, 0xa_eeb0);           /* call 0x10163053 */
            ii(0x100b_41a3, 5); jmpd(0x100b_4279, 0xd1); goto l_0x100b_4279; /* jmp 0x100b4279 */
        l_0x100b_41a8:
            ii(0x100b_41a8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_41ab, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100b_41ae, 5); calld(0x1007_6574, -0x3_dc3f);          /* call 0x10076574 */
            ii(0x100b_41b3, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_41b5, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100b_41b8, 4); mov(memw_a32[ds, edx + 0x41], ax);      /* mov [edx+0x41], ax */
            ii(0x100b_41bc, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_41bf, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100b_41c2, 5); calld(0x1007_6574, -0x3_dc53);          /* call 0x10076574 */
            ii(0x100b_41c7, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_41c9, 3); mov(eax, memd_a32[ss, ebp - 0x12]);     /* mov eax, [ebp-0x12] */
            ii(0x100b_41cc, 4); mov(memw_a32[ds, edx + 0x43], ax);      /* mov [edx+0x43], ax */
            ii(0x100b_41d0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_41d3, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_41d6, 5); calld(0x1007_65d0, -0x3_dc0b);          /* call 0x100765d0 */
            ii(0x100b_41db, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_41dd, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_41e0, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100b_41e3, 5); calld(0x1007_6574, -0x3_dc74);          /* call 0x10076574 */
            ii(0x100b_41e8, 5); calld(0x1008_a998, -0x2_9855);          /* call 0x1008a998 */
            ii(0x100b_41ed, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x100b_41f2, 5); mov(edx, 0x5);                          /* mov edx, 0x5 */
            ii(0x100b_41f7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_41fa, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100b_41fd, 5); calld(0x1007_65d0, -0x3_dc32);          /* call 0x100765d0 */
            ii(0x100b_4202, 5); calld(0x1016_3053, 0xa_ee4c);           /* call 0x10163053 */
            ii(0x100b_4207, 5); jmpd(0x100b_4279, 0x6d); goto l_0x100b_4279; /* jmp 0x100b4279 */
        l_0x100b_420c:
            ii(0x100b_420c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_420f, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_4212, 5); calld(0x1007_6574, -0x3_dca3);          /* call 0x10076574 */
            ii(0x100b_4217, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_4219, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100b_421c, 4); mov(memw_a32[ds, edx + 0x41], ax);      /* mov [edx+0x41], ax */
            ii(0x100b_4220, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_4223, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_4226, 5); calld(0x1007_6574, -0x3_dcb7);          /* call 0x10076574 */
            ii(0x100b_422b, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_422d, 3); mov(eax, memd_a32[ss, ebp - 0x12]);     /* mov eax, [ebp-0x12] */
            ii(0x100b_4230, 4); mov(memw_a32[ds, edx + 0x43], ax);      /* mov [edx+0x43], ax */
            ii(0x100b_4234, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100b_4236, 5); mov(edx, 0x2);                          /* mov edx, 0x2 */
            ii(0x100b_423b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_423e, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_4241, 5); calld(0x1007_65d0, -0x3_dc76);          /* call 0x100765d0 */
            ii(0x100b_4246, 5); calld(0x1016_3053, 0xa_ee08);           /* call 0x10163053 */
            ii(0x100b_424b, 2); jmpd(0x100b_4279, 0x2c); goto l_0x100b_4279; /* jmp 0x100b4279 */
        l_0x100b_424d:
            ii(0x100b_424d, 2); jmpd(0x100b_4279, 0x2a); goto l_0x100b_4279; /* jmp 0x100b4279 */
        l_0x100b_424f:
            ii(0x100b_424f, 3); mov(al, memb_a32[ss, ebp - 0x2c]);      /* mov al, [ebp-0x2c] */
            ii(0x100b_4252, 3); mov(memb_a32[ss, ebp - 0x30], al);      /* mov [ebp-0x30], al */
            ii(0x100b_4255, 4); cmp(memb_a32[ss, ebp - 0x30], 0x4);     /* cmp byte [ebp-0x30], 0x4 */
            ii(0x100b_4259, 2); if(jbd(0x100b_4271, 0x16)) goto l_0x100b_4271; /* jb 0x100b4271 */
            ii(0x100b_425b, 4); cmp(memb_a32[ss, ebp - 0x30], 0x4);     /* cmp byte [ebp-0x30], 0x4 */
            ii(0x100b_425f, 6); if(jbed(0x100b_4161, -0x104)) goto l_0x100b_4161; /* jbe 0x100b4161 */
            ii(0x100b_4265, 4); cmp(memb_a32[ss, ebp - 0x30], 0x10);    /* cmp byte [ebp-0x30], 0x10 */
            ii(0x100b_4269, 6); if(jzd(0x100b_41a8, -0xc7)) goto l_0x100b_41a8; /* jz 0x100b41a8 */
            ii(0x100b_426f, 2); jmpd(0x100b_424d, -0x24); goto l_0x100b_424d; /* jmp 0x100b424d */
        l_0x100b_4271:
            ii(0x100b_4271, 4); cmp(memb_a32[ss, ebp - 0x30], 0);       /* cmp byte [ebp-0x30], 0x0 */
            ii(0x100b_4275, 2); if(jzd(0x100b_420c, -0x6b)) goto l_0x100b_420c; /* jz 0x100b420c */
            ii(0x100b_4277, 2); jmpd(0x100b_424d, -0x2c); goto l_0x100b_424d; /* jmp 0x100b424d */
        l_0x100b_4279:
            ii(0x100b_4279, 5); jmpd(0x100b_43a7, 0x129); goto l_0x100b_43a7; /* jmp 0x100b43a7 */
        l_0x100b_427e:
            ii(0x100b_427e, 5); jmpd(0x100b_40e8, -0x19b); goto l_0x100b_40e8; /* jmp 0x100b40e8 */
        l_0x100b_4283:
            ii(0x100b_4283, 5); jmpd(0x100b_40ce, -0x1ba); goto l_0x100b_40ce; /* jmp 0x100b40ce */
        l_0x100b_4288:
            ii(0x100b_4288, 7); mov(memd_a32[ss, ebp - 0xc], 0);        /* mov dword [ebp-0xc], 0x0 */
            ii(0x100b_428f, 2); jmpd(0x100b_4295, 0x4); goto l_0x100b_4295; /* jmp 0x100b4295 */
        l_0x100b_4291:
            ii(0x100b_4291, 4); add(memd_a32[ss, ebp - 0xc], 0x2);      /* add dword [ebp-0xc], 0x2 */
        l_0x100b_4295:
            ii(0x100b_4295, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x100b_4299, 3); cmp(eax, 0x8);                          /* cmp eax, 0x8 */
            ii(0x100b_429c, 6); if(jged(0x100b_43a7, 0x105)) goto l_0x100b_43a7; /* jge 0x100b43a7 */
            ii(0x100b_42a2, 7); mov(memd_a32[ss, ebp - 0x8], 0);        /* mov dword [ebp-0x8], 0x0 */
            ii(0x100b_42a9, 2); jmpd(0x100b_42b1, 0x6); goto l_0x100b_42b1; /* jmp 0x100b42b1 */
        l_0x100b_42ab:
            ii(0x100b_42ab, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_42ae, 3); inc(memd_a32[ss, ebp - 0x8]);           /* inc dword [ebp-0x8] */
        l_0x100b_42b1:
            ii(0x100b_42b1, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x100b_42b5, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x100b_42b9, 1); inc(eax);                               /* inc eax */
            ii(0x100b_42ba, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100b_42bc, 6); if(jged(0x100b_43a2, 0xe0)) goto l_0x100b_43a2; /* jge 0x100b43a2 */
            ii(0x100b_42c2, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x100b_42c6, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x100b_42c9, 5); mov(eax, 0x101c_5348);                  /* mov eax, 0x101c5348 */
            ii(0x100b_42ce, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100b_42d0, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100b_42d3, 5); calld(0x1008_b1a4, -0x2_9134);          /* call 0x1008b1a4 */
            ii(0x100b_42d8, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100b_42dd, 1); pushd(eax);                             /* push eax */
            ii(0x100b_42de, 4); movsx(ecx, memw_a32[ss, ebp - 0x12]);   /* movsx ecx, word [ebp-0x12] */
            ii(0x100b_42e2, 4); movsx(ebx, memw_a32[ss, ebp - 0x14]);   /* movsx ebx, word [ebp-0x14] */
            ii(0x100b_42e6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_42e9, 3); mov(edx, memd_a32[ds, eax + 0x7]);      /* mov edx, [eax+0x7] */
            ii(0x100b_42ec, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100b_42ef, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_42f2, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_42f5, 5); calld(0x1007_6574, -0x3_dd86);          /* call 0x10076574 */
            ii(0x100b_42fa, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x100b_42fd, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100b_4300, 5); calld(0x1007_02b9, -0x4_404c);          /* call 0x100702b9 */
            ii(0x100b_4305, 3); test(ax, ax);                           /* test ax, ax */
            ii(0x100b_4308, 6); if(jzd(0x100b_439d, 0x8f)) goto l_0x100b_439d; /* jz 0x100b439d */
            ii(0x100b_430e, 5); mov(eax, 0x1f);                         /* mov eax, 0x1f */
            ii(0x100b_4313, 5); calld(Definitions.sys_new, 0xb_1ae8);   /* call 0x10165e00 */
            ii(0x100b_4318, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
            ii(0x100b_431b, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x100b_431e, 3); mov(memd_a32[ss, ebp - 0x38], eax);     /* mov [ebp-0x38], eax */
            ii(0x100b_4321, 4); cmp(memd_a32[ss, ebp - 0x38], 0);       /* cmp dword [ebp-0x38], 0x0 */
            ii(0x100b_4325, 2); if(jzd(0x100b_434c, 0x25)) goto l_0x100b_434c; /* jz 0x100b434c */
            ii(0x100b_4327, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x100b_432a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_432d, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_4330, 5); calld(0x1007_65d0, -0x3_dd65);          /* call 0x100765d0 */
            ii(0x100b_4335, 3); mov(ecx, memd_a32[ss, ebp - 0x34]);     /* mov ecx, [ebp-0x34] */
            ii(0x100b_4338, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_433a, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x100b_433c, 5); calld(0x100a_73d7, -0xcf6a);            /* call 0x100a73d7 */
            ii(0x100b_4341, 3); mov(memd_a32[ss, ebp - 0x3c], eax);     /* mov [ebp-0x3c], eax */
            ii(0x100b_4344, 3); mov(eax, memd_a32[ss, ebp - 0x3c]);     /* mov eax, [ebp-0x3c] */
            ii(0x100b_4347, 3); mov(memd_a32[ss, ebp - 0x40], eax);     /* mov [ebp-0x40], eax */
            ii(0x100b_434a, 2); jmpd(0x100b_4352, 0x6); goto l_0x100b_4352; /* jmp 0x100b4352 */
        l_0x100b_434c:
            ii(0x100b_434c, 3); mov(eax, memd_a32[ss, ebp - 0x38]);     /* mov eax, [ebp-0x38] */
            ii(0x100b_434f, 3); mov(memd_a32[ss, ebp - 0x40], eax);     /* mov [ebp-0x40], eax */
        l_0x100b_4352:
            ii(0x100b_4352, 3); mov(edx, memd_a32[ss, ebp - 0x40]);     /* mov edx, [ebp-0x40] */
            ii(0x100b_4355, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_4358, 3); add(eax, 0x1b);                         /* add eax, 0x1b */
            ii(0x100b_435b, 5); calld(0x1009_c8f8, -0x1_7a68);          /* call 0x1009c8f8 */
            ii(0x100b_4360, 3); lea(edx, ebp - 0x14);                   /* lea edx, [ebp-0x14] */
            ii(0x100b_4363, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_4366, 3); add(eax, 0x1b);                         /* add eax, 0x1b */
            ii(0x100b_4369, 5); calld(0x100a_a824, -0x9b4a);            /* call 0x100aa824 */
            ii(0x100b_436e, 5); calld(0x100a_7557, -0xce1c);            /* call 0x100a7557 */
            ii(0x100b_4373, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_4376, 3); add(eax, 0x1b);                         /* add eax, 0x1b */
            ii(0x100b_4379, 5); calld(0x100b_80f4, 0x3d76);             /* call 0x100b80f4 */
            ii(0x100b_437e, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_4380, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_4383, 3); mov(eax, memd_a32[ds, eax + 0x7]);      /* mov eax, [eax+0x7] */
            ii(0x100b_4386, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100b_4389, 6); imul(eax, eax, 0xc5);                   /* imul eax, eax, 0xc5 */
            ii(0x100b_438f, 5); mov(ebx, 0x101c_31c4);                  /* mov ebx, 0x101c31c4 */
            ii(0x100b_4394, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x100b_4396, 5); calld(0x100c_21b2, 0xde17);             /* call 0x100c21b2 */
            ii(0x100b_439b, 2); jmpd(0x100b_43a7, 0xa); goto l_0x100b_43a7; /* jmp 0x100b43a7 */
        l_0x100b_439d:
            ii(0x100b_439d, 5); jmpd(0x100b_42ab, -0xf7); goto l_0x100b_42ab; /* jmp 0x100b42ab */
        l_0x100b_43a2:
            ii(0x100b_43a2, 5); jmpd(0x100b_4291, -0x116); goto l_0x100b_4291; /* jmp 0x100b4291 */
        l_0x100b_43a7:
            ii(0x100b_43a7, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_43a9, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_43aa, 1); popd(edi);                              /* pop edi */
            ii(0x100b_43ab, 1); popd(esi);                              /* pop esi */
            ii(0x100b_43ac, 1); popd(edx);                              /* pop edx */
            ii(0x100b_43ad, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_43ae, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_43af, 1); retd();                                 /* ret */
        }
    }
}
