using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("ef04ed84-42d5-4882-8ed4-705090a752cd")]
        public void Method_100c_b1dc()
        {
            ii(0x100c_b1dc, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x100c_b1e1, 5); calld(Definitions.sys_check_available_stack_size, 0x9_ab6c); /* call 0x10165d52 */
            ii(0x100c_b1e6, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_b1e7, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_b1e8, 1); pushd(edx);                             /* push edx */
            ii(0x100c_b1e9, 1); pushd(esi);                             /* push esi */
            ii(0x100c_b1ea, 1); pushd(edi);                             /* push edi */
            ii(0x100c_b1eb, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_b1ec, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_b1ee, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100c_b1f4, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100c_b1f7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_b1fa, 5); calld(0x1007_6d58, -0x5_44a7);          /* call 0x10076d58 */
            ii(0x100c_b1ff, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100c_b202, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x100c_b205, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_b208, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_b20b, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100c_b20e, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_b211, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_b213, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_b214, 1); popd(edi);                              /* pop edi */
            ii(0x100c_b215, 1); popd(esi);                              /* pop esi */
            ii(0x100c_b216, 1); popd(edx);                              /* pop edx */
            ii(0x100c_b217, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_b218, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_b219, 1); retd(); return;                         /* ret */
        }
    }
}
