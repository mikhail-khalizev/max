using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("362e8775-e200-40f2-97a1-812999acc54b")]
        public void Method_1009_c73c()
        {
            ii(0x1009_c73c, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1009_c741, 5); calld(Definitions.sys_check_available_stack_size, 0xc_960c); /* call 0x10165d52 */
            ii(0x1009_c746, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_c747, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_c748, 1); pushd(edx);                             /* push edx */
            ii(0x1009_c749, 1); pushd(esi);                             /* push esi */
            ii(0x1009_c74a, 1); pushd(edi);                             /* push edi */
            ii(0x1009_c74b, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_c74c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_c74e, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1009_c754, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1009_c757, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_c75a, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1009_c75c, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_c75f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_c762, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_c764, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_c765, 1); popd(edi);                              /* pop edi */
            ii(0x1009_c766, 1); popd(esi);                              /* pop esi */
            ii(0x1009_c767, 1); popd(edx);                              /* pop edx */
            ii(0x1009_c768, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_c769, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_c76a, 1); retd(); return;                         /* ret */
        }
    }
}
