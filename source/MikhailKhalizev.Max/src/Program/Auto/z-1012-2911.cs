using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("9556d584-65b3-42de-8343-89abaf181fe6")]
        public void Method_1012_2911()
        {
            ii(0x1012_2911, 5); pushd(0x8c);                            /* push 0x8c */
            ii(0x1012_2916, 5); calld(Definitions.sys_check_available_stack_size, 0x43437); /* call 0x10165d52 */
            ii(0x1012_291b, 1); pushd(ebx);                             /* push ebx */
            ii(0x1012_291c, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_291d, 1); pushd(edx);                             /* push edx */
            ii(0x1012_291e, 1); pushd(esi);                             /* push esi */
            ii(0x1012_291f, 1); pushd(edi);                             /* push edi */
            ii(0x1012_2920, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_2921, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_2923, 6); sub(esp, 0x60);                         /* sub esp, 0x60 */
            ii(0x1012_2929, 4); or(memb_a32[ss, ebp - 0x4], 0x1);       /* or byte [ebp-0x4], 0x1 */
            ii(0x1012_292d, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1012_2930, 5); calld(Definitions.my_string_ctor, 0x1f1b3); /* call 0x10141ae8 */
            ii(0x1012_2935, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1012_2938, 4); and(memb_a32[ss, ebp - 0x4], -0x2 /* 0xfe */); /* and byte [ebp-0x4], 0xfe */
            ii(0x1012_293c, 5); calld(0x1010_6bb0, -0x1bd91);           /* call 0x10106bb0 */
            ii(0x1012_2941, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1012_2943, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1012_2945, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1012_2948, 3); shl(edx, 0x14);                         /* shl edx, 0x14 */
            ii(0x1012_294b, 2); sbb(eax, edx);                          /* sbb eax, edx */
            ii(0x1012_294d, 3); sar(eax, 0x14);                         /* sar eax, 0x14 */
            ii(0x1012_2950, 1); pushd(eax);                             /* push eax */
            ii(0x1012_2951, 5); mov(eax, StringDefinitions.WarningYouHaveOnlyImbXmsEnablingEnhancedGraphicsWillLikelyResultInTheGameCrashing); /* mov eax, 0x101a7ea8 */
            ii(0x1012_2956, 1); pushd(eax);                             /* push eax */
            ii(0x1012_2957, 5); mov(eax, 0x12c);                        /* mov eax, 0x12c */
            ii(0x1012_295c, 1); pushd(eax);                             /* push eax */
            ii(0x1012_295d, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1012_2960, 1); pushd(eax);                             /* push eax */
            ii(0x1012_2961, 5); calld(0x1014_2037, 0x1f6d1);            /* call 0x10142037 */
            ii(0x1012_2966, 3); add(esp, 0x10);                         /* add esp, 0x10 */
            ii(0x1012_2969, 4); or(memb_a32[ss, ebp - 0x4], 0x1);       /* or byte [ebp-0x4], 0x1 */
            ii(0x1012_296d, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1012_296f, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1012_2972, 5); calld(Definitions.my_strobj_c_str_v2, -0x991af); /* call 0x100897c8 */
            ii(0x1012_2977, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1012_2979, 3); lea(eax, ebp - 0x60);                   /* lea eax, [ebp-0x60] */
            ii(0x1012_297c, 5); calld(0x1011_61a2, -0xc7df);            /* call 0x101161a2 */
            ii(0x1012_2981, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1012_2984, 4); and(memb_a32[ss, ebp - 0x4], -0x2 /* 0xfe */); /* and byte [ebp-0x4], 0xfe */
            ii(0x1012_2988, 3); lea(eax, ebp - 0x60);                   /* lea eax, [ebp-0x60] */
            ii(0x1012_298b, 5); calld(0x1011_6a19, -0xbf77);            /* call 0x10116a19 */
            ii(0x1012_2990, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_2992, 3); lea(eax, ebp - 0x60);                   /* lea eax, [ebp-0x60] */
            ii(0x1012_2995, 5); calld(0x1011_6536, -0xc464);            /* call 0x10116536 */
            ii(0x1012_299a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_299c, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1012_299f, 5); calld(Definitions.my_string_dtor, 0x1f186); /* call 0x10141b2a */
            ii(0x1012_29a4, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_29a6, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_29a7, 1); popd(edi);                              /* pop edi */
            ii(0x1012_29a8, 1); popd(esi);                              /* pop esi */
            ii(0x1012_29a9, 1); popd(edx);                              /* pop edx */
            ii(0x1012_29aa, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_29ab, 1); popd(ebx);                              /* pop ebx */
            ii(0x1012_29ac, 1); retd(); return;                         /* ret */
        }
    }
}
