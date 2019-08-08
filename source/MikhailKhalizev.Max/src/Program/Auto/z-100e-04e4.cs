using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("9d123c84-6f30-4192-a7f1-1f789cefc4d5")]
        public void Method_100e_04e4()
        {
            ii(0x100e_04e4, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100e_04e9, 5); calld(Definitions.sys_check_available_stack_size, 0x8_5864); /* call 0x10165d52 */
            ii(0x100e_04ee, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_04ef, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_04f0, 1); pushd(edx);                             /* push edx */
            ii(0x100e_04f1, 1); pushd(esi);                             /* push esi */
            ii(0x100e_04f2, 1); pushd(edi);                             /* push edi */
            ii(0x100e_04f3, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_04f4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_04f6, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100e_04fc, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100e_04ff, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_0502, 5); calld(0x1007_6c30, -0x6_98d7);          /* call 0x10076c30 */
            ii(0x100e_0507, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_050a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_050d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_050f, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_0510, 1); popd(edi);                              /* pop edi */
            ii(0x100e_0511, 1); popd(esi);                              /* pop esi */
            ii(0x100e_0512, 1); popd(edx);                              /* pop edx */
            ii(0x100e_0513, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_0514, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_0515, 1); retd(); return;                         /* ret */
        }
    }
}
