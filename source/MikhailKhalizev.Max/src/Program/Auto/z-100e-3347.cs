using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_3347-9fe37db3")]
        public void Method_100e_3347()
        {
            ii(0x100e_3347, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100e_334c, 5); calld(Definitions.sys_check_available_stack_size, 0x8_2a01); /* call 0x10165d52 */
            ii(0x100e_3351, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_3352, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_3353, 1); pushd(esi);                             /* push esi */
            ii(0x100e_3354, 1); pushd(edi);                             /* push edi */
            ii(0x100e_3355, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_3356, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_3358, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100e_335e, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_3361, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100e_3364, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100e_3367, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_336a, 5); calld(0x100e_2f92, -0x3dd);             /* call 0x100e2f92 */
            ii(0x100e_336f, 2); test(al, al);                           /* test al, al */
            ii(0x100e_3371, 2); if(jzd(0x100e_33c4, 0x51)) goto l_0x100e_33c4; /* jz 0x100e33c4 */
            ii(0x100e_3373, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100e_3376, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_3379, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x100e_337c, 5); calld(0x1007_6574, -0x6_ce0d);          /* call 0x10076574 */
            ii(0x100e_3381, 5); calld(0x1008_a998, -0x5_89ee);          /* call 0x1008a998 */
            ii(0x100e_3386, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100e_3388, 5); mov(edx, 0x11);                         /* mov edx, 0x11 */
            ii(0x100e_338d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_3390, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x100e_3393, 5); calld(0x1007_65d0, -0x6_cdc8);          /* call 0x100765d0 */
            ii(0x100e_3398, 5); calld(0x1016_3053, 0x7_fcb6);           /* call 0x10163053 */
            ii(0x100e_339d, 7); cmp(memd_a32[ds, 0x101c_5624], 0);      /* cmp dword [0x101c5624], 0x0 */
            ii(0x100e_33a4, 2); if(jnzd(0x100e_33ad, 0x7)) goto l_0x100e_33ad; /* jnz 0x100e33ad */
            ii(0x100e_33a6, 5); calld(0x1016_2cb8, 0x7_f90d);           /* call 0x10162cb8 */
            ii(0x100e_33ab, 2); jmpd(0x100e_33c4, 0x17); goto l_0x100e_33c4; /* jmp 0x100e33c4 */
        l_0x100e_33ad:
            ii(0x100e_33ad, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100e_33af, 5); mov(edx, 0x11);                         /* mov edx, 0x11 */
            ii(0x100e_33b4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_33b7, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x100e_33ba, 5); calld(0x1007_65d0, -0x6_cdef);          /* call 0x100765d0 */
            ii(0x100e_33bf, 5); calld(0x100e_0e24, -0x25a0);            /* call 0x100e0e24 */
        l_0x100e_33c4:
            ii(0x100e_33c4, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_33c6, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_33c7, 1); popd(edi);                              /* pop edi */
            ii(0x100e_33c8, 1); popd(esi);                              /* pop esi */
            ii(0x100e_33c9, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_33ca, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_33cb, 1); retd();                                 /* ret */
        }
    }
}
