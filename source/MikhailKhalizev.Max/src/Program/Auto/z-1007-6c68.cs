using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("b48ffcde-50b5-4458-9047-5f63f28e0a1f")]
        public void Method_1007_6c68()
        {
            ii(0x1007_6c68, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1007_6c6d, 5); calld(Definitions.sys_check_available_stack_size, 0xef0e0); /* call 0x10165d52 */
            ii(0x1007_6c72, 1); pushd(ebx);                             /* push ebx */
            ii(0x1007_6c73, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_6c74, 1); pushd(edx);                             /* push edx */
            ii(0x1007_6c75, 1); pushd(esi);                             /* push esi */
            ii(0x1007_6c76, 1); pushd(edi);                             /* push edi */
            ii(0x1007_6c77, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_6c78, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_6c7a, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1007_6c80, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1007_6c83, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_6c86, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1007_6c88, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1007_6c8b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_6c8e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_6c90, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_6c91, 1); popd(edi);                              /* pop edi */
            ii(0x1007_6c92, 1); popd(esi);                              /* pop esi */
            ii(0x1007_6c93, 1); popd(edx);                              /* pop edx */
            ii(0x1007_6c94, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_6c95, 1); popd(ebx);                              /* pop ebx */
            ii(0x1007_6c96, 1); retd(); return;                         /* ret */
        }
    }
}
