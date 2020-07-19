using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_f049-9c5552f6")]
        public void Method_100f_f049()
        {
            ii(0x100f_f049, 5);  push(0x2c);                           /* push 0x2c */
            ii(0x100f_f04e, 5);  call(Definitions.sys_check_available_stack_size, 0x6_6cff);/* call 0x10165d52 */
            ii(0x100f_f053, 1);  push(ebx);                            /* push ebx */
            ii(0x100f_f054, 1);  push(ecx);                            /* push ecx */
            ii(0x100f_f055, 1);  push(edx);                            /* push edx */
            ii(0x100f_f056, 1);  push(esi);                            /* push esi */
            ii(0x100f_f057, 1);  push(edi);                            /* push edi */
            ii(0x100f_f058, 1);  push(ebp);                            /* push ebp */
            ii(0x100f_f059, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100f_f05b, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x100f_f061, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100f_f064, 5);  call(0x100f_ef80, -0xe9);             /* call 0x100fef80 */
            ii(0x100f_f069, 4);  cmp(ax, memw[ss, ebp - 4]);           /* cmp ax, [ebp-0x4] */
            ii(0x100f_f06d, 2);  if(jz(0x100f_f0b1, 0x42)) goto l_0x100f_f0b1;/* jz 0x100ff0b1 */
            ii(0x100f_f06f, 5);  call(0x100f_ef80, -0xf4);             /* call 0x100fef80 */
            ii(0x100f_f074, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100f_f077, 7);  mov(memd[ss, ebp - 16], 1);           /* mov dword [ebp-0x10], 0x1 */
            ii(0x100f_f07e, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100f_f081, 1);  inc(eax);                             /* inc eax */
            ii(0x100f_f082, 4);  imul(eax, memd[ss, ebp - 4]);         /* imul eax, [ebp-0x4] */
            ii(0x100f_f086, 5);  add(eax, 0x443);                      /* add eax, 0x443 */
            ii(0x100f_f08b, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100f_f08e, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100f_f091, 3);  add(eax, memd[ss, ebp - 16]);         /* add eax, [ebp-0x10] */
            ii(0x100f_f094, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100f_f097, 5);  call(0x100d_5470, -0x2_9c2c);         /* call 0x100d5470 */
            ii(0x100f_f09c, 3);  movsx(ecx, ax);                       /* movsx ecx, ax */
            ii(0x100f_f09f, 4);  movsx(ebx, memw[ss, ebp - 8]);        /* movsx ebx, word [ebp-0x8] */
            ii(0x100f_f0a3, 4);  movsx(edx, memw[ss, ebp - 12]);       /* movsx edx, word [ebp-0xc] */
            ii(0x100f_f0a7, 5);  mov(eax, 0x101c_7278);                /* mov eax, 0x101c7278 */
            ii(0x100f_f0ac, 5);  call(0x1013_daea, 0x3_ea39);          /* call 0x1013daea */
        l_0x100f_f0b1:
            ii(0x100f_f0b1, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100f_f0b3, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100f_f0b4, 1);  pop(edi);                             /* pop edi */
            ii(0x100f_f0b5, 1);  pop(esi);                             /* pop esi */
            ii(0x100f_f0b6, 1);  pop(edx);                             /* pop edx */
            ii(0x100f_f0b7, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100f_f0b8, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100f_f0b9, 1);  ret();                                /* ret */
        }
    }
}
