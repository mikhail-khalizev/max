using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_de99-43ae5939")]
        public void Method_100b_de99()
        {
            ii(0x100b_de99, 5);  push(0x20);                           /* push 0x20 */
            ii(0x100b_de9e, 5);  call(Definitions.sys_check_available_stack_size, 0xa_7eaf);/* call 0x10165d52 */
            ii(0x100b_dea3, 1);  push(ebx);                            /* push ebx */
            ii(0x100b_dea4, 1);  push(ecx);                            /* push ecx */
            ii(0x100b_dea5, 1);  push(esi);                            /* push esi */
            ii(0x100b_dea6, 1);  push(edi);                            /* push edi */
            ii(0x100b_dea7, 1);  push(ebp);                            /* push ebp */
            ii(0x100b_dea8, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100b_deaa, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x100b_deb0, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100b_deb3, 3);  mov(memb[ss, ebp - 4], dl);           /* mov [ebp-0x4], dl */
            ii(0x100b_deb6, 3);  mov(al, memb[ss, ebp - 4]);           /* mov al, [ebp-0x4] */
            ii(0x100b_deb9, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x100b_debc, 3);  mov(memb[ds, edx + 15], al);          /* mov [edx+0xf], al */
            ii(0x100b_debf, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100b_dec1, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100b_dec2, 1);  pop(edi);                             /* pop edi */
            ii(0x100b_dec3, 1);  pop(esi);                             /* pop esi */
            ii(0x100b_dec4, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100b_dec5, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100b_dec6, 1);  ret();                                /* ret */
        }
    }
}
