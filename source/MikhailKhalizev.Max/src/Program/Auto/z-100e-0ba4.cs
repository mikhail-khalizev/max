using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_0ba4-d68c8207")]
        public void Method_100e_0ba4()
        {
            ii(0x100e_0ba4, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_0ba5, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_0ba6, 1); pushd(edx);                             /* push edx */
            ii(0x100e_0ba7, 1); pushd(esi);                             /* push esi */
            ii(0x100e_0ba8, 1); pushd(edi);                             /* push edi */
            ii(0x100e_0ba9, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_0baa, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_0bac, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100e_0bb2, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100e_0bb5, 5); mov(edx, 0x101c_35a8);                  /* mov edx, 0x101c35a8 */
            ii(0x100e_0bba, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_0bbd, 5); calld(0x100d_4d78, -0xbe4a);            /* call 0x100d4d78 */
            ii(0x100e_0bc2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_0bc5, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_0bc7, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_0bc8, 1); popd(edi);                              /* pop edi */
            ii(0x100e_0bc9, 1); popd(esi);                              /* pop esi */
            ii(0x100e_0bca, 1); popd(edx);                              /* pop edx */
            ii(0x100e_0bcb, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_0bcc, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_0bcd, 1); retd();                                 /* ret */
        }
    }
}
