using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_9b9b-49a6d3dd")]
        public void Method_1014_9b9b()
        {
            ii(0x1014_9b9b, 5);  push(0x28);                           /* push 0x28 */
            ii(0x1014_9ba0, 5);  call(Definitions.sys_check_available_stack_size, 0x1_c1ad);/* call 0x10165d52 */
            ii(0x1014_9ba5, 1);  push(ebx);                            /* push ebx */
            ii(0x1014_9ba6, 1);  push(ecx);                            /* push ecx */
            ii(0x1014_9ba7, 1);  push(esi);                            /* push esi */
            ii(0x1014_9ba8, 1);  push(edi);                            /* push edi */
            ii(0x1014_9ba9, 1);  push(ebp);                            /* push ebp */
            ii(0x1014_9baa, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1014_9bac, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x1014_9bb2, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1014_9bb5, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1014_9bb8, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_9bbb, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1014_9bbe, 7);  cmp(ax, memw[ds, edx + 215]);         /* cmp ax, [edx+0xd7] */
            ii(0x1014_9bc5, 2);  if(jz(0x1014_9c27, 0x60)) goto l_0x1014_9c27;/* jz 0x10149c27 */
            ii(0x1014_9bc7, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1014_9bc9, 5);  mov(al, memb[ds, 0x101c_37da]);       /* mov al, [0x101c37da] */
            ii(0x1014_9bce, 3);  movsx(edx, ax);                       /* movsx edx, ax */
            ii(0x1014_9bd1, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_9bd4, 5);  call(0x1007_6074, -0xd_3b65);         /* call 0x10076074 */
            ii(0x1014_9bd9, 2);  test(al, al);                         /* test al, al */
            ii(0x1014_9bdb, 2);  if(jnz(0x1014_9be6, 9)) goto l_0x1014_9be6;/* jnz 0x10149be6 */
            ii(0x1014_9bdd, 7);  cmp(memb[ds, 0x101c_3980], 0);        /* cmp byte [0x101c3980], 0x0 */
            ii(0x1014_9be4, 2);  if(jz(0x1014_9bec, 6)) goto l_0x1014_9bec;/* jz 0x10149bec */
        l_0x1014_9be6:
            ii(0x1014_9be6, 4);  mov(memb[ss, ebp - 12], 1);           /* mov byte [ebp-0xc], 0x1 */
            ii(0x1014_9bea, 2);  jmp(0x1014_9bf0, 4); goto l_0x1014_9bf0;/* jmp 0x10149bf0 */
        l_0x1014_9bec:
            ii(0x1014_9bec, 4);  mov(memb[ss, ebp - 12], 0);           /* mov byte [ebp-0xc], 0x0 */
        l_0x1014_9bf0:
            ii(0x1014_9bf0, 3);  mov(al, memb[ss, ebp - 12]);          /* mov al, [ebp-0xc] */
            ii(0x1014_9bf3, 3);  mov(memb[ss, ebp - 16], al);          /* mov [ebp-0x10], al */
            ii(0x1014_9bf6, 4);  cmp(memb[ss, ebp - 16], 0);           /* cmp byte [ebp-0x10], 0x0 */
            ii(0x1014_9bfa, 2);  if(jz(0x1014_9c04, 8)) goto l_0x1014_9c04;/* jz 0x10149c04 */
            ii(0x1014_9bfc, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_9bff, 5);  call(0x1014_9fa8, 0x3a4);             /* call 0x10149fa8 */
        l_0x1014_9c04:
            ii(0x1014_9c04, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_9c07, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1014_9c0a, 7);  mov(memw[ds, edx + 215], ax);         /* mov [edx+0xd7], ax */
            ii(0x1014_9c11, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_9c14, 5);  call(0x1014_9cd1, 0xb8);              /* call 0x10149cd1 */
            ii(0x1014_9c19, 4);  cmp(memb[ss, ebp - 16], 0);           /* cmp byte [ebp-0x10], 0x0 */
            ii(0x1014_9c1d, 2);  if(jz(0x1014_9c27, 8)) goto l_0x1014_9c27;/* jz 0x10149c27 */
            ii(0x1014_9c1f, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_9c22, 5);  call(0x1014_9fa8, 0x381);             /* call 0x10149fa8 */
        l_0x1014_9c27:
            ii(0x1014_9c27, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1014_9c29, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1014_9c2a, 1);  pop(edi);                             /* pop edi */
            ii(0x1014_9c2b, 1);  pop(esi);                             /* pop esi */
            ii(0x1014_9c2c, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1014_9c2d, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1014_9c2e, 1);  ret();                                /* ret */
        }
    }
}
