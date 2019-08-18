using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("aba18780-45ae-40df-82c7-e891e5985c4e")]
        public void Method_1008_9424()
        {
            ii(0x1008_9424, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1008_9429, 5); calld(Definitions.sys_check_available_stack_size, 0xd_c924); /* call 0x10165d52 */
            ii(0x1008_942e, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_942f, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_9430, 1); pushd(esi);                             /* push esi */
            ii(0x1008_9431, 1); pushd(edi);                             /* push edi */
            ii(0x1008_9432, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_9433, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_9435, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1008_943b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_943e, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1008_9441, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1008_9446, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_9449, 5); calld(Definitions.my_dtor_0x101b_6edc, 0xb_17f7); /* call 0x1013ac45 */
            ii(0x1008_944e, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_9451, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_9454, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1008_9457, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1008_945a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_945c, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_945d, 1); popd(edi);                              /* pop edi */
            ii(0x1008_945e, 1); popd(esi);                              /* pop esi */
            ii(0x1008_945f, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_9460, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_9461, 1); retd(); return;                         /* ret */
        }
    }
}
