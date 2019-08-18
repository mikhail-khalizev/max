using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_3a68-e774053")]
        public void Method_1010_3a68()
        {
            ii(0x1010_3a68, 5); pushd(0x68);                            /* push 0x68 */
            ii(0x1010_3a6d, 5); calld(Definitions.sys_check_available_stack_size, 0x6_22e0); /* call 0x10165d52 */
            ii(0x1010_3a72, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_3a73, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_3a74, 1); pushd(esi);                             /* push esi */
            ii(0x1010_3a75, 1); pushd(edi);                             /* push edi */
            ii(0x1010_3a76, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_3a77, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_3a79, 6); sub(esp, 0x50);                         /* sub esp, 0x50 */
            ii(0x1010_3a7f, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1010_3a82, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1010_3a85, 4); or(memb_a32[ss, ebp - 0xc], 0x1);       /* or byte [ebp-0xc], 0x1 */
            ii(0x1010_3a89, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1010_3a8c, 5); calld(0x100e_0720, -0x2_3371);          /* call 0x100e0720 */
            ii(0x1010_3a91, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x1010_3a94, 4); and(memb_a32[ss, ebp - 0xc], -0x2 /* 0xfe */); /* and byte [ebp-0xc], 0xfe */
            ii(0x1010_3a98, 4); or(memb_a32[ss, ebp - 0xc], 0x1);       /* or byte [ebp-0xc], 0x1 */
            ii(0x1010_3a9c, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1010_3a9f, 5); calld(0x100e_0720, -0x2_3384);          /* call 0x100e0720 */
            ii(0x1010_3aa4, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1010_3aa7, 4); and(memb_a32[ss, ebp - 0xc], -0x2 /* 0xfe */); /* and byte [ebp-0xc], 0xfe */
            ii(0x1010_3aab, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_3aae, 5); calld(0x1010_380b, -0x2a8);             /* call 0x1010380b */
            ii(0x1010_3ab3, 5); mov(edx, 0x101b_63ec);                  /* mov edx, 0x101b63ec */
            ii(0x1010_3ab8, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_3abb, 3); mov(eax, memd_a32[ds, eax + 0x4]);      /* mov eax, [eax+0x4] */
            ii(0x1010_3abe, 5); calld(Definitions.sys_call_dtor_arr, 0x6_24f5); /* call 0x10165fb8 */
            ii(0x1010_3ac3, 5); calld(Definitions.sys_delete_arr, 0x6_2510); /* call 0x10165fd8 */
            ii(0x1010_3ac8, 5); mov(edx, StringDefinitions.HashSize);   /* mov edx, 0x101a31e5 */
            ii(0x1010_3acd, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_3ad0, 5); calld(0x1014_60aa, 0x4_25d5);           /* call 0x101460aa */
            ii(0x1010_3ad5, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1010_3ad7, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_3ada, 3); mov(memw_a32[ds, eax], dx);             /* mov [eax], dx */
            ii(0x1010_3add, 5); mov(edx, StringDefinitions.XShift);     /* mov edx, 0x101a31ef */
            ii(0x1010_3ae2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_3ae5, 5); calld(0x1014_60aa, 0x4_25c0);           /* call 0x101460aa */
            ii(0x1010_3aea, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1010_3aed, 4); mov(memw_a32[ds, edx + 0x2], ax);       /* mov [edx+0x2], ax */
            ii(0x1010_3af1, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_3af4, 3); mov(ax, memw_a32[ds, eax]);             /* mov ax, [eax] */
            ii(0x1010_3af7, 4); mov(memw_a32[ss, ebp - 0x14], ax);      /* mov [ebp-0x14], ax */
            ii(0x1010_3afb, 5); mov(ebx, 0x101b_63ec);                  /* mov ebx, 0x101b63ec */
            ii(0x1010_3b00, 3); mov(edx, memd_a32[ss, ebp - 0x16]);     /* mov edx, [ebp-0x16] */
            ii(0x1010_3b03, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1010_3b06, 3); mov(eax, memd_a32[ss, ebp - 0x16]);     /* mov eax, [ebp-0x16] */
            ii(0x1010_3b09, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1010_3b0c, 3); imul(eax, eax, 0xa);                    /* imul eax, eax, 0xa */
            ii(0x1010_3b0f, 3); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x1010_3b12, 5); calld(Definitions.sys_new_arr, 0x6_24f9); /* call 0x10166010 */
            ii(0x1010_3b17, 5); calld(Definitions.sys_call_ctor_arr, 0x6_e2e3); /* call 0x10171dff */
            ii(0x1010_3b1c, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1010_3b1f, 3); mov(memd_a32[ds, edx + 0x4], eax);      /* mov [edx+0x4], eax */
        l_0x1010_3b22:
            ii(0x1010_3b22, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1010_3b24, 5); mov(ebx, StringDefinitions.Entry);      /* mov ebx, 0x101a31f7 */
            ii(0x1010_3b29, 3); lea(edx, ebp - 0x18);                   /* lea edx, [ebp-0x18] */
            ii(0x1010_3b2c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_3b2f, 5); calld(0x1014_625c, 0x4_2728);           /* call 0x1014625c */
            ii(0x1010_3b34, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1010_3b36, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1010_3b39, 5); calld(0x100e_06a4, -0x2_349a);          /* call 0x100e06a4 */
            ii(0x1010_3b3e, 2); mov(edx, ecx);                          /* mov edx, ecx */
            ii(0x1010_3b40, 5); calld(0x1013_ad71, 0x3_722c);           /* call 0x1013ad71 */
            ii(0x1010_3b45, 2); test(al, al);                           /* test al, al */
            ii(0x1010_3b47, 2); if(jzd(0x1010_3b52, 0x9)) goto l_0x1010_3b52; /* jz 0x10103b52 */
            ii(0x1010_3b49, 7); mov(memd_a32[ss, ebp - 0x2c], 0x1);     /* mov dword [ebp-0x2c], 0x1 */
            ii(0x1010_3b50, 2); jmpd(0x1010_3b59, 0x7); goto l_0x1010_3b59; /* jmp 0x10103b59 */
        l_0x1010_3b52:
            ii(0x1010_3b52, 7); mov(memd_a32[ss, ebp - 0x2c], 0);       /* mov dword [ebp-0x2c], 0x0 */
        l_0x1010_3b59:
            ii(0x1010_3b59, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x1010_3b5c, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
            ii(0x1010_3b5f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_3b61, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1010_3b64, 5); calld(0x100e_03fc, -0x2_376d);          /* call 0x100e03fc */
            ii(0x1010_3b69, 4); cmp(memd_a32[ss, ebp - 0x30], 0);       /* cmp dword [ebp-0x30], 0x0 */
            ii(0x1010_3b6d, 6); if(jzd(0x1010_3c4b, 0xd8)) goto l_0x1010_3c4b; /* jz 0x10103c4b */
            ii(0x1010_3b73, 5); mov(edx, StringDefinitions.Index5);     /* mov edx, 0x101a31fd */
            ii(0x1010_3b78, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1010_3b7b, 5); calld(0x100e_0648, -0x2_3538);          /* call 0x100e0648 */
            ii(0x1010_3b80, 5); calld(0x1014_60aa, 0x4_2525);           /* call 0x101460aa */
            ii(0x1010_3b85, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
        l_0x1010_3b88:
            ii(0x1010_3b88, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1010_3b8a, 5); mov(ebx, StringDefinitions.List);       /* mov ebx, 0x101a3203 */
            ii(0x1010_3b8f, 3); lea(edx, ebp - 0x34);                   /* lea edx, [ebp-0x34] */
            ii(0x1010_3b92, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1010_3b95, 5); calld(0x100e_0648, -0x2_3552);          /* call 0x100e0648 */
            ii(0x1010_3b9a, 5); calld(0x1014_625c, 0x4_26bd);           /* call 0x1014625c */
            ii(0x1010_3b9f, 3); lea(ebx, ebp - 0x20);                   /* lea ebx, [ebp-0x20] */
            ii(0x1010_3ba2, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1010_3ba4, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1010_3ba6, 5); calld(0x100e_06a4, -0x2_3507);          /* call 0x100e06a4 */
            ii(0x1010_3bab, 2); mov(edx, ecx);                          /* mov edx, ecx */
            ii(0x1010_3bad, 5); calld(0x1013_ad71, 0x3_71bf);           /* call 0x1013ad71 */
            ii(0x1010_3bb2, 2); test(al, al);                           /* test al, al */
            ii(0x1010_3bb4, 2); if(jzd(0x1010_3bbf, 0x9)) goto l_0x1010_3bbf; /* jz 0x10103bbf */
            ii(0x1010_3bb6, 7); mov(memd_a32[ss, ebp - 0x38], 0x1);     /* mov dword [ebp-0x38], 0x1 */
            ii(0x1010_3bbd, 2); jmpd(0x1010_3bc6, 0x7); goto l_0x1010_3bc6; /* jmp 0x10103bc6 */
        l_0x1010_3bbf:
            ii(0x1010_3bbf, 7); mov(memd_a32[ss, ebp - 0x38], 0);       /* mov dword [ebp-0x38], 0x0 */
        l_0x1010_3bc6:
            ii(0x1010_3bc6, 3); mov(eax, memd_a32[ss, ebp - 0x38]);     /* mov eax, [ebp-0x38] */
            ii(0x1010_3bc9, 3); mov(memd_a32[ss, ebp - 0x3c], eax);     /* mov [ebp-0x3c], eax */
            ii(0x1010_3bcc, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_3bce, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1010_3bd1, 5); calld(0x100e_03fc, -0x2_37da);          /* call 0x100e03fc */
            ii(0x1010_3bd6, 4); cmp(memd_a32[ss, ebp - 0x3c], 0);       /* cmp dword [ebp-0x3c], 0x0 */
            ii(0x1010_3bda, 2); if(jzd(0x1010_3c46, 0x6a)) goto l_0x1010_3c46; /* jz 0x10103c46 */
            ii(0x1010_3bdc, 5); mov(eax, 0x14);                         /* mov eax, 0x14 */
            ii(0x1010_3be1, 5); calld(Definitions.sys_new, 0x6_221a);   /* call 0x10165e00 */
            ii(0x1010_3be6, 3); mov(memd_a32[ss, ebp - 0x40], eax);     /* mov [ebp-0x40], eax */
            ii(0x1010_3be9, 3); mov(eax, memd_a32[ss, ebp - 0x40]);     /* mov eax, [ebp-0x40] */
            ii(0x1010_3bec, 3); mov(memd_a32[ss, ebp - 0x44], eax);     /* mov [ebp-0x44], eax */
            ii(0x1010_3bef, 4); cmp(memd_a32[ss, ebp - 0x44], 0);       /* cmp dword [ebp-0x44], 0x0 */
            ii(0x1010_3bf3, 2); if(jzd(0x1010_3c0c, 0x17)) goto l_0x1010_3c0c; /* jz 0x10103c0c */
            ii(0x1010_3bf5, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1010_3bf7, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_3bf9, 3); mov(eax, memd_a32[ss, ebp - 0x40]);     /* mov eax, [ebp-0x40] */
            ii(0x1010_3bfc, 5); calld(0x1010_3069, -0xb98);             /* call 0x10103069 */
            ii(0x1010_3c01, 3); mov(memd_a32[ss, ebp - 0x48], eax);     /* mov [ebp-0x48], eax */
            ii(0x1010_3c04, 3); mov(eax, memd_a32[ss, ebp - 0x48]);     /* mov eax, [ebp-0x48] */
            ii(0x1010_3c07, 3); mov(memd_a32[ss, ebp - 0x4c], eax);     /* mov [ebp-0x4c], eax */
            ii(0x1010_3c0a, 2); jmpd(0x1010_3c12, 0x6); goto l_0x1010_3c12; /* jmp 0x10103c12 */
        l_0x1010_3c0c:
            ii(0x1010_3c0c, 3); mov(eax, memd_a32[ss, ebp - 0x44]);     /* mov eax, [ebp-0x44] */
            ii(0x1010_3c0f, 3); mov(memd_a32[ss, ebp - 0x4c], eax);     /* mov [ebp-0x4c], eax */
        l_0x1010_3c12:
            ii(0x1010_3c12, 3); mov(eax, memd_a32[ss, ebp - 0x4c]);     /* mov eax, [ebp-0x4c] */
            ii(0x1010_3c15, 3); mov(memd_a32[ss, ebp - 0x50], eax);     /* mov [ebp-0x50], eax */
            ii(0x1010_3c18, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1010_3c1b, 5); calld(0x1010_48c0, 0xca0);              /* call 0x101048c0 */
            ii(0x1010_3c20, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1010_3c22, 3); mov(eax, memd_a32[ss, ebp - 0x50]);     /* mov eax, [ebp-0x50] */
            ii(0x1010_3c25, 5); calld(0x1010_3182, -0xaa8);             /* call 0x10103182 */
            ii(0x1010_3c2a, 3); mov(edx, memd_a32[ss, ebp - 0x50]);     /* mov edx, [ebp-0x50] */
            ii(0x1010_3c2d, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1010_3c31, 3); imul(ebx, eax, 0xa);                    /* imul ebx, eax, 0xa */
            ii(0x1010_3c34, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_3c37, 3); mov(eax, memd_a32[ds, eax + 0x4]);      /* mov eax, [eax+0x4] */
            ii(0x1010_3c3a, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1010_3c3c, 5); calld(0x1010_4674, 0xa33);              /* call 0x10104674 */
            ii(0x1010_3c41, 5); jmpd(0x1010_3b88, -0xbe); goto l_0x1010_3b88; /* jmp 0x10103b88 */
        l_0x1010_3c46:
            ii(0x1010_3c46, 5); jmpd(0x1010_3b22, -0x129); goto l_0x1010_3b22; /* jmp 0x10103b22 */
        l_0x1010_3c4b:
            ii(0x1010_3c4b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_3c4d, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1010_3c50, 5); calld(0x100e_03fc, -0x2_3859);          /* call 0x100e03fc */
            ii(0x1010_3c55, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_3c57, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1010_3c5a, 5); calld(0x100e_03fc, -0x2_3863);          /* call 0x100e03fc */
            ii(0x1010_3c5f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_3c61, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_3c62, 1); popd(edi);                              /* pop edi */
            ii(0x1010_3c63, 1); popd(esi);                              /* pop esi */
            ii(0x1010_3c64, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_3c65, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_3c66, 1); retd(); return;                         /* ret */
        }
    }
}
