using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("65ee7639-4e83-454f-a655-87dffd4b6eb0")]
        public void Method_100c_a864()
        {
            ii(0x100c_a864, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100c_a869, 5); calld(Definitions.sys_check_available_stack_size, 0x9_b4e4); /* call 0x10165d52 */
            ii(0x100c_a86e, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_a86f, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_a870, 1); pushd(edx);                             /* push edx */
            ii(0x100c_a871, 1); pushd(esi);                             /* push esi */
            ii(0x100c_a872, 1); pushd(edi);                             /* push edi */
            ii(0x100c_a873, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_a874, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_a876, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100c_a87c, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100c_a87f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_a882, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100c_a884, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_a887, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_a88a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_a88c, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_a88d, 1); popd(edi);                              /* pop edi */
            ii(0x100c_a88e, 1); popd(esi);                              /* pop esi */
            ii(0x100c_a88f, 1); popd(edx);                              /* pop edx */
            ii(0x100c_a890, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_a891, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_a892, 1); retd(); return;                         /* ret */
        }
    }
}
