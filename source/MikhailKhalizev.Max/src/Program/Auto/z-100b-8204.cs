using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_8204-4050d6fb")]
        public void Method_100b_8204()
        {
            ii(0x100b_8204, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100b_8209, 5); calld(Definitions.sys_check_available_stack_size, 0xa_db44); /* call 0x10165d52 */
            ii(0x100b_820e, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_820f, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_8210, 1); pushd(esi);                             /* push esi */
            ii(0x100b_8211, 1); pushd(edi);                             /* push edi */
            ii(0x100b_8212, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_8213, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_8215, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100b_821b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_821e, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100b_8221, 5); calld(0x100b_8388, 0x162);              /* call 0x100b8388 */
            ii(0x100b_8226, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100b_8228, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100b_822a, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100b_822d, 3); add(edx, 0x18);                         /* add edx, 0x18 */
            ii(0x100b_8230, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_8233, 5); calld(0x100b_82f8, 0xc0);               /* call 0x100b82f8 */
            ii(0x100b_8238, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_823b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_823d, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_823e, 1); popd(edi);                              /* pop edi */
            ii(0x100b_823f, 1); popd(esi);                              /* pop esi */
            ii(0x100b_8240, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_8241, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_8242, 1); retd(); return;                         /* ret */
        }
    }
}
