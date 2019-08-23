using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_2b98-3fb02ef2")]
        public void Method_100a_2b98()
        {
            ii(0x100a_2b98, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100a_2b9d, 5); calld(Definitions.sys_check_available_stack_size, 0xc_31b0); /* call 0x10165d52 */
            ii(0x100a_2ba2, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_2ba3, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_2ba4, 1); pushd(esi);                             /* push esi */
            ii(0x100a_2ba5, 1); pushd(edi);                             /* push edi */
            ii(0x100a_2ba6, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_2ba7, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_2ba9, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100a_2baf, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_2bb2, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100a_2bb5, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
            ii(0x100a_2bb9, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x100a_2bbc, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_2bbe, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_2bbf, 1); popd(edi);                              /* pop edi */
            ii(0x100a_2bc0, 1); popd(esi);                              /* pop esi */
            ii(0x100a_2bc1, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_2bc2, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_2bc3, 1); retd();                                 /* ret */
        }
    }
}
