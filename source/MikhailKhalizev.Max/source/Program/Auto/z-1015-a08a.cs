using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_a08a-1c70c028")]
        public void Method_1015_a08a()
        {
            ii(0x1015_a08a, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1015_a08f, 5);  call(Definitions.sys_check_available_stack_size, 0xbcbe);/* call 0x10165d52 */
            ii(0x1015_a094, 1);  push(ebx);                            /* push ebx */
            ii(0x1015_a095, 1);  push(ecx);                            /* push ecx */
            ii(0x1015_a096, 1);  push(esi);                            /* push esi */
            ii(0x1015_a097, 1);  push(edi);                            /* push edi */
            ii(0x1015_a098, 1);  push(ebp);                            /* push ebp */
            ii(0x1015_a099, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1015_a09b, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1015_a0a1, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1015_a0a4, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1015_a0a7, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_a0aa, 4);  cmp(memb[ds, eax + 61], 0xb);         /* cmp byte [eax+0x3d], 0xb */
            ii(0x1015_a0ae, 2);  if(jnz(0x1015_a0cc, 0x1c)) goto l_0x1015_a0cc;/* jnz 0x1015a0cc */
            ii(0x1015_a0b0, 5);  mov(eax, 0x1015_9f08);                /* mov eax, 0x10159f08 */
            ii(0x1015_a0b5, 1);  push(eax);                            /* push eax */
            ii(0x1015_a0b6, 5);  mov(ecx, 0x37);                       /* mov ecx, 0x37 */
            ii(0x1015_a0bb, 5);  mov(ebx, StringDefinitions.Stop9);    /* mov ebx, 0x101b26f6 */
            ii(0x1015_a0c0, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1015_a0c2, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_a0c5, 5);  call(0x1015_7ccf, -0x23fb);           /* call 0x10157ccf */
            ii(0x1015_a0ca, 2);  jmp(0x1015_a0e6, 0x1a); goto l_0x1015_a0e6;/* jmp 0x1015a0e6 */
        l_0x1015_a0cc:
            ii(0x1015_a0cc, 5);  mov(eax, 0x1015_9f08);                /* mov eax, 0x10159f08 */
            ii(0x1015_a0d1, 1);  push(eax);                            /* push eax */
            ii(0x1015_a0d2, 5);  mov(ecx, 0x30);                       /* mov ecx, 0x30 */
            ii(0x1015_a0d7, 5);  mov(ebx, StringDefinitions.Remove3);  /* mov ebx, 0x101b26fb */
            ii(0x1015_a0dc, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1015_a0de, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_a0e1, 5);  call(0x1015_7ccf, -0x2417);           /* call 0x10157ccf */
        l_0x1015_a0e6:
            ii(0x1015_a0e6, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1015_a0e9, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_a0ec, 5);  call(0x1015_8bbb, -0x1536);           /* call 0x10158bbb */
            ii(0x1015_a0f1, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1015_a0f3, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1015_a0f4, 1);  pop(edi);                             /* pop edi */
            ii(0x1015_a0f5, 1);  pop(esi);                             /* pop esi */
            ii(0x1015_a0f6, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1015_a0f7, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1015_a0f8, 1);  ret();                                /* ret */
        }
    }
}
