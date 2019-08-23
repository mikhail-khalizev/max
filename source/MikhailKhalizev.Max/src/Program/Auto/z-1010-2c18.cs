using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_2c18-2f7a12c1")]
        public void Method_1010_2c18()
        {
            ii(0x1010_2c18, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1010_2c1d, 5); calld(Definitions.sys_check_available_stack_size, 0x6_3130); /* call 0x10165d52 */
            ii(0x1010_2c22, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_2c23, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_2c24, 1); pushd(edx);                             /* push edx */
            ii(0x1010_2c25, 1); pushd(esi);                             /* push esi */
            ii(0x1010_2c26, 1); pushd(edi);                             /* push edi */
            ii(0x1010_2c27, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_2c28, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_2c2a, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1010_2c30, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1010_2c33, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_2c36, 5); add(eax, 0x2f0);                        /* add eax, 0x2f0 */
            ii(0x1010_2c3b, 5); calld(0x100e_0cf0, -0x2_1f50);          /* call 0x100e0cf0 */
            ii(0x1010_2c40, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1010_2c43, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_2c46, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_2c48, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_2c49, 1); popd(edi);                              /* pop edi */
            ii(0x1010_2c4a, 1); popd(esi);                              /* pop esi */
            ii(0x1010_2c4b, 1); popd(edx);                              /* pop edx */
            ii(0x1010_2c4c, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_2c4d, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_2c4e, 1); retd();                                 /* ret */
        }
    }
}
