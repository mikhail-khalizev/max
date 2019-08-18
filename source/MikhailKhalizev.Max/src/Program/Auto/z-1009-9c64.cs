using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_9c64-ba13dda6")]
        public void Method_1009_9c64()
        {
            ii(0x1009_9c64, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1009_9c69, 5); calld(Definitions.sys_check_available_stack_size, 0xc_c0e4); /* call 0x10165d52 */
            ii(0x1009_9c6e, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_9c6f, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_9c70, 1); pushd(esi);                             /* push esi */
            ii(0x1009_9c71, 1); pushd(edi);                             /* push edi */
            ii(0x1009_9c72, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_9c73, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_9c75, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1009_9c7b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_9c7e, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1009_9c81, 5); mov(edx, StringDefinitions.PowerAssistant); /* mov edx, 0x101a068e */
            ii(0x1009_9c86, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_9c89, 5); calld(Definitions.sys_strcpy, 0xc_c241); /* call 0x10165ecf */
            ii(0x1009_9c8e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_9c91, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1009_9c94, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_9c97, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_9c99, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_9c9a, 1); popd(edi);                              /* pop edi */
            ii(0x1009_9c9b, 1); popd(esi);                              /* pop esi */
            ii(0x1009_9c9c, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_9c9d, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_9c9e, 1); retd(); return;                         /* ret */
        }
    }
}
