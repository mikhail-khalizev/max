using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("e8064d3b-12d1-420f-a200-cba4466a0a55")]
        public void Method_1009_9dce()
        {
            ii(0x1009_9dce, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1009_9dd3, 5); calld(Definitions.sys_check_available_stack_size, 0xc_bf7a); /* call 0x10165d52 */
            ii(0x1009_9dd8, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_9dd9, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_9dda, 1); pushd(esi);                             /* push esi */
            ii(0x1009_9ddb, 1); pushd(edi);                             /* push edi */
            ii(0x1009_9ddc, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_9ddd, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_9ddf, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1009_9de5, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_9de8, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1009_9deb, 5); mov(edx, StringDefinitions.HabitatAssistant); /* mov edx, 0x101a069e */
            ii(0x1009_9df0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_9df3, 5); calld(Definitions.sys_strcpy, 0xc_c0d7); /* call 0x10165ecf */
            ii(0x1009_9df8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_9dfb, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1009_9dfe, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_9e01, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_9e03, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_9e04, 1); popd(edi);                              /* pop edi */
            ii(0x1009_9e05, 1); popd(esi);                              /* pop esi */
            ii(0x1009_9e06, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_9e07, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_9e08, 1); retd(); return;                         /* ret */
        }
    }
}
