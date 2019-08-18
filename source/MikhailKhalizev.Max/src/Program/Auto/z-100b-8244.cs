using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_8244-32d02e0b")]
        public void Method_100b_8244()
        {
            ii(0x100b_8244, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100b_8249, 5); calld(Definitions.sys_check_available_stack_size, 0xa_db04); /* call 0x10165d52 */
            ii(0x100b_824e, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_824f, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_8250, 1); pushd(esi);                             /* push esi */
            ii(0x100b_8251, 1); pushd(edi);                             /* push edi */
            ii(0x100b_8252, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_8253, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_8255, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100b_825b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_825e, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100b_8261, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100b_8264, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_8267, 5); calld(0x1013_ac7d, 0x8_2a11);           /* call 0x1013ac7d */
            ii(0x100b_826c, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100b_826f, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_8272, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_8274, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_8275, 1); popd(edi);                              /* pop edi */
            ii(0x100b_8276, 1); popd(esi);                              /* pop esi */
            ii(0x100b_8277, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_8278, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_8279, 1); retd(); return;                         /* ret */
        }
    }
}
