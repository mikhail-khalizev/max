using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_30de-94ff335f")]
        public void Method_1010_30de()
        {
            ii(0x1010_30de, 5);  push(0x20);                           /* push 0x20 */
            ii(0x1010_30e3, 5);  call(Definitions.sys_check_available_stack_size, 0x6_2c6a);/* call 0x10165d52 */
            ii(0x1010_30e8, 1);  push(ebx);                            /* push ebx */
            ii(0x1010_30e9, 1);  push(ecx);                            /* push ecx */
            ii(0x1010_30ea, 1);  push(esi);                            /* push esi */
            ii(0x1010_30eb, 1);  push(edi);                            /* push edi */
            ii(0x1010_30ec, 1);  push(ebp);                            /* push ebp */
            ii(0x1010_30ed, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1010_30ef, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1010_30f5, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1010_30f8, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1010_30fb, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1010_30fe, 3);  add(edx, 0x10);                       /* add edx, 0x10 */
            ii(0x1010_3101, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_3104, 5);  call(0x1013_bb7b, 0x3_8a72);          /* call 0x1013bb7b */
            ii(0x1010_3109, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1010_310c, 3);  add(edx, 0x12);                       /* add edx, 0x12 */
            ii(0x1010_310f, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_3112, 5);  call(0x1013_bb7b, 0x3_8a64);          /* call 0x1013bb7b */
            ii(0x1010_3117, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1010_311a, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_311d, 3);  add(eax, 6);                          /* add eax, 0x6 */
            ii(0x1010_3120, 5);  call(0x1010_2cbf, -0x466);            /* call 0x10102cbf */
            ii(0x1010_3125, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1010_3127, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1010_3128, 1);  pop(edi);                             /* pop edi */
            ii(0x1010_3129, 1);  pop(esi);                             /* pop esi */
            ii(0x1010_312a, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1010_312b, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1010_312c, 1);  ret();                                /* ret */
        }
    }
}
