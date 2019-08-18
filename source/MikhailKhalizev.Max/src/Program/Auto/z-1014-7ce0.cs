using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_7ce0-e1d887a5")]
        public void Method_1014_7ce0()
        {
            ii(0x1014_7ce0, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1014_7ce5, 5); calld(Definitions.sys_check_available_stack_size, 0x1_e068); /* call 0x10165d52 */
            ii(0x1014_7cea, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_7ceb, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_7cec, 1); pushd(edx);                             /* push edx */
            ii(0x1014_7ced, 1); pushd(esi);                             /* push esi */
            ii(0x1014_7cee, 1); pushd(edi);                             /* push edi */
            ii(0x1014_7cef, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_7cf0, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_7cf2, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1014_7cf8, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1014_7cfb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_7cfe, 5); calld(0x1007_6c30, -0xd_10d3);          /* call 0x10076c30 */
            ii(0x1014_7d03, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_7d06, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_7d09, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_7d0b, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_7d0c, 1); popd(edi);                              /* pop edi */
            ii(0x1014_7d0d, 1); popd(esi);                              /* pop esi */
            ii(0x1014_7d0e, 1); popd(edx);                              /* pop edx */
            ii(0x1014_7d0f, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_7d10, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_7d11, 1); retd(); return;                         /* ret */
        }
    }
}
