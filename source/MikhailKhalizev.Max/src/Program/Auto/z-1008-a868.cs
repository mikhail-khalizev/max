using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("99c91315-5692-48a3-918d-d6325dc994f4")]
        public void Method_1008_a868()
        {
            ii(0x1008_a868, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1008_a86d, 5); calld(Definitions.sys_check_available_stack_size, 0xd_b4e0); /* call 0x10165d52 */
            ii(0x1008_a872, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_a873, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_a874, 1); pushd(edx);                             /* push edx */
            ii(0x1008_a875, 1); pushd(esi);                             /* push esi */
            ii(0x1008_a876, 1); pushd(edi);                             /* push edi */
            ii(0x1008_a877, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_a878, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_a87a, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1008_a880, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1008_a883, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_a886, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1008_a888, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_a88b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_a88e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_a890, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_a891, 1); popd(edi);                              /* pop edi */
            ii(0x1008_a892, 1); popd(esi);                              /* pop esi */
            ii(0x1008_a893, 1); popd(edx);                              /* pop edx */
            ii(0x1008_a894, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_a895, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_a896, 1); retd(); return;                         /* ret */
        }
    }
}
