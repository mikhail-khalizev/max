using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("d33a5c35-948f-45ea-82e6-2f022d354e37")]
        public void Method_100c_b74c()
        {
            ii(0x100c_b74c, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100c_b751, 5); calld(Definitions.sys_check_available_stack_size, 0x9a5fc); /* call 0x10165d52 */
            ii(0x100c_b756, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_b757, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_b758, 1); pushd(edx);                             /* push edx */
            ii(0x100c_b759, 1); pushd(esi);                             /* push esi */
            ii(0x100c_b75a, 1); pushd(edi);                             /* push edi */
            ii(0x100c_b75b, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_b75c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_b75e, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100c_b764, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100c_b767, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_b76a, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100c_b76c, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_b76f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_b772, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_b774, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_b775, 1); popd(edi);                              /* pop edi */
            ii(0x100c_b776, 1); popd(esi);                              /* pop esi */
            ii(0x100c_b777, 1); popd(edx);                              /* pop edx */
            ii(0x100c_b778, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_b779, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_b77a, 1); retd(); return;                         /* ret */
        }
    }
}