using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a4adaa45-7f62-47c7-ae9e-375660a375c0")]
        public void Method_1009_99f4()
        {
            ii(0x1009_99f4, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1009_99f9, 5); calld(Definitions.sys_check_available_stack_size, 0xc_c354); /* call 0x10165d52 */
            ii(0x1009_99fe, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_99ff, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_9a00, 1); pushd(esi);                             /* push esi */
            ii(0x1009_9a01, 1); pushd(edi);                             /* push edi */
            ii(0x1009_9a02, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_9a03, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_9a05, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1009_9a0b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_9a0e, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1009_9a11, 5); mov(edx, StringDefinitions.RadarAssistant); /* mov edx, 0x101a067e */
            ii(0x1009_9a16, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_9a19, 5); calld(Definitions.sys_strcpy, 0xc_c4b1); /* call 0x10165ecf */
            ii(0x1009_9a1e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_9a21, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1009_9a24, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_9a27, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_9a29, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_9a2a, 1); popd(edi);                              /* pop edi */
            ii(0x1009_9a2b, 1); popd(esi);                              /* pop esi */
            ii(0x1009_9a2c, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_9a2d, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_9a2e, 1); retd(); return;                         /* ret */
        }
    }
}
