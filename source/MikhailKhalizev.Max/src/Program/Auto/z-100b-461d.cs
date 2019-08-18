using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_461d-e73f9864")]
        public void Method_100b_461d()
        {
            ii(0x100b_461d, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100b_4622, 5); calld(Definitions.sys_check_available_stack_size, 0xb_172b); /* call 0x10165d52 */
            ii(0x100b_4627, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_4628, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_4629, 1); pushd(edx);                             /* push edx */
            ii(0x100b_462a, 1); pushd(esi);                             /* push esi */
            ii(0x100b_462b, 1); pushd(edi);                             /* push edi */
            ii(0x100b_462c, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_462d, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_462f, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100b_4635, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100b_4638, 4); mov(memb_a32[ss, ebp - 0x8], 0x24);     /* mov byte [ebp-0x8], 0x24 */
            ii(0x100b_463c, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x100b_463f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_4641, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_4642, 1); popd(edi);                              /* pop edi */
            ii(0x100b_4643, 1); popd(esi);                              /* pop esi */
            ii(0x100b_4644, 1); popd(edx);                              /* pop edx */
            ii(0x100b_4645, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_4646, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_4647, 1); retd(); return;                         /* ret */
        }
    }
}
