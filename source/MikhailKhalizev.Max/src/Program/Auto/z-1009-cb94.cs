using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("d71c9d44-39cd-4939-8a89-5bed83bb91e7")]
        public void Method_1009_cb94()
        {
            ii(0x1009_cb94, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1009_cb99, 5); calld(Definitions.sys_check_available_stack_size, 0xc_91b4); /* call 0x10165d52 */
            ii(0x1009_cb9e, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_cb9f, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_cba0, 1); pushd(edx);                             /* push edx */
            ii(0x1009_cba1, 1); pushd(esi);                             /* push esi */
            ii(0x1009_cba2, 1); pushd(edi);                             /* push edi */
            ii(0x1009_cba3, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_cba4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_cba6, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1009_cbac, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1009_cbaf, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_cbb2, 6); mov(memw_a32[ds, eax + 0x2], 0);        /* mov word [eax+0x2], 0x0 */
            ii(0x1009_cbb8, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_cbba, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_cbbb, 1); popd(edi);                              /* pop edi */
            ii(0x1009_cbbc, 1); popd(esi);                              /* pop esi */
            ii(0x1009_cbbd, 1); popd(edx);                              /* pop edx */
            ii(0x1009_cbbe, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_cbbf, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_cbc0, 1); retd(); return;                         /* ret */
        }
    }
}
