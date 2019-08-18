using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_80f4-f7fe4242")]
        public void Method_100b_80f4()
        {
            ii(0x100b_80f4, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100b_80f9, 5); calld(Definitions.sys_check_available_stack_size, 0xa_dc54); /* call 0x10165d52 */
            ii(0x100b_80fe, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_80ff, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_8100, 1); pushd(edx);                             /* push edx */
            ii(0x100b_8101, 1); pushd(esi);                             /* push esi */
            ii(0x100b_8102, 1); pushd(edi);                             /* push edi */
            ii(0x100b_8103, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_8104, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_8106, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100b_810c, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100b_810f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_8112, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100b_8114, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_8117, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_811a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_811c, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_811d, 1); popd(edi);                              /* pop edi */
            ii(0x100b_811e, 1); popd(esi);                              /* pop esi */
            ii(0x100b_811f, 1); popd(edx);                              /* pop edx */
            ii(0x100b_8120, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_8121, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_8122, 1); retd(); return;                         /* ret */
        }
    }
}
