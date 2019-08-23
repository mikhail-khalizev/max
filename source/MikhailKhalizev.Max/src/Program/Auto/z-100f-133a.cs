using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_133a-fafdf055")]
        public void Method_100f_133a()
        {
            ii(0x100f_133a, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100f_133f, 5); calld(Definitions.sys_check_available_stack_size, 0x7_4a0e); /* call 0x10165d52 */
            ii(0x100f_1344, 1); pushd(ebx);                             /* push ebx */
            ii(0x100f_1345, 1); pushd(ecx);                             /* push ecx */
            ii(0x100f_1346, 1); pushd(esi);                             /* push esi */
            ii(0x100f_1347, 1); pushd(edi);                             /* push edi */
            ii(0x100f_1348, 1); pushd(ebp);                             /* push ebp */
            ii(0x100f_1349, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_134b, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100f_1351, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100f_1354, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100f_1357, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100f_135a, 5); calld(0x100f_140e, 0xaf);               /* call 0x100f140e */
            ii(0x100f_135f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100f_1362, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100f_1365, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100f_1368, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_136a, 1); popd(ebp);                              /* pop ebp */
            ii(0x100f_136b, 1); popd(edi);                              /* pop edi */
            ii(0x100f_136c, 1); popd(esi);                              /* pop esi */
            ii(0x100f_136d, 1); popd(ecx);                              /* pop ecx */
            ii(0x100f_136e, 1); popd(ebx);                              /* pop ebx */
            ii(0x100f_136f, 1); retd();                                 /* ret */
        }
    }
}
