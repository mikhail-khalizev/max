using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_1a86-86760b5e")]
        public void Method_100f_1a86()
        {
            ii(0x100f_1a86, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100f_1a8b, 5); calld(Definitions.sys_check_available_stack_size, 0x7_42c2); /* call 0x10165d52 */
            ii(0x100f_1a90, 1); pushd(ebx);                             /* push ebx */
            ii(0x100f_1a91, 1); pushd(ecx);                             /* push ecx */
            ii(0x100f_1a92, 1); pushd(edx);                             /* push edx */
            ii(0x100f_1a93, 1); pushd(esi);                             /* push esi */
            ii(0x100f_1a94, 1); pushd(edi);                             /* push edi */
            ii(0x100f_1a95, 1); pushd(ebp);                             /* push ebp */
            ii(0x100f_1a96, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_1a98, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100f_1a9e, 3); mov(memb_a32[ss, ebp - 0x4], al);       /* mov [ebp-0x4], al */
            ii(0x100f_1aa1, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_1aa3, 3); mov(dl, memb_a32[ss, ebp - 0x4]);       /* mov dl, [ebp-0x4] */
            ii(0x100f_1aa6, 5); mov(eax, 0x101c_3990);                  /* mov eax, 0x101c3990 */
            ii(0x100f_1aab, 5); calld(0x100f_14b4, -0x5fc);             /* call 0x100f14b4 */
            ii(0x100f_1ab0, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_1ab2, 1); popd(ebp);                              /* pop ebp */
            ii(0x100f_1ab3, 1); popd(edi);                              /* pop edi */
            ii(0x100f_1ab4, 1); popd(esi);                              /* pop esi */
            ii(0x100f_1ab5, 1); popd(edx);                              /* pop edx */
            ii(0x100f_1ab6, 1); popd(ecx);                              /* pop ecx */
            ii(0x100f_1ab7, 1); popd(ebx);                              /* pop ebx */
            ii(0x100f_1ab8, 1); retd(); return;                         /* ret */
        }
    }
}
