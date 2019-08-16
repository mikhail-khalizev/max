using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("f4de32b8-f8be-4838-baa7-6f05aaaae3e7")]
        public void Method_1009_c4c4()
        {
            ii(0x1009_c4c4, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1009_c4c9, 5); calld(Definitions.sys_check_available_stack_size, 0xc_9884); /* call 0x10165d52 */
            ii(0x1009_c4ce, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_c4cf, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_c4d0, 1); pushd(edx);                             /* push edx */
            ii(0x1009_c4d1, 1); pushd(esi);                             /* push esi */
            ii(0x1009_c4d2, 1); pushd(edi);                             /* push edi */
            ii(0x1009_c4d3, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_c4d4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_c4d6, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1009_c4dc, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1009_c4df, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_c4e2, 4); mov(ax, memw_a32[ds, eax + 0x13]);      /* mov ax, [eax+0x13] */
            ii(0x1009_c4e6, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_c4e9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_c4ec, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_c4ee, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_c4ef, 1); popd(edi);                              /* pop edi */
            ii(0x1009_c4f0, 1); popd(esi);                              /* pop esi */
            ii(0x1009_c4f1, 1); popd(edx);                              /* pop edx */
            ii(0x1009_c4f2, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_c4f3, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_c4f4, 1); retd(); return;                         /* ret */
        }
    }
}