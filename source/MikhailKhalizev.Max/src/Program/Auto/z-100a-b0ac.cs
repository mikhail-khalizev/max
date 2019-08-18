using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("7675adc8-d4e3-4a85-b299-1b17554564fb")]
        public void Method_100a_b0ac()
        {
            ii(0x100a_b0ac, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100a_b0b1, 5); calld(Definitions.sys_check_available_stack_size, 0xb_ac9c); /* call 0x10165d52 */
            ii(0x100a_b0b6, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_b0b7, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_b0b8, 1); pushd(edx);                             /* push edx */
            ii(0x100a_b0b9, 1); pushd(esi);                             /* push esi */
            ii(0x100a_b0ba, 1); pushd(edi);                             /* push edi */
            ii(0x100a_b0bb, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_b0bc, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_b0be, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100a_b0c4, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100a_b0c7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_b0ca, 5); calld(0x1007_6b58, -0x3_4577);          /* call 0x10076b58 */
            ii(0x100a_b0cf, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_b0d2, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_b0d5, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_b0d7, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_b0d8, 1); popd(edi);                              /* pop edi */
            ii(0x100a_b0d9, 1); popd(esi);                              /* pop esi */
            ii(0x100a_b0da, 1); popd(edx);                              /* pop edx */
            ii(0x100a_b0db, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_b0dc, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_b0dd, 1); retd(); return;                         /* ret */
        }
    }
}
