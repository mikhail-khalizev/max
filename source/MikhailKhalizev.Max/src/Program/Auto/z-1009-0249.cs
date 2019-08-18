using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("ce1bfebe-1a42-460a-8647-9f112f7648fb")]
        public void Method_1009_0249()
        {
            ii(0x1009_0249, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x1009_024e, 5); calld(Definitions.sys_check_available_stack_size, 0xd_5aff); /* call 0x10165d52 */
            ii(0x1009_0253, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_0254, 1); pushd(esi);                             /* push esi */
            ii(0x1009_0255, 1); pushd(edi);                             /* push edi */
            ii(0x1009_0256, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_0257, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_0259, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x1009_025f, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1009_0262, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1009_0265, 3); mov(memb_a32[ss, ebp - 0x4], bl);       /* mov [ebp-0x4], bl */
            ii(0x1009_0268, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_026b, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1009_026e, 4); cmp(memb_a32[ss, ebp - 0x4], 0);        /* cmp byte [ebp-0x4], 0x0 */
            ii(0x1009_0272, 2); if(jnzd(0x1009_0287, 0x13)) goto l_0x1009_0287; /* jnz 0x10090287 */
            ii(0x1009_0274, 5); calld(0x1008_b0e4, -0x5195);            /* call 0x1008b0e4 */
            ii(0x1009_0279, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_027b, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x1009_027d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_0280, 5); calld(0x100a_297d, 0x1_26f8);           /* call 0x100a297d */
            ii(0x1009_0285, 2); jmpd(0x1009_02f1, 0x6a); goto l_0x1009_02f1; /* jmp 0x100902f1 */
        l_0x1009_0287:
            ii(0x1009_0287, 4); cmp(memb_a32[ss, ebp - 0x4], 0x2);      /* cmp byte [ebp-0x4], 0x2 */
            ii(0x1009_028b, 2); if(jnzd(0x1009_02f1, 0x64)) goto l_0x1009_02f1; /* jnz 0x100902f1 */
            ii(0x1009_028d, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_0290, 4); mov(memb_a32[ds, eax + 0x25], 0x6);     /* mov byte [eax+0x25], 0x6 */
            ii(0x1009_0294, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_0297, 3); add(eax, 0x2b);                         /* add eax, 0x2b */
            ii(0x1009_029a, 5); calld(0x1008_aef4, -0x53ab);            /* call 0x1008aef4 */
            ii(0x1009_029f, 3); lea(ebx, ebp - 0x14);                   /* lea ebx, [ebp-0x14] */
            ii(0x1009_02a2, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_02a4, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1009_02a6, 5); calld(0x1008_ae70, -0x543b);            /* call 0x1008ae70 */
            ii(0x1009_02ab, 2); jmpd(0x1009_02b5, 0x8); goto l_0x1009_02b5; /* jmp 0x100902b5 */
        l_0x1009_02ad:
            ii(0x1009_02ad, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1009_02b0, 5); calld(0x1007_6bf8, -0x1_96bd);          /* call 0x10076bf8 */
        l_0x1009_02b5:
            ii(0x1009_02b5, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_02b7, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1009_02ba, 5); calld(0x1013_ad71, 0xa_aab2);           /* call 0x1013ad71 */
            ii(0x1009_02bf, 2); test(al, al);                           /* test al, al */
            ii(0x1009_02c1, 2); if(jzd(0x1009_02dc, 0x19)) goto l_0x1009_02dc; /* jz 0x100902dc */
            ii(0x1009_02c3, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1009_02c6, 5); calld(0x1008_adc4, -0x5507);            /* call 0x1008adc4 */
            ii(0x1009_02cb, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1009_02ce, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1009_02d1, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x1009_02d4, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1009_02d7, 3); calld_abs(memd_a32[ds, edx + 0x48]);    /* call dword [edx+0x48] */
            ii(0x1009_02da, 2); jmpd(0x1009_02ad, -0x2f); goto l_0x1009_02ad; /* jmp 0x100902ad */
        l_0x1009_02dc:
            ii(0x1009_02dc, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_02df, 3); add(eax, 0x2b);                         /* add eax, 0x2b */
            ii(0x1009_02e2, 5); calld(0x1013_a6f4, 0xa_a40d);           /* call 0x1013a6f4 */
            ii(0x1009_02e7, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_02e9, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1009_02ec, 5); calld(0x1008_8bbc, -0x7735);            /* call 0x10088bbc */
        l_0x1009_02f1:
            ii(0x1009_02f1, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_02f3, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_02f4, 1); popd(edi);                              /* pop edi */
            ii(0x1009_02f5, 1); popd(esi);                              /* pop esi */
            ii(0x1009_02f6, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_02f7, 1); retd(); return;                         /* ret */
        }
    }
}
