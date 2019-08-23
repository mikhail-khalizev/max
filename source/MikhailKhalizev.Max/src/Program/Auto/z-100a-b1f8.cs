using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_b1f8-eac309dc")]
        public void Method_100a_b1f8()
        {
            ii(0x100a_b1f8, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100a_b1fd, 5); calld(Definitions.sys_check_available_stack_size, 0xb_ab50); /* call 0x10165d52 */
            ii(0x100a_b202, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_b203, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_b204, 1); pushd(esi);                             /* push esi */
            ii(0x100a_b205, 1); pushd(edi);                             /* push edi */
            ii(0x100a_b206, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_b207, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_b209, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100a_b20f, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_b212, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100a_b215, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100a_b218, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_b21b, 5); calld(0x1007_6c98, -0x3_4588);          /* call 0x10076c98 */
            ii(0x100a_b220, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_b223, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_b226, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_b228, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_b229, 1); popd(edi);                              /* pop edi */
            ii(0x100a_b22a, 1); popd(esi);                              /* pop esi */
            ii(0x100a_b22b, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_b22c, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_b22d, 1); retd();                                 /* ret */
        }
    }
}
