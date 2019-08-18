using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("69483188-f81d-4a83-ae9c-885dd0a5cdc8")]
        public void Method_1014_7fc0()
        {
            ii(0x1014_7fc0, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1014_7fc5, 5); calld(Definitions.sys_check_available_stack_size, 0x1_dd88); /* call 0x10165d52 */
            ii(0x1014_7fca, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_7fcb, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_7fcc, 1); pushd(edx);                             /* push edx */
            ii(0x1014_7fcd, 1); pushd(esi);                             /* push esi */
            ii(0x1014_7fce, 1); pushd(edi);                             /* push edi */
            ii(0x1014_7fcf, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_7fd0, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_7fd2, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1014_7fd8, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1014_7fdb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_7fde, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1014_7fe0, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_7fe3, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_7fe6, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_7fe8, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_7fe9, 1); popd(edi);                              /* pop edi */
            ii(0x1014_7fea, 1); popd(esi);                              /* pop esi */
            ii(0x1014_7feb, 1); popd(edx);                              /* pop edx */
            ii(0x1014_7fec, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_7fed, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_7fee, 1); retd(); return;                         /* ret */
        }
    }
}
