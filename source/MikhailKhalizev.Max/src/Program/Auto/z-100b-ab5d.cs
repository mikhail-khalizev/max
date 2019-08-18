using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("bc4b389c-9135-4c23-8db9-f76ae4febb8b")]
        public void Method_100b_ab5d()
        {
            ii(0x100b_ab5d, 5); pushd(0x3c);                            /* push 0x3c */
            ii(0x100b_ab62, 5); calld(Definitions.sys_check_available_stack_size, 0xa_b1eb); /* call 0x10165d52 */
            ii(0x100b_ab67, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_ab68, 1); pushd(esi);                             /* push esi */
            ii(0x100b_ab69, 1); pushd(edi);                             /* push edi */
            ii(0x100b_ab6a, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_ab6b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_ab6d, 6); sub(esp, 0x28);                         /* sub esp, 0x28 */
            ii(0x100b_ab73, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100b_ab76, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x100b_ab79, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x100b_ab7c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_ab7f, 5); calld(0x100b_8dfb, -0x1d89);            /* call 0x100b8dfb */
            ii(0x100b_ab84, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_ab86, 6); if(jnzd(0x100b_ad42, 0x1b6)) goto l_0x100b_ad42; /* jnz 0x100bad42 */
            ii(0x100b_ab8c, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100b_ab90, 5); cmp(eax, 0x1000);                       /* cmp eax, 0x1000 */
            ii(0x100b_ab95, 2); if(jled(0x100b_abc7, 0x30)) goto l_0x100b_abc7; /* jle 0x100babc7 */
            ii(0x100b_ab97, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_ab9a, 5); calld(0x1008_a370, -0x3_082f);          /* call 0x1008a370 */
            ii(0x100b_ab9f, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x100b_aba2, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100b_aba7, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100b_abad, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100b_abb0, 3); movsx(edx, memw_a32[ds, edx]);          /* movsx edx, word [edx] */
            ii(0x100b_abb3, 6); imul(edx, edx, 0x247);                  /* imul edx, edx, 0x247 */
            ii(0x100b_abb9, 6); mov(eax, memd_a32[ds, eax + 0x101c_a550]); /* mov eax, [eax+0x101ca550] */
            ii(0x100b_abbf, 6); cmp(eax, memd_a32[ds, edx + 0x101c_a550]); /* cmp eax, [edx+0x101ca550] */
            ii(0x100b_abc5, 2); if(jgd(0x100b_abc9, 0x2)) goto l_0x100b_abc9; /* jg 0x100babc9 */
        l_0x100b_abc7:
            ii(0x100b_abc7, 2); jmpd(0x100b_abe9, 0x20); goto l_0x100b_abe9; /* jmp 0x100babe9 */
        l_0x100b_abc9:
            ii(0x100b_abc9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_abcc, 5); calld(0x1008_a370, -0x3_0861);          /* call 0x1008a370 */
            ii(0x100b_abd1, 5); cmp(memw_a32[ds, eax + 0x8], 0x1e);     /* cmp word [eax+0x8], 0x1e */
            ii(0x100b_abd6, 2); if(jzd(0x100b_abe7, 0xf)) goto l_0x100b_abe7; /* jz 0x100babe7 */
            ii(0x100b_abd8, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_abdb, 5); calld(0x1008_a370, -0x3_0870);          /* call 0x1008a370 */
            ii(0x100b_abe0, 5); cmp(memw_a32[ds, eax + 0x8], 0x28);     /* cmp word [eax+0x8], 0x28 */
            ii(0x100b_abe5, 2); if(jnzd(0x100b_abe9, 0x2)) goto l_0x100b_abe9; /* jnz 0x100babe9 */
        l_0x100b_abe7:
            ii(0x100b_abe7, 2); jmpd(0x100b_abeb, 0x2); goto l_0x100b_abeb; /* jmp 0x100babeb */
        l_0x100b_abe9:
            ii(0x100b_abe9, 2); jmpd(0x100b_abf2, 0x7); goto l_0x100b_abf2; /* jmp 0x100babf2 */
        l_0x100b_abeb:
            ii(0x100b_abeb, 7); mov(memd_a32[ss, ebp - 0x4], 0x1700);   /* mov dword [ebp-0x4], 0x1700 */
        l_0x100b_abf2:
            ii(0x100b_abf2, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_abf5, 3); movsx(ebx, memw_a32[ds, eax]);          /* movsx ebx, word [eax] */
            ii(0x100b_abf8, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_abfb, 5); calld(0x1008_a370, -0x3_0890);          /* call 0x1008a370 */
            ii(0x100b_ac00, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x100b_ac02, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_ac04, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x100b_ac06, 5); calld(0x1007_cfc2, -0x3_dc49);          /* call 0x1007cfc2 */
            ii(0x100b_ac0b, 3); add(eax, memd_a32[ss, ebp - 0x4]);      /* add eax, [ebp-0x4] */
            ii(0x100b_ac0e, 5); add(eax, 0xfa);                         /* add eax, 0xfa */
            ii(0x100b_ac13, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100b_ac16, 7); mov(memd_a32[ss, ebp - 0x14], 0);       /* mov dword [ebp-0x14], 0x0 */
        l_0x100b_ac1d:
            ii(0x100b_ac1d, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100b_ac21, 3); cmp(eax, 0x3);                          /* cmp eax, 0x3 */
            ii(0x100b_ac24, 2); if(jged(0x100b_ac40, 0x1a)) goto l_0x100b_ac40; /* jge 0x100bac40 */
            ii(0x100b_ac26, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_ac28, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100b_ac2c, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100b_ac2f, 3); mov(ebx, memd_a32[ss, ebp - 0xc]);      /* mov ebx, [ebp-0xc] */
            ii(0x100b_ac32, 3); add(ebx, 0x37);                         /* add ebx, 0x37 */
            ii(0x100b_ac35, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x100b_ac37, 5); calld(0x1013_ad71, 0x8_0135);           /* call 0x1013ad71 */
            ii(0x100b_ac3c, 2); test(al, al);                           /* test al, al */
            ii(0x100b_ac3e, 2); if(jnzd(0x100b_ac42, 0x2)) goto l_0x100b_ac42; /* jnz 0x100bac42 */
        l_0x100b_ac40:
            ii(0x100b_ac40, 2); jmpd(0x100b_ac4a, 0x8); goto l_0x100b_ac4a; /* jmp 0x100bac4a */
        l_0x100b_ac42:
            ii(0x100b_ac42, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100b_ac45, 3); inc(memd_a32[ss, ebp - 0x14]);          /* inc dword [ebp-0x14] */
            ii(0x100b_ac48, 2); jmpd(0x100b_ac1d, -0x2d); goto l_0x100b_ac1d; /* jmp 0x100bac1d */
        l_0x100b_ac4a:
            ii(0x100b_ac4a, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100b_ac4e, 3); cmp(eax, 0x3);                          /* cmp eax, 0x3 */
            ii(0x100b_ac51, 2); if(jnzd(0x100b_ac83, 0x30)) goto l_0x100b_ac83; /* jnz 0x100bac83 */
        l_0x100b_ac53:
            ii(0x100b_ac53, 3); dec(memd_a32[ss, ebp - 0x14]);          /* dec dword [ebp-0x14] */
            ii(0x100b_ac56, 5); cmp(memw_a32[ss, ebp - 0x14], -0x1 /* 0xff */); /* cmp word [ebp-0x14], 0xffff */
            ii(0x100b_ac5b, 2); if(jzd(0x100b_ac7f, 0x22)) goto l_0x100b_ac7f; /* jz 0x100bac7f */
            ii(0x100b_ac5d, 4); movsx(edx, memw_a32[ss, ebp - 0x10]);   /* movsx edx, word [ebp-0x10] */
            ii(0x100b_ac61, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100b_ac65, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100b_ac68, 3); mov(ebx, memd_a32[ss, ebp - 0xc]);      /* mov ebx, [ebp-0xc] */
            ii(0x100b_ac6b, 3); add(ebx, 0x37);                         /* add ebx, 0x37 */
            ii(0x100b_ac6e, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x100b_ac70, 5); calld(0x1008_af28, -0x2_fd4d);          /* call 0x1008af28 */
            ii(0x100b_ac75, 5); calld(0x100a_2bc4, -0x1_80b6);          /* call 0x100a2bc4 */
            ii(0x100b_ac7a, 1); cwde();                                 /* cwde */
            ii(0x100b_ac7b, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_ac7d, 2); if(jled(0x100b_ac81, 0x2)) goto l_0x100b_ac81; /* jle 0x100bac81 */
        l_0x100b_ac7f:
            ii(0x100b_ac7f, 2); jmpd(0x100b_ac83, 0x2); goto l_0x100b_ac83; /* jmp 0x100bac83 */
        l_0x100b_ac81:
            ii(0x100b_ac81, 2); jmpd(0x100b_ac53, -0x30); goto l_0x100b_ac53; /* jmp 0x100bac53 */
        l_0x100b_ac83:
            ii(0x100b_ac83, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100b_ac87, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_ac89, 6); if(jld(0x100b_ad42, 0xb3)) goto l_0x100b_ad42; /* jl 0x100bad42 */
            ii(0x100b_ac8f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_ac91, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100b_ac95, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100b_ac98, 3); mov(ebx, memd_a32[ss, ebp - 0xc]);      /* mov ebx, [ebp-0xc] */
            ii(0x100b_ac9b, 3); add(ebx, 0x37);                         /* add ebx, 0x37 */
            ii(0x100b_ac9e, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x100b_aca0, 5); calld(0x1013_ad71, 0x8_00cc);           /* call 0x1013ad71 */
            ii(0x100b_aca5, 2); test(al, al);                           /* test al, al */
            ii(0x100b_aca7, 2); if(jzd(0x100b_accc, 0x23)) goto l_0x100b_accc; /* jz 0x100baccc */
            ii(0x100b_aca9, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100b_acad, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100b_acb0, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100b_acb3, 3); add(edx, 0x37);                         /* add edx, 0x37 */
            ii(0x100b_acb6, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100b_acb8, 5); calld(0x1008_af28, -0x2_fd95);          /* call 0x1008af28 */
            ii(0x100b_acbd, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100b_acc0, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100b_acc3, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x100b_acc6, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100b_acc9, 3); calld_abs(memd_a32[ds, edx + 0x48]);    /* call dword [edx+0x48] */
        l_0x100b_accc:
            ii(0x100b_accc, 5); mov(eax, 0x47);                         /* mov eax, 0x47 */
            ii(0x100b_acd1, 5); calld(Definitions.sys_new, 0xa_b12a);   /* call 0x10165e00 */
            ii(0x100b_acd6, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x100b_acd9, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100b_acdc, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x100b_acdf, 4); cmp(memd_a32[ss, ebp - 0x20], 0);       /* cmp dword [ebp-0x20], 0x0 */
            ii(0x100b_ace3, 2); if(jzd(0x100b_ad01, 0x1c)) goto l_0x100b_ad01; /* jz 0x100bad01 */
            ii(0x100b_ace5, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x100b_ace7, 4); movsx(ebx, memw_a32[ss, ebp - 0x4]);    /* movsx ebx, word [ebp-0x4] */
            ii(0x100b_aceb, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100b_acee, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100b_acf1, 5); calld(0x1008_1116, -0x3_9be0);          /* call 0x10081116 */
            ii(0x100b_acf6, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x100b_acf9, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100b_acfc, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x100b_acff, 2); jmpd(0x100b_ad07, 0x6); goto l_0x100b_ad07; /* jmp 0x100bad07 */
        l_0x100b_ad01:
            ii(0x100b_ad01, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x100b_ad04, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
        l_0x100b_ad07:
            ii(0x100b_ad07, 3); mov(edx, memd_a32[ss, ebp - 0x28]);     /* mov edx, [ebp-0x28] */
            ii(0x100b_ad0a, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100b_ad0e, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100b_ad11, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100b_ad13, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_ad16, 3); add(eax, 0x37);                         /* add eax, 0x37 */
            ii(0x100b_ad19, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x100b_ad1b, 5); calld(0x1008_afe4, -0x2_fd3c);          /* call 0x1008afe4 */
            ii(0x100b_ad20, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100b_ad24, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100b_ad27, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_ad29, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_ad2c, 3); add(eax, 0x37);                         /* add eax, 0x37 */
            ii(0x100b_ad2f, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100b_ad31, 5); calld(0x1008_af84, -0x2_fdb2);          /* call 0x1008af84 */
            ii(0x100b_ad36, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_ad38, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100b_ad3d, 5); calld(0x100a_4d50, -0x1_5ff2);          /* call 0x100a4d50 */
        l_0x100b_ad42:
            ii(0x100b_ad42, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_ad44, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_ad45, 1); popd(edi);                              /* pop edi */
            ii(0x100b_ad46, 1); popd(esi);                              /* pop esi */
            ii(0x100b_ad47, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_ad48, 1); retd(); return;                         /* ret */
        }
    }
}
