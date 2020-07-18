using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_3879-652702d9")]
        public void Method_100a_3879()
        {
            ii(0x100a_3879, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100a_387e, 5);  call(Definitions.sys_check_available_stack_size, 0xc_24cf);/* call 0x10165d52 */
            ii(0x100a_3883, 1);  push(ebx);                            /* push ebx */
            ii(0x100a_3884, 1);  push(ecx);                            /* push ecx */
            ii(0x100a_3885, 1);  push(edx);                            /* push edx */
            ii(0x100a_3886, 1);  push(esi);                            /* push esi */
            ii(0x100a_3887, 1);  push(edi);                            /* push edi */
            ii(0x100a_3888, 1);  push(ebp);                            /* push ebp */
            ii(0x100a_3889, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100a_388b, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x100a_3891, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100a_3894, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100a_3896, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_3899, 3);  add(eax, 6);                          /* add eax, 0x6 */
            ii(0x100a_389c, 5);  call(0x1008_af28, -0x1_8979);         /* call 0x1008af28 */
            ii(0x100a_38a1, 5);  call(0x100a_b198, 0x78f2);            /* call 0x100ab198 */
            ii(0x100a_38a6, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_38a9, 3);  add(eax, 6);                          /* add eax, 0x6 */
            ii(0x100a_38ac, 5);  call(0x1008_af28, -0x1_8989);         /* call 0x1008af28 */
            ii(0x100a_38b1, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100a_38b4, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_38b7, 3);  mov(edx, memd[ds, eax + 2]);          /* mov edx, [eax+0x2] */
            ii(0x100a_38ba, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_38bd, 3);  call_abs(memd[ds, edx + 52]);         /* call dword [edx+0x34] */
            ii(0x100a_38c0, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100a_38c2, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100a_38c3, 1);  pop(edi);                             /* pop edi */
            ii(0x100a_38c4, 1);  pop(esi);                             /* pop esi */
            ii(0x100a_38c5, 1);  pop(edx);                             /* pop edx */
            ii(0x100a_38c6, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100a_38c7, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100a_38c8, 1);  ret();                                /* ret */
        }
    }
}
