using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("1d739033-c978-4a94-b03f-e3b81b59c97d")]
        public void Method_1009_caf8()
        {
            ii(0x1009_caf8, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1009_cafd, 5); calld(Definitions.sys_check_available_stack_size, 0xc_9250); /* call 0x10165d52 */
            ii(0x1009_cb02, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_cb03, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_cb04, 1); pushd(edx);                             /* push edx */
            ii(0x1009_cb05, 1); pushd(esi);                             /* push esi */
            ii(0x1009_cb06, 1); pushd(edi);                             /* push edi */
            ii(0x1009_cb07, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_cb08, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_cb0a, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1009_cb10, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1009_cb13, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_cb16, 5); calld(0x1008_b410, -0x1_170b);          /* call 0x1008b410 */
            ii(0x1009_cb1b, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x1009_cb1e, 5); calld(0x1009_cb94, 0x71);               /* call 0x1009cb94 */
            ii(0x1009_cb23, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_cb25, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_cb26, 1); popd(edi);                              /* pop edi */
            ii(0x1009_cb27, 1); popd(esi);                              /* pop esi */
            ii(0x1009_cb28, 1); popd(edx);                              /* pop edx */
            ii(0x1009_cb29, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_cb2a, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_cb2b, 1); retd(); return;                         /* ret */
        }
    }
}
