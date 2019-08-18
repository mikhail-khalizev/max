using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("544ff3fe-3be0-41fd-8232-cc7d80de305a")]
        public void Method_100c_bf40()
        {
            ii(0x100c_bf40, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100c_bf45, 5); calld(Definitions.sys_check_available_stack_size, 0x9_9e08); /* call 0x10165d52 */
            ii(0x100c_bf4a, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_bf4b, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_bf4c, 1); pushd(edx);                             /* push edx */
            ii(0x100c_bf4d, 1); pushd(esi);                             /* push esi */
            ii(0x100c_bf4e, 1); pushd(edi);                             /* push edi */
            ii(0x100c_bf4f, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_bf50, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_bf52, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100c_bf58, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100c_bf5b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_bf5e, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_bf61, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_bf64, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x100c_bf67, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_bf6a, 3); calld_abs(memd_a32[ds, edx + 0x3c]);    /* call dword [edx+0x3c] */
            ii(0x100c_bf6d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_bf6f, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_bf70, 1); popd(edi);                              /* pop edi */
            ii(0x100c_bf71, 1); popd(esi);                              /* pop esi */
            ii(0x100c_bf72, 1); popd(edx);                              /* pop edx */
            ii(0x100c_bf73, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_bf74, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_bf75, 1); retd(); return;                         /* ret */
        }
    }
}
