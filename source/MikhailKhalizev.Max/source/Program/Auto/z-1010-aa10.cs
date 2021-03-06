using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_aa10-a2099245")]
        public void Method_1010_aa10()
        {
            ii(0x1010_aa10, 5);  push(0x20);                           /* push 0x20 */
            ii(0x1010_aa15, 5);  call(Definitions.sys_check_available_stack_size, 0x5_b338);/* call 0x10165d52 */
            ii(0x1010_aa1a, 1);  push(ebx);                            /* push ebx */
            ii(0x1010_aa1b, 1);  push(ecx);                            /* push ecx */
            ii(0x1010_aa1c, 1);  push(edx);                            /* push edx */
            ii(0x1010_aa1d, 1);  push(esi);                            /* push esi */
            ii(0x1010_aa1e, 1);  push(edi);                            /* push edi */
            ii(0x1010_aa1f, 1);  push(ebp);                            /* push ebp */
            ii(0x1010_aa20, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1010_aa22, 6);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x1010_aa28, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1010_aa2b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_aa2e, 3);  mov(al, memb[ds, eax + 12]);          /* mov al, [eax+0xc] */
            ii(0x1010_aa31, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1010_aa36, 3);  cmp(eax, 1);                          /* cmp eax, 0x1 */
            ii(0x1010_aa39, 2);  if(jz(0x1010_aa4b, 0x10)) goto l_0x1010_aa4b;/* jz 0x1010aa4b */
            ii(0x1010_aa3b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_aa3e, 3);  mov(al, memb[ds, eax + 12]);          /* mov al, [eax+0xc] */
            ii(0x1010_aa41, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1010_aa46, 3);  cmp(eax, 2);                          /* cmp eax, 0x2 */
            ii(0x1010_aa49, 2);  if(jnz(0x1010_aa53, 8)) goto l_0x1010_aa53;/* jnz 0x1010aa53 */
        l_0x1010_aa4b:
            ii(0x1010_aa4b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_aa4e, 5);  call(0x1010_a3fc, -0x657);            /* call 0x1010a3fc */
        l_0x1010_aa53:
            ii(0x1010_aa53, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_aa56, 5);  call(0x1010_a8f7, -0x164);            /* call 0x1010a8f7 */
            ii(0x1010_aa5b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_aa5e, 5);  call(0x1010_a8a7, -0x1bc);            /* call 0x1010a8a7 */
            ii(0x1010_aa63, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_aa66, 3);  mov(al, memb[ds, eax + 12]);          /* mov al, [eax+0xc] */
            ii(0x1010_aa69, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1010_aa6e, 3);  cmp(eax, 1);                          /* cmp eax, 0x1 */
            ii(0x1010_aa71, 2);  if(jz(0x1010_aa83, 0x10)) goto l_0x1010_aa83;/* jz 0x1010aa83 */
            ii(0x1010_aa73, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_aa76, 3);  mov(al, memb[ds, eax + 12]);          /* mov al, [eax+0xc] */
            ii(0x1010_aa79, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1010_aa7e, 3);  cmp(eax, 3);                          /* cmp eax, 0x3 */
            ii(0x1010_aa81, 2);  if(jnz(0x1010_aa9b, 0x18)) goto l_0x1010_aa9b;/* jnz 0x1010aa9b */
        l_0x1010_aa83:
            ii(0x1010_aa83, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_aa86, 5);  call(0x1010_a4a1, -0x5ea);            /* call 0x1010a4a1 */
            ii(0x1010_aa8b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_aa8e, 5);  call(0x1010_a564, -0x52f);            /* call 0x1010a564 */
            ii(0x1010_aa93, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_aa96, 5);  call(0x1010_a69d, -0x3fe);            /* call 0x1010a69d */
        l_0x1010_aa9b:
            ii(0x1010_aa9b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_aa9e, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1010_aaa0, 3);  mov(eax, memd[ds, eax + 18]);         /* mov eax, [eax+0x12] */
            ii(0x1010_aaa3, 5);  call(Definitions.sys_display_draw_0, 0x5_c9dc);/* call 0x10167484 */
            ii(0x1010_aaa8, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1010_aaaa, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1010_aaab, 1);  pop(edi);                             /* pop edi */
            ii(0x1010_aaac, 1);  pop(esi);                             /* pop esi */
            ii(0x1010_aaad, 1);  pop(edx);                             /* pop edx */
            ii(0x1010_aaae, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1010_aaaf, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1010_aab0, 1);  ret();                                /* ret */
        }
    }
}
