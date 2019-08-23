using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_8432-6f00a1f8")]
        public void Method_1011_8432()
        {
            ii(0x1011_8432, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1011_8437, 5); calld(Definitions.sys_check_available_stack_size, 0x4_d916); /* call 0x10165d52 */
            ii(0x1011_843c, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_843d, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_843e, 1); pushd(esi);                             /* push esi */
            ii(0x1011_843f, 1); pushd(edi);                             /* push edi */
            ii(0x1011_8440, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_8441, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_8443, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1011_8449, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1011_844c, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1011_844f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_8451, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_8452, 1); popd(edi);                              /* pop edi */
            ii(0x1011_8453, 1); popd(esi);                              /* pop esi */
            ii(0x1011_8454, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_8455, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_8456, 1); retd();                                 /* ret */
        }
    }
}
