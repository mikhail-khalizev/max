using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_0878-b91de4fd")]
        public void Method_100e_0878()
        {
            ii(0x100e_0878, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100e_087d, 5);  call(Definitions.sys_check_available_stack_size, 0x8_54d0);/* call 0x10165d52 */
            ii(0x100e_0882, 1);  push(ebx);                            /* push ebx */
            ii(0x100e_0883, 1);  push(ecx);                            /* push ecx */
            ii(0x100e_0884, 1);  push(esi);                            /* push esi */
            ii(0x100e_0885, 1);  push(edi);                            /* push edi */
            ii(0x100e_0886, 1);  push(ebp);                            /* push ebp */
            ii(0x100e_0887, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100e_0889, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x100e_088f, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100e_0892, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100e_0895, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100e_0899, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x100e_089c, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x100e_089f, 6);  add(edx, 0x1cf);                      /* add edx, 0x1cf */
            ii(0x100e_08a5, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x100e_08a7, 5);  call(0x1007_678c, -0x6_a120);         /* call 0x1007678c */
            ii(0x100e_08ac, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100e_08af, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100e_08b2, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100e_08b4, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100e_08b5, 1);  pop(edi);                             /* pop edi */
            ii(0x100e_08b6, 1);  pop(esi);                             /* pop esi */
            ii(0x100e_08b7, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100e_08b8, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100e_08b9, 1);  ret();                                /* ret */
        }
    }
}
