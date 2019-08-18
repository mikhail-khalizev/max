using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("3016b5af-0f16-43db-a43a-f9ce3aee5c37")]
        public void Method_100c_8a10()
        {
            ii(0x100c_8a10, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100c_8a15, 5); calld(Definitions.sys_check_available_stack_size, 0x9_d338); /* call 0x10165d52 */
            ii(0x100c_8a1a, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_8a1b, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_8a1c, 1); pushd(edx);                             /* push edx */
            ii(0x100c_8a1d, 1); pushd(esi);                             /* push esi */
            ii(0x100c_8a1e, 1); pushd(edi);                             /* push edi */
            ii(0x100c_8a1f, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_8a20, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_8a22, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100c_8a28, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100c_8a2b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_8a2e, 7); mov(memd_a32[ds, eax + 0x6], 0);        /* mov dword [eax+0x6], 0x0 */
            ii(0x100c_8a35, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_8a38, 7); mov(memd_a32[ds, eax + 0x2], 0);        /* mov dword [eax+0x2], 0x0 */
            ii(0x100c_8a3f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_8a42, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_8a45, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_8a48, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_8a4a, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_8a4b, 1); popd(edi);                              /* pop edi */
            ii(0x100c_8a4c, 1); popd(esi);                              /* pop esi */
            ii(0x100c_8a4d, 1); popd(edx);                              /* pop edx */
            ii(0x100c_8a4e, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_8a4f, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_8a50, 1); retd(); return;                         /* ret */
        }
    }
}
