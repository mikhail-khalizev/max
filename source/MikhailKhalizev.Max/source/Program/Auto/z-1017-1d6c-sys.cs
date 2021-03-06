using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_1d6c-e866cbd1")]
        public void /* sys */ Method_1017_1d6c()
        {
            ii(0x1017_1d6c, 1);  push(esi);                            /* push esi */
            ii(0x1017_1d6d, 1);  push(edi);                            /* push edi */
            ii(0x1017_1d6e, 3);  sub(esp, 0x30);                       /* sub esp, 0x30 */
            ii(0x1017_1d71, 2);  mov(edi, edx);                        /* mov edi, edx */
            ii(0x1017_1d73, 2);  mov(esi, ebx);                        /* mov esi, ebx */
            ii(0x1017_1d75, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1017_1d77, 2);  if(jnz(0x1017_1d7d, 4)) goto l_0x1017_1d7d;/* jnz 0x10171d7d */
            ii(0x1017_1d79, 2);  xor(esi, ebx);                        /* xor esi, ebx */
            ii(0x1017_1d7b, 2);  jmp(0x1017_1de9, 0x6c); goto l_0x1017_1de9;/* jmp 0x10171de9 */
        l_0x1017_1d7d:
            ii(0x1017_1d7d, 2);  mov(memd[ds, eax], edx);              /* mov [eax], edx */
            ii(0x1017_1d7f, 4);  mov(edx, memd[ss, esp + 60]);         /* mov edx, [esp+0x3c] */
            ii(0x1017_1d83, 8);  mov(memd[ss, esp + 16], 0);           /* mov dword [esp+0x10], 0x0 */
            ii(0x1017_1d8b, 8);  mov(memd[ss, esp + 20], /* sys */ 0x1017_1d40);/* mov dword [esp+0x14], 0x10171d40 */
            ii(0x1017_1d93, 8);  mov(memd[ss, esp + 24], 0xffff_ffe4); /* mov dword [esp+0x18], 0xffffffe4 */
            ii(0x1017_1d9b, 4);  mov(memd[ss, esp + 8], eax);          /* mov [esp+0x8], eax */
            ii(0x1017_1d9f, 4);  mov(memd[ss, esp + 12], ebx);         /* mov [esp+0xc], ebx */
            ii(0x1017_1da3, 5);  mov(ebx, 1);                          /* mov ebx, 0x1 */
            ii(0x1017_1da8, 4);  lea(eax, memd[ss, esp + 28]);         /* lea eax, [esp+0x1c] */
            ii(0x1017_1dac, 3);  mov(memd[ss, esp], edx);              /* mov [esp], edx */
            ii(0x1017_1daf, 4);  lea(edx, memd[ss, esp + 16]);         /* lea edx, [esp+0x10] */
            ii(0x1017_1db3, 4);  mov(memd[ss, esp + 4], ecx);          /* mov [esp+0x4], ecx */
            ii(0x1017_1db7, 5);  call(/* sys */ 0x1018_d348, 0x1_b58c);/* call 0x1018d348 */
            ii(0x1017_1dbc, 3);  cmp(memb[ds, esi], 4);                /* cmp byte [esi], 0x4 */
            ii(0x1017_1dbf, 2);  if(jnz(0x1017_1dcb, 0xa)) goto l_0x1017_1dcb;/* jnz 0x10171dcb */
            ii(0x1017_1dc1, 8);  mov(memd[ss, esp + 44], /* sys */ 0x1018_d370);/* mov dword [esp+0x2c], 0x1018d370 */
            ii(0x1017_1dc9, 2);  jmp(0x1017_1dd3, 8); goto l_0x1017_1dd3;/* jmp 0x10171dd3 */
        l_0x1017_1dcb:
            ii(0x1017_1dcb, 8);  mov(memd[ss, esp + 44], Definitions.sys_call_ctor_arr_v2);/* mov dword [esp+0x2c], 0x10165f70 */
        l_0x1017_1dd3:
            ii(0x1017_1dd3, 4);  mov(eax, memd[ss, esp + 8]);          /* mov eax, [esp+0x8] */
            ii(0x1017_1dd7, 2);  mov(ebx, esi);                        /* mov ebx, esi */
            ii(0x1017_1dd9, 2);  mov(edx, edi);                        /* mov edx, edi */
            ii(0x1017_1ddb, 3);  add(eax, 4);                          /* add eax, 0x4 */
            ii(0x1017_1dde, 4);  call_abs(memd[ss, esp + 44]);         /* call dword [esp+0x2c] */
            ii(0x1017_1de2, 2);  mov(esi, eax);                        /* mov esi, eax */
            ii(0x1017_1de4, 5);  call(/* sys */ 0x1018_d361, 0x1_b578);/* call 0x1018d361 */
        l_0x1017_1de9:
            ii(0x1017_1de9, 2);  mov(eax, esi);                        /* mov eax, esi */
            ii(0x1017_1deb, 3);  add(esp, 0x30);                       /* add esp, 0x30 */
            ii(0x1017_1dee, 1);  pop(edi);                             /* pop edi */
            ii(0x1017_1def, 1);  pop(esi);                             /* pop esi */
            ii(0x1017_1df0, 3);  ret(4);                               /* ret 0x4 */
        }
    }
}
