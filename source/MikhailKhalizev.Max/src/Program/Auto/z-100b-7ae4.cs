using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_7ae4-2289260a")]
        public void Method_100b_7ae4()
        {
            ii(0x100b_7ae4, 5); push(0x28);                             /* push 0x28 */
            ii(0x100b_7ae9, 5); call(Definitions.sys_check_available_stack_size, 0xa_e264); /* call 0x10165d52 */
            ii(0x100b_7aee, 1); push(ebx);                              /* push ebx */
            ii(0x100b_7aef, 1); push(ecx);                              /* push ecx */
            ii(0x100b_7af0, 1); push(esi);                              /* push esi */
            ii(0x100b_7af1, 1); push(edi);                              /* push edi */
            ii(0x100b_7af2, 1); push(ebp);                              /* push ebp */
            ii(0x100b_7af3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_7af5, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100b_7afb, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100b_7afe, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100b_7b01, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x100b_7b04, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_7b07, 5); call(0x1007_6cd0, -0x4_0e3c);           /* call 0x10076cd0 */
            ii(0x100b_7b0c, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100b_7b0f, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x100b_7b12, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100b_7b15, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_7b18, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100b_7b1b, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100b_7b1e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_7b20, 1); pop(ebp);                               /* pop ebp */
            ii(0x100b_7b21, 1); pop(edi);                               /* pop edi */
            ii(0x100b_7b22, 1); pop(esi);                               /* pop esi */
            ii(0x100b_7b23, 1); pop(ecx);                               /* pop ecx */
            ii(0x100b_7b24, 1); pop(ebx);                               /* pop ebx */
            ii(0x100b_7b25, 1); ret();                                  /* ret */
        }
    }
}
