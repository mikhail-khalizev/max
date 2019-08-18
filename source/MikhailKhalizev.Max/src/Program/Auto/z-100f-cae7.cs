using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a37d9db2-8b97-4fb4-af23-cee35b070707")]
        public void Method_100f_cae7()
        {
            ii(0x100f_cae7, 5); pushd(0x40);                            /* push 0x40 */
            ii(0x100f_caec, 5); calld(Definitions.sys_check_available_stack_size, 0x6_9261); /* call 0x10165d52 */
            ii(0x100f_caf1, 1); pushd(ebx);                             /* push ebx */
            ii(0x100f_caf2, 1); pushd(ecx);                             /* push ecx */
            ii(0x100f_caf3, 1); pushd(edx);                             /* push edx */
            ii(0x100f_caf4, 1); pushd(esi);                             /* push esi */
            ii(0x100f_caf5, 1); pushd(edi);                             /* push edi */
            ii(0x100f_caf6, 1); pushd(ebp);                             /* push ebp */
            ii(0x100f_caf7, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_caf9, 6); sub(esp, 0x24);                         /* sub esp, 0x24 */
            ii(0x100f_caff, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100f_cb02, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100f_cb05, 5); calld(Definitions.my_ctor_0x101b_4184, -0x8_601a); /* call 0x10076af0 */
            ii(0x100f_cb0a, 5); mov(eax, 0x1d);                         /* mov eax, 0x1d */
            ii(0x100f_cb0f, 5); calld(0x1007_5fdc, -0x8_6b38);          /* call 0x10075fdc */
            ii(0x100f_cb14, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100f_cb17, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100f_cb1a, 5); calld(Definitions.my_ctor_0x101b_4184, -0x8_602f); /* call 0x10076af0 */
            ii(0x100f_cb1f, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
            ii(0x100f_cb23, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_cb26, 3); mov(edx, memd_a32[ds, eax + 0xc]);      /* mov edx, [eax+0xc] */
            ii(0x100f_cb29, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100f_cb2c, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x100f_cb2f, 5); mov(ebx, 0x5);                          /* mov ebx, 0x5 */
            ii(0x100f_cb34, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100f_cb36, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100f_cb39, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x100f_cb3b, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_cb3d, 5); calld(/* sys */ 0x1016_5e9b, 0x6_9359); /* call 0x10165e9b */
            ii(0x100f_cb42, 1); inc(edx);                               /* inc edx */
            ii(0x100f_cb43, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x100f_cb46, 3); shr(eax, 0xf);                          /* shr eax, 0xf */
            ii(0x100f_cb49, 4); mov(memw_a32[ss, ebp - 0x1c], ax);      /* mov [ebp-0x1c], ax */
            ii(0x100f_cb4d, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100f_cb50, 3); mov(edx, memd_a32[ds, edx + 0xc]);      /* mov edx, [edx+0xc] */
            ii(0x100f_cb53, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100f_cb56, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100f_cb58, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100f_cb5b, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100f_cb5d, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x100f_cb5f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_cb61, 5); calld(/* sys */ 0x1016_5e9b, 0x6_9335); /* call 0x10165e9b */
            ii(0x100f_cb66, 1); inc(edx);                               /* inc edx */
            ii(0x100f_cb67, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x100f_cb6a, 3); shr(eax, 0xf);                          /* shr eax, 0xf */
            ii(0x100f_cb6d, 4); mov(memw_a32[ss, ebp - 0x1a], ax);      /* mov [ebp-0x1a], ax */
            ii(0x100f_cb71, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100f_cb74, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100f_cb77, 2); jmpd(0x100f_cb9a, 0x21); goto l_0x100f_cb9a; /* jmp 0x100fcb9a */
        l_0x100f_cb79:
            ii(0x100f_cb79, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100f_cb7c, 3); mov(edx, memd_a32[ds, edx + 0xc]);      /* mov edx, [edx+0xc] */
            ii(0x100f_cb7f, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100f_cb82, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x100f_cb85, 5); mov(ebx, 0x5);                          /* mov ebx, 0x5 */
            ii(0x100f_cb8a, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100f_cb8c, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100f_cb8f, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x100f_cb91, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x100f_cb95, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100f_cb97, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
        l_0x100f_cb9a:
            ii(0x100f_cb9a, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100f_cb9d, 7); cmp(ax, memw_a32[ds, 0x101c_8172]);     /* cmp ax, [0x101c8172] */
            ii(0x100f_cba4, 6); if(jged(0x100f_cca8, 0xfe)) goto l_0x100f_cca8; /* jge 0x100fcca8 */
            ii(0x100f_cbaa, 3); mov(eax, memd_a32[ss, ebp - 0x1a]);     /* mov eax, [ebp-0x1a] */
            ii(0x100f_cbad, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100f_cbb0, 4); cmp(memb_a32[ss, ebp - 0x8], 0);        /* cmp byte [ebp-0x8], 0x0 */
            ii(0x100f_cbb4, 2); if(jzd(0x100f_cbd1, 0x1b)) goto l_0x100f_cbd1; /* jz 0x100fcbd1 */
            ii(0x100f_cbb6, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100f_cbb9, 3); mov(edx, memd_a32[ds, edx + 0xc]);      /* mov edx, [edx+0xc] */
            ii(0x100f_cbbc, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100f_cbbf, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100f_cbc1, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100f_cbc4, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100f_cbc6, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x100f_cbc8, 4); movsx(edx, memw_a32[ss, ebp - 0x14]);   /* movsx edx, word [ebp-0x14] */
            ii(0x100f_cbcc, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100f_cbce, 3); mov(memd_a32[ss, ebp - 0x14], edx);     /* mov [ebp-0x14], edx */
        l_0x100f_cbd1:
            ii(0x100f_cbd1, 2); jmpd(0x100f_cbdd, 0xa); goto l_0x100f_cbdd; /* jmp 0x100fcbdd */
        l_0x100f_cbd3:
            ii(0x100f_cbd3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_cbd6, 4); mov(ax, memw_a32[ds, eax + 0xe]);       /* mov ax, [eax+0xe] */
            ii(0x100f_cbda, 3); add(memd_a32[ss, ebp - 0x14], eax);     /* add [ebp-0x14], eax */
        l_0x100f_cbdd:
            ii(0x100f_cbdd, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100f_cbe0, 7); cmp(ax, memw_a32[ds, 0x101c_8174]);     /* cmp ax, [0x101c8174] */
            ii(0x100f_cbe7, 6); if(jged(0x100f_cc8d, 0xa0)) goto l_0x100f_cc8d; /* jge 0x100fcc8d */
            ii(0x100f_cbed, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_cbf0, 3); mov(edx, memd_a32[ds, eax + 0xe]);      /* mov edx, [eax+0xe] */
            ii(0x100f_cbf3, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100f_cbf6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_cbf9, 3); mov(eax, memd_a32[ds, eax + 0xe]);      /* mov eax, [eax+0xe] */
            ii(0x100f_cbfc, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_cbff, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100f_cc01, 5); calld(/* sys */ 0x1016_5e9b, 0x6_9295); /* call 0x10165e9b */
            ii(0x100f_cc06, 1); inc(edx);                               /* inc edx */
            ii(0x100f_cc07, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x100f_cc0a, 3); shr(eax, 0xf);                          /* shr eax, 0xf */
            ii(0x100f_cc0d, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_cc0f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_cc12, 3); mov(eax, memd_a32[ds, eax + 0xe]);      /* mov eax, [eax+0xe] */
            ii(0x100f_cc15, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_cc18, 2); neg(eax);                               /* neg eax */
            ii(0x100f_cc1a, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100f_cc1c, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x100f_cc20, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100f_cc22, 4); mov(memw_a32[ss, ebp - 0x18], ax);      /* mov [ebp-0x18], ax */
            ii(0x100f_cc26, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100f_cc29, 3); mov(edx, memd_a32[ds, edx + 0xe]);      /* mov edx, [edx+0xe] */
            ii(0x100f_cc2c, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100f_cc2f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_cc32, 3); mov(eax, memd_a32[ds, eax + 0xe]);      /* mov eax, [eax+0xe] */
            ii(0x100f_cc35, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_cc38, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100f_cc3a, 5); calld(/* sys */ 0x1016_5e9b, 0x6_925c); /* call 0x10165e9b */
            ii(0x100f_cc3f, 1); inc(edx);                               /* inc edx */
            ii(0x100f_cc40, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x100f_cc43, 3); shr(eax, 0xf);                          /* shr eax, 0xf */
            ii(0x100f_cc46, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_cc48, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_cc4b, 3); mov(eax, memd_a32[ds, eax + 0xe]);      /* mov eax, [eax+0xe] */
            ii(0x100f_cc4e, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_cc51, 2); neg(eax);                               /* neg eax */
            ii(0x100f_cc53, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100f_cc55, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100f_cc59, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100f_cc5b, 4); mov(memw_a32[ss, ebp - 0x16], ax);      /* mov [ebp-0x16], ax */
            ii(0x100f_cc5f, 4); movsx(ecx, memw_a32[ss, ebp - 0x10]);   /* movsx ecx, word [ebp-0x10] */
            ii(0x100f_cc63, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_cc66, 3); add(eax, 0xa);                          /* add eax, 0xa */
            ii(0x100f_cc69, 5); calld(0x100f_c32c, -0x942);             /* call 0x100fc32c */
            ii(0x100f_cc6e, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x100f_cc71, 3); lea(edx, ebp - 0x18);                   /* lea edx, [ebp-0x18] */
            ii(0x100f_cc74, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100f_cc77, 5); calld(0x1007_5e64, -0x8_6e18);          /* call 0x10075e64 */
            ii(0x100f_cc7c, 3); mov(esi, memd_a32[ss, ebp - 0x4]);      /* mov esi, [ebp-0x4] */
            ii(0x100f_cc7f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_cc81, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x100f_cc83, 5); calld(0x100f_c6f6, -0x592);             /* call 0x100fc6f6 */
            ii(0x100f_cc88, 5); jmpd(0x100f_cbd3, -0xba); goto l_0x100f_cbd3; /* jmp 0x100fcbd3 */
        l_0x100f_cc8d:
            ii(0x100f_cc8d, 4); cmp(memb_a32[ss, ebp - 0x8], 0);        /* cmp byte [ebp-0x8], 0x0 */
            ii(0x100f_cc91, 2); if(jnzd(0x100f_cc99, 0x6)) goto l_0x100f_cc99; /* jnz 0x100fcc99 */
            ii(0x100f_cc93, 4); mov(memb_a32[ss, ebp - 0x24], 0x1);     /* mov byte [ebp-0x24], 0x1 */
            ii(0x100f_cc97, 2); jmpd(0x100f_cc9d, 0x4); goto l_0x100f_cc9d; /* jmp 0x100fcc9d */
        l_0x100f_cc99:
            ii(0x100f_cc99, 4); mov(memb_a32[ss, ebp - 0x24], 0);       /* mov byte [ebp-0x24], 0x0 */
        l_0x100f_cc9d:
            ii(0x100f_cc9d, 3); mov(al, memb_a32[ss, ebp - 0x24]);      /* mov al, [ebp-0x24] */
            ii(0x100f_cca0, 3); mov(memb_a32[ss, ebp - 0x8], al);       /* mov [ebp-0x8], al */
            ii(0x100f_cca3, 5); jmpd(0x100f_cb79, -0x12f); goto l_0x100f_cb79; /* jmp 0x100fcb79 */
        l_0x100f_cca8:
            ii(0x100f_cca8, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_ccaa, 1); popd(ebp);                              /* pop ebp */
            ii(0x100f_ccab, 1); popd(edi);                              /* pop edi */
            ii(0x100f_ccac, 1); popd(esi);                              /* pop esi */
            ii(0x100f_ccad, 1); popd(edx);                              /* pop edx */
            ii(0x100f_ccae, 1); popd(ecx);                              /* pop ecx */
            ii(0x100f_ccaf, 1); popd(ebx);                              /* pop ebx */
            ii(0x100f_ccb0, 1); retd(); return;                         /* ret */
        }
    }
}
