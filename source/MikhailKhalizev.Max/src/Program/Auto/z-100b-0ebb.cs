using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_0ebb-7ec12dd8")]
        public void Method_100b_0ebb()
        {
            ii(0x100b_0ebb, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100b_0ec0, 5);  call(Definitions.sys_check_available_stack_size, 0xb_4e8d);/* call 0x10165d52 */
            ii(0x100b_0ec5, 1);  push(ecx);                            /* push ecx */
            ii(0x100b_0ec6, 1);  push(esi);                            /* push esi */
            ii(0x100b_0ec7, 1);  push(edi);                            /* push edi */
            ii(0x100b_0ec8, 1);  push(ebp);                            /* push ebp */
            ii(0x100b_0ec9, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100b_0ecb, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x100b_0ed1, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100b_0ed4, 3);  mov(memd[ss, ebp - 8], edx);          /* mov [ebp-0x8], edx */
            ii(0x100b_0ed7, 3);  mov(memb[ss, ebp - 4], bl);           /* mov [ebp-0x4], bl */
            ii(0x100b_0eda, 4);  cmp(memb[ss, ebp - 4], 0);            /* cmp byte [ebp-0x4], 0x0 */
            ii(0x100b_0ede, 2);  if(jnz(0x100b_0f06, 0x26)) goto l_0x100b_0f06;/* jnz 0x100b0f06 */
            ii(0x100b_0ee0, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_0ee3, 3);  mov(al, memb[ds, eax + 78]);          /* mov al, [eax+0x4e] */
            ii(0x100b_0ee6, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x100b_0eeb, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100b_0eed, 2);  if(jle(0x100b_0ef5, 6)) goto l_0x100b_0ef5;/* jle 0x100b0ef5 */
            ii(0x100b_0eef, 4);  mov(memb[ss, ebp - 16], 1);           /* mov byte [ebp-0x10], 0x1 */
            ii(0x100b_0ef3, 2);  jmp(0x100b_0ef9, 4); goto l_0x100b_0ef9;/* jmp 0x100b0ef9 */
        l_0x100b_0ef5:
            ii(0x100b_0ef5, 4);  mov(memb[ss, ebp - 16], 0);           /* mov byte [ebp-0x10], 0x0 */
        l_0x100b_0ef9:
            ii(0x100b_0ef9, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100b_0efb, 3);  mov(dl, memb[ss, ebp - 16]);          /* mov dl, [ebp-0x10] */
            ii(0x100b_0efe, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_0f01, 5);  call(0x100a_297d, -0xe589);           /* call 0x100a297d */
        l_0x100b_0f06:
            ii(0x100b_0f06, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100b_0f08, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100b_0f09, 1);  pop(edi);                             /* pop edi */
            ii(0x100b_0f0a, 1);  pop(esi);                             /* pop esi */
            ii(0x100b_0f0b, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100b_0f0c, 1);  ret();                                /* ret */
        }
    }
}
