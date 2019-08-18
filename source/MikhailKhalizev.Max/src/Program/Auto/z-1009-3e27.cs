using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("4f6a5fb0-471b-44ed-9717-77992b6e7116")]
        public void Method_1009_3e27()
        {
            ii(0x1009_3e27, 5); pushd(0x34);                            /* push 0x34 */
            ii(0x1009_3e2c, 5); calld(Definitions.sys_check_available_stack_size, 0xd_1f21); /* call 0x10165d52 */
            ii(0x1009_3e31, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_3e32, 1); pushd(esi);                             /* push esi */
            ii(0x1009_3e33, 1); pushd(edi);                             /* push edi */
            ii(0x1009_3e34, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_3e35, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_3e37, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x1009_3e3d, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1009_3e40, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1009_3e43, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x1009_3e46, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_3e49, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1009_3e4c, 5); calld(0x1007_6338, -0x1_db19);          /* call 0x10076338 */
            ii(0x1009_3e51, 3); lea(ebx, ebp - 0x14);                   /* lea ebx, [ebp-0x14] */
            ii(0x1009_3e54, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_3e56, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1009_3e58, 5); calld(0x1007_64b8, -0x1_d9a5);          /* call 0x100764b8 */
            ii(0x1009_3e5d, 7); mov(memd_a32[ss, ebp - 0x18], 0);       /* mov dword [ebp-0x18], 0x0 */
            ii(0x1009_3e64, 2); jmpd(0x1009_3e6e, 0x8); goto l_0x1009_3e6e; /* jmp 0x10093e6e */
        l_0x1009_3e66:
            ii(0x1009_3e66, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1009_3e69, 5); calld(0x1007_6bf8, -0x1_d276);          /* call 0x10076bf8 */
        l_0x1009_3e6e:
            ii(0x1009_3e6e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_3e70, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1009_3e73, 5); calld(0x1013_ad71, 0xa_6ef9);           /* call 0x1013ad71 */
            ii(0x1009_3e78, 2); test(al, al);                           /* test al, al */
            ii(0x1009_3e7a, 2); if(jzd(0x1009_3e96, 0x1a)) goto l_0x1009_3e96; /* jz 0x10093e96 */
            ii(0x1009_3e7c, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1009_3e7f, 5); calld(0x1007_63a0, -0x1_dae4);          /* call 0x100763a0 */
            ii(0x1009_3e84, 4); mov(ax, memw_a32[ds, eax + 0x8]);       /* mov ax, [eax+0x8] */
            ii(0x1009_3e88, 4); cmp(ax, memw_a32[ss, ebp - 0x8]);       /* cmp ax, [ebp-0x8] */
            ii(0x1009_3e8c, 2); if(jnzd(0x1009_3e94, 0x6)) goto l_0x1009_3e94; /* jnz 0x10093e94 */
            ii(0x1009_3e8e, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1009_3e91, 3); inc(memd_a32[ss, ebp - 0x18]);          /* inc dword [ebp-0x18] */
        l_0x1009_3e94:
            ii(0x1009_3e94, 2); jmpd(0x1009_3e66, -0x30); goto l_0x1009_3e66; /* jmp 0x10093e66 */
        l_0x1009_3e96:
            ii(0x1009_3e96, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_3e99, 3); add(eax, 0x21);                         /* add eax, 0x21 */
            ii(0x1009_3e9c, 5); calld(0x1009_c6c8, 0x8827);             /* call 0x1009c6c8 */
            ii(0x1009_3ea1, 3); lea(ebx, ebp - 0x1c);                   /* lea ebx, [ebp-0x1c] */
            ii(0x1009_3ea4, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_3ea6, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1009_3ea8, 5); calld(0x1009_c5dc, 0x872f);             /* call 0x1009c5dc */
            ii(0x1009_3ead, 2); jmpd(0x1009_3eb7, 0x8); goto l_0x1009_3eb7; /* jmp 0x10093eb7 */
        l_0x1009_3eaf:
            ii(0x1009_3eaf, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1009_3eb2, 5); calld(0x1007_6bf8, -0x1_d2bf);          /* call 0x10076bf8 */
        l_0x1009_3eb7:
            ii(0x1009_3eb7, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_3eb9, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1009_3ebc, 5); calld(0x1013_ad71, 0xa_6eb0);           /* call 0x1013ad71 */
            ii(0x1009_3ec1, 2); test(al, al);                           /* test al, al */
            ii(0x1009_3ec3, 2); if(jzd(0x1009_3f19, 0x54)) goto l_0x1009_3f19; /* jz 0x10093f19 */
            ii(0x1009_3ec5, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1009_3ec8, 5); calld(0x1009_c4f8, 0x862b);             /* call 0x1009c4f8 */
            ii(0x1009_3ecd, 5); calld(0x1009_c4c4, 0x85f2);             /* call 0x1009c4c4 */
            ii(0x1009_3ed2, 4); cmp(ax, memw_a32[ss, ebp - 0x8]);       /* cmp ax, [ebp-0x8] */
            ii(0x1009_3ed6, 2); if(jnzd(0x1009_3f17, 0x3f)) goto l_0x1009_3f17; /* jnz 0x10093f17 */
            ii(0x1009_3ed8, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1009_3edb, 5); calld(0x1009_c4f8, 0x8618);             /* call 0x1009c4f8 */
            ii(0x1009_3ee0, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1009_3ee3, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1009_3ee6, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x1009_3ee9, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1009_3eec, 3); calld_abs(memd_a32[ds, edx + 0x70]);    /* call dword [edx+0x70] */
            ii(0x1009_3eef, 2); test(al, al);                           /* test al, al */
            ii(0x1009_3ef1, 2); if(jzd(0x1009_3efb, 0x8)) goto l_0x1009_3efb; /* jz 0x10093efb */
            ii(0x1009_3ef3, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1009_3ef6, 3); inc(memd_a32[ss, ebp - 0x18]);          /* inc dword [ebp-0x18] */
            ii(0x1009_3ef9, 2); jmpd(0x1009_3f17, 0x1c); goto l_0x1009_3f17; /* jmp 0x10093f17 */
        l_0x1009_3efb:
            ii(0x1009_3efb, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x1009_3eff, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1009_3f02, 5); calld(0x1009_c4f8, 0x85f1);             /* call 0x1009c4f8 */
            ii(0x1009_3f07, 5); calld(0x100a_2bc4, 0xecb8);             /* call 0x100a2bc4 */
            ii(0x1009_3f0c, 1); cwde();                                 /* cwde */
            ii(0x1009_3f0d, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1009_3f0f, 2); if(jgd(0x1009_3f17, 0x6)) goto l_0x1009_3f17; /* jg 0x10093f17 */
            ii(0x1009_3f11, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1009_3f14, 3); inc(memd_a32[ss, ebp - 0x18]);          /* inc dword [ebp-0x18] */
        l_0x1009_3f17:
            ii(0x1009_3f17, 2); jmpd(0x1009_3eaf, -0x6a); goto l_0x1009_3eaf; /* jmp 0x10093eaf */
        l_0x1009_3f19:
            ii(0x1009_3f19, 3); mov(al, memb_a32[ss, ebp - 0x18]);      /* mov al, [ebp-0x18] */
            ii(0x1009_3f1c, 3); mov(memb_a32[ss, ebp - 0x10], al);      /* mov [ebp-0x10], al */
            ii(0x1009_3f1f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_3f21, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1009_3f24, 5); calld(0x1009_ba6c, 0x7b43);             /* call 0x1009ba6c */
            ii(0x1009_3f29, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_3f2b, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1009_3f2e, 5); calld(0x1007_5f6c, -0x1_dfc7);          /* call 0x10075f6c */
            ii(0x1009_3f33, 2); jmpd(0x1009_3f49, 0x14); goto l_0x1009_3f49; /* jmp 0x10093f49 */
        //    ii(0x1009_3f35, 2); xor(edx, edx);                          /* xor edx, edx */
        //    ii(0x1009_3f37, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
        //    ii(0x1009_3f3a, 5); calld(0x1009_ba6c, 0x7b2d);             /* call 0x1009ba6c */
        //    ii(0x1009_3f3f, 2); xor(edx, edx);                          /* xor edx, edx */
        //    ii(0x1009_3f41, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
        //    ii(0x1009_3f44, 5); calld(0x1007_5f6c, -0x1_dfdd);          /* call 0x10075f6c */
        l_0x1009_3f49:
            ii(0x1009_3f49, 3); mov(al, memb_a32[ss, ebp - 0x10]);      /* mov al, [ebp-0x10] */
            ii(0x1009_3f4c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_3f4e, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_3f4f, 1); popd(edi);                              /* pop edi */
            ii(0x1009_3f50, 1); popd(esi);                              /* pop esi */
            ii(0x1009_3f51, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_3f52, 1); retd(); return;                         /* ret */
        }
    }
}
