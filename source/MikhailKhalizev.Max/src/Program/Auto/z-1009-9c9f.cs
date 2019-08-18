using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_9c9f-2693b76")]
        public void Method_1009_9c9f()
        {
            ii(0x1009_9c9f, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1009_9ca4, 5); calld(Definitions.sys_check_available_stack_size, 0xc_c0a9); /* call 0x10165d52 */
            ii(0x1009_9ca9, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_9caa, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_9cab, 1); pushd(edx);                             /* push edx */
            ii(0x1009_9cac, 1); pushd(esi);                             /* push esi */
            ii(0x1009_9cad, 1); pushd(edi);                             /* push edi */
            ii(0x1009_9cae, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_9caf, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_9cb1, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1009_9cb7, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1009_9cba, 7); mov(memd_a32[ss, ebp - 0x8], 0x4);      /* mov dword [ebp-0x8], 0x4 */
            ii(0x1009_9cc1, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_9cc4, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_9cc6, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_9cc7, 1); popd(edi);                              /* pop edi */
            ii(0x1009_9cc8, 1); popd(esi);                              /* pop esi */
            ii(0x1009_9cc9, 1); popd(edx);                              /* pop edx */
            ii(0x1009_9cca, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_9ccb, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_9ccc, 1); retd(); return;                         /* ret */
        }
    }
}
