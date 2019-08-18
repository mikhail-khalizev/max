using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_6d14-f7321788")]
        public void Method_1007_6d14()
        {
            ii(0x1007_6d14, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1007_6d19, 5); calld(Definitions.sys_check_available_stack_size, 0xe_f034); /* call 0x10165d52 */
            ii(0x1007_6d1e, 1); pushd(ebx);                             /* push ebx */
            ii(0x1007_6d1f, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_6d20, 1); pushd(esi);                             /* push esi */
            ii(0x1007_6d21, 1); pushd(edi);                             /* push edi */
            ii(0x1007_6d22, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_6d23, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_6d25, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1007_6d2b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1007_6d2e, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1007_6d31, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1007_6d34, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_6d37, 5); calld(0x1013_abc3, 0xc_3e87);           /* call 0x1013abc3 */
            ii(0x1007_6d3c, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1007_6d3f, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1007_6d42, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1007_6d45, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_6d48, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1007_6d4b, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1007_6d4e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_6d50, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_6d51, 1); popd(edi);                              /* pop edi */
            ii(0x1007_6d52, 1); popd(esi);                              /* pop esi */
            ii(0x1007_6d53, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_6d54, 1); popd(ebx);                              /* pop ebx */
            ii(0x1007_6d55, 1); retd(); return;                         /* ret */
        }
    }
}
