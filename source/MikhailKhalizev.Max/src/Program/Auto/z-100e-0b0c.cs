using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_0b0c-bf292724")]
        public void Method_100e_0b0c()
        {
            ii(0x100e_0b0c, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100e_0b11, 5); calld(Definitions.sys_check_available_stack_size, 0x8_523c); /* call 0x10165d52 */
            ii(0x100e_0b16, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_0b17, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_0b18, 1); pushd(edx);                             /* push edx */
            ii(0x100e_0b19, 1); pushd(esi);                             /* push esi */
            ii(0x100e_0b1a, 1); pushd(edi);                             /* push edi */
            ii(0x100e_0b1b, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_0b1c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_0b1e, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100e_0b24, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100e_0b27, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_0b2a, 4); mov(ax, memw_a32[ds, eax + 0x4]);       /* mov ax, [eax+0x4] */
            ii(0x100e_0b2e, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_0b31, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_0b34, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_0b36, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_0b37, 1); popd(edi);                              /* pop edi */
            ii(0x100e_0b38, 1); popd(esi);                              /* pop esi */
            ii(0x100e_0b39, 1); popd(edx);                              /* pop edx */
            ii(0x100e_0b3a, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_0b3b, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_0b3c, 1); retd();                                 /* ret */
        }
    }
}
