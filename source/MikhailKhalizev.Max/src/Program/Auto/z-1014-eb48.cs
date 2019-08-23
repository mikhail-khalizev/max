using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_eb48-b7dfdb0f")]
        public void Method_1014_eb48()
        {
            ii(0x1014_eb48, 5); push(0x48);                             /* push 0x48 */
            ii(0x1014_eb4d, 5); call(Definitions.sys_check_available_stack_size, 0x1_7200); /* call 0x10165d52 */
            ii(0x1014_eb52, 1); push(ecx);                              /* push ecx */
            ii(0x1014_eb53, 1); push(esi);                              /* push esi */
            ii(0x1014_eb54, 1); push(edi);                              /* push edi */
            ii(0x1014_eb55, 1); push(ebp);                              /* push ebp */
            ii(0x1014_eb56, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_eb58, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x1014_eb5e, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1014_eb61, 3); mov(memd[ss, ebp - 0x8], edx);          /* mov [ebp-0x8], edx */
            ii(0x1014_eb64, 3); mov(memd[ss, ebp - 0x4], ebx);          /* mov [ebp-0x4], ebx */
            ii(0x1014_eb67, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x1014_eb6c, 4); movsx(ebx, memw[ss, ebp - 0x4]);        /* movsx ebx, word [ebp-0x4] */
            ii(0x1014_eb70, 4); movsx(edx, memw[ss, ebp - 0x8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x1014_eb74, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1014_eb77, 5); call(0x1007_4c30, -0xd_9f4c);           /* call 0x10074c30 */
            ii(0x1014_eb7c, 3); lea(ebx, ebp - 0x14);                   /* lea ebx, [ebp-0x14] */
            ii(0x1014_eb7f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_eb81, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1014_eb83, 5); call(0x1007_66ac, -0xd_84dc);           /* call 0x100766ac */
            ii(0x1014_eb88, 7); mov(memd[ss, ebp - 0x18], 0);           /* mov dword [ebp-0x18], 0x0 */
            ii(0x1014_eb8f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_eb91, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1014_eb94, 5); call(0x1013_ad11, -0x1_3e88);           /* call 0x1013ad11 */
            ii(0x1014_eb99, 2); test(al, al);                           /* test al, al */
            ii(0x1014_eb9b, 6); if(jz(0x1014_ecda, 0x139)) goto l_0x1014_ecda; /* jz 0x1014ecda */
            ii(0x1014_eba1, 4); movsx(ebx, memw[ss, ebp - 0x4]);        /* movsx ebx, word [ebp-0x4] */
            ii(0x1014_eba5, 4); movsx(edx, memw[ss, ebp - 0x8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x1014_eba9, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1014_ebac, 5); call(0x1007_4f1e, -0xd_9c93);           /* call 0x10074f1e */
            ii(0x1014_ebb1, 3); lea(ebx, ebp - 0x14);                   /* lea ebx, [ebp-0x14] */
            ii(0x1014_ebb4, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_ebb6, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1014_ebb8, 5); call(0x1007_6630, -0xd_858d);           /* call 0x10076630 */
            ii(0x1014_ebbd, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_ebbf, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1014_ebc2, 5); call(0x1013_ad71, -0x1_3e56);           /* call 0x1013ad71 */
            ii(0x1014_ebc7, 2); test(al, al);                           /* test al, al */
            ii(0x1014_ebc9, 2); if(jz(0x1014_ebee, 0x23)) goto l_0x1014_ebee; /* jz 0x1014ebee */
            ii(0x1014_ebcb, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1014_ebce, 5); call(0x1007_6574, -0xd_865f);           /* call 0x10076574 */
            ii(0x1014_ebd3, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_ebd5, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1014_ebd8, 3); mov(al, memb[ds, eax + 0x26]);          /* mov al, [eax+0x26] */
            ii(0x1014_ebdb, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1014_ebe0, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1014_ebe2, 7); mov(memb[ds, edx + 0xab], 0x1);         /* mov byte [edx+0xab], 0x1 */
            ii(0x1014_ebe9, 5); jmp(0x1014_ecda, 0xec); goto l_0x1014_ecda; /* jmp 0x1014ecda */
        l_0x1014_ebee:
            ii(0x1014_ebee, 5); mov(ecx, 0x40_0000);                    /* mov ecx, 0x400000 */
            ii(0x1014_ebf3, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1014_ebf6, 3); mov(al, memb[ds, eax + 0x26]);          /* mov al, [eax+0x26] */
            ii(0x1014_ebf9, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1014_ebfb, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1014_ebfe, 4); movsx(edx, memw[ss, ebp - 0x4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x1014_ec02, 4); movsx(eax, memw[ss, ebp - 0x8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1014_ec06, 5); call(0x1007_388b, -0xd_b380);           /* call 0x1007388b */
            ii(0x1014_ec0b, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x1014_ec0e, 4); cmp(memd[ss, ebp - 0x18], 0);           /* cmp dword [ebp-0x18], 0x0 */
            ii(0x1014_ec12, 2); if(jnz(0x1014_ec1e, 0xa)) goto l_0x1014_ec1e; /* jnz 0x1014ec1e */
            ii(0x1014_ec14, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1014_ec17, 5); cmp(memw[ds, eax + 0x8], 0x23);         /* cmp word [eax+0x8], 0x23 */
            ii(0x1014_ec1c, 2); if(jnz(0x1014_ec20, 0x2)) goto l_0x1014_ec20; /* jnz 0x1014ec20 */
        l_0x1014_ec1e:
            ii(0x1014_ec1e, 2); jmp(0x1014_ec2a, 0xa); goto l_0x1014_ec2a; /* jmp 0x1014ec2a */
        l_0x1014_ec20:
            ii(0x1014_ec20, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1014_ec23, 5); cmp(memw[ds, eax + 0x8], 0x37);         /* cmp word [eax+0x8], 0x37 */
            ii(0x1014_ec28, 2); if(jnz(0x1014_ec2c, 0x2)) goto l_0x1014_ec2c; /* jnz 0x1014ec2c */
        l_0x1014_ec2a:
            ii(0x1014_ec2a, 2); jmp(0x1014_ec36, 0xa); goto l_0x1014_ec36; /* jmp 0x1014ec36 */
        l_0x1014_ec2c:
            ii(0x1014_ec2c, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1014_ec2f, 5); cmp(memw[ds, eax + 0x8], 0x44);         /* cmp word [eax+0x8], 0x44 */
            ii(0x1014_ec34, 2); if(jnz(0x1014_ec3b, 0x5)) goto l_0x1014_ec3b; /* jnz 0x1014ec3b */
        l_0x1014_ec36:
            ii(0x1014_ec36, 5); jmp(0x1014_ecda, 0x9f); goto l_0x1014_ecda; /* jmp 0x1014ecda */
        l_0x1014_ec3b:
            ii(0x1014_ec3b, 5); call(0x1010_2b84, -0x4_c0bc);           /* call 0x10102b84 */
            ii(0x1014_ec40, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1014_ec45, 1); push(eax);                              /* push eax */
            ii(0x1014_ec46, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1014_ec4b, 1); push(eax);                              /* push eax */
            ii(0x1014_ec4c, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1014_ec4e, 1); push(eax);                              /* push eax */
            ii(0x1014_ec4f, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1014_ec53, 1); push(eax);                              /* push eax */
            ii(0x1014_ec54, 4); movsx(eax, memw[ss, ebp - 0x8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1014_ec58, 1); push(eax);                              /* push eax */
            ii(0x1014_ec59, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1014_ec5b, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1014_ec5e, 3); mov(al, memb[ds, eax + 0x26]);          /* mov al, [eax+0x26] */
            ii(0x1014_ec61, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1014_ec63, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1014_ec66, 5); mov(edx, 0x2f);                         /* mov edx, 0x2f */
            ii(0x1014_ec6b, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1014_ec6e, 5); call(0x1015_a2da, 0xb667);              /* call 0x1015a2da */
            ii(0x1014_ec73, 4); movsx(edx, memw[ss, ebp - 0x4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x1014_ec77, 4); movsx(eax, memw[ss, ebp - 0x8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1014_ec7b, 5); call(0x1007_3d48, -0xd_af38);           /* call 0x10073d48 */
            ii(0x1014_ec80, 5); and(eax, 0xffff);                       /* and eax, 0xffff */
            ii(0x1014_ec85, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1014_ec88, 2); if(jnz(0x1014_ecae, 0x24)) goto l_0x1014_ecae; /* jnz 0x1014ecae */
            ii(0x1014_ec8a, 5); call(0x1010_2bf8, -0x4_c097);           /* call 0x10102bf8 */
            ii(0x1014_ec8f, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1014_ec91, 2); mov(cl, al);                            /* mov cl, al */
            ii(0x1014_ec93, 5); mov(ebx, 0xd);                          /* mov ebx, 0xd */
            ii(0x1014_ec98, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1014_ec9b, 5); call(0x1007_6600, -0xd_86a0);           /* call 0x10076600 */
            ii(0x1014_eca0, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_eca2, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x1014_eca7, 5); call(0x1013_d5c0, -0x1_16ec);           /* call 0x1013d5c0 */
            ii(0x1014_ecac, 2); jmp(0x1014_ecd0, 0x22); goto l_0x1014_ecd0; /* jmp 0x1014ecd0 */
        l_0x1014_ecae:
            ii(0x1014_ecae, 5); call(0x1010_2bf8, -0x4_c0bb);           /* call 0x10102bf8 */
            ii(0x1014_ecb3, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1014_ecb5, 2); mov(cl, al);                            /* mov cl, al */
            ii(0x1014_ecb7, 5); mov(ebx, 0xe);                          /* mov ebx, 0xe */
            ii(0x1014_ecbc, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1014_ecbf, 5); call(0x1007_6600, -0xd_86c4);           /* call 0x10076600 */
            ii(0x1014_ecc4, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_ecc6, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x1014_eccb, 5); call(0x1013_d5c0, -0x1_1710);           /* call 0x1013d5c0 */
        l_0x1014_ecd0:
            ii(0x1014_ecd0, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_ecd2, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1014_ecd5, 5); call(0x1007_5f2c, -0xd_8dae);           /* call 0x10075f2c */
        l_0x1014_ecda:
            ii(0x1014_ecda, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1014_ecdd, 4); test(memb[ds, eax + 0x12], 0x20);       /* test byte [eax+0x12], 0x20 */
            ii(0x1014_ece1, 2); if(jz(0x1014_ecfd, 0x1a)) goto l_0x1014_ecfd; /* jz 0x1014ecfd */
            ii(0x1014_ece3, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1014_ece6, 3); mov(dl, memb[ds, edx + 0x29]);          /* mov dl, [edx+0x29] */
            ii(0x1014_ece9, 6); and(edx, 0xff);                         /* and edx, 0xff */
            ii(0x1014_ecef, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1014_ecf1, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1014_ecf4, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1014_ecf6, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x1014_ecf8, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1014_ecfb, 2); jmp(0x1014_ed21, 0x24); goto l_0x1014_ed21; /* jmp 0x1014ed21 */
        l_0x1014_ecfd:
            ii(0x1014_ecfd, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1014_ed00, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1014_ed03, 4); sub(dx, memw[ds, eax + 0x1c]);          /* sub dx, [eax+0x1c] */
            ii(0x1014_ed07, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1014_ed09, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1014_ed0c, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1014_ed0f, 3); mov(ebx, memd[ss, ebp - 0x8]);          /* mov ebx, [ebp-0x8] */
            ii(0x1014_ed12, 4); sub(bx, memw[ds, eax + 0x1a]);          /* sub bx, [eax+0x1a] */
            ii(0x1014_ed16, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1014_ed18, 1); cwde();                                 /* cwde */
            ii(0x1014_ed19, 5); call(0x1015_c339, 0xd61b);              /* call 0x1015c339 */
            ii(0x1014_ed1e, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
        l_0x1014_ed21:
            ii(0x1014_ed21, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1014_ed24, 5); call(0x1014_1698, -0xd691);             /* call 0x10141698 */
            ii(0x1014_ed29, 5); cmp(memw[ds, eax + 0x1d], 0);           /* cmp word [eax+0x1d], 0x0 */
            ii(0x1014_ed2e, 2); if(jz(0x1014_ed71, 0x41)) goto l_0x1014_ed71; /* jz 0x1014ed71 */
            ii(0x1014_ed30, 5); mov(ecx, 0x101c_8178);                  /* mov ecx, 0x101c8178 */
            ii(0x1014_ed35, 4); movsx(ebx, memw[ss, ebp - 0x4]);        /* movsx ebx, word [ebp-0x4] */
            ii(0x1014_ed39, 4); movsx(edx, memw[ss, ebp - 0x8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x1014_ed3d, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1014_ed40, 5); call(0x1014_e9e0, -0x365);              /* call 0x1014e9e0 */
            ii(0x1014_ed45, 5); mov(ecx, 0x101c_819c);                  /* mov ecx, 0x101c819c */
            ii(0x1014_ed4a, 4); movsx(ebx, memw[ss, ebp - 0x4]);        /* movsx ebx, word [ebp-0x4] */
            ii(0x1014_ed4e, 4); movsx(edx, memw[ss, ebp - 0x8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x1014_ed52, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1014_ed55, 5); call(0x1014_e9e0, -0x37a);              /* call 0x1014e9e0 */
            ii(0x1014_ed5a, 5); mov(ecx, 0x101c_8184);                  /* mov ecx, 0x101c8184 */
            ii(0x1014_ed5f, 4); movsx(ebx, memw[ss, ebp - 0x4]);        /* movsx ebx, word [ebp-0x4] */
            ii(0x1014_ed63, 4); movsx(edx, memw[ss, ebp - 0x8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x1014_ed67, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1014_ed6a, 5); call(0x1014_e9e0, -0x38f);              /* call 0x1014e9e0 */
            ii(0x1014_ed6f, 2); jmp(0x1014_edd3, 0x62); goto l_0x1014_edd3; /* jmp 0x1014edd3 */
        l_0x1014_ed71:
            ii(0x1014_ed71, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_ed73, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1014_ed76, 5); call(0x1013_ad71, -0x1_400a);           /* call 0x1013ad71 */
            ii(0x1014_ed7b, 2); test(al, al);                           /* test al, al */
            ii(0x1014_ed7d, 2); if(jz(0x1014_ed97, 0x18)) goto l_0x1014_ed97; /* jz 0x1014ed97 */
            ii(0x1014_ed7f, 4); movsx(ecx, memw[ss, ebp - 0x10]);       /* movsx ecx, word [ebp-0x10] */
            ii(0x1014_ed83, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1014_ed85, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1014_ed88, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1014_ed8b, 5); call(0x1007_6574, -0xd_881c);           /* call 0x10076574 */
            ii(0x1014_ed90, 5); call(0x1014_a8f2, -0x44a3);             /* call 0x1014a8f2 */
            ii(0x1014_ed95, 2); jmp(0x1014_edd3, 0x3c); goto l_0x1014_edd3; /* jmp 0x1014edd3 */
        l_0x1014_ed97:
            ii(0x1014_ed97, 4); cmp(memd[ss, ebp - 0x18], 0);           /* cmp dword [ebp-0x18], 0x0 */
            ii(0x1014_ed9b, 2); if(jz(0x1014_edc0, 0x23)) goto l_0x1014_edc0; /* jz 0x1014edc0 */
            ii(0x1014_ed9d, 4); movsx(ebx, memw[ss, ebp - 0x4]);        /* movsx ebx, word [ebp-0x4] */
            ii(0x1014_eda1, 4); movsx(edx, memw[ss, ebp - 0x8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x1014_eda5, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1014_eda8, 5); call(0x1007_6aac, -0xd_8301);           /* call 0x10076aac */
            ii(0x1014_edad, 3); mov(edx, memd[ss, ebp - 0x18]);         /* mov edx, [ebp-0x18] */
            ii(0x1014_edb0, 3); mov(ecx, memd[ss, ebp - 0xc]);          /* mov ecx, [ebp-0xc] */
            ii(0x1014_edb3, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1014_edb5, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1014_edb7, 5); call(0x1007_4b2b, -0xd_a291);           /* call 0x10074b2b */
            ii(0x1014_edbc, 2); test(al, al);                           /* test al, al */
            ii(0x1014_edbe, 2); if(jnz(0x1014_edc2, 0x2)) goto l_0x1014_edc2; /* jnz 0x1014edc2 */
        l_0x1014_edc0:
            ii(0x1014_edc0, 2); jmp(0x1014_edd3, 0x11); goto l_0x1014_edd3; /* jmp 0x1014edd3 */
        l_0x1014_edc2:
            ii(0x1014_edc2, 4); movsx(ecx, memw[ss, ebp - 0x10]);       /* movsx ecx, word [ebp-0x10] */
            ii(0x1014_edc6, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1014_edc8, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1014_edcb, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1014_edce, 5); call(0x1014_a8f2, -0x44e1);             /* call 0x1014a8f2 */
        l_0x1014_edd3:
            ii(0x1014_edd3, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1014_edd6, 3); mov(al, memb[ds, eax + 0x50]);          /* mov al, [eax+0x50] */
            ii(0x1014_edd9, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1014_edde, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1014_ede0, 2); if(jnz(0x1014_ede9, 0x7)) goto l_0x1014_ede9; /* jnz 0x1014ede9 */
            ii(0x1014_ede2, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1014_ede5, 4); mov(memb[ds, eax + 0x55], 0);           /* mov byte [eax+0x55], 0x0 */
        l_0x1014_ede9:
            ii(0x1014_ede9, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_edeb, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1014_edee, 5); call(0x1007_5f2c, -0xd_8ec7);           /* call 0x10075f2c */
            ii(0x1014_edf3, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_edf5, 1); pop(ebp);                               /* pop ebp */
            ii(0x1014_edf6, 1); pop(edi);                               /* pop edi */
            ii(0x1014_edf7, 1); pop(esi);                               /* pop esi */
            ii(0x1014_edf8, 1); pop(ecx);                               /* pop ecx */
            ii(0x1014_edf9, 1); ret();                                  /* ret */
        }
    }
}
