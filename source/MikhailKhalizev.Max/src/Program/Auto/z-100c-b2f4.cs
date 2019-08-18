using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_b2f4-15513b50")]
        public void Method_100c_b2f4()
        {
            ii(0x100c_b2f4, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100c_b2f9, 5); calld(Definitions.sys_check_available_stack_size, 0x9_aa54); /* call 0x10165d52 */
            ii(0x100c_b2fe, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_b2ff, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_b300, 1); pushd(edx);                             /* push edx */
            ii(0x100c_b301, 1); pushd(esi);                             /* push esi */
            ii(0x100c_b302, 1); pushd(edi);                             /* push edi */
            ii(0x100c_b303, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_b304, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_b306, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100c_b30c, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100c_b30f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_b312, 3); mov(al, memb_a32[ds, eax + 0x6]);       /* mov al, [eax+0x6] */
            ii(0x100c_b315, 3); mov(memb_a32[ss, ebp - 0x8], al);       /* mov [ebp-0x8], al */
            ii(0x100c_b318, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x100c_b31b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_b31d, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_b31e, 1); popd(edi);                              /* pop edi */
            ii(0x100c_b31f, 1); popd(esi);                              /* pop esi */
            ii(0x100c_b320, 1); popd(edx);                              /* pop edx */
            ii(0x100c_b321, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_b322, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_b323, 1); retd(); return;                         /* ret */
        }
    }
}
