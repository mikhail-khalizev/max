using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_1b62-d75937e4")]
        public void my_string_reserve()
        {
            ii(0x1014_1b62, 5);  push(0x20);                           /* push 0x20 */
            ii(0x1014_1b67, 5);  call(Definitions.sys_check_available_stack_size, 0x2_41e6);/* call 0x10165d52 */
            ii(0x1014_1b6c, 1);  push(ecx);                            /* push ecx */
            ii(0x1014_1b6d, 1);  push(esi);                            /* push esi */
            ii(0x1014_1b6e, 1);  push(edi);                            /* push edi */
            ii(0x1014_1b6f, 1);  push(ebp);                            /* push ebp */
            ii(0x1014_1b70, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1014_1b72, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1014_1b78, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1014_1b7b, 3);  mov(memd[ss, ebp - 8], edx);          /* mov [ebp-0x8], edx */
            ii(0x1014_1b7e, 3);  mov(memb[ss, ebp - 4], bl);           /* mov [ebp-0x4], bl */
            ii(0x1014_1b81, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1014_1b84, 5);  call(Definitions.my_string_make_single_ref, 0x7d3);/* call 0x1014235c */
            ii(0x1014_1b89, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x1014_1b8b, 3);  mov(bl, memb[ss, ebp - 4]);           /* mov bl, [ebp-0x4] */
            ii(0x1014_1b8e, 4);  movsx(edx, memw[ss, ebp - 8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x1014_1b92, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1014_1b95, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1014_1b97, 5);  call(Definitions.my_strobj_reserve, -0x29f);/* call 0x101418fd */
            ii(0x1014_1b9c, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1014_1b9e, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1014_1b9f, 1);  pop(edi);                             /* pop edi */
            ii(0x1014_1ba0, 1);  pop(esi);                             /* pop esi */
            ii(0x1014_1ba1, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1014_1ba2, 1);  ret();                                /* ret */
        }
    }
}
