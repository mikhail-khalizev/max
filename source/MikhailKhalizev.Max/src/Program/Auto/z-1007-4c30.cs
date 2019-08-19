using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_4c30-bcec5dd7")]
        public void Method_1007_4c30()
        {
            ii(0x1007_4c30, 5); pushd(0x34);                            /* push 0x34 */
            ii(0x1007_4c35, 5); calld(Definitions.sys_check_available_stack_size, 0xf_1118); /* call 0x10165d52 */
            ii(0x1007_4c3a, 1); pushd(esi);                             /* push esi */
            ii(0x1007_4c3b, 1); pushd(edi);                             /* push edi */
            ii(0x1007_4c3c, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_4c3d, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_4c3f, 6); sub(esp, 0x24);                         /* sub esp, 0x24 */
            ii(0x1007_4c45, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1007_4c48, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x1007_4c4b, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x1007_4c4e, 3); mov(memb_a32[ss, ebp - 0x4], cl);       /* mov [ebp-0x4], cl */
            ii(0x1007_4c51, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1007_4c55, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_4c57, 2); if(jld(0x1007_4c65, 0xc)) goto l_0x1007_4c65; /* jl 0x10074c65 */
            ii(0x1007_4c59, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_4c5c, 7); cmp(ax, memw_a32[ds, 0x101c_8172]);     /* cmp ax, [0x101c8172] */
            ii(0x1007_4c63, 2); if(jld(0x1007_4c67, 0x2)) goto l_0x1007_4c67; /* jl 0x10074c67 */
        l_0x1007_4c65:
            ii(0x1007_4c65, 2); jmpd(0x1007_4c6f, 0x8); goto l_0x1007_4c6f; /* jmp 0x10074c6f */
        l_0x1007_4c67:
            ii(0x1007_4c67, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1007_4c6b, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_4c6d, 2); if(jged(0x1007_4c71, 0x2)) goto l_0x1007_4c71; /* jge 0x10074c71 */
        l_0x1007_4c6f:
            ii(0x1007_4c6f, 2); jmpd(0x1007_4c7d, 0xc); goto l_0x1007_4c7d; /* jmp 0x10074c7d */
        l_0x1007_4c71:
            ii(0x1007_4c71, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_4c74, 7); cmp(ax, memw_a32[ds, 0x101c_8174]);     /* cmp ax, [0x101c8174] */
            ii(0x1007_4c7b, 2); if(jld(0x1007_4c89, 0xc)) goto l_0x1007_4c89; /* jl 0x10074c89 */
        l_0x1007_4c7d:
            ii(0x1007_4c7d, 7); mov(memd_a32[ss, ebp - 0x14], 0);       /* mov dword [ebp-0x14], 0x0 */
            ii(0x1007_4c84, 5); jmpd(0x1007_4e03, 0x17a); goto l_0x1007_4e03; /* jmp 0x10074e03 */
        l_0x1007_4c89:
            ii(0x1007_4c89, 4); movsx(ebx, memw_a32[ss, ebp - 0x8]);    /* movsx ebx, word [ebp-0x8] */
            ii(0x1007_4c8d, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x1007_4c91, 5); mov(eax, 0x101c_39b8);                  /* mov eax, 0x101c39b8 */
            ii(0x1007_4c96, 5); calld(0x1010_3541, 0x8_e8a6);           /* call 0x10103541 */
            ii(0x1007_4c9b, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_4c9d, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1007_4ca0, 5); calld(0x1007_64b8, 0x1813);             /* call 0x100764b8 */
            ii(0x1007_4ca5, 7); mov(memd_a32[ss, ebp - 0x1c], 0);       /* mov dword [ebp-0x1c], 0x0 */
            ii(0x1007_4cac, 4); mov(memb_a32[ss, ebp - 0x20], 0);       /* mov byte [ebp-0x20], 0x0 */
        l_0x1007_4cb0:
            ii(0x1007_4cb0, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_4cb2, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1007_4cb5, 5); calld(0x1013_ad71, 0xc_60b7);           /* call 0x1013ad71 */
            ii(0x1007_4cba, 2); test(al, al);                           /* test al, al */
            ii(0x1007_4cbc, 6); if(jzd(0x1007_4da8, 0xe6)) goto l_0x1007_4da8; /* jz 0x10074da8 */
            ii(0x1007_4cc2, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1007_4cc5, 5); calld(0x1007_63a0, 0x16d6);             /* call 0x100763a0 */
            ii(0x1007_4cca, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x1007_4ccd, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1007_4cd0, 3); cmp(dl, memb_a32[ds, eax + 0x26]);      /* cmp dl, [eax+0x26] */
            ii(0x1007_4cd3, 2); if(jnzd(0x1007_4cec, 0x17)) goto l_0x1007_4cec; /* jnz 0x10074cec */
            ii(0x1007_4cd5, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1007_4cd8, 5); calld(0x1007_63a0, 0x16c3);             /* call 0x100763a0 */
            ii(0x1007_4cdd, 4); test(memb_a32[ds, eax + 0x12], 0x20);   /* test byte [eax+0x12], 0x20 */
            ii(0x1007_4ce1, 2); if(jnzd(0x1007_4ce7, 0x4)) goto l_0x1007_4ce7; /* jnz 0x10074ce7 */
            ii(0x1007_4ce3, 4); mov(memb_a32[ss, ebp - 0x20], 0x1);     /* mov byte [ebp-0x20], 0x1 */
        l_0x1007_4ce7:
            ii(0x1007_4ce7, 5); jmpd(0x1007_4d9b, 0xaf); goto l_0x1007_4d9b; /* jmp 0x10074d9b */
        l_0x1007_4cec:
            ii(0x1007_4cec, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1007_4cef, 5); calld(0x1007_63a0, 0x16ac);             /* call 0x100763a0 */
            ii(0x1007_4cf4, 4); test(memb_a32[ds, eax + 0x14], 0x40);   /* test byte [eax+0x14], 0x40 */
            ii(0x1007_4cf8, 2); if(jzd(0x1007_4d08, 0xe)) goto l_0x1007_4d08; /* jz 0x10074d08 */
            ii(0x1007_4cfa, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1007_4cfd, 5); calld(0x1007_63a0, 0x169e);             /* call 0x100763a0 */
            ii(0x1007_4d02, 4); cmp(memb_a32[ds, eax + 0x3d], 0x9);     /* cmp byte [eax+0x3d], 0x9 */
            ii(0x1007_4d06, 2); if(jnzd(0x1007_4d0a, 0x2)) goto l_0x1007_4d0a; /* jnz 0x10074d0a */
        l_0x1007_4d08:
            ii(0x1007_4d08, 2); jmpd(0x1007_4d18, 0xe); goto l_0x1007_4d18; /* jmp 0x10074d18 */
        l_0x1007_4d0a:
            ii(0x1007_4d0a, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1007_4d0d, 5); calld(0x1007_63a0, 0x168e);             /* call 0x100763a0 */
            ii(0x1007_4d12, 4); cmp(memb_a32[ds, eax + 0x3e], 0xe);     /* cmp byte [eax+0x3e], 0xe */
            ii(0x1007_4d16, 2); if(jnzd(0x1007_4d1a, 0x2)) goto l_0x1007_4d1a; /* jnz 0x10074d1a */
        l_0x1007_4d18:
            ii(0x1007_4d18, 2); jmpd(0x1007_4d28, 0xe); goto l_0x1007_4d28; /* jmp 0x10074d28 */
        l_0x1007_4d1a:
            ii(0x1007_4d1a, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1007_4d1d, 5); calld(0x1007_63a0, 0x167e);             /* call 0x100763a0 */
            ii(0x1007_4d22, 4); cmp(memb_a32[ds, eax + 0x3d], 0x10);    /* cmp byte [eax+0x3d], 0x10 */
            ii(0x1007_4d26, 2); if(jnzd(0x1007_4d2a, 0x2)) goto l_0x1007_4d2a; /* jnz 0x10074d2a */
        l_0x1007_4d28:
            ii(0x1007_4d28, 2); jmpd(0x1007_4d52, 0x28); goto l_0x1007_4d52; /* jmp 0x10074d52 */
        l_0x1007_4d2a:
            ii(0x1007_4d2a, 4); movsx(ebx, memw_a32[ss, ebp - 0x8]);    /* movsx ebx, word [ebp-0x8] */
            ii(0x1007_4d2e, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x1007_4d32, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1007_4d35, 5); calld(0x1007_6aac, 0x1d72);             /* call 0x10076aac */
            ii(0x1007_4d3a, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1007_4d3c, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1007_4d3f, 5); calld(0x1007_6408, 0x16c4);             /* call 0x10076408 */
            ii(0x1007_4d44, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_4d46, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1007_4d49, 5); calld(0x1007_4b2b, -0x223);             /* call 0x10074b2b */
            ii(0x1007_4d4e, 2); test(al, al);                           /* test al, al */
            ii(0x1007_4d50, 2); if(jnzd(0x1007_4d54, 0x2)) goto l_0x1007_4d54; /* jnz 0x10074d54 */
        l_0x1007_4d52:
            ii(0x1007_4d52, 2); jmpd(0x1007_4d9b, 0x47); goto l_0x1007_4d9b; /* jmp 0x10074d9b */
        l_0x1007_4d54:
            ii(0x1007_4d54, 4); cmp(memb_a32[ss, ebp - 0x4], 0);        /* cmp byte [ebp-0x4], 0x0 */
            ii(0x1007_4d58, 2); if(jzd(0x1007_4d72, 0x18)) goto l_0x1007_4d72; /* jz 0x10074d72 */
            ii(0x1007_4d5a, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1007_4d5d, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x1007_4d60, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1007_4d62, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1007_4d65, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1007_4d68, 5); calld(0x1007_63a0, 0x1633);             /* call 0x100763a0 */
            ii(0x1007_4d6d, 5); calld(0x1014_f634, 0xd_a8c2);           /* call 0x1014f634 */
        l_0x1007_4d72:
            ii(0x1007_4d72, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1007_4d75, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x1007_4d78, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1007_4d7a, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1007_4d7d, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1007_4d80, 5); calld(0x1007_63a0, 0x161b);             /* call 0x100763a0 */
            ii(0x1007_4d85, 5); calld(0x1007_6074, 0x12ea);             /* call 0x10076074 */
            ii(0x1007_4d8a, 2); test(al, al);                           /* test al, al */
            ii(0x1007_4d8c, 2); if(jzd(0x1007_4d9b, 0xd)) goto l_0x1007_4d9b; /* jz 0x10074d9b */
            ii(0x1007_4d8e, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1007_4d91, 5); calld(0x1007_6408, 0x1672);             /* call 0x10076408 */
            ii(0x1007_4d96, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1007_4d99, 2); jmpd(0x1007_4da8, 0xd); goto l_0x1007_4da8; /* jmp 0x10074da8 */
        l_0x1007_4d9b:
            ii(0x1007_4d9b, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1007_4d9e, 5); calld(0x1007_6bf8, 0x1e55);             /* call 0x10076bf8 */
            ii(0x1007_4da3, 5); jmpd(0x1007_4cb0, -0xf8); goto l_0x1007_4cb0; /* jmp 0x10074cb0 */
        l_0x1007_4da8:
            ii(0x1007_4da8, 4); cmp(memd_a32[ss, ebp - 0x1c], 0);       /* cmp dword [ebp-0x1c], 0x0 */
            ii(0x1007_4dac, 2); if(jzd(0x1007_4de7, 0x39)) goto l_0x1007_4de7; /* jz 0x10074de7 */
            ii(0x1007_4dae, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1007_4db1, 5); cmp(memw_a32[ds, eax + 0x8], 0xf);      /* cmp word [eax+0x8], 0xf */
            ii(0x1007_4db6, 2); if(jzd(0x1007_4dc2, 0xa)) goto l_0x1007_4dc2; /* jz 0x10074dc2 */
            ii(0x1007_4db8, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1007_4dbb, 5); cmp(memw_a32[ds, eax + 0x8], 0x10);     /* cmp word [eax+0x8], 0x10 */
            ii(0x1007_4dc0, 2); if(jnzd(0x1007_4dcf, 0xd)) goto l_0x1007_4dcf; /* jnz 0x10074dcf */
        l_0x1007_4dc2:
            ii(0x1007_4dc2, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1007_4dc5, 5); calld(0x1007_611c, 0x1352);             /* call 0x1007611c */
            ii(0x1007_4dca, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1007_4dcd, 2); jmpd(0x1007_4de7, 0x18); goto l_0x1007_4de7; /* jmp 0x10074de7 */
        l_0x1007_4dcf:
            ii(0x1007_4dcf, 4); cmp(memb_a32[ss, ebp - 0x20], 0);       /* cmp byte [ebp-0x20], 0x0 */
            ii(0x1007_4dd3, 2); if(jzd(0x1007_4dde, 0x9)) goto l_0x1007_4dde; /* jz 0x10074dde */
            ii(0x1007_4dd5, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1007_4dd8, 4); test(memb_a32[ds, eax + 0x12], 0x1);    /* test byte [eax+0x12], 0x1 */
            ii(0x1007_4ddc, 2); if(jnzd(0x1007_4de0, 0x2)) goto l_0x1007_4de0; /* jnz 0x10074de0 */
        l_0x1007_4dde:
            ii(0x1007_4dde, 2); jmpd(0x1007_4de7, 0x7); goto l_0x1007_4de7; /* jmp 0x10074de7 */
        l_0x1007_4de0:
            ii(0x1007_4de0, 7); mov(memd_a32[ss, ebp - 0x1c], 0);       /* mov dword [ebp-0x1c], 0x0 */
        l_0x1007_4de7:
            ii(0x1007_4de7, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1007_4dea, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1007_4ded, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_4def, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1007_4df2, 5); calld(0x1007_5f6c, 0x1175);             /* call 0x10075f6c */
            ii(0x1007_4df7, 2); jmpd(0x1007_4e03, 0xa); goto l_0x1007_4e03; /* jmp 0x10074e03 */
        //  ii(0x1007_4df9, 10); Недостижимый код.
        l_0x1007_4e03:
            ii(0x1007_4e03, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1007_4e06, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_4e08, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_4e09, 1); popd(edi);                              /* pop edi */
            ii(0x1007_4e0a, 1); popd(esi);                              /* pop esi */
            ii(0x1007_4e0b, 1); retd(); return;                         /* ret */
        }
    }
}
