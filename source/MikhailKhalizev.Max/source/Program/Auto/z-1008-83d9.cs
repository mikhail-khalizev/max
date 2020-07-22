using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_83d9-cfc100f4")]
        public void Method_1008_83d9()
        {
            ii(0x1008_83d9, 5);  push(0x28);                           /* push 0x28 */
            ii(0x1008_83de, 5);  call(Definitions.sys_check_available_stack_size, 0xd_d96f);/* call 0x10165d52 */
            ii(0x1008_83e3, 1);  push(ebx);                            /* push ebx */
            ii(0x1008_83e4, 1);  push(ecx);                            /* push ecx */
            ii(0x1008_83e5, 1);  push(esi);                            /* push esi */
            ii(0x1008_83e6, 1);  push(edi);                            /* push edi */
            ii(0x1008_83e7, 1);  push(ebp);                            /* push ebp */
            ii(0x1008_83e8, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1008_83ea, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x1008_83f0, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1008_83f3, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1008_83f6, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1008_83f8, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_83fb, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x1008_83fe, 5);  call(0x1013_ad11, 0xb_290e);          /* call 0x1013ad11 */
            ii(0x1008_8403, 2);  test(al, al);                         /* test al, al */
            ii(0x1008_8405, 2);  if(jz(0x1008_8410, 9)) goto l_0x1008_8410;/* jz 0x10088410 */
            ii(0x1008_8407, 4);  mov(memb[ss, ebp - 12], 0);           /* mov byte [ebp-0xc], 0x0 */
            ii(0x1008_840b, 5);  jmp(0x1008_84c3, 0xb3); goto l_0x1008_84c3;/* jmp 0x100884c3 */
        l_0x1008_8410:
            ii(0x1008_8410, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_8413, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x1008_8416, 5);  call(0x1007_6574, -0x1_1ea7);         /* call 0x10076574 */
            ii(0x1008_841b, 3);  mov(al, memb[ds, eax + 77]);          /* mov al, [eax+0x4d] */
            ii(0x1008_841e, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1008_8423, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1008_8425, 2);  if(jg(0x1008_8442, 0x1b)) goto l_0x1008_8442;/* jg 0x10088442 */
            ii(0x1008_8427, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_842a, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1008_842d, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1008_8430, 3);  mov(edx, memd[ds, eax + 2]);          /* mov edx, [eax+0x2] */
            ii(0x1008_8433, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1008_8436, 3);  call_abs(memd[ds, edx + 72]);         /* call dword [edx+0x48] */
            ii(0x1008_8439, 4);  mov(memb[ss, ebp - 12], 0);           /* mov byte [ebp-0xc], 0x0 */
            ii(0x1008_843d, 5);  jmp(0x1008_84c3, 0x81); goto l_0x1008_84c3;/* jmp 0x100884c3 */
        l_0x1008_8442:
            ii(0x1008_8442, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1008_8445, 3);  add(edx, 0x17);                       /* add edx, 0x17 */
            ii(0x1008_8448, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_844b, 5);  call(0x1008_b4b4, 0x3064);            /* call 0x1008b4b4 */
            ii(0x1008_8450, 2);  test(al, al);                         /* test al, al */
            ii(0x1008_8452, 2);  if(jz(0x1008_845d, 9)) goto l_0x1008_845d;/* jz 0x1008845d */
            ii(0x1008_8454, 4);  mov(memb[ss, ebp - 12], 0);           /* mov byte [ebp-0xc], 0x0 */
            ii(0x1008_8458, 5);  jmp(0x1008_84c3, 0x66); goto l_0x1008_84c3;/* jmp 0x100884c3 */
        l_0x1008_845d:
            ii(0x1008_845d, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_8460, 3);  mov(al, memb[ds, eax + 78]);          /* mov al, [eax+0x4e] */
            ii(0x1008_8463, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1008_8468, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1008_846a, 2);  if(jz(0x1008_847b, 0xf)) goto l_0x1008_847b;/* jz 0x1008847b */
            ii(0x1008_846c, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1008_846f, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_8472, 5);  call(0x1015_2a52, 0xc_a5db);          /* call 0x10152a52 */
            ii(0x1008_8477, 2);  test(al, al);                         /* test al, al */
            ii(0x1008_8479, 2);  if(jnz(0x1008_8481, 6)) goto l_0x1008_8481;/* jnz 0x10088481 */
        l_0x1008_847b:
            ii(0x1008_847b, 4);  mov(memb[ss, ebp - 12], 0);           /* mov byte [ebp-0xc], 0x0 */
            ii(0x1008_847f, 2);  jmp(0x1008_84c3, 0x42); goto l_0x1008_84c3;/* jmp 0x100884c3 */
        l_0x1008_8481:
            ii(0x1008_8481, 5);  mov(ebx, 2);                          /* mov ebx, 0x2 */
            ii(0x1008_8486, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1008_8489, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_848c, 5);  call(0x100a_3671, 0x1_b1e0);          /* call 0x100a3671 */
            ii(0x1008_8491, 2);  test(al, al);                         /* test al, al */
            ii(0x1008_8493, 2);  if(jz(0x1008_849b, 6)) goto l_0x1008_849b;/* jz 0x1008849b */
            ii(0x1008_8495, 4);  mov(memb[ss, ebp - 12], 1);           /* mov byte [ebp-0xc], 0x1 */
            ii(0x1008_8499, 2);  jmp(0x1008_84c3, 0x28); goto l_0x1008_84c3;/* jmp 0x100884c3 */
        l_0x1008_849b:
            ii(0x1008_849b, 5);  mov(ebx, 0x1008_8379);                /* mov ebx, 0x10088379 */
            ii(0x1008_84a0, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1008_84a3, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_84a6, 5);  call(0x1007_8d4a, -0xf761);           /* call 0x10078d4a */
            ii(0x1008_84ab, 2);  test(al, al);                         /* test al, al */
            ii(0x1008_84ad, 2);  if(jz(0x1008_84b5, 6)) goto l_0x1008_84b5;/* jz 0x100884b5 */
            ii(0x1008_84af, 4);  mov(memb[ss, ebp - 12], 1);           /* mov byte [ebp-0xc], 0x1 */
            ii(0x1008_84b3, 2);  jmp(0x1008_84c3, 0xe); goto l_0x1008_84c3;/* jmp 0x100884c3 */
        l_0x1008_84b5:
            ii(0x1008_84b5, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1008_84b8, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_84bb, 5);  call(0x1008_84ce, 0xe);               /* call 0x100884ce */
            ii(0x1008_84c0, 3);  mov(memb[ss, ebp - 12], al);          /* mov [ebp-0xc], al */
        l_0x1008_84c3:
            ii(0x1008_84c3, 3);  mov(al, memb[ss, ebp - 12]);          /* mov al, [ebp-0xc] */
            ii(0x1008_84c6, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1008_84c8, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1008_84c9, 1);  pop(edi);                             /* pop edi */
            ii(0x1008_84ca, 1);  pop(esi);                             /* pop esi */
            ii(0x1008_84cb, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1008_84cc, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1008_84cd, 1);  ret();                                /* ret */
        }
    }
}
