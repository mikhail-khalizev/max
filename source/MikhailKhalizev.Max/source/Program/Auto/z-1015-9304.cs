using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_9304-ec308a81")]
        public void Method_1015_9304()
        {
            ii(0x1015_9304, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1015_9309, 5);  call(Definitions.sys_check_available_stack_size, 0xca44);/* call 0x10165d52 */
            ii(0x1015_930e, 1);  push(ebx);                            /* push ebx */
            ii(0x1015_930f, 1);  push(ecx);                            /* push ecx */
            ii(0x1015_9310, 1);  push(esi);                            /* push esi */
            ii(0x1015_9311, 1);  push(edi);                            /* push edi */
            ii(0x1015_9312, 1);  push(ebp);                            /* push ebp */
            ii(0x1015_9313, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1015_9315, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1015_931b, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1015_931e, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1015_9321, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_9324, 4);  cmp(memb[ds, eax + 61], 4);           /* cmp byte [eax+0x3d], 0x4 */
            ii(0x1015_9328, 2);  if(jnz(0x1015_9333, 9)) goto l_0x1015_9333;/* jnz 0x10159333 */
            ii(0x1015_932a, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_932d, 4);  cmp(memb[ds, eax + 62], 0xd);         /* cmp byte [eax+0x3e], 0xd */
            ii(0x1015_9331, 2);  if(jnz(0x1015_9335, 2)) goto l_0x1015_9335;/* jnz 0x10159335 */
        l_0x1015_9333:
            ii(0x1015_9333, 2);  jmp(0x1015_9343, 0xe); goto l_0x1015_9343;/* jmp 0x10159343 */
        l_0x1015_9335:
            ii(0x1015_9335, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_9338, 3);  mov(eax, memd[ds, eax + 58]);         /* mov eax, [eax+0x3a] */
            ii(0x1015_933b, 3);  sar(eax, 0x18);                       /* sar eax, 0x18 */
            ii(0x1015_933e, 3);  cmp(eax, 0x2e);                       /* cmp eax, 0x2e */
            ii(0x1015_9341, 2);  if(jnz(0x1015_9345, 2)) goto l_0x1015_9345;/* jnz 0x10159345 */
        l_0x1015_9343:
            ii(0x1015_9343, 2);  jmp(0x1015_9361, 0x1c); goto l_0x1015_9361;/* jmp 0x10159361 */
        l_0x1015_9345:
            ii(0x1015_9345, 5);  mov(eax, 0x1015_9291);                /* mov eax, 0x10159291 */
            ii(0x1015_934a, 1);  push(eax);                            /* push eax */
            ii(0x1015_934b, 5);  mov(ecx, 0x37);                       /* mov ecx, 0x37 */
            ii(0x1015_9350, 5);  mov(ebx, StringDefinitions.Stop2);    /* mov ebx, 0x101b25a6 */
            ii(0x1015_9355, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1015_9357, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_935a, 5);  call(0x1015_7ccf, -0x1690);           /* call 0x10157ccf */
            ii(0x1015_935f, 2);  jmp(0x1015_937b, 0x1a); goto l_0x1015_937b;/* jmp 0x1015937b */
        l_0x1015_9361:
            ii(0x1015_9361, 5);  mov(eax, 0x1015_9291);                /* mov eax, 0x10159291 */
            ii(0x1015_9366, 1);  push(eax);                            /* push eax */
            ii(0x1015_9367, 5);  mov(ecx, 0x31);                       /* mov ecx, 0x31 */
            ii(0x1015_936c, 5);  mov(ebx, StringDefinitions.Build2);   /* mov ebx, 0x101b25ab */
            ii(0x1015_9371, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1015_9373, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_9376, 5);  call(0x1015_7ccf, -0x16ac);           /* call 0x10157ccf */
        l_0x1015_937b:
            ii(0x1015_937b, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1015_937e, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_9381, 5);  call(0x1015_8bbb, -0x7cb);            /* call 0x10158bbb */
            ii(0x1015_9386, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1015_9388, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1015_9389, 1);  pop(edi);                             /* pop edi */
            ii(0x1015_938a, 1);  pop(esi);                             /* pop esi */
            ii(0x1015_938b, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1015_938c, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1015_938d, 1);  ret();                                /* ret */
        }
    }
}
