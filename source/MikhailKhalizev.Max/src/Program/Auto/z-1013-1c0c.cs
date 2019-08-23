using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_1c0c-d46fd1de")]
        public void Method_1013_1c0c()
        {
            ii(0x1013_1c0c, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1013_1c11, 5); calld(Definitions.sys_check_available_stack_size, 0x3_413c); /* call 0x10165d52 */
            ii(0x1013_1c16, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_1c17, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_1c18, 1); pushd(edx);                             /* push edx */
            ii(0x1013_1c19, 1); pushd(esi);                             /* push esi */
            ii(0x1013_1c1a, 1); pushd(edi);                             /* push edi */
            ii(0x1013_1c1b, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_1c1c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_1c1e, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1013_1c24, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1013_1c27, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_1c2a, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1013_1c2c, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_1c2f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_1c32, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_1c34, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_1c35, 1); popd(edi);                              /* pop edi */
            ii(0x1013_1c36, 1); popd(esi);                              /* pop esi */
            ii(0x1013_1c37, 1); popd(edx);                              /* pop edx */
            ii(0x1013_1c38, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_1c39, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_1c3a, 1); retd();                                 /* ret */
        }
    }
}
