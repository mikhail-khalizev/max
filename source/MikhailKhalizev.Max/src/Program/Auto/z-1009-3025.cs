using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_3025-a9dc76c9")]
        public void Method_1009_3025()
        {
            ii(0x1009_3025, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1009_302a, 5); calld(Definitions.sys_check_available_stack_size, 0xd_2d23); /* call 0x10165d52 */
            ii(0x1009_302f, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_3030, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_3031, 1); pushd(edx);                             /* push edx */
            ii(0x1009_3032, 1); pushd(esi);                             /* push esi */
            ii(0x1009_3033, 1); pushd(edi);                             /* push edi */
            ii(0x1009_3034, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_3035, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_3037, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1009_303d, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1009_3040, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_3043, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1009_3046, 5); calld(0x1013_a794, 0xa_7749);           /* call 0x1013a794 */
            ii(0x1009_304b, 3); lea(edx, eax - 0x6);                    /* lea edx, [eax-0x6] */
            ii(0x1009_304e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_3051, 3); add(eax, 0x21);                         /* add eax, 0x21 */
            ii(0x1009_3054, 5); calld(0x1013_a794, 0xa_773b);           /* call 0x1013a794 */
            ii(0x1009_3059, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1009_305b, 3); sub(eax, 0xa);                          /* sub eax, 0xa */
            ii(0x1009_305e, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_3061, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_3064, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_3066, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_3067, 1); popd(edi);                              /* pop edi */
            ii(0x1009_3068, 1); popd(esi);                              /* pop esi */
            ii(0x1009_3069, 1); popd(edx);                              /* pop edx */
            ii(0x1009_306a, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_306b, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_306c, 1); retd(); return;                         /* ret */
        }
    }
}
