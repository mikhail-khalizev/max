using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_5365-174bb30b")]
        public void Method_100e_5365()
        {
            ii(0x100e_5365, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x100e_536a, 5); calld(Definitions.sys_check_available_stack_size, 0x8_09e3); /* call 0x10165d52 */
            ii(0x100e_536f, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_5370, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_5371, 1); pushd(esi);                             /* push esi */
            ii(0x100e_5372, 1); pushd(edi);                             /* push edi */
            ii(0x100e_5373, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_5374, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_5376, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100e_537c, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_537f, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100e_5382, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x100e_5386, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_5389, 5); calld(0x100e_86a4, 0x3316);             /* call 0x100e86a4 */
            ii(0x100e_538e, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_5391, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x100e_5394, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100e_5397, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_539a, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100e_539d, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_53a0, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_53a2, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_53a3, 1); popd(edi);                              /* pop edi */
            ii(0x100e_53a4, 1); popd(esi);                              /* pop esi */
            ii(0x100e_53a5, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_53a6, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_53a7, 1); retd();                                 /* ret */
        }
    }
}
