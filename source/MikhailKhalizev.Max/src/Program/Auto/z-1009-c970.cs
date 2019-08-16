using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("8bcc41d8-e06a-4904-afc4-c6ee982550a2")]
        public void Method_1009_c970()
        {
            ii(0x1009_c970, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1009_c975, 5); calld(Definitions.sys_check_available_stack_size, 0xc_93d8); /* call 0x10165d52 */
            ii(0x1009_c97a, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_c97b, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_c97c, 1); pushd(esi);                             /* push esi */
            ii(0x1009_c97d, 1); pushd(edi);                             /* push edi */
            ii(0x1009_c97e, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_c97f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_c981, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1009_c987, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_c98a, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1009_c98d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_c990, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1009_c993, 4); mov(memw_a32[ds, edx + 0x78], ax);      /* mov [edx+0x78], ax */
            ii(0x1009_c997, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_c999, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_c99a, 1); popd(edi);                              /* pop edi */
            ii(0x1009_c99b, 1); popd(esi);                              /* pop esi */
            ii(0x1009_c99c, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_c99d, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_c99e, 1); retd(); return;                         /* ret */
        }
    }
}