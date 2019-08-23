using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_aa00-b70b8a0f")]
        public void Method_100c_aa00()
        {
            ii(0x100c_aa00, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_aa01, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_aa02, 1); pushd(edx);                             /* push edx */
            ii(0x100c_aa03, 1); pushd(esi);                             /* push esi */
            ii(0x100c_aa04, 1); pushd(edi);                             /* push edi */
            ii(0x100c_aa05, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_aa06, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_aa08, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100c_aa0e, 4); mov(memb_a32[ss, ebp - 0x4], 0);        /* mov byte [ebp-0x4], 0x0 */
            ii(0x100c_aa12, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x100c_aa15, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_aa17, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_aa18, 1); popd(edi);                              /* pop edi */
            ii(0x100c_aa19, 1); popd(esi);                              /* pop esi */
            ii(0x100c_aa1a, 1); popd(edx);                              /* pop edx */
            ii(0x100c_aa1b, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_aa1c, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_aa1d, 1); retd();                                 /* ret */
        }
    }
}
