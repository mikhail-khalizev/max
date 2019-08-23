using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_a292-a5ebee87")]
        public void Method_1009_a292()
        {
            ii(0x1009_a292, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1009_a297, 5); calld(Definitions.sys_check_available_stack_size, 0xc_bab6); /* call 0x10165d52 */
            ii(0x1009_a29c, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_a29d, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_a29e, 1); pushd(edx);                             /* push edx */
            ii(0x1009_a29f, 1); pushd(esi);                             /* push esi */
            ii(0x1009_a2a0, 1); pushd(edi);                             /* push edi */
            ii(0x1009_a2a1, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_a2a2, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_a2a4, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1009_a2aa, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1009_a2ad, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_a2af, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_a2b2, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1009_a2b5, 5); calld(0x1013_ad11, 0xa_0a57);           /* call 0x1013ad11 */
            ii(0x1009_a2ba, 3); mov(memb_a32[ss, ebp - 0x8], al);       /* mov [ebp-0x8], al */
            ii(0x1009_a2bd, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x1009_a2c0, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_a2c2, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_a2c3, 1); popd(edi);                              /* pop edi */
            ii(0x1009_a2c4, 1); popd(esi);                              /* pop esi */
            ii(0x1009_a2c5, 1); popd(edx);                              /* pop edx */
            ii(0x1009_a2c6, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_a2c7, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_a2c8, 1); retd();                                 /* ret */
        }
    }
}
