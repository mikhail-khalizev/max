using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_f5d5-97fe07d4")]
        public void Method_1010_f5d5()
        {
            ii(0x1010_f5d5, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1010_f5da, 5); calld(Definitions.sys_check_available_stack_size, 0x5_6773); /* call 0x10165d52 */
            ii(0x1010_f5df, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_f5e0, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_f5e1, 1); pushd(edx);                             /* push edx */
            ii(0x1010_f5e2, 1); pushd(esi);                             /* push esi */
            ii(0x1010_f5e3, 1); pushd(edi);                             /* push edi */
            ii(0x1010_f5e4, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_f5e5, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_f5e7, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1010_f5ed, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1010_f5f0, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_f5f2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_f5f5, 5); calld(0x1010_f4eb, -0x10f);             /* call 0x1010f4eb */
            ii(0x1010_f5fa, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_f5fc, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_f5fd, 1); popd(edi);                              /* pop edi */
            ii(0x1010_f5fe, 1); popd(esi);                              /* pop esi */
            ii(0x1010_f5ff, 1); popd(edx);                              /* pop edx */
            ii(0x1010_f600, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_f601, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_f602, 1); retd();                                 /* ret */
        }
    }
}
