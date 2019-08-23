using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_168d-e76b2402")]
        public void Method_1013_168d()
        {
            ii(0x1013_168d, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1013_1692, 5); calld(Definitions.sys_check_available_stack_size, 0x3_46bb); /* call 0x10165d52 */
            ii(0x1013_1697, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_1698, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_1699, 1); pushd(esi);                             /* push esi */
            ii(0x1013_169a, 1); pushd(edi);                             /* push edi */
            ii(0x1013_169b, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_169c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_169e, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1013_16a4, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_16a7, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1013_16aa, 5); calld(0x100d_4e6c, -0x5_c843);          /* call 0x100d4e6c */
            ii(0x1013_16af, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1013_16b1, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1013_16b3, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_16b5, 5); mov(eax, 0x1d);                         /* mov eax, 0x1d */
            ii(0x1013_16ba, 5); calld(0x1010_5b00, -0x2_bbbf);          /* call 0x10105b00 */
            ii(0x1013_16bf, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_16c1, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_16c2, 1); popd(edi);                              /* pop edi */
            ii(0x1013_16c3, 1); popd(esi);                              /* pop esi */
            ii(0x1013_16c4, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_16c5, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_16c6, 1); retd();                                 /* ret */
        }
    }
}
