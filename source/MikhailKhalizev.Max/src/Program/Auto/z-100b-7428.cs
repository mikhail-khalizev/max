using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("93b6e791-f8bc-47c3-bd93-fc2a62e44efa")]
        public void Method_100b_7428()
        {
            ii(0x100b_7428, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100b_742d, 5); calld(Definitions.sys_check_available_stack_size, 0xa_e920); /* call 0x10165d52 */
            ii(0x100b_7432, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_7433, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_7434, 1); pushd(esi);                             /* push esi */
            ii(0x100b_7435, 1); pushd(edi);                             /* push edi */
            ii(0x100b_7436, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_7437, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_7439, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100b_743f, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_7442, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100b_7445, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100b_744a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_744d, 5); calld(Definitions.my_dtor_0x101b_6edc, 0x8_37f3); /* call 0x1013ac45 */
            ii(0x100b_7452, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_7455, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_7458, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100b_745b, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_745e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_7460, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_7461, 1); popd(edi);                              /* pop edi */
            ii(0x100b_7462, 1); popd(esi);                              /* pop esi */
            ii(0x100b_7463, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_7464, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_7465, 1); retd(); return;                         /* ret */
        }
    }
}
