using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_af14-c502b1ca")]
        public void Method_100c_af14()
        {
            ii(0x100c_af14, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_af15, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_af16, 1); pushd(edx);                             /* push edx */
            ii(0x100c_af17, 1); pushd(esi);                             /* push esi */
            ii(0x100c_af18, 1); pushd(edi);                             /* push edi */
            ii(0x100c_af19, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_af1a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_af1c, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100c_af22, 7); mov(memd_a32[ss, ebp - 0x4], 0x5);      /* mov dword [ebp-0x4], 0x5 */
            ii(0x100c_af29, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_af2c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_af2e, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_af2f, 1); popd(edi);                              /* pop edi */
            ii(0x100c_af30, 1); popd(esi);                              /* pop esi */
            ii(0x100c_af31, 1); popd(edx);                              /* pop edx */
            ii(0x100c_af32, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_af33, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_af34, 1); retd();                                 /* ret */
        }
    }
}
