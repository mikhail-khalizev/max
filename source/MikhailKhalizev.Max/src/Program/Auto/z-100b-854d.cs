using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_854d-ed89aec8")]
        public void Method_100b_854d()
        {
            ii(0x100b_854d, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100b_8552, 5); calld(Definitions.sys_check_available_stack_size, 0xa_d7fb); /* call 0x10165d52 */
            ii(0x100b_8557, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_8558, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_8559, 1); pushd(esi);                             /* push esi */
            ii(0x100b_855a, 1); pushd(edi);                             /* push edi */
            ii(0x100b_855b, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_855c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_855e, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100b_8564, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_8567, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100b_856a, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100b_856d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_8570, 5); calld(0x100c_b364, 0x1_2def);           /* call 0x100cb364 */
            ii(0x100b_8575, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100b_8578, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_857b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_857d, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_857e, 1); popd(edi);                              /* pop edi */
            ii(0x100b_857f, 1); popd(esi);                              /* pop esi */
            ii(0x100b_8580, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_8581, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_8582, 1); retd();                                 /* ret */
        }
    }
}
