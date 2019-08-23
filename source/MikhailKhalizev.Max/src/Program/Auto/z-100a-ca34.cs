using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_ca34-a221107c")]
        public void Method_100a_ca34()
        {
            ii(0x100a_ca34, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100a_ca39, 5); calld(Definitions.sys_check_available_stack_size, 0xb_9314); /* call 0x10165d52 */
            ii(0x100a_ca3e, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_ca3f, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_ca40, 1); pushd(esi);                             /* push esi */
            ii(0x100a_ca41, 1); pushd(edi);                             /* push edi */
            ii(0x100a_ca42, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_ca43, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_ca45, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100a_ca4b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_ca4e, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100a_ca51, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100a_ca54, 3); add(edx, 0x1e);                         /* add edx, 0x1e */
            ii(0x100a_ca57, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_ca5a, 5); calld(0x1007_5e64, -0x3_6bfb);          /* call 0x10075e64 */
            ii(0x100a_ca5f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_ca62, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_ca64, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_ca65, 1); popd(edi);                              /* pop edi */
            ii(0x100a_ca66, 1); popd(esi);                              /* pop esi */
            ii(0x100a_ca67, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_ca68, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_ca69, 1); retd();                                 /* ret */
        }
    }
}
