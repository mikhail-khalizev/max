using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("7ed91249-9204-470f-9085-2600b1db5cc5")]
        public void Method_1014_8750()
        {
            ii(0x1014_8750, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1014_8755, 5); calld(Definitions.sys_check_available_stack_size, 0x1_d5f8); /* call 0x10165d52 */
            ii(0x1014_875a, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_875b, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_875c, 1); pushd(esi);                             /* push esi */
            ii(0x1014_875d, 1); pushd(edi);                             /* push edi */
            ii(0x1014_875e, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_875f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_8761, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1014_8767, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_876a, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1014_876d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_876f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_8772, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x1014_8775, 5); calld(0x1007_5f2c, -0xd_284e);          /* call 0x10075f2c */
            ii(0x1014_877a, 3); sub(eax, 0x6);                          /* sub eax, 0x6 */
            ii(0x1014_877d, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_8780, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1014_8785, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_8788, 5); calld(0x1013_ab27, -0xdc66);            /* call 0x1013ab27 */
            ii(0x1014_878d, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_8790, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_8793, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1014_8796, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_8799, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_879b, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_879c, 1); popd(edi);                              /* pop edi */
            ii(0x1014_879d, 1); popd(esi);                              /* pop esi */
            ii(0x1014_879e, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_879f, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_87a0, 1); retd(); return;                         /* ret */
        }
    }
}
