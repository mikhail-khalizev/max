using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_4a73-f945e649")]
        public void Method_100a_4a73()
        {
            ii(0x100a_4a73, 5); push(0x11c);                            /* push 0x11c */
            ii(0x100a_4a78, 5); call(Definitions.sys_check_available_stack_size, 0xc_12d5); /* call 0x10165d52 */
            ii(0x100a_4a7d, 1); push(esi);                              /* push esi */
            ii(0x100a_4a7e, 1); push(edi);                              /* push edi */
            ii(0x100a_4a7f, 1); push(ebp);                              /* push ebp */
            ii(0x100a_4a80, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_4a82, 6); sub(esp, 0x10c);                        /* sub esp, 0x10c */
            ii(0x100a_4a88, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x100a_4a8b, 3); mov(memd[ss, ebp - 8], edx);            /* mov [ebp-0x8], edx */
            ii(0x100a_4a8e, 3); mov(memd[ss, ebp - 4], ebx);            /* mov [ebp-0x4], ebx */
            ii(0x100a_4a91, 3); mov(memd[ss, ebp - 12], ecx);           /* mov [ebp-0xc], ecx */
            ii(0x100a_4a94, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100a_4a97, 5); call(0x1008_aef4, -0x1_9ba8);           /* call 0x1008aef4 */
            ii(0x100a_4a9c, 3); lea(ebx, memd[ss, ebp - 44]);           /* lea ebx, [ebp-0x2c] */
            ii(0x100a_4a9f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_4aa1, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100a_4aa3, 5); call(0x1008_ae70, -0x1_9c38);           /* call 0x1008ae70 */
            ii(0x100a_4aa8, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100a_4aab, 3); mov(memd[ss, ebp - 48], eax);           /* mov [ebp-0x30], eax */
            ii(0x100a_4aae, 3); mov(eax, memd[ss, ebp - 48]);           /* mov eax, [ebp-0x30] */
            ii(0x100a_4ab1, 3); mov(edx, memd[ds, eax + 2]);            /* mov edx, [eax+0x2] */
            ii(0x100a_4ab4, 3); mov(eax, memd[ss, ebp - 48]);           /* mov eax, [ebp-0x30] */
            ii(0x100a_4ab7, 3); call_abs(memd[ds, edx + 20]);           /* call dword [edx+0x14] */
            ii(0x100a_4aba, 3); mov(memd[ss, ebp - 40], eax);           /* mov [ebp-0x28], eax */
            ii(0x100a_4abd, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100a_4ac0, 5); call(0x1008_ad90, -0x1_9d35);           /* call 0x1008ad90 */
            ii(0x100a_4ac5, 3); mov(memd[ss, ebp - 20], eax);           /* mov [ebp-0x14], eax */
            ii(0x100a_4ac8, 4); movsx(edx, memw[ss, ebp - 8]);          /* movsx edx, word [ebp-0x8] */
            ii(0x100a_4acc, 4); movsx(eax, memw[ss, ebp - 20]);         /* movsx eax, word [ebp-0x14] */
            ii(0x100a_4ad0, 6); imul(ebx, eax, 0x247);                  /* imul ebx, eax, 0x247 */
            ii(0x100a_4ad6, 5); mov(eax, 0x101c_a468);                  /* mov eax, 0x101ca468 */
            ii(0x100a_4adb, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x100a_4add, 5); call(0x100d_fd2c, 0x3_b24a);            /* call 0x100dfd2c */
            ii(0x100a_4ae2, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_4ae4, 5); call(0x100a_314c, -0x199d);             /* call 0x100a314c */
            ii(0x100a_4ae9, 4); cmp(ax, memw[ds, edx + 8]);             /* cmp ax, [edx+0x8] */
            ii(0x100a_4aed, 2); if(jge(0x100a_4afe, 0xf)) goto l_0x100a_4afe; /* jge 0x100a4afe */
            ii(0x100a_4aef, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_4af1, 3); lea(eax, memd[ss, ebp - 44]);           /* lea eax, [ebp-0x2c] */
            ii(0x100a_4af4, 5); call(0x1008_8bbc, -0x1_bf3d);           /* call 0x10088bbc */
            ii(0x100a_4af9, 5); jmp(0x100a_4d48, 0x24a); goto l_0x100a_4d48; /* jmp 0x100a4d48 */
        l_0x100a_4afe:
            ii(0x100a_4afe, 5); mov(ebx, 0xba);                         /* mov ebx, 0xba */
            ii(0x100a_4b03, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_4b05, 6); lea(eax, memd[ss, ebp - 236]);          /* lea eax, [ebp-0xec] */
            ii(0x100a_4b0b, 5); call(Definitions.sys_memset, 0xc_12d0); /* call 0x10165de0 */
            ii(0x100a_4b10, 2); jmp(0x100a_4b1a, 8); goto l_0x100a_4b1a; /* jmp 0x100a4b1a */
        l_0x100a_4b12:
            ii(0x100a_4b12, 3); lea(eax, memd[ss, ebp - 44]);           /* lea eax, [ebp-0x2c] */
            ii(0x100a_4b15, 5); call(0x1007_6bf8, -0x2_df22);           /* call 0x10076bf8 */
        l_0x100a_4b1a:
            ii(0x100a_4b1a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_4b1c, 3); lea(eax, memd[ss, ebp - 44]);           /* lea eax, [ebp-0x2c] */
            ii(0x100a_4b1f, 5); call(0x1013_ad71, 0x9_624d);            /* call 0x1013ad71 */
            ii(0x100a_4b24, 2); test(al, al);                           /* test al, al */
            ii(0x100a_4b26, 6); if(jz(0x100a_4baa, 0x7e)) goto l_0x100a_4baa; /* jz 0x100a4baa */
            ii(0x100a_4b2c, 3); lea(eax, memd[ss, ebp - 44]);           /* lea eax, [ebp-0x2c] */
            ii(0x100a_4b2f, 5); call(0x1008_adc4, -0x1_9d70);           /* call 0x1008adc4 */
            ii(0x100a_4b34, 5); call(0x1008_ad90, -0x1_9da9);           /* call 0x1008ad90 */
            ii(0x100a_4b39, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_4b3b, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100a_4b3e, 5); call(0x1008_ad90, -0x1_9db3);           /* call 0x1008ad90 */
            ii(0x100a_4b43, 3); cmp(dx, ax);                            /* cmp dx, ax */
            ii(0x100a_4b46, 2); if(jnz(0x100a_4b6c, 0x24)) goto l_0x100a_4b6c; /* jnz 0x100a4b6c */
            ii(0x100a_4b48, 3); lea(eax, memd[ss, ebp - 44]);           /* lea eax, [ebp-0x2c] */
            ii(0x100a_4b4b, 5); call(0x1008_adc4, -0x1_9d8c);           /* call 0x1008adc4 */
            ii(0x100a_4b50, 6); mov(memd[ss, ebp - 240], eax);          /* mov [ebp-0xf0], eax */
            ii(0x100a_4b56, 6); mov(eax, memd[ss, ebp - 240]);          /* mov eax, [ebp-0xf0] */
            ii(0x100a_4b5c, 3); mov(edx, memd[ds, eax + 2]);            /* mov edx, [eax+0x2] */
            ii(0x100a_4b5f, 6); mov(eax, memd[ss, ebp - 240]);          /* mov eax, [ebp-0xf0] */
            ii(0x100a_4b65, 3); call_abs(memd[ds, edx + 32]);           /* call dword [edx+0x20] */
            ii(0x100a_4b68, 2); cmp(al, 8);                             /* cmp al, 0x8 */
            ii(0x100a_4b6a, 2); if(jz(0x100a_4b6e, 2)) goto l_0x100a_4b6e; /* jz 0x100a4b6e */
        l_0x100a_4b6c:
            ii(0x100a_4b6c, 2); jmp(0x100a_4b8b, 0x1d); goto l_0x100a_4b8b; /* jmp 0x100a4b8b */
        l_0x100a_4b6e:
            ii(0x100a_4b6e, 3); mov(eax, memd[ss, ebp - 40]);           /* mov eax, [ebp-0x28] */
            ii(0x100a_4b71, 5); add(eax, 0xfa);                         /* add eax, 0xfa */
            ii(0x100a_4b76, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100a_4b79, 3); lea(eax, memd[ss, ebp - 44]);           /* lea eax, [ebp-0x2c] */
            ii(0x100a_4b7c, 5); call(0x1008_adc4, -0x1_9dbd);           /* call 0x1008adc4 */
            ii(0x100a_4b81, 5); call(0x100a_2bc4, -0x1fc2);             /* call 0x100a2bc4 */
            ii(0x100a_4b86, 1); cwde();                                 /* cwde */
            ii(0x100a_4b87, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_4b89, 2); if(jle(0x100a_4b8d, 2)) goto l_0x100a_4b8d; /* jle 0x100a4b8d */
        l_0x100a_4b8b:
            ii(0x100a_4b8b, 2); jmp(0x100a_4ba5, 0x18); goto l_0x100a_4ba5; /* jmp 0x100a4ba5 */
        l_0x100a_4b8d:
            ii(0x100a_4b8d, 3); lea(eax, memd[ss, ebp - 44]);           /* lea eax, [ebp-0x2c] */
            ii(0x100a_4b90, 5); call(0x1008_adf8, -0x1_9d9d);           /* call 0x1008adf8 */
            ii(0x100a_4b95, 5); call(0x1009_c4c4, -0x86d6);             /* call 0x1009c4c4 */
            ii(0x100a_4b9a, 1); cwde();                                 /* cwde */
            ii(0x100a_4b9b, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100a_4b9d, 8); inc(memw[ds, eax + ebp - 236]);         /* inc word [eax+ebp-0xec] */
        l_0x100a_4ba5:
            ii(0x100a_4ba5, 5); jmp(0x100a_4b12, -0x98); goto l_0x100a_4b12; /* jmp 0x100a4b12 */
        l_0x100a_4baa:
            ii(0x100a_4baa, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x100a_4baf, 5); call(0x1007_6338, -0x2_e87c);           /* call 0x10076338 */
            ii(0x100a_4bb4, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_4bb6, 6); lea(eax, memd[ss, ebp - 244]);          /* lea eax, [ebp-0xf4] */
            ii(0x100a_4bbc, 5); call(0x1007_64b8, -0x2_e709);           /* call 0x100764b8 */
            ii(0x100a_4bc1, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x100a_4bc5, 5); call(0x100c_defa, 0x2_9330);            /* call 0x100cdefa */
            ii(0x100a_4bca, 3); mov(memd[ss, ebp - 36], eax);           /* mov [ebp-0x24], eax */
            ii(0x100a_4bcd, 7); mov(memd[ss, ebp - 32], 0);             /* mov dword [ebp-0x20], 0x0 */
            ii(0x100a_4bd4, 7); mov(memd[ss, ebp - 28], 0);             /* mov dword [ebp-0x1c], 0x0 */
            ii(0x100a_4bdb, 4); movsx(edx, memw[ss, ebp - 36]);         /* movsx edx, word [ebp-0x24] */
            ii(0x100a_4bdf, 6); lea(eax, memd[ss, ebp - 248]);          /* lea eax, [ebp-0xf8] */
            ii(0x100a_4be5, 5); call(0x100c_df95, 0x2_93ab);            /* call 0x100cdf95 */
            ii(0x100a_4bea, 2); jmp(0x100a_4bf7, 0xb); goto l_0x100a_4bf7; /* jmp 0x100a4bf7 */
        l_0x100a_4bec:
            ii(0x100a_4bec, 6); lea(eax, memd[ss, ebp - 244]);          /* lea eax, [ebp-0xf4] */
            ii(0x100a_4bf2, 5); call(0x1007_6bf8, -0x2_dfff);           /* call 0x10076bf8 */
        l_0x100a_4bf7:
            ii(0x100a_4bf7, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_4bf9, 6); lea(eax, memd[ss, ebp - 244]);          /* lea eax, [ebp-0xf4] */
            ii(0x100a_4bff, 5); call(0x1013_ad71, 0x9_616d);            /* call 0x1013ad71 */
            ii(0x100a_4c04, 2); test(al, al);                           /* test al, al */
            ii(0x100a_4c06, 2); if(jz(0x100a_4c3f, 0x37)) goto l_0x100a_4c3f; /* jz 0x100a4c3f */
            ii(0x100a_4c08, 6); lea(eax, memd[ss, ebp - 244]);          /* lea eax, [ebp-0xf4] */
            ii(0x100a_4c0e, 5); call(0x1007_63a0, -0x2_e873);           /* call 0x100763a0 */
            ii(0x100a_4c13, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_4c15, 3); mov(dl, memb[ds, eax + 38]);            /* mov dl, [eax+0x26] */
            ii(0x100a_4c18, 4); movsx(eax, memw[ss, ebp - 20]);         /* movsx eax, word [ebp-0x14] */
            ii(0x100a_4c1c, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100a_4c1e, 2); if(jnz(0x100a_4c35, 0x15)) goto l_0x100a_4c35; /* jnz 0x100a4c35 */
            ii(0x100a_4c20, 6); lea(eax, memd[ss, ebp - 244]);          /* lea eax, [ebp-0xf4] */
            ii(0x100a_4c26, 5); call(0x1007_63a0, -0x2_e88b);           /* call 0x100763a0 */
            ii(0x100a_4c2b, 4); mov(ax, memw[ds, eax + 8]);             /* mov ax, [eax+0x8] */
            ii(0x100a_4c2f, 4); cmp(ax, memw[ss, ebp - 36]);            /* cmp ax, [ebp-0x24] */
            ii(0x100a_4c33, 2); if(jz(0x100a_4c37, 2)) goto l_0x100a_4c37; /* jz 0x100a4c37 */
        l_0x100a_4c35:
            ii(0x100a_4c35, 2); jmp(0x100a_4c3d, 6); goto l_0x100a_4c3d; /* jmp 0x100a4c3d */
        l_0x100a_4c37:
            ii(0x100a_4c37, 3); mov(eax, memd[ss, ebp - 32]);           /* mov eax, [ebp-0x20] */
            ii(0x100a_4c3a, 3); inc(memd[ss, ebp - 32]);                /* inc dword [ebp-0x20] */
        l_0x100a_4c3d:
            ii(0x100a_4c3d, 2); jmp(0x100a_4bec, -0x53); goto l_0x100a_4bec; /* jmp 0x100a4bec */
        l_0x100a_4c3f:
            ii(0x100a_4c3f, 7); mov(memd[ss, ebp - 24], 0);             /* mov dword [ebp-0x18], 0x0 */
            ii(0x100a_4c46, 2); jmp(0x100a_4c4e, 6); goto l_0x100a_4c4e; /* jmp 0x100a4c4e */
        l_0x100a_4c48:
            ii(0x100a_4c48, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x100a_4c4b, 3); inc(memd[ss, ebp - 24]);                /* inc dword [ebp-0x18] */
        l_0x100a_4c4e:
            ii(0x100a_4c4e, 6); lea(eax, memd[ss, ebp - 248]);          /* lea eax, [ebp-0xf8] */
            ii(0x100a_4c54, 5); call(Definitions.my_2_get_count, -0x1_98f1); /* call 0x1008b368 */
            ii(0x100a_4c59, 4); cmp(ax, memw[ss, ebp - 24]);            /* cmp ax, [ebp-0x18] */
            ii(0x100a_4c5d, 2); if(jle(0x100a_4c80, 0x21)) goto l_0x100a_4c80; /* jle 0x100a4c80 */
            ii(0x100a_4c5f, 4); movsx(edx, memw[ss, ebp - 24]);         /* movsx edx, word [ebp-0x18] */
            ii(0x100a_4c63, 6); lea(eax, memd[ss, ebp - 248]);          /* lea eax, [ebp-0xf8] */
            ii(0x100a_4c69, 5); call(0x1008_b228, -0x1_9a46);           /* call 0x1008b228 */
            ii(0x100a_4c6e, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x100a_4c71, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100a_4c73, 8); mov(ax, memw[ds, eax + ebp - 236]);     /* mov ax, [eax+ebp-0xec] */
            ii(0x100a_4c7b, 3); add(memd[ss, ebp - 28], eax);           /* add [ebp-0x1c], eax */
            ii(0x100a_4c7e, 2); jmp(0x100a_4c48, -0x38); goto l_0x100a_4c48; /* jmp 0x100a4c48 */
        l_0x100a_4c80:
            ii(0x100a_4c80, 3); mov(eax, memd[ss, ebp - 32]);           /* mov eax, [ebp-0x20] */
            ii(0x100a_4c83, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100a_4c85, 1); inc(eax);                               /* inc eax */
            ii(0x100a_4c86, 3); sub(eax, memd[ss, ebp - 28]);           /* sub eax, [ebp-0x1c] */
            ii(0x100a_4c89, 3); mov(memd[ss, ebp - 32], eax);           /* mov [ebp-0x20], eax */
            ii(0x100a_4c8c, 3); mov(eax, memd[ss, ebp - 32]);           /* mov eax, [ebp-0x20] */
            ii(0x100a_4c8f, 4); cmp(ax, memw[ss, ebp - 4]);             /* cmp ax, [ebp-0x4] */
            ii(0x100a_4c93, 2); if(jle(0x100a_4c9b, 6)) goto l_0x100a_4c9b; /* jle 0x100a4c9b */
            ii(0x100a_4c95, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_4c98, 3); mov(memd[ss, ebp - 32], eax);           /* mov [ebp-0x20], eax */
        l_0x100a_4c9b:
            ii(0x100a_4c9b, 3); mov(eax, memd[ss, ebp - 32]);           /* mov eax, [ebp-0x20] */
            ii(0x100a_4c9e, 3); dec(memd[ss, ebp - 32]);                /* dec dword [ebp-0x20] */
            ii(0x100a_4ca1, 1); cwde();                                 /* cwde */
            ii(0x100a_4ca2, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_4ca4, 6); if(jle(0x100a_4d24, 0x7a)) goto l_0x100a_4d24; /* jle 0x100a4d24 */
            ii(0x100a_4caa, 5); mov(eax, 0x1e);                         /* mov eax, 0x1e */
            ii(0x100a_4caf, 5); call(Definitions.sys_new, 0xc_114c);    /* call 0x10165e00 */
            ii(0x100a_4cb4, 6); mov(memd[ss, ebp - 252], eax);          /* mov [ebp-0xfc], eax */
            ii(0x100a_4cba, 6); mov(eax, memd[ss, ebp - 252]);          /* mov eax, [ebp-0xfc] */
            ii(0x100a_4cc0, 6); mov(memd[ss, ebp - 256], eax);          /* mov [ebp-0x100], eax */
            ii(0x100a_4cc6, 7); cmp(memd[ss, ebp - 256], 0);            /* cmp dword [ebp-0x100], 0x0 */
            ii(0x100a_4ccd, 2); if(jz(0x100a_4d05, 0x36)) goto l_0x100a_4d05; /* jz 0x100a4d05 */
            ii(0x100a_4ccf, 3); mov(edx, memd[ss, ebp + 16]);           /* mov edx, [ebp+0x10] */
            ii(0x100a_4cd2, 6); lea(eax, memd[ss, ebp - 260]);          /* lea eax, [ebp-0x104] */
            ii(0x100a_4cd8, 5); call(0x1007_5e64, -0x2_ee79);           /* call 0x10075e64 */
            ii(0x100a_4cdd, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x100a_4cdf, 3); mov(ebx, memd[ss, ebp - 12]);           /* mov ebx, [ebp-0xc] */
            ii(0x100a_4ce2, 4); movsx(edx, memw[ss, ebp - 8]);          /* movsx edx, word [ebp-0x8] */
            ii(0x100a_4ce6, 6); mov(eax, memd[ss, ebp - 252]);          /* mov eax, [ebp-0xfc] */
            ii(0x100a_4cec, 5); call(0x1009_87c5, -0xc52c);             /* call 0x100987c5 */
            ii(0x100a_4cf1, 6); mov(memd[ss, ebp - 264], eax);          /* mov [ebp-0x108], eax */
            ii(0x100a_4cf7, 6); mov(eax, memd[ss, ebp - 264]);          /* mov eax, [ebp-0x108] */
            ii(0x100a_4cfd, 6); mov(memd[ss, ebp - 268], eax);          /* mov [ebp-0x10c], eax */
            ii(0x100a_4d03, 2); jmp(0x100a_4d11, 0xc); goto l_0x100a_4d11; /* jmp 0x100a4d11 */
        l_0x100a_4d05:
            ii(0x100a_4d05, 6); mov(eax, memd[ss, ebp - 256]);          /* mov eax, [ebp-0x100] */
            ii(0x100a_4d0b, 6); mov(memd[ss, ebp - 268], eax);          /* mov [ebp-0x10c], eax */
        l_0x100a_4d11:
            ii(0x100a_4d11, 6); mov(edx, memd[ss, ebp - 268]);          /* mov edx, [ebp-0x10c] */
            ii(0x100a_4d17, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100a_4d1a, 5); call(0x100a_4d50, 0x31);                /* call 0x100a4d50 */
            ii(0x100a_4d1f, 5); jmp(0x100a_4c9b, -0x89); goto l_0x100a_4c9b; /* jmp 0x100a4c9b */
        l_0x100a_4d24:
            ii(0x100a_4d24, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_4d26, 6); lea(eax, memd[ss, ebp - 248]);          /* lea eax, [ebp-0xf8] */
            ii(0x100a_4d2c, 5); call(0x1008_8b04, -0x1_c22d);           /* call 0x10088b04 */
            ii(0x100a_4d31, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_4d33, 6); lea(eax, memd[ss, ebp - 244]);          /* lea eax, [ebp-0xf4] */
            ii(0x100a_4d39, 5); call(0x1007_5f6c, -0x2_edd2);           /* call 0x10075f6c */
            ii(0x100a_4d3e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_4d40, 3); lea(eax, memd[ss, ebp - 44]);           /* lea eax, [ebp-0x2c] */
            ii(0x100a_4d43, 5); call(0x1008_8bbc, -0x1_c18c);           /* call 0x10088bbc */
        l_0x100a_4d48:
            ii(0x100a_4d48, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_4d4a, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_4d4b, 1); pop(edi);                               /* pop edi */
            ii(0x100a_4d4c, 1); pop(esi);                               /* pop esi */
            ii(0x100a_4d4d, 3); ret(4);                                 /* ret 0x4 */
        }
    }
}
