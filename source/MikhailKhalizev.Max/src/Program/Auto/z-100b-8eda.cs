using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_8eda-1bb83862")]
        public void Method_100b_8eda()
        {
            ii(0x100b_8eda, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100b_8edf, 5); calld(Definitions.sys_check_available_stack_size, 0xa_ce6e); /* call 0x10165d52 */
            ii(0x100b_8ee4, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_8ee5, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_8ee6, 1); pushd(edx);                             /* push edx */
            ii(0x100b_8ee7, 1); pushd(esi);                             /* push esi */
            ii(0x100b_8ee8, 1); pushd(edi);                             /* push edi */
            ii(0x100b_8ee9, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_8eea, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_8eec, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100b_8ef2, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100b_8ef5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_8ef8, 5); calld(0x100b_8f63, 0x66);               /* call 0x100b8f63 */
            ii(0x100b_8efd, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_8f00, 4); mov(ax, memw_a32[ds, eax + 0x12]);      /* mov ax, [eax+0x12] */
            ii(0x100b_8f04, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_8f07, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_8f0a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_8f0c, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_8f0d, 1); popd(edi);                              /* pop edi */
            ii(0x100b_8f0e, 1); popd(esi);                              /* pop esi */
            ii(0x100b_8f0f, 1); popd(edx);                              /* pop edx */
            ii(0x100b_8f10, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_8f11, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_8f12, 1); retd();                                 /* ret */
        }
    }
}
