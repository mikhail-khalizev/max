using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("e87312bb-d72a-489b-bc91-7bf003ba917f")]
        public void Method_1016_4ad4()
        {
            ii(0x1016_4ad4, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1016_4ad9, 5); calld(Definitions.sys_check_available_stack_size, 0x1274); /* call 0x10165d52 */
            ii(0x1016_4ade, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_4adf, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_4ae0, 1); pushd(esi);                             /* push esi */
            ii(0x1016_4ae1, 1); pushd(edi);                             /* push edi */
            ii(0x1016_4ae2, 1); pushd(ebp);                             /* push ebp */
            ii(0x1016_4ae3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1016_4ae5, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1016_4aeb, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1016_4aee, 3); mov(memb_a32[ss, ebp - 0x4], dl);       /* mov [ebp-0x4], dl */
            ii(0x1016_4af1, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x1016_4af4, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1016_4af7, 6); mov(memb_a32[ds, edx + 0xa6], al);      /* mov [edx+0xa6], al */
            ii(0x1016_4afd, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1016_4aff, 1); popd(ebp);                              /* pop ebp */
            ii(0x1016_4b00, 1); popd(edi);                              /* pop edi */
            ii(0x1016_4b01, 1); popd(esi);                              /* pop esi */
            ii(0x1016_4b02, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_4b03, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_4b04, 1); retd(); return;                         /* ret */
        }
    }
}
