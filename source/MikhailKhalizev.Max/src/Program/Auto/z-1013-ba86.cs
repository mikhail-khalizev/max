using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_ba86-51f4f30a")]
        public void Method_1013_ba86()
        {
            ii(0x1013_ba86, 5);  push(0x20);                           /* push 0x20 */
            ii(0x1013_ba8b, 5);  call(Definitions.sys_check_available_stack_size, 0x2_a2c2);/* call 0x10165d52 */
            ii(0x1013_ba90, 1);  push(ecx);                            /* push ecx */
            ii(0x1013_ba91, 1);  push(esi);                            /* push esi */
            ii(0x1013_ba92, 1);  push(edi);                            /* push edi */
            ii(0x1013_ba93, 1);  push(ebp);                            /* push ebp */
            ii(0x1013_ba94, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1013_ba96, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1013_ba9c, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1013_ba9f, 3);  mov(memd[ss, ebp - 8], edx);          /* mov [ebp-0x8], edx */
            ii(0x1013_baa2, 3);  mov(memd[ss, ebp - 4], ebx);          /* mov [ebp-0x4], ebx */
            ii(0x1013_baa5, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1013_baa8, 2);  mov(ecx, memd[ds, eax]);              /* mov ecx, [eax] */
            ii(0x1013_baaa, 5);  mov(ebx, 1);                          /* mov ebx, 0x1 */
            ii(0x1013_baaf, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1013_bab2, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_bab5, 5);  call(Definitions.my_fread, -0x4_c62b);/* call 0x100ef48f */
            ii(0x1013_baba, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1013_babc, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1013_babd, 1);  pop(edi);                             /* pop edi */
            ii(0x1013_babe, 1);  pop(esi);                             /* pop esi */
            ii(0x1013_babf, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1013_bac0, 1);  ret();                                /* ret */
        }
    }
}
