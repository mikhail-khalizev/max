using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_dec2-ad1452bd")]
        public void Method_100c_dec2()
        {
            ii(0x100c_dec2, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100c_dec7, 5);  call(Definitions.sys_check_available_stack_size, 0x9_7e86);/* call 0x10165d52 */
            ii(0x100c_decc, 1);  push(ebx);                            /* push ebx */
            ii(0x100c_decd, 1);  push(ecx);                            /* push ecx */
            ii(0x100c_dece, 1);  push(edx);                            /* push edx */
            ii(0x100c_decf, 1);  push(esi);                            /* push esi */
            ii(0x100c_ded0, 1);  push(edi);                            /* push edi */
            ii(0x100c_ded1, 1);  push(ebp);                            /* push ebp */
            ii(0x100c_ded2, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100c_ded4, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x100c_deda, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100c_dedd, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100c_dee1, 5);  call(0x100c_de37, -0xaf);             /* call 0x100cde37 */
            ii(0x100c_dee6, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x100c_deeb, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100c_deee, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_def1, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100c_def3, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100c_def4, 1);  pop(edi);                             /* pop edi */
            ii(0x100c_def5, 1);  pop(esi);                             /* pop esi */
            ii(0x100c_def6, 1);  pop(edx);                             /* pop edx */
            ii(0x100c_def7, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100c_def8, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100c_def9, 1);  ret();                                /* ret */
        }
    }
}
