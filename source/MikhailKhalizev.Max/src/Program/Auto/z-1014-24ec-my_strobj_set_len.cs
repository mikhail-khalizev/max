using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("1b21ddef-a4ba-4751-bfa5-7c631f6f436f")]
        public void my_strobj_set_len()
        {
            ii(0x1014_24ec, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1014_24f1, 5); calld(Definitions.sys_check_available_stack_size, 0x2_385c); /* call 0x10165d52 */
            ii(0x1014_24f6, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_24f7, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_24f8, 1); pushd(esi);                             /* push esi */
            ii(0x1014_24f9, 1); pushd(edi);                             /* push edi */
            ii(0x1014_24fa, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_24fb, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_24fd, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1014_2503, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_2506, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1014_2509, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_250c, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_250f, 4); mov(memw_a32[ds, edx + 0x6], ax);       /* mov [edx+0x6], ax */
            ii(0x1014_2513, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_2515, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_2516, 1); popd(edi);                              /* pop edi */
            ii(0x1014_2517, 1); popd(esi);                              /* pop esi */
            ii(0x1014_2518, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_2519, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_251a, 1); retd(); return;                         /* ret */
        }
    }
}
