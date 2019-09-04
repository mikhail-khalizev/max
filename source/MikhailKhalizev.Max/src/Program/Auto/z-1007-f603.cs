using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_f603-d5ecd8b8")]
        public void Method_1007_f603()
        {
            ii(0x1007_f603, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1007_f608, 5);  call(Definitions.sys_check_available_stack_size, 0xe_6745);/* call 0x10165d52 */
            ii(0x1007_f60d, 1);  push(ecx);                            /* push ecx */
            ii(0x1007_f60e, 1);  push(esi);                            /* push esi */
            ii(0x1007_f60f, 1);  push(edi);                            /* push edi */
            ii(0x1007_f610, 1);  push(ebp);                            /* push ebp */
            ii(0x1007_f611, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1007_f613, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x1007_f619, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1007_f61c, 3);  mov(memd[ss, ebp - 8], edx);          /* mov [ebp-0x8], edx */
            ii(0x1007_f61f, 3);  mov(memb[ss, ebp - 4], bl);           /* mov [ebp-0x4], bl */
            ii(0x1007_f622, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1007_f625, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1007_f628, 4);  cmp(memb[ss, ebp - 4], 2);            /* cmp byte [ebp-0x4], 0x2 */
            ii(0x1007_f62c, 2);  if(jnz(0x1007_f64a, 0x1c)) goto l_0x1007_f64a;/* jnz 0x1007f64a */
            ii(0x1007_f62e, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1007_f631, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_f634, 3);  add(eax, 0x22);                       /* add eax, 0x22 */
            ii(0x1007_f637, 5);  call(0x1008_ab1c, 0xb4e0);            /* call 0x1008ab1c */
            ii(0x1007_f63c, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1007_f63f, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_f642, 3);  add(eax, 0x18);                       /* add eax, 0x18 */
            ii(0x1007_f645, 5);  call(0x1008_aab4, 0xb46a);            /* call 0x1008aab4 */
        l_0x1007_f64a:
            ii(0x1007_f64a, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_f64d, 5);  call(0x1007_f76b, 0x119);             /* call 0x1007f76b */
            ii(0x1007_f652, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1007_f654, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1007_f655, 1);  pop(edi);                             /* pop edi */
            ii(0x1007_f656, 1);  pop(esi);                             /* pop esi */
            ii(0x1007_f657, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1007_f658, 1);  ret();                                /* ret */
        }
    }
}
