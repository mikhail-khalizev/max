using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_18c2-3912aee9")]
        public void Method_1016_18c2()
        {
            ii(0x1016_18c2, 5);  push(0x20);                           /* push 0x20 */
            ii(0x1016_18c7, 5);  call(Definitions.sys_check_available_stack_size, 0x4486);/* call 0x10165d52 */
            ii(0x1016_18cc, 1);  push(ebx);                            /* push ebx */
            ii(0x1016_18cd, 1);  push(ecx);                            /* push ecx */
            ii(0x1016_18ce, 1);  push(edx);                            /* push edx */
            ii(0x1016_18cf, 1);  push(esi);                            /* push esi */
            ii(0x1016_18d0, 1);  push(edi);                            /* push edi */
            ii(0x1016_18d1, 1);  push(ebp);                            /* push ebp */
            ii(0x1016_18d2, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1016_18d4, 6);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x1016_18da, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1016_18dd, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_18e0, 4);  cmp(memb[ds, eax + 92], 0);           /* cmp byte [eax+0x5c], 0x0 */
            ii(0x1016_18e4, 2);  if(jz(0x1016_18f5, 0xf)) goto l_0x1016_18f5;/* jz 0x101618f5 */
            ii(0x1016_18e6, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_18e9, 3);  mov(al, memb[ds, eax + 78]);          /* mov al, [eax+0x4e] */
            ii(0x1016_18ec, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1016_18f1, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1016_18f3, 2);  if(jnz(0x1016_18fa, 5)) goto l_0x1016_18fa;/* jnz 0x101618fa */
        l_0x1016_18f5:
            ii(0x1016_18f5, 5);  jmp(0x1016_19c3, 0xc9); goto l_0x1016_19c3;/* jmp 0x101619c3 */
        l_0x1016_18fa:
            ii(0x1016_18fa, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1016_18fc, 5);  mov(al, memb[ds, 0x101c_37c9]);       /* mov al, [0x101c37c9] */
            ii(0x1016_1901, 3);  cmp(eax, 2);                          /* cmp eax, 0x2 */
            ii(0x1016_1904, 6);  if(jz(0x1016_19c3, 0xb9)) goto l_0x1016_19c3;/* jz 0x101619c3 */
            ii(0x1016_190a, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1016_190c, 5);  mov(al, memb[ds, 0x101c_37c9]);       /* mov al, [0x101c37c9] */
            ii(0x1016_1911, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1016_1913, 2);  if(jnz(0x1016_192c, 0x17)) goto l_0x1016_192c;/* jnz 0x1016192c */
            ii(0x1016_1915, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_1918, 3);  mov(al, memb[ds, eax + 38]);          /* mov al, [eax+0x26] */
            ii(0x1016_191b, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1016_1920, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1016_1922, 6);  mov(dl, memb[ds, 0x101c_37c8]);       /* mov dl, [0x101c37c8] */
            ii(0x1016_1928, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x1016_192a, 2);  if(jnz(0x1016_192e, 2)) goto l_0x1016_192e;/* jnz 0x1016192e */
        l_0x1016_192c:
            ii(0x1016_192c, 2);  jmp(0x1016_1933, 5); goto l_0x1016_1933;/* jmp 0x10161933 */
        l_0x1016_192e:
            ii(0x1016_192e, 5);  jmp(0x1016_19c3, 0x90); goto l_0x1016_19c3;/* jmp 0x101619c3 */
        l_0x1016_1933:
            ii(0x1016_1933, 7);  cmp(memd[ds, 0x101c_5624], 0);        /* cmp dword [0x101c5624], 0x0 */
            ii(0x1016_193a, 2);  if(jz(0x1016_1956, 0x1a)) goto l_0x1016_1956;/* jz 0x10161956 */
            ii(0x1016_193c, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_193f, 3);  mov(al, memb[ds, eax + 38]);          /* mov al, [eax+0x26] */
            ii(0x1016_1942, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1016_1947, 6);  imul(eax, eax, 0x247);                /* imul eax, eax, 0x247 */
            ii(0x1016_194d, 7);  cmp(memb[ds, eax + 0x101c_a491], 0);  /* cmp byte [eax+0x101ca491], 0x0 */
            ii(0x1016_1954, 2);  if(jnz(0x1016_1958, 2)) goto l_0x1016_1958;/* jnz 0x10161958 */
        l_0x1016_1956:
            ii(0x1016_1956, 2);  jmp(0x1016_195a, 2); goto l_0x1016_195a;/* jmp 0x1016195a */
        l_0x1016_1958:
            ii(0x1016_1958, 2);  jmp(0x1016_19c3, 0x69); goto l_0x1016_19c3;/* jmp 0x101619c3 */
        l_0x1016_195a:
            ii(0x1016_195a, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_195d, 3);  mov(al, memb[ds, eax + 38]);          /* mov al, [eax+0x26] */
            ii(0x1016_1960, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1016_1965, 6);  imul(eax, eax, 0x247);                /* imul eax, eax, 0x247 */
            ii(0x1016_196b, 6);  mov(al, memb[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x1016_1971, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1016_1976, 3);  cmp(eax, 2);                          /* cmp eax, 0x2 */
            ii(0x1016_1979, 2);  if(jz(0x1016_199c, 0x21)) goto l_0x1016_199c;/* jz 0x1016199c */
            ii(0x1016_197b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_197e, 3);  mov(al, memb[ds, eax + 38]);          /* mov al, [eax+0x26] */
            ii(0x1016_1981, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1016_1986, 6);  imul(eax, eax, 0x247);                /* imul eax, eax, 0x247 */
            ii(0x1016_198c, 6);  mov(al, memb[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x1016_1992, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1016_1997, 3);  cmp(eax, 3);                          /* cmp eax, 0x3 */
            ii(0x1016_199a, 2);  if(jnz(0x1016_19a5, 9)) goto l_0x1016_19a5;/* jnz 0x101619a5 */
        l_0x1016_199c:
            ii(0x1016_199c, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_199f, 4);  mov(memb[ds, eax + 92], 0);           /* mov byte [eax+0x5c], 0x0 */
            ii(0x1016_19a3, 2);  jmp(0x1016_19c3, 0x1e); goto l_0x1016_19c3;/* jmp 0x101619c3 */
        l_0x1016_19a5:
            ii(0x1016_19a5, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_19a8, 5);  call(0x1015_26ac, -0xf301);           /* call 0x101526ac */
            ii(0x1016_19ad, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1016_19af, 2);  if(jnz(0x1016_19b9, 8)) goto l_0x1016_19b9;/* jnz 0x101619b9 */
            ii(0x1016_19b1, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_19b4, 5);  call(0x100a_9e06, -0xb_7bb3);         /* call 0x100a9e06 */
        l_0x1016_19b9:
            ii(0x1016_19b9, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1016_19bb, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_19be, 5);  call(0x1015_2605, -0xf3be);           /* call 0x10152605 */
        l_0x1016_19c3:
            ii(0x1016_19c3, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1016_19c5, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1016_19c6, 1);  pop(edi);                             /* pop edi */
            ii(0x1016_19c7, 1);  pop(esi);                             /* pop esi */
            ii(0x1016_19c8, 1);  pop(edx);                             /* pop edx */
            ii(0x1016_19c9, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1016_19ca, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1016_19cb, 1);  ret();                                /* ret */
        }
    }
}
