using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("2ef175c0-99de-40cd-bdec-929b62cf4305")]
        public void Method_100c_adac()
        {
            ii(0x100c_adac, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100c_adb1, 5); calld(Definitions.sys_check_available_stack_size, 0x9af9c); /* call 0x10165d52 */
            ii(0x100c_adb6, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_adb7, 1); pushd(esi);                             /* push esi */
            ii(0x100c_adb8, 1); pushd(edi);                             /* push edi */
            ii(0x100c_adb9, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_adba, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_adbc, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100c_adc2, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100c_adc5, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x100c_adc8, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x100c_adcb, 4); movsx(ebx, memw_a32[ss, ebp - 0x4]);    /* movsx ebx, word [ebp-0x4] */
            ii(0x100c_adcf, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100c_add2, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_add5, 5); calld(0x1008_b410, -0x3f9ca);           /* call 0x1008b410 */
            ii(0x100c_adda, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x100c_addd, 5); calld(0x100c_d990, 0x2bae);             /* call 0x100cd990 */
            ii(0x100c_ade2, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_ade4, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_ade5, 1); popd(edi);                              /* pop edi */
            ii(0x100c_ade6, 1); popd(esi);                              /* pop esi */
            ii(0x100c_ade7, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_ade8, 1); retd(); return;                         /* ret */
        }
    }
}