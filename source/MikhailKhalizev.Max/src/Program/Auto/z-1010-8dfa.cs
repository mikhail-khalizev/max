using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_8dfa-f45dd83d")]
        public void Method_1010_8dfa()
        {
            ii(0x1010_8dfa, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1010_8dff, 5); calld(Definitions.sys_check_available_stack_size, 0x5_cf4e); /* call 0x10165d52 */
            ii(0x1010_8e04, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_8e05, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_8e06, 1); pushd(edx);                             /* push edx */
            ii(0x1010_8e07, 1); pushd(esi);                             /* push esi */
            ii(0x1010_8e08, 1); pushd(edi);                             /* push edi */
            ii(0x1010_8e09, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_8e0a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_8e0c, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1010_8e12, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1010_8e15, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_8e18, 6); mov(memw_a32[ds, eax + 0x9], 0);        /* mov word [eax+0x9], 0x0 */
            ii(0x1010_8e1e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_8e21, 7); mov(memd_a32[ds, eax + 0x4], 0x1);      /* mov dword [eax+0x4], 0x1 */
            ii(0x1010_8e28, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_8e2a, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_8e2b, 1); popd(edi);                              /* pop edi */
            ii(0x1010_8e2c, 1); popd(esi);                              /* pop esi */
            ii(0x1010_8e2d, 1); popd(edx);                              /* pop edx */
            ii(0x1010_8e2e, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_8e2f, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_8e30, 1); retd();                                 /* ret */
        }
    }
}
