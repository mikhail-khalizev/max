using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("49cb6523-b888-4118-a93c-f35550b714b5")]
        public void Method_1016_4b08()
        {
            ii(0x1016_4b08, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1016_4b0d, 5); calld(Definitions.sys_check_available_stack_size, 0x1240); /* call 0x10165d52 */
            ii(0x1016_4b12, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_4b13, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_4b14, 1); pushd(edx);                             /* push edx */
            ii(0x1016_4b15, 1); pushd(esi);                             /* push esi */
            ii(0x1016_4b16, 1); pushd(edi);                             /* push edi */
            ii(0x1016_4b17, 1); pushd(ebp);                             /* push ebp */
            ii(0x1016_4b18, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1016_4b1a, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1016_4b20, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1016_4b23, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_4b26, 9); mov(memw_a32[ds, eax + 0xa3], 0);       /* mov word [eax+0xa3], 0x0 */
            ii(0x1016_4b2f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1016_4b31, 1); popd(ebp);                              /* pop ebp */
            ii(0x1016_4b32, 1); popd(edi);                              /* pop edi */
            ii(0x1016_4b33, 1); popd(esi);                              /* pop esi */
            ii(0x1016_4b34, 1); popd(edx);                              /* pop edx */
            ii(0x1016_4b35, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_4b36, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_4b37, 1); retd(); return;                         /* ret */
        }
    }
}