using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("8ec9f14e-e579-44fa-a9b4-0fe3dd942849")]
        public void Method_1008_736d()
        {
            ii(0x1008_736d, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1008_7372, 5); calld(Definitions.sys_check_available_stack_size, 0xd_e9db); /* call 0x10165d52 */
            ii(0x1008_7377, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_7378, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_7379, 1); pushd(esi);                             /* push esi */
            ii(0x1008_737a, 1); pushd(edi);                             /* push edi */
            ii(0x1008_737b, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_737c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_737e, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1008_7384, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_7387, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1008_738a, 5); mov(edx, StringDefinitions.SupportAttack); /* mov edx, 0x101a02d7 */
            ii(0x1008_738f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_7392, 5); calld(Definitions.sys_strcpy, 0xd_eb38); /* call 0x10165ecf */
            ii(0x1008_7397, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_739a, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1008_739d, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1008_73a0, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_73a2, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_73a3, 1); popd(edi);                              /* pop edi */
            ii(0x1008_73a4, 1); popd(esi);                              /* pop esi */
            ii(0x1008_73a5, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_73a6, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_73a7, 1); retd(); return;                         /* ret */
        }
    }
}
