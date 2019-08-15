using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0b711e0d-c682-49a2-8214-938c72270b62")]
        public void Method_1010_2ff9()
        {
            ii(0x1010_2ff9, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1010_2ffe, 5); calld(Definitions.sys_check_available_stack_size, 0x6_2d4f); /* call 0x10165d52 */
            ii(0x1010_3003, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_3004, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_3005, 1); pushd(esi);                             /* push esi */
            ii(0x1010_3006, 1); pushd(edi);                             /* push edi */
            ii(0x1010_3007, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_3008, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_300a, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1010_3010, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1010_3013, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1010_3016, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_3019, 5); calld(0x1007_6338, -0x8_cce6);          /* call 0x10076338 */
            ii(0x1010_301e, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1010_3020, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1010_3023, 5); calld(0x1007_64b8, -0x8_cb70);          /* call 0x100764b8 */
        l_0x1010_3028:
            ii(0x1010_3028, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_302a, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1010_302d, 5); calld(0x1013_ad71, 0x3_7d3f);           /* call 0x1013ad71 */
            ii(0x1010_3032, 2); test(al, al);                           /* test al, al */
            ii(0x1010_3034, 2); if(jzd(0x1010_3057, 0x21)) goto l_0x1010_3057; /* jz 0x10103057 */
            ii(0x1010_3036, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1010_3039, 5); calld(0x1007_6408, -0x8_cc36);          /* call 0x10076408 */
            ii(0x1010_303e, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1010_3040, 5); mov(edx, StringDefinitions.Unit8);      /* mov edx, 0x101a3151 */
            ii(0x1010_3045, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_3048, 5); calld(0x1014_756a, 0x4_451d);           /* call 0x1014756a */
            ii(0x1010_304d, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1010_3050, 5); calld(0x1007_6bf8, -0x8_c45d);          /* call 0x10076bf8 */
            ii(0x1010_3055, 2); jmpd(0x1010_3028, -0x2f); goto l_0x1010_3028; /* jmp 0x10103028 */
        l_0x1010_3057:
            ii(0x1010_3057, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_3059, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1010_305c, 5); calld(0x1007_5f6c, -0x8_d0f5);          /* call 0x10075f6c */
            ii(0x1010_3061, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_3063, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_3064, 1); popd(edi);                              /* pop edi */
            ii(0x1010_3065, 1); popd(esi);                              /* pop esi */
            ii(0x1010_3066, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_3067, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_3068, 1); retd(); return;                         /* ret */
        }
    }
}
