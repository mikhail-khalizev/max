using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("e05c2977-2ad6-45d8-9496-fb36f9ed7726")]
        public void my_3_get_count()
        {
            ii(0x1008_b480, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1008_b485, 5); calld(Definitions.sys_check_available_stack_size, 0xd_a8c8); /* call 0x10165d52 */
            ii(0x1008_b48a, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_b48b, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_b48c, 1); pushd(edx);                             /* push edx */
            ii(0x1008_b48d, 1); pushd(esi);                             /* push esi */
            ii(0x1008_b48e, 1); pushd(edi);                             /* push edi */
            ii(0x1008_b48f, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_b490, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_b492, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1008_b498, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1008_b49b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_b49e, 4); mov(ax, memw_a32[ds, eax + 0x2]);       /* mov ax, [eax+0x2] */
            ii(0x1008_b4a2, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_b4a5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_b4a8, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_b4aa, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_b4ab, 1); popd(edi);                              /* pop edi */
            ii(0x1008_b4ac, 1); popd(esi);                              /* pop esi */
            ii(0x1008_b4ad, 1); popd(edx);                              /* pop edx */
            ii(0x1008_b4ae, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_b4af, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_b4b0, 1); retd(); return;                         /* ret */
        }
    }
}
