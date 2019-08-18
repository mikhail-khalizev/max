using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_b7cf-7915b7c6")]
        public void Method_1009_b7cf()
        {
            ii(0x1009_b7cf, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1009_b7d4, 5); calld(Definitions.sys_check_available_stack_size, 0xc_a579); /* call 0x10165d52 */
            ii(0x1009_b7d9, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_b7da, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_b7db, 1); pushd(esi);                             /* push esi */
            ii(0x1009_b7dc, 1); pushd(edi);                             /* push edi */
            ii(0x1009_b7dd, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_b7de, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_b7e0, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1009_b7e6, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_b7e9, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1009_b7ec, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1009_b7ef, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_b7f2, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1009_b7f5, 5); calld(0x1008_aab4, -0x1_0d46);          /* call 0x1008aab4 */
            ii(0x1009_b7fa, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_b7fc, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_b7fd, 1); popd(edi);                              /* pop edi */
            ii(0x1009_b7fe, 1); popd(esi);                              /* pop esi */
            ii(0x1009_b7ff, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_b800, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_b801, 1); retd(); return;                         /* ret */
        }
    }
}
