using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("e964bb22-5a1d-4605-86b5-8aa96da6f89c")]
        public void Method_1013_de44()
        {
            ii(0x1013_de44, 5); pushd(0x3c);                            /* push 0x3c */
            ii(0x1013_de49, 5); calld(Definitions.sys_check_available_stack_size, 0x2_7f04); /* call 0x10165d52 */
            ii(0x1013_de4e, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_de4f, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_de50, 1); pushd(esi);                             /* push esi */
            ii(0x1013_de51, 1); pushd(edi);                             /* push edi */
            ii(0x1013_de52, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_de53, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_de55, 6); sub(esp, 0x24);                         /* sub esp, 0x24 */
            ii(0x1013_de5b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_de5e, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1013_de61, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_de64, 7); cmp(memd_a32[ds, eax + 0xda5], 0);      /* cmp dword [eax+0xda5], 0x0 */
            ii(0x1013_de6b, 2); if(jzd(0x1013_de7e, 0x11)) goto l_0x1013_de7e; /* jz 0x1013de7e */
            ii(0x1013_de6d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_de70, 6); mov(eax, memd_a32[ds, eax + 0xda5]);    /* mov eax, [eax+0xda5] */
            ii(0x1013_de76, 6); cmp(memd_a32[ds, eax], 0xffff);         /* cmp dword [eax], 0xffff */
            ii(0x1013_de7c, 2); if(jnzd(0x1013_de83, 0x5)) goto l_0x1013_de83; /* jnz 0x1013de83 */
        l_0x1013_de7e:
            ii(0x1013_de7e, 5); jmpd(0x1013_dfc9, 0x146); goto l_0x1013_dfc9; /* jmp 0x1013dfc9 */
        l_0x1013_de83:
            ii(0x1013_de83, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_de86, 6); mov(edx, memd_a32[ds, eax + 0xda5]);    /* mov edx, [eax+0xda5] */
            ii(0x1013_de8c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_de8f, 4); mov(ax, memw_a32[ds, eax + 0x1a]);      /* mov ax, [eax+0x1a] */
            ii(0x1013_de93, 4); mov(memw_a32[ds, edx + 0x7], ax);       /* mov [edx+0x7], ax */
            ii(0x1013_de97, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_de9a, 6); mov(edx, memd_a32[ds, eax + 0xda5]);    /* mov edx, [eax+0xda5] */
            ii(0x1013_dea0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_dea3, 4); mov(ax, memw_a32[ds, eax + 0x1c]);      /* mov ax, [eax+0x1c] */
            ii(0x1013_dea7, 4); mov(memw_a32[ds, edx + 0x9], ax);       /* mov [edx+0x9], ax */
            ii(0x1013_deab, 6); mov(edx, memd_a32[ds, 0x101c_38dc]);    /* mov edx, [0x101c38dc] */
            ii(0x1013_deb1, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1013_deb4, 5); mov(eax, memd_a32[ds, 0x101c_38d8]);    /* mov eax, [0x101c38d8] */
            ii(0x1013_deb9, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1013_debc, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1013_debe, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x1013_dec0, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1013_dec3, 5); mov(eax, memd_a32[ds, 0x101c_38de]);    /* mov eax, [0x101c38de] */
            ii(0x1013_dec8, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1013_decb, 6); mov(edx, memd_a32[ds, 0x101c_38da]);    /* mov edx, [0x101c38da] */
            ii(0x1013_ded1, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1013_ded4, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1013_ded6, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x1013_ded8, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1013_dedb, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_dede, 6); mov(eax, memd_a32[ds, eax + 0xda5]);    /* mov eax, [eax+0xda5] */
            ii(0x1013_dee4, 4); mov(ax, memw_a32[ds, eax + 0x7]);       /* mov ax, [eax+0x7] */
            ii(0x1013_dee8, 3); sub(eax, memd_a32[ss, ebp - 0x1c]);     /* sub eax, [ebp-0x1c] */
            ii(0x1013_deeb, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1013_deee, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1013_def2, 5); calld(/* sys */ 0x1016_5df8, 0x2_7f01); /* call 0x10165df8 */
            ii(0x1013_def7, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1013_defa, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_defd, 6); mov(eax, memd_a32[ds, eax + 0xda5]);    /* mov eax, [eax+0xda5] */
            ii(0x1013_df03, 3); mov(edx, memd_a32[ds, eax + 0x7]);      /* mov edx, [eax+0x7] */
            ii(0x1013_df06, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1013_df09, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1013_df0d, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1013_df0f, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1013_df11, 5); calld(/* sys */ 0x1016_5df8, 0x2_7ee2); /* call 0x10165df8 */
            ii(0x1013_df16, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1013_df19, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1013_df1d, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1013_df1f, 2); if(jged(0x1013_df27, 0x6)) goto l_0x1013_df27; /* jge 0x1013df27 */
            ii(0x1013_df21, 4); mov(memb_a32[ss, ebp - 0x24], 0x1);     /* mov byte [ebp-0x24], 0x1 */
            ii(0x1013_df25, 2); jmpd(0x1013_df2b, 0x4); goto l_0x1013_df2b; /* jmp 0x1013df2b */
        l_0x1013_df27:
            ii(0x1013_df27, 4); mov(memb_a32[ss, ebp - 0x24], 0);       /* mov byte [ebp-0x24], 0x0 */
        l_0x1013_df2b:
            ii(0x1013_df2b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_df2d, 3); mov(dl, memb_a32[ss, ebp - 0x24]);      /* mov dl, [ebp-0x24] */
            ii(0x1013_df30, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x1013_df34, 5); calld(0x1013_d45e, -0xadb);             /* call 0x1013d45e */
            ii(0x1013_df39, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1013_df3b, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1013_df3e, 6); mov(eax, memd_a32[ds, edx + 0xda5]);    /* mov eax, [edx+0xda5] */
            ii(0x1013_df44, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1013_df46, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1013_df49, 3); mov(ecx, memd_a32[ds, edx + 0x1c]);     /* mov ecx, [edx+0x1c] */
            ii(0x1013_df4c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1013_df4e, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1013_df50, 5); calld(/* sys */ 0x1018_0a4a, 0x4_2af5); /* call 0x10180a4a */
            ii(0x1013_df55, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x1013_df58, 6); mov(ebx, memd_a32[ds, ebx + 0xda5]);    /* mov ebx, [ebx+0xda5] */
            ii(0x1013_df5e, 4); movsx(edx, memw_a32[ss, ebp - 0x14]);   /* movsx edx, word [ebp-0x14] */
            ii(0x1013_df62, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x1013_df66, 5); calld(0x1007_6e7c, -0xc_70ef);          /* call 0x10076e7c */
            ii(0x1013_df6b, 7); imul(eax, memd_a32[ds, ebx + 0x83]);    /* imul eax, [ebx+0x83] */
            ii(0x1013_df72, 5); mov(ebx, 0x70);                         /* mov ebx, 0x70 */
            ii(0x1013_df77, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_df79, 2); div(ebx);                               /* div ebx */
            ii(0x1013_df7b, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1013_df7e, 6); mov(edx, memd_a32[ds, edx + 0xda5]);    /* mov edx, [edx+0xda5] */
            ii(0x1013_df84, 6); mov(edx, memd_a32[ds, edx + 0x83]);     /* mov edx, [edx+0x83] */
            ii(0x1013_df8a, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1013_df8c, 3); mov(memd_a32[ss, ebp - 0x20], edx);     /* mov [ebp-0x20], edx */
            ii(0x1013_df8f, 5); mov(eax, 0x37);                         /* mov eax, 0x37 */
            ii(0x1013_df94, 5); calld(0x1007_5fdc, -0xc_7fbd);          /* call 0x10075fdc */
            ii(0x1013_df99, 3); mov(edx, memd_a32[ss, ebp - 0x20]);     /* mov edx, [ebp-0x20] */
            ii(0x1013_df9c, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1013_df9f, 5); mov(ebx, 0x64);                         /* mov ebx, 0x64 */
            ii(0x1013_dfa4, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1013_dfa6, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1013_dfa9, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1013_dfab, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1013_dfae, 3); mov(ebx, memd_a32[ss, ebp - 0x20]);     /* mov ebx, [ebp-0x20] */
            ii(0x1013_dfb1, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1013_dfb4, 6); mov(eax, memd_a32[ds, edx + 0xda5]);    /* mov eax, [edx+0xda5] */
            ii(0x1013_dfba, 2); mov(ecx, memd_a32[ds, eax]);            /* mov ecx, [eax] */
            ii(0x1013_dfbc, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1013_dfbf, 3); mov(eax, memd_a32[ds, edx + 0x1c]);     /* mov eax, [edx+0x1c] */
            ii(0x1013_dfc2, 2); mov(edx, ecx);                          /* mov edx, ecx */
            ii(0x1013_dfc4, 5); calld(/* sys */ 0x1018_07a7, 0x4_27de); /* call 0x101807a7 */
        l_0x1013_dfc9:
            ii(0x1013_dfc9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_dfcb, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_dfcc, 1); popd(edi);                              /* pop edi */
            ii(0x1013_dfcd, 1); popd(esi);                              /* pop esi */
            ii(0x1013_dfce, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_dfcf, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_dfd0, 1); retd(); return;                         /* ret */
        }
    }
}
