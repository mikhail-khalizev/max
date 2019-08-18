using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("9852844d-a143-48ce-87eb-ba67c56bd7ec")]
        public void Method_100c_b460()
        {
            ii(0x100c_b460, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100c_b465, 5); calld(Definitions.sys_check_available_stack_size, 0x9_a8e8); /* call 0x10165d52 */
            ii(0x100c_b46a, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_b46b, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_b46c, 1); pushd(edx);                             /* push edx */
            ii(0x100c_b46d, 1); pushd(esi);                             /* push esi */
            ii(0x100c_b46e, 1); pushd(edi);                             /* push edi */
            ii(0x100c_b46f, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_b470, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_b472, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100c_b478, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100c_b47b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_b47e, 3); mov(al, memb_a32[ds, eax + 0x1f]);      /* mov al, [eax+0x1f] */
            ii(0x100c_b481, 3); mov(memb_a32[ss, ebp - 0x8], al);       /* mov [ebp-0x8], al */
            ii(0x100c_b484, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x100c_b487, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_b489, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_b48a, 1); popd(edi);                              /* pop edi */
            ii(0x100c_b48b, 1); popd(esi);                              /* pop esi */
            ii(0x100c_b48c, 1); popd(edx);                              /* pop edx */
            ii(0x100c_b48d, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_b48e, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_b48f, 1); retd(); return;                         /* ret */
        }
    }
}
