using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_f556-116209bd")]
        public void Method_1007_f556()
        {
            ii(0x1007_f556, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1007_f55b, 5); calld(Definitions.sys_check_available_stack_size, 0xe_67f2); /* call 0x10165d52 */
            ii(0x1007_f560, 1); pushd(ebx);                             /* push ebx */
            ii(0x1007_f561, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_f562, 1); pushd(edx);                             /* push edx */
            ii(0x1007_f563, 1); pushd(esi);                             /* push esi */
            ii(0x1007_f564, 1); pushd(edi);                             /* push edi */
            ii(0x1007_f565, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_f566, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_f568, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1007_f56e, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1007_f571, 4); mov(memb_a32[ss, ebp - 0x8], 0x11);     /* mov byte [ebp-0x8], 0x11 */
            ii(0x1007_f575, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x1007_f578, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_f57a, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_f57b, 1); popd(edi);                              /* pop edi */
            ii(0x1007_f57c, 1); popd(esi);                              /* pop esi */
            ii(0x1007_f57d, 1); popd(edx);                              /* pop edx */
            ii(0x1007_f57e, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_f57f, 1); popd(ebx);                              /* pop ebx */
            ii(0x1007_f580, 1); retd(); return;                         /* ret */
        }
    }
}
