using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("54e66cab-8114-47fd-932c-4608b6f28f7d")]
        public void Method_1013_6564()
        {
            ii(0x1013_6564, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1013_6569, 5); calld(Definitions.sys_check_available_stack_size, 0x2f7e4); /* call 0x10165d52 */
            ii(0x1013_656e, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_656f, 1); pushd(esi);                             /* push esi */
            ii(0x1013_6570, 1); pushd(edi);                             /* push edi */
            ii(0x1013_6571, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_6572, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_6574, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1013_657a, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1013_657d, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1013_6580, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x1013_6583, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1013_6586, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1013_658a, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1013_658d, 3); mov(ebx, memd_a32[ss, ebp - 0xc]);      /* mov ebx, [ebp-0xc] */
            ii(0x1013_6590, 3); add(ebx, 0x8);                          /* add ebx, 0x8 */
            ii(0x1013_6593, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1013_6595, 5); calld(0x100c_b77c, -0x6ae1e);           /* call 0x100cb77c */
            ii(0x1013_659a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_659c, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_659d, 1); popd(edi);                              /* pop edi */
            ii(0x1013_659e, 1); popd(esi);                              /* pop esi */
            ii(0x1013_659f, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_65a0, 1); retd(); return;                         /* ret */
        }
    }
}
