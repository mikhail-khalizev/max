using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_b8d1-8184bad3")]
        public void Method_1007_b8d1()
        {
            ii(0x1007_b8d1, 5);  push(0x28);                           /* push 0x28 */
            ii(0x1007_b8d6, 5);  call(Definitions.sys_check_available_stack_size, 0xe_a477);/* call 0x10165d52 */
            ii(0x1007_b8db, 1);  push(ebx);                            /* push ebx */
            ii(0x1007_b8dc, 1);  push(ecx);                            /* push ecx */
            ii(0x1007_b8dd, 1);  push(edx);                            /* push edx */
            ii(0x1007_b8de, 1);  push(esi);                            /* push esi */
            ii(0x1007_b8df, 1);  push(edi);                            /* push edi */
            ii(0x1007_b8e0, 1);  push(ebp);                            /* push ebp */
            ii(0x1007_b8e1, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1007_b8e3, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1007_b8e9, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1007_b8ec, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_b8ef, 4);  cmp(memb[ds, eax + 61], 2);           /* cmp byte [eax+0x3d], 0x2 */
            ii(0x1007_b8f3, 2);  if(jnz(0x1007_b8fe, 9)) goto l_0x1007_b8fe;/* jnz 0x1007b8fe */
            ii(0x1007_b8f5, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_b8f8, 4);  cmp(memb[ds, eax + 62], 1);           /* cmp byte [eax+0x3e], 0x1 */
            ii(0x1007_b8fc, 2);  if(jnz(0x1007_b900, 2)) goto l_0x1007_b900;/* jnz 0x1007b900 */
        l_0x1007_b8fe:
            ii(0x1007_b8fe, 2);  jmp(0x1007_b906, 6); goto l_0x1007_b906;/* jmp 0x1007b906 */
        l_0x1007_b900:
            ii(0x1007_b900, 4);  mov(memb[ss, ebp - 8], 1);            /* mov byte [ebp-0x8], 0x1 */
            ii(0x1007_b904, 2);  jmp(0x1007_b90a, 4); goto l_0x1007_b90a;/* jmp 0x1007b90a */
        l_0x1007_b906:
            ii(0x1007_b906, 4);  mov(memb[ss, ebp - 8], 0);            /* mov byte [ebp-0x8], 0x0 */
        l_0x1007_b90a:
            ii(0x1007_b90a, 3);  mov(al, memb[ss, ebp - 8]);           /* mov al, [ebp-0x8] */
            ii(0x1007_b90d, 3);  mov(memb[ss, ebp - 12], al);          /* mov [ebp-0xc], al */
            ii(0x1007_b910, 3);  mov(al, memb[ss, ebp - 12]);          /* mov al, [ebp-0xc] */
            ii(0x1007_b913, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1007_b915, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1007_b916, 1);  pop(edi);                             /* pop edi */
            ii(0x1007_b917, 1);  pop(esi);                             /* pop esi */
            ii(0x1007_b918, 1);  pop(edx);                             /* pop edx */
            ii(0x1007_b919, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1007_b91a, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1007_b91b, 1);  ret();                                /* ret */
        }
    }
}
