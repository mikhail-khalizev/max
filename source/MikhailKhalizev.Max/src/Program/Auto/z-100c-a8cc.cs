using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_a8cc-5f32fe04")]
        public void Method_100c_a8cc()
        {
            ii(0x100c_a8cc, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100c_a8d1, 5); calld(Definitions.sys_check_available_stack_size, 0x9_b47c); /* call 0x10165d52 */
            ii(0x100c_a8d6, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_a8d7, 1); pushd(esi);                             /* push esi */
            ii(0x100c_a8d8, 1); pushd(edi);                             /* push edi */
            ii(0x100c_a8d9, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_a8da, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_a8dc, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100c_a8e2, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100c_a8e5, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x100c_a8e8, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x100c_a8eb, 4); movsx(ebx, memw_a32[ss, ebp - 0x4]);    /* movsx ebx, word [ebp-0x4] */
            ii(0x100c_a8ef, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100c_a8f2, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_a8f5, 5); calld(0x1013_b0f9, 0x7_07ff);           /* call 0x1013b0f9 */
            ii(0x100c_a8fa, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_a8fc, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_a8fd, 1); popd(edi);                              /* pop edi */
            ii(0x100c_a8fe, 1); popd(esi);                              /* pop esi */
            ii(0x100c_a8ff, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_a900, 1); retd();                                 /* ret */
        }
    }
}
