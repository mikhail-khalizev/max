using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_44e4-ac3410fa")]
        public void Method_1010_44e4()
        {
            ii(0x1010_44e4, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1010_44e9, 5); calld(Definitions.sys_check_available_stack_size, 0x6_1864); /* call 0x10165d52 */
            ii(0x1010_44ee, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_44ef, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_44f0, 1); pushd(edx);                             /* push edx */
            ii(0x1010_44f1, 1); pushd(esi);                             /* push esi */
            ii(0x1010_44f2, 1); pushd(edi);                             /* push edi */
            ii(0x1010_44f3, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_44f4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_44f6, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1010_44fc, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1010_44ff, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_4502, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1010_4504, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1010_4507, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_450a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_450c, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_450d, 1); popd(edi);                              /* pop edi */
            ii(0x1010_450e, 1); popd(esi);                              /* pop esi */
            ii(0x1010_450f, 1); popd(edx);                              /* pop edx */
            ii(0x1010_4510, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_4511, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_4512, 1); retd(); return;                         /* ret */
        }
    }
}
