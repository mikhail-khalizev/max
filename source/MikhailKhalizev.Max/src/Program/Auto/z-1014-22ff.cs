using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_22ff-cf1b2e50")]
        public void Method_1014_22ff()
        {
            ii(0x1014_22ff, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1014_2304, 5);  call(Definitions.sys_check_available_stack_size, 0x2_3a49);/* call 0x10165d52 */
            ii(0x1014_2309, 1);  push(ecx);                            /* push ecx */
            ii(0x1014_230a, 1);  push(esi);                            /* push esi */
            ii(0x1014_230b, 1);  push(edi);                            /* push edi */
            ii(0x1014_230c, 1);  push(ebp);                            /* push ebp */
            ii(0x1014_230d, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1014_230f, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x1014_2315, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1014_2318, 3);  mov(memd[ss, ebp - 8], edx);          /* mov [ebp-0x8], edx */
            ii(0x1014_231b, 3);  mov(memd[ss, ebp - 4], ebx);          /* mov [ebp-0x4], ebx */
            ii(0x1014_231e, 3);  mov(ecx, memd[ss, ebp - 4]);          /* mov ecx, [ebp-0x4] */
            ii(0x1014_2321, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1014_2324, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1014_2326, 5);  call(Definitions.my_strobj_c_str, -0xb_8b2f);/* call 0x100897fc */
            ii(0x1014_232b, 3);  lea(ebx, memd[ss, ebp - 16]);         /* lea ebx, [ebp-0x10] */
            ii(0x1014_232e, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1014_2330, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x1014_2332, 5);  call(Definitions.my_string_ctor_char_ptr, -0x8fc);/* call 0x10141a3b */
            ii(0x1014_2337, 2);  mov(edx, ecx);                        /* mov edx, ecx */
            ii(0x1014_2339, 5);  call(Definitions.my_string_append_string_v2, 0x156);/* call 0x10142494 */
            ii(0x1014_233e, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1014_2340, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_2343, 5);  call(Definitions.my_string_ctor_string, -0x8a2);/* call 0x10141aa6 */
            ii(0x1014_2348, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1014_234a, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x1014_234d, 5);  call(Definitions.my_string_dtor, -0x828);/* call 0x10141b2a */
            ii(0x1014_2352, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_2355, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1014_2357, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1014_2358, 1);  pop(edi);                             /* pop edi */
            ii(0x1014_2359, 1);  pop(esi);                             /* pop esi */
            ii(0x1014_235a, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1014_235b, 1);  ret();                                /* ret */
        }
    }
}
