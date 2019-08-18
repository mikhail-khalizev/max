using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_3334-7ee5db96")]
        public void Method_1012_3334()
        {
            ii(0x1012_3334, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1012_3339, 5); calld(Definitions.sys_check_available_stack_size, 0x4_2a14); /* call 0x10165d52 */
            ii(0x1012_333e, 1); pushd(ebx);                             /* push ebx */
            ii(0x1012_333f, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_3340, 1); pushd(esi);                             /* push esi */
            ii(0x1012_3341, 1); pushd(edi);                             /* push edi */
            ii(0x1012_3342, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_3343, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_3345, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1012_334b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1012_334e, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1012_3351, 3); mov(edi, memd_a32[ss, ebp - 0x8]);      /* mov edi, [ebp-0x8] */
            ii(0x1012_3354, 3); mov(esi, memd_a32[ss, ebp - 0x4]);      /* mov esi, [ebp-0x4] */
            ii(0x1012_3357, 2); movsw_a32();                            /* movsw */
            ii(0x1012_3359, 1); movsb_a32();                            /* movsb */
            ii(0x1012_335a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_335d, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1012_3360, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_3363, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_3365, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_3366, 1); popd(edi);                              /* pop edi */
            ii(0x1012_3367, 1); popd(esi);                              /* pop esi */
            ii(0x1012_3368, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_3369, 1); popd(ebx);                              /* pop ebx */
            ii(0x1012_336a, 1); retd(); return;                         /* ret */
        }
    }
}
