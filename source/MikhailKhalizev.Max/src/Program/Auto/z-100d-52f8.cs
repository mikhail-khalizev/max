using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("077b1ad3-a00f-46e7-9e98-c3cf13d918dd")]
        public void Method_100d_52f8()
        {
            ii(0x100d_52f8, 1); pushd(ebx);                             /* push ebx */
            ii(0x100d_52f9, 1); pushd(ecx);                             /* push ecx */
            ii(0x100d_52fa, 1); pushd(edx);                             /* push edx */
            ii(0x100d_52fb, 1); pushd(esi);                             /* push esi */
            ii(0x100d_52fc, 1); pushd(edi);                             /* push edi */
            ii(0x100d_52fd, 1); pushd(ebp);                             /* push ebp */
            ii(0x100d_52fe, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_5300, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100d_5306, 7); mov(memd_a32[ss, ebp - 0x4], 0);        /* mov dword [ebp-0x4], 0x0 */
            ii(0x100d_530d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_5310, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_5312, 1); popd(ebp);                              /* pop ebp */
            ii(0x100d_5313, 1); popd(edi);                              /* pop edi */
            ii(0x100d_5314, 1); popd(esi);                              /* pop esi */
            ii(0x100d_5315, 1); popd(edx);                              /* pop edx */
            ii(0x100d_5316, 1); popd(ecx);                              /* pop ecx */
            ii(0x100d_5317, 1); popd(ebx);                              /* pop ebx */
            ii(0x100d_5318, 1); retd(); return;                         /* ret */
        }
    }
}
