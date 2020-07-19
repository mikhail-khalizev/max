using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_e4a5-5ee24641")]
        public void Method_1010_e4a5()
        {
            ii(0x1010_e4a5, 5);  push(0x2c);                           /* push 0x2c */
            ii(0x1010_e4aa, 5);  call(Definitions.sys_check_available_stack_size, 0x5_78a3);/* call 0x10165d52 */
            ii(0x1010_e4af, 1);  push(ebx);                            /* push ebx */
            ii(0x1010_e4b0, 1);  push(ecx);                            /* push ecx */
            ii(0x1010_e4b1, 1);  push(edx);                            /* push edx */
            ii(0x1010_e4b2, 1);  push(esi);                            /* push esi */
            ii(0x1010_e4b3, 1);  push(edi);                            /* push edi */
            ii(0x1010_e4b4, 1);  push(ebp);                            /* push ebp */
            ii(0x1010_e4b5, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1010_e4b7, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x1010_e4bd, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1010_e4c0, 5);  call(0x100d_4e6c, -0x3_9659);         /* call 0x100d4e6c */
            ii(0x1010_e4c5, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1010_e4ca, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1010_e4cd, 7);  mov(memd[ss, ebp - 12], 0);           /* mov dword [ebp-0xc], 0x0 */
            ii(0x1010_e4d4, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_e4d7, 4);  cmp(memd[ds, eax + 12], 0);           /* cmp dword [eax+0xc], 0x0 */
            ii(0x1010_e4db, 2);  if(jz(0x1010_e4e3, 6)) goto l_0x1010_e4e3;/* jz 0x1010e4e3 */
            ii(0x1010_e4dd, 4);  mov(memb[ss, ebp - 8], 0);            /* mov byte [ebp-0x8], 0x0 */
            ii(0x1010_e4e1, 2);  jmp(0x1010_e4e7, 4); goto l_0x1010_e4e7;/* jmp 0x1010e4e7 */
        l_0x1010_e4e3:
            ii(0x1010_e4e3, 4);  mov(memb[ss, ebp - 8], 0x19);         /* mov byte [ebp-0x8], 0x19 */
        l_0x1010_e4e7:
            ii(0x1010_e4e7, 3);  mov(eax, memd[ss, ebp - 11]);         /* mov eax, [ebp-0xb] */
            ii(0x1010_e4ea, 3);  sar(eax, 0x18);                       /* sar eax, 0x18 */
            ii(0x1010_e4ed, 3);  mov(ebx, memd[ss, ebp - 16]);         /* mov ebx, [ebp-0x10] */
            ii(0x1010_e4f0, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1010_e4f3, 5);  call(0x1010_5b00, -0x89f8);           /* call 0x10105b00 */
            ii(0x1010_e4f8, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1010_e4fa, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1010_e4fb, 1);  pop(edi);                             /* pop edi */
            ii(0x1010_e4fc, 1);  pop(esi);                             /* pop esi */
            ii(0x1010_e4fd, 1);  pop(edx);                             /* pop edx */
            ii(0x1010_e4fe, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1010_e4ff, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1010_e500, 1);  ret();                                /* ret */
        }
    }
}
