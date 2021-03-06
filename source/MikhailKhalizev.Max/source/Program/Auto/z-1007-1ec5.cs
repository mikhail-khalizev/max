using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_1ec5-e81e799")]
        public void Method_1007_1ec5()
        {
            ii(0x1007_1ec5, 5);  push(0x2c);                           /* push 0x2c */
            ii(0x1007_1eca, 5);  call(Definitions.sys_check_available_stack_size, 0xf_3e83);/* call 0x10165d52 */
            ii(0x1007_1ecf, 1);  push(ebx);                            /* push ebx */
            ii(0x1007_1ed0, 1);  push(ecx);                            /* push ecx */
            ii(0x1007_1ed1, 1);  push(edx);                            /* push edx */
            ii(0x1007_1ed2, 1);  push(esi);                            /* push esi */
            ii(0x1007_1ed3, 1);  push(edi);                            /* push edi */
            ii(0x1007_1ed4, 1);  push(ebp);                            /* push ebp */
            ii(0x1007_1ed5, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1007_1ed7, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x1007_1edd, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1007_1ee0, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_1ee3, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1007_1ee6, 2);  jmp(0x1007_1efc, 0x14); goto l_0x1007_1efc;/* jmp 0x10071efc */
        l_0x1007_1ee8:
            ii(0x1007_1ee8, 7);  mov(memd[ss, ebp - 12], 6);           /* mov dword [ebp-0xc], 0x6 */
            ii(0x1007_1eef, 2);  jmp(0x1007_1f22, 0x31); goto l_0x1007_1f22;/* jmp 0x10071f22 */
        l_0x1007_1ef1:
            ii(0x1007_1ef1, 7);  mov(memd[ss, ebp - 12], 2);           /* mov dword [ebp-0xc], 0x2 */
            ii(0x1007_1ef8, 2);  jmp(0x1007_1f22, 0x28); goto l_0x1007_1f22;/* jmp 0x10071f22 */
        l_0x1007_1efa:
            ii(0x1007_1efa, 2);  jmp(0x1007_1f1b, 0x1f); goto l_0x1007_1f1b;/* jmp 0x10071f1b */
        l_0x1007_1efc:
            ii(0x1007_1efc, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_1eff, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1007_1f02, 5);  cmp(memw[ss, ebp - 16], 1);           /* cmp word [ebp-0x10], 0x1 */
            ii(0x1007_1f07, 2);  if(jb(0x1007_1f19, 0x10)) goto l_0x1007_1f19;/* jb 0x10071f19 */
            ii(0x1007_1f09, 5);  cmp(memw[ss, ebp - 16], 1);           /* cmp word [ebp-0x10], 0x1 */
            ii(0x1007_1f0e, 2);  if(jbe(0x1007_1ee8, -0x28)) goto l_0x1007_1ee8;/* jbe 0x10071ee8 */
            ii(0x1007_1f10, 5);  cmp(memw[ss, ebp - 16], 2);           /* cmp word [ebp-0x10], 0x2 */
            ii(0x1007_1f15, 2);  if(jz(0x1007_1ef1, -0x26)) goto l_0x1007_1ef1;/* jz 0x10071ef1 */
            ii(0x1007_1f17, 2);  jmp(0x1007_1efa, -0x1f); goto l_0x1007_1efa;/* jmp 0x10071efa */
        l_0x1007_1f19:
            ii(0x1007_1f19, 2);  jmp(0x1007_1efa, -0x21); goto l_0x1007_1efa;/* jmp 0x10071efa */
        l_0x1007_1f1b:
            ii(0x1007_1f1b, 7);  mov(memd[ss, ebp - 12], 0);           /* mov dword [ebp-0xc], 0x0 */
        l_0x1007_1f22:
            ii(0x1007_1f22, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1007_1f25, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1007_1f27, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1007_1f28, 1);  pop(edi);                             /* pop edi */
            ii(0x1007_1f29, 1);  pop(esi);                             /* pop esi */
            ii(0x1007_1f2a, 1);  pop(edx);                             /* pop edx */
            ii(0x1007_1f2b, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1007_1f2c, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1007_1f2d, 1);  ret();                                /* ret */
        }
    }
}
