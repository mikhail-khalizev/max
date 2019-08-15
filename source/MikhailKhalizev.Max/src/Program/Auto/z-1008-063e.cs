using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("4d4abcc3-5547-4439-adf3-31b6d1f61411")]
        public void Method_1008_063e()
        {
            ii(0x1008_063e, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1008_0643, 5); calld(Definitions.sys_check_available_stack_size, 0xe_570a); /* call 0x10165d52 */
            ii(0x1008_0648, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_0649, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_064a, 1); pushd(esi);                             /* push esi */
            ii(0x1008_064b, 1); pushd(edi);                             /* push edi */
            ii(0x1008_064c, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_064d, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_064f, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1008_0655, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_0658, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1008_065b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_065e, 5); calld(0x1007_f76b, -0xef8);             /* call 0x1007f76b */
            ii(0x1008_0663, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x1008_0667, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x1008_066a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_066c, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_066d, 1); popd(edi);                              /* pop edi */
            ii(0x1008_066e, 1); popd(esi);                              /* pop esi */
            ii(0x1008_066f, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_0670, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_0671, 1); retd(); return;                         /* ret */
        }
    }
}
