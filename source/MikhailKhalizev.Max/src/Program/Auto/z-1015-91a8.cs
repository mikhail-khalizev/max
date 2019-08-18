using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a8537dfb-fc90-455c-9581-f3f7898e54b7")]
        public void Method_1015_91a8()
        {
            ii(0x1015_91a8, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1015_91ad, 5); calld(Definitions.sys_check_available_stack_size, 0xcba0); /* call 0x10165d52 */
            ii(0x1015_91b2, 1); pushd(ebx);                             /* push ebx */
            ii(0x1015_91b3, 1); pushd(ecx);                             /* push ecx */
            ii(0x1015_91b4, 1); pushd(esi);                             /* push esi */
            ii(0x1015_91b5, 1); pushd(edi);                             /* push edi */
            ii(0x1015_91b6, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_91b7, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_91b9, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1015_91bf, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1015_91c2, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1015_91c5, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1015_91c8, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_91cb, 5); calld(0x1015_8bbb, -0x615);             /* call 0x10158bbb */
            ii(0x1015_91d0, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_91d2, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_91d3, 1); popd(edi);                              /* pop edi */
            ii(0x1015_91d4, 1); popd(esi);                              /* pop esi */
            ii(0x1015_91d5, 1); popd(ecx);                              /* pop ecx */
            ii(0x1015_91d6, 1); popd(ebx);                              /* pop ebx */
            ii(0x1015_91d7, 1); retd(); return;                         /* ret */
        }
    }
}
