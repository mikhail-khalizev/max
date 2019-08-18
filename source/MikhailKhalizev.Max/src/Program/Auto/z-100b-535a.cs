using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("e5ea7cc4-7346-482c-ad00-96e4bf04af53")]
        public void Method_100b_535a()
        {
            ii(0x100b_535a, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100b_535f, 5); calld(Definitions.sys_check_available_stack_size, 0xb_09ee); /* call 0x10165d52 */
            ii(0x100b_5364, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_5365, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_5366, 1); pushd(esi);                             /* push esi */
            ii(0x100b_5367, 1); pushd(edi);                             /* push edi */
            ii(0x100b_5368, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_5369, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_536b, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100b_5371, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_5374, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100b_5377, 5); mov(edx, StringDefinitions.MoveBackToComplex); /* mov edx, 0x101a1122 */
            ii(0x100b_537c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_537f, 5); calld(Definitions.sys_strcpy, 0xb_0b4b); /* call 0x10165ecf */
            ii(0x100b_5384, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_5387, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100b_538a, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_538d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_538f, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_5390, 1); popd(edi);                              /* pop edi */
            ii(0x100b_5391, 1); popd(esi);                              /* pop esi */
            ii(0x100b_5392, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_5393, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_5394, 1); retd(); return;                         /* ret */
        }
    }
}
