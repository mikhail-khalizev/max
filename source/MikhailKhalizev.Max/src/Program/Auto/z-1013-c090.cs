using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("3c6eae24-ecca-472d-9ba7-39d4a8fb600e")]
        public void Method_1013_c090()
        {
            ii(0x1013_c090, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1013_c095, 5); calld(Definitions.sys_check_available_stack_size, 0x2_9cb8); /* call 0x10165d52 */
            ii(0x1013_c09a, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_c09b, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_c09c, 1); pushd(esi);                             /* push esi */
            ii(0x1013_c09d, 1); pushd(edi);                             /* push edi */
            ii(0x1013_c09e, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_c09f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_c0a1, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1013_c0a7, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_c0aa, 3); mov(memb_a32[ss, ebp - 0x4], dl);       /* mov [ebp-0x4], dl */
            ii(0x1013_c0ad, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1013_c0b2, 3); lea(edx, ebp - 0x4);                    /* lea edx, [ebp-0x4] */
            ii(0x1013_c0b5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_c0b8, 5); calld(0x1013_c055, -0x68);              /* call 0x1013c055 */
            ii(0x1013_c0bd, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_c0bf, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_c0c0, 1); popd(edi);                              /* pop edi */
            ii(0x1013_c0c1, 1); popd(esi);                              /* pop esi */
            ii(0x1013_c0c2, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_c0c3, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_c0c4, 1); retd(); return;                         /* ret */
        }
    }
}
