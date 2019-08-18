using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("d7a050df-cbf9-4c4c-bcb3-cdbdaf29b887")]
        public void Method_1014_8170()
        {
            ii(0x1014_8170, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1014_8175, 5); calld(Definitions.sys_check_available_stack_size, 0x1_dbd8); /* call 0x10165d52 */
            ii(0x1014_817a, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_817b, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_817c, 1); pushd(edx);                             /* push edx */
            ii(0x1014_817d, 1); pushd(esi);                             /* push esi */
            ii(0x1014_817e, 1); pushd(edi);                             /* push edi */
            ii(0x1014_817f, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_8180, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_8182, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1014_8188, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1014_818b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_818e, 4); mov(ax, memw_a32[ds, eax + 0x4]);       /* mov ax, [eax+0x4] */
            ii(0x1014_8192, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_8195, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_8198, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_819a, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_819b, 1); popd(edi);                              /* pop edi */
            ii(0x1014_819c, 1); popd(esi);                              /* pop esi */
            ii(0x1014_819d, 1); popd(edx);                              /* pop edx */
            ii(0x1014_819e, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_819f, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_81a0, 1); retd(); return;                         /* ret */
        }
    }
}
