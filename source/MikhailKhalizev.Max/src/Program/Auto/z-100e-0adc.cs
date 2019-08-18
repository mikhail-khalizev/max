using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_0adc-8cf7c792")]
        public void Method_100e_0adc()
        {
            ii(0x100e_0adc, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100e_0ae1, 5); calld(Definitions.sys_check_available_stack_size, 0x8_526c); /* call 0x10165d52 */
            ii(0x100e_0ae6, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_0ae7, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_0ae8, 1); pushd(esi);                             /* push esi */
            ii(0x100e_0ae9, 1); pushd(edi);                             /* push edi */
            ii(0x100e_0aea, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_0aeb, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_0aed, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100e_0af3, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_0af6, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100e_0af9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_0afc, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100e_0aff, 4); mov(memw_a32[ds, edx + 0xe], ax);       /* mov [edx+0xe], ax */
            ii(0x100e_0b03, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_0b05, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_0b06, 1); popd(edi);                              /* pop edi */
            ii(0x100e_0b07, 1); popd(esi);                              /* pop esi */
            ii(0x100e_0b08, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_0b09, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_0b0a, 1); retd(); return;                         /* ret */
        }
    }
}
