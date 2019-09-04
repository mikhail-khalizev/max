using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_44e6-a3da9f67")]
        public void Method_1014_44e6()
        {
            ii(0x1014_44e6, 5); push(0x3c);                             /* push 0x3c */
            ii(0x1014_44eb, 5); call(Definitions.sys_check_available_stack_size, 0x2_1862); /* call 0x10165d52 */
            ii(0x1014_44f0, 1); push(ebx);                              /* push ebx */
            ii(0x1014_44f1, 1); push(ecx);                              /* push ecx */
            ii(0x1014_44f2, 1); push(esi);                              /* push esi */
            ii(0x1014_44f3, 1); push(edi);                              /* push edi */
            ii(0x1014_44f4, 1); push(ebp);                              /* push ebp */
            ii(0x1014_44f5, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_44f7, 6); sub(esp, 0x24);                         /* sub esp, 0x24 */
            ii(0x1014_44fd, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1014_4500, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1014_4503, 3); lea(edx, memd[ss, ebp - 16]);           /* lea edx, [ebp-0x10] */
            ii(0x1014_4506, 3); lea(eax, memd[ss, ebp - 12]);           /* lea eax, [ebp-0xc] */
            ii(0x1014_4509, 5); call(/* sys */ 0x1016_b244, 0x2_6d36);  /* call 0x1016b244 */
            ii(0x1014_450e, 3); lea(edx, memd[ss, ebp - 32]);           /* lea edx, [ebp-0x20] */
            ii(0x1014_4511, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_4514, 5); call(/* sys */ 0x1016_7e74, 0x2_395b);  /* call 0x10167e74 */
            ii(0x1014_4519, 3); mov(eax, memd[ss, ebp - 32]);           /* mov eax, [ebp-0x20] */
            ii(0x1014_451c, 5); add(eax, 0xae);                         /* add eax, 0xae */
            ii(0x1014_4521, 3); sub(memd[ss, ebp - 12], eax);           /* sub [ebp-0xc], eax */
            ii(0x1014_4524, 3); mov(edx, memd[ss, ebp - 12]);           /* mov edx, [ebp-0xc] */
            ii(0x1014_4527, 4); imul(edx, memd[ss, ebp - 4]);           /* imul edx, [ebp-0x4] */
            ii(0x1014_452b, 3); add(edx, 0x78);                         /* add edx, 0x78 */
            ii(0x1014_452e, 5); mov(ebx, 0xf0);                         /* mov ebx, 0xf0 */
            ii(0x1014_4533, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1014_4535, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1014_4538, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1014_453a, 3); mov(memd[ss, ebp - 36], eax);           /* mov [ebp-0x24], eax */
            ii(0x1014_453d, 3); mov(eax, memd[ss, ebp - 36]);           /* mov eax, [ebp-0x24] */
            ii(0x1014_4540, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_4542, 1); pop(ebp);                               /* pop ebp */
            ii(0x1014_4543, 1); pop(edi);                               /* pop edi */
            ii(0x1014_4544, 1); pop(esi);                               /* pop esi */
            ii(0x1014_4545, 1); pop(ecx);                               /* pop ecx */
            ii(0x1014_4546, 1); pop(ebx);                               /* pop ebx */
            ii(0x1014_4547, 1); ret();                                  /* ret */
        }
    }
}
