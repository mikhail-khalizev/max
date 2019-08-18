using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_c930-b03964be")]
        public void Method_1009_c930()
        {
            ii(0x1009_c930, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1009_c935, 5); calld(Definitions.sys_check_available_stack_size, 0xc_9418); /* call 0x10165d52 */
            ii(0x1009_c93a, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_c93b, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_c93c, 1); pushd(edx);                             /* push edx */
            ii(0x1009_c93d, 1); pushd(esi);                             /* push esi */
            ii(0x1009_c93e, 1); pushd(edi);                             /* push edi */
            ii(0x1009_c93f, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_c940, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_c942, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1009_c948, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1009_c94b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_c94e, 5); calld(Definitions.my_ctor_0x101b_6edc, -0x2_5b0f); /* call 0x10076e44 */
            ii(0x1009_c953, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1009_c956, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x1009_c959, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_c95c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_c95f, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1009_c962, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_c965, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_c967, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_c968, 1); popd(edi);                              /* pop edi */
            ii(0x1009_c969, 1); popd(esi);                              /* pop esi */
            ii(0x1009_c96a, 1); popd(edx);                              /* pop edx */
            ii(0x1009_c96b, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_c96c, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_c96d, 1); retd(); return;                         /* ret */
        }
    }
}
