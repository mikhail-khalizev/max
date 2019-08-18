using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("7149c499-cf3c-452d-a898-b83667103e25")]
        public void Method_100b_8340()
        {
            ii(0x100b_8340, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x100b_8345, 5); calld(Definitions.sys_check_available_stack_size, 0xa_da08); /* call 0x10165d52 */
            ii(0x100b_834a, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_834b, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_834c, 1); pushd(esi);                             /* push esi */
            ii(0x100b_834d, 1); pushd(edi);                             /* push edi */
            ii(0x100b_834e, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_834f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_8351, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100b_8357, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_835a, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100b_835d, 5); mov(ebx, 0x2);                          /* mov ebx, 0x2 */
            ii(0x100b_8362, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x100b_8366, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_8369, 5); calld(0x1013_af3b, 0x8_2bcd);           /* call 0x1013af3b */
            ii(0x100b_836e, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_8371, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x100b_8374, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100b_8377, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_837a, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100b_837d, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100b_8380, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_8382, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_8383, 1); popd(edi);                              /* pop edi */
            ii(0x100b_8384, 1); popd(esi);                              /* pop esi */
            ii(0x100b_8385, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_8386, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_8387, 1); retd(); return;                         /* ret */
        }
    }
}
