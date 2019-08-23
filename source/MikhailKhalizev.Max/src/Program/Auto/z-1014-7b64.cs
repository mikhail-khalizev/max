using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_7b64-51ef9e39")]
        public void Method_1014_7b64()
        {
            ii(0x1014_7b64, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1014_7b69, 5); calld(Definitions.sys_check_available_stack_size, 0x1_e1e4); /* call 0x10165d52 */
            ii(0x1014_7b6e, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_7b6f, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_7b70, 1); pushd(edx);                             /* push edx */
            ii(0x1014_7b71, 1); pushd(esi);                             /* push esi */
            ii(0x1014_7b72, 1); pushd(edi);                             /* push edi */
            ii(0x1014_7b73, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_7b74, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_7b76, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1014_7b7c, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1014_7b7f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_7b82, 3); mov(al, memb_a32[ds, eax + 0x1c]);      /* mov al, [eax+0x1c] */
            ii(0x1014_7b85, 3); mov(memb_a32[ss, ebp - 0x8], al);       /* mov [ebp-0x8], al */
            ii(0x1014_7b88, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x1014_7b8b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_7b8d, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_7b8e, 1); popd(edi);                              /* pop edi */
            ii(0x1014_7b8f, 1); popd(esi);                              /* pop esi */
            ii(0x1014_7b90, 1); popd(edx);                              /* pop edx */
            ii(0x1014_7b91, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_7b92, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_7b93, 1); retd();                                 /* ret */
        }
    }
}
