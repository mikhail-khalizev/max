using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_7a19-3537819e")]
        public void Method_1013_7a19()
        {
            ii(0x1013_7a19, 5); push(0x178);                            /* push 0x178 */
            ii(0x1013_7a1e, 5); call(Definitions.sys_check_available_stack_size, 0x2_e32f); /* call 0x10165d52 */
            ii(0x1013_7a23, 1); push(esi);                              /* push esi */
            ii(0x1013_7a24, 1); push(edi);                              /* push edi */
            ii(0x1013_7a25, 1); push(ebp);                              /* push ebp */
            ii(0x1013_7a26, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_7a28, 6); sub(esp, 0x144);                        /* sub esp, 0x144 */
            ii(0x1013_7a2e, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x1013_7a31, 3); mov(memd[ss, ebp - 12], edx);           /* mov [ebp-0xc], edx */
            ii(0x1013_7a34, 3); mov(memd[ss, ebp - 8], ebx);            /* mov [ebp-0x8], ebx */
            ii(0x1013_7a37, 3); mov(memd[ss, ebp - 4], ecx);            /* mov [ebp-0x4], ecx */
            ii(0x1013_7a3a, 5); call(/* sys */ 0x1016_be34, 0x3_43f5);  /* call 0x1016be34 */
            ii(0x1013_7a3f, 4); cmp(memb[ss, ebp + 32], 0);             /* cmp byte [ebp+0x20], 0x0 */
            ii(0x1013_7a43, 2); if(jz(0x1013_7a75, 0x30)) goto l_0x1013_7a75; /* jz 0x10137a75 */
            ii(0x1013_7a45, 5); call(0x100d_533c, -0x6_270e);           /* call 0x100d533c */
            ii(0x1013_7a4a, 1); cwde();                                 /* cwde */
            ii(0x1013_7a4b, 1); push(eax);                              /* push eax */
            ii(0x1013_7a4c, 5); call(0x100d_5360, -0x6_26f1);           /* call 0x100d5360 */
            ii(0x1013_7a51, 1); cwde();                                 /* cwde */
            ii(0x1013_7a52, 1); push(eax);                              /* push eax */
            ii(0x1013_7a53, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_7a55, 1); push(eax);                              /* push eax */
            ii(0x1013_7a56, 5); mov(ecx, 1);                            /* mov ecx, 0x1 */
            ii(0x1013_7a5b, 5); mov(ebx, 0x280);                        /* mov ebx, 0x280 */
            ii(0x1013_7a60, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_7a62, 5); call(0x100e_883d, -0x4_f22a);           /* call 0x100e883d */
            ii(0x1013_7a67, 5); mov(esi, 0x6c2);                        /* mov esi, 0x6c2 */
            ii(0x1013_7a6c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1013_7a6e, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1013_7a70, 5); call(0x100e_8c51, -0x4_ee24);           /* call 0x100e8c51 */
        l_0x1013_7a75:
            ii(0x1013_7a75, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_7a77, 5); call(0x100e_883d, -0x4_f23f);           /* call 0x100e883d */
            ii(0x1013_7a7c, 3); mov(memd[ss, ebp - 20], eax);           /* mov [ebp-0x14], eax */
            ii(0x1013_7a7f, 5); mov(eax, 5);                            /* mov eax, 0x5 */
            ii(0x1013_7a84, 5); call(/* sys */ 0x1016_a24c, 0x3_27c3);  /* call 0x1016a24c */
            ii(0x1013_7a89, 5); call(0x100d_531c, -0x6_2772);           /* call 0x100d531c */
            ii(0x1013_7a8e, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1013_7a93, 3); mov(memd[ss, ebp - 24], eax);           /* mov [ebp-0x18], eax */
            ii(0x1013_7a96, 3); push(memd[ss, ebp - 24]);               /* push dword [ebp-0x18] */
            ii(0x1013_7a99, 7); mov(memd[ss, ebp - 28], 1);             /* mov dword [ebp-0x1c], 0x1 */
            ii(0x1013_7aa0, 3); push(memd[ss, ebp - 28]);               /* push dword [ebp-0x1c] */
            ii(0x1013_7aa3, 2); push(2);                                /* push 0x2 */
            ii(0x1013_7aa5, 7); mov(memd[ss, ebp - 32], 0x15);          /* mov dword [ebp-0x20], 0x15 */
            ii(0x1013_7aac, 3); push(memd[ss, ebp - 32]);               /* push dword [ebp-0x20] */
            ii(0x1013_7aaf, 7); mov(memd[ss, ebp - 36], 0xb5);          /* mov dword [ebp-0x24], 0xb5 */
            ii(0x1013_7ab6, 3); push(memd[ss, ebp - 36]);               /* push dword [ebp-0x24] */
            ii(0x1013_7ab9, 7); mov(memd[ss, ebp - 40], 5);             /* mov dword [ebp-0x28], 0x5 */
            ii(0x1013_7ac0, 3); push(memd[ss, ebp - 40]);               /* push dword [ebp-0x28] */
            ii(0x1013_7ac3, 7); mov(memd[ss, ebp - 44], 0xe5);          /* mov dword [ebp-0x2c], 0xe5 */
            ii(0x1013_7aca, 4); cmp(memb[ss, ebp + 16], 0);             /* cmp byte [ebp+0x10], 0x0 */
            ii(0x1013_7ace, 2); if(jz(0x1013_7ad9, 9)) goto l_0x1013_7ad9; /* jz 0x10137ad9 */
            ii(0x1013_7ad0, 7); mov(memd[ss, ebp - 48], StringDefinitions.SaveLoadMenu); /* mov dword [ebp-0x30], 0x101ac7d6 */
            ii(0x1013_7ad7, 2); jmp(0x1013_7ae0, 7); goto l_0x1013_7ae0; /* jmp 0x10137ae0 */
        l_0x1013_7ad9:
            ii(0x1013_7ad9, 7); mov(memd[ss, ebp - 48], StringDefinitions.LoadMenu); /* mov dword [ebp-0x30], 0x101ac7e5 */
        l_0x1013_7ae0:
            ii(0x1013_7ae0, 3); mov(ebx, memd[ss, ebp - 48]);           /* mov ebx, [ebp-0x30] */
            ii(0x1013_7ae3, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x1013_7ae6, 3); mov(edx, memd[ds, eax + 14]);           /* mov edx, [eax+0xe] */
            ii(0x1013_7ae9, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1013_7aec, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x1013_7aef, 3); mov(eax, memd[ds, eax + 22]);           /* mov eax, [eax+0x16] */
            ii(0x1013_7af2, 3); mov(ecx, memd[ss, ebp - 44]);           /* mov ecx, [ebp-0x2c] */
            ii(0x1013_7af5, 5); call(0x100e_9ae5, -0x4_e015);           /* call 0x100e9ae5 */
            ii(0x1013_7afa, 7); mov(memd[ss, ebp - 52], 0);             /* mov dword [ebp-0x34], 0x0 */
            ii(0x1013_7b01, 2); jmp(0x1013_7b09, 6); goto l_0x1013_7b09; /* jmp 0x10137b09 */
        l_0x1013_7b03:
            ii(0x1013_7b03, 3); mov(eax, memd[ss, ebp - 52]);           /* mov eax, [ebp-0x34] */
            ii(0x1013_7b06, 3); inc(memd[ss, ebp - 52]);                /* inc dword [ebp-0x34] */
        l_0x1013_7b09:
            ii(0x1013_7b09, 3); mov(eax, memd[ss, ebp - 52]);           /* mov eax, [ebp-0x34] */
            ii(0x1013_7b0c, 3); cmp(eax, memd[ss, ebp - 12]);           /* cmp eax, [ebp-0xc] */
            ii(0x1013_7b0f, 6); if(jge(0x1013_8066, 0x551)) goto l_0x1013_8066; /* jge 0x10138066 */
            ii(0x1013_7b15, 4); cmp(memb[ss, ebp + 20], 0);             /* cmp byte [ebp+0x14], 0x0 */
            ii(0x1013_7b19, 2); if(jz(0x1013_7b3e, 0x23)) goto l_0x1013_7b3e; /* jz 0x10137b3e */
            ii(0x1013_7b1b, 4); movsx(eax, memw[ss, ebp + 28]);         /* movsx eax, word [ebp+0x1c] */
            ii(0x1013_7b1f, 3); add(eax, memd[ss, ebp - 52]);           /* add eax, [ebp-0x34] */
            ii(0x1013_7b22, 1); push(eax);                              /* push eax */
            ii(0x1013_7b23, 5); mov(eax, StringDefinitions.ScnrioITxt); /* mov eax, 0x101ac7ef */
            ii(0x1013_7b28, 1); push(eax);                              /* push eax */
            ii(0x1013_7b29, 4); imul(eax, memd[ss, ebp - 52], 0x53);    /* imul eax, [ebp-0x34], 0x53 */
            ii(0x1013_7b2d, 3); add(eax, memd[ss, ebp - 16]);           /* add eax, [ebp-0x10] */
            ii(0x1013_7b30, 3); add(eax, 0x20);                         /* add eax, 0x20 */
            ii(0x1013_7b33, 1); push(eax);                              /* push eax */
            ii(0x1013_7b34, 5); call(Definitions.sys_sprintf, 0x2_e3c8); /* call 0x10165f01 */
            ii(0x1013_7b39, 3); add(esp, 0xc);                          /* add esp, 0xc */
            ii(0x1013_7b3c, 2); jmp(0x1013_7b6c, 0x2e); goto l_0x1013_7b6c; /* jmp 0x10137b6c */
        l_0x1013_7b3e:
            ii(0x1013_7b3e, 4); movsx(eax, memb[ss, ebp + 24]);         /* movsx eax, byte [ebp+0x18] */
            ii(0x1013_7b42, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1013_7b45, 6); push(memd[ds, eax + 0x101b_d42c]);      /* push dword [eax+0x101bd42c] */
            ii(0x1013_7b4b, 4); movsx(eax, memw[ss, ebp + 28]);         /* movsx eax, word [ebp+0x1c] */
            ii(0x1013_7b4f, 3); add(eax, memd[ss, ebp - 52]);           /* add eax, [ebp-0x34] */
            ii(0x1013_7b52, 1); push(eax);                              /* push eax */
            ii(0x1013_7b53, 5); mov(eax, StringDefinitions.SaveIS);     /* mov eax, 0x101ac7fc */
            ii(0x1013_7b58, 1); push(eax);                              /* push eax */
            ii(0x1013_7b59, 4); imul(eax, memd[ss, ebp - 52], 0x53);    /* imul eax, [ebp-0x34], 0x53 */
            ii(0x1013_7b5d, 3); add(eax, memd[ss, ebp - 16]);           /* add eax, [ebp-0x10] */
            ii(0x1013_7b60, 3); add(eax, 0x20);                         /* add eax, 0x20 */
            ii(0x1013_7b63, 1); push(eax);                              /* push eax */
            ii(0x1013_7b64, 5); call(Definitions.sys_sprintf, 0x2_e398); /* call 0x10165f01 */
            ii(0x1013_7b69, 3); add(esp, 0x10);                         /* add esp, 0x10 */
        l_0x1013_7b6c:
            ii(0x1013_7b6c, 5); mov(eax, 0x3e);                         /* mov eax, 0x3e */
            ii(0x1013_7b71, 5); call(0x1007_5fdc, -0xc_1b9a);           /* call 0x10075fdc */
            ii(0x1013_7b76, 3); mov(memb[ss, ebp - 56], al);            /* mov [ebp-0x38], al */
            ii(0x1013_7b79, 5); mov(edx, 0x101c_3d70);                  /* mov edx, 0x101c3d70 */
            ii(0x1013_7b7e, 6); lea(eax, memd[ss, ebp - 156]);          /* lea eax, [ebp-0x9c] */
            ii(0x1013_7b84, 5); call(Definitions.sys_strcpy, 0x2_e346); /* call 0x10165ecf */
            ii(0x1013_7b89, 4); imul(eax, memd[ss, ebp - 52], 0x53);    /* imul eax, [ebp-0x34], 0x53 */
            ii(0x1013_7b8d, 3); add(eax, memd[ss, ebp - 16]);           /* add eax, [ebp-0x10] */
            ii(0x1013_7b90, 3); lea(edx, memd[ds, eax + 32]);           /* lea edx, [eax+0x20] */
            ii(0x1013_7b93, 6); lea(eax, memd[ss, ebp - 156]);          /* lea eax, [ebp-0x9c] */
            ii(0x1013_7b99, 5); call(Definitions.sys_strcat, 0x2_e393); /* call 0x10165f31 */
            ii(0x1013_7b9e, 5); mov(edx, StringDefinitions.Rb5);        /* mov edx, 0x101ac806 */
            ii(0x1013_7ba3, 6); lea(eax, memd[ss, ebp - 156]);          /* lea eax, [ebp-0x9c] */
            ii(0x1013_7ba9, 5); call(Definitions.sys_fopen, 0x3_a7cc);  /* call 0x1017237a */
            ii(0x1013_7bae, 6); mov(memd[ss, ebp - 160], eax);          /* mov [ebp-0xa0], eax */
            ii(0x1013_7bb4, 7); cmp(memd[ss, ebp - 160], 0);            /* cmp dword [ebp-0xa0], 0x0 */
            ii(0x1013_7bbb, 2); if(jnz(0x1013_7bcd, 0x10)) goto l_0x1013_7bcd; /* jnz 0x10137bcd */
            ii(0x1013_7bbd, 4); imul(eax, memd[ss, ebp - 52], 0x53);    /* imul eax, [ebp-0x34], 0x53 */
            ii(0x1013_7bc1, 3); add(eax, memd[ss, ebp - 16]);           /* add eax, [ebp-0x10] */
            ii(0x1013_7bc4, 4); mov(memb[ds, eax + 77], 0);             /* mov byte [eax+0x4d], 0x0 */
            ii(0x1013_7bc8, 5); jmp(0x1013_7c3f, 0x72); goto l_0x1013_7c3f; /* jmp 0x10137c3f */
        l_0x1013_7bcd:
            ii(0x1013_7bcd, 4); cmp(memb[ss, ebp + 20], 0);             /* cmp byte [ebp+0x14], 0x0 */
            ii(0x1013_7bd1, 2); if(jz(0x1013_7be0, 0xd)) goto l_0x1013_7be0; /* jz 0x10137be0 */
            ii(0x1013_7bd3, 4); imul(eax, memd[ss, ebp - 52], 0x53);    /* imul eax, [ebp-0x34], 0x53 */
            ii(0x1013_7bd7, 3); add(eax, memd[ss, ebp - 16]);           /* add eax, [ebp-0x10] */
            ii(0x1013_7bda, 4); mov(memb[ds, eax + 77], 1);             /* mov byte [eax+0x4d], 0x1 */
            ii(0x1013_7bde, 2); jmp(0x1013_7c3f, 0x5f); goto l_0x1013_7c3f; /* jmp 0x10137c3f */
        l_0x1013_7be0:
            ii(0x1013_7be0, 6); mov(ecx, memd[ss, ebp - 160]);          /* mov ecx, [ebp-0xa0] */
            ii(0x1013_7be6, 5); mov(ebx, 2);                            /* mov ebx, 0x2 */
            ii(0x1013_7beb, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1013_7bf0, 6); lea(eax, memd[ss, ebp - 168]);          /* lea eax, [ebp-0xa8] */
            ii(0x1013_7bf6, 5); call(Definitions.sys_fread, 0x3_a971);  /* call 0x1017256c */
            ii(0x1013_7bfb, 7); movsx(eax, memw[ss, ebp - 168]);        /* movsx eax, word [ebp-0xa8] */
            ii(0x1013_7c02, 3); cmp(eax, 0x46);                         /* cmp eax, 0x46 */
            ii(0x1013_7c05, 2); if(jnz(0x1013_7c10, 9)) goto l_0x1013_7c10; /* jnz 0x10137c10 */
            ii(0x1013_7c07, 7); mov(memb[ss, ebp - 164], 1);            /* mov byte [ebp-0xa4], 0x1 */
            ii(0x1013_7c0e, 2); jmp(0x1013_7c17, 7); goto l_0x1013_7c17; /* jmp 0x10137c17 */
        l_0x1013_7c10:
            ii(0x1013_7c10, 7); mov(memb[ss, ebp - 164], 0);            /* mov byte [ebp-0xa4], 0x0 */
        l_0x1013_7c17:
            ii(0x1013_7c17, 4); imul(ecx, memd[ss, ebp - 52], 0x53);    /* imul ecx, [ebp-0x34], 0x53 */
            ii(0x1013_7c1b, 3); add(ecx, memd[ss, ebp - 16]);           /* add ecx, [ebp-0x10] */
            ii(0x1013_7c1e, 6); mov(al, memb[ss, ebp - 164]);           /* mov al, [ebp-0xa4] */
            ii(0x1013_7c24, 3); mov(memb[ds, ecx + 77], al);            /* mov [ecx+0x4d], al */
            ii(0x1013_7c27, 6); mov(ecx, memd[ss, ebp - 160]);          /* mov ecx, [ebp-0xa0] */
            ii(0x1013_7c2d, 5); mov(ebx, 1);                            /* mov ebx, 0x1 */
            ii(0x1013_7c32, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1013_7c37, 3); lea(eax, memd[ss, ebp - 56]);           /* lea eax, [ebp-0x38] */
            ii(0x1013_7c3a, 5); call(Definitions.sys_fread, 0x3_a92d);  /* call 0x1017256c */
        l_0x1013_7c3f:
            ii(0x1013_7c3f, 4); imul(edx, memd[ss, ebp - 52], 0x53);    /* imul edx, [ebp-0x34], 0x53 */
            ii(0x1013_7c43, 3); add(edx, memd[ss, ebp - 16]);           /* add edx, [ebp-0x10] */
            ii(0x1013_7c46, 3); mov(al, memb[ss, ebp - 56]);            /* mov al, [ebp-0x38] */
            ii(0x1013_7c49, 3); mov(memb[ds, edx + 78], al);            /* mov [edx+0x4e], al */
            ii(0x1013_7c4c, 4); imul(edx, memd[ss, ebp - 52], 0x53);    /* imul edx, [ebp-0x34], 0x53 */
            ii(0x1013_7c50, 3); add(edx, memd[ss, ebp - 16]);           /* add edx, [ebp-0x10] */
            ii(0x1013_7c53, 4); cmp(memb[ds, edx + 77], 0);             /* cmp byte [edx+0x4d], 0x0 */
            ii(0x1013_7c57, 6); if(jz(0x1013_7d49, 0xec)) goto l_0x1013_7d49; /* jz 0x10137d49 */
            ii(0x1013_7c5d, 4); cmp(memb[ss, ebp + 20], 0);             /* cmp byte [ebp+0x14], 0x0 */
            ii(0x1013_7c61, 6); if(jz(0x1013_7d28, 0xc1)) goto l_0x1013_7d28; /* jz 0x10137d28 */
            ii(0x1013_7c67, 6); mov(eax, memd[ss, ebp - 160]);          /* mov eax, [ebp-0xa0] */
            ii(0x1013_7c6d, 5); call(Definitions.sys_fclose, 0x3_a3f7); /* call 0x10172069 */
            ii(0x1013_7c72, 10); mov(memd[ss, ebp - 160], 0);           /* mov dword [ebp-0xa0], 0x0 */
            ii(0x1013_7c7c, 7); or(memb[ss, ebp - 172], 1);             /* or byte [ebp-0xac], 0x1 */
            ii(0x1013_7c83, 6); lea(eax, memd[ss, ebp - 208]);          /* lea eax, [ebp-0xd0] */
            ii(0x1013_7c89, 5); call(0x1014_6562, 0xe8d4);              /* call 0x10146562 */
            ii(0x1013_7c8e, 6); mov(memd[ss, ebp - 212], eax);          /* mov [ebp-0xd4], eax */
            ii(0x1013_7c94, 7); and(memb[ss, ebp - 172], -2 /* 0xfe */); /* and byte [ebp-0xac], 0xfe */
            ii(0x1013_7c9b, 6); lea(edx, memd[ss, ebp - 156]);          /* lea edx, [ebp-0x9c] */
            ii(0x1013_7ca1, 6); lea(eax, memd[ss, ebp - 208]);          /* lea eax, [ebp-0xd0] */
            ii(0x1013_7ca7, 5); call(0x1014_65ce, 0xe922);              /* call 0x101465ce */
            ii(0x1013_7cac, 6); lea(edx, memd[ss, ebp - 216]);          /* lea edx, [ebp-0xd8] */
            ii(0x1013_7cb2, 6); lea(eax, memd[ss, ebp - 208]);          /* lea eax, [ebp-0xd0] */
            ii(0x1013_7cb8, 5); call(0x1013_9e7c, 0x21bf);              /* call 0x10139e7c */
            ii(0x1013_7cbd, 5); mov(ebx, StringDefinitions.Description2); /* mov ebx, 0x101ac809 */
            ii(0x1013_7cc2, 6); lea(edx, memd[ss, ebp - 220]);          /* lea edx, [ebp-0xdc] */
            ii(0x1013_7cc8, 6); lea(eax, memd[ss, ebp - 216]);          /* lea eax, [ebp-0xd8] */
            ii(0x1013_7cce, 5); call(0x100e_0648, -0x5_768b);           /* call 0x100e0648 */
            ii(0x1013_7cd3, 5); call(0x1014_60f3, 0xe41b);              /* call 0x101460f3 */
            ii(0x1013_7cd8, 6); lea(eax, memd[ss, ebp - 220]);          /* lea eax, [ebp-0xdc] */
            ii(0x1013_7cde, 5); call(Definitions.my_strobj_c_str_v2, -0xa_e51b); /* call 0x100897c8 */
            ii(0x1013_7ce3, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1013_7ce5, 4); imul(eax, memd[ss, ebp - 52], 0x53);    /* imul eax, [ebp-0x34], 0x53 */
            ii(0x1013_7ce9, 3); add(eax, memd[ss, ebp - 16]);           /* add eax, [ebp-0x10] */
            ii(0x1013_7cec, 3); add(eax, 0x2f);                         /* add eax, 0x2f */
            ii(0x1013_7cef, 5); call(Definitions.sys_strcpy, 0x2_e1db); /* call 0x10165ecf */
            ii(0x1013_7cf4, 6); lea(eax, memd[ss, ebp - 208]);          /* lea eax, [ebp-0xd0] */
            ii(0x1013_7cfa, 5); call(0x1014_66df, 0xe9e0);              /* call 0x101466df */
            ii(0x1013_7cff, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_7d01, 6); lea(eax, memd[ss, ebp - 220]);          /* lea eax, [ebp-0xdc] */
            ii(0x1013_7d07, 5); call(Definitions.my_string_dtor, 0x9e1e); /* call 0x10141b2a */
            ii(0x1013_7d0c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_7d0e, 6); lea(eax, memd[ss, ebp - 216]);          /* lea eax, [ebp-0xd8] */
            ii(0x1013_7d14, 5); call(0x100e_03fc, -0x5_791d);           /* call 0x100e03fc */
            ii(0x1013_7d19, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_7d1b, 6); lea(eax, memd[ss, ebp - 208]);          /* lea eax, [ebp-0xd0] */
            ii(0x1013_7d21, 5); call(0x1013_9e18, 0x20f2);              /* call 0x10139e18 */
            ii(0x1013_7d26, 2); jmp(0x1013_7d47, 0x1f); goto l_0x1013_7d47; /* jmp 0x10137d47 */
        l_0x1013_7d28:
            ii(0x1013_7d28, 6); mov(ecx, memd[ss, ebp - 160]);          /* mov ecx, [ebp-0xa0] */
            ii(0x1013_7d2e, 5); mov(ebx, 0x1e);                         /* mov ebx, 0x1e */
            ii(0x1013_7d33, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1013_7d38, 4); imul(eax, memd[ss, ebp - 52], 0x53);    /* imul eax, [ebp-0x34], 0x53 */
            ii(0x1013_7d3c, 3); add(eax, memd[ss, ebp - 16]);           /* add eax, [ebp-0x10] */
            ii(0x1013_7d3f, 3); add(eax, 0x2f);                         /* add eax, 0x2f */
            ii(0x1013_7d42, 5); call(Definitions.sys_fread, 0x3_a825);  /* call 0x1017256c */
        l_0x1013_7d47:
            ii(0x1013_7d47, 2); jmp(0x1013_7d54, 0xb); goto l_0x1013_7d54; /* jmp 0x10137d54 */
        l_0x1013_7d49:
            ii(0x1013_7d49, 4); imul(eax, memd[ss, ebp - 52], 0x53);    /* imul eax, [ebp-0x34], 0x53 */
            ii(0x1013_7d4d, 3); add(eax, memd[ss, ebp - 16]);           /* add eax, [ebp-0x10] */
            ii(0x1013_7d50, 4); mov(memb[ds, eax + 47], 0);             /* mov byte [eax+0x2f], 0x0 */
        l_0x1013_7d54:
            ii(0x1013_7d54, 7); cmp(memd[ss, ebp - 160], 0);            /* cmp dword [ebp-0xa0], 0x0 */
            ii(0x1013_7d5b, 2); if(jz(0x1013_7d68, 0xb)) goto l_0x1013_7d68; /* jz 0x10137d68 */
            ii(0x1013_7d5d, 6); mov(eax, memd[ss, ebp - 160]);          /* mov eax, [ebp-0xa0] */
            ii(0x1013_7d63, 5); call(Definitions.sys_fclose, 0x3_a301); /* call 0x10172069 */
        l_0x1013_7d68:
            ii(0x1013_7d68, 3); mov(eax, memd[ss, ebp - 52]);           /* mov eax, [ebp-0x34] */
            ii(0x1013_7d6b, 5); add(eax, 0x4c5);                        /* add eax, 0x4c5 */
            ii(0x1013_7d70, 1); cwde();                                 /* cwde */
            ii(0x1013_7d71, 5); call(Definitions.my_get_res_data_by_id_malloc, -0x3b8b); /* call 0x101341eb */
            ii(0x1013_7d76, 6); mov(memd[ss, ebp - 224], eax);          /* mov [ebp-0xe0], eax */
            ii(0x1013_7d7c, 3); mov(eax, memd[ss, ebp - 52]);           /* mov eax, [ebp-0x34] */
            ii(0x1013_7d7f, 5); add(eax, 0x4cf);                        /* add eax, 0x4cf */
            ii(0x1013_7d84, 1); cwde();                                 /* cwde */
            ii(0x1013_7d85, 5); call(Definitions.my_get_res_data_by_id_malloc, -0x3b9f); /* call 0x101341eb */
            ii(0x1013_7d8a, 6); mov(memd[ss, ebp - 228], eax);          /* mov [ebp-0xe4], eax */
            ii(0x1013_7d90, 6); mov(eax, memd[ss, ebp - 224]);          /* mov eax, [ebp-0xe0] */
            ii(0x1013_7d96, 2); mov(edx, memd[ds, eax]);                /* mov edx, [eax] */
            ii(0x1013_7d98, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1013_7d9b, 6); mov(eax, memd[ss, ebp - 224]);          /* mov eax, [ebp-0xe0] */
            ii(0x1013_7da1, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x1013_7da4, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x1013_7da7, 6); mov(memd[ss, ebp - 232], eax);          /* mov [ebp-0xe8], eax */
            ii(0x1013_7dad, 6); mov(eax, memd[ss, ebp - 228]);          /* mov eax, [ebp-0xe4] */
            ii(0x1013_7db3, 2); mov(edx, memd[ds, eax]);                /* mov edx, [eax] */
            ii(0x1013_7db5, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1013_7db8, 6); mov(eax, memd[ss, ebp - 228]);          /* mov eax, [ebp-0xe4] */
            ii(0x1013_7dbe, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x1013_7dc1, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x1013_7dc4, 6); mov(memd[ss, ebp - 236], eax);          /* mov [ebp-0xec], eax */
            ii(0x1013_7dca, 6); mov(eax, memd[ss, ebp - 232]);          /* mov eax, [ebp-0xe8] */
            ii(0x1013_7dd0, 5); call(Definitions.sys_new_arr, 0x2_e23b); /* call 0x10166010 */
            ii(0x1013_7dd5, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1013_7dd7, 4); imul(eax, memd[ss, ebp - 52], 0x53);    /* imul eax, [ebp-0x34], 0x53 */
            ii(0x1013_7ddb, 3); add(eax, memd[ss, ebp - 16]);           /* add eax, [ebp-0x10] */
            ii(0x1013_7dde, 3); mov(memd[ds, eax + 20], edx);           /* mov [eax+0x14], edx */
            ii(0x1013_7de1, 6); mov(eax, memd[ss, ebp - 232]);          /* mov eax, [ebp-0xe8] */
            ii(0x1013_7de7, 5); call(Definitions.sys_new_arr, 0x2_e224); /* call 0x10166010 */
            ii(0x1013_7dec, 4); imul(edx, memd[ss, ebp - 52], 0x53);    /* imul edx, [ebp-0x34], 0x53 */
            ii(0x1013_7df0, 3); add(edx, memd[ss, ebp - 16]);           /* add edx, [ebp-0x10] */
            ii(0x1013_7df3, 3); mov(memd[ds, edx + 24], eax);           /* mov [edx+0x18], eax */
            ii(0x1013_7df6, 6); mov(ebx, memd[ss, ebp - 232]);          /* mov ebx, [ebp-0xe8] */
            ii(0x1013_7dfc, 6); mov(edx, memd[ss, ebp - 224]);          /* mov edx, [ebp-0xe0] */
            ii(0x1013_7e02, 3); add(edx, 8);                            /* add edx, 0x8 */
            ii(0x1013_7e05, 4); imul(eax, memd[ss, ebp - 52], 0x53);    /* imul eax, [ebp-0x34], 0x53 */
            ii(0x1013_7e09, 3); add(eax, memd[ss, ebp - 16]);           /* add eax, [ebp-0x10] */
            ii(0x1013_7e0c, 3); mov(eax, memd[ds, eax + 20]);           /* mov eax, [eax+0x14] */
            ii(0x1013_7e0f, 5); call(Definitions.sys_memcpy, 0x2_e037); /* call 0x10165e4b */
            ii(0x1013_7e14, 6); mov(ebx, memd[ss, ebp - 236]);          /* mov ebx, [ebp-0xec] */
            ii(0x1013_7e1a, 6); mov(edx, memd[ss, ebp - 228]);          /* mov edx, [ebp-0xe4] */
            ii(0x1013_7e20, 3); add(edx, 8);                            /* add edx, 0x8 */
            ii(0x1013_7e23, 4); imul(eax, memd[ss, ebp - 52], 0x53);    /* imul eax, [ebp-0x34], 0x53 */
            ii(0x1013_7e27, 3); add(eax, memd[ss, ebp - 16]);           /* add eax, [ebp-0x10] */
            ii(0x1013_7e2a, 3); mov(eax, memd[ds, eax + 24]);           /* mov eax, [eax+0x18] */
            ii(0x1013_7e2d, 5); call(Definitions.sys_memcpy, 0x2_e019); /* call 0x10165e4b */
            ii(0x1013_7e32, 5); mov(eax, 1);                            /* mov eax, 0x1 */
            ii(0x1013_7e37, 5); call(/* sys */ 0x1016_a24c, 0x3_2410);  /* call 0x1016a24c */
            ii(0x1013_7e3c, 4); imul(eax, memd[ss, ebp - 52], 0x53);    /* imul eax, [ebp-0x34], 0x53 */
            ii(0x1013_7e40, 3); add(eax, memd[ss, ebp - 16]);           /* add eax, [ebp-0x10] */
            ii(0x1013_7e43, 3); mov(eax, memd[ds, eax + 20]);           /* mov eax, [eax+0x14] */
            ii(0x1013_7e46, 6); mov(memd[ss, ebp - 242], eax);          /* mov [ebp-0xf2], eax */
            ii(0x1013_7e4c, 6); mov(eax, memd[ss, ebp - 224]);          /* mov eax, [ebp-0xe0] */
            ii(0x1013_7e52, 3); mov(ax, memw[ds, eax]);                 /* mov ax, [eax] */
            ii(0x1013_7e55, 7); mov(memw[ss, ebp - 248], ax);           /* mov [ebp-0xf8], ax */
            ii(0x1013_7e5c, 5); mov(ebx, 0xa);                          /* mov ebx, 0xa */
            ii(0x1013_7e61, 6); lea(edx, memd[ss, ebp - 272]);          /* lea edx, [ebp-0x110] */
            ii(0x1013_7e67, 4); movsx(eax, memw[ss, ebp + 28]);         /* movsx eax, word [ebp+0x1c] */
            ii(0x1013_7e6b, 3); add(eax, memd[ss, ebp - 52]);           /* add eax, [ebp-0x34] */
            ii(0x1013_7e6e, 5); call(/* sys */ 0x1017_93f8, 0x4_1585);  /* call 0x101793f8 */
            ii(0x1013_7e73, 5); mov(ecx, 0xc7);                         /* mov ecx, 0xc7 */
            ii(0x1013_7e78, 5); mov(ebx, 0xb1);                         /* mov ebx, 0xb1 */
            ii(0x1013_7e7d, 5); mov(edx, 0xa5);                         /* mov edx, 0xa5 */
            ii(0x1013_7e82, 6); lea(eax, memd[ss, ebp - 276]);          /* lea eax, [ebp-0x114] */
            ii(0x1013_7e88, 5); call(0x100d_53a4, -0x6_2ae9);           /* call 0x100d53a4 */
            ii(0x1013_7e8d, 1); push(eax);                              /* push eax */
            ii(0x1013_7e8e, 5); mov(eax, 1);                            /* mov eax, 0x1 */
            ii(0x1013_7e93, 1); push(eax);                              /* push eax */
            ii(0x1013_7e94, 5); mov(eax, 1);                            /* mov eax, 0x1 */
            ii(0x1013_7e99, 1); push(eax);                              /* push eax */
            ii(0x1013_7e9a, 5); mov(eax, 0x46);                         /* mov eax, 0x46 */
            ii(0x1013_7e9f, 1); push(eax);                              /* push eax */
            ii(0x1013_7ea0, 5); mov(eax, 0x28);                         /* mov eax, 0x28 */
            ii(0x1013_7ea5, 1); push(eax);                              /* push eax */
            ii(0x1013_7ea6, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1013_7ea8, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1013_7eaa, 6); lea(edx, memd[ss, ebp - 272]);          /* lea edx, [ebp-0x110] */
            ii(0x1013_7eb0, 6); lea(eax, memd[ss, ebp - 264]);          /* lea eax, [ebp-0x108] */
            ii(0x1013_7eb6, 5); call(0x100e_ab9d, -0x4_d31e);           /* call 0x100eab9d */
            ii(0x1013_7ebb, 4); imul(eax, memd[ss, ebp - 52], 0x53);    /* imul eax, [ebp-0x34], 0x53 */
            ii(0x1013_7ebf, 3); add(eax, memd[ss, ebp - 16]);           /* add eax, [ebp-0x10] */
            ii(0x1013_7ec2, 3); mov(eax, memd[ds, eax + 24]);           /* mov eax, [eax+0x18] */
            ii(0x1013_7ec5, 6); mov(memd[ss, ebp - 242], eax);          /* mov [ebp-0xf2], eax */
            ii(0x1013_7ecb, 6); mov(eax, memd[ss, ebp - 228]);          /* mov eax, [ebp-0xe4] */
            ii(0x1013_7ed1, 3); mov(ax, memw[ds, eax]);                 /* mov ax, [eax] */
            ii(0x1013_7ed4, 7); mov(memw[ss, ebp - 248], ax);           /* mov [ebp-0xf8], ax */
            ii(0x1013_7edb, 5); mov(ecx, 0xc7);                         /* mov ecx, 0xc7 */
            ii(0x1013_7ee0, 5); mov(ebx, 0x3a);                         /* mov ebx, 0x3a */
            ii(0x1013_7ee5, 5); mov(edx, 5);                            /* mov edx, 0x5 */
            ii(0x1013_7eea, 6); lea(eax, memd[ss, ebp - 280]);          /* lea eax, [ebp-0x118] */
            ii(0x1013_7ef0, 5); call(0x100d_53a4, -0x6_2b51);           /* call 0x100d53a4 */
            ii(0x1013_7ef5, 1); push(eax);                              /* push eax */
            ii(0x1013_7ef6, 5); mov(eax, 1);                            /* mov eax, 0x1 */
            ii(0x1013_7efb, 1); push(eax);                              /* push eax */
            ii(0x1013_7efc, 5); mov(eax, 1);                            /* mov eax, 0x1 */
            ii(0x1013_7f01, 1); push(eax);                              /* push eax */
            ii(0x1013_7f02, 5); mov(eax, 0x46);                         /* mov eax, 0x46 */
            ii(0x1013_7f07, 1); push(eax);                              /* push eax */
            ii(0x1013_7f08, 5); mov(eax, 0x28);                         /* mov eax, 0x28 */
            ii(0x1013_7f0d, 1); push(eax);                              /* push eax */
            ii(0x1013_7f0e, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1013_7f10, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1013_7f12, 6); lea(edx, memd[ss, ebp - 272]);          /* lea edx, [ebp-0x110] */
            ii(0x1013_7f18, 6); lea(eax, memd[ss, ebp - 264]);          /* lea eax, [ebp-0x108] */
            ii(0x1013_7f1e, 5); call(0x100e_ab9d, -0x4_d386);           /* call 0x100eab9d */
            ii(0x1013_7f23, 5); mov(eax, 5);                            /* mov eax, 0x5 */
            ii(0x1013_7f28, 5); call(/* sys */ 0x1016_a24c, 0x3_231f);  /* call 0x1016a24c */
            ii(0x1013_7f2d, 5); mov(ebx, 5);                            /* mov ebx, 0x5 */
            ii(0x1013_7f32, 3); mov(eax, memd[ss, ebp - 52]);           /* mov eax, [ebp-0x34] */
            ii(0x1013_7f35, 3); mov(edx, memd[ss, ebp - 52]);           /* mov edx, [ebp-0x34] */
            ii(0x1013_7f38, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1013_7f3b, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1013_7f3d, 6); imul(edx, eax, 0x192);                  /* imul edx, eax, 0x192 */
            ii(0x1013_7f43, 4); imul(eax, memd[ss, ebp - 52], 0x53);    /* imul eax, [ebp-0x34], 0x53 */
            ii(0x1013_7f47, 3); add(eax, memd[ss, ebp - 16]);           /* add eax, [ebp-0x10] */
            ii(0x1013_7f4a, 3); add(edx, 0x10);                         /* add edx, 0x10 */
            ii(0x1013_7f4d, 3); mov(memd[ds, eax + 4], edx);            /* mov [eax+0x4], edx */
            ii(0x1013_7f50, 5); mov(ebx, 5);                            /* mov ebx, 0x5 */
            ii(0x1013_7f55, 3); mov(eax, memd[ss, ebp - 52]);           /* mov eax, [ebp-0x34] */
            ii(0x1013_7f58, 3); mov(edx, memd[ss, ebp - 52]);           /* mov edx, [ebp-0x34] */
            ii(0x1013_7f5b, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1013_7f5e, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1013_7f60, 3); imul(edx, edx, 0x4c);                   /* imul edx, edx, 0x4c */
            ii(0x1013_7f63, 4); imul(eax, memd[ss, ebp - 52], 0x53);    /* imul eax, [ebp-0x34], 0x53 */
            ii(0x1013_7f67, 3); add(eax, memd[ss, ebp - 16]);           /* add eax, [ebp-0x10] */
            ii(0x1013_7f6a, 3); add(edx, 0x2c);                         /* add edx, 0x2c */
            ii(0x1013_7f6d, 3); mov(memd[ds, eax + 8], edx);            /* mov [eax+0x8], edx */
            ii(0x1013_7f70, 6); mov(edx, memd[ss, ebp - 224]);          /* mov edx, [ebp-0xe0] */
            ii(0x1013_7f76, 3); movsx(edx, memw[ds, edx]);              /* movsx edx, word [edx] */
            ii(0x1013_7f79, 4); imul(eax, memd[ss, ebp - 52], 0x53);    /* imul eax, [ebp-0x34], 0x53 */
            ii(0x1013_7f7d, 3); add(eax, memd[ss, ebp - 16]);           /* add eax, [ebp-0x10] */
            ii(0x1013_7f80, 3); mov(memd[ds, eax + 12], edx);           /* mov [eax+0xc], edx */
            ii(0x1013_7f83, 6); mov(edx, memd[ss, ebp - 224]);          /* mov edx, [ebp-0xe0] */
            ii(0x1013_7f89, 2); mov(edx, memd[ds, edx]);                /* mov edx, [edx] */
            ii(0x1013_7f8b, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1013_7f8e, 4); imul(eax, memd[ss, ebp - 52], 0x53);    /* imul eax, [ebp-0x34], 0x53 */
            ii(0x1013_7f92, 3); add(eax, memd[ss, ebp - 16]);           /* add eax, [ebp-0x10] */
            ii(0x1013_7f95, 3); mov(memd[ds, eax + 16], edx);           /* mov [eax+0x10], edx */
            ii(0x1013_7f98, 4); imul(edx, memd[ss, ebp - 52], 0x53);    /* imul edx, [ebp-0x34], 0x53 */
            ii(0x1013_7f9c, 3); add(edx, memd[ss, ebp - 16]);           /* add edx, [ebp-0x10] */
            ii(0x1013_7f9f, 3); mov(dl, memb[ds, edx + 78]);            /* mov dl, [edx+0x4e] */
            ii(0x1013_7fa2, 6); and(edx, 0xff);                         /* and edx, 0xff */
            ii(0x1013_7fa8, 4); imul(eax, memd[ss, ebp - 52], 0x53);    /* imul eax, [ebp-0x34], 0x53 */
            ii(0x1013_7fac, 3); add(eax, memd[ss, ebp - 16]);           /* add eax, [ebp-0x10] */
            ii(0x1013_7faf, 5); call(0x1013_784d, -0x767);              /* call 0x1013784d */
            ii(0x1013_7fb4, 2); push(1);                                /* push 0x1 */
            ii(0x1013_7fb6, 2); push(0);                                /* push 0x0 */
            ii(0x1013_7fb8, 4); imul(eax, memd[ss, ebp - 52], 0x53);    /* imul eax, [ebp-0x34], 0x53 */
            ii(0x1013_7fbc, 3); add(eax, memd[ss, ebp - 16]);           /* add eax, [ebp-0x10] */
            ii(0x1013_7fbf, 3); push(memd[ds, eax + 24]);               /* push dword [eax+0x18] */
            ii(0x1013_7fc2, 4); imul(eax, memd[ss, ebp - 52], 0x53);    /* imul eax, [ebp-0x34], 0x53 */
            ii(0x1013_7fc6, 3); add(eax, memd[ss, ebp - 16]);           /* add eax, [ebp-0x10] */
            ii(0x1013_7fc9, 3); push(memd[ds, eax + 20]);               /* push dword [eax+0x14] */
            ii(0x1013_7fcc, 3); mov(eax, memd[ss, ebp - 52]);           /* mov eax, [ebp-0x34] */
            ii(0x1013_7fcf, 5); add(eax, 0x3f3);                        /* add eax, 0x3f3 */
            ii(0x1013_7fd4, 1); push(eax);                              /* push eax */
            ii(0x1013_7fd5, 3); mov(eax, memd[ss, ebp - 52]);           /* mov eax, [ebp-0x34] */
            ii(0x1013_7fd8, 5); add(eax, 0x3e9);                        /* add eax, 0x3e9 */
            ii(0x1013_7fdd, 1); push(eax);                              /* push eax */
            ii(0x1013_7fde, 2); push(-1 /* 0xff */);                    /* push 0xffffffff */
            ii(0x1013_7fe0, 2); push(-1 /* 0xff */);                    /* push 0xffffffff */
            ii(0x1013_7fe2, 6); mov(eax, memd[ss, ebp - 224]);          /* mov eax, [ebp-0xe0] */
            ii(0x1013_7fe8, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1013_7fea, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1013_7fed, 1); push(eax);                              /* push eax */
            ii(0x1013_7fee, 6); mov(ecx, memd[ss, ebp - 224]);          /* mov ecx, [ebp-0xe0] */
            ii(0x1013_7ff4, 3); movsx(ecx, memw[ds, ecx]);              /* movsx ecx, word [ecx] */
            ii(0x1013_7ff7, 4); imul(ebx, memd[ss, ebp - 52], 0x53);    /* imul ebx, [ebp-0x34], 0x53 */
            ii(0x1013_7ffb, 3); add(ebx, memd[ss, ebp - 16]);           /* add ebx, [ebp-0x10] */
            ii(0x1013_7ffe, 3); mov(ebx, memd[ds, ebx + 8]);            /* mov ebx, [ebx+0x8] */
            ii(0x1013_8001, 4); imul(eax, memd[ss, ebp - 52], 0x53);    /* imul eax, [ebp-0x34], 0x53 */
            ii(0x1013_8005, 3); add(eax, memd[ss, ebp - 16]);           /* add eax, [ebp-0x10] */
            ii(0x1013_8008, 3); mov(edx, memd[ds, eax + 4]);            /* mov edx, [eax+0x4] */
            ii(0x1013_800b, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x1013_800e, 3); mov(eax, memd[ds, eax + 18]);           /* mov eax, [eax+0x12] */
            ii(0x1013_8011, 5); call(/* sys */ 0x1016_86b0, 0x3_069a);  /* call 0x101686b0 */
            ii(0x1013_8016, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1013_8018, 4); imul(eax, memd[ss, ebp - 52], 0x53);    /* imul eax, [ebp-0x34], 0x53 */
            ii(0x1013_801c, 3); add(eax, memd[ss, ebp - 16]);           /* add eax, [ebp-0x10] */
            ii(0x1013_801f, 3); mov(memd[ds, eax + 28], edx);           /* mov [eax+0x1c], edx */
            ii(0x1013_8022, 6); mov(eax, memd[ss, ebp - 224]);          /* mov eax, [ebp-0xe0] */
            ii(0x1013_8028, 5); call(Definitions.sys_delete, 0x2_df37); /* call 0x10165f64 */
            ii(0x1013_802d, 6); mov(eax, memd[ss, ebp - 228]);          /* mov eax, [ebp-0xe4] */
            ii(0x1013_8033, 5); call(Definitions.sys_delete, 0x2_df2c); /* call 0x10165f64 */
            ii(0x1013_8038, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x1013_803b, 3); mov(edx, memd[ds, eax + 18]);           /* mov edx, [eax+0x12] */
            ii(0x1013_803e, 4); imul(eax, memd[ss, ebp - 52], 0x53);    /* imul eax, [ebp-0x34], 0x53 */
            ii(0x1013_8042, 3); add(eax, memd[ss, ebp - 16]);           /* add eax, [ebp-0x10] */
            ii(0x1013_8045, 5); call(0x1013_6c02, -0x1448);             /* call 0x10136c02 */
            ii(0x1013_804a, 4); imul(edx, memd[ss, ebp - 52], 0x53);    /* imul edx, [ebp-0x34], 0x53 */
            ii(0x1013_804e, 3); add(edx, memd[ss, ebp - 16]);           /* add edx, [ebp-0x10] */
            ii(0x1013_8051, 3); mov(eax, memd[ss, ebp - 52]);           /* mov eax, [ebp-0x34] */
            ii(0x1013_8054, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1013_8057, 3); mov(edx, memd[ds, edx + 28]);           /* mov edx, [edx+0x1c] */
            ii(0x1013_805a, 7); mov(memd[ds, eax + ebp - 320], edx);    /* mov [eax+ebp-0x140], edx */
            ii(0x1013_8061, 5); jmp(0x1013_7b03, -0x563); goto l_0x1013_7b03; /* jmp 0x10137b03 */
        l_0x1013_8066:
            ii(0x1013_8066, 6); lea(edx, memd[ss, ebp - 320]);          /* lea edx, [ebp-0x140] */
            ii(0x1013_806c, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1013_806f, 5); call(/* sys */ 0x1016_9a78, 0x3_1a04);  /* call 0x10169a78 */
            ii(0x1013_8074, 5); push(0x149);                            /* push 0x149 */
            ii(0x1013_8079, 2); push(0);                                /* push 0x0 */
            ii(0x1013_807b, 5); mov(eax, 0x1b6);                        /* mov eax, 0x1b6 */
            ii(0x1013_8080, 1); push(eax);                              /* push eax */
            ii(0x1013_8081, 5); mov(ecx, 0x21);                         /* mov ecx, 0x21 */
            ii(0x1013_8086, 5); mov(ebx, 0x344);                        /* mov ebx, 0x344 */
            ii(0x1013_808b, 5); mov(edx, 0x343);                        /* mov edx, 0x343 */
            ii(0x1013_8090, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x1013_8093, 3); mov(eax, memd[ds, eax + 18]);           /* mov eax, [eax+0x12] */
            ii(0x1013_8096, 5); call(0x1013_791f, -0x77c);              /* call 0x1013791f */
            ii(0x1013_809b, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1013_809d, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1013_80a0, 2); mov(memd[ds, eax], edx);                /* mov [eax], edx */
            ii(0x1013_80a2, 5); push(0x151);                            /* push 0x151 */
            ii(0x1013_80a7, 2); push(0);                                /* push 0x0 */
            ii(0x1013_80a9, 5); mov(eax, 0x1b6);                        /* mov eax, 0x1b6 */
            ii(0x1013_80ae, 1); push(eax);                              /* push eax */
            ii(0x1013_80af, 5); mov(ecx, 0x3f);                         /* mov ecx, 0x3f */
            ii(0x1013_80b4, 5); mov(ebx, 0x346);                        /* mov ebx, 0x346 */
            ii(0x1013_80b9, 5); mov(edx, 0x345);                        /* mov edx, 0x345 */
            ii(0x1013_80be, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x1013_80c1, 3); mov(eax, memd[ds, eax + 18]);           /* mov eax, [eax+0x12] */
            ii(0x1013_80c4, 5); call(0x1013_791f, -0x7aa);              /* call 0x1013791f */
            ii(0x1013_80c9, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1013_80cc, 3); mov(memd[ds, edx + 4], eax);            /* mov [edx+0x4], eax */
            ii(0x1013_80cf, 5); mov(eax, 1);                            /* mov eax, 0x1 */
            ii(0x1013_80d4, 5); call(/* sys */ 0x1016_a24c, 0x3_2173);  /* call 0x1016a24c */
            ii(0x1013_80d9, 5); push(0x3ff);                            /* push 0x3ff */
            ii(0x1013_80de, 5); mov(eax, StringDefinitions.Load);       /* mov eax, 0x101ac815 */
            ii(0x1013_80e3, 1); push(eax);                              /* push eax */
            ii(0x1013_80e4, 5); mov(eax, 0x1b6);                        /* mov eax, 0x1b6 */
            ii(0x1013_80e9, 1); push(eax);                              /* push eax */
            ii(0x1013_80ea, 5); mov(ecx, 0x202);                        /* mov ecx, 0x202 */
            ii(0x1013_80ef, 5); mov(ebx, 0x33e);                        /* mov ebx, 0x33e */
            ii(0x1013_80f4, 5); mov(edx, 0x33d);                        /* mov edx, 0x33d */
            ii(0x1013_80f9, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x1013_80fc, 3); mov(eax, memd[ds, eax + 18]);           /* mov eax, [eax+0x12] */
            ii(0x1013_80ff, 5); call(0x1013_791f, -0x7e5);              /* call 0x1013791f */
            ii(0x1013_8104, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1013_8107, 3); mov(memd[ds, edx + 8], eax);            /* mov [edx+0x8], eax */
            ii(0x1013_810a, 5); push(0x3fd);                            /* push 0x3fd */
            ii(0x1013_810f, 5); mov(eax, StringDefinitions.Control5);   /* mov eax, 0x101ac81a */
            ii(0x1013_8114, 1); push(eax);                              /* push eax */
            ii(0x1013_8115, 5); mov(eax, 0x1b6);                        /* mov eax, 0x1b6 */
            ii(0x1013_811a, 1); push(eax);                              /* push eax */
            ii(0x1013_811b, 5); mov(ecx, 0x1d1);                        /* mov ecx, 0x1d1 */
            ii(0x1013_8120, 5); mov(ebx, 0x33c);                        /* mov ebx, 0x33c */
            ii(0x1013_8125, 5); mov(edx, 0x33b);                        /* mov edx, 0x33b */
            ii(0x1013_812a, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x1013_812d, 3); mov(eax, memd[ds, eax + 18]);           /* mov eax, [eax+0x12] */
            ii(0x1013_8130, 5); call(0x1013_791f, -0x816);              /* call 0x1013791f */
            ii(0x1013_8135, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1013_8138, 3); mov(memd[ds, edx + 12], eax);           /* mov [edx+0xc], eax */
            ii(0x1013_813b, 5); push(0x3e8);                            /* push 0x3e8 */
            ii(0x1013_8140, 4); cmp(memb[ss, ebp + 16], 0);             /* cmp byte [ebp+0x10], 0x0 */
            ii(0x1013_8144, 2); if(jz(0x1013_8152, 0xc)) goto l_0x1013_8152; /* jz 0x10138152 */
            ii(0x1013_8146, 10); mov(memd[ss, ebp - 324], StringDefinitions.Return); /* mov dword [ebp-0x144], 0x101ac81c */
            ii(0x1013_8150, 2); jmp(0x1013_815c, 0xa); goto l_0x1013_815c; /* jmp 0x1013815c */
        l_0x1013_8152:
            ii(0x1013_8152, 10); mov(memd[ss, ebp - 324], StringDefinitions.Cancel2); /* mov dword [ebp-0x144], 0x101ac823 */
        l_0x1013_815c:
            ii(0x1013_815c, 6); push(memd[ss, ebp - 324]);              /* push dword [ebp-0x144] */
            ii(0x1013_8162, 5); mov(eax, 0x1b6);                        /* mov eax, 0x1b6 */
            ii(0x1013_8167, 1); push(eax);                              /* push eax */
            ii(0x1013_8168, 5); mov(ecx, 0x162);                        /* mov ecx, 0x162 */
            ii(0x1013_816d, 5); mov(ebx, 0x33a);                        /* mov ebx, 0x33a */
            ii(0x1013_8172, 5); mov(edx, 0x339);                        /* mov edx, 0x339 */
            ii(0x1013_8177, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x1013_817a, 3); mov(eax, memd[ds, eax + 18]);           /* mov eax, [eax+0x12] */
            ii(0x1013_817d, 5); call(0x1013_791f, -0x863);              /* call 0x1013791f */
            ii(0x1013_8182, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1013_8184, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1013_8187, 3); mov(memd[ds, eax + 16], edx);           /* mov [eax+0x10], edx */
            ii(0x1013_818a, 4); cmp(memb[ss, ebp + 16], 0);             /* cmp byte [ebp+0x10], 0x0 */
            ii(0x1013_818e, 2); if(jz(0x1013_81f6, 0x66)) goto l_0x1013_81f6; /* jz 0x101381f6 */
            ii(0x1013_8190, 5); push(0x400);                            /* push 0x400 */
            ii(0x1013_8195, 5); mov(eax, StringDefinitions.Quit);       /* mov eax, 0x101ac82a */
            ii(0x1013_819a, 1); push(eax);                              /* push eax */
            ii(0x1013_819b, 5); mov(eax, 0x1b6);                        /* mov eax, 0x1b6 */
            ii(0x1013_81a0, 1); push(eax);                              /* push eax */
            ii(0x1013_81a1, 5); mov(ecx, 0xf3);                         /* mov ecx, 0xf3 */
            ii(0x1013_81a6, 5); mov(ebx, 0x338);                        /* mov ebx, 0x338 */
            ii(0x1013_81ab, 5); mov(edx, 0x337);                        /* mov edx, 0x337 */
            ii(0x1013_81b0, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x1013_81b3, 3); mov(eax, memd[ds, eax + 18]);           /* mov eax, [eax+0x12] */
            ii(0x1013_81b6, 5); call(0x1013_791f, -0x89c);              /* call 0x1013791f */
            ii(0x1013_81bb, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1013_81bd, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1013_81c0, 3); mov(memd[ds, eax + 20], edx);           /* mov [eax+0x14], edx */
            ii(0x1013_81c3, 5); push(0x3fe);                            /* push 0x3fe */
            ii(0x1013_81c8, 5); mov(eax, StringDefinitions.Save);       /* mov eax, 0x101ac82f */
            ii(0x1013_81cd, 1); push(eax);                              /* push eax */
            ii(0x1013_81ce, 5); mov(eax, 0x1b6);                        /* mov eax, 0x1b6 */
            ii(0x1013_81d3, 1); push(eax);                              /* push eax */
            ii(0x1013_81d4, 5); mov(ecx, 0x84);                         /* mov ecx, 0x84 */
            ii(0x1013_81d9, 5); mov(ebx, 0x336);                        /* mov ebx, 0x336 */
            ii(0x1013_81de, 5); mov(edx, 0x335);                        /* mov edx, 0x335 */
            ii(0x1013_81e3, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x1013_81e6, 3); mov(eax, memd[ds, eax + 18]);           /* mov eax, [eax+0x12] */
            ii(0x1013_81e9, 5); call(0x1013_791f, -0x8cf);              /* call 0x1013791f */
            ii(0x1013_81ee, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1013_81f0, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1013_81f3, 3); mov(memd[ds, eax + 24], edx);           /* mov [eax+0x18], edx */
        l_0x1013_81f6:
            ii(0x1013_81f6, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x1013_81f9, 3); mov(eax, memd[ds, eax + 18]);           /* mov eax, [eax+0x12] */
            ii(0x1013_81fc, 5); call(Definitions.sys_display_draw_0, 0x2_f283); /* call 0x10167484 */
            ii(0x1013_8201, 4); cmp(memb[ss, ebp + 32], 0);             /* cmp byte [ebp+0x20], 0x0 */
            ii(0x1013_8205, 2); if(jz(0x1013_823a, 0x33)) goto l_0x1013_823a; /* jz 0x1013823a */
            ii(0x1013_8207, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_8209, 1); push(eax);                              /* push eax */
            ii(0x1013_820a, 5); mov(eax, 2);                            /* mov eax, 0x2 */
            ii(0x1013_820f, 1); push(eax);                              /* push eax */
            ii(0x1013_8210, 5); mov(eax, 0x68);                         /* mov eax, 0x68 */
            ii(0x1013_8215, 1); push(eax);                              /* push eax */
            ii(0x1013_8216, 5); mov(ecx, 0x100);                        /* mov ecx, 0x100 */
            ii(0x1013_821b, 5); mov(ebx, 0x280);                        /* mov ebx, 0x280 */
            ii(0x1013_8220, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_8222, 5); call(0x100e_883d, -0x4_f9ea);           /* call 0x100e883d */
            ii(0x1013_8227, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1013_8229, 5); mov(eax, 0x4b1);                        /* mov eax, 0x4b1 */
            ii(0x1013_822e, 5); call(0x100f_04d8, -0x4_7d5b);           /* call 0x100f04d8 */
            ii(0x1013_8233, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1013_8235, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1013_8238, 2); mov(memd[ds, eax], edx);                /* mov [eax], edx */
        l_0x1013_823a:
            ii(0x1013_823a, 5); call(/* sys */ 0x1016_bcc4, 0x3_3a85);  /* call 0x1016bcc4 */
            ii(0x1013_823f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_8241, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_8242, 1); pop(edi);                               /* pop edi */
            ii(0x1013_8243, 1); pop(esi);                               /* pop esi */
            ii(0x1013_8244, 3); ret(0x14);                              /* ret 0x14 */
        }
    }
}
