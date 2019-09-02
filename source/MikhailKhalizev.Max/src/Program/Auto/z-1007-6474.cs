using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_6474-2f2018c9")]
        public void Method_1007_6474()
        {
            ii(0x1007_6474, 5); push(0x28);                             /* push 0x28 */
            ii(0x1007_6479, 5); call(Definitions.sys_check_available_stack_size, 0xe_f8d4); /* call 0x10165d52 */
            ii(0x1007_647e, 1); push(ebx);                              /* push ebx */
            ii(0x1007_647f, 1); push(ecx);                              /* push ecx */
            ii(0x1007_6480, 1); push(esi);                              /* push esi */
            ii(0x1007_6481, 1); push(edi);                              /* push edi */
            ii(0x1007_6482, 1); push(ebp);                              /* push ebp */
            ii(0x1007_6483, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_6485, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1007_648b, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1007_648e, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1007_6491, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1007_6494, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1007_6497, 5); call(0x1007_6cd0, 0x834);               /* call 0x10076cd0 */
            ii(0x1007_649c, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1007_649f, 3); lea(eax, memd[ss, ebp - 8]);            /* lea eax, [ebp-0x8] */
            ii(0x1007_64a2, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1007_64a5, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1007_64a8, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1007_64ab, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_64ae, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_64b0, 1); pop(ebp);                               /* pop ebp */
            ii(0x1007_64b1, 1); pop(edi);                               /* pop edi */
            ii(0x1007_64b2, 1); pop(esi);                               /* pop esi */
            ii(0x1007_64b3, 1); pop(ecx);                               /* pop ecx */
            ii(0x1007_64b4, 1); pop(ebx);                               /* pop ebx */
            ii(0x1007_64b5, 1); ret();                                  /* ret */
        }
    }
}
