using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_7610-12b367a4")]
        public void Method_100b_7610()
        {
            ii(0x100b_7610, 5); push(0x24);                             /* push 0x24 */
            ii(0x100b_7615, 5); call(Definitions.sys_check_available_stack_size, 0xa_e738); /* call 0x10165d52 */
            ii(0x100b_761a, 1); push(ebx);                              /* push ebx */
            ii(0x100b_761b, 1); push(ecx);                              /* push ecx */
            ii(0x100b_761c, 1); push(esi);                              /* push esi */
            ii(0x100b_761d, 1); push(edi);                              /* push edi */
            ii(0x100b_761e, 1); push(ebp);                              /* push ebp */
            ii(0x100b_761f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_7621, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100b_7627, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100b_762a, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100b_762d, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x100b_7632, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100b_7635, 5); call(0x1013_a1be, 0x8_2b84);            /* call 0x1013a1be */
            ii(0x100b_763a, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100b_763d, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100b_7640, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100b_7643, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100b_7646, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_7648, 1); pop(ebp);                               /* pop ebp */
            ii(0x100b_7649, 1); pop(edi);                               /* pop edi */
            ii(0x100b_764a, 1); pop(esi);                               /* pop esi */
            ii(0x100b_764b, 1); pop(ecx);                               /* pop ecx */
            ii(0x100b_764c, 1); pop(ebx);                               /* pop ebx */
            ii(0x100b_764d, 1); ret();                                  /* ret */
        }
    }
}
