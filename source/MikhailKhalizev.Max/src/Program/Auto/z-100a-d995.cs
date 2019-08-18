using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("56e25a51-7f9b-4ad8-bf2d-8b7a60f7064f")]
        public void Method_100a_d995()
        {
            ii(0x100a_d995, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100a_d99a, 5); calld(Definitions.sys_check_available_stack_size, 0xb_83b3); /* call 0x10165d52 */
            ii(0x100a_d99f, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_d9a0, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_d9a1, 1); pushd(esi);                             /* push esi */
            ii(0x100a_d9a2, 1); pushd(edi);                             /* push edi */
            ii(0x100a_d9a3, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_d9a4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_d9a6, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100a_d9ac, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_d9af, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100a_d9b2, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_d9b5, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_d9b8, 5); mov(edx, 0x3);                          /* mov edx, 0x3 */
            ii(0x100a_d9bd, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_d9c0, 5); calld(0x100a_d02d, -0x998);             /* call 0x100ad02d */
            ii(0x100a_d9c5, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_d9c7, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_d9c8, 1); popd(edi);                              /* pop edi */
            ii(0x100a_d9c9, 1); popd(esi);                              /* pop esi */
            ii(0x100a_d9ca, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_d9cb, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_d9cc, 1); retd(); return;                         /* ret */
        }
    }
}
