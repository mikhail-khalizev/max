using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("2dc012eb-9a71-4dab-b988-1c5ac579d4d9")]
        public void Method_100c_b324()
        {
            ii(0x100c_b324, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x100c_b329, 5); calld(Definitions.sys_check_available_stack_size, 0x9_aa24); /* call 0x10165d52 */
            ii(0x100c_b32e, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_b32f, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_b330, 1); pushd(edx);                             /* push edx */
            ii(0x100c_b331, 1); pushd(esi);                             /* push esi */
            ii(0x100c_b332, 1); pushd(edi);                             /* push edi */
            ii(0x100c_b333, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_b334, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_b336, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100c_b33c, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100c_b33f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_b342, 5); calld(Definitions.my_ctor_0x101b_6edc, -0x5_4503); /* call 0x10076e44 */
            ii(0x100c_b347, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100c_b34a, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x100c_b34d, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_b350, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_b353, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100c_b356, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_b359, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_b35b, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_b35c, 1); popd(edi);                              /* pop edi */
            ii(0x100c_b35d, 1); popd(esi);                              /* pop esi */
            ii(0x100c_b35e, 1); popd(edx);                              /* pop edx */
            ii(0x100c_b35f, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_b360, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_b361, 1); retd(); return;                         /* ret */
        }
    }
}
