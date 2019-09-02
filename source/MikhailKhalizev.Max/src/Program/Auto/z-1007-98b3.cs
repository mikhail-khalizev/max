using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_98b3-f183604b")]
        public void Method_1007_98b3()
        {
            ii(0x1007_98b3, 5); push(0x24);                             /* push 0x24 */
            ii(0x1007_98b8, 5); call(Definitions.sys_check_available_stack_size, 0xe_c495); /* call 0x10165d52 */
            ii(0x1007_98bd, 1); push(ebx);                              /* push ebx */
            ii(0x1007_98be, 1); push(ecx);                              /* push ecx */
            ii(0x1007_98bf, 1); push(edx);                              /* push edx */
            ii(0x1007_98c0, 1); push(esi);                              /* push esi */
            ii(0x1007_98c1, 1); push(edi);                              /* push edi */
            ii(0x1007_98c2, 1); push(ebp);                              /* push ebp */
            ii(0x1007_98c3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_98c5, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x1007_98cb, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1007_98ce, 4); mov(memb[ss, ebp - 8], 3);              /* mov byte [ebp-0x8], 0x3 */
            ii(0x1007_98d2, 3); mov(al, memb[ss, ebp - 8]);             /* mov al, [ebp-0x8] */
            ii(0x1007_98d5, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_98d7, 1); pop(ebp);                               /* pop ebp */
            ii(0x1007_98d8, 1); pop(edi);                               /* pop edi */
            ii(0x1007_98d9, 1); pop(esi);                               /* pop esi */
            ii(0x1007_98da, 1); pop(edx);                               /* pop edx */
            ii(0x1007_98db, 1); pop(ecx);                               /* pop ecx */
            ii(0x1007_98dc, 1); pop(ebx);                               /* pop ebx */
            ii(0x1007_98dd, 1); ret();                                  /* ret */
        }
    }
}
