using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("8ed4a9ce-68d6-4f36-a830-1fe5fee99656")]
        public void Method_1008_afe4()
        {
            ii(0x1008_afe4, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1008_afe9, 5); calld(Definitions.sys_check_available_stack_size, 0xd_ad64); /* call 0x10165d52 */
            ii(0x1008_afee, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_afef, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_aff0, 1); pushd(esi);                             /* push esi */
            ii(0x1008_aff1, 1); pushd(edi);                             /* push edi */
            ii(0x1008_aff2, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_aff3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_aff5, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1008_affb, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_affe, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1008_b001, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1008_b004, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_b007, 5); calld(0x1013_ac7d, 0xa_fc71);           /* call 0x1013ac7d */
            ii(0x1008_b00c, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1008_b00f, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1008_b012, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_b014, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_b015, 1); popd(edi);                              /* pop edi */
            ii(0x1008_b016, 1); popd(esi);                              /* pop esi */
            ii(0x1008_b017, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_b018, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_b019, 1); retd(); return;                         /* ret */
        }
    }
}
