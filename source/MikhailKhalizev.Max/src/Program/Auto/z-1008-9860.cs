using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_9860-906726ef")]
        public void Method_1008_9860()
        {
            ii(0x1008_9860, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1008_9865, 5); calld(Definitions.sys_check_available_stack_size, 0xd_c4e8); /* call 0x10165d52 */
            ii(0x1008_986a, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_986b, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_986c, 1); pushd(edx);                             /* push edx */
            ii(0x1008_986d, 1); pushd(esi);                             /* push esi */
            ii(0x1008_986e, 1); pushd(edi);                             /* push edi */
            ii(0x1008_986f, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_9870, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_9872, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1008_9878, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1008_987b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_987e, 4); mov(ax, memw_a32[ds, eax + 0x8]);       /* mov ax, [eax+0x8] */
            ii(0x1008_9882, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_9885, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_9888, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_988a, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_988b, 1); popd(edi);                              /* pop edi */
            ii(0x1008_988c, 1); popd(esi);                              /* pop esi */
            ii(0x1008_988d, 1); popd(edx);                              /* pop edx */
            ii(0x1008_988e, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_988f, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_9890, 1); retd();                                 /* ret */
        }
    }
}
