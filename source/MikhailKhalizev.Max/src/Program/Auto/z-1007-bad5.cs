using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_bad5-555b93f7")]
        public void Method_1007_bad5()
        {
            ii(0x1007_bad5, 5); push(0x48);                             /* push 0x48 */
            ii(0x1007_bada, 5); call(Definitions.sys_check_available_stack_size, 0xe_a273); /* call 0x10165d52 */
            ii(0x1007_badf, 1); push(esi);                              /* push esi */
            ii(0x1007_bae0, 1); push(edi);                              /* push edi */
            ii(0x1007_bae1, 1); push(ebp);                              /* push ebp */
            ii(0x1007_bae2, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_bae4, 6); sub(esp, 0x38);                         /* sub esp, 0x38 */
            ii(0x1007_baea, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x1007_baed, 3); mov(memd[ss, ebp - 12], edx);           /* mov [ebp-0xc], edx */
            ii(0x1007_baf0, 3); mov(memd[ss, ebp - 8], ebx);            /* mov [ebp-0x8], ebx */
            ii(0x1007_baf3, 3); mov(memd[ss, ebp - 4], ecx);            /* mov [ebp-0x4], ecx */
            ii(0x1007_baf6, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1007_baf9, 5); call(0x1007_6338, -0x57c6);             /* call 0x10076338 */
            ii(0x1007_bafe, 3); lea(ebx, memd[ss, ebp - 36]);           /* lea ebx, [ebp-0x24] */
            ii(0x1007_bb01, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_bb03, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1007_bb05, 5); call(0x1007_64b8, -0x5652);             /* call 0x100764b8 */
            ii(0x1007_bb0a, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1007_bb0d, 3); mov(memd[ss, ebp - 32], eax);           /* mov [ebp-0x20], eax */
            ii(0x1007_bb10, 3); mov(eax, memd[ss, ebp - 32]);           /* mov eax, [ebp-0x20] */
            ii(0x1007_bb13, 3); mov(edx, memd[ds, eax + 2]);            /* mov edx, [eax+0x2] */
            ii(0x1007_bb16, 3); mov(eax, memd[ss, ebp - 32]);           /* mov eax, [ebp-0x20] */
            ii(0x1007_bb19, 3); call_abs(memd[ds, edx + 20]);           /* call dword [edx+0x14] */
            ii(0x1007_bb1c, 3); mov(memd[ss, ebp - 24], eax);           /* mov [ebp-0x18], eax */
            ii(0x1007_bb1f, 2); jmp(0x1007_bb29, 8); goto l_0x1007_bb29; /* jmp 0x1007bb29 */
        l_0x1007_bb21:
            ii(0x1007_bb21, 3); lea(eax, memd[ss, ebp - 36]);           /* lea eax, [ebp-0x24] */
            ii(0x1007_bb24, 5); call(0x1007_6bf8, -0x4f31);             /* call 0x10076bf8 */
        l_0x1007_bb29:
            ii(0x1007_bb29, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_bb2b, 3); lea(eax, memd[ss, ebp - 36]);           /* lea eax, [ebp-0x24] */
            ii(0x1007_bb2e, 5); call(0x1013_ad71, 0xb_f23e);            /* call 0x1013ad71 */
            ii(0x1007_bb33, 2); test(al, al);                           /* test al, al */
            ii(0x1007_bb35, 6); if(jz(0x1007_bcdd, 0x1a2)) goto l_0x1007_bcdd; /* jz 0x1007bcdd */
            ii(0x1007_bb3b, 3); lea(eax, memd[ss, ebp - 36]);           /* lea eax, [ebp-0x24] */
            ii(0x1007_bb3e, 5); call(0x1007_63a0, -0x57a3);             /* call 0x100763a0 */
            ii(0x1007_bb43, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_bb45, 3); mov(dl, memb[ds, eax + 38]);            /* mov dl, [eax+0x26] */
            ii(0x1007_bb48, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1007_bb4b, 3); mov(eax, memd[ds, eax + 7]);            /* mov eax, [eax+0x7] */
            ii(0x1007_bb4e, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1007_bb51, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1007_bb53, 2); if(jnz(0x1007_bb69, 0x14)) goto l_0x1007_bb69; /* jnz 0x1007bb69 */
            ii(0x1007_bb55, 3); lea(eax, memd[ss, ebp - 36]);           /* lea eax, [ebp-0x24] */
            ii(0x1007_bb58, 5); call(0x1007_63a0, -0x57bd);             /* call 0x100763a0 */
            ii(0x1007_bb5d, 3); mov(al, memb[ds, eax + 77]);            /* mov al, [eax+0x4d] */
            ii(0x1007_bb60, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1007_bb65, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_bb67, 2); if(jg(0x1007_bb6b, 2)) goto l_0x1007_bb6b; /* jg 0x1007bb6b */
        l_0x1007_bb69:
            ii(0x1007_bb69, 2); jmp(0x1007_bb7f, 0x14); goto l_0x1007_bb7f; /* jmp 0x1007bb7f */
        l_0x1007_bb6b:
            ii(0x1007_bb6b, 3); lea(eax, memd[ss, ebp - 36]);           /* lea eax, [ebp-0x24] */
            ii(0x1007_bb6e, 5); call(0x1007_63a0, -0x57d3);             /* call 0x100763a0 */
            ii(0x1007_bb73, 3); mov(al, memb[ds, eax + 84]);            /* mov al, [eax+0x54] */
            ii(0x1007_bb76, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1007_bb7b, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_bb7d, 2); if(jg(0x1007_bb84, 5)) goto l_0x1007_bb84; /* jg 0x1007bb84 */
        l_0x1007_bb7f:
            ii(0x1007_bb7f, 5); jmp(0x1007_bcd8, 0x154); goto l_0x1007_bcd8; /* jmp 0x1007bcd8 */
        l_0x1007_bb84:
            ii(0x1007_bb84, 3); lea(eax, memd[ss, ebp - 36]);           /* lea eax, [ebp-0x24] */
            ii(0x1007_bb87, 5); call(0x1007_63a0, -0x57ec);             /* call 0x100763a0 */
            ii(0x1007_bb8c, 4); cmp(memb[ds, eax + 61], 0);             /* cmp byte [eax+0x3d], 0x0 */
            ii(0x1007_bb90, 2); if(jz(0x1007_bba0, 0xe)) goto l_0x1007_bba0; /* jz 0x1007bba0 */
            ii(0x1007_bb92, 3); lea(eax, memd[ss, ebp - 36]);           /* lea eax, [ebp-0x24] */
            ii(0x1007_bb95, 5); call(0x1007_63a0, -0x57fa);             /* call 0x100763a0 */
            ii(0x1007_bb9a, 4); cmp(memb[ds, eax + 61], 0xc);           /* cmp byte [eax+0x3d], 0xc */
            ii(0x1007_bb9e, 2); if(jnz(0x1007_bba2, 2)) goto l_0x1007_bba2; /* jnz 0x1007bba2 */
        l_0x1007_bba0:
            ii(0x1007_bba0, 2); jmp(0x1007_bbb0, 0xe); goto l_0x1007_bbb0; /* jmp 0x1007bbb0 */
        l_0x1007_bba2:
            ii(0x1007_bba2, 3); lea(eax, memd[ss, ebp - 36]);           /* lea eax, [ebp-0x24] */
            ii(0x1007_bba5, 5); call(0x1007_63a0, -0x580a);             /* call 0x100763a0 */
            ii(0x1007_bbaa, 4); cmp(memb[ds, eax + 61], 2);             /* cmp byte [eax+0x3d], 0x2 */
            ii(0x1007_bbae, 2); if(jnz(0x1007_bbb2, 2)) goto l_0x1007_bbb2; /* jnz 0x1007bbb2 */
        l_0x1007_bbb0:
            ii(0x1007_bbb0, 2); jmp(0x1007_bbc4, 0x12); goto l_0x1007_bbc4; /* jmp 0x1007bbc4 */
        l_0x1007_bbb2:
            ii(0x1007_bbb2, 3); lea(eax, memd[ss, ebp - 36]);           /* lea eax, [ebp-0x24] */
            ii(0x1007_bbb5, 5); call(0x1007_63a0, -0x581a);             /* call 0x100763a0 */
            ii(0x1007_bbba, 4); cmp(memb[ds, eax + 61], 0x1b);          /* cmp byte [eax+0x3d], 0x1b */
            ii(0x1007_bbbe, 6); if(jnz(0x1007_bcd8, 0x114)) goto l_0x1007_bcd8; /* jnz 0x1007bcd8 */
        l_0x1007_bbc4:
            ii(0x1007_bbc4, 4); mov(memb[ss, ebp - 20], 0);             /* mov byte [ebp-0x14], 0x0 */
            ii(0x1007_bbc8, 3); lea(eax, memd[ss, ebp - 36]);           /* lea eax, [ebp-0x24] */
            ii(0x1007_bbcb, 5); call(0x1007_63a0, -0x5830);             /* call 0x100763a0 */
            ii(0x1007_bbd0, 5); call(0x1015_26ac, 0xd_6ad7);            /* call 0x101526ac */
            ii(0x1007_bbd5, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_bbd7, 2); if(jnz(0x1007_bbdf, 6)) goto l_0x1007_bbdf; /* jnz 0x1007bbdf */
            ii(0x1007_bbd9, 4); mov(memb[ss, ebp - 20], 1);             /* mov byte [ebp-0x14], 0x1 */
            ii(0x1007_bbdd, 2); jmp(0x1007_bc25, 0x46); goto l_0x1007_bc25; /* jmp 0x1007bc25 */
        l_0x1007_bbdf:
            ii(0x1007_bbdf, 4); movsx(edx, memw[ss, ebp - 24]);         /* movsx edx, word [ebp-0x18] */
            ii(0x1007_bbe3, 3); lea(eax, memd[ss, ebp - 36]);           /* lea eax, [ebp-0x24] */
            ii(0x1007_bbe6, 5); call(0x1007_63a0, -0x584b);             /* call 0x100763a0 */
            ii(0x1007_bbeb, 5); call(0x1015_26ac, 0xd_6abc);            /* call 0x101526ac */
            ii(0x1007_bbf0, 5); call(0x100a_2bc4, 0x2_6fcf);            /* call 0x100a2bc4 */
            ii(0x1007_bbf5, 1); cwde();                                 /* cwde */
            ii(0x1007_bbf6, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_bbf8, 2); if(jle(0x1007_bc25, 0x2b)) goto l_0x1007_bc25; /* jle 0x1007bc25 */
            ii(0x1007_bbfa, 3); lea(eax, memd[ss, ebp - 36]);           /* lea eax, [ebp-0x24] */
            ii(0x1007_bbfd, 5); call(0x1007_63a0, -0x5862);             /* call 0x100763a0 */
            ii(0x1007_bc02, 5); call(0x1015_26ac, 0xd_6aa5);            /* call 0x101526ac */
            ii(0x1007_bc07, 3); mov(memd[ss, ebp - 44], eax);           /* mov [ebp-0x2c], eax */
            ii(0x1007_bc0a, 3); mov(eax, memd[ss, ebp - 44]);           /* mov eax, [ebp-0x2c] */
            ii(0x1007_bc0d, 3); mov(ebx, memd[ds, eax + 2]);            /* mov ebx, [eax+0x2] */
            ii(0x1007_bc10, 3); lea(eax, memd[ss, ebp - 36]);           /* lea eax, [ebp-0x24] */
            ii(0x1007_bc13, 5); call(0x1007_63d4, -0x5844);             /* call 0x100763d4 */
            ii(0x1007_bc18, 3); mov(ecx, memd[ss, ebp - 44]);           /* mov ecx, [ebp-0x2c] */
            ii(0x1007_bc1b, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_bc1d, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1007_bc1f, 3); call_abs(memd[ds, ebx + 4]);            /* call dword [ebx+0x4] */
            ii(0x1007_bc22, 3); mov(memb[ss, ebp - 20], al);            /* mov [ebp-0x14], al */
        l_0x1007_bc25:
            ii(0x1007_bc25, 4); cmp(memb[ss, ebp - 20], 0);             /* cmp byte [ebp-0x14], 0x0 */
            ii(0x1007_bc29, 6); if(jz(0x1007_bcd8, 0xa9)) goto l_0x1007_bcd8; /* jz 0x1007bcd8 */
            ii(0x1007_bc2f, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1007_bc32, 3); mov(memd[ss, ebp - 48], eax);           /* mov [ebp-0x30], eax */
            ii(0x1007_bc35, 3); mov(eax, memd[ss, ebp - 48]);           /* mov eax, [ebp-0x30] */
            ii(0x1007_bc38, 3); mov(ebx, memd[ds, eax + 2]);            /* mov ebx, [eax+0x2] */
            ii(0x1007_bc3b, 3); lea(eax, memd[ss, ebp - 36]);           /* lea eax, [ebp-0x24] */
            ii(0x1007_bc3e, 5); call(0x1007_63d4, -0x586f);             /* call 0x100763d4 */
            ii(0x1007_bc43, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_bc45, 3); mov(eax, memd[ss, ebp - 48]);           /* mov eax, [ebp-0x30] */
            ii(0x1007_bc48, 3); call_abs(memd[ds, ebx + 8]);            /* call dword [ebx+0x8] */
            ii(0x1007_bc4b, 2); test(al, al);                           /* test al, al */
            ii(0x1007_bc4d, 2); if(jz(0x1007_bc8b, 0x3c)) goto l_0x1007_bc8b; /* jz 0x1007bc8b */
            ii(0x1007_bc4f, 4); cmp(memd[ss, ebp + 16], 0);             /* cmp dword [ebp+0x10], 0x0 */
            ii(0x1007_bc53, 2); if(jz(0x1007_bc89, 0x34)) goto l_0x1007_bc89; /* jz 0x1007bc89 */
            ii(0x1007_bc55, 3); lea(eax, memd[ss, ebp - 36]);           /* lea eax, [ebp-0x24] */
            ii(0x1007_bc58, 5); call(0x1007_63a0, -0x58bd);             /* call 0x100763a0 */
            ii(0x1007_bc5d, 3); mov(ebx, memd[ds, eax + 26]);           /* mov ebx, [eax+0x1a] */
            ii(0x1007_bc60, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1007_bc63, 3); lea(eax, memd[ss, ebp - 36]);           /* lea eax, [ebp-0x24] */
            ii(0x1007_bc66, 5); call(0x1007_63a0, -0x58cb);             /* call 0x100763a0 */
            ii(0x1007_bc6b, 3); mov(edx, memd[ds, eax + 24]);           /* mov edx, [eax+0x18] */
            ii(0x1007_bc6e, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1007_bc71, 3); lea(eax, memd[ss, ebp - 52]);           /* lea eax, [ebp-0x34] */
            ii(0x1007_bc74, 5); call(0x1007_6aac, -0x51cd);             /* call 0x10076aac */
            ii(0x1007_bc79, 3); mov(ebx, memd[ss, ebp + 16]);           /* mov ebx, [ebp+0x10] */
            ii(0x1007_bc7c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_bc7e, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1007_bc80, 5); call(0x1011_ff4c, 0xa_42c7);            /* call 0x1011ff4c */
            ii(0x1007_bc85, 2); test(al, al);                           /* test al, al */
            ii(0x1007_bc87, 2); if(jz(0x1007_bc8b, 2)) goto l_0x1007_bc8b; /* jz 0x1007bc8b */
        l_0x1007_bc89:
            ii(0x1007_bc89, 2); jmp(0x1007_bc8d, 2); goto l_0x1007_bc8d; /* jmp 0x1007bc8d */
        l_0x1007_bc8b:
            ii(0x1007_bc8b, 2); jmp(0x1007_bcd8, 0x4b); goto l_0x1007_bcd8; /* jmp 0x1007bcd8 */
        l_0x1007_bc8d:
            ii(0x1007_bc8d, 3); lea(edx, memd[ss, ebp - 56]);           /* lea edx, [ebp-0x38] */
            ii(0x1007_bc90, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1007_bc93, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1007_bc96, 5); call(0x1008_a228, 0xe58d);              /* call 0x1008a228 */
            ii(0x1007_bc9b, 5); call(0x100b_8e63, 0x3_d1c3);            /* call 0x100b8e63 */
            ii(0x1007_bca0, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_bca2, 3); lea(eax, memd[ss, ebp - 36]);           /* lea eax, [ebp-0x24] */
            ii(0x1007_bca5, 5); call(0x1007_63d4, -0x58d6);             /* call 0x100763d4 */
            ii(0x1007_bcaa, 5); call(0x1007_0ca1, -0xb00e);             /* call 0x10070ca1 */
            ii(0x1007_bcaf, 3); mov(memd[ss, ebp - 28], eax);           /* mov [ebp-0x1c], eax */
            ii(0x1007_bcb2, 4); cmp(memd[ss, ebp - 8], 0);              /* cmp dword [ebp-0x8], 0x0 */
            ii(0x1007_bcb6, 2); if(jz(0x1007_bcc4, 0xc)) goto l_0x1007_bcc4; /* jz 0x1007bcc4 */
            ii(0x1007_bcb8, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1007_bcbb, 3); mov(ax, memw[ds, eax]);                 /* mov ax, [eax] */
            ii(0x1007_bcbe, 4); cmp(ax, memw[ss, ebp - 28]);            /* cmp ax, [ebp-0x1c] */
            ii(0x1007_bcc2, 2); if(jle(0x1007_bcd8, 0x14)) goto l_0x1007_bcd8; /* jle 0x1007bcd8 */
        l_0x1007_bcc4:
            ii(0x1007_bcc4, 3); lea(eax, memd[ss, ebp - 36]);           /* lea eax, [ebp-0x24] */
            ii(0x1007_bcc7, 5); call(0x1007_63d4, -0x58f8);             /* call 0x100763d4 */
            ii(0x1007_bccc, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1007_bccf, 3); mov(eax, memd[ss, ebp - 28]);           /* mov eax, [ebp-0x1c] */
            ii(0x1007_bcd2, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1007_bcd5, 3); mov(memw[ds, edx], ax);                 /* mov [edx], ax */
        l_0x1007_bcd8:
            ii(0x1007_bcd8, 5); jmp(0x1007_bb21, -0x1bc); goto l_0x1007_bb21; /* jmp 0x1007bb21 */
        l_0x1007_bcdd:
            ii(0x1007_bcdd, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1007_bce0, 3); mov(memd[ss, ebp - 40], eax);           /* mov [ebp-0x28], eax */
            ii(0x1007_bce3, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_bce5, 3); lea(eax, memd[ss, ebp - 36]);           /* lea eax, [ebp-0x24] */
            ii(0x1007_bce8, 5); call(0x1007_5f6c, -0x5d81);             /* call 0x10075f6c */
            ii(0x1007_bced, 2); jmp(0x1007_bcf9, 0xa); goto l_0x1007_bcf9; /* jmp 0x1007bcf9 */
        //  ii(0x1007_bcef, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x1007_bcf1, 3); lea(eax, memd[ss, ebp - 36]);           /* lea eax, [ebp-0x24] */
        //  ii(0x1007_bcf4, 5); call(0x1007_5f6c, -0x5d8d);             /* call 0x10075f6c */
        l_0x1007_bcf9:
            ii(0x1007_bcf9, 3); mov(eax, memd[ss, ebp - 40]);           /* mov eax, [ebp-0x28] */
            ii(0x1007_bcfc, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_bcfe, 1); pop(ebp);                               /* pop ebp */
            ii(0x1007_bcff, 1); pop(edi);                               /* pop edi */
            ii(0x1007_bd00, 1); pop(esi);                               /* pop esi */
            ii(0x1007_bd01, 3); ret(4);                                 /* ret 0x4 */
        }
    }
}
