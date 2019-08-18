using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("ad7a4914-61d6-4882-99b6-c70eb27dd62b")]
        public void Method_1008_b01c()
        {
            ii(0x1008_b01c, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1008_b021, 5); calld(Definitions.sys_check_available_stack_size, 0xd_ad2c); /* call 0x10165d52 */
            ii(0x1008_b026, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_b027, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_b028, 1); pushd(esi);                             /* push esi */
            ii(0x1008_b029, 1); pushd(edi);                             /* push edi */
            ii(0x1008_b02a, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_b02b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_b02d, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1008_b033, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_b036, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1008_b039, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1008_b03c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_b03f, 5); calld(0x1013_ac03, 0xa_fbbf);           /* call 0x1013ac03 */
            ii(0x1008_b044, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_b047, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1008_b04a, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1008_b04d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_b050, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1008_b053, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1008_b056, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_b058, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_b059, 1); popd(edi);                              /* pop edi */
            ii(0x1008_b05a, 1); popd(esi);                              /* pop esi */
            ii(0x1008_b05b, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_b05c, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_b05d, 1); retd(); return;                         /* ret */
        }
    }
}
