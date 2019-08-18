using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("cdd70916-1528-44d6-8e90-baf6c366beae")]
        public void Method_1012_06d4()
        {
            ii(0x1012_06d4, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1012_06d9, 5); calld(Definitions.sys_check_available_stack_size, 0x4_5674); /* call 0x10165d52 */
            ii(0x1012_06de, 1); pushd(ebx);                             /* push ebx */
            ii(0x1012_06df, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_06e0, 1); pushd(edx);                             /* push edx */
            ii(0x1012_06e1, 1); pushd(esi);                             /* push esi */
            ii(0x1012_06e2, 1); pushd(edi);                             /* push edi */
            ii(0x1012_06e3, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_06e4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_06e6, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1012_06ec, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1012_06ef, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_06f2, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1012_06f4, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1012_06f7, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_06fa, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_06fc, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_06fd, 1); popd(edi);                              /* pop edi */
            ii(0x1012_06fe, 1); popd(esi);                              /* pop esi */
            ii(0x1012_06ff, 1); popd(edx);                              /* pop edx */
            ii(0x1012_0700, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_0701, 1); popd(ebx);                              /* pop ebx */
            ii(0x1012_0702, 1); retd(); return;                         /* ret */
        }
    }
}
