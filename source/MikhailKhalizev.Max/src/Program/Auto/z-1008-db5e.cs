using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("4b2b7d4b-22ca-47be-a010-870ee5f6db71")]
        public void Method_1008_db5e()
        {
            ii(0x1008_db5e, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1008_db63, 5); calld(Definitions.sys_check_available_stack_size, 0xd_81ea); /* call 0x10165d52 */
            ii(0x1008_db68, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_db69, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_db6a, 1); pushd(esi);                             /* push esi */
            ii(0x1008_db6b, 1); pushd(edi);                             /* push edi */
            ii(0x1008_db6c, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_db6d, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_db6f, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1008_db75, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_db78, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1008_db7b, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1008_db7e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_db81, 3); add(eax, 0x2b);                         /* add eax, 0x2b */
            ii(0x1008_db84, 5); calld(0x1009_ca08, 0xee7f);             /* call 0x1009ca08 */
            ii(0x1008_db89, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_db8b, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_db8c, 1); popd(edi);                              /* pop edi */
            ii(0x1008_db8d, 1); popd(esi);                              /* pop esi */
            ii(0x1008_db8e, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_db8f, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_db90, 1); retd(); return;                         /* ret */
        }
    }
}
