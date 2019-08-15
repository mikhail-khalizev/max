using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("66999746-3aba-42cc-810d-c20ed237d363")]
        public void Method_1008_9acc()
        {
            ii(0x1008_9acc, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1008_9ad1, 5); calld(Definitions.sys_check_available_stack_size, 0xd_c27c); /* call 0x10165d52 */
            ii(0x1008_9ad6, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_9ad7, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_9ad8, 1); pushd(edx);                             /* push edx */
            ii(0x1008_9ad9, 1); pushd(esi);                             /* push esi */
            ii(0x1008_9ada, 1); pushd(edi);                             /* push edi */
            ii(0x1008_9adb, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_9adc, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_9ade, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1008_9ae4, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1008_9ae7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_9aea, 5); calld(0x1007_6c30, -0x1_2ebf);          /* call 0x10076c30 */
            ii(0x1008_9aef, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_9af2, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_9af5, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_9af7, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_9af8, 1); popd(edi);                              /* pop edi */
            ii(0x1008_9af9, 1); popd(esi);                              /* pop esi */
            ii(0x1008_9afa, 1); popd(edx);                              /* pop edx */
            ii(0x1008_9afb, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_9afc, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_9afd, 1); retd(); return;                         /* ret */
        }
    }
}
