using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("759ca3b5-f609-4e2e-a576-ff2ca6de1834")]
        public void Method_1007_4e0c()
        {
            ii(0x1007_4e0c, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1007_4e11, 5); calld(Definitions.sys_check_available_stack_size, 0xf0f3c); /* call 0x10165d52 */
            ii(0x1007_4e16, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_4e17, 1); pushd(esi);                             /* push esi */
            ii(0x1007_4e18, 1); pushd(edi);                             /* push edi */
            ii(0x1007_4e19, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_4e1a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_4e1c, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1007_4e22, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1007_4e25, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1007_4e28, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x1007_4e2b, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1007_4e2f, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_4e31, 2); if(jld(0x1007_4e3f, 0xc)) goto l_0x1007_4e3f; /* jl 0x10074e3f */
            ii(0x1007_4e33, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_4e36, 7); cmp(ax, memw_a32[ds, 0x101c_8172]);     /* cmp ax, [0x101c8172] */
            ii(0x1007_4e3d, 2); if(jld(0x1007_4e41, 0x2)) goto l_0x1007_4e41; /* jl 0x10074e41 */
        l_0x1007_4e3f:
            ii(0x1007_4e3f, 2); jmpd(0x1007_4e49, 0x8); goto l_0x1007_4e49; /* jmp 0x10074e49 */
        l_0x1007_4e41:
            ii(0x1007_4e41, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1007_4e45, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_4e47, 2); if(jged(0x1007_4e4b, 0x2)) goto l_0x1007_4e4b; /* jge 0x10074e4b */
        l_0x1007_4e49:
            ii(0x1007_4e49, 2); jmpd(0x1007_4e57, 0xc); goto l_0x1007_4e57; /* jmp 0x10074e57 */
        l_0x1007_4e4b:
            ii(0x1007_4e4b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_4e4e, 7); cmp(ax, memw_a32[ds, 0x101c_8174]);     /* cmp ax, [0x101c8174] */
            ii(0x1007_4e55, 2); if(jld(0x1007_4e63, 0xc)) goto l_0x1007_4e63; /* jl 0x10074e63 */
        l_0x1007_4e57:
            ii(0x1007_4e57, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
            ii(0x1007_4e5e, 5); jmpd(0x1007_4f14, 0xb1); goto l_0x1007_4f14; /* jmp 0x10074f14 */
        l_0x1007_4e63:
            ii(0x1007_4e63, 4); movsx(ebx, memw_a32[ss, ebp - 0x4]);    /* movsx ebx, word [ebp-0x4] */
            ii(0x1007_4e67, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1007_4e6b, 5); mov(eax, 0x101c_39b8);                  /* mov eax, 0x101c39b8 */
            ii(0x1007_4e70, 5); calld(0x1010_3541, 0x8e6cc);            /* call 0x10103541 */
            ii(0x1007_4e75, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_4e77, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_4e7a, 5); calld(0x1007_64b8, 0x1639);             /* call 0x100764b8 */
        l_0x1007_4e7f:
            ii(0x1007_4e7f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_4e81, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_4e84, 5); calld(0x1013_ad71, 0xc5ee8);            /* call 0x1013ad71 */
            ii(0x1007_4e89, 2); test(al, al);                           /* test al, al */
            ii(0x1007_4e8b, 6); if(jzd(0x1007_4ef7, 0x66)) goto l_0x1007_4ef7; /* jz 0x10074ef7 */
            ii(0x1007_4e91, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_4e94, 5); calld(0x1007_63a0, 0x1507);             /* call 0x100763a0 */
            ii(0x1007_4e99, 5); cmp(memw_a32[ds, eax + 0x8], 0x29);     /* cmp word [eax+0x8], 0x29 */
            ii(0x1007_4e9e, 2); if(jzd(0x1007_4eaf, 0xf)) goto l_0x1007_4eaf; /* jz 0x10074eaf */
            ii(0x1007_4ea0, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_4ea3, 5); calld(0x1007_63a0, 0x14f8);             /* call 0x100763a0 */
            ii(0x1007_4ea8, 5); cmp(memw_a32[ds, eax + 0x8], 0x2a);     /* cmp word [eax+0x8], 0x2a */
            ii(0x1007_4ead, 2); if(jnzd(0x1007_4ec4, 0x15)) goto l_0x1007_4ec4; /* jnz 0x10074ec4 */
        l_0x1007_4eaf:
            ii(0x1007_4eaf, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_4eb2, 5); calld(0x1007_63a0, 0x14e9);             /* call 0x100763a0 */
            ii(0x1007_4eb7, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_4eb9, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x1007_4ebc, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1007_4ec0, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1007_4ec2, 2); if(jnzd(0x1007_4ec6, 0x2)) goto l_0x1007_4ec6; /* jnz 0x10074ec6 */
        l_0x1007_4ec4:
            ii(0x1007_4ec4, 2); jmpd(0x1007_4ed4, 0xe); goto l_0x1007_4ed4; /* jmp 0x10074ed4 */
        l_0x1007_4ec6:
            ii(0x1007_4ec6, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_4ec9, 5); calld(0x1007_63a0, 0x14d2);             /* call 0x100763a0 */
            ii(0x1007_4ece, 4); cmp(memb_a32[ds, eax + 0x3d], 0xc);     /* cmp byte [eax+0x3d], 0xc */
            ii(0x1007_4ed2, 2); if(jzd(0x1007_4ed6, 0x2)) goto l_0x1007_4ed6; /* jz 0x10074ed6 */
        l_0x1007_4ed4:
            ii(0x1007_4ed4, 2); jmpd(0x1007_4eed, 0x17); goto l_0x1007_4eed; /* jmp 0x10074eed */
        l_0x1007_4ed6:
            ii(0x1007_4ed6, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_4ed9, 5); calld(0x1007_6408, 0x152a);             /* call 0x10076408 */
            ii(0x1007_4ede, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1007_4ee1, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_4ee3, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_4ee6, 5); calld(0x1007_5f6c, 0x1081);             /* call 0x10075f6c */
            ii(0x1007_4eeb, 2); jmpd(0x1007_4f14, 0x27); goto l_0x1007_4f14; /* jmp 0x10074f14 */
        l_0x1007_4eed:
            ii(0x1007_4eed, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_4ef0, 5); calld(0x1007_6bf8, 0x1d03);             /* call 0x10076bf8 */
            ii(0x1007_4ef5, 2); jmpd(0x1007_4e7f, -0x78); goto l_0x1007_4e7f; /* jmp 0x10074e7f */
        l_0x1007_4ef7:
            ii(0x1007_4ef7, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
            ii(0x1007_4efe, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_4f00, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_4f03, 5); calld(0x1007_5f6c, 0x1064);             /* call 0x10075f6c */
            ii(0x1007_4f08, 2); jmpd(0x1007_4f14, 0xa); goto l_0x1007_4f14; /* jmp 0x10074f14 */
        //  ii(0x1007_4f0a, 10); Недостижимый код.
        l_0x1007_4f14:
            ii(0x1007_4f14, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1007_4f17, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_4f19, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_4f1a, 1); popd(edi);                              /* pop edi */
            ii(0x1007_4f1b, 1); popd(esi);                              /* pop esi */
            ii(0x1007_4f1c, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_4f1d, 1); retd(); return;                         /* ret */
        }
    }
}
