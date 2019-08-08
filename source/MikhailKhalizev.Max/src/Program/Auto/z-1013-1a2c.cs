using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("8a0b505b-b493-4527-b5ac-fc851330374e")]
        public void Method_1013_1a2c()
        {
            ii(0x1013_1a2c, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1013_1a31, 5); calld(Definitions.sys_check_available_stack_size, 0x3_431c); /* call 0x10165d52 */
            ii(0x1013_1a36, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_1a37, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_1a38, 1); pushd(edx);                             /* push edx */
            ii(0x1013_1a39, 1); pushd(esi);                             /* push esi */
            ii(0x1013_1a3a, 1); pushd(edi);                             /* push edi */
            ii(0x1013_1a3b, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_1a3c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_1a3e, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1013_1a44, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1013_1a47, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_1a4a, 3); add(eax, 0xa);                          /* add eax, 0xa */
            ii(0x1013_1a4d, 5); calld(Definitions.my_strobj_c_str_v2, -0xa_828a); /* call 0x100897c8 */
            ii(0x1013_1a52, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_1a55, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_1a58, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_1a5a, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_1a5b, 1); popd(edi);                              /* pop edi */
            ii(0x1013_1a5c, 1); popd(esi);                              /* pop esi */
            ii(0x1013_1a5d, 1); popd(edx);                              /* pop edx */
            ii(0x1013_1a5e, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_1a5f, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_1a60, 1); retd(); return;                         /* ret */
        }
    }
}
