using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_20ff-8f663a8e")]
        public void Method_100d_20ff()
        {
            ii(0x100d_20ff, 5);  push(0x28);                           /* push 0x28 */
            ii(0x100d_2104, 5);  call(Definitions.sys_check_available_stack_size, 0x9_3c49);/* call 0x10165d52 */
            ii(0x100d_2109, 1);  push(ecx);                            /* push ecx */
            ii(0x100d_210a, 1);  push(esi);                            /* push esi */
            ii(0x100d_210b, 1);  push(edi);                            /* push edi */
            ii(0x100d_210c, 1);  push(ebp);                            /* push ebp */
            ii(0x100d_210d, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100d_210f, 6);  sub(esp, 0x14);                       /* sub esp, 0x14 */
            ii(0x100d_2115, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100d_2118, 3);  mov(memd[ss, ebp - 8], edx);          /* mov [ebp-0x8], edx */
            ii(0x100d_211b, 3);  mov(memb[ss, ebp - 4], bl);           /* mov [ebp-0x4], bl */
            ii(0x100d_211e, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_2121, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x100d_2124, 3);  cmp(eax, memd[ds, edx + 62]);         /* cmp eax, [edx+0x3e] */
            ii(0x100d_2127, 2);  if(jnz(0x100d_215f, 0x36)) goto l_0x100d_215f;/* jnz 0x100d215f */
            ii(0x100d_2129, 4);  cmp(memb[ss, ebp - 4], 0);            /* cmp byte [ebp-0x4], 0x0 */
            ii(0x100d_212d, 2);  if(jz(0x100d_2143, 0x14)) goto l_0x100d_2143;/* jz 0x100d2143 */
            ii(0x100d_212f, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100d_2132, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x100d_2135, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x100d_2138, 3);  mov(edx, memd[ds, eax + 19]);         /* mov edx, [eax+0x13] */
            ii(0x100d_213b, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x100d_213e, 3);  call_abs(memd[ds, edx + 20]);         /* call dword [edx+0x14] */
            ii(0x100d_2141, 2);  jmp(0x100d_2159, 0x16); goto l_0x100d_2159;/* jmp 0x100d2159 */
        l_0x100d_2143:
            ii(0x100d_2143, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100d_2146, 3);  mov(eax, memd[ds, eax + 62]);         /* mov eax, [eax+0x3e] */
            ii(0x100d_2149, 5);  call(0x100d_0149, -0x2005);           /* call 0x100d0149 */
            ii(0x100d_214e, 3);  movsx(edx, ax);                       /* movsx edx, ax */
            ii(0x100d_2151, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100d_2154, 5);  call(0x100d_19a4, -0x7b5);            /* call 0x100d19a4 */
        l_0x100d_2159:
            ii(0x100d_2159, 4);  mov(memb[ss, ebp - 16], 1);           /* mov byte [ebp-0x10], 0x1 */
            ii(0x100d_215d, 2);  jmp(0x100d_2163, 4); goto l_0x100d_2163;/* jmp 0x100d2163 */
        l_0x100d_215f:
            ii(0x100d_215f, 4);  mov(memb[ss, ebp - 16], 0);           /* mov byte [ebp-0x10], 0x0 */
        l_0x100d_2163:
            ii(0x100d_2163, 3);  mov(al, memb[ss, ebp - 16]);          /* mov al, [ebp-0x10] */
            ii(0x100d_2166, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100d_2168, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100d_2169, 1);  pop(edi);                             /* pop edi */
            ii(0x100d_216a, 1);  pop(esi);                             /* pop esi */
            ii(0x100d_216b, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100d_216c, 1);  ret();                                /* ret */
        }
    }
}
