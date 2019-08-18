using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("e0830ae7-571a-4683-ab71-b3a3cb67bc13")]
        public void Method_1009_30d3()
        {
            ii(0x1009_30d3, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1009_30d8, 5); calld(Definitions.sys_check_available_stack_size, 0xd_2c75); /* call 0x10165d52 */
            ii(0x1009_30dd, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_30de, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_30df, 1); pushd(edx);                             /* push edx */
            ii(0x1009_30e0, 1); pushd(esi);                             /* push esi */
            ii(0x1009_30e1, 1); pushd(edi);                             /* push edi */
            ii(0x1009_30e2, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_30e3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_30e5, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1009_30eb, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1009_30ee, 4); mov(memb_a32[ss, ebp - 0x8], 0x1);      /* mov byte [ebp-0x8], 0x1 */
            ii(0x1009_30f2, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x1009_30f5, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_30f7, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_30f8, 1); popd(edi);                              /* pop edi */
            ii(0x1009_30f9, 1); popd(esi);                              /* pop esi */
            ii(0x1009_30fa, 1); popd(edx);                              /* pop edx */
            ii(0x1009_30fb, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_30fc, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_30fd, 1); retd(); return;                         /* ret */
        }
    }
}
