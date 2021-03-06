using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_8aee-1921fce8")]
        public void Method_1015_8aee()
        {
            ii(0x1015_8aee, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1015_8af3, 5);  call(Definitions.sys_check_available_stack_size, 0xd25a);/* call 0x10165d52 */
            ii(0x1015_8af8, 1);  push(ebx);                            /* push ebx */
            ii(0x1015_8af9, 1);  push(ecx);                            /* push ecx */
            ii(0x1015_8afa, 1);  push(esi);                            /* push esi */
            ii(0x1015_8afb, 1);  push(edi);                            /* push edi */
            ii(0x1015_8afc, 1);  push(ebp);                            /* push ebp */
            ii(0x1015_8afd, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1015_8aff, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1015_8b05, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1015_8b08, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1015_8b0b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_8b0e, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1015_8b11, 5);  mov(eax, 1);                          /* mov eax, 0x1 */
            ii(0x1015_8b16, 5);  call(0x100f_448c, -0x6_468f);         /* call 0x100f448c */
            ii(0x1015_8b1b, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1015_8b1e, 4);  cmp(memb[ds, eax + 87], 3);           /* cmp byte [eax+0x57], 0x3 */
            ii(0x1015_8b22, 2);  if(jnz(0x1015_8b2d, 9)) goto l_0x1015_8b2d;/* jnz 0x10158b2d */
            ii(0x1015_8b24, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1015_8b27, 4);  mov(memb[ds, eax + 87], 0);           /* mov byte [eax+0x57], 0x0 */
            ii(0x1015_8b2b, 2);  jmp(0x1015_8b34, 7); goto l_0x1015_8b34;/* jmp 0x10158b34 */
        l_0x1015_8b2d:
            ii(0x1015_8b2d, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1015_8b30, 4);  mov(memb[ds, eax + 87], 3);           /* mov byte [eax+0x57], 0x3 */
        l_0x1015_8b34:
            ii(0x1015_8b34, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1015_8b37, 4);  mov(memb[ds, eax + 85], 0);           /* mov byte [eax+0x55], 0x0 */
            ii(0x1015_8b3b, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1015_8b3e, 4);  mov(memb[ds, eax + 86], 0);           /* mov byte [eax+0x56], 0x0 */
            ii(0x1015_8b42, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1015_8b44, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1015_8b45, 1);  pop(edi);                             /* pop edi */
            ii(0x1015_8b46, 1);  pop(esi);                             /* pop esi */
            ii(0x1015_8b47, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1015_8b48, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1015_8b49, 1);  ret();                                /* ret */
        }
    }
}
