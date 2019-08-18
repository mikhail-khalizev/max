using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("b8289c93-a347-40ec-a9f6-2407fba5179f")]
        public void Method_1015_53e0()
        {
            ii(0x1015_53e0, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1015_53e5, 5); calld(Definitions.sys_check_available_stack_size, 0x1_0968); /* call 0x10165d52 */
            ii(0x1015_53ea, 1); pushd(ebx);                             /* push ebx */
            ii(0x1015_53eb, 1); pushd(ecx);                             /* push ecx */
            ii(0x1015_53ec, 1); pushd(edx);                             /* push edx */
            ii(0x1015_53ed, 1); pushd(esi);                             /* push esi */
            ii(0x1015_53ee, 1); pushd(edi);                             /* push edi */
            ii(0x1015_53ef, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_53f0, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_53f2, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1015_53f8, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1015_53fb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_53fe, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1015_5400, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1015_5403, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_5406, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_5408, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_5409, 1); popd(edi);                              /* pop edi */
            ii(0x1015_540a, 1); popd(esi);                              /* pop esi */
            ii(0x1015_540b, 1); popd(edx);                              /* pop edx */
            ii(0x1015_540c, 1); popd(ecx);                              /* pop ecx */
            ii(0x1015_540d, 1); popd(ebx);                              /* pop ebx */
            ii(0x1015_540e, 1); retd(); return;                         /* ret */
        }
    }
}
