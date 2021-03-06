using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_c68c-8292d79e")]
        public void Method_100f_c68c()
        {
            ii(0x100f_c68c, 5);  push(0x28);                           /* push 0x28 */
            ii(0x100f_c691, 5);  call(Definitions.sys_check_available_stack_size, 0x6_96bc);/* call 0x10165d52 */
            ii(0x100f_c696, 1);  push(esi);                            /* push esi */
            ii(0x100f_c697, 1);  push(edi);                            /* push edi */
            ii(0x100f_c698, 1);  push(ebp);                            /* push ebp */
            ii(0x100f_c699, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100f_c69b, 6);  sub(esp, 0x18);                       /* sub esp, 0x18 */
            ii(0x100f_c6a1, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x100f_c6a4, 3);  mov(memd[ss, ebp - 12], edx);         /* mov [ebp-0xc], edx */
            ii(0x100f_c6a7, 3);  mov(memd[ss, ebp - 8], ebx);          /* mov [ebp-0x8], ebx */
            ii(0x100f_c6aa, 3);  mov(memd[ss, ebp - 4], ecx);          /* mov [ebp-0x4], ecx */
            ii(0x100f_c6ad, 4);  movsx(edx, memw[ss, ebp - 12]);       /* movsx edx, word [ebp-0xc] */
            ii(0x100f_c6b1, 4);  movsx(eax, memw[ss, ebp - 16]);       /* movsx eax, word [ebp-0x10] */
            ii(0x100f_c6b5, 5);  call(0x100f_c58b, -0x12f);            /* call 0x100fc58b */
            ii(0x100f_c6ba, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x100f_c6bd, 4);  movsx(edx, memw[ss, ebp - 24]);       /* movsx edx, word [ebp-0x18] */
            ii(0x100f_c6c1, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x100f_c6c5, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x100f_c6c7, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100f_c6cb, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x100f_c6cd, 2);  if(jle(0x100f_c6d8, 9)) goto l_0x100f_c6d8;/* jle 0x100fc6d8 */
            ii(0x100f_c6cf, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_c6d2, 3);  sub(eax, memd[ss, ebp - 24]);         /* sub eax, [ebp-0x18] */
            ii(0x100f_c6d5, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
        l_0x100f_c6d8:
            ii(0x100f_c6d8, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x100f_c6dc, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100f_c6de, 2);  if(jge(0x100f_c6e7, 7)) goto l_0x100f_c6e7;/* jge 0x100fc6e7 */
            ii(0x100f_c6e0, 7);  mov(memd[ss, ebp - 8], 0);            /* mov dword [ebp-0x8], 0x0 */
        l_0x100f_c6e7:
            ii(0x100f_c6e7, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_c6ea, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x100f_c6ed, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x100f_c6f0, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100f_c6f2, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100f_c6f3, 1);  pop(edi);                             /* pop edi */
            ii(0x100f_c6f4, 1);  pop(esi);                             /* pop esi */
            ii(0x100f_c6f5, 1);  ret();                                /* ret */
        }
    }
}
