using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("d0fd52ec-611e-48ac-a717-15958a8e3347")]
        public void Method_100c_8978()
        {
            ii(0x100c_8978, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100c_897d, 5); calld(Definitions.sys_check_available_stack_size, 0x9_d3d0); /* call 0x10165d52 */
            ii(0x100c_8982, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_8983, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_8984, 1); pushd(edx);                             /* push edx */
            ii(0x100c_8985, 1); pushd(esi);                             /* push esi */
            ii(0x100c_8986, 1); pushd(edi);                             /* push edi */
            ii(0x100c_8987, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_8988, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_898a, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100c_8990, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100c_8993, 7); mov(memd_a32[ss, ebp - 0x8], 0x4);      /* mov dword [ebp-0x8], 0x4 */
            ii(0x100c_899a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_899d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_899f, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_89a0, 1); popd(edi);                              /* pop edi */
            ii(0x100c_89a1, 1); popd(esi);                              /* pop esi */
            ii(0x100c_89a2, 1); popd(edx);                              /* pop edx */
            ii(0x100c_89a3, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_89a4, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_89a5, 1); retd(); return;                         /* ret */
        }
    }
}
