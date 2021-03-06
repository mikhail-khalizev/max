using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_bd7b-c7977511")]
        public void Method_100a_bd7b()
        {
            ii(0x100a_bd7b, 5);  push(0x20);                           /* push 0x20 */
            ii(0x100a_bd80, 5);  call(Definitions.sys_check_available_stack_size, 0xb_9fcd);/* call 0x10165d52 */
            ii(0x100a_bd85, 1);  push(ebx);                            /* push ebx */
            ii(0x100a_bd86, 1);  push(ecx);                            /* push ecx */
            ii(0x100a_bd87, 1);  push(edx);                            /* push edx */
            ii(0x100a_bd88, 1);  push(esi);                            /* push esi */
            ii(0x100a_bd89, 1);  push(edi);                            /* push edi */
            ii(0x100a_bd8a, 1);  push(ebp);                            /* push ebp */
            ii(0x100a_bd8b, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100a_bd8d, 6);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x100a_bd93, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100a_bd96, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100a_bd99, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_bd9c, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x100a_bd9f, 5);  call(0x100b_7f18, 0xc174);            /* call 0x100b7f18 */
            ii(0x100a_bda4, 5);  call(Definitions.my__get_unit, 0xc273);/* call 0x100b801c */
            ii(0x100a_bda9, 5);  call(0x1015_27ed, 0xa_6a3f);          /* call 0x101527ed */
            ii(0x100a_bdae, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_bdb1, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x100a_bdb4, 5);  call(0x100b_7f18, 0xc15f);            /* call 0x100b7f18 */
            ii(0x100a_bdb9, 5);  call(Definitions.my__get_unit, 0xc25e);/* call 0x100b801c */
            ii(0x100a_bdbe, 5);  call(0x1011_fe27, 0x7_4064);          /* call 0x1011fe27 */
            ii(0x100a_bdc3, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_bdc6, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x100a_bdc9, 5);  call(0x100b_7f74, 0xc1a6);            /* call 0x100b7f74 */
            ii(0x100a_bdce, 5);  call(0x1011_fcb2, 0x7_3edf);          /* call 0x1011fcb2 */
            ii(0x100a_bdd3, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100a_bdd5, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100a_bdd6, 1);  pop(edi);                             /* pop edi */
            ii(0x100a_bdd7, 1);  pop(esi);                             /* pop esi */
            ii(0x100a_bdd8, 1);  pop(edx);                             /* pop edx */
            ii(0x100a_bdd9, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100a_bdda, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100a_bddb, 1);  ret();                                /* ret */
        }
    }
}
