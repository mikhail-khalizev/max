using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("26fc3e1b-1d43-450d-82b8-381611af6c64")]
        public void Method_100b_3afc()
        {
            ii(0x100b_3afc, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100b_3b01, 5); calld(Definitions.sys_check_available_stack_size, 0xb_224c); /* call 0x10165d52 */
            ii(0x100b_3b06, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_3b07, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_3b08, 1); pushd(edx);                             /* push edx */
            ii(0x100b_3b09, 1); pushd(esi);                             /* push esi */
            ii(0x100b_3b0a, 1); pushd(edi);                             /* push edi */
            ii(0x100b_3b0b, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_3b0c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_3b0e, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100b_3b14, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100b_3b17, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
            ii(0x100b_3b1b, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x100b_3b1e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_3b20, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_3b21, 1); popd(edi);                              /* pop edi */
            ii(0x100b_3b22, 1); popd(esi);                              /* pop esi */
            ii(0x100b_3b23, 1); popd(edx);                              /* pop edx */
            ii(0x100b_3b24, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_3b25, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_3b26, 1); retd(); return;                         /* ret */
        }
    }
}
