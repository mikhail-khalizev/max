using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_9e82-207f28f0")]
        public void Method_1009_9e82()
        {
            ii(0x1009_9e82, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1009_9e87, 5); calld(Definitions.sys_check_available_stack_size, 0xc_bec6); /* call 0x10165d52 */
            ii(0x1009_9e8c, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_9e8d, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_9e8e, 1); pushd(edx);                             /* push edx */
            ii(0x1009_9e8f, 1); pushd(esi);                             /* push esi */
            ii(0x1009_9e90, 1); pushd(edi);                             /* push edi */
            ii(0x1009_9e91, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_9e92, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_9e94, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1009_9e9a, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1009_9e9d, 4); mov(memb_a32[ss, ebp - 0x8], 0x13);     /* mov byte [ebp-0x8], 0x13 */
            ii(0x1009_9ea1, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x1009_9ea4, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_9ea6, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_9ea7, 1); popd(edi);                              /* pop edi */
            ii(0x1009_9ea8, 1); popd(esi);                              /* pop esi */
            ii(0x1009_9ea9, 1); popd(edx);                              /* pop edx */
            ii(0x1009_9eaa, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_9eab, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_9eac, 1); retd(); return;                         /* ret */
        }
    }
}
