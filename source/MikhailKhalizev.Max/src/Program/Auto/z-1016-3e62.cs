using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("1f04e063-f66d-4995-afb0-90fcd7efea2e")]
        public void Method_1016_3e62()
        {
            ii(0x1016_3e62, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1016_3e67, 5); calld(Definitions.sys_check_available_stack_size, 0x1ee6); /* call 0x10165d52 */
            ii(0x1016_3e6c, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_3e6d, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_3e6e, 1); pushd(edx);                             /* push edx */
            ii(0x1016_3e6f, 1); pushd(esi);                             /* push esi */
            ii(0x1016_3e70, 1); pushd(edi);                             /* push edi */
            ii(0x1016_3e71, 1); pushd(ebp);                             /* push ebp */
            ii(0x1016_3e72, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1016_3e74, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1016_3e7a, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1016_3e7d, 5); mov(eax, 0x101c_b11a);                  /* mov eax, 0x101cb11a */
            ii(0x1016_3e82, 5); calld(0x1012_0d64, -0x4_3123);          /* call 0x10120d64 */
            ii(0x1016_3e87, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1016_3e8a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1016_3e8d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1016_3e8f, 1); popd(ebp);                              /* pop ebp */
            ii(0x1016_3e90, 1); popd(edi);                              /* pop edi */
            ii(0x1016_3e91, 1); popd(esi);                              /* pop esi */
            ii(0x1016_3e92, 1); popd(edx);                              /* pop edx */
            ii(0x1016_3e93, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_3e94, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_3e95, 1); retd(); return;                         /* ret */
        }
    }
}