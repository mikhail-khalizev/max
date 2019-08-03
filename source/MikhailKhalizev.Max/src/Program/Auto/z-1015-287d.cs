using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("cd2190d6-5aec-48a9-b91e-7052c4757a59")]
        public void Method_1015_287d()
        {
            ii(0x1015_287d, 5); pushd(0x3c);                            /* push 0x3c */
            ii(0x1015_2882, 5); calld(Definitions.sys_check_available_stack_size, 0x134cb); /* call 0x10165d52 */
            ii(0x1015_2887, 1); pushd(ebx);                             /* push ebx */
            ii(0x1015_2888, 1); pushd(ecx);                             /* push ecx */
            ii(0x1015_2889, 1); pushd(edx);                             /* push edx */
            ii(0x1015_288a, 1); pushd(esi);                             /* push esi */
            ii(0x1015_288b, 1); pushd(edi);                             /* push edi */
            ii(0x1015_288c, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_288d, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_288f, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x1015_2895, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1015_2898, 4); or(memb_a32[ss, ebp - 0x8], 0x1);       /* or byte [ebp-0x8], 0x1 */
            ii(0x1015_289c, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1015_289f, 5); calld(0x1009_ca70, -0xb5e34);           /* call 0x1009ca70 */
            ii(0x1015_28a4, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1015_28a7, 4); and(memb_a32[ss, ebp - 0x8], -0x2 /* 0xfe */); /* and byte [ebp-0x8], 0xfe */
            ii(0x1015_28ab, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_28ae, 5); add(eax, 0x8a);                         /* add eax, 0x8a */
            ii(0x1015_28b3, 5); calld(0x1008_aef4, -0xc79c4);           /* call 0x1008aef4 */
            ii(0x1015_28b8, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_28ba, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1015_28bd, 5); calld(0x1008_ae70, -0xc7a52);           /* call 0x1008ae70 */
            ii(0x1015_28c2, 2); jmpd(0x1015_28cc, 0x8); goto l_0x1015_28cc; /* jmp 0x101528cc */
        l_0x1015_28c4:
            ii(0x1015_28c4, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1015_28c7, 5); calld(0x1007_6bf8, -0xdbcd4);           /* call 0x10076bf8 */
        l_0x1015_28cc:
            ii(0x1015_28cc, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_28ce, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1015_28d1, 5); calld(0x1013_ad71, -0x17b65);           /* call 0x1013ad71 */
            ii(0x1015_28d6, 2); test(al, al);                           /* test al, al */
            ii(0x1015_28d8, 2); if(jzd(0x1015_28f0, 0x16)) goto l_0x1015_28f0; /* jz 0x101528f0 */
            ii(0x1015_28da, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1015_28dd, 5); calld(0x1008_adf8, -0xc7aea);           /* call 0x1008adf8 */
            ii(0x1015_28e2, 3); lea(ebx, ebp - 0x1c);                   /* lea ebx, [ebp-0x1c] */
            ii(0x1015_28e5, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_28e7, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1015_28e9, 5); calld(0x1009_ca40, -0xb5eae);           /* call 0x1009ca40 */
            ii(0x1015_28ee, 2); jmpd(0x1015_28c4, -0x2c); goto l_0x1015_28c4; /* jmp 0x101528c4 */
        l_0x1015_28f0:
            ii(0x1015_28f0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_28f3, 5); add(eax, 0x8a);                         /* add eax, 0x8a */
            ii(0x1015_28f8, 5); calld(0x1013_a6f4, -0x18209);           /* call 0x1013a6f4 */
            ii(0x1015_28fd, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1015_2900, 5); calld(0x1008_aef4, -0xc7a11);           /* call 0x1008aef4 */
            ii(0x1015_2905, 3); lea(ebx, ebp - 0xc);                    /* lea ebx, [ebp-0xc] */
            ii(0x1015_2908, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_290a, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1015_290c, 5); calld(0x100a_b1f8, -0xa7719);           /* call 0x100ab1f8 */
            ii(0x1015_2911, 2); jmpd(0x1015_291b, 0x8); goto l_0x1015_291b; /* jmp 0x1015291b */
        l_0x1015_2913:
            ii(0x1015_2913, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1015_2916, 5); calld(0x1007_6bf8, -0xdbd23);           /* call 0x10076bf8 */
        l_0x1015_291b:
            ii(0x1015_291b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_291d, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1015_2920, 5); calld(0x1013_ad71, -0x17bb4);           /* call 0x1013ad71 */
            ii(0x1015_2925, 2); test(al, al);                           /* test al, al */
            ii(0x1015_2927, 2); if(jzd(0x1015_2945, 0x1c)) goto l_0x1015_2945; /* jz 0x10152945 */
            ii(0x1015_2929, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1015_292c, 5); calld(0x1008_adc4, -0xc7b6d);           /* call 0x1008adc4 */
            ii(0x1015_2931, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1015_2934, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1015_2937, 3); mov(ebx, memd_a32[ds, eax + 0x2]);      /* mov ebx, [eax+0x2] */
            ii(0x1015_293a, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1015_293d, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1015_2940, 3); calld_abs(memd_a32[ds, ebx + 0x54]);    /* call dword [ebx+0x54] */
            ii(0x1015_2943, 2); jmpd(0x1015_2913, -0x32); goto l_0x1015_2913; /* jmp 0x10152913 */
        l_0x1015_2945:
            ii(0x1015_2945, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_2947, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1015_294a, 5); calld(0x1008_8bbc, -0xc9d93);           /* call 0x10088bbc */
            ii(0x1015_294f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_2951, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1015_2954, 5); calld(0x1009_b834, -0xb7125);           /* call 0x1009b834 */
            ii(0x1015_2959, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_295b, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_295c, 1); popd(edi);                              /* pop edi */
            ii(0x1015_295d, 1); popd(esi);                              /* pop esi */
            ii(0x1015_295e, 1); popd(edx);                              /* pop edx */
            ii(0x1015_295f, 1); popd(ecx);                              /* pop ecx */
            ii(0x1015_2960, 1); popd(ebx);                              /* pop ebx */
            ii(0x1015_2961, 1); retd(); return;                         /* ret */
        }
    }
}
