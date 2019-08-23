using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_7c6c-8b73d9f6")]
        public void Method_1011_7c6c()
        {
            ii(0x1011_7c6c, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1011_7c71, 5); calld(Definitions.sys_check_available_stack_size, 0x4_e0dc); /* call 0x10165d52 */
            ii(0x1011_7c76, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_7c77, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_7c78, 1); pushd(edx);                             /* push edx */
            ii(0x1011_7c79, 1); pushd(esi);                             /* push esi */
            ii(0x1011_7c7a, 1); pushd(edi);                             /* push edi */
            ii(0x1011_7c7b, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_7c7c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_7c7e, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1011_7c84, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1011_7c87, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_7c8a, 5); calld(0x1007_6b58, -0xa_1137);          /* call 0x10076b58 */
            ii(0x1011_7c8f, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1011_7c92, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_7c95, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_7c97, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_7c98, 1); popd(edi);                              /* pop edi */
            ii(0x1011_7c99, 1); popd(esi);                              /* pop esi */
            ii(0x1011_7c9a, 1); popd(edx);                              /* pop edx */
            ii(0x1011_7c9b, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_7c9c, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_7c9d, 1); retd();                                 /* ret */
        }
    }
}
