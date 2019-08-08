using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("6c7eb4bd-0194-480c-a1e9-1e4af0453992")]
        public void Method_100a_3711()
        {
            ii(0x100a_3711, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x100a_3716, 5); calld(Definitions.sys_check_available_stack_size, 0xc_2637); /* call 0x10165d52 */
            ii(0x100a_371b, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_371c, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_371d, 1); pushd(esi);                             /* push esi */
            ii(0x100a_371e, 1); pushd(edi);                             /* push edi */
            ii(0x100a_371f, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_3720, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_3722, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x100a_3728, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_372b, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100a_372e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_3731, 5); calld(0x100a_a0b0, 0x697a);             /* call 0x100aa0b0 */
            ii(0x100a_3736, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_3739, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x100a_373c, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100a_373f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_3742, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x100a_3745, 5); calld(Definitions.my_ctor_0x101b3b58, -0x1_86a6); /* call 0x1008b0a4 */
            ii(0x100a_374a, 3); sub(eax, 0x6);                          /* sub eax, 0x6 */
            ii(0x100a_374d, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_3750, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x100a_3753, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_3756, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_3759, 7); mov(memd_a32[ds, eax + 0x2], 0x101b_4f34); /* mov dword [eax+0x2], 0x101b4f34 */
            ii(0x100a_3760, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100a_3763, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_3766, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x100a_3769, 5); calld(0x1008_afe4, -0x1_878a);          /* call 0x1008afe4 */
            ii(0x100a_376e, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100a_3773, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_3776, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x100a_3779, 5); calld(0x1008_af28, -0x1_8856);          /* call 0x1008af28 */
            ii(0x100a_377e, 5); calld(0x100a_b198, 0x7a15);             /* call 0x100ab198 */
            ii(0x100a_3783, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_3786, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100a_3789, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100a_378c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_378e, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_378f, 1); popd(edi);                              /* pop edi */
            ii(0x100a_3790, 1); popd(esi);                              /* pop esi */
            ii(0x100a_3791, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_3792, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_3793, 1); retd(); return;                         /* ret */
        }
    }
}
