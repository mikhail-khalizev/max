using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_71a4-ac79ee04")]
        public void Method_100a_71a4()
        {
            ii(0x100a_71a4, 5);  push(0x28);                           /* push 0x28 */
            ii(0x100a_71a9, 5);  call(Definitions.sys_check_available_stack_size, 0xb_eba4);/* call 0x10165d52 */
            ii(0x100a_71ae, 1);  push(ecx);                            /* push ecx */
            ii(0x100a_71af, 1);  push(esi);                            /* push esi */
            ii(0x100a_71b0, 1);  push(edi);                            /* push edi */
            ii(0x100a_71b1, 1);  push(ebp);                            /* push ebp */
            ii(0x100a_71b2, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100a_71b4, 6);  sub(esp, 0x14);                       /* sub esp, 0x14 */
            ii(0x100a_71ba, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100a_71bd, 3);  mov(memd[ss, ebp - 8], edx);          /* mov [ebp-0x8], edx */
            ii(0x100a_71c0, 3);  mov(memb[ss, ebp - 4], bl);           /* mov [ebp-0x4], bl */
            ii(0x100a_71c3, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100a_71c6, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x100a_71c9, 4);  cmp(memb[ss, ebp - 4], 2);            /* cmp byte [ebp-0x4], 0x2 */
            ii(0x100a_71cd, 2);  if(jnz(0x100a_71d9, 0xa)) goto l_0x100a_71d9;/* jnz 0x100a71d9 */
            ii(0x100a_71cf, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100a_71d2, 5);  call(0x100a_71f8, 0x21);              /* call 0x100a71f8 */
            ii(0x100a_71d7, 2);  jmp(0x100a_71f1, 0x18); goto l_0x100a_71f1;/* jmp 0x100a71f1 */
        l_0x100a_71d9:
            ii(0x100a_71d9, 4);  cmp(memb[ss, ebp - 4], 0);            /* cmp byte [ebp-0x4], 0x0 */
            ii(0x100a_71dd, 2);  if(jnz(0x100a_71f1, 0x12)) goto l_0x100a_71f1;/* jnz 0x100a71f1 */
            ii(0x100a_71df, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100a_71e2, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x100a_71e5, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x100a_71e8, 3);  mov(edx, memd[ds, eax + 2]);          /* mov edx, [eax+0x2] */
            ii(0x100a_71eb, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x100a_71ee, 3);  call_abs(memd[ds, edx + 60]);         /* call dword [edx+0x3c] */
        l_0x100a_71f1:
            ii(0x100a_71f1, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100a_71f3, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100a_71f4, 1);  pop(edi);                             /* pop edi */
            ii(0x100a_71f5, 1);  pop(esi);                             /* pop esi */
            ii(0x100a_71f6, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100a_71f7, 1);  ret();                                /* ret */
        }
    }
}
