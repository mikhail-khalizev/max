using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_e354-9b916a32")]
        public void Method_100f_e354()
        {
            ii(0x100f_e354, 5);  push(0x28);                           /* push 0x28 */
            ii(0x100f_e359, 5);  call(Definitions.sys_check_available_stack_size, 0x6_79f4);/* call 0x10165d52 */
            ii(0x100f_e35e, 1);  push(ebx);                            /* push ebx */
            ii(0x100f_e35f, 1);  push(ecx);                            /* push ecx */
            ii(0x100f_e360, 1);  push(esi);                            /* push esi */
            ii(0x100f_e361, 1);  push(edi);                            /* push edi */
            ii(0x100f_e362, 1);  push(ebp);                            /* push ebp */
            ii(0x100f_e363, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100f_e365, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x100f_e36b, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100f_e36e, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100f_e371, 7);  mov(memd[ss, ebp - 12], 0x10);        /* mov dword [ebp-0xc], 0x10 */
        l_0x100f_e378:
            ii(0x100f_e378, 3);  dec(memd[ss, ebp - 12]);              /* dec dword [ebp-0xc] */
            ii(0x100f_e37b, 5);  cmp(memw[ss, ebp - 12], -1 /* 0xff */);/* cmp word [ebp-0xc], 0xffff */
            ii(0x100f_e380, 2);  if(jz(0x100f_e39f, 0x1d)) goto l_0x100f_e39f;/* jz 0x100fe39f */
            ii(0x100f_e382, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100f_e386, 3);  test(ah, 0x80);                       /* test ah, 0x80 */
            ii(0x100f_e389, 2);  if(jz(0x100f_e39a, 0xf)) goto l_0x100f_e39a;/* jz 0x100fe39a */
            ii(0x100f_e38b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_e38e, 2);  add(eax, eax);                        /* add eax, eax */
            ii(0x100f_e390, 5);  xor(eax, 0x1021);                     /* xor eax, 0x1021 */
            ii(0x100f_e395, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100f_e398, 2);  jmp(0x100f_e39d, 3); goto l_0x100f_e39d;/* jmp 0x100fe39d */
        l_0x100f_e39a:
            ii(0x100f_e39a, 3);  shl(memd[ss, ebp - 4], 1);            /* shl dword [ebp-0x4], 1 */
        l_0x100f_e39d:
            ii(0x100f_e39d, 2);  jmp(0x100f_e378, -0x27); goto l_0x100f_e378;/* jmp 0x100fe378 */
        l_0x100f_e39f:
            ii(0x100f_e39f, 4);  movsx(edx, memw[ss, ebp - 4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x100f_e3a3, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x100f_e3a7, 2);  xor(edx, eax);                        /* xor edx, eax */
            ii(0x100f_e3a9, 3);  mov(memd[ss, ebp - 16], edx);         /* mov [ebp-0x10], edx */
            ii(0x100f_e3ac, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100f_e3af, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100f_e3b1, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100f_e3b2, 1);  pop(edi);                             /* pop edi */
            ii(0x100f_e3b3, 1);  pop(esi);                             /* pop esi */
            ii(0x100f_e3b4, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100f_e3b5, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100f_e3b6, 1);  ret();                                /* ret */
        }
    }
}
