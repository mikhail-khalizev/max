using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_b074-63113d3c")]
        public void Method_100c_b074()
        {
            ii(0x100c_b074, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x100c_b079, 5); calld(Definitions.sys_check_available_stack_size, 0x9_acd4); /* call 0x10165d52 */
            ii(0x100c_b07e, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_b07f, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_b080, 1); pushd(esi);                             /* push esi */
            ii(0x100c_b081, 1); pushd(edi);                             /* push edi */
            ii(0x100c_b082, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_b083, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_b085, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100c_b08b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_b08e, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100c_b091, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100c_b094, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_b097, 5); calld(0x1013_abc3, 0x6_fb27);           /* call 0x1013abc3 */
            ii(0x100c_b09c, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_b09f, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x100c_b0a2, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100c_b0a5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_b0a8, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100c_b0ab, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100c_b0ae, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_b0b0, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_b0b1, 1); popd(edi);                              /* pop edi */
            ii(0x100c_b0b2, 1); popd(esi);                              /* pop esi */
            ii(0x100c_b0b3, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_b0b4, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_b0b5, 1); retd(); return;                         /* ret */
        }
    }
}
