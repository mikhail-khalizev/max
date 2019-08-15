using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("11bbf2fd-30dd-4c15-a2f4-071e72f9880c")]
        public void Method_1010_f603()
        {
            ii(0x1010_f603, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1010_f608, 5); calld(Definitions.sys_check_available_stack_size, 0x5_6745); /* call 0x10165d52 */
            ii(0x1010_f60d, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_f60e, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_f60f, 1); pushd(edx);                             /* push edx */
            ii(0x1010_f610, 1); pushd(esi);                             /* push esi */
            ii(0x1010_f611, 1); pushd(edi);                             /* push edi */
            ii(0x1010_f612, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_f613, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_f615, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1010_f61b, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1010_f61e, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1010_f623, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_f626, 5); calld(0x1010_f4eb, -0x140);             /* call 0x1010f4eb */
            ii(0x1010_f62b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_f62d, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_f62e, 1); popd(edi);                              /* pop edi */
            ii(0x1010_f62f, 1); popd(esi);                              /* pop esi */
            ii(0x1010_f630, 1); popd(edx);                              /* pop edx */
            ii(0x1010_f631, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_f632, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_f633, 1); retd(); return;                         /* ret */
        }
    }
}
