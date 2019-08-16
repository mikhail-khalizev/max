using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("da83c64a-cd81-487f-9829-e8fb0d55ad8c")]
        public void Method_1014_56f2()
        {
            ii(0x1014_56f2, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1014_56f7, 5); calld(Definitions.sys_check_available_stack_size, 0x2_0656); /* call 0x10165d52 */
            ii(0x1014_56fc, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_56fd, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_56fe, 1); pushd(esi);                             /* push esi */
            ii(0x1014_56ff, 1); pushd(edi);                             /* push edi */
            ii(0x1014_5700, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_5701, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_5703, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1014_5709, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_570c, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1014_570f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_5712, 5); calld(0x1014_7cb0, 0x2599);             /* call 0x10147cb0 */
            ii(0x1014_5717, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1014_571a, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_571d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_571f, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_5720, 1); popd(edi);                              /* pop edi */
            ii(0x1014_5721, 1); popd(esi);                              /* pop esi */
            ii(0x1014_5722, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_5723, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_5724, 1); retd(); return;                         /* ret */
        }
    }
}