using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("1b99cb6e-dcb9-4d2c-9e82-8cf5c2af5306")]
        public void Method_1008_aa4c()
        {
            ii(0x1008_aa4c, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1008_aa51, 5); calld(Definitions.sys_check_available_stack_size, 0xd_b2fc); /* call 0x10165d52 */
            ii(0x1008_aa56, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_aa57, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_aa58, 1); pushd(edx);                             /* push edx */
            ii(0x1008_aa59, 1); pushd(esi);                             /* push esi */
            ii(0x1008_aa5a, 1); pushd(edi);                             /* push edi */
            ii(0x1008_aa5b, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_aa5c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_aa5e, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1008_aa64, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1008_aa67, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_aa6a, 6); mov(al, memb_a32[ds, eax + 0xa6]);      /* mov al, [eax+0xa6] */
            ii(0x1008_aa70, 3); mov(memb_a32[ss, ebp - 0x8], al);       /* mov [ebp-0x8], al */
            ii(0x1008_aa73, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x1008_aa76, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_aa78, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_aa79, 1); popd(edi);                              /* pop edi */
            ii(0x1008_aa7a, 1); popd(esi);                              /* pop esi */
            ii(0x1008_aa7b, 1); popd(edx);                              /* pop edx */
            ii(0x1008_aa7c, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_aa7d, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_aa7e, 1); retd(); return;                         /* ret */
        }
    }
}
