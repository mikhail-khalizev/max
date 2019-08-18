using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("adda1665-6aec-4753-b448-321790a2c485")]
        public void Method_100e_3938()
        {
            ii(0x100e_3938, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100e_393d, 5); calld(Definitions.sys_check_available_stack_size, 0x8_2410); /* call 0x10165d52 */
            ii(0x100e_3942, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_3943, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_3944, 1); pushd(esi);                             /* push esi */
            ii(0x100e_3945, 1); pushd(edi);                             /* push edi */
            ii(0x100e_3946, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_3947, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_3949, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100e_394f, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_3952, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100e_3955, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_3958, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100e_395b, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_395e, 5); calld(0x100e_3b27, 0x1c4);              /* call 0x100e3b27 */
            ii(0x100e_3963, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100e_3968, 5); calld(0x1007_65d0, -0x6_d39d);          /* call 0x100765d0 */
            ii(0x100e_396d, 5); calld(0x100f_fa70, 0x1_c0fe);           /* call 0x100ffa70 */
            ii(0x100e_3972, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_3974, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_3975, 1); popd(edi);                              /* pop edi */
            ii(0x100e_3976, 1); popd(esi);                              /* pop esi */
            ii(0x100e_3977, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_3978, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_3979, 1); retd(); return;                         /* ret */
        }
    }
}
