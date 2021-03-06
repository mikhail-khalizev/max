using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_f19e-7b9ebc69")]
        public void Method_1009_f19e()
        {
            ii(0x1009_f19e, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1009_f1a3, 5);  call(Definitions.sys_check_available_stack_size, 0xc_6baa);/* call 0x10165d52 */
            ii(0x1009_f1a8, 1);  push(ebx);                            /* push ebx */
            ii(0x1009_f1a9, 1);  push(ecx);                            /* push ecx */
            ii(0x1009_f1aa, 1);  push(esi);                            /* push esi */
            ii(0x1009_f1ab, 1);  push(edi);                            /* push edi */
            ii(0x1009_f1ac, 1);  push(ebp);                            /* push ebp */
            ii(0x1009_f1ad, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1009_f1af, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1009_f1b5, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1009_f1b8, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1009_f1bb, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1009_f1be, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_f1c1, 5);  call(0x1015_2a52, 0xb_388c);          /* call 0x10152a52 */
            ii(0x1009_f1c6, 2);  test(al, al);                         /* test al, al */
            ii(0x1009_f1c8, 2);  if(jnz(0x1009_f1d0, 6)) goto l_0x1009_f1d0;/* jnz 0x1009f1d0 */
            ii(0x1009_f1ca, 4);  mov(memb[ss, ebp - 12], 0);           /* mov byte [ebp-0xc], 0x0 */
            ii(0x1009_f1ce, 2);  jmp(0x1009_f1f9, 0x29); goto l_0x1009_f1f9;/* jmp 0x1009f1f9 */
        l_0x1009_f1d0:
            ii(0x1009_f1d0, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_f1d3, 3);  mov(al, memb[ds, eax + 78]);          /* mov al, [eax+0x4e] */
            ii(0x1009_f1d6, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1009_f1db, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1009_f1dd, 2);  if(jnz(0x1009_f1e5, 6)) goto l_0x1009_f1e5;/* jnz 0x1009f1e5 */
            ii(0x1009_f1df, 4);  mov(memb[ss, ebp - 12], 0);           /* mov byte [ebp-0xc], 0x0 */
            ii(0x1009_f1e3, 2);  jmp(0x1009_f1f9, 0x14); goto l_0x1009_f1f9;/* jmp 0x1009f1f9 */
        l_0x1009_f1e5:
            ii(0x1009_f1e5, 5);  mov(ebx, 1);                          /* mov ebx, 0x1 */
            ii(0x1009_f1ea, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1009_f1ed, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_f1f0, 5);  call(0x1009_d066, -0x218f);           /* call 0x1009d066 */
            ii(0x1009_f1f5, 4);  mov(memb[ss, ebp - 12], 1);           /* mov byte [ebp-0xc], 0x1 */
        l_0x1009_f1f9:
            ii(0x1009_f1f9, 3);  mov(al, memb[ss, ebp - 12]);          /* mov al, [ebp-0xc] */
            ii(0x1009_f1fc, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1009_f1fe, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1009_f1ff, 1);  pop(edi);                             /* pop edi */
            ii(0x1009_f200, 1);  pop(esi);                             /* pop esi */
            ii(0x1009_f201, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1009_f202, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1009_f203, 1);  ret();                                /* ret */
        }
    }
}
