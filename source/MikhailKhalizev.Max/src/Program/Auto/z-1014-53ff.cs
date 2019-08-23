using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_53ff-65928ff6")]
        public void Method_1014_53ff()
        {
            ii(0x1014_53ff, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1014_5404, 5); calld(Definitions.sys_check_available_stack_size, 0x2_0949); /* call 0x10165d52 */
            ii(0x1014_5409, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_540a, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_540b, 1); pushd(edx);                             /* push edx */
            ii(0x1014_540c, 1); pushd(esi);                             /* push esi */
            ii(0x1014_540d, 1); pushd(edi);                             /* push edi */
            ii(0x1014_540e, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_540f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_5411, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1014_5417, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1014_541a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_541d, 3); mov(eax, memd_a32[ds, eax + 0x14]);     /* mov eax, [eax+0x14] */
            ii(0x1014_5420, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_5423, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_5426, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_5428, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_5429, 1); popd(edi);                              /* pop edi */
            ii(0x1014_542a, 1); popd(esi);                              /* pop esi */
            ii(0x1014_542b, 1); popd(edx);                              /* pop edx */
            ii(0x1014_542c, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_542d, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_542e, 1); retd();                                 /* ret */
        }
    }
}
