using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_64f8-cd37a1d7")]
        public void Method_1010_64f8()
        {
            ii(0x1010_64f8, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1010_64fd, 5); calld(Definitions.sys_check_available_stack_size, 0x5_f850); /* call 0x10165d52 */
            ii(0x1010_6502, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_6503, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_6504, 1); pushd(edx);                             /* push edx */
            ii(0x1010_6505, 1); pushd(esi);                             /* push esi */
            ii(0x1010_6506, 1); pushd(edi);                             /* push edi */
            ii(0x1010_6507, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_6508, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_650a, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1010_6510, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1010_6513, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_6516, 10); mov(memd_a32[ds, eax + 0x84], 0);      /* mov dword [eax+0x84], 0x0 */
            ii(0x1010_6520, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_6523, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1010_6526, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_6529, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_652b, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_652c, 1); popd(edi);                              /* pop edi */
            ii(0x1010_652d, 1); popd(esi);                              /* pop esi */
            ii(0x1010_652e, 1); popd(edx);                              /* pop edx */
            ii(0x1010_652f, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_6530, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_6531, 1); retd();                                 /* ret */
        }
    }
}
