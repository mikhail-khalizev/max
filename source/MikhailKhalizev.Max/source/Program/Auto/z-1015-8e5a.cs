using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_8e5a-aeee73ac")]
        public void Method_1015_8e5a()
        {
            ii(0x1015_8e5a, 5);  push(0x28);                           /* push 0x28 */
            ii(0x1015_8e5f, 5);  call(Definitions.sys_check_available_stack_size, 0xceee);/* call 0x10165d52 */
            ii(0x1015_8e64, 1);  push(ebx);                            /* push ebx */
            ii(0x1015_8e65, 1);  push(ecx);                            /* push ecx */
            ii(0x1015_8e66, 1);  push(esi);                            /* push esi */
            ii(0x1015_8e67, 1);  push(edi);                            /* push edi */
            ii(0x1015_8e68, 1);  push(ebp);                            /* push ebp */
            ii(0x1015_8e69, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1015_8e6b, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x1015_8e71, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1015_8e74, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1015_8e77, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_8e7a, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1015_8e7d, 5);  mov(eax, 1);                          /* mov eax, 0x1 */
            ii(0x1015_8e82, 5);  call(0x100f_448c, -0x6_49fb);         /* call 0x100f448c */
            ii(0x1015_8e87, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1015_8e8a, 4);  cmp(memb[ds, eax + 85], 0);           /* cmp byte [eax+0x55], 0x0 */
            ii(0x1015_8e8e, 2);  if(jnz(0x1015_8e96, 6)) goto l_0x1015_8e96;/* jnz 0x10158e96 */
            ii(0x1015_8e90, 4);  mov(memb[ss, ebp - 12], 1);           /* mov byte [ebp-0xc], 0x1 */
            ii(0x1015_8e94, 2);  jmp(0x1015_8e9a, 4); goto l_0x1015_8e9a;/* jmp 0x10158e9a */
        l_0x1015_8e96:
            ii(0x1015_8e96, 4);  mov(memb[ss, ebp - 12], 0);           /* mov byte [ebp-0xc], 0x0 */
        l_0x1015_8e9a:
            ii(0x1015_8e9a, 3);  mov(al, memb[ss, ebp - 12]);          /* mov al, [ebp-0xc] */
            ii(0x1015_8e9d, 3);  mov(edx, memd[ss, ebp - 16]);         /* mov edx, [ebp-0x10] */
            ii(0x1015_8ea0, 3);  mov(memb[ds, edx + 85], al);          /* mov [edx+0x55], al */
            ii(0x1015_8ea3, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1015_8ea6, 4);  mov(memb[ds, eax + 86], 0);           /* mov byte [eax+0x56], 0x0 */
            ii(0x1015_8eaa, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1015_8ead, 4);  mov(memb[ds, eax + 87], 0);           /* mov byte [eax+0x57], 0x0 */
            ii(0x1015_8eb1, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1015_8eb3, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1015_8eb4, 1);  pop(edi);                             /* pop edi */
            ii(0x1015_8eb5, 1);  pop(esi);                             /* pop esi */
            ii(0x1015_8eb6, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1015_8eb7, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1015_8eb8, 1);  ret();                                /* ret */
        }
    }
}
