using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_27b8-c451a130")]
        public void Method_1015_27b8()
        {
            ii(0x1015_27b8, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1015_27bd, 5); calld(Definitions.sys_check_available_stack_size, 0x1_3590); /* call 0x10165d52 */
            ii(0x1015_27c2, 1); pushd(ebx);                             /* push ebx */
            ii(0x1015_27c3, 1); pushd(ecx);                             /* push ecx */
            ii(0x1015_27c4, 1); pushd(esi);                             /* push esi */
            ii(0x1015_27c5, 1); pushd(edi);                             /* push edi */
            ii(0x1015_27c6, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_27c7, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_27c9, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1015_27cf, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1015_27d2, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1015_27d5, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1015_27d8, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_27db, 5); add(eax, 0x94);                         /* add eax, 0x94 */
            ii(0x1015_27e0, 5); calld(0x1009_ca08, -0xb_5ddd);          /* call 0x1009ca08 */
            ii(0x1015_27e5, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_27e7, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_27e8, 1); popd(edi);                              /* pop edi */
            ii(0x1015_27e9, 1); popd(esi);                              /* pop esi */
            ii(0x1015_27ea, 1); popd(ecx);                              /* pop ecx */
            ii(0x1015_27eb, 1); popd(ebx);                              /* pop ebx */
            ii(0x1015_27ec, 1); retd();                                 /* ret */
        }
    }
}
