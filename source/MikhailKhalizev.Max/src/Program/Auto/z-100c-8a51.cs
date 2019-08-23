using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_8a51-bf8f6be4")]
        public void Method_100c_8a51()
        {
            ii(0x100c_8a51, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100c_8a56, 5); calld(Definitions.sys_check_available_stack_size, 0x9_d2f7); /* call 0x10165d52 */
            ii(0x100c_8a5b, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_8a5c, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_8a5d, 1); pushd(esi);                             /* push esi */
            ii(0x100c_8a5e, 1); pushd(edi);                             /* push edi */
            ii(0x100c_8a5f, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_8a60, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_8a62, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100c_8a68, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_8a6b, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100c_8a6e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_8a71, 5); calld(0x100c_8a87, 0x11);               /* call 0x100c8a87 */
            ii(0x100c_8a76, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_8a79, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100c_8a7c, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_8a7f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_8a81, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_8a82, 1); popd(edi);                              /* pop edi */
            ii(0x100c_8a83, 1); popd(esi);                              /* pop esi */
            ii(0x100c_8a84, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_8a85, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_8a86, 1); retd();                                 /* ret */
        }
    }
}
