using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("bb58bafc-ebdf-438f-a521-2aeee52064a7")]
        public void Method_100c_a6a0()
        {
            ii(0x100c_a6a0, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100c_a6a5, 5); calld(Definitions.sys_check_available_stack_size, 0x9b6a8); /* call 0x10165d52 */
            ii(0x100c_a6aa, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_a6ab, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_a6ac, 1); pushd(esi);                             /* push esi */
            ii(0x100c_a6ad, 1); pushd(edi);                             /* push edi */
            ii(0x100c_a6ae, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_a6af, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_a6b1, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100c_a6b7, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_a6ba, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100c_a6bd, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100c_a6c2, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_a6c5, 5); calld(0x1008_8a84, -0x41c46);           /* call 0x10088a84 */
            ii(0x100c_a6ca, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_a6cd, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_a6d0, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100c_a6d3, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_a6d6, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_a6d8, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_a6d9, 1); popd(edi);                              /* pop edi */
            ii(0x100c_a6da, 1); popd(esi);                              /* pop esi */
            ii(0x100c_a6db, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_a6dc, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_a6dd, 1); retd(); return;                         /* ret */
        }
    }
}