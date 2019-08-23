using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_09c8-2718019e")]
        public void Method_1012_09c8()
        {
            ii(0x1012_09c8, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1012_09cd, 5); calld(Definitions.sys_check_available_stack_size, 0x4_5380); /* call 0x10165d52 */
            ii(0x1012_09d2, 1); pushd(ebx);                             /* push ebx */
            ii(0x1012_09d3, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_09d4, 1); pushd(edx);                             /* push edx */
            ii(0x1012_09d5, 1); pushd(esi);                             /* push esi */
            ii(0x1012_09d6, 1); pushd(edi);                             /* push edi */
            ii(0x1012_09d7, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_09d8, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_09da, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1012_09e0, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1012_09e3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_09e6, 4); mov(ax, memw_a32[ds, eax + 0xf]);       /* mov ax, [eax+0xf] */
            ii(0x1012_09ea, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1012_09ed, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_09f0, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_09f2, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_09f3, 1); popd(edi);                              /* pop edi */
            ii(0x1012_09f4, 1); popd(esi);                              /* pop esi */
            ii(0x1012_09f5, 1); popd(edx);                              /* pop edx */
            ii(0x1012_09f6, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_09f7, 1); popd(ebx);                              /* pop ebx */
            ii(0x1012_09f8, 1); retd();                                 /* ret */
        }
    }
}
