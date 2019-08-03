using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("1a4c9805-eed7-45f4-97ca-084fc6b2f4ae")]
        public void Method_1011_584c()
        {
            ii(0x1011_584c, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1011_5851, 5); calld(Definitions.sys_check_available_stack_size, 0x504fc); /* call 0x10165d52 */
            ii(0x1011_5856, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_5857, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_5858, 1); pushd(edx);                             /* push edx */
            ii(0x1011_5859, 1); pushd(esi);                             /* push esi */
            ii(0x1011_585a, 1); pushd(edi);                             /* push edi */
            ii(0x1011_585b, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_585c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_585e, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1011_5864, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1011_5867, 5); calld(0x100e_88bd, -0x2cfaf);           /* call 0x100e88bd */
            ii(0x1011_586c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_586e, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1011_5872, 5); calld(0x1011_556b, -0x30c);             /* call 0x1011556b */
            ii(0x1011_5877, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_5879, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_587a, 1); popd(edi);                              /* pop edi */
            ii(0x1011_587b, 1); popd(esi);                              /* pop esi */
            ii(0x1011_587c, 1); popd(edx);                              /* pop edx */
            ii(0x1011_587d, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_587e, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_587f, 1); retd(); return;                         /* ret */
        }
    }
}