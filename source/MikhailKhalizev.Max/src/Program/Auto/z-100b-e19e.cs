using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_e19e-513b233e")]
        public void Method_100b_e19e()
        {
            ii(0x100b_e19e, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100b_e1a3, 5);  call(Definitions.sys_check_available_stack_size, 0xa_7baa);/* call 0x10165d52 */
            ii(0x100b_e1a8, 1);  push(ebx);                            /* push ebx */
            ii(0x100b_e1a9, 1);  push(ecx);                            /* push ecx */
            ii(0x100b_e1aa, 1);  push(edx);                            /* push edx */
            ii(0x100b_e1ab, 1);  push(esi);                            /* push esi */
            ii(0x100b_e1ac, 1);  push(edi);                            /* push edi */
            ii(0x100b_e1ad, 1);  push(ebp);                            /* push ebp */
            ii(0x100b_e1ae, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100b_e1b0, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x100b_e1b6, 7);  mov(memd[ss, ebp - 8], 0);            /* mov dword [ebp-0x8], 0x0 */
            ii(0x100b_e1bd, 2);  jmp(0x100b_e1c5, 6); goto l_0x100b_e1c5;/* jmp 0x100be1c5 */
        l_0x100b_e1bf:
            ii(0x100b_e1bf, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_e1c2, 3);  inc(memd[ss, ebp - 8]);               /* inc dword [ebp-0x8] */
        l_0x100b_e1c5:
            ii(0x100b_e1c5, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x100b_e1c9, 3);  cmp(eax, 4);                          /* cmp eax, 0x4 */
            ii(0x100b_e1cc, 2);  if(jge(0x100b_e20a, 0x3c)) goto l_0x100b_e20a;/* jge 0x100be20a */
            ii(0x100b_e1ce, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x100b_e1d2, 6);  imul(eax, eax, 0x247);                /* imul eax, eax, 0x247 */
            ii(0x100b_e1d8, 6);  mov(al, memb[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x100b_e1de, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x100b_e1e3, 3);  cmp(eax, 1);                          /* cmp eax, 0x1 */
            ii(0x100b_e1e6, 2);  if(jz(0x100b_e202, 0x1a)) goto l_0x100b_e202;/* jz 0x100be202 */
            ii(0x100b_e1e8, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x100b_e1ec, 6);  imul(eax, eax, 0x247);                /* imul eax, eax, 0x247 */
            ii(0x100b_e1f2, 6);  mov(al, memb[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x100b_e1f8, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x100b_e1fd, 3);  cmp(eax, 3);                          /* cmp eax, 0x3 */
            ii(0x100b_e200, 2);  if(jnz(0x100b_e208, 6)) goto l_0x100b_e208;/* jnz 0x100be208 */
        l_0x100b_e202:
            ii(0x100b_e202, 4);  mov(memb[ss, ebp - 4], 0);            /* mov byte [ebp-0x4], 0x0 */
            ii(0x100b_e206, 2);  jmp(0x100b_e20e, 6); goto l_0x100b_e20e;/* jmp 0x100be20e */
        l_0x100b_e208:
            ii(0x100b_e208, 2);  jmp(0x100b_e1bf, -0x4b); goto l_0x100b_e1bf;/* jmp 0x100be1bf */
        l_0x100b_e20a:
            ii(0x100b_e20a, 4);  mov(memb[ss, ebp - 4], 1);            /* mov byte [ebp-0x4], 0x1 */
        l_0x100b_e20e:
            ii(0x100b_e20e, 3);  mov(al, memb[ss, ebp - 4]);           /* mov al, [ebp-0x4] */
            ii(0x100b_e211, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100b_e213, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100b_e214, 1);  pop(edi);                             /* pop edi */
            ii(0x100b_e215, 1);  pop(esi);                             /* pop esi */
            ii(0x100b_e216, 1);  pop(edx);                             /* pop edx */
            ii(0x100b_e217, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100b_e218, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100b_e219, 1);  ret();                                /* ret */
        }
    }
}
