using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("d6f29e7c-3c28-41a8-a57c-e0b8b4c76b90")]
        public void Method_100b_a6d6()
        {
            ii(0x100b_a6d6, 5); pushd(0x38);                            /* push 0x38 */
            ii(0x100b_a6db, 5); calld(Definitions.sys_check_available_stack_size, 0xa_b672); /* call 0x10165d52 */
            ii(0x100b_a6e0, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_a6e1, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_a6e2, 1); pushd(edx);                             /* push edx */
            ii(0x100b_a6e3, 1); pushd(esi);                             /* push esi */
            ii(0x100b_a6e4, 1); pushd(edi);                             /* push edi */
            ii(0x100b_a6e5, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_a6e6, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_a6e8, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x100b_a6ee, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100b_a6f1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_a6f4, 3); mov(al, memb_a32[ds, eax + 0x2]);       /* mov al, [eax+0x2] */
            ii(0x100b_a6f7, 3); mov(memb_a32[ss, ebp - 0x8], al);       /* mov [ebp-0x8], al */
            ii(0x100b_a6fa, 5); if(jmpd_func(0x100b_a99c, 0x29d)) return; /* jmp 0x100ba99c */
        }
    }
}
