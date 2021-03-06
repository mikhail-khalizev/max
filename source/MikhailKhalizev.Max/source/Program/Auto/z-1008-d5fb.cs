using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_d5fb-4c9333c5")]
        public void Method_1008_d5fb()
        {
            ii(0x1008_d5fb, 5);  push(0x20);                           /* push 0x20 */
            ii(0x1008_d600, 5);  call(Definitions.sys_check_available_stack_size, 0xd_874d);/* call 0x10165d52 */
            ii(0x1008_d605, 1);  push(ebx);                            /* push ebx */
            ii(0x1008_d606, 1);  push(ecx);                            /* push ecx */
            ii(0x1008_d607, 1);  push(edx);                            /* push edx */
            ii(0x1008_d608, 1);  push(esi);                            /* push esi */
            ii(0x1008_d609, 1);  push(edi);                            /* push edi */
            ii(0x1008_d60a, 1);  push(ebp);                            /* push ebp */
            ii(0x1008_d60b, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1008_d60d, 6);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x1008_d613, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1008_d616, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1008_d618, 5);  mov(al, memb[ds, 0x101c_37c9]);       /* mov al, [0x101c37c9] */
            ii(0x1008_d61d, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1008_d61f, 2);  if(jnz(0x1008_d640, 0x1f)) goto l_0x1008_d640;/* jnz 0x1008d640 */
            ii(0x1008_d621, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_d624, 3);  add(eax, 0x15);                       /* add eax, 0x15 */
            ii(0x1008_d627, 5);  call(0x1007_6574, -0x1_70b8);         /* call 0x10076574 */
            ii(0x1008_d62c, 3);  mov(al, memb[ds, eax + 38]);          /* mov al, [eax+0x26] */
            ii(0x1008_d62f, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1008_d634, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1008_d636, 6);  mov(dl, memb[ds, 0x101c_37c8]);       /* mov dl, [0x101c37c8] */
            ii(0x1008_d63c, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x1008_d63e, 2);  if(jnz(0x1008_d642, 2)) goto l_0x1008_d642;/* jnz 0x1008d642 */
        l_0x1008_d640:
            ii(0x1008_d640, 2);  jmp(0x1008_d644, 2); goto l_0x1008_d644;/* jmp 0x1008d644 */
        l_0x1008_d642:
            ii(0x1008_d642, 2);  jmp(0x1008_d6b1, 0x6d); goto l_0x1008_d6b1;/* jmp 0x1008d6b1 */
        l_0x1008_d644:
            ii(0x1008_d644, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1008_d646, 5);  mov(al, memb[ds, 0x101c_37c9]);       /* mov al, [0x101c37c9] */
            ii(0x1008_d64b, 3);  cmp(eax, 2);                          /* cmp eax, 0x2 */
            ii(0x1008_d64e, 2);  if(jz(0x1008_d6b1, 0x61)) goto l_0x1008_d6b1;/* jz 0x1008d6b1 */
            ii(0x1008_d650, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_d653, 3);  add(eax, 0x15);                       /* add eax, 0x15 */
            ii(0x1008_d656, 5);  call(0x1007_6574, -0x1_70e7);         /* call 0x10076574 */
            ii(0x1008_d65b, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1008_d65d, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_d660, 3);  add(eax, 0x15);                       /* add eax, 0x15 */
            ii(0x1008_d663, 5);  call(0x1007_6574, -0x1_70f4);         /* call 0x10076574 */
            ii(0x1008_d668, 4);  mov(dx, memw[ds, edx + 26]);          /* mov dx, [edx+0x1a] */
            ii(0x1008_d66c, 4);  mov(memw[ds, eax + 65], dx);          /* mov [eax+0x41], dx */
            ii(0x1008_d670, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_d673, 3);  add(eax, 0x15);                       /* add eax, 0x15 */
            ii(0x1008_d676, 5);  call(0x1007_6574, -0x1_7107);         /* call 0x10076574 */
            ii(0x1008_d67b, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1008_d67d, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_d680, 3);  add(eax, 0x15);                       /* add eax, 0x15 */
            ii(0x1008_d683, 5);  call(0x1007_6574, -0x1_7114);         /* call 0x10076574 */
            ii(0x1008_d688, 4);  mov(dx, memw[ds, edx + 28]);          /* mov dx, [edx+0x1c] */
            ii(0x1008_d68c, 4);  mov(memw[ds, eax + 67], dx);          /* mov [eax+0x43], dx */
            ii(0x1008_d690, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_d693, 4);  mov(memb[ds, eax + 37], 7);           /* mov byte [eax+0x25], 0x7 */
            ii(0x1008_d697, 5);  mov(ebx, 0xd);                        /* mov ebx, 0xd */
            ii(0x1008_d69c, 5);  mov(edx, 4);                          /* mov edx, 0x4 */
            ii(0x1008_d6a1, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_d6a4, 3);  add(eax, 0x15);                       /* add eax, 0x15 */
            ii(0x1008_d6a7, 5);  call(0x1007_65d0, -0x1_70dc);         /* call 0x100765d0 */
            ii(0x1008_d6ac, 5);  call(0x1016_3053, 0xd_59a2);          /* call 0x10163053 */
        l_0x1008_d6b1:
            ii(0x1008_d6b1, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1008_d6b3, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1008_d6b4, 1);  pop(edi);                             /* pop edi */
            ii(0x1008_d6b5, 1);  pop(esi);                             /* pop esi */
            ii(0x1008_d6b6, 1);  pop(edx);                             /* pop edx */
            ii(0x1008_d6b7, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1008_d6b8, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1008_d6b9, 1);  ret();                                /* ret */
        }
    }
}
