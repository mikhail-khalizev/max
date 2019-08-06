using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("1d4589f6-b744-4097-a6d8-e3b431823257")]
        public void Method_100e_7c7b()
        {
            ii(0x100e_7c7b, 5); pushd(0x54);                            /* push 0x54 */
            ii(0x100e_7c80, 5); calld(Definitions.sys_check_available_stack_size, 0x7e0cd); /* call 0x10165d52 */
            ii(0x100e_7c85, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_7c86, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_7c87, 1); pushd(edx);                             /* push edx */
            ii(0x100e_7c88, 1); pushd(esi);                             /* push esi */
            ii(0x100e_7c89, 1); pushd(edi);                             /* push edi */
            ii(0x100e_7c8a, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_7c8b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_7c8d, 6); sub(esp, 0x38);                         /* sub esp, 0x38 */
            ii(0x100e_7c93, 5); mov(eax, 0x101c_3620);                  /* mov eax, 0x101c3620 */
            ii(0x100e_7c98, 5); calld(Definitions.my_3_get_count, -0x5c81d); /* call 0x1008b480 */
            ii(0x100e_7c9d, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100e_7ca0, 5); mov(eax, 0x26);                         /* mov eax, 0x26 */
            ii(0x100e_7ca5, 5); calld(0x100e_883d, 0xb93);              /* call 0x100e883d */
            ii(0x100e_7caa, 5); mov(ecx, 0x6);                          /* mov ecx, 0x6 */
            ii(0x100e_7caf, 3); lea(edi, ebp - 0x30);                   /* lea edi, [ebp-0x30] */
            ii(0x100e_7cb2, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x100e_7cb4, 2); rep_a32(() => movsd_a32());             /* rep movsd */
            ii(0x100e_7cb6, 2); movsw_a32();                            /* movsw */
            ii(0x100e_7cb8, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_7cba, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100e_7cbf, 5); calld(0x1013_ad71, 0x530ad);            /* call 0x1013ad71 */
            ii(0x100e_7cc4, 2); test(al, al);                           /* test al, al */
            ii(0x100e_7cc6, 2); if(jzd(0x100e_7cdc, 0x14)) goto l_0x100e_7cdc; /* jz 0x100e7cdc */
            ii(0x100e_7cc8, 5); mov(edx, 0x100e_618d);                  /* mov edx, 0x100e618d */
            ii(0x100e_7ccd, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100e_7cd2, 5); calld(0x1007_65d0, -0x71707);           /* call 0x100765d0 */
            ii(0x100e_7cd7, 5); calld(0x100e_603a, -0x1ca2);            /* call 0x100e603a */
        l_0x100e_7cdc:
            ii(0x100e_7cdc, 3); dec(memd_a32[ss, ebp - 0x4]);           /* dec dword [ebp-0x4] */
            ii(0x100e_7cdf, 5); cmp(memw_a32[ss, ebp - 0x4], -0x1 /* 0xff */); /* cmp word [ebp-0x4], 0xffff */
            ii(0x100e_7ce4, 6); if(jzd(0x100e_7e21, 0x137)) goto l_0x100e_7e21; /* jz 0x100e7e21 */
            ii(0x100e_7cea, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x100e_7cee, 5); mov(eax, 0x101c_3620);                  /* mov eax, 0x101c3620 */
            ii(0x100e_7cf3, 5); calld(0x100e_84b8, 0x7c0);              /* call 0x100e84b8 */
            ii(0x100e_7cf8, 3); lea(edi, ebp - 0x14);                   /* lea edi, [ebp-0x14] */
            ii(0x100e_7cfb, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x100e_7cfd, 1); movsd_a32();                            /* movsd */
            ii(0x100e_7cfe, 1); movsd_a32();                            /* movsd */
            ii(0x100e_7cff, 1); movsd_a32();                            /* movsd */
            ii(0x100e_7d00, 1); movsd_a32();                            /* movsd */
            ii(0x100e_7d01, 3); mov(edx, memd_a32[ss, ebp - 0x14]);     /* mov edx, [ebp-0x14] */
            ii(0x100e_7d04, 3); shl(edx, 0x10);                         /* shl edx, 0x10 */
            ii(0x100e_7d07, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100e_7d09, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100e_7d0c, 6); idiv(memd_a32[ds, 0x101c_38c4]);        /* idiv dword [0x101c38c4] */
            ii(0x100e_7d12, 6); mov(edx, memd_a32[ds, 0x101c_38fa]);    /* mov edx, [0x101c38fa] */
            ii(0x100e_7d18, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100e_7d1b, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100e_7d1d, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100e_7d20, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x100e_7d23, 3); shl(edx, 0x10);                         /* shl edx, 0x10 */
            ii(0x100e_7d26, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100e_7d28, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100e_7d2b, 6); idiv(memd_a32[ds, 0x101c_38c4]);        /* idiv dword [0x101c38c4] */
            ii(0x100e_7d31, 6); mov(edx, memd_a32[ds, 0x101c_38fc]);    /* mov edx, [0x101c38fc] */
            ii(0x100e_7d37, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100e_7d3a, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100e_7d3c, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100e_7d3f, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100e_7d42, 1); dec(edx);                               /* dec edx */
            ii(0x100e_7d43, 3); shl(edx, 0x10);                         /* shl edx, 0x10 */
            ii(0x100e_7d46, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100e_7d48, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100e_7d4b, 6); idiv(memd_a32[ds, 0x101c_38c4]);        /* idiv dword [0x101c38c4] */
            ii(0x100e_7d51, 6); mov(edx, memd_a32[ds, 0x101c_38fa]);    /* mov edx, [0x101c38fa] */
            ii(0x100e_7d57, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100e_7d5a, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100e_7d5c, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100e_7d5f, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100e_7d62, 1); dec(edx);                               /* dec edx */
            ii(0x100e_7d63, 3); shl(edx, 0x10);                         /* shl edx, 0x10 */
            ii(0x100e_7d66, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100e_7d68, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100e_7d6b, 6); idiv(memd_a32[ds, 0x101c_38c4]);        /* idiv dword [0x101c38c4] */
            ii(0x100e_7d71, 6); mov(edx, memd_a32[ds, 0x101c_38fc]);    /* mov edx, [0x101c38fc] */
            ii(0x100e_7d77, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100e_7d7a, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100e_7d7c, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_7d7f, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x100e_7d82, 3); add(memd_a32[ss, ebp - 0x14], eax);     /* add [ebp-0x14], eax */
            ii(0x100e_7d85, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x100e_7d88, 3); add(memd_a32[ss, ebp - 0x10], eax);     /* add [ebp-0x10], eax */
            ii(0x100e_7d8b, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x100e_7d8e, 3); add(memd_a32[ss, ebp - 0xc], eax);      /* add [ebp-0xc], eax */
            ii(0x100e_7d91, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x100e_7d94, 3); add(memd_a32[ss, ebp - 0x8], eax);      /* add [ebp-0x8], eax */
            ii(0x100e_7d97, 4); cmp(memd_a32[ss, ebp - 0x14], 0);       /* cmp dword [ebp-0x14], 0x0 */
            ii(0x100e_7d9b, 2); if(jld(0x100e_7da3, 0x6)) goto l_0x100e_7da3; /* jl 0x100e7da3 */
            ii(0x100e_7d9d, 4); cmp(memd_a32[ss, ebp - 0x10], 0);       /* cmp dword [ebp-0x10], 0x0 */
            ii(0x100e_7da1, 2); if(jged(0x100e_7da5, 0x2)) goto l_0x100e_7da5; /* jge 0x100e7da5 */
        l_0x100e_7da3:
            ii(0x100e_7da3, 2); jmpd(0x100e_7dae, 0x9); goto l_0x100e_7dae; /* jmp 0x100e7dae */
        l_0x100e_7da5:
            ii(0x100e_7da5, 7); cmp(memd_a32[ss, ebp - 0xc], 0x280);    /* cmp dword [ebp-0xc], 0x280 */
            ii(0x100e_7dac, 2); if(jld(0x100e_7db0, 0x2)) goto l_0x100e_7db0; /* jl 0x100e7db0 */
        l_0x100e_7dae:
            ii(0x100e_7dae, 2); jmpd(0x100e_7db9, 0x9); goto l_0x100e_7db9; /* jmp 0x100e7db9 */
        l_0x100e_7db0:
            ii(0x100e_7db0, 7); cmp(memd_a32[ss, ebp - 0x8], 0x1e0);    /* cmp dword [ebp-0x8], 0x1e0 */
            ii(0x100e_7db7, 2); if(jld(0x100e_7dbb, 0x2)) goto l_0x100e_7dbb; /* jl 0x100e7dbb */
        l_0x100e_7db9:
            ii(0x100e_7db9, 2); jmpd(0x100e_7dc4, 0x9); goto l_0x100e_7dc4; /* jmp 0x100e7dc4 */
        l_0x100e_7dbb:
            ii(0x100e_7dbb, 7); mov(memd_a32[ss, ebp - 0x34], 0);       /* mov dword [ebp-0x34], 0x0 */
            ii(0x100e_7dc2, 2); jmpd(0x100e_7ddd, 0x19); goto l_0x100e_7ddd; /* jmp 0x100e7ddd */
        l_0x100e_7dc4:
            ii(0x100e_7dc4, 5); mov(ecx, 0x546);                        /* mov ecx, 0x546 */
            ii(0x100e_7dc9, 5); mov(ebx, StringDefinitions.DrawmapCpp); /* mov ebx, 0x101a1e3a */
            ii(0x100e_7dce, 5); mov(edx, StringDefinitions.RectUlxGreaterOrEqual0RectUlyGreaterOrEqual0RectLrxLess640RectLryLess480); /* mov edx, 0x101a1e46 */
            ii(0x100e_7dd3, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100e_7dd5, 5); calld(Definitions.sys_assert, 0x7dfb8); /* call 0x10165d92 */
            ii(0x100e_7dda, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
        l_0x100e_7ddd:
            ii(0x100e_7ddd, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100e_7de0, 3); cmp(eax, memd_a32[ss, ebp - 0xc]);      /* cmp eax, [ebp-0xc] */
            ii(0x100e_7de3, 2); if(jgd(0x100e_7ded, 0x8)) goto l_0x100e_7ded; /* jg 0x100e7ded */
            ii(0x100e_7de5, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_7de8, 3); cmp(eax, memd_a32[ss, ebp - 0x8]);      /* cmp eax, [ebp-0x8] */
            ii(0x100e_7deb, 2); if(jled(0x100e_7def, 0x2)) goto l_0x100e_7def; /* jle 0x100e7def */
        l_0x100e_7ded:
            ii(0x100e_7ded, 2); jmpd(0x100e_7df8, 0x9); goto l_0x100e_7df8; /* jmp 0x100e7df8 */
        l_0x100e_7def:
            ii(0x100e_7def, 7); mov(memd_a32[ss, ebp - 0x38], 0);       /* mov dword [ebp-0x38], 0x0 */
            ii(0x100e_7df6, 2); jmpd(0x100e_7e11, 0x19); goto l_0x100e_7e11; /* jmp 0x100e7e11 */
        l_0x100e_7df8:
            ii(0x100e_7df8, 5); mov(ecx, 0x547);                        /* mov ecx, 0x547 */
            ii(0x100e_7dfd, 5); mov(ebx, StringDefinitions.DrawmapCpp2); /* mov ebx, 0x101a1e89 */
            ii(0x100e_7e02, 5); mov(edx, StringDefinitions.RectUlxLessOrEqualRectLrxRectUlyLessOrEqualRectLry); /* mov edx, 0x101a1e95 */
            ii(0x100e_7e07, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100e_7e09, 5); calld(Definitions.sys_assert, 0x7df84); /* call 0x10165d92 */
            ii(0x100e_7e0e, 3); mov(memd_a32[ss, ebp - 0x38], eax);     /* mov [ebp-0x38], eax */
        l_0x100e_7e11:
            ii(0x100e_7e11, 3); lea(edx, ebp - 0x14);                   /* lea edx, [ebp-0x14] */
            ii(0x100e_7e14, 3); mov(eax, memd_a32[ss, ebp - 0x1e]);     /* mov eax, [ebp-0x1e] */
            ii(0x100e_7e17, 5); calld(Definitions.sys_display_draw_1, 0x7f68c); /* call 0x101674a8 */
            ii(0x100e_7e1c, 5); jmpd(0x100e_7cdc, -0x145); goto l_0x100e_7cdc; /* jmp 0x100e7cdc */
        l_0x100e_7e21:
            ii(0x100e_7e21, 5); mov(eax, 0x101c_3620);                  /* mov eax, 0x101c3620 */
            ii(0x100e_7e26, 5); calld(0x1009_cb94, -0x4b297);           /* call 0x1009cb94 */
            ii(0x100e_7e2b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_7e2d, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_7e2e, 1); popd(edi);                              /* pop edi */
            ii(0x100e_7e2f, 1); popd(esi);                              /* pop esi */
            ii(0x100e_7e30, 1); popd(edx);                              /* pop edx */
            ii(0x100e_7e31, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_7e32, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_7e33, 1); retd(); return;                         /* ret */
        }
    }
}
