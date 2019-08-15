using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("4dd0cde1-9964-4c59-bbef-90272c368930")]
        public void Method_1008_7e0e()
        {
            ii(0x1008_7e0e, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1008_7e13, 5); calld(Definitions.sys_check_available_stack_size, 0xd_df3a); /* call 0x10165d52 */
            ii(0x1008_7e18, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_7e19, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_7e1a, 1); pushd(edx);                             /* push edx */
            ii(0x1008_7e1b, 1); pushd(esi);                             /* push esi */
            ii(0x1008_7e1c, 1); pushd(edi);                             /* push edi */
            ii(0x1008_7e1d, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_7e1e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_7e20, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1008_7e26, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1008_7e29, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1008_7e2c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_7e2f, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1008_7e32, 5); calld(0x1007_6574, -0x1_18c3);          /* call 0x10076574 */
            ii(0x1008_7e37, 5); calld(0x1015_2783, 0xc_a947);           /* call 0x10152783 */
            ii(0x1008_7e3c, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1008_7e41, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_7e44, 5); calld(0x100a_2a04, 0x1_abbb);           /* call 0x100a2a04 */
            ii(0x1008_7e49, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_7e4b, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_7e4c, 1); popd(edi);                              /* pop edi */
            ii(0x1008_7e4d, 1); popd(esi);                              /* pop esi */
            ii(0x1008_7e4e, 1); popd(edx);                              /* pop edx */
            ii(0x1008_7e4f, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_7e50, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_7e51, 1); retd(); return;                         /* ret */
        }
    }
}
