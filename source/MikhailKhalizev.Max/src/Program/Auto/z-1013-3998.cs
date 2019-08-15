using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("7308b248-8208-4715-bd52-2c20af990e36")]
        public void Method_1013_3998()
        {
            ii(0x1013_3998, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1013_399d, 5); calld(Definitions.sys_check_available_stack_size, 0x3_23b0); /* call 0x10165d52 */
            ii(0x1013_39a2, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_39a3, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_39a4, 1); pushd(edx);                             /* push edx */
            ii(0x1013_39a5, 1); pushd(esi);                             /* push esi */
            ii(0x1013_39a6, 1); pushd(edi);                             /* push edi */
            ii(0x1013_39a7, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_39a8, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_39aa, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1013_39b0, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1013_39b3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_39b6, 4); mov(ax, memw_a32[ds, eax + 0x5]);       /* mov ax, [eax+0x5] */
            ii(0x1013_39ba, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_39bd, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_39c0, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_39c2, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_39c3, 1); popd(edi);                              /* pop edi */
            ii(0x1013_39c4, 1); popd(esi);                              /* pop esi */
            ii(0x1013_39c5, 1); popd(edx);                              /* pop edx */
            ii(0x1013_39c6, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_39c7, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_39c8, 1); retd(); return;                         /* ret */
        }
    }
}
