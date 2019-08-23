using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_06dc-6c57397b")]
        public void Method_100e_06dc()
        {
            ii(0x100e_06dc, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x100e_06e1, 5); calld(Definitions.sys_check_available_stack_size, 0x8_566c); /* call 0x10165d52 */
            ii(0x100e_06e6, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_06e7, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_06e8, 1); pushd(esi);                             /* push esi */
            ii(0x100e_06e9, 1); pushd(edi);                             /* push edi */
            ii(0x100e_06ea, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_06eb, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_06ed, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100e_06f3, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_06f6, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100e_06f9, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100e_06fc, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_06ff, 5); calld(0x1013_ac03, 0x5_a4ff);           /* call 0x1013ac03 */
            ii(0x100e_0704, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_0707, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x100e_070a, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100e_070d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_0710, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100e_0713, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_0716, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_0718, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_0719, 1); popd(edi);                              /* pop edi */
            ii(0x100e_071a, 1); popd(esi);                              /* pop esi */
            ii(0x100e_071b, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_071c, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_071d, 1); retd();                                 /* ret */
        }
    }
}
