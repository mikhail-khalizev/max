using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("4221ff4b-af9d-460e-92cb-c769d30b224f")]
        public void Method_1007_3c18()
        {
            ii(0x1007_3c18, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1007_3c1d, 5); calld(Definitions.sys_check_available_stack_size, 0xf2130); /* call 0x10165d52 */
            ii(0x1007_3c22, 1); pushd(ebx);                             /* push ebx */
            ii(0x1007_3c23, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_3c24, 1); pushd(esi);                             /* push esi */
            ii(0x1007_3c25, 1); pushd(edi);                             /* push edi */
            ii(0x1007_3c26, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_3c27, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_3c29, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1007_3c2f, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1007_3c32, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1007_3c35, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1007_3c39, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_3c3b, 2); if(jld(0x1007_3c49, 0xc)) goto l_0x1007_3c49; /* jl 0x10073c49 */
            ii(0x1007_3c3d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_3c40, 7); cmp(ax, memw_a32[ds, 0x101c_8172]);     /* cmp ax, [0x101c8172] */
            ii(0x1007_3c47, 2); if(jld(0x1007_3c4b, 0x2)) goto l_0x1007_3c4b; /* jl 0x10073c4b */
        l_0x1007_3c49:
            ii(0x1007_3c49, 2); jmpd(0x1007_3c53, 0x8); goto l_0x1007_3c53; /* jmp 0x10073c53 */
        l_0x1007_3c4b:
            ii(0x1007_3c4b, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1007_3c4f, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_3c51, 2); if(jged(0x1007_3c55, 0x2)) goto l_0x1007_3c55; /* jge 0x10073c55 */
        l_0x1007_3c53:
            ii(0x1007_3c53, 2); jmpd(0x1007_3c61, 0xc); goto l_0x1007_3c61; /* jmp 0x10073c61 */
        l_0x1007_3c55:
            ii(0x1007_3c55, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_3c58, 7); cmp(ax, memw_a32[ds, 0x101c_8174]);     /* cmp ax, [0x101c8174] */
            ii(0x1007_3c5f, 2); if(jld(0x1007_3c6d, 0xc)) goto l_0x1007_3c6d; /* jl 0x10073c6d */
        l_0x1007_3c61:
            ii(0x1007_3c61, 7); mov(memd_a32[ss, ebp - 0xc], 0);        /* mov dword [ebp-0xc], 0x0 */
            ii(0x1007_3c68, 5); jmpd(0x1007_3cf2, 0x85); goto l_0x1007_3cf2; /* jmp 0x10073cf2 */
        l_0x1007_3c6d:
            ii(0x1007_3c6d, 4); movsx(ebx, memw_a32[ss, ebp - 0x4]);    /* movsx ebx, word [ebp-0x4] */
            ii(0x1007_3c71, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1007_3c75, 5); mov(eax, 0x101c_39b8);                  /* mov eax, 0x101c39b8 */
            ii(0x1007_3c7a, 5); calld(0x1010_3541, 0x8f8c2);            /* call 0x10103541 */
            ii(0x1007_3c7f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_3c81, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1007_3c84, 5); calld(0x1007_64b8, 0x282f);             /* call 0x100764b8 */
        l_0x1007_3c89:
            ii(0x1007_3c89, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_3c8b, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1007_3c8e, 5); calld(0x1013_ad71, 0xc70de);            /* call 0x1013ad71 */
            ii(0x1007_3c93, 2); test(al, al);                           /* test al, al */
            ii(0x1007_3c95, 2); if(jzd(0x1007_3cd5, 0x3e)) goto l_0x1007_3cd5; /* jz 0x10073cd5 */
            ii(0x1007_3c97, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1007_3c9a, 5); calld(0x1007_63a0, 0x2701);             /* call 0x100763a0 */
            ii(0x1007_3c9f, 4); test(memb_a32[ds, eax + 0x12], 0x1);    /* test byte [eax+0x12], 0x1 */
            ii(0x1007_3ca3, 2); if(jnzd(0x1007_3cb4, 0xf)) goto l_0x1007_3cb4; /* jnz 0x10073cb4 */
            ii(0x1007_3ca5, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1007_3ca8, 5); calld(0x1007_63a0, 0x26f3);             /* call 0x100763a0 */
            ii(0x1007_3cad, 5); cmp(memw_a32[ds, eax + 0x8], 0x5b);     /* cmp word [eax+0x8], 0x5b */
            ii(0x1007_3cb2, 2); if(jnzd(0x1007_3ccb, 0x17)) goto l_0x1007_3ccb; /* jnz 0x10073ccb */
        l_0x1007_3cb4:
            ii(0x1007_3cb4, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1007_3cb7, 5); calld(0x1007_6408, 0x274c);             /* call 0x10076408 */
            ii(0x1007_3cbc, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1007_3cbf, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_3cc1, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1007_3cc4, 5); calld(0x1007_5f6c, 0x22a3);             /* call 0x10075f6c */
            ii(0x1007_3cc9, 2); jmpd(0x1007_3cf2, 0x27); goto l_0x1007_3cf2; /* jmp 0x10073cf2 */
        l_0x1007_3ccb:
            ii(0x1007_3ccb, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1007_3cce, 5); calld(0x1007_6bf8, 0x2f25);             /* call 0x10076bf8 */
            ii(0x1007_3cd3, 2); jmpd(0x1007_3c89, -0x4c); goto l_0x1007_3c89; /* jmp 0x10073c89 */
        l_0x1007_3cd5:
            ii(0x1007_3cd5, 7); mov(memd_a32[ss, ebp - 0xc], 0);        /* mov dword [ebp-0xc], 0x0 */
            ii(0x1007_3cdc, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_3cde, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1007_3ce1, 5); calld(0x1007_5f6c, 0x2286);             /* call 0x10075f6c */
            ii(0x1007_3ce6, 2); jmpd(0x1007_3cf2, 0xa); goto l_0x1007_3cf2; /* jmp 0x10073cf2 */
        //  ii(0x1007_3ce8, 10); Недостижимый код.
l_0x1007_3cf2:
            ii(0x1007_3cf2, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_3cf5, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_3cf7, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_3cf8, 1); popd(edi);                              /* pop edi */
            ii(0x1007_3cf9, 1); popd(esi);                              /* pop esi */
            ii(0x1007_3cfa, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_3cfb, 1); popd(ebx);                              /* pop ebx */
            ii(0x1007_3cfc, 1); retd(); return;                         /* ret */
        }
    }
}