using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("ce5b71d3-b346-407c-b5a1-36f170f9aa22")]
        public void Method_100e_03bc()
        {
            ii(0x100e_03bc, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100e_03c1, 5); calld(Definitions.sys_check_available_stack_size, 0x8_598c); /* call 0x10165d52 */
            ii(0x100e_03c6, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_03c7, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_03c8, 1); pushd(esi);                             /* push esi */
            ii(0x100e_03c9, 1); pushd(edi);                             /* push edi */
            ii(0x100e_03ca, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_03cb, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_03cd, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100e_03d3, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_03d6, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100e_03d9, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100e_03de, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_03e1, 5); calld(Definitions.my_dtor_0x101b6edc, 0x5_a85f); /* call 0x1013ac45 */
            ii(0x100e_03e6, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_03e9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_03ec, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100e_03ef, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_03f2, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_03f4, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_03f5, 1); popd(edi);                              /* pop edi */
            ii(0x100e_03f6, 1); popd(esi);                              /* pop esi */
            ii(0x100e_03f7, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_03f8, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_03f9, 1); retd(); return;                         /* ret */
        }
    }
}
