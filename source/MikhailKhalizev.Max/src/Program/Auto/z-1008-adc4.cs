using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("bf9f0d68-0344-4a84-bda2-df1793856cf8")]
        public void Method_1008_adc4()
        {
            ii(0x1008_adc4, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1008_adc9, 5); calld(Definitions.sys_check_available_stack_size, 0xdaf84); /* call 0x10165d52 */
            ii(0x1008_adce, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_adcf, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_add0, 1); pushd(edx);                             /* push edx */
            ii(0x1008_add1, 1); pushd(esi);                             /* push esi */
            ii(0x1008_add2, 1); pushd(edi);                             /* push edi */
            ii(0x1008_add3, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_add4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_add6, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1008_addc, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1008_addf, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_ade2, 5); calld(0x1007_6c30, -0x141b7);           /* call 0x10076c30 */
            ii(0x1008_ade7, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_adea, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_aded, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_adef, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_adf0, 1); popd(edi);                              /* pop edi */
            ii(0x1008_adf1, 1); popd(esi);                              /* pop esi */
            ii(0x1008_adf2, 1); popd(edx);                              /* pop edx */
            ii(0x1008_adf3, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_adf4, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_adf5, 1); retd(); return;                         /* ret */
        }
    }
}