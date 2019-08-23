using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_623c-e3414a5a")]
        public void Method_1007_623c()
        {
            ii(0x1007_623c, 5); push(0x24);                             /* push 0x24 */
            ii(0x1007_6241, 5); call(Definitions.sys_check_available_stack_size, 0xe_fb0c); /* call 0x10165d52 */
            ii(0x1007_6246, 1); push(ebx);                              /* push ebx */
            ii(0x1007_6247, 1); push(ecx);                              /* push ecx */
            ii(0x1007_6248, 1); push(edx);                              /* push edx */
            ii(0x1007_6249, 1); push(esi);                              /* push esi */
            ii(0x1007_624a, 1); push(edi);                              /* push edi */
            ii(0x1007_624b, 1); push(ebp);                              /* push ebp */
            ii(0x1007_624c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_624e, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1007_6254, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1007_6257, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_625a, 3); add(eax, 0x6c);                         /* add eax, 0x6c */
            ii(0x1007_625d, 5); call(0x1007_678c, 0x52a);               /* call 0x1007678c */
            ii(0x1007_6262, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1007_6265, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_6268, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_626a, 1); pop(ebp);                               /* pop ebp */
            ii(0x1007_626b, 1); pop(edi);                               /* pop edi */
            ii(0x1007_626c, 1); pop(esi);                               /* pop esi */
            ii(0x1007_626d, 1); pop(edx);                               /* pop edx */
            ii(0x1007_626e, 1); pop(ecx);                               /* pop ecx */
            ii(0x1007_626f, 1); pop(ebx);                               /* pop ebx */
            ii(0x1007_6270, 1); ret();                                  /* ret */
        }
    }
}
