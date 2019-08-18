using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("e9ae9a57-78e4-4cc4-8099-72f0743bea49")]
        public void Method_1009_a051()
        {
            ii(0x1009_a051, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1009_a056, 5); calld(Definitions.sys_check_available_stack_size, 0xc_bcf7); /* call 0x10165d52 */
            ii(0x1009_a05b, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_a05c, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_a05d, 1); pushd(edx);                             /* push edx */
            ii(0x1009_a05e, 1); pushd(esi);                             /* push esi */
            ii(0x1009_a05f, 1); pushd(edi);                             /* push edi */
            ii(0x1009_a060, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_a061, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_a063, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1009_a069, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1009_a06c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_a06f, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1009_a072, 5); calld(0x1009_c3c0, 0x2349);             /* call 0x1009c3c0 */
            ii(0x1009_a077, 5); calld(0x1009_834c, -0x1d30);            /* call 0x1009834c */
            ii(0x1009_a07c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_a07e, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_a07f, 1); popd(edi);                              /* pop edi */
            ii(0x1009_a080, 1); popd(esi);                              /* pop esi */
            ii(0x1009_a081, 1); popd(edx);                              /* pop edx */
            ii(0x1009_a082, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_a083, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_a084, 1); retd(); return;                         /* ret */
        }
    }
}
