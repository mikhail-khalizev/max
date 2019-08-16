using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("6b6c4e4b-afe5-4525-aa5d-810f15703bcf")]
        public void Method_1008_9004()
        {
            ii(0x1008_9004, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1008_9009, 5); calld(Definitions.sys_check_available_stack_size, 0xd_cd44); /* call 0x10165d52 */
            ii(0x1008_900e, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_900f, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_9010, 1); pushd(esi);                             /* push esi */
            ii(0x1008_9011, 1); pushd(edi);                             /* push edi */
            ii(0x1008_9012, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_9013, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_9015, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1008_901b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_901e, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1008_9021, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1008_9026, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_9029, 5); calld(0x1013_a1be, 0xb_1190);           /* call 0x1013a1be */
            ii(0x1008_902e, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_9031, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_9034, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1008_9037, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1008_903a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_903c, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_903d, 1); popd(edi);                              /* pop edi */
            ii(0x1008_903e, 1); popd(esi);                              /* pop esi */
            ii(0x1008_903f, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_9040, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_9041, 1); retd(); return;                         /* ret */
        }
    }
}