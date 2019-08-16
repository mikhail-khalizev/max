using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("9b959e09-c2be-4e19-859b-e80b6a643c49")]
        public void Method_100b_1a6c()
        {
            ii(0x100b_1a6c, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100b_1a71, 5); calld(Definitions.sys_check_available_stack_size, 0xb_42dc); /* call 0x10165d52 */
            ii(0x100b_1a76, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_1a77, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_1a78, 1); pushd(edx);                             /* push edx */
            ii(0x100b_1a79, 1); pushd(esi);                             /* push esi */
            ii(0x100b_1a7a, 1); pushd(edi);                             /* push edi */
            ii(0x100b_1a7b, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_1a7c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_1a7e, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100b_1a84, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100b_1a87, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_1a8a, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_1a8d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_1a90, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x100b_1a93, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_1a96, 3); calld_abs(memd_a32[ds, edx + 0x3c]);    /* call dword [edx+0x3c] */
            ii(0x100b_1a99, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_1a9b, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_1a9c, 1); popd(edi);                              /* pop edi */
            ii(0x100b_1a9d, 1); popd(esi);                              /* pop esi */
            ii(0x100b_1a9e, 1); popd(edx);                              /* pop edx */
            ii(0x100b_1a9f, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_1aa0, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_1aa1, 1); retd(); return;                         /* ret */
        }
    }
}