using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_3940-9f771a04")]
        public void Method_100b_3940()
        {
            ii(0x100b_3940, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100b_3945, 5); calld(Definitions.sys_check_available_stack_size, 0xb_2408); /* call 0x10165d52 */
            ii(0x100b_394a, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_394b, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_394c, 1); pushd(edx);                             /* push edx */
            ii(0x100b_394d, 1); pushd(esi);                             /* push esi */
            ii(0x100b_394e, 1); pushd(edi);                             /* push edi */
            ii(0x100b_394f, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_3950, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_3952, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100b_3958, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100b_395b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_395d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_3960, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_3963, 5); calld(0x1013_ad71, 0x8_7409);           /* call 0x1013ad71 */
            ii(0x100b_3968, 2); test(al, al);                           /* test al, al */
            ii(0x100b_396a, 2); if(jzd(0x100b_3988, 0x1c)) goto l_0x100b_3988; /* jz 0x100b3988 */
            ii(0x100b_396c, 5); calld(0x1008_ac50, -0x2_8d21);          /* call 0x1008ac50 */
            ii(0x100b_3971, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100b_3973, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100b_3975, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100b_3978, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_397b, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_397e, 5); calld(0x1007_6574, -0x3_d40f);          /* call 0x10076574 */
            ii(0x100b_3983, 5); calld(0x1015_2962, 0x9_efda);           /* call 0x10152962 */
        l_0x100b_3988:
            ii(0x100b_3988, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_398a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_398d, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_3990, 5); calld(0x1007_6630, -0x3_d365);          /* call 0x10076630 */
            ii(0x100b_3995, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_3997, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_399a, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100b_399d, 5); calld(0x1007_6630, -0x3_d372);          /* call 0x10076630 */
            ii(0x100b_39a2, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_39a4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_39a7, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x100b_39aa, 5); calld(0x1008_afe4, -0x2_89cb);          /* call 0x1008afe4 */
            ii(0x100b_39af, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_39b1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_39b4, 3); add(eax, 0x1b);                         /* add eax, 0x1b */
            ii(0x100b_39b7, 5); calld(0x1009_c8f8, -0x1_70c4);          /* call 0x1009c8f8 */
            ii(0x100b_39bc, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100b_39bf, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100b_39c4, 5); calld(0x100a_5e27, -0xdba2);            /* call 0x100a5e27 */
            ii(0x100b_39c9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_39cb, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_39cc, 1); popd(edi);                              /* pop edi */
            ii(0x100b_39cd, 1); popd(esi);                              /* pop esi */
            ii(0x100b_39ce, 1); popd(edx);                              /* pop edx */
            ii(0x100b_39cf, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_39d0, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_39d1, 1); retd();                                 /* ret */
        }
    }
}
