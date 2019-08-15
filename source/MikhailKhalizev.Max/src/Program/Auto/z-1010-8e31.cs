using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("f5a4fb84-22f6-4680-8061-7a7dcaafc86a")]
        public void Method_1010_8e31()
        {
            ii(0x1010_8e31, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1010_8e36, 5); calld(Definitions.sys_check_available_stack_size, 0x5_cf17); /* call 0x10165d52 */
            ii(0x1010_8e3b, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_8e3c, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_8e3d, 1); pushd(edx);                             /* push edx */
            ii(0x1010_8e3e, 1); pushd(esi);                             /* push esi */
            ii(0x1010_8e3f, 1); pushd(edi);                             /* push edi */
            ii(0x1010_8e40, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_8e41, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_8e43, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1010_8e49, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1010_8e4c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_8e4f, 7); mov(memd_a32[ds, eax + 0x4], 0x1);      /* mov dword [eax+0x4], 0x1 */
            ii(0x1010_8e56, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_8e58, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_8e59, 1); popd(edi);                              /* pop edi */
            ii(0x1010_8e5a, 1); popd(esi);                              /* pop esi */
            ii(0x1010_8e5b, 1); popd(edx);                              /* pop edx */
            ii(0x1010_8e5c, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_8e5d, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_8e5e, 1); retd(); return;                         /* ret */
        }
    }
}
