using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_0934-fb5c0f92")]
        public void Method_100e_0934()
        {
            ii(0x100e_0934, 5);  push(0x20);                           /* push 0x20 */
            ii(0x100e_0939, 5);  call(Definitions.sys_check_available_stack_size, 0x8_5414);/* call 0x10165d52 */
            ii(0x100e_093e, 1);  push(ebx);                            /* push ebx */
            ii(0x100e_093f, 1);  push(ecx);                            /* push ecx */
            ii(0x100e_0940, 1);  push(esi);                            /* push esi */
            ii(0x100e_0941, 1);  push(edi);                            /* push edi */
            ii(0x100e_0942, 1);  push(ebp);                            /* push ebp */
            ii(0x100e_0943, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100e_0945, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x100e_094b, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100e_094e, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100e_0951, 4);  movsx(edx, memw[ss, ebp - 4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x100e_0955, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_0958, 5);  call(0x1008_b410, -0x5_554d);         /* call 0x1008b410 */
            ii(0x100e_095d, 3);  add(eax, 6);                          /* add eax, 0x6 */
            ii(0x100e_0960, 5);  call(0x100c_db14, -0x1_2e51);         /* call 0x100cdb14 */
            ii(0x100e_0965, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100e_0967, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100e_0968, 1);  pop(edi);                             /* pop edi */
            ii(0x100e_0969, 1);  pop(esi);                             /* pop esi */
            ii(0x100e_096a, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100e_096b, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100e_096c, 1);  ret();                                /* ret */
        }
    }
}
