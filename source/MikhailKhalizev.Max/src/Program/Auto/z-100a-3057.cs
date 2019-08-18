using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("fe898d80-c2dd-4ee4-b770-26cfcc63ac6f")]
        public void Method_100a_3057()
        {
            ii(0x100a_3057, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100a_305c, 5); calld(Definitions.sys_check_available_stack_size, 0xc_2cf1); /* call 0x10165d52 */
            ii(0x100a_3061, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_3062, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_3063, 1); pushd(esi);                             /* push esi */
            ii(0x100a_3064, 1); pushd(edi);                             /* push edi */
            ii(0x100a_3065, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_3066, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_3068, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100a_306e, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_3071, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100a_3074, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_3076, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_3077, 1); popd(edi);                              /* pop edi */
            ii(0x100a_3078, 1); popd(esi);                              /* pop esi */
            ii(0x100a_3079, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_307a, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_307b, 1); retd(); return;                         /* ret */
        }
    }
}
