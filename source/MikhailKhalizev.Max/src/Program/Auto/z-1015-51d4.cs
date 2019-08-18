using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("d735a6b3-4ce8-4cb3-bd4b-ad1bdbb98c04")]
        public void Method_1015_51d4()
        {
            ii(0x1015_51d4, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1015_51d9, 5); calld(Definitions.sys_check_available_stack_size, 0x1_0b74); /* call 0x10165d52 */
            ii(0x1015_51de, 1); pushd(ebx);                             /* push ebx */
            ii(0x1015_51df, 1); pushd(ecx);                             /* push ecx */
            ii(0x1015_51e0, 1); pushd(esi);                             /* push esi */
            ii(0x1015_51e1, 1); pushd(edi);                             /* push edi */
            ii(0x1015_51e2, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_51e3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_51e5, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1015_51eb, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1015_51ee, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1015_51f1, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1015_51f4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_51f7, 5); calld(0x1013_a369, -0x1_ae93);          /* call 0x1013a369 */
            ii(0x1015_51fc, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_51fe, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_51ff, 1); popd(edi);                              /* pop edi */
            ii(0x1015_5200, 1); popd(esi);                              /* pop esi */
            ii(0x1015_5201, 1); popd(ecx);                              /* pop ecx */
            ii(0x1015_5202, 1); popd(ebx);                              /* pop ebx */
            ii(0x1015_5203, 1); retd(); return;                         /* ret */
        }
    }
}
