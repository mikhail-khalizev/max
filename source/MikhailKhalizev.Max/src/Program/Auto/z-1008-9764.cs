using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_9764-b70b8a0f")]
        public void Method_1008_9764()
        {
            ii(0x1008_9764, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_9765, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_9766, 1); pushd(edx);                             /* push edx */
            ii(0x1008_9767, 1); pushd(esi);                             /* push esi */
            ii(0x1008_9768, 1); pushd(edi);                             /* push edi */
            ii(0x1008_9769, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_976a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_976c, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1008_9772, 4); mov(memb_a32[ss, ebp - 0x4], 0);        /* mov byte [ebp-0x4], 0x0 */
            ii(0x1008_9776, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x1008_9779, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_977b, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_977c, 1); popd(edi);                              /* pop edi */
            ii(0x1008_977d, 1); popd(esi);                              /* pop esi */
            ii(0x1008_977e, 1); popd(edx);                              /* pop edx */
            ii(0x1008_977f, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_9780, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_9781, 1); retd(); return;                         /* ret */
        }
    }
}
