using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_2edb-534e4dbe")]
        public void Method_100a_2edb()
        {
            ii(0x100a_2edb, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100a_2ee0, 5);  call(Definitions.sys_check_available_stack_size, 0xc_2e6d);/* call 0x10165d52 */
            ii(0x100a_2ee5, 1);  push(ebx);                            /* push ebx */
            ii(0x100a_2ee6, 1);  push(ecx);                            /* push ecx */
            ii(0x100a_2ee7, 1);  push(edx);                            /* push edx */
            ii(0x100a_2ee8, 1);  push(esi);                            /* push esi */
            ii(0x100a_2ee9, 1);  push(edi);                            /* push edi */
            ii(0x100a_2eea, 1);  push(ebp);                            /* push ebp */
            ii(0x100a_2eeb, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100a_2eed, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x100a_2ef3, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100a_2ef6, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_2ef9, 3);  mov(al, memb[ds, eax + 77]);          /* mov al, [eax+0x4d] */
            ii(0x100a_2efc, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x100a_2f01, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100a_2f03, 2);  if(jg(0x100a_2f0e, 9)) goto l_0x100a_2f0e;/* jg 0x100a2f0e */
            ii(0x100a_2f05, 4);  mov(memb[ss, ebp - 8], 0);            /* mov byte [ebp-0x8], 0x0 */
            ii(0x100a_2f09, 5);  jmp(0x100a_2f90, 0x82); goto l_0x100a_2f90;/* jmp 0x100a2f90 */
        l_0x100a_2f0e:
            ii(0x100a_2f0e, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x100a_2f10, 5);  mov(al, memb[ds, 0x101c_37c9]);       /* mov al, [0x101c37c9] */
            ii(0x100a_2f15, 3);  cmp(eax, 2);                          /* cmp eax, 0x2 */
            ii(0x100a_2f18, 2);  if(jnz(0x100a_2f23, 9)) goto l_0x100a_2f23;/* jnz 0x100a2f23 */
            ii(0x100a_2f1a, 4);  mov(memb[ss, ebp - 8], 0);            /* mov byte [ebp-0x8], 0x0 */
            ii(0x100a_2f1e, 5);  jmp(0x100a_2f90, 0x6d); goto l_0x100a_2f90;/* jmp 0x100a2f90 */
        l_0x100a_2f23:
            ii(0x100a_2f23, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_2f26, 3);  mov(eax, memd[ds, eax + 58]);         /* mov eax, [eax+0x3a] */
            ii(0x100a_2f29, 3);  sar(eax, 0x18);                       /* sar eax, 0x18 */
            ii(0x100a_2f2c, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100a_2f2e, 2);  if(jz(0x100a_2f3e, 0xe)) goto l_0x100a_2f3e;/* jz 0x100a2f3e */
            ii(0x100a_2f30, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_2f33, 3);  mov(eax, memd[ds, eax + 58]);         /* mov eax, [eax+0x3a] */
            ii(0x100a_2f36, 3);  sar(eax, 0x18);                       /* sar eax, 0x18 */
            ii(0x100a_2f39, 3);  cmp(eax, 0xc);                        /* cmp eax, 0xc */
            ii(0x100a_2f3c, 2);  if(jnz(0x100a_2f44, 6)) goto l_0x100a_2f44;/* jnz 0x100a2f44 */
        l_0x100a_2f3e:
            ii(0x100a_2f3e, 4);  mov(memb[ss, ebp - 8], 1);            /* mov byte [ebp-0x8], 0x1 */
            ii(0x100a_2f42, 2);  jmp(0x100a_2f90, 0x4c); goto l_0x100a_2f90;/* jmp 0x100a2f90 */
        l_0x100a_2f44:
            ii(0x100a_2f44, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_2f47, 3);  mov(eax, memd[ds, eax + 58]);         /* mov eax, [eax+0x3a] */
            ii(0x100a_2f4a, 3);  sar(eax, 0x18);                       /* sar eax, 0x18 */
            ii(0x100a_2f4d, 3);  cmp(eax, 2);                          /* cmp eax, 0x2 */
            ii(0x100a_2f50, 2);  if(jnz(0x100a_2f60, 0xe)) goto l_0x100a_2f60;/* jnz 0x100a2f60 */
            ii(0x100a_2f52, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_2f55, 3);  mov(eax, memd[ds, eax + 59]);         /* mov eax, [eax+0x3b] */
            ii(0x100a_2f58, 3);  sar(eax, 0x18);                       /* sar eax, 0x18 */
            ii(0x100a_2f5b, 3);  cmp(eax, 1);                          /* cmp eax, 0x1 */
            ii(0x100a_2f5e, 2);  if(jz(0x100a_2f62, 2)) goto l_0x100a_2f62;/* jz 0x100a2f62 */
        l_0x100a_2f60:
            ii(0x100a_2f60, 2);  jmp(0x100a_2f68, 6); goto l_0x100a_2f68;/* jmp 0x100a2f68 */
        l_0x100a_2f62:
            ii(0x100a_2f62, 4);  mov(memb[ss, ebp - 8], 1);            /* mov byte [ebp-0x8], 0x1 */
            ii(0x100a_2f66, 2);  jmp(0x100a_2f90, 0x28); goto l_0x100a_2f90;/* jmp 0x100a2f90 */
        l_0x100a_2f68:
            ii(0x100a_2f68, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_2f6b, 3);  mov(eax, memd[ds, eax + 58]);         /* mov eax, [eax+0x3a] */
            ii(0x100a_2f6e, 3);  sar(eax, 0x18);                       /* sar eax, 0x18 */
            ii(0x100a_2f71, 3);  cmp(eax, 0x1b);                       /* cmp eax, 0x1b */
            ii(0x100a_2f74, 2);  if(jnz(0x100a_2f84, 0xe)) goto l_0x100a_2f84;/* jnz 0x100a2f84 */
            ii(0x100a_2f76, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_2f79, 3);  mov(eax, memd[ds, eax + 59]);         /* mov eax, [eax+0x3b] */
            ii(0x100a_2f7c, 3);  sar(eax, 0x18);                       /* sar eax, 0x18 */
            ii(0x100a_2f7f, 3);  cmp(eax, 1);                          /* cmp eax, 0x1 */
            ii(0x100a_2f82, 2);  if(jz(0x100a_2f86, 2)) goto l_0x100a_2f86;/* jz 0x100a2f86 */
        l_0x100a_2f84:
            ii(0x100a_2f84, 2);  jmp(0x100a_2f8c, 6); goto l_0x100a_2f8c;/* jmp 0x100a2f8c */
        l_0x100a_2f86:
            ii(0x100a_2f86, 4);  mov(memb[ss, ebp - 8], 1);            /* mov byte [ebp-0x8], 0x1 */
            ii(0x100a_2f8a, 2);  jmp(0x100a_2f90, 4); goto l_0x100a_2f90;/* jmp 0x100a2f90 */
        l_0x100a_2f8c:
            ii(0x100a_2f8c, 4);  mov(memb[ss, ebp - 8], 0);            /* mov byte [ebp-0x8], 0x0 */
        l_0x100a_2f90:
            ii(0x100a_2f90, 3);  mov(al, memb[ss, ebp - 8]);           /* mov al, [ebp-0x8] */
            ii(0x100a_2f93, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100a_2f95, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100a_2f96, 1);  pop(edi);                             /* pop edi */
            ii(0x100a_2f97, 1);  pop(esi);                             /* pop esi */
            ii(0x100a_2f98, 1);  pop(edx);                             /* pop edx */
            ii(0x100a_2f99, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100a_2f9a, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100a_2f9b, 1);  ret();                                /* ret */
        }
    }
}
