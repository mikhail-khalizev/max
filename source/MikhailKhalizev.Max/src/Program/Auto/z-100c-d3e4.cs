using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_d3e4-aa934a37")]
        public void Method_100c_d3e4()
        {
            ii(0x100c_d3e4, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100c_d3e9, 5); calld(Definitions.sys_check_available_stack_size, 0x9_8964); /* call 0x10165d52 */
            ii(0x100c_d3ee, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_d3ef, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_d3f0, 1); pushd(edx);                             /* push edx */
            ii(0x100c_d3f1, 1); pushd(esi);                             /* push esi */
            ii(0x100c_d3f2, 1); pushd(edi);                             /* push edi */
            ii(0x100c_d3f3, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_d3f4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_d3f6, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100c_d3fc, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100c_d3ff, 7); mov(memd_a32[ss, ebp - 0x8], 0x4);      /* mov dword [ebp-0x8], 0x4 */
            ii(0x100c_d406, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_d409, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_d40b, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_d40c, 1); popd(edi);                              /* pop edi */
            ii(0x100c_d40d, 1); popd(esi);                              /* pop esi */
            ii(0x100c_d40e, 1); popd(edx);                              /* pop edx */
            ii(0x100c_d40f, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_d410, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_d411, 1); retd();                                 /* ret */
        }
    }
}
