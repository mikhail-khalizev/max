using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("358b5e5e-4558-4971-9ff8-904e2795119f")]
        public void Method_1011_5358()
        {
            ii(0x1011_5358, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_5359, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_535a, 1); pushd(edx);                             /* push edx */
            ii(0x1011_535b, 1); pushd(esi);                             /* push esi */
            ii(0x1011_535c, 1); pushd(edi);                             /* push edi */
            ii(0x1011_535d, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_535e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_5360, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1011_5366, 4); mov(memb_a32[ss, ebp - 0x4], 0x1);      /* mov byte [ebp-0x4], 0x1 */
            ii(0x1011_536a, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x1011_536d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_536f, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_5370, 1); popd(edi);                              /* pop edi */
            ii(0x1011_5371, 1); popd(esi);                              /* pop esi */
            ii(0x1011_5372, 1); popd(edx);                              /* pop edx */
            ii(0x1011_5373, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_5374, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_5375, 1); retd(); return;                         /* ret */
        }
    }
}
