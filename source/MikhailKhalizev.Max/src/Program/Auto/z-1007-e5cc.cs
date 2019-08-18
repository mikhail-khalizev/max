using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_e5cc-ab40ac6e")]
        public void Method_1007_e5cc()
        {
            ii(0x1007_e5cc, 5); pushd(0x38);                            /* push 0x38 */
            ii(0x1007_e5d1, 5); calld(Definitions.sys_check_available_stack_size, 0xe_777c); /* call 0x10165d52 */
            ii(0x1007_e5d6, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_e5d7, 1); pushd(esi);                             /* push esi */
            ii(0x1007_e5d8, 1); pushd(edi);                             /* push edi */
            ii(0x1007_e5d9, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_e5da, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_e5dc, 6); sub(esp, 0x24);                         /* sub esp, 0x24 */
            ii(0x1007_e5e2, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1007_e5e5, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1007_e5e8, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x1007_e5eb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_e5ee, 5); calld(0x1007_6338, -0x82bb);            /* call 0x10076338 */
            ii(0x1007_e5f3, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_e5f5, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_e5f8, 5); calld(0x1007_64b8, -0x8145);            /* call 0x100764b8 */
            ii(0x1007_e5fd, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1007_e600, 5); calld(Definitions.my_ctor_0x101b_4184, -0x7b15); /* call 0x10076af0 */
            ii(0x1007_e605, 2); jmpd(0x1007_e60f, 0x8); goto l_0x1007_e60f; /* jmp 0x1007e60f */
        l_0x1007_e607:
            ii(0x1007_e607, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_e60a, 5); calld(0x1007_6bf8, -0x7a17);            /* call 0x10076bf8 */
        l_0x1007_e60f:
            ii(0x1007_e60f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_e611, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_e614, 5); calld(0x1013_ad71, 0xb_c758);           /* call 0x1013ad71 */
            ii(0x1007_e619, 2); test(al, al);                           /* test al, al */
            ii(0x1007_e61b, 6); if(jzd(0x1007_e6ab, 0x8a)) goto l_0x1007_e6ab; /* jz 0x1007e6ab */
            ii(0x1007_e621, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_e624, 5); calld(0x1007_63a0, -0x8289);            /* call 0x100763a0 */
            ii(0x1007_e629, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_e62b, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x1007_e62e, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_e631, 3); mov(eax, memd_a32[ds, eax + 0x7]);      /* mov eax, [eax+0x7] */
            ii(0x1007_e634, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1007_e637, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1007_e639, 2); if(jnzd(0x1007_e649, 0xe)) goto l_0x1007_e649; /* jnz 0x1007e649 */
            ii(0x1007_e63b, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_e63e, 5); calld(0x1007_63a0, -0x82a3);            /* call 0x100763a0 */
            ii(0x1007_e643, 4); cmp(memb_a32[ds, eax + 0x3d], 0x10);    /* cmp byte [eax+0x3d], 0x10 */
            ii(0x1007_e647, 2); if(jnzd(0x1007_e64b, 0x2)) goto l_0x1007_e64b; /* jnz 0x1007e64b */
        l_0x1007_e649:
            ii(0x1007_e649, 2); jmpd(0x1007_e6a6, 0x5b); goto l_0x1007_e6a6; /* jmp 0x1007e6a6 */
        l_0x1007_e64b:
            ii(0x1007_e64b, 3); lea(edx, ebp - 0x24);                   /* lea edx, [ebp-0x24] */
            ii(0x1007_e64e, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_e651, 5); calld(0x1007_63a0, -0x82b6);            /* call 0x100763a0 */
            ii(0x1007_e656, 5); calld(0x1015_2532, 0xd_3ed7);           /* call 0x10152532 */
            ii(0x1007_e65b, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1007_e65e, 4); mov(memw_a32[ss, ebp - 0x10], ax);      /* mov [ebp-0x10], ax */
            ii(0x1007_e662, 2); jmpd(0x1007_e66b, 0x7); goto l_0x1007_e66b; /* jmp 0x1007e66b */
        l_0x1007_e664:
            ii(0x1007_e664, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1007_e667, 4); inc(memw_a32[ss, ebp - 0x10]);          /* inc word [ebp-0x10] */
        l_0x1007_e66b:
            ii(0x1007_e66b, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1007_e66f, 3); cmp(eax, memd_a32[ss, ebp - 0x1c]);     /* cmp eax, [ebp-0x1c] */
            ii(0x1007_e672, 2); if(jged(0x1007_e6a6, 0x32)) goto l_0x1007_e6a6; /* jge 0x1007e6a6 */
            ii(0x1007_e674, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1007_e677, 4); mov(memw_a32[ss, ebp - 0xe], ax);       /* mov [ebp-0xe], ax */
            ii(0x1007_e67b, 2); jmpd(0x1007_e684, 0x7); goto l_0x1007_e684; /* jmp 0x1007e684 */
        l_0x1007_e67d:
            ii(0x1007_e67d, 3); mov(eax, memd_a32[ss, ebp - 0xe]);      /* mov eax, [ebp-0xe] */
            ii(0x1007_e680, 4); inc(memw_a32[ss, ebp - 0xe]);           /* inc word [ebp-0xe] */
        l_0x1007_e684:
            ii(0x1007_e684, 4); movsx(eax, memw_a32[ss, ebp - 0xe]);    /* movsx eax, word [ebp-0xe] */
            ii(0x1007_e688, 3); cmp(eax, memd_a32[ss, ebp - 0x18]);     /* cmp eax, [ebp-0x18] */
            ii(0x1007_e68b, 2); if(jged(0x1007_e6a4, 0x17)) goto l_0x1007_e6a4; /* jge 0x1007e6a4 */
            ii(0x1007_e68d, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1007_e691, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1007_e694, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x1007_e697, 4); movsx(edx, memw_a32[ss, ebp - 0xe]);    /* movsx edx, word [ebp-0xe] */
            ii(0x1007_e69b, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1007_e69d, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1007_e69f, 3); and(memb_a32[ds, eax], -0x80 /* 0x80 */); /* and byte [eax], 0x80 */
            ii(0x1007_e6a2, 2); jmpd(0x1007_e67d, -0x27); goto l_0x1007_e67d; /* jmp 0x1007e67d */
        l_0x1007_e6a4:
            ii(0x1007_e6a4, 2); jmpd(0x1007_e664, -0x42); goto l_0x1007_e664; /* jmp 0x1007e664 */
        l_0x1007_e6a6:
            ii(0x1007_e6a6, 5); jmpd(0x1007_e607, -0xa4); goto l_0x1007_e607; /* jmp 0x1007e607 */
        l_0x1007_e6ab:
            ii(0x1007_e6ab, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_e6ad, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_e6b0, 5); calld(0x1007_5f6c, -0x8749);            /* call 0x10075f6c */
            ii(0x1007_e6b5, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_e6b7, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_e6b8, 1); popd(edi);                              /* pop edi */
            ii(0x1007_e6b9, 1); popd(esi);                              /* pop esi */
            ii(0x1007_e6ba, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_e6bb, 1); retd(); return;                         /* ret */
        }
    }
}
