using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_9970-70b8d1ec")]
        public void Method_1008_9970()
        {
            ii(0x1008_9970, 5);  push(0x28);                           /* push 0x28 */
            ii(0x1008_9975, 5);  call(Definitions.sys_check_available_stack_size, 0xd_c3d8);/* call 0x10165d52 */
            ii(0x1008_997a, 1);  push(ebx);                            /* push ebx */
            ii(0x1008_997b, 1);  push(ecx);                            /* push ecx */
            ii(0x1008_997c, 1);  push(edx);                            /* push edx */
            ii(0x1008_997d, 1);  push(esi);                            /* push esi */
            ii(0x1008_997e, 1);  push(edi);                            /* push edi */
            ii(0x1008_997f, 1);  push(ebp);                            /* push ebp */
            ii(0x1008_9980, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1008_9982, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1008_9988, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1008_998b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_998e, 3);  cmp(memd[ds, eax], 0);                /* cmp dword [eax], 0x0 */
            ii(0x1008_9991, 2);  if(jz(0x1008_999c, 9)) goto l_0x1008_999c;/* jz 0x1008999c */
            ii(0x1008_9993, 7);  mov(memd[ss, ebp - 8], 0);            /* mov dword [ebp-0x8], 0x0 */
            ii(0x1008_999a, 2);  jmp(0x1008_99b5, 0x19); goto l_0x1008_99b5;/* jmp 0x100899b5 */
        l_0x1008_999c:
            ii(0x1008_999c, 5);  mov(ecx, 0xae);                       /* mov ecx, 0xae */
            ii(0x1008_99a1, 5);  mov(ebx, StringDefinitions.SmartptrH18);/* mov ebx, 0x101a010c */
            ii(0x1008_99a6, 5);  mov(edx, StringDefinitions.PtrNotEqual020);/* mov edx, 0x101a0117 */
            ii(0x1008_99ab, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1008_99ad, 5);  call(Definitions.sys_assert, 0xd_c3e0);/* call 0x10165d92 */
            ii(0x1008_99b2, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
        l_0x1008_99b5:
            ii(0x1008_99b5, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_99b8, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1008_99ba, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1008_99bd, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1008_99c0, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1008_99c2, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1008_99c3, 1);  pop(edi);                             /* pop edi */
            ii(0x1008_99c4, 1);  pop(esi);                             /* pop esi */
            ii(0x1008_99c5, 1);  pop(edx);                             /* pop edx */
            ii(0x1008_99c6, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1008_99c7, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1008_99c8, 1);  ret();                                /* ret */
        }
    }
}
