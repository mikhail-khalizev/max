using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_caa6-2a4f06bb")]
        public void Method_100a_caa6()
        {
            ii(0x100a_caa6, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100a_caab, 5); calld(Definitions.sys_check_available_stack_size, 0xb_92a2); /* call 0x10165d52 */
            ii(0x100a_cab0, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_cab1, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_cab2, 1); pushd(edx);                             /* push edx */
            ii(0x100a_cab3, 1); pushd(esi);                             /* push esi */
            ii(0x100a_cab4, 1); pushd(edi);                             /* push edi */
            ii(0x100a_cab5, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_cab6, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_cab8, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100a_cabe, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100a_cac1, 4); mov(memb_a32[ss, ebp - 0x8], 0x17);     /* mov byte [ebp-0x8], 0x17 */
            ii(0x100a_cac5, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x100a_cac8, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_caca, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_cacb, 1); popd(edi);                              /* pop edi */
            ii(0x100a_cacc, 1); popd(esi);                              /* pop esi */
            ii(0x100a_cacd, 1); popd(edx);                              /* pop edx */
            ii(0x100a_cace, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_cacf, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_cad0, 1); retd();                                 /* ret */
        }
    }
}
