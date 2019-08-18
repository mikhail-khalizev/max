using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_808c-d4fd53e8")]
        public void Method_100b_808c()
        {
            ii(0x100b_808c, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100b_8091, 5); calld(Definitions.sys_check_available_stack_size, 0xa_dcbc); /* call 0x10165d52 */
            ii(0x100b_8096, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_8097, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_8098, 1); pushd(esi);                             /* push esi */
            ii(0x100b_8099, 1); pushd(edi);                             /* push edi */
            ii(0x100b_809a, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_809b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_809d, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100b_80a3, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_80a6, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100b_80a9, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100b_80ac, 3); add(edx, 0xa);                          /* add edx, 0xa */
            ii(0x100b_80af, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_80b2, 5); calld(0x1007_5e64, -0x4_2253);          /* call 0x10075e64 */
            ii(0x100b_80b7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_80ba, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_80bc, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_80bd, 1); popd(edi);                              /* pop edi */
            ii(0x100b_80be, 1); popd(esi);                              /* pop esi */
            ii(0x100b_80bf, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_80c0, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_80c1, 1); retd(); return;                         /* ret */
        }
    }
}
