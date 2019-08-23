using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_8e5f-5e4b4b26")]
        public void Method_1010_8e5f()
        {
            ii(0x1010_8e5f, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1010_8e64, 5); calld(Definitions.sys_check_available_stack_size, 0x5_cee9); /* call 0x10165d52 */
            ii(0x1010_8e69, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_8e6a, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_8e6b, 1); pushd(edx);                             /* push edx */
            ii(0x1010_8e6c, 1); pushd(esi);                             /* push esi */
            ii(0x1010_8e6d, 1); pushd(edi);                             /* push edi */
            ii(0x1010_8e6e, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_8e6f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_8e71, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1010_8e77, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1010_8e7a, 5); calld(0x100d_4e6c, -0x3_4013);          /* call 0x100d4e6c */
            ii(0x1010_8e7f, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1010_8e81, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1010_8e83, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_8e85, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1010_8e8a, 5); calld(0x1010_5b00, -0x338f);            /* call 0x10105b00 */
            ii(0x1010_8e8f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_8e91, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_8e92, 1); popd(edi);                              /* pop edi */
            ii(0x1010_8e93, 1); popd(esi);                              /* pop esi */
            ii(0x1010_8e94, 1); popd(edx);                              /* pop edx */
            ii(0x1010_8e95, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_8e96, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_8e97, 1); retd();                                 /* ret */
        }
    }
}
