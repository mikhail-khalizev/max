using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_6944-1b686646")]
        public void Method_1010_6944()
        {
            ii(0x1010_6944, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1010_6949, 5); calld(Definitions.sys_check_available_stack_size, 0x5_f404); /* call 0x10165d52 */
            ii(0x1010_694e, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_694f, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_6950, 1); pushd(edx);                             /* push edx */
            ii(0x1010_6951, 1); pushd(esi);                             /* push esi */
            ii(0x1010_6952, 1); pushd(edi);                             /* push edi */
            ii(0x1010_6953, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_6954, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_6956, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1010_695c, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1010_695f, 5); mov(eax, 0x763);                        /* mov eax, 0x763 */
            ii(0x1010_6964, 1); pushd(eax);                             /* push eax */
            ii(0x1010_6965, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_6968, 1); pushd(eax);                             /* push eax */
            ii(0x1010_6969, 5); calld(0x1012_3398, 0x1_ca2a);           /* call 0x10123398 */
            ii(0x1010_696e, 3); add(esp, 0x8);                          /* add esp, 0x8 */
            ii(0x1010_6971, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_6973, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_6974, 1); popd(edi);                              /* pop edi */
            ii(0x1010_6975, 1); popd(esi);                              /* pop esi */
            ii(0x1010_6976, 1); popd(edx);                              /* pop edx */
            ii(0x1010_6977, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_6978, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_6979, 1); retd(); return;                         /* ret */
        }
    }
}
