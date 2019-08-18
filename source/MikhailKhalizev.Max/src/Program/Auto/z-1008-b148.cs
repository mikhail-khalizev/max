using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("8db036a9-7daa-4c1a-92db-7939cf4db47d")]
        public void Method_1008_b148()
        {
            ii(0x1008_b148, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1008_b14d, 5); calld(Definitions.sys_check_available_stack_size, 0xd_ac00); /* call 0x10165d52 */
            ii(0x1008_b152, 1); pushd(esi);                             /* push esi */
            ii(0x1008_b153, 1); pushd(edi);                             /* push edi */
            ii(0x1008_b154, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_b155, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_b157, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1008_b15d, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1008_b160, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x1008_b163, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x1008_b166, 3); mov(memd_a32[ss, ebp - 0x8], ecx);      /* mov [ebp-0x8], ecx */
            ii(0x1008_b169, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1008_b16d, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1008_b170, 2); mov(memd_a32[ds, edx], eax);            /* mov [edx], eax */
            ii(0x1008_b172, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1008_b176, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1008_b179, 3); mov(memd_a32[ds, edx + 0x4], eax);      /* mov [edx+0x4], eax */
            ii(0x1008_b17c, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1008_b180, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1008_b183, 3); mov(memd_a32[ds, edx + 0x8], eax);      /* mov [edx+0x8], eax */
            ii(0x1008_b186, 4); movsx(eax, memw_a32[ss, ebp + 0x10]);   /* movsx eax, word [ebp+0x10] */
            ii(0x1008_b18a, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1008_b18d, 3); mov(memd_a32[ds, edx + 0xc], eax);      /* mov [edx+0xc], eax */
            ii(0x1008_b190, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1008_b193, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1008_b196, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1008_b199, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_b19b, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_b19c, 1); popd(edi);                              /* pop edi */
            ii(0x1008_b19d, 1); popd(esi);                              /* pop esi */
            ii(0x1008_b19e, 3); retd(0x4); return;                      /* ret 0x4 */
        }
    }
}
