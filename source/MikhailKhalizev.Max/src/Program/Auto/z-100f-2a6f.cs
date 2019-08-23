using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_2a6f-40bc5b3e")]
        public void Method_100f_2a6f()
        {
            ii(0x100f_2a6f, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100f_2a74, 5); calld(Definitions.sys_check_available_stack_size, 0x7_32d9); /* call 0x10165d52 */
            ii(0x100f_2a79, 1); pushd(ecx);                             /* push ecx */
            ii(0x100f_2a7a, 1); pushd(esi);                             /* push esi */
            ii(0x100f_2a7b, 1); pushd(edi);                             /* push edi */
            ii(0x100f_2a7c, 1); pushd(ebp);                             /* push ebp */
            ii(0x100f_2a7d, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_2a7f, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100f_2a85, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100f_2a88, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x100f_2a8b, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x100f_2a8e, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100f_2a91, 5); calld(0x1007_6338, -0x7_c75e);          /* call 0x10076338 */
            ii(0x100f_2a96, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_2a98, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100f_2a9b, 5); calld(0x1007_64b8, -0x7_c5e8);          /* call 0x100764b8 */
        l_0x100f_2aa0:
            ii(0x100f_2aa0, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_2aa2, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100f_2aa5, 5); calld(0x1013_ad71, 0x4_82c7);           /* call 0x1013ad71 */
            ii(0x100f_2aaa, 2); test(al, al);                           /* test al, al */
            ii(0x100f_2aac, 6); if(jzd(0x100f_2b82, 0xd0)) goto l_0x100f_2b82; /* jz 0x100f2b82 */
            ii(0x100f_2ab2, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100f_2ab5, 5); calld(0x1007_63a0, -0x7_c71a);          /* call 0x100763a0 */
            ii(0x100f_2aba, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_2abc, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x100f_2abf, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100f_2ac3, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100f_2ac5, 6); if(jnzd(0x100f_2b75, 0xaa)) goto l_0x100f_2b75; /* jnz 0x100f2b75 */
            ii(0x100f_2acb, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100f_2ace, 5); calld(0x1007_63a0, -0x7_c733);          /* call 0x100763a0 */
            ii(0x100f_2ad3, 4); cmp(memb_a32[ds, eax + 0x45], 0);       /* cmp byte [eax+0x45], 0x0 */
            ii(0x100f_2ad7, 2); if(jzd(0x100f_2ae7, 0xe)) goto l_0x100f_2ae7; /* jz 0x100f2ae7 */
            ii(0x100f_2ad9, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100f_2adc, 5); calld(0x1007_63a0, -0x7_c741);          /* call 0x100763a0 */
            ii(0x100f_2ae1, 4); cmp(memb_a32[ds, eax + 0x3d], 0x15);    /* cmp byte [eax+0x3d], 0x15 */
            ii(0x100f_2ae5, 2); if(jnzd(0x100f_2ae9, 0x2)) goto l_0x100f_2ae9; /* jnz 0x100f2ae9 */
        l_0x100f_2ae7:
            ii(0x100f_2ae7, 2); jmpd(0x100f_2af7, 0xe); goto l_0x100f_2af7; /* jmp 0x100f2af7 */
        l_0x100f_2ae9:
            ii(0x100f_2ae9, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100f_2aec, 5); calld(0x1007_63a0, -0x7_c751);          /* call 0x100763a0 */
            ii(0x100f_2af1, 4); cmp(memb_a32[ds, eax + 0x3d], 0x1f);    /* cmp byte [eax+0x3d], 0x1f */
            ii(0x100f_2af5, 2); if(jnzd(0x100f_2afc, 0x5)) goto l_0x100f_2afc; /* jnz 0x100f2afc */
        l_0x100f_2af7:
            ii(0x100f_2af7, 5); jmpd(0x100f_2b75, 0x79); goto l_0x100f_2b75; /* jmp 0x100f2b75 */
        l_0x100f_2afc:
            ii(0x100f_2afc, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100f_2aff, 5); calld(0x1007_63a0, -0x7_c764);          /* call 0x100763a0 */
            ii(0x100f_2b04, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_2b06, 3); mov(dl, memb_a32[ds, eax + 0x45]);      /* mov dl, [eax+0x45] */
            ii(0x100f_2b09, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100f_2b0c, 5); calld(0x1007_63a0, -0x7_c771);          /* call 0x100763a0 */
            ii(0x100f_2b11, 5); calld(0x1009_c9a0, -0x5_6176);          /* call 0x1009c9a0 */
            ii(0x100f_2b16, 1); cwde();                                 /* cwde */
            ii(0x100f_2b17, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100f_2b19, 2); if(jled(0x100f_2b37, 0x1c)) goto l_0x100f_2b37; /* jle 0x100f2b37 */
            ii(0x100f_2b1b, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100f_2b1e, 5); calld(0x1007_63a0, -0x7_c783);          /* call 0x100763a0 */
            ii(0x100f_2b23, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_2b25, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100f_2b28, 5); calld(0x1007_63a0, -0x7_c78d);          /* call 0x100763a0 */
            ii(0x100f_2b2d, 5); calld(0x1009_c9a0, -0x5_6192);          /* call 0x1009c9a0 */
            ii(0x100f_2b32, 3); sub(memb_a32[ds, edx + 0x45], al);      /* sub [edx+0x45], al */
            ii(0x100f_2b35, 2); jmpd(0x100f_2b75, 0x3e); goto l_0x100f_2b75; /* jmp 0x100f2b75 */
        l_0x100f_2b37:
            ii(0x100f_2b37, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100f_2b3a, 5); calld(0x1007_63a0, -0x7_c79f);          /* call 0x100763a0 */
            ii(0x100f_2b3f, 4); mov(memb_a32[ds, eax + 0x45], 0);       /* mov byte [eax+0x45], 0x0 */
            ii(0x100f_2b43, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100f_2b46, 5); calld(0x1007_63a0, -0x7_c7ab);          /* call 0x100763a0 */
            ii(0x100f_2b4b, 5); cmp(memw_a32[ds, eax + 0x8], 0x3e);     /* cmp word [eax+0x8], 0x3e */
            ii(0x100f_2b50, 2); if(jzd(0x100f_2b68, 0x16)) goto l_0x100f_2b68; /* jz 0x100f2b68 */
            ii(0x100f_2b52, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100f_2b55, 5); calld(0x1007_63a0, -0x7_c7ba);          /* call 0x100763a0 */
            ii(0x100f_2b5a, 5); calld(0x1015_0a9e, 0x5_df3f);           /* call 0x10150a9e */
            ii(0x100f_2b5f, 1); cwde();                                 /* cwde */
            ii(0x100f_2b60, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100f_2b62, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x100f_2b65, 3); inc(memw_a32[ds, eax]);                 /* inc word [eax] */
        l_0x100f_2b68:
            ii(0x100f_2b68, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100f_2b6b, 5); calld(0x1007_63a0, -0x7_c7d0);          /* call 0x100763a0 */
            ii(0x100f_2b70, 5); calld(0x1015_1740, 0x5_ebcb);           /* call 0x10151740 */
        l_0x100f_2b75:
            ii(0x100f_2b75, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100f_2b78, 5); calld(0x1007_6bf8, -0x7_bf85);          /* call 0x10076bf8 */
            ii(0x100f_2b7d, 5); jmpd(0x100f_2aa0, -0xe2); goto l_0x100f_2aa0; /* jmp 0x100f2aa0 */
        l_0x100f_2b82:
            ii(0x100f_2b82, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_2b84, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100f_2b87, 5); calld(0x1007_5f6c, -0x7_cc20);          /* call 0x10075f6c */
            ii(0x100f_2b8c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_2b8e, 1); popd(ebp);                              /* pop ebp */
            ii(0x100f_2b8f, 1); popd(edi);                              /* pop edi */
            ii(0x100f_2b90, 1); popd(esi);                              /* pop esi */
            ii(0x100f_2b91, 1); popd(ecx);                              /* pop ecx */
            ii(0x100f_2b92, 1); retd();                                 /* ret */
        }
    }
}
