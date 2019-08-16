using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c698e9de-04c4-405a-818b-97449f7e28e6")]
        public void Method_1009_b229()
        {
            ii(0x1009_b229, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1009_b22e, 5); calld(Definitions.sys_check_available_stack_size, 0xc_ab1f); /* call 0x10165d52 */
            ii(0x1009_b233, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_b234, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_b235, 1); pushd(esi);                             /* push esi */
            ii(0x1009_b236, 1); pushd(edi);                             /* push edi */
            ii(0x1009_b237, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_b238, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_b23a, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1009_b240, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_b243, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1009_b246, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1009_b249, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_b24c, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1009_b24f, 5); calld(0x1008_ab1c, -0x1_0738);          /* call 0x1008ab1c */
            ii(0x1009_b254, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1009_b257, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_b25a, 5); calld(0x1015_27ed, 0xb_758e);           /* call 0x101527ed */
            ii(0x1009_b25f, 5); calld(0x1008_b0e4, -0x1_0180);          /* call 0x1008b0e4 */
            ii(0x1009_b264, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_b266, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x1009_b268, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_b26b, 5); calld(0x100a_297d, 0x770d);             /* call 0x100a297d */
            ii(0x1009_b270, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_b272, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_b273, 1); popd(edi);                              /* pop edi */
            ii(0x1009_b274, 1); popd(esi);                              /* pop esi */
            ii(0x1009_b275, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_b276, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_b277, 1); retd(); return;                         /* ret */
        }
    }
}