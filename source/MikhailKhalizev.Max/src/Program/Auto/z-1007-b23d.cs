using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_b23d-fd178c0d")]
        public void Method_1007_b23d()
        {
            ii(0x1007_b23d, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1007_b242, 5); calld(Definitions.sys_check_available_stack_size, 0xe_ab0b); /* call 0x10165d52 */
            ii(0x1007_b247, 1); pushd(ebx);                             /* push ebx */
            ii(0x1007_b248, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_b249, 1); pushd(edx);                             /* push edx */
            ii(0x1007_b24a, 1); pushd(esi);                             /* push esi */
            ii(0x1007_b24b, 1); pushd(edi);                             /* push edi */
            ii(0x1007_b24c, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_b24d, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_b24f, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1007_b255, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1007_b258, 4); mov(memb_a32[ss, ebp - 0x8], 0x14);     /* mov byte [ebp-0x8], 0x14 */
            ii(0x1007_b25c, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x1007_b25f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_b261, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_b262, 1); popd(edi);                              /* pop edi */
            ii(0x1007_b263, 1); popd(esi);                              /* pop esi */
            ii(0x1007_b264, 1); popd(edx);                              /* pop edx */
            ii(0x1007_b265, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_b266, 1); popd(ebx);                              /* pop ebx */
            ii(0x1007_b267, 1); retd();                                 /* ret */
        }
    }
}
