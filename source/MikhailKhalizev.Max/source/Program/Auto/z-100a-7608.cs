using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_7608-d4357604")]
        public void Method_100a_7608()
        {
            ii(0x100a_7608, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100a_760d, 5);  call(Definitions.sys_check_available_stack_size, 0xb_e740);/* call 0x10165d52 */
            ii(0x100a_7612, 1);  push(ebx);                            /* push ebx */
            ii(0x100a_7613, 1);  push(ecx);                            /* push ecx */
            ii(0x100a_7614, 1);  push(esi);                            /* push esi */
            ii(0x100a_7615, 1);  push(edi);                            /* push edi */
            ii(0x100a_7616, 1);  push(ebp);                            /* push ebp */
            ii(0x100a_7617, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100a_7619, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x100a_761f, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100a_7622, 3);  mov(memb[ss, ebp - 4], dl);           /* mov [ebp-0x4], dl */
            ii(0x100a_7625, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_7628, 3);  add(eax, 0x1a);                       /* add eax, 0x1a */
            ii(0x100a_762b, 5);  call(0x1008_af28, -0x1_c708);         /* call 0x1008af28 */
            ii(0x100a_7630, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100a_7633, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100a_7636, 3);  mov(ecx, memd[ds, eax + 2]);          /* mov ecx, [eax+0x2] */
            ii(0x100a_7639, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x100a_763b, 3);  mov(bl, memb[ss, ebp - 4]);           /* mov bl, [ebp-0x4] */
            ii(0x100a_763e, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x100a_7641, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100a_7644, 3);  call_abs(memd[ds, ecx + 108]);        /* call dword [ecx+0x6c] */
            ii(0x100a_7647, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100a_7649, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100a_764a, 1);  pop(edi);                             /* pop edi */
            ii(0x100a_764b, 1);  pop(esi);                             /* pop esi */
            ii(0x100a_764c, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100a_764d, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100a_764e, 1);  ret();                                /* ret */
        }
    }
}
