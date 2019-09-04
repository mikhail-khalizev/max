using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_51c9-b90e7c0")]
        public void Method_1014_51c9()
        {
            ii(0x1014_51c9, 5);  push(0x30);                           /* push 0x30 */
            ii(0x1014_51ce, 5);  call(Definitions.sys_check_available_stack_size, 0x2_0b7f);/* call 0x10165d52 */
            ii(0x1014_51d3, 1);  push(ebx);                            /* push ebx */
            ii(0x1014_51d4, 1);  push(ecx);                            /* push ecx */
            ii(0x1014_51d5, 1);  push(esi);                            /* push esi */
            ii(0x1014_51d6, 1);  push(edi);                            /* push edi */
            ii(0x1014_51d7, 1);  push(ebp);                            /* push ebp */
            ii(0x1014_51d8, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1014_51da, 6);  sub(esp, 0x14);                       /* sub esp, 0x14 */
            ii(0x1014_51e0, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1014_51e3, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1014_51e6, 1);  int3();                               /* int3 */
            ii(0x1014_51e7, 5);  call(0x100c_aa00, -0x7_a7ec);         /* call 0x100caa00 */
            ii(0x1014_51ec, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1014_51f1, 1);  push(eax);                            /* push eax */
            ii(0x1014_51f2, 5);  call(0x100c_aa20, -0x7_a7d7);         /* call 0x100caa20 */
            ii(0x1014_51f7, 2);  mov(esi, eax);                        /* mov esi, eax */
            ii(0x1014_51f9, 5);  mov(edi, 1);                          /* mov edi, 0x1 */
            ii(0x1014_51fe, 7);  mov(memd[ss, ebp - 16], 2);           /* mov dword [ebp-0x10], 0x2 */
            ii(0x1014_5205, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_5208, 3);  mov(eax, memd[ds, eax + 16]);         /* mov eax, [eax+0x10] */
            ii(0x1014_520b, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1014_520e, 1);  push(eax);                            /* push eax */
            ii(0x1014_520f, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_5212, 3);  mov(ecx, memd[ds, eax + 14]);         /* mov ecx, [eax+0xe] */
            ii(0x1014_5215, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_5218, 3);  add(eax, 0xa);                        /* add eax, 0xa */
            ii(0x1014_521b, 5);  call(Definitions.my_strobj_c_str_v2, -0xb_ba58);/* call 0x100897c8 */
            ii(0x1014_5220, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1014_5223, 3);  lea(ebx, memd[ss, ebp - 12]);         /* lea ebx, [ebp-0xc] */
            ii(0x1014_5226, 3);  mov(memd[ss, ebp - 20], ebx);         /* mov [ebp-0x14], ebx */
            ii(0x1014_5229, 2);  mov(ebx, eax);                        /* mov ebx, eax */
            ii(0x1014_522b, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1014_522e, 5);  call(0x1014_5056, -0x1dd);            /* call 0x10145056 */
            ii(0x1014_5233, 5);  call(Definitions.my_strobj_c_str_v2, -0xb_ba70);/* call 0x100897c8 */
            ii(0x1014_5238, 2);  mov(ecx, esi);                        /* mov ecx, esi */
            ii(0x1014_523a, 2);  mov(ebx, edi);                        /* mov ebx, edi */
            ii(0x1014_523c, 3);  mov(edx, memd[ss, ebp - 16]);         /* mov edx, [ebp-0x10] */
            ii(0x1014_523f, 5);  call(0x1011_5d23, -0x2_f521);         /* call 0x10115d23 */
            ii(0x1014_5244, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1014_5246, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x1014_5249, 5);  call(Definitions.my_string_dtor, -0x3724);/* call 0x10141b2a */
            ii(0x1014_524e, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1014_5250, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1014_5251, 1);  pop(edi);                             /* pop edi */
            ii(0x1014_5252, 1);  pop(esi);                             /* pop esi */
            ii(0x1014_5253, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1014_5254, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1014_5255, 1);  ret();                                /* ret */
        }
    }
}
