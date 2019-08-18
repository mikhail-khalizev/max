using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_470c-57145570")]
        public void Method_1016_470c()
        {
            ii(0x1016_470c, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1016_4711, 5); calld(Definitions.sys_check_available_stack_size, 0x163c); /* call 0x10165d52 */
            ii(0x1016_4716, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_4717, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_4718, 1); pushd(edx);                             /* push edx */
            ii(0x1016_4719, 1); pushd(esi);                             /* push esi */
            ii(0x1016_471a, 1); pushd(edi);                             /* push edi */
            ii(0x1016_471b, 1); pushd(ebp);                             /* push ebp */
            ii(0x1016_471c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1016_471e, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1016_4724, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1016_4727, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_472a, 3); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x1016_472d, 5); calld(Definitions.my_ctor_0x101b_4184, -0xe_dc42); /* call 0x10076af0 */
            ii(0x1016_4732, 3); sub(eax, 0x4);                          /* sub eax, 0x4 */
            ii(0x1016_4735, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1016_4738, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_473b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1016_473e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1016_4741, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1016_4743, 1); popd(ebp);                              /* pop ebp */
            ii(0x1016_4744, 1); popd(edi);                              /* pop edi */
            ii(0x1016_4745, 1); popd(esi);                              /* pop esi */
            ii(0x1016_4746, 1); popd(edx);                              /* pop edx */
            ii(0x1016_4747, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_4748, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_4749, 1); retd(); return;                         /* ret */
        }
    }
}
