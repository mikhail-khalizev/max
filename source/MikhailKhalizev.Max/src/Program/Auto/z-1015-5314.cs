using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("76380aca-8713-45ac-9686-18f269a01418")]
        public void Method_1015_5314()
        {
            ii(0x1015_5314, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1015_5319, 5); calld(Definitions.sys_check_available_stack_size, 0x1_0a34); /* call 0x10165d52 */
            ii(0x1015_531e, 1); pushd(ebx);                             /* push ebx */
            ii(0x1015_531f, 1); pushd(ecx);                             /* push ecx */
            ii(0x1015_5320, 1); pushd(edx);                             /* push edx */
            ii(0x1015_5321, 1); pushd(esi);                             /* push esi */
            ii(0x1015_5322, 1); pushd(edi);                             /* push edi */
            ii(0x1015_5323, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_5324, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_5326, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1015_532c, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1015_532f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_5332, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1015_5334, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1015_5337, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_533a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_533c, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_533d, 1); popd(edi);                              /* pop edi */
            ii(0x1015_533e, 1); popd(esi);                              /* pop esi */
            ii(0x1015_533f, 1); popd(edx);                              /* pop edx */
            ii(0x1015_5340, 1); popd(ecx);                              /* pop ecx */
            ii(0x1015_5341, 1); popd(ebx);                              /* pop ebx */
            ii(0x1015_5342, 1); retd(); return;                         /* ret */
        }
    }
}
