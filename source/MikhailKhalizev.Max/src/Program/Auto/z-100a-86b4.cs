using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_86b4-4bc68283")]
        public void Method_100a_86b4()
        {
            ii(0x100a_86b4, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100a_86b9, 5); calld(Definitions.sys_check_available_stack_size, 0xb_d694); /* call 0x10165d52 */
            ii(0x100a_86be, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_86bf, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_86c0, 1); pushd(edx);                             /* push edx */
            ii(0x100a_86c1, 1); pushd(esi);                             /* push esi */
            ii(0x100a_86c2, 1); pushd(edi);                             /* push edi */
            ii(0x100a_86c3, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_86c4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_86c6, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100a_86cc, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100a_86cf, 5); calld(0x100a_b288, 0x2bb4);             /* call 0x100ab288 */
            ii(0x100a_86d4, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_86d6, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x100a_86d8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_86db, 5); calld(0x100a_28ff, -0x5de1);            /* call 0x100a28ff */
            ii(0x100a_86e0, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_86e2, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_86e3, 1); popd(edi);                              /* pop edi */
            ii(0x100a_86e4, 1); popd(esi);                              /* pop esi */
            ii(0x100a_86e5, 1); popd(edx);                              /* pop edx */
            ii(0x100a_86e6, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_86e7, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_86e8, 1); retd(); return;                         /* ret */
        }
    }
}
