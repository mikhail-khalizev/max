using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("1e86294b-5b51-4c89-8c43-cd5d8d5097c1")]
        public void Method_1007_e1fb()
        {
            ii(0x1007_e1fb, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1007_e200, 5); calld(Definitions.sys_check_available_stack_size, 0xe_7b4d); /* call 0x10165d52 */
            ii(0x1007_e205, 1); pushd(ebx);                             /* push ebx */
            ii(0x1007_e206, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_e207, 1); pushd(esi);                             /* push esi */
            ii(0x1007_e208, 1); pushd(edi);                             /* push edi */
            ii(0x1007_e209, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_e20a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_e20c, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1007_e212, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1007_e215, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1007_e218, 5); mov(edx, StringDefinitions.DefenseReserve); /* mov edx, 0x101a01a8 */
            ii(0x1007_e21d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_e220, 5); calld(Definitions.sys_strcpy, 0xe_7caa); /* call 0x10165ecf */
            ii(0x1007_e225, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_e228, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1007_e22b, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_e22e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_e230, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_e231, 1); popd(edi);                              /* pop edi */
            ii(0x1007_e232, 1); popd(esi);                              /* pop esi */
            ii(0x1007_e233, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_e234, 1); popd(ebx);                              /* pop ebx */
            ii(0x1007_e235, 1); retd(); return;                         /* ret */
        }
    }
}
