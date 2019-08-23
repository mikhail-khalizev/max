using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_a0b0-79f7a1c4")]
        public void Method_100a_a0b0()
        {
            ii(0x100a_a0b0, 5); push(0x28);                             /* push 0x28 */
            ii(0x100a_a0b5, 5); call(Definitions.sys_check_available_stack_size, 0xb_bc98); /* call 0x10165d52 */
            ii(0x100a_a0ba, 1); push(ebx);                              /* push ebx */
            ii(0x100a_a0bb, 1); push(ecx);                              /* push ecx */
            ii(0x100a_a0bc, 1); push(edx);                              /* push edx */
            ii(0x100a_a0bd, 1); push(esi);                              /* push esi */
            ii(0x100a_a0be, 1); push(edi);                              /* push edi */
            ii(0x100a_a0bf, 1); push(ebp);                              /* push ebp */
            ii(0x100a_a0c0, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_a0c2, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100a_a0c8, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100a_a0cb, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_a0ce, 5); call(0x1013_aaa8, 0x9_09d5);            /* call 0x1013aaa8 */
            ii(0x100a_a0d3, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100a_a0d6, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x100a_a0d9, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100a_a0dc, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_a0df, 7); mov(memd[ds, eax + 0x2], 0x101b_4f44);  /* mov dword [eax+0x2], 0x101b4f44 */
            ii(0x100a_a0e6, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_a0e9, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100a_a0ec, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_a0ef, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_a0f1, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_a0f2, 1); pop(edi);                               /* pop edi */
            ii(0x100a_a0f3, 1); pop(esi);                               /* pop esi */
            ii(0x100a_a0f4, 1); pop(edx);                               /* pop edx */
            ii(0x100a_a0f5, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_a0f6, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_a0f7, 1); ret();                                  /* ret */
        }
    }
}
