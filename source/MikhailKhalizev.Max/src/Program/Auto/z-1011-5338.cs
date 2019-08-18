using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_5338-b70b8a0f")]
        public void Method_1011_5338()
        {
            ii(0x1011_5338, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_5339, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_533a, 1); pushd(edx);                             /* push edx */
            ii(0x1011_533b, 1); pushd(esi);                             /* push esi */
            ii(0x1011_533c, 1); pushd(edi);                             /* push edi */
            ii(0x1011_533d, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_533e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_5340, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1011_5346, 4); mov(memb_a32[ss, ebp - 0x4], 0);        /* mov byte [ebp-0x4], 0x0 */
            ii(0x1011_534a, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x1011_534d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_534f, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_5350, 1); popd(edi);                              /* pop edi */
            ii(0x1011_5351, 1); popd(esi);                              /* pop esi */
            ii(0x1011_5352, 1); popd(edx);                              /* pop edx */
            ii(0x1011_5353, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_5354, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_5355, 1); retd(); return;                         /* ret */
        }
    }
}
