using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("005407b5-9e8b-4afc-8669-1b45f35a4d0b")]
        public void Method_1015_53b0()
        {
            ii(0x1015_53b0, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1015_53b5, 5); calld(Definitions.sys_check_available_stack_size, 0x1_0998); /* call 0x10165d52 */
            ii(0x1015_53ba, 1); pushd(ebx);                             /* push ebx */
            ii(0x1015_53bb, 1); pushd(ecx);                             /* push ecx */
            ii(0x1015_53bc, 1); pushd(edx);                             /* push edx */
            ii(0x1015_53bd, 1); pushd(esi);                             /* push esi */
            ii(0x1015_53be, 1); pushd(edi);                             /* push edi */
            ii(0x1015_53bf, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_53c0, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_53c2, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1015_53c8, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1015_53cb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_53ce, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1015_53d0, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1015_53d3, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_53d6, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_53d8, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_53d9, 1); popd(edi);                              /* pop edi */
            ii(0x1015_53da, 1); popd(esi);                              /* pop esi */
            ii(0x1015_53db, 1); popd(edx);                              /* pop edx */
            ii(0x1015_53dc, 1); popd(ecx);                              /* pop ecx */
            ii(0x1015_53dd, 1); popd(ebx);                              /* pop ebx */
            ii(0x1015_53de, 1); retd(); return;                         /* ret */
        }
    }
}
