using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("031e9258-52f5-4a42-a0bc-2870782a0a57")]
        public void Method_1008_7449()
        {
            ii(0x1008_7449, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1008_744e, 5); calld(Definitions.sys_check_available_stack_size, 0xd_e8ff); /* call 0x10165d52 */
            ii(0x1008_7453, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_7454, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_7455, 1); pushd(edx);                             /* push edx */
            ii(0x1008_7456, 1); pushd(esi);                             /* push esi */
            ii(0x1008_7457, 1); pushd(edi);                             /* push edi */
            ii(0x1008_7458, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_7459, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_745b, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1008_7461, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1008_7464, 4); mov(memb_a32[ss, ebp - 0x8], 0x2a);     /* mov byte [ebp-0x8], 0x2a */
            ii(0x1008_7468, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x1008_746b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_746d, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_746e, 1); popd(edi);                              /* pop edi */
            ii(0x1008_746f, 1); popd(esi);                              /* pop esi */
            ii(0x1008_7470, 1); popd(edx);                              /* pop edx */
            ii(0x1008_7471, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_7472, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_7473, 1); retd(); return;                         /* ret */
        }
    }
}
