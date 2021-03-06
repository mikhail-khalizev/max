using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_44d5-f995d20e")]
        public void Method_1013_44d5()
        {
            ii(0x1013_44d5, 5);  push(0x20);                           /* push 0x20 */
            ii(0x1013_44da, 5);  call(Definitions.sys_check_available_stack_size, 0x3_1873);/* call 0x10165d52 */
            ii(0x1013_44df, 1);  push(ebx);                            /* push ebx */
            ii(0x1013_44e0, 1);  push(ecx);                            /* push ecx */
            ii(0x1013_44e1, 1);  push(edx);                            /* push edx */
            ii(0x1013_44e2, 1);  push(esi);                            /* push esi */
            ii(0x1013_44e3, 1);  push(edi);                            /* push edi */
            ii(0x1013_44e4, 1);  push(ebp);                            /* push ebp */
            ii(0x1013_44e5, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1013_44e7, 6);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x1013_44ed, 5);  call(/* sys */ 0x1016_be34, 0x3_7942);/* call 0x1016be34 */
            ii(0x1013_44f2, 7);  mov(memd[ss, ebp - 4], 0);            /* mov dword [ebp-0x4], 0x0 */
            ii(0x1013_44f9, 2);  jmp(0x1013_4501, 6); goto l_0x1013_4501;/* jmp 0x10134501 */
        l_0x1013_44fb:
            ii(0x1013_44fb, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_44fe, 3);  inc(memd[ss, ebp - 4]);               /* inc dword [ebp-0x4] */
        l_0x1013_4501:
            ii(0x1013_4501, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1013_4505, 5);  cmp(eax, 0x38e);                      /* cmp eax, 0x38e */
            ii(0x1013_450a, 2);  if(jge(0x1013_454e, 0x42)) goto l_0x1013_454e;/* jge 0x1013454e */
            ii(0x1013_450c, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1013_4510, 3);  imul(edx, eax, 7);                    /* imul edx, eax, 0x7 */
            ii(0x1013_4513, 5);  mov(eax, memd[ds, Definitions.ptr_arr_meta_by_id]);/* mov eax, [0x101c70ec] */
            ii(0x1013_4518, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1013_451a, 4);  cmp(memd[ds, eax + 2], 0);            /* cmp dword [eax+0x2], 0x0 */
            ii(0x1013_451e, 2);  if(jz(0x1013_454c, 0x2c)) goto l_0x1013_454c;/* jz 0x1013454c */
            ii(0x1013_4520, 4);  movsx(edx, memw[ss, ebp - 4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x1013_4524, 3);  imul(edx, edx, 7);                    /* imul edx, edx, 0x7 */
            ii(0x1013_4527, 5);  mov(eax, memd[ds, Definitions.ptr_arr_meta_by_id]);/* mov eax, [0x101c70ec] */
            ii(0x1013_452c, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1013_452e, 3);  mov(eax, memd[ds, eax + 2]);          /* mov eax, [eax+0x2] */
            ii(0x1013_4531, 5);  call(Definitions.sys_delete, 0x3_1a2e);/* call 0x10165f64 */
            ii(0x1013_4536, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1013_453a, 3);  imul(eax, eax, 7);                    /* imul eax, eax, 0x7 */
            ii(0x1013_453d, 6);  mov(edx, memd[ds, Definitions.ptr_arr_meta_by_id]);/* mov edx, [0x101c70ec] */
            ii(0x1013_4543, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1013_4545, 7);  mov(memd[ds, eax + 2], 0);            /* mov dword [eax+0x2], 0x0 */
        l_0x1013_454c:
            ii(0x1013_454c, 2);  jmp(0x1013_44fb, -0x53); goto l_0x1013_44fb;/* jmp 0x101344fb */
        l_0x1013_454e:
            ii(0x1013_454e, 7);  mov(memd[ss, ebp - 4], 0);            /* mov dword [ebp-0x4], 0x0 */
            ii(0x1013_4555, 2);  jmp(0x1013_455d, 6); goto l_0x1013_455d;/* jmp 0x1013455d */
        l_0x1013_4557:
            ii(0x1013_4557, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_455a, 3);  inc(memd[ss, ebp - 4]);               /* inc dword [ebp-0x4] */
        l_0x1013_455d:
            ii(0x1013_455d, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1013_4561, 3);  cmp(eax, 0x5d);                       /* cmp eax, 0x5d */
            ii(0x1013_4564, 2);  if(jge(0x1013_459b, 0x35)) goto l_0x1013_459b;/* jge 0x1013459b */
            ii(0x1013_4566, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1013_456a, 3);  imul(eax, eax, 0x33);                 /* imul eax, eax, 0x33 */
            ii(0x1013_456d, 10);  mov(memd[ds, eax + 0x101c_81e7], 0); /* mov dword [eax+0x101c81e7], 0x0 */
            ii(0x1013_4577, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1013_457b, 3);  imul(eax, eax, 0x33);                 /* imul eax, eax, 0x33 */
            ii(0x1013_457e, 10);  mov(memd[ds, eax + 0x101c_81eb], 0); /* mov dword [eax+0x101c81eb], 0x0 */
            ii(0x1013_4588, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1013_458c, 3);  imul(eax, eax, 0x33);                 /* imul eax, eax, 0x33 */
            ii(0x1013_458f, 10);  mov(memd[ds, eax + 0x101c_81ef], 0); /* mov dword [eax+0x101c81ef], 0x0 */
            ii(0x1013_4599, 2);  jmp(0x1013_4557, -0x44); goto l_0x1013_4557;/* jmp 0x10134557 */
        l_0x1013_459b:
            ii(0x1013_459b, 10);  mov(memd[ds, 0x101c_70dc], 0);       /* mov dword [0x101c70dc], 0x0 */
            ii(0x1013_45a5, 5);  call(0x1012_124a, -0x1_3360);         /* call 0x1012124a */
            ii(0x1013_45aa, 5);  mov(eax, 1);                          /* mov eax, 0x1 */
            ii(0x1013_45af, 5);  call(0x1012_0d94, -0x1_3820);         /* call 0x10120d94 */
            ii(0x1013_45b4, 5);  call(/* sys */ 0x1016_bcc4, 0x3_770b);/* call 0x1016bcc4 */
            ii(0x1013_45b9, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1013_45bb, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1013_45bc, 1);  pop(edi);                             /* pop edi */
            ii(0x1013_45bd, 1);  pop(esi);                             /* pop esi */
            ii(0x1013_45be, 1);  pop(edx);                             /* pop edx */
            ii(0x1013_45bf, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1013_45c0, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1013_45c1, 1);  ret();                                /* ret */
        }
    }
}
