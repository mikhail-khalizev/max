using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_aac8-2cc44473")]
        public void Method_100c_aac8()
        {
            ii(0x100c_aac8, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100c_aacd, 5); calld(Definitions.sys_check_available_stack_size, 0x9_b280); /* call 0x10165d52 */
            ii(0x100c_aad2, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_aad3, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_aad4, 1); pushd(edx);                             /* push edx */
            ii(0x100c_aad5, 1); pushd(esi);                             /* push esi */
            ii(0x100c_aad6, 1); pushd(edi);                             /* push edi */
            ii(0x100c_aad7, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_aad8, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_aada, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100c_aae0, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100c_aae3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_aae6, 5); calld(0x1008_b410, -0x3_f6db);          /* call 0x1008b410 */
            ii(0x100c_aaeb, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x100c_aaee, 5); calld(0x1009_cb94, -0x2_df5f);          /* call 0x1009cb94 */
            ii(0x100c_aaf3, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_aaf5, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_aaf6, 1); popd(edi);                              /* pop edi */
            ii(0x100c_aaf7, 1); popd(esi);                              /* pop esi */
            ii(0x100c_aaf8, 1); popd(edx);                              /* pop edx */
            ii(0x100c_aaf9, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_aafa, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_aafb, 1); retd(); return;                         /* ret */
        }
    }
}
