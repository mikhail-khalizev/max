using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("7abad3c9-bcf9-4c3a-b4a5-9875d6d5d183")]
        public void Method_100b_0b1b()
        {
            ii(0x100b_0b1b, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100b_0b20, 5); calld(Definitions.sys_check_available_stack_size, 0xb_522d); /* call 0x10165d52 */
            ii(0x100b_0b25, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_0b26, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_0b27, 1); pushd(esi);                             /* push esi */
            ii(0x100b_0b28, 1); pushd(edi);                             /* push edi */
            ii(0x100b_0b29, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_0b2a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_0b2c, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100b_0b32, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_0b35, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100b_0b38, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100b_0b3b, 3); add(edx, 0x15);                         /* add edx, 0x15 */
            ii(0x100b_0b3e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_0b41, 5); calld(0x1008_b4b4, -0x2_5692);          /* call 0x1008b4b4 */
            ii(0x100b_0b46, 3); mov(memb_a32[ss, ebp - 0xc], al);       /* mov [ebp-0xc], al */
            ii(0x100b_0b49, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x100b_0b4c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_0b4e, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_0b4f, 1); popd(edi);                              /* pop edi */
            ii(0x100b_0b50, 1); popd(esi);                              /* pop esi */
            ii(0x100b_0b51, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_0b52, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_0b53, 1); retd(); return;                         /* ret */
        }
    }
}
