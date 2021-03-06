using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_2504-b6f0d266")]
        public void Method_100d_2504()
        {
            ii(0x100d_2504, 5);  push(0x2c);                           /* push 0x2c */
            ii(0x100d_2509, 5);  call(Definitions.sys_check_available_stack_size, 0x9_3844);/* call 0x10165d52 */
            ii(0x100d_250e, 1);  push(ebx);                            /* push ebx */
            ii(0x100d_250f, 1);  push(ecx);                            /* push ecx */
            ii(0x100d_2510, 1);  push(edx);                            /* push edx */
            ii(0x100d_2511, 1);  push(esi);                            /* push esi */
            ii(0x100d_2512, 1);  push(edi);                            /* push edi */
            ii(0x100d_2513, 1);  push(ebp);                            /* push ebp */
            ii(0x100d_2514, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100d_2516, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x100d_251c, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100d_251f, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_2522, 4);  mov(memb[ds, eax + 54], 0);           /* mov byte [eax+0x36], 0x0 */
            ii(0x100d_2526, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_2529, 4);  mov(memb[ds, eax + 53], 0);           /* mov byte [eax+0x35], 0x0 */
            ii(0x100d_252d, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_2530, 4);  mov(memb[ds, eax + 55], 0);           /* mov byte [eax+0x37], 0x0 */
        l_0x100d_2534:
            ii(0x100d_2534, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_2537, 4);  cmp(memb[ds, eax + 54], 0);           /* cmp byte [eax+0x36], 0x0 */
            ii(0x100d_253b, 6);  if(jnz(0x100d_25aa, 0x69)) goto l_0x100d_25aa;/* jnz 0x100d25aa */
            ii(0x100d_2541, 5);  call(/* sys */ 0x1016_b208, 0x9_8cc2);/* call 0x1016b208 */
            ii(0x100d_2546, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100d_2549, 7);  cmp(memb[ds, 0x101c_37d2], 0);        /* cmp byte [0x101c37d2], 0x0 */
            ii(0x100d_2550, 2);  if(jnz(0x100d_255e, 0xc)) goto l_0x100d_255e;/* jnz 0x100d255e */
            ii(0x100d_2552, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_2555, 3);  mov(eax, memd[ds, eax + 49]);         /* mov eax, [eax+0x31] */
            ii(0x100d_2558, 4);  cmp(memb[ds, eax + 61], 0x1a);        /* cmp byte [eax+0x3d], 0x1a */
            ii(0x100d_255c, 2);  if(jnz(0x100d_2560, 2)) goto l_0x100d_2560;/* jnz 0x100d2560 */
        l_0x100d_255e:
            ii(0x100d_255e, 2);  jmp(0x100d_2576, 0x16); goto l_0x100d_2576;/* jmp 0x100d2576 */
        l_0x100d_2560:
            ii(0x100d_2560, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_2563, 3);  mov(eax, memd[ds, eax + 49]);         /* mov eax, [eax+0x31] */
            ii(0x100d_2566, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100d_2568, 3);  mov(dl, memb[ds, eax + 38]);          /* mov dl, [eax+0x26] */
            ii(0x100d_256b, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x100d_256d, 5);  mov(al, memb[ds, 0x101c_37da]);       /* mov al, [0x101c37da] */
            ii(0x100d_2572, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x100d_2574, 2);  if(jz(0x100d_257d, 7)) goto l_0x100d_257d;/* jz 0x100d257d */
        l_0x100d_2576:
            ii(0x100d_2576, 7);  mov(memd[ss, ebp - 12], 0x1b);        /* mov dword [ebp-0xc], 0x1b */
        l_0x100d_257d:
            ii(0x100d_257d, 4);  cmp(memd[ss, ebp - 12], 0);           /* cmp dword [ebp-0xc], 0x0 */
            ii(0x100d_2581, 2);  if(jle(0x100d_2598, 0x15)) goto l_0x100d_2598;/* jle 0x100d2598 */
            ii(0x100d_2583, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_2586, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x100d_2589, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100d_258c, 3);  mov(ebx, memd[ds, eax + 19]);         /* mov ebx, [eax+0x13] */
            ii(0x100d_258f, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x100d_2592, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100d_2595, 3);  call_abs(memd[ds, ebx + 8]);          /* call dword [ebx+0x8] */
        l_0x100d_2598:
            ii(0x100d_2598, 5);  call(0x100d_5094, 0x2af7);            /* call 0x100d5094 */
            ii(0x100d_259d, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100d_259f, 2);  mov(dl, al);                          /* mov dl, al */
            ii(0x100d_25a1, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x100d_25a3, 5);  call(0x1010_0e32, 0x2_e88a);          /* call 0x10100e32 */
            ii(0x100d_25a8, 2);  jmp(0x100d_2534, -0x76); goto l_0x100d_2534;/* jmp 0x100d2534 */
        l_0x100d_25aa:
            ii(0x100d_25aa, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_25ad, 3);  mov(eax, memd[ds, eax + 49]);         /* mov eax, [eax+0x31] */
            ii(0x100d_25b0, 5);  call(0x100f_fa70, 0x2_d4bb);          /* call 0x100ffa70 */
            ii(0x100d_25b5, 5);  mov(eax, 1);                          /* mov eax, 0x1 */
            ii(0x100d_25ba, 5);  call(0x1010_0efe, 0x2_e93f);          /* call 0x10100efe */
            ii(0x100d_25bf, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_25c2, 3);  mov(al, memb[ds, eax + 53]);          /* mov al, [eax+0x35] */
            ii(0x100d_25c5, 3);  mov(memb[ss, ebp - 8], al);           /* mov [ebp-0x8], al */
            ii(0x100d_25c8, 3);  mov(al, memb[ss, ebp - 8]);           /* mov al, [ebp-0x8] */
            ii(0x100d_25cb, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100d_25cd, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100d_25ce, 1);  pop(edi);                             /* pop edi */
            ii(0x100d_25cf, 1);  pop(esi);                             /* pop esi */
            ii(0x100d_25d0, 1);  pop(edx);                             /* pop edx */
            ii(0x100d_25d1, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100d_25d2, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100d_25d3, 1);  ret();                                /* ret */
        }
    }
}
