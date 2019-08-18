using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_6bb8-8c8fa96")]
        public void Method_100d_6bb8()
        {
            ii(0x100d_6bb8, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100d_6bbd, 5); calld(Definitions.sys_check_available_stack_size, 0x8_f190); /* call 0x10165d52 */
            ii(0x100d_6bc2, 1); pushd(ebx);                             /* push ebx */
            ii(0x100d_6bc3, 1); pushd(ecx);                             /* push ecx */
            ii(0x100d_6bc4, 1); pushd(esi);                             /* push esi */
            ii(0x100d_6bc5, 1); pushd(edi);                             /* push edi */
            ii(0x100d_6bc6, 1); pushd(ebp);                             /* push ebp */
            ii(0x100d_6bc7, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_6bc9, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100d_6bcf, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100d_6bd2, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100d_6bd5, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
            ii(0x100d_6bd9, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x100d_6bdc, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_6bde, 1); popd(ebp);                              /* pop ebp */
            ii(0x100d_6bdf, 1); popd(edi);                              /* pop edi */
            ii(0x100d_6be0, 1); popd(esi);                              /* pop esi */
            ii(0x100d_6be1, 1); popd(ecx);                              /* pop ecx */
            ii(0x100d_6be2, 1); popd(ebx);                              /* pop ebx */
            ii(0x100d_6be3, 1); retd(); return;                         /* ret */
        }
    }
}
