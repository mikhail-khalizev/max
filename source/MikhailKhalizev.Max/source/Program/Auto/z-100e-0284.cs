using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_0284-99f734bb")]
        public void Method_100e_0284()
        {
            ii(0x100e_0284, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100e_0289, 5);  call(Definitions.sys_check_available_stack_size, 0x8_5ac4);/* call 0x10165d52 */
            ii(0x100e_028e, 1);  push(ebx);                            /* push ebx */
            ii(0x100e_028f, 1);  push(ecx);                            /* push ecx */
            ii(0x100e_0290, 1);  push(esi);                            /* push esi */
            ii(0x100e_0291, 1);  push(edi);                            /* push edi */
            ii(0x100e_0292, 1);  push(ebp);                            /* push ebp */
            ii(0x100e_0293, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100e_0295, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x100e_029b, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100e_029e, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100e_02a1, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100e_02a3, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_02a6, 3);  add(eax, 4);                          /* add eax, 0x4 */
            ii(0x100e_02a9, 5);  call(0x100e_0244, -0x6a);             /* call 0x100e0244 */
            ii(0x100e_02ae, 3);  sub(eax, 4);                          /* sub eax, 0x4 */
            ii(0x100e_02b1, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100e_02b4, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100e_02b6, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_02b9, 5);  call(0x1008_8b04, -0x5_77ba);         /* call 0x10088b04 */
            ii(0x100e_02be, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100e_02c1, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_02c4, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100e_02c7, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100e_02ca, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100e_02cc, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100e_02cd, 1);  pop(edi);                             /* pop edi */
            ii(0x100e_02ce, 1);  pop(esi);                             /* pop esi */
            ii(0x100e_02cf, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100e_02d0, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100e_02d1, 1);  ret();                                /* ret */
        }
    }
}
