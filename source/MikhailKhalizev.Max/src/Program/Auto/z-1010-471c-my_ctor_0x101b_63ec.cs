using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("73961a20-b94f-4d80-9025-654378d7f930")]
        public void my_ctor_0x101b_63ec()
        {
            ii(0x1010_471c, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1010_4721, 5); calld(Definitions.sys_check_available_stack_size, 0x6_162c); /* call 0x10165d52 */
            ii(0x1010_4726, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_4727, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_4728, 1); pushd(edx);                             /* push edx */
            ii(0x1010_4729, 1); pushd(esi);                             /* push esi */
            ii(0x1010_472a, 1); pushd(edi);                             /* push edi */
            ii(0x1010_472b, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_472c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_472e, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1010_4734, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1010_4737, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_473a, 5); calld(0x1013_a0af, 0x3_5970);           /* call 0x1013a0af */
            ii(0x1010_473f, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1010_4742, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x1010_4745, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1010_4748, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_474b, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1010_474e, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1010_4751, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_4753, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_4754, 1); popd(edi);                              /* pop edi */
            ii(0x1010_4755, 1); popd(esi);                              /* pop esi */
            ii(0x1010_4756, 1); popd(edx);                              /* pop edx */
            ii(0x1010_4757, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_4758, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_4759, 1); retd(); return;                         /* ret */
        }
    }
}