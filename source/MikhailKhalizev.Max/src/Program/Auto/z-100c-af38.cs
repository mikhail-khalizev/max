using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_af38-2180737")]
        public void Method_100c_af38()
        {
            ii(0x100c_af38, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100c_af3d, 5); calld(Definitions.sys_check_available_stack_size, 0x9_ae10); /* call 0x10165d52 */
            ii(0x100c_af42, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_af43, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_af44, 1); pushd(edx);                             /* push edx */
            ii(0x100c_af45, 1); pushd(esi);                             /* push esi */
            ii(0x100c_af46, 1); pushd(edi);                             /* push edi */
            ii(0x100c_af47, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_af48, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_af4a, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100c_af50, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100c_af53, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_af56, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100c_af58, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_af5b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_af5e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_af60, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_af61, 1); popd(edi);                              /* pop edi */
            ii(0x100c_af62, 1); popd(esi);                              /* pop esi */
            ii(0x100c_af63, 1); popd(edx);                              /* pop edx */
            ii(0x100c_af64, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_af65, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_af66, 1); retd(); return;                         /* ret */
        }
    }
}
