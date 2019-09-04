using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_8b4a-569d5f36")]
        public void Method_100a_8b4a()
        {
            ii(0x100a_8b4a, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100a_8b4f, 5);  call(Definitions.sys_check_available_stack_size, 0xb_d1fe);/* call 0x10165d52 */
            ii(0x100a_8b54, 1);  push(ebx);                            /* push ebx */
            ii(0x100a_8b55, 1);  push(ecx);                            /* push ecx */
            ii(0x100a_8b56, 1);  push(edx);                            /* push edx */
            ii(0x100a_8b57, 1);  push(esi);                            /* push esi */
            ii(0x100a_8b58, 1);  push(edi);                            /* push edi */
            ii(0x100a_8b59, 1);  push(ebp);                            /* push ebp */
            ii(0x100a_8b5a, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100a_8b5c, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x100a_8b62, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100a_8b65, 7);  mov(memd[ss, ebp - 8], 0);            /* mov dword [ebp-0x8], 0x0 */
            ii(0x100a_8b6c, 2);  jmp(0x100a_8b74, 6); goto l_0x100a_8b74;/* jmp 0x100a8b74 */
        l_0x100a_8b6e:
            ii(0x100a_8b6e, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_8b71, 3);  inc(memd[ss, ebp - 8]);               /* inc dword [ebp-0x8] */
        l_0x100a_8b74:
            ii(0x100a_8b74, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x100a_8b78, 3);  cmp(eax, 4);                          /* cmp eax, 0x4 */
            ii(0x100a_8b7b, 2);  if(jge(0x100a_8bb4, 0x37)) goto l_0x100a_8bb4;/* jge 0x100a8bb4 */
            ii(0x100a_8b7d, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x100a_8b81, 6);  imul(eax, eax, 0x247);                /* imul eax, eax, 0x247 */
            ii(0x100a_8b87, 6);  mov(al, memb[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x100a_8b8d, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x100a_8b92, 3);  cmp(eax, 2);                          /* cmp eax, 0x2 */
            ii(0x100a_8b95, 2);  if(jnz(0x100a_8bb2, 0x1b)) goto l_0x100a_8bb2;/* jnz 0x100a8bb2 */
            ii(0x100a_8b97, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x100a_8b9c, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x100a_8ba0, 6);  imul(eax, eax, 0xc5);                 /* imul eax, eax, 0xc5 */
            ii(0x100a_8ba6, 5);  mov(ebx, 0x101c_31c4);                /* mov ebx, 0x101c31c4 */
            ii(0x100a_8bab, 2);  add(eax, ebx);                        /* add eax, ebx */
            ii(0x100a_8bad, 5);  call(0x100b_de99, 0x1_52e7);          /* call 0x100bde99 */
        l_0x100a_8bb2:
            ii(0x100a_8bb2, 2);  jmp(0x100a_8b6e, -0x46); goto l_0x100a_8b6e;/* jmp 0x100a8b6e */
        l_0x100a_8bb4:
            ii(0x100a_8bb4, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100a_8bb6, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100a_8bb7, 1);  pop(edi);                             /* pop edi */
            ii(0x100a_8bb8, 1);  pop(esi);                             /* pop esi */
            ii(0x100a_8bb9, 1);  pop(edx);                             /* pop edx */
            ii(0x100a_8bba, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100a_8bbb, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100a_8bbc, 1);  ret();                                /* ret */
        }
    }
}
