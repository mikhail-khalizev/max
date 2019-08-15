using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("933a499a-5791-42cb-b775-73f267a643d5")]
        public void Method_1009_2c20()
        {
            ii(0x1009_2c20, 5); pushd(0x64);                            /* push 0x64 */
            ii(0x1009_2c25, 5); calld(Definitions.sys_check_available_stack_size, 0xd_3128); /* call 0x10165d52 */
            ii(0x1009_2c2a, 1); pushd(esi);                             /* push esi */
            ii(0x1009_2c2b, 1); pushd(edi);                             /* push edi */
            ii(0x1009_2c2c, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_2c2d, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_2c2f, 6); sub(esp, 0x50);                         /* sub esp, 0x50 */
            ii(0x1009_2c35, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1009_2c38, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x1009_2c3b, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x1009_2c3e, 3); mov(memd_a32[ss, ebp - 0x8], ecx);      /* mov [ebp-0x8], ecx */
            ii(0x1009_2c41, 4); mov(memb_a32[ss, ebp - 0x14], 0);       /* mov byte [ebp-0x14], 0x0 */
            ii(0x1009_2c45, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1009_2c48, 5); calld(Definitions.my_ctor_0x101b4184, -0x1_c15d); /* call 0x10076af0 */
            ii(0x1009_2c4d, 6); mov(memw_a32[ss, ebp - 0x28], 0);       /* mov word [ebp-0x28], 0x0 */
            ii(0x1009_2c53, 2); jmpd(0x1009_2c5c, 0x7); goto l_0x1009_2c5c; /* jmp 0x10092c5c */
        l_0x1009_2c55:
            ii(0x1009_2c55, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1009_2c58, 4); inc(memw_a32[ss, ebp - 0x28]);          /* inc word [ebp-0x28] */
        l_0x1009_2c5c:
            ii(0x1009_2c5c, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1009_2c5f, 7); cmp(ax, memw_a32[ds, 0x101c_8172]);     /* cmp ax, [0x101c8172] */
            ii(0x1009_2c66, 6); if(jged(0x1009_2d1d, 0xb1)) goto l_0x1009_2d1d; /* jge 0x10092d1d */
            ii(0x1009_2c6c, 6); mov(memw_a32[ss, ebp - 0x26], 0);       /* mov word [ebp-0x26], 0x0 */
            ii(0x1009_2c72, 2); jmpd(0x1009_2c7b, 0x7); goto l_0x1009_2c7b; /* jmp 0x10092c7b */
        l_0x1009_2c74:
            ii(0x1009_2c74, 3); mov(eax, memd_a32[ss, ebp - 0x26]);     /* mov eax, [ebp-0x26] */
            ii(0x1009_2c77, 4); inc(memw_a32[ss, ebp - 0x26]);          /* inc word [ebp-0x26] */
        l_0x1009_2c7b:
            ii(0x1009_2c7b, 3); mov(eax, memd_a32[ss, ebp - 0x26]);     /* mov eax, [ebp-0x26] */
            ii(0x1009_2c7e, 7); cmp(ax, memw_a32[ds, 0x101c_8174]);     /* cmp ax, [0x101c8174] */
            ii(0x1009_2c85, 6); if(jged(0x1009_2d18, 0x8d)) goto l_0x1009_2d18; /* jge 0x10092d18 */
            ii(0x1009_2c8b, 4); movsx(eax, memw_a32[ss, ebp - 0x28]);   /* movsx eax, word [ebp-0x28] */
            ii(0x1009_2c8f, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1009_2c92, 3); add(eax, memd_a32[ss, ebp - 0xc]);      /* add eax, [ebp-0xc] */
            ii(0x1009_2c95, 4); movsx(edx, memw_a32[ss, ebp - 0x26]);   /* movsx edx, word [ebp-0x26] */
            ii(0x1009_2c99, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x1009_2c9b, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1009_2c9d, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1009_2c9f, 3); mov(ax, memw_a32[ds, eax]);             /* mov ax, [eax] */
            ii(0x1009_2ca2, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x1009_2ca5, 4); movsx(eax, memw_a32[ss, ebp - 0x24]);   /* movsx eax, word [ebp-0x24] */
            ii(0x1009_2ca9, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x1009_2cac, 2); if(jged(0x1009_2d13, 0x65)) goto l_0x1009_2d13; /* jge 0x10092d13 */
            ii(0x1009_2cae, 4); movsx(ecx, memw_a32[ss, ebp - 0x4]);    /* movsx ecx, word [ebp-0x4] */
            ii(0x1009_2cb2, 3); lea(edx, ebp - 0x28);                   /* lea edx, [ebp-0x28] */
            ii(0x1009_2cb5, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x1009_2cb8, 5); calld(0x1007_5e64, -0x1_ce59);          /* call 0x10075e64 */
            ii(0x1009_2cbd, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1009_2cbf, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1009_2cc2, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_2cc5, 5); calld(0x1009_2334, -0x996);             /* call 0x10092334 */
            ii(0x1009_2cca, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1009_2ccd, 4); cmp(memb_a32[ss, ebp - 0x14], 0);       /* cmp byte [ebp-0x14], 0x0 */
            ii(0x1009_2cd1, 2); if(jzd(0x1009_2cdc, 0x9)) goto l_0x1009_2cdc; /* jz 0x10092cdc */
            ii(0x1009_2cd3, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1009_2cd6, 4); cmp(ax, memw_a32[ss, ebp - 0x20]);      /* cmp ax, [ebp-0x20] */
            ii(0x1009_2cda, 2); if(jled(0x1009_2cfc, 0x20)) goto l_0x1009_2cfc; /* jle 0x10092cfc */
        l_0x1009_2cdc:
            ii(0x1009_2cdc, 4); movsx(ecx, memw_a32[ss, ebp - 0x4]);    /* movsx ecx, word [ebp-0x4] */
            ii(0x1009_2ce0, 3); lea(edx, ebp - 0x28);                   /* lea edx, [ebp-0x28] */
            ii(0x1009_2ce3, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x1009_2ce6, 5); calld(0x1007_5e64, -0x1_ce87);          /* call 0x10075e64 */
            ii(0x1009_2ceb, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1009_2ced, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1009_2cf0, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_2cf3, 5); calld(0x1009_285c, -0x49c);             /* call 0x1009285c */
            ii(0x1009_2cf8, 2); test(al, al);                           /* test al, al */
            ii(0x1009_2cfa, 2); if(jnzd(0x1009_2cfe, 0x2)) goto l_0x1009_2cfe; /* jnz 0x10092cfe */
        l_0x1009_2cfc:
            ii(0x1009_2cfc, 2); jmpd(0x1009_2d13, 0x15); goto l_0x1009_2d13; /* jmp 0x10092d13 */
        l_0x1009_2cfe:
            ii(0x1009_2cfe, 3); lea(edx, ebp - 0x28);                   /* lea edx, [ebp-0x28] */
            ii(0x1009_2d01, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_2d04, 5); calld(0x1008_8b44, -0xa1c5);            /* call 0x10088b44 */
            ii(0x1009_2d09, 4); mov(memb_a32[ss, ebp - 0x14], 0x1);     /* mov byte [ebp-0x14], 0x1 */
            ii(0x1009_2d0d, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1009_2d10, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
        l_0x1009_2d13:
            ii(0x1009_2d13, 5); jmpd(0x1009_2c74, -0xa4); goto l_0x1009_2c74; /* jmp 0x10092c74 */
        l_0x1009_2d18:
            ii(0x1009_2d18, 5); jmpd(0x1009_2c55, -0xc8); goto l_0x1009_2c55; /* jmp 0x10092c55 */
        l_0x1009_2d1d:
            ii(0x1009_2d1d, 4); cmp(memb_a32[ss, ebp - 0x14], 0);       /* cmp byte [ebp-0x14], 0x0 */
            ii(0x1009_2d21, 6); if(jzd(0x1009_2e16, 0xef)) goto l_0x1009_2e16; /* jz 0x10092e16 */
            ii(0x1009_2d27, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_2d2a, 4); mov(ax, memw_a32[ds, eax + 0x2]);       /* mov ax, [eax+0x2] */
            ii(0x1009_2d2e, 1); inc(eax);                               /* inc eax */
            ii(0x1009_2d2f, 1); cwde();                                 /* cwde */
            ii(0x1009_2d30, 1); pushd(eax);                             /* push eax */
            ii(0x1009_2d31, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_2d34, 3); mov(ax, memw_a32[ds, eax]);             /* mov ax, [eax] */
            ii(0x1009_2d37, 1); inc(eax);                               /* inc eax */
            ii(0x1009_2d38, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1009_2d3b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_2d3e, 2); mov(ebx, memd_a32[ds, eax]);            /* mov ebx, [eax] */
            ii(0x1009_2d40, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1009_2d43, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_2d46, 3); movsx(edx, memw_a32[ds, eax]);          /* movsx edx, word [eax] */
            ii(0x1009_2d49, 3); lea(eax, ebp - 0x40);                   /* lea eax, [ebp-0x40] */
            ii(0x1009_2d4c, 5); calld(0x1008_b148, -0x7c09);            /* call 0x1008b148 */
            ii(0x1009_2d51, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_2d54, 3); add(eax, 0x21);                         /* add eax, 0x21 */
            ii(0x1009_2d57, 5); calld(0x1009_c6c8, 0x996c);             /* call 0x1009c6c8 */
            ii(0x1009_2d5c, 3); lea(ebx, ebp - 0x44);                   /* lea ebx, [ebp-0x44] */
            ii(0x1009_2d5f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_2d61, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1009_2d63, 5); calld(0x1009_c5dc, 0x9874);             /* call 0x1009c5dc */
            ii(0x1009_2d68, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1009_2d6c, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x1009_2d6f, 7); test(memb_a32[ds, eax + 0x101c_81c0], 0x10); /* test byte [eax+0x101c81c0], 0x10 */
            ii(0x1009_2d76, 2); if(jzd(0x1009_2d84, 0xc)) goto l_0x1009_2d84; /* jz 0x10092d84 */
            ii(0x1009_2d78, 3); mov(eax, memd_a32[ss, ebp - 0x38]);     /* mov eax, [ebp-0x38] */
            ii(0x1009_2d7b, 3); inc(memd_a32[ss, ebp - 0x38]);          /* inc dword [ebp-0x38] */
            ii(0x1009_2d7e, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x1009_2d81, 3); inc(memd_a32[ss, ebp - 0x34]);          /* inc dword [ebp-0x34] */
        l_0x1009_2d84:
            ii(0x1009_2d84, 2); jmpd(0x1009_2d8e, 0x8); goto l_0x1009_2d8e; /* jmp 0x10092d8e */
        l_0x1009_2d86:
            ii(0x1009_2d86, 3); lea(eax, ebp - 0x44);                   /* lea eax, [ebp-0x44] */
            ii(0x1009_2d89, 5); calld(0x1007_6bf8, -0x1_c196);          /* call 0x10076bf8 */
        l_0x1009_2d8e:
            ii(0x1009_2d8e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_2d90, 3); lea(eax, ebp - 0x44);                   /* lea eax, [ebp-0x44] */
            ii(0x1009_2d93, 5); calld(0x1013_ad71, 0xa_7fd9);           /* call 0x1013ad71 */
            ii(0x1009_2d98, 2); test(al, al);                           /* test al, al */
            ii(0x1009_2d9a, 6); if(jzd(0x1009_2e0c, 0x6c)) goto l_0x1009_2e0c; /* jz 0x10092e0c */
            ii(0x1009_2da0, 3); lea(eax, ebp - 0x44);                   /* lea eax, [ebp-0x44] */
            ii(0x1009_2da3, 5); calld(0x1009_c4f8, 0x9750);             /* call 0x1009c4f8 */
            ii(0x1009_2da8, 5); calld(0x1009_c4c4, 0x9717);             /* call 0x1009c4c4 */
            ii(0x1009_2dad, 4); cmp(ax, 0x27);                          /* cmp ax, 0x27 */
            ii(0x1009_2db1, 2); if(jnzd(0x1009_2dce, 0x1b)) goto l_0x1009_2dce; /* jnz 0x10092dce */
            ii(0x1009_2db3, 3); lea(eax, ebp - 0x44);                   /* lea eax, [ebp-0x44] */
            ii(0x1009_2db6, 5); calld(0x1009_c4f8, 0x973d);             /* call 0x1009c4f8 */
            ii(0x1009_2dbb, 3); mov(memd_a32[ss, ebp - 0x48], eax);     /* mov [ebp-0x48], eax */
            ii(0x1009_2dbe, 3); mov(eax, memd_a32[ss, ebp - 0x48]);     /* mov eax, [ebp-0x48] */
            ii(0x1009_2dc1, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x1009_2dc4, 3); mov(eax, memd_a32[ss, ebp - 0x48]);     /* mov eax, [ebp-0x48] */
            ii(0x1009_2dc7, 3); calld_abs(memd_a32[ds, edx + 0x70]);    /* call dword [edx+0x70] */
            ii(0x1009_2dca, 2); test(al, al);                           /* test al, al */
            ii(0x1009_2dcc, 2); if(jzd(0x1009_2dd0, 0x2)) goto l_0x1009_2dd0; /* jz 0x10092dd0 */
        l_0x1009_2dce:
            ii(0x1009_2dce, 2); jmpd(0x1009_2dee, 0x1e); goto l_0x1009_2dee; /* jmp 0x10092dee */
        l_0x1009_2dd0:
            ii(0x1009_2dd0, 3); lea(edx, ebp - 0x4c);                   /* lea edx, [ebp-0x4c] */
            ii(0x1009_2dd3, 3); lea(eax, ebp - 0x44);                   /* lea eax, [ebp-0x44] */
            ii(0x1009_2dd6, 5); calld(0x1009_c4f8, 0x971d);             /* call 0x1009c4f8 */
            ii(0x1009_2ddb, 5); calld(0x100a_2d3d, 0xff5d);             /* call 0x100a2d3d */
            ii(0x1009_2de0, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_2de2, 3); lea(eax, ebp - 0x40);                   /* lea eax, [ebp-0x40] */
            ii(0x1009_2de5, 5); calld(0x1010_82ce, 0x7_54e4);           /* call 0x101082ce */
            ii(0x1009_2dea, 2); test(al, al);                           /* test al, al */
            ii(0x1009_2dec, 2); if(jnzd(0x1009_2df0, 0x2)) goto l_0x1009_2df0; /* jnz 0x10092df0 */
        l_0x1009_2dee:
            ii(0x1009_2dee, 2); jmpd(0x1009_2e07, 0x17); goto l_0x1009_2e07; /* jmp 0x10092e07 */
        l_0x1009_2df0:
            ii(0x1009_2df0, 3); lea(eax, ebp - 0x44);                   /* lea eax, [ebp-0x44] */
            ii(0x1009_2df3, 5); calld(0x1009_c4f8, 0x9700);             /* call 0x1009c4f8 */
            ii(0x1009_2df8, 3); mov(memd_a32[ss, ebp - 0x50], eax);     /* mov [ebp-0x50], eax */
            ii(0x1009_2dfb, 3); mov(eax, memd_a32[ss, ebp - 0x50]);     /* mov eax, [ebp-0x50] */
            ii(0x1009_2dfe, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x1009_2e01, 3); mov(eax, memd_a32[ss, ebp - 0x50]);     /* mov eax, [ebp-0x50] */
            ii(0x1009_2e04, 3); calld_abs(memd_a32[ds, edx + 0x48]);    /* call dword [edx+0x48] */
        l_0x1009_2e07:
            ii(0x1009_2e07, 5); jmpd(0x1009_2d86, -0x86); goto l_0x1009_2d86; /* jmp 0x10092d86 */
        l_0x1009_2e0c:
            ii(0x1009_2e0c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_2e0e, 3); lea(eax, ebp - 0x44);                   /* lea eax, [ebp-0x44] */
            ii(0x1009_2e11, 5); calld(0x1009_ba6c, 0x8c56);             /* call 0x1009ba6c */
        l_0x1009_2e16:
            ii(0x1009_2e16, 3); mov(al, memb_a32[ss, ebp - 0x14]);      /* mov al, [ebp-0x14] */
            ii(0x1009_2e19, 3); mov(memb_a32[ss, ebp - 0x18], al);      /* mov [ebp-0x18], al */
            ii(0x1009_2e1c, 3); mov(al, memb_a32[ss, ebp - 0x18]);      /* mov al, [ebp-0x18] */
            ii(0x1009_2e1f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_2e21, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_2e22, 1); popd(edi);                              /* pop edi */
            ii(0x1009_2e23, 1); popd(esi);                              /* pop esi */
            ii(0x1009_2e24, 1); retd(); return;                         /* ret */
        }
    }
}
