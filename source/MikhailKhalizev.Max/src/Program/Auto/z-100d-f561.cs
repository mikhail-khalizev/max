using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_f561-af972dd6")]
        public void Method_100d_f561()
        {
            ii(0x100d_f561, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x100d_f566, 5); calld(Definitions.sys_check_available_stack_size, 0x8_67e7); /* call 0x10165d52 */
            ii(0x100d_f56b, 1); pushd(ecx);                             /* push ecx */
            ii(0x100d_f56c, 1); pushd(esi);                             /* push esi */
            ii(0x100d_f56d, 1); pushd(edi);                             /* push edi */
            ii(0x100d_f56e, 1); pushd(ebp);                             /* push ebp */
            ii(0x100d_f56f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_f571, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x100d_f577, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100d_f57a, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100d_f57d, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x100d_f580, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_f583, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100d_f586, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_f589, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x100d_f58c, 3); mov(memw_a32[ds, edx], ax);             /* mov [edx], ax */
            ii(0x100d_f58f, 3); mov(ebx, memd_a32[ss, ebp - 0x10]);     /* mov ebx, [ebp-0x10] */
            ii(0x100d_f592, 3); add(ebx, 0x2);                          /* add ebx, 0x2 */
            ii(0x100d_f595, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x100d_f599, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100d_f59c, 5); calld(0x100d_f329, -0x278);             /* call 0x100df329 */
            ii(0x100d_f5a1, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x100d_f5a3, 5); calld(0x1016_3e96, 0x8_48ee);           /* call 0x10163e96 */
            ii(0x100d_f5a8, 5); add(eax, 0x2);                          /* add eax, 0x2 */
            ii(0x100d_f5ad, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100d_f5b0, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100d_f5b3, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_f5b5, 1); popd(ebp);                              /* pop ebp */
            ii(0x100d_f5b6, 1); popd(edi);                              /* pop edi */
            ii(0x100d_f5b7, 1); popd(esi);                              /* pop esi */
            ii(0x100d_f5b8, 1); popd(ecx);                              /* pop ecx */
            ii(0x100d_f5b9, 1); retd(); return;                         /* ret */
        }
    }
}
