using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a7f87334-eaac-468f-81d3-c05854cafc56")]
        public void Method_1008_969c()
        {
            ii(0x1008_969c, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1008_96a1, 5); calld(Definitions.sys_check_available_stack_size, 0xd_c6ac); /* call 0x10165d52 */
            ii(0x1008_96a6, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_96a7, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_96a8, 1); pushd(esi);                             /* push esi */
            ii(0x1008_96a9, 1); pushd(edi);                             /* push edi */
            ii(0x1008_96aa, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_96ab, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_96ad, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1008_96b3, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_96b6, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1008_96b9, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1008_96bc, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_96bf, 5); calld(0x1013_ac03, 0xb_153f);           /* call 0x1013ac03 */
            ii(0x1008_96c4, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_96c7, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1008_96ca, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1008_96cd, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_96d0, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1008_96d3, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1008_96d6, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_96d8, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_96d9, 1); popd(edi);                              /* pop edi */
            ii(0x1008_96da, 1); popd(esi);                              /* pop esi */
            ii(0x1008_96db, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_96dc, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_96dd, 1); retd(); return;                         /* ret */
        }
    }
}
