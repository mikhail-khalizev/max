using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_4cfc-f185da40")]
        public void Method_100e_4cfc()
        {
            ii(0x100e_4cfc, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100e_4d01, 5);  call(Definitions.sys_check_available_stack_size, 0x8_104c);/* call 0x10165d52 */
            ii(0x100e_4d06, 1);  push(esi);                            /* push esi */
            ii(0x100e_4d07, 1);  push(edi);                            /* push edi */
            ii(0x100e_4d08, 1);  push(ebp);                            /* push ebp */
            ii(0x100e_4d09, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100e_4d0b, 6);  sub(esp, 0x14);                       /* sub esp, 0x14 */
            ii(0x100e_4d11, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x100e_4d14, 3);  mov(memd[ss, ebp - 12], edx);         /* mov [ebp-0xc], edx */
            ii(0x100e_4d17, 3);  mov(memd[ss, ebp - 8], ebx);          /* mov [ebp-0x8], ebx */
            ii(0x100e_4d1a, 3);  mov(memd[ss, ebp - 4], ecx);          /* mov [ebp-0x4], ecx */
            ii(0x100e_4d1d, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100e_4d20, 4);  cmp(ax, memw[ss, ebp - 8]);           /* cmp ax, [ebp-0x8] */
            ii(0x100e_4d24, 2);  if(jl(0x100e_4d2f, 9)) goto l_0x100e_4d2f;/* jl 0x100e4d2f */
            ii(0x100e_4d26, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100e_4d29, 4);  cmp(ax, memw[ss, ebp - 4]);           /* cmp ax, [ebp-0x4] */
            ii(0x100e_4d2d, 2);  if(jle(0x100e_4d31, 2)) goto l_0x100e_4d31;/* jle 0x100e4d31 */
        l_0x100e_4d2f:
            ii(0x100e_4d2f, 2);  jmp(0x100e_4d3a, 9); goto l_0x100e_4d3a;/* jmp 0x100e4d3a */
        l_0x100e_4d31:
            ii(0x100e_4d31, 7);  mov(memd[ss, ebp - 20], 0);           /* mov dword [ebp-0x14], 0x0 */
            ii(0x100e_4d38, 2);  jmp(0x100e_4d70, 0x36); goto l_0x100e_4d70;/* jmp 0x100e4d70 */
        l_0x100e_4d3a:
            ii(0x100e_4d3a, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100e_4d3d, 4);  cmp(ax, memw[ss, ebp - 8]);           /* cmp ax, [ebp-0x8] */
            ii(0x100e_4d41, 2);  if(jg(0x100e_4d4c, 9)) goto l_0x100e_4d4c;/* jg 0x100e4d4c */
            ii(0x100e_4d43, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100e_4d46, 4);  cmp(ax, memw[ss, ebp - 4]);           /* cmp ax, [ebp-0x4] */
            ii(0x100e_4d4a, 2);  if(jge(0x100e_4d4e, 2)) goto l_0x100e_4d4e;/* jge 0x100e4d4e */
        l_0x100e_4d4c:
            ii(0x100e_4d4c, 2);  jmp(0x100e_4d57, 9); goto l_0x100e_4d57;/* jmp 0x100e4d57 */
        l_0x100e_4d4e:
            ii(0x100e_4d4e, 7);  mov(memd[ss, ebp - 20], 3);           /* mov dword [ebp-0x14], 0x3 */
            ii(0x100e_4d55, 2);  jmp(0x100e_4d70, 0x19); goto l_0x100e_4d70;/* jmp 0x100e4d70 */
        l_0x100e_4d57:
            ii(0x100e_4d57, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100e_4d5a, 4);  cmp(ax, memw[ss, ebp - 8]);           /* cmp ax, [ebp-0x8] */
            ii(0x100e_4d5e, 2);  if(jge(0x100e_4d69, 9)) goto l_0x100e_4d69;/* jge 0x100e4d69 */
            ii(0x100e_4d60, 7);  mov(memd[ss, ebp - 20], 1);           /* mov dword [ebp-0x14], 0x1 */
            ii(0x100e_4d67, 2);  jmp(0x100e_4d70, 7); goto l_0x100e_4d70;/* jmp 0x100e4d70 */
        l_0x100e_4d69:
            ii(0x100e_4d69, 7);  mov(memd[ss, ebp - 20], 2);           /* mov dword [ebp-0x14], 0x2 */
        l_0x100e_4d70:
            ii(0x100e_4d70, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x100e_4d73, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100e_4d75, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100e_4d76, 1);  pop(edi);                             /* pop edi */
            ii(0x100e_4d77, 1);  pop(esi);                             /* pop esi */
            ii(0x100e_4d78, 1);  ret();                                /* ret */
        }
    }
}
