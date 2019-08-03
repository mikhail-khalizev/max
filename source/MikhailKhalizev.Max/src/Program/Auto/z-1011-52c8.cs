using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a45a8016-a2fa-43ad-a3c9-c7b87b310d8c")]
        public void Method_1011_52c8()
        {
            ii(0x1011_52c8, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_52c9, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_52ca, 1); pushd(edx);                             /* push edx */
            ii(0x1011_52cb, 1); pushd(esi);                             /* push esi */
            ii(0x1011_52cc, 1); pushd(edi);                             /* push edi */
            ii(0x1011_52cd, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_52ce, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_52d0, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1011_52d6, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1011_52d9, 5); mov(edx, 0x101c_4e54);                  /* mov edx, 0x101c4e54 */
            ii(0x1011_52de, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_52e1, 5); calld(0x100d_4d78, -0x4056e);           /* call 0x100d4d78 */
            ii(0x1011_52e6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_52e9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_52eb, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_52ec, 1); popd(edi);                              /* pop edi */
            ii(0x1011_52ed, 1); popd(esi);                              /* pop esi */
            ii(0x1011_52ee, 1); popd(edx);                              /* pop edx */
            ii(0x1011_52ef, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_52f0, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_52f1, 1); retd(); return;                         /* ret */
        }
    }
}
