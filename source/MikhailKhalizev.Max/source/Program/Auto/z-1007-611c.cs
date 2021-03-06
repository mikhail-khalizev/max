using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_611c-aa6a702")]
        public void Method_1007_611c()
        {
            ii(0x1007_611c, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1007_6121, 5);  call(Definitions.sys_check_available_stack_size, 0xe_fc2c);/* call 0x10165d52 */
            ii(0x1007_6126, 1);  push(ebx);                            /* push ebx */
            ii(0x1007_6127, 1);  push(ecx);                            /* push ecx */
            ii(0x1007_6128, 1);  push(edx);                            /* push edx */
            ii(0x1007_6129, 1);  push(esi);                            /* push esi */
            ii(0x1007_612a, 1);  push(edi);                            /* push edi */
            ii(0x1007_612b, 1);  push(ebp);                            /* push ebp */
            ii(0x1007_612c, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1007_612e, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1007_6134, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1007_6137, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_613a, 5);  add(eax, 0x82);                       /* add eax, 0x82 */
            ii(0x1007_613f, 5);  call(0x1007_6600, 0x4bc);             /* call 0x10076600 */
            ii(0x1007_6144, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1007_6147, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_614a, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1007_614c, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1007_614d, 1);  pop(edi);                             /* pop edi */
            ii(0x1007_614e, 1);  pop(esi);                             /* pop esi */
            ii(0x1007_614f, 1);  pop(edx);                             /* pop edx */
            ii(0x1007_6150, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1007_6151, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1007_6152, 1);  ret();                                /* ret */
        }
    }
}
