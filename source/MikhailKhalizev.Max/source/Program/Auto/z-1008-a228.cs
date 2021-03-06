using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_a228-91a18dec")]
        public void Method_1008_a228()
        {
            ii(0x1008_a228, 5);  push(0x28);                           /* push 0x28 */
            ii(0x1008_a22d, 5);  call(Definitions.sys_check_available_stack_size, 0xd_bb20);/* call 0x10165d52 */
            ii(0x1008_a232, 1);  push(ebx);                            /* push ebx */
            ii(0x1008_a233, 1);  push(ecx);                            /* push ecx */
            ii(0x1008_a234, 1);  push(edx);                            /* push edx */
            ii(0x1008_a235, 1);  push(esi);                            /* push esi */
            ii(0x1008_a236, 1);  push(edi);                            /* push edi */
            ii(0x1008_a237, 1);  push(ebp);                            /* push ebp */
            ii(0x1008_a238, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1008_a23a, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1008_a240, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1008_a243, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_a246, 3);  cmp(memd[ds, eax], 0);                /* cmp dword [eax], 0x0 */
            ii(0x1008_a249, 2);  if(jz(0x1008_a254, 9)) goto l_0x1008_a254;/* jz 0x1008a254 */
            ii(0x1008_a24b, 7);  mov(memd[ss, ebp - 8], 0);            /* mov dword [ebp-0x8], 0x0 */
            ii(0x1008_a252, 2);  jmp(0x1008_a26d, 0x19); goto l_0x1008_a26d;/* jmp 0x1008a26d */
        l_0x1008_a254:
            ii(0x1008_a254, 5);  mov(ecx, 0xae);                       /* mov ecx, 0xae */
            ii(0x1008_a259, 5);  mov(ebx, StringDefinitions.SmartptrH6);/* mov ebx, 0x101a00e4 */
            ii(0x1008_a25e, 5);  mov(edx, StringDefinitions.PtrNotEqual06);/* mov edx, 0x101a00ef */
            ii(0x1008_a263, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1008_a265, 5);  call(Definitions.sys_assert, 0xd_bb28);/* call 0x10165d92 */
            ii(0x1008_a26a, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
        l_0x1008_a26d:
            ii(0x1008_a26d, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_a270, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1008_a272, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1008_a275, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1008_a278, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1008_a27a, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1008_a27b, 1);  pop(edi);                             /* pop edi */
            ii(0x1008_a27c, 1);  pop(esi);                             /* pop esi */
            ii(0x1008_a27d, 1);  pop(edx);                             /* pop edx */
            ii(0x1008_a27e, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1008_a27f, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1008_a280, 1);  ret();                                /* ret */
        }
    }
}
