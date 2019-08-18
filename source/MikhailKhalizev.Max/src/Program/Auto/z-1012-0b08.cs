using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_0b08-3016ae02")]
        public void Method_1012_0b08()
        {
            ii(0x1012_0b08, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1012_0b0d, 5); calld(Definitions.sys_check_available_stack_size, 0x4_5240); /* call 0x10165d52 */
            ii(0x1012_0b12, 1); pushd(ebx);                             /* push ebx */
            ii(0x1012_0b13, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_0b14, 1); pushd(esi);                             /* push esi */
            ii(0x1012_0b15, 1); pushd(edi);                             /* push edi */
            ii(0x1012_0b16, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_0b17, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_0b19, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1012_0b1f, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1012_0b22, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1012_0b25, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_0b28, 5); calld(0x1008_b410, -0x9_571d);          /* call 0x1008b410 */
            ii(0x1012_0b2d, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x1012_0b30, 5); calld(Definitions.my_3_get_count, -0x9_56b5); /* call 0x1008b480 */
            ii(0x1012_0b35, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1012_0b38, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1012_0b3b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_0b3e, 5); calld(0x1012_0b4c, 0x9);                /* call 0x10120b4c */
            ii(0x1012_0b43, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_0b45, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_0b46, 1); popd(edi);                              /* pop edi */
            ii(0x1012_0b47, 1); popd(esi);                              /* pop esi */
            ii(0x1012_0b48, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_0b49, 1); popd(ebx);                              /* pop ebx */
            ii(0x1012_0b4a, 1); retd(); return;                         /* ret */
        }
    }
}
