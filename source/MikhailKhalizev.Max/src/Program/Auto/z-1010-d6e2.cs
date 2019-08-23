using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_d6e2-9b3b783d")]
        public void Method_1010_d6e2()
        {
            ii(0x1010_d6e2, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1010_d6e7, 5); calld(Definitions.sys_check_available_stack_size, 0x5_8666); /* call 0x10165d52 */
            ii(0x1010_d6ec, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_d6ed, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_d6ee, 1); pushd(edx);                             /* push edx */
            ii(0x1010_d6ef, 1); pushd(esi);                             /* push esi */
            ii(0x1010_d6f0, 1); pushd(edi);                             /* push edi */
            ii(0x1010_d6f1, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_d6f2, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_d6f4, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1010_d6fa, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1010_d6fd, 5); calld(0x100d_4e6c, -0x3_8896);          /* call 0x100d4e6c */
            ii(0x1010_d702, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1010_d704, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1010_d706, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_d708, 5); mov(eax, 0x2);                          /* mov eax, 0x2 */
            ii(0x1010_d70d, 5); calld(0x1010_5b00, -0x7c12);            /* call 0x10105b00 */
            ii(0x1010_d712, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_d714, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_d715, 1); popd(edi);                              /* pop edi */
            ii(0x1010_d716, 1); popd(esi);                              /* pop esi */
            ii(0x1010_d717, 1); popd(edx);                              /* pop edx */
            ii(0x1010_d718, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_d719, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_d71a, 1); retd();                                 /* ret */
        }
    }
}
