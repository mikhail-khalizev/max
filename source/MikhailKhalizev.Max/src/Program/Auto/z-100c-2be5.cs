using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_2be5-a1ba1dfe")]
        public void Method_100c_2be5()
        {
            ii(0x100c_2be5, 5); pushd(0x40);                            /* push 0x40 */
            ii(0x100c_2bea, 5); calld(Definitions.sys_check_available_stack_size, 0xa_3163); /* call 0x10165d52 */
            ii(0x100c_2bef, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_2bf0, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_2bf1, 1); pushd(esi);                             /* push esi */
            ii(0x100c_2bf2, 1); pushd(edi);                             /* push edi */
            ii(0x100c_2bf3, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_2bf4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_2bf6, 6); sub(esp, 0x28);                         /* sub esp, 0x28 */
            ii(0x100c_2bfc, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_2bff, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100c_2c02, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_2c05, 4); cmp(memd_a32[ds, eax + 0x67], 0);       /* cmp dword [eax+0x67], 0x0 */
            ii(0x100c_2c09, 6); if(jzd(0x100c_2d17, 0x108)) goto l_0x100c_2d17; /* jz 0x100c2d17 */
            ii(0x100c_2c0f, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x100c_2c12, 3); mov(ebx, memd_a32[ds, ebx + 0x1a]);     /* mov ebx, [ebx+0x1a] */
            ii(0x100c_2c15, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100c_2c18, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100c_2c1b, 3); mov(edx, memd_a32[ds, edx + 0x18]);     /* mov edx, [edx+0x18] */
            ii(0x100c_2c1e, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100c_2c21, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100c_2c24, 5); calld(0x1007_6aac, -0x4_c17d);          /* call 0x10076aac */
            ii(0x100c_2c29, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100c_2c2b, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100c_2c2e, 3); mov(al, memb_a32[ds, edx + 0x26]);      /* mov al, [edx+0x26] */
            ii(0x100c_2c31, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100c_2c34, 5); mov(edx, 0x29);                         /* mov edx, 0x29 */
            ii(0x100c_2c39, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x100c_2c3d, 6); imul(ebx, eax, 0x247);                  /* imul ebx, eax, 0x247 */
            ii(0x100c_2c43, 5); mov(eax, 0x101c_a468);                  /* mov eax, 0x101ca468 */
            ii(0x100c_2c48, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x100c_2c4a, 5); calld(0x100d_fd2c, 0x1_d0dd);           /* call 0x100dfd2c */
            ii(0x100c_2c4f, 4); mov(ax, memw_a32[ds, eax + 0xe]);       /* mov ax, [eax+0xe] */
            ii(0x100c_2c53, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100c_2c56, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100c_2c5a, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100c_2c5d, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100c_2c60, 3); mov(edx, memd_a32[ds, edx + 0x67]);     /* mov edx, [edx+0x67] */
            ii(0x100c_2c63, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100c_2c65, 4); movsx(edx, memw_a32[ss, ebp - 0x12]);   /* movsx edx, word [ebp-0x12] */
            ii(0x100c_2c69, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100c_2c6b, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100c_2c6d, 3); movsx(eax, memb_a32[ds, eax]);          /* movsx eax, byte [eax] */
            ii(0x100c_2c70, 4); movsx(edx, memw_a32[ss, ebp - 0x10]);   /* movsx edx, word [ebp-0x10] */
            ii(0x100c_2c74, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100c_2c76, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100c_2c78, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100c_2c7b, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100c_2c7d, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x100c_2c7f, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100c_2c81, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100c_2c85, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100c_2c88, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_2c8a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_2c8d, 3); mov(eax, memd_a32[ds, eax + 0x67]);     /* mov eax, [eax+0x67] */
            ii(0x100c_2c90, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100c_2c92, 4); movsx(edx, memw_a32[ss, ebp - 0x12]);   /* movsx edx, word [ebp-0x12] */
            ii(0x100c_2c96, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100c_2c98, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100c_2c9a, 2); mov(memb_a32[ds, eax], bl);             /* mov [eax], bl */
            ii(0x100c_2c9c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_2c9e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_2ca1, 3); add(eax, 0x21);                         /* add eax, 0x21 */
            ii(0x100c_2ca4, 5); calld(0x1013_ad11, 0x7_8068);           /* call 0x1013ad11 */
            ii(0x100c_2ca9, 2); test(al, al);                           /* test al, al */
            ii(0x100c_2cab, 2); if(jzd(0x100c_2d17, 0x6a)) goto l_0x100c_2d17; /* jz 0x100c2d17 */
            ii(0x100c_2cad, 5); mov(eax, 0x23);                         /* mov eax, 0x23 */
            ii(0x100c_2cb2, 5); calld(Definitions.sys_new, 0xa_3149);   /* call 0x10165e00 */
            ii(0x100c_2cb7, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100c_2cba, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100c_2cbd, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x100c_2cc0, 4); cmp(memd_a32[ss, ebp - 0x1c], 0);       /* cmp dword [ebp-0x1c], 0x0 */
            ii(0x100c_2cc4, 2); if(jzd(0x100c_2cec, 0x26)) goto l_0x100c_2cec; /* jz 0x100c2cec */
            ii(0x100c_2cc6, 3); lea(edx, ebp - 0x14);                   /* lea edx, [ebp-0x14] */
            ii(0x100c_2cc9, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100c_2ccc, 5); calld(0x1007_5e64, -0x4_ce6d);          /* call 0x10075e64 */
            ii(0x100c_2cd1, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100c_2cd3, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_2cd6, 3); movsx(edx, memw_a32[ds, eax]);          /* movsx edx, word [eax] */
            ii(0x100c_2cd9, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100c_2cdc, 5); calld(0x1009_ef13, -0x2_3dce);          /* call 0x1009ef13 */
            ii(0x100c_2ce1, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x100c_2ce4, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100c_2ce7, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x100c_2cea, 2); jmpd(0x100c_2cf2, 0x6); goto l_0x100c_2cf2; /* jmp 0x100c2cf2 */
        l_0x100c_2cec:
            ii(0x100c_2cec, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100c_2cef, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
        l_0x100c_2cf2:
            ii(0x100c_2cf2, 3); mov(edx, memd_a32[ss, ebp - 0x28]);     /* mov edx, [ebp-0x28] */
            ii(0x100c_2cf5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_2cf8, 3); add(eax, 0x21);                         /* add eax, 0x21 */
            ii(0x100c_2cfb, 5); calld(0x1008_afe4, -0x3_7d1c);          /* call 0x1008afe4 */
            ii(0x100c_2d00, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_2d03, 3); add(eax, 0x21);                         /* add eax, 0x21 */
            ii(0x100c_2d06, 5); calld(0x1008_af84, -0x3_7d87);          /* call 0x1008af84 */
            ii(0x100c_2d0b, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_2d0d, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100c_2d12, 5); calld(0x100a_4d50, -0x1_dfc7);          /* call 0x100a4d50 */
        l_0x100c_2d17:
            ii(0x100c_2d17, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_2d19, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_2d1a, 1); popd(edi);                              /* pop edi */
            ii(0x100c_2d1b, 1); popd(esi);                              /* pop esi */
            ii(0x100c_2d1c, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_2d1d, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_2d1e, 1); retd(); return;                         /* ret */
        }
    }
}
