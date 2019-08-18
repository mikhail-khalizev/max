using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("6434b9a3-ff02-42f3-ba14-4514951b332b")]
        public void Method_100c_b120()
        {
            ii(0x100c_b120, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100c_b125, 5); calld(Definitions.sys_check_available_stack_size, 0x9_ac28); /* call 0x10165d52 */
            ii(0x100c_b12a, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_b12b, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_b12c, 1); pushd(edx);                             /* push edx */
            ii(0x100c_b12d, 1); pushd(esi);                             /* push esi */
            ii(0x100c_b12e, 1); pushd(edi);                             /* push edi */
            ii(0x100c_b12f, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_b130, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_b132, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100c_b138, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100c_b13b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_b13e, 5); calld(0x1007_6c30, -0x5_4513);          /* call 0x10076c30 */
            ii(0x100c_b143, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_b146, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_b149, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_b14b, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_b14c, 1); popd(edi);                              /* pop edi */
            ii(0x100c_b14d, 1); popd(esi);                              /* pop esi */
            ii(0x100c_b14e, 1); popd(edx);                              /* pop edx */
            ii(0x100c_b14f, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_b150, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_b151, 1); retd(); return;                         /* ret */
        }
    }
}
