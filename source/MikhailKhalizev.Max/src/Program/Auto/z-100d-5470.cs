using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_5470-7e93caef")]
        public void Method_100d_5470()
        {
            ii(0x100d_5470, 1); pushd(ebx);                             /* push ebx */
            ii(0x100d_5471, 1); pushd(ecx);                             /* push ecx */
            ii(0x100d_5472, 1); pushd(edx);                             /* push edx */
            ii(0x100d_5473, 1); pushd(esi);                             /* push esi */
            ii(0x100d_5474, 1); pushd(edi);                             /* push edi */
            ii(0x100d_5475, 1); pushd(ebp);                             /* push ebp */
            ii(0x100d_5476, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_5478, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100d_547e, 7); mov(memd_a32[ss, ebp - 0x4], 0);        /* mov dword [ebp-0x4], 0x0 */
            ii(0x100d_5485, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_5488, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_548a, 1); popd(ebp);                              /* pop ebp */
            ii(0x100d_548b, 1); popd(edi);                              /* pop edi */
            ii(0x100d_548c, 1); popd(esi);                              /* pop esi */
            ii(0x100d_548d, 1); popd(edx);                              /* pop edx */
            ii(0x100d_548e, 1); popd(ecx);                              /* pop ecx */
            ii(0x100d_548f, 1); popd(ebx);                              /* pop ebx */
            ii(0x100d_5490, 1); retd();                                 /* ret */
        }
    }
}
