using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_85fc-b1869906")]
        public void Method_100e_85fc()
        {
            ii(0x100e_85fc, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100e_8601, 5); calld(Definitions.sys_check_available_stack_size, 0x7_d74c); /* call 0x10165d52 */
            ii(0x100e_8606, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_8607, 1); pushd(esi);                             /* push esi */
            ii(0x100e_8608, 1); pushd(edi);                             /* push edi */
            ii(0x100e_8609, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_860a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_860c, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100e_8612, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100e_8615, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x100e_8618, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x100e_861b, 4); movsx(ebx, memw_a32[ss, ebp - 0x4]);    /* movsx ebx, word [ebp-0x4] */
            ii(0x100e_861f, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100e_8622, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_8625, 5); calld(0x1013_b0f9, 0x5_2acf);           /* call 0x1013b0f9 */
            ii(0x100e_862a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_862c, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_862d, 1); popd(edi);                              /* pop edi */
            ii(0x100e_862e, 1); popd(esi);                              /* pop esi */
            ii(0x100e_862f, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_8630, 1); retd();                                 /* ret */
        }
    }
}
