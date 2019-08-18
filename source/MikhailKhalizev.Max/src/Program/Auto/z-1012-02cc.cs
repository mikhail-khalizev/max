using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_02cc-e0ac88a4")]
        public void Method_1012_02cc()
        {
            ii(0x1012_02cc, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1012_02d1, 5); calld(Definitions.sys_check_available_stack_size, 0x4_5a7c); /* call 0x10165d52 */
            ii(0x1012_02d6, 1); pushd(ebx);                             /* push ebx */
            ii(0x1012_02d7, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_02d8, 1); pushd(esi);                             /* push esi */
            ii(0x1012_02d9, 1); pushd(edi);                             /* push edi */
            ii(0x1012_02da, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_02db, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_02dd, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1012_02e3, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1012_02e6, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1012_02e9, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1012_02ee, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_02f1, 5); calld(0x100c_a200, -0x5_60f6);          /* call 0x100ca200 */
            ii(0x1012_02f6, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1012_02f9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_02fc, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1012_02ff, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_0302, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_0304, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_0305, 1); popd(edi);                              /* pop edi */
            ii(0x1012_0306, 1); popd(esi);                              /* pop esi */
            ii(0x1012_0307, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_0308, 1); popd(ebx);                              /* pop ebx */
            ii(0x1012_0309, 1); retd(); return;                         /* ret */
        }
    }
}
