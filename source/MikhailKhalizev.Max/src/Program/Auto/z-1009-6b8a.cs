using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_6b8a-b0c42810")]
        public void Method_1009_6b8a()
        {
            ii(0x1009_6b8a, 5); pushd(0x50);                            /* push 0x50 */
            ii(0x1009_6b8f, 5); calld(Definitions.sys_check_available_stack_size, 0xc_f1be); /* call 0x10165d52 */
            ii(0x1009_6b94, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_6b95, 1); pushd(esi);                             /* push esi */
            ii(0x1009_6b96, 1); pushd(edi);                             /* push edi */
            ii(0x1009_6b97, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_6b98, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_6b9a, 6); sub(esp, 0x34);                         /* sub esp, 0x34 */
            ii(0x1009_6ba0, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1009_6ba3, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1009_6ba6, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x1009_6ba9, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_6bac, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1009_6baf, 5); calld(0x1007_6338, -0x2_087c);          /* call 0x10076338 */
            ii(0x1009_6bb4, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_6bb6, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1009_6bb9, 5); calld(0x1007_64b8, -0x2_0706);          /* call 0x100764b8 */
            ii(0x1009_6bbe, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1009_6bc0, 1); pushd(eax);                             /* push eax */
            ii(0x1009_6bc1, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1009_6bc3, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1009_6bc5, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_6bc7, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x1009_6bca, 5); calld(0x1008_b148, -0xba87);            /* call 0x1008b148 */
            ii(0x1009_6bcf, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_6bd2, 5); calld(0x1009_c4c4, 0x58ed);             /* call 0x1009c4c4 */
            ii(0x1009_6bd7, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1009_6bda, 5); cmp(memw_a32[ss, ebp - 0x18], 0x5);     /* cmp word [ebp-0x18], 0x5 */
            ii(0x1009_6bdf, 2); if(jnzd(0x1009_6bf7, 0x16)) goto l_0x1009_6bf7; /* jnz 0x10096bf7 */
            ii(0x1009_6be1, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x1009_6be4, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1009_6be7, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_6bea, 5); calld(0x1009_6a12, -0x1dd);             /* call 0x10096a12 */
            ii(0x1009_6bef, 3); mov(memb_a32[ss, ebp - 0x10], al);      /* mov [ebp-0x10], al */
            ii(0x1009_6bf2, 5); jmpd(0x1009_6c71, 0x7a); goto l_0x1009_6c71; /* jmp 0x10096c71 */
        l_0x1009_6bf7:
            ii(0x1009_6bf7, 5); cmp(memw_a32[ss, ebp - 0x18], 0x22);    /* cmp word [ebp-0x18], 0x22 */
            ii(0x1009_6bfc, 2); if(jzd(0x1009_6c05, 0x7)) goto l_0x1009_6c05; /* jz 0x10096c05 */
            ii(0x1009_6bfe, 5); cmp(memw_a32[ss, ebp - 0x18], 0x25);    /* cmp word [ebp-0x18], 0x25 */
            ii(0x1009_6c03, 2); if(jnzd(0x1009_6c07, 0x2)) goto l_0x1009_6c07; /* jnz 0x10096c07 */
        l_0x1009_6c05:
            ii(0x1009_6c05, 2); jmpd(0x1009_6c0e, 0x7); goto l_0x1009_6c0e; /* jmp 0x10096c0e */
        l_0x1009_6c07:
            ii(0x1009_6c07, 5); cmp(memw_a32[ss, ebp - 0x18], 0x24);    /* cmp word [ebp-0x18], 0x24 */
            ii(0x1009_6c0c, 2); if(jnzd(0x1009_6c10, 0x2)) goto l_0x1009_6c10; /* jnz 0x10096c10 */
        l_0x1009_6c0e:
            ii(0x1009_6c0e, 2); jmpd(0x1009_6c17, 0x7); goto l_0x1009_6c17; /* jmp 0x10096c17 */
        l_0x1009_6c10:
            ii(0x1009_6c10, 5); cmp(memw_a32[ss, ebp - 0x18], 0x23);    /* cmp word [ebp-0x18], 0x23 */
            ii(0x1009_6c15, 2); if(jnzd(0x1009_6c48, 0x31)) goto l_0x1009_6c48; /* jnz 0x10096c48 */
        l_0x1009_6c17:
            ii(0x1009_6c17, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_6c1a, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
            ii(0x1009_6c1d, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x1009_6c20, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x1009_6c23, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x1009_6c26, 3); calld_abs(memd_a32[ds, edx + 0x14]);    /* call dword [edx+0x14] */
            ii(0x1009_6c29, 1); cwde();                                 /* cwde */
            ii(0x1009_6c2a, 1); pushd(eax);                             /* push eax */
            ii(0x1009_6c2b, 5); mov(eax, 0x5);                          /* mov eax, 0x5 */
            ii(0x1009_6c30, 1); pushd(eax);                             /* push eax */
            ii(0x1009_6c31, 3); mov(ecx, memd_a32[ss, ebp - 0x4]);      /* mov ecx, [ebp-0x4] */
            ii(0x1009_6c34, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x1009_6c37, 4); movsx(edx, memw_a32[ss, ebp - 0x18]);   /* movsx edx, word [ebp-0x18] */
            ii(0x1009_6c3b, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_6c3e, 5); calld(0x1009_5f0a, -0xd39);             /* call 0x10095f0a */
            ii(0x1009_6c43, 3); mov(memb_a32[ss, ebp - 0x10], al);      /* mov [ebp-0x10], al */
            ii(0x1009_6c46, 2); jmpd(0x1009_6c71, 0x29); goto l_0x1009_6c71; /* jmp 0x10096c71 */
        l_0x1009_6c48:
            ii(0x1009_6c48, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_6c4b, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
            ii(0x1009_6c4e, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x1009_6c51, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x1009_6c54, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x1009_6c57, 3); calld_abs(memd_a32[ds, edx + 0x14]);    /* call dword [edx+0x14] */
            ii(0x1009_6c5a, 1); cwde();                                 /* cwde */
            ii(0x1009_6c5b, 1); pushd(eax);                             /* push eax */
            ii(0x1009_6c5c, 3); mov(ecx, memd_a32[ss, ebp - 0x4]);      /* mov ecx, [ebp-0x4] */
            ii(0x1009_6c5f, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x1009_6c62, 4); movsx(edx, memw_a32[ss, ebp - 0x18]);   /* movsx edx, word [ebp-0x18] */
            ii(0x1009_6c66, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_6c69, 5); calld(0x1009_2e25, -0x3e49);            /* call 0x10092e25 */
            ii(0x1009_6c6e, 3); mov(memb_a32[ss, ebp - 0x10], al);      /* mov [ebp-0x10], al */
        l_0x1009_6c71:
            ii(0x1009_6c71, 4); cmp(memb_a32[ss, ebp - 0x10], 0);       /* cmp byte [ebp-0x10], 0x0 */
            ii(0x1009_6c75, 2); if(jzd(0x1009_6c87, 0x10)) goto l_0x1009_6c87; /* jz 0x10096c87 */
            ii(0x1009_6c77, 4); mov(memb_a32[ss, ebp - 0x14], 0x1);     /* mov byte [ebp-0x14], 0x1 */
            ii(0x1009_6c7b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_6c7d, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1009_6c80, 5); calld(0x1007_5f6c, -0x2_0d19);          /* call 0x10075f6c */
            ii(0x1009_6c85, 2); jmpd(0x1009_6ca1, 0x1a); goto l_0x1009_6ca1; /* jmp 0x10096ca1 */
        l_0x1009_6c87:
            ii(0x1009_6c87, 4); mov(memb_a32[ss, ebp - 0x14], 0);       /* mov byte [ebp-0x14], 0x0 */
            ii(0x1009_6c8b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_6c8d, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1009_6c90, 5); calld(0x1007_5f6c, -0x2_0d29);          /* call 0x10075f6c */
            ii(0x1009_6c95, 2); jmpd(0x1009_6ca1, 0xa); goto l_0x1009_6ca1; /* jmp 0x10096ca1 */
        //  ii(0x1009_6c97, 10); Недостижимый код.
        l_0x1009_6ca1:
            ii(0x1009_6ca1, 3); mov(al, memb_a32[ss, ebp - 0x14]);      /* mov al, [ebp-0x14] */
            ii(0x1009_6ca4, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_6ca6, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_6ca7, 1); popd(edi);                              /* pop edi */
            ii(0x1009_6ca8, 1); popd(esi);                              /* pop esi */
            ii(0x1009_6ca9, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_6caa, 1); retd(); return;                         /* ret */
        }
    }
}
