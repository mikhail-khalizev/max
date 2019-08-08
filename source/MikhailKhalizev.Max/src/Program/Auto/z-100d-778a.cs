using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("6fc8a11a-b325-4d60-a399-5e95650001c4")]
        public void Method_100d_778a()
        {
            ii(0x100d_778a, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100d_778f, 5); calld(Definitions.sys_check_available_stack_size, 0x8_e5be); /* call 0x10165d52 */
            ii(0x100d_7794, 1); pushd(ebx);                             /* push ebx */
            ii(0x100d_7795, 1); pushd(ecx);                             /* push ecx */
            ii(0x100d_7796, 1); pushd(esi);                             /* push esi */
            ii(0x100d_7797, 1); pushd(edi);                             /* push edi */
            ii(0x100d_7798, 1); pushd(ebp);                             /* push ebp */
            ii(0x100d_7799, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_779b, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100d_77a1, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100d_77a4, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100d_77a7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_77aa, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_77ad, 4); mov(memw_a32[ds, edx + 0x2b], ax);      /* mov [edx+0x2b], ax */
            ii(0x100d_77b1, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_77b3, 1); popd(ebp);                              /* pop ebp */
            ii(0x100d_77b4, 1); popd(edi);                              /* pop edi */
            ii(0x100d_77b5, 1); popd(esi);                              /* pop esi */
            ii(0x100d_77b6, 1); popd(ecx);                              /* pop ecx */
            ii(0x100d_77b7, 1); popd(ebx);                              /* pop ebx */
            ii(0x100d_77b8, 1); retd(); return;                         /* ret */
        }
    }
}
