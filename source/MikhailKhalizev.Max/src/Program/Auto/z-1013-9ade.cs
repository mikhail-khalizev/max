using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_9ade-fd7a0fa8")]
        public void Method_1013_9ade()
        {
            ii(0x1013_9ade, 5); pushd(0xc0);                            /* push 0xc0 */
            ii(0x1013_9ae3, 5); calld(Definitions.sys_check_available_stack_size, 0x2_c26a); /* call 0x10165d52 */
            ii(0x1013_9ae8, 1); pushd(esi);                             /* push esi */
            ii(0x1013_9ae9, 1); pushd(edi);                             /* push edi */
            ii(0x1013_9aea, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_9aeb, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_9aed, 6); sub(esp, 0xa0);                         /* sub esp, 0xa0 */
            ii(0x1013_9af3, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_9af6, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x1013_9af9, 3); mov(memd_a32[ss, ebp - 0x10], ebx);     /* mov [ebp-0x10], ebx */
            ii(0x1013_9afc, 3); mov(memb_a32[ss, ebp - 0x4], cl);       /* mov [ebp-0x4], cl */
            ii(0x1013_9aff, 4); or(memb_a32[ss, ebp - 0x14], 0x1);      /* or byte [ebp-0x14], 0x1 */
            ii(0x1013_9b03, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1013_9b06, 5); calld(0x1013_b8e1, 0x1dd6);             /* call 0x1013b8e1 */
            ii(0x1013_9b0b, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x1013_9b0e, 4); and(memb_a32[ss, ebp - 0x14], -0x2 /* 0xfe */); /* and byte [ebp-0x14], 0xfe */
            ii(0x1013_9b12, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1013_9b16, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1013_9b19, 6); pushd(memd_a32[ds, eax + 0x101b_d42c]); /* push dword [eax+0x101bd42c] */
            ii(0x1013_9b1f, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1013_9b23, 1); pushd(eax);                             /* push eax */
            ii(0x1013_9b24, 5); mov(eax, StringDefinitions.SaveIS5);    /* mov eax, 0x101ac8aa */
            ii(0x1013_9b29, 1); pushd(eax);                             /* push eax */
            ii(0x1013_9b2a, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x1013_9b2d, 1); pushd(eax);                             /* push eax */
            ii(0x1013_9b2e, 5); calld(Definitions.sys_sprintf, 0x2_c3ce); /* call 0x10165f01 */
            ii(0x1013_9b33, 3); add(esp, 0x10);                         /* add esp, 0x10 */
            ii(0x1013_9b36, 7); mov(memb_a32[ss, ebp - 0x9c], 0);       /* mov byte [ebp-0x9c], 0x0 */
            ii(0x1013_9b3d, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1013_9b41, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1013_9b43, 2); if(jzd(0x1013_9b4e, 0x9)) goto l_0x1013_9b4e; /* jz 0x10139b4e */
            ii(0x1013_9b45, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1013_9b49, 3); cmp(eax, 0x3);                          /* cmp eax, 0x3 */
            ii(0x1013_9b4c, 2); if(jnzd(0x1013_9b50, 0x2)) goto l_0x1013_9b50; /* jnz 0x10139b50 */
        l_0x1013_9b4e:
            ii(0x1013_9b4e, 2); jmpd(0x1013_9b59, 0x9); goto l_0x1013_9b59; /* jmp 0x10139b59 */
        l_0x1013_9b50:
            ii(0x1013_9b50, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1013_9b54, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x1013_9b57, 2); if(jnzd(0x1013_9b69, 0x10)) goto l_0x1013_9b69; /* jnz 0x10139b69 */
        l_0x1013_9b59:
            ii(0x1013_9b59, 5); mov(edx, 0x101c_3d70);                  /* mov edx, 0x101c3d70 */
            ii(0x1013_9b5e, 6); lea(eax, ebp - 0x9c);                   /* lea eax, [ebp-0x9c] */
            ii(0x1013_9b64, 5); calld(Definitions.sys_strcpy, 0x2_c366); /* call 0x10165ecf */
        l_0x1013_9b69:
            ii(0x1013_9b69, 3); lea(edx, ebp - 0x38);                   /* lea edx, [ebp-0x38] */
            ii(0x1013_9b6c, 6); lea(eax, ebp - 0x9c);                   /* lea eax, [ebp-0x9c] */
            ii(0x1013_9b72, 5); calld(Definitions.sys_strcat, 0x2_c3ba); /* call 0x10165f31 */
            ii(0x1013_9b77, 6); lea(edx, ebp - 0x9c);                   /* lea edx, [ebp-0x9c] */
            ii(0x1013_9b7d, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1013_9b80, 5); calld(0x1013_b9e0, 0x1e5b);             /* call 0x1013b9e0 */
            ii(0x1013_9b85, 2); test(al, al);                           /* test al, al */
            ii(0x1013_9b87, 2); if(jnzd(0x1013_9b9f, 0x16)) goto l_0x1013_9b9f; /* jnz 0x10139b9f */
            ii(0x1013_9b89, 10); mov(memd_a32[ss, ebp - 0xa0], 0);      /* mov dword [ebp-0xa0], 0x0 */
            ii(0x1013_9b93, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_9b95, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1013_9b98, 5); calld(0x1013_b997, 0x1dfa);             /* call 0x1013b997 */
            ii(0x1013_9b9d, 2); jmpd(0x1013_9c04, 0x65); goto l_0x1013_9c04; /* jmp 0x10139c04 */
        l_0x1013_9b9f:
            ii(0x1013_9b9f, 5); mov(ebx, 0xb0);                         /* mov ebx, 0xb0 */
            ii(0x1013_9ba4, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1013_9ba7, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1013_9baa, 5); calld(0x1013_ba86, 0x1ed7);             /* call 0x1013ba86 */
            ii(0x1013_9baf, 4); movsx(ebx, memw_a32[ss, ebp - 0xc]);    /* movsx ebx, word [ebp-0xc] */
            ii(0x1013_9bb3, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1013_9bb7, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_9bba, 5); calld(0x1013_8d74, -0xe4b);             /* call 0x10138d74 */
            ii(0x1013_9bbf, 4); cmp(memb_a32[ss, ebp - 0x4], 0);        /* cmp byte [ebp-0x4], 0x0 */
            ii(0x1013_9bc3, 2); if(jzd(0x1013_9bdc, 0x17)) goto l_0x1013_9bdc; /* jz 0x10139bdc */
            ii(0x1013_9bc5, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x1013_9bca, 5); mov(ebx, 0x44);                         /* mov ebx, 0x44 */
            ii(0x1013_9bcf, 3); lea(edx, ebp - 0x24);                   /* lea edx, [ebp-0x24] */
            ii(0x1013_9bd2, 5); mov(eax, 0x101c_39c8);                  /* mov eax, 0x101c39c8 */
            ii(0x1013_9bd7, 5); calld(0x1010_63f3, -0x3_37e9);          /* call 0x101063f3 */
        l_0x1013_9bdc:
            ii(0x1013_9bdc, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1013_9bdf, 5); calld(0x1013_ba3c, 0x1e58);             /* call 0x1013ba3c */
            ii(0x1013_9be4, 10); mov(memd_a32[ss, ebp - 0xa0], 0x1);    /* mov dword [ebp-0xa0], 0x1 */
            ii(0x1013_9bee, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_9bf0, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1013_9bf3, 5); calld(0x1013_b997, 0x1d9f);             /* call 0x1013b997 */
            ii(0x1013_9bf8, 2); jmpd(0x1013_9c04, 0xa); goto l_0x1013_9c04; /* jmp 0x10139c04 */
        //  ii(0x1013_9bfa, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x1013_9bfc, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
        //  ii(0x1013_9bff, 5); calld(0x1013_b997, 0x1d93);             /* call 0x1013b997 */
        l_0x1013_9c04:
            ii(0x1013_9c04, 6); mov(eax, memd_a32[ss, ebp - 0xa0]);     /* mov eax, [ebp-0xa0] */
            ii(0x1013_9c0a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_9c0c, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_9c0d, 1); popd(edi);                              /* pop edi */
            ii(0x1013_9c0e, 1); popd(esi);                              /* pop esi */
            ii(0x1013_9c0f, 1); retd(); return;                         /* ret */
        }
    }
}
