using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_bc8c-c2824fd9")]
        public void Method_1013_bc8c()
        {
            ii(0x1013_bc8c, 5); pushd(0x3c);                            /* push 0x3c */
            ii(0x1013_bc91, 5); calld(Definitions.sys_check_available_stack_size, 0x2_a0bc); /* call 0x10165d52 */
            ii(0x1013_bc96, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_bc97, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_bc98, 1); pushd(edx);                             /* push edx */
            ii(0x1013_bc99, 1); pushd(esi);                             /* push esi */
            ii(0x1013_bc9a, 1); pushd(edi);                             /* push edi */
            ii(0x1013_bc9b, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_bc9c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_bc9e, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x1013_bca4, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1013_bca7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_bcaa, 5); calld(0x1013_bc4f, -0x60);              /* call 0x1013bc4f */
            ii(0x1013_bcaf, 5); and(eax, 0xffff);                       /* and eax, 0xffff */
            ii(0x1013_bcb4, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1013_bcb7, 4); cmp(memd_a32[ss, ebp - 0x10], 0);       /* cmp dword [ebp-0x10], 0x0 */
            ii(0x1013_bcbb, 2); if(jnzd(0x1013_bcc9, 0xc)) goto l_0x1013_bcc9; /* jnz 0x1013bcc9 */
            ii(0x1013_bcbd, 7); mov(memd_a32[ss, ebp - 0x14], 0);       /* mov dword [ebp-0x14], 0x0 */
            ii(0x1013_bcc4, 5); jmpd(0x1013_bdbc, 0xf3); goto l_0x1013_bdbc; /* jmp 0x1013bdbc */
        l_0x1013_bcc9:
            ii(0x1013_bcc9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_bccc, 3); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x1013_bccf, 5); calld(Definitions.my_1_get_count, -0x9_07fc); /* call 0x100ab4d8 */
            ii(0x1013_bcd4, 1); cwde();                                 /* cwde */
            ii(0x1013_bcd5, 3); cmp(eax, memd_a32[ss, ebp - 0x10]);     /* cmp eax, [ebp-0x10] */
            ii(0x1013_bcd8, 2); if(jbd(0x1013_bcf4, 0x1a)) goto l_0x1013_bcf4; /* jb 0x1013bcf4 */
            ii(0x1013_bcda, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_bcdd, 1); dec(eax);                               /* dec eax */
            ii(0x1013_bcde, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1013_bce1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_bce4, 3); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x1013_bce7, 5); calld(0x1013_c5f8, 0x90c);              /* call 0x1013c5f8 */
            ii(0x1013_bcec, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1013_bcef, 5); jmpd(0x1013_bdbc, 0xc8); goto l_0x1013_bdbc; /* jmp 0x1013bdbc */
        l_0x1013_bcf4:
            ii(0x1013_bcf4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_bcf7, 3); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x1013_bcfa, 5); calld(Definitions.my_1_get_count, -0x9_0827); /* call 0x100ab4d8 */
            ii(0x1013_bcff, 1); cwde();                                 /* cwde */
            ii(0x1013_bd00, 1); inc(eax);                               /* inc eax */
            ii(0x1013_bd01, 3); cmp(eax, memd_a32[ss, ebp - 0x10]);     /* cmp eax, [ebp-0x10] */
            ii(0x1013_bd04, 2); if(jnzd(0x1013_bd0f, 0x9)) goto l_0x1013_bd0f; /* jnz 0x1013bd0f */
            ii(0x1013_bd06, 7); mov(memd_a32[ss, ebp - 0x18], 0);       /* mov dword [ebp-0x18], 0x0 */
            ii(0x1013_bd0d, 2); jmpd(0x1013_bd28, 0x19); goto l_0x1013_bd28; /* jmp 0x1013bd28 */
        l_0x1013_bd0f:
            ii(0x1013_bd0f, 5); mov(ecx, 0xb7);                         /* mov ecx, 0xb7 */
            ii(0x1013_bd14, 5); mov(ebx, StringDefinitions.SmrtfileCpp3); /* mov ebx, 0x101acc63 */
            ii(0x1013_bd19, 5); mov(edx, StringDefinitions.ObjectIndexEqualReadObjectsGetcount1); /* mov edx, 0x101acc70 */
            ii(0x1013_bd1e, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_bd20, 5); calld(Definitions.sys_assert, 0x2_a06d); /* call 0x10165d92 */
            ii(0x1013_bd25, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
        l_0x1013_bd28:
            ii(0x1013_bd28, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_bd2b, 5); calld(0x1013_bc4f, -0xe1);              /* call 0x1013bc4f */
            ii(0x1013_bd30, 5); and(eax, 0xffff);                       /* and eax, 0xffff */
            ii(0x1013_bd35, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1013_bd38, 4); cmp(memd_a32[ss, ebp - 0xc], 0);        /* cmp dword [ebp-0xc], 0x0 */
            ii(0x1013_bd3c, 2); if(jzd(0x1013_bd47, 0x9)) goto l_0x1013_bd47; /* jz 0x1013bd47 */
            ii(0x1013_bd3e, 7); mov(memd_a32[ss, ebp - 0x1c], 0);       /* mov dword [ebp-0x1c], 0x0 */
            ii(0x1013_bd45, 2); jmpd(0x1013_bd60, 0x19); goto l_0x1013_bd60; /* jmp 0x1013bd60 */
        l_0x1013_bd47:
            ii(0x1013_bd47, 5); mov(ecx, 0xbf);                         /* mov ecx, 0xbf */
            ii(0x1013_bd4c, 5); mov(ebx, StringDefinitions.SmrtfileCpp2); /* mov ebx, 0x101acc9c */
            ii(0x1013_bd51, 5); mov(edx, StringDefinitions.TypeIndexNotEqual0); /* mov edx, 0x101acca9 */
            ii(0x1013_bd56, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_bd58, 5); calld(Definitions.sys_assert, 0x2_a035); /* call 0x10165d92 */
            ii(0x1013_bd5d, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
        l_0x1013_bd60:
            ii(0x1013_bd60, 5); mov(eax, memd_a32[ds, 0x101c_7274]);    /* mov eax, [0x101c7274] */
            ii(0x1013_bd65, 5); calld(Definitions.my_1_get_count, -0x9_0892); /* call 0x100ab4d8 */
            ii(0x1013_bd6a, 1); cwde();                                 /* cwde */
            ii(0x1013_bd6b, 3); cmp(eax, memd_a32[ss, ebp - 0xc]);      /* cmp eax, [ebp-0xc] */
            ii(0x1013_bd6e, 2); if(jbd(0x1013_bd79, 0x9)) goto l_0x1013_bd79; /* jb 0x1013bd79 */
            ii(0x1013_bd70, 7); mov(memd_a32[ss, ebp - 0x20], 0);       /* mov dword [ebp-0x20], 0x0 */
            ii(0x1013_bd77, 2); jmpd(0x1013_bd92, 0x19); goto l_0x1013_bd92; /* jmp 0x1013bd92 */
        l_0x1013_bd79:
            ii(0x1013_bd79, 5); mov(ecx, 0xc0);                         /* mov ecx, 0xc0 */
            ii(0x1013_bd7e, 5); mov(ebx, StringDefinitions.SmrtfileCpp); /* mov ebx, 0x101accb9 */
            ii(0x1013_bd83, 5); mov(edx, StringDefinitions.TypeIndexLessOrEqualRegisteredClassesGetcount); /* mov edx, 0x101accc6 */
            ii(0x1013_bd88, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_bd8a, 5); calld(Definitions.sys_assert, 0x2_a003); /* call 0x10165d92 */
            ii(0x1013_bd8f, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
        l_0x1013_bd92:
            ii(0x1013_bd92, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_bd95, 1); dec(eax);                               /* dec eax */
            ii(0x1013_bd96, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1013_bd99, 5); mov(eax, memd_a32[ds, 0x101c_7274]);    /* mov eax, [0x101c7274] */
            ii(0x1013_bd9e, 5); calld(0x1013_c798, 0x9f5);              /* call 0x1013c798 */
            ii(0x1013_bda3, 5); calld(0x1013_c808, 0xa60);              /* call 0x1013c808 */
            ii(0x1013_bda8, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_bdab, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1013_bdae, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_bdb1, 5); calld(0x1013_bac1, -0x2f5);             /* call 0x1013bac1 */
            ii(0x1013_bdb6, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_bdb9, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
        l_0x1013_bdbc:
            ii(0x1013_bdbc, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1013_bdbf, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_bdc1, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_bdc2, 1); popd(edi);                              /* pop edi */
            ii(0x1013_bdc3, 1); popd(esi);                              /* pop esi */
            ii(0x1013_bdc4, 1); popd(edx);                              /* pop edx */
            ii(0x1013_bdc5, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_bdc6, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_bdc7, 1); retd(); return;                         /* ret */
        }
    }
}
