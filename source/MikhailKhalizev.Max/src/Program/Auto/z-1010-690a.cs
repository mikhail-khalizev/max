using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_690a-f7675bd9")]
        public void Method_1010_690a()
        {
            ii(0x1010_690a, 5); push(0x28);                             /* push 0x28 */
            ii(0x1010_690f, 5); call(Definitions.sys_check_available_stack_size, 0x5_f43e); /* call 0x10165d52 */
            ii(0x1010_6914, 1); push(ebx);                              /* push ebx */
            ii(0x1010_6915, 1); push(ecx);                              /* push ecx */
            ii(0x1010_6916, 1); push(esi);                              /* push esi */
            ii(0x1010_6917, 1); push(edi);                              /* push edi */
            ii(0x1010_6918, 1); push(ebp);                              /* push ebp */
            ii(0x1010_6919, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_691b, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1010_6921, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1010_6924, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1010_6927, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1010_692a, 1); push(eax);                              /* push eax */
            ii(0x1010_692b, 5); call(0x1012_36ac, 0x1_cd7c);            /* call 0x101236ac */
            ii(0x1010_6930, 3); add(esp, 4);                            /* add esp, 0x4 */
            ii(0x1010_6933, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1010_6936, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1010_6939, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1010_693c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_693e, 1); pop(ebp);                               /* pop ebp */
            ii(0x1010_693f, 1); pop(edi);                               /* pop edi */
            ii(0x1010_6940, 1); pop(esi);                               /* pop esi */
            ii(0x1010_6941, 1); pop(ecx);                               /* pop ecx */
            ii(0x1010_6942, 1); pop(ebx);                               /* pop ebx */
            ii(0x1010_6943, 1); ret();                                  /* ret */
        }
    }
}
