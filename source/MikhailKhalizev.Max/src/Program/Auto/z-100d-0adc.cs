using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_0adc-61c587e9")]
        public void Method_100d_0adc()
        {
            ii(0x100d_0adc, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100d_0ae1, 5); calld(Definitions.sys_check_available_stack_size, 0x9_526c); /* call 0x10165d52 */
            ii(0x100d_0ae6, 1); pushd(ebx);                             /* push ebx */
            ii(0x100d_0ae7, 1); pushd(ecx);                             /* push ecx */
            ii(0x100d_0ae8, 1); pushd(edx);                             /* push edx */
            ii(0x100d_0ae9, 1); pushd(esi);                             /* push esi */
            ii(0x100d_0aea, 1); pushd(edi);                             /* push edi */
            ii(0x100d_0aeb, 1); pushd(ebp);                             /* push ebp */
            ii(0x100d_0aec, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_0aee, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100d_0af4, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100d_0af7, 7); mov(memd_a32[ss, ebp - 0x8], 0x101c_35b0); /* mov dword [ebp-0x8], 0x101c35b0 */
            ii(0x100d_0afe, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_0b01, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_0b03, 1); popd(ebp);                              /* pop ebp */
            ii(0x100d_0b04, 1); popd(edi);                              /* pop edi */
            ii(0x100d_0b05, 1); popd(esi);                              /* pop esi */
            ii(0x100d_0b06, 1); popd(edx);                              /* pop edx */
            ii(0x100d_0b07, 1); popd(ecx);                              /* pop ecx */
            ii(0x100d_0b08, 1); popd(ebx);                              /* pop ebx */
            ii(0x100d_0b09, 1); retd(); return;                         /* ret */
        }
    }
}
