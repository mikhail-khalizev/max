using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_484c-c502b1ca")]
        public void Method_1016_484c()
        {
            ii(0x1016_484c, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_484d, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_484e, 1); pushd(edx);                             /* push edx */
            ii(0x1016_484f, 1); pushd(esi);                             /* push esi */
            ii(0x1016_4850, 1); pushd(edi);                             /* push edi */
            ii(0x1016_4851, 1); pushd(ebp);                             /* push ebp */
            ii(0x1016_4852, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1016_4854, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1016_485a, 7); mov(memd_a32[ss, ebp - 0x4], 0x5);      /* mov dword [ebp-0x4], 0x5 */
            ii(0x1016_4861, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_4864, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1016_4866, 1); popd(ebp);                              /* pop ebp */
            ii(0x1016_4867, 1); popd(edi);                              /* pop edi */
            ii(0x1016_4868, 1); popd(esi);                              /* pop esi */
            ii(0x1016_4869, 1); popd(edx);                              /* pop edx */
            ii(0x1016_486a, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_486b, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_486c, 1); retd();                                 /* ret */
        }
    }
}
