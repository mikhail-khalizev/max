using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("f21f401e-5c15-41f0-b9b0-5aea1b1dc48f")]
        public void Method_100d_5410()
        {
            ii(0x100d_5410, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100d_5415, 5); calld(Definitions.sys_check_available_stack_size, 0x9_0938); /* call 0x10165d52 */
            ii(0x100d_541a, 1); pushd(ebx);                             /* push ebx */
            ii(0x100d_541b, 1); pushd(ecx);                             /* push ecx */
            ii(0x100d_541c, 1); pushd(esi);                             /* push esi */
            ii(0x100d_541d, 1); pushd(edi);                             /* push edi */
            ii(0x100d_541e, 1); pushd(ebp);                             /* push ebp */
            ii(0x100d_541f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_5421, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100d_5427, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100d_542a, 3); mov(memb_a32[ss, ebp - 0x4], dl);       /* mov [ebp-0x4], dl */
            ii(0x100d_542d, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x100d_5430, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_5433, 3); mov(memb_a32[ds, edx + 0x7a], al);      /* mov [edx+0x7a], al */
            ii(0x100d_5436, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_5438, 1); popd(ebp);                              /* pop ebp */
            ii(0x100d_5439, 1); popd(edi);                              /* pop edi */
            ii(0x100d_543a, 1); popd(esi);                              /* pop esi */
            ii(0x100d_543b, 1); popd(ecx);                              /* pop ecx */
            ii(0x100d_543c, 1); popd(ebx);                              /* pop ebx */
            ii(0x100d_543d, 1); retd(); return;                         /* ret */
        }
    }
}
