using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_3ce2-4f7549f3")]
        public void Method_1009_3ce2()
        {
            ii(0x1009_3ce2, 5); pushd(0x3c);                            /* push 0x3c */
            ii(0x1009_3ce7, 5); calld(Definitions.sys_check_available_stack_size, 0xd_2066); /* call 0x10165d52 */
            ii(0x1009_3cec, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_3ced, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_3cee, 1); pushd(edx);                             /* push edx */
            ii(0x1009_3cef, 1); pushd(esi);                             /* push esi */
            ii(0x1009_3cf0, 1); pushd(edi);                             /* push edi */
            ii(0x1009_3cf1, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_3cf2, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_3cf4, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x1009_3cfa, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1009_3cfd, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_3d00, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1009_3d03, 5); calld(0x1007_6338, -0x1_d9d0);          /* call 0x10076338 */
            ii(0x1009_3d08, 3); lea(ebx, ebp - 0x1c);                   /* lea ebx, [ebp-0x1c] */
            ii(0x1009_3d0b, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_3d0d, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1009_3d0f, 5); calld(0x1007_64b8, -0x1_d85c);          /* call 0x100764b8 */
            ii(0x1009_3d14, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
            ii(0x1009_3d1b, 2); jmpd(0x1009_3d25, 0x8); goto l_0x1009_3d25; /* jmp 0x10093d25 */
        l_0x1009_3d1d:
            ii(0x1009_3d1d, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1009_3d20, 5); calld(0x1007_6bf8, -0x1_d12d);          /* call 0x10076bf8 */
        l_0x1009_3d25:
            ii(0x1009_3d25, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_3d27, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1009_3d2a, 5); calld(0x1013_ad71, 0xa_7042);           /* call 0x1013ad71 */
            ii(0x1009_3d2f, 2); test(al, al);                           /* test al, al */
            ii(0x1009_3d31, 2); if(jzd(0x1009_3d59, 0x26)) goto l_0x1009_3d59; /* jz 0x10093d59 */
            ii(0x1009_3d33, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1009_3d36, 5); calld(0x1007_63a0, -0x1_d99b);          /* call 0x100763a0 */
            ii(0x1009_3d3b, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x1009_3d3e, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_3d41, 5); calld(0x1007_1ff5, -0x2_1d51);          /* call 0x10071ff5 */
            ii(0x1009_3d46, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1009_3d49, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x1009_3d4d, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1009_3d4f, 2); if(jled(0x1009_3d57, 0x6)) goto l_0x1009_3d57; /* jle 0x10093d57 */
            ii(0x1009_3d51, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1009_3d54, 3); add(memd_a32[ss, ebp - 0x10], eax);     /* add [ebp-0x10], eax */
        l_0x1009_3d57:
            ii(0x1009_3d57, 2); jmpd(0x1009_3d1d, -0x3c); goto l_0x1009_3d1d; /* jmp 0x10093d1d */
        l_0x1009_3d59:
            ii(0x1009_3d59, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_3d5c, 3); add(eax, 0x21);                         /* add eax, 0x21 */
            ii(0x1009_3d5f, 5); calld(0x1009_c6c8, 0x8964);             /* call 0x1009c6c8 */
            ii(0x1009_3d64, 3); lea(ebx, ebp - 0x18);                   /* lea ebx, [ebp-0x18] */
            ii(0x1009_3d67, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_3d69, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1009_3d6b, 5); calld(0x1009_c5dc, 0x886c);             /* call 0x1009c5dc */
            ii(0x1009_3d70, 2); jmpd(0x1009_3d7a, 0x8); goto l_0x1009_3d7a; /* jmp 0x10093d7a */
        l_0x1009_3d72:
            ii(0x1009_3d72, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1009_3d75, 5); calld(0x1007_6bf8, -0x1_d182);          /* call 0x10076bf8 */
        l_0x1009_3d7a:
            ii(0x1009_3d7a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_3d7c, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1009_3d7f, 5); calld(0x1013_ad71, 0xa_6fed);           /* call 0x1013ad71 */
            ii(0x1009_3d84, 2); test(al, al);                           /* test al, al */
            ii(0x1009_3d86, 2); if(jzd(0x1009_3dc9, 0x41)) goto l_0x1009_3dc9; /* jz 0x10093dc9 */
            ii(0x1009_3d88, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1009_3d8b, 5); calld(0x1009_c4f8, 0x8768);             /* call 0x1009c4f8 */
            ii(0x1009_3d90, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1009_3d93, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1009_3d96, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x1009_3d99, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1009_3d9c, 3); calld_abs(memd_a32[ds, edx + 0x70]);    /* call dword [edx+0x70] */
            ii(0x1009_3d9f, 2); test(al, al);                           /* test al, al */
            ii(0x1009_3da1, 2); if(jzd(0x1009_3dc7, 0x24)) goto l_0x1009_3dc7; /* jz 0x10093dc7 */
            ii(0x1009_3da3, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1009_3da6, 5); calld(0x1009_c4f8, 0x874d);             /* call 0x1009c4f8 */
            ii(0x1009_3dab, 5); calld(0x1009_c4c4, 0x8714);             /* call 0x1009c4c4 */
            ii(0x1009_3db0, 1); cwde();                                 /* cwde */
            ii(0x1009_3db1, 5); calld(0x1007_1ff5, -0x2_1dc1);          /* call 0x10071ff5 */
            ii(0x1009_3db6, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1009_3db9, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x1009_3dbd, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1009_3dbf, 2); if(jled(0x1009_3dc7, 0x6)) goto l_0x1009_3dc7; /* jle 0x10093dc7 */
            ii(0x1009_3dc1, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1009_3dc4, 3); add(memd_a32[ss, ebp - 0x10], eax);     /* add [ebp-0x10], eax */
        l_0x1009_3dc7:
            ii(0x1009_3dc7, 2); jmpd(0x1009_3d72, -0x57); goto l_0x1009_3d72; /* jmp 0x10093d72 */
        l_0x1009_3dc9:
            ii(0x1009_3dc9, 5); mov(eax, 0x1c);                         /* mov eax, 0x1c */
            ii(0x1009_3dce, 5); calld(0x1007_1ff5, -0x2_1dde);          /* call 0x10071ff5 */
            ii(0x1009_3dd3, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_3dd6, 3); neg(memd_a32[ss, ebp - 0x8]);           /* neg dword [ebp-0x8] */
            ii(0x1009_3dd9, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1009_3ddd, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1009_3de1, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1009_3de3, 4); movsx(ebx, memw_a32[ss, ebp - 0x8]);    /* movsx ebx, word [ebp-0x8] */
            ii(0x1009_3de7, 3); lea(edx, eax - 0x1);                    /* lea edx, [eax-0x1] */
            ii(0x1009_3dea, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1009_3dec, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1009_3def, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1009_3df1, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1009_3df4, 5); mov(ecx, 0xc00);                        /* mov ecx, 0xc00 */
            ii(0x1009_3df9, 5); mov(ebx, 0x1c);                         /* mov ebx, 0x1c */
            ii(0x1009_3dfe, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x1009_3e02, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_3e05, 5); calld(0x1009_4165, 0x35b);              /* call 0x10094165 */
            ii(0x1009_3e0a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_3e0c, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1009_3e0f, 5); calld(0x1009_ba6c, 0x7c58);             /* call 0x1009ba6c */
            ii(0x1009_3e14, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_3e16, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1009_3e19, 5); calld(0x1007_5f6c, -0x1_deb2);          /* call 0x10075f6c */
            ii(0x1009_3e1e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_3e20, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_3e21, 1); popd(edi);                              /* pop edi */
            ii(0x1009_3e22, 1); popd(esi);                              /* pop esi */
            ii(0x1009_3e23, 1); popd(edx);                              /* pop edx */
            ii(0x1009_3e24, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_3e25, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_3e26, 1); retd(); return;                         /* ret */
        }
    }
}
