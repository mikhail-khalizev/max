using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("813df537-c6b0-4881-a740-7addac836046")]
        public void Method_1013_c53c()
        {
            ii(0x1013_c53c, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1013_c541, 5); calld(Definitions.sys_check_available_stack_size, 0x2980c); /* call 0x10165d52 */
            ii(0x1013_c546, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_c547, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_c548, 1); pushd(esi);                             /* push esi */
            ii(0x1013_c549, 1); pushd(edi);                             /* push edi */
            ii(0x1013_c54a, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_c54b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_c54d, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1013_c553, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_c556, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1013_c559, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1013_c55c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_c55f, 5); calld(0x1007_6d14, -0xc5850);           /* call 0x10076d14 */
            ii(0x1013_c564, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_c567, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1013_c56a, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1013_c56d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_c570, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1013_c573, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_c576, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_c578, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_c579, 1); popd(edi);                              /* pop edi */
            ii(0x1013_c57a, 1); popd(esi);                              /* pop esi */
            ii(0x1013_c57b, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_c57c, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_c57d, 1); retd(); return;                         /* ret */
        }
    }
}
