using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_8e98-cc7c1d58")]
        public void Method_1010_8e98()
        {
            ii(0x1010_8e98, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1010_8e9d, 5); calld(Definitions.sys_check_available_stack_size, 0x5_ceb0); /* call 0x10165d52 */
            ii(0x1010_8ea2, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_8ea3, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_8ea4, 1); pushd(edx);                             /* push edx */
            ii(0x1010_8ea5, 1); pushd(esi);                             /* push esi */
            ii(0x1010_8ea6, 1); pushd(edi);                             /* push edi */
            ii(0x1010_8ea7, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_8ea8, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_8eaa, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1010_8eb0, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1010_8eb3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_8eb6, 4); mov(dx, memw_a32[ds, eax + 0xb]);       /* mov dx, [eax+0xb] */
            ii(0x1010_8eba, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_8ebd, 4); mov(memw_a32[ds, eax + 0x9], dx);       /* mov [eax+0x9], dx */
            ii(0x1010_8ec1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_8ec4, 7); mov(memd_a32[ds, eax + 0x4], 0x1);      /* mov dword [eax+0x4], 0x1 */
            ii(0x1010_8ecb, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_8ecd, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_8ece, 1); popd(edi);                              /* pop edi */
            ii(0x1010_8ecf, 1); popd(esi);                              /* pop esi */
            ii(0x1010_8ed0, 1); popd(edx);                              /* pop edx */
            ii(0x1010_8ed1, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_8ed2, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_8ed3, 1); retd(); return;                         /* ret */
        }
    }
}
