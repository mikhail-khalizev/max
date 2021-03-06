using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_a48e-ab2b994f")]
        public void Method_1014_a48e()
        {
            ii(0x1014_a48e, 5);  push(0x20);                           /* push 0x20 */
            ii(0x1014_a493, 5);  call(Definitions.sys_check_available_stack_size, 0x1_b8ba);/* call 0x10165d52 */
            ii(0x1014_a498, 1);  push(esi);                            /* push esi */
            ii(0x1014_a499, 1);  push(edi);                            /* push edi */
            ii(0x1014_a49a, 1);  push(ebp);                            /* push ebp */
            ii(0x1014_a49b, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1014_a49d, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x1014_a4a3, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1014_a4a6, 3);  mov(memd[ss, ebp - 12], edx);         /* mov [ebp-0xc], edx */
            ii(0x1014_a4a9, 3);  mov(memd[ss, ebp - 8], ebx);          /* mov [ebp-0x8], ebx */
            ii(0x1014_a4ac, 3);  mov(memb[ss, ebp - 4], cl);           /* mov [ebp-0x4], cl */
            ii(0x1014_a4af, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1014_a4b2, 3);  shl(edx, 6);                          /* shl edx, 0x6 */
            ii(0x1014_a4b5, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_a4b8, 3);  add(edx, 0x20);                       /* add edx, 0x20 */
            ii(0x1014_a4bb, 4);  mov(memw[ds, eax + 22], dx);          /* mov [eax+0x16], dx */
            ii(0x1014_a4bf, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1014_a4c2, 3);  shl(edx, 6);                          /* shl edx, 0x6 */
            ii(0x1014_a4c5, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_a4c8, 3);  add(edx, 0x20);                       /* add edx, 0x20 */
            ii(0x1014_a4cb, 4);  mov(memw[ds, eax + 24], dx);          /* mov [eax+0x18], dx */
            ii(0x1014_a4cf, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_a4d2, 3);  mov(eax, memd[ds, eax + 20]);         /* mov eax, [eax+0x14] */
            ii(0x1014_a4d5, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1014_a4d8, 3);  sar(eax, 6);                          /* sar eax, 0x6 */
            ii(0x1014_a4db, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1014_a4dd, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_a4e0, 4);  mov(memw[ds, eax + 26], dx);          /* mov [eax+0x1a], dx */
            ii(0x1014_a4e4, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_a4e7, 3);  mov(eax, memd[ds, eax + 22]);         /* mov eax, [eax+0x16] */
            ii(0x1014_a4ea, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1014_a4ed, 3);  sar(eax, 6);                          /* sar eax, 0x6 */
            ii(0x1014_a4f0, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1014_a4f2, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_a4f5, 4);  mov(memw[ds, eax + 28], dx);          /* mov [eax+0x1c], dx */
            ii(0x1014_a4f9, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_a4fc, 4);  test(memb[ds, eax + 18], 0x10);       /* test byte [eax+0x12], 0x10 */
            ii(0x1014_a500, 2);  if(jz(0x1014_a512, 0x10)) goto l_0x1014_a512;/* jz 0x1014a512 */
            ii(0x1014_a502, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_a505, 5);  add(memw[ds, eax + 22], 0x1f);        /* add word [eax+0x16], 0x1f */
            ii(0x1014_a50a, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_a50d, 5);  add(memw[ds, eax + 24], 0x1f);        /* add word [eax+0x18], 0x1f */
        l_0x1014_a512:
            ii(0x1014_a512, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_a515, 5);  call(0x1014_9cd1, -0x849);            /* call 0x10149cd1 */
            ii(0x1014_a51a, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_a51d, 5);  call(0x1014_9fa8, -0x57a);            /* call 0x10149fa8 */
            ii(0x1014_a522, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_a525, 3);  mov(al, memb[ds, eax + 18]);          /* mov al, [eax+0x12] */
            ii(0x1014_a528, 2);  and(al, 1);                           /* and al, 0x1 */
            ii(0x1014_a52a, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x1014_a52c, 2);  mov(bl, al);                          /* mov bl, al */
            ii(0x1014_a52e, 3);  mov(edx, memd[ss, ebp - 16]);         /* mov edx, [ebp-0x10] */
            ii(0x1014_a531, 5);  mov(eax, 0x101c_39b8);                /* mov eax, 0x101c39b8 */
            ii(0x1014_a536, 5);  call(0x1010_346f, -0x4_70cc);         /* call 0x1010346f */
            ii(0x1014_a53b, 4);  cmp(memb[ss, ebp - 4], 0);            /* cmp byte [ebp-0x4], 0x0 */
            ii(0x1014_a53f, 2);  if(jnz(0x1014_a56b, 0x2a)) goto l_0x1014_a56b;/* jnz 0x1014a56b */
            ii(0x1014_a541, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_a544, 5);  call(0x1007_6154, -0xd_43f5);         /* call 0x10076154 */
            ii(0x1014_a549, 5);  and(eax, 0xffff);                     /* and eax, 0xffff */
            ii(0x1014_a54e, 5);  cmp(eax, 0xffff);                     /* cmp eax, 0xffff */
            ii(0x1014_a553, 2);  if(jnz(0x1014_a55e, 9)) goto l_0x1014_a55e;/* jnz 0x1014a55e */
            ii(0x1014_a555, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_a558, 4);  test(memb[ds, eax + 18], 0x22);       /* test byte [eax+0x12], 0x22 */
            ii(0x1014_a55c, 2);  if(jz(0x1014_a56b, 0xd)) goto l_0x1014_a56b;/* jz 0x1014a56b */
        l_0x1014_a55e:
            ii(0x1014_a55e, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x1014_a563, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_a566, 5);  call(0x1007_1838, -0xd_8d33);         /* call 0x10071838 */
        l_0x1014_a56b:
            ii(0x1014_a56b, 5);  call(0x1015_50bc, 0xab4c);            /* call 0x101550bc */
            ii(0x1014_a570, 3);  mov(ebx, memd[ss, ebp - 16]);         /* mov ebx, [ebp-0x10] */
            ii(0x1014_a573, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1014_a575, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x1014_a577, 5);  call(0x1014_a205, -0x377);            /* call 0x1014a205 */
            ii(0x1014_a57c, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1014_a57e, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1014_a57f, 1);  pop(edi);                             /* pop edi */
            ii(0x1014_a580, 1);  pop(esi);                             /* pop esi */
            ii(0x1014_a581, 1);  ret();                                /* ret */
        }
    }
}
