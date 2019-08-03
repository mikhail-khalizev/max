using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("212ca8f2-4554-46d6-90ab-132b33db8b60")]
        public void Method_1014_1698()
        {
            ii(0x1014_1698, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1014_169d, 5); calld(Definitions.sys_check_available_stack_size, 0x246b0); /* call 0x10165d52 */
            ii(0x1014_16a2, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_16a3, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_16a4, 1); pushd(edx);                             /* push edx */
            ii(0x1014_16a5, 1); pushd(esi);                             /* push esi */
            ii(0x1014_16a6, 1); pushd(edi);                             /* push edi */
            ii(0x1014_16a7, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_16a8, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_16aa, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1014_16b0, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1014_16b3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_16b6, 5); calld(0x1007_623c, -0xcb47f);           /* call 0x1007623c */
            ii(0x1014_16bb, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_16be, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_16c1, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_16c3, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_16c4, 1); popd(edi);                              /* pop edi */
            ii(0x1014_16c5, 1); popd(esi);                              /* pop esi */
            ii(0x1014_16c6, 1); popd(edx);                              /* pop edx */
            ii(0x1014_16c7, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_16c8, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_16c9, 1); retd(); return;                         /* ret */
        }
    }
}
