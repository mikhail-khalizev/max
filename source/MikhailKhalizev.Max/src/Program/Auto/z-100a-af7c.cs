using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("f5ea3eb2-8fe4-4a2e-be75-30417c985bd3")]
        public void Method_100a_af7c()
        {
            ii(0x100a_af7c, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x100a_af81, 5); calld(Definitions.sys_check_available_stack_size, 0xb_adcc); /* call 0x10165d52 */
            ii(0x100a_af86, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_af87, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_af88, 1); pushd(esi);                             /* push esi */
            ii(0x100a_af89, 1); pushd(edi);                             /* push edi */
            ii(0x100a_af8a, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_af8b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_af8d, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100a_af93, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_af96, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100a_af99, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100a_af9c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_af9f, 5); calld(0x1007_6cd0, -0x3_42d4);          /* call 0x10076cd0 */
            ii(0x100a_afa4, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_afa7, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x100a_afaa, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_afad, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_afb0, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100a_afb3, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100a_afb6, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_afb8, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_afb9, 1); popd(edi);                              /* pop edi */
            ii(0x100a_afba, 1); popd(esi);                              /* pop esi */
            ii(0x100a_afbb, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_afbc, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_afbd, 1); retd(); return;                         /* ret */
        }
    }
}
