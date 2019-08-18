using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_0838-83e4afce")]
        public void Method_100e_0838()
        {
            ii(0x100e_0838, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x100e_083d, 5); calld(Definitions.sys_check_available_stack_size, 0x8_5510); /* call 0x10165d52 */
            ii(0x100e_0842, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_0843, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_0844, 1); pushd(edx);                             /* push edx */
            ii(0x100e_0845, 1); pushd(esi);                             /* push esi */
            ii(0x100e_0846, 1); pushd(edi);                             /* push edi */
            ii(0x100e_0847, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_0848, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_084a, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100e_0850, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100e_0853, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_0856, 5); calld(Definitions.my_ctor_0x101b_6edc, -0x6_9a17); /* call 0x10076e44 */
            ii(0x100e_085b, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100e_085e, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x100e_0861, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_0864, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_0867, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100e_086a, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_086d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_086f, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_0870, 1); popd(edi);                              /* pop edi */
            ii(0x100e_0871, 1); popd(esi);                              /* pop esi */
            ii(0x100e_0872, 1); popd(edx);                              /* pop edx */
            ii(0x100e_0873, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_0874, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_0875, 1); retd(); return;                         /* ret */
        }
    }
}
