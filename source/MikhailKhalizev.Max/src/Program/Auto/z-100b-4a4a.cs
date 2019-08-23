using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_4a4a-ece4773c")]
        public void Method_100b_4a4a()
        {
            ii(0x100b_4a4a, 5); push(0x54);                             /* push 0x54 */
            ii(0x100b_4a4f, 5); call(Definitions.sys_check_available_stack_size, 0xb_12fe); /* call 0x10165d52 */
            ii(0x100b_4a54, 1); push(ebx);                              /* push ebx */
            ii(0x100b_4a55, 1); push(ecx);                              /* push ecx */
            ii(0x100b_4a56, 1); push(esi);                              /* push esi */
            ii(0x100b_4a57, 1); push(edi);                              /* push edi */
            ii(0x100b_4a58, 1); push(ebp);                              /* push ebp */
            ii(0x100b_4a59, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_4a5b, 6); sub(esp, 0x30);                         /* sub esp, 0x30 */
            ii(0x100b_4a61, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100b_4a64, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100b_4a67, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100b_4a69, 5); mov(al, memb[ds, 0x101c_37c9]);         /* mov al, [0x101c37c9] */
            ii(0x100b_4a6e, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_4a70, 2); if(jnz(0x100b_4a87, 0x15)) goto l_0x100b_4a87; /* jnz 0x100b4a87 */
            ii(0x100b_4a72, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_4a75, 3); mov(eax, memd[ds, eax + 0x7]);          /* mov eax, [eax+0x7] */
            ii(0x100b_4a78, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100b_4a7b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_4a7d, 6); mov(dl, memb[ds, 0x101c_37c8]);         /* mov dl, [0x101c37c8] */
            ii(0x100b_4a83, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100b_4a85, 2); if(jnz(0x100b_4a89, 0x2)) goto l_0x100b_4a89; /* jnz 0x100b4a89 */
        l_0x100b_4a87:
            ii(0x100b_4a87, 2); jmp(0x100b_4a92, 0x9); goto l_0x100b_4a92; /* jmp 0x100b4a92 */
        l_0x100b_4a89:
            ii(0x100b_4a89, 4); mov(memb[ss, ebp - 0xc], 0);            /* mov byte [ebp-0xc], 0x0 */
            ii(0x100b_4a8d, 5); jmp(0x100b_4d30, 0x29e); goto l_0x100b_4d30; /* jmp 0x100b4d30 */
        l_0x100b_4a92:
            ii(0x100b_4a92, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100b_4a94, 5); mov(al, memb[ds, 0x101c_37c9]);         /* mov al, [0x101c37c9] */
            ii(0x100b_4a99, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x100b_4a9c, 2); if(jnz(0x100b_4aa7, 0x9)) goto l_0x100b_4aa7; /* jnz 0x100b4aa7 */
            ii(0x100b_4a9e, 4); mov(memb[ss, ebp - 0xc], 0);            /* mov byte [ebp-0xc], 0x0 */
            ii(0x100b_4aa2, 5); jmp(0x100b_4d30, 0x289); goto l_0x100b_4d30; /* jmp 0x100b4d30 */
        l_0x100b_4aa7:
            ii(0x100b_4aa7, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_4aa9, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_4aac, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_4aaf, 5); call(0x1013_ad11, 0x8_625d);            /* call 0x1013ad11 */
            ii(0x100b_4ab4, 2); test(al, al);                           /* test al, al */
            ii(0x100b_4ab6, 2); if(jnz(0x100b_4ac9, 0x11)) goto l_0x100b_4ac9; /* jnz 0x100b4ac9 */
            ii(0x100b_4ab8, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_4aba, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_4abd, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100b_4ac0, 5); call(0x1013_ad11, 0x8_624c);            /* call 0x1013ad11 */
            ii(0x100b_4ac5, 2); test(al, al);                           /* test al, al */
            ii(0x100b_4ac7, 2); if(jz(0x100b_4ad2, 0x9)) goto l_0x100b_4ad2; /* jz 0x100b4ad2 */
        l_0x100b_4ac9:
            ii(0x100b_4ac9, 4); mov(memb[ss, ebp - 0xc], 0);            /* mov byte [ebp-0xc], 0x0 */
            ii(0x100b_4acd, 5); jmp(0x100b_4d30, 0x25e); goto l_0x100b_4d30; /* jmp 0x100b4d30 */
        l_0x100b_4ad2:
            ii(0x100b_4ad2, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x100b_4ad5, 3); add(edx, 0x13);                         /* add edx, 0x13 */
            ii(0x100b_4ad8, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_4adb, 5); call(0x1008_b4b4, -0x2_962c);           /* call 0x1008b4b4 */
            ii(0x100b_4ae0, 2); test(al, al);                           /* test al, al */
            ii(0x100b_4ae2, 2); if(jz(0x100b_4af6, 0x12)) goto l_0x100b_4af6; /* jz 0x100b4af6 */
            ii(0x100b_4ae4, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x100b_4ae7, 3); add(edx, 0x17);                         /* add edx, 0x17 */
            ii(0x100b_4aea, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_4aed, 5); call(0x1008_b4b4, -0x2_963e);           /* call 0x1008b4b4 */
            ii(0x100b_4af2, 2); test(al, al);                           /* test al, al */
            ii(0x100b_4af4, 2); if(jnz(0x100b_4af8, 0x2)) goto l_0x100b_4af8; /* jnz 0x100b4af8 */
        l_0x100b_4af6:
            ii(0x100b_4af6, 2); jmp(0x100b_4b01, 0x9); goto l_0x100b_4b01; /* jmp 0x100b4b01 */
        l_0x100b_4af8:
            ii(0x100b_4af8, 4); mov(memb[ss, ebp - 0xc], 0);            /* mov byte [ebp-0xc], 0x0 */
            ii(0x100b_4afc, 5); jmp(0x100b_4d30, 0x22f); goto l_0x100b_4d30; /* jmp 0x100b4d30 */
        l_0x100b_4b01:
            ii(0x100b_4b01, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_4b04, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_4b07, 5); call(0x1007_6574, -0x3_e598);           /* call 0x10076574 */
            ii(0x100b_4b0c, 5); call(0x1015_26ac, 0x9_db9b);            /* call 0x101526ac */
            ii(0x100b_4b11, 3); cmp(eax, memd[ss, ebp - 0x8]);          /* cmp eax, [ebp-0x8] */
            ii(0x100b_4b14, 2); if(jz(0x100b_4b2a, 0x14)) goto l_0x100b_4b2a; /* jz 0x100b4b2a */
            ii(0x100b_4b16, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_4b19, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_4b1c, 5); call(0x1007_6574, -0x3_e5ad);           /* call 0x10076574 */
            ii(0x100b_4b21, 5); call(0x1015_26ac, 0x9_db86);            /* call 0x101526ac */
            ii(0x100b_4b26, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_4b28, 2); if(jnz(0x100b_4b2c, 0x2)) goto l_0x100b_4b2c; /* jnz 0x100b4b2c */
        l_0x100b_4b2a:
            ii(0x100b_4b2a, 2); jmp(0x100b_4b58, 0x2c); goto l_0x100b_4b58; /* jmp 0x100b4b58 */
        l_0x100b_4b2c:
            ii(0x100b_4b2c, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_4b2f, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_4b32, 5); call(0x1007_6574, -0x3_e5c3);           /* call 0x10076574 */
            ii(0x100b_4b37, 5); call(0x1015_26ac, 0x9_db70);            /* call 0x101526ac */
            ii(0x100b_4b3c, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100b_4b3f, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100b_4b42, 3); mov(edx, memd[ds, eax + 0x2]);          /* mov edx, [eax+0x2] */
            ii(0x100b_4b45, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100b_4b48, 3); call_abs(memd[ds, edx + 0x20]);         /* call dword [edx+0x20] */
            ii(0x100b_4b4b, 2); cmp(al, 0x17);                          /* cmp al, 0x17 */
            ii(0x100b_4b4d, 2); if(jz(0x100b_4b58, 0x9)) goto l_0x100b_4b58; /* jz 0x100b4b58 */
            ii(0x100b_4b4f, 4); mov(memb[ss, ebp - 0xc], 0);            /* mov byte [ebp-0xc], 0x0 */
            ii(0x100b_4b53, 5); jmp(0x100b_4d30, 0x1d8); goto l_0x100b_4d30; /* jmp 0x100b4d30 */
        l_0x100b_4b58:
            ii(0x100b_4b58, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_4b5b, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_4b5e, 5); call(0x1007_6574, -0x3_e5ef);           /* call 0x10076574 */
            ii(0x100b_4b63, 3); mov(ebx, memd[ds, eax + 0x1a]);         /* mov ebx, [eax+0x1a] */
            ii(0x100b_4b66, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100b_4b69, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_4b6c, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_4b6f, 5); call(0x1007_6574, -0x3_e600);           /* call 0x10076574 */
            ii(0x100b_4b74, 3); mov(edx, memd[ds, eax + 0x18]);         /* mov edx, [eax+0x18] */
            ii(0x100b_4b77, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100b_4b7a, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_4b7d, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100b_4b80, 5); call(0x1008_abbc, -0x2_9fc9);           /* call 0x1008abbc */
            ii(0x100b_4b85, 5); call(0x100a_30a2, -0x1_1ae8);           /* call 0x100a30a2 */
            ii(0x100b_4b8a, 2); test(al, al);                           /* test al, al */
            ii(0x100b_4b8c, 2); if(jz(0x100b_4ba1, 0x13)) goto l_0x100b_4ba1; /* jz 0x100b4ba1 */
            ii(0x100b_4b8e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_4b90, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_4b93, 5); call(0x100b_4d93, 0x1fb);               /* call 0x100b4d93 */
            ii(0x100b_4b98, 4); mov(memb[ss, ebp - 0xc], 0);            /* mov byte [ebp-0xc], 0x0 */
            ii(0x100b_4b9c, 5); jmp(0x100b_4d30, 0x18f); goto l_0x100b_4d30; /* jmp 0x100b4d30 */
        l_0x100b_4ba1:
            ii(0x100b_4ba1, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_4ba4, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100b_4ba7, 5); call(0x1007_6574, -0x3_e638);           /* call 0x10076574 */
            ii(0x100b_4bac, 3); mov(al, memb[ds, eax + 0x4e]);          /* mov al, [eax+0x4e] */
            ii(0x100b_4baf, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100b_4bb4, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_4bb6, 2); if(jz(0x100b_4bcf, 0x17)) goto l_0x100b_4bcf; /* jz 0x100b4bcf */
            ii(0x100b_4bb8, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x100b_4bbb, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_4bbe, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100b_4bc1, 5); call(0x1007_6574, -0x3_e652);           /* call 0x10076574 */
            ii(0x100b_4bc6, 5); call(0x1015_2a52, 0x9_de87);            /* call 0x10152a52 */
            ii(0x100b_4bcb, 2); test(al, al);                           /* test al, al */
            ii(0x100b_4bcd, 2); if(jnz(0x100b_4bee, 0x1f)) goto l_0x100b_4bee; /* jnz 0x100b4bee */
        l_0x100b_4bcf:
            ii(0x100b_4bcf, 5); mov(ebx, 0x2);                          /* mov ebx, 0x2 */
            ii(0x100b_4bd4, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_4bd7, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100b_4bda, 5); call(0x1007_65d0, -0x3_e60f);           /* call 0x100765d0 */
            ii(0x100b_4bdf, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_4be1, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_4be4, 5); call(0x100b_4ecb, 0x2e2);               /* call 0x100b4ecb */
            ii(0x100b_4be9, 5); jmp(0x100b_4d2c, 0x13e); goto l_0x100b_4d2c; /* jmp 0x100b4d2c */
        l_0x100b_4bee:
            ii(0x100b_4bee, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_4bf1, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_4bf4, 5); call(0x1007_65d0, -0x3_e629);           /* call 0x100765d0 */
            ii(0x100b_4bf9, 5); call(0x100a_2edb, -0x1_1d23);           /* call 0x100a2edb */
            ii(0x100b_4bfe, 2); test(al, al);                           /* test al, al */
            ii(0x100b_4c00, 2); if(jz(0x100b_4c22, 0x20)) goto l_0x100b_4c22; /* jz 0x100b4c22 */
            ii(0x100b_4c02, 5); mov(ebx, 0x3);                          /* mov ebx, 0x3 */
            ii(0x100b_4c07, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_4c0a, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100b_4c0d, 5); call(0x1007_65d0, -0x3_e642);           /* call 0x100765d0 */
            ii(0x100b_4c12, 3); mov(ecx, memd[ss, ebp - 0x8]);          /* mov ecx, [ebp-0x8] */
            ii(0x100b_4c15, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_4c17, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x100b_4c19, 5); call(0x100a_3671, -0x1_15ad);           /* call 0x100a3671 */
            ii(0x100b_4c1e, 2); test(al, al);                           /* test al, al */
            ii(0x100b_4c20, 2); if(jz(0x100b_4c27, 0x5)) goto l_0x100b_4c27; /* jz 0x100b4c27 */
        l_0x100b_4c22:
            ii(0x100b_4c22, 5); jmp(0x100b_4d2c, 0x105); goto l_0x100b_4d2c; /* jmp 0x100b4d2c */
        l_0x100b_4c27:
            ii(0x100b_4c27, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x100b_4c2a, 5); call(Definitions.my_ctor_0x101b_4184, -0x3_e13f); /* call 0x10076af0 */
            ii(0x100b_4c2f, 3); lea(ebx, memd[ss, ebp - 0x14]);         /* lea ebx, [ebp-0x14] */
            ii(0x100b_4c32, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_4c35, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_4c38, 5); call(0x1007_65d0, -0x3_e66d);           /* call 0x100765d0 */
            ii(0x100b_4c3d, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_4c3f, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_4c42, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100b_4c45, 5); call(0x1007_65d0, -0x3_e67a);           /* call 0x100765d0 */
            ii(0x100b_4c4a, 5); call(0x100b_49e3, -0x26c);              /* call 0x100b49e3 */
            ii(0x100b_4c4f, 2); test(al, al);                           /* test al, al */
            ii(0x100b_4c51, 2); if(jnz(0x100b_4c72, 0x1f)) goto l_0x100b_4c72; /* jnz 0x100b4c72 */
            ii(0x100b_4c53, 5); mov(ebx, 0x2);                          /* mov ebx, 0x2 */
            ii(0x100b_4c58, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_4c5b, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100b_4c5e, 5); call(0x1007_65d0, -0x3_e693);           /* call 0x100765d0 */
            ii(0x100b_4c63, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_4c65, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_4c68, 5); call(0x100b_4ecb, 0x25e);               /* call 0x100b4ecb */
            ii(0x100b_4c6d, 5); jmp(0x100b_4d26, 0xb4); goto l_0x100b_4d26; /* jmp 0x100b4d26 */
        l_0x100b_4c72:
            ii(0x100b_4c72, 5); mov(eax, 0x49);                         /* mov eax, 0x49 */
            ii(0x100b_4c77, 5); call(Definitions.sys_new, 0xb_1184);    /* call 0x10165e00 */
            ii(0x100b_4c7c, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x100b_4c7f, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x100b_4c82, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x100b_4c85, 4); cmp(memd[ss, ebp - 0x1c], 0);           /* cmp dword [ebp-0x1c], 0x0 */
            ii(0x100b_4c89, 2); if(jz(0x100b_4cc8, 0x3d)) goto l_0x100b_4cc8; /* jz 0x100b4cc8 */
            ii(0x100b_4c8b, 5); mov(eax, 0x100b_4ecb);                  /* mov eax, 0x100b4ecb */
            ii(0x100b_4c90, 1); push(eax);                              /* push eax */
            ii(0x100b_4c91, 3); lea(edx, memd[ss, ebp - 0x14]);         /* lea edx, [ebp-0x14] */
            ii(0x100b_4c94, 3); lea(eax, memd[ss, ebp - 0x20]);         /* lea eax, [ebp-0x20] */
            ii(0x100b_4c97, 5); call(0x1007_5e64, -0x3_ee38);           /* call 0x10075e64 */
            ii(0x100b_4c9c, 1); push(eax);                              /* push eax */
            ii(0x100b_4c9d, 5); mov(eax, 0x3);                          /* mov eax, 0x3 */
            ii(0x100b_4ca2, 1); push(eax);                              /* push eax */
            ii(0x100b_4ca3, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x100b_4ca5, 3); mov(ebx, memd[ss, ebp - 0x8]);          /* mov ebx, [ebp-0x8] */
            ii(0x100b_4ca8, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_4cab, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100b_4cae, 5); call(0x1007_65d0, -0x3_e6e3);           /* call 0x100765d0 */
            ii(0x100b_4cb3, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_4cb5, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x100b_4cb8, 5); call(0x100a_c220, -0x8a9d);             /* call 0x100ac220 */
            ii(0x100b_4cbd, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
            ii(0x100b_4cc0, 3); mov(eax, memd[ss, ebp - 0x24]);         /* mov eax, [ebp-0x24] */
            ii(0x100b_4cc3, 3); mov(memd[ss, ebp - 0x28], eax);         /* mov [ebp-0x28], eax */
            ii(0x100b_4cc6, 2); jmp(0x100b_4cce, 0x6); goto l_0x100b_4cce; /* jmp 0x100b4cce */
        l_0x100b_4cc8:
            ii(0x100b_4cc8, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x100b_4ccb, 3); mov(memd[ss, ebp - 0x28], eax);         /* mov [ebp-0x28], eax */
        l_0x100b_4cce:
            ii(0x100b_4cce, 3); mov(edx, memd[ss, ebp - 0x28]);         /* mov edx, [ebp-0x28] */
            ii(0x100b_4cd1, 3); lea(eax, memd[ss, ebp - 0x2c]);         /* lea eax, [ebp-0x2c] */
            ii(0x100b_4cd4, 5); call(0x1008_a5f0, -0x2_a6e9);           /* call 0x1008a5f0 */
            ii(0x100b_4cd9, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_4cdc, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_4cdf, 5); call(0x1007_6574, -0x3_e770);           /* call 0x10076574 */
            ii(0x100b_4ce4, 4); test(memb[ds, eax + 0x13], 0x2);        /* test byte [eax+0x13], 0x2 */
            ii(0x100b_4ce8, 2); if(jnz(0x100b_4cf0, 0x6)) goto l_0x100b_4cf0; /* jnz 0x100b4cf0 */
            ii(0x100b_4cea, 4); mov(memb[ss, ebp - 0x30], 0x1);         /* mov byte [ebp-0x30], 0x1 */
            ii(0x100b_4cee, 2); jmp(0x100b_4cf4, 0x4); goto l_0x100b_4cf4; /* jmp 0x100b4cf4 */
        l_0x100b_4cf0:
            ii(0x100b_4cf0, 4); mov(memb[ss, ebp - 0x30], 0);           /* mov byte [ebp-0x30], 0x0 */
        l_0x100b_4cf4:
            ii(0x100b_4cf4, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_4cf6, 3); mov(dl, memb[ss, ebp - 0x30]);          /* mov dl, [ebp-0x30] */
            ii(0x100b_4cf9, 3); lea(eax, memd[ss, ebp - 0x2c]);         /* lea eax, [ebp-0x2c] */
            ii(0x100b_4cfc, 5); call(0x1008_a520, -0x2_a7e1);           /* call 0x1008a520 */
            ii(0x100b_4d01, 5); call(0x1008_a6a4, -0x2_a662);           /* call 0x1008a6a4 */
            ii(0x100b_4d06, 3); lea(eax, memd[ss, ebp - 0x2c]);         /* lea eax, [ebp-0x2c] */
            ii(0x100b_4d09, 5); call(0x1008_a57c, -0x2_a792);           /* call 0x1008a57c */
            ii(0x100b_4d0e, 5); mov(ebx, 0x101c_3180);                  /* mov ebx, 0x101c3180 */
            ii(0x100b_4d13, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_4d15, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100b_4d17, 5); call(0x100a_4d50, -0xffcc);             /* call 0x100a4d50 */
            ii(0x100b_4d1c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_4d1e, 3); lea(eax, memd[ss, ebp - 0x2c]);         /* lea eax, [ebp-0x2c] */
            ii(0x100b_4d21, 5); call(0x1008_8d4c, -0x2_bfda);           /* call 0x10088d4c */
        l_0x100b_4d26:
            ii(0x100b_4d26, 4); mov(memb[ss, ebp - 0xc], 0x1);          /* mov byte [ebp-0xc], 0x1 */
            ii(0x100b_4d2a, 2); jmp(0x100b_4d30, 0x4); goto l_0x100b_4d30; /* jmp 0x100b4d30 */
        l_0x100b_4d2c:
            ii(0x100b_4d2c, 4); mov(memb[ss, ebp - 0xc], 0);            /* mov byte [ebp-0xc], 0x0 */
        l_0x100b_4d30:
            ii(0x100b_4d30, 3); mov(al, memb[ss, ebp - 0xc]);           /* mov al, [ebp-0xc] */
            ii(0x100b_4d33, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_4d35, 1); pop(ebp);                               /* pop ebp */
            ii(0x100b_4d36, 1); pop(edi);                               /* pop edi */
            ii(0x100b_4d37, 1); pop(esi);                               /* pop esi */
            ii(0x100b_4d38, 1); pop(ecx);                               /* pop ecx */
            ii(0x100b_4d39, 1); pop(ebx);                               /* pop ebx */
            ii(0x100b_4d3a, 1); ret();                                  /* ret */
        }
    }
}
