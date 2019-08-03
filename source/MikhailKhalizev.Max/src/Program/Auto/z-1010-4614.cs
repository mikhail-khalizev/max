using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("49a72cd6-61bc-4f34-9e9c-1051feec030b")]
        public void Method_1010_4614()
        {
            ii(0x1010_4614, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1010_4619, 5); calld(Definitions.sys_check_available_stack_size, 0x61734); /* call 0x10165d52 */
            ii(0x1010_461e, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_461f, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_4620, 1); pushd(esi);                             /* push esi */
            ii(0x1010_4621, 1); pushd(edi);                             /* push edi */
            ii(0x1010_4622, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_4623, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_4625, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1010_462b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1010_462e, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1010_4631, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1010_4634, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_4637, 5); calld(0x1013_a5af, 0x35f73);            /* call 0x1013a5af */
            ii(0x1010_463c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_463e, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_463f, 1); popd(edi);                              /* pop edi */
            ii(0x1010_4640, 1); popd(esi);                              /* pop esi */
            ii(0x1010_4641, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_4642, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_4643, 1); retd(); return;                         /* ret */
        }
    }
}
