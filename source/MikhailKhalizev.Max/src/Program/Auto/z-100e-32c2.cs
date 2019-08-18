using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("bf82e96e-01d9-4663-a1a3-9300ed0bd5a4")]
        public void Method_100e_32c2()
        {
            ii(0x100e_32c2, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100e_32c7, 5); calld(Definitions.sys_check_available_stack_size, 0x8_2a86); /* call 0x10165d52 */
            ii(0x100e_32cc, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_32cd, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_32ce, 1); pushd(esi);                             /* push esi */
            ii(0x100e_32cf, 1); pushd(edi);                             /* push edi */
            ii(0x100e_32d0, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_32d1, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_32d3, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100e_32d9, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_32dc, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100e_32df, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100e_32e2, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_32e5, 5); calld(0x100e_2f04, -0x3e6);             /* call 0x100e2f04 */
            ii(0x100e_32ea, 2); test(al, al);                           /* test al, al */
            ii(0x100e_32ec, 2); if(jzd(0x100e_333f, 0x51)) goto l_0x100e_333f; /* jz 0x100e333f */
            ii(0x100e_32ee, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100e_32f1, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_32f4, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x100e_32f7, 5); calld(0x1007_6574, -0x6_cd88);          /* call 0x10076574 */
            ii(0x100e_32fc, 5); calld(0x1008_a998, -0x5_8969);          /* call 0x1008a998 */
            ii(0x100e_3301, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100e_3303, 5); mov(edx, 0x13);                         /* mov edx, 0x13 */
            ii(0x100e_3308, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_330b, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x100e_330e, 5); calld(0x1007_65d0, -0x6_cd43);          /* call 0x100765d0 */
            ii(0x100e_3313, 5); calld(0x1016_3053, 0x7_fd3b);           /* call 0x10163053 */
            ii(0x100e_3318, 7); cmp(memd_a32[ds, 0x101c_5624], 0);      /* cmp dword [0x101c5624], 0x0 */
            ii(0x100e_331f, 2); if(jnzd(0x100e_3328, 0x7)) goto l_0x100e_3328; /* jnz 0x100e3328 */
            ii(0x100e_3321, 5); calld(0x1016_2cb8, 0x7_f992);           /* call 0x10162cb8 */
            ii(0x100e_3326, 2); jmpd(0x100e_333f, 0x17); goto l_0x100e_333f; /* jmp 0x100e333f */
        l_0x100e_3328:
            ii(0x100e_3328, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100e_332a, 5); mov(edx, 0x13);                         /* mov edx, 0x13 */
            ii(0x100e_332f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_3332, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x100e_3335, 5); calld(0x1007_65d0, -0x6_cd6a);          /* call 0x100765d0 */
            ii(0x100e_333a, 5); calld(0x100e_0e24, -0x251b);            /* call 0x100e0e24 */
        l_0x100e_333f:
            ii(0x100e_333f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_3341, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_3342, 1); popd(edi);                              /* pop edi */
            ii(0x100e_3343, 1); popd(esi);                              /* pop esi */
            ii(0x100e_3344, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_3345, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_3346, 1); retd(); return;                         /* ret */
        }
    }
}
