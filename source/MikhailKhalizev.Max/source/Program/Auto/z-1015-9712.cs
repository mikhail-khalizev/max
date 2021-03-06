using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_9712-e8d27ac6")]
        public void Method_1015_9712()
        {
            ii(0x1015_9712, 5);  push(0x1c4);                          /* push 0x1c4 */
            ii(0x1015_9717, 5);  call(Definitions.sys_check_available_stack_size, 0xc636);/* call 0x10165d52 */
            ii(0x1015_971c, 1);  push(ebx);                            /* push ebx */
            ii(0x1015_971d, 1);  push(ecx);                            /* push ecx */
            ii(0x1015_971e, 1);  push(esi);                            /* push esi */
            ii(0x1015_971f, 1);  push(edi);                            /* push edi */
            ii(0x1015_9720, 1);  push(ebp);                            /* push ebp */
            ii(0x1015_9721, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1015_9723, 6);  sub(esp, 0x19c);                      /* sub esp, 0x19c */
            ii(0x1015_9729, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1015_972c, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1015_972f, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_9732, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1015_9735, 5);  mov(eax, 1);                          /* mov eax, 0x1 */
            ii(0x1015_973a, 5);  call(0x100f_448c, -0x6_52b3);         /* call 0x100f448c */
            ii(0x1015_973f, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x1015_9741, 5);  mov(edx, 8);                          /* mov edx, 0x8 */
            ii(0x1015_9746, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1015_9749, 5);  call(0x1016_3053, 0x9905);            /* call 0x10163053 */
            ii(0x1015_974e, 5);  mov(eax, StringDefinitions.Off);      /* mov eax, 0x101b261e */
            ii(0x1015_9753, 1);  push(eax);                            /* push eax */
            ii(0x1015_9754, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1015_9757, 3);  mov(eax, memd[ds, eax + 6]);          /* mov eax, [eax+0x6] */
            ii(0x1015_975a, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1015_975d, 3);  imul(eax, eax, 0x33);                 /* imul eax, eax, 0x33 */
            ii(0x1015_9760, 6);  push(memd[ds, eax + 0x101c_81d7]);    /* push dword [eax+0x101c81d7] */
            ii(0x1015_9766, 5);  mov(eax, StringDefinitions.SPoweredS2);/* mov eax, 0x101b2622 */
            ii(0x1015_976b, 1);  push(eax);                            /* push eax */
            ii(0x1015_976c, 6);  lea(eax, memd[ss, ebp - 412]);        /* lea eax, [ebp-0x19c] */
            ii(0x1015_9772, 1);  push(eax);                            /* push eax */
            ii(0x1015_9773, 5);  call(Definitions.sys_sprintf, 0xc789);/* call 0x10165f01 */
            ii(0x1015_9778, 3);  add(esp, 0x10);                       /* add esp, 0x10 */
            ii(0x1015_977b, 5);  call(0x100c_aa00, -0x8_ed80);         /* call 0x100caa00 */
            ii(0x1015_9780, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1015_9785, 1);  push(eax);                            /* push eax */
            ii(0x1015_9786, 5);  call(0x100c_aa20, -0x8_ed6b);         /* call 0x100caa20 */
            ii(0x1015_978b, 2);  mov(ecx, eax);                        /* mov ecx, eax */
            ii(0x1015_978d, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x1015_978f, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1015_9791, 6);  lea(eax, memd[ss, ebp - 412]);        /* lea eax, [ebp-0x19c] */
            ii(0x1015_9797, 5);  call(0x1011_5d23, -0x4_3a79);         /* call 0x10115d23 */
            ii(0x1015_979c, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1015_979e, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1015_979f, 1);  pop(edi);                             /* pop edi */
            ii(0x1015_97a0, 1);  pop(esi);                             /* pop esi */
            ii(0x1015_97a1, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1015_97a2, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1015_97a3, 1);  ret();                                /* ret */
        }
    }
}
