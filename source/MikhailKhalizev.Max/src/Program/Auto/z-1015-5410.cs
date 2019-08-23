using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_5410-52b4ff81")]
        public void Method_1015_5410()
        {
            ii(0x1015_5410, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1015_5415, 5); calld(Definitions.sys_check_available_stack_size, 0x1_0938); /* call 0x10165d52 */
            ii(0x1015_541a, 1); pushd(ebx);                             /* push ebx */
            ii(0x1015_541b, 1); pushd(ecx);                             /* push ecx */
            ii(0x1015_541c, 1); pushd(esi);                             /* push esi */
            ii(0x1015_541d, 1); pushd(edi);                             /* push edi */
            ii(0x1015_541e, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_541f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_5421, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1015_5427, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1015_542a, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1015_542d, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1015_5430, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_5433, 5); calld(0x1013_bb11, -0x1_9927);          /* call 0x1013bb11 */
            ii(0x1015_5438, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_543a, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_543b, 1); popd(edi);                              /* pop edi */
            ii(0x1015_543c, 1); popd(esi);                              /* pop esi */
            ii(0x1015_543d, 1); popd(ecx);                              /* pop ecx */
            ii(0x1015_543e, 1); popd(ebx);                              /* pop ebx */
            ii(0x1015_543f, 1); retd();                                 /* ret */
        }
    }
}
