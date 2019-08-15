using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0a6d8b45-efea-4dc1-bb2f-8fe543c8518d")]
        public void Method_100a_7836()
        {
            ii(0x100a_7836, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100a_783b, 5); calld(Definitions.sys_check_available_stack_size, 0xb_e512); /* call 0x10165d52 */
            ii(0x100a_7840, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_7841, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_7842, 1); pushd(edx);                             /* push edx */
            ii(0x100a_7843, 1); pushd(esi);                             /* push esi */
            ii(0x100a_7844, 1); pushd(edi);                             /* push edi */
            ii(0x100a_7845, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_7846, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_7848, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100a_784e, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100a_7851, 4); mov(memb_a32[ss, ebp - 0x8], 0x7);      /* mov byte [ebp-0x8], 0x7 */
            ii(0x100a_7855, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x100a_7858, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_785a, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_785b, 1); popd(edi);                              /* pop edi */
            ii(0x100a_785c, 1); popd(esi);                              /* pop esi */
            ii(0x100a_785d, 1); popd(edx);                              /* pop edx */
            ii(0x100a_785e, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_785f, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_7860, 1); retd(); return;                         /* ret */
        }
    }
}
