using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_76d8-61160c91")]
        public void Method_100d_76d8()
        {
            ii(0x100d_76d8, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100d_76dd, 5); calld(Definitions.sys_check_available_stack_size, 0x8_e670); /* call 0x10165d52 */
            ii(0x100d_76e2, 1); pushd(ebx);                             /* push ebx */
            ii(0x100d_76e3, 1); pushd(ecx);                             /* push ecx */
            ii(0x100d_76e4, 1); pushd(edx);                             /* push edx */
            ii(0x100d_76e5, 1); pushd(esi);                             /* push esi */
            ii(0x100d_76e6, 1); pushd(edi);                             /* push edi */
            ii(0x100d_76e7, 1); pushd(ebp);                             /* push ebp */
            ii(0x100d_76e8, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_76ea, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100d_76f0, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100d_76f3, 7); mov(memd_a32[ss, ebp - 0x8], 0x101c_3602); /* mov dword [ebp-0x8], 0x101c3602 */
            ii(0x100d_76fa, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_76fd, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_76ff, 1); popd(ebp);                              /* pop ebp */
            ii(0x100d_7700, 1); popd(edi);                              /* pop edi */
            ii(0x100d_7701, 1); popd(esi);                              /* pop esi */
            ii(0x100d_7702, 1); popd(edx);                              /* pop edx */
            ii(0x100d_7703, 1); popd(ecx);                              /* pop ecx */
            ii(0x100d_7704, 1); popd(ebx);                              /* pop ebx */
            ii(0x100d_7705, 1); retd(); return;                         /* ret */
        }
    }
}
