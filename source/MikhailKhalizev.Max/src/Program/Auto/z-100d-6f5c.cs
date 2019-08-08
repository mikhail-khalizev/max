using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0264fd08-0519-4636-8c60-3caaea93a8f5")]
        public void Method_100d_6f5c()
        {
            ii(0x100d_6f5c, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100d_6f61, 5); calld(Definitions.sys_check_available_stack_size, 0x8_edec); /* call 0x10165d52 */
            ii(0x100d_6f66, 1); pushd(ebx);                             /* push ebx */
            ii(0x100d_6f67, 1); pushd(ecx);                             /* push ecx */
            ii(0x100d_6f68, 1); pushd(esi);                             /* push esi */
            ii(0x100d_6f69, 1); pushd(edi);                             /* push edi */
            ii(0x100d_6f6a, 1); pushd(ebp);                             /* push ebp */
            ii(0x100d_6f6b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_6f6d, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100d_6f73, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100d_6f76, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100d_6f79, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_6f7c, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_6f7f, 4); mov(memw_a32[ds, edx + 0x2], ax);       /* mov [edx+0x2], ax */
            ii(0x100d_6f83, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_6f85, 1); popd(ebp);                              /* pop ebp */
            ii(0x100d_6f86, 1); popd(edi);                              /* pop edi */
            ii(0x100d_6f87, 1); popd(esi);                              /* pop esi */
            ii(0x100d_6f88, 1); popd(ecx);                              /* pop ecx */
            ii(0x100d_6f89, 1); popd(ebx);                              /* pop ebx */
            ii(0x100d_6f8a, 1); retd(); return;                         /* ret */
        }
    }
}
