using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("b192aaf5-794f-4af4-a6d2-16c32654e278")]
        public void Method_100d_531c()
        {
            ii(0x100d_531c, 1); pushd(ebx);                             /* push ebx */
            ii(0x100d_531d, 1); pushd(ecx);                             /* push ecx */
            ii(0x100d_531e, 1); pushd(edx);                             /* push edx */
            ii(0x100d_531f, 1); pushd(esi);                             /* push esi */
            ii(0x100d_5320, 1); pushd(edi);                             /* push edi */
            ii(0x100d_5321, 1); pushd(ebp);                             /* push ebp */
            ii(0x100d_5322, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_5324, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100d_532a, 4); mov(memb_a32[ss, ebp - 0x4], 0x1);      /* mov byte [ebp-0x4], 0x1 */
            ii(0x100d_532e, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x100d_5331, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_5333, 1); popd(ebp);                              /* pop ebp */
            ii(0x100d_5334, 1); popd(edi);                              /* pop edi */
            ii(0x100d_5335, 1); popd(esi);                              /* pop esi */
            ii(0x100d_5336, 1); popd(edx);                              /* pop edx */
            ii(0x100d_5337, 1); popd(ecx);                              /* pop ecx */
            ii(0x100d_5338, 1); popd(ebx);                              /* pop ebx */
            ii(0x100d_5339, 1); retd(); return;                         /* ret */
        }
    }
}
