using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("40df9f54-bbcb-48df-abda-e2cf076cec6e")]
        public void Method_1011_fc7b()
        {
            ii(0x1011_fc7b, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1011_fc80, 5); calld(Definitions.sys_check_available_stack_size, 0x4_60cd); /* call 0x10165d52 */
            ii(0x1011_fc85, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_fc86, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_fc87, 1); pushd(edx);                             /* push edx */
            ii(0x1011_fc88, 1); pushd(esi);                             /* push esi */
            ii(0x1011_fc89, 1); pushd(edi);                             /* push edi */
            ii(0x1011_fc8a, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_fc8b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_fc8d, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1011_fc93, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1011_fc96, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1011_fc99, 5); mov(eax, 0x101c_536c);                  /* mov eax, 0x101c536c */
            ii(0x1011_fc9e, 5); calld(0x1011_e6bd, -0x15e6);            /* call 0x1011e6bd */
            ii(0x1011_fca3, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1011_fca6, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_fca9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_fcab, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_fcac, 1); popd(edi);                              /* pop edi */
            ii(0x1011_fcad, 1); popd(esi);                              /* pop esi */
            ii(0x1011_fcae, 1); popd(edx);                              /* pop edx */
            ii(0x1011_fcaf, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_fcb0, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_fcb1, 1); retd(); return;                         /* ret */
        }
    }
}
