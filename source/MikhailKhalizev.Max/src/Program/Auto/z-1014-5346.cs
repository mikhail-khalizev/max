using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("18a5762d-b5cd-4eb0-b848-54b768e6f3b4")]
        public void Method_1014_5346()
        {
            ii(0x1014_5346, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1014_534b, 5); calld(Definitions.sys_check_available_stack_size, 0x2_0a02); /* call 0x10165d52 */
            ii(0x1014_5350, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_5351, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_5352, 1); pushd(edx);                             /* push edx */
            ii(0x1014_5353, 1); pushd(esi);                             /* push esi */
            ii(0x1014_5354, 1); pushd(edi);                             /* push edi */
            ii(0x1014_5355, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_5356, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_5358, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1014_535e, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1014_5361, 5); mov(edx, StringDefinitions.ExpectingA); /* mov edx, 0x101acff2 */
            ii(0x1014_5366, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_5369, 5); calld(0x1014_5151, -0x21d);             /* call 0x10145151 */
            ii(0x1014_536e, 7); mov(memd_a32[ss, ebp - 0x8], 0);        /* mov dword [ebp-0x8], 0x0 */
            ii(0x1014_5375, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_5378, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_537a, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_537b, 1); popd(edi);                              /* pop edi */
            ii(0x1014_537c, 1); popd(esi);                              /* pop esi */
            ii(0x1014_537d, 1); popd(edx);                              /* pop edx */
            ii(0x1014_537e, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_537f, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_5380, 1); retd(); return;                         /* ret */
        }
    }
}
