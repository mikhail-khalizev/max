using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_0a5f-45dc0535")]
        public void Method_1015_0a5f()
        {
            ii(0x1015_0a5f, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1015_0a64, 5); calld(Definitions.sys_check_available_stack_size, 0x1_52e9); /* call 0x10165d52 */
            ii(0x1015_0a69, 1); pushd(ebx);                             /* push ebx */
            ii(0x1015_0a6a, 1); pushd(ecx);                             /* push ecx */
            ii(0x1015_0a6b, 1); pushd(esi);                             /* push esi */
            ii(0x1015_0a6c, 1); pushd(edi);                             /* push edi */
            ii(0x1015_0a6d, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_0a6e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_0a70, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1015_0a76, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1015_0a79, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1015_0a7c, 5); calld(0x1009_cb74, -0xb_3f0d);          /* call 0x1009cb74 */
            ii(0x1015_0a81, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1015_0a83, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1015_0a85, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1015_0a88, 3); add(edx, 0x74);                         /* add edx, 0x74 */
            ii(0x1015_0a8b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_0a8e, 5); calld(0x1009_cab0, -0xb_3fe3);          /* call 0x1009cab0 */
            ii(0x1015_0a93, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_0a96, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_0a98, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_0a99, 1); popd(edi);                              /* pop edi */
            ii(0x1015_0a9a, 1); popd(esi);                              /* pop esi */
            ii(0x1015_0a9b, 1); popd(ecx);                              /* pop ecx */
            ii(0x1015_0a9c, 1); popd(ebx);                              /* pop ebx */
            ii(0x1015_0a9d, 1); retd();                                 /* ret */
        }
    }
}
