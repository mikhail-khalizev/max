using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_2a34-7e93caef")]
        public void Method_1010_2a34()
        {
            ii(0x1010_2a34, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_2a35, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_2a36, 1); pushd(edx);                             /* push edx */
            ii(0x1010_2a37, 1); pushd(esi);                             /* push esi */
            ii(0x1010_2a38, 1); pushd(edi);                             /* push edi */
            ii(0x1010_2a39, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_2a3a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_2a3c, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1010_2a42, 7); mov(memd_a32[ss, ebp - 0x4], 0);        /* mov dword [ebp-0x4], 0x0 */
            ii(0x1010_2a49, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_2a4c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_2a4e, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_2a4f, 1); popd(edi);                              /* pop edi */
            ii(0x1010_2a50, 1); popd(esi);                              /* pop esi */
            ii(0x1010_2a51, 1); popd(edx);                              /* pop edx */
            ii(0x1010_2a52, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_2a53, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_2a54, 1); retd();                                 /* ret */
        }
    }
}
