using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("9c6f88ba-73e4-46c8-ac8b-892f319cb8ab")]
        public void Method_100a_ac40()
        {
            ii(0x100a_ac40, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x100a_ac45, 5); calld(Definitions.sys_check_available_stack_size, 0xb_b108); /* call 0x10165d52 */
            ii(0x100a_ac4a, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_ac4b, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_ac4c, 1); pushd(edx);                             /* push edx */
            ii(0x100a_ac4d, 1); pushd(esi);                             /* push esi */
            ii(0x100a_ac4e, 1); pushd(edi);                             /* push edi */
            ii(0x100a_ac4f, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_ac50, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_ac52, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100a_ac58, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100a_ac5b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_ac5e, 5); calld(0x1007_6d58, -0x3_3f0b);          /* call 0x10076d58 */
            ii(0x100a_ac63, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100a_ac66, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x100a_ac69, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_ac6c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_ac6f, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_ac72, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_ac75, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_ac77, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_ac78, 1); popd(edi);                              /* pop edi */
            ii(0x100a_ac79, 1); popd(esi);                              /* pop esi */
            ii(0x100a_ac7a, 1); popd(edx);                              /* pop edx */
            ii(0x100a_ac7b, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_ac7c, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_ac7d, 1); retd(); return;                         /* ret */
        }
    }
}
