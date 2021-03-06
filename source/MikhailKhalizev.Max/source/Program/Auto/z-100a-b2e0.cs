using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_b2e0-effba50c")]
        public void Method_100a_b2e0()
        {
            ii(0x100a_b2e0, 5);  push(0x28);                           /* push 0x28 */
            ii(0x100a_b2e5, 5);  call(Definitions.sys_check_available_stack_size, 0xb_aa68);/* call 0x10165d52 */
            ii(0x100a_b2ea, 1);  push(ebx);                            /* push ebx */
            ii(0x100a_b2eb, 1);  push(ecx);                            /* push ecx */
            ii(0x100a_b2ec, 1);  push(edx);                            /* push edx */
            ii(0x100a_b2ed, 1);  push(esi);                            /* push esi */
            ii(0x100a_b2ee, 1);  push(edi);                            /* push edi */
            ii(0x100a_b2ef, 1);  push(ebp);                            /* push ebp */
            ii(0x100a_b2f0, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100a_b2f2, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x100a_b2f8, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100a_b2fb, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_b2fe, 3);  cmp(memd[ds, eax], 0);                /* cmp dword [eax], 0x0 */
            ii(0x100a_b301, 2);  if(jz(0x100a_b30c, 9)) goto l_0x100a_b30c;/* jz 0x100ab30c */
            ii(0x100a_b303, 7);  mov(memd[ss, ebp - 8], 0);            /* mov dword [ebp-0x8], 0x0 */
            ii(0x100a_b30a, 2);  jmp(0x100a_b325, 0x19); goto l_0x100a_b325;/* jmp 0x100ab325 */
        l_0x100a_b30c:
            ii(0x100a_b30c, 5);  mov(ecx, 0xae);                       /* mov ecx, 0xae */
            ii(0x100a_b311, 5);  mov(ebx, StringDefinitions.SmartptrH10);/* mov ebx, 0x101a07ec */
            ii(0x100a_b316, 5);  mov(edx, StringDefinitions.PtrNotEqual010);/* mov edx, 0x101a07f7 */
            ii(0x100a_b31b, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x100a_b31d, 5);  call(Definitions.sys_assert, 0xb_aa70);/* call 0x10165d92 */
            ii(0x100a_b322, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
        l_0x100a_b325:
            ii(0x100a_b325, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_b328, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x100a_b32a, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100a_b32d, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100a_b330, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100a_b332, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100a_b333, 1);  pop(edi);                             /* pop edi */
            ii(0x100a_b334, 1);  pop(esi);                             /* pop esi */
            ii(0x100a_b335, 1);  pop(edx);                             /* pop edx */
            ii(0x100a_b336, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100a_b337, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100a_b338, 1);  ret();                                /* ret */
        }
    }
}
