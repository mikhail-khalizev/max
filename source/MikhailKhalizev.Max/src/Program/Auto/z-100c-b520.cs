using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("7abb803e-ed4f-421e-91bd-c638d067540c")]
        public void Method_100c_b520()
        {
            ii(0x100c_b520, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100c_b525, 5); calld(Definitions.sys_check_available_stack_size, 0x9_a828); /* call 0x10165d52 */
            ii(0x100c_b52a, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_b52b, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_b52c, 1); pushd(edx);                             /* push edx */
            ii(0x100c_b52d, 1); pushd(esi);                             /* push esi */
            ii(0x100c_b52e, 1); pushd(edi);                             /* push edi */
            ii(0x100c_b52f, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_b530, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_b532, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100c_b538, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100c_b53b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_b53e, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100c_b540, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_b543, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_b546, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_b548, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_b549, 1); popd(edi);                              /* pop edi */
            ii(0x100c_b54a, 1); popd(esi);                              /* pop esi */
            ii(0x100c_b54b, 1); popd(edx);                              /* pop edx */
            ii(0x100c_b54c, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_b54d, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_b54e, 1); retd(); return;                         /* ret */
        }
    }
}
