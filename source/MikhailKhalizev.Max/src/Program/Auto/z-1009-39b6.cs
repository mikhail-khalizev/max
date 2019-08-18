using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("44e71df7-5661-4cba-8929-e8283f8697c6")]
        public void Method_1009_39b6()
        {
            ii(0x1009_39b6, 5); pushd(0x64);                            /* push 0x64 */
            ii(0x1009_39bb, 5); calld(Definitions.sys_check_available_stack_size, 0xd_2392); /* call 0x10165d52 */
            ii(0x1009_39c0, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_39c1, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_39c2, 1); pushd(edx);                             /* push edx */
            ii(0x1009_39c3, 1); pushd(esi);                             /* push esi */
            ii(0x1009_39c4, 1); pushd(edi);                             /* push edi */
            ii(0x1009_39c5, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_39c6, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_39c8, 6); sub(esp, 0x48);                         /* sub esp, 0x48 */
            ii(0x1009_39ce, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1009_39d1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_39d4, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1009_39d7, 5); calld(0x1007_6338, -0x1_d6a4);          /* call 0x10076338 */
            ii(0x1009_39dc, 3); lea(ebx, ebp - 0x40);                   /* lea ebx, [ebp-0x40] */
            ii(0x1009_39df, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_39e1, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1009_39e3, 5); calld(0x1007_64b8, -0x1_d530);          /* call 0x100764b8 */
            ii(0x1009_39e8, 7); mov(memd_a32[ss, ebp - 0x34], 0);       /* mov dword [ebp-0x34], 0x0 */
            ii(0x1009_39ef, 7); mov(memd_a32[ss, ebp - 0x38], 0);       /* mov dword [ebp-0x38], 0x0 */
            ii(0x1009_39f6, 7); mov(memd_a32[ss, ebp - 0x20], 0);       /* mov dword [ebp-0x20], 0x0 */
            ii(0x1009_39fd, 7); mov(memd_a32[ss, ebp - 0x30], 0);       /* mov dword [ebp-0x30], 0x0 */
            ii(0x1009_3a04, 2); jmpd(0x1009_3a0e, 0x8); goto l_0x1009_3a0e; /* jmp 0x10093a0e */
        l_0x1009_3a06:
            ii(0x1009_3a06, 3); lea(eax, ebp - 0x40);                   /* lea eax, [ebp-0x40] */
            ii(0x1009_3a09, 5); calld(0x1007_6bf8, -0x1_ce16);          /* call 0x10076bf8 */
        l_0x1009_3a0e:
            ii(0x1009_3a0e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_3a10, 3); lea(eax, ebp - 0x40);                   /* lea eax, [ebp-0x40] */
            ii(0x1009_3a13, 5); calld(0x1013_ad71, 0xa_7359);           /* call 0x1013ad71 */
            ii(0x1009_3a18, 2); test(al, al);                           /* test al, al */
            ii(0x1009_3a1a, 2); if(jzd(0x1009_3a78, 0x5c)) goto l_0x1009_3a78; /* jz 0x10093a78 */
            ii(0x1009_3a1c, 3); lea(eax, ebp - 0x40);                   /* lea eax, [ebp-0x40] */
            ii(0x1009_3a1f, 5); calld(0x1007_63a0, -0x1_d684);          /* call 0x100763a0 */
            ii(0x1009_3a24, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x1009_3a27, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_3a2a, 5); calld(0x1007_1f2e, -0x2_1b01);          /* call 0x10071f2e */
            ii(0x1009_3a2f, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1009_3a32, 4); movsx(eax, memw_a32[ss, ebp - 0x1c]);   /* movsx eax, word [ebp-0x1c] */
            ii(0x1009_3a36, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1009_3a38, 2); if(jged(0x1009_3a42, 0x8)) goto l_0x1009_3a42; /* jge 0x10093a42 */
            ii(0x1009_3a3a, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1009_3a3d, 3); sub(memd_a32[ss, ebp - 0x38], eax);     /* sub [ebp-0x38], eax */
            ii(0x1009_3a40, 2); jmpd(0x1009_3a48, 0x6); goto l_0x1009_3a48; /* jmp 0x10093a48 */
        l_0x1009_3a42:
            ii(0x1009_3a42, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1009_3a45, 3); add(memd_a32[ss, ebp - 0x34], eax);     /* add [ebp-0x34], eax */
        l_0x1009_3a48:
            ii(0x1009_3a48, 3); lea(eax, ebp - 0x40);                   /* lea eax, [ebp-0x40] */
            ii(0x1009_3a4b, 5); calld(0x1007_63a0, -0x1_d6b0);          /* call 0x100763a0 */
            ii(0x1009_3a50, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x1009_3a53, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_3a56, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x1009_3a59, 6); mov(eax, memd_a32[ds, eax + 0x101c_81d2]); /* mov eax, [eax+0x101c81d2] */
            ii(0x1009_3a5f, 3); sar(eax, 0x18);                         /* sar eax, 0x18 */
            ii(0x1009_3a62, 3); cmp(eax, 0x6);                          /* cmp eax, 0x6 */
            ii(0x1009_3a65, 2); if(jnzd(0x1009_3a76, 0xf)) goto l_0x1009_3a76; /* jnz 0x10093a76 */
            ii(0x1009_3a67, 3); lea(eax, ebp - 0x40);                   /* lea eax, [ebp-0x40] */
            ii(0x1009_3a6a, 5); calld(0x1007_63a0, -0x1_d6cf);          /* call 0x100763a0 */
            ii(0x1009_3a6f, 4); mov(ax, memw_a32[ds, eax + 0x52]);      /* mov ax, [eax+0x52] */
            ii(0x1009_3a73, 3); add(memd_a32[ss, ebp - 0x30], eax);     /* add [ebp-0x30], eax */
        l_0x1009_3a76:
            ii(0x1009_3a76, 2); jmpd(0x1009_3a06, -0x72); goto l_0x1009_3a06; /* jmp 0x10093a06 */
        l_0x1009_3a78:
            ii(0x1009_3a78, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_3a7b, 3); add(eax, 0x21);                         /* add eax, 0x21 */
            ii(0x1009_3a7e, 5); calld(0x1009_c6c8, 0x8c45);             /* call 0x1009c6c8 */
            ii(0x1009_3a83, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_3a85, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x1009_3a88, 5); calld(0x1009_c5dc, 0x8b4f);             /* call 0x1009c5dc */
            ii(0x1009_3a8d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_3a90, 3); mov(edx, memd_a32[ds, eax + 0x7]);      /* mov edx, [eax+0x7] */
            ii(0x1009_3a93, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1009_3a96, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1009_3a9b, 5); calld(0x100d_4b64, 0x4_10c4);           /* call 0x100d4b64 */
            ii(0x1009_3aa0, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1009_3aa3, 3); mov(eax, memd_a32[ss, ebp - 0x38]);     /* mov eax, [ebp-0x38] */
            ii(0x1009_3aa6, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1009_3aa9, 2); jmpd(0x1009_3ab3, 0x8); goto l_0x1009_3ab3; /* jmp 0x10093ab3 */
        l_0x1009_3aab:
            ii(0x1009_3aab, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x1009_3aae, 5); calld(0x1007_6bf8, -0x1_cebb);          /* call 0x10076bf8 */
        l_0x1009_3ab3:
            ii(0x1009_3ab3, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_3ab5, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x1009_3ab8, 5); calld(0x1013_ad71, 0xa_72b4);           /* call 0x1013ad71 */
            ii(0x1009_3abd, 2); test(al, al);                           /* test al, al */
            ii(0x1009_3abf, 6); if(jzd(0x1009_3b37, 0x72)) goto l_0x1009_3b37; /* jz 0x10093b37 */
            ii(0x1009_3ac5, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x1009_3ac8, 5); calld(0x1009_c4f8, 0x8a2b);             /* call 0x1009c4f8 */
            ii(0x1009_3acd, 5); calld(0x1009_c4c4, 0x89f2);             /* call 0x1009c4c4 */
            ii(0x1009_3ad2, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1009_3ad5, 5); cmp(memw_a32[ss, ebp - 0x10], 0x2);     /* cmp word [ebp-0x10], 0x2 */
            ii(0x1009_3ada, 2); if(jnzd(0x1009_3ae2, 0x6)) goto l_0x1009_3ae2; /* jnz 0x10093ae2 */
            ii(0x1009_3adc, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1009_3adf, 3); inc(memd_a32[ss, ebp - 0x20]);          /* inc dword [ebp-0x20] */
        l_0x1009_3ae2:
            ii(0x1009_3ae2, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x1009_3ae5, 5); calld(0x1009_c4f8, 0x8a0e);             /* call 0x1009c4f8 */
            ii(0x1009_3aea, 3); mov(memd_a32[ss, ebp - 0x44], eax);     /* mov [ebp-0x44], eax */
            ii(0x1009_3aed, 3); mov(eax, memd_a32[ss, ebp - 0x44]);     /* mov eax, [ebp-0x44] */
            ii(0x1009_3af0, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x1009_3af3, 3); mov(eax, memd_a32[ss, ebp - 0x44]);     /* mov eax, [ebp-0x44] */
            ii(0x1009_3af6, 3); calld_abs(memd_a32[ds, edx + 0x70]);    /* call dword [edx+0x70] */
            ii(0x1009_3af9, 2); test(al, al);                           /* test al, al */
            ii(0x1009_3afb, 2); if(jzd(0x1009_3b10, 0x13)) goto l_0x1009_3b10; /* jz 0x10093b10 */
            ii(0x1009_3afd, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x1009_3b00, 5); calld(0x1009_c4f8, 0x89f3);             /* call 0x1009c4f8 */
            ii(0x1009_3b05, 5); calld(0x1009_c4c4, 0x89ba);             /* call 0x1009c4c4 */
            ii(0x1009_3b0a, 4); cmp(ax, 0x1);                           /* cmp ax, 0x1 */
            ii(0x1009_3b0e, 2); if(jzd(0x1009_3b12, 0x2)) goto l_0x1009_3b12; /* jz 0x10093b12 */
        l_0x1009_3b10:
            ii(0x1009_3b10, 2); jmpd(0x1009_3b32, 0x20); goto l_0x1009_3b32; /* jmp 0x10093b32 */
        l_0x1009_3b12:
            ii(0x1009_3b12, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x1009_3b15, 5); calld(0x1009_c4f8, 0x89de);             /* call 0x1009c4f8 */
            ii(0x1009_3b1a, 5); calld(0x1008_c92d, -0x71f2);            /* call 0x1008c92d */
            ii(0x1009_3b1f, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1009_3b22, 4); movsx(edx, memw_a32[ss, ebp - 0x1c]);   /* movsx edx, word [ebp-0x1c] */
            ii(0x1009_3b26, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x1009_3b2a, 5); calld(Definitions.my_min, -0xa3ab);     /* call 0x10089784 */
            ii(0x1009_3b2f, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
        l_0x1009_3b32:
            ii(0x1009_3b32, 5); jmpd(0x1009_3aab, -0x8c); goto l_0x1009_3aab; /* jmp 0x10093aab */
        l_0x1009_3b37:
            ii(0x1009_3b37, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_3b3a, 3); add(eax, 0x21);                         /* add eax, 0x21 */
            ii(0x1009_3b3d, 5); calld(0x1009_c6c8, 0x8b86);             /* call 0x1009c6c8 */
            ii(0x1009_3b42, 3); lea(ebx, ebp - 0x3c);                   /* lea ebx, [ebp-0x3c] */
            ii(0x1009_3b45, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_3b47, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1009_3b49, 5); calld(0x1009_c560, 0x8a12);             /* call 0x1009c560 */
            ii(0x1009_3b4e, 2); jmpd(0x1009_3b58, 0x8); goto l_0x1009_3b58; /* jmp 0x10093b58 */
        l_0x1009_3b50:
            ii(0x1009_3b50, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x1009_3b53, 5); calld(0x1007_6bf8, -0x1_cf60);          /* call 0x10076bf8 */
        l_0x1009_3b58:
            ii(0x1009_3b58, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_3b5a, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x1009_3b5d, 5); calld(0x1013_ad71, 0xa_720f);           /* call 0x1013ad71 */
            ii(0x1009_3b62, 2); test(al, al);                           /* test al, al */
            ii(0x1009_3b64, 2); if(jzd(0x1009_3bbc, 0x56)) goto l_0x1009_3bbc; /* jz 0x10093bbc */
            ii(0x1009_3b66, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x1009_3b69, 5); calld(0x1009_c4f8, 0x898a);             /* call 0x1009c4f8 */
            ii(0x1009_3b6e, 3); mov(memd_a32[ss, ebp - 0x48], eax);     /* mov [ebp-0x48], eax */
            ii(0x1009_3b71, 3); mov(eax, memd_a32[ss, ebp - 0x48]);     /* mov eax, [ebp-0x48] */
            ii(0x1009_3b74, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x1009_3b77, 3); mov(eax, memd_a32[ss, ebp - 0x48]);     /* mov eax, [ebp-0x48] */
            ii(0x1009_3b7a, 3); calld_abs(memd_a32[ds, edx + 0x70]);    /* call dword [edx+0x70] */
            ii(0x1009_3b7d, 2); test(al, al);                           /* test al, al */
            ii(0x1009_3b7f, 2); if(jzd(0x1009_3b94, 0x13)) goto l_0x1009_3b94; /* jz 0x10093b94 */
            ii(0x1009_3b81, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x1009_3b84, 5); calld(0x1009_c4f8, 0x896f);             /* call 0x1009c4f8 */
            ii(0x1009_3b89, 5); calld(0x1008_c92d, -0x7261);            /* call 0x1008c92d */
            ii(0x1009_3b8e, 4); cmp(ax, memw_a32[ss, ebp - 0x18]);      /* cmp ax, [ebp-0x18] */
            ii(0x1009_3b92, 2); if(jld(0x1009_3b96, 0x2)) goto l_0x1009_3b96; /* jl 0x10093b96 */
        l_0x1009_3b94:
            ii(0x1009_3b94, 2); jmpd(0x1009_3bba, 0x24); goto l_0x1009_3bba; /* jmp 0x10093bba */
        l_0x1009_3b96:
            ii(0x1009_3b96, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x1009_3b99, 5); calld(0x1009_c4f8, 0x895a);             /* call 0x1009c4f8 */
            ii(0x1009_3b9e, 5); calld(0x1009_c4c4, 0x8921);             /* call 0x1009c4c4 */
            ii(0x1009_3ba3, 1); cwde();                                 /* cwde */
            ii(0x1009_3ba4, 5); calld(0x1007_1f2e, -0x2_1c7b);          /* call 0x10071f2e */
            ii(0x1009_3ba9, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1009_3bac, 4); movsx(eax, memw_a32[ss, ebp - 0x1c]);   /* movsx eax, word [ebp-0x1c] */
            ii(0x1009_3bb0, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1009_3bb2, 2); if(jled(0x1009_3bba, 0x6)) goto l_0x1009_3bba; /* jle 0x10093bba */
            ii(0x1009_3bb4, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1009_3bb7, 3); add(memd_a32[ss, ebp - 0x34], eax);     /* add [ebp-0x34], eax */
        l_0x1009_3bba:
            ii(0x1009_3bba, 2); jmpd(0x1009_3b50, -0x6c); goto l_0x1009_3b50; /* jmp 0x10093b50 */
        l_0x1009_3bbc:
            ii(0x1009_3bbc, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1009_3bc1, 5); calld(0x1007_1f2e, -0x2_1c98);          /* call 0x10071f2e */
            ii(0x1009_3bc6, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1009_3bc9, 3); neg(memd_a32[ss, ebp - 0xc]);           /* neg dword [ebp-0xc] */
            ii(0x1009_3bcc, 5); mov(eax, 0x2);                          /* mov eax, 0x2 */
            ii(0x1009_3bd1, 5); calld(0x1007_1f2e, -0x2_1ca8);          /* call 0x10071f2e */
            ii(0x1009_3bd6, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
            ii(0x1009_3bd9, 3); neg(memd_a32[ss, ebp - 0x2c]);          /* neg dword [ebp-0x2c] */
            ii(0x1009_3bdc, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1009_3be1, 5); calld(0x1007_1ec5, -0x2_1d21);          /* call 0x10071ec5 */
            ii(0x1009_3be6, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1009_3be9, 5); mov(eax, 0x2);                          /* mov eax, 0x2 */
            ii(0x1009_3bee, 5); calld(0x1007_1ec5, -0x2_1d2e);          /* call 0x10071ec5 */
            ii(0x1009_3bf3, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x1009_3bf6, 4); movsx(eax, memw_a32[ss, ebp - 0x30]);   /* movsx eax, word [ebp-0x30] */
            ii(0x1009_3bfa, 3); cmp(eax, 0x32);                         /* cmp eax, 0x32 */
            ii(0x1009_3bfd, 2); if(jged(0x1009_3c6a, 0x6b)) goto l_0x1009_3c6a; /* jge 0x10093c6a */
            ii(0x1009_3bff, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x1009_3c03, 4); movsx(edx, memw_a32[ss, ebp - 0x2c]);   /* movsx edx, word [ebp-0x2c] */
            ii(0x1009_3c07, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1009_3c0a, 4); movsx(ebx, memw_a32[ss, ebp - 0x28]);   /* movsx ebx, word [ebp-0x28] */
            ii(0x1009_3c0e, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1009_3c10, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1009_3c13, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1009_3c15, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x1009_3c19, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1009_3c1b, 3); mov(memd_a32[ss, ebp - 0x24], edx);     /* mov [ebp-0x24], edx */
            ii(0x1009_3c1e, 4); movsx(eax, memw_a32[ss, ebp - 0x34]);   /* movsx eax, word [ebp-0x34] */
            ii(0x1009_3c22, 4); movsx(edx, memw_a32[ss, ebp - 0x24]);   /* movsx edx, word [ebp-0x24] */
            ii(0x1009_3c26, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1009_3c28, 4); movsx(ebx, memw_a32[ss, ebp - 0xc]);    /* movsx ebx, word [ebp-0xc] */
            ii(0x1009_3c2c, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1009_3c2e, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1009_3c31, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1009_3c33, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x1009_3c36, 5); mov(ecx, 0xb00);                        /* mov ecx, 0xb00 */
            ii(0x1009_3c3b, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1009_3c40, 4); movsx(edx, memw_a32[ss, ebp - 0x24]);   /* movsx edx, word [ebp-0x24] */
            ii(0x1009_3c44, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_3c47, 5); calld(0x1009_4165, 0x519);              /* call 0x10094165 */
            ii(0x1009_3c4c, 2); test(al, al);                           /* test al, al */
            ii(0x1009_3c4e, 2); if(jzd(0x1009_3c6a, 0x1a)) goto l_0x1009_3c6a; /* jz 0x10093c6a */
            ii(0x1009_3c50, 4); mov(memb_a32[ss, ebp - 0x8], 0x1);      /* mov byte [ebp-0x8], 0x1 */
            ii(0x1009_3c54, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_3c56, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x1009_3c59, 5); calld(0x1009_ba6c, 0x7e0e);             /* call 0x1009ba6c */
            ii(0x1009_3c5e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_3c60, 3); lea(eax, ebp - 0x40);                   /* lea eax, [ebp-0x40] */
            ii(0x1009_3c63, 5); calld(0x1007_5f6c, -0x1_dcfc);          /* call 0x10075f6c */
            ii(0x1009_3c68, 2); jmpd(0x1009_3cd6, 0x6c); goto l_0x1009_3cd6; /* jmp 0x10093cd6 */
        l_0x1009_3c6a:
            ii(0x1009_3c6a, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x1009_3c6d, 4); cmp(ax, memw_a32[ss, ebp - 0x20]);      /* cmp ax, [ebp-0x20] */
            ii(0x1009_3c71, 2); if(jled(0x1009_3c8c, 0x19)) goto l_0x1009_3c8c; /* jle 0x10093c8c */
            ii(0x1009_3c73, 5); mov(ecx, 0xb00);                        /* mov ecx, 0xb00 */
            ii(0x1009_3c78, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x1009_3c7b, 5); mov(edx, 0x2);                          /* mov edx, 0x2 */
            ii(0x1009_3c80, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_3c83, 5); calld(0x1009_6e02, 0x317a);             /* call 0x10096e02 */
            ii(0x1009_3c88, 2); test(al, al);                           /* test al, al */
            ii(0x1009_3c8a, 2); if(jnzd(0x1009_3c8e, 0x2)) goto l_0x1009_3c8e; /* jnz 0x10093c8e */
        l_0x1009_3c8c:
            ii(0x1009_3c8c, 2); jmpd(0x1009_3ca8, 0x1a); goto l_0x1009_3ca8; /* jmp 0x10093ca8 */
        l_0x1009_3c8e:
            ii(0x1009_3c8e, 4); mov(memb_a32[ss, ebp - 0x8], 0x1);      /* mov byte [ebp-0x8], 0x1 */
            ii(0x1009_3c92, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_3c94, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x1009_3c97, 5); calld(0x1009_ba6c, 0x7dd0);             /* call 0x1009ba6c */
            ii(0x1009_3c9c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_3c9e, 3); lea(eax, ebp - 0x40);                   /* lea eax, [ebp-0x40] */
            ii(0x1009_3ca1, 5); calld(0x1007_5f6c, -0x1_dd3a);          /* call 0x10075f6c */
            ii(0x1009_3ca6, 2); jmpd(0x1009_3cd6, 0x2e); goto l_0x1009_3cd6; /* jmp 0x10093cd6 */
        l_0x1009_3ca8:
            ii(0x1009_3ca8, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
            ii(0x1009_3cac, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_3cae, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x1009_3cb1, 5); calld(0x1009_ba6c, 0x7db6);             /* call 0x1009ba6c */
            ii(0x1009_3cb6, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_3cb8, 3); lea(eax, ebp - 0x40);                   /* lea eax, [ebp-0x40] */
            ii(0x1009_3cbb, 5); calld(0x1007_5f6c, -0x1_dd54);          /* call 0x10075f6c */
            ii(0x1009_3cc0, 2); jmpd(0x1009_3cd6, 0x14); goto l_0x1009_3cd6; /* jmp 0x10093cd6 */
        //    ii(0x1009_3cc2, 2); xor(edx, edx);                          /* xor edx, edx */
        //    ii(0x1009_3cc4, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
        //    ii(0x1009_3cc7, 5); calld(0x1009_ba6c, 0x7da0);             /* call 0x1009ba6c */
        //    ii(0x1009_3ccc, 2); xor(edx, edx);                          /* xor edx, edx */
        //    ii(0x1009_3cce, 3); lea(eax, ebp - 0x40);                   /* lea eax, [ebp-0x40] */
        //    ii(0x1009_3cd1, 5); calld(0x1007_5f6c, -0x1_dd6a);          /* call 0x10075f6c */
        l_0x1009_3cd6:
            ii(0x1009_3cd6, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x1009_3cd9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_3cdb, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_3cdc, 1); popd(edi);                              /* pop edi */
            ii(0x1009_3cdd, 1); popd(esi);                              /* pop esi */
            ii(0x1009_3cde, 1); popd(edx);                              /* pop edx */
            ii(0x1009_3cdf, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_3ce0, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_3ce1, 1); retd(); return;                         /* ret */
        }
    }
}
