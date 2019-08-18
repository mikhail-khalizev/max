using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_5f9d-b8c0ffea")]
        public void Method_100b_5f9d()
        {
            ii(0x100b_5f9d, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100b_5fa2, 5); calld(Definitions.sys_check_available_stack_size, 0xa_fdab); /* call 0x10165d52 */
            ii(0x100b_5fa7, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_5fa8, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_5fa9, 1); pushd(edx);                             /* push edx */
            ii(0x100b_5faa, 1); pushd(esi);                             /* push esi */
            ii(0x100b_5fab, 1); pushd(edi);                             /* push edi */
            ii(0x100b_5fac, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_5fad, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_5faf, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100b_5fb5, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100b_5fb8, 4); mov(memb_a32[ss, ebp - 0x8], 0x1);      /* mov byte [ebp-0x8], 0x1 */
            ii(0x100b_5fbc, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x100b_5fbf, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_5fc1, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_5fc2, 1); popd(edi);                              /* pop edi */
            ii(0x100b_5fc3, 1); popd(esi);                              /* pop esi */
            ii(0x100b_5fc4, 1); popd(edx);                              /* pop edx */
            ii(0x100b_5fc5, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_5fc6, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_5fc7, 1); retd(); return;                         /* ret */
        }
    }
}
