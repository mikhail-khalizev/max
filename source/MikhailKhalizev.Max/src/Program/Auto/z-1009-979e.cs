using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("67e9866b-4946-405b-8d75-952516d3b473")]
        public void Method_1009_979e()
        {
            ii(0x1009_979e, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1009_97a3, 5); calld(Definitions.sys_check_available_stack_size, 0xc_c5aa); /* call 0x10165d52 */
            ii(0x1009_97a8, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_97a9, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_97aa, 1); pushd(edx);                             /* push edx */
            ii(0x1009_97ab, 1); pushd(esi);                             /* push esi */
            ii(0x1009_97ac, 1); pushd(edi);                             /* push edi */
            ii(0x1009_97ad, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_97ae, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_97b0, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1009_97b6, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1009_97b9, 7); mov(memd_a32[ss, ebp - 0x8], 0x4);      /* mov dword [ebp-0x8], 0x4 */
            ii(0x1009_97c0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_97c3, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_97c5, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_97c6, 1); popd(edi);                              /* pop edi */
            ii(0x1009_97c7, 1); popd(esi);                              /* pop esi */
            ii(0x1009_97c8, 1); popd(edx);                              /* pop edx */
            ii(0x1009_97c9, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_97ca, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_97cb, 1); retd(); return;                         /* ret */
        }
    }
}
