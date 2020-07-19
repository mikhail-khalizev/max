using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_b097-d697ec64")]
        public void Method_100b_b097()
        {
            ii(0x100b_b097, 5);  push(0x28);                           /* push 0x28 */
            ii(0x100b_b09c, 5);  call(Definitions.sys_check_available_stack_size, 0xa_acb1);/* call 0x10165d52 */
            ii(0x100b_b0a1, 1);  push(ebx);                            /* push ebx */
            ii(0x100b_b0a2, 1);  push(ecx);                            /* push ecx */
            ii(0x100b_b0a3, 1);  push(edx);                            /* push edx */
            ii(0x100b_b0a4, 1);  push(esi);                            /* push esi */
            ii(0x100b_b0a5, 1);  push(edi);                            /* push edi */
            ii(0x100b_b0a6, 1);  push(ebp);                            /* push ebp */
            ii(0x100b_b0a7, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100b_b0a9, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x100b_b0af, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100b_b0b2, 5);  cmp(memw[ss, ebp - 4], 0x28);         /* cmp word [ebp-0x4], 0x28 */
            ii(0x100b_b0b7, 2);  if(jz(0x100b_b0c0, 7)) goto l_0x100b_b0c0;/* jz 0x100bb0c0 */
            ii(0x100b_b0b9, 5);  cmp(memw[ss, ebp - 4], 0x1e);         /* cmp word [ebp-0x4], 0x1e */
            ii(0x100b_b0be, 2);  if(jnz(0x100b_b0c2, 2)) goto l_0x100b_b0c2;/* jnz 0x100bb0c2 */
        l_0x100b_b0c0:
            ii(0x100b_b0c0, 2);  jmp(0x100b_b0c9, 7); goto l_0x100b_b0c9;/* jmp 0x100bb0c9 */
        l_0x100b_b0c2:
            ii(0x100b_b0c2, 5);  cmp(memw[ss, ebp - 4], 0x17);         /* cmp word [ebp-0x4], 0x17 */
            ii(0x100b_b0c7, 2);  if(jnz(0x100b_b0cb, 2)) goto l_0x100b_b0cb;/* jnz 0x100bb0cb */
        l_0x100b_b0c9:
            ii(0x100b_b0c9, 2);  jmp(0x100b_b0d2, 7); goto l_0x100b_b0d2;/* jmp 0x100bb0d2 */
        l_0x100b_b0cb:
            ii(0x100b_b0cb, 5);  cmp(memw[ss, ebp - 4], 0x18);         /* cmp word [ebp-0x4], 0x18 */
            ii(0x100b_b0d0, 2);  if(jnz(0x100b_b0d4, 2)) goto l_0x100b_b0d4;/* jnz 0x100bb0d4 */
        l_0x100b_b0d2:
            ii(0x100b_b0d2, 2);  jmp(0x100b_b0db, 7); goto l_0x100b_b0db;/* jmp 0x100bb0db */
        l_0x100b_b0d4:
            ii(0x100b_b0d4, 5);  cmp(memw[ss, ebp - 4], 0x19);         /* cmp word [ebp-0x4], 0x19 */
            ii(0x100b_b0d9, 2);  if(jnz(0x100b_b0dd, 2)) goto l_0x100b_b0dd;/* jnz 0x100bb0dd */
        l_0x100b_b0db:
            ii(0x100b_b0db, 2);  jmp(0x100b_b0e4, 7); goto l_0x100b_b0e4;/* jmp 0x100bb0e4 */
        l_0x100b_b0dd:
            ii(0x100b_b0dd, 5);  cmp(memw[ss, ebp - 4], 0x1b);         /* cmp word [ebp-0x4], 0x1b */
            ii(0x100b_b0e2, 2);  if(jnz(0x100b_b0ea, 6)) goto l_0x100b_b0ea;/* jnz 0x100bb0ea */
        l_0x100b_b0e4:
            ii(0x100b_b0e4, 4);  mov(memb[ss, ebp - 8], 1);            /* mov byte [ebp-0x8], 0x1 */
            ii(0x100b_b0e8, 2);  jmp(0x100b_b0ee, 4); goto l_0x100b_b0ee;/* jmp 0x100bb0ee */
        l_0x100b_b0ea:
            ii(0x100b_b0ea, 4);  mov(memb[ss, ebp - 8], 0);            /* mov byte [ebp-0x8], 0x0 */
        l_0x100b_b0ee:
            ii(0x100b_b0ee, 3);  mov(al, memb[ss, ebp - 8]);           /* mov al, [ebp-0x8] */
            ii(0x100b_b0f1, 3);  mov(memb[ss, ebp - 12], al);          /* mov [ebp-0xc], al */
            ii(0x100b_b0f4, 3);  mov(al, memb[ss, ebp - 12]);          /* mov al, [ebp-0xc] */
            ii(0x100b_b0f7, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100b_b0f9, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100b_b0fa, 1);  pop(edi);                             /* pop edi */
            ii(0x100b_b0fb, 1);  pop(esi);                             /* pop esi */
            ii(0x100b_b0fc, 1);  pop(edx);                             /* pop edx */
            ii(0x100b_b0fd, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100b_b0fe, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100b_b0ff, 1);  ret();                                /* ret */
        }
    }
}
