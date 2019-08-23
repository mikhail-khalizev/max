using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_5194-82bd95e")]
        public void Method_100d_5194()
        {
            ii(0x100d_5194, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100d_5199, 5); calld(Definitions.sys_check_available_stack_size, 0x9_0bb4); /* call 0x10165d52 */
            ii(0x100d_519e, 1); pushd(ebx);                             /* push ebx */
            ii(0x100d_519f, 1); pushd(ecx);                             /* push ecx */
            ii(0x100d_51a0, 1); pushd(esi);                             /* push esi */
            ii(0x100d_51a1, 1); pushd(edi);                             /* push edi */
            ii(0x100d_51a2, 1); pushd(ebp);                             /* push ebp */
            ii(0x100d_51a3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_51a5, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100d_51ab, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100d_51ae, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100d_51b1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_51b4, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_51b7, 3); mov(memd_a32[ds, edx + 0x24], eax);     /* mov [edx+0x24], eax */
            ii(0x100d_51ba, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_51bc, 1); popd(ebp);                              /* pop ebp */
            ii(0x100d_51bd, 1); popd(edi);                              /* pop edi */
            ii(0x100d_51be, 1); popd(esi);                              /* pop esi */
            ii(0x100d_51bf, 1); popd(ecx);                              /* pop ecx */
            ii(0x100d_51c0, 1); popd(ebx);                              /* pop ebx */
            ii(0x100d_51c1, 1); retd();                                 /* ret */
        }
    }
}
