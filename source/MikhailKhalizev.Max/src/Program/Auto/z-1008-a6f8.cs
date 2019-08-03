using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("5ad75526-659b-4e2d-b469-17aa95e380ba")]
        public void Method_1008_a6f8()
        {
            ii(0x1008_a6f8, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1008_a6fd, 5); calld(Definitions.sys_check_available_stack_size, 0xdb650); /* call 0x10165d52 */
            ii(0x1008_a702, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_a703, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_a704, 1); pushd(edx);                             /* push edx */
            ii(0x1008_a705, 1); pushd(esi);                             /* push esi */
            ii(0x1008_a706, 1); pushd(edi);                             /* push edi */
            ii(0x1008_a707, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_a708, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_a70a, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1008_a710, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1008_a713, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_a716, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1008_a718, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_a71b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_a71e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_a720, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_a721, 1); popd(edi);                              /* pop edi */
            ii(0x1008_a722, 1); popd(esi);                              /* pop esi */
            ii(0x1008_a723, 1); popd(edx);                              /* pop edx */
            ii(0x1008_a724, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_a725, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_a726, 1); retd(); return;                         /* ret */
        }
    }
}
