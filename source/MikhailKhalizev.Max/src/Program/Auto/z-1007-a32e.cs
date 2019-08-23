using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_a32e-c10f59fd")]
        public void Method_1007_a32e()
        {
            ii(0x1007_a32e, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1007_a333, 5); calld(Definitions.sys_check_available_stack_size, 0xe_ba1a); /* call 0x10165d52 */
            ii(0x1007_a338, 1); pushd(ebx);                             /* push ebx */
            ii(0x1007_a339, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_a33a, 1); pushd(esi);                             /* push esi */
            ii(0x1007_a33b, 1); pushd(edi);                             /* push edi */
            ii(0x1007_a33c, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_a33d, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_a33f, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1007_a345, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1007_a348, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1007_a34b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_a34d, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_a34e, 1); popd(edi);                              /* pop edi */
            ii(0x1007_a34f, 1); popd(esi);                              /* pop esi */
            ii(0x1007_a350, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_a351, 1); popd(ebx);                              /* pop ebx */
            ii(0x1007_a352, 1); retd();                                 /* ret */
        }
    }
}
