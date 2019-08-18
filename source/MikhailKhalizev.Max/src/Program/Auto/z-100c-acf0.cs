using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a698230d-6eb2-4d21-87e1-db458abfba4c")]
        public void Method_100c_acf0()
        {
            ii(0x100c_acf0, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100c_acf5, 5); calld(Definitions.sys_check_available_stack_size, 0x9_b058); /* call 0x10165d52 */
            ii(0x100c_acfa, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_acfb, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_acfc, 1); pushd(esi);                             /* push esi */
            ii(0x100c_acfd, 1); pushd(edi);                             /* push edi */
            ii(0x100c_acfe, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_acff, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_ad01, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100c_ad07, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_ad0a, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100c_ad0d, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x100c_ad11, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_ad14, 5); calld(0x1008_b410, -0x3_f909);          /* call 0x1008b410 */
            ii(0x100c_ad19, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x100c_ad1c, 5); calld(0x1008_b440, -0x3_f8e1);          /* call 0x1008b440 */
            ii(0x100c_ad21, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100c_ad24, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_ad27, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_ad29, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_ad2a, 1); popd(edi);                              /* pop edi */
            ii(0x100c_ad2b, 1); popd(esi);                              /* pop esi */
            ii(0x100c_ad2c, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_ad2d, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_ad2e, 1); retd(); return;                         /* ret */
        }
    }
}
