using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_42dd-29df63bc")]
        public void Method_1016_42dd()
        {
            ii(0x1016_42dd, 5);  push(0x30);                           /* push 0x30 */
            ii(0x1016_42e2, 5);  call(Definitions.sys_check_available_stack_size, 0x1a6b);/* call 0x10165d52 */
            ii(0x1016_42e7, 1);  push(ebx);                            /* push ebx */
            ii(0x1016_42e8, 1);  push(ecx);                            /* push ecx */
            ii(0x1016_42e9, 1);  push(edx);                            /* push edx */
            ii(0x1016_42ea, 1);  push(esi);                            /* push esi */
            ii(0x1016_42eb, 1);  push(edi);                            /* push edi */
            ii(0x1016_42ec, 1);  push(ebp);                            /* push ebp */
            ii(0x1016_42ed, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1016_42ef, 6);  sub(esp, 0x14);                       /* sub esp, 0x14 */
            ii(0x1016_42f5, 5);  mov(eax, 0x16);                       /* mov eax, 0x16 */
            ii(0x1016_42fa, 5);  call(Definitions.sys_new, 0x1b01);    /* call 0x10165e00 */
            ii(0x1016_42ff, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1016_4302, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_4305, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1016_4308, 4);  cmp(memd[ss, ebp - 12], 0);           /* cmp dword [ebp-0xc], 0x0 */
            ii(0x1016_430c, 2);  if(jz(0x1016_4323, 0x15)) goto l_0x1016_4323;/* jz 0x10164323 */
            ii(0x1016_430e, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1016_4310, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_4313, 5);  call(0x1016_3dd9, -0x53f);            /* call 0x10163dd9 */
            ii(0x1016_4318, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1016_431b, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1016_431e, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1016_4321, 2);  jmp(0x1016_4329, 6); goto l_0x1016_4329;/* jmp 0x10164329 */
        l_0x1016_4323:
            ii(0x1016_4323, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1016_4326, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
        l_0x1016_4329:
            ii(0x1016_4329, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_432c, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1016_432f, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1016_4332, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1016_4334, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1016_4335, 1);  pop(edi);                             /* pop edi */
            ii(0x1016_4336, 1);  pop(esi);                             /* pop esi */
            ii(0x1016_4337, 1);  pop(edx);                             /* pop edx */
            ii(0x1016_4338, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1016_4339, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1016_433a, 1);  ret();                                /* ret */
        }
    }
}
