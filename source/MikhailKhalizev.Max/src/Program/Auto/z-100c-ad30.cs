using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("f69f8958-617e-4366-8d1d-86168cbbe7a0")]
        public void Method_100c_ad30()
        {
            ii(0x100c_ad30, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100c_ad35, 5); calld(Definitions.sys_check_available_stack_size, 0x9_b018); /* call 0x10165d52 */
            ii(0x100c_ad3a, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_ad3b, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_ad3c, 1); pushd(esi);                             /* push esi */
            ii(0x100c_ad3d, 1); pushd(edi);                             /* push edi */
            ii(0x100c_ad3e, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_ad3f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_ad41, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100c_ad47, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_ad4a, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100c_ad4d, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100c_ad50, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_ad53, 5); calld(0x100c_b850, 0xaf8);              /* call 0x100cb850 */
            ii(0x100c_ad58, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100c_ad5b, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_ad5e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_ad60, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_ad61, 1); popd(edi);                              /* pop edi */
            ii(0x100c_ad62, 1); popd(esi);                              /* pop esi */
            ii(0x100c_ad63, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_ad64, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_ad65, 1); retd(); return;                         /* ret */
        }
    }
}
