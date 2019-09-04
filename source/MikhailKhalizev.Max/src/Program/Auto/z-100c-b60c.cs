using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_b60c-445f209e")]
        public void Method_100c_b60c()
        {
            ii(0x100c_b60c, 5); push(0x20);                             /* push 0x20 */
            ii(0x100c_b611, 5); call(Definitions.sys_check_available_stack_size, 0x9_a73c); /* call 0x10165d52 */
            ii(0x100c_b616, 1); push(ebx);                              /* push ebx */
            ii(0x100c_b617, 1); push(ecx);                              /* push ecx */
            ii(0x100c_b618, 1); push(esi);                              /* push esi */
            ii(0x100c_b619, 1); push(edi);                              /* push edi */
            ii(0x100c_b61a, 1); push(ebp);                              /* push ebp */
            ii(0x100c_b61b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_b61d, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x100c_b623, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100c_b626, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100c_b629, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100c_b62c, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100c_b62f, 4); mov(memw[ds, edx + 6], ax);             /* mov [edx+0x6], ax */
            ii(0x100c_b633, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_b635, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_b636, 1); pop(edi);                               /* pop edi */
            ii(0x100c_b637, 1); pop(esi);                               /* pop esi */
            ii(0x100c_b638, 1); pop(ecx);                               /* pop ecx */
            ii(0x100c_b639, 1); pop(ebx);                               /* pop ebx */
            ii(0x100c_b63a, 1); ret();                                  /* ret */
        }
    }
}
